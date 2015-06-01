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
    public class clsCategoriaBLL
    {
        private DAL.DAO.clsBanco Banco;              
            
        public clsCategoriaBLL()
            {
                Banco = new clsBanco();
            }

         ~clsCategoriaBLL()
            {
                Banco = null;
            }

        public DataTable BuscarCategorias() 
            {
                return Banco.ExecuteProc("USP_CSharp_Categoria_BuscarCategorias");
            }

        public void InserirCategoria(clsCategoria objCategoria) 
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@NomeCategoria";
                parametro.Value = objCategoria.NomeCategoria;
                parametro.DbType = System.Data.DbType.String;

                Banco.ExecuteProc("USP_CSharp_Categoria_InserirCategoria",parametro);
            }

        public DataTable PreencherProdutos()
            {
                return Banco.ExecuteProc("USP_CSharp_Categoria_PreencherProdutos");
            }

        public DataTable PreencherInsumos()
            {
                return Banco.ExecuteProc("USP_CSharp_Categoria_PreencherInsumos");
            }

        public DataTable RemoverCategoria(clsCategoria objCategoria)
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@CodCategoria";
                parametro.Value = objCategoria.CodCategoria;
                parametro.DbType = System.Data.DbType.Int32;

                return Banco.ExecuteProc("USP_CSharp_Categoria_RemoverCategoria", parametro);
            }

        public void AlterarCategoria(clsCategoria objCategoria) 
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@NomeCategoria";
            parametro.Value = objCategoria.NomeCategoria;
            parametro.DbType = System.Data.DbType.String;

            lstParametros.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodCategoria";
            parametro.Value = objCategoria.CodCategoria;
            parametro.DbType = System.Data.DbType.Int32;

            lstParametros.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Categoria_AlterarCategoria", lstParametros);
        }

        public DataTable PreencherProdutosNaCategoria(clsCategoria objCategoria)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCategoria";
            parametro.Value = objCategoria.CodCategoria;
            parametro.DbType = System.Data.DbType.Int32;

            return Banco.ExecuteProc("USP_CSharp_Categoria_PreencherProdutosNaCategoria", parametro);
        }

        public DataTable PreencherInsumosNaCategoria(clsCategoria objCategoria)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCategoria";
            parametro.Value = objCategoria.CodCategoria;
            parametro.DbType = System.Data.DbType.Int32;

            return Banco.ExecuteProc("USP_CSharp_Categoria_PreencherInsumosNaCategoria", parametro);
        }

        public DataTable ValidarCategoriaNoBanco(clsCategoria objCategoria)
        {
            List<SqlParameter> lista = new List<SqlParameter>();
            
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@NomeCategoria";
            parametro.Value = objCategoria.NomeCategoria;
            parametro.DbType = System.Data.DbType.String;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodCategoria";
            parametro.Value = objCategoria.CodCategoria;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Categoria_ValidarCategoriaNoBanco", lista);
        }

        public void InserirProdutoNaCategoria(clsCategoriaProduto objCategoriaProduto)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodProduto";
            parametro.Value = objCategoriaProduto.CodProduto;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodCategoria";
            parametro.Value = objCategoriaProduto.CodCategoria;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Categoria_InserirProdutoNaCategoria", lista);
        }

        public DataTable ValidaProdutoNaCategoria(clsCategoriaProduto objCategoriaProduto)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodProduto";
            parametro.Value = objCategoriaProduto.CodProduto;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodCategoria";
            parametro.Value = objCategoriaProduto.CodCategoria;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Categoria_ValidaProdutoNaCategoria", lista);
        }

        public void RemoverProdutoDaCategoria(clsCategoriaProduto objCategoriaProduto) 
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCategoria";
            parametro.Value = objCategoriaProduto.CodCategoria;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodProduto";
            parametro.Value = objCategoriaProduto.CodProduto;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Categoria_RemoverProdutoDaCategoria", lista);
        }

        public DataTable ValidaExclusaoCategoria(clsCategoria objCategoria)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCategoria";
            parametro.Value = objCategoria.CodCategoria;
            parametro.DbType = System.Data.DbType.Int32;

            return Banco.ExecuteProc("USP_CSharp_Categoria_ValidaExclusaoCategoria", parametro);
        }

        public DataTable ValidaInsumoNaCategoria(clsCategoriaInsumo objCategoriaInsumo)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodInsumo";
            parametro.Value = objCategoriaInsumo.CodInsumo;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodCategoria";
            parametro.Value = objCategoriaInsumo.CodCategoria;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Categoria_ValidaInsumoNaCategoria", lista);
        }

        public void InserirInsumoNaCategoria(clsCategoriaInsumo objCategoriaInsumo)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodInsumo";
            parametro.Value = objCategoriaInsumo.CodInsumo;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodCategoria";
            parametro.Value = objCategoriaInsumo.CodCategoria;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Categoria_InserirInsumoNaCategoria", lista);
        }

        public void RemoverInsumoDaCategoria(clsCategoriaInsumo objCategoriaInsumo) 
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCategoria";
            parametro.Value = objCategoriaInsumo.CodCategoria;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodInsumo";
            parametro.Value = objCategoriaInsumo.CodInsumo;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Categoria_RemoverInsumoDaCategoria", lista);
        }

        
    }
}
