using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class Acesso
    {
        private static int _acesso = 0;

        public static int PermissAcesso
        {
            get { return _acesso; }

            set { _acesso = value; }
        }

        private static string _datasorce = "";

        public static string Conexao
        {
            get { return _datasorce; }

            set { _datasorce = value; }
        }

    }
}
