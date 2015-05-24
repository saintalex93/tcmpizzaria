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

            public DataTable MostrarConsumoDesc()
            {
                return Banco.ExecuteProc("USP_CSharp_Consumo_MostrarConsumoDesc");
            }

            public DataTable PreencherProdutos()
            {
                return Banco.ExecuteProc("USP_CSharp_Consumo_PreencherProdutos");
            }

            public DataTable PreencherInsumos()
            {
                return Banco.ExecuteProc("USP_CSharp_Consumo_PreencherInsumos");
            }

            public DataTable BuscarConsumosPorNomeProduto()
            {
                return Banco.ExecuteProc("USP_CSharp_Consumo_PreencherInsumos");
            }

            public DataTable BuscarConsumosPorNomeProduto(string nome)
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Nome";
                parametro.Value = nome;
                parametro.DbType = System.Data.DbType.String;

                return Banco.ExecuteProc("USP_CSharp_Consumo_BuscarConsumosPorNomeProduto", parametro);
            }

            public DataTable BuscarConsumosPorIDProduto(int id)
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@ID";
                parametro.Value = id;
                parametro.DbType = System.Data.DbType.Int32;

                return Banco.ExecuteProc("USP_CSharp_Consumo_BuscarConsumosPorIDProduto", parametro);
            }

            public void InserirConsumo(clsConsumo objConsumo)
            {
                List<SqlParameter> lstParametros = new List<SqlParameter>();

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@CodProduto";
                parametro.Value = objConsumo.CodProduto;
                parametro.DbType = System.Data.DbType.Int32;
                lstParametros.Add(parametro);

                parametro = new SqlParameter();
                parametro.ParameterName = "@CodInsumo";
                parametro.Value = objConsumo.CodInsumo;
                parametro.DbType = System.Data.DbType.Int32;
                lstParametros.Add(parametro);

                parametro = new SqlParameter();
                parametro.ParameterName = "@Quantidade";
                parametro.Value = objConsumo.Quantidade;
                parametro.DbType = System.Data.DbType.Decimal;
                lstParametros.Add(parametro);

                Banco.ExecuteProc("USP_CSharp_Consumo_InserirConsumo", lstParametros);
            }

            public DataTable BuscarConsumosPorIdInsumo(int id)
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@ID";
                parametro.Value = id;
                parametro.DbType = System.Data.DbType.Int32;

                return Banco.ExecuteProc("USP_CSharp_Consumo_BuscarConsumosPorIdInsumo", parametro);
            }

            public DataTable BuscarConsumosPorNomeInsumo(string nome)
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Nome";
                parametro.Value = nome;
                parametro.DbType = System.Data.DbType.String;

                return Banco.ExecuteProc("USP_CSharp_Consumo_BuscarConsumosPorNomeInsumo", parametro);
            }

            public DataTable ValidaExistenciaNoBanco(clsConsumo objConsumo)
            {
                List<SqlParameter> lstParametros = new List<SqlParameter>();

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@CodProduto";
                parametro.Value = objConsumo.CodProduto;
                parametro.DbType = System.Data.DbType.Int32;
                lstParametros.Add(parametro);

                parametro = new SqlParameter();
                parametro.ParameterName = "@CodInsumo";
                parametro.Value = objConsumo.CodInsumo;
                parametro.DbType = System.Data.DbType.Int32;
                lstParametros.Add(parametro);

                return Banco.ExecuteProc("USP_CSharp_Consumo_ValidaExistenciaNoBanco", lstParametros);
            }
    }
}
