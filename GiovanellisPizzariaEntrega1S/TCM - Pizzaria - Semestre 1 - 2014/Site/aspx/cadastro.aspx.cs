using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_cadastro : System.Web.UI.Page
{
    int result = 0;
    bool validando = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["nome"] != null)
        {
            if (Request.Cookies["nome"].Value != "0")
            {
                Response.Write("<script>alert('Você deve deslogar para cadastrar uma nova conta !')</script>");
                Response.Write("<script>window.history.go(-1)</script>");
            }
        }
        else
        {
            //Response.Write("<script>alert('Você deve deslogar para cadastrar uma nova conta !!!')</script>");
            //Response.Write("<script>window.history.go(-1)</script>");
        }

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
    }
    protected void btnEnvia_Click(object sender, EventArgs e)
    {
        validacao();
        if (validando == true)
        {
            String nome = txtNome.Text.Trim();
            String tel = txtTel.Text;
            String cel = txtCel.Text;
            String email = txtEmail.Text;
            String cpf = txtCpf.Text;
            String datanasc = txtDtNasc.Text;
            String senha = txtSenha.Text;
            String senhaconf = txtSenhaConfirm.Text;
            String cidade = txtCidade.Text.Trim();
            String rua = txtRua.Text.Trim();
            String complemento = txtComplemento.Text.Trim();
            int numcasa = Convert.ToInt32(txtNumCasa.Text);
            int numapart = Convert.ToInt32(txtNumApart.Text);
            String bairro = txtBairro.Text.Trim();
            String cep = txtCep.Text;
            String estado = DDLEstado.SelectedValue.ToString();

            try
            {
                Convert.ToInt32(txtNumCasa.Text);
            }
            catch (Exception ex)
            {
                validando = false;
                lblresposta.Text = "Número é obrigatório e deve conter apenas números !!";
                txtNumCasa.Focus();
            }
            Conexao con2 = new Conexao();
            con2.conectar();

            con2.command.CommandText = "select * from Cliente where Login_Cliente=@email or CPF_Cliente=@cpf";
            con2.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            con2.command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            result = Convert.ToInt32(con2.command.ExecuteScalar());
            con2.fechaConexao();
            con2.command = null;
            if (result != 0)
            {
                Response.Write("<script>alert('Email e/ou CPF já cadastrado(s).\\nInsira outro Email ou CPF para se cadastrar.')</script>");
            }
            else
            {
                try
                {
                    Conexao con = new Conexao();
                    con.conectar();
                    con.command.CommandText = "insert into Cliente(Nome_Cliente, CPF_Cliente,Endereco_Cliente, Numero_Residencia, Numero_Apartamento, Bairro_Cliente, CEP_Cliente, Estado_Cliente, Cidade_Cliente, Complemento_Cliente, Telefone_Cliente, Celular_Cliente, Login_Cliente, Senha_Cliente, DataNascimento)" + "values(@nome, @cpf, @rua, @numcasa, @numapart, @bairro, @cep, @estado, @cidade, @complemento, @telefone, @celular, @email, @senha, @datanasc)";
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
                    con.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                    con.command.Parameters.Add("@datanasc", SqlDbType.VarChar).Value = datanasc;
                    con.command.ExecuteNonQuery();
                    con.fechaConexao();

                    Response.Write("<script>alert('Dados Cadastrados com sucesso.\\nVocê já pode se logar.')</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Dados Incorretos.')</script>");
                }
            }

        }
        LimpaCamposAprovado();

    }
    protected void btnLimpa_Click(object sender, EventArgs e)
    {
        LimpaCampos();
    }
    protected void LimpaCampos()
    {

        txtNome.Text = "";
        txtTel.Text = "";
        txtCel.Text = "";
        txtEmail.Text = "";
        txtCpf.Text = "";
        txtDtNasc.Text = "";
        txtSenha.Text = "";
        txtSenhaConfirm.Text = "";
        DDLEstado.SelectedIndex = 0;
        txtCidade.Text = "";
        txtRua.Text = "";
        txtComplemento.Text = "";
        txtNumCasa.Text = "";
        txtNumApart.Text = "";
        txtBairro.Text = "";
        txtCep.Text = "";
        btnLimpa.Focus();
        lblresposta.Text = "";

    }
    protected void LimpaCamposAprovado()
    {
        txtNome.Text = "";
        txtTel.Text = "";
        txtCel.Text = "";
        txtEmail.Text = "";
        txtCpf.Text = "";
        txtDtNasc.Text = "";
        txtSenha.Text = "";
        txtSenhaConfirm.Text = "";
        DDLEstado.SelectedIndex = 0;
        txtCidade.Text = "";
        txtRua.Text = "";
        txtComplemento.Text = "";
        txtNumCasa.Text = "";
        txtNumApart.Text = "";
        txtBairro.Text = "";
        txtCep.Text = "";
        btnLimpa.Focus();
    }
    protected void Preenche_Click(object sender, EventArgs e)
    {
        txtNome.Text = "Nome Teste";
        txtTel.Text = "(11)9999-9999";
        txtCel.Text = "(11)9-3333-3333";
        txtEmail.Text = "email@teste.com";
        txtCpf.Text = "666.666.666-66";
        txtDtNasc.Text = "12/05/1995";
        DDLEstado.SelectedIndex = 1;
        txtCidade.Text = "Cidade Teste";
        txtRua.Text = "Rua Teste";
        txtComplemento.Text = "Complemento Teste";
        txtNumCasa.Text = "123";
        txtNumApart.Text = "321";
        txtBairro.Text = "Bairro Teste";
        txtCep.Text = "55555-555";
        btnEnvia.Focus();
    }

    protected void validacao()
    {
        string numcasa = txtNumCasa.Text.Trim();

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

        else if (txtSenha.Text.Length < 5)
        {
            validando = false;
            lblresposta.Text = "Senha inválida !!";
            txtSenha.Focus();
        }
        else if (txtSenhaConfirm.Text != txtSenha.Text)
        {
            validando = false;
            lblresposta.Text = "Suas senhas não conferem !!";
            txtSenhaConfirm.Focus();
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
        /*
                else if (txtNumCasa.Text == "")
                {
                    Convert.ToInt32(txtNumCasa.Text);
                    x = false;
                    lblresposta.Text = "Número incorreto";
                }
            */

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