using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShopApp.Migrations
{
    public partial class TabelaAnimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PrecoVenda",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<double>(
                name: "PrecoCompra",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    DtNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Raca = table.Column<string>(type: "TEXT", nullable: true),
                    Porte = table.Column<string>(type: "TEXT", nullable: true),
                    Sexo = table.Column<string>(type: "TEXT", nullable: true),
                    Especie = table.Column<string>(type: "TEXT", nullable: true),
                    ProprietarioID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.AlterColumn<double>(
                name: "PrecoVenda",
                table: "Produto",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "PrecoCompra",
                table: "Produto",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "decimal(18,2)");
        }
    }
}
