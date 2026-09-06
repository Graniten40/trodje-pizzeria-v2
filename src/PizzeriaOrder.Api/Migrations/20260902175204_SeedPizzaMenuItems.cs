using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzeriaOrder.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedPizzaMenuItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "MenuCategoryId", "Name", "Price", "SortOrder" },
                values: new object[,]
                {
                    { 1, "Ost", null, true, 1, "Margherita", 100m, 1 },
                    { 2, "Skinka", null, true, 1, "Vesuvio", 100m, 2 },
                    { 3, "Skinka & ananas", null, true, 1, "Hawaii", 110m, 3 },
                    { 4, "Skinka & färska champinjoner", null, true, 1, "Capricciosa", 110m, 4 },
                    { 5, "Skinka & räkor", null, true, 1, "Bussola", 110m, 5 },
                    { 6, "Inbakad. Skinka", null, true, 1, "Calzone", 110m, 6 },
                    { 7, "Skinka, ananas, banan & curry", null, true, 1, "Florida", 120m, 7 },
                    { 8, "Skinka, räkor & färska champinjoner", null, true, 1, "Bella", 120m, 8 },
                    { 9, "Skinka, räkor, musslor, oliver, färska champinjoner & kronärtskocka", null, true, 1, "Quattro Stagioni", 125m, 9 },
                    { 10, "Inbakad. Skinka, räkor & färska champinjoner", null, true, 1, "Calzone Special", 120m, 10 },
                    { 11, "Dubbel deg. Skinka, räkor & färska champinjoner", null, true, 1, "Dubbel Calzone", 130m, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
