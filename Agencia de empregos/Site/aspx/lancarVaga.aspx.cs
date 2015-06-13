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
        if (Session["funcionario"] != null && !IsPostBack)
        {
            string sessao = Session["funcionario"].ToString();
            string[] codEmpresa = sessao.Split('/');

            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            Conexao con = new Conexao();
            con.conectar();
            con.command.Parameters.AddWithValue("@codEmpresa", Convert.ToInt32(codEmpresa[2]));
            con.command.CommandType = CommandType.StoredProcedure;
            con.command.CommandText = "USP_BuscarVagasEmpresa";
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds);

            gdEditaVaga.DataSource = ds;
            gdEditaVaga.DataBind();

            con.fechaConexao();
        }
    }

    protected void carregarVagas(object sender, EventArgs e)
    {

    }

    protected void adicionarVaga(object sender, EventArgs e)
    {
        string sessao = Session["funcionario"].ToString();
        string[] codEmpresa = sessao.Split('/');

        Conexao con = new Conexao();
        con.conectar();
        con.command.Parameters.AddWithValue("@Titulo", txtNomeVaga.Text.Trim());
        con.command.Parameters.AddWithValue("@Descricao", txtDescricaoVaga.Text.Trim());
        con.command.Parameters.AddWithValue("@CodEmpresa", codEmpresa[2]);
        con.command.Parameters.AddWithValue("@Endereco", txtEnderecoVaga.Text.Trim());
        con.command.Parameters.AddWithValue("@CodCategoria", Convert.ToInt32(ddlCategorias.SelectedItem.Value));
        con.command.Parameters.AddWithValue("@CodArea", Convert.ToInt32(ddlAreas.SelectedItem.Value));
        con.command.Parameters.AddWithValue("@Data", DateTime.Now.ToShortDateString());
        con.command.CommandType = CommandType.StoredProcedure;
        con.command.CommandText = "USP_AdicionarVaga";

        con.command.ExecuteNonQuery();

        con.fechaConexao();
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

        if (ddl.ID.Contains("Categoria") && !IsPostBack)
        {
            Conexao con = new Conexao();
            con.conectar();

            con.command.CommandText = "select * from Categorias";
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds, "Categorias");

            ddl.DataSource = ds.Tables["Categorias"].DefaultView;
            ddl.DataTextField = "Nome";
            ddl.DataValueField = "codCategoria";
            
            ddl.DataBind();
            ddl.Items.Insert(0, "Selecione uma Categoria");
            ddl.SelectedIndex = 0;

            con.fechaConexao();
        }
    }

    protected void carregarArea(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;

        if (ddl.SelectedIndex > 0)
        {
            Conexao con = new Conexao();
            DataSet ds = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();

            int codigoCategoria = Convert.ToInt32(ddl.SelectedItem.Value);

            con.conectar();
            con.command.CommandText = "select * from Areas where codCategoria = " + codigoCategoria;

            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds, "Areas");

            con.fechaConexao();

            foreach (Control ctr in ddl.Parent.Controls)
            {
                if (ctr is DropDownList && ctr.ID.Contains("Area"))
                {
                    DropDownList ddl2 = (DropDownList)ctr;
                    ddl2.DataSource = ds.Tables["Areas"].DefaultView;
                    ddl2.DataTextField = "Nome";
                    ddl2.DataValueField = "codArea";

                    ddl2.DataBind();

                    if (ddl2.Items[0].Text != "Selecione uma área")
                    {
                        ddl2.Items.Insert(0, "Selecione uma área");
                        ddl2.SelectedIndex = 0;
                    }
                }
            }

            pnlSelecionaArea.Visible = true;
        }
        //Se ele não selecionou nada
        else
        {
            pnlSelecionaArea.Visible = false;
        }
    }
}