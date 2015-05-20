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
    public class clsProdutoPromocaoBLL
    {
        private DAL.DAO.clsBanco ObjBanco;              
            public clsProdutoPromocaoBLL()
            {
                ObjBanco = new clsBanco();

            }

        ~clsProdutoPromocaoBLL()
            {
                ObjBanco = null;
            }

        public void InserirProdutoEmPromocao(clsProdutoPromocao objProdutoPromocao)
        {
            List<SqlParameter> LstParametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@codProduto";
            parametro.Value = objProdutoPromocao.Cod_Produto;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@codPromocao";
            parametro.Value = objProdutoPromocao.Cod_Promocao;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            ObjBanco.ExecuteProc("USP_CSharp_Promocao_InserirProdutoEmPromocao", LstParametros);
        }

        public DataTable BuscarProdutosNaPromocao(clsProdutoPromocao objProdutoPromocao)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@codPromocao";
            parametro.Value = objProdutoPromocao.Cod_Promocao;
            parametro.DbType = System.Data.DbType.Int32;

            return ObjBanco.ExecuteProc("USP_CSharp_Promocao_BuscarProdutosNaPromocao", parametro);
        }

        public void RemoverProdutoDePromocao(clsProdutoPromocao objProdutoPromocao)
        {
            List<SqlParameter> LstParametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodProduto";
            parametro.Value = objProdutoPromocao.Cod_Produto;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodPromocao";
            parametro.Value = objProdutoPromocao.Cod_Promocao;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            ObjBanco.ExecuteProc("USP_CSharp_Promocao_RemoverProdutoDePromocao", LstParametros);
        }
    }
}