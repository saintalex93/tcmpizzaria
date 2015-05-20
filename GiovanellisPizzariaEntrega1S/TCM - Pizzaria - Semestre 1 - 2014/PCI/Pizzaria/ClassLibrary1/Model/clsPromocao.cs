using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class clsPromocao
    {
        public int Cod_Promocao { get; set; }
        public string Nome_Promocao { get; set; }
        public string Descricao { get; set; }
        public int PorcentualDesconto { get; set; }
        public string Vigencia { get; set; }
        public int SobeSite { get; set; }
        public int AcessivelATodos { get; set; }
    }
}
