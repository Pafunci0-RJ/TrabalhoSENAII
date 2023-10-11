using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Perfumes.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbCategorias",
                columns: table => new
                {
                    CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCategorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "tbClientes",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbClientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "tbCompras",
                columns: table => new
                {
                    CompraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    Horario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Produto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCompras", x => x.CompraId);
                });

            migrationBuilder.CreateTable(
                name: "tbProdutos",
                columns: table => new
                {
                    ProdutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estoque = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProdutos", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_tbProdutos_tbCategorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "tbCategorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbVendas",
                columns: table => new
                {
                    VendaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    Horario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Produto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbVendas", x => x.VendaId);
                    table.ForeignKey(
                        name: "FK_tbVendas_tbClientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "tbClientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbProdutos_CategoriaId",
                table: "tbProdutos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_tbVendas_ClienteId",
                table: "tbVendas",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbCompras");

            migrationBuilder.DropTable(
                name: "tbProdutos");

            migrationBuilder.DropTable(
                name: "tbVendas");

            migrationBuilder.DropTable(
                name: "tbCategorias");

            migrationBuilder.DropTable(
                name: "tbClientes");
        }
    }
}
