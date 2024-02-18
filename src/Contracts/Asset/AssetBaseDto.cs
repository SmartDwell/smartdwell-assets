namespace Contracts.Asset;

/// <summary>
/// Базовая модель актива.
/// </summary>
public sealed class AssetBaseDto
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