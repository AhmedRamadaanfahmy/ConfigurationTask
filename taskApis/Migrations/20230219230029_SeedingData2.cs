using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taskApis.Migrations
{
    public partial class SeedingData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MapSubTypes",
                columns: new[] { "Id", "MapTypeId", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Dynamic" },
                    { 2, 1, "Cached" },
                    { 3, 2, "Imagery" },
                    { 4, 2, "Topographic" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MapSubTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MapSubTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MapSubTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MapSubTypes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
