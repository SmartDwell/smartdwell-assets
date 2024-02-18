using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class FixCollectionInterface : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f6b25b5-0f51-4e47-b8f3-dc2a027e235e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2193f21d-5a4b-49a1-aaf1-19ae49ba914a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45eddaba-231b-4402-9b67-8bb6129dda9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("501786d1-49db-4efd-a371-da1cc3bd7d97"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b4cd52a-9501-4fa1-a6d1-6bbaf338965d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90ac0a5b-b256-4e3f-8105-1f163a939dab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc52621b-1485-4eb8-9997-c3e05490bba7"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("1f6b25b5-0f51-4e47-b8f3-dc2a027e235e"), null, "Дом", true },
                    { new Guid("2193f21d-5a4b-49a1-aaf1-19ae49ba914a"), null, "Квартира", true },
                    { new Guid("45eddaba-231b-4402-9b67-8bb6129dda9e"), null, "Детсткая площадка", true },
                    { new Guid("501786d1-49db-4efd-a371-da1cc3bd7d97"), null, "Жилой комплекс", true },
                    { new Guid("6b4cd52a-9501-4fa1-a6d1-6bbaf338965d"), null, "Подъезд", true },
                    { new Guid("90ac0a5b-b256-4e3f-8105-1f163a939dab"), null, "Этаж", true },
                    { new Guid("fc52621b-1485-4eb8-9997-c3e05490bba7"), null, "Игровая площадка", true }
                });
        }
    }
}
