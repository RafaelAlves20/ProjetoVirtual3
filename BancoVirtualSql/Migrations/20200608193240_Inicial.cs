using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BancoVirtualSql.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContasCorrentes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: true),
                    Agencia = table.Column<string>(nullable: true),
                    Conta = table.Column<string>(nullable: true),
                    Saldo = table.Column<double>(nullable: false),
                    Senha = table.Column<string>(nullable: true),
                    Situacao = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasCorrentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContasCorrentes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Extratos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContaId = table.Column<int>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Valor = table.Column<string>(nullable: true),
                    DataHora = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extratos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Extratos_ContasCorrentes_ContaId",
                        column: x => x.ContaId,
                        principalTable: "ContasCorrentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContasCorrentes_ClienteId",
                table: "ContasCorrentes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Extratos_ContaId",
                table: "Extratos",
                column: "ContaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Extratos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "ContasCorrentes");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
