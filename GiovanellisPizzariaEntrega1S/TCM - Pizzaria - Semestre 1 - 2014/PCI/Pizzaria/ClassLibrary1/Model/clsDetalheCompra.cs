using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class clsDetalheCompra
    {
        public int codDetalheCompra { get; set; }

        public int codCompra { get; set; }

        public int codFornecedor { get; set; }
        
        public int codFuncionario { get; set; }

        public int codInsumo { get; set; }

        public double valorInsumo { get; set; }

        public double Quantidade { get; set; }
    }
}
