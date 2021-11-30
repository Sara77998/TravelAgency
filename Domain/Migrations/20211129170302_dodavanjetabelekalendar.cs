using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class dodavanjetabelekalendar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kalendar",
                columns: table => new
                {
                    KalendarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dogadjaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detalji = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pocetak = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kraj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Boja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CeoDan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kalendar", x => x.KalendarID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kalendar");
        }
    }
}
