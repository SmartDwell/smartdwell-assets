namespace Models;

/// <summary>
/// Актив.
/// </summary>
public class Asset
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
    /// Идентификаторы изображений.
    /// </summary>
    public ICollection<Guid> Images { get; set; } = [];

    /// <summary>
    /// Категории.
    /// </summary>
    public virtual ICollection<Category> Categories { get; set; } = [];
}