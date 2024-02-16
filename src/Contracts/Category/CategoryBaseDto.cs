namespace Contracts.Category;

/// <summary>
/// Базовая модель категории.
/// </summary>
public class CategoryBaseDto
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