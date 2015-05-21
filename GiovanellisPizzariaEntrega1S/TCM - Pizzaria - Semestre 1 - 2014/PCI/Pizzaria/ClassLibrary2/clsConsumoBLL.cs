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
    public class clsConsumoBLL
    {
        private DAL.DAO.clsBanco Banco;              
            public clsConsumoBLL()
            {
                Banco = new clsBanco();
            }

            ~clsConsumoBLL()
            {
                Banco = null;
            }

            public DataTable MostrarConsumo() 
            {
                return Banco.ExecuteProc("USP_CSharp_Consumo_MostrarConsumo");
            }
    }
}
