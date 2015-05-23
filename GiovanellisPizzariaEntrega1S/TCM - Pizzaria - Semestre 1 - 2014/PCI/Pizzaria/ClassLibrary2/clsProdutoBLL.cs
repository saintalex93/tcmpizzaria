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
    public class clsProdutoBLL
    {
        private DAL.DAO.clsBanco Banco;
        public clsProdutoBLL()
        {
            Banco = new clsBanco();

        }

        ~clsProdutoBLL()
        {
            Banco = null;
        }

        public void InserirProduto(clsProduto objProduto)
        {
            List<SqlParameter> LstParametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Nome";
            parametro.Value = objProduto.Nome_Produto;
            parametro.DbType = System.Data.DbType.String;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Preco";
            parametro.Value = objProduto.Valor_Venda;
            parametro.DbType = System.Data.DbType.Decimal;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@SobeSite";
            parametro.Value = objProduto.Sobe_Site;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Produto_InserirProduto", LstParametros);
        }

        public DataTable ValidaExistenciaNoBanco(clsProduto objProduto)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodProduto";
            parametro.Value = objProduto.Cod_Produto;
            parametro.DbType = System.Data.DbType.Int32;
            lstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Nome";
            parametro.Value = objProduto.Nome_Produto;
            parametro.DbType = System.Data.DbType.String;
            lstParametros.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Produto_ValidaExistenciaNoBanco", lstParametros);
        }

        public DataTable MostrarTodosProdutos()
        {
            return Banco.ExecuteProc("USP_CSharp_Produto_MostrarTodosProdutos");
        }

        public DataTable BuscarProdutoPorNome(string nome)
        { 
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Palavra";
            parametro.Value = nome;
            parametro.DbType = System.Data.DbType.String;

            return Banco.ExecuteProc("USP_CSharp_Produto_BuscarProdutoPorNome", parametro);
        }

        public DataTable BuscarProdutoPorID(int id)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@ID";
            parametro.Value = id;
            parametro.DbType = System.Data.DbType.Int32;

            return Banco.ExecuteProc("USP_CSharp_Produto_BuscarProdutoPorID", parametro);
        }

        public DataTable MostrarTodosProdutosDesc()
        {
            return Banco.ExecuteProc("USP_CSharp_Produto_MostrarTodosProdutosDesc");
        }

        public void AtualizarProduto(clsProduto objProduto) 
        {
            List<SqlParameter> LstParametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodProduto";
            parametro.Value = objProduto.Cod_Produto;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Nome";
            parametro.Value = objProduto.Nome_Produto;
            parametro.DbType = System.Data.DbType.String;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Preco";
            parametro.Value = objProduto.Valor_Venda;
            parametro.DbType = System.Data.DbType.Decimal;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@SobeSite";
            parametro.Value = objProduto.Sobe_Site;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Produto_AtualizarProduto", LstParametros);
        }

        public void RemoverProduto(int codProduto)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@codProduto";
            parametro.Value = codProduto;
            parametro.DbType = System.Data.DbType.Int32;

            Banco.ExecuteProc("USP_CSharp_Produto_RemoverProduto", parametro);
        }
    }
}
