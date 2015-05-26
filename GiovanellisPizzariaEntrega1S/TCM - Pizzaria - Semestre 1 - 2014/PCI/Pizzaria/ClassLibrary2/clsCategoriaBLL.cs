using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DAL.Model;
using DAL.DAO;

namespace BLL
{
    public class clsCategoriaBLL
    {
        private DAL.DAO.clsBanco Banco;              
            public clsCategoriaBLL()
            {
                Banco = new clsBanco();
            }

            ~clsCategoriaBLL()
            {
                Banco = null;
            }

            public DataTable BuscarCategorias() 
            {
                return Banco.ExecuteProc("USP_CSharp_Categoria_BuscarCategorias");
            }

    }
}
