using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzeriaOrder.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedHavspizzor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "MenuCategoryId", "Name", "Price", "SortOrder" },
                values: new object[,]
                {
                    { 12, "Skinka & tonfisk", null, true, 2, "Opera", 110m, 1 },
                    { 13, "Tonfisk & lök", null, true, 2, "Al Tonno", 110m, 2 },
                    { 14, "Räkor, musslor & tonfisk", null, true, 2, "Tredag", 120m, 3 },
                    { 15, "Crème fraiche, mozzarella, rödlök, kräftstjärtar & räkor", null, true, 2, "Sjölejon & Iggon Special", 150m, 4 },
                    { 16, "Scampi, räkor, kräftstjärtar & ruccola", null, true, 2, "Havets Läckerheter", 160m, 5 },
                    { 17, "Champinjoner, lök, tomat, ananas, feferoni, oliver, paprika & kronärtskocka", null, true, 2, "Vegetariska", 130m, 6 },
                    { 18, "Mozzarellaost, champinjoner, tomat & ruccolasallad", null, true, 2, "Mozzarella", 120m, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
