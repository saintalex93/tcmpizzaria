using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_lancarVaga : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void carregarVagas(object sender, EventArgs e)
    {

    }

    protected void adicionarVaga(object sender, EventArgs e)
    {

    }

    protected void editarVaga(object sender, EventArgs e)
    {

    }

    protected void removerVaga(object sender, EventArgs e)
    {

    }

    protected void selecionaGridVaga(object sender, EventArgs e)
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
                    //txtEditarArea.Text = area;
                }
                else if (painelPai.Contains("Remover"))
                {
                    //txtRemoverArea.Text = area;
                }
                break;
            }
        }
    }

    protected void carregarDropdown(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;
        DataSet ds = new DataSet();
         SqlDataAdapter dAdapter = new SqlDataAdapter();

        if (ddl.ID.Contains("Categoria"))
        {
            Conexao con = new Conexao();
            con.conectar();

            con.command.CommandText = "select * from Categorias";
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds, "Categorias");

            ddlCategorias.DataSource = ds.Tables["Categorias"].DefaultView;
            ddlCategorias.DataTextField = "Nome";
            ddlCategorias.DataValueField = "codCategoria";
            
            ddlCategorias.DataBind();
            ddlCategorias.Items.Insert(0, "Selecione uma Categoria");

            con.fechaConexao();
        }
    }

    protected void carregarArea(object sender, EventArgs e)
    {
        //if (ddlCategorias.SelectedIndex != 0)
        //{
            ddlAreas.Visible = true;

            Conexao con = new Conexao();
            DataSet ds = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();

            con.conectar();
            con.command.CommandText = "select * from Areas where Nome like %" + ddlCategorias.SelectedItem.Text + "%";

            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds, "Areas");

            ddlAreas.DataSource = ds.Tables["Areas"].DefaultView;
            ddlAreas.DataTextField = "Nome";
            ddlAreas.DataValueField = "codArea";

            con.fechaConexao();
        //}
        //Se ele não selecionou nada
        //else
        //{
            //Response.Write("Seleciona alguma coisa filho da puta");
        //}
    }
}