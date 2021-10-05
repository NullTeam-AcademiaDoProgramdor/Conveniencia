using Microsoft.EntityFrameworkCore.Migrations;

namespace Conveniencia.ORM.Migrations
{
    public partial class AdicionadoValoresPadroesParaOsDoubles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SaldoDevedor",
                table: "TBCliente",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<double>(
                name: "LimiteCredito",
                table: "TBCliente",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "REAL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SaldoDevedor",
                table: "TBCliente",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<double>(
                name: "LimiteCredito",
                table: "TBCliente",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldDefaultValue: 0.0);
        }
    }
}
