using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class clsFuncPermissao
    {

        public int Cod_Func_Perm { get; set; }
        public string Login_ { get; set; }
        public string Senha { get; set; }
        public int Cod_Funcionario { get; set; }
        public int Cod_Permissao { get; set; }
    }
}
