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
    public class clsInsumoBLL
    {

        private DAL.DAO.clsBanco ObjBanco;

              public clsInsumoBLL()
            {
                ObjBanco = new clsBanco();
            }
              ~clsInsumoBLL()
            {
                ObjBanco = null;
            }

         public DataTable SelecionaInsumo(clsInsumo objPedido)
         {  
             List<SqlParameter> LstParametros = new List<SqlParameter>();

             SqlParameter ParametroCodInsumo = new SqlParameter();
             ParametroCodInsumo.ParameterName = "Cod_Insumo";
             if (objPedido.Cod_Insumo > 0)
                 ParametroCodInsumo.Value = objPedido.Cod_Insumo;
             else
                 ParametroCodInsumo.Value = null;
             ParametroCodInsumo.DbType = System.Data.DbType.Int32;



             LstParametros.Add(ParametroCodInsumo);
             SqlParameter ParametroNomeInsumo = new SqlParameter();
             ParametroNomeInsumo.ParameterName = "Nome_Insumo";
             ParametroNomeInsumo.Value = objPedido.Nome_Insumo;
             ParametroNomeInsumo.DbType = System.Data.DbType.String;



             LstParametros.Add(ParametroNomeInsumo);



             DataTable dt = ObjBanco.ExecuteProc("SP_CSHARP_SELECIONA_INSUMO", LstParametros);


             return dt;
         }


    }
}
