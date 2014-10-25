using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using System.Data.SqlClient;



namespace Pizzaria
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            btn_alterar.Enabled = false;
            btn_excluir.Enabled = false;

            preenchegrid();
            preenchecargo();

        }

        SqlConnection conn;

        string
            cod_permissao = "",
            cod_cliente,
            usuario = "",
            senha = "",
            cargo = "",
            nome = "",
            cep = "",
            email = "",
            endereco = "",
            bairro = "",
            cidade = "",
            uf = "",
            complemento = "",
            telefone = "",
            cel = "",
            cpf = "",
            strIncluir = "";

        int num_endereco = 0;
        DateTime data;


        //String com informações de acesso pro BD
        string conexao = "Data Source=CASA-PC\\BPASERVER10 ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=AutoMateBPA10";

        

        //Validar se e update ou insert
        Boolean valida = false;
        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }


        /*  private void Funcionario_Load(object sender, EventArgs e)
          {

          }*/
        /* private void btn_salvar_Click(object sender, EventArgs e)
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
        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            conexao = Rede.DataContainer.conexaoGlobal;


            //Valida se todos os campos estao preenchidos corretamente    
            if (ValidaCampos() == true)
            {
                //Verifica se e para incluiur ou atualizar
                switch (valida)
                {
                    case true:
                        cod_cliente = dtgv_gravacao.CurrentRow.Cells[0].Value.ToString();

                        strIncluir = "update Funcionario set Nome_Func = '" + nome + "',CPF_Funcionario = '" + cpf + "',Endereco_Funcionario = '" + endereco + "',Complemento_Funcionario ='" + complemento + "',Numero_Residencia = '" + num_endereco + "',CEP_Funcionario = '" + cep + "',Estado_Funcionario = '" + uf + "',Cidade_Funcionario = '" + cidade + "' ,Email_Funcionario = '" + email + "' ,Telefone_Funcionario = '" + telefone + "' ,Celular_Funcionario = '" + cel + "' ,Bairro_Funcionario = '" + bairro + "', data_nasc = '" + data.ToString("yyyy/mm/dd") + "' where Cod_Funcionario =  '" + cod_cliente + "" + "'";

                      //  if (ValidaCPF(cpf))
                     //   {
                            AtualizaFunc(strIncluir);

                            valida = false;
                            Clear_Dados();
                            btn_alterar.Enabled = false;
                            btn_excluir.Enabled = false;
                            mtxt_cpf.Enabled = true;
                            btn_salvar.Text = "Gravar";
                            btn_Buscar.Enabled = true;
                      /*  }
                        else
                        {
                            MessageBox.Show("Este CPF ja Existe");
                            btn_salvar.Text = "Gravar";
                        }*/

                        break;

                    //Se for para incluir abaixo
                    case false:

                        //Verificar se existe usuario cadastrado


                        // fim da verificacao

                        strIncluir = "select * from Funcionario where CPF_Funcionario = '" + cpf + "'";
                        if (ValidaCPF(cpf))
                        {
                            strIncluir = "insert into Funcionario (Nome_Func,CPF_Funcionario,Endereco_Funcionario,Complemento_Funcionario,Numero_Residencia,CEP_Funcionario,Estado_Funcionario,Cidade_Funcionario ,Email_Funcionario ,Telefone_Funcionario,Celular_Funcionario ,Bairro_Funcionario, data_nasc) values ('" + nome + "','" + cpf + "','" + endereco + "','" + complemento + "','" + num_endereco + "','" + cep + "','" + uf + "','" + cidade + "','" + email + "','" + telefone + "','" + cel + "','" + bairro + "','" + data.ToString("yyyy/MM/dd") + "')";
                            InsereFunc(strIncluir);
                            btn_salvar.Text = "Gravar";
                        }
                        else
                        {
                            MessageBox.Show("CPF ja Existe");
                        }


                        break;
                }
            }
        }
        private void btn_excluir_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            gp_dadosfunc.Enabled = true;
            groupBox3.Enabled = true;
            valida = true;
            btn_excluir.Enabled = true;
            mtxt_cpf.Enabled = false;
            btn_salvar.Text = "Atualizar";
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            gp_dadosfunc.Enabled = true;
            groupBox3.Enabled = true;
            valida = false;
            btn_excluir.Enabled = false;
            btn_Buscar.Enabled = true;
            btn_salvar.Text = "Gravar";
            Clear_Dados();

        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            cpf = dtgv_gravacao.CurrentRow.Cells[0].Value.ToString();
            strIncluir = "delete FuncPermissao where cod_Funcionario = '" + cpf + "'";
            excluiFunc(strIncluir);

            valida = false;
            preenchegrid();
            Clear_Dados();
            btn_alterar.Enabled = false;
            btn_excluir.Enabled = false;
            mtxt_cpf.Enabled = true;
            btn_salvar.Text = "Gravar";
            btn_Buscar.Enabled = true;


        }
        private void dtgv_gravacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nome.Text = dtgv_gravacao.CurrentRow.Cells[1].Value.ToString();
            mtxt_cpf.Text = dtgv_gravacao.CurrentRow.Cells[2].Value.ToString();
            txt_endereco.Text = dtgv_gravacao.CurrentRow.Cells[3].Value.ToString();
            txt_complemento.Text = dtgv_gravacao.CurrentRow.Cells[4].Value.ToString();
            txt_numero.Text = dtgv_gravacao.CurrentRow.Cells[5].Value.ToString();
            mtxt_cep.Text = dtgv_gravacao.CurrentRow.Cells[6].Value.ToString();
            //Verificar logica para selecionar de acordo com o texto
            //cb_uf.SelectedText.Text = dtgw_dados.CurrentRow.Cells[7].Value.ToString();
            txt_cidade.Text = dtgv_gravacao.CurrentRow.Cells[8].Value.ToString();
            txt_email.Text = dtgv_gravacao.CurrentRow.Cells[9].Value.ToString();
            txt_bairro.Text = dtgv_gravacao.CurrentRow.Cells[10].Value.ToString();
            mtxt_celular.Text = dtgv_gravacao.CurrentRow.Cells[11].Value.ToString();
            mtxt_telefone.Text = dtgv_gravacao.CurrentRow.Cells[12].Value.ToString();



            gp_dadosfunc.Enabled = false;
            groupBox3.Enabled = false;


            //btn_excluir.Enabled = true;
            btn_alterar.Enabled = true;
            btn_Buscar.Enabled = false;

            cod_cliente = dtgv_gravacao.CurrentRow.Cells[0].Value.ToString();
            cpf = dtgv_gravacao.CurrentRow.Cells[2].Value.ToString();


        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Dados();
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (mtxt_cpf.Text.Replace(" ", "").Length == 14)
            {
                cpf = mtxt_cpf.Text;

                if (ValidaCPF(cpf))
                {
                    MessageBox.Show("Não foi encontrado funcionario com este CPF");
                    preenchegrid();



                }
                else
                {
                    strIncluir = "select * from Funcionario where CPF_Funcionario = '" + cpf + "'";
                    DataTable conteudo = new DataTable();
                    conteudo = Buscar(strIncluir);



                    //conteudo.Rows[1].ItemArray.GetValue(0).ToString();


                    txt_nome.Text = conteudo.Rows[0][1].ToString();
                    mtxt_cpf.Text = conteudo.Rows[0][2].ToString();
                    txt_endereco.Text = conteudo.Rows[0][3].ToString();
                    txt_complemento.Text = conteudo.Rows[0][4].ToString();
                    txt_numero.Text = conteudo.Rows[0][5].ToString();
                    mtxt_cep.Text = conteudo.Rows[0][6].ToString();
                    //Verificar logica para selecionar de acordo com o texto
                    //cb_uf.SelectedText.Text = dtgw_dados.CurrentRow.Cells[7].Value.ToString();
                    txt_cidade.Text = conteudo.Rows[0][8].ToString();
                    txt_email.Text = conteudo.Rows[0][9].ToString();
                    txt_bairro.Text = conteudo.Rows[0][10].ToString();
                    mtxt_celular.Text = conteudo.Rows[0][11].ToString();
                    mtxt_telefone.Text = conteudo.Rows[0][12].ToString();


                    gp_dadosfunc.Enabled = false;
                    groupBox3.Enabled = false;


                    //btn_excluir.Enabled = true;
                    btn_alterar.Enabled = true;

                }


            }

            else
            {
                MessageBox.Show("Prencha corretamente o Campo CPF");
                preenchegrid();
            }
        }

        public void preenchegrid()
        {

            string strIncluir = "select * from Funcionario";
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
                dtgv_gravacao.DataSource = dt;


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
            if (txt_Senha.TextLength > 3)
            {
                senha = txt_Senha.Text.ToString();
                if (txt_Usuario.TextLength > 4)
                {
                    usuario = txt_Usuario.Text.ToString();

                    //Valida Campo Nome
                    if (txt_nome.TextLength > 2)
                    {
                        nome = txt_nome.Text.ToString();

                        //Valida Campo CPF
                        if (mtxt_cpf.Text.Replace(" ", "").Replace(".", "").Replace("-", "").Length == 11)
                        {

                            cpf = mtxt_cpf.Text;

                            //Valida Campo Telefone
                            if (mtxt_telefone.Text.Replace(" ", "").Length == 13)
                            {

                                telefone = mtxt_telefone.Text;

                                //Valida Campo Email
                                if (txt_email.TextLength > 3 || txt_email.TextLength == 0)
                                {
                                    email = txt_email.Text;
                                }
                                else
                                {
                                    email = "";
                                    MessageBox.Show("Email Incorreto");
                                    return false;
                                }

                                //Valida Campo Data

                                if (dtp_datanasc.Value.Date.AddYears(18) <= DateTime.Today.ToLocalTime())
                                {

                                    data = dtp_datanasc.Value;

                                    //  MessageBox.Show(Convert.ToString(dtp_datanasc.Value.Date.AddYears(18)));
                                }
                                else
                                {
                                    //  MessageBox.Show(Convert.ToString(dtp_datanasc.Value.Date.AddYears(18)));
                                    MessageBox.Show("Data de Nascimento Incorreta");
                                    return false;
                                    //cel = ""; 
                                }


                                // Valida Campo Celular
                                if (mtxt_celular.Text.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").Length >= 11 || mtxt_celular.Text.Replace(" ", "").Length == 0)
                                {
                                    cel = mtxt_celular.Text;
                                }
                                else
                                {
                                    MessageBox.Show("Celular Incorreto");
                                    return false;
                                    //cel = ""; 
                                }


                                //Valida Campo CEP
                                if (mtxt_cep.Text.Replace(" ", "").Replace("-", "").Replace(".", "").Length == 8 || mtxt_cep.Text.Replace(" ", "").Replace("-", "").Replace(".", "").Length == 0)
                                {
                                    cep = mtxt_cep.Text;
                                }
                                else
                                {
                                    MessageBox.Show("Cep Incorreto");
                                    return false;
                                }

                                if (mtxt_cep.Text.Replace(" ", "").Replace("-", "").Replace(".", "").Length == 0)
                                {
                                    cep = "";
                                }

                                //Valida Endereco
                                if (txt_endereco.TextLength > 3 || txt_endereco.TextLength == 0)
                                {
                                    endereco = txt_endereco.Text.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Endereco Incorreto");
                                    return false;
                                }
                                if (txt_bairro.TextLength > 3 || txt_bairro.TextLength == 0)
                                {
                                    bairro = txt_bairro.Text;
                                }
                                else
                                {
                                    MessageBox.Show("Bairro Incorreto");
                                    return false;
                                }
                                if (txt_cidade.TextLength > 3 || txt_cidade.TextLength == 0)
                                {
                                    cidade = txt_cidade.Text.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Cidade Incorreto");
                                    return false;
                                }
                                if (txt_complemento.TextLength > 3 || txt_complemento.TextLength == 0)
                                {
                                    complemento = txt_complemento.Text.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Complemento Incorreto");
                                    return false;
                                }
                                if (Convert.ToInt32(txt_numero.TextLength) != 0 || txt_endereco.TextLength == 0)
                                {
                                    try
                                    {
                                        num_endereco = Convert.ToInt32(txt_numero.Text.ToString());
                                    }
                                    catch (Exception ex)
                                    {
                                        num_endereco = 0;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Numero do Endereco Incorreto");
                                    return false;
                                }
                                if (cb_uf.SelectedIndex > 0)
                                {
                                    uf = cb_uf.Text.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Estado Incorreto");
                                    return false;
                                }

                                if (cbox_Cargo.SelectedIndex >= 0)
                                {
                                    cargo = cbox_Cargo.Text.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Estado Incorreto");
                                    return false;
                                }


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
                        MessageBox.Show("Nome Incorreto");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario Deve conter no minimo 5 caracteres");
                }
            }
            else
            {
                MessageBox.Show("Senha deve conter no minimo 4 caracteres");
            }

            return false;

        }
        public void Clear_Dados()
        {

            txt_nome.Text = "";
            mtxt_telefone.Text = "";
            txt_email.Text = "";
            mtxt_celular.Text = "";
            mtxt_cep.Text = "";
            mtxt_cpf.Text = "";
            txt_endereco.Text = "";
            txt_bairro.Text = "";
            txt_cidade.Text = "";
            txt_complemento.Text = "";
            txt_numero.Text = "";
            cb_uf.Text = "";
            txt_Senha.Text = "";
            txt_Usuario.Text = "";

            gp_dadosfunc.Enabled = true;
            groupBox3.Enabled = true;
        }
        public DataTable Buscar(string strIncluir)
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
                    dtgv_gravacao.Columns.Clear();
                    dtgv_gravacao.DataSource = dt;
                    //  MessageBox.Show("CLiente com este CPF ja Cadastrado");
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
        public void InsereFunc(string stringInc)
        {
            conn = new SqlConnection(conexao);
            conn.Open();
            try
            {

                SqlCommand sqlComm = new SqlCommand(stringInc, conn);

                sqlComm.ExecuteNonQuery();
                //Seleciona Cargo
                DataTable dt = new DataTable();
                try
                {
                    stringInc = "select cod_Permissao from Permissao where Cargo = '" + cargo + "'";
                    sqlComm = new SqlCommand(stringInc, conn);

                    sqlComm.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    da.Fill(dt);
                    cod_permissao = dt.Rows[0][0].ToString();

                    //Cod Funcionario

                    dt = new DataTable();
                    try
                    {
                        stringInc = "select cod_Funcionario from Funcionario where CPF_Funcionario = '" + cpf + "'";
                        sqlComm = new SqlCommand(stringInc, conn);

                        sqlComm.ExecuteNonQuery();
                        da = new SqlDataAdapter();
                        da.SelectCommand = sqlComm;
                        da.Fill(dt);
                        cod_cliente = dt.Rows[0][0].ToString();

                        //insere tabela permissao funcionario

                        dt = new DataTable();
                        try
                        {
                            stringInc = "insert into FuncPermissao (Login_,Senha,Cod_Funcionario,Cod_Permissao) values ('" + usuario + "','" + senha + "','" + cod_cliente + "','" + cod_permissao + "')";
                            sqlComm = new SqlCommand(stringInc, conn);

                            sqlComm.ExecuteNonQuery();

                            /*    stringInc = "update FUncPermissao set Login_ = '" + usuario + "',senha='" + senha + "',cod_Permissao = '" + cod_permissao + "' where cod_Funcionario ='" + cod_cliente + "'";
                                sqlComm = new SqlCommand(stringInc, conn);
                                sqlComm.ExecuteNonQuery();
                             */

                            stringInc = "update Funcionario set cod_Permissao = '" + cod_permissao + "'";
                            sqlComm = new SqlCommand(stringInc, conn);
                            sqlComm.ExecuteNonQuery();



                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Falha tabela de permissoes de funcionario");
                        }


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Falha ao obter numero do Funcionario");
                    }



                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao Selecionar o Cargo");
                }






                MessageBox.Show("Funcionario Inserido com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao Inserir Funcionario");

            }
            conn.Close();

            preenchegrid();
            Clear_Dados();
        }
        public void AtualizaFunc(string stringUpd)
        {
            conn = new SqlConnection(conexao);
            conn.Open();

            try
            {
                SqlCommand sqlComm = new SqlCommand(stringUpd, conn);

                sqlComm.ExecuteNonQuery();

                //Seleciona Cargo
                DataTable dt = new DataTable();
                try
                {
                    stringUpd = "select cod_Permissao from Permissao where Cargo = '" + cargo + "'";
                    sqlComm = new SqlCommand(stringUpd, conn);

                    sqlComm.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    da.Fill(dt);
                    cod_permissao = dt.Rows[0][0].ToString();

                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao Selecionar o Cargo");
                }



                stringUpd = "update FUncPermissao set Login_ = '" + usuario + "',senha='" + senha + "',cod_Permissao = '" + cod_permissao + "' where cod_Funcionario ='" + cod_cliente + "'";
                sqlComm = new SqlCommand(stringUpd, conn);
                sqlComm.ExecuteNonQuery();

                stringUpd = "update Funcionario set cod_Permissao = '" + cod_permissao + "',Usuario_Funcionario='" + usuario + "' where cod_Funcionario ='" + cod_cliente + "'";
                sqlComm = new SqlCommand(stringUpd, conn);
                sqlComm.ExecuteNonQuery();




                MessageBox.Show("Dados do funcionario Atualizado");
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao Atualizar Funcionario");



            }
            conn.Close();

            preenchegrid();

        }
        public Boolean ValidaCPF(string strValida)
        {


            strValida = "select * from Funcionario where CPF_Funcionario = '" + strValida + "'";
            SqlConnection conn = new SqlConnection(conexao);
            DataTable dt = new DataTable();
            conn.Open();



            try
            {
                SqlCommand sqlComm = new SqlCommand(strValida, conn);

                sqlComm.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return false;

                }





            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao consultar CPF do Funcionario");
            }


            conn.Close();

            return true;


        }
        public void excluiFunc(string strExclui)
        {
            conn = new SqlConnection(conexao);
            conn.Open();
            try
            {

                SqlCommand sqlComm = new SqlCommand(strExclui, conn);

                sqlComm.ExecuteNonQuery();

                strExclui = "delete Funcionario where cod_Funcionario = '" + cpf + "'";

                sqlComm = new SqlCommand(strExclui, conn);

                sqlComm.ExecuteNonQuery();

                MessageBox.Show("Funcionario Excluido com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao Excluir Funcionario");

            }
            conn.Close();

            preenchegrid();
            Clear_Dados();
        }
        private void dtgv_gravacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dtp(object sender, EventArgs e)
        {

        }
        private void dtp_datanasc_ValueChanged(object sender, EventArgs e)
        {

        }
        private void preenchecargo()
        {
            string strIncluir = "select cargo from Permissao";
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
                for (int i = 0; dt.Rows.Count > i; i++)
                {
                    cbox_Cargo.Items.Add(dt.Rows[i][0].ToString());

                }




            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao conectar ao Bano de Dados, Contate seu suporte");
            }
            conn.Close();
        }

        private void lbl_telefone_Click(object sender, EventArgs e)
        {

        }

        private void Funcionario_Shown(object sender, EventArgs e)
        {
            
        }




    }
}
