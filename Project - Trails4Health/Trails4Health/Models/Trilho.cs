﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trails4Health.Models
{
    public class Trilho
    {
        public int TrilhoID { get; set; } // tem de ter este formato para reconhecer pk: nomeID !!

        [Required(ErrorMessage = "Introduza nome do Trilho")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Introduza inicio do Trilho")]
        public string Inicio { get; set; }

        [Required(ErrorMessage = "Introduza fim do Trilho")]
        public string Fim { get; set; }

        // Acrescentar coordenadas GPS

        // Acrescentar data criação

        // Nota: Acrescentar em SeedData!! Ainda nao está na BD 
        // public string Sumario { get; set; }

        [Required(ErrorMessage = "Introduza detalhes do Trilho")]
        public string Detalhes { get; set; }

        [Required(ErrorMessage = "Introduza Distancia do Trilho")]
        public decimal Distancia { get; set; }

        [Required(ErrorMessage = "Escolha uma foto")]
        public string Foto { get; set; } // mais tarde vai ser na base dados

        public bool Desativado { get; set; } = false;

        //public int DificuldadeID { get; set; } // FK 
        //public Dificuldade Dificuldade { get; set; }
    }
}
