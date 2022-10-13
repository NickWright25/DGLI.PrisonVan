using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DGLI.PrisonVan.Data.Migrations
{
    public partial class filechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "SoundFiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "SoundFiles",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extension",
                table: "SoundFiles");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "SoundFiles");
        }
    }
}
