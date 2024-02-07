namespace Models;

/// <summary>
/// Категория.
/// </summary>
public class Category
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
    /// Параметры.
    /// </summary>
    public virtual ICollection<Parameter> Parameters { get; set; } = [];

    /// <summary>
    /// Активы.
    /// </summary>
    public virtual ICollection<Asset> Assets { get; set; } = [];
}