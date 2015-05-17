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

        string conexao = "";
        string strBusca = "";

        public Form FormHome { get; set; }

        private void CadastrarPromocao_Load(object sender, EventArgs e)
        {
            conexao = Acesso.Conexao;

            atualizarPromocoesEncontradas();
        }

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

        public void calcularSaldo()
        {
            double saldo = 0;

            for (int x = 0; x < gridProdutosNaPromocao.Rows.Count; x++)
            {


                saldo += Convert.ToDouble(gridProdutosNaPromocao.Rows[x].Cells[3].Value);
            }

//            txtSaldo.Text = saldo.ToString();
        }

        public void atualizarPromocoesEncontradas() 
        {
            preencherGrid("USP_CSP_Promocao_MostrarTodasPromocoes", gridPromocoesEncontradas);
        }

        public bool validaTitulo() 
        {
            bool resultado = true;

            if(txtTituloPromocao.Text.Length == 0)
            {
                Home.mensagemDeErro("Por favor, adicione um título para a Promoção.","Promoção sem nome");

                resultado = false;
            }

            return resultado;
        }

        public bool validaVigencia() 
        {
            bool resultado = true;

            if (dataVigencia.Value == DateTime.Today)
            {
                Home.mensagemDeErro("Por favor, escolha uma data para a validade da Promoção.","Data inválida");

                resultado = false;
            }

            if(dataVigencia.Value < DateTime.Today)
            {
                Home.mensagemDeErro("Infelizmente, não é possível escolher uma data passada para a Promoção.\n\nPor favor, escolha uma data futura.","Data inválida");

                resultado = false;
            }

                return resultado;
        }

        public bool validaDescricao() 
        {
            bool resultado = true;

            if (txtDescricaoPromocao.Text.Length == 0)
            {
                Home.mensagemDeErro("Por favor, coloque uma descrição que liste os produtos que estarão na Promoção.","Sem descrição");

                resultado = false;
            }

            return resultado;
        }

        public bool validaDesconto() 
        {
            if (txtDesconto.Text.Length == 0)
            {
                Home.mensagemDeErro("É preciso fornecer valor para oporcentual de desconto da promoção.", "Erro no desconto");
                return false;
            }
                
            else
            {
                int s = 0;
                Int32.TryParse(txtDesconto.Text, out s);

                if (s == 0)
                {
                    Home.mensagemDeErro("O campo de porcentual do desconto tem que ser preenchido apenas com números.", "Erro no desconto");
                    return false;
                }
                    
                else if (s >= 100 || s <= 0)
                {
                    Home.mensagemDeErro("Por favor, insira um valor de desconto entre 0 e 100.", "Erro no desconto");
                    return false;
                }
            }

            return true;
        }

        public bool validaCampos() 
        {
            if (!validaTitulo())
                return false;

            if (!validaVigencia())
                return false;

            if (!validaDesconto())
                return false;
            return true;
        }

        public void limparGrid(DataGridView tabela)
        {
            tabela.DataSource = null;
            tabela.Rows.Clear();
        }

        //------ Eventos de controles

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtProdutoID.Text = "";

            preencherGrid("select cod_Produto as [ID], Nome_Produto as [Produto], Valor_Venda as [Preço] from Produto where Nome_Produto LIKE ('%" + txtProdutoPalavraChave.Text + "%')", gridBuscaProdutos);

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
            txtTituloPromocao.Focus();
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
            txtProdutoPalavraChave.BackColor = Color.White;
        }

        private void txtBuscaPalavraChave_Enter(object sender, EventArgs e)
        {
            txtProdutoPalavraChave.BackColor = Color.Aquamarine;
        }

        private void txtBuscaID_Leave(object sender, EventArgs e)
        {
            txtProdutoID.BackColor = Color.White;
        }

        private void txtBuscaID_Enter(object sender, EventArgs e)
        {
            txtProdutoID.BackColor = Color.Aquamarine;
        }

        private void txtNovoPreco_Leave(object sender, EventArgs e)
        {
//            txtNovoPreco.BackColor = Color.White;
        }

        private void txtNovoPreco_Enter(object sender, EventArgs e)
        {
            //txtNovoPreco.BackColor = Color.Aquamarine;
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
                vigencia = dataVigencia.Value.ToString("yyyy-MM-dd"),
                desconto = txtDesconto.Text,
                visivelNoSite = "",
                acessivelATodos = "";

            if (ckSobeSite.Checked)
                acessivelATodos = "1";
            else
                acessivelATodos = "0";

            if (ckAcessivelATodos.Checked)
                visivelNoSite = "1";
            else
                visivelNoSite = "0";

            preencherGrid(
                "USP_CSP_Promocao_InserirPromocao '" + 
                    tituloPromocao+"', '" + 
                    descricaoPromocao + "', " +
                    desconto + ", '" + 
                    vigencia + "', " +
                    visivelNoSite + ", " +
                    acessivelATodos, 

                    gridProdutosNaPromocao);

            preencherGrid("USP_CSP_Promocao_BuscarPromocaoInserida", gridPromocoesEncontradas);

            txtTituloPromocao.Clear();
            dataVigencia.Value = DateTime.Today;
            txtDescricaoPromocao.Clear();
            ckSobeSite.Checked = false;
            ckAcessivelATodos.Checked = false;

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
            txtPromocaoPalavraChave.Text = "";

            for (int i = 0; i < txtPromocaoID.Text.Length; i++)
                if (!char.IsNumber(txtPromocaoID.Text[i]))
                {
                    Home.mensagemDeErro("É permitido apenas o uso de números no campo \"Busca por ID\".","Símbolos proibidos nas busca");
                    txtPromocaoID.Clear();
                    txtPromocaoID.Focus();
                }

            if (txtPromocaoID.Text.Length == 0)
                preencherGrid("USP_CSP_Promocao_MostrarTodasPromocoes", gridPromocoesEncontradas);
            else
                preencherGrid("USP_CSP_Promocoes_BuscarPromocoesPorID " + txtPromocaoID.Text, gridPromocoesEncontradas);

            btnAlterar.Enabled = true;

            //btnProcessarNovoPreco.Enabled = false;
            btnRemoverProduto.Enabled = false;
            btnAdicionarProduto.Enabled = false;

            limparGrid(gridProdutosNaPromocao);
            limparGrid(gridBuscaProdutos);

        }

        private void txtNovoPreco_TextChanged(object sender, EventArgs e)
        {
            /*if (txtNovoPreco.Text.Contains("."))
            {
                Home.mensagemDeErro("Por favor, use vírgula (\",\") no lugar de ponto (\".\").","Utilização de símbolo errado");
                return;
            }*/

            decimal decSaldo = 0;
            decimal decNovoPreco = 0;

            //decSaldo = Convert.ToDecimal(txtSaldo.Text);
            //decNovoPreco = Convert.ToDecimal(txtNovoPreco.Text);

            if (decNovoPreco > decSaldo)
                decNovoPreco = decSaldo;
            else if (decNovoPreco < 0)
                decNovoPreco = 0;

            //txtNovoPreco.Text = decNovoPreco.ToString();
            //txtSaldo.Text = decSaldo.ToString();

            SqlConnection conn = new SqlConnection(conexao);
            
            conn.Open();
            
            SqlCommand sqlComm = new SqlCommand("update Promocao set Preco_Original = " + decSaldo.ToString().Replace(",", ".") + ", Preco_Promocao = " + decNovoPreco.ToString().Replace(",", ".") + " where cod_Promocao =" + gridPromocoesEncontradas.CurrentRow.Cells[0].Value.ToString(), conn);

            sqlComm.ExecuteNonQuery();


        }

        private void txtBuscaPorTitulo_TextChanged(object sender, EventArgs e)
        {
            txtPromocaoID.Text = "";
            
            if(txtPromocaoPalavraChave.Text.Length != 0)
                preencherGrid("USP_CSP_Promocoes_BuscarPromocoesPorPalavraChave '" + txtPromocaoPalavraChave.Text + "'", gridPromocoesEncontradas);
            else
                preencherGrid("USP_CSP_Promocoes_MostrarTodasPromocoes", gridPromocoesEncontradas);

            btnAlterar.Enabled = true;

            //btnProcessarNovoPreco.Enabled = false;
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
                dataVigencia.Value = DateTime.Today;
                grpDados.Enabled = true;
                btnAlterar.Enabled = false;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int idPromocao = (int)gridPromocoesEncontradas.CurrentRow.Cells[0].Value;

            preencherGrid
                (
                "USP_CSP_Promocoes_BuscarPromocoesPorID " + idPromocao,
                gridPromocoesEncontradas
                );

            if (btnAlterar.Text == "Alterar")
                iniciarModoEdicao();
            else if (btnAlterar.Text == "Gravar")
                if (!validaCampos())
                    return;
                else
                    finalizarModoEdicao();
        }

        private void gridPromocoesEncontradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            preencherGrid("USP_CSP_Promocao_BuscarProdutosNaPromocao " + gridPromocoesEncontradas.CurrentRow.Cells[0].Value.ToString(), gridProdutosNaPromocao);

            calcularSaldo();

            txtTituloPromocao.Clear();
            txtDescricaoPromocao.Clear();
            ckSobeSite.Checked = false;
            ckAcessivelATodos.Checked = false;
            dataVigencia.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            //btnProcessarNovoPreco.Enabled = true;
            btnRemoverProduto.Enabled = true;
        }

        private void txtBuscaProdutoPorID_TextChanged(object sender, EventArgs e)
        {
            txtProdutoPalavraChave.Text = "";

            for (int i = 0; i < txtProdutoID.Text.Length; i++)
                if (!char.IsNumber(txtProdutoID.Text[i]))
                {
                    Home.mensagemDeErro("É permitido apenas o uso de números no campo de busca de produtos por ID.","Utilização de símbolos proibidos na busca");
                    txtProdutoID.Clear();
                    txtProdutoID.Focus();
                }

            preencherGrid("select cod_Produto as [ID], Nome_Produto as [Produto], Valor_Venda as [Preço] from Produto where Cod_Produto like '%" + txtProdutoID.Text + "%'", gridBuscaProdutos);

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
            txtPromocaoPalavraChave.BackColor = Color.Aquamarine;

            txtPromocaoID.Clear();
        }

        private void txtBuscaPorTitulo_Leave(object sender, EventArgs e)
        {
            txtPromocaoPalavraChave.BackColor = Color.White;
        }

        private void txtBuscaPromocaoPorID_Enter(object sender, EventArgs e)
        {
            txtPromocaoID.BackColor = Color.Aquamarine;

            txtPromocaoPalavraChave.Clear();
        }

        private void txtBuscaPromocaoPorID_Leave(object sender, EventArgs e)
        {
            txtPromocaoID.BackColor = Color.White;
        }

        private void txtBuscaPalavraChave_Enter_1(object sender, EventArgs e)
        {
            if (gridProdutosNaPromocao.Rows.Count == 0)
            {
                Home.mensagemDeErro("Por favor, antes de selecionar um Produto, selecione uma Promoção aonde inserir o Produto.", "Promoção não selecionada");

                txtPromocaoPalavraChave.Focus();
            }
            else
            {
                txtProdutoPalavraChave.BackColor = Color.Aquamarine;

                txtProdutoID.Clear();
            }
                
        }

        private void txtBuscaPalavraChave_Leave_1(object sender, EventArgs e)
        {
            txtProdutoPalavraChave.BackColor = Color.White;
        }

        private void txtBuscaProdutoPorID_Enter(object sender, EventArgs e)
        {
            if (gridProdutosNaPromocao.Rows.Count == 0)
            {
                Home.mensagemDeErro("Por favor, antes de selecionar um Produto, selecione uma Promoção aonde inserir o Produto.", "Promoção não selecionada");

                txtPromocaoPalavraChave.Focus();
            }
            else 
            {
                txtProdutoID.BackColor = Color.Aquamarine;

                txtProdutoPalavraChave.Clear();
            }
                
        }

        private void txtBuscaProdutoPorID_Leave(object sender, EventArgs e)
        {
            txtProdutoID.BackColor = Color.White;
        }

        private void txtSaldo_Enter(object sender, EventArgs e)
        {
            //txtSaldo.BackColor = Color.Aquamarine;
        }

        private void txtSaldo_Leave(object sender, EventArgs e)
        {
            //txtSaldo.BackColor = Color.White;
        }

        private void txtNovoPreco_Enter_1(object sender, EventArgs e)
        {
           // txtNovoPreco.BackColor = Color.Aquamarine;
        }

        private void txtNovoPreco_Leave_1(object sender, EventArgs e)
        {
          //  txtNovoPreco.BackColor = Color.White;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            txtTituloPromocao.Text = "3 por 2 natalino";
            //dataPrazo.Value = new DateTime(2014, 12, 25);
            txtDescricaoPromocao.Text = "Até o Natal, três pizzas e um refrigerante sairá por R$ 50! Ho ho ho!";
            ckAcessivelATodos.Checked = true;
            ckSobeSite.Checked = true;
        }

        private void gridPromocoesEncontradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        DateTime getVigenciaPromocao() 
        {
            string[] arrayData = gridPromocoesEncontradas.CurrentRow.Cells[4].Value.ToString().Split('/');

            arrayData[2] = arrayData[2].Remove(4);

            return new DateTime
                (
                    Convert.ToInt32(arrayData[2]),
                    Convert.ToInt32(arrayData[1]),
                    Convert.ToInt32(arrayData[0])
                );
        }

        void iniciarModoEdicao() 
        {
            btnAlterar.Text = "Gravar";
            
            //Desabilitando outros controles
            btnCriarPromocoes.Enabled = false;
            grpProdutos.Enabled = false;
            txtPromocaoID.Enabled = false;
            txtPromocaoPalavraChave.Enabled = false;
            btnRemoverPromocao.Enabled = false;

            txtTituloPromocao.Text = gridPromocoesEncontradas.CurrentRow.Cells[1].Value.ToString();

            txtDescricaoPromocao.Text = gridPromocoesEncontradas.CurrentRow.Cells[2].Value.ToString();

            txtDesconto.Text = gridPromocoesEncontradas.CurrentRow.Cells[3].Value.ToString();

            dataVigencia.Value = getVigenciaPromocao();

            if ((int)gridPromocoesEncontradas.CurrentRow.Cells[5].Value == 1)
                ckAcessivelATodos.Checked = true;
            else
                ckAcessivelATodos.Checked = false;

            if ((int)gridPromocoesEncontradas.CurrentRow.Cells[6].Value == 1)
                ckSobeSite.Checked = true;
            else
                ckSobeSite.Checked = false;
        }

        void finalizarModoEdicao() 
        {
            btnAlterar.Text = "Alterar";

            int sobeSite = 0, acessivelATodos = 0;

            if (ckSobeSite.Checked)
                sobeSite = 1;
            else
                sobeSite = 0;

            if (ckAcessivelATodos.Checked)
                acessivelATodos = 1;
            else
                acessivelATodos = 0;

            int idPromocao = (int)gridPromocoesEncontradas.CurrentRow.Cells[0].Value;

            preencherGrid
                (
                "USP_CSP_Promocao_AtualizarPromocao '" + 
                txtTituloPromocao.Text + "', '" + 
                txtDescricaoPromocao.Text + "', " + 
                txtDesconto.Text + ", '" + 
                dataVigencia.Value.ToString("yyyy-MM-dd") + "', " + 
                sobeSite + ", " + 
                acessivelATodos + ", " + 
                idPromocao
                
                ,gridPromocoesEncontradas
                 );

            preencherGrid("USP_CSP_Promocoes_BuscarPromocoesPorID " + idPromocao, gridPromocoesEncontradas);

            //Limpando conteúdo anterior
            txtTituloPromocao.Clear();
            txtDescricaoPromocao.Clear();
            dataVigencia.Value = DateTime.Today;
            ckAcessivelATodos.Checked = false;
            ckSobeSite.Checked = false;
            txtDesconto.Clear();

            //Habilitando controles anteriorente desabilitados
            btnCriarPromocoes.Enabled = true;
            grpProdutos.Enabled = true;
            txtPromocaoID.Enabled = true;
            txtPromocaoPalavraChave.Enabled = true;
            btnRemoverPromocao.Enabled = true;
        }
    }
}