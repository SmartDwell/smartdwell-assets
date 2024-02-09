namespace Contracts.Parameter;

/// <summary>
/// Модель параметра.
/// </summary>
public class ParameterDto
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