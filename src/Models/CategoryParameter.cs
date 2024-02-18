namespace Models;

/// <summary>
/// Параметр категории.
/// </summary>
public sealed class CategoryParameter
{
    /// <summary>
    /// Идентификатор связи.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Идентификатор категории.
    /// </summary>
    public Guid CategoryId { get; set; }
    
    /// <summary>
    /// Категория.
    /// </summary>
    public Category Category { get; set; } = null!;
    
    /// <summary>
    /// Идентификатор параметра.
    /// </summary>
    public Guid ParameterId { get; set; }
    
    /// <summary>
    /// Параметр.
    /// </summary>
    public Parameter Parameter { get; set; } = null!;

    /// <summary>
    /// Коллекция параметров категории актива.
    /// </summary>
    public IEnumerable<AssetCategoryParameter> AssetCategoryParameters { get; set; } =
        new List<AssetCategoryParameter>();
}