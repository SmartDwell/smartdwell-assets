using System.ComponentModel.DataAnnotations;

namespace Contracts.Parameter;

/// <summary>
/// Модель параметра для обновления/добавления.
/// </summary>
public class ParameterPutDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid? Id { get; set; }
    
    /// <summary>
    /// Наименование.
    /// </summary>
    [Required(ErrorMessage = "Не указано наименование параметра.")]
    [MaxLength(100, ErrorMessage = "Наименование параметра не должно превышать 100 символов.]")]
    public string Name { get; set; } = string.Empty;
}