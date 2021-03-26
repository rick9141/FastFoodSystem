using System.ComponentModel.DataAnnotations;

namespace FastFoodSystem.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public virtual Cliente Cliente { get; set; }
        //public string Cpf { get; set; }
        public virtual Refeicao Refeicao { get; set; }
        //public int IdRefeicao { get; set; }
        //public string Tipo { get; set; }
        //public string Valor { get; set; }
        public string FormaPag { get; set; }
        public virtual StatusPedido StatusPedido { get; set; }
        //public int IdStatus { get; set; }
        //public string Descricao { get; set; }
    }
}