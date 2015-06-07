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
    public class clsGerenciamentoEntregaBLL
    {
        private DAL.DAO.clsBanco ObjBanco;              

          public clsGerenciamentoEntregaBLL()
            {
                ObjBanco = new clsBanco();

            }
          ~clsGerenciamentoEntregaBLL()
            {
                ObjBanco = null;
            }

        public DataTable SelectPedido(clsPedido objPedido)
        {
            List<SqlParameter> LstParametros = new List<SqlParameter>();

            SqlParameter ParametroCodCliente = new SqlParameter();
            ParametroCodCliente.ParameterName = "Cod_Cliente";
            ParametroCodCliente.Value = objPedido.Cod_Cliente;
            ParametroCodCliente.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroCodCliente);
            SqlParameter ParametroCodFuncionario = new SqlParameter();
            ParametroCodFuncionario.ParameterName = "Cod_Funcionario";
            ParametroCodFuncionario.Value = objPedido.Cod_Funcionario;
            ParametroCodFuncionario.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroCodFuncionario);
            SqlParameter ParametroValor = new SqlParameter();
            ParametroValor.ParameterName = "Valor";
            ParametroValor.Value = objPedido.Valor;
            ParametroValor.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroValor);
            SqlParameter ParametroHora = new SqlParameter();
            ParametroHora.ParameterName = "Hora";
            ParametroHora.Value = objPedido.Hora;
            ParametroHora.DbType = System.Data.DbType.Time;

            LstParametros.Add(ParametroHora);
            SqlParameter ParametroHoraFIM = new SqlParameter();
            ParametroHoraFIM.ParameterName = "HoraFim";
            ParametroHoraFIM.Value = objPedido.HoraFim;
            ParametroHoraFIM.DbType = System.Data.DbType.Time;

            LstParametros.Add(ParametroHoraFIM);
            SqlParameter ParametroData = new SqlParameter();
            ParametroData.ParameterName = "Data";
            ParametroData.Value = objPedido.Data;
            ParametroData.DbType = System.Data.DbType.Date;

            LstParametros.Add(ParametroData);
            SqlParameter ParametroDataFIM = new SqlParameter();
            ParametroDataFIM.ParameterName = "DataFIM";
            ParametroDataFIM.Value = objPedido.DataFim;
            ParametroDataFIM.DbType = System.Data.DbType.Date;

            LstParametros.Add(ParametroDataFIM);
            SqlParameter ParametroCodPedido = new SqlParameter();
            ParametroCodPedido.ParameterName = "Cod_Pedido";
            ParametroCodPedido.Value = objPedido.Cod_Pedido;
            ParametroCodPedido.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroCodPedido);
            SqlParameter ParametroObservacao = new SqlParameter();
            ParametroObservacao.ParameterName = "Observacao";
            ParametroObservacao.Value = objPedido.Observacao;
            ParametroObservacao.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroObservacao);
            SqlParameter ParametroEstado_Entregue = new SqlParameter();
            ParametroEstado_Entregue.ParameterName = "Estado_Entregue";
            ParametroEstado_Entregue.Value = objPedido.Estado_Entregue;
            ParametroEstado_Entregue.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroEstado_Entregue);
            SqlParameter ParametroEstado_Caminho = new SqlParameter();
            ParametroEstado_Caminho.ParameterName = "Estado_Caminho";
            ParametroEstado_Caminho.Value = objPedido.Estado_Caminho;
            ParametroEstado_Caminho.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroEstado_Caminho);
            SqlParameter ParametroEstado_Preparo = new SqlParameter();
            ParametroEstado_Preparo.ParameterName = "Estado_Preparo";
            ParametroEstado_Preparo.Value = objPedido.Estado_Preparo;
            ParametroEstado_Preparo.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroEstado_Preparo);
            SqlParameter ParametroEstado_Cancelado = new SqlParameter();
            ParametroEstado_Cancelado.ParameterName = "Estado_Cancelado";
            ParametroEstado_Cancelado.Value = objPedido.Estado_Cancelado;
            ParametroEstado_Cancelado.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroEstado_Cancelado);
            SqlParameter ParametroEstado_Novo = new SqlParameter();
            ParametroEstado_Novo.ParameterName = "Estado_Novo";
            ParametroEstado_Novo.Value = objPedido.Estado_Novo;
            ParametroEstado_Novo.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroEstado_Novo);
            SqlParameter ParametroFormaDePagamento = new SqlParameter();
            ParametroFormaDePagamento.ParameterName = "FormaDePagamento";
            ParametroFormaDePagamento.Value = objPedido.FormaDePagamento;
            ParametroFormaDePagamento.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroFormaDePagamento);

            DataTable dt = ObjBanco.ExecuteProc("USP_CSharp_Entregas_SelectPedidos", LstParametros);
            return dt;
        }

        public DataTable SelectProdutos(clsProduto objProduto)
        {
            List<SqlParameter> LstParametros = new List<SqlParameter>();

            SqlParameter ParametroCodCliente = new SqlParameter();
            ParametroCodCliente.ParameterName = "cod_Pedido";
            ParametroCodCliente.Value = objProduto.Cod_Produto;
            ParametroCodCliente.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroCodCliente);

            DataTable dt = ObjBanco.ExecuteProc("USP_CSharp_GerenciamentoEntregas_Seleciona_Produtos", LstParametros);
            return dt;
        }

        public DataTable UpdatePedidos(clsPedido objPedido)
        {
            List<SqlParameter> LstParametros = new List<SqlParameter>();

            SqlParameter ParametroCodPedido = new SqlParameter();
            ParametroCodPedido.ParameterName = "cod_Pedido";
            ParametroCodPedido.Value = objPedido.Cod_Pedido;
            ParametroCodPedido.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroCodPedido);

            SqlParameter ParametroEstado = new SqlParameter();
            ParametroEstado.ParameterName = "Estado";
            ParametroEstado.Value = objPedido.Estado;
            ParametroEstado.DbType = System.Data.DbType.String;

            LstParametros.Add(ParametroEstado);


            DataTable dt = ObjBanco.ExecuteProc("USP_CSharp_GerenciamentoEntrega_UpdatePedido", LstParametros);


            return dt;
        }

        public DataTable ProdutosNoPedido(clsPedido objPedido) 
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodPedido";
            parametro.Value = objPedido.Cod_Pedido;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            DataTable asdf = ObjBanco.ExecuteProc("USP_CSharp_ConfirmacaoAlterarStatus_ProdutosNoPedido", lista);

            return asdf;
        }

        public DataTable AbaterInsumo(clsProduto objProduto) 
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodProduto";
            parametro.Value = objProduto.Cod_Produto;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return ObjBanco.ExecuteProc("USP_CSharp_ConfirmacaoAlterarStatus_AbaterInsumo", lista);
        }

        public DataTable ChecarEstadoPedido(clsPedido objPedido) 
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodPedido";
            parametro.Value = objPedido.Cod_Pedido;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            return ObjBanco.ExecuteProc("USP_CSharp_ConfirmacaoAlterarStatus_ChecarEstadoPedido", lista);
        }

        public void AtribuirEntregador(clsPedido objPedido)
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@CodPedido";
            parametro.Value = objPedido.Cod_Pedido;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@CodFuncionario";
            parametro.Value = objPedido.Cod_Funcionario;
            parametro.DbType = System.Data.DbType.Int32;

            lista.Add(parametro);

            ObjBanco.ExecuteProc("USP_CSharp_Entregas_AtribuirEntregador", lista);
        }
    }
}
