using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_modelo : System.Web.UI.MasterPage
{
    string nome;
    int codcliente;
    bool x = true;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] != null)
        {
            linkCadastro.NavigateUrl = "pedidos.aspx";
            linkCadastro.Text = "Meus pedidos";
            pnl.Visible = false;
            pnl_logout.Visible = true;
            lblNomeUsuario.Text = Session["nome"].ToString();
        }
        if (Session["nome_func"] != null)
        {
            linkCadastro.NavigateUrl = "pedidos.aspx";
            linkCadastro.Text = "Gerenciar Pedidos";
            pnl.Visible = false;
            pnl_logout.Visible = true;
            lblNomeUsuario.Text = Session["nome_func"].ToString();
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Chamando o método de validação que torna os campos txtEmail e txtSenha obrigatórios.
        validacao();
        //Verifico se a variável global x é true.Se for, ele passou pela validação dos campos obrigatórios.
        if (x == true)
        {
            try
            {
                //Criação dos DataAdapter's e dos DataSet's
                DataSet dt = new DataSet();
                SqlDataAdapter dAdapter = new SqlDataAdapter();


                //Declaração da variáveis que recuperam o login e senha digitados
                String login = txtLogin.Text.Trim();
                String senha = txtLogin_senha.Text.Trim();

                //Conexão que vai recuperar o CÓDIGO e o NOME do cliente pelo email e senha digitados.
                conexao con = new conexao();
                con.conectar();

                con.command.CommandText = "select Cod_Cliente,Nome_Cliente from Cliente where Login_Cliente=@login and Senha_Cliente=@senha";

                con.command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                con.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                
                dAdapter.SelectCommand = con.command;
                dAdapter.Fill(dt);
                con.fechaConexao();


                //Pegando as informações do DataSet e jogando em variáveis.

                codcliente = Convert.ToInt32(dt.Tables[0].DefaultView[0].Row["Cod_Cliente"]);
                nome = dt.Tables[0].DefaultView[0].Row["Nome_Cliente"].ToString();

                /*Verificando se o nome não é nulo. 
                Se não for, duas sessões são criadas, 
                uma com nome dele para mostrar depois,
                e outra com ID dele, para manipulação de dados. */

                if (nome != null)
                {
                    Session["nome"] = nome;
                    Session["cod"] = codcliente;
                    lblNomeUsuario.Text = Session["nome"].ToString();
                    pnl.Visible = false;
                    pnl_logout.Visible = true;
                    Response.Redirect("index.aspx");
                }
                //if (nome_func != null)
                //{
                //    Session["funcionario"] = permissao;
                //    Session["nome_func"] = nome_func;
                //    lblNomeUsuario.Text = Session["nome_func"].ToString();
                //    pnl.Visible = false;
                //    pnl_logout.Visible = true;
                //    Response.Redirect("index.aspx");
                //}
                else
                {
                    Session.Abandon();
                    lblLoginInc.Text = "Login e/ou Senha incorreto(s)";
                }

            }
            catch (Exception ex)
            {
                lblLoginInc.Text = "Dados incorretos.Tente novamente.";
            }
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        pnl.Visible = true;
        pnl_logout.Visible = false;

        lblLoginInc.Text = "";
        txtLogin.Text = "";
        txtLogin_senha.Text = "";
        Response.Redirect("index.aspx");
    }

    protected void validacao() 
    {
        //if (txtLogin.Text.Length < 1) 
        //{
        //    x = false;
        //    Response.Write("<script>alert('Email não foi preenchido corretamente !!')</script>");
        //    txtLogin.Focus();
        //}
        //else if (txtLogin_senha.Text.Length < 1)
        //{
        //    x = false;
        //    Response.Write("<script>alert('Senha não foi preenchida corretamente !!')</script>");
        //    txtLogin_senha.Focus();
        //}
    }
}
