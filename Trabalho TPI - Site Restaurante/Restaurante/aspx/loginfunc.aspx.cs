using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_loginfunc : System.Web.UI.Page
{
    string permissao;
    string nome_func;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome_func"] != null) 
        {
            Response.Write("<script>alert('Você já está logado !!')</script>");
            Response.Write("<script>history.go(-1)</script>");
        }
        if (Session["nome"] != null)
        {
            Response.Write("<script>alert('Você não tem acesso a essa área !!')</script>");
            Response.Write("<script>history.go(-1)</script>");
        }
    }
    protected void btnLoginFunc_Click(object sender, EventArgs e)
    {

        //Conexão que vai recuperar a PERMISSÃO do funcionário pelo email e senha digitados.

        DataSet dt = new DataSet();
        SqlDataAdapter dAdapter2 = new SqlDataAdapter();

        string login = txtLoginFunc.Text.Trim();
        string senha = txtSenhaFunc.Text.Trim();

        conexao con2 = new conexao();
        con2.conectar();

        con2.command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
        con2.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
        con2.command.CommandText = "select Nome_Func from Funcionario where Login_Func=@login and Senha_Func=@senha";
        dAdapter2.SelectCommand = con2.command;
        dAdapter2.Fill(dt);
        con2.fechaConexao();

        nome_func = dt.Tables[0].DefaultView[0].Row["Nome_Func"].ToString();

        if (nome_func != null)
        {
            Session["nome_func"] = nome_func;
            Response.Redirect("index.aspx");
        }
        else 
        {
            Session.Abandon();
            lblErrado.Visible = true;
            lblErrado.Text = "Login/Senha errados";
        }
    }
}