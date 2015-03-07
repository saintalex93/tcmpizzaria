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
        if (Session["nome"] != null)
        {
            refreshCadastrado();
        }
        else
        {
            refresh();
        }
    }
    protected void refresh()
    {
        {
            conexao c = new conexao();
            c.conectar();
            c.command.CommandText = "select Nome_Promocao,Descricao from Promocao where sobe_promocao = 1 and usuario_cadastrado = 0";
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
        conexao c = new conexao();
        c.conectar();
        c.command.CommandText = "select Nome_Promocao,Descricao from Promocao where sobe_promocao = 1 and usuario_cadastrado >= 0";
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet dt = new DataSet();

        dAdapter.SelectCommand = c.command;
        dAdapter.Fill(dt);
        GridPromo.DataSource = dt;
        GridPromo.DataBind();
        c.fechaConexao();
    }
}