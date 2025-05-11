using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ikea.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductColours",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ColourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColours", x => new { x.ProductId, x.ColourId });
                    table.ForeignKey(
                        name: "FK_ProductColours_Colours_ColourId",
                        column: x => x.ColourId,
                        principalTable: "Colours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductColours_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Black" },
                    { 2, "White" },
                    { 3, "Brown" },
                    { 4, "Blue" },
                    { 5, "Red" },
                    { 6, "Green" },
                    { 7, "Yellow" },
                    { 8, "Orange" },
                    { 9, "Purple" },
                    { 10, "Pink" },
                    { 11, "Gray" },
                    { 12, "Silver" },
                    { 13, "Gold" },
                    { 14, "Beige" },
                    { 15, "Turquoise" },
                    { 16, "Teal" },
                    { 17, "Navy" },
                    { 18, "Maroon" },
                    { 19, "Olive" },
                    { 20, "Mint" },
                    { 21, "Coral" },
                    { 22, "Indigo" },
                    { 23, "Magenta" },
                    { 24, "Violet" },
                    { 25, "Cyan" },
                    { 26, "Burgundy" },
                    { 27, "Lavender" },
                    { 28, "Cream" },
                    { 29, "Salmon" },
                    { 30, "Charcoal" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chair" },
                    { 2, "Table" },
                    { 3, "Bed" },
                    { 4, "Sofa" },
                    { 5, "Bookshelf" },
                    { 6, "Desk" },
                    { 7, "Wardrobe" },
                    { 8, "Dresser" },
                    { 9, "TV Stand" },
                    { 10, "Coffee Table" },
                    { 11, "Dining Set" },
                    { 12, "Nightstand" },
                    { 13, "Armchair" },
                    { 14, "Kitchen Cabinet" },
                    { 15, "Bathroom Vanity" },
                    { 16, "Storage Unit" },
                    { 17, "Lamp" },
                    { 18, "Rug" },
                    { 19, "Mirror" },
                    { 20, "Picture Frame" },
                    { 21, "Plant Pot" },
                    { 22, "Curtains" },
                    { 23, "Pillow" },
                    { 24, "Blanket" },
                    { 25, "Mattress" },
                    { 26, "Office Chair" },
                    { 27, "Shelf Unit" },
                    { 28, "Side Table" },
                    { 29, "Dining Chair" },
                    { 30, "Stool" },
                    { 31, "Room Divider" },
                    { 32, "Wall Shelf" },
                    { 33, "Kitchen Island" },
                    { 34, "Bar Stool" },
                    { 35, "Daybed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductColours_ColourId",
                table: "ProductColours",
                column: "ColourId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductColours");

            migrationBuilder.DropTable(
                name: "Colours");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductTypes");
        }
    }
}
