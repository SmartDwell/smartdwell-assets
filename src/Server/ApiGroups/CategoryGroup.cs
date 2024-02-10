using Contracts.Category;
using Mapster;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Server.Constants;

namespace Server.ApiGroups;

/// <summary>
/// Группа методов для работы с категориями.
/// </summary>
public static class CategoryGroup
{
    /// <summary>
    /// Определение маршрутов работы с категориями.
    /// </summary>
    /// <param name="endpoints">Маршруты.</param>
    public static void MapCategoryGroup(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup(string.Empty);
            //.RequireAuthorization();
        group.MapGet(RouteConstants.CategoryData.CategoriesUrl, GetCategories)
            .Produces<CategoryDto[]>()
            .WithName("GetCategories")
            .WithSummary("Получение списка категорий")
            .WithOpenApi(); 
        group.MapGet(RouteConstants.CategoryData.CategoryByIdUrl, GetCategoryById)
            .Produces<CategoryDto>()
            .WithName("GetCategoryById")
            .WithSummary("Получение категории по идентификатору")
            .WithOpenApi();
        group.MapPut(RouteConstants.CategoryData.CategoryPutUrl, PutCategory)
            .Produces<CategoryDto>()
            .WithName("PutCategory")
            .WithSummary("Создание/обновление категории")
            .WithOpenApi();
        group.MapDelete(RouteConstants.CategoryData.CategoryDeleteUrl, DeleteCategory)
            .WithName("DeleteCategory")
            .WithSummary("Удаление категории")
            .WithOpenApi();
    }
    
    private static Ok<CategoryDto[]> GetCategories(DatabaseContext context)
    {
        return TypedResults.Ok(context.Categories
            .Include(e => e.CategoryParameters)
            .ThenInclude(cp => cp.Parameter)
            .Adapt<CategoryDto[]>());
    }
    
    private static async Task<IResult> GetCategoryById(DatabaseContext context, [FromRoute] Guid id)
    {
        var categories = await context.Categories
            .Include(e => e.CategoryParameters)
            .ThenInclude(cp => cp.Parameter).ToListAsync();
        var category = categories.FirstOrDefault(e => e.Id == id);
        return category is null 
            ? TypedResults.NotFound("Категория не найдена") 
            : TypedResults.Ok(category.Adapt<CategoryDto>());
    }
    
    private static async Task<IResult> PutCategory(DatabaseContext context, [FromBody] CategoryPutDto categoryPutDto)
    {
        return categoryPutDto.Id is null 
            ? await AddCategory(context, categoryPutDto) 
            : await UpdateCategory(context, categoryPutDto);
    }

    private static async Task<IResult> AddCategory(DatabaseContext context, CategoryPutDto categoryPutDto)
    {
        var category = categoryPutDto.Adapt<Category>();
        category.Id = Guid.NewGuid();
        foreach (var categoryParameter in category.CategoryParameters)
        {
            categoryParameter.CategoryId = category.Id;
        }
        await context.Categories.AddAsync(category);
        await context.SaveChangesAsync();
        return TypedResults.Ok(category.Adapt<CategoryDto>());
    }

    private static async Task<IResult> UpdateCategory(DatabaseContext context, CategoryPutDto categoryPutDto)
    {
        var category = await context.Categories.FindAsync(categoryPutDto.Id);
        if (category is null)
            return TypedResults.NotFound("Категория не найдена");
        
        if (categoryPutDto.Name != category.Name && await context.Categories.AnyAsync(e => e.Name == categoryPutDto.Name))
            return TypedResults.Conflict("Категория с таким именем уже существует");
        
        category.Name = categoryPutDto.Name;
        category.Description = categoryPutDto.Description;
        category.UseForApi = categoryPutDto.UseForApi;
        
        var categoryParameters = categoryPutDto.Parameters.Select(id => new CategoryParameter { Id = Guid.NewGuid(), CategoryId = category.Id, ParameterId = id }).ToList();
        context.CategoryParameters.RemoveRange(context.CategoryParameters.Where(e => e.CategoryId == category.Id));
        context.CategoryParameters.AddRange(categoryParameters);
        
        context.Categories.Update(category);
        await context.SaveChangesAsync();
        return TypedResults.Ok(category.Adapt<CategoryDto>());
    }
    
    private static async Task<IResult> DeleteCategory(DatabaseContext context, [FromRoute] Guid id)
    {
        var category = await context.Categories.FindAsync(id);
        if (category is null)
            return TypedResults.NotFound("Категория не найдена");
        
        context.Categories.Remove(category);
        await context.SaveChangesAsync();
        return TypedResults.Ok();
    }
}