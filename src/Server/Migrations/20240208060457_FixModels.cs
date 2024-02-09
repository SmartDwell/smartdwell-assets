using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class FixModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parameters_MeasureUnits_MeasureUnitId",
                table: "Parameters");

            migrationBuilder.DropTable(
                name: "CategoryParameter");

            migrationBuilder.DropTable(
                name: "MeasureUnits");

            migrationBuilder.DropIndex(
                name: "IX_Parameters_MeasureUnitId",
                table: "Parameters");

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
                name: "Description",
                table: "Parameters");

            migrationBuilder.DropColumn(
                name: "MeasureUnitId",
                table: "Parameters");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Parameters");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Parameters");

            migrationBuilder.CreateTable(
                name: "CategoryParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    ParameterId = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryParameters_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryParameters_Parameters_ParameterId",
                        column: x => x.ParameterId,
                        principalTable: "Parameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("3607ebb5-8fbe-470c-a8c7-f67d441ddbe0"), null, "Квартира", false },
                    { new Guid("38b48a67-a5de-4c49-a17d-5ee2dc860586"), null, "Подъезд", false },
                    { new Guid("59fd629b-edc1-472c-bf19-dc419ba31bcf"), null, "Игровая площадка", false },
                    { new Guid("6955f376-e26f-46ab-aa2c-68842b9ec626"), null, "Этаж", false },
                    { new Guid("7d3e79d2-b3db-44ec-803b-870359d5b5aa"), null, "Дом", false },
                    { new Guid("92ea86e1-f7d0-4c47-bc9f-a4915b57cfca"), null, "Детсткая площадка", false },
                    { new Guid("c21aac11-ddfb-49d1-9bf1-71f44cb2ba1d"), null, "Жилой комплекс", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryParameters_CategoryId",
                table: "CategoryParameters",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryParameters_ParameterId",
                table: "CategoryParameters",
                column: "ParameterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryParameters");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3607ebb5-8fbe-470c-a8c7-f67d441ddbe0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("38b48a67-a5de-4c49-a17d-5ee2dc860586"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59fd629b-edc1-472c-bf19-dc419ba31bcf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6955f376-e26f-46ab-aa2c-68842b9ec626"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d3e79d2-b3db-44ec-803b-870359d5b5aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92ea86e1-f7d0-4c47-bc9f-a4915b57cfca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c21aac11-ddfb-49d1-9bf1-71f44cb2ba1d"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Parameters",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MeasureUnitId",
                table: "Parameters",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Parameters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Parameters",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CategoryParameter",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uuid", nullable: false),
                    ParametersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryParameter", x => new { x.CategoriesId, x.ParametersId });
                    table.ForeignKey(
                        name: "FK_CategoryParameter_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryParameter_Parameters_ParametersId",
                        column: x => x.ParametersId,
                        principalTable: "Parameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeasureUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureUnits", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Parameters_MeasureUnitId",
                table: "Parameters",
                column: "MeasureUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryParameter_ParametersId",
                table: "CategoryParameter",
                column: "ParametersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parameters_MeasureUnits_MeasureUnitId",
                table: "Parameters",
                column: "MeasureUnitId",
                principalTable: "MeasureUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
