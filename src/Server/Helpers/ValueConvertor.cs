namespace Server.Helpers;

/// <summary>
/// Конвертор значений.
/// </summary>
public static class ValueConvertor
{
    /// <summary>
    /// Попытаться преобразовать объект в строку.
    /// </summary>
    /// <param name="value">Объект.</param>
    /// <returns>Строка.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Неизвестный тип.</exception>
    public static string TryConvertObjectToString(object value)
    {
        return value switch
        {
            bool b => b.ToString(),
            DateTime dt => dt.ToString("O"),
            double d => d.ToString("G"),
            long l => l.ToString(),
            string s => s,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    /// <summary>
    /// Попытаться преобразовать строку в объект.
    /// </summary>
    /// <param name="value">Строка.</param>
    /// <param name="type">Тип.</param>
    /// <returns>Объект.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Неизвестный тип.</exception>
    public static object? TryConvertStringToObject(string value, TypeCode type)
    {
        return type switch
        {
            TypeCode.Boolean => bool.TryParse(value, out var b) ? b : null,
            TypeCode.DateTime => DateTime.TryParse(value, out var dt) ? dt : null,
            TypeCode.Double => double.TryParse(value, out var d) ? d : null,
            TypeCode.Int64 => long.TryParse(value, out var l) ? l : null,
            TypeCode.String => !string.IsNullOrEmpty(value) ? value : null,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}