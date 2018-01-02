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
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<int>("EstadoID");

                    b.Property<int>("TrilhoID");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.HasKey("EstadoID", "TrilhoID");

                    b.HasIndex("TrilhoID");

                    b.ToTable("EstadoTrilhos");
                });

            modelBuilder.Entity("Trails4Health.Models.QuestaoAvaliacaoTrilho", b =>
                {
                    b.Property<int>("TipoRespostaID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Desactivada");

                    b.Property<string>("NomeQuestao");

                    b.Property<int>("QuestaoID");

                    b.Property<int?>("TipoRespostaID1");

                    b.HasKey("TipoRespostaID");

                    b.HasIndex("TipoRespostaID1");

                    b.ToTable("QuestaoAvaliacaoTrilho");
                });

            modelBuilder.Entity("Trails4Health.Models.QuestaoAvalicaoGuia", b =>
                {
                    b.Property<int>("TipoRespostaID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Desactivada");

                    b.Property<string>("NomeQuestao");

                    b.Property<int>("QuestaoID");

                    b.Property<int?>("TipoRespostaID1");

                    b.HasKey("TipoRespostaID");

                    b.HasIndex("TipoRespostaID1");

                    b.ToTable("QuestaoAvaliacaoGuia");
                });

            modelBuilder.Entity("Trails4Health.Models.TipoResposta", b =>
                {
                    b.Property<int>("TipoRespostaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("TipoRespostaID");

                    b.ToTable("TipoResposta");
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

                    b.Property<string>("Foto")
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

            modelBuilder.Entity("Trails4Health.Models.QuestaoAvaliacaoTrilho", b =>
                {
                    b.HasOne("Trails4Health.Models.TipoResposta")
                        .WithMany("QuestoesAvaliacaoTrilhos")
                        .HasForeignKey("TipoRespostaID1");
                });

            modelBuilder.Entity("Trails4Health.Models.QuestaoAvalicaoGuia", b =>
                {
                    b.HasOne("Trails4Health.Models.TipoResposta")
                        .WithMany("QuestoesAvalicaoGuias")
                        .HasForeignKey("TipoRespostaID1");
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
