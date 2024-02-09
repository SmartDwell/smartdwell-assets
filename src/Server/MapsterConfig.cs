using Contracts.Category;
using Contracts.Parameter;
using Mapster;
using Models;

namespace Server;

/// <summary>
/// Конфигурация Mapster.
/// </summary>
internal static class MapsterConfig
{
    /// <summary>
    /// Конфигурация.
    /// </summary>
    public static void Config()
    {
        #region Parameter

        TypeAdapterConfig<Parameter, ParameterDto>.NewConfig()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Name, src => src.Name);

        TypeAdapterConfig<ParameterDto, Parameter>.NewConfig()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Name, src => src.Name);

        TypeAdapterConfig<ParameterPutDto, Parameter>.NewConfig()
            .Map(dest => dest.Id, src => Guid.Empty)
            .Map(dest => dest.Name, src => src.Name);

        TypeAdapterConfig<ParameterDto, CategoryParameter>.NewConfig()
            .Map(dest => dest.Id, src => Guid.NewGuid())
            .Map(dest => dest.ParameterId, src => src.Id);

        #endregion
        
        #region Category
        
        TypeAdapterConfig<Category, CategoryDto>.NewConfig()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Name, src => src.Name)
            .Map(dest => dest.Description, src => src.Description)
            .Map(dest => dest.UseForApi, src => src.UseForApi)
            .Map(dest => dest.Parameters, src => src.CategoryParameters.Adapt<ICollection<ParameterDto>>());
 
        TypeAdapterConfig<CategoryPutDto, Category>.NewConfig()
            .Map(dest => dest.Id, src => src.Id ?? Guid.Empty)
            .Map(dest => dest.Name, src => src.Name)
            .Map(dest => dest.Description, src => src.Description)
            .Map(dest => dest.UseForApi, src => src.UseForApi)
            .Map(dest => dest.CategoryParameters, src => src.Parameters.Select(id => new CategoryParameter { Id = Guid.NewGuid(), ParameterId = id }).ToList());
        
        #endregion
        
        #region CategoryParameter
        
        TypeAdapterConfig<CategoryParameter, ParameterDto>.NewConfig()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Name, src => src.Parameter.Name);
        
        TypeAdapterConfig<CategoryParameter, Parameter>.NewConfig()
            .Map(dest => dest.Id, src => src.ParameterId)
            .Map(dest => dest.Name, src => src.Parameter.Name);
        
        #endregion
    }
}