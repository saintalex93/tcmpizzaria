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
        validacao();
        if (x == true)
        {
            try
            {
                DataSet dt = new DataSet();
                SqlDataAdapter dAdapter = new SqlDataAdapter();

                SqlDataAdapter dAdapter2 = new SqlDataAdapter();
                DataSet dt2 = new DataSet();

                String email = txtEmail.Text.Trim();
                String senha = txtLogin_senha.Text.Trim();

                conexao con = new conexao();
                con.conectar();

                con.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                con.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                
                con.command.CommandText = "select Cod_Cliente from Cliente where Email_Cliente=@email and Senha_Cliente=@senha";
                dAdapter.SelectCommand = con.command;
                dAdapter.Fill(dt);
                con.fechaConexao();

                conexao con2 = new conexao();
                con2.conectar();

                con2.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                con2.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                con2.command.CommandText = "select Nome_Cliente from Cliente where Email_Cliente=@email and Senha_Cliente=@senha";
                dAdapter2.SelectCommand = con2.command;
                dAdapter2.Fill(dt2);
                con2.fechaConexao();

                nome = dt2.Tables[0].DefaultView[0].Row["Nome_Cliente"].ToString();
                codcliente = Convert.ToInt32(dt.Tables[0].DefaultView[0].Row["Cod_Cliente"]);
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
        if (txtEmail.Text.Length < 5) 
        {
            x = false;
            Response.Write("<script>alert('Email curto demais !!')</script>");
            txtEmail.Focus();
        }
        else if (txtLogin_senha.Text.Length < 6)
        {
            x = false;
            Response.Write("<script>alert('Senha curta demais !!')</script>");
            txtLogin_senha.Focus();
        }
    }
}
