namespace Contracts.Asset;

/// <summary>
/// Информация о параметре актива.
/// </summary>
public class AssetParameterDto
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
    /// Тип значения.
    /// </summary>
    public TypeCode TypeCode { get; set; }
    
    /// <summary>
    /// Значение.
    /// </summary>
    public string Value { get; set; } = null!;
}