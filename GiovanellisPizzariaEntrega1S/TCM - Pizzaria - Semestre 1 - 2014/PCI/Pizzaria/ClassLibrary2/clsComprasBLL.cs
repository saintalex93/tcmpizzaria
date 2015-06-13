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

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodFuncionario";
            parametro.Value = objCompra.codFuncionario;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Data";
            parametro.Value = objCompra.DataVenda;
            parametro.DbType = System.Data.DbType.Date;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Compras_RegistrarCompra", lista);
        }
    }
}
