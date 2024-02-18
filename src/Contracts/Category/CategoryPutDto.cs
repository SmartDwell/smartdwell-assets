using System.ComponentModel.DataAnnotations;
using Contracts.Parameter;

namespace Contracts.Category;

/// <summary>
/// Модель категории для изменения/добавления.
/// </summary>
public class CategoryPutDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid? Id { get; set; }
    
    /// <summary>
    /// Наименование.
    /// </summary>
    [Required(ErrorMessage = "Не указано наименование категории.")]
    [MaxLength(100, ErrorMessage = "Наименование категории не должно превышать 100 символов.")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Описание.
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    /// Признак использования в API.
    /// </summary>
    [Required(ErrorMessage = "Не указано использование категории в API.")]
    public bool UseForApi { get; set; }
    
    /// <summary>
    /// Параметры.
    /// </summary>
    [Required(ErrorMessage = "Не указаны параметры категории.")]
    [MinLength(1, ErrorMessage = "Категория должна содержать хотя бы один параметр.")]
    public IEnumerable<Guid> Parameters { get; set; } = [];
}