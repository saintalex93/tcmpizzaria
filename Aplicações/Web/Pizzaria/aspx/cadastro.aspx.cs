using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class aspx_cadastro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
        txtDtNasc.Attributes.Add("placeholder", "30121990");
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
        String nome = txtNome.Text;
        String tel = txtTel.Text;
        String cel = txtCel.Text;
        String email = txtEmail.Text;
        String cpf = txtCpf.Text;
        String datanasc = txtDtNasc.Text;
        String senha = txtSenha.Text;
        String senhaconf = txtSenhaConfirm.Text;
        String cidade = txtCidade.Text;
        String rua = txtRua.Text;
        String complemento = txtComplemento.Text;
        int numcasa = Convert.ToInt32(txtNumCasa.Text);
        int numapart = Convert.ToInt32(txtNumApart.Text);
        String bairro = txtBairro.Text;
        String cep = txtCep.Text;
        String estado = DDLEstado.SelectedValue.ToString();

        conexao con = new conexao();
        con.conectar();
        con.command.CommandText = "insert into Cliente(Nome_Cliente, CPF_Cliente,Endereco_Cliente, Numero_Residencia, Numero_Apartamento, Bairro_Cliente, CEP_Cliente, Estado_Cliente, Cidade_Cliente, Complemento_Cliente, Telefone_Cliente, Celular_Cliente, Email_Cliente, Senha_Cliente, DataNascimento)" + "values(@nome, @cpf, @rua, @numcasa, @numapart, @bairro, @cep, @estado, @cidade, @complemento, @telefone, @celular, @email, @senha, @datanasc)";
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
        String resposta = "Dados Cadastrados com sucesso.<br/>Você já pode se logar.";
        lblresposta.Text = resposta;

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
        txtSenha.Text = "123321";
        txtSenhaConfirm.Text = "123321";
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
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        String login = txtLogin.Text;
        String senha = txtLogin_Senha.Text;
        //var logado = false;
        try
        {
            conexao con = new conexao();
            con.conectar();
            con.command.CommandText = "select * from Cliente where Email_Cliente = @email AND Senha_Cliente = @senha";
            con.command.Parameters.Add("@email", SqlDbType.VarChar).Value = login;
            con.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
            con.command.ExecuteNonQuery();
            con.fechaConexao();
            lblLoginInc.Text = "Logado com sucesso";
        }
        catch(Exception ex)
        {
            lblLoginInc.Text = "Login e Senha incorretos";
        }
    }
}