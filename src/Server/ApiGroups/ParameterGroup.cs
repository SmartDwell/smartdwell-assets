using Contracts.Parameter;
using Mapster;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Constants;

namespace Server.ApiGroups;

/// <summary>
/// Группа методов для работы с параметрами.
/// </summary>
public static class ParameterGroup
{
    /// <summary>
    /// Определение маршрутов работы с параметрами.
    /// </summary>
    /// <param name="endpoints">Маршруты.</param>
    public static void MapParameterGroup(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup(RouteConstants.ParameterData.Route);
        group.MapGet(RouteConstants.Base, GetParameters)
            .Produces<ParameterDto[]>()
            .WithName("GetParameters")
            .WithSummary("Получение списка параметров")
            .WithOpenApi(); 
        group.MapGet(RouteConstants.ById, GetParameterById)
            .Produces<ParameterDto>()
            .WithName("GetParameterById")
            .WithSummary("Получение параметра по идентификатору")
            .WithOpenApi();
        group.MapPut(RouteConstants.Base, PutParameter)
            .Produces<ParameterDto>()
            .WithName("PutParameter")
            .WithSummary("Создание/обновление параметра")
            .WithOpenApi();
        group.MapDelete(RouteConstants.ById, DeleteParameter)
            .WithName("DeleteParameter")
            .WithSummary("Удаление параметра")
            .WithOpenApi();
    }
    
    private static Ok<ParameterDto[]> GetParameters(DatabaseContext context)
    {
        return TypedResults.Ok(context.Parameters.Adapt<ParameterDto[]>());
    }
    
    private static async Task<IResult> GetParameterById(DatabaseContext context, 
        [FromRoute] Guid id)
    {
        var parameter = await context.Parameters.FindAsync(id);
        return parameter is null 
            ? TypedResults.NotFound("Параметр не найден")
            : TypedResults.Ok(parameter.Adapt<ParameterDto>());
    }
    
    private static async Task<IResult> PutParameter(DatabaseContext context, 
        [FromBody] ParameterPutDto parameterDto)
    {
        var parameter = parameterDto.Adapt<Parameter>();
        if (parameter.Id == Guid.Empty)
        {
            parameter.Id = Guid.NewGuid();
            await context.Parameters.AddAsync(parameter);
        }
        else
        {
            context.Parameters.Update(parameter);
        }
        await context.SaveChangesAsync();
        return TypedResults.Ok(parameter.Adapt<ParameterDto>());
    }
    
    private static async Task<IResult> DeleteParameter(DatabaseContext context, 
        [FromRoute] Guid id)
    {
        var parameter = await context.Parameters.FindAsync(id);
        if (parameter is null)
            return TypedResults.NotFound("Параметр не найден");
        
        context.Parameters.Remove(parameter);
        await context.SaveChangesAsync();
        return TypedResults.Ok();
    }
}