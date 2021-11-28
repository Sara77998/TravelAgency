using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class dodatakolonagrad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Grad",
                table: "Hoteli",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grad",
                table: "Hoteli");
        }
    }
}
