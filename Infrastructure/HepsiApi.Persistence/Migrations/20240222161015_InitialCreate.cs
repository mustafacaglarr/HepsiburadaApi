using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HepsiApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priorty = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(2771), false, "Outdoors, Automotive & Computers" },
                    { 2, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(2787), false, "Music, Electronics & Computers" },
                    { 3, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(2793), true, "Home" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priorty" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(6268), false, "Elektronik", 0, 1 },
                    { 2, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(6270), false, "Moda", 0, 2 },
                    { 3, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(6272), false, "Ev,Yaşam,Kırtasiye,Ofis", 0, 3 },
                    { 4, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(6273), false, "Oto,Bahçe,Yapı Market", 0, 4 },
                    { 5, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(6274), false, "Anne,Bebek,Oyuncak", 0, 5 },
                    { 6, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(6276), false, "Spor,OutDoor", 0, 6 },
                    { 7, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(6277), false, "Kozmetik,Kişisel Bakım", 0, 7 },
                    { 8, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(6278), false, "Süpermarket, Pet Shop", 0, 8 },
                    { 9, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(6280), false, "Kitap, Müziki,Film,Hobi", 0, 9 },
                    { 10, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(6281), false, "Bilgisayar", 1, 1 },
                    { 11, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(6282), false, "Kadın", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(7542), "IPS", false, "Ekran Panel Tipi" },
                    { 2, 10, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(7544), "Mika Gümüşü", false, "Renk" },
                    { 3, 10, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(7545), "GDDR6", true, "Ekran Kartı Bellek Tipi" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedDate", "Description", "Discount", "IsDeleted", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(8409), "Test", 10m, false, 1000m, "Test" },
                    { 2, 1, new DateTime(2024, 2, 22, 19, 10, 14, 864, DateTimeKind.Local).AddTicks(8475), "Tes1t", 10m, false, 1000m, "Test1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_CategoryId",
                table: "Details",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
