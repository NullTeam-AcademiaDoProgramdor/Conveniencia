using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Conveniencia.ORM.Migrations
{
    public partial class AdicionadoTabelaProdutosMarcados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBProdutoMarcado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: true),
                    ProdutoId = table.Column<int>(type: "INTEGER", nullable: true),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    DataMarcada = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2021, 10, 4, 21, 19, 27, 981, DateTimeKind.Local).AddTicks(9067))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBProdutoMarcado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBProdutoMarcado_TBCliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TBCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBProdutoMarcado_TBProduto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "TBProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBProdutoMarcado_ClienteId",
                table: "TBProdutoMarcado",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TBProdutoMarcado_ProdutoId",
                table: "TBProdutoMarcado",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBProdutoMarcado");
        }
    }
}
