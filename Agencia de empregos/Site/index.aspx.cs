using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["funcionario"] != null)
        {
            pnlLogout.Visible = true;
            string funcionario = Session["funcionario"].ToString();
            string[] infoFuncionario = funcionario.Split('/');
            lblNomeFunc.Text = infoFuncionario[1];
            pnlLogin.Visible = false;
        }

        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        con.command.CommandText = "USP_BuscarVagas";

        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);

        gridVagas.DataSource = ds;
        gridVagas.DataBind();

        con.command.ExecuteNonQuery();
        con.fechaConexao();
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txtBuscarTitulo.Text != "")
        {
            Conexao con = new Conexao();
            con.conectar();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.command.CommandText = "USP_BuscarVagasPorTitulo " + txtBuscarTitulo.Text;

            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds);

            gridVagas.DataSource = ds;
            gridVagas.DataBind();

            con.command.ExecuteNonQuery();
            con.fechaConexao();
        }
        else
        {
            txtBuscarTitulo.Attributes.Add("placeholder", "Digite algum título !");
        }
    }

    protected void Logar(object sender, EventArgs e)
    {
        Conexao con = new Conexao();
        con.conectar();

        con.command.CommandText = "USP_Login_Func";
        con.command.Parameters.AddWithValue("@email", txtLogin.Text.Trim());
        con.command.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());
        con.command.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = con.command.ExecuteReader();

        try
        {
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Session["funcionario"] = dr[0] + " / " + dr[1];
                    Session.Timeout = 60;
                    lblNomeFunc.Text = dr[1].ToString();
                    pnlLogin.Visible = false;
                    pnlLogout.Visible = true;
                }
            }
            else
            {
                Response.Write("<script>alert('Esse login não existe.')</script");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Esse login não existe.')</script");
        }
        con.fechaConexao();
    }

    protected void Logout(object sender, EventArgs e)
    {
        Session["funcionario"] = null;
        pnlLogout.Visible = false;
        pnlLogin.Visible = true;
        Response.Redirect(Request.ApplicationPath + "/index.aspx");
    }
}