using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Server.ApiGroups;

/// <summary>
/// Группа для мокапов.
/// </summary>
public static class MockupGroup
{
    /// <summary>
    /// Маппинг группы мокапов.
    /// </summary>
    /// <param name="endpoints"></param>
    public static void MapMockupGroup(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup(string.Empty);
        //.RequireAuthorization();
        group.MapGet("/api/drop", DropData)
            .WithName("DropData")
            .WithSummary("Удаление всех данных")
            .WithOpenApi();
        group.MapGet("/api/mockup", MockupData)
            .WithName("MockupData")
            .WithSummary("Заполнение данными")
            .WithOpenApi();
    }

    private static async Task<IResult> DropData(DatabaseContext context)
    {
        var assetsCategories = await context.AssetCategoryParameters.ToListAsync();
        context.AssetCategoryParameters.RemoveRange(assetsCategories);
        await context.SaveChangesAsync();

        var assets = await context.Assets.ToListAsync();
        context.Assets.RemoveRange(assets);
        await context.SaveChangesAsync();

        var categoryParameters = await context.CategoryParameters.ToListAsync();
        context.CategoryParameters.RemoveRange(categoryParameters);
        await context.SaveChangesAsync();

        var categories = await context.Categories.ToListAsync();
        context.Categories.RemoveRange(categories);
        await context.SaveChangesAsync();

        var parameters = await context.Parameters.ToListAsync();
        context.Parameters.RemoveRange(parameters);
        await context.SaveChangesAsync();
        return TypedResults.Ok();
    }

    private static async Task<IResult> MockupData(DatabaseContext context)
    {
        var categories = new List<Category>
        {
            new() {Id = Guid.NewGuid(), Name = "Жилой комплекс", UseForApi = true},
            new() {Id = Guid.NewGuid(), Name = "Дом", UseForApi = true},
            new() {Id = Guid.NewGuid(), Name = "Подъезд", UseForApi = true},
            new() {Id = Guid.NewGuid(), Name = "Квартира", UseForApi = true},
            new() {Id = Guid.NewGuid(), Name = "Детская площадка", UseForApi = true},
            new() {Id = Guid.NewGuid(), Name = "Парковка", UseForApi = true},
            new() {Id = Guid.NewGuid(), Name = "Спортивная площадка", UseForApi = true},
        };

        var parameters = new List<Parameter>
        {
            new() {Id = Guid.NewGuid(), Name = "Площадь", TypeCode = TypeCode.Double},
            new() {Id = Guid.NewGuid(), Name = "Количество комнат", TypeCode = TypeCode.Int32},
            new() {Id = Guid.NewGuid(), Name = "Этаж", TypeCode = TypeCode.Int32},
            new() {Id = Guid.NewGuid(), Name = "Количество домов", TypeCode = TypeCode.Int32},
            new() {Id = Guid.NewGuid(), Name = "Количество этажей", TypeCode = TypeCode.Int32},
            new() {Id = Guid.NewGuid(), Name = "Количество подъездов", TypeCode = TypeCode.Int32},
            new() {Id = Guid.NewGuid(), Name = "Количество квартир", TypeCode = TypeCode.Int32},
            new() {Id = Guid.NewGuid(), Name = "Количество машиномест", TypeCode = TypeCode.Int32},
            new() {Id = Guid.NewGuid(), Name = "Количество спортивных площадок", TypeCode = TypeCode.Int32},
        };

        var categoryParameters = new List<CategoryParameter>
        {
            new() { Id = Guid.NewGuid(), CategoryId = categories[0].Id, ParameterId = parameters[3].Id }, // Жилой комплекс - Количество домов 
            new() { Id = Guid.NewGuid(), CategoryId = categories[0].Id, ParameterId = parameters[6].Id }, // Жилой комплекс - Количество квартир
            new() { Id = Guid.NewGuid(), CategoryId = categories[0].Id, ParameterId = parameters[7].Id }, // Жилой комплекс - Количество машиномест
            new() { Id = Guid.NewGuid(), CategoryId = categories[0].Id, ParameterId = parameters[8].Id }, // Жилой комплекс - Количество спортивных площадок
            
            new() { Id = Guid.NewGuid(), CategoryId = categories[1].Id, ParameterId = parameters[4].Id }, // Дом - Количество этажей
            new() { Id = Guid.NewGuid(), CategoryId = categories[1].Id, ParameterId = parameters[5].Id }, // Дом - Количество подъездов
            new() { Id = Guid.NewGuid(), CategoryId = categories[1].Id, ParameterId = parameters[6].Id }, // Дом - Количество квартир
            new() { Id = Guid.NewGuid(), CategoryId = categories[1].Id, ParameterId = parameters[7].Id }, // Дом - Количество машиномест
            
            new() { Id = Guid.NewGuid(), CategoryId = categories[2].Id, ParameterId = parameters[4].Id }, // Подъезд - Количество этажей
            new() { Id = Guid.NewGuid(), CategoryId = categories[2].Id, ParameterId = parameters[6].Id }, // Подъезд - Количество квартир
            
            new() { Id = Guid.NewGuid(), CategoryId = categories[3].Id, ParameterId = parameters[2].Id }, // Квартира - Этаж
            new() { Id = Guid.NewGuid(), CategoryId = categories[3].Id, ParameterId = parameters[0].Id }, // Квартира - Площадь
            new() { Id = Guid.NewGuid(), CategoryId = categories[3].Id, ParameterId = parameters[1].Id }, // Квартира - Количество комнат
        };

        await context.Categories.AddRangeAsync(categories);
        await context.Parameters.AddRangeAsync(parameters);
        await context.CategoryParameters.AddRangeAsync(categoryParameters);
        await context.SaveChangesAsync();
        
        var assets = new List<Asset>
        {
            new() {Id = Guid.NewGuid(), Name = "Новое время"},
            
            new() {Id = Guid.NewGuid(), Name = "Дом А2"},
            new() {Id = Guid.NewGuid(), Name = "Дом А3"},
            
            new() {Id = Guid.NewGuid(), Name = "Подъезд 1"},
            new() {Id = Guid.NewGuid(), Name = "Подъезд 2"},
            new() {Id = Guid.NewGuid(), Name = "Подъезд 1"},
            new() {Id = Guid.NewGuid(), Name = "Подъезд 2"},
            
            // 12 квартир в каждом доме (по 6 в каждом подъезде)
            new() {Id = Guid.NewGuid(), Name = "Квартира 1"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 2"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 3"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 4"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 5"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 6"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 7"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 8"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 9"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 10"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 11"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 12"},
            
            new() {Id = Guid.NewGuid(), Name = "Квартира 1"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 2"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 3"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 4"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 5"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 6"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 7"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 8"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 9"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 10"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 11"},
            new() {Id = Guid.NewGuid(), Name = "Квартира 12"},
            
            new() {Id = Guid.NewGuid(), Name = "Спортивная площадка 1"},
            new() {Id = Guid.NewGuid(), Name = "Спортивная площадка 2"},
            new() {Id = Guid.NewGuid(), Name = "Детская площадка 1"},
        };

        var assetParents = new List<AssetParent>
        {
            new() { Id = Guid.NewGuid(), AssetId = assets[1].Id, ParentId = assets[0].Id }, // Дом А2 - Новое время
            new() { Id = Guid.NewGuid(), AssetId = assets[2].Id, ParentId = assets[0].Id }, // Дом А3 - Новое время
            
            new() { Id = Guid.NewGuid(), AssetId = assets[3].Id, ParentId = assets[1].Id }, // Подъезд 1 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[4].Id, ParentId = assets[1].Id }, // Подъезд 2 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[5].Id, ParentId = assets[2].Id }, // Подъезд 1 - Дом А3
            new() { Id = Guid.NewGuid(), AssetId = assets[6].Id, ParentId = assets[2].Id }, // Подъезд 2 - Дом А3
            
            new() { Id = Guid.NewGuid(), AssetId = assets[7].Id, ParentId = assets[3].Id }, // Квартира 1 - Подъезд 1 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[8].Id, ParentId = assets[3].Id }, // Квартира 2 - Подъезд 1 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[9].Id, ParentId = assets[3].Id }, // Квартира 3 - Подъезд 1 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[10].Id, ParentId = assets[3].Id }, // Квартира 4 - Подъезд 1 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[11].Id, ParentId = assets[3].Id }, // Квартира 5 - Подъезд 1 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[12].Id, ParentId = assets[3].Id }, // Квартира 6 - Подъезд 1 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[13].Id, ParentId = assets[4].Id }, // Квартира 7 - Подъезд 2 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[14].Id, ParentId = assets[4].Id }, // Квартира 8 - Подъезд 2 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[15].Id, ParentId = assets[4].Id }, // Квартира 9 - Подъезд 2 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[16].Id, ParentId = assets[4].Id }, // Квартира 10 - Подъезд 2 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[17].Id, ParentId = assets[4].Id }, // Квартира 11 - Подъезд 2 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[18].Id, ParentId = assets[4].Id }, // Квартира 12 - Подъезд 2 - Дом А2
            
            new() { Id = Guid.NewGuid(), AssetId = assets[19].Id, ParentId = assets[5].Id }, // Квартира 1 - Подъезд 1 - Дом А3
            new() { Id = Guid.NewGuid(), AssetId = assets[20].Id, ParentId = assets[5].Id }, // Квартира 2 - Подъезд 1 - Дом А3
            new() { Id = Guid.NewGuid(), AssetId = assets[21].Id, ParentId = assets[5].Id }, // Квартира 3 - Подъезд 1 - Дом А3
            new() { Id = Guid.NewGuid(), AssetId = assets[22].Id, ParentId = assets[5].Id }, // Квартира 4 - Подъезд 1 - Дом А3
            new() { Id = Guid.NewGuid(), AssetId = assets[23].Id, ParentId = assets[5].Id }, // Квартира 5 - Подъезд 1 - Дом А3
            new() { Id = Guid.NewGuid(), AssetId = assets[24].Id, ParentId = assets[5].Id }, // Квартира 6 - Подъезд 1 - Дом А3
            new() { Id = Guid.NewGuid(), AssetId = assets[25].Id, ParentId = assets[6].Id }, // Квартира 7 - Подъезд 2 - Дом А3
            new() { Id = Guid.NewGuid(), AssetId = assets[26].Id, ParentId = assets[6].Id }, // Квартира 8 - Подъезд 2 - Дом А3
            new() { Id = Guid.NewGuid(), AssetId = assets[27].Id, ParentId = assets[6].Id }, // Квартира 9 - Подъезд 2 - Дом А3
            new() { Id = Guid.NewGuid(), AssetId = assets[28].Id, ParentId = assets[6].Id }, // Квартира 10 - Подъезд 2 - Дом А3
            new() { Id = Guid.NewGuid(), AssetId = assets[29].Id, ParentId = assets[6].Id }, // Квартира 11 - Подъезд 2 - Дом А3
            new() { Id = Guid.NewGuid(), AssetId = assets[30].Id, ParentId = assets[6].Id }, // Квартира 12 - Подъезд 2 - Дом А3
            
            new() { Id = Guid.NewGuid(), AssetId = assets[31].Id, ParentId = assets[1].Id }, // Спортивная площадка 1 - Дом А2
            new() { Id = Guid.NewGuid(), AssetId = assets[32].Id, ParentId = assets[2].Id }, // Спортивная площадка 2 - Дом А3
            
            new() { Id = Guid.NewGuid(), AssetId = assets[33].Id, ParentId = assets[1].Id }, // Детская площадка 1 - Дом А2
        };
        
        // TODO: Возможно, TypeCode не нужен
        var assetsCategories = new List<AssetCategoryParameter>
        {
            new() { Id = Guid.NewGuid(), AssetId = assets[0].Id, CategoryParameterId = categoryParameters[0].Id, Value = "2", TypeCode = TypeCode.Int32 },  // Новое время - Количество домов
            new() { Id = Guid.NewGuid(), AssetId = assets[0].Id, CategoryParameterId = categoryParameters[1].Id, Value = "12", TypeCode = TypeCode.Int32 }, // Новое время - Количество квартир
            new() { Id = Guid.NewGuid(), AssetId = assets[0].Id, CategoryParameterId = categoryParameters[2].Id, Value = "0", TypeCode = TypeCode.Int32 },  // Новое время - Количество машиномест
            new() { Id = Guid.NewGuid(), AssetId = assets[0].Id, CategoryParameterId = categoryParameters[3].Id, Value = "2", TypeCode = TypeCode.Int32 },  // Новое время - Количество спортивных площадок
            
            new() { Id = Guid.NewGuid(), AssetId = assets[1].Id, CategoryParameterId = categoryParameters[4].Id, Value = "3", TypeCode = TypeCode.Int32 },  // Дом А2 - Количество этажей
            new() { Id = Guid.NewGuid(), AssetId = assets[1].Id, CategoryParameterId = categoryParameters[5].Id, Value = "2", TypeCode = TypeCode.Int32 },  // Дом А2 - Количество подъездов
            new() { Id = Guid.NewGuid(), AssetId = assets[1].Id, CategoryParameterId = categoryParameters[6].Id, Value = "12", TypeCode = TypeCode.Int32 }, // Дом А2 - Количество квартир
            new() { Id = Guid.NewGuid(), AssetId = assets[1].Id, CategoryParameterId = categoryParameters[7].Id, Value = "0", TypeCode = TypeCode.Int32 },  // Дом А2 - Количество машиномест
            
            new() { Id = Guid.NewGuid(), AssetId = assets[2].Id, CategoryParameterId = categoryParameters[4].Id, Value = "3", TypeCode = TypeCode.Int32 },  // Дом А3 - Количество этажей
            new() { Id = Guid.NewGuid(), AssetId = assets[2].Id, CategoryParameterId = categoryParameters[5].Id, Value = "2", TypeCode = TypeCode.Int32 },  // Дом А3 - Количество подъездов
            new() { Id = Guid.NewGuid(), AssetId = assets[2].Id, CategoryParameterId = categoryParameters[6].Id, Value = "12", TypeCode = TypeCode.Int32 }, // Дом А3 - Количество квартир
            new() { Id = Guid.NewGuid(), AssetId = assets[2].Id, CategoryParameterId = categoryParameters[7].Id, Value = "0", TypeCode = TypeCode.Int32 },  // Дом А3 - Количество машиномест
            
            new() { Id = Guid.NewGuid(), AssetId = assets[3].Id, CategoryParameterId = categoryParameters[8].Id, Value = "3", TypeCode = TypeCode.Int32 },  // Дом А2 - Подъезд 1 - Количество этажей
            new() { Id = Guid.NewGuid(), AssetId = assets[3].Id, CategoryParameterId = categoryParameters[9].Id, Value = "6", TypeCode = TypeCode.Int32 },  // Дом А2 - Подъезд 1 - Количество квартир
            
            new() { Id = Guid.NewGuid(), AssetId = assets[4].Id, CategoryParameterId = categoryParameters[8].Id, Value = "3", TypeCode = TypeCode.Int32 },  // Дом А2 - Подъезд 2 - Количество этажей
            new() { Id = Guid.NewGuid(), AssetId = assets[4].Id, CategoryParameterId = categoryParameters[9].Id, Value = "6", TypeCode = TypeCode.Int32 },  // Дом А2 - Подъезд 2 - Количество квартир
            
            new() { Id = Guid.NewGuid(), AssetId = assets[5].Id, CategoryParameterId = categoryParameters[8].Id, Value = "3", TypeCode = TypeCode.Int32 },  // Дом А3 - Подъезд 1 - Количество этажей
            new() { Id = Guid.NewGuid(), AssetId = assets[5].Id, CategoryParameterId = categoryParameters[9].Id, Value = "6", TypeCode = TypeCode.Int32 },  // Дом А3 - Подъезд 1 - Количество квартир
            
            new() { Id = Guid.NewGuid(), AssetId = assets[6].Id, CategoryParameterId = categoryParameters[8].Id, Value = "3", TypeCode = TypeCode.Int32 },  // Дом А3 - Подъезд 2 - Количество этажей
            new() { Id = Guid.NewGuid(), AssetId = assets[6].Id, CategoryParameterId = categoryParameters[9].Id, Value = "6", TypeCode = TypeCode.Int32 },  // Дом А3 - Подъезд 2 - Количество квартир
        };

        for (var i = 0; i <= 23; ++i)
        {
            var index = i + 7;
            var square = Math.Round(50 + i * 0.5, 2);
            var roomCount = i % 6 + 1;
            assetsCategories.Add(new AssetCategoryParameter
            {
                Id = Guid.NewGuid(),
                AssetId = assets[index].Id,
                CategoryParameterId = categoryParameters[10].Id,
                Value = (-1).ToString(),
                TypeCode = TypeCode.Int32
            }); // Квартира - Подъезд - Дом - Этаж
            assetsCategories.Add(new AssetCategoryParameter
            {
                Id = Guid.NewGuid(),
                AssetId = assets[index].Id,
                CategoryParameterId = categoryParameters[11].Id,
                Value = square.ToString(CultureInfo.CurrentCulture),
                TypeCode = TypeCode.Double
            }); // Квартира - Подъезд - Дом - Площадь
            assetsCategories.Add(new AssetCategoryParameter
            {
                Id = Guid.NewGuid(),
                AssetId = assets[index].Id,
                CategoryParameterId = categoryParameters[12].Id,
                Value = roomCount.ToString(),
                TypeCode = TypeCode.Int32
            }); // Квартира - Подъезд - Дом - Количество комнат
        }
        
        await context.Assets.AddRangeAsync(assets);
        await context.AssetParents.AddRangeAsync(assetParents);
        await context.AssetCategoryParameters.AddRangeAsync(assetsCategories);
        await context.SaveChangesAsync();

        return TypedResults.Ok();

    }
}