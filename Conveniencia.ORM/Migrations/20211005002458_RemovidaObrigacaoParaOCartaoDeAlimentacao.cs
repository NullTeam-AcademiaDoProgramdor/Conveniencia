using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Conveniencia.ORM.Migrations
{
    public partial class RemovidaObrigacaoParaOCartaoDeAlimentacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataMarcada",
                table: "TBProdutoMarcado",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 21, 24, 57, 951, DateTimeKind.Local).AddTicks(21),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2021, 10, 4, 21, 19, 27, 981, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.AlterColumn<string>(
                name: "CartaoAlimentacao",
                table: "TBCliente",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataMarcada",
                table: "TBProdutoMarcado",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 21, 19, 27, 981, DateTimeKind.Local).AddTicks(9067),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2021, 10, 4, 21, 24, 57, 951, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.AlterColumn<string>(
                name: "CartaoAlimentacao",
                table: "TBCliente",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
