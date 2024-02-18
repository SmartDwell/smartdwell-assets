using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class AddParentsToAsset2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12d4b666-3d1a-4ee2-bb50-40503eced00a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18285145-9e0c-4a6f-8a3f-4e7c02a4ae25"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b6ac57b-a748-4a34-a74f-893c3197730b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("698280e5-4979-4f5c-a22c-53ee1ba7c0c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6eb7010-e8d8-4c7e-bddd-94e2d216d32e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dea58412-7585-4b95-8cbe-f283a36039ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e500a8ef-7b7a-45a4-90f0-ec5661ecfde5"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("01c8cb38-0d7e-4ce4-9601-9676c16f9576"), null, "Этаж", true },
                    { new Guid("87e6cc59-17a4-4ee7-9bf1-ad3d98aeea16"), null, "Детсткая площадка", true },
                    { new Guid("8d13a74f-e7fd-45df-94e7-73d85149d944"), null, "Подъезд", true },
                    { new Guid("d2708444-6f62-4fc6-a99e-80fd21989a1e"), null, "Жилой комплекс", true },
                    { new Guid("d3865f22-ec4b-4b3b-ba13-33ecfc56a22e"), null, "Дом", true },
                    { new Guid("f16d6f57-a0f7-441f-b703-63b78d47d707"), null, "Квартира", true },
                    { new Guid("faa82e26-34c3-41b8-895f-73adc9bddf28"), null, "Игровая площадка", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01c8cb38-0d7e-4ce4-9601-9676c16f9576"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87e6cc59-17a4-4ee7-9bf1-ad3d98aeea16"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d13a74f-e7fd-45df-94e7-73d85149d944"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2708444-6f62-4fc6-a99e-80fd21989a1e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3865f22-ec4b-4b3b-ba13-33ecfc56a22e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f16d6f57-a0f7-441f-b703-63b78d47d707"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("faa82e26-34c3-41b8-895f-73adc9bddf28"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("12d4b666-3d1a-4ee2-bb50-40503eced00a"), null, "Этаж", true },
                    { new Guid("18285145-9e0c-4a6f-8a3f-4e7c02a4ae25"), null, "Дом", true },
                    { new Guid("1b6ac57b-a748-4a34-a74f-893c3197730b"), null, "Жилой комплекс", true },
                    { new Guid("698280e5-4979-4f5c-a22c-53ee1ba7c0c2"), null, "Игровая площадка", true },
                    { new Guid("a6eb7010-e8d8-4c7e-bddd-94e2d216d32e"), null, "Детсткая площадка", true },
                    { new Guid("dea58412-7585-4b95-8cbe-f283a36039ba"), null, "Квартира", true },
                    { new Guid("e500a8ef-7b7a-45a4-90f0-ec5661ecfde5"), null, "Подъезд", true }
                });
        }
    }
}
