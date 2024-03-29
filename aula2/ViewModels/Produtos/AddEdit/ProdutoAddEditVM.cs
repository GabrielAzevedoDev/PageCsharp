﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aula2.ViewModels.Produtos.AddEdit
{
    public class ProdutoAddEditVM
    {
        public ProdutoAddEditVM()
        {
            DataCadastro = DateTime.Now;
        }
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public short Qtde { get; set; }

        [Display(Name ="Tipo de Produto")]
        public int TipoDeProdutoId { get; set; }

        public DateTime DataCadastro { get; set; } 
    }
}