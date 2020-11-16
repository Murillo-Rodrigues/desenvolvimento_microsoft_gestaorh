﻿// <auto-generated />
using System;
using GestaoRHWPF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestaoRHWPF.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201005231054_attBancoDefesa")]
    partial class attBancoDefesa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestaoRHWPF.Models.Caixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Custodia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCaixa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Caixas");
                });

            modelBuilder.Entity("GestaoRHWPF.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Matricula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcionários");
                });

            modelBuilder.Entity("GestaoRHWPF.Models.ItemSolicitacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProntuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("SolicitacaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProntuarioId");

                    b.HasIndex("SolicitacaoId");

                    b.ToTable("ItensSolicitacao");
                });

            modelBuilder.Entity("GestaoRHWPF.Models.Prontuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CaixaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FuncionarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CaixaId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Prontuarios");
                });

            modelBuilder.Entity("GestaoRHWPF.Models.Solicitacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CaixaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FuncionarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CaixaId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Solicitacoes");
                });

            modelBuilder.Entity("GestaoRHWPF.Models.ItemSolicitacao", b =>
                {
                    b.HasOne("GestaoRHWPF.Models.Prontuario", "Prontuario")
                        .WithMany()
                        .HasForeignKey("ProntuarioId");

                    b.HasOne("GestaoRHWPF.Models.Solicitacao", null)
                        .WithMany("Itens")
                        .HasForeignKey("SolicitacaoId");
                });

            modelBuilder.Entity("GestaoRHWPF.Models.Prontuario", b =>
                {
                    b.HasOne("GestaoRHWPF.Models.Caixa", "Caixa")
                        .WithMany()
                        .HasForeignKey("CaixaId");

                    b.HasOne("GestaoRHWPF.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");
                });

            modelBuilder.Entity("GestaoRHWPF.Models.Solicitacao", b =>
                {
                    b.HasOne("GestaoRHWPF.Models.Caixa", "Caixa")
                        .WithMany()
                        .HasForeignKey("CaixaId");

                    b.HasOne("GestaoRHWPF.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
