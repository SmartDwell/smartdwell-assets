using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class AddAssetParents2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07e40252-c40d-4c47-aef1-332048ac9a89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3700ec53-7747-4d09-b9fc-45b359353e2e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51fc3a3a-347d-46fb-bc0b-3fad812a7311"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ed8f272-7c2a-4f4f-bb05-899eee0daab5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71135f0c-da0b-4f17-b20b-a5f71119f73f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ba8e781-103f-48a3-8d68-8d8bebe6d131"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d64cc9c7-be3d-4329-99f4-ed399d7b7925"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("59105967-bed3-4e40-ac56-32e47c9cc7f4"), null, "Подъезд", true },
                    { new Guid("6374dd75-9852-4047-9fb7-eccbc045a2b7"), null, "Этаж", true },
                    { new Guid("8a30887a-021f-4917-9e82-05dac54e517d"), null, "Игровая площадка", true },
                    { new Guid("9d64c7cb-1c4b-495d-bf89-95a39cbed3cf"), null, "Жилой комплекс", true },
                    { new Guid("b331ba0a-fff2-42b3-a587-713b14676c6d"), null, "Квартира", true },
                    { new Guid("d0670183-319c-4518-a46d-102a131289e5"), null, "Детсткая площадка", true },
                    { new Guid("f4b9ff89-a8f1-42fc-8b5a-0e11aebe9ed2"), null, "Дом", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59105967-bed3-4e40-ac56-32e47c9cc7f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6374dd75-9852-4047-9fb7-eccbc045a2b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a30887a-021f-4917-9e82-05dac54e517d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d64c7cb-1c4b-495d-bf89-95a39cbed3cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b331ba0a-fff2-42b3-a587-713b14676c6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0670183-319c-4518-a46d-102a131289e5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f4b9ff89-a8f1-42fc-8b5a-0e11aebe9ed2"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("07e40252-c40d-4c47-aef1-332048ac9a89"), null, "Детсткая площадка", true },
                    { new Guid("3700ec53-7747-4d09-b9fc-45b359353e2e"), null, "Игровая площадка", true },
                    { new Guid("51fc3a3a-347d-46fb-bc0b-3fad812a7311"), null, "Жилой комплекс", true },
                    { new Guid("5ed8f272-7c2a-4f4f-bb05-899eee0daab5"), null, "Дом", true },
                    { new Guid("71135f0c-da0b-4f17-b20b-a5f71119f73f"), null, "Этаж", true },
                    { new Guid("8ba8e781-103f-48a3-8d68-8d8bebe6d131"), null, "Подъезд", true },
                    { new Guid("d64cc9c7-be3d-4329-99f4-ed399d7b7925"), null, "Квартира", true }
                });
        }
    }
}
