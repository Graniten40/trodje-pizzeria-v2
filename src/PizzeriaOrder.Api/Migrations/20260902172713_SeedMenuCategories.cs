using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzeriaOrder.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedMenuCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuCategories",
                columns: new[] { "Id", "IsActive", "Name", "RestaurantId", "SortOrder" },
                values: new object[,]
                {
                    { 1, true, "Skinkpizzor", 1, 1 },
                    { 2, true, "Havspizzor", 1, 2 },
                    { 3, true, "Köttfärspizzor", 1, 3 },
                    { 4, true, "Salami & Baconpizzor", 1, 4 },
                    { 5, true, "Ox-/Fläskfilépizzor", 1, 5 },
                    { 6, true, "Gorgonzolapizzor", 1, 6 },
                    { 7, true, "Mexikanska pizzor", 1, 7 },
                    { 8, true, "Kycklingpizzor", 1, 8 },
                    { 9, true, "Kebabpizzor", 1, 9 },
                    { 10, true, "Kebab / Kyckling / Falafel", 1, 10 },
                    { 11, true, "Kötträtter", 1, 11 },
                    { 12, true, "Grillrätter", 1, 12 },
                    { 13, true, "Fiskrätter", 1, 13 },
                    { 14, true, "Pastarätter", 1, 14 },
                    { 15, true, "Sallader", 1, 15 },
                    { 16, true, "Barnrätter", 1, 16 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
