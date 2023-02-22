using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taskApis.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MapTypes",
                columns: new[] { "Id", "Value" },
                values: new object[] { 1, "Features" });

            migrationBuilder.InsertData(
                table: "MapTypes",
                columns: new[] { "Id", "Value" },
                values: new object[] { 2, "Basemap" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MapTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MapTypes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
