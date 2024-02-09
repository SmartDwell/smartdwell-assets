namespace Models;

/// <summary>
/// Категория.
/// </summary>
public sealed class Category
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
    /// Признак использования в API.
    /// </summary>
    public bool UseForApi { get; set; }

    /// <summary>
    /// Параметры категории.
    /// </summary>
    public ICollection<CategoryParameter> CategoryParameters { get; set; } = [];
}