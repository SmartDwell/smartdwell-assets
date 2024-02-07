namespace Contracts.MeasureUnit;

/// <summary>
/// Единица измерения.
/// </summary>
public class MeasureUnitDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; } = string.Empty;
}