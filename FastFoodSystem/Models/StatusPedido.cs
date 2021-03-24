using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastFoodSystem.Models
{
    public abstract class StatusPedido
    {
        public int IdStatus { get; set; }
        public string Descricao { get; set; }
    }
}