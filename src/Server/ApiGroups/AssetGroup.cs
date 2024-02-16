using Contracts.Asset;
using Mapster;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Server.Constants;

namespace Server.ApiGroups;

public static class AssetGroup
{
    public static void MapAssetGroup(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup(string.Empty);
            //.RequireAuthorization();
        group.MapGet(RouteConstants.AssetData.AssetsUrl, GetAssets)
            .Produces<AssetDto[]>()
            .WithName("GetAssets")
            .WithSummary("Получение списка активов")
            .WithOpenApi();
        group.MapGet(RouteConstants.AssetData.AssetByIdUrl, GetAssetById)
            .Produces<AssetDto>()
            .WithName("GetAssetById")
            .WithSummary("Получение актива по идентификатору")
            .WithOpenApi();
        group.MapPut(RouteConstants.AssetData.AssetPutUrl, PutAsset)
            .Produces<AssetDto>()
            .WithName("PutAsset")
            .WithSummary("Создание/обновление актива")
            .WithOpenApi();
        group.MapDelete(RouteConstants.AssetData.AssetDeleteUrl, DeleteAsset)
            .WithName("DeleteAsset")
            .WithSummary("Удаление актива")
            .WithOpenApi();
    }
    
    private static Ok<AssetDto[]> GetAssets(DatabaseContext context)
    {
        return TypedResults.Ok(context.Assets
            .Include(e => e.Categories)
            .ThenInclude(c => c.CategoryParameter)
            .ThenInclude(cp => cp.Parameter)
            .Adapt<AssetDto[]>());
    }
    
    private static async Task<IResult> GetAssetById(DatabaseContext context, [FromRoute] Guid id)
    {
        var assets = await context.Assets
            .Include(e => e.Categories)
            .ThenInclude(c => c.CategoryParameter)
            .ThenInclude(cp => cp.Parameter).ToListAsync();
        var asset = assets.FirstOrDefault(e => e.Id == id);
        return asset is null 
            ? TypedResults.NotFound("Актив не найден") 
            : TypedResults.Ok(asset.Adapt<AssetDto>());
    }
    
    private static async Task<IResult> PutAsset(DatabaseContext context, [FromBody] AssetPutDto assetPutDto)
    {
        return assetPutDto.Id is null 
            ? await AddAsset(context, assetPutDto) 
            : await UpdateAsset(context, assetPutDto);
    }
    
    private static async Task<IResult> AddAsset(DatabaseContext context, [FromBody] AssetPutDto assetPutDto)
    {
        var asset = assetPutDto.Adapt<Asset>();
        asset.Id = Guid.NewGuid();
        foreach (var category in asset.Categories)
        {
            category.AssetId = asset.Id;
        }
        await context.Assets.AddAsync(asset);
        await context.SaveChangesAsync();
        return TypedResults.Ok(asset.Adapt<AssetDto>());
    }
    
    private static async Task<IResult> UpdateAsset(DatabaseContext context, [FromBody] AssetPutDto assetPutDto)
    {
        var asset = await context.Assets.FindAsync(assetPutDto.Id);
        if (asset is null)
            return TypedResults.NotFound("Актив не найден");
        
        if (asset.Name != assetPutDto.Name && await context.Assets.AnyAsync(e => e.Name == assetPutDto.Name))
            return TypedResults.Conflict("Актив с таким именем уже существует");
        
        asset.Name = assetPutDto.Name;
        asset.Description = assetPutDto.Description;
        asset.Images = assetPutDto.Images;
        
        var assetCategoryParameters = assetPutDto.Categories.Select(e => e.Adapt<AssetCategoryParameter>()).ToList();
        context.AssetCategoryParameters.RemoveRange(context.AssetCategoryParameters.Where(e => e.AssetId == asset.Id));
        context.AssetCategoryParameters.AddRange(assetCategoryParameters);
        
        context.Assets.Update(asset);
        await context.SaveChangesAsync();
        return TypedResults.Ok(asset.Adapt<AssetDto>());
    }
    
    private static async Task<IResult> DeleteAsset(DatabaseContext context, [FromRoute] Guid id)
    {
        var asset = await context.Assets.FindAsync(id);
        if (asset is null)
            return TypedResults.NotFound("Актив не найден");
        
        context.AssetCategoryParameters.RemoveRange(context.AssetCategoryParameters.Where(e => e.AssetId == id));
        context.Assets.Remove(asset);
        await context.SaveChangesAsync();
        return TypedResults.Ok();
    }
}