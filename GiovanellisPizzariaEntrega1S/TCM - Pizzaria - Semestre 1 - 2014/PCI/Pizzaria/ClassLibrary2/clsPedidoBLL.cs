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
    public class clsPedidoBLL
    {
        private DAL.DAO.clsBanco Banco;
        public clsPedidoBLL()
        {
            Banco = new clsBanco();

        }

        ~clsPedidoBLL()
        {
            Banco = null;
        }



        public DataTable Relatorio_pedido(clsPedido objCliente)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "Data_Inicial";
            parametro.Value = objCliente.Data;
            parametro.DbType = System.Data.DbType.String;

            lista.Add(parametro);

            SqlParameter parametro1 = new SqlParameter();
            parametro1.ParameterName = "Data_Final";
            parametro1.Value = objCliente.DataFim;
            parametro1.DbType = System.Data.DbType.String;

            lista.Add(parametro1);
            DataTable dt = new DataTable();

            return dt = Banco.ExecuteProc("CSharp_Seleciona_pedido", lista);
        }


        public DataTable BuscarClientesPorNome(clsCliente objCliente) 
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Nome";
            parametro.Value = objCliente.Nome_Cliente;
            parametro.DbType = System.Data.DbType.String;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Pedidos_BuscarClientesPorNome", lista);
        }

        public DataTable BuscarClientesPorCPF(clsCliente objCliente)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CPF";
            parametro.Value = objCliente.Cpf_Cliente;
            parametro.DbType = System.Data.DbType.String;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Pedidos_BuscarClientesPorCPF", lista);
        }

        public DataTable BuscarPedidosDoCliente(clsPedido objPedido)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCliente";
            parametro.Value = objPedido.Cod_Cliente;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Pedidos_BuscarPedidosDoCliente", lista);
        }

        public void InserirNovoPedido(clsPedido objPedido)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodCliente";
            parametro.Value = objPedido.Cod_Cliente;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Data";
            parametro.Value = objPedido.Data;
            parametro.DbType = System.Data.DbType.Date;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Hora";
            parametro.Value = objPedido.Hora;
            parametro.DbType = System.Data.DbType.Time;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Pedidos_InserirNovoPedido", lista);
        }

        public DataTable ValidarExclusaoDePedido(clsPedido objPedido)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodPedido";
            parametro.Value = objPedido.Cod_Pedido;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Pedidos_ValidarExclusaoDePedido", lista);
        }

        public void ExcluirPedido(clsPedido objPedido)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodPedido";
            parametro.Value = objPedido.Cod_Pedido;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Pedidos_ExcluirPedido", lista);
        }

        public DataTable BuscarProdutosDoPedido(clsPedido objPedido)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodPedido";
            parametro.Value = objPedido.Cod_Pedido;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Pedidos_BuscarProdutosDoPedido", lista);
        }

        public DataTable BuscarProdutosPorPalavraChave(clsProduto objProduto)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Nome";
            parametro.Value = objProduto.Nome_Produto;
            parametro.DbType = System.Data.DbType.String;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Pedidos_BuscarProdutosPorPalavraChave", lista);
        }


        public DataTable BuscarProdutosPorID(clsProduto objProduto)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@ID";
            parametro.Value = objProduto.Cod_Produto;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Pedidos_BuscarProdutosPorID", lista);
        }

        public DataTable BuscarTodosProdutos()
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            return Banco.ExecuteProc("USP_CSharp_Pedidos_BuscarTodosProdutos", lista);
        }


        public void InserirProdutoNoPedido(clsProdutoPedido objProdutoPedido)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodProduto";
            parametro.Value = objProdutoPedido.CodProduto;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodPedido";
            parametro.Value = objProdutoPedido.CodPedido;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Pedidos_InserirProdutoNoPedido", lista);
        }

        public void AtualizarValor(clsPedido objPedido)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Valor";
            parametro.Value = objPedido.Valor;
            parametro.DbType = System.Data.DbType.Decimal;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodPedido";
            parametro.Value = objPedido.Cod_Pedido;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Pedidos_AtualizarValor", lista);
        }


        public void ExcluirProdutoDoPedido(clsProdutoPedido objProdutoPedido)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodProduto";
            parametro.Value = objProdutoPedido.CodProduto;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodPedido";
            parametro.Value = objProdutoPedido.CodPedido;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            Banco.ExecuteProc("USP_CSharp_Pedidos_ExcluirProdutoDoPedido", lista);
        }
    }
}
