using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_promocoes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["nome"] != null)
        {
            if (Request.Cookies["nome"].Value != "0")
            {
                refreshCadastrado();
            }
            else
            {
                refresh();
            }
        }
        else
        {
            refresh();
        }
    }
    protected void refresh()
    {
        {
            Conexao c = new Conexao();
            c.conectar();
            c.command.CommandText = "select Nome_Promocao,Descricao from Promocao where sobe_promocao = 1 and AcessivelATodos = 0";
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet dt = new DataSet();

            dAdapter.SelectCommand = c.command;
            dAdapter.Fill(dt);
            GridPromo.DataSource = dt;
            GridPromo.DataBind();
            c.fechaConexao();
        }
    }

    protected void refreshCadastrado()
    {
        Conexao c = new Conexao();
        c.conectar();
        c.command.CommandText = "select Nome_Promocao,Descricao from Promocao where sobe_promocao = 1 and AcessivelATodos >= 0";
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet dt = new DataSet();

        dAdapter.SelectCommand = c.command;
        dAdapter.Fill(dt);
        GridPromo.DataSource = dt;
        GridPromo.DataBind();
        c.fechaConexao();
    }
}