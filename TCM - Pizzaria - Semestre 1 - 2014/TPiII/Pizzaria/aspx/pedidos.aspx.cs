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
    int x;
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
        x = Convert.ToInt32(Session["cod"]);
        conexao con = new conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.command.CommandText = "select Data,Valor from Pedido where " + x + "= Cod_Cliente order by Data desc";
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
    protected void refreshDataAntiga()
    {
        x = Convert.ToInt32(Session["cod"]);
        conexao con = new conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.command.CommandText = "select Data,Valor from Pedido where " + x + "= Cod_Cliente order by Data";
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
    protected void refreshOrdenaValor()
    {
        x = Convert.ToInt32(Session["cod"]);
        conexao con2 = new conexao();
        con2.conectar();
        SqlDataAdapter dAdapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();
        con2.command.CommandText = "select Data,Valor from Pedido where " + x + "= Cod_Cliente order by Valor desc";
        //dAdapter seleciona o comando con.command
        dAdapter2.SelectCommand = con2.command;
        //Preencho meu DataSet com informações que o dAdapter "traduziu" pra ele.
        dAdapter2.Fill(ds2);
        //Pego as informações do DataSet, e preencho a tabela com elas.
        datagPedidos.DataSource = ds2;
        //Renderizando as informações na tabela com DataBind()
        datagPedidos.DataBind();
        con2.fechaConexao();
    }
    protected void refreshOrdenaValorBarato()
    {
        x = Convert.ToInt32(Session["cod"]);
        conexao con2 = new conexao();
        con2.conectar();
        SqlDataAdapter dAdapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();
        con2.command.CommandText = "select Data,Valor from Pedido where " + x + "= Cod_Cliente order by Valor";
        //dAdapter seleciona o comando con.command
        dAdapter2.SelectCommand = con2.command;
        //Preencho meu DataSet com informações que o dAdapter "traduziu" pra ele.
        dAdapter2.Fill(ds2);
        //Pego as informações do DataSet, e preencho a tabela com elas.
        datagPedidos.DataSource = ds2;
        //Renderizando as informações na tabela com DataBind()
        datagPedidos.DataBind();
        con2.fechaConexao();
    }

protected void btnOrdenarData_Click(object sender, EventArgs e)
{
    refresh();
}
protected void btnOrdenarPreco_Click(object sender, EventArgs e)
{
    refreshOrdenaValor();
}

protected void btnOrdenarBarato_Click(object sender, EventArgs e)
{
    refreshOrdenaValorBarato();
}
protected void btnOrdenarDataAntiga_Click(object sender, EventArgs e)
{
    refreshDataAntiga();
}
}