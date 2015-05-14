using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class clsPedidoFornecedor
    {  
      public int Cod_PedidoF { get; set; }
      public double Valor_Venda { get; set; }
      public string Data_Venda { get; set; }
      public int Cod_Fornecedor { get; set; }
      public int Cod_Funcionario { get; set; }
    }
}
