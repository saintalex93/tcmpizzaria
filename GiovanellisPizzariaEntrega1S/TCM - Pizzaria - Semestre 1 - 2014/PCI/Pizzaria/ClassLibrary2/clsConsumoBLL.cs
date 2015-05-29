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

            public DataTable BuscarConsumosPorNomeProduto(clsProduto objProduto)
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Nome";
                parametro.Value = objProduto.Nome_Produto;
                parametro.DbType = System.Data.DbType.String;

                return Banco.ExecuteProc("USP_CSharp_Consumo_BuscarConsumosPorNomeProduto", parametro);
            }

            public DataTable BuscarConsumosPorIDProduto(clsProduto objProduto)
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@ID";
                parametro.Value = objProduto.Cod_Produto;
                parametro.DbType = System.Data.DbType.Int32;

                return Banco.ExecuteProc("USP_CSharp_Consumo_BuscarConsumosPorIDProduto", parametro);
            }

            public DataTable BuscarConsumosPorIDProduto(clsConsumo objConsumo)
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@ID";
                parametro.Value = objConsumo.CodProduto;
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

            public DataTable BuscarConsumosPorIdInsumo(clsInsumo objInsumo)
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@ID";
                parametro.Value = objInsumo.Cod_Insumo;
                parametro.DbType = System.Data.DbType.Int32;

                return Banco.ExecuteProc("USP_CSharp_Consumo_BuscarConsumosPorIdInsumo", parametro);
            }

            public DataTable BuscarConsumosPorNomeInsumo(clsInsumo objInsumo)
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Nome";
                parametro.Value = objInsumo.Nome_Insumo;
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

                parametro = new SqlParameter();
                parametro.ParameterName = "@CodProdutoInsumo";
                parametro.Value = objConsumo.CodProdutoInsumo;
                parametro.DbType = System.Data.DbType.Int32;
                lstParametros.Add(parametro);

                return Banco.ExecuteProc("USP_CSharp_Consumo_ValidaExistenciaNoBanco", lstParametros);
            }

            public void AtualizarConsumo(clsConsumo objConsumo) 
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
                parametro.ParameterName = "@CodProdutoInsumo";
                parametro.Value = objConsumo.CodProdutoInsumo;
                parametro.DbType = System.Data.DbType.Int32;
                lstParametros.Add(parametro);

                parametro = new SqlParameter();
                parametro.ParameterName = "@Quantidade";
                parametro.Value = objConsumo.Quantidade;
                parametro.DbType = System.Data.DbType.Decimal;
                lstParametros.Add(parametro);

                Banco.ExecuteProc("USP_CSharp_Consumo_AtualizarConsumo", lstParametros);
            }

            public void RemoverConsumo(clsConsumo objConsumo) 
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id";
                parametro.Value = objConsumo.CodProdutoInsumo;
                parametro.DbType = System.Data.DbType.Int32;

                Banco.ExecuteProc("USP_CSharp_Consumo_RemoverConsumo", parametro);
            }

            public DataTable VerificaProdutoSemConsumo() 
            {
                return Banco.ExecuteProc("USP_CSharp_Consumo_VerificaProdutoSemConsumo");
            }

            public DataTable VerificaConsumoVazio() 
            {
                return Banco.ExecuteProc("USP_CSharp_Consumo_VerificaConsumoVazio");
            }

            public int MostrarProdutoInserido() 
            {
                DataTable tabela = Banco.ExecuteProc("USP_CSharp_Consumo_MostrarProdutoInserido");

                return (int) tabela.Rows[0][0] - 1;
            }

            public void CancelarInsercao()
            {
                Banco.ExecuteProc("USP_CSharp_Consumo_CancelarInsercao");
            }

    }
}
