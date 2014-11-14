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
    bool x = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] != null)
        {
            Response.Write("<script>alert('Você deve deslogar para cadastrar uma nova conta !!!')</script>");
            Response.Write("<script>window.history.go(-1)</script>");
        }

        /*Adicionando o atributo onblur e chamando a função aplicaMascara().
        Onblur é para quando o usuário tirar o foco do campo*/
        txtCpf.Attributes.Add("onblur", "aplicaMascara()");
        txtTel.Attributes.Add("onblur", "aplicaMascara()");
        txtCel.Attributes.Add("onblur", "aplicaMascara()");
        txtCep.Attributes.Add("onblur", "aplicaMascara()");

        //Adicionando placeholder nos campos
        txtTel.Attributes.Add("placeholder", "Digite apenas números");
        txtCel.Attributes.Add("placeholder", "Digite apenas números");
        txtCep.Attributes.Add("placeholder", "Digite apenas números");
        txtCpf.Attributes.Add("placeholder", "Digite apenas números");

        //Adicionando atributo onfocus e chamando a função retiraMascara() referente a cada campo
        txtCpf.Attributes.Add("onfocus", "retiraMascaraCpf()");
        txtTel.Attributes.Add("onfocus", "retiraMascaraTel()");
        txtCel.Attributes.Add("onfocus", "retiraMascaraCel()");
        txtCep.Attributes.Add("onfocus", "retiraMascaraCep()");
    }

    protected void btnEnvia_Click(object sender, EventArgs e)
    {
        validacao();
        if (x == true)
        {
                String nome = txtNome.Text.Trim();
                String tel = txtTel.Text;
                String cel = txtCel.Text;
                String cpf = txtCpf.Text;
                String login = txtLogin_Cli.Text;
                String senha = txtSenha.Text;
                String senhaconf = txtSenhaConfirm.Text;
                String rua = txtRua.Text.Trim();
                String complemento = txtComplemento.Text.Trim();
                int numcasa = Convert.ToInt32(txtNumCasa.Text);
                String bairro = txtBairro.Text.Trim();
                String cep = txtCep.Text;

                conexao con2 = new conexao();
                con2.conectar();
               
                con2.command.CommandText = "select * from Cliente where CPF_Cliente=@cpf";
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
                conexao con = new conexao();
                con.conectar();
                    con.command.CommandText = "insert into Cliente(Nome_Cliente, CPF_Cliente,Endereco_Cliente, Numero_Residencia, Bairro_Cliente, CEP_Cliente, Complemento_Cliente, Telefone_Cliente, Celular_Cliente, Login_Cliente, Senha_Cliente)" + "values(@nome, @cpf, @rua, @numcasa, @bairro, @cep, @complemento, @telefone, @celular, @login, @senha)";
                    con.command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    con.command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                    con.command.Parameters.Add("@rua", SqlDbType.VarChar).Value = rua;
                    con.command.Parameters.Add("@numcasa", SqlDbType.Int).Value = numcasa;
                    con.command.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
                    con.command.Parameters.Add("@cep", SqlDbType.VarChar).Value = cep;
                    con.command.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
                    con.command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = tel;
                    con.command.Parameters.Add("@celular", SqlDbType.VarChar).Value = cel;
                    con.command.Parameters.Add("@login",SqlDbType.VarChar).Value = login;
                    con.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                    con.command.ExecuteNonQuery();
                    con.fechaConexao();
                    }
                    catch (Exception exx)
                    {
                        Response.Write("<script language=javascript>alert('Dados Incorretos.')</script>");
                    }
                }
                        LimpaCamposAprovado();
            }
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
        txtLogin_Cli.Text = "";
        txtCpf.Text = "";
        txtSenha.Text = "";
        txtSenhaConfirm.Text = "";
        txtRua.Text = "";
        txtComplemento.Text = "";
        txtNumCasa.Text = "";
        txtBairro.Text = "";
        txtCep.Text = "";
        btnLimpa.Focus();

    }
    public void LimpaCamposAprovado()
    {
        txtNome.Text = "";
        txtTel.Text = "";
        txtCel.Text = "";
        txtLogin_Cli.Text = "";
        txtCpf.Text = "";
        txtSenha.Text = "";
        txtSenhaConfirm.Text = "";
        txtRua.Text = "";
        txtComplemento.Text = "";
        txtNumCasa.Text = "";
        txtBairro.Text = "";
        txtCep.Text = "";
        btnLimpa.Focus();
    }
    protected void Preenche_Click(object sender, EventArgs e)
    {
        txtNome.Text = "Nome Teste";
        txtTel.Text = "(11)9999-9999";
        txtCel.Text = "(11)9-3333-3333";
        txtLogin_Cli.Text = "Testelog";
        txtCpf.Text = "666.666.666-66";
        txtRua.Text = "Rua Teste";
        txtComplemento.Text = "Complemento Teste";
        txtNumCasa.Text = "123";
        txtBairro.Text = "Bairro Teste";
        txtCep.Text = "55555-555";
        btnEnvia.Focus();
    }

    protected void validacao()
    {
        string numcasa = txtNumCasa.Text.Trim();

        if (txtNome.Text.Length < 3)
        {
            x = false;
            txtNome.Focus();
        }
        else if (txtTel.Text.Length != 10 && txtTel.Text.Length != 13)
        {
            x = false;
            txtTel.Focus();
        }

        
        else if (txtCel.Text.Length != 0)
        {
            if (txtCel.Text.Length != 10 && txtCel.Text.Length != 11 && txtCel.Text.Length != 13 && txtCel.Text.Length != 15)
            {
                x = false;
                txtCel.Focus();
            }
        }
        
        else if (txtCpf.Text.Length != 11 && txtCpf.Text.Length != 14)
        {
            x = false;
            txtCpf.Focus();
        }

        else if (txtSenha.Text.Length < 5)
        {
            x = false;
            txtSenha.Focus();
        }
        else if (txtSenhaConfirm.Text != txtSenha.Text) 
        {
            x = false;
            txtSenhaConfirm.Focus();
        }

        else if (txtRua.Text.Length < 1)
        {
            x = false;
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
            x = false;
            txtBairro.Focus();
        }

        else if (txtCep.Text.Length != 8 && txtCep.Text.Length != 9)
        {
            x = false;
            txtCep.Focus();
        }
    }
    
}