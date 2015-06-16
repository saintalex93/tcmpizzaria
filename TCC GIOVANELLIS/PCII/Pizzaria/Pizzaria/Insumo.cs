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

using DAL.Model;
using BLL;

namespace Pizzaria
{
    public partial class Insumo : Form
    {
        public Insumo()
        {
            InitializeComponent();
        }

        public Form FormHome { get; set; }

        private void Produtos_Load(object sender, EventArgs e)
        {
            clsInsumoBLL teste = new clsInsumoBLL();
            clsInsumo teste1 = new clsInsumo();

            dtg_gravacao.DataSource = teste.CarregaInsumos();

            cmb_medida.SelectedIndex = 0;
        }

        clsInsumoBLL insumoBLL = new clsInsumoBLL();
        clsInsumo objInsumo = new clsInsumo();

        SqlConnection conn;
        string strsql = "", nome = "", cod_produto = "", categoria = "", medida = "";
        DateTime datavalidade, datarecebimento, datafabricacao;
        double valoruntd = 0;
        Boolean valida = false;
        int qtd = 0, cod_categoria = 0;
        string conexao = "";

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.FormHome.Show();
            Dispose();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
             return;
            
            if (!ValidaExistente())
                return;
            
            objInsumo                   = new clsInsumo();

            objInsumo.Nome_Insumo       = txt_nome.Text;
            objInsumo.Medida            = cmb_medida.Text;
            objInsumo.Validade          = dtp_datavalidade.Value.ToShortDateString().ToString();
            objInsumo.Fabricacao        = dtp_datafabricacao.Value.ToShortDateString().ToString();
            objInsumo.QtdeEmEstoque     = numQuantidadeEmEstoque.Value;
            objInsumo.QtdeRecomendavel  = numQuantidadeRecomendada.Value;

            insumoBLL.InserirInsumo(objInsumo);
            
            dtg_gravacao.DataSource = insumoBLL.CarregaInsumos();
        }
        
        private void btn_gravar_Click_1(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (ValidaExistente())
                {
                    atualizarproduto(dtg_gravacao.CurrentRow.Cells[0].Value.ToString());
                    dtg_gravacao.Enabled = true;
                    btn_excluir.Enabled = false;
                    btn_alterar.Enabled = false;
                    btn_inserir.Enabled = true;
                    dtg_gravacao.DataSource = insumoBLL.CarregaInsumos();;
                }
                else
                {
                    if (nome.ToString() == dtg_gravacao.CurrentRow.Cells[1].Value.ToString())
                    {
                        atualizarproduto(dtg_gravacao.CurrentRow.Cells[0].Value.ToString());
                        dtg_gravacao.Enabled = true;
                        btn_excluir.Enabled = false;
                        btn_alterar.Enabled = false;
                        btn_inserir.Enabled = true;
                        dtg_gravacao.DataSource = insumoBLL.CarregaInsumos();;
                    }
                    else
                        MessageBox.Show("Ja existe um produto com este nome");
                }
            }
        }
        
        private void dtg_gravacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_nome.Text = dtg_gravacao.CurrentRow.Cells[1].Value.ToString();
            dtp_datavalidade.Value = Convert.ToDateTime(dtg_gravacao.CurrentRow.Cells[5].Value.ToString());
            dtp_datafabricacao.Value = Convert.ToDateTime(dtg_gravacao.CurrentRow.Cells[6].Value.ToString());
            gpb_compras.Enabled = false;
            btn_alterar.Enabled = true;
            btn_inserir.Enabled = false;
            dtg_gravacao.Enabled = false;

        }
        
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (btn_alterar.Text == "Alterar")
                iniciarModoEdicao();
            else
                finalizarModoEdicao();
        }

        void iniciarModoEdicao() 
        {
            txtBuscarPorNome.Enabled    = false;
            txtBuscarPorID.Enabled      = false;
            btn_excluir.Enabled         = false;
            btn_inserir.Enabled         = false;
            dtg_gravacao.Enabled        = false;

            txt_nome.Text                   = dtg_gravacao.CurrentRow.Cells[1].Value.ToString();

            numQuantidadeRecomendada.Value  = (decimal)dtg_gravacao.CurrentRow.Cells[2].Value;

            numQuantidadeEmEstoque.Value    = (decimal)dtg_gravacao.CurrentRow.Cells[3].Value;

            cmb_medida.Text                 =   dtg_gravacao.CurrentRow.Cells[4].Value.ToString();

            if(dtg_gravacao.CurrentRow.Cells[5].Value.ToString().Length > 0)
                dtp_datafabricacao.Value    = Convert.ToDateTime(dtg_gravacao.CurrentRow.Cells[5].Value);

            if (dtg_gravacao.CurrentRow.Cells[6].Value.ToString().Length > 0)
                dtp_datavalidade.Value      = Convert.ToDateTime(dtg_gravacao.CurrentRow.Cells[6].Value);

            dtg_gravacao.DataSource = insumoBLL.CarregaInsumos();

            btn_alterar.Text = "Gravar";
        }
            

        void finalizarModoEdicao() 
        {
            if (!ValidaCampos())
                return;

            if (!ValidaExistente())
                return;

            objInsumo = new clsInsumo();

            objInsumo.Cod_Insumo = (int)dtg_gravacao.CurrentRow.Cells[0].Value;
            objInsumo.Nome_Insumo = txt_nome.Text;
            objInsumo.Medida = cmb_medida.Text;
            objInsumo.Validade = dtp_datavalidade.Value.ToShortDateString().ToString();
            objInsumo.Fabricacao = dtp_datafabricacao.Value.ToShortDateString().ToString();
            objInsumo.QtdeEmEstoque = numQuantidadeEmEstoque.Value;
            objInsumo.QtdeRecomendavel = numQuantidadeRecomendada.Value;

            insumoBLL.AtualizarInsumo(objInsumo);

            dtg_gravacao.DataSource = insumoBLL.CarregaInsumos();

            txtBuscarPorNome.Enabled    = true;
            txtBuscarPorID.Enabled      = true;
            btn_excluir.Enabled         = true;
            btn_inserir.Enabled         = true;
            dtg_gravacao.Enabled = true;

            btn_alterar.Text = "Alterar";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            dtg_gravacao.Enabled = true;
            btn_excluir.Enabled = false;
            btn_inserir.Enabled = true;
            gpb_compras.Enabled = true;
            btn_alterar.Enabled = false;
        }
        
        private void txt_vlrunitario_TextChanged(object sender, EventArgs e)
        {
            string conteudoCorrigido = "";
        }

        private void dtg_gravacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            cod_produto = dtg_gravacao.CurrentRow.Cells[0].Value.ToString();

            excluiprod(cod_produto);

            dtg_gravacao.Enabled = true;
            btn_excluir.Enabled = false;
            btn_alterar.Enabled = false;
            dtg_gravacao.DataSource = insumoBLL.CarregaInsumos();;

        }
        
        private void gpb_compras_Enter(object sender, EventArgs e)
        {

        }
        
        private void dtp_datafabricacao_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_inserir_Click_1(object sender, EventArgs e)
        {

        }

        bool validaNome() 
        {
            if (txt_nome.TextLength == 0)
            {
                Home.mensagemDeErro("É preciso inserir um nome.","Nome inválido");

                txt_nome.Focus();

                return false;
            }

            return true;
        }

        bool validaFabricacao()
        {
            if (dtp_datafabricacao.Value.Date > DateTime.Today)
            {
                Home.mensagemDeErro("A Data de Fabricação não pode estar em uma data futura.","Data de Fabricação inválida");

                dtp_datafabricacao.Focus();

                return false;
            }
            return true;
        }

        bool validaValidade() 
        {
            if (dtp_datavalidade.Value.Date < DateTime.Today.AddDays(1))
            {
                Home.mensagemDeErro("A Data de Validade não pode estar em uma data passada.", "Data de Validade inválida");

                dtp_datavalidade.Focus();

                return false;
            }

            return true;
        }

        bool validaQuantidadeRecomendada() 
        {

            if (numQuantidadeRecomendada.Value <= 0)
            {
                Home.mensagemDeErro("É preciso fornecer a quantidade recomendada do insumo." + ".", "Quantidade inválida");

                return false;
            }

            return true;
        }

        public Boolean ValidaCampos()
        {
            if (!validaNome())
                return false;

            if (!validaFabricacao())
                return false;

            if (!validaValidade())
                return false;

            if (!validaQuantidadeRecomendada())
                return false;
            
            return true;
        }

        public Boolean ValidaExistente()
        {
            objInsumo = new clsInsumo();

            objInsumo.Nome_Insumo = txt_nome.Text;

            if ((int)insumoBLL.ValidaExistente(objInsumo).Rows[0][0] != 0)
            {
                Home.mensagemDeErro("Já existe um insumo com esse nome no sistema.\n\nCertifique-se de que o nome está correto e tente de novo.","Insumo inválido");

                txt_nome.Focus();

                return false;
            }
            return true;
        }
        
        public void atualizarproduto(string cod_prod)
        {


            //seleciona categoria
            /*
            SqlConnection conn = new SqlConnection(conexao);
            string strIncluir = "select cod_Categoria from Categoria where Nome_Categoria = '" + categoria + "'";
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = sqlComm;
            da.Fill(dt);
            */

            //atualiza produto
            conn = new SqlConnection(conexao);

            string strIncluir = "";/*"update Insumo set Nome_Insumo ='" + nome +
                "',ValorDeCompra='" + valoruntd.ToString().Replace(",", ".") +
                "',QtdeRecomendavel = '" + txtbox_Recomendada.Text.ToString() + "',validade ='" +
                datavalidade.ToString("yyy/MM/dd") + "',qtdeemEstoque= qtdeemEstoque +" + qtd +
                "',Fabricacao = '" + datafabricacao.ToString("yyy/MM/dd") +
                "',Recebimento = '" + datarecebimento.ToString("yyy/MM/dd") + "', medida ='" + medida + "' where Cod_Insumo = '" +
                cod_prod + "'";
            */
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(strIncluir, conn);
            sqlComm.ExecuteNonQuery();
            /*
            da.SelectCommand = sqlComm;
            da.Fill(dt);
            */


        }
        
        public void excluiprod(string produto)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conexao);
                string strIncluir = "delete insumo_fornecedor where cod_Insumo = '" + produto + "'";
                conn.Open();
                SqlCommand sqlComm = new SqlCommand(strIncluir, conn);
                sqlComm.ExecuteNonQuery();

                strIncluir = "delete Produto_Insumo where cod_Insumo= '" + produto + "'";

                sqlComm = new SqlCommand(strIncluir, conn);
                sqlComm.ExecuteNonQuery();

                strIncluir = "delete Insumo where cod_Insumo= '" + produto + "'";

                sqlComm = new SqlCommand(strIncluir, conn);
                sqlComm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("Falha ao excluir arquivo");
            }
        }
        
        public string ValidaUpdate(string strIncluir)
        {
            //seleciona categoria

            SqlConnection conn = new SqlConnection(conexao);
            //string strIncluir = "select cod_Produto from Produto where Nome_Produto = '" + dtg_gravacao.CurrentRow.Cells[1].ToString(); +"'";
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(strIncluir, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = sqlComm;
            da.Fill(dt);
            //cod_produto= dt.Rows[0][0].ToString();
            conn.Close();
            return dt.Rows[0][0].ToString();
        }
        
        public void preenchefornecedores()
        {

            try
            {
                SqlConnection conn = new SqlConnection(conexao);
                string strIncluir = "select Razao_Social from Fornecedor";
                conn.Open();
                SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;


                da.Fill(dt);

                

                conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao preencher Lista de fornecedores");
            }
        }

        public string txt { get; set; }
        
        public string dtp { get; set; }

        private void txt_nome_Leave(object sender, EventArgs e)
        {
            txt_nome.BackColor = Color.White;
        }

        private void txt_nome_Enter(object sender, EventArgs e)
        {
            txt_nome.BackColor = Color.Aquamarine;
        }

        private void cmb_categoria_Leave(object sender, EventArgs e)
        {
            //cmb_categoria.BackColor = Color.White;
        }

        private void cmb_categoria_Enter(object sender, EventArgs e)
        {
            //  cmb_categoria.BackColor = Color.Aquamarine;
        }

        private void cmb_medida_Enter(object sender, EventArgs e)
        {
            cmb_medida.BackColor = Color.Aquamarine;
        }

        private void cmb_medida_Leave(object sender, EventArgs e)
        {
            cmb_medida.BackColor = Color.White;
        }

        private void txt_vlrunitario_Leave(object sender, EventArgs e)
        {
        }

        private void txt_vlrunitario_Enter(object sender, EventArgs e)
        {

        }

        private void txtbox_Recomendada_Enter(object sender, EventArgs e)
        {
        }

        private void txtbox_Recomendada_Leave(object sender, EventArgs e)
        {
        }

        private void dtp_datarecebimento_Enter(object sender, EventArgs e)
        {
        }

        private void dtp_datarecebimento_Leave(object sender, EventArgs e)
        {
        }

        private void dtp_datafabricacao_Enter(object sender, EventArgs e)
        {
            dtp_datafabricacao.BackColor = Color.Aquamarine;
        }

        private void dtp_datafabricacao_Leave(object sender, EventArgs e)
        {
            dtp_datafabricacao.BackColor = Color.White;
        }

        private void dtp_datavalidade_Enter(object sender, EventArgs e)
        {
            dtp_datavalidade.BackColor = Color.Aquamarine;
        }

        private void dtp_datavalidade_Leave(object sender, EventArgs e)
        {
            dtp_datavalidade.BackColor = Color.White;
        }

        private void cbox_Fornecedores_Leave(object sender, EventArgs e)
        {
        }

        private void cbox_Fornecedores_Enter(object sender, EventArgs e)
        {
        }
        
        private void cbox_Fornecedores_DropDown(object sender, EventArgs e)
        {
        }

        private void txt_vlrunitario_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void txtBuscarPorNome_TextChanged(object sender, EventArgs e)
        {
            objInsumo = new clsInsumo();
            objInsumo.Nome_Insumo = txtBuscarPorNome.Text.ToString();

            dtg_gravacao.DataSource = insumoBLL.SelecionaInsumoPorNome(objInsumo);
        }

        private void txtBuscarPorID_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarPorID.Text.Length > 0 && !validaCampoNumerico(txtBuscarPorID))
                return;

            if (txtBuscarPorID.Text.Length == 0)
                dtg_gravacao.DataSource     = insumoBLL.CarregaInsumos();
            else
            {
                objInsumo                   = new clsInsumo();
                objInsumo.Cod_Insumo        = Int32.Parse(txtBuscarPorID.Text);
                dtg_gravacao.DataSource     = insumoBLL.SelecionaInsumoPorID(objInsumo);
            }
        }

        public bool validaCampoNumerico(TextBox campo)
        {
            int s = 0;

            Int32.TryParse(campo.Text, out s);

            if (campo.TextLength > 0 && campo.Text == "0")
            {
                campo.Text = "";

                return false;
            }

            if (s == 0)
            {
                Home.mensagemDeErro("Por favor, insira apenas números no campo.", "Erro no campo");

                campo.Text = campo.Text.Remove(campo.TextLength - 1);

                return false;
            }
            return true;
        }
    }

}
