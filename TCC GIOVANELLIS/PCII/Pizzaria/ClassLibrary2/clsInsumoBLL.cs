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

         public DataTable SelecionaInsumoPorNome(clsInsumo objInsumo)
         {  
             List<SqlParameter> lista = new List<SqlParameter>();

             SqlParameter parametro     = new SqlParameter();
             parametro.ParameterName    = "@Nome";
             parametro.Value            = objInsumo.Nome_Insumo;
             parametro.DbType           = System.Data.DbType.String;

             lista.Add(parametro);

             DataTable dt = ObjBanco.ExecuteProc("USP_CSharp_Insumos_SelecionaInsumoPorNome", lista);

             return dt;
         }

         public DataTable SelecionaInsumoPorID(clsInsumo objInsumo)
         {  
             List<SqlParameter> lista = new List<SqlParameter>();

             SqlParameter parametro     = new SqlParameter();
             parametro.ParameterName    = "@ID";
             parametro.Value            = objInsumo.Cod_Insumo;
             parametro.DbType           = System.Data.DbType.Int32;

             lista.Add(parametro);

             DataTable dt = ObjBanco.ExecuteProc("USP_CSharp_Insumos_SelecionaInsumoPorID", lista);

             return dt;
         }

         public DataTable ValidaExistente(clsInsumo objInsumo)
         {  
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Nome";
            parametro.Value = objInsumo.Nome_Insumo;
            parametro.DbType = System.Data.DbType.String;
            
             lista.Add(parametro);

             DataTable dt = ObjBanco.ExecuteProc("USP_CSharp_Insumos_ValidaExistente", lista);

             return dt;
         }

         public void InserirInsumo(clsInsumo objInsumo)
         {  
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Nome";
            parametro.Value = objInsumo.Nome_Insumo;
            parametro.DbType = System.Data.DbType.String;
            
             lista.Add(parametro);

             parametro = new SqlParameter();
             parametro.ParameterName = "@Medida";
             parametro.Value = objInsumo.Medida;
             parametro.DbType = System.Data.DbType.String;

             lista.Add(parametro);

             parametro = new SqlParameter();
             parametro.ParameterName = "@Validade";
             parametro.Value = objInsumo.Validade;
             parametro.DbType = System.Data.DbType.String;

             lista.Add(parametro);

             parametro = new SqlParameter();
             parametro.ParameterName = "@Fabricacao";
             parametro.Value = objInsumo.Fabricacao;
             parametro.DbType = System.Data.DbType.Date;

             lista.Add(parametro);

             parametro = new SqlParameter();
             parametro.ParameterName = "@QtdEstoque";
             parametro.Value = objInsumo.QtdeEmEstoque;
             parametro.DbType = System.Data.DbType.Decimal;

             lista.Add(parametro);

             parametro = new SqlParameter();
             parametro.ParameterName = "@QtdRecomendavel";
             parametro.Value = objInsumo.QtdeRecomendavel;
             parametro.DbType = System.Data.DbType.Decimal;

             lista.Add(parametro);

             ObjBanco.ExecuteProc("USP_CSharp_Insumos_InserirInsumo", lista);
         }

         public DataTable CarregaInsumos()
         {
             List<SqlParameter> lista = null;

             DataTable dt = ObjBanco.ExecuteProc("USP_CSharp_Insumos_CarregaInsumos", lista);

             return dt;
         }

         public void AtualizarInsumo(clsInsumo objInsumo)
         {
             List<SqlParameter> lista = new List<SqlParameter>();

             SqlParameter parametro = new SqlParameter();
             parametro.ParameterName = "@CodInsumo";
             parametro.Value = objInsumo.Cod_Insumo;
             parametro.DbType = System.Data.DbType.Int32;

             lista.Add(parametro);
                 
            parametro = new SqlParameter();
             parametro.ParameterName = "@Nome";
             parametro.Value = objInsumo.Nome_Insumo;
             parametro.DbType = System.Data.DbType.String;

             lista.Add(parametro);

             parametro = new SqlParameter();
             parametro.ParameterName = "@Medida";
             parametro.Value = objInsumo.Medida;
             parametro.DbType = System.Data.DbType.String;

             lista.Add(parametro);

             parametro = new SqlParameter();
             parametro.ParameterName = "@Validade";
             parametro.Value = objInsumo.Validade;
             parametro.DbType = System.Data.DbType.String;

             lista.Add(parametro);

             parametro = new SqlParameter();
             parametro.ParameterName = "@Fabricacao";
             parametro.Value = objInsumo.Fabricacao;
             parametro.DbType = System.Data.DbType.Date;

             lista.Add(parametro);

             parametro = new SqlParameter();
             parametro.ParameterName = "@QtdEstoque";
             parametro.Value = objInsumo.QtdeEmEstoque;
             parametro.DbType = System.Data.DbType.Decimal;

             lista.Add(parametro);

             parametro = new SqlParameter();
             parametro.ParameterName = "@QtdRecomendavel";
             parametro.Value = objInsumo.QtdeRecomendavel;
             parametro.DbType = System.Data.DbType.Decimal;

             lista.Add(parametro);

             ObjBanco.ExecuteProc("USP_CSharp_Insumos_AtualizarInsumo", lista);
         }
        
    }
}
