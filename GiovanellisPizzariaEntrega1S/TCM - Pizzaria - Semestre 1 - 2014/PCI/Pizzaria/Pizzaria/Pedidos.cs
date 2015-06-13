using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

using BLL;
using DAL.DAO;
using DAL.Model;

namespace Pizzaria
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        clsPedidoBLL pedidos = new clsPedidoBLL();
        //TODO: Limpar comentários
        public void preencherGrid(string busca, DataGridView tabela)
        {/*
            //conexao = "Data Source=localhost; Initial Catalog=Pizzaria; Persist Security Info = True; User ID=SA; Password=peganomeupau";
          //  conexao = "Data Source=Tuca\\SQLEXPRESS; Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=peganomeupau";
            //SqlConnection conn = new SqlConnection(conexao);
            
            //conn.Open();
            SqlCommand sqlComm = new SqlCommand(busca, conn);
//            sqlComm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabela.DataSource = dt;
            conn.Close();*/
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

            for (int x = 0; x < gridProdutosConsumidos.Rows.Count - 1; x++)
            {
                saldo += Convert.ToDouble(gridProdutosConsumidos.Rows[x].Cells[2].Value);
            }

            txtTotal.Text = saldo.ToString();

            clsPedido objPedido = new clsPedido();
            objPedido.Cod_Pedido = gridPedidosClientes.CurrentRow.Cells[0].Value.ToString();
            objPedido.Valor = txtTotal.Text;

            gridProdutosConsumidos.DataSource = pedidos.BuscarProdutosDoPedido(objPedido);

            pedidos.AtualizarValor(objPedido);
        }

        public Form FormHome { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            this.FormHome.Show();
            Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            //conexao = Acesso.Conexao;

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
            string cpf = txtCPF.Text.ToString();

            clsCliente objCliente = new clsCliente();
            objCliente.Nome_Cliente = txtNome.Text.ToString();

            gridClientesEncontrados.DataSource = pedidos.BuscarClientesPorNome(objCliente);

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
            //conexao = Rede.DataContainer.conexaoGlobal;
        }


        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            clsCliente objCliente = new clsCliente();
            objCliente.Cpf_Cliente = txtCPF.Text;

            gridClientesEncontrados.DataSource = pedidos.BuscarClientesPorCPF(objCliente);

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
            clsPedido objPedido = new clsPedido();
            objPedido.Cod_Cliente = gridClientesEncontrados.CurrentRow.Cells[0].Value.ToString();

            gridPedidosClientes.DataSource = pedidos.BuscarPedidosDoCliente(objPedido);

/*            for (int i = 0; i < gridPedidosClientes.RowCount; i++)
            {
                string data = "";

                if(gridPedidosClientes.Rows[i].Cells[1].Value != null)
                    data = gridPedidosClientes.Rows[i].Cells[1].Value.ToString();


                if(data.Length != 0)
                    for (int j = 0; j < data.Length; j++)
                        if (j == 4 || j == 7)
                            data = data.Insert(j, "/");

                data.Remove(9);

                    gridPedidosClientes.Rows[i].Cells[1].Value = data;
            }*/

//            for (int i = 0; i < gridPedidosClientes.Columns.Count; i++)
  //              gridPedidosClientes.Columns[i].Width = 70;

            txtPalavraChave.Clear();
            txtIDProduto.Clear();
            btn_inserir.Enabled = false;
            limparGrid(gridProdutosEncontrados);
            limparGrid(gridProdutosConsumidos);
            btn_remover.Enabled = false;

            btnRemoverPedido.Enabled = true;
            btnNovoPedido.Enabled = true;
            
        }

        private void gridPedidosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clsPedido objPedido = new clsPedido();
            objPedido.Cod_Pedido = gridPedidosClientes.CurrentRow.Cells[0].Value.ToString();

            gridProdutosConsumidos.DataSource = pedidos.BuscarProdutosDoPedido(objPedido);
            
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
            clsProduto objProduto = new clsProduto();
            objProduto.Nome_Produto = txtPalavraChave.Text;

            gridProdutosEncontrados.DataSource = pedidos.BuscarProdutosPorPalavraChave(objProduto);

            btn_inserir.Enabled = true;
            btn_remover.Enabled = true;
        }

        private void txtIDProduto_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtIDProduto.Text.Length; i++)
                if (!char.IsNumber(txtIDProduto.Text[i]))
                {
                    Home.mensagemDeErro("É permitido apenas o uso de números no campo \"Busca por ID\".","Símbolos proibidos em busca");
                    txtIDProduto.Clear();
                    txtIDProduto.Focus();
                }

            if (Int32.Parse(txtIDProduto.Text) > 0)
            {
                clsProduto objProduto = new clsProduto();
                objProduto.Cod_Produto = Int32.Parse(txtIDProduto.Text);

                gridProdutosEncontrados.DataSource = pedidos.BuscarProdutosPorID(objProduto);
            }
            else
            {
                gridProdutosEncontrados.DataSource = pedidos.BuscarTodosProdutos();
            }

            txtPalavraChave.Clear();
            btn_inserir.Enabled = true;
            btn_remover.Enabled = true;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            clsProdutoPedido objProdutoPedido = new clsProdutoPedido();
            objProdutoPedido.CodProduto = (int)gridProdutosEncontrados.CurrentRow.Cells[0].Value;
            objProdutoPedido.CodPedido = (int)gridPedidosClientes.CurrentRow.Cells[0].Value;

            pedidos.InserirProdutoNoPedido(objProdutoPedido);

            calcularSaldo();
        }

        private void gridProdutosEncontrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            clsProdutoPedido objProdutoPedido = new clsProdutoPedido();
            objProdutoPedido.CodPedido = (int)gridPedidosClientes.CurrentRow.Cells[0].Value;
            objProdutoPedido.CodProduto = (int)gridProdutosConsumidos.CurrentRow.Cells[0].Value;

            pedidos.ExcluirProdutoDoPedido(objProdutoPedido);

            clsPedido objPedido = new clsPedido();
            objPedido.Cod_Pedido = objProdutoPedido.CodPedido.ToString();

            gridProdutosConsumidos.DataSource = pedidos.BuscarProdutosDoPedido(objPedido);

            calcularSaldo();
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
        }
        
        private void mtxtAjuste_Leave(object sender, EventArgs e)
        {

        }

        private void txtAjuste_Leave_1(object sender, EventArgs e)
        {
        }

        private void btnGravarAjuste_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsPedido objPedido = new clsPedido();
            objPedido.Cod_Pedido = gridPedidosClientes.CurrentRow.Cells[0].Value.ToString();

            if ((int)pedidos.ValidarExclusaoDePedido(objPedido).Rows[0][0] > 0) 
            {
                Home.mensagemDeErro("Esse pedido não pode ser excluido, porque possui associações com outras partes do sistema.","Exclusão negada");

                return;
            }

            pedidos.ExcluirPedido(objPedido);

            objPedido.Cod_Cliente = gridClientesEncontrados.CurrentRow.Cells[0].Value.ToString();

            gridPedidosClientes.DataSource = pedidos.BuscarPedidosDoCliente(objPedido);
        }

        private void txtNovoPedido_Click(object sender, EventArgs e)
        {
            clsPedido objPedido = new clsPedido();
            objPedido.Cod_Cliente = gridClientesEncontrados.CurrentRow.Cells[0].Value.ToString();
            objPedido.Data = DateTime.Today.ToString("dd/MM/yyyy"); 
            objPedido.Hora = DateTime.Now.ToString("HH:mm"); 

            pedidos.InserirNovoPedido(objPedido);

            gridPedidosClientes.DataSource = pedidos.BuscarPedidosDoCliente(objPedido);
        }

        private void txtAjuste_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAjuste_Enter_1(object sender, EventArgs e)
        {
        }
    }
}