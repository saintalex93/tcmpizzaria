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
    public partial class Insumo : Form
    {
        public Insumo()
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
            preenchefornecedores();
            


        }


        SqlConnection conn;
        string strsql = "", nome = "", cod_produto = "", categoria = "", medida = "";
        DateTime datavalidade, datarecebimento, datafabricacao;
        double valoruntd = 0;
        Boolean valida = false;
        int qtd = 0,cod_categoria= 0;

        //conexao DB
       // string conexao = "Data Source=ALEX\\SQLEXPRESS ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=1234";
        string conexao = "Data Source=CASA-PC\\BPASERVER10 ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=AutoMateBPA10";



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
                    //Nome procurado não existe
                  //  strsql = "select cod_Insumo from Insumo where Nome_Insumo = '" + dtg_gravacao.CurrentRow.Cells[0].Value.ToString() + "'";
                    //obtem cod do produto antes de alterar
                 //   cod_produto = ValidaUpdate(strsql);
                    atualizarproduto(dtg_gravacao.CurrentRow.Cells[0].Value.ToString());
                    dtg_gravacao.Enabled = true;
                    btn_excluir.Enabled = false;
                    btn_gravar.Enabled = false;
                    btn_cancelar.Enabled = false;
                    btn_alterar.Enabled = false;
                    btn_inserir.Enabled = true;
                    preenchegrid();
                }
                else
                {

                 //   strsql = "select cod_Insumo from Insumo where Nome_Insumo = '" + dtg_gravacao.CurrentRow.Cells[0].Value.ToString() + "'";
                    //obtem cod do produto antes de alterar
                //    cod_produto = ValidaUpdate(strsql);
                    strsql = "select cod_Produto from Produto where Nome_Produto = '" + nome + "'";
                    if (cod_produto == dtg_gravacao.CurrentRow.Cells[0].Value.ToString())
                    {
                        atualizarproduto(dtg_gravacao.CurrentRow.Cells[0].Value.ToString());
                        dtg_gravacao.Enabled = true;
                        btn_excluir.Enabled = false;
                        btn_gravar.Enabled = false;
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
        private void dtg_gravacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_nome.Text = dtg_gravacao.CurrentRow.Cells[1].Value.ToString();
            txt_vlrunitario.Text = dtg_gravacao.CurrentRow.Cells[2].Value.ToString();
            dtp_datavalidade.Value = Convert.ToDateTime(dtg_gravacao.CurrentRow.Cells[5].Value.ToString());
            dtp_datafabricacao.Value = Convert.ToDateTime(dtg_gravacao.CurrentRow.Cells[6].Value.ToString());
            dtp_datarecebimento.Value = Convert.ToDateTime(dtg_gravacao.CurrentRow.Cells[7].Value.ToString());
            txt_qdtcomprada.Text = dtg_gravacao.CurrentRow.Cells[3].Value.ToString();
            gpb_compras.Enabled = false;
            btn_alterar.Enabled = true;
            btn_inserir.Enabled = false;
            dtg_gravacao.Enabled = false;

        }
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            //gpb_compras.Enabled = false;

            //valida = true;
            //btn_gravar.Text = "Atualizar";
            
            btn_excluir.Enabled = true;
            gpb_compras.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_gravar.Enabled = true;
            btn_alterar.Enabled = false;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            dtg_gravacao.Enabled = true;
            btn_excluir.Enabled = false;
            btn_gravar.Enabled = false;
            btn_inserir.Enabled = true;
            gpb_compras.Enabled = true;
            btn_alterar.Enabled = false;
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
        private void gpb_compras_Enter(object sender, EventArgs e)
        {

        }
        private void dtp_datafabricacao_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btn_inserir_Click_1(object sender, EventArgs e)
        {

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


            for (int i = 1; i < dt.Rows.Count; i++)
            {
               cmb_categoria.Items.Add((dt.Rows[i][0].ToString()));

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
                if (cmb_categoria.SelectedIndex > 0)
                {
                    categoria = cmb_categoria.SelectedItem.ToString();
                    // valida medida
                    if (cmb_medida.SelectedIndex > 0)
                    {
                        medida = cmb_medida.SelectedItem.ToString();
                        //Valida os campos de valores
                        if (txt_vlrunitario.Text.Replace(",", "").Replace(".", "").Replace("_", "").Replace(" ", "").Replace("R$", "").Length == 0)
                        {
                            txt_vlrunitario.Text = "0";
                        }
                        if (txt_qdtcomprada.Text.Replace(",", "").Replace(".", "").Replace("_", "").Replace(" ", "").Replace("R$", "").Length == 0)
                        {
                            txt_qdtcomprada.Text = "0";
                        }
                        if (txtbox_Recomendada.Text.Replace(",", "").Replace(".", "").Replace("_", "").Replace(" ", "").Replace("R$", "").Length == 0)
                        {
                            txtbox_Recomendada.Text = "0";
                        }

                        //Valida campo valor unitario
                        if (Convert.ToInt32(txt_vlrunitario.Text.Replace(",", "").Replace(".", "").Replace("_", "").Replace(" ", "").Replace("R$", "")) > 0)
                        {
                            valoruntd = Convert.ToDouble(txt_vlrunitario.Text.Replace(" ", "").Replace(".", "").Replace("_", "").Replace(" ", "").Replace("R$", "")) / 100;

                            //Valida Quantidade
                            if (Convert.ToInt32(txt_qdtcomprada.Text.Replace(",", "").Replace(".", "")) > 0)
                            {
                                qtd = Convert.ToInt32(txt_qdtcomprada.Text.Replace(",", "").Replace(".", ""));

                                // Obtem os valores de data

                                //Valida Campo Data

                               // if (dtp_datafabricacao.Value.Date.AddDays(-1) < DateTime.Today.ToLocalTime())
                                if (dtp_datafabricacao.Value.Date < DateTime.Today.ToLocalTime())
                                {
                                    datafabricacao = dtp_datafabricacao.Value;
                                    if (dtp_datavalidade.Value.Date > DateTime.Today.ToLocalTime())
                                    {


                                        datavalidade = dtp_datavalidade.Value;

                                        if (dtp_datarecebimento.Value.Date > dtp_datafabricacao.Value.Date)
                                        {
                                            datarecebimento = dtp_datarecebimento.Value;

                                            if (cbox_Fornecedores.SelectedIndex > 0)
                                            {
                                                if (Convert.ToInt32(txt_qdtcomprada.Text.Replace(",", "").Replace(".", "")) > 0)
                                                {
                                                return true;    
                                                }
                                                
                                                   else

                                                {
                                                MessageBox.Show("Quantidade Recomendada incorreta!");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Fornecedor incorreto!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Data de Recebimento incorreta!");
                                        }
                                    }

                                    else
                                    {
                                        MessageBox.Show("Data de Validade incorreta!");
                                    }
                                }



                                else
                                {
                                    MessageBox.Show("Data de Fabricação incorreta!");
                                }
                                
                               
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
            string strIncluir = "select * from insumo where Nome_insumo = '" + nome + "'";
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
        public void inseredados()
        {


            //seleciona categoria
            try
            {
                SqlConnection conn = new SqlConnection(conexao);
                string strIncluir = "select cod_Categoria from Categoria where Nome_Categoria = '" + categoria + "'";
                conn.Open();
                SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = sqlComm;
                da.Fill(dt);
                cod_categoria = Convert.ToInt32(dt.Rows[0][0].ToString());
                conn.Close();
                //Insere dados
                conn = new SqlConnection(conexao);
                strIncluir = "insert into insumo " +
                    "(Nome_Insumo, Medida, ValorDeCompra,QtdeEmEstoque, " +
                    "Recebimento, Fabricacao,validade,Cod_Categoria,QtdeRecomendavel) values ('"
                    + nome + "','" + medida + "','" + valoruntd.ToString().Replace(",", ".") + "','" +
                    qtd + "','" + datarecebimento.ToString("dd/MM/yyyy") + "','" + datafabricacao.ToString("dd/MM/yyyy") +
                    "','" + datavalidade.ToString("dd/MM/yyyy") + "','" + cod_categoria + "','" + txtbox_Recomendada.Text.ToString() +"')";
                conn.Open();
                sqlComm = new SqlCommand(strIncluir, conn);
                sqlComm.ExecuteNonQuery();
                

                try
                {
                    conn.Close();
                    //Recupera cod do insumo
                    conn = new SqlConnection(conexao);
                    strIncluir = "select cod_insumo from Insumo where nome_Insumo = '" + nome + "'";
                    conn.Open();
                    sqlComm = new SqlCommand(strIncluir, conn);

                       da = new SqlDataAdapter();
                       dt = new DataTable();
                    da.SelectCommand = sqlComm;
                    da.Fill(dt);

                    //Atualiza Insumo_Fornecedor
                    conn = new SqlConnection(conexao);
                    strIncluir = "insert into Insumo_Fornecedor " +
                    " select insu.Cod_Insumo,forne.Cod_Fornecedor " +
                    " from Insumo insu, Fornecedor forne where " +
                    " insu.Nome_Insumo = '" + nome + "' and forne.Razao_Social = '" + cbox_Fornecedores.SelectedItem.ToString() + "'";
                    conn.Open();
                    sqlComm = new SqlCommand(strIncluir, conn);
                    sqlComm.ExecuteNonQuery();
                    conn.Close();


                }
                catch(Exception)
                {
                    MessageBox.Show("Falha ao inserir Insumo!");
                    conn.Close();
                }



            }
            catch(Exception)
            {
                MessageBox.Show("Falha ao inserir Insumo!");
                conn.Close();
            }


        }
        public void preenchegrid()
        {

            try
            {
                SqlConnection conn = new SqlConnection(conexao);
                string strIncluir = "select * from insumo";
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
            strIncluir = "update Insumo set Nome_Insumo ='" + nome + 
                "',ValorDeCompra='" + valoruntd.ToString().Replace(",", ".") + 
                "',QtdeRecomendavel = '"+ txtbox_Recomendada.Text.ToString() +"',validade ='" + 
                datavalidade + "',qtdeemEstoque= qtdeemEstoque +" + qtd + 
                ",cod_categoria ='" + dt.Rows[0][0].ToString() + "',Fabricacao = '"+ datafabricacao +
                "',Recebimento = '"+ datarecebimento +"', medida ='"+ medida + "' where Cod_Insumo = '" + 
                cod_prod + "'";

            conn.Open();
            sqlComm = new SqlCommand(strIncluir, conn);
            sqlComm.ExecuteNonQuery();

            da.SelectCommand = sqlComm;
            da.Fill(dt);



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


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                     cbox_Fornecedores.Items.Add((dt.Rows[i][0].ToString()));

                }

                conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao preencher Lista de fornecedores");
            }
        }

        public string txt { get; set; }
        public string dtp { get; set; }
    }

}
