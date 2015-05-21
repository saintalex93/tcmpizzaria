using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class clsProduto
    {
        public int Cod_Produto { get; set; }
        public string Nome_Produto { get; set; }
        public double Valor_Venda { get; set; }
        public int Sobe_Site { get; set; }
    }
}
