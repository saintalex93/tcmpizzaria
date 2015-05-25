using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_gerenciaCategoria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        DataSet ds = new DataSet();
        SqlDataAdapter dAdapter = new SqlDataAdapter();

        Conexao con = new Conexao();
        con.conectar();

        con.command.CommandText = "select * from Categorias";
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);

        //Renderizando as tabelas
        gdEditaCategoria.DataSource = ds;
        gdEditaCategoria.DataBind();

        gdRemoveCategoria.DataSource = ds;
        gdRemoveCategoria.DataBind();

        con.command.ExecuteNonQuery();
        con.fechaConexao();
    }

    protected void adicionarCategoria(object sender, EventArgs e)
    {
        if (txtNomeCategoria.Text != "")
        {
            //try
            //{
                Conexao con = new Conexao();
                con.conectar();
                //Executando procedure para adicionar a categoria
                con.command.CommandText = "USP_AdicionarCategoria";
                con.command.CommandType = CommandType.StoredProcedure;

                //Parâmetro nome que vem do que foi digitado no TextBox
                con.command.Parameters.AddWithValue("@nome", txtNomeCategoria.Text.Trim());

                int result = con.command.ExecuteNonQuery();
                con.fechaConexao();
                //Verificando se foi inserido com sucesso.
                if (result > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Categoria inserida com sucesso.'); window.location='" + Request.ApplicationPath + "admin/gerenciaCategoria.aspx';", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Falha na inserção de Categoria.');", true);
                }
            }
            //catch(Exception ex)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Falha na inserção de Categoria.');", true);
            //}
        //}
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Digite um nome para a Categoria.');", true);
        }
    }

    public void editarCategoria(object sender, EventArgs e)
    {
        int? linhaSelecionada = 0;
        int? codigoCategoria = 0;
        
        try
        {
            linhaSelecionada = gdEditaCategoria.SelectedRow.RowIndex;
            codigoCategoria = Convert.ToInt32(gdEditaCategoria.SelectedRow.Cells[1].Text);
        }
        catch(Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Selecione a categoria que deseja alterar.');", true);
        }

        if (txtEditarCategoria.Text != "" && linhaSelecionada >= 0)
        {
            Conexao con = new Conexao();
            con.conectar();

            con.command.CommandType = CommandType.StoredProcedure;
            con.command.CommandText = "USP_EditarCategoria";

            con.command.Parameters.AddWithValue("@novoNome", txtEditarCategoria.Text);
            con.command.Parameters.AddWithValue("@codigoCategoria", codigoCategoria);

            con.command.ExecuteNonQuery();
            con.fechaConexao();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Categoria alterada com sucesso.'); window.location='" + Request.ApplicationPath + "admin/gerenciaCategoria.aspx';", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Selecione a categoria que deseja alterar.');", true);
        }

        txtEditarCategoria.Text = "";
    }

    protected void removerCategoria(object sender, EventArgs e)
    {
        int? linhaSelecionada = 0;
        int? codigoCategoria = 0;

        try
        {
            linhaSelecionada = gdRemoveCategoria.SelectedRow.RowIndex;
            codigoCategoria = Convert.ToInt32(gdRemoveCategoria.SelectedRow.Cells[1].Text);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Selecione a categoria que deseja remover.');", true);
        }

        if (txtRemoverCategoria.Text != "" && linhaSelecionada >= 0)
        {
            Conexao con = new Conexao();
            con.conectar();

            con.command.CommandType = CommandType.StoredProcedure;
            con.command.CommandText = "USP_RemoverCategoria";

            con.command.Parameters.AddWithValue("@codigoCategoria", codigoCategoria);

            con.command.ExecuteNonQuery();
            con.fechaConexao();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Categoria removida com sucesso.'); window.location='" + Request.ApplicationPath + "admin/gerenciaCategoria.aspx';", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Selecione a categoria que deseja remover.');", true);
        }

        txtRemoverCategoria.Text = "";
    }

    protected void selecionaGridCategoria(object sender, EventArgs e)
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
                string categoria = gd.SelectedRow.Cells[2].Text;
                if (categoria.Contains("&#"))
                {
                    categoria = categoria.Replace("&#225;", "á");
                    categoria = categoria.Replace("&#227;", "ã");
                    categoria = categoria.Replace("&#233;", "é");
                    categoria = categoria.Replace("&#234;", "ê");
                    categoria = categoria.Replace("&#237;", "í");
                    categoria = categoria.Replace("&#243;", "ó");
                    categoria = categoria.Replace("&#244;", "ô");
                    categoria = categoria.Replace("&#245;", "õ");
                    categoria = categoria.Replace("&#250;", "ú");
                    categoria = categoria.Replace("&#231;", "ç");

                    categoria = categoria.Replace("#", "");
                }
                if (painelPai.Contains("Editar"))
                {
                    txtEditarCategoria.Text = categoria;
                }
                else if(painelPai.Contains("Remover"))
                {
                    txtRemoverCategoria.Text = categoria;
                }
                break;
            }
        }
    }
}