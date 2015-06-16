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
    public class clsComprasBLL
    {
        private DAL.DAO.clsBanco Banco;

        public clsComprasBLL()
        {
            Banco = new clsBanco();
        }

        ~clsComprasBLL()
        {
            Banco = null;
        }

        public DataTable SelectFuncionarios() 
        {
            List<SqlParameter> lista = null;

            return Banco.ExecuteProc("USP_CSharp_Compras_SelectFuncionarios", lista);
        }

        public DataTable SelectFornecedores()
        {
            List<SqlParameter> lista = null;

            return Banco.ExecuteProc("USP_CSharp_Compras_SelectFornecedores", lista);
        }

        public DataTable SelectInsumos()
        {
            List<SqlParameter> lista = null;

            return Banco.ExecuteProc("USP_CSharp_Compras_SelectInsumos", lista);
        }

        public DataTable BuscarFornecedoresPorID(clsFornecedor objFornecedor)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodFornecedor";
            parametro.Value = objFornecedor.Cod_Fornecedor;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Compras_BuscarFornecedoresPorID", lista);
        }

        public DataTable BuscarFornecedoresPorPalavraChave(clsFornecedor objFornecedor)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Palavra";
            parametro.Value = objFornecedor.Nome_Fantasia;
            parametro.DbType = System.Data.DbType.String;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Compras_BuscarFornecedoresPorPalavraChave", lista);
        }

        public DataTable BuscarComprasComFornecedor(clsFornecedor objFornecedor)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodFornecedor";
            parametro.Value = objFornecedor.Cod_Fornecedor;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Compras_BuscarComprasComFornecedor", lista);
        }
    
        public DataTable RegistrarCompra(clsCompra objCompra)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro  = new SqlParameter();
            parametro.ParameterName = "@CodFuncionario";
            parametro.Value         = objCompra.codFuncionario;
            parametro.DbType        = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodFornecedor";
            parametro.Value = objCompra.codFornecedor;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro               = new SqlParameter();
            parametro.ParameterName = "@Data";
            parametro.Value         = objCompra.DataVenda;
            parametro.DbType        = System.Data.DbType.Date;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Compras_RegistrarCompra", lista);
        }

        public DataTable PreencherComboBoxFornecedores()
        {
            List<SqlParameter> lista = null;

            return Banco.ExecuteProc("USP_CSharp_Compras_PreencherComboBoxFornecedores", lista);
        }

        public DataTable BuscarInsumosNaCompra(clsCompra objCompra)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCompra";
            parametro.Value = objCompra.codCompra;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Compras_BuscarInsumosNaCompra", lista);
        }

        public void InserirInsumoNaCompra(clsDetalheCompra objDetalheCompra)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodFornecedor";
            parametro.Value = objDetalheCompra.codFornecedor;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodCompra";
            parametro.Value = objDetalheCompra.codCompra;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodInsumo";
            parametro.Value = objDetalheCompra.codInsumo;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Quantidade";
            parametro.Value = objDetalheCompra.Quantidade;
            parametro.DbType = System.Data.DbType.Decimal;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Valor";
            parametro.Value = objDetalheCompra.valorInsumo;
            parametro.DbType = System.Data.DbType.Decimal;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Compras_InserirInsumoNaCompra", lista);
        }

        public DataTable ValidarAssociacoesNoBanco(clsCompra objCompra)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCompra";
            parametro.Value = objCompra.codCompra;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Compras_ValidarAssociacoesNoBanco", lista);
        }

        public void ExcluirCompra(clsCompra objCompra)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCompra";
            parametro.Value = objCompra.codCompra;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Compras_ExcluirCompra", lista);
        }
        
        public void AtualizarCompra(clsCompra objCompra)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCompra";
            parametro.Value = objCompra.codCompra;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodFuncionario";
            parametro.Value = objCompra.codFuncionario;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Data";
            parametro.Value = objCompra.DataVenda;
            parametro.DbType = System.Data.DbType.Date;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Compras_AtualizarCompra", lista);
        }

        public void AtualizarPrecoCompra(clsDetalheCompra objDetalheCompra)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCompra";
            parametro.Value = objDetalheCompra.codCompra;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@ValorCompra";
            parametro.Value = objDetalheCompra.valorInsumo;
            parametro.DbType = System.Data.DbType.Decimal;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Compras_AtualizarPrecoCompra", lista);
        }

        public DataTable ValidarExistenciaInsumoNaCompra(clsDetalheCompra objDetalheCompra)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCompra";
            parametro.Value = objDetalheCompra.codCompra;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodInsumo";
            parametro.Value = objDetalheCompra.codInsumo;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Compras_ValidarExistenciaInsumoNaCompra", lista);
        }


        public DataTable ExcluirInsumoDaCompra(clsDetalheCompra objDetalheCompra)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCompra";
            parametro.Value = objDetalheCompra.codCompra;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodInsumo";
            parametro.Value = objDetalheCompra.codInsumo;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Compras_ExcluirInsumoDaCompra", lista);
        }

    }
}
