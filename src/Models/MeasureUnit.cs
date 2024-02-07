namespace Models;

/// <summary>
/// Единица измерения.
/// </summary>
public class MeasureUnit
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
    public virtual ICollection<Parameter> Parameters { get; set; } = new List<Parameter>();
}