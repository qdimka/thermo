using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thermo.Web.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TemperatureSensors",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeviceName = table.Column<string>(nullable: true),
                    ChipId = table.Column<long>(nullable: false),
                    Temperature = table.Column<float>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemperatureSensors", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemperatureSensors");
        }
    }
}
