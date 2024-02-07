using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class AddValueToParameter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bdcc048-c878-4cbd-9fe4-d24880c12971"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19311b9e-d865-476d-97f9-7ef81a1ea26f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1cf8e33f-5256-4edd-a488-130c7fe06198"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47999b03-4f36-420e-8000-b746fa4b9721"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60ccb212-6c55-4d58-bbb8-bb6b2b83ab51"));

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Parameters",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("0966f757-2552-427b-b08c-9c704a04165c"), null, "Дом", false },
                    { new Guid("111144fa-88e3-4236-9bf1-ac9f7cdb806e"), null, "Жилой комплекс", false },
                    { new Guid("1bfe95db-5f01-48e3-9109-f4da22093aa8"), null, "Этаж", false },
                    { new Guid("ad8abce3-3110-427f-bf77-d1caa321b3de"), null, "Квартира", false },
                    { new Guid("b9c81a33-c142-4893-b4a1-b731b33b26a1"), null, "Подъезд", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0966f757-2552-427b-b08c-9c704a04165c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("111144fa-88e3-4236-9bf1-ac9f7cdb806e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bfe95db-5f01-48e3-9109-f4da22093aa8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad8abce3-3110-427f-bf77-d1caa321b3de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b9c81a33-c142-4893-b4a1-b731b33b26a1"));

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Parameters");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("0bdcc048-c878-4cbd-9fe4-d24880c12971"), null, "Жилой комплекс", false },
                    { new Guid("19311b9e-d865-476d-97f9-7ef81a1ea26f"), null, "Квартира", false },
                    { new Guid("1cf8e33f-5256-4edd-a488-130c7fe06198"), null, "Подъезд", false },
                    { new Guid("47999b03-4f36-420e-8000-b746fa4b9721"), null, "Дом", false },
                    { new Guid("60ccb212-6c55-4d58-bbb8-bb6b2b83ab51"), null, "Этаж", false }
                });
        }
    }
}
