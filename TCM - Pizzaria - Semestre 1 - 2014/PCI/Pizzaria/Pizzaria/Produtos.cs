using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        string strsql = "", nome = "", cod_produto = "", categoria = "", medida = "";
        DateTime datavalidade, datarecebimento, datafabricacao;
        double valoruntd = 0;
        Boolean valida = false;
        int qtd = 0, site = 0;

        string buscarPorNome = "";
        string buscarPorID = "";

        public Form FormHome { get; set; }

        String conexao = "";

        public void preencherGrid(string busca, DataGridView tabela)
        {

            conn = new SqlConnection(conexao);
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(busca, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabela.DataSource = dt;
            conn.Close();
        }

        public void preenchegrid()
        {

            try
            {
                SqlConnection conn = new SqlConnection(conexao);
                string strIncluir = "select Nome_Produto,Valor_Venda, sobe_site from produto";
                conn.Open();
                SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;


                da.Fill(dt);
                conn.Close();
                dtg_produtos.DataSource = dt;


            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("Falha ao preencher tabela com produtos cadastrados");
            }


        }   

        private void Insumo_Load(object sender, EventArgs e)
        {
            conexao = Acesso.Conexao;
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.FormHome.Show();
            Dispose();
        }


        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (btn_atualizar.Text == "Alterar")
            {
                btn_atualizar.Text = "Gravar";
                txt_nome.Enabled = true;
                txt_vlrunitario.Enabled = true;
                chk_site.Enabled = true;
                gbp_produtos.Enabled = true;
            }
            else 
            {
                int sobeProSite = 0;
                if (chk_site.Checked)
                    sobeProSite = 1;

                int idProduto = (int)dtg_produtos.CurrentRow.Cells[0].Value;

                preenchegrid("UPDATE Produto SET Nome_Produto = '" + txt_nome.Text + "', Valor_Venda = " + txt_vlrunitario.Text.Replace("R$", "").Replace(" ", "") + ", Sobe_Site = " + sobeProSite + " WHERE cod_Produto = " + dtg_produtos.CurrentRow.Cells[0].Value);

                preenchegrid("select cod_Produto as [ID], Nome_Produto as [Produto], Valor_Venda as [Preço], Sobe_Site as [Visível no site] from Produto where Cod_Produto like (" + idProduto + ")");

                txt_vlrunitario.Clear();
                txt_nome.Clear();
                chk_site.Checked = false;
                btn_atualizar.Text = "Alterar";
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            dtg_produtos.Enabled = true;
            btn_excluir.Enabled = false;
            btn_atualizar.Enabled = false;
            btn_inserir.Enabled = true;

        }

        public bool ValidaCampos()
        {
            //valida nome
            if (txt_nome.TextLength > 2)
            {
                nome = txt_nome.Text;
                //Valida categoria
                /*if (cmb_categoria.SelectedIndex > 0)
                {
                    categoria = cmb_categoria.SelectedItem.ToString();*/
                   // Valida valor
                        if (Convert.ToInt32(txt_vlrunitario.Text.Replace(",", "").Replace(".", "").Replace("_", "").Replace(" ", "").Replace("R$", "")) > 0)
                        {
                            valoruntd = Convert.ToDouble(txt_vlrunitario.Text.Replace(" ", "").Replace(".", "").Replace("_", "").Replace(" ", "").Replace("R$", "")) / 100;

                         
                                if (chk_site.Checked == true)
                                {
                                    site = 1;
                                    return true;
                                }
                                else
                                {
                                    site  = 0;
                                    return true;
                                }
                                //  MessageBox.Show(Convert.ToString(dtp_datanasc.Value.Date.AddYears(18)));
                           
                        
                           
                        }
                        /*else
                        {
                            MessageBox.Show("Valor Unitario Incorreta!");
                        }*/
                
                
                else
                {
                    MessageBox.Show("Categoria Incorreta!");
                }
            }
            else
            {
                MessageBox.Show("Nome Incorreto!");
            }
            return false;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (Validaexistente())
                {
//                    inseredados();
            //        preenchegrid();
                    int sobeSite = 0;
                    if (chk_site.Checked)
                        sobeSite = 1;
                    else
                        sobeSite = 0;

                    Home.preencherGrid("insert into produto(Nome_Produto, Valor_Venda, Sobe_Site) values('"+ txt_nome.Text +"', "+ txt_vlrunitario.Text +", " + sobeSite + ") ", dtg_produtos);

                    Home.preencherGrid("select cod_Produto as [ID], Nome_Produto as [Produto], Valor_Venda as [Preço], Sobe_Site as [Visível no site] from Produto where Nome_Produto like ('%" + txt_nome.Text + "%')", dtg_produtos);

                    txt_nome.Clear();
                    txt_vlrunitario.Clear();
                    chk_site.Checked = false;

                }
                else
                {
                    MessageBox.Show("Ja existe produto com este nome");
                }
            }

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
           // strsql = "select cod_Produto from Produto where Nome_Produto = '" + dtg_produtos.CurrentRow.Cells[0].Value.ToString() + "'";
            //obtem cod do produto antes de alterar
            cod_produto = dtg_produtos.CurrentRow.Cells[0].Value.ToString();

//            excluiprod(cod_produto);

            Home.preencherGrid("delete Produto_Insumo where cod_produto = '" + cod_produto +"'",dtg_produtos);

            Home.preencherGrid("delete ProdutoPromocao where cod_produto = '" + cod_produto + "'", dtg_produtos);

            Home.preencherGrid("delete Detalhe_Pedido where cod_produto = '" + cod_produto + "'", dtg_produtos);

            Home.preencherGrid("delete Produto where cod_produto = '" + cod_produto + "'", dtg_produtos);

            dtg_produtos.Enabled = true;
        }

        public void preenchegrid(string comandoSQL)
        {

            try
            {
                SqlConnection conn = new SqlConnection(conexao);
                conn.Open();
                SqlCommand sqlComm = new SqlCommand(comandoSQL, conn);

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;


                da.Fill(dt);
                conn.Close();
                dtg_produtos.DataSource = dt;


            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("Falha ao preencher tabela com produtos cadastrados");
            }


        }

        public void inseredados()
        {
            //seleciona categoria
            SqlConnection conn = new SqlConnection(conexao);

            //Insere dados
            conn = new SqlConnection(conexao);
            string strIncluir = "insert into Produto (Nome_Produto, Valor_venda,Sobe_Site ) values ('" + nome + "','" + valoruntd.ToString().Replace(",",".") + "','"+ site +"')";
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(strIncluir, conn);
            sqlComm.ExecuteNonQuery();
        }
        
        public Boolean Validaexistente()
        {

            SqlConnection conn = new SqlConnection(conexao);
            string strIncluir = "select * from Produto where Nome_Produto = '" + nome + "'";
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = sqlComm;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {



                return true;
            }


        }
        
        public void PreencheCatego()
        {

            SqlConnection conn = new SqlConnection(conexao);
            string strIncluir = "select nome_Categoria from categoria";
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;


            da.Fill(dt);


          

            conn.Close();

        }

        public void excluiprod(string produto)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conexao);
                string strIncluir = "select cod_Produto from Produto where Nome_Produto = '" + produto + "'";
                conn.Open();
                SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = sqlComm;
                da.Fill(dt);

                conn = new SqlConnection(conexao);
                strIncluir = "delete Produto_Insumo where cod_produto = '" + dt.Rows[0][0].ToString() + "'";

                sqlComm = new SqlCommand(strIncluir, conn);
                conn.Open();
                sqlComm.ExecuteNonQuery();

                conn = new SqlConnection(conexao);
                strIncluir = "delete ProdutoPromocao where cod_produto = '" + dt.Rows[0][0].ToString() + "'";

                sqlComm = new SqlCommand(strIncluir, conn);
                conn.Open();
                sqlComm.ExecuteNonQuery();

                conn = new SqlConnection(conexao);
                strIncluir = "delete Detalhe_Pedido where cod_produto = '" + dt.Rows[0][0].ToString() + "'";

                sqlComm = new SqlCommand(strIncluir, conn);
                conn.Open();
                sqlComm.ExecuteNonQuery();

                conn = new SqlConnection(conexao);
                strIncluir = "delete Produto where Nome_Produto = '" + produto + "'";
                
                sqlComm = new SqlCommand(strIncluir, conn);
                conn.Open();
                sqlComm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
               
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
            return dt.Rows[0][0].ToString();
        }

        private void dtg_produtos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nome.Text = dtg_produtos.CurrentRow.Cells[1].Value.ToString();

            txt_vlrunitario.Text = dtg_produtos.CurrentRow.Cells[2].Value.ToString();


            if ((int)dtg_produtos.CurrentRow.Cells[3].Value == 0)
                chk_site.Checked = true;
            else
                chk_site.Checked = false;

            btn_atualizar.Enabled = true;
            gbp_produtos.Enabled = false;
            btn_inserir.Enabled = false;

        }

        private void txt_nome_Enter(object sender, EventArgs e)
        {
            txt_nome.BackColor = Color.Aquamarine;
        }

        private void txt_nome_Leave(object sender, EventArgs e)
        {
            txt_nome.BackColor = Color.White;
        }

        private void txt_vlrunitario_Enter(object sender, EventArgs e)
        {
            txt_vlrunitario.BackColor = Color.Aquamarine;
        }

        private void txt_vlrunitario_Leave(object sender, EventArgs e)
        {
            txt_vlrunitario.BackColor = Color.White;
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscaPorNome_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBuscaPorNome_KeyPress(object sender, EventArgs e)
        {
            
        }

        private void txtBuscaPorID_KeyPress(object sender, EventArgs e)
        {

        }

        private void txtBuscaPorNome_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBuscaPorID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBuscaPorNome_KeyPress_1(object sender, KeyEventArgs e)
        {
            
        }

        private void txtBuscaPorNome_Leave(object sender, EventArgs e)
        {
            txtBuscaPorNome.Clear();

            dtg_produtos.DataSource = null;
            dtg_produtos.Rows.Clear();
        }

        private void txtBuscaPorID_Leave(object sender, EventArgs e)
        {
            txtBuscaPorID.Clear();
        }

        private void txtBuscaPorNome_TextChanged(object sender, EventArgs e)
        {
            dtg_produtos.DataSource = null;

            dtg_produtos.Rows.Clear();

            Home.preencherGrid("select cod_Produto as [ID], Nome_Produto as [Produto], Valor_Venda as [Preço], Sobe_Site as [Visível no site] from Produto where Nome_Produto like ('%" + txtBuscaPorNome.Text + "%')", dtg_produtos);
        }

        private void txtBuscaPorID_TextChanged(object sender, EventArgs e)
        {
            dtg_produtos.DataSource = null;

            dtg_produtos.Rows.Clear();
            
            Home.preencherGrid("select cod_Produto as [ID], Nome_Produto as [Produto], Valor_Venda as [Preço], Sobe_Site as [Visível no site] from Produto where cod_Produto like (" + txtBuscaPorID.Text + ")", dtg_produtos);
        }

        private void chk_site_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "Pizza Quatro Queijos";
            txt_vlrunitario.Text = "23,30";
            chk_site.Checked = true;
        }

        private void dtg_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
