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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            PreencheCatego();
            preenchegrid();
            btn_alterar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_gravar.Enabled = false;




        }


        SqlConnection conn;
        string strsql="",nome = "", cod_produto = "", categoria = "", medida = "";
        DateTime datavalidade, datarecebimento, datafabricacao;
        double valoruntd = 0;
        Boolean valida = false;
        int qtd = 0;

        //conexao DB
        string conexao = "Data Source=TECNICO01-PC\\BPASERVER9 ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=AutoMateBPA9";
      

      

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {/*
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

        private void btn_gravar_Click_1(object sender, EventArgs e)
        {

            if (ValidaCampos())
            {
                if (Validaexistente())
                {
                    strsql = "select cod_Produto from Produto where Nome_Produto = '" + dtg_gravacao.CurrentRow.Cells[0].Value.ToString() + "'";
                    //obtem cod do produto antes de alterar
                    cod_produto = ValidaUpdate(strsql);
                    atualizarproduto(cod_produto);
                    dtg_gravacao.Enabled = true;
                    btn_excluir.Enabled = false;
                    btn_gravar.Enabled = false;
                    btn_cancelar.Enabled = false;
                    btn_alterar.Enabled = false;
                    preenchegrid();
                }
                else
                {
                    
                    strsql = "select cod_Produto from Produto where Nome_Produto = '" + dtg_gravacao.CurrentRow.Cells[0].Value.ToString() + "'";
                    //obtem cod do produto antes de alterar
                    cod_produto = ValidaUpdate(strsql);
                    strsql = "select cod_Produto from Produto where Nome_Produto = '" + nome + "'";
                    if (cod_produto == ValidaUpdate(strsql))
                    {
                        atualizarproduto(cod_produto);
                        dtg_gravacao.Enabled = true;
                        btn_excluir.Enabled = false;
                        btn_gravar.Enabled = false;
                        btn_cancelar.Enabled = false;
                        btn_alterar.Enabled = false;
                        preenchegrid();
                    }
                    else
                    {
                        MessageBox.Show("Ja existe um produto com este nome");
                    }
                }

            }

        }

        private void dtg_gravacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_nome.Text = dtg_gravacao.CurrentRow.Cells[0].Value.ToString();
            txt_vlrunitario.Text = dtg_gravacao.CurrentRow.Cells[1].Value.ToString();
            dtp_datavalidade.Value = Convert.ToDateTime(dtg_gravacao.CurrentRow.Cells[2].Value.ToString());
            txt_qdtcomprada.Text = dtg_gravacao.CurrentRow.Cells[3].Value.ToString();
            gpb_compras.Enabled = false;
            btn_alterar.Enabled = true;
            btn_inserir.Enabled = false;


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


            for (int i = 1; i > dt.Rows.Count; i++)
            {
                cmb_categoria.Items.Add((dt.Rows[i][1].ToString()));

            }

            conn.Close();

        }

        public Boolean ValidaCampos() 
        {
            //valida nome
            if (txt_nome.TextLength > 2)
            {
                nome = txt_nome.Text;
                //Valida categoria
                if(cmb_categoria.SelectedIndex > 0)
                {
                    categoria = cmb_categoria.SelectedItem.ToString();
                    // valida medida
                    if (cmb_medida.SelectedIndex > 0)
                    {
                        medida = cmb_medida.SelectedItem.ToString();
                        //Valida campo valor unitario
                        if (Convert.ToInt32(txt_vlrunitario.Text.Replace(",", "").Replace(".", "").Replace("_","").Replace(" ","").Replace("R$","")) > 0)
                        {
                            valoruntd = Convert.ToDouble(txt_vlrunitario.Text.Replace(" ", "").Replace(".", "").Replace("_", "").Replace(" ", "").Replace("R$", ""))/100;

                            //Valida Quantidade
                            if (Convert.ToInt32(txt_qdtcomprada.Text.Replace(",","").Replace(".","")) > 0)
                            {
                                qtd = Convert.ToInt32(txt_qdtcomprada.Text.Replace(",", "").Replace(".", ""));

                                // Obtem os valores de data

                                datafabricacao = dtp_datafabricacao.Value;
                                datavalidade = dtp_datavalidade.Value;
                                datarecebimento = dtp_datarecebimento.Value;
                                return true;


                            }
                            else
                            {
                                MessageBox.Show("Quantidade Incorreta!");
                            }
                                    
                        }
                        else
                        {
                            MessageBox.Show("Valor Unitario Incorreta!");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Medida Incorreta!");
                    }
                }
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

        public Boolean Validaexistente()
            {

            SqlConnection conn = new SqlConnection(conexao);
            string strIncluir = "select * from Produto where Nome_Produto = '"+ nome + "'";
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = sqlComm;
            da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }

        public void inseredados() 
        {


            //seleciona categoria

            SqlConnection conn = new SqlConnection(conexao);
            string strIncluir = "select cod_Categoria from Categoria where Nome_Categoria = '"+ categoria + "'";
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = sqlComm;
            da.Fill(dt);

            //Insere dados
            conn = new SqlConnection(conexao);
            strIncluir = "insert into Produto (Nome_Produto, Valor_venda,validade,qtd_Estoque,cod_categoria) values ('"+nome+"','"+valoruntd+"','"+datavalidade+"','"+qtd + "','"+ dt.Rows[0][0].ToString()+ "')";
            conn.Open();
            sqlComm = new SqlCommand(strIncluir, conn);
            sqlComm.ExecuteNonQuery();

        
        
        }

        public void preenchegrid() 
        {

            try
            {
                SqlConnection conn = new SqlConnection(conexao);
                string strIncluir = "select Nome_Produto,Valor_Venda,Validade,Qtd_Estoque from produto";
                conn.Open();
                SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;


                da.Fill(dt);

                dtg_gravacao.DataSource = dt;


            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao preencher tabela com produtos cadastrados");
            }
            

        }


        public string txt { get; set; }

        public string dtp { get; set; }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
           //gpb_compras.Enabled = false;

            //valida = true;
            //btn_gravar.Text = "Atualizar";
            dtg_gravacao.Enabled = false;
            btn_excluir.Enabled = true;
            gpb_compras.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_gravar.Enabled = true;
            btn_alterar.Enabled = false;
        }

        public void atualizarproduto(string cod_prod)
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
            strIncluir = "update Produto set Nome_Produto ='" + nome + "',Valor_venda='" + valoruntd.ToString().Replace(",",".") + "',validade ='" + datavalidade + "',qtd_Estoque= qtd_Estoque +" + qtd + ",cod_categoria ='" + dt.Rows[0][0].ToString() + "' where Cod_Produto = '" + cod_prod + "'";
            conn.Open();
            sqlComm = new SqlCommand(strIncluir, conn);
            sqlComm.ExecuteNonQuery();
           
            da.SelectCommand = sqlComm;
            da.Fill(dt);



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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            dtg_gravacao.Enabled = true;
            btn_excluir.Enabled = false;
            btn_gravar.Enabled = false;
            btn_inserir.Enabled = true;

        }

        private void txt_vlrunitario_TextChanged(object sender, EventArgs e)
        {
            //Decimal.Parse(txt_vlrunitario.Text).ToString("N2");
        }

        private void dtg_gravacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            strsql = "select cod_Produto from Produto where Nome_Produto = '" + dtg_gravacao.CurrentRow.Cells[0].Value.ToString() + "'";
            //obtem cod do produto antes de alterar
            cod_produto = ValidaUpdate(strsql);

            excluiprod(cod_produto);

            dtg_gravacao.Enabled = true;
            btn_excluir.Enabled = false;
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_alterar.Enabled = false;
            preenchegrid();

        }

        public void excluiprod(string produto)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conexao);
                string strIncluir = "delete Produto where cod_Produto = '" + produto + "'";
                conn.Open();
                SqlCommand sqlComm = new SqlCommand(strIncluir, conn);
                sqlComm.ExecuteNonQuery();
            }
            catch(Exception)
            {
                MessageBox.Show("Falha ao excluir arquivo");
            }
        }
    }
}
