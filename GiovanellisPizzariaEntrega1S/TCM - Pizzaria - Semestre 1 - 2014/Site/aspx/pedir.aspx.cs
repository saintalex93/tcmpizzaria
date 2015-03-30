using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mail;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_pedir : System.Web.UI.Page
{
    public static double selecionado1;
    public static double selecionado2;
    public static double selecionado3;
    public static double selecionado4;
    public static double selecionado5;
    public static double selecionado6;
    public double precoAtual;
    public double precoAtual2;
    public double precoAtual3;
    public int valor;
    public int valor2;
    public int ultimoValor;
    string codCli;

    protected void Page_Load(object sender, EventArgs e)
    {
        pnlProdutosPedido.Visible = false;
        if (Request.Cookies["cod"] != null)
        {
            if (Request.Cookies["cod"].Value == "0")
            {
                Response.Write("<script>alert('Você deve estar logado para acessar esta página.')</script>");
                Response.Write("<script>history.go(-1)</script>");
            }
            else
            {
                Conexao con2 = new Conexao();
                SqlDataAdapter dAdapter2 = new SqlDataAdapter();
                DataSet ds2 = new DataSet();

                con2.conectar();
                con2.command.CommandText = "select Valor_Venda from Produto as p inner join Categoria as c on c.CodCategoria = 1";
                dAdapter2.SelectCommand = con2.command;
                dAdapter2.Fill(ds2);
                Session["valor"] = ds2;
                con2.fechaConexao();

                txtObservacoes.Attributes.Add("placeholder", "Ex: Pizza Mussarela sem cebola");
                codCli = Request.Cookies["cod"].Value;
                if (Request.Cookies["pizzas"] == null)
                {
                    
                }
                else
                {
                    if (!IsPostBack)
                    {
                        lblPrimeiroSabor.Text = Request.Cookies["pizzas"].Value;
                    }
                    pnlProdutosPedido.Visible = true;
                }

                Conexao con = new Conexao();
                SqlDataAdapter dAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                con.conectar();
                con.command.CommandText = "select Endereco_Cliente, Numero_Residencia, Bairro_Cliente, Numero_Apartamento from Cliente where Cod_Cliente =" + codCli;
                dAdapter.SelectCommand = con.command;
                dAdapter.Fill(ds);
                string endereco = ds.Tables[0].DefaultView[0].Row["Endereco_Cliente"].ToString();
                string numero = ds.Tables[0].DefaultView[0].Row["Numero_Residencia"].ToString();
                string bairro = ds.Tables[0].DefaultView[0].Row["Bairro_Cliente"].ToString();
                string numApart = ds.Tables[0].DefaultView[0].Row["Numero_Apartamento"].ToString();
                con.fechaConexao();

                if (numApart == "0" || numApart == "")
                {
                    txtEnderecoPedido.Text = endereco + ", nº " + numero + " - " + bairro;
                }
                else
                {
                    txtEnderecoPedido.Text = endereco + ", nº " + numero + " - " + bairro + ", Apt. " + numApart;
                }
            }
        }
        else
        {
            Response.Write("<script>alert('Você deve estar logado para acessar esta página.')</script>");
            Response.Write("<script>history.go(-1)</script>");
        }
    }

    //FIM LOAD DA PÁGINA

    protected void ddlQtdPizzas_SelectedIndexChanged(object sender, EventArgs e)
    {
        int pizzaSelecionada = ddlQtdPizzas.SelectedIndex;
        switch (pizzaSelecionada)
        {
            case 0:
                pnlSegundaPizza.Visible = false;
                pnlTerceiraPizza.Visible = false;
                pnlQuartaPizza.Visible = false;
                pnlQuintaPizza.Visible = false;

                lblPrecoDois.Text = "";
                lblPrecoTres.Text = "";
                lblPrecoQuatro.Text = "";
                lblPrecoCinco.Text = "";
                break;
            case 1:
                pnlSegundaPizza.Visible = true;

                pnlTerceiraPizza.Visible = false;
                pnlQuartaPizza.Visible = false;
                pnlQuintaPizza.Visible = false;

                lblPrecoTres.Text = "";
                lblPrecoQuatro.Text = "";
                lblPrecoCinco.Text = "";
                break;
            case 2:
                pnlSegundaPizza.Visible = true;
                pnlTerceiraPizza.Visible = true;

                pnlQuartaPizza.Visible = false;
                pnlQuintaPizza.Visible = false;

                lblPrecoQuatro.Text = "";
                lblPrecoCinco.Text = "";
                break;
            case 3:
                pnlSegundaPizza.Visible = true;
                pnlTerceiraPizza.Visible = true;
                pnlQuartaPizza.Visible = true;

                pnlQuintaPizza.Visible = false;

                lblPrecoCinco.Text = "";
                break;
            case 4:
                pnlSegundaPizza.Visible = true;
                pnlTerceiraPizza.Visible = true;
                pnlQuartaPizza.Visible = true;
                pnlQuintaPizza.Visible = true;
                break;
        }
    }

    /* LOAD DOS DROPDOWNS */

    protected void carregandoDropDown(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;
        if (!IsPostBack)
        {
            Conexao con = new Conexao();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.conectar();
            con.command.CommandText = "select * from Produto as p inner join Categoria as c on c.codCategoria = 1 and p.codCategoria = 1";
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds, "Produto");
            ds.Tables["Produto"].DefaultView[0].ToString();
            ddl.DataSource = ds.Tables["Produto"].DefaultView;
            ddl.DataTextField = "Nome_Produto";
            ddl.DataValueField = "Cod_Produto";
            ddl.DataBind();
            con.fechaConexao();

            ddl.Items.Insert(0, "Selecione uma Pizza");

            lblPrecoUm.Text = ds.Tables["Produto"].DefaultView[0].Row["Valor_Venda"].ToString();
        }
    }

    public void carregandoDropDown2(DropDownList drop)
    {
        DropDownList ddl = (DropDownList)drop;
        if (IsPostBack)
        {
            Conexao con = new Conexao();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.conectar();
            con.command.CommandText = "select * from Produto as p inner join Categoria as c on c.codCategoria = 1 and p.codCategoria = 1";
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds, "Produto");
            ds.Tables["Produto"].DefaultView[0].ToString();
            ddl.DataSource = ds.Tables["Produto"].DefaultView;
            ddl.DataTextField = "Nome_Produto";
            ddl.DataValueField = "Cod_Produto";
            ddl.DataBind();
            con.fechaConexao();

            ddl.Items.Insert(0, "Selecione uma Pizza");
        }
    }

    /* TROCAS DE PIZZA NO DROPDOWN */
    
    protected void ddlPizzasInteiras_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet ds = (DataSet)Session["valor"];
        valor = Convert.ToInt32(ddlPizzasInteiras.SelectedValue);
        int valorFinal = valor - 1;
        if (ddlPizzasInteiras.SelectedItem.Selected)
        {
            lblPrecoUm.Text = "Preço";
        }
        else
        {
            carregandoDropDown2(ddlPizzasInteiras2);
            ListItem itemRemovido = ddlPizzasInteiras.Items.FindByValue(valor.ToString());
            ddlPizzasInteiras2.Items.Remove(itemRemovido);

            selecionado1 = Convert.ToDouble(ds.Tables[0].DefaultView[valorFinal].Row["Valor_Venda"]);
            if (ultimoValor == valor)
            {
                ddlPizzasInteiras2.SelectedIndex = 0;
            }
            else
            {

            }
            retornaPreco();
        }
    }

    protected void ddlPizzasInteiras2_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet ds = (DataSet)Session["valor"];
        valor2 = Convert.ToInt32(ddlPizzasInteiras2.SelectedValue);
        int valorFinal = valor2 - 1;
        if (valor2 == 0)
        {

        }
        else
        {
            selecionado2 = Convert.ToDouble(ds.Tables[0].DefaultView[valorFinal].Row["Valor_Venda"]);
            ultimoValor = Convert.ToInt32(ddlPizzasInteiras2.SelectedValue);
            retornaPreco();
        }
    }

    protected void ddlPizzasInteiras3_SelectedIndexChanged(object sender, EventArgs e)
    {
        Conexao con = new Conexao();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        con.conectar();
        con.command.CommandText = "select Valor_Venda from Produto as p inner join Categoria as c on c.CodCategoria = 1 and p.Cod_Produto =" + ddlPizzasInteiras3.SelectedValue;
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);
        selecionado3 = Convert.ToDouble(ds.Tables[0].DefaultView[0].Row["Valor_Venda"]);
        con.fechaConexao();

        retornaPreco2();
    }

    protected void ddlPizzasInteiras4_SelectedIndexChanged(object sender, EventArgs e)
    {
        Conexao con = new Conexao();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        con.conectar();
        con.command.CommandText = "select Valor_Venda from Produto as p inner join Categoria as c on c.CodCategoria = 1 and p.Cod_Produto =" + ddlPizzasInteiras4.SelectedValue;
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);
        selecionado4 = Convert.ToDouble(ds.Tables[0].DefaultView[0].Row["Valor_Venda"]);
        con.fechaConexao();

        retornaPreco2();
    }

    protected void ddlPizzasInteiras5_SelectedIndexChanged(object sender, EventArgs e)
    {
        Conexao con = new Conexao();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        con.conectar();
        con.command.CommandText = "select Valor_Venda from Produto as p inner join Categoria as c on c.CodCategoria = 1 and p.Cod_Produto =" + ddlPizzasInteiras5.SelectedValue;
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);
        selecionado5 = Convert.ToDouble(ds.Tables[0].DefaultView[0].Row["Valor_Venda"]);
        con.fechaConexao();

        retornaPreco3();
    }

    protected void ddlPizzasInteiras6_SelectedIndexChanged(object sender, EventArgs e)
    {
        Conexao con = new Conexao();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        con.conectar();
        con.command.CommandText = "select Valor_Venda from Produto as p inner join Categoria as c on c.CodCategoria = 1 and p.Cod_Produto =" + ddlPizzasInteiras6.SelectedValue;
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);
        selecionado6 = Convert.ToDouble(ds.Tables[0].DefaultView[0].Row["Valor_Venda"]);
        con.fechaConexao();

        retornaPreco3();
    }

    public void retornaPreco()
    {
        if (chkMeio.Checked)
        {
            try
            {
                precoAtual = Convert.ToDouble(lblPrecoUm.Text);
                if (precoAtual >= selecionado1 && precoAtual >= selecionado2)
                {
                    if (selecionado1 > selecionado2)
                    {
                        lblPrecoUm.Text = selecionado1.ToString();
                    }
                    else
                    {
                        lblPrecoUm.Text = selecionado2.ToString();
                    }
                }
                else if(precoAtual >= selecionado1 && precoAtual <= selecionado2)
                {
                    lblPrecoUm.Text = selecionado2.ToString();
                }
                else if (precoAtual >= selecionado2 && precoAtual <= selecionado1)
                {
                    lblPrecoUm.Text = selecionado1.ToString();
                }
            }
            catch (Exception ex)
            {
                if (selecionado1 > selecionado2)
                {
                    lblPrecoUm.Text = selecionado1.ToString();
                }
                else
                {
                    lblPrecoUm.Text = selecionado2.ToString();
                }
            }
        }
        else
        {
            lblPrecoUm.Text = selecionado1.ToString();
        }
    }

    public void retornaPreco2()
    {
        if (chkMeio2.Checked)
        {
            try
            {
                precoAtual2 = Convert.ToDouble(lblPrecoDois.Text);
                if (precoAtual2 >= selecionado3 && precoAtual2 >= selecionado4)
                {
                    if (selecionado3 > selecionado4)
                    {
                        lblPrecoDois.Text = selecionado3.ToString();
                    }
                    else
                    {
                        lblPrecoDois.Text = selecionado4.ToString();
                    }
                }
                else if (precoAtual2 >= selecionado3 && precoAtual2 <= selecionado4)
                {
                    lblPrecoDois.Text = selecionado4.ToString();
                }
                else if (precoAtual2 >= selecionado4 && precoAtual2 <= selecionado3)
                {
                    lblPrecoDois.Text = selecionado3.ToString();
                }
            }
            catch (Exception ex)
            {
                if (selecionado3 > selecionado4)
                {
                    lblPrecoDois.Text = selecionado3.ToString();
                }
                else
                {
                    lblPrecoDois.Text = selecionado4.ToString();
                }
            }
        }
        else
        {
            lblPrecoDois.Text = selecionado3.ToString();
        }
    }

    public void retornaPreco3()
    {
        if (chkMeio3.Checked)
        {
            try
            {
                precoAtual3 = Convert.ToDouble(lblPrecoTres.Text);
                if (precoAtual3 >= selecionado5 && precoAtual3 >= selecionado6)
                {
                    if (selecionado5 > selecionado6)
                    {
                        lblPrecoTres.Text = selecionado5.ToString();
                    }
                    else
                    {
                        lblPrecoTres.Text = selecionado6.ToString();
                    }
                }
                else if (precoAtual3 >= selecionado5 && precoAtual3 <= selecionado6)
                {
                    lblPrecoTres.Text = selecionado6.ToString();
                }
                else if (precoAtual3 >= selecionado6 && precoAtual3 <= selecionado5)
                {
                    lblPrecoTres.Text = selecionado5.ToString();
                }
            }
            catch (Exception ex)
            {
                if (selecionado5 > selecionado6)
                {
                    lblPrecoTres.Text = selecionado5.ToString();
                }
                else
                {
                    lblPrecoTres.Text = selecionado6.ToString();
                }
            }
        }
        else
        {
            lblPrecoTres.Text = selecionado5.ToString();
        }
    }

    protected void chkMeio_CheckedChanged(object sender, EventArgs e)
    {
        string pizzaSelecionada = ddlPizzasInteiras.SelectedItem.Value.ToString();
        if (pizzaSelecionada == "Selecione uma Pizza")
        {
            if (chkMeio.Checked)
            {
                ddlPizzasInteiras2.Visible = true;
            }
            else
            {
                ddlPizzasInteiras2.Visible = false;
                retornaPreco();
            }
        }
        else
        {
            Conexao con = new Conexao();
            con.conectar();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            SqlDataSource dSource = new SqlDataSource();
            dSource.SelectCommand = "select * from Produto as p inner join Categoria as c on c.codCategoria = 1 and p.codCategoria = 1";
            ddlPizzasInteiras.DataSource = dSource;
            con.fechaConexao();

            if (chkMeio.Checked)
            {
                ddlPizzasInteiras2.Visible = true;
            }
            else
            {
                ddlPizzasInteiras2.Visible = false;
                retornaPreco();
            }
        }
    }

    protected void chkMeio2_CheckedChanged(object sender, EventArgs e)
    {
        if (chkMeio2.Checked)
        {
            ddlPizzasInteiras4.Visible = true;
        }
        else
        {
            ddlPizzasInteiras4.Visible = false;
        }
        retornaPreco2();
    }

    protected void chkMeio3_CheckedChanged(object sender, EventArgs e)
    {
        if (chkMeio3.Checked)
        {
            ddlPizzasInteiras6.Visible = true;
        }
        else
        {
            ddlPizzasInteiras6.Visible = false;
        }
    }

    protected void chkMeio4_CheckedChanged(object sender, EventArgs e)
    {
        if (chkMeio4.Checked)
        {
            ddlPizzasInteiras8.Visible = true;
        }
        else
        {
            ddlPizzasInteiras8.Visible = false;
        }
    }

    protected void chkMeio5_CheckedChanged(object sender, EventArgs e)
    {
        if (chkMeio5.Checked)
        {
            ddlPizzasInteiras10.Visible = true;
        }
        else
        {
            ddlPizzasInteiras10.Visible = false;
        }
    }

    protected void btnEfetuarPedido_Click(object sender, EventArgs e)
    {
        pnlProdutosPedido.Visible = true;
        int valor;
        if (chkMeio.Checked)
        {
            lblPrimeiroSabor.Text = ddlPizzasInteiras.SelectedItem.ToString();
            lblSegundoSabor.Text = ddlPizzasInteiras2.SelectedItem.ToString();

            if (lblPrimeiroSabor.Text == lblSegundoSabor.Text)
            {
                lblSegundoSabor.Text = "";
            }

            lblPreco.Text = "Preço Total: R$ " + lblPrecoUm.Text;


            Response.Cookies["pizzas"].Value = lblPrimeiroSabor.Text + " / " + lblSegundoSabor.Text;
            Response.Cookies["pizzas"].Expires = DateTime.Now.AddDays(10);
        }
        else
        {
            lblPrimeiroSabor.Text = ddlPizzasInteiras.SelectedItem.ToString();
            lblSegundoSabor.Text = "";

            Conexao con = new Conexao();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.conectar();
            con.command.CommandText = "select Valor_Venda from Produto as p inner join Categoria as c on c.CodCategoria = 1 and p.Nome_Produto like '" + lblPrimeiroSabor.Text + "'";
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds);
            con.fechaConexao();

            valor = Convert.ToInt32(ds.Tables[0].DefaultView[0].Row["Valor_Venda"]);

            lblPreco.Text = "Preço Total: R$ " + valor.ToString();

            Response.Cookies["pizzas"].Value = lblPrimeiroSabor.Text;
            Response.Cookies["pizzas"].Expires = DateTime.Now.AddDays(10);
        }

        if (chkMeio.Checked && chkMeio2.Checked)
        {
            lblTerceiroSabor.Text = ddlPizzasInteiras3.SelectedItem.ToString();
            lblQuartoSabor.Text = ddlPizzasInteiras4.SelectedItem.ToString();

            if (lblTerceiroSabor.Text == lblQuartoSabor.Text)
            {
                lblQuartoSabor.Text = "";
            }

            lblPreco.Text = "Preço Total: R$ " + lblPrecoUm.Text + lblPrecoDois.Text;


            Response.Cookies["segundaPizza"].Value = lblTerceiroSabor.Text + " / " + lblQuartoSabor.Text;
            Response.Cookies["segundaPizza"].Expires = DateTime.Now.AddDays(10);
        }
    }

    protected void RbtnList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RbtnList1.SelectedItem.Value == "1")
        {
            txtEnderecoPedido.ReadOnly = true;
            txtEnderecoPedido.Style.Add("background", "#ccc");
            txtEnderecoPedido.Style.Add("color", "#666");
        }
        else if (RbtnList1.SelectedItem.Value == "2")
        {
            txtEnderecoPedido.ReadOnly = false;
            txtEnderecoPedido.Style.Add("background", "#fff");
            txtEnderecoPedido.Style.Add("color", "#ef6f53");
            txtEnderecoPedido.Text = "";
        }
    }
}