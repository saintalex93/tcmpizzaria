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

            gdRemoveVaga.DataSource = ds;
            gdRemoveVaga.DataBind();

            con.fechaConexao();
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

    /* Método que valida os campos do painel de adicionar
     * e do painel de edição de vagas.
    */ 
    protected bool validarCampos()
    {
        if (txtNomeVaga.Text.Length <= 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Digite algum título para sua vaga.');", true);
            return false;
        }
        else if (txtEnderecoVaga.Text.Length <= 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Digite algum endereço para sua vaga.');", true);
            return false;
        }
        else if (txtDescricaoVaga.Text.Length <= 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Digite alguma descrição para sua vaga.');", true);
            return false;
        }
        else if (ddlCategorias.SelectedIndex == 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Escolha alguma categoria para sua vaga.');", true);
            return false;
        }
        else if (ddlAreas.SelectedIndex == 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Escolha alguma área para sua vaga.');", true);
            return false;
        }
        else
        {
            return true;
        }
    }

    protected void adicionarVaga(object sender, EventArgs e)
    {
        bool valida = validarCampos();
        /* A sessão do funcionario tem Código de Func / Nome / Codigo Empresa
         * A função split separa pela '/' e joga no array.
        */
        if (valida == true)
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

            int result = con.command.ExecuteNonQuery();
            if (result > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Vaga Inserida com Sucesso.'); window.location ='" + Request.ApplicationPath + "/aspx/lancarVaga.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Falha na inserção da Vaga.');", true);
            }

            con.fechaConexao();
        }
    }

    protected void editarVaga(object sender, EventArgs e)
    {
        if (gdEditaVaga.SelectedRow.RowIndex >= 0)
        {
            Conexao con = new Conexao();
            con.conectar();
            con.command.CommandText = "USP_EditarVaga";
            con.command.Parameters.AddWithValue("@codVaga", Convert.ToInt32(gdEditaVaga.SelectedRow.Cells[1].Text));
            con.command.Parameters.AddWithValue("@NovoTitulo", txtEditarNomeVaga.Text.Trim());
            con.command.Parameters.AddWithValue("@NovaDescricao", txtEditarDescricaoVaga.Text.Trim());
            con.command.Parameters.AddWithValue("@NovoEndereco", txtEditarEnderecoVaga.Text.Trim());
            con.command.Parameters.AddWithValue("@codCategoria", Convert.ToInt32(ddlEditaCategoria.SelectedItem.Value));
            con.command.Parameters.AddWithValue("@CodArea", Convert.ToInt32(ddlEditaArea.SelectedItem.Value));
            con.command.CommandType = CommandType.StoredProcedure;
            int result = con.command.ExecuteNonQuery();
            if (result > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "redirect", "alert('Vaga editada com sucesso.');window.location ='" + Request.ApplicationPath + "/aspx/lancarVaga.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Falha ao editar a vaga.');", true);
            }
            con.fechaConexao();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Selecione alguma vaga para editar.');", true);
        }
    }

    protected void removerVaga(object sender, EventArgs e)
    {
        if (gdRemoveVaga.SelectedRow.RowIndex >= 0)
        {
            int codigoVaga = Convert.ToInt32(gdRemoveVaga.SelectedRow.Cells[1].Text);
            Conexao con = new Conexao();
            con.conectar();
            con.command.CommandText = "USP_RemoverVaga";
            con.command.Parameters.AddWithValue("@codVaga", codigoVaga);
            con.command.CommandType = CommandType.StoredProcedure;
            int result = con.command.ExecuteNonQuery();
            if (result > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Vaga removida com Sucesso.'); window.location ='" + Request.ApplicationPath + "/aspx/lancarVaga.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Falha na remoção da vaga.');", true);
            }
            con.fechaConexao();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Selecione alguma vaga para deletar.');", true);
        }
    }

    protected void selecionaGridVaga(object sender, EventArgs e)
    {
        GridView gd = (GridView)sender;
        TextBox txt = new TextBox();

        //Percorrendo todos os controles do pai do grid(no caso o painel)
        foreach (Control ctr in gd.Parent.Controls)
        {
            string painelPai = gd.Parent.ID.ToString();
            string codCategoria = "";
            string codArea = "";
            string titulo = "";
            string descricao = "";
            string endereco = "";

            //Painel de Edição
            if (painelPai.Contains("2"))
            {
                codCategoria = gd.SelectedRow.Cells[2].Text;
                codArea = gd.SelectedRow.Cells[3].Text;
                titulo = gd.SelectedRow.Cells[4].Text;
                descricao = gd.SelectedRow.Cells[5].Text;
                endereco = gd.SelectedRow.Cells[6].Text;

                titulo = validarAcentos(titulo);
                descricao = validarAcentos(descricao);
                endereco = validarAcentos(endereco);

                txtEditarNomeVaga.Text = titulo;
                txtEditarEnderecoVaga.Text = endereco;
                txtEditarDescricaoVaga.Text = descricao;

                foreach(ListItem lt in ddlEditaCategoria.Items)
                {
                    if(lt.Value == codCategoria.ToString())
                    {
                        lt.Selected = true;
                        ddlEditaCategoria.SelectedValue = lt.Value;
                        break;
                    }
                }
                if (ddlEditaCategoria.SelectedIndex > 0)
                {
                    carregarArea(ddlEditaCategoria);
                    foreach (ListItem lt2 in ddlEditaArea.Items)
                    {
                        if (lt2.Value == codArea.ToString())
                        {
                            pnlEditaArea.Visible = true;
                            lt2.Selected = true;
                            ddlEditaArea.SelectedValue = lt2.Value;
                            break;
                        }
                    }
                }
            }
            break;
        }
    }

    /* Método que valida os acentos das strings que são
     * retiradas do gridview
    */
    protected string validarAcentos(string stringErrada)
    {
        if (stringErrada.Contains("&#"))
        {
            stringErrada = stringErrada.Replace("&#225;", "á");
            stringErrada = stringErrada.Replace("&#227;", "ã");
            stringErrada = stringErrada.Replace("&#233;", "é");
            stringErrada = stringErrada.Replace("&#234;", "ê");
            stringErrada = stringErrada.Replace("&#237;", "í");
            stringErrada = stringErrada.Replace("&#243;", "ó");
            stringErrada = stringErrada.Replace("&#244;", "ô");
            stringErrada = stringErrada.Replace("&#245;", "õ");
            stringErrada = stringErrada.Replace("&#250;", "ú");
            stringErrada = stringErrada.Replace("&#231;", "ç");
            stringErrada = stringErrada.Replace("&", "");
            stringErrada = stringErrada.Replace("#", "");
            stringErrada = stringErrada.Replace(";", "");
        }
        return stringErrada;
    }

    /* Método que mostra e popula o dropdown de áreas de acordo
     * com a categoria escolhida no primeiro dropdown
    */
    protected void carregarArea(DropDownList drop)
    {
        DropDownList ddl = (DropDownList)drop;
        string validarPainelPai = ddl.Parent.Parent.ID.ToString();

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

            //Buscando o painel de áreas
            foreach (Control ctr in ddl.Parent.Parent.Controls)
            {
                if(ctr is Panel && ctr.ID.Contains("Area"))
                {
                    //Buscando o Dropdown dentro do painel de áreas
                    foreach (Control ctr2 in ctr.Controls)
                    {
                        if (ctr2 is DropDownList && ctr2.ID.Contains("Area"))
                        {
                            //Preenchendo o dropdown com as informações relevantes a Categoria escolhida
                            DropDownList ddl2 = (DropDownList)ctr2;
                            ddl2.DataSource = ds.Tables["Areas"].DefaultView;
                            ddl2.DataTextField = "Nome";
                            ddl2.DataValueField = "codArea";

                            ddl2.DataBind();

                            if (ddl2.Items[0].Text != "Selecione uma área")
                            {
                                ddl2.Items.Insert(0, "Selecione uma área");
                                ddl2.SelectedIndex = 0;
                            }
                            break;
                        }
                    }
                }
            }
            if (validarPainelPai.Contains("pnlInfos1"))
            {
                pnlSelecionaArea.Visible = true;
            }
            else if (validarPainelPai.Contains("pnlInfos2"))
            {
                pnlEditaArea.Visible = true;
            }
        }
        //Se ele não selecionou nada
        else
        {
            if (validarPainelPai.Contains("pnlInfos1"))
            {
                pnlSelecionaArea.Visible = false;
            }
            else if (validarPainelPai.Contains("pnlInfos2"))
            {
                pnlEditaArea.Visible = false;
            }
        }
    }

    //Método que serve apenas para delegar a função para o método carregarArea
    //Famosa gambiarra :)
    protected void carregarArea2(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;
        carregarArea(ddl);
    }

    /* Método que verifica se algo foi carregado no gridview,
     * e esconde a célula com a index '1', que é o código referente
     * a vaga daquela linha.
    */
    protected void esconderCodigo(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.Cells.Count > 1)
        {
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[3].Visible = false;
        }
    }
}