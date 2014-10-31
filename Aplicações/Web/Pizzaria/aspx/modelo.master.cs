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
    //int qtde;
    string nome;
    bool x = true;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] != null)
        {
            pnl.Visible = false;
            pnl_logout.Visible = true;
            lblNomeUsuario.Text = Session["nome"].ToString();
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        validacao();
        if (x == true)
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

                sql = "select Nome_Cliente from Cliente where Email_Cliente=@email and Senha_Cliente=@senha";
                con.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                con.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                con.command.CommandText = sql;
                dAdapter.SelectCommand = con.command;
                dAdapter.Fill(dt);
                con.fechaConexao();

                nome = dt.Tables[0].DefaultView[0].Row["Nome_Cliente"].ToString();
                if (nome != null)
                {
                    Session["nome"] = nome;
                    lblNomeUsuario.Text = Session["nome"].ToString();
                    pnl.Visible = false;
                    pnl_logout.Visible = true;
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
    }

    protected void validacao() 
    {
        if (txtEmail.Text.Length < 7) 
        {
            x = false;
            txtEmail.Focus();
            x = true;
        }
        else if (txtLogin_senha.Text.Length < 6) 
        {
            x = false;
            txtLogin_senha.Focus();
            x = true;
        }
    }
}
