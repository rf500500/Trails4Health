﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Trails4Health.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dificuldades",
                columns: table => new
                {
                    DificuldadeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Observacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dificuldades", x => x.DificuldadeID);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    EstadoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.EstadoID);
                });

            migrationBuilder.CreateTable(
                name: "Trilhos",
                columns: table => new
                {
                    TrilhoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Desativado = table.Column<bool>(nullable: false),
                    Detalhes = table.Column<string>(nullable: false),
                    DificuldadeID = table.Column<int>(nullable: false),
                    Distancia = table.Column<decimal>(nullable: false),
                    Fim = table.Column<string>(nullable: false),
                    Foto = table.Column<string>(nullable: false),
                    Inicio = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trilhos", x => x.TrilhoID);
                    table.ForeignKey(
                        name: "FK_Trilhos_Dificuldades_DificuldadeID",
                        column: x => x.DificuldadeID,
                        principalTable: "Dificuldades",
                        principalColumn: "DificuldadeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstadoTrilhos",
                columns: table => new
                {
                    EstadoID = table.Column<int>(nullable: false),
                    TrilhoID = table.Column<int>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoTrilhos", x => new { x.EstadoID, x.TrilhoID });
                    table.ForeignKey(
                        name: "FK_EstadoTrilhos_Estados_EstadoID",
                        column: x => x.EstadoID,
                        principalTable: "Estados",
                        principalColumn: "EstadoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstadoTrilhos_Trilhos_TrilhoID",
                        column: x => x.TrilhoID,
                        principalTable: "Trilhos",
                        principalColumn: "TrilhoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstadoTrilhos_TrilhoID",
                table: "EstadoTrilhos",
                column: "TrilhoID");

            migrationBuilder.CreateIndex(
                name: "IX_Trilhos_DificuldadeID",
                table: "Trilhos",
                column: "DificuldadeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadoTrilhos");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Trilhos");

            migrationBuilder.DropTable(
                name: "Dificuldades");
        }
    }
}