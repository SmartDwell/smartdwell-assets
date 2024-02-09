using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class AddParameterTypeCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10f87ec1-1dea-417b-96b5-e587fb30be95"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c29fda8-5a57-4604-9f9f-2c684445a92b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6cdb706f-3320-492a-b103-ba1ee48b61a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cff366a8-61c0-40bd-ba7a-0164547b29ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e19518a5-797e-46b1-b8c1-f0cbe9e800fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7be5453-2cab-4638-aaf6-0a20102a77da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc52731f-dda1-47a5-98ea-fec15e25b4ce"));

            migrationBuilder.AddColumn<int>(
                name: "TypeCode",
                table: "Parameters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeCode",
                table: "AssetCategoryParameters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("30dd86f1-4684-4fa2-88d1-fb48f8b0bbaa"), null, "Квартира", true },
                    { new Guid("67c40cb8-a870-4a14-b438-8e929b944f4b"), null, "Этаж", true },
                    { new Guid("a22ea67a-e82b-4708-b473-b55e7e893a7b"), null, "Подъезд", true },
                    { new Guid("c813864e-f33f-4a45-a3bf-89af74e5bafd"), null, "Детсткая площадка", true },
                    { new Guid("f1ce8c18-7202-4060-a52f-87b03f8681be"), null, "Дом", true },
                    { new Guid("f4695b6e-8f3f-4aec-b67d-ff4e70b7efc0"), null, "Жилой комплекс", true },
                    { new Guid("ff75070d-68ed-4ed3-8adc-0abb904a7c73"), null, "Игровая площадка", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30dd86f1-4684-4fa2-88d1-fb48f8b0bbaa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67c40cb8-a870-4a14-b438-8e929b944f4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a22ea67a-e82b-4708-b473-b55e7e893a7b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c813864e-f33f-4a45-a3bf-89af74e5bafd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1ce8c18-7202-4060-a52f-87b03f8681be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f4695b6e-8f3f-4aec-b67d-ff4e70b7efc0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff75070d-68ed-4ed3-8adc-0abb904a7c73"));

            migrationBuilder.DropColumn(
                name: "TypeCode",
                table: "Parameters");

            migrationBuilder.DropColumn(
                name: "TypeCode",
                table: "AssetCategoryParameters");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("10f87ec1-1dea-417b-96b5-e587fb30be95"), null, "Игровая площадка", true },
                    { new Guid("4c29fda8-5a57-4604-9f9f-2c684445a92b"), null, "Подъезд", true },
                    { new Guid("6cdb706f-3320-492a-b103-ba1ee48b61a2"), null, "Квартира", true },
                    { new Guid("cff366a8-61c0-40bd-ba7a-0164547b29ba"), null, "Детсткая площадка", true },
                    { new Guid("e19518a5-797e-46b1-b8c1-f0cbe9e800fc"), null, "Жилой комплекс", true },
                    { new Guid("f7be5453-2cab-4638-aaf6-0a20102a77da"), null, "Дом", true },
                    { new Guid("fc52731f-dda1-47a5-98ea-fec15e25b4ce"), null, "Этаж", true }
                });
        }
    }
}
