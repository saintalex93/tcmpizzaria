using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using DAL.DAO;
using DAL.Model;

namespace Pizzaria
{
    public partial class Alterar_Status : Form
    {
        Gerenciamento_Entregas teste; // = new Gerenciamento_Entregas();

        clsFuncionarioBLL funcionario = new clsFuncionarioBLL();

        public Form FormHome { get; set; }
        
        public string cod;
        public string status;

        public Alterar_Status(Gerenciamento_Entregas frm1)
        {
            InitializeComponent();

            teste =  frm1;
            txtCod_Pedido.Text = teste.cod;
        }

        private void Alterar_Status_Load(object sender, EventArgs e)
        {
            cmbStatus_Pedido.SelectedIndex = 0;
            txtCod_Pedido.Text = teste.cod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status = cmbStatus_Pedido.SelectedItem.ToString();
            cod = txtCod_Pedido.Text;

            DialogResult resultado = MessageBox.Show
                (
                "Alterar estado do Pedido para \"" + status + "\"?",
                "Alterar estado",
                MessageBoxButtons.YesNo
                );

            if (resultado == System.Windows.Forms.DialogResult.Yes)
                AlterarEstado();
        }

        void AlterarEstado() 
        {
            clsGerenciamentoEntregaBLL entrega = new clsGerenciamentoEntregaBLL();
            clsPedido objPedido = new clsPedido();

            objPedido.Estado = status;
            objPedido.Cod_Pedido = cod;

            if (objPedido.Estado.ToLower() == "a caminho")
            {
                objPedido.Cod_Funcionario = cbEntregador.SelectedValue.ToString();

                entrega.AtribuirEntregador(objPedido);
            }
                

            if (!ValidaAlteracao(objPedido, entrega))
                return;

            entrega.UpdatePedidos(objPedido);

            if (objPedido.Estado.ToLower() == "em preparo")
            {
                DataTable produtosNoPedido = entrega.ProdutosNoPedido(objPedido);
                clsProduto objProduto = new clsProduto();

                for (int i = 0; i < produtosNoPedido.Rows.Count; i++)
                {
                    objProduto.Cod_Produto = (int)produtosNoPedido.Rows[i][0];

                    entrega.AbaterInsumo(objProduto);
                }
            }

            FormHome.Enabled = true;

            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHome.Enabled = true;

            this.Dispose();
        }

        void mensagemErroSequencia(string inicial, string final)
        {
            MessageBox.Show
                (
                    "Pedidos marcados como \"" + inicial + "\" só podem ser alterados para \"" + final + "\".",
                    "Erro na sequência",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
        }

        bool ValidaAlteracao(clsPedido objPedido, clsGerenciamentoEntregaBLL entrega)
        {
            string estadoBanco = (string)entrega.ChecarEstadoPedido(objPedido).Rows[0][0];

            if
            (
                estadoBanco.ToLower() == "na fila" 
                && 
                (
                    objPedido.Estado.ToLower() != "em preparo" 
                    || 
                    objPedido.Estado.ToLower() != "cancelado"
                )
            )
            {
                mensagemErroSequencia("Na fila", "Em preparo");

                return false;
            }

            else if
            (estadoBanco.ToLower() == "em preparo" && objPedido.Estado.ToLower() != "a caminho"
            )
            {
                mensagemErroSequencia("Em preparo", "A caminho");

                return false;
            }

            else if
            (
                estadoBanco.ToLower() == "a caminho"
                &&
                (
                    objPedido.Estado.ToLower() != "cancelado" || objPedido.Estado.ToLower() != "realizado"
                )
            )
            {
                mensagemErroSequencia("A caminho", "Cancelado\" ou \"Realizado");

                return false;
            }

            else if
            (estadoBanco.ToLower() == "cancelado" && objPedido.Estado.ToLower() != "realizado")
            {
                mensagemErroSequencia("Cancelado", "Realizado");

                return false;
            }

            else if
            (estadoBanco.ToLower() == "realizado" && objPedido.Estado.ToLower() != "cancelado")
            {
                mensagemErroSequencia("Realizado", "Cancelado");

                return false;
            }

            return true;
        }

        private void cmbStatus_Pedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus_Pedido.Text.ToLower() == "a caminho")
            {
                cbEntregador.Enabled = true;

                cbEntregador.DataSource = funcionario.SelecionaEntregadores();
                cbEntregador.DisplayMember = "Nome_Func";
                cbEntregador.ValueMember = "Cod_Funcionario";
            }
            else
            {
                cbEntregador.Enabled = false;
                cbEntregador.DataSource = null;
            }
                
        }
    }
}
