using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FastFoodSystem.Models
{
    public class Refeicao
    {
        [Key]
        public int IdRefeicao { get; set; }
        public string Tipo { get; set; }
        public string Valor { get; set; }
    }
}