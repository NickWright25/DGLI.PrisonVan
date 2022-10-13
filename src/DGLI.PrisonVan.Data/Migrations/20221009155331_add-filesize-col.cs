using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DGLI.PrisonVan.Data.Migrations
{
    public partial class addfilesizecol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "SoundFiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "SoundFiles");
        }
    }
}
