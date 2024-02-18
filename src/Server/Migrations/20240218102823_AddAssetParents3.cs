using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class AddAssetParents3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ParentsIds",
                table: "Assets");

            migrationBuilder.CreateTable(
                name: "AssetParents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AssetId = table.Column<Guid>(type: "uuid", nullable: false),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetParents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetParents_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetParents_Assets_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UseForApi" },
                values: new object[,]
                {
                    { new Guid("149cde0b-b241-48ee-ad36-940697ce34ed"), null, "Этаж", true },
                    { new Guid("208165e7-f38f-4050-b010-5db412ce6003"), null, "Детсткая площадка", true },
                    { new Guid("216acd02-e1d3-48d6-a489-40f122999796"), null, "Квартира", true },
                    { new Guid("4c2f5845-5d02-468d-b7c8-f22b5786a708"), null, "Подъезд", true },
                    { new Guid("7013e0ab-b7b6-4a3c-af25-2906149fe305"), null, "Жилой комплекс", true },
                    { new Guid("81e2fe41-b81d-42f2-9b43-5e2cbd7b136a"), null, "Дом", true },
                    { new Guid("bc7ddb66-b4b2-425b-9b3e-e08eca32036a"), null, "Игровая площадка", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetParents_AssetId",
                table: "AssetParents",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetParents_ParentId",
                table: "AssetParents",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetParents");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("149cde0b-b241-48ee-ad36-940697ce34ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("208165e7-f38f-4050-b010-5db412ce6003"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("216acd02-e1d3-48d6-a489-40f122999796"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c2f5845-5d02-468d-b7c8-f22b5786a708"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7013e0ab-b7b6-4a3c-af25-2906149fe305"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81e2fe41-b81d-42f2-9b43-5e2cbd7b136a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc7ddb66-b4b2-425b-9b3e-e08eca32036a"));

            migrationBuilder.AddColumn<List<Guid>>(
                name: "ParentsIds",
                table: "Assets",
                type: "uuid[]",
                nullable: false);

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
    }
}
