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
        private DAL.DAO.clsBanco ObjBanco;
        public clsProdutoBLL()
        {
            ObjBanco = new clsBanco();

        }

        ~clsProdutoBLL()
        {
            ObjBanco = null;
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

            ObjBanco.ExecuteProc("USP_CSharp_Produto_InserirProduto", LstParametros);
        }

        public DataTable ValidaExistenciaNoBanco(clsProduto objProduto)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Nome";
            parametro.Value = objProduto.Nome_Produto;
            parametro.DbType = System.Data.DbType.String;

            return ObjBanco.ExecuteProc("USP_CSharp_Produto_ValidaExistenciaNoBanco", parametro);
        }

        public DataTable MostrarTodosProdutos()
        {
            return ObjBanco.ExecuteProc("USP_CSharp_Produto_MostrarTodosProdutos");
        }
    }
}
