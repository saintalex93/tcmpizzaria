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

            DialogResult resultado = MessageBox.Show(
                "Alterar estado do Pedido para \"" + status + "\"?",
                "Alterar estado",
                MessageBoxButtons.YesNo);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
                AlterarEstado();
        }

        void AlterarEstado() 
        {
            clsGerenciamentoEntregaBLL entrega = new clsGerenciamentoEntregaBLL();
            clsPedido objPedido = new clsPedido();

            objPedido.Estado = status;
            objPedido.Cod_Pedido = cod;

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
            this.Dispose();
        }

        string mensagemErroSequencia(string inicial, string final)
        {
            return "Pedidos marcados como \"" + inicial + " só podem ser alterados para \"" + final + "\".";
        }

        bool ValidaAlteracao(clsPedido objPedido, clsGerenciamentoEntregaBLL entrega)
        {
            string estadoBanco = (string)entrega.ChecarEstadoPedido(objPedido).Rows[0][0];

            if
            (estadoBanco.ToLower() == "na fila" && objPedido.Estado.ToLower() != "em preparo")
            {
                mensagemErroSequencia("na fila", "em preparo");

                return false;
            }

            else if
            (estadoBanco.ToLower() == "em preparo" && objPedido.Estado.ToLower() != "a caminho"
            )
            {
                mensagemErroSequencia("em preparo", "e caminho");

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
                mensagemErroSequencia("a caminho", "cancelado\" ou \"realizado");

                return false;
            }

            else if
            (estadoBanco.ToLower() == "cancelado" && objPedido.Estado.ToLower() != "realizado")
            {
                mensagemErroSequencia("cancelado", "realizado");

                return false;
            }

            else if
            (estadoBanco.ToLower() == "realizado" && objPedido.Estado.ToLower() != "cancelado")
            {
                mensagemErroSequencia("realizado", "cancelado");

                return false;
            }

            return true;
        }
    }
}
