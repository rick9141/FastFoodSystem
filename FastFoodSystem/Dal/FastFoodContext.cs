using FastFoodSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FastFoodSystem.Dal
{
    public class FastFoodContext : DbContext
    {
        public FastFoodContext() : base("FastFoodContext")
            {
            }

        public DbSet<Cliente> Clientes { set; get; }
    }
}