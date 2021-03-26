using FastFoodSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FastFoodSystem.Dal
{
    public class FastFoodInitializer : DropCreateDatabaseIfModelChanges<FastFoodContext>
    {
        //Cliente
        protected override void Seed(FastFoodContext context)
        {
            var clientes = new List<Cliente>
            {
                new Cliente{Id = 1, Cpf = "11111111111", Nome = "Luis Henrique", Telefone = "(16)997409141" },
                new Cliente{Id = 2, Cpf = "22222222222", Nome = "Maiara", Telefone = "(21)32514359" }
            };

            clientes.ForEach(d => context.Clientes.Add(d));
            context.SaveChanges();

            //Refeição
            var refeicoes = new List<Refeicao>
            {
                new Refeicao{IdRefeicao = 1, Tipo = "Pizza", Valor = "50.00"},
                new Refeicao{IdRefeicao = 2, Tipo = "Lanche", Valor = "25.00"},
                new Refeicao{IdRefeicao = 3, Tipo = "Pastel", Valor = "12.00"},
            };

            refeicoes.ForEach(d => context.Refeicaos.Add(d));
            context.SaveChanges();

            // StatusPedidos
            var status = new List<StatusPedido>
            {
                new StatusPedido{IdStatus = 1, Descricao = "Em aberto"},
                new StatusPedido{IdStatus = 2, Descricao = "Em Preparo"},
                new StatusPedido{IdStatus = 3, Descricao = "Concluído"},
            };

            status.ForEach(d => context.StatusPedidos.Add(d));
            context.SaveChanges();


        }

        
        
        
            

           
        
    }
}