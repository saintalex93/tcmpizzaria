using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_gerenciaVaga : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter dAdapter = new SqlDataAdapter();

        Conexao con = new Conexao();
        con.conectar();

        con.command.CommandType = CommandType.StoredProcedure;
        con.command.CommandText = "USP_BuscarVagasAdmin";
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);
        gdVagas.DataSource = ds;
        gdVagas.DataBind();

        con.fechaConexao();

        int linhas = gdVagas.Rows.Count;
        
        for (int i = 0; i < linhas; i++)
        {
            if (gdVagas.Rows[i].Cells[1].Text == "1")
            {
                gdVagas.Rows[i].BackColor = System.Drawing.Color.FromArgb(108, 207, 108);
            }
            else if (gdVagas.Rows[i].Cells[1].Text == "0")
            {
                gdVagas.Rows[i].BackColor = System.Drawing.Color.FromArgb(211, 73, 73);
            }
        }
    }

    protected void AlterarEstado(object sender, EventArgs e)
    {
        int? linhaSelecionada = 0;

        try
        {
            linhaSelecionada = gdVagas.SelectedRow.RowIndex;

            string codigoVaga = gdVagas.SelectedRow.Cells[2].Text;
            Conexao con = new Conexao();
            con.conectar();

            con.command.CommandType = CommandType.StoredProcedure;
            con.command.Parameters.AddWithValue("@codVaga", codigoVaga);
            con.command.CommandText = "USP_AtivarInativarVagas";
            int result = con.command.ExecuteNonQuery();
            con.fechaConexao();

            if (result > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "redirect", "alert('Estado alterado com sucesso.');window.location = '" + Request.ApplicationPath + "/admin/gerenciaVaga.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Erro ao inativar a vaga.');", true);
            }
        }
        catch (Exception NullReferenceException)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Escolha uma vaga para alterar o estado.');", true);
        }
    }

    protected void esconderCodigos(object sender, GridViewRowEventArgs e)
    {
        //Escondendo código de estado
        e.Row.Cells[1].Visible = false;
        //Escondendo código de vaga
        e.Row.Cells[2].Visible = false;
    }
}