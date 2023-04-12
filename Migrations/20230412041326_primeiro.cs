using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoboDeApostas.Migrations
{
    /// <inheritdoc />
    public partial class primeiro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Liga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partidas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeTimeDaCasa = table.Column<string>(type: "TEXT", nullable: false),
                    NomeTimeVisitante = table.Column<string>(type: "TEXT", nullable: false),
                    LinkDaPartida = table.Column<string>(type: "TEXT", nullable: false),
                    Liga = table.Column<string>(type: "TEXT", nullable: false),
                    ODD_Vitoria_TimeDaCasa = table.Column<double>(type: "REAL", nullable: false),
                    ODD_Vitoria_TimeVisitante = table.Column<double>(type: "REAL", nullable: false),
                    ODD_Empate_Ambos = table.Column<double>(type: "REAL", nullable: false),
                    ODD_VitoriaOuEmpate_TimeCasa = table.Column<double>(type: "REAL", nullable: false),
                    ODD_VitoriaOuEmpate_TimeVisitante = table.Column<double>(type: "REAL", nullable: false),
                    DataCompleta = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    NomeDaCasaDeAposta = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinkDaLiga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LigaId = table.Column<int>(type: "INTEGER", nullable: false),
                    CasaDeAposta = table.Column<string>(type: "TEXT", nullable: false),
                    Link = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkDaLiga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinkDaLiga_Liga_LigaId",
                        column: x => x.LigaId,
                        principalTable: "Liga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Surebet2Casas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PartidaDaCasa1Id = table.Column<int>(type: "INTEGER", nullable: false),
                    PartidaDaCasa2Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Data = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Prob1 = table.Column<double>(type: "REAL", nullable: false),
                    Prob2 = table.Column<double>(type: "REAL", nullable: false),
                    Prob3 = table.Column<double>(type: "REAL", nullable: false),
                    Prob4 = table.Column<double>(type: "REAL", nullable: false),
                    Lucro = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surebet2Casas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Surebet2Casas_Partidas_PartidaDaCasa1Id",
                        column: x => x.PartidaDaCasa1Id,
                        principalTable: "Partidas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Surebet2Casas_Partidas_PartidaDaCasa2Id",
                        column: x => x.PartidaDaCasa2Id,
                        principalTable: "Partidas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Surebet3Casas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PartidaDaCasa1Id = table.Column<int>(type: "INTEGER", nullable: false),
                    PartidaDaCasa2Id = table.Column<int>(type: "INTEGER", nullable: false),
                    PartidaDaCasa3Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Data = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Prob1 = table.Column<double>(type: "REAL", nullable: false),
                    Prob2 = table.Column<double>(type: "REAL", nullable: false),
                    Prob3 = table.Column<double>(type: "REAL", nullable: false),
                    Prob4 = table.Column<double>(type: "REAL", nullable: false),
                    Prob5 = table.Column<double>(type: "REAL", nullable: false),
                    Prob6 = table.Column<double>(type: "REAL", nullable: false),
                    Lucro = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surebet3Casas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Surebet3Casas_Partidas_PartidaDaCasa1Id",
                        column: x => x.PartidaDaCasa1Id,
                        principalTable: "Partidas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Surebet3Casas_Partidas_PartidaDaCasa2Id",
                        column: x => x.PartidaDaCasa2Id,
                        principalTable: "Partidas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Surebet3Casas_Partidas_PartidaDaCasa3Id",
                        column: x => x.PartidaDaCasa3Id,
                        principalTable: "Partidas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Liga_Nome",
                table: "Liga",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LinkDaLiga_LigaId",
                table: "LinkDaLiga",
                column: "LigaId");

            migrationBuilder.CreateIndex(
                name: "IX_LinkDaLiga_Link",
                table: "LinkDaLiga",
                column: "Link",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Surebet2Casas_PartidaDaCasa1Id",
                table: "Surebet2Casas",
                column: "PartidaDaCasa1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Surebet2Casas_PartidaDaCasa2Id",
                table: "Surebet2Casas",
                column: "PartidaDaCasa2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Surebet3Casas_PartidaDaCasa1Id",
                table: "Surebet3Casas",
                column: "PartidaDaCasa1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Surebet3Casas_PartidaDaCasa2Id",
                table: "Surebet3Casas",
                column: "PartidaDaCasa2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Surebet3Casas_PartidaDaCasa3Id",
                table: "Surebet3Casas",
                column: "PartidaDaCasa3Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkDaLiga");

            migrationBuilder.DropTable(
                name: "Surebet2Casas");

            migrationBuilder.DropTable(
                name: "Surebet3Casas");

            migrationBuilder.DropTable(
                name: "Liga");

            migrationBuilder.DropTable(
                name: "Partidas");
        }
    }
}
