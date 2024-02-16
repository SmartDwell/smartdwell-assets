namespace Contracts.Asset;

/// <summary>
/// Параметр категории актива.
/// </summary>
public class AssetCategoryParameterPutDto
{
    /// <summary>
    /// Идентификатор категории.
    /// </summary>
    public Guid CategoryId { get; set; }
    
    /// <summary>
    /// Идентификатор параметра.
    /// </summary>
    public Guid ParameterId { get; set; }
    
    /// <summary>
    /// Тип значения.
    /// </summary>
    public TypeCode TypeCode { get; set; }
    
    /// <summary>
    /// Значение.
    /// </summary>
    public string Value { get; set; } = null!;
}