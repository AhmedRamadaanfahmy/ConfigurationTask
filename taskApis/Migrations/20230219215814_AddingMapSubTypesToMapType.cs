using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taskApis.Migrations
{
    public partial class AddingMapSubTypesToMapType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MapTypeId",
                table: "MapSubTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MapSubTypes_MapTypeId",
                table: "MapSubTypes",
                column: "MapTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MapSubTypes_MapTypes_MapTypeId",
                table: "MapSubTypes",
                column: "MapTypeId",
                principalTable: "MapTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MapSubTypes_MapTypes_MapTypeId",
                table: "MapSubTypes");

            migrationBuilder.DropIndex(
                name: "IX_MapSubTypes_MapTypeId",
                table: "MapSubTypes");

            migrationBuilder.DropColumn(
                name: "MapTypeId",
                table: "MapSubTypes");
        }
    }
}
