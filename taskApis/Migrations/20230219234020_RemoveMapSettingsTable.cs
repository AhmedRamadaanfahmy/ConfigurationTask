using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taskApis.Migrations
{
    public partial class RemoveMapSettingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MapSettings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MapSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClusterRadios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeoFencing = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapSettings", x => x.Id);
                });
        }
    }
}
