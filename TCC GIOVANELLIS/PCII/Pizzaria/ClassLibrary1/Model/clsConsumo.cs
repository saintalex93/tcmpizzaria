using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class clsConsumo
    {
        public int CodProdutoInsumo {get; set;}
        public int CodInsumo {get; set;}
        public int CodProduto {get; set;}
        public decimal Quantidade {get; set;}
    }
}
