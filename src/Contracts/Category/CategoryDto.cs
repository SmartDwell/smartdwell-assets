using Contracts.Parameter;

namespace Contracts.Category;

/// <summary>
/// Модель категории.
/// </summary>
public class CategoryDto
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
    public IEnumerable<ParameterDto> Parameters { get; set; } = [];
}