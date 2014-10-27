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


namespace Pizzaria
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        string conexao = "Data Source=Tuca\\SQLEXPRESS; Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=peganomeupau";

        public void preencherGrid(string busca, DataGridView tabela)
        {
            conexao = "Data Source=Tuca\\SQLEXPRESS; Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=peganomeupau";
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(busca, conn);
            sqlComm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabela.DataSource = dt;
            conn.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
                {
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
                    

            /*

            SqlConnection conn = new SqlConnection(conexao);
            string strIncluir = "insert into tb_Cadastro values('" + txt_nome.Text + "', '" + dtp_datanasc.Text + "', '" + mtxt_cpf.Text + "', '" + mtxt_rg.Text + "', '" + txt_mensagem.Text + "')";
            conn.Open();
            SqlCommand comando = new SqlCommand(strIncluir, conn);

            int retorno = (int)comando.ExecuteNonQuery();

            if (retorno > 0)
            {

                MessageBox.Show("Gravação realizada com sucesso!");
            }

            else
            {
                MessageBox.Show("Erro na gavação, verifique");

            }*/
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

            preencherGrid("select Cod_Pedido, Valor, Data, Hora from pedido where Cod_Cliente like ('%" + id + "%')", gridPedidosClientes);

            for (int i = 0; i < gridPedidosClientes.Columns.Count; i++)
                gridPedidosClientes.Columns[i].Width = 70;
        }

        private void gridPedidosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(gridPedidosClientes.CurrentRow.Cells[0].Value);

            preencherGrid("select Cod_Produto as [ID Produto],  Nome_Produto as [Produto], Valor_Venda as [Preço] from produto where Cod_Produto IN (select Cod_Produto from Detalhe_Pedido where Cod_Pedido =" + id + ")", gridProdutosConsumidos);

            
            for (int i = 0; i < gridProdutosConsumidos.Columns.Count; i++)
                gridProdutosConsumidos.Columns[i].Width = 90;
//            gridProdutosConsumidos.Columns[1].Width = 100;
  //          gridProdutosConsumidos.Columns[2].Width = 50;
        }

        private void txt_palavrachave_TextChanged(object sender, EventArgs e)
        {
            txtIDProduto.Text = "";

            preencherGrid("select Cod_Produto as [ID Produto],  Nome_Produto as [Produto], Valor_Venda as [Preço] from Produto where Nome_Produto like ('%" + txtPalavraChave.Text + "%')", gridResultadoBusca);
        }
    }
}