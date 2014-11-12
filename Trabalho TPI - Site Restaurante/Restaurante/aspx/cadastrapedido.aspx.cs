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
        refresh();
        //refreshUltimo();
        //if (Session["nome"] != null)
        //{
        //    Response.Write("<script>alert('Você não está autorizado a acessar essa página')</script>");
        //    Response.Write("<script>window.history.go(-1)</script>");
        //}

        //int cod2 = 0;
        //cod2 = Convert.ToInt32(Session["codpedido"]);

        //if (cod2 > 0)
        //{
        //    refreshUltimo();
        //}
    }
   
    protected void btnCadastraPedido_Click(object sender, EventArgs e)
    {
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet dt = new DataSet();

        String data = txtData.Text;
        double valor = Convert.ToDouble(txtValor.Text);
        int sit = Convert.ToInt32(txtSit.Text);

        conexao con = new conexao();
        con.conectar();
        con.command.CommandText = "insert into Pedido(Data, Valor, Situacao) " + "values(@data, @valor, @sit)";
        con.command.Parameters.Add("@data", SqlDbType.VarChar).Value = data;
        con.command.Parameters.Add("@valor", SqlDbType.Decimal).Value = valor;
        con.command.Parameters.Add("@sit", SqlDbType.Int).Value = sit;
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(dt);
        dataGridPedido.DataSource = dt;
        dataGridPedido.DataBind();
        con.fechaConexao();

        
    }
    protected void refresh()
    {
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet dt = new DataSet();

        conexao con = new conexao();
        con.conectar();
        con.command.CommandText = "select Cod_Produto,Nome_Produto from Produto";
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(dt);
        datagridProdutos.DataSource = dt;
        datagridProdutos.DataBind();
        con.fechaConexao();
    }
    protected void refreshUltimo()
    {
        SqlDataAdapter dAdapter2 = new SqlDataAdapter();
        DataSet dt2 = new DataSet();

        conexao con2 = new conexao();
        con2.conectar();
        con2.command.CommandText = "select MAX(Cod_Pedido), as Pedido from Pedido_Cliente";
        dAdapter2.SelectCommand = con2.command;
        dAdapter2.Fill(dt2);
        dataGridPedido.DataSource = dt2;
        dataGridPedido.DataBind();
        con2.fechaConexao();
    }
    protected void UltimosProdutos() 
    {
        SqlDataAdapter dAdapter3 = new SqlDataAdapter();
        DataSet dt3 = new DataSet();

        conexao con3 = new conexao();
        con3.conectar();

        //con3.command.CommandText = "select Cod_Produto as Produtos from Pedido_Cliente where @cod = " + x + "\"";
        dAdapter3.SelectCommand = con3.command;
        dAdapter3.Fill(dt3);
        dataGridProduto.DataSource = dt3;
        dataGridProduto.DataBind();
        con3.fechaConexao();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String data = txtData.Text;
        double valor = Convert.ToDouble(txtValor.Text);
        int prod = Convert.ToInt32(txtProduto.Text);
        int qtde = Convert.ToInt32(txtQtd.Text);

        conexao con = new conexao();
        con.conectar();
        con.command.CommandText = "insert into Pedido(Data, Valor) " + "values(@data, @valor)";
        con.command.Parameters.Add("@data",SqlDbType.VarChar).Value = data;
        con.command.Parameters.Add("@valor",SqlDbType.Decimal).Value = @valor;

        refreshUltimo();

        //cod = Convert.ToInt32(dt.Tables[0].DefaultView[0].Row["Cod_Pedido"]);

        //Session["codpedido"] = cod;
    }
    public void aparecerUsuario() 
    {
        pnl_dgProdutos.Visible = false;
        pnl_dgCliente.Visible = true;
    }
    
}