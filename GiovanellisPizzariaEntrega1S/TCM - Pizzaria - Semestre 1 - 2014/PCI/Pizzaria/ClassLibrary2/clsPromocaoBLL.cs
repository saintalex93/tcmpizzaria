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
    public class clsPromocaoBLL
    {

        private DAL.DAO.clsBanco ObjBanco;              
            public clsPromocaoBLL()
            {
                ObjBanco = new clsBanco();

            }

        ~clsPromocaoBLL()
            {
                ObjBanco = null;
            }

        public DataTable MostrarTodasAsPromocoes()
        {
            return ObjBanco.ExecuteProc("USP_CSharp_Promocao_BuscarTodasPromocoes");
        }

        public DataTable MostrarProdutosNaPromocoes(clsPromocao objPromocao)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "Cod_Promocao";
            parametro.Value = objPromocao.Cod_Promocao;
            parametro.DbType = System.Data.DbType.Int32;

            return ObjBanco.ExecuteProc("USP_CSharp_Promocao_BuscarProdutosNaPromocao", parametro);
        }

        public void InserirPromocoes(clsPromocao objPromocao)
        {
            List<SqlParameter> LstParametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Nome";
            parametro.Value = objPromocao.Nome_Promocao;
            parametro.DbType = System.Data.DbType.String;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Descricao";
            parametro.Value = objPromocao.Descricao;
            parametro.DbType = System.Data.DbType.String;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@PorcentagemDesconto";
            parametro.Value = objPromocao.PorcentualDesconto;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Vigencia";
            parametro.Value = objPromocao.Vigencia;
            parametro.DbType = System.Data.DbType.Date;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@sobe_promocao";
            parametro.Value = objPromocao.SobeSite;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@AcessivelATodos";
            parametro.Value = objPromocao.AcessivelATodos;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            ObjBanco.ExecuteProc("USP_CSharp_Promocao_InserirPromocao", LstParametros);
        }

        public DataTable BuscarPromocaoInserida()
        {
            return ObjBanco.ExecuteProc("USP_CSharp_Promocao_BuscarPromocaoInserida");
        }

        public void InserirProdutoNaPromocoes(clsPromocao objPromocao)
        {
            List<SqlParameter> LstParametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "Cod_Produto";
            parametro.Value = objPromocao.Nome_Promocao;
            parametro.DbType = System.Data.DbType.String;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "Cod_Promocao";
            parametro.Value = objPromocao.Descricao;
            parametro.DbType = System.Data.DbType.String;
            LstParametros.Add(parametro);

            
            ObjBanco.ExecuteProc("USP_CSharp_Promocao_InserirProdutoEmPromocao", LstParametros);
        }

        public DataTable BuscarPromocoesPorPalavraChave(string palavraChave) 
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Palavra";
            parametro.Value = palavraChave;
            parametro.DbType = System.Data.DbType.String;

            return ObjBanco.ExecuteProc("USP_CSharp_Promocao_BuscarPromocoesPorPalavraChave", parametro);
        }

        public DataTable BuscarPromocoesPorID(int id)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@ID";
            parametro.Value = id;
            parametro.DbType = System.Data.DbType.Int32;

            return ObjBanco.ExecuteProc("USP_CSharp_Promocao_BuscarPromocoesPorID", parametro);
        }

        public DataTable AtualizarPromocao(clsPromocao objPromocao)
        {
            List<SqlParameter> LstParametros = new List<SqlParameter>();
	
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Nome";
            parametro.Value = objPromocao.Nome_Promocao;
            parametro.DbType = System.Data.DbType.String;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodPromocao";
            parametro.Value = objPromocao.Cod_Promocao;
            parametro.DbType = System.Data.DbType.String;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Descricao";
            parametro.Value = objPromocao.Descricao;
            parametro.DbType = System.Data.DbType.String;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@PorcentagemDesconto";
            parametro.Value = objPromocao.PorcentualDesconto;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Vigencia";
            parametro.Value = objPromocao.Vigencia;
            parametro.DbType = System.Data.DbType.Date;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@sobe_promocao";
            parametro.Value = objPromocao.SobeSite;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@AcessivelATodos";
            parametro.Value = objPromocao.AcessivelATodos;
            parametro.DbType = System.Data.DbType.Int32;
            LstParametros.Add(parametro);

            return ObjBanco.ExecuteProc("USP_CSharp_Promocao_AtualizarPromocao", LstParametros);
        }
    }
}
