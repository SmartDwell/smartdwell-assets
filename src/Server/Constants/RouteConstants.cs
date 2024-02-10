namespace Server.Constants;

/// <summary>
/// Константы маршрутов.
/// </summary>
public static class RouteConstants
{
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
        
        /// <summary>
        /// Маршрут для получения всех категорий.
        /// </summary>
        public const string CategoriesUrl = Route;
        
        /// <summary>
        /// Маршрут для получения категории по идентификатору.
        /// </summary>
        public const string CategoryByIdUrl = $$"""{{Route}}/{id:guid}""";
        
        /// <summary>
        /// Маршрут для создания/обновления категории.
        /// </summary>
        public const string CategoryPutUrl = Route;
        
        /// <summary>
        /// Маршрут для удаления категории.
        /// </summary>
        public const string CategoryDeleteUrl = $$"""{{Route}}/{id:guid}""";
    }
    
    /// <summary>
    /// Данные единицы измерения.
    /// </summary>
    public static class ParameterData
    {
        /// <summary>
        /// Базовый маршрут.
        /// </summary>
        private const string Route = "/api/parameters";

        /// <summary>
        /// Маршрут для получения всех параметров.
        /// </summary>
        public const string ParametersUrl = Route;
        
        /// <summary>
        /// Маршрут для получения параметра по идентификатору.
        /// </summary>
        public const string ParameterByIdUrl = $$"""{{Route}}/{id:guid}""";
        
        /// <summary>
        /// Маршрут для создания/обновления параметра.
        /// </summary>
        public const string ParameterPutUrl = Route;
        
        /// <summary>
        /// Маршрут для удаления параметра.
        /// </summary>
        public const string ParameterDeleteUrl = $$"""{{Route}}/{id:guid}""";
    }
}