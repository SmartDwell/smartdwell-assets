namespace Models;

/// <summary>
/// Параметр категории актива.
/// </summary>
/// <remarks>Связь между категорией и параметром, прикрепленным к активу.</remarks>
public sealed class AssetCategoryParameter
{
    /// <summary>
    /// Идентификатор связи.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Идентификатор актива.
    /// </summary>
    public Guid AssetId { get; set; }
    
    /// <summary>
    /// Актив.
    /// </summary>
    public Asset Asset { get; set; } = null!;
    
    /// <summary>
    /// Идентификатор параметра категории.
    /// </summary>
    public Guid CategoryParameterId { get; set; }
    
    /// <summary>
    /// Параметр категории.
    /// </summary>
    public CategoryParameter CategoryParameter { get; set; } = null!;
    
    /// <summary>
    /// Тип значения.
    /// </summary>
    public TypeCode TypeCode { get; set; }
    
    /// <summary>
    /// Значение.
    /// </summary>
    public string Value { get; set; } = null!;
}