using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cadastro : System.Web.UI.Page
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
        txtTel.Attributes.Add("placeholder","Digite apenas números");
        txtCel.Attributes.Add("placeholder", "Digite apenas números");
        txtCep.Attributes.Add("placeholder", "Digite apenas números");
        txtCpf.Attributes.Add("placeholder", "Digite apenas números");
        txtDtNasc.Attributes.Add("placeholder", "30121990");
        txtEmail.Attributes.Add("placeholder", "exemplo@exemplo.com.br");


        //Adicionando atributo onfocus e chamando a função retiraMascara referente a cada campo
        txtDtNasc.Attributes.Add("onfocus", "retiraMascaraDtNasc()");
        txtCpf.Attributes.Add("onfocus", "retiraMascaraCpf()");
        txtTel.Attributes.Add("onfocus", "retiraMascaraTel()");
        txtCel.Attributes.Add("onfocus", "retiraMascaraCel()");
        txtCep.Attributes.Add("onfocus", "retiraMascaraCep()");
    }
    protected void btnEnvia_Click(object sender, EventArgs e)
    {
        String resposta = "Dados Cadastrados com sucesso.<br/>Você já pode se logar.";
        lblresposta.Text = resposta;
        btnEnvia.Focus();
        txtNome.Text = "";
        txtTel.Text = "";
        txtCel.Text = "";
        txtEmail.Text = "";
        txtCpf.Text = "";
        txtDtNasc.Text = "";
        txtSenha.Text = "";
        txtSenhaConfirm.Text = "";
        txtCidade.Text = "";
        txtRua.Text = "";
        txtNumCasa.Text = "";
        txtNumApart.Text = "";
        txtBairro.Text = "";
        txtCep.Text = "";
    }

    protected void btnLimpa_Click(object sender, EventArgs e)
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
        txtNumCasa.Text = "";
        txtNumApart.Text = "";
        txtBairro.Text = "";
        txtCep.Text = "";
        btnLimpa.Focus();
        lblresposta.Text = "";
    }

}