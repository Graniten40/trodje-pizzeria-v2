using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzeriaOrder.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedTrodjeRestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "City", "CreatedAtUtc", "Email", "IsActive", "Name", "Phone", "PostalCode" },
                values: new object[] { 1, "Tittmyrvägen 1", "Gävle", new DateTime(2026, 9, 2, 0, 0, 0, 0, DateTimeKind.Utc), null, true, "Trödje Pizzeria", "026-16 14 11", "805 96" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
