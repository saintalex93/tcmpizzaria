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
            parametro.ParameterName = "Cod_Produto";
            parametro.Value = objProdutoPromocao.Cod_Produto;
            parametro.DbType = System.Data.DbType.String;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "Cod_Promocao";
            parametro.Value = objProdutoPromocao.Cod_Promocao;
            parametro.DbType = System.Data.DbType.String;
            LstParametros.Add(parametro);

            ObjBanco.ExecuteProc("USP_CSP_Promocao_InserirProdutoEmPromocao", LstParametros);
        }
    }
}