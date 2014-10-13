using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        var login = txtLogin;
        var senha = txtLogin_Senha;
        var logado = false;
        try
        {
            conexao con = new conexao();
            con.conectar();
            con.command.CommandText = "select Email_Cliente,Senha_Cliente from Cliente where Email_Cliente=@email and Senha_Cliente=@senha";
            con.command.Parameters.Add("@email", SqlDbType.VarChar).Value = login;
            con.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
            con.command.ExecuteNonQuery();
            con.fechaConexao();
            logado = true;
        }
        catch (Exception ex)
        {
            lblLoginInc.Text = "Login e/ou Senha incorretos";
        }
    }
}