using FastFoodSystem.Models;
using System.Data.Entity;

namespace FastFoodSystem.Dal
{
    public class FastFoodContext : DbContext
    {
        public FastFoodContext() : base("FastFoodContext")
            {
            }

        public DbSet<Cliente> Clientes { set; get; }
        public DbSet<Refeicao> Refeicaos { set; get; }
        public DbSet<StatusPedido> StatusPedidos { set; get; }
        public DbSet<Pedido> Pedidos { set; get; }

    }
}