using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoRHWPF.Migrations
{
    public partial class AdicionarTabelaCaixa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caixas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    NumeroCaixa = table.Column<string>(nullable: true),
                    PosicaoCorredor = table.Column<string>(nullable: true),
                    PosicaoEstante = table.Column<string>(nullable: true),
                    PosicaoAltura = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caixas");
        }
    }
}
