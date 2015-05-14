using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL.Model;
using BLL;
//using DAL.DAO;


namespace Pizzaria
{
    public partial class Gerenciamento_Entregas : Form
    {
        public Gerenciamento_Entregas()
        {
            InitializeComponent();
           
        }
        public string cod;// { get; set; }
        private void Gerenciamento_Entregas_Load(object sender, EventArgs e)
        {
            preenche_grid();
            timer1.Start();
        }        
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (InvokeRequired)
                this.Invoke(new EventHandler(timer1_Tick), new object[] { sender, e });

            #region teste           
            /*
            clsPedido teste = new clsPedido();
            clsGerenciamentoEntregaBLL teste1 = new clsGerenciamentoEntregaBLL();
            teste.Data = dateDeData.Value.ToString("d");
            teste.DataFim = dateAteData.Value.ToString("d");

            if (chcCaminho.Checked)
                teste.Estado_Caminho = chcCaminho.Text.ToString();
            if (chcEntregue.Checked)
                teste.Estado_Entregue = chcEntregue.Text.ToString();
            if (chcNovos_Pedidos.Checked)
                teste.Estado_Novo = "Novo";
            GridPedidosP.DataSource = teste1.SelectPedido(teste);*/
            #endregion
            preenche_grid();
        }

        private void btnAterar_StatusP_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridPedidosP.SelectedCells[0].Value.ToString().Length > 0)
                {
                    Alterar_Status altera_status = new Alterar_Status(this);
                    //altera_status.MdiParent = this;
                    altera_status.Show();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnAlterar_StatusF_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridPedidosF.SelectedCells[0].Value.ToString().Length > 0)
                {
                    Alterar_Status altera_status = new Alterar_Status(this);
                    //altera_status.MdiParent = this;
                    altera_status.Show();
                }
            }
            catch (Exception ex)
            { 
            }
        }


        #region Valida_CheckBoxs

                private void chcNovos_Pedidos_CheckedChanged(object sender, EventArgs e)
                {
                    if (chcCaminho.Checked == false && chcPreparo.Checked == false && chcNovos_Pedidos.Checked == false)
                        chcNovos_Pedidos.Checked = true;
                }

                private void chcPreparo_CheckedChanged(object sender, EventArgs e)
                {
                    if (chcCaminho.Checked == false && chcPreparo.Checked == false && chcNovos_Pedidos.Checked == false)
                        chcPreparo.Checked = true;
                }

                private void chcCaminho_CheckedChanged(object sender, EventArgs e)
                {

                    if (chcCaminho.Checked == false && chcPreparo.Checked == false && chcNovos_Pedidos.Checked == false)
                        chcCaminho.Checked = true;
                }

                private void chcEntregue_CheckedChanged(object sender, EventArgs e)
                {
                    if (chcEntregue.Checked == false && chcCancelado.Checked == false)
                        chcEntregue.Checked = true;
                }

                private void chcCancelado_CheckedChanged(object sender, EventArgs e)
                {
                    if (chcEntregue.Checked == false && chcCancelado.Checked == false)
                        chcCancelado.Checked = true;
                }
        #endregion


        #region Seleciona_Produtos_e_Define_Campo_valor_ao_clicar_na_Celula

                private void GridPedidosF_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                    seleciona_produto();
                    txtTotalF.Text = GridPedidosF.SelectedCells[3].Value.ToString();
                    cod = GridPedidosF.SelectedCells[0].Value.ToString();

                }

                private void GridPedidosP_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                    seleciona_produto();
                    txtTotalP.Text = GridPedidosP.SelectedCells[3].Value.ToString();
                    cod = GridPedidosP.SelectedCells[0].Value.ToString();
                }

        #endregion

        #region Define_Cor_dos_GrideViwer

            // Define a cor das linhas do grideviwer da aba pendentes de acordo com campo Estado
            private void GridPedidosP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {
                if (this.GridPedidosP.Columns[e.ColumnIndex].Name == "Estado")
                {
                    if (e.Value != null && (string)e.Value == "Em preparo")
                    {
                        DataGridViewRow row = GridPedidosP.Rows[e.RowIndex];
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                        //  e.CellStyle.BackColor = Color.Red;
                    }
                    if (e.Value != null && (string)e.Value == "Novo")
                    {
                        DataGridViewRow row = GridPedidosP.Rows[e.RowIndex];
                        row.DefaultCellStyle.BackColor = Color.Gray;
                        //  e.CellStyle.BackColor = Color.Black;
                    }
                    if (e.Value != null && (string)e.Value == "A caminho")
                    {
                        DataGridViewRow row = GridPedidosP.Rows[e.RowIndex];
                        row.DefaultCellStyle.BackColor = Color.Aquamarine;
                        // e.CellStyle.BackColor = Color.Red;
                    }
                }

            }
            // Define a cor das linhas do grideviwer da aba Finalizado de acordo com campo Estado
            private void GridPedidosF_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {
                if (this.GridPedidosF.Columns[e.ColumnIndex].Name == "Estado")
                {
                    if (e.Value != null && (string)e.Value == "Finalizado")
                    {
                        DataGridViewRow row = GridPedidosF.Rows[e.RowIndex];
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        //  e.CellStyle.BackColor = Color.Red;
                    }
                    if (e.Value != null && (string)e.Value == "Cancelado")
                    {
                        DataGridViewRow row = GridPedidosF.Rows[e.RowIndex];
                        row.DefaultCellStyle.BackColor = Color.Red;
                        //  e.CellStyle.BackColor = Color.Black;
                    }

                }
            }

        #endregion
 
        //para que ao alterar entre os formularios seja preenchido os gridviwer
        private void tabGerenciamento_entrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            preenche_grid();
        }


        public void preenche_grid()
        {

            if (tabGerenciamento_entrega.SelectedIndex == 0)
            {
                #region Seleciona_Pedidos_Nao_Finalizados

                        clsPedido teste = new clsPedido();
                        clsGerenciamentoEntregaBLL teste1 = new clsGerenciamentoEntregaBLL();
                        teste.Data = dateDeData.Value.ToString("d");
                        teste.DataFim = dateAteData.Value.ToString("d");

                        if (chcCaminho.Checked)
                            teste.Estado_Caminho = chcCaminho.Text.ToString();
                        if (chcPreparo.Checked)
                            teste.Estado_Preparo = chcPreparo.Text.ToString();
                        if (chcNovos_Pedidos.Checked)
                            teste.Estado_Novo = "Novo";

                        GridPedidosP.DataSource = teste1.SelectPedido(teste);
                        GridPedidosP.Columns["Cod_Funcionario"].Visible = false;
                        GridPedidosP.Columns["Cod_Cliente"].Visible = false;   
             
                #endregion
            }
            else
            {
                #region Seleciona_Pedidos_Finalizados
                        clsPedido teste = new clsPedido();
                        clsGerenciamentoEntregaBLL teste1 = new clsGerenciamentoEntregaBLL();
                        teste.Data = DateDeData2.Value.ToString("d");
                        teste.DataFim = dateAteData2.Value.ToString("d");

                        if (chcCancelado.Checked)
                            teste.Estado_Cancelado = chcCancelado.Text.ToString();
                        if (chcEntregue.Checked)
                            teste.Estado_Entregue = "Finalizado";
                        GridPedidosF.DataSource = teste1.SelectPedido(teste);
                        GridPedidosF.Columns["Cod_Funcionario"].Visible = false;
                        GridPedidosF.Columns["Cod_Cliente"].Visible = false;
                #endregion
            }
        }

        private void seleciona_produto()
        {
            if (tabGerenciamento_entrega.SelectedIndex == 0)
            {
                if (GridPedidosP.SelectedCells[0].Value.ToString().Length > 0)
                {
                    clsProduto teste = new clsProduto();
                    clsGerenciamentoEntregaBLL teste1 = new clsGerenciamentoEntregaBLL();
                    teste.Cod_Produto = Convert.ToInt32(GridPedidosP.SelectedCells[0].Value.ToString());
                    GridProdutosP.DataSource = teste1.SelectProdutos(teste);
                }
            }
            else
            {
                if (GridPedidosF.SelectedCells[0].Value.ToString().Length > 0)
                {
                    clsProduto teste = new clsProduto();
                    clsGerenciamentoEntregaBLL teste1 = new clsGerenciamentoEntregaBLL();
                    teste.Cod_Produto = Convert.ToInt32(GridPedidosF.SelectedCells[0].Value.ToString());
                    GridProdutosF.DataSource = teste1.SelectProdutos(teste);
                }
            }
        }

        private void tabGerenciamento_entrega_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            preenche_grid();
        }

       
    }
}
