using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DGLI.PrisonVan.Data.Migrations
{
    public partial class removeisactive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "SoundFiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "SoundFiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
