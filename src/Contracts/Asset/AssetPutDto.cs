using System.ComponentModel.DataAnnotations;

namespace Contracts.Asset;

/// <summary>
/// Модель актива для изменения/добавления.
/// </summary>
public class AssetPutDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid? Id { get; set; }
    
    /// <summary>
    /// Наименование.
    /// </summary>
    [Required]
    [MaxLength(100, ErrorMessage = "Наименование актива не должно превышать 100 символов.")]
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
    /// Категории с параметрами.
    /// </summary>
    public ICollection<AssetCategoryParameterPutDto> Categories { get; set; } = [];
}