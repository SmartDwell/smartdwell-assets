using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class FixModelsRelations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetCategoryParameters_Categories_CategoryId",
                table: "AssetCategoryParameters");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetCategoryParameters_Parameters_ParameterId",
                table: "AssetCategoryParameters");

            migrationBuilder.DropIndex(
                name: "IX_AssetCategoryParameters_CategoryId",
                table: "AssetCategoryParameters");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ddcaf35-e4dc-4537-9ac9-05f227f657e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e5bcb49-72f9-4170-a3cd-63403a26a22c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55695105-16cd-41db-a32c-3049133c5aa5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55c895fc-a8bc-4f47-9125-88076dad87fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98ea91df-29ea-4bdf-a9fc-1388cf7b1626"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7d8cb3a-0f45-454b-bc35-5730f376cc5b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d115b165-04c1-4fc7-8876-c58c8b71e6e6"));

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "AssetCategoryParameters");

            migrationBuilder.RenameColumn(
                name: "ParameterId",
                table: "AssetCategoryParameters",
                newName: "CategoryParameterId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetCategoryParameters_ParameterId",
                table: "AssetCategoryParameters",
                newName: "IX_AssetCategoryParameters_CategoryParameterId");

            migrationBuilder.CreateTable(
                name: "CategoryParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    ParameterId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    { new Guid("10f87ec1-1dea-417b-96b5-e587fb30be95"), null, "Игровая площадка", true },
                    { new Guid("4c29fda8-5a57-4604-9f9f-2c684445a92b"), null, "Подъезд", true },
                    { new Guid("6cdb706f-3320-492a-b103-ba1ee48b61a2"), null, "Квартира", true },
                    { new Guid("cff366a8-61c0-40bd-ba7a-0164547b29ba"), null, "Детсткая площадка", true },
                    { new Guid("e19518a5-797e-46b1-b8c1-f0cbe9e800fc"), null, "Жилой комплекс", true },
                    { new Guid("f7be5453-2cab-4638-aaf6-0a20102a77da"), null, "Дом", true },
                    { new Guid("fc52731f-dda1-47a5-98ea-fec15e25b4ce"), null, "Этаж", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryParameters_CategoryId",
                table: "CategoryParameters",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryParameters_ParameterId",
                table: "CategoryParameters",
                column: "ParameterId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetCategoryParameters_CategoryParameters_CategoryParamete~",
                table: "AssetCategoryParameters",
                column: "CategoryParameterId",
                principalTable: "CategoryParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetCategoryParameters_CategoryParameters_CategoryParamete~",
                table: "AssetCategoryParameters");

            migrationBuilder.DropTable(
                name: "CategoryParameters");

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

            migrationBuilder.RenameColumn(
                name: "CategoryParameterId",
                table: "AssetCategoryParameters",
                newName: "ParameterId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetCategoryParameters_CategoryParameterId",
                table: "AssetCategoryParameters",
                newName: "IX_AssetCategoryParameters_ParameterId");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "AssetCategoryParameters",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("3ddcaf35-e4dc-4537-9ac9-05f227f657e3"), null, "Этаж", true },
                    { new Guid("4e5bcb49-72f9-4170-a3cd-63403a26a22c"), null, "Дом", true },
                    { new Guid("55695105-16cd-41db-a32c-3049133c5aa5"), null, "Подъезд", true },
                    { new Guid("55c895fc-a8bc-4f47-9125-88076dad87fd"), null, "Детсткая площадка", true },
                    { new Guid("98ea91df-29ea-4bdf-a9fc-1388cf7b1626"), null, "Жилой комплекс", true },
                    { new Guid("c7d8cb3a-0f45-454b-bc35-5730f376cc5b"), null, "Игровая площадка", true },
                    { new Guid("d115b165-04c1-4fc7-8876-c58c8b71e6e6"), null, "Квартира", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetCategoryParameters_CategoryId",
                table: "AssetCategoryParameters",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetCategoryParameters_Categories_CategoryId",
                table: "AssetCategoryParameters",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetCategoryParameters_Parameters_ParameterId",
                table: "AssetCategoryParameters",
                column: "ParameterId",
                principalTable: "Parameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
