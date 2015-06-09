using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_gerenciaArea : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter dAdapter = new SqlDataAdapter();

        Conexao con = new Conexao();
        con.conectar();

        con.command.CommandText = "select * from Areas";
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);

        //Renderizando as tabelas
        gdEditaArea.DataSource = ds;
        gdEditaArea.DataBind();

        gdRemoveArea.DataSource = ds;
        gdRemoveArea.DataBind();

        con.command.ExecuteNonQuery();
        con.fechaConexao();
    }

    protected void adicionarArea(object sender, EventArgs e)
    {
        if (txtNomeArea.Text != "" && ddlCategorias.SelectedIndex != 0)
        {
            Conexao con = new Conexao();
            con.conectar();
            con.command.CommandType = CommandType.StoredProcedure;
            con.command.CommandText = "USP_AdicionarArea";
            con.command.Parameters.AddWithValue("@NomeArea", txtNomeArea.Text);
            con.command.Parameters.AddWithValue("@CodigoCategoria", ddlCategorias.SelectedItem.Value);
            int result = con.command.ExecuteNonQuery();
            con.fechaConexao();

            if (result > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Área inserida com sucesso.'); window.location='" + Request.ApplicationPath + "/admin/gerenciaArea.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Falha na inserção de Área.');", true);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Insira um nome para a Área.');", true);
        }
    }

    protected void selecionaGridArea(object sender, EventArgs e)
    {
        GridView gd = (GridView)sender;
        TextBox txt = new TextBox();

        //Percorrendo todos os controles do pai do grid(no caso o painel)
        foreach (Control ctr in gd.Parent.Controls)
        {
            string painelPai = gd.Parent.ID.ToString();
            //Encontrado o TextBox que vai receber o que o usuário selecionar
            if (ctr is TextBox)
            {
                txt = (TextBox)ctr;
                string area = gd.SelectedRow.Cells[2].Text;
                if (area.Contains("&#"))
                {
                    area = area.Replace("&#225;", "á");
                    area = area.Replace("&#227;", "ã");
                    area = area.Replace("&#233;", "é");
                    area = area.Replace("&#234;", "ê");
                    area = area.Replace("&#237;", "í");
                    area = area.Replace("&#243;", "ó");
                    area = area.Replace("&#244;", "ô");
                    area = area.Replace("&#245;", "õ");
                    area = area.Replace("&#250;", "ú");
                    area = area.Replace("&#231;", "ç");

                    area = area.Replace("#", "");
                }
                if (painelPai.Contains("Editar"))
                {
                    txtEditarArea.Text = area;
                }
                else if (painelPai.Contains("Remover"))
                {
                    txtRemoverArea.Text = area;
                }
                break;
            }
        }
    }

    protected void editarArea(object sender, EventArgs e)
    {
        int? linhaSelecionada = 0;
        int? codigoArea = 0;

        try
        {
            linhaSelecionada = gdEditaArea.SelectedRow.RowIndex;
            codigoArea = Convert.ToInt32(gdEditaArea.SelectedRow.Cells[1].Text);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Selecione a categoria que deseja alterar.');", true);
        }

        if (txtEditarArea.Text != "" && linhaSelecionada >= 0)
        {
            Conexao con = new Conexao();
            con.conectar();

            con.command.CommandType = CommandType.StoredProcedure;
            con.command.CommandText = "USP_EditarNomeArea";

            con.command.Parameters.AddWithValue("@NomeArea", txtEditarArea.Text);
            con.command.Parameters.AddWithValue("@codArea", codigoArea);

            con.command.ExecuteNonQuery();
            con.fechaConexao();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Área alterada com sucesso.'); window.location='" + Request.ApplicationPath + "/admin/gerenciaArea.aspx';", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Selecione a área que deseja alterar.');", true);
        }

        txtEditarArea.Text = "";
    }

    protected void removerArea(object sender, EventArgs e)
    {
        int linhaSelecionada = gdRemoveArea.SelectedRow.RowIndex;
        int codigoArea = Convert.ToInt32(gdRemoveArea.SelectedRow.Cells[1].Text);
        Conexao con = new Conexao();
        con.conectar();
        con.command.CommandType = CommandType.StoredProcedure;
        con.command.CommandText = "USP_DeletarArea";
        con.command.Parameters.AddWithValue("@codArea", codigoArea);
        int result = con.command.ExecuteNonQuery();
        con.fechaConexao();
        if (result > 0)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Área removida com sucesso.'); window.location='" + Request.ApplicationPath + "/admin/gerenciaArea.aspx';", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Falha na remoção de Área.');", true);
        }
    }

    protected void carregarCategorias(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();

            Conexao con = new Conexao();
            con.conectar();
            con.command.CommandText = "select * from Categorias";
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds, "Categorias");
            ds.Tables["Categorias"].DefaultView.ToString();
            ddlCategorias.DataSource = ds.Tables["Categorias"].DefaultView;
            ddlCategorias.DataTextField = "Nome";
            ddlCategorias.DataValueField = "codCategoria";
            ddlCategorias.DataBind();
            con.fechaConexao();

            ddlCategorias.Items.Insert(0, "Selecione uma Categoria");
        }
    }
}