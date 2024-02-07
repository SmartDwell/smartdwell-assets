using Contracts.MeasureUnit;
using Mapster;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Constants;

namespace Server.ApiGroups;

/// <summary>
/// Группа маршрутов для работы с единицами измерения.
/// </summary>
public static class MeasureUnitGroup
{
    /// <summary>
    /// Определение маршрутов.
    /// </summary>
    /// <param name="endpoints">Маршруты.</param>
    public static void MapMeasureUnitGroup(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup(RouteConstants.MeasureUnitData.Route);
        group.MapGet(RouteConstants.Base, GetMeasureUnits)
            .Produces<MeasureUnitDto[]>()
            .WithName("GetMeasureUnits")
            .WithSummary("Получение списка единиц измерения")
            .WithOpenApi();
        group.MapGet(RouteConstants.ById, GetMeasureUnitById)
            .Produces<MeasureUnitDto>()
            .WithName("GetMeasureUnitById")
            .WithSummary("Получение единицы измерения по идентификатору")
            .WithOpenApi();
        group.MapPut(RouteConstants.ById, PutMeasureUnit)
            .Produces<MeasureUnitDto>()
            .WithName("PutMeasureUnit")
            .WithSummary("Создание/обновление единицы измерения")
            .WithOpenApi();
        group.MapDelete(RouteConstants.ById, DeleteMeasureUnit)
            .WithName("DeleteMeasureUnit")
            .WithSummary("Удаление единицы измерения")
            .WithOpenApi();
    }
    
    private static Ok<MeasureUnitDto[]> GetMeasureUnits(DatabaseContext context)
    {
        return TypedResults.Ok(context.MeasureUnits.Adapt<MeasureUnitDto[]>());
    }
    
    private static async Task<IResult> GetMeasureUnitById(DatabaseContext context, 
        [FromRoute] Guid id)
    {
        var measureUnit = await context.MeasureUnits.FindAsync(id);
        return measureUnit is null 
            ? TypedResults.NotFound("Единица измерения не найдена")
            : TypedResults.Ok(measureUnit.Adapt<MeasureUnitDto>());
    }
    
    private static async Task<IResult> PutMeasureUnit(DatabaseContext context, 
        [FromBody] MeasureUnitPutDto measureUnitDto)
    {
        if (measureUnitDto.Id is null)
        {
            var measureUnit = new MeasureUnit { Name = measureUnitDto.Name };
            await context.MeasureUnits.AddAsync(measureUnit);
            await context.SaveChangesAsync();
            return TypedResults.Ok(measureUnit.Adapt<MeasureUnitDto>());
        }
        
        var measureUnitEntity = await context.MeasureUnits.FindAsync(measureUnitDto.Id);
        if (measureUnitEntity is null)
            return TypedResults.NotFound("Единица измерения не найдена");
        
        measureUnitEntity.Name = measureUnitDto.Name;
        context.MeasureUnits.Update(measureUnitEntity);
        await context.SaveChangesAsync();
        return TypedResults.Ok(measureUnitEntity.Adapt<MeasureUnitDto>());
    }
    
    private static async Task<IResult> DeleteMeasureUnit(DatabaseContext context, 
        [FromRoute] Guid id)
    {
        var measureUnit = await context.MeasureUnits.FindAsync(id);
        if (measureUnit is null)
            return TypedResults.NotFound("Единица измерения не найдена");
        
        context.MeasureUnits.Remove(measureUnit);
        await context.SaveChangesAsync();
        return TypedResults.Ok();
    }
}
