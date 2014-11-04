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

        string conexao = "Data Source= USER-PC;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=1234";
        string strBusca = "";

        public Form FormHome { get; set; }

        public void preencherGrid(string busca, DataGridView tabela)
        {

            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(busca, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabela.DataSource = dt;
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

/*        public void preencherGridView(string busca, DataGridView tabela)
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
//            conn.Close();
  //      }
    
        public void mensagemDeErro(string mensagem) 
        {
            Fornecedores.mensagemDeErro(mensagem);
        }
/*
        public void criarSegundaTabela()
        {
            List<int> visibleColumns = new List<int>();
            
            foreach (DataGridViewColumn col in gridBuscaProdutos.Columns)
            {
                if (col.Visible)
                {
                    gridProdutosNaPromocao.Columns.Add((DataGridViewColumn)col.Clone());

                    visibleColumns.Add(col.Index);
                }
            }
            
            // Now add the data from the columns
            // Set a counter for the current row index for the second DataGridView
            int rowIndex = 0;
            
            DataTable DT = (DataTable)gridProdutosNaPromocao.DataSource;

            foreach (DataGridViewRow row in gridBuscaProdutos.Rows)
            {
                // Add a new row to the DataGridView
                gridProdutosNaPromocao.Rows.Add();
                
                // Loop through the visible columns
                for (int i = 0; i < visibleColumns.Count; i++)
                {
                    // Use the index of the for loop for the column in the target data grid
                    // Use the index value from the List<T> for the cell of the source target data grid
                    gridProdutosNaPromocao.Rows[rowIndex].Cells[i].Value = row.Cells[visibleColumns[i]].Value;
                }
                
                // Increment the rowIndex
                rowIndex++;
            }

            gridProdutosNaPromocao.Rows.Clear();

            do
            {
                foreach (DataGridViewRow row in gridProdutosNaPromocao.Rows)
                {
                    try
                    {
                        gridProdutosNaPromocao.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (gridProdutosNaPromocao.Rows.Count > 1);
        }
        */

/*        public void formatarColunasDoGridDeBuscaDeProdutos() 
        {
            gridBuscaProdutos.Columns[0].Width = 20;
            gridBuscaProdutos.Columns[1].Width = 150;
            gridBuscaProdutos.Columns[2].Width = 50;
        }
        */
        
        public void calcularSaldo()
        {
            double saldo = 0;

            for (int x = 0; x < gridProdutosNaPromocao.Rows.Count; x++)
            {


                saldo += Convert.ToDouble(gridProdutosNaPromocao.Rows[x].Cells[3].Value);
            }

            txtSaldo.Text = saldo.ToString();
        }

        public void atualizarPromocoesEncontradas() 
        {
            preencherGrid("select Cod_Promocao as [ID], Nome_Promocao as [Título], Preco_Original [Preço Original], Preco_Promocao as [Preço Promocional], Vigencia as [Vigência], Descricao as [Descrição] from Promocao", gridPromocoesEncontradas);
        }

        public bool validaTitulo() 
        {
            bool resultado = true;

            if(txtTituloPromocao.Text.Length == 0)
            {
                Fornecedores.mensagemDeErro("Por favor, adicione um título para a Promoção.");

                resultado = false;
            }

            return resultado;
        }

        public bool validaVigencia() 
        {
            bool resultado = true;

            if (!dataPrazo.Checked)
            {
                Fornecedores.mensagemDeErro("Por favor, escolha uma data para a validade da Promoção.");

                resultado = false;
            }

            if(dataPrazo.Value < DateTime.Today)
            {
                Fornecedores.mensagemDeErro("Infelizmente, não é possível escolher uma data passada para a Promoção.\n\nPor favor, escolha uma data futura.");

                resultado = false;
            }

                return resultado;
        }

        public bool validaDescricao() 
        {
            bool resultado = true;

            if (txtDescricaoPromocao.Text.Length == 0)
            {
                Fornecedores.mensagemDeErro("Por favor, coloque uma descrição que liste os produtos que estarão na Promoção.");

                resultado = false;
            }

            return resultado;
        }

        public bool validaPrecoOriginal() 
        {
            bool resultado = true;

            if (txtSaldo.Text.Length == 0)
            {
                Fornecedores.mensagemDeErro("Por favor, antes de adicionar uma Promoção ao banco, é preciso adicionar produtos a ela.");

                txtBuscaPalavraChave.Focus();

                resultado = false;
            }

            return resultado;
        
        }

        public bool validaNovoPreco()
        {
            bool resultado = true;

            if (txtNovoPreco.Text.Length == 0)
            {
                Fornecedores.mensagemDeErro("Não é permitido criar uma nova Promoção sem antes estabelecer um novo preço promocional.");

                txtNovoPreco.Focus();

                resultado = false;
            }

            return resultado;

        }

        public bool validaCampos() 
        {
            bool resultado = true;

            if (!validaTitulo())
                return false;

            if (!validaVigencia())
                return false;

/*            if (!validaPrecoOriginal())
                return false;

            if (!validaNovoPreco())
                return false;
            */
            return resultado;
        }

        public void limparGrid(DataGridView tabela)
        {
            tabela.DataSource = null;
            tabela.Rows.Clear();
        }

        //------ Eventos de controles

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtBuscaProdutoPorID.Text = "";

            preencherGrid("select cod_Produto as [ID], Nome_Produto as [Produto], Valor_Venda as [Preço] from Produto where Nome_Produto LIKE ('%" + txtBuscaPalavraChave.Text + "%')", gridBuscaProdutos);

            if (gridProdutosNaPromocao.Rows.Count > 0)
                btnAdicionarProduto.Enabled = true;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CadastrarPromocao_Shown(object sender, EventArgs e)
        {
//            conexao = Rede.DataContainer.conexaoGlobal;

/*            preencherGrid("select cod_Produto, Nome_Produto, Valor_Venda from Produto where Nome_Produto LIKE ('%a%')", dtgBuscaProdutos);


*/

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            preencherGrid("insert into ProdutoPromocao (Cod_Produto, Cod_Promocao) values (" + gridBuscaProdutos.CurrentRow.Cells[0].Value.ToString() + ", " + gridPromocoesEncontradas.CurrentRow.Cells[0].Value.ToString() + ")", gridProdutosNaPromocao);

            //atualizarPromocoesEncontradas();

            preencherGrid("select ProdutoPromocao.codPromoProd as [ID], Produto.Cod_Produto as [ID Produto], Produto.Nome_Produto as [Produto], Produto.Valor_Venda as [Preço] from Promocao inner join ProdutoPromocao on Promocao.Cod_Promocao = ProdutoPromocao.Cod_Promocao inner join Produto on ProdutoPromocao.Cod_Produto = Produto.Cod_Produto where ProdutoPromocao.Cod_Promocao = " + gridPromocoesEncontradas.CurrentRow.Cells[0].Value.ToString(), gridProdutosNaPromocao);

            calcularSaldo();
        }
            
        private void btnRemover_Click(object sender, EventArgs e)
        {
//            lbProdutosPromocao.Items.RemoveAt(lbProdutosPromocao.SelectedIndex);
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

        private void txtBuscaPalavraChave_Leave(object sender, EventArgs e)
        {
            txtBuscaPalavraChave.BackColor = Color.White;
        }

        private void txtBuscaPalavraChave_Enter(object sender, EventArgs e)
        {
            txtBuscaPalavraChave.BackColor = Color.Aquamarine;
        }

        private void txtBuscaID_Leave(object sender, EventArgs e)
        {
            txtBuscaProdutoPorID.BackColor = Color.White;
        }

        private void txtBuscaID_Enter(object sender, EventArgs e)
        {
            txtBuscaProdutoPorID.BackColor = Color.Aquamarine;
        }

        private void txtNovoPreco_Leave(object sender, EventArgs e)
        {
            txtNovoPreco.BackColor = Color.White;
        }

        private void txtNovoPreco_Enter(object sender, EventArgs e)
        {
            txtNovoPreco.BackColor = Color.Aquamarine;
        }

        private void gridBuscaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gridPromocoesEncontradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCriarPromocoes_Click(object sender, EventArgs e)
        {
            if (!validaCampos())
                return;

            string
                tituloPromocao = txtTituloPromocao.Text,
                descricaoPromocao = txtDescricaoPromocao.Text,
                precoOriginal = txtSaldo.Text,
                precoPromocao = txtNovoPreco.Text,
                vigencia = dataPrazo.Value.ToString("dd/MM/yyyy"),
                visivelNoSite = "",
                paraCadastrados = "";

            if (ckAcessoCadastrado.Checked)
                paraCadastrados = "1";
            else
                paraCadastrados = "0";

            if (ckVisivelNoSite.Checked)
                visivelNoSite = "1";
            else
                visivelNoSite = "0";

            preencherGrid("insert into promocao (Nome_Promocao, Descricao, Vigencia, sobe_promocao, usuario_cadastrado) values("+ 
                "'"+tituloPromocao+"', "+
                "'" + descricaoPromocao + "', " +
                "'" + vigencia + "', " +
                "" + visivelNoSite + ", " +
                "" + paraCadastrados +")", gridProdutosNaPromocao);

            preencherGrid("select Cod_Promocao as [ID], Nome_Promocao as [Título], Vigencia as [Vigência], Descricao as [Descrição] from Promocao where Nome_Promocao = '" + txtTituloPromocao.Text + "'", gridPromocoesEncontradas);

            txtTituloPromocao.Clear();
            dataPrazo.Value = DateTime.Today;
            txtDescricaoPromocao.Clear();
            ckAcessoCadastrado.Checked = false;
            ckVisivelNoSite.Checked = false;

            btnAlterar.Enabled = true;
            btnRemoverPromocao.Enabled = true;
        }

        private void dataPrazo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTituloPromocao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscaPorID_TextChanged(object sender, EventArgs e)
        {
            txtBuscaPorTitulo.Text = "";

            for (int i = 0; i < txtBuscaPromocaoPorID.Text.Length; i++)
                if (!char.IsNumber(txtBuscaPromocaoPorID.Text[i]))
                {
                    Fornecedores.mensagemDeErro("É permitido apenas o uso de números no campo \"Busca por ID\".");
                    txtBuscaPromocaoPorID.Clear();
                    txtBuscaPromocaoPorID.Focus();
                }

            preencherGrid("select Cod_Promocao as [ID], Nome_Promocao as [Título], Vigencia as [Vigência], Descricao as [Descrição] from Promocao where Cod_Promocao = " + txtBuscaPromocaoPorID.Text, gridPromocoesEncontradas);

            btnAlterar.Enabled = true;

            btnProcessarNovoPreco.Enabled = false;
            btnRemoverProduto.Enabled = false;
            btnAdicionarProduto.Enabled = false;

            limparGrid(gridProdutosNaPromocao);
            limparGrid(gridBuscaProdutos);

        }

        private void txtNovoPreco_TextChanged(object sender, EventArgs e)
        {
            if (txtNovoPreco.Text.Contains("."))
            {
                Fornecedores.mensagemDeErro("Por favor, use vírgula (\",\") no lugar de ponto (\".\").");
                return;
            }

            decimal decSaldo = 0;
            decimal decNovoPreco = 0;

            decSaldo = Convert.ToDecimal(txtSaldo.Text);
            decNovoPreco = Convert.ToDecimal(txtNovoPreco.Text);

            if (decNovoPreco > decSaldo)
                decNovoPreco = decSaldo;
            else if (decNovoPreco < 0)
                decNovoPreco = 0;

            txtNovoPreco.Text = decNovoPreco.ToString();
            txtSaldo.Text = decSaldo.ToString();

            SqlConnection conn = new SqlConnection(conexao);
            
            conn.Open();
            
            SqlCommand sqlComm = new SqlCommand("update Promocao set Preco_Original = " + decSaldo.ToString().Replace(",", ".") + ", Preco_Promocao = " + decNovoPreco.ToString().Replace(",", ".") + " where cod_Promocao =" + gridPromocoesEncontradas.CurrentRow.Cells[0].Value.ToString(), conn);

            sqlComm.ExecuteNonQuery();


        }

        private void txtBuscaPorTitulo_TextChanged(object sender, EventArgs e)
        {
            txtBuscaPromocaoPorID.Text = "";

            preencherGrid("select Cod_Promocao as [ID], Nome_Promocao as [Título], Vigencia as [Vigência], Descricao as [Descrição] from Promocao where Nome_Promocao like ('%" + txtBuscaPorTitulo.Text + "%')", gridPromocoesEncontradas);

            btnAlterar.Enabled = true;

            btnProcessarNovoPreco.Enabled = false;
            btnRemoverProduto.Enabled = false;
            btnAdicionarProduto.Enabled = false;

            limparGrid(gridProdutosNaPromocao);
            limparGrid(gridBuscaProdutos);
        }

        private void btnRemoverPromocao_Click(object sender, EventArgs e)
        {
            DialogResult decisao = MessageBox.Show("Tem certeza que deseja remover essa Promoção do banco?", "Remover Promoção", MessageBoxButtons.YesNo);

            if (decisao == DialogResult.Yes)
            {
                int idPromocao = (int)gridPromocoesEncontradas.CurrentRow.Cells[0].Value;

                preencherGrid("delete from ProdutoPromocao where cod_Promocao = " + idPromocao, gridPromocoesEncontradas);

                preencherGrid("delete from Promocao where cod_Promocao = " + idPromocao, gridPromocoesEncontradas);

                atualizarPromocoesEncontradas();

                preencherGrid("select ProdutoPromocao.codPromoProd as [ID], Produto.Cod_Produto as [ID Produto], Produto.Nome_Produto as [Produto], Produto.Valor_Venda as [Preço] from Promocao inner join ProdutoPromocao on Promocao.Cod_Promocao = ProdutoPromocao.Cod_Promocao inner join Produto on ProdutoPromocao.Cod_Produto = Produto.Cod_Produto where ProdutoPromocao.Cod_Promocao = " + gridPromocoesEncontradas.CurrentRow.Cells[0].Value.ToString(), gridProdutosNaPromocao);

                btnCriarPromocoes.Enabled = true;
                txtTituloPromocao.Clear();
                txtDescricaoPromocao.Clear();
                dataPrazo.Value = DateTime.Today;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (btnAlterar.Text == "Alterar")
            {
                btnAlterar.Text = "Gravar";

                btnCriarPromocoes.Enabled = false;

                txtTituloPromocao.Text = gridPromocoesEncontradas.CurrentRow.Cells[1].Value.ToString();

                string dia = "";
                string mes = "";
                string ano = "";
                int sessao = 0;

                string valor = gridPromocoesEncontradas.CurrentRow.Cells[3].Value.ToString();

                if (gridPromocoesEncontradas.CurrentRow.Cells[2].Value.ToString().Length > 0)
                {
                    for (int i = 0; i < gridPromocoesEncontradas.CurrentRow.Cells[2].Value.ToString().Length; i++)
                        if (gridPromocoesEncontradas.CurrentRow.Cells[2].Value.ToString()[i].ToString() == "/")
                            sessao++;
                        else
                            switch (sessao)
                            {
                                case 0:
                                    dia += gridPromocoesEncontradas.CurrentRow.Cells[2].Value.ToString()[i];
                                    break;

                                case 1:
                                    mes += gridPromocoesEncontradas.CurrentRow.Cells[2].Value.ToString()[i];
                                    break;

                                case 2:
                                    ano += gridPromocoesEncontradas.CurrentRow.Cells[2].Value.ToString()[i];
                                    break;

                                default:
                                    mensagemDeErro("Aconteceu algo de errado na alteração das Promoções. Informe seu suporte para que o problema possa ser avaliado.");
                                    break;

                            }

                    dataPrazo.Value = new DateTime(Convert.ToInt32(ano), Convert.ToInt32(mes), Convert.ToInt32(dia));
                }
                txtDescricaoPromocao.Text = gridPromocoesEncontradas.CurrentRow.Cells[3].Value.ToString();
            }
            else if (btnAlterar.Text == "Gravar")
            {
                btnAlterar.Text = "Alterar";

                btnCriarPromocoes.Enabled = true;

                int acesso = 0, visivel = 0;

                if (ckAcessoCadastrado.Checked)
                    acesso = 1;
                else
                    acesso = 0;

                if (ckVisivelNoSite.Checked)
                    visivel = 1;
                else
                    visivel = 0;

                int idPromocao = (int)gridPromocoesEncontradas.CurrentRow.Cells[0].Value;

                preencherGrid("update Promocao set Nome_Promocao = '" + txtTituloPromocao.Text + "', Descricao = '" + txtDescricaoPromocao.Text + "', Vigencia = '" + dataPrazo.Value.ToShortDateString() + "', sobe_promocao = " + visivel + ", usuario_cadastrado = " + acesso + " where cod_Promocao = " + idPromocao, gridPromocoesEncontradas);
 
                preencherGrid("select Cod_Promocao as [ID], Nome_Promocao as [Título], Preco_Original [Preço Original], Preco_Promocao as [Preço Promocional], Vigencia as [Vigência], Descricao as [Descrição] from Promocao where cod_Promocao = " + idPromocao, gridPromocoesEncontradas);

                txtTituloPromocao.Clear();
                txtDescricaoPromocao.Clear();
                dataPrazo.Value = DateTime.Today;
                ckVisivelNoSite.Checked = false;
                ckAcessoCadastrado.Checked = false;
            }
        }

        private void gridPromocoesEncontradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            preencherGrid("select ProdutoPromocao.codPromoProd as [ID], Produto.Cod_Produto as [ID Produto], Produto.Nome_Produto as [Produto], Produto.Valor_Venda as [Preço] from Promocao inner join ProdutoPromocao on Promocao.Cod_Promocao = ProdutoPromocao.Cod_Promocao inner join Produto on ProdutoPromocao.Cod_Produto = Produto.Cod_Produto where ProdutoPromocao.Cod_Promocao = " + gridPromocoesEncontradas.CurrentRow.Cells[0].Value.ToString(), gridProdutosNaPromocao);

            calcularSaldo();

            btnProcessarNovoPreco.Enabled = true;
            btnRemoverProduto.Enabled = true;
        }

        private void txtBuscaProdutoPorID_TextChanged(object sender, EventArgs e)
        {
            txtBuscaPalavraChave.Text = "";

            for (int i = 0; i < txtBuscaProdutoPorID.Text.Length; i++)
                if (!char.IsNumber(txtBuscaProdutoPorID.Text[i]))
                {
                    Fornecedores.mensagemDeErro("É permitido apenas o uso de números no campo de busca de produtos por ID.");
                    txtBuscaProdutoPorID.Clear();
                    txtBuscaProdutoPorID.Focus();
                }

            preencherGrid("select cod_Produto as [ID], Nome_Produto as [Produto], Valor_Venda as [Preço] from Produto where Cod_Produto = "+ txtBuscaProdutoPorID.Text, gridBuscaProdutos);

            if (gridProdutosNaPromocao.Rows.Count > 0)
                btnAdicionarProduto.Enabled = true;
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            int idItem = (int)gridProdutosNaPromocao.CurrentRow.Cells[0].Value;

            preencherGrid("delete from ProdutoPromocao where codPromoProd = " + idItem, gridProdutosNaPromocao);

            preencherGrid("select ProdutoPromocao.codPromoProd as [ID], Produto.Cod_Produto as [ID Produto], Produto.Nome_Produto as [Produto], Produto.Valor_Venda as [Preço] from Promocao inner join ProdutoPromocao on Promocao.Cod_Promocao = ProdutoPromocao.Cod_Promocao inner join Produto on ProdutoPromocao.Cod_Produto = Produto.Cod_Produto where ProdutoPromocao.Cod_Promocao = " + gridPromocoesEncontradas.CurrentRow.Cells[0].Value.ToString(), gridProdutosNaPromocao);

            calcularSaldo();
        }

        private void rdAcessoCadastrados_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdVisivelNoSite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.FormHome.Show();
            Dispose();
        }

        private void txtTituloPromocao_Enter(object sender, EventArgs e)
        {
            txtTituloPromocao.BackColor = Color.Aquamarine;
        }

        private void txtTituloPromocao_Leave(object sender, EventArgs e)
        {
            txtTituloPromocao.BackColor = Color.White;
        }

        private void txtDescricaoPromocao_Enter(object sender, EventArgs e)
        {
            txtDescricaoPromocao.BackColor = Color.Aquamarine;
        }

        private void txtDescricaoPromocao_Leave(object sender, EventArgs e)
        {
            txtDescricaoPromocao.BackColor = Color.White;
        }

        private void txtBuscaPorTitulo_Enter(object sender, EventArgs e)
        {
            txtBuscaPorTitulo.BackColor = Color.Aquamarine;
        }

        private void txtBuscaPorTitulo_Leave(object sender, EventArgs e)
        {
            txtBuscaPorTitulo.BackColor = Color.White;
        }

        private void txtBuscaPromocaoPorID_Enter(object sender, EventArgs e)
        {
            txtBuscaPromocaoPorID.BackColor = Color.Aquamarine;
        }

        private void txtBuscaPromocaoPorID_Leave(object sender, EventArgs e)
        {
            txtBuscaPromocaoPorID.BackColor = Color.White;
        }

        private void txtBuscaPalavraChave_Enter_1(object sender, EventArgs e)
        {
            txtBuscaPalavraChave.BackColor = Color.Aquamarine;
        }

        private void txtBuscaPalavraChave_Leave_1(object sender, EventArgs e)
        {
            txtBuscaPalavraChave.BackColor = Color.White;
        }

        private void txtBuscaProdutoPorID_Enter(object sender, EventArgs e)
        {
            txtBuscaProdutoPorID.BackColor = Color.Aquamarine;
        }

        private void txtBuscaProdutoPorID_Leave(object sender, EventArgs e)
        {
            txtBuscaProdutoPorID.BackColor = Color.White;
        }

        private void txtSaldo_Enter(object sender, EventArgs e)
        {
            txtSaldo.BackColor = Color.Aquamarine;
        }

        private void txtSaldo_Leave(object sender, EventArgs e)
        {
            txtSaldo.BackColor = Color.White;
        }

        private void txtNovoPreco_Enter_1(object sender, EventArgs e)
        {
            txtNovoPreco.BackColor = Color.Aquamarine;
        }

        private void txtNovoPreco_Leave_1(object sender, EventArgs e)
        {
            txtNovoPreco.BackColor = Color.White;
        }

        private void CadastrarPromocao_Load(object sender, EventArgs e)
        {
            //conexao = Acesso.Conexao;
        }
    }
}