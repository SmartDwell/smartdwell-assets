using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class RemoveImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e0cc9ec-4fd3-4d9f-9438-f47dec3482a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3cfdb514-c921-427d-a27c-4efb988b1fc6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77a127d4-7fe0-4da7-ac5d-ffab026ed82d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("894b3e1a-7b3b-4c75-aa97-27fc288873d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9dfdffbb-78a0-403a-94ac-c488bd868234"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3de6611-da4a-409c-a3fb-c6e5a5cf454a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fda48a4b-e2b9-4e53-8e74-0a33837d565a"));

            migrationBuilder.DropColumn(
                name: "Images",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Images",
                table: "Assets",
                type: "uuid[]",
                nullable: false,
                defaultValue: new Guid[0]);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("0e0cc9ec-4fd3-4d9f-9438-f47dec3482a4"), null, "Детсткая площадка", true },
                    { new Guid("3cfdb514-c921-427d-a27c-4efb988b1fc6"), null, "Дом", true },
                    { new Guid("77a127d4-7fe0-4da7-ac5d-ffab026ed82d"), null, "Квартира", true },
                    { new Guid("894b3e1a-7b3b-4c75-aa97-27fc288873d4"), null, "Игровая площадка", true },
                    { new Guid("9dfdffbb-78a0-403a-94ac-c488bd868234"), null, "Жилой комплекс", true },
                    { new Guid("e3de6611-da4a-409c-a3fb-c6e5a5cf454a"), null, "Этаж", true },
                    { new Guid("fda48a4b-e2b9-4e53-8e74-0a33837d565a"), null, "Подъезд", true }
                });
        }
    }
}
