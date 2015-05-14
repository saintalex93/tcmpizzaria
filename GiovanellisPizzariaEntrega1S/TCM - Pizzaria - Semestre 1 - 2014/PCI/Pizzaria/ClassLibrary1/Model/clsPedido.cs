using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class clsPedido
    {
        public string Cod_Pedido { get; set; }
        public string Data { get; set; }
        public string DataFim { get; set; }
        public string Hora { get; set; }
        public string HoraFim { get; set; }
        public string Valor { get; set; }
        public string Cod_Funcionario { get; set; }
        public string Cod_Cliente { get; set; }
        public string Observacao { get; set; }
        public string Estado { get; set; }
        public string Estado_Entregue { get; set; }
        public string Estado_Caminho { get; set; }
        public string Estado_Preparo { get; set; }
        public string Estado_Cancelado { get; set; }
        public string Estado_Novo { get; set; }
        public string FormaDePagamento { get; set; }
        
    }
}
