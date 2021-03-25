using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FastFoodSystem.Models
{
    public class StatusPedido
    {
        [Key]
        public int IdStatus { get; set; }
        public string Descricao { get; set; }
    }
}