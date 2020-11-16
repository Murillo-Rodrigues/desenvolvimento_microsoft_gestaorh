using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoRHWPF.Migrations
{
    public partial class attBancoDefesa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Funcionários",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Funcionários");
        }
    }
}
