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

            modelBuilder.Entity("Trails4Health.Models.Questao", b =>
                {
                    b.Property<int>("TipoQuestaoID");

                    b.Property<int>("TipoRespostaID");

                    b.Property<string>("Nome");

                    b.HasKey("TipoQuestaoID", "TipoRespostaID");

                    b.HasIndex("TipoRespostaID");

                    b.ToTable("Questoes");
                });

            modelBuilder.Entity("Trails4Health.Models.TipoQuestao", b =>
                {
                    b.Property<int>("TipoQuestaoID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TipoQ");

                    b.HasKey("TipoQuestaoID");

                    b.ToTable("TipoQuestoes");
                });

            modelBuilder.Entity("Trails4Health.Models.TipoResposta", b =>
                {
                    b.Property<int>("TipoRespostaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<int>("TipoR");

                    b.HasKey("TipoRespostaID");

                    b.ToTable("TipoRespostas");
                });

            modelBuilder.Entity("Trails4Health.Models.Trilho", b =>
                {
                    b.Property<int>("TrilhoID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Desativado");

                    b.Property<string>("Detalhes")
                        .IsRequired();

                    b.Property<int>("DificuldadeID");

                    b.Property<decimal>("Distancia");

                    b.Property<string>("Fim")
                        .IsRequired();

                    b.Property<string>("Foto")
                        .IsRequired();

                    b.Property<string>("Inicio")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

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

            modelBuilder.Entity("Trails4Health.Models.Questao", b =>
                {
                    b.HasOne("Trails4Health.Models.TipoQuestao", "TipoQuestao")
                        .WithMany("Questoes")
                        .HasForeignKey("TipoQuestaoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Trails4Health.Models.TipoResposta", "TipoResposta")
                        .WithMany("Questoes")
                        .HasForeignKey("TipoRespostaID")
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
