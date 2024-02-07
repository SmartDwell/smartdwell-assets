using Contracts.MeasureUnit;
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
        TypeAdapterConfig<MeasureUnit, MeasureUnitDto>.NewConfig()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Name, src => src.Name);
        
        TypeAdapterConfig<MeasureUnitPutDto, MeasureUnit>.NewConfig()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Name, src => src.Name);
    }
}