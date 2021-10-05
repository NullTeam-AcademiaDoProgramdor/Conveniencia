using Microsoft.EntityFrameworkCore.Migrations;

namespace Conveniencia.ORM.Migrations
{
    public partial class AdicionadoCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Cpf = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Endereço = table.Column<string>(type: "VARCHAR(500)", nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(1000)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(500)", nullable: false),
                    LimiteCredito = table.Column<double>(type: "REAL", nullable: false),
                    CartaoAlimentacao = table.Column<string>(type: "VARCHAR(500)", nullable: false),
                    SaldoDevedor = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCliente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBCliente");
        }
    }
}
