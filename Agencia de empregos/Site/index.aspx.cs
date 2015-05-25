using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        con.command.CommandText = "USP_BuscarVagas";

        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);

        gridVagas.DataSource = ds;
        gridVagas.DataBind();

        con.command.ExecuteNonQuery();
        con.fechaConexao();
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txtBuscarTitulo.Text != "")
        {
            Conexao con = new Conexao();
            con.conectar();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.command.CommandText = "USP_BuscarVagasPorTitulo " + txtBuscarTitulo.Text;

            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds);

            gridVagas.DataSource = ds;
            gridVagas.DataBind();

            con.command.ExecuteNonQuery();
            con.fechaConexao();
        }
        else
        {
            txtBuscarTitulo.Attributes.Add("placeholder", "Digite algum título !");
        }
    }
    protected void gridVagas_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}