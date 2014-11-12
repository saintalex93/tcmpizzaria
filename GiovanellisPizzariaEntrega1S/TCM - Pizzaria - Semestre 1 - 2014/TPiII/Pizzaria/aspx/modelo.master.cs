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

                SqlDataAdapter dAdapter2 = new SqlDataAdapter();
                DataSet dt2 = new DataSet();

                //Declaração da variáveis que recuperam o login e senha digitados
                String email = txtEmail.Text.Trim();
                String senha = txtLogin_senha.Text.Trim();

                //Conexão que vai recuperar o CÓDIGO do cliente pelo email e senha digitados.
                conexao con = new conexao();
                con.conectar();

                con.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                con.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                
                con.command.CommandText = "select Cod_Cliente from Cliente where Email_Cliente=@email and Senha_Cliente=@senha";
                dAdapter.SelectCommand = con.command;
                dAdapter.Fill(dt);
                con.fechaConexao();

                //Conexão que vai recuperar o NOME do cliente pelo email e senha digitados.

                conexao con2 = new conexao();
                con2.conectar();

                con2.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                con2.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                con2.command.CommandText = "select Nome_Cliente from Cliente where Email_Cliente=@email and Senha_Cliente=@senha";
                dAdapter2.SelectCommand = con2.command;
                dAdapter2.Fill(dt2);
                con2.fechaConexao();

                //Pegando as informações do DataSet e jogando em variáveis.

                nome = dt2.Tables[0].DefaultView[0].Row["Nome_Cliente"].ToString();
                codcliente = Convert.ToInt32(dt.Tables[0].DefaultView[0].Row["Cod_Cliente"]);

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
        txtEmail.Text = "";
        txtLogin_senha.Text = "";
        Response.Redirect("index.aspx");
    }

    protected void validacao() 
    {
        if (txtEmail.Text.Length < 1) 
        {
            x = false;
            Response.Write("<script>alert('Email não foi preenchido corretamente !!')</script>");
            txtEmail.Focus();
        }
        else if (txtLogin_senha.Text.Length < 6)
        {
            x = false;
            Response.Write("<script>alert('Senha não foi preenchida corretamente !!')</script>");
            txtLogin_senha.Focus();
        }
    }
}
