using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class dodavanjeagencije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TuristickeAgencije",
                columns: new[] { "TuristickaAgencijaID", "Naziv", "Telefon" },
                values: new object[] { 1, "Sabra", "068172121" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TuristickeAgencije",
                keyColumn: "TuristickaAgencijaID",
                keyValue: 1);
        }
    }
}
