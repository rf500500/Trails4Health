﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Trails4Health.Models;

namespace Trails4Health.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180114105252_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Trails4Health.Models.AvaliacaoGuia", b =>
                {
                    b.Property<int>("AvaliacaoGuiaID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Avaliacao");

                    b.Property<int>("GuiaID");

                    b.Property<int>("NumeroAvaliacoes");

                    b.HasKey("AvaliacaoGuiaID");

                    b.HasIndex("GuiaID");

                    b.ToTable("AvaliacaoGuias");
                });

            modelBuilder.Entity("Trails4Health.Models.AvaliacaoTrilho", b =>
                {
                    b.Property<int>("AvaliacaoTrilhoID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Avaliacao");

                    b.Property<int>("NumeroAvaliacoes");

                    b.Property<int>("TrilhoID");

                    b.HasKey("AvaliacaoTrilhoID");

                    b.HasIndex("TrilhoID");

                    b.ToTable("AvaliacaoTrilhos");
                });

            modelBuilder.Entity("Trails4Health.Models.Dificuldade", b =>
                {
                    b.Property<int>("DificuldadeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Observacao");

                    b.HasKey("DificuldadeID");

                    b.ToTable("Dificuldades");
                });

            modelBuilder.Entity("Trails4Health.Models.Estado", b =>
                {
                    b.Property<int>("EstadoID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("EstadoID");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Trails4Health.Models.EstadoTrilho", b =>
                {
                    b.Property<int>("EstadoTrilhoID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DataFim");

                    b.Property<DateTime?>("DataInicio");

                    b.Property<int>("EstadoID");

                    b.Property<int>("TrilhoID");

                    b.HasKey("EstadoTrilhoID");

                    b.HasIndex("EstadoID");

                    b.HasIndex("TrilhoID");

                    b.ToTable("EstadoTrilhos");
                });

            modelBuilder.Entity("Trails4Health.Models.Guia", b =>
                {
                    b.Property<int>("GuiaID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("GuiaID");

                    b.ToTable("Guias");
                });

            modelBuilder.Entity("Trails4Health.Models.Opcao", b =>
                {
                    b.Property<int>("OpcaoID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QuestaoID");

                    b.HasKey("OpcaoID");

                    b.HasIndex("QuestaoID");

                    b.ToTable("Opcoes");
                });

            modelBuilder.Entity("Trails4Health.Models.Questao", b =>
                {
                    b.Property<int>("QuestaoID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Desactivada");

                    b.Property<string>("NomeQuestao");

                    b.Property<int>("NumeroOpcoes");

                    b.Property<int>("TipoQuestaoID");

                    b.Property<string>("TipoResposta");

                    b.Property<int>("ValorMaximo");

                    b.Property<int>("ValorMinimo");

                    b.HasKey("QuestaoID");

                    b.HasIndex("TipoQuestaoID");

                    b.ToTable("Questoes");
                });

            modelBuilder.Entity("Trails4Health.Models.Questionario", b =>
                {
                    b.Property<int>("QuestionarioID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataRespostas");

                    b.HasKey("QuestionarioID");

                    b.ToTable("Questionarios");
                });

            modelBuilder.Entity("Trails4Health.Models.QuestionarioQuestao", b =>
                {
                    b.Property<int>("QuestionarioID");

                    b.Property<int>("QuestaoID");

                    b.HasKey("QuestionarioID", "QuestaoID");

                    b.HasIndex("QuestaoID");

                    b.ToTable("QuestionarioQuestoes");
                });

            modelBuilder.Entity("Trails4Health.Models.Resposta", b =>
                {
                    b.Property<int>("OpcaoID");

                    b.Property<int>("TuristaID");

                    b.HasKey("OpcaoID", "TuristaID");

                    b.HasIndex("TuristaID");

                    b.ToTable("Respostas");
                });

            modelBuilder.Entity("Trails4Health.Models.TipoQuestao", b =>
                {
                    b.Property<int>("TipoQuestaoID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("TipoQuestaoID");

                    b.ToTable("TipoQuestoes");
                });

            modelBuilder.Entity("Trails4Health.Models.Trilho", b =>
                {
                    b.Property<int>("TrilhoID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Desativado");

                    b.Property<string>("Detalhes")
                        .IsRequired()
                        .HasMaxLength(700);

                    b.Property<int>("DificuldadeID");

                    b.Property<decimal>("Distancia");

                    b.Property<string>("Fim")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<byte[]>("ImagemTrilho")
                        .IsRequired();

                    b.Property<string>("Inicio")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sumario")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("TrilhoID");

                    b.HasIndex("DificuldadeID");

                    b.ToTable("Trilhos");
                });

            modelBuilder.Entity("Trails4Health.Models.Turista", b =>
                {
                    b.Property<int>("TuristaID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Morada");

                    b.Property<int>("Nif");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("TuristaID");

                    b.ToTable("Turistas");
                });

            modelBuilder.Entity("Trails4Health.Models.AvaliacaoGuia", b =>
                {
                    b.HasOne("Trails4Health.Models.Guia", "Guia")
                        .WithMany("AvaliacaoGuias")
                        .HasForeignKey("GuiaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trails4Health.Models.AvaliacaoTrilho", b =>
                {
                    b.HasOne("Trails4Health.Models.Trilho", "Trilho")
                        .WithMany()
                        .HasForeignKey("TrilhoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trails4Health.Models.EstadoTrilho", b =>
                {
                    b.HasOne("Trails4Health.Models.Estado", "Estado")
                        .WithMany("EstadoTrilhos")
                        .HasForeignKey("EstadoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Trails4Health.Models.Trilho", "Trilho")
                        .WithMany("EstadoTrilhos")
                        .HasForeignKey("TrilhoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trails4Health.Models.Opcao", b =>
                {
                    b.HasOne("Trails4Health.Models.Questao", "Questao")
                        .WithMany("Opcoes")
                        .HasForeignKey("QuestaoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trails4Health.Models.Questao", b =>
                {
                    b.HasOne("Trails4Health.Models.TipoQuestao", "TipoQuestao")
                        .WithMany("Questoes")
                        .HasForeignKey("TipoQuestaoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trails4Health.Models.QuestionarioQuestao", b =>
                {
                    b.HasOne("Trails4Health.Models.Questao", "Questao")
                        .WithMany("QuestionarioQuestoes")
                        .HasForeignKey("QuestaoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Trails4Health.Models.Questionario", "Questionario")
                        .WithMany("QuestionarioQuestoes")
                        .HasForeignKey("QuestionarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trails4Health.Models.Resposta", b =>
                {
                    b.HasOne("Trails4Health.Models.Opcao", "Opcao")
                        .WithMany("Respostas")
                        .HasForeignKey("OpcaoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Trails4Health.Models.Turista", "Turista")
                        .WithMany("Respostas")
                        .HasForeignKey("TuristaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trails4Health.Models.Trilho", b =>
                {
                    b.HasOne("Trails4Health.Models.Dificuldade", "Dificuldade")
                        .WithMany("Trilhos")
                        .HasForeignKey("DificuldadeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
