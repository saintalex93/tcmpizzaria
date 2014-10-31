﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Pizzaria
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        string conexao = "";

        public void preencherGrid(string busca, DataGridView tabela)
        {
            conexao = "Data Source=Tuca\\SQLEXPRESS; Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=peganomeupau";
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(busca, conn);
//            sqlComm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabela.DataSource = dt;
            conn.Close();
        }

        public void limparGrid(DataGridView tabela)
        {
            tabela.DataSource = null;
            tabela.Rows.Clear();
        }

        public void atualizarGridProdutosConsumidos() 
        {
            preencherGrid("select Cod_Detalhe as [Nº Pedido], Produto.Cod_Produto as [ID Produto], Produto.Nome_Produto as [Produto], Produto.Valor_Venda as [Preço] from Pedido inner join Detalhe_Pedido on Pedido.Cod_Pedido = Detalhe_Pedido.Cod_Pedido inner join Produto on Detalhe_Pedido.Cod_Produto = Produto.Cod_Produto where Detalhe_Pedido.Cod_Pedido =" + gridPedidosClientes.CurrentRow.Cells[0].Value.ToString(), gridProdutosConsumidos);
        }

        public void atualizarSaldo() 
        {
        
//        select sum (Produto.Valor_Venda) as [Preço] from Pedido inner join Detalhe_Pedido on Pedido.Cod_Pedido = Detalhe_Pedido.Cod_Pedido inner join Produto on Detalhe_Pedido.Cod_Produto = Produto.Cod_Produto where Detalhe_Pedido.Cod_Pedido = 1

        }

        public void calcularSaldo() 
        {
            double saldo = 0;
            double ajuste = 0;
            double total = 0;

            for (int x = 0; x < gridProdutosConsumidos.Rows.Count; x++)
            {
                saldo += Convert.ToDouble(gridProdutosConsumidos.Rows[x].Cells[3].Value);
            }

            txtSaldo.Text = saldo.ToString();

//            ajuste = Convert.ToDouble(txtAjuste.Text/*.Replace("_", "").Replace(",", ".")*/);

            total = saldo - ajuste;

            txtTotal.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
        }

        private void gpb_detalhamento_Enter(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            txtCPF.Text = "";

            preencherGrid("select Cod_Cliente, Nome_Cliente ,CPF_Cliente from cliente where Nome_Cliente like ('%" + txtNome.Text + "%')", gridClientesEncontrados);

            txtCPF.Clear();
            limparGrid(gridPedidosClientes);
            txtPalavraChave.Clear();
            txtPalavraChave.Enabled = false;
            txtIDProduto.Clear();
            txtIDProduto.Enabled = false;
            btn_inserir.Enabled = false;
            limparGrid(gridProdutosEncontrados);
            limparGrid(gridProdutosConsumidos);
            btn_remover.Enabled = false;
        }

        private void Pedidos_Shown(object sender, EventArgs e)
        {
            conexao = Rede.DataContainer.conexaoGlobal;
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            txtNome.Text = "";

            string cpf = txtCPF.Text.Replace("-", "").Replace(".", "").Replace(" ","");

            preencherGrid("select Cod_Cliente, Nome_Cliente ,CPF_Cliente from cliente where CPF_Cliente like ('%" + cpf + "%')", gridClientesEncontrados);

            txtNome.Clear();
            txtPalavraChave.Clear();
            txtIDProduto.Clear();
            btn_inserir.Enabled = false;
            limparGrid(gridProdutosEncontrados);
            limparGrid(gridProdutosConsumidos);
            btn_remover.Enabled = false;
        }

        private void txtCPFTeste_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridClientesEncontrados_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridPedidosClientes_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridClientesEncontrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(gridClientesEncontrados.CurrentRow.Cells[0].Value);

            preencherGrid("select Cod_Pedido, Data, Hora from pedido where Cod_Cliente like ('%" + id + "%')", gridPedidosClientes);

            for (int i = 0; i < gridPedidosClientes.Columns.Count; i++)
                gridPedidosClientes.Columns[i].Width = 70;

            txtPalavraChave.Clear();
            txtIDProduto.Clear();
            btn_inserir.Enabled = false;
            limparGrid(gridProdutosEncontrados);
            limparGrid(gridProdutosConsumidos);
            btn_remover.Enabled = false;
            
        }

        private void gridPedidosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(gridPedidosClientes.CurrentRow.Cells[0].Value);

            atualizarGridProdutosConsumidos();
            
            for (int i = 0; i < gridProdutosConsumidos.Columns.Count; i++)
                gridProdutosConsumidos.Columns[i].Width = 85;

            txtPalavraChave.Clear();
            txtIDProduto.Clear();
            txtPalavraChave.Enabled = true;
            txtIDProduto.Enabled = true;
            btn_inserir.Enabled = false;
            limparGrid(gridProdutosEncontrados);
            btn_remover.Enabled = true;

            calcularSaldo();

        }

        private void txt_palavrachave_TextChanged(object sender, EventArgs e)
        {
            txtIDProduto.Clear();

            preencherGrid("select Cod_Produto as [ID Produto],  Nome_Produto as [Produto], Valor_Venda as [Preço] from Produto where Nome_Produto like ('%" + txtPalavraChave.Text + "%')", gridProdutosEncontrados);

            txtIDProduto.Clear();
            btn_inserir.Enabled = true;
            btn_remover.Enabled = true;
        }

        private void txtIDProduto_TextChanged(object sender, EventArgs e)
        {
            txtPalavraChave.Clear();

            for (int i = 0; i < txtIDProduto.Text.Length; i++)
                if (!char.IsNumber(txtIDProduto.Text[i]))
                {
                    Fornecedores.mensagemDeErro("É permitido apenas o uso de números no campo \"Busca por ID\".");
                    txtIDProduto.Clear();
                    txtIDProduto.Focus();
                }

            preencherGrid("select Cod_Produto as [ID Produto],  Nome_Produto as [Produto], Valor_Venda as [Preço] from Produto where Cod_Produto like ('%" + txtIDProduto.Text + "%')", gridProdutosEncontrados);

            txtPalavraChave.Clear();
            btn_inserir.Enabled = true;
            btn_remover.Enabled = true;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            string idProduto = "";
            string idPedido = "";

            idPedido = gridPedidosClientes.CurrentRow.Cells[0].Value.ToString();
            idProduto = gridProdutosEncontrados.CurrentRow.Cells[0].Value.ToString();

            preencherGrid("insert into Detalhe_Pedido(Cod_pedido, Cod_Produto) values(" + idPedido + ", "+ idProduto +")", gridProdutosConsumidos);

            atualizarGridProdutosConsumidos();
        }

        private void gridProdutosEncontrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            string id = "";

            id = gridProdutosConsumidos.CurrentRow.Cells[0].Value.ToString();

            preencherGrid("delete from Detalhe_Pedido where Cod_Detalhe = " + id, gridProdutosConsumidos);

            atualizarGridProdutosConsumidos();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.Aquamarine;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.White;
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.BackColor = Color.Aquamarine;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            txtCPF.BackColor = Color.White;
        }

        private void txtPalavraChave_Enter(object sender, EventArgs e)
        {
            txtPalavraChave.BackColor = Color.Aquamarine;
        }

        private void txtPalavraChave_Leave(object sender, EventArgs e)
        {
            txtPalavraChave.BackColor = Color.White;
        }

        private void txtIDProduto_Enter(object sender, EventArgs e)
        {
            txtIDProduto.BackColor = Color.Aquamarine;
        }

        private void txtIDProduto_Leave(object sender, EventArgs e)
        {
            txtIDProduto.BackColor = Color.White;
        }

        private void txtAjuste_Enter(object sender, EventArgs e)
        {
//            txtAjuste.BackColor = Color.Aquamarine;
        }

        private void txtAjuste_Leave(object sender, EventArgs e)
        {
            txtAjuste.BackColor = Color.White;

            if (txtSaldo.Text != "")
            {

                string strAjuste = txtAjuste.Text.Replace(".","");

                for (int i = 0; i < strAjuste.Length; i++)
                    if (!char.IsNumber(strAjuste[i]))
                    {
                        Fornecedores.mensagemDeErro("É permitido apenas o uso de números no campo \"Ajuste\".");
                        txtAjuste.Clear();
                        txtAjuste.Focus();
                    }

                strAjuste = strAjuste.Insert(strAjuste.Length - 2, ".");

            }
            else
            {
                Fornecedores.mensagemDeErro("Este pedido ainda não possui nenhum produto.\n\nAntes de adicionar algum ajuste, tenha certeza que o pedido tenha algo a ser ajustado.");

                txtSaldo.Text = "0";
                txtAjuste.Clear();
                txtSaldo.Clear();
            }
        }

        private void txtAjuste_TextChanged(object sender, EventArgs e)
        {

                
            


        }

/*        private void mtxtAjuste_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mtxtAjuste_Leave(object sender, EventArgs e)
        {
            double saldo = 0;
            double ajuste = 0;
            double total = 0;

            Double.TryParse(txtSaldo.Text, out saldo);
            Double.TryParse(mtxtAjuste.Text, out ajuste);
            Double.TryParse(txtTotal.Text, out total);

            if (ajuste > saldo)
            {
                ajuste = saldo;
                mtxtAjuste.Text = Convert.ToString(ajuste);
                mtxtAjuste.Text.PadLeft(6);

            
            }

            total = saldo - ajuste;

            txtTotal.Text = total.ToString();

            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            SqlCommand sqlComm = new SqlCommand("update Pedido set Ajuste =" + mtxtAjuste.Text + "where cod_Pedido =" + gridPedidosClientes.CurrentRow.Cells[0].Value.ToString(), conn);
            sqlComm.ExecuteNonQuery();
        }*/

        /*
        UPDATE table_name
        SET column1=value1,column2=value2,...
        WHERE some_column=some_value;
         */


       
        


    }
}