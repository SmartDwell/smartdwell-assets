namespace Models;

/// <summary>
/// Родительский актив.
/// </summary>
public class AssetParent
{
    /// <summary>
    /// Идентификатор связи.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Идентификатор актива.
    /// </summary>
    public Guid AssetId { get; set; }
    
    /// <summary>
    /// Актив.
    /// </summary>
    public Asset Asset { get; set; } = null!;
    
    /// <summary>
    /// Идентификатор родительского актива.
    /// </summary>
    public Guid ParentId { get; set; }
    
    /// <summary>
    /// Родительский актив.
    /// </summary>
    public Asset Parent { get; set; } = null!;
}