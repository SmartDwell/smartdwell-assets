namespace Server.Constants;

/// <summary>
/// Константы маршрутов.
/// </summary>
public static class RouteConstants
{
    /// <summary>
    /// Базовый маршрут.
    /// </summary>
    public const string Base = "/";
        
    /// <summary>
    /// Доступ по идентификатору.
    /// </summary>
    public const string ById = "/{id:guid}";
    
    /// <summary>
    /// Данные актива.
    /// </summary>
    public static class AssetData
    {
        /// <summary>
        /// Базовый маршрут.
        /// </summary>
        public const string Route = "/api/assets";
    }
    
    /// <summary>
    /// Данные категории.
    /// </summary>
    public static class CategoryData
    {
        /// <summary>
        /// Базовый маршрут.
        /// </summary>
        public const string Route = "/api/categories";
    }
    
    /// <summary>
    /// Данные единицы измерения.
    /// </summary>
    public static class ParameterData
    {
        /// <summary>
        /// Базовый маршрут.
        /// </summary>
        public const string Route = "/api/parameters";
    }
    
    /// <summary>
    /// Данные единицы измерения.
    /// </summary>
    public static class MeasureUnitData
    {
        /// <summary>
        /// Базовый маршрут.
        /// </summary>
        public const string Route = "/api/measure-units";
    }
}