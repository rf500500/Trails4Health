﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trails4Health.Models
{
    public class Trilho
    {
        // ATRIBUTOS
        public int TrilhoID { get; set; } // formato para reconhecer pk: nomeID !!

        [Required(ErrorMessage = "Introduza nome do Trilho")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Introduza inicio do Trilho")]
        public string Inicio { get; set; }

        [Required(ErrorMessage = "Introduza fim do Trilho")]
        public string Fim { get; set; }

       // Nota: Acrescentar em SeedData!! Ainda nao está na BD
       // coordenadas GPS
       //public string Latitude { get; set; }

       //public string Longitude { get; set; }

       // public string Sumario { get; set; }

       [Required(ErrorMessage = "Introduza detalhes do Trilho")]
        public string Detalhes { get; set; }

        [Required(ErrorMessage = "Introduza Distancia do Trilho")]
        public decimal Distancia { get; set; }

        [Required(ErrorMessage = "Escolha uma foto")]
        public string Foto { get; set; } // mais tarde vai ser na base dados

        public bool Desativado { get; set; } = false;


        // FK Dificuldade
        public int DificuldadeID { get; set; }
        public Dificuldade Dificuldade { get; set; }

        // Trilho tem varios EstadoTrilhos (classe intermedia)
        public ICollection<EstadoTrilho> EstadoTrilhos { get; set; }
    }
}