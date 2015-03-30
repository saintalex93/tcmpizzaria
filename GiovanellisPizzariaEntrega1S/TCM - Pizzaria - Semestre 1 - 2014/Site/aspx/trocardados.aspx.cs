using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_trocardados : System.Web.UI.Page
{
    int codCli;
    bool validando = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["cod"] == null || Request.Cookies["cod"].Value == "0")
        {
            Response.Write("<script>alert('Você não está autorizado.');</script>");
            Response.Write("<script>history.go(-1);</script>");
        }
        else
        {
            codCli = Convert.ToInt32(Request.Cookies["cod"].Value);
            /*Adicionando o atributo onblur e chamando a função aplicaMascara().
            Onblur é para quando o usuário tirar o foco do campo*/
            txtDtNasc.Attributes.Add("onblur", "aplicaMascara()");
            txtCpf.Attributes.Add("onblur", "aplicaMascara()");
            txtTel.Attributes.Add("onblur", "aplicaMascara()");
            txtCel.Attributes.Add("onblur", "aplicaMascara()");
            txtCep.Attributes.Add("onblur", "aplicaMascara()");

            //Adicionando placeholder nos campos
            txtTel.Attributes.Add("placeholder", "Digite apenas números");
            txtCel.Attributes.Add("placeholder", "Digite apenas números");
            txtCep.Attributes.Add("placeholder", "Digite apenas números");
            txtCpf.Attributes.Add("placeholder", "Digite apenas números");
            txtDtNasc.Attributes.Add("placeholder", "Digite apenas números");
            txtEmail.Attributes.Add("placeholder", "exemplo@exemplo.com.br");

            //Adicionando atributo onfocus e chamando a função retiraMascara() referente a cada campo
            txtDtNasc.Attributes.Add("onfocus", "retiraMascaraDtNasc()");
            txtCpf.Attributes.Add("onfocus", "retiraMascaraCpf()");
            txtTel.Attributes.Add("onfocus", "retiraMascaraTel()");
            txtCel.Attributes.Add("onfocus", "retiraMascaraCel()");
            txtCep.Attributes.Add("onfocus", "retiraMascaraCep()");

            if (!IsPostBack)
            {
                try
                {
                    codCli = Convert.ToInt32(Request.Cookies["cod"].Value);
                    Conexao con = new Conexao();
                    SqlDataAdapter dAdapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();

                    con.conectar();
                    con.command.CommandText = "select * from Cliente where Cod_Cliente =" + codCli;
                    dAdapter.SelectCommand = con.command;
                    dAdapter.Fill(ds);
                    ds.Tables[0].DefaultView[0].Row[0].ToString();
                    con.fechaConexao();
                    txtNome.Text = ds.Tables[0].DefaultView[0].Row["Nome_Cliente"].ToString();
                    txtTel.Text = ds.Tables[0].DefaultView[0].Row["Telefone_Cliente"].ToString();
                    txtCel.Text = ds.Tables[0].DefaultView[0].Row["Celular_Cliente"].ToString();
                    txtEmail.Text = ds.Tables[0].DefaultView[0].Row["Login_Cliente"].ToString();
                    txtCpf.Text = ds.Tables[0].DefaultView[0].Row["CPF_Cliente"].ToString();
                    DateTime datanasc = Convert.ToDateTime(ds.Tables[0].DefaultView[0].Row["DataNascimento"]);
                    txtDtNasc.Text = datanasc.ToString("dd/MM/yyyy");
                    DDLEstado.SelectedItem.Value = ds.Tables[0].DefaultView[0].Row["Estado_Cliente"].ToString();
                    txtCidade.Text = ds.Tables[0].DefaultView[0].Row["Cidade_Cliente"].ToString();
                    txtRua.Text = ds.Tables[0].DefaultView[0].Row["Endereco_Cliente"].ToString();
                    txtComplemento.Text = ds.Tables[0].DefaultView[0].Row["Complemento_Cliente"].ToString();
                    txtNumCasa.Text = ds.Tables[0].DefaultView[0].Row["Numero_Residencia"].ToString();
                    //Trazendo número do apartamento(se foi cadastrado como "0", não mostra nada.)
                    string numapart = ds.Tables[0].DefaultView[0].Row["Numero_Apartamento"].ToString();
                    if (numapart == "0")
                    {

                    }
                    else
                    {
                        txtNumApart.Text = numapart;
                    }
                    txtBairro.Text = ds.Tables[0].DefaultView[0].Row["Bairro_Cliente"].ToString();
                    txtCep.Text = ds.Tables[0].DefaultView[0].Row["CEP_Cliente"].ToString();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Você não está autorizado.');</script>");
                    Response.Write("<script>history.go(-1);</script>");
                }
            }
        }
    }
    protected void btnTrocaDados_Click(object sender, EventArgs e)
    {
        validacao();
        if (validando == true)
        {
            string nome = txtNome.Text.Trim();
            string tel = txtTel.Text;
            string cel = txtCel.Text;
            string email = txtEmail.Text;
            string cpf = txtCpf.Text;
            DateTime datanasc = Convert.ToDateTime(txtDtNasc.Text);
            string datanasc2 = datanasc.ToShortDateString();
            string cidade = txtCidade.Text.Trim();
            string rua = txtRua.Text.Trim();
            string complemento = txtComplemento.Text.Trim();
            int numcasa = Convert.ToInt32(txtNumCasa.Text);
            int numapart = 0;
            string bairro = txtBairro.Text.Trim();
            string cep = txtCep.Text;
            string estado = DDLEstado.SelectedValue.ToString();

            try
            {
                numcasa = Convert.ToInt32(txtNumCasa.Text);
            }
            catch (Exception ex)
            {
                validando = false;
                txtNumCasa.Focus();
            }
            try
            {
                Conexao con = new Conexao();
                con.conectar();
                con.command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                con.command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                con.command.Parameters.Add("@rua", SqlDbType.VarChar).Value = rua;
                con.command.Parameters.Add("@numcasa", SqlDbType.Int).Value = numcasa;
                con.command.Parameters.Add("@numapart", SqlDbType.Int).Value = numapart;
                con.command.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
                con.command.Parameters.Add("@cep", SqlDbType.VarChar).Value = cep;
                con.command.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
                con.command.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
                con.command.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
                con.command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = tel;
                con.command.Parameters.Add("@celular", SqlDbType.VarChar).Value = cel;
                con.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                con.command.Parameters.Add("@datanasc", SqlDbType.Date).Value = datanasc2;
                con.command.CommandText = "update Cliente set Nome_Cliente=@nome, CPF_Cliente=@cpf, Endereco_Cliente=@rua, Numero_Residencia=@numcasa, Numero_Apartamento=@numapart, Bairro_Cliente=@bairro, CEP_Cliente=@cep, Estado_Cliente=@estado, Cidade_Cliente=@cidade, Complemento_Cliente=@complemento, Telefone_Cliente=@telefone, Celular_Cliente=@celular, Login_Cliente=@email, DataNascimento=@datanasc where Cod_Cliente=" + codCli;
                int um = con.command.ExecuteNonQuery();
                con.fechaConexao();
                if (um > 0)
                {
                    Response.Write("<script>alert('Dados alterados com sucesso !')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Falha na alteração, tente novamente !')</script>");
                }
                lblresposta.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Erro na alteração, tente novamente em alguns segundos !')</script>");
            }
            
        }
        else
        {

        }
    }

    protected void validacao()
    {

        if (txtNome.Text.Length < 3)
        {
            validando = false;
            lblresposta.Text = "Nome deve conter mais de 3 letras";
            txtNome.Focus();
        }
        else if (txtTel.Text.Length != 10 && txtTel.Text.Length != 13)
        {
            validando = false;
            lblresposta.Text = "Telefone inválido !!";
            txtTel.Focus();
        }


        else if (txtCel.Text.Length != 0)
        {
            if (txtCel.Text.Length != 10 && txtCel.Text.Length != 11 && txtCel.Text.Length != 13 && txtCel.Text.Length != 15)
            {
                validando = false;
                lblresposta.Text = "Celular inválido !!";
                txtCel.Focus();
            }
        }

        else if (txtEmail.Text.Length < 5)
        {
            validando = false;
            lblresposta.Text = "Email inválido !!";
            txtEmail.Focus();
        }

        else if (txtCpf.Text.Length != 11 && txtCpf.Text.Length != 14)
        {
            validando = false;
            lblresposta.Text = "CPF inválido !!";
            txtCpf.Focus();
        }

        else if (txtDtNasc.Text.Length != 8 && txtDtNasc.Text.Length != 10)
        {
            validando = false;
            lblresposta.Text = "Data de Nascimento inválida !!";
            txtDtNasc.Focus();
        }

        else if (txtCidade.Text.Length < 3)
        {
            validando = false;
            lblresposta.Text = "Cidade inválido !!";
            txtCidade.Focus();
        }

        else if (txtRua.Text.Length < 1)
        {
            validando = false;
            lblresposta.Text = "Rua é obrigatória !!";
            txtRua.Focus();
        }
        
        else if (txtNumCasa.Text == "")
        {
            Convert.ToInt32(txtNumCasa.Text);
            validando = false;
            lblresposta.Text = "Número da casa incorreto";
            txtNumCasa.Focus();
        }
        else if (txtNumApart.Text != "")
        {
            try
            {
                Convert.ToInt32(txtNumApart.Text);
            }
            catch(Exception ex)
            {
                validando = false;
                lblresposta.Text = "Número do apartamento deve conter apenas números !";
                txtNumApart.Focus();
            }
        }

        else if (txtBairro.Text.Length < 3)
        {
            validando = false;
            lblresposta.Text = "Bairro deve conter mais de 3 letras !!";
            txtBairro.Focus();
        }

        else if (txtCep.Text.Length != 8 && txtCep.Text.Length != 9)
        {
            validando = false;
            lblresposta.Text = "CEP inválido !!";
            txtCep.Focus();
        }
    }
}