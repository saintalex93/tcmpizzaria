using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_pedidos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        refresh();
        if (Session["nome"] == null) 
        {
            Response.Write("<script>alert('Você deve estar logado para acessar essa página !!')</script>");
            Response.Write("<script>window.history.go(-1)</script>");
            Response.End();
        }
    }
    protected void refresh() 
    {
        int x =  Convert.ToInt32(Session["cod"]);

        conexao con = new conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.command.CommandText = "select Data,Valor from Pedido where "+ x + "= Cod_Cliente";
        //dAdapter seleciona o comando con.command
        dAdapter.SelectCommand = con.command;
        //Preencho meu DataSet com informações que o dAdapter "traduziu" pra ele.
        dAdapter.Fill(ds);
        //Pego as informações do DataSet, e preencho a tabela com elas.
        datagPedidos.DataSource = ds;
        //Renderizando as informações na tabela com DataBind()
        datagPedidos.DataBind();
        con.fechaConexao();
    }
}