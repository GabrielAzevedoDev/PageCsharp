﻿using FN.Store.Domain._2.Entities;
using FN.Store.Domain._2.Helpers;
using System.Collections.Generic;
using System.Data.Entity;

namespace FN.Store.Data.EF
{
    internal class DbInitializer : CreateDatabaseIfNotExists<FNStoreDataContextEF>
    {
        protected override void Seed(FNStoreDataContextEF context)
        {
            var alimento = new TipoDeProduto() { Nome = "Alimento" };
            var higiene = new TipoDeProduto() { Nome = "Higiene" };
            var limpeza = new TipoDeProduto() { Nome = "Limpeza" };
            var eletronico = new TipoDeProduto() { Nome = "Eletrônico" };



            var produtos = new List<Produto>() {


                new Produto() { Nome = "Picanha", Preco = 70.5M, Qtde = 150, TipoDeProduto = alimento},
                new Produto() { Nome = "Iogurte", Preco = 10.5M, Qtde = 250, TipoDeProduto = alimento},
                new Produto() { Nome = "Pasta de dente", Preco = 9.5M, Qtde = 250, TipoDeProduto = higiene },
                new Produto() { Nome = "Sabonete", Preco = 5.5M, Qtde = 1250, TipoDeProduto = higiene },
                new Produto() { Nome = "Desinfetante", Preco = 8.99M, Qtde = 520, TipoDeProduto = limpeza },
                new Produto() { Nome = "Detergente", Preco = 4.49M, Qtde = 1520, TipoDeProduto = limpeza },
                new Produto() { Nome = "Telefone sem fio", Preco = 125.15M, Qtde = 85, TipoDeProduto = eletronico },



          };
            context.Produtos.AddRange(produtos);


            context.Usuarios.Add(new Usuario()
            {
                Nome = "Gabriel Oliveira",
                Email = "gabrielfatec7@gmail.com",
                Senha = "123456".Encrypt()
            });




            context.SaveChanges();

        }


    }
}
