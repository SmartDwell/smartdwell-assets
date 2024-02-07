namespace Models;

/// <summary>
/// Параметр.
/// </summary>
public class Parameter
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
    /// Тип.
    /// </summary>
    public TypeCode Type { get; set; }
    
    /// <summary>
    /// Значение.
    /// </summary>
    public string Value { get; set; } = null!;
    
    /// <summary>
    /// Идентификатор единицы измерения.
    /// </summary>
    public Guid MeasureUnitId { get; set; }
    
    /// <summary>
    /// Единица измерения.
    /// </summary>
    public virtual MeasureUnit MeasureUnit { get; set; } = null!;

    /// <summary>
    /// Категории.
    /// </summary>
    public virtual ICollection<Category> Categories { get; set; } = [];
}