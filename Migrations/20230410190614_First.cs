using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RoboDeApostas.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Liga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partidas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeTimeDaCasa = table.Column<string>(type: "text", nullable: false),
                    NomeTimeVisitante = table.Column<string>(type: "text", nullable: false),
                    LinkDaPartida = table.Column<string>(type: "text", nullable: false),
                    Liga = table.Column<string>(type: "text", nullable: false),
                    ODD_Vitoria_TimeDaCasa = table.Column<float>(type: "real", nullable: false),
                    ODD_Vitoria_TimeVisitante = table.Column<float>(type: "real", nullable: false),
                    ODD_Empate_Ambos = table.Column<float>(type: "real", nullable: false),
                    ODD_VitoriaOuEmpate_TimeCasa = table.Column<float>(type: "real", nullable: false),
                    ODD_VitoriaOuEmpate_TimeVisitante = table.Column<float>(type: "real", nullable: false),
                    DataCompleta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NomeDaCasaDeAposta = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surebet2Casas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surebet2Casas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surebet3Casas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surebet3Casas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinkDaLiga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LigaId = table.Column<int>(type: "integer", nullable: false),
                    CasaDeAposta = table.Column<string>(type: "text", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: false)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkDaLiga");

            migrationBuilder.DropTable(
                name: "Partidas");

            migrationBuilder.DropTable(
                name: "Surebet2Casas");

            migrationBuilder.DropTable(
                name: "Surebet3Casas");

            migrationBuilder.DropTable(
                name: "Liga");
        }
    }
}
