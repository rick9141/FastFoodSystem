using System.ComponentModel.DataAnnotations;

namespace FastFoodSystem.Models
{
    public class StatusPedido
    {
        [Key]
        public int IdStatus { get; set; }
        public string Descricao { get; set; }
    }
}