using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class StatusPedido
    {
        public int IdStatus { get; set; }
        public string Descricao { get; set; }
    }
}
