using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BancoVirtualSql.Conexao;

namespace BancoVirtualSql.Migrations
{
    [DbContext(typeof(BancoVirtualContext))]
    [Migration("20200608193240_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BancoVirtualSql.Repositorio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("Sobrenome");

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("BancoVirtualSql.Repositorio.ContaCorrente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Agencia");

                    b.Property<int?>("ClienteId");

                    b.Property<string>("Conta");

                    b.Property<double>("Saldo");

                    b.Property<string>("Senha");

                    b.Property<bool>("Situacao");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("ContasCorrentes");
                });

            modelBuilder.Entity("BancoVirtualSql.Repositorio.Extrato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContaId");

                    b.Property<string>("Tipo");

                    b.Property<string>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.ToTable("Extratos");
                });

            modelBuilder.Entity("BancoVirtualSql.Repositorio.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BancoVirtualSql.Repositorio.ContaCorrente", b =>
                {
                    b.HasOne("BancoVirtualSql.Repositorio.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("BancoVirtualSql.Repositorio.Extrato", b =>
                {
                    b.HasOne("BancoVirtualSql.Repositorio.ContaCorrente", "Conta")
                        .WithMany()
                        .HasForeignKey("ContaId");
                });
        }
    }
}
