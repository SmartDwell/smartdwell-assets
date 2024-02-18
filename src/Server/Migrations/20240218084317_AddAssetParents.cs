using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class AddAssetParents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Parents",
                table: "Assets",
                newName: "ParentsIds");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ParentsIds",
                table: "Assets",
                newName: "Parents");

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
    }
}
