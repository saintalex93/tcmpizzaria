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
    public double precoAtual;
    string codCli;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["cod"] != null)
        {
            if (Request.Cookies["cod"].Value == "0")
            {
                Response.Write("<script>alert('Você deve estar logado para acessar esta página')</script>");
                Response.Write("<script>history.go(-1)</script>");
            }
            else
            {
                codCli = Request.Cookies["cod"].Value;
                if (Request.Cookies["pizzas"] == null)
                {
                    Response.Cookies["pizzas"].Value = "1";
                }
                else
                {
                    if (!IsPostBack)
                    {
                        ddlPizzasInteiras.SelectedValue = Request.Cookies["pizzas"].Value;
                    }
                }
            }
        }
        else
        {
            Response.Write("<script>alert('Você deve estar logado para acessar esta página')</script>");
            Response.Write("<script>history.go(-1)</script>");
        }        

        txtObservacoes.Attributes.Add("placeholder", "Ex: Pizza Mussarela sem cebola");

        Conexao con2 = new Conexao();
        SqlDataAdapter dAdapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();

        con2.conectar();
        con2.command.CommandText = "select Valor_Venda from Produto where Categoria=1 and Cod_Produto=" + Convert.ToInt32(Request.Cookies["pizzas"].Value);
        dAdapter2.SelectCommand = con2.command;
        dAdapter2.Fill(ds2);
        selecionado1 = Convert.ToDouble(ds2.Tables[0].DefaultView[0].Row["Valor_Venda"]);
        con2.fechaConexao();

        Conexao con = new Conexao();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        con.conectar();
        con.command.CommandText = "select Endereco_Cliente, Numero_Residencia, Bairro_Cliente, Numero_Apartamento from Cliente where Cod_Cliente="+ codCli;
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);
        string endereco = ds.Tables[0].DefaultView[0].Row["Endereco_Cliente"].ToString();
        string numero = ds.Tables[0].DefaultView[0].Row["Numero_Residencia"].ToString();
        string bairro = ds.Tables[0].DefaultView[0].Row["Bairro_Cliente"].ToString();
        string numApart = ds.Tables[0].DefaultView[0].Row["Numero_Apartamento"].ToString();
        con.fechaConexao();

        if (numApart != "")
        {
            txtEnderecoPedido.Text = endereco + ", nº " + numero + " - " + bairro + ", Apt. " + numApart;
        }
        else
        {
            txtEnderecoPedido.Text = endereco + ", nº " + numero + " - " + bairro;
        }
    }

    //FIM LOAD DA PÁGINA

    protected void ddlPizzasInteiras_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Conexao con = new Conexao();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.conectar();
            con.command.CommandText = "select * from Produto where Categoria=1";
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds, "Produto");
            ds.Tables["Produto"].DefaultView[0].ToString();
            ddlPizzasInteiras.DataSource = ds.Tables["Produto"].DefaultView;
            ddlPizzasInteiras.DataTextField = "Nome_Produto";
            ddlPizzasInteiras.DataValueField = "Cod_Produto";
            ddlPizzasInteiras.DataBind();
            con.fechaConexao();
        }
    }

    protected void ddlPizzasInteiras_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Cookies["pizzas"].Value = ddlPizzasInteiras.SelectedValue.ToString();
        Response.Cookies["pizzas"].Expires = DateTime.Now.AddDays(10);

        Conexao con = new Conexao();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        con.conectar();
        con.command.CommandText = "select Valor_Venda from Produto where Categoria=1 and Cod_Produto=" + ddlPizzasInteiras.SelectedValue;
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);
        selecionado1 = Convert.ToDouble(ds.Tables[0].DefaultView[0].Row["Valor_Venda"]);
        con.fechaConexao();

        retornaPreco();
    }

    protected void ddlPizzasInteiras2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Conexao con = new Conexao();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        con.conectar();
        con.command.CommandText = "select Valor_Venda from Produto where Categoria=1 and Cod_Produto=" + ddlPizzasInteiras2.SelectedValue;
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);
        con.fechaConexao();
        selecionado2 = Convert.ToDouble(ds.Tables[0].DefaultView[0].Row["Valor_Venda"]);

        retornaPreco();
    }

    public void retornaPreco()
    {
        if (chkMeio.Checked)
        {
            try
            {
                precoAtual = Convert.ToDouble(lblIndex.Text);
                if (precoAtual >= selecionado1 && precoAtual >= selecionado2)
                {
                    if (selecionado1 > selecionado2)
                    {
                        lblIndex.Text = selecionado1.ToString();
                    }
                    else
                    {
                        lblIndex.Text = selecionado2.ToString();
                    }
                }
                else if(precoAtual >= selecionado1 && precoAtual <= selecionado2)
                {
                    lblIndex.Text = selecionado2.ToString();
                }
                else if (precoAtual >= selecionado2 && precoAtual <= selecionado1)
                {
                    lblIndex.Text = selecionado1.ToString();
                }
            }
            catch (Exception ex)
            {
                if (selecionado1 > selecionado2)
                {
                    lblIndex.Text = selecionado1.ToString();
                }
                else
                {
                    lblIndex.Text = selecionado2.ToString();
                }
            }
        }
        else
        {
            lblIndex.Text = selecionado1.ToString();
        }


        //try
        //{
        //    precoAtual = Convert.ToDouble(lblIndex.Text);
        //}
        //catch(Exception ex){
        //    if (precoAtual > selecionado1)
        //    {

        //    }
        //    else
        //    {
        //        if (chkMeio.Checked)
        //        {
        //            if (selecionado2 > selecionado1)
        //            {
        //                lblIndex.Text = selecionado2.ToString();
        //            }
        //            else
        //            {
        //                lblIndex.Text = selecionado1.ToString();
        //            }
        //        }
        //        else
        //        {
        //            lblIndex.Text = selecionado1.ToString();
        //        }
        //    }
        //}
    }

    protected void ddlPizzasInteiras2_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Conexao con = new Conexao();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.conectar();
            con.command.CommandText = "select * from Produto where Categoria=1";
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds, "Produto");
            ds.Tables["Produto"].DefaultView[0].ToString();
            ddlPizzasInteiras2.DataSource = ds.Tables["Produto"].DefaultView;
            ddlPizzasInteiras2.DataTextField = "Nome_Produto";
            ddlPizzasInteiras2.DataValueField = "Cod_Produto";
            ddlPizzasInteiras2.DataBind();
            con.fechaConexao();
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
        else if(RbtnList1.SelectedItem.Value == "2")
        {
            txtEnderecoPedido.ReadOnly = false;
            txtEnderecoPedido.Style.Add("background", "#fff");
            txtEnderecoPedido.Style.Add("color", "#ef6f53");
        }
    }
    protected void chkMeio_CheckedChanged(object sender, EventArgs e)
    {
        if (chkMeio.Checked)
        {
            ddlPizzasInteiras2.Visible = true;
        }
        else
        {
            ddlPizzasInteiras2.Visible = false;
        }
    }
    

    protected void btnEfetuarPedido_Click(object sender, EventArgs e)
    {
        //Conexao con = new Conexao();
        //SqlDataAdapter dAdapter = new SqlDataAdapter();
        //DataSet ds = new DataSet();

        //con.conectar();

        //con.command.CommandText = "insert into Pedido(Data,Hora,Valor,Cod_Cliente) values (@data,@hora,@valor,@codCli)";
        //con.command.Parameters.Add("@data", SqlDbType.Date).Value = DateTime.Today;
        //con.command.Parameters.Add("@hora", SqlDbType.VarChar).Value = DateTime.Now.ToString();
        //con.command.Parameters.Add("@valor", SqlDbType.Decimal).Value = lblIndex.Text;
        //con.fechaConexao();
    }
}
