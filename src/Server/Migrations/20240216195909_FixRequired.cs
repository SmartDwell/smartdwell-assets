using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class FixRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0382490e-f9bd-470d-96fb-e1a32e7d4484"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1586fcef-f7f4-4248-9afb-03015c7c85be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44cd1fb4-61bb-4716-a5b1-b98cbdd42d70"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c94ff409-f973-4e3c-84aa-d66237b4749d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cfece9ea-b049-46ff-933e-3c31567fde99"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1273eb5-7f0b-45b8-beb2-d1902f7a06b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6313d91-a4d9-4278-83ba-248537bd538f"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("0382490e-f9bd-470d-96fb-e1a32e7d4484"), null, "Детсткая площадка", true },
                    { new Guid("1586fcef-f7f4-4248-9afb-03015c7c85be"), null, "Подъезд", true },
                    { new Guid("44cd1fb4-61bb-4716-a5b1-b98cbdd42d70"), null, "Этаж", true },
                    { new Guid("c94ff409-f973-4e3c-84aa-d66237b4749d"), null, "Жилой комплекс", true },
                    { new Guid("cfece9ea-b049-46ff-933e-3c31567fde99"), null, "Дом", true },
                    { new Guid("d1273eb5-7f0b-45b8-beb2-d1902f7a06b3"), null, "Квартира", true },
                    { new Guid("e6313d91-a4d9-4278-83ba-248537bd538f"), null, "Игровая площадка", true }
                });
        }
    }
}
