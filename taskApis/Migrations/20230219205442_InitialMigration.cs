using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taskApis.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "MapSubTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapSubTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MapTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClusterRadius = table.Column<int>(type: "int", nullable: true),
                    GeoFencing = table.Column<bool>(type: "bit", nullable: false),
                    TimeBuffer = table.Column<int>(type: "int", nullable: true),
                    LocationBuffer = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    MapTypeId = table.Column<int>(type: "int", nullable: true),
                    MapSubTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Configurations_MapSubTypes_MapSubTypeId",
                        column: x => x.MapSubTypeId,
                        principalTable: "MapSubTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_MapTypes_MapTypeId",
                        column: x => x.MapTypeId,
                        principalTable: "MapTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_MapSubTypeId",
                table: "Configurations",
                column: "MapSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_MapTypeId",
                table: "Configurations",
                column: "MapTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "MapSettings");

            migrationBuilder.DropTable(
                name: "MapSubTypes");

            migrationBuilder.DropTable(
                name: "MapTypes");
        }
    }
}
