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
    int codCli;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["nome"] != null)
        {
            if (Request.Cookies["nome"].Value == "0")
            {
                Response.Write("<script>alert('Você deve estar logado para acessar esta página.')</script>");
                Response.Write("<script>history.go(-1)</script>");
            }
            else
            {
                refresh();
            }
        }
        else
        {
            Response.Write("<script>alert('Você deve estar logado para acessar esta página.')</script>");
            Response.Write("<script>history.go(-1)</script>");
        }
    }
    protected void refresh()
    {
        codCli = Convert.ToInt32(Request.Cookies["cod"].Value);
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.command.CommandText = "select Data,Valor,Observacao from Pedido where " + codCli + "= Cod_Cliente order by Data desc";
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
        codCli = Convert.ToInt32(Request.Cookies["cod"].Value);
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.command.CommandText = "select Data,Valor,Observacao from Pedido where " + codCli + "= Cod_Cliente order by Data";
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
        codCli = Convert.ToInt32(Request.Cookies["cod"].Value);
        Conexao con2 = new Conexao();
        con2.conectar();
        SqlDataAdapter dAdapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();
        con2.command.CommandText = "select Data,Valor,Observacao from Pedido where " + codCli + "= Cod_Cliente order by Valor desc";
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
        codCli = Convert.ToInt32(Request.Cookies["cod"].Value);
        Conexao con2 = new Conexao();
        con2.conectar();
        SqlDataAdapter dAdapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();
        con2.command.CommandText = "select Data,Valor,Observacao from Pedido where " + codCli + "= Cod_Cliente order by Valor";
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