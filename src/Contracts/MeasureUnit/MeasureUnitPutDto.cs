namespace Contracts.MeasureUnit;

/// <summary>
/// Модель для обновления единицы измерения.
/// </summary>
public class MeasureUnitPutDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid? Id { get; set; }
    
    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; } = string.Empty;
}