using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class AddParentsToAsset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a6f1bbe-e6ce-439d-9ee2-5f25607a0cca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54bfc828-d1f7-4f7f-a887-497200168625"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7beb46fe-cf06-4952-a412-f4a694bc521e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8699752c-0a1e-479a-9591-0115d3525d2b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89c8b698-3b47-4dd6-ae5f-43dc0cd92fd0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8683868-9dc3-4c81-aeae-60e048164067"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3fd0053-bc6c-4298-a963-97d46832aae9"));

            migrationBuilder.AddColumn<Guid[]>(
                name: "Parents",
                table: "Assets",
                type: "uuid[]",
                nullable: false,
                defaultValue: new Guid[0]);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Parents",
                table: "Assets");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("1a6f1bbe-e6ce-439d-9ee2-5f25607a0cca"), null, "Детсткая площадка", true },
                    { new Guid("54bfc828-d1f7-4f7f-a887-497200168625"), null, "Этаж", true },
                    { new Guid("7beb46fe-cf06-4952-a412-f4a694bc521e"), null, "Жилой комплекс", true },
                    { new Guid("8699752c-0a1e-479a-9591-0115d3525d2b"), null, "Дом", true },
                    { new Guid("89c8b698-3b47-4dd6-ae5f-43dc0cd92fd0"), null, "Подъезд", true },
                    { new Guid("b8683868-9dc3-4c81-aeae-60e048164067"), null, "Квартира", true },
                    { new Guid("c3fd0053-bc6c-4298-a963-97d46832aae9"), null, "Игровая площадка", true }
                });
        }
    }
}
