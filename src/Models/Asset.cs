namespace Models;

/// <summary>
/// Актив.
/// </summary>
public sealed class Asset
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
    /// Описание.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Категории.
    /// </summary>
    public IEnumerable<AssetCategoryParameter> Categories { get; set; } = new List<AssetCategoryParameter>();
}