using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FaultTracker.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Faults",
                columns: new[] { "Id", "Description", "ReportedAt", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "Sudden power failure in district 3", new DateTime(2025, 6, 22, 16, 0, 0, 0, DateTimeKind.Utc), "Open", "Power outage" },
                    { 2, "Load exceeded threshold during peak hours", new DateTime(2025, 6, 22, 19, 0, 0, 0, DateTimeKind.Utc), "Investigating", "System overload" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faults",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Faults",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
