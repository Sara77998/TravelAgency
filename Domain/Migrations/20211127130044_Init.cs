using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gosti",
                columns: table => new
                {
                    GostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pasos = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gosti", x => x.GostID);
                });

            migrationBuilder.CreateTable(
                name: "Hoteli",
                columns: table => new
                {
                    HotelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zemlja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojZvezdinca = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoteli", x => x.HotelID);
                });

            migrationBuilder.CreateTable(
                name: "TuristickeAgencije",
                columns: table => new
                {
                    TuristickaAgencijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuristickeAgencije", x => x.TuristickaAgencijaID);
                });

            migrationBuilder.CreateTable(
                name: "Sobe",
                columns: table => new
                {
                    SobaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelID = table.Column<int>(type: "int", nullable: false),
                    BrojSobe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipSobe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zauzeta = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sobe", x => x.SobaID);
                    table.ForeignKey(
                        name: "FK_Sobe_Hoteli_HotelID",
                        column: x => x.HotelID,
                        principalTable: "Hoteli",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agenti",
                columns: table => new
                {
                    AgentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuristickaAgencijaID = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenti", x => x.AgentID);
                    table.ForeignKey(
                        name: "FK_Agenti_TuristickeAgencije_TuristickaAgencijaID",
                        column: x => x.TuristickaAgencijaID,
                        principalTable: "TuristickeAgencije",
                        principalColumn: "TuristickaAgencijaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentID = table.Column<int>(type: "int", nullable: false),
                    SobaID = table.Column<int>(type: "int", nullable: false),
                    DatumOd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumDo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.RezervacijaID);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Agenti_AgentID",
                        column: x => x.AgentID,
                        principalTable: "Agenti",
                        principalColumn: "AgentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Sobe_SobaID",
                        column: x => x.SobaID,
                        principalTable: "Sobe",
                        principalColumn: "SobaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkeRezervacije",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(type: "int", nullable: false),
                    RB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StavkaRezervacijeID = table.Column<int>(type: "int", nullable: false),
                    GostID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeRezervacije", x => new { x.RB, x.RezervacijaID });
                    table.ForeignKey(
                        name: "FK_StavkeRezervacije_Gosti_GostID",
                        column: x => x.GostID,
                        principalTable: "Gosti",
                        principalColumn: "GostID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkeRezervacije_Rezervacije_RezervacijaID",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TuristickeAgencije",
                columns: new[] { "TuristickaAgencijaID", "Naziv", "Telefon" },
                values: new object[] { 1, "Sabra", "068172121" });

            migrationBuilder.CreateIndex(
                name: "IX_Agenti_TuristickaAgencijaID",
                table: "Agenti",
                column: "TuristickaAgencijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_AgentID",
                table: "Rezervacije",
                column: "AgentID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_SobaID",
                table: "Rezervacije",
                column: "SobaID");

            migrationBuilder.CreateIndex(
                name: "IX_Sobe_HotelID",
                table: "Sobe",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeRezervacije_GostID",
                table: "StavkeRezervacije",
                column: "GostID");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeRezervacije_RezervacijaID",
                table: "StavkeRezervacije",
                column: "RezervacijaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StavkeRezervacije");

            migrationBuilder.DropTable(
                name: "Gosti");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "Agenti");

            migrationBuilder.DropTable(
                name: "Sobe");

            migrationBuilder.DropTable(
                name: "TuristickeAgencije");

            migrationBuilder.DropTable(
                name: "Hoteli");
        }
    }
}
