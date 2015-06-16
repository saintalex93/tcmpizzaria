using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class clsCompra
    {
        public int codCompra { get; set; }
        
        public double ValorCompra { get; set; }
        
        public DateTime DataVenda { get; set; }
        
        public int codFornecedor { get; set; }
        
        public int codFuncionario { get; set; }
    }
}
