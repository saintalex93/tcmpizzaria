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

        public Form FormHome { get; set; }

        //conexao DB
        //ALEX
        // string conexao = "Data Source=ALEX\\SQLEXPRESS ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=1234";

        String conexao = "";
        //EMERSON
        /*string conexao = "Data Source=CASA-PC\\BPASERVER10 ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=AutoMateBPA10";*/


        //RAPHA
        //string conexao = "Data Source=localhost ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=SA; Password=123456";
        
        private void Insumo_Load(object sender, EventArgs e)
        {
            conexao = Acesso.Conexao;
            btn_alterar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_atualizar.Enabled = false;

         
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.FormHome.Show();
            Dispose();
        }

        private void btn_altera_Click(object sender, EventArgs e)
        {

            dtg_produtos.Enabled = false;
            btn_excluir.Enabled = true;
            gbp_produtos.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_atualizar.Enabled = true;
            btn_alterar.Enabled = false;
        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {

            if (ValidaCampos())
            {
                if (Validaexistente())
                {
                    strsql = "select cod_Produto from Produto where Nome_Produto = '" + dtg_produtos.CurrentRow.Cells[0].Value.ToString() + "'";
                    //obtem cod do produto antes de alterar
                    cod_produto = ValidaUpdate(strsql);
                    //atualizarproduto(cod_produto);
                    dtg_produtos.Enabled = true;
                    btn_excluir.Enabled = false;
                    btn_atualizar.Enabled = false;
                    btn_cancelar.Enabled = false;
                    btn_alterar.Enabled = false;
                    btn_inserir.Enabled = true;
                    preenchegrid();
                }
                else
                {

                    strsql = "select cod_Produto from Produto where Nome_Produto = '" + dtg_produtos.CurrentRow.Cells[0].Value.ToString() + "'";
                    //obtem cod do produto antes de alterar
                    cod_produto = ValidaUpdate(strsql);
                    strsql = "select cod_Produto from Produto where Nome_Produto = '" + nome + "'";
                    if (cod_produto == ValidaUpdate(strsql))
                    {
                        //atualizarproduto(cod_produto);
                        dtg_produtos.Enabled = true;
                        btn_excluir.Enabled = false;
                        btn_atualizar.Enabled = false;
                        btn_cancelar.Enabled = false;
                        btn_alterar.Enabled = false;
                        btn_inserir.Enabled = true;
                        preenchegrid();
                    }
                    else
                    {
                        MessageBox.Show("Ja existe um produto com este nome");
                    }
                }

            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            dtg_produtos.Enabled = true;
            btn_excluir.Enabled = false;
            btn_atualizar.Enabled = false;
            btn_inserir.Enabled = true;

        }
        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (Validaexistente())
                {
                    inseredados();
                    preenchegrid();
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

            excluiprod(cod_produto);

            dtg_produtos.Enabled = true;
            btn_excluir.Enabled = false;
            btn_inserir.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_alterar.Enabled = false;
            preenchegrid();
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
        public void inseredados()
        {


            //seleciona categoria

            SqlConnection conn = new SqlConnection(conexao);
            /*string strIncluir = "select cod_Categoria from Categoria where Nome_Categoria = '" + categoria + "'";
            string strIncluir = "select cod_produto from Produto where";
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = sqlComm;
            da.Fill(dt);*/

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
        public Boolean ValidaCampos()
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
        /*public void atualizarproduto(string cod_prod)
        {


            //seleciona categoria

            SqlConnection conn = new SqlConnection(conexao);
            string strIncluir = "select cod_Categoria from Categoria where Nome_Categoria = '" + categoria + "'";
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = sqlComm;
            da.Fill(dt);

            //atualiza produto
            conn = new SqlConnection(conexao);
            strIncluir = "update Produto set Nome_Produto ='" + nome + "',Valor_venda='" + valoruntd.ToString().Replace(",", ".") + "',cod_categoria ='" + dt.Rows[0][0].ToString() + "', Sobe_Site = '" + site + "' where Cod_Produto = '" + cod_prod + "'";
            conn.Open();
            sqlComm = new SqlCommand(strIncluir, conn);
            sqlComm.ExecuteNonQuery();

            da.SelectCommand = sqlComm;
            da.Fill(dt);



        }*/
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
            txt_nome.Text = dtg_produtos.CurrentRow.Cells[0].Value.ToString();
            txt_vlrunitario.Text = dtg_produtos.CurrentRow.Cells[1].Value.ToString();
           

            gbp_produtos.Enabled = false;
            btn_alterar.Enabled = true;
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


    }

}
