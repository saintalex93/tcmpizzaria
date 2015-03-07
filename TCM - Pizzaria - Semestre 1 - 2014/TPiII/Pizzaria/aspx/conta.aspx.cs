using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_conta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["logado"] == null) 
        {
            Label1.Visible = true;
            Response.End();
        }
        /*
        conexao con = new conexao();
        con.conectar();

        con.command.CommandText = "select Nome_Cliente from Cliente";
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet dt = new DataSet();
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(dt);
        con.fechaConexao();
         */ 
        
    }
}