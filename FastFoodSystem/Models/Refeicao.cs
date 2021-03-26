using System.ComponentModel.DataAnnotations;

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