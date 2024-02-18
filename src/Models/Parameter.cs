namespace Models;

/// <summary>
/// Параметр.
/// </summary>
public sealed class Parameter
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
    /// Категории.
    /// </summary>
    public IEnumerable<CategoryParameter> CategoryParameters { get; set; } = new List<CategoryParameter>();
    
    /// <summary>
    /// Тип значения.
    /// </summary>
    public TypeCode TypeCode { get; set; }
}