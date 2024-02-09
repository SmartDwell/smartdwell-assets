using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class FixModelsRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetCategory");

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

            migrationBuilder.CreateTable(
                name: "AssetCategoryParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AssetId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    ParameterId = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetCategoryParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetCategoryParameters_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetCategoryParameters_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetCategoryParameters_Parameters_ParameterId",
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
                    { new Guid("3ddcaf35-e4dc-4537-9ac9-05f227f657e3"), null, "Этаж", true },
                    { new Guid("4e5bcb49-72f9-4170-a3cd-63403a26a22c"), null, "Дом", true },
                    { new Guid("55695105-16cd-41db-a32c-3049133c5aa5"), null, "Подъезд", true },
                    { new Guid("55c895fc-a8bc-4f47-9125-88076dad87fd"), null, "Детсткая площадка", true },
                    { new Guid("98ea91df-29ea-4bdf-a9fc-1388cf7b1626"), null, "Жилой комплекс", true },
                    { new Guid("c7d8cb3a-0f45-454b-bc35-5730f376cc5b"), null, "Игровая площадка", true },
                    { new Guid("d115b165-04c1-4fc7-8876-c58c8b71e6e6"), null, "Квартира", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetCategoryParameters_AssetId",
                table: "AssetCategoryParameters",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetCategoryParameters_CategoryId",
                table: "AssetCategoryParameters",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetCategoryParameters_ParameterId",
                table: "AssetCategoryParameters",
                column: "ParameterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetCategoryParameters");

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

            migrationBuilder.CreateTable(
                name: "AssetCategory",
                columns: table => new
                {
                    AssetsId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoriesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetCategory", x => new { x.AssetsId, x.CategoriesId });
                    table.ForeignKey(
                        name: "FK_AssetCategory_Assets_AssetsId",
                        column: x => x.AssetsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetCategory_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_AssetCategory_CategoriesId",
                table: "AssetCategory",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryParameters_CategoryId",
                table: "CategoryParameters",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryParameters_ParameterId",
                table: "CategoryParameters",
                column: "ParameterId");
        }
    }
}
