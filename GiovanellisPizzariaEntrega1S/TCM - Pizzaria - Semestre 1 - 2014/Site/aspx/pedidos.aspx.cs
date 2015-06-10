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
                codCli = Convert.ToInt32(Request.Cookies["cod"].Value);
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
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();
        con.command.CommandText = "USP_ASP_Pedidos_FiltraPedido";
        //Declarando que o tipo de comando é uma stored procedure
        con.command.CommandType = CommandType.StoredProcedure;
        //Passando Parâmetros
        con.command.Parameters.AddWithValue("botaoClicado", 1);
        con.command.Parameters.AddWithValue("codCliente", codCli);
        //dAdapter seleciona o comando con.command
        dAdapter2.SelectCommand = con.command;
        //Preencho meu DataSet com informações que o dAdapter "traduziu" pra ele.
        dAdapter2.Fill(ds2);
        //Pego as informações do DataSet, e preencho a tabela com elas.
        datagPedidos.DataSource = ds2;
        //Renderizando as informações na tabela com DataBind()
        datagPedidos.DataBind();
        con.fechaConexao();
    }
    protected void refreshDataAntiga()
    {
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.command.CommandText = "USP_ASP_Pedidos_FiltraPedido";
        //Declarando que o tipo de comando é uma stored procedure
        con.command.CommandType = CommandType.StoredProcedure;
        //Passando Parâmetros
        con.command.Parameters.AddWithValue("botaoClicado", 2);
        con.command.Parameters.AddWithValue("codCliente", codCli);
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
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.command.CommandText = "USP_ASP_Pedidos_FiltraPedido";
        //Declarando que o tipo de comando é uma stored procedure
        con.command.CommandType = CommandType.StoredProcedure;
        //Passando Parâmetros
        con.command.Parameters.AddWithValue("botaoClicado", 3);
        con.command.Parameters.AddWithValue("codCliente", codCli);
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
    protected void refreshOrdenaValorBarato()
    {
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.command.CommandText = "USP_ASP_Pedidos_FiltraPedido";
        //Declarando que o tipo de comando é uma stored procedure
        con.command.CommandType = CommandType.StoredProcedure;
        //Passando Parâmetros
        con.command.Parameters.AddWithValue("botaoClicado", 4);
        con.command.Parameters.AddWithValue("codCliente", codCli);
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