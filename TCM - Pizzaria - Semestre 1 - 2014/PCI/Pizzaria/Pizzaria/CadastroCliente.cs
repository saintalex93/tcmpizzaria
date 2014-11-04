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
using Microsoft.VisualBasic;



namespace Pizzaria
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        public Form FormHome { get; set; }

        //Variaveis de dados
        SqlConnection conn;
        string cod_cliente, nome = "", cep="",email = "", endereco = "", bairro = "", cidade = "", uf = "", complemento = "", telefone = "", cel = "", cpf = "",strIncluir = "";
        int num_endereco = 0;

        //conexao DB
        string conexao = ""/*Data Source=Alex\\SQLEXPRESS ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=1234"*/;
       // string conexao = "Data Source=192.168.1.105\\BPAServer9;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=AutoMateBPA9";
        
        //Validar se e update ou insert
        Boolean valida = false;


        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.FormHome.Show();
            Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {}

        private void CadastroCliente_Load_1(object sender, EventArgs e)
        {
//            btn_alterar.Enabled = true;
            btn_excluir.Enabled = false;

            preenchegrid();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_gravar_Click_1(object sender, EventArgs e)
        {
            
            if (ValidaCampos() == true)
            {

                switch (valida)
                {
                    case true:
                        cod_cliente = dtgw_dados.CurrentRow.Cells[0].Value.ToString();

                        strIncluir = "update cliente set Nome_Cliente = '" + nome + "',CPF_Cliente = '" + cpf + "',Endereco_Cliente = '" + endereco + "',Complemento_Cliente ='" + complemento + "',Número_Cliente = '" + num_endereco + "',CEP_Cliente = '" + cep + "',Estado_Cliente = '" + uf + "',Cidade_Cliente = '" + cidade + "' ,Email_Cliente = '" + email + "' ,Telefone_Cliente = '" + telefone + "' ,Celular_Cliente = '" + cel + "' ,Bairo_Cliente = '" + bairro + "' where Cod_Cliente =  '"+ cod_cliente +"'";
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////'" + nome + "','" + cpf + "','" + endereco + "','" + complemento + "','" + num_endereco + "','" + cep + "','" + uf + "','" + cidade + "','" + email + "','" + telefone + "','" + cel + "','" + bairro + "')
                       //insert into Cliente () values (";

                         conn = new SqlConnection(conexao);
                                    conn.Open();
                                    try
                                    {


                                        

                                        SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                                        sqlComm.ExecuteNonQuery();




                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Dados de localidade invalidos ou não preenchidos!");



                                    }
                                    conn.Close();

                                    preenchegrid();
                                    Clear_Dados();
                        


                        valida = false;
                      //  groupBox1.Enabled = false;
                     //   groupBox2.Enabled = false;
                        break;
                    case false:

                        //Verificar se existe usuario cadastrado
                       

                        // fim da verificacao

                        strIncluir = "select * from CLiente where CPF_Cliente = '" + cpf + "'";

                       if (Buscar(strIncluir).Rows.Count <= 0)
                       {
                           strIncluir = "insert into Cliente (Nome_Cliente,CPF_Cliente,Endereco_Cliente,Complemento_Cliente ,Número_Cliente ,CEP_Cliente,Estado_Cliente,Cidade_Cliente ,Email_Cliente ,Telefone_Cliente ,Celular_Cliente ,Bairo_Cliente) values ('" + nome + "','" + cpf + "','" + endereco + "','" + complemento + "','" + num_endereco + "','" + cep + "','" + uf + "','" + cidade + "','" + email + "','" + telefone + "','" + cel + "','" + bairro + "')";
                           conn = new SqlConnection(conexao);
                           conn.Open();
                           try
                           {

                               SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                               sqlComm.ExecuteNonQuery();

                           }
                           catch (Exception)
                           {
                               MessageBox.Show("Dados de localidade invalidos ou não preenchidos!");

                           }
                           conn.Close();

                           preenchegrid();
                           Clear_Dados();


                       }
                       else
                       {

                           preenchegrid();
                       }


                        break;


                }

            }
            btn_gravar.Text = "Gravar";
        }


      
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (mtxt_cpf.Text.Replace(" ", "").Length == 14)
            {
                cpf = mtxt_cpf.Text;
                strIncluir = "select * from CLiente where CPF_Cliente = '" + cpf + "'";
                Buscar(strIncluir);
             
                






            }

            else
            {

                
                strIncluir = "select * from CLiente";
                Buscar(strIncluir);
            }

        }



        private void dtgw_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            txt_nome.Text = dtgw_dados.CurrentRow.Cells[1].Value.ToString();
            mtxt_cpf.Text = dtgw_dados.CurrentRow.Cells[2].Value.ToString();
            txt_endereco.Text = dtgw_dados.CurrentRow.Cells[3].Value.ToString();
            txt_complemento.Text = dtgw_dados.CurrentRow.Cells[4].Value.ToString();
            txt_numero.Text = dtgw_dados.CurrentRow.Cells[5].Value.ToString();
            mtxt_cep.Text = dtgw_dados.CurrentRow.Cells[6].Value.ToString();
            //Verificar logica para selecionar de acordo com o texto
            //cb_uf.SelectedText.Text = dtgw_dados.CurrentRow.Cells[7].Value.ToString();
            txt_cidade.Text = dtgw_dados.CurrentRow.Cells[8].Value.ToString();
            txt_telefone.Text = dtgw_dados.CurrentRow.Cells[9].Value.ToString();
            mtxt_telefone.Text = dtgw_dados.CurrentRow.Cells[10].Value.ToString();
            mtxt_celular.Text = dtgw_dados.CurrentRow.Cells[11].Value.ToString();
            txt_bairro.Text = dtgw_dados.CurrentRow.Cells[12].Value.ToString();









            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            

            //btn_excluir.Enabled = true;
            btn_alterar.Enabled = true;
            


        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            valida = true;
            btn_excluir.Enabled = true;
            btn_gravar.Text = "Atualizar";

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {


            Clear_Dados();
         
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            /*
            if(Interaction.MsgBox("Deseja?",MsgBoxStyle.OkCancel, "Atenção").)
            {
                MessageBox.Show("TREu");
            }
                else
            {
                MessageBox.Show("False");
            }

            
            cod_cliente = dtgw_dados.CurrentRow.Cells[0].Value.ToString();

            strIncluir = "delete cliente where cod_Cliente = '" + cod_cliente + "'";
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////'" + nome + "','" + cpf + "','" + endereco + "','" + complemento + "','" + num_endereco + "','" + cep + "','" + uf + "','" + cidade + "','" + email + "','" + telefone + "','" + cel + "','" + bairro + "')
            //insert into Cliente () values (";

            conn = new SqlConnection(conexao);
            conn.Open();
            try
            {
               SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                sqlComm.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Dados de localidade invalidos ou não preenchidos!");
                
            }
            conn.Close();

            preenchegrid();
            */

        }





        public void Clear_Dados()
        {

            txt_nome.Text = "";
            mtxt_telefone.Text = "";
            txt_telefone.Text = "";

            mtxt_celular.Text = "";
            mtxt_cep.Text = "";

            mtxt_cpf.Text = "";

            txt_endereco.Text = "";

            txt_bairro.Text = "";

            txt_cidade.Text = "";

            txt_complemento.Text = "";

            txt_numero.Text = "";

            cb_uf.Text = "";

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }

        public void preenchegrid()
        {

            string strIncluir = "select * from Cliente";
            SqlConnection conn = new SqlConnection(conexao);

            conn.Open();


            try
            {


                SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                //sqlComm.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgw_dados.DataSource = dt;


            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao conectar ao Bano de Dados, Contate seu suporte");


            }
            conn.Close();







        }

        public Boolean ValidaCampos()
        {

            // MessageBox.Show("teste");
            if (txt_nome.TextLength > 1)
            {
                if (mtxt_cpf.Text.Replace(" ", "").Length == 14)
                {
                    if (mtxt_telefone.Text.Replace(" ", "").Length == 13)
                    {
                        //  MessageBox.Show(mtxt_telefone.Text.Replace("i", "").Length.ToString());
                        //    MessageBox.Show(mtxt_cpf.Text.Replace("i", "").Length.ToString());
                        // if (txt_nome.TextLength > 3 && txt_telefone.TextLength > 9 && mtxt_telefone.Text.Replace(" ", "").Length == 13 && mtxt_celular.TextLength > 8 && mtxt_cpf.Text.Replace(" ", "").Length == 14)
                        //   {

                        //   if (txt_endereco.TextLength > 6 && txt_bairro.TextLength > 6 && txt_complemento.TextLength > 6 && txt_cidade.TextLength > 6 && txt_numero.TextLength > 6 && cb_uf.SelectionLength > 6)
                        //    {


                        if (txt_nome.TextLength > 3)
                        {
                            nome = txt_nome.Text.ToString();
                        }
                        else
                        {
                            nome = "";

                        }
                        // MessageBox.Show(mtxt_telefone.Text);
                        telefone = mtxt_telefone.Text;
                        if (txt_telefone.TextLength > 3)
                        {
                            email = txt_telefone.Text;
                        }
                        else
                        {
                            email = "";
                        }
                        if (mtxt_celular.Text.Replace(" ", "").Length > 3)
                        {
                            cel = mtxt_celular.Text;
                        }
                        else { cel = ""; }
                        if (mtxt_cep.Text.Replace(" ", "").Length > 3)
                        {
                            cep = mtxt_cep.Text;
                        }
                        else { cep = ""; }
                        if (mtxt_cpf.Text.Replace(" ", "").Length > 3)
                        {
                            cpf = mtxt_cpf.Text;
                        }
                        else { cpf = ""; }
                        if (txt_endereco.TextLength > 3)
                        {
                            endereco = txt_endereco.Text.ToString();
                        }
                        else { endereco = ""; }
                        if (txt_bairro.TextLength > 3)
                        {
                            bairro = txt_bairro.Text;
                        }
                        else { bairro = ""; }
                        if (txt_cidade.TextLength > 3)
                        {
                            cidade = txt_cidade.Text.ToString();
                        }
                        else { cidade = ""; }
                        if (txt_complemento.TextLength > 3)
                        {
                            complemento = txt_complemento.Text.ToString();
                        }
                        else { complemento = ""; }
                        if (txt_numero.TextLength != 0)
                        {
                            num_endereco = Convert.ToInt32(txt_numero.Text.ToString());
                        }
                        else { num_endereco = 0; }
                        if (cb_uf.SelectedIndex < 1)
                        {
                            uf = cb_uf.SelectedIndex.ToString();
                        }
                        else { uf = ""; }
                       // MessageBox.Show(dtp_datanasc.Value.Date.ToString());
                       // MessageBox.Show("fim");
                        //MessageBox.Show(cb_uf.SelectedItem.ToString());
                        // MessageBox.Show(cb_uf.SelectedIndex.ToString());

                        return true;



                    }

                    else
                    {
                        MessageBox.Show("Telefone Incorreto!");
                    }
                }
                else
                {
                    MessageBox.Show("CPF Incorreto!");
                }
            }
            else
            {
                MessageBox.Show("Nome incorreto!");
            }
            return false;

        }


        private DataTable Buscar(string strIncluir)
        {


            SqlConnection conn = new SqlConnection(conexao);

            conn.Open();
            DataTable dt = new DataTable();

            try
            {


                SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                sqlComm.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dtgw_dados.Columns.Clear();
                    dtgw_dados.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nenhum cliente com este CPF foi encontrado");
                }

                return dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao conectar ao Bano de Dados, Contate seu suporte");

                return dt;
            }
            conn.Close();

          
        }

        private void txt_nome_Leave(object sender, EventArgs e)
        {

        }

    }


}
