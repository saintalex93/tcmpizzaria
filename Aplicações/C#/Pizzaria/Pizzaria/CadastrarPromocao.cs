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
    public partial class CadastrarPromocao : Form
    {
        public CadastrarPromocao()
        {
            InitializeComponent();
        }

        string conexao = "Data Source= Tuca\\SQLEXPRESS ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=peganomeupau";

        string strBusca = "";

        public void preencherGrid(string busca, DataGridView tabela)
        {
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();

//            try
  //          {
                SqlCommand sqlComm = new SqlCommand(busca, conn);
                sqlComm.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;
                DataTable dt = new DataTable();
                da.Fill(dt);
                tabela.DataSource = dt;
/*            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao conectar ao Bano de Dados, Contate seu suporte");
            }
        */
            conn.Close();
        }

        public void preencherListBox(string busca, ListBox tabela)
        {
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();

            //            try
            //          {
            SqlCommand sqlComm = new SqlCommand(busca, conn);
            sqlComm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabela.DataSource = dt;

            // 1. set DisplayMember and ValueMember
            lbBuscaProdutos.DisplayMember = dt.Columns[1].ColumnName;
            lbBuscaProdutos.ValueMember = dt.Columns[1].ColumnName;
            // 2. set DataSource
            lbBuscaProdutos.DataSource = dt;

            lbProdutosPromocao.DisplayMember = dt.Columns[1].ColumnName;
            lbProdutosPromocao.ValueMember = dt.Columns[1].ColumnName;
            // 2. set DataSource
            conn.Close();
        }

        public double precoItem(string busca) 
        {
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();

            SqlCommand sqlComm = new SqlCommand(busca, conn);
            sqlComm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;


            DataTable dt = new DataTable();
            da.Fill(dt);
//            tabela.DataSource = dt;

           
            conn.Close();
        
        return 0;
        }

        public void preencherGridView(string busca, DataGridView tabela)
        {
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();

            //            try
            //          {
            SqlCommand sqlComm = new SqlCommand(busca, conn);
            sqlComm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabela.DataSource = dt;

            /*            // 1. set DisplayMember and ValueMember
                        lbBuscaProdutos.DisplayMember = dt.Columns[1].ColumnName;
                        lbBuscaProdutos.ValueMember = dt.Columns[1].ColumnName;
                        // 2. set DataSource
                        lbBuscaProdutos.DataSource = dt;

                        lbProdutosPromocao.DisplayMember = dt.Columns[1].ColumnName;
                        lbProdutosPromocao.ValueMember = dt.Columns[1].ColumnName;
                        // 2. set DataSource*/
            conn.Close();
        }

        public void mensagemDeErro(string mensagem) 
        {
            Fornecedores.mensagemDeErro(mensagem);
        }

        public void criarSegundaTabela()
        {
            List<int> visibleColumns = new List<int>();
            
            foreach (DataGridViewColumn col in dtgBuscaProdutos.Columns)
            {
                if (col.Visible)
                {
                    dtgProdutosNaPromocao.Columns.Add((DataGridViewColumn)col.Clone());

                    visibleColumns.Add(col.Index);
                }
            }
            
            // Now add the data from the columns
            // Set a counter for the current row index for the second DataGridView
            int rowIndex = 0;
            
            DataTable DT = (DataTable)dtgProdutosNaPromocao.DataSource;

            foreach (DataGridViewRow row in dtgBuscaProdutos.Rows)
            {
                // Add a new row to the DataGridView
                dtgProdutosNaPromocao.Rows.Add();
                
                // Loop through the visible columns
                for (int i = 0; i < visibleColumns.Count; i++)
                {
                    // Use the index of the for loop for the column in the target data grid
                    // Use the index value from the List<T> for the cell of the source target data grid
                    dtgProdutosNaPromocao.Rows[rowIndex].Cells[i].Value = row.Cells[visibleColumns[i]].Value;
                }
                
                // Increment the rowIndex
                rowIndex++;
            }

            dtgProdutosNaPromocao.Rows.Clear();

            do
            {
                foreach (DataGridViewRow row in dtgProdutosNaPromocao.Rows)
                {
                    try
                    {
                        dtgProdutosNaPromocao.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dtgProdutosNaPromocao.Rows.Count > 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtBuscaID.Text = "";

//            preencherGridView("select cod_Produto, Nome_Produto, Valor_Venda from Produto where Nome_Produto LIKE ('%" + txtBuscaPalavraChave.Text + "%')", dtgBuscaProdutos);

            preencherListBox("select cod_Produto, Nome_Produto, Valor_Venda from Produto where Nome_Produto LIKE ('%" + txtBuscaPalavraChave.Text + "%')", lbBuscaProdutos);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CadastrarPromocao_Shown(object sender, EventArgs e)
        {
//            conexao = Rede.DataContainer.conexaoGlobal;

/*            preencherGrid("select cod_Produto, Nome_Produto, Valor_Venda from Produto where Nome_Produto LIKE ('%a%')", dtgBuscaProdutos);


*/
            criarSegundaTabela();

        }

        private void txtBuscaID_TextChanged(object sender, EventArgs e)
        {
            txtBuscaPalavraChave.Text = "";

            for (int i = 0; i < txtBuscaID.Text.Length; i++)
                if (!char.IsNumber(txtBuscaID.Text[0]))
                {
                    mensagemDeErro("É permitido apenas o uso de números no campo \"Busca por ID\".");
                    txtBuscaID.Clear();
                    txtBuscaID.Focus();
                }

            preencherListBox("select cod_Produto, Nome_Produto, Valor_Venda from Produto where Cod_Produto LIKE ('%" + txtBuscaID.Text + "%')", lbBuscaProdutos);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string id = "";

/*            id = dtgBuscaProdutos.CurrentRow.Cells[0].Value.ToString();

//            dtgProdutosNaPromocao.Columns.Insert(0,);

            preencherGrid("select cod_Produto, Nome_Produto, Valor_Venda from Produto where cod_Produto LIKE ('%" + txtBuscaID.Text + "%')", dtgProdutosNaPromocao);*/
            
//            dtgProdutosNaPromocao.Rows.Add(dtgBuscaProdutos.CurrentRow);



            int testaSel = lbProdutosPromocao.FindString(lbBuscaProdutos.SelectedItem.ToString());

            if (testaSel == -1)
            {
                lbProdutosPromocao.Items.Add(lbBuscaProdutos.SelectedItem);
                
            }

            ListBox x = lbProdutosPromocao;

            double preço = 0;

             foreach (var item in lbProdutosPromocao.SelectedItems) 
                 preço += Convert.ToDouble(((DataRowView)item)["Valor_Venda"]);
            

                 //                 MessageBox.Show("ID = " + ((DataRowView)item)["people_id"].ToString());

            string busca = "select Valor_Venda from Produto where Cod_Produto = ";


/*            for (int i = 0; i < lbProdutosPromocao.Items.Count; i++)
            {


                ListViewItem selItem = lbProdutosPromocao;
                
  string txt = selItem.SubItems[2].Text;
                Console.WriteLine("----TESTE----"+txt);
            }
            

            for (int i = 0; i < lbProdutosPromocao.Items.Count; i++) 
//                  preço += lbProdutosPromocao.SelectedItems.
            if(lbProdutosPromocao.Items.Count > 0)
                Console.WriteLine("-------------------" + lbProdutosPromocao.Items[0].ToString()+ "-------------------");
     
        */}
            
        private void btnRemover_Click(object sender, EventArgs e)
        {
            lbProdutosPromocao.Items.RemoveAt(lbProdutosPromocao.SelectedIndex);
        }

        private void lbProdutosPromocao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Dispose();
        }

        private void dtgProdutosNaPromocao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
