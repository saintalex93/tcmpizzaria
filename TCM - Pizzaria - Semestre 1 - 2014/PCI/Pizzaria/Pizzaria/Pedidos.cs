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
            //conexao = "Data Source=localhost; Initial Catalog=Pizzaria; Persist Security Info = True; User ID=SA; Password=peganomeupau";
          //  conexao = "Data Source=Tuca\\SQLEXPRESS; Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=peganomeupau";
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
            conexao = Acesso.Conexao;

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
            //conexao = Rede.DataContainer.conexaoGlobal;
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            txtNome.Text = "";

            string cpfOriginal = txtCPF.Text/*.Replace(" ", "").Replace(".", "").Replace(" ","")*/;
            string cpfCorrigido = "";
            bool primeiroNumeroDoStringEncontardo = false;
            int i = 0;

            if (txtCPF.Text != "   .   .   -")
            {
                while (!primeiroNumeroDoStringEncontardo)
                {
                    if (char.IsNumber(cpfOriginal[i]))
                        break;
                    i++;
                }
               
                for (int j = i; j < cpfOriginal.Length; j++)
                    if (cpfOriginal[j].ToString() != " ")
                        cpfCorrigido += cpfOriginal[j].ToString();
                    else
                        break;
            }
               
            preencherGrid("select Cod_Cliente, Nome_Cliente ,CPF_Cliente from cliente where CPF_Cliente like ('%" + cpfCorrigido + "%')", gridClientesEncontrados);

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

            for (int i = 0; i < gridPedidosClientes.RowCount - 1; i++)
            {
                string data = "";

                if(gridPedidosClientes.Rows[i].Cells[1].Value != null)
                    data = (string)gridPedidosClientes.Rows[i].Cells[1].Value;


                if(data.Length != 0)
                    for (int j = 0; j < data.Length; j++)
                        if (j == 4 || j == 7)
                            data = data.Insert(j, "/");

                    gridPedidosClientes.Rows[i].Cells[1].Value = data;
            }

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
            int id = Convert.ToInt32(gridPedidosClientes.CurrentRow.Cells[0].Value);

            atualizarGridProdutosConsumidos();
            
//            for (int i = 0; i < gridProdutosConsumidos.Columns.Count; i++)
  //              gridProdutosConsumidos.Columns[i].Width = 85;

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

//            for (int i = 0; i < gridProdutosConsumidos.Columns.Count; i++)
  
            
//            gridProdutosConsumidos.Columns[i].Width = 85;

            calcularSaldo();
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

//            for (int i = 0; i < gridProdutosConsumidos.Columns.Count; i++)
  //              gridProdutosConsumidos.Columns[i].Width = 85;

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
            if (txtAjuste.Text == "")
                btnGravarAjuste.Enabled = false;
        }
        
        private void mtxtAjuste_Leave(object sender, EventArgs e)
        {

        }

        private void txtAjuste_Leave_1(object sender, EventArgs e)
        {
            txtAjuste.BackColor = Color.White;
        }

        private void btnGravarAjuste_Click(object sender, EventArgs e)
        {
            if (txtAjuste.Text.Contains(".")) 
            {
                Fornecedores.mensagemDeErro("Por favor, use vírgula (,) no lugar de ponto (.).");
                return;
            }
                

            decimal decSaldo = 0;
            decimal decAjuste = 0;
            decimal decTotal = 0;

            decSaldo = Convert.ToDecimal(txtSaldo.Text);
            decAjuste = Convert.ToDecimal(txtAjuste.Text);

            if (decAjuste > decSaldo)
                decAjuste = decSaldo;
            
            decTotal = decSaldo - decAjuste;

            txtAjuste.Text = decAjuste.ToString();
            txtTotal.Text = decTotal.ToString();

            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            SqlCommand sqlComm = new SqlCommand("update Pedido set Ajuste = " + decAjuste.ToString().Replace(",", ".") + ", Valor = "+decSaldo.ToString().Replace(",", ".")+ " where cod_Pedido =" + gridPedidosClientes.CurrentRow.Cells[0].Value.ToString(), conn);
            sqlComm.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult decisao = MessageBox.Show("Tem certeza que deseja remover esse pedido?", "Remover Pedido", MessageBoxButtons.YesNo);
            if (decisao == DialogResult.Yes)
            {
                int idCliente = Convert.ToInt32(gridClientesEncontrados.CurrentRow.Cells[0].Value);
                int idPedido = Convert.ToInt32(gridPedidosClientes.CurrentRow.Cells[0].Value);

                preencherGrid("DELETE FROM detalhe_pedido where Cod_Pedido =" + idPedido, gridPedidosClientes);

                preencherGrid("DELETE FROM pedido where Cod_Pedido =" + idPedido, gridPedidosClientes);

                preencherGrid("select Cod_Pedido, Data, Hora from pedido where Cod_Cliente like ('%" + idCliente + "%')", gridPedidosClientes);

//                for (int i = 0; i < gridPedidosClientes.Columns.Count; i++)
  //                  gridPedidosClientes.Columns[i].Width = 70;
            }
            else if (decisao == DialogResult.No)
            {
                return;
            }
        }

        private void txtNovoPedido_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridClientesEncontrados.CurrentRow.Cells[0].Value);

            DateTime hoje = DateTime.Today;
            DateTime agora = DateTime.Now;
            
            preencherGrid("insert into Pedido(Cod_Cliente, Data, Hora, Valor) values ("+
                gridClientesEncontrados.CurrentRow.Cells[0].Value + ", '" +
                hoje.ToString("dd/MM/yyyy") + "', '"+
                agora.ToString("HH:mm") + "', " +
                "0)", gridPedidosClientes);

            preencherGrid("select Cod_Pedido, Data, Hora from pedido where Cod_Cliente like ('%" + id + "%')", gridPedidosClientes);

//            for (int i = 0; i < gridPedidosClientes.Columns.Count; i++)
  //              gridPedidosClientes.Columns[i].Width = 70;
        }

        private void txtAjuste_TextChanged(object sender, EventArgs e)
        {
            if(txtSaldo.Text != "")
                btnGravarAjuste.Enabled = true;
        }

        private void txtAjuste_Enter_1(object sender, EventArgs e)
        {
            txtAjuste.BackColor = Color.Aquamarine;
        }
    }
}