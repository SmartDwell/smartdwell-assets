using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Images = table.Column<Guid[]>(type: "uuid[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    UseForApi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TypeCode = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "AssetCategoryParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AssetId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryParameterId = table.Column<Guid>(type: "uuid", nullable: false),
                    TypeCode = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_AssetCategoryParameters_CategoryParameters_CategoryParamete~",
                        column: x => x.CategoryParameterId,
                        principalTable: "CategoryParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AssetCategoryParameters_AssetId",
                table: "AssetCategoryParameters",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetCategoryParameters_CategoryParameterId",
                table: "AssetCategoryParameters",
                column: "CategoryParameterId");

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
                name: "AssetCategoryParameters");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "CategoryParameters");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Parameters");
        }
    }
}
