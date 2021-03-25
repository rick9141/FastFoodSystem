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
        protected override void Seed(FastFoodContext context)
        {
            var dogs = new List<Cliente>
            {
                new Cliente{Id = 1, Cpf = "11111111111", Nome = "Luis Henrique", Telefone = "(16)997409141" },
                new Cliente{Id = 2, Cpf = "22222222222", Nome = "Maiara", Telefone = "(21)32514359" }
            };

            dogs.ForEach(d => context.Clientes.Add(d));
            context.SaveChanges();
        }
    }
}