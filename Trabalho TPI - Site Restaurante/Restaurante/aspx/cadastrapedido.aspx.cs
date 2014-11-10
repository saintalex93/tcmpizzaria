using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_cadastrapedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] != null) 
        {
            Response.Write("<script>alert('Você não está autorizado a acessar essa página')</script>");
            Response.Write("<script>window.history.go(-1)</script>");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet dt = new DataSet();

        conexao con = new conexao();
        con.conectar();
        String prod = "%" + txtNomeProduto + "%";
        con.command.CommandText = "select * from Produto where Nome_Produto like @p";
        con.command.Parameters.Add("@p", System.Data.SqlDbType.VarChar).Value = prod;
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(dt);
        datagridProdutos.DataSource = dt;
        datagridProdutos.DataBind();
        con.fechaConexao();
    }
}