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
        //refresh();
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
        String data = txtData.Text;
        decimal valor = Convert.ToDecimal(txtValor.Text);
        int sit = Convert.ToInt32(txtSit.Text);
        int cod_cli = Convert.ToInt32(txtCodCli.Text);

        conexao con = new conexao();
        con.conectar();
        con.command.CommandText = "insert into Pedido(Data, Valor,Cod_Cliente,Situacao)" + "values(@data,@valor,@codcliente,@sit)";
        con.command.Parameters.Add("@data", SqlDbType.VarChar).Value = data;
        con.command.Parameters.Add("@valor", SqlDbType.Decimal).Value = valor;
        con.command.Parameters.Add("@codcliente",SqlDbType.Int).Value = cod_cli;
        con.command.Parameters.Add("@sit", SqlDbType.Int).Value = sit;
        con.command.ExecuteNonQuery();
        con.fechaConexao();
        Response.Write("<script>alert('Pedido cadastrado com sucesso !!')</script>");
        refresh();
    }
    protected void refresh()
    {
        SqlDataAdapter dAdapter2 = new SqlDataAdapter();
        DataSet dt2 = new DataSet();

        conexao con2 = new conexao();
        con2.conectar();
        con2.command.CommandText = "select MAX(Cod_Pedido) as ultimoPedido from Pedido";
        dAdapter2.SelectCommand = con2.command;
        dAdapter2.Fill(dt2);
        con2.command.ExecuteNonQuery();
        con2.fechaConexao();

        Session["codpedido"] = Convert.ToInt32(dt2.Tables[0].DefaultView[0].Row["ultimoPedido"]);

        Response.Redirect("cadastraproduto.aspx");
    }

    protected void UltimosProdutos() 
    {
        //SqlDataAdapter dAdapter3 = new SqlDataAdapter();
        //DataSet dt3 = new DataSet();

        //conexao con3 = new conexao();
        //con3.conectar();

        ////con3.command.CommandText = "select Cod_Produto as Produtos from Pedido_Cliente where @cod = " + x + "\"";
        //dAdapter3.SelectCommand = con3.command;
        //dAdapter3.Fill(dt3);
        //datagridProdutos.DataSource = dt3;
        //datagridProdutos.DataBind();
        //con3.fechaConexao();
    }

    protected void btnPesquisarCliente_Click(object sender, EventArgs e)
    {
        //SqlDataAdapter dAdapter5 = new SqlDataAdapter();
        //DataSet dt5 = new DataSet();

        //conexao con = new conexao();
        //con.conectar();
        //string cpf = "%" + txtCpf.Text + "%";
        //con.command.CommandText = "select Cod_Cliente,Nome_Cliente from Cliente where CPF_Cliente like @cpf";
        //con.command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
        //dAdapter5.SelectCommand = con.command;
        //dAdapter5.Fill(dt5);
        //datagridClientes.DataSource = dt5;
        //datagridClientes.DataBind();
        //con.fechaConexao();
    }
    protected void btnCadastrarProdutos_Click(object sender, EventArgs e)
    {
       
        ////Response.Write("<script>alert('Produto Cadastrado com sucesso.')</script>");
    }
}