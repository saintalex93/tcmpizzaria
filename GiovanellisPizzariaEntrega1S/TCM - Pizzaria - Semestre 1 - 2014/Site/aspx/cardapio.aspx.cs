using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_cardapio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        refresh();
    }
    protected void refresh()
    {
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.command.CommandText = "select Nome_Produto,Ingred_Prod,Valor_Venda from Produto p inner join Categoria c on p.CodCategoria = 1 and c.CodCategoria = 1 and p.Sobe_Site=1 order by Nome_Produto";
        
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);
        dtCardapio.DataSource = ds;
        dtCardapio.DataBind();
        con.fechaConexao();
    }
}