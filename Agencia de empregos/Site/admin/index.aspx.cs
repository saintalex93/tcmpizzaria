using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter dAdapter = new SqlDataAdapter();

        Conexao con = new Conexao();
        con.conectar();
        con.command.CommandText = "USP_Login_Admin";
        con.command.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = txtLoginAdm.Text.Trim();
        con.command.Parameters.AddWithValue("@senha", SqlDbType.VarChar).Value = txtSenhaAdm.Text.Trim();
        con.command.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = con.command.ExecuteReader();

        try
        {
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    Session["admin"] = dr[0].ToString() + " / " + dr[1].ToString();
                    Session.Timeout = 60;
                    Response.Redirect(Request.ApplicationPath + "/admin/gerenciaCategoria.aspx");
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
}