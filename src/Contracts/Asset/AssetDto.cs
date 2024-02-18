using Contracts.Category;

namespace Contracts.Asset;

/// <summary>
/// Актив.
/// </summary>
public sealed class AssetDto
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
    /// Родительские активы.
    /// </summary>
    public IEnumerable<AssetBaseDto> Parents { get; set; } = [];
    
    /// <summary>
    /// Категории.
    /// </summary>
    public IEnumerable<CategoryBaseDto> Categories { get; set; } = [];
}