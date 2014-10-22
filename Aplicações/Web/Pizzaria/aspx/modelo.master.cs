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
    int qtde;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        btnLogout.Visible = false;
        if (Session["logado"] != null)
        {
            Label1.Text = "Bem vindo";
            Label1.Style.Add("margin-left","450px");
            txtEmail.Visible = false;
            Label2.Text = "";
            txtLogin_senha.Visible = false;
            btnLogin.Visible = false;
            btnLogout.Visible = true;
            linkCadastro.Text = "Minha conta";
            linkCadastro.NavigateUrl = "conta.aspx";
            HyperLink1.Visible = false;
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            
            String sql;
            DataSet dt = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();

            String email = txtEmail.Text.Trim();
            String senha = txtLogin_senha.Text.Trim();

            conexao con = new conexao();
            con.conectar();

            sql = "select count(*) as qtde from Cliente where Email_Cliente=@email and Senha_Cliente=@senha";
            con.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            con.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
            con.command.CommandText = sql;
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(dt);
            con.fechaConexao();
            qtde = Convert.ToInt32(dt.Tables[0].DefaultView[0].Row["qtde"]);
            if (qtde == 1)
            {
                Session["logado"] = 1;
                lblLoginInc.Text = "Logado com sucesso !!";
                btnLogin.Visible = false;
                btnLogout.Visible = true;

                Label1.Text = "Bem vindo";
                txtEmail.Visible = false;
                Label2.Text = "";
                txtLogin_senha.Visible = false;
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

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("index.aspx");
        Label1.Text = "Login"; 
        txtEmail.Visible = true;
        Label2.Text = "Senha";
        txtLogin_senha.Visible = true;
        Session.Abandon();
        btnLogin.Visible = true;
        btnLogout.Visible = false;
        lblLoginInc.Text = "";
        txtEmail.Text = "";
        txtLogin_senha.Text = "";
    }

}
