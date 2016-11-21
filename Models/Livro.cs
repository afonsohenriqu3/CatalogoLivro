﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogoLivro.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoEdicao { get; set; }
        public decimal Valor { get; set; }

        public Genero  Genero { get; set; }
        public int GenetoId { get; set; }
    }
}