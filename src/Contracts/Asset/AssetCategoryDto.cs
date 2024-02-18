namespace Contracts.Asset;

/// <summary>
/// Категория актива.
/// </summary>
public class AssetCategoryDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Параметры.
    /// </summary>
    public IEnumerable<AssetParameterDto> Parameters { get; set; } = [];
}