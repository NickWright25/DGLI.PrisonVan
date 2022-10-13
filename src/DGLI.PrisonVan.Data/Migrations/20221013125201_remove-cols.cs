using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DGLI.PrisonVan.Data.Migrations
{
    public partial class removecols : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extension",
                table: "SoundFiles");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "SoundFiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "SoundFiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "SoundFiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
