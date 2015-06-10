using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_pedir2 : System.Web.UI.Page
{
    int codCli;
    static string endereco = "";
    static string numero = "";
    static string bairro = "";
    static string numApart = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["cod"] == null || Request.Cookies["cod"].Value == "0")
        {
            Response.Write("<script>alert('Você deve estar logado para acessar esta página.')</script>");
            Response.Write("<script>window.location.assign('" + Request.ApplicationPath + "/index.aspx');</script>");
        }
        else
        {
            txtObservacoes.Attributes.Add("placeholder", "Ex: Pizza Mussarela sem cebola");
            txtValor.Attributes.Add("placeholder", "Exemplo: 50,00");

            codCli = Convert.ToInt32(Request.Cookies["cod"].Value);

            //Conexão que pega o endereço do usuário logado no momento.
            if (!IsPostBack)
            {
                Conexao con = new Conexao();
                SqlDataAdapter dAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                con.conectar();
                con.command.CommandText = "select Endereco_Cliente, Numero_Residencia, Bairro_Cliente, Numero_Apartamento from Cliente where Cod_Cliente =" + codCli;
                dAdapter.SelectCommand = con.command;
                dAdapter.Fill(ds);
                endereco = ds.Tables[0].DefaultView[0].Row["Endereco_Cliente"].ToString();
                numero = ds.Tables[0].DefaultView[0].Row["Numero_Residencia"].ToString();
                bairro = ds.Tables[0].DefaultView[0].Row["Bairro_Cliente"].ToString();
                numApart = ds.Tables[0].DefaultView[0].Row["Numero_Apartamento"].ToString();
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

            //Conexão que cria um DataSet com os valores de cada produto e coloca em uma sessão.
            Conexao con2 = new Conexao();
            SqlDataAdapter dAdapter2 = new SqlDataAdapter();
            DataSet ds2 = new DataSet();

            con2.conectar();
            con2.command.CommandText = "select Cod_Produto,Nome_Produto,Valor_Venda from Produto as p inner join Categoria as c on c.NomeCategoria = 'Pizza'";
            dAdapter2.SelectCommand = con2.command;
            dAdapter2.Fill(ds2);
            Session["valorPizza"] = ds2;
            Session.Timeout = 60;
            con2.fechaConexao();

            Conexao con3 = new Conexao();
            SqlDataAdapter dAdapter3 = new SqlDataAdapter();
            DataSet ds3 = new DataSet();

            con3.conectar();
            con3.command.CommandText = "select Cod_Produto,Nome_Produto,Valor_Venda from Produto as p inner join Categoria as c on c.NomeCategoria = 'Pizza'";
            dAdapter3.SelectCommand = con3.command;
            dAdapter3.Fill(ds3);
            Session["valorBebida"] = ds3;
            Session.Timeout = 60;
            con3.fechaConexao();

            if (!IsPostBack && Session["carrinho"] == null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Produtos", System.Type.GetType("System.String"));
                dt.Columns.Add("Quantidade", System.Type.GetType("System.String"));
                dt.Columns.Add("Valor", System.Type.GetType("System.String"));

                Session["carrinho"] = dt;
                Session.Timeout = 60;
            }
            else if (Session["carrinho"] != null)
            {
                DataTable dt = (DataTable)Session["carrinho"];
                gdCarrinho.DataSource = dt;
                gdCarrinho.DataBind();
                int numLinhas = gdCarrinho.Rows.Count;
                if (!IsPostBack && numLinhas >= 1)
                {
                    pnlCarrinhoPedido.Visible = true;
                }
                double precoTotal = 0;

                foreach (GridViewRow row in gdCarrinho.Rows)
                {
                    string celulaPreco = row.Cells[2].Text;
                    precoTotal += Convert.ToDouble(celulaPreco.Substring(2));
                    lblPrecoTotal.Text = precoTotal.ToString("C");
                    lblPrecoDoPedido.Text = precoTotal.ToString("C");
                }
            }
        }
    }
    //Fim Page_Load

    /* MÉTODO QUE TRAZ AS PIZZAS DO BANCO PARA POPULAR OS DROPDOWNS */
    protected void carregandoDropDown(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;
        if (!IsPostBack)
        {
            Conexao con = new Conexao();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.conectar();
            con.command.CommandText = "select * from Produto as p inner join ProdutoCategoria as pc on pc.CodCategoria = 1 and p.Cod_Produto = pc.CodProduto";
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds, "Produto");
            ds.Tables["Produto"].DefaultView.ToString();
            ddl.DataSource = ds.Tables["Produto"].DefaultView;
            ddl.DataTextField = "Nome_Produto";
            ddl.DataValueField = "Cod_Produto";
            ddl.DataBind();
            con.fechaConexao();

            ddl.Items.Insert(0, "Selecione uma Pizza");
        }
    }
    /* FIM CARREGA DROPDOWN */

    /* MÉTODO QUE ADICIONA MAIS DROPDOWNS DE PIZZAS PARA ESCOLHA */
    protected void adicionarPizza(object sender, EventArgs e)
     {
         foreach (Control ctr in pnlPedindoPizzas.Controls)
         {
             if (ctr is Panel && ctr.Visible == false)
             {
                 ctr.Visible = true;
                 break;
             }
         }
    }
    /* FIM ADICIONAR PIZZAS */

    /* REMOVER PIZZAS */
    protected void removerPizza(object sender, EventArgs e)
    {
        foreach (Control ctr in pnlPedindoPizzas.Controls)
        {
            if (ctr is Panel && ctr.Visible == true)  
            {
                //Variável contendo o ID do controle a ser encontrado.
                string pizza = "pnlPizzaDin";

                if (ctr.ID.Contains(pizza))
                {
                    ctr.Visible = false;
                    break;
                }
            }
        }
    }
    /* FIM REMOVER PIZZAS */

    // MÉTODO DOS CHECKBOXES
    protected void chkTroca(object sender, EventArgs e)
    {
        CheckBox chk = (CheckBox)sender;
        foreach (Control ctr in chk.Parent.Controls)
        {
            if (ctr is DropDownList)
            {
                if (ctr.ID.Contains("2") || ctr.ID.Contains("4") || ctr.ID.Contains("6") || ctr.ID.Contains("8") || ctr.ID.Contains("0"))
                {
                    if (ctr.Visible == false)
                    {
                        ctr.Visible = true;
                    }
                    else
                    {
                        ctr.Visible = false;
                    }
                }
            }
        }
    }
    // FIM MÉTODO DOS CHECKBOXES

    public void carregandoDropDown2(DropDownList drop)
    {
        DropDownList ddl = (DropDownList)drop;
        if (IsPostBack)
        {
            Conexao con = new Conexao();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.conectar();
            con.command.CommandText = "select * from Produto as p inner join ProdutoCategoria as pc on pc.CodCategoria = 1 and p.Cod_Produto = pc.CodProduto";
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

    //Método que troca as pizzas dos primeiros dropdowns de cada painel
    protected void trocaPizza(object sender, EventArgs e)
    {
        int valor = 0;
        DropDownList drop = (DropDownList)sender;
        DropDownList drop2;
        DataSet ds = (DataSet)Session["valorPizza"];
        if (drop.SelectedIndex != 0)
        {
            valor = Convert.ToInt32(drop.SelectedValue);
        }
        int ultimoValor;
        string preco = "";

        foreach(Control ctr in drop.Parent.Controls)
        {
            if (ctr is DropDownList)
            {
                if (ctr.ID.Contains("2") || ctr.ID.Contains("4") || ctr.ID.Contains("6") || ctr.ID.Contains("8") || ctr.ID.Contains("0"))
                {
                    drop2 = (DropDownList)ctr;
                    if (drop2.SelectedIndex != 0)
                    {
                        ultimoValor = Convert.ToInt32(drop2.SelectedValue);
                        drop2.SelectedValue = ultimoValor.ToString();
                    }
                    carregandoDropDown2(drop2);
                    ListItem itemRemovido = drop.Items.FindByValue(valor.ToString());
                    drop2.Items.Remove(itemRemovido);
                }
            }
        }
        foreach (Control ctr3 in drop.Parent.Controls)
        {
            if (ctr3 is CheckBox)
            {
                CheckBox chk = (CheckBox)ctr3;
                preco = retornaPreco(drop, chk);
            }
        }
        foreach (Control ctr4 in drop.Parent.Controls)
        {
            if (ctr4 is Label)
            {
                if (ctr4.ID.Contains("lblPreco"))
                {
                    Label lbl = (Label)ctr4;
                    double preco2 = Convert.ToDouble(preco);
                    preco = preco2.ToString("C");
                    lbl.Text = preco;
                }
            }
        }
    }
    //FIM Método que troca as pizzas dos primeiros dropdowns de cada painel

    //Método que troca as pizzas dos dropdowns "Meio a Meio"
    protected void trocaPizza2(object sender,EventArgs e)
    {
        DropDownList drop2 = (DropDownList)sender;
        DropDownList drop1 = new DropDownList();
        Label lbl = new Label();
        CheckBox chk = new CheckBox();
        foreach (Control ctr in drop2.Parent.Controls)
        {
            if (ctr is CheckBox)
            {
                if (ctr.ID.Contains("chkMeio"))
                {
                    chk = (CheckBox)ctr;
                }
            }
            if (ctr is DropDownList)
            {
                if (ctr.ID.Contains("1") || ctr.ID.Contains("3") || ctr.ID.Contains("5") || ctr.ID.Contains("7") || ctr.ID.Contains("9"))
                {
                    drop1 = (DropDownList)ctr;
                }
            }
            if (ctr is Label)
            {
                if (ctr.ID.Contains("lblPreco"))
                {
                    lbl = (Label)ctr;
                }
            }
        }
        string preco = retornaPreco(drop1,chk);
        double preco2 = Convert.ToDouble(preco);
        preco = preco2.ToString("C");
        lbl.Text = preco;
    }
    //FIM Método que troca as pizzas dos dropdowns "Meio a Meio"

    //Método que retorna o preço da pizza do dropdown(quando for meio a meio, a pizza mais cara entre as duas)
    public string retornaPreco(DropDownList drop,CheckBox chk)
    {
        DataSet ds = (DataSet)Session["valorPizza"];
        Label lbl = new Label();
        double precoAtual;
        double selecionado1 = 0;
        double selecionado2 = 0;
        int quantidade = 1;

        //Verificando se algum sabor foi selecionado no Dropdown
        if (drop.SelectedIndex != 0)
        {
            selecionado1 = Convert.ToDouble(ds.Tables[0].DefaultView[Convert.ToInt32(drop.SelectedValue)].Row["Valor_Venda"]);
        }


        if (chk.Checked)
        {
            //Pegando o valor que está selecionado no segundo dropdown
            foreach (Control ctr in drop.Parent.Controls)
            {
                if (ctr is DropDownList)
                {
                    if (ctr.ID.Contains("2") || ctr.ID.Contains("4") || ctr.ID.Contains("6") || ctr.ID.Contains("8") || ctr.ID.Contains("0"))
                    {
                        DropDownList drop2 = (DropDownList)ctr;
                        if (drop2.SelectedIndex != 0)
                        {
                            selecionado2 = Convert.ToDouble(ds.Tables[0].DefaultView[Convert.ToInt32(drop2.SelectedValue) -1].Row["Valor_Venda"]);
                        }
                    }
                }
                if (ctr is TextBox && ctr.ID.Contains("txtQtd"))
                {
                    TextBox txt = (TextBox)ctr;
                    try
                    {
                        int qtd = Convert.ToInt32(txt.Text);
                        if (qtd >= 1)
                        {
                            quantidade = qtd;
                        }
                    }
                    catch (Exception ex)
                    {
                        quantidade = 1;
                    }
                }
            }
            
            //Executando a lógica para retornar o preço da pizza mais cara
            try
            {
                precoAtual = Convert.ToDouble(lbl.Text);
                if (precoAtual >= selecionado1 && precoAtual >= selecionado2)
                {
                    if (selecionado1 > selecionado2)
                    {
                        return (selecionado1 * quantidade).ToString();
                    }
                    else
                    {
                        return (selecionado2 * quantidade).ToString();
                    }
                }
                else if (precoAtual >= selecionado1 && precoAtual <= selecionado2)
                {
                    return (selecionado2 * quantidade).ToString();
                }
                else if (precoAtual >= selecionado2 && precoAtual <= selecionado1)
                {
                    return (selecionado1 * quantidade).ToString();
                }
                return "";
            }
            catch (Exception ex)
            {
                if (selecionado1 > selecionado2)
                {
                    return (selecionado1 * quantidade).ToString();
                }
                else
                {
                    return (selecionado2 * quantidade).ToString();
                }
            }
        }
        else
        {
            foreach (Control ctr in drop.Parent.Controls)
            {
                if (ctr is TextBox && ctr.ID.Contains("txtQtd"))
                {
                    TextBox txt = (TextBox)ctr;
                    try
                    {
                        int qtd = Convert.ToInt32(txt.Text);
                        if (qtd >= 1)
                        {
                            quantidade = qtd;
                        }
                    }
                    catch(Exception ex)
                    {
                        quantidade = 1;
                    }
                }
            }
            return (selecionado1 * quantidade).ToString();
        }
    }
    /* FIM retorna preço */

    //Método para trocar o preço de acordo com a quantidade
    protected void trocandoQtd(object sender, EventArgs e)
    {
        TextBox txt = (TextBox)sender;
        DropDownList drop = new DropDownList();
        CheckBox chk = new CheckBox();
        Label lbl = new Label();
        foreach (Control ctr in txt.Parent.Controls)
        {
            if (ctr is DropDownList)
            {
                if (ctr.ID.Contains("1") || ctr.ID.Contains("3") || ctr.ID.Contains("5") || ctr.ID.Contains("7") || ctr.ID.Contains("9"))
                {
                    drop = (DropDownList)ctr;
                }
            }
            if (ctr is CheckBox)
            {
                chk = (CheckBox)ctr;
            }
            if (ctr is Label && ctr.ID.Contains("lblPreco"))
            {
                lbl = (Label)ctr;
            }
        }
        string preco = retornaPreco(drop, chk);
        double preco1 = Convert.ToDouble(preco);
        preco = preco1.ToString("C");
        lbl.Text = preco;
    }
    //FIM Método para trocar o preço de acordo com a quantidade


    //Carregando Bebidas no Dropdown
    protected void carregandoBebidas(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;
        if (!IsPostBack)
        {
            Conexao con = new Conexao();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.conectar();
            con.command.CommandText = "select * from Produto as p inner join ProdutoCategoria as pc on pc.CodCategoria = 3 and p.Cod_Produto = pc.CodProduto";
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds, "Bebidas");
            ds.Tables["Bebidas"].DefaultView.ToString();
            ddl.DataSource = ds.Tables["Bebidas"].DefaultView;
            ddl.DataTextField = "Nome_Produto";
            ddl.DataValueField = "Cod_Produto";
            ddl.DataBind();
            con.fechaConexao();

            ddl.Items.Insert(0, "Selecione uma Bebida");
        }
    }
    //FIM CARREGA BEBIDAS

    // MÉTODO QUE ADICIONA MAIS DROPDOWNS DE BEBIDAS PARA ESCOLHA
    protected void adicionarBebida(object sender, EventArgs e)
    {
        foreach (Control ctr in pnlPedindoBebidas.Controls)
        {
            if (ctr is Panel && ctr.Visible == false)
            {
                ctr.Visible = true;
                break;
            }
        }
    }
    // FIM ADICIONAR BEBIDAS

    // REMOVER BEBIDAS
    protected void removerBebida(object sender, EventArgs e)
    {
        foreach (Control ctr in pnlPedindoBebidas.Controls)
        {
            if (ctr is Panel && ctr.Visible == true)
            {
                string pizza = "pnlBebidaDin";

                if (ctr.ID.Contains(pizza))
                {
                    ctr.Visible = false;
                    break;
                }
            }
        }
    }
    // FIM REMOVER BEBIDAS

    protected void trocaBebida(object sender, EventArgs e)
    {
        DropDownList drop = (DropDownList)sender;
        foreach (Control ctr in drop.Parent.Controls)
        {
            if (ctr is Label)
            {
                if (ctr.ID.Contains("lblPrecoBebida"))
                {
                    Label lbl = (Label)ctr;
                    string preco = retornaPrecoBebida(drop);
                    double preco1 = Convert.ToDouble(preco);
                    preco = preco1.ToString("C");
                    lbl.Text = preco;
                }
            }
        }
    }

    public string retornaPrecoBebida(DropDownList drop)
    {
        DataSet ds = (DataSet)Session["valorBebida"];
        double selecionado = 0;
        int qtd = 1;

        foreach (Control ctr in drop.Parent.Controls)
        {
            if (ctr is TextBox && ctr.ID.Contains("txtQtd"))
            {
                TextBox txt = (TextBox)ctr;
                qtd = Convert.ToInt32(txt.Text);
            }
        }

        if (drop.SelectedIndex != 0)
        {
            selecionado = Convert.ToDouble(ds.Tables[0].DefaultView[Convert.ToInt32(drop.SelectedValue)].Row["Valor_Venda"]);
            return (selecionado * qtd).ToString();
        }
        else
        {
            return "R$ 00,00";
        }
    }

    protected void trocandoQtdBebida(object sender, EventArgs e)
    {
        TextBox txt = (TextBox)sender;
        DropDownList drop = new DropDownList();
        Label lbl = new Label();

        foreach (Control ctr in txt.Parent.Controls)
        {
            if (ctr is DropDownList)
            {
                drop = (DropDownList)ctr;
            }
            if (ctr is Label && ctr.ID.Contains("lblPrecoBebida"))
            {
                lbl = (Label)ctr;
            }
        }
        string preco = retornaPrecoBebida(drop);
        double preco1 = Convert.ToDouble(preco);
        preco = preco1.ToString("C");
        lbl.Text = preco;
    }


    //Método para adicionar pizzas no carrinho
    protected void AdicionarProdutosCarrinho(object sender, EventArgs e)
    {
        txtTroco.Text = "R$ 00,00";
        DataTable dt = (DataTable)Session["carrinho"];
        DataSet ds = (DataSet)Session["valorPizza"];

        DropDownList drop = new DropDownList();
        DropDownList drop2 = new DropDownList();
        Label lbl = new Label();
        TextBox txt = new TextBox();

        Button btn = (Button)sender;
        foreach (Control ctr in btn.Parent.Controls)
        {
            //Se for o painel de pizzas
            if (ctr.Parent.ID.Contains("pnlPedindoPizzas"))
            {
                //Procurando controles que sejam painéis e estejam vísíveis ao usuário
                if (ctr is Panel && ctr.Visible == true)
                {
                    //Varrendo os controles de cada painel
                    foreach (Control ctr2 in ctr.Controls)
                    {
                        if (ctr2 is CheckBox)
                        {
                            CheckBox chk = (CheckBox)ctr2;
                            int selecionado = 0;
                            int selecionado2 = 0;
                            string nome = "";
                            string nome2 = "";
                            string preco = "";
                            string quantidade = "";
                            int contadorVolta = 1;
                            int contadorPainel = 0;
                            //Se a pizza não for meio a meio
                            if (!chk.Checked)
                            {
                                foreach (Control ctr3 in chk.Parent.Controls)
                                {
                                    if (ctr3 is DropDownList)
                                    {
                                        if (ctr3.ID.Contains("1") || ctr3.ID.Contains("3") || ctr3.ID.Contains("5") || ctr3.ID.Contains("7") || ctr3.ID.Contains("9"))
                                        {
                                            drop = (DropDownList)ctr3;
                                            if (drop.SelectedItem.Value == "Selecione uma Pizza")
                                            {
                                                ScriptManager.RegisterStartupScript(Page, GetType(), "ScriptManager1", "alert('Selecione uma pizza, por favor !');", true);
                                                if (dt.Rows.Count <= 0)
                                                {
                                                    pnlCarrinhoPedido.Visible = false;
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                selecionado = Convert.ToInt32(drop.SelectedItem.Value);
                                                nome = ds.Tables[0].DefaultView[selecionado].Row["Nome_Produto"].ToString();
                                            }
                                            contadorPainel++;
                                        }
                                    }
                                    else if (ctr3 is TextBox && ctr3.ID.Contains("txtQtd"))
                                    {
                                        txt = (TextBox)ctr3;
                                        quantidade = txt.Text;
                                    }
                                    else if (ctr3 is Label && ctr3.ID.Contains("lblPreco"))
                                    {
                                        lbl = (Label)ctr3;
                                        preco = lbl.Text;
                                        pnlCarrinhoPedido.Visible = true;
                                    }

                                    if (pnlCarrinhoPedido.Visible == true && nome != "" && preco != "")
                                    {
                                        int contadorRepetido = 0;
                                        int numLinhas = dt.Rows.Count;
                                        if (numLinhas >= 1)
                                        {
                                            for (int i = numLinhas - 1; i >= 0; i--)
                                            {
                                                DataRow linha2 = dt.Rows[i];
                                                if (linha2["Produtos"].ToString() == nome && contadorVolta <= contadorPainel)
                                                {
                                                    double valorFinal = 0;
                                                    int qtd = Convert.ToInt32(linha2["Quantidade"]) + Convert.ToInt32(quantidade);
                                                    double valor = Convert.ToDouble(preco.Substring(2).Trim()) / Convert.ToInt32(quantidade);
                                                    valorFinal += valor * qtd;
                                                    linha2["Quantidade"] = qtd;
                                                    linha2["Valor"] = valorFinal.ToString("C");
                                                    contadorVolta++;
                                                    contadorRepetido++;
                                                    break;
                                                }
                                            }
                                        }
                                        //Se for a primeira vez que ele está adicionando pizzas
                                        else if (numLinhas == 0)
                                        {
                                            DataRow linha = dt.NewRow();
                                            linha["Produtos"] = nome;
                                            linha["Quantidade"] = quantidade;
                                            linha["Valor"] = preco;
                                            dt.Rows.Add(linha);
                                            contadorVolta++;
                                        }
                                        //Se não houve repetição, e se não é mais a primeira pizza que o usuário tenta adicionar
                                        if (contadorRepetido == 0 && contadorVolta >= 1 && numLinhas >= 1)
                                        {
                                            DataRow linha = dt.NewRow();
                                            linha["Produtos"] = nome;
                                            linha["Quantidade"] = quantidade;
                                            linha["Valor"] = preco;
                                            dt.Rows.Add(linha);
                                            contadorVolta++;
                                        }

                                        Session["carrinho"] = dt;

                                        gdCarrinho.DataSource = dt;
                                        gdCarrinho.DataBind();

                                        double precoTotal = 0;
                                        foreach (GridViewRow row in gdCarrinho.Rows)
                                        {
                                            string teste = row.Cells[2].Text;
                                            precoTotal += Convert.ToDouble(teste.Substring(2));
                                            lblPrecoTotal.Text = precoTotal.ToString("C");
                                            lblPrecoDoPedido.Text = precoTotal.ToString("C");
                                            txtValor.Text = precoTotal.ToString("C");
                                        }
                                        break;
                                    }
                                }
                            }
                            //Se a pizza FOR meio a meio
                            else
                            {
                                foreach (Control ctr3 in chk.Parent.Controls)
                                {
                                    if (ctr3 is DropDownList)
                                    {
                                        if (ctr3.ID.Contains("1") || ctr3.ID.Contains("3") || ctr3.ID.Contains("5") || ctr3.ID.Contains("7") || ctr3.ID.Contains("9"))
                                        {
                                            drop = (DropDownList)ctr3;
                                            if (drop.SelectedItem.Value == "Selecione uma Pizza")
                                            {
                                                ScriptManager.RegisterStartupScript(Page, GetType(), "ScriptManager1", "alert('Selecione uma pizza, por favor !');", true);
                                                if (dt.Rows.Count <= 0)
                                                {
                                                    pnlCarrinhoPedido.Visible = false;
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                selecionado = Convert.ToInt32(drop.SelectedItem.Value);
                                                nome = ds.Tables[0].DefaultView[selecionado].Row["Nome_Produto"].ToString();
                                            }
                                            contadorPainel++;
                                        }
                                        else
                                        {
                                            drop = (DropDownList)ctr3;
                                            selecionado2 = Convert.ToInt32(drop.SelectedItem.Value);
                                            nome2 = ds.Tables[0].DefaultView[selecionado2].Row["Nome_Produto"].ToString();
                                        }
                                    }
                                    else if (ctr3 is TextBox && ctr3.ID.Contains("txtQtd"))
                                    {
                                        txt = (TextBox)ctr3;
                                        quantidade = txt.Text;
                                    }
                                    else if (ctr3 is Label && ctr3.ID.Contains("lblPreco"))
                                    {
                                        lbl = (Label)ctr3;
                                        preco = lbl.Text;
                                        pnlCarrinhoPedido.Visible = true;
                                    }

                                    if (pnlCarrinhoPedido.Visible == true && nome != "" && preco != "")
                                    {
                                        int contadorRepetido = 0;
                                        int numLinhas = dt.Rows.Count;
                                        string nomePizzaMeio = nome + " / " + nome2;
                                        string nomePizzaInvertido = nome2 + " / " + nome;
                                        if (numLinhas >= 1)
                                        {
                                            for (int i = numLinhas - 1; i >= 0; i--)
                                            {
                                                DataRow linha = dt.Rows[i];
                                                if (linha["Produtos"].ToString() == nomePizzaMeio || linha["Produtos"].ToString() == nomePizzaInvertido && contadorVolta <= contadorPainel)
                                                {
                                                    double valorFinal = 0;
                                                    int qtd = Convert.ToInt32(linha["Quantidade"]) + Convert.ToInt32(quantidade);
                                                    double valor = Convert.ToDouble(preco.Substring(2).Trim()) / Convert.ToInt32(quantidade);
                                                    valorFinal += valor * qtd;
                                                    linha["Quantidade"] = qtd;
                                                    linha["Valor"] = valorFinal.ToString("C");
                                                    contadorVolta++;
                                                    contadorRepetido++;
                                                    break;
                                                }
                                            }
                                        }
                                        //Se for a primeira vez que ele está adicionando pizzas
                                        else if (numLinhas == 0)
                                        {
                                            DataRow linha = dt.NewRow();
                                            linha["Produtos"] = nome + " / " + nome2;
                                            linha["Quantidade"] = quantidade;
                                            linha["Valor"] = preco;
                                            dt.Rows.Add(linha);
                                            contadorVolta++;
                                        }
                                        //Se não houve repetição, e se não é mais a primeira pizza que o usuário tenta adicionar
                                        if (contadorRepetido == 0 && contadorVolta >= 1 && numLinhas >= 1)
                                        {
                                            DataRow linha = dt.NewRow();
                                            linha["Produtos"] = nome + " / " + nome2;
                                            linha["Quantidade"] = quantidade;
                                            linha["Valor"] = preco;
                                            dt.Rows.Add(linha);
                                            contadorVolta++;
                                        }

                                        Session["carrinho"] = dt;

                                        gdCarrinho.DataSource = dt;
                                        gdCarrinho.DataBind();

                                        double precoTotal = 0;
                                        foreach (GridViewRow row in gdCarrinho.Rows)
                                        {
                                            string celula = row.Cells[2].Text;
                                            precoTotal += Convert.ToDouble(celula.Substring(2));
                                            lblPrecoTotal.Text = precoTotal.ToString("C");
                                            lblPrecoDoPedido.Text = precoTotal.ToString("C");
                                            txtValor.Text = precoTotal.ToString("C");
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //Se for o painel de bebidas
            else if (ctr.Parent.ID.Contains("pnlPedindoBebidas"))
            {
                string nomeBebida = "";
                string precoBebida = "";
                string quantidadeBebida = "";
                int contadorVolta = 1;
                int contadorPainel = 0;

                Label lblBebidaPrec = new Label();
                if (ctr is Panel && ctr.Visible == true)
                {
                    foreach (Control ctr2 in ctr.Controls)
                    {
                        if (ctr2 is DropDownList)
                        {
                            DropDownList dropBebida = (DropDownList)ctr2;
                            if (dropBebida.SelectedIndex != 0)
                            {
                                nomeBebida = dropBebida.SelectedItem.Text;
                            }
                            else
                            {
                                ScriptManager.RegisterStartupScript(Page, GetType(), "ScriptManager1", "alert('Selecione uma bebida, por favor !');", true);
                                if (dt.Rows.Count <= 0)
                                {
                                    pnlCarrinhoPedido.Visible = false;
                                }
                            }
                            contadorPainel++;
                        }
                        if (ctr2 is TextBox && ctr2.ID.Contains("txtQtdBebida"))
                        {
                            txt = (TextBox)ctr2;
                            quantidadeBebida = txt.Text;
                        }
                        if (ctr2 is Label && ctr2.ID.Contains("lblPrecoBebida"))
                        {
                            lblBebidaPrec = (Label)ctr2;
                            precoBebida = lblBebidaPrec.Text;
                            pnlCarrinhoPedido.Visible = true;
                        }

                        if (pnlCarrinhoPedido.Visible == true && nomeBebida != "" && precoBebida != "")
                        {
                            int contadorRepetido = 0;
                            int numLinhas = dt.Rows.Count;
                            if (numLinhas >= 1)
                            {
                                for (int i = numLinhas - 1; i >= 0; i--)
                                {
                                    //Verificando se não há repetição de bebidas, se houver é somado na quantidade.
                                    DataRow linha = dt.Rows[i];
                                    if (linha["Produtos"].ToString() == nomeBebida && contadorVolta <= contadorPainel)
                                    {
                                        double valorFinal = 0;
                                        int qtd = Convert.ToInt32(linha["Quantidade"]) + Convert.ToInt32(quantidadeBebida);
                                        double valor = Convert.ToDouble(precoBebida.Substring(2).Trim()) / Convert.ToInt32(quantidadeBebida);
                                        valorFinal += valor * qtd;
                                        linha["Quantidade"] = qtd;
                                        linha["Valor"] = valorFinal.ToString("C");
                                        contadorVolta++;
                                        contadorRepetido++;
                                        break;
                                    }
                                }
                            }
                            //Se for a primeira vez que ele está adicionando pizzas
                            else if (numLinhas == 0)
                            {
                                DataRow linha = dt.NewRow();
                                linha["Produtos"] = nomeBebida;
                                linha["Quantidade"] = quantidadeBebida;
                                linha["Valor"] = precoBebida;
                                dt.Rows.Add(linha);
                                contadorVolta++;
                            }
                            //Se não houve repetição, e se não é mais a primeira pizza que o usuário tenta adicionar
                            if (contadorRepetido == 0 && contadorVolta >= 1 && numLinhas >= 1)
                            {
                                DataRow linha = dt.NewRow();
                                linha["Produtos"] = nomeBebida;
                                linha["Quantidade"] = quantidadeBebida;
                                linha["Valor"] = precoBebida;
                                dt.Rows.Add(linha);
                                contadorVolta++;
                            }

                            Session["carrinho"] = dt;

                            gdCarrinho.DataSource = dt;
                            gdCarrinho.DataBind();

                            double precoTotal = 0;
                            foreach (GridViewRow row in gdCarrinho.Rows)
                            {
                                string celula = row.Cells[2].Text;
                                precoTotal += Convert.ToDouble(celula.Substring(2));
                                lblPrecoTotal.Text = precoTotal.ToString("C");
                                lblPrecoDoPedido.Text = precoTotal.ToString("C");
                                txtValor.Text = precoTotal.ToString("C");
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
    //FIM método para adicionar pizzas no carrinho

    //Método para adicionar endereço alternativo
    protected void trocarEndereco(object sender, EventArgs e)
    {
        if (rbtnEnd.SelectedItem.Value == "1")
        {
            txtEnderecoPedido.ReadOnly = true;
            txtEnderecoPedido.Style.Add("background", "#999");
            txtEnderecoPedido.Style.Add("color", "#ddd");

            lblLogradouro.Visible = false;

            lblBairro.Visible = false;
            txtBairro.Visible = false;

            lblNumAlt.Visible = false;
            txtNum.Visible = false;

            lblNumApartAlt.Visible = false;
            txtNumApart.Visible = false;

            if (numApart == "0" || numApart == "")
            {
                txtEnderecoPedido.Text = endereco + ", nº " + numero + " - " + bairro;
            }
            else
            {
                txtEnderecoPedido.Text = endereco + ", nº " + numero + " - " + bairro + ", Apt. " + numApart;
            }
        }
        else if (rbtnEnd.SelectedItem.Value == "2")
        {
            txtEnderecoPedido.ReadOnly = false;
            txtEnderecoPedido.Style.Add("background", "#fff3e9;");
            txtEnderecoPedido.Style.Add("color", "#ef6f53;");
            txtEnderecoPedido.Text = "";

            lblLogradouro.Visible = true;

            lblBairro.Visible = true;
            txtBairro.Visible = true;

            lblNumAlt.Visible = true;
            txtNum.Visible = true;

            lblNumApartAlt.Visible = true;
            txtNumApart.Visible = true;
        }
    }
    //FIM Método para adicionar endereço alternativo

    protected void limparCarrinho(object sender, EventArgs e)
    {
        Session["carrinho"] = null;
        Response.Redirect("pedir.aspx");
    }

    protected void trocaFormaPagamento(object sender, EventArgs e)
    {
        double valor = Convert.ToDouble(lblPrecoDoPedido.Text.Substring(2));
        if (rbtnPagamento.SelectedItem.Value == "1")
        {
            txtValor.Text = valor.ToString("C");
            txtValor.ReadOnly = false;
            txtValor.Text = "";
            txtValor.Attributes.Add("placeholder","Exemplo: 50,00");
        }
        else if (rbtnPagamento.SelectedItem.Value == "2")
        {
            txtValor.Text = valor.ToString("C");
            txtValor.ReadOnly = true;
            txtTroco.Text = "R$ 00,00";
        }
    }

    protected void trocarValor(object sender, EventArgs e)
    {
        DataTable dt = (DataTable)Session["carrinho"];
        double preco = 0;
        string precoStr = "";
        double numDigitado = 0;
        foreach (DataRow row in dt.Rows)
        {
             precoStr = row["Valor"].ToString().Substring(2).Trim();
             preco += Convert.ToDouble(precoStr);
        }

        try
        {
            string numDigitado2 = txtValor.Text;
            txtValor.Text = "R$ " + numDigitado2;
            numDigitado2 = numDigitado2.Replace('.', ',');

            numDigitado = Convert.ToDouble(numDigitado2);
            //txtValor.Text = numDigitado.ToString("C2");

            if (preco <= numDigitado)
            {
                double troco = numDigitado - preco;
                txtTroco.Text = troco.ToString("C2");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ScriptManager1", "alert('Coloque um valor maior que o preço !!');", true);
                txtValor.Text = "";
            }
        }
        catch (Exception ex)
        {
            txtValor.Text = "";
            txtValor.Attributes.Add("placeholder", "Digite um valor válido !!");
        }
    }

    protected void finalizaPedido(object sender, EventArgs e)
    {
        string enderecoF = "";
        string bairroF = "";
        string numeroF = "";
        string numapartF = "";

        string formaPag = "";
        double valorPago = Convert.ToDouble(txtValor.Text.Substring(2).Trim());
        string valor = valorPago.ToString();
        valor.Replace(",", ".");
        valorPago = Convert.ToDouble(valor);

        //Variáveis para inserção no banco
        string testeData = DateTime.Now.ToShortDateString();
        string testeHora = DateTime.Now.ToShortTimeString();
        double preco = Convert.ToDouble(lblPrecoTotal.Text.Substring(2).Trim());

        int codUltimoPedido = 0;

        if (rbtnEnd.SelectedItem.Value == "2")
        {
            enderecoF = txtEnderecoPedido.Text;
            numeroF = txtNum.Text;
            bairroF = txtBairro.Text;
            numapartF = txtNumApart.Text;
        }

        if (rbtnPagamento.SelectedItem.Value == "1")
        {
            formaPag = "Dinheiro";
        }
        else
        {
            formaPag = "Cartão";
        }

        Conexao con = new Conexao();
        con.conectar();
        con.command.CommandText = "insert into Pedido(Data,Hora,Valor,Cod_Funcionario,Cod_Cliente, Observacao,Origem,Estado, EnderecoAlt, NumeroResidencialAlt, BairroAlt , NumeroApartamentoAlt ,FormaDePagamento,ValorPago)" + "values(@data, @hora,@valor,@codFunc,@codCliente,@obs,@origem,@estado,@enderecoAlt,@numAlt,@bairroAlt,@numApartAlt,@pagamento,@valorPago)";
        con.command.Parameters.Add("@data", SqlDbType.Date).Value = testeData;
        con.command.Parameters.Add("@hora", SqlDbType.VarChar).Value = testeHora;
        con.command.Parameters.Add("@valor", SqlDbType.Decimal).Value = preco;
        con.command.Parameters.Add("@codFunc", SqlDbType.Int).Value = 1;
        con.command.Parameters.Add("@codCliente", SqlDbType.Int).Value = codCli;
        con.command.Parameters.Add("@obs", SqlDbType.VarChar).Value = txtObservacoes.Text;
        con.command.Parameters.Add("@origem", SqlDbType.VarChar).Value = "Site";
        con.command.Parameters.Add("@estado", SqlDbType.VarChar).Value = "A caminho";
        con.command.Parameters.Add("@enderecoAlt", SqlDbType.VarChar).Value = enderecoF;
        con.command.Parameters.Add("@numAlt", SqlDbType.VarChar).Value = numeroF;
        con.command.Parameters.Add("@bairroAlt", SqlDbType.VarChar).Value = bairroF;
        con.command.Parameters.Add("@numApartAlt", SqlDbType.VarChar).Value = numapartF;
        con.command.Parameters.Add("@pagamento", SqlDbType.VarChar).Value = formaPag;
        con.command.Parameters.Add("@valorPago", SqlDbType.Decimal).Value = valorPago;
        int qtd = con.command.ExecuteNonQuery();
        if (qtd <= 0)
        {
            Session.Clear();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect","alert('Problema ao Registrar seu pedido'); window.location='" + Request.ApplicationPath + "/aspx/pedir.aspx';", true);
        }
        con.fechaConexao();


        //Conexão que traz o Código do último pedido inserido(esse do insert de cima).
        Conexao con2 = new Conexao();
        con2.conectar();
        con2.command.CommandText = "select MAX(Cod_Pedido) as 'UltimoPedido' from Pedido";
        codUltimoPedido = Convert.ToInt32(con2.command.ExecuteScalar());
        con2.fechaConexao();

        DataTable dt = (DataTable)Session["carrinho"];
        DataSet ds = (DataSet)Session["valorPizza"];
        DataSet dsBebida = (DataSet)Session["valorBebida"];

        //Conexão que cria o Detalhe_Pedido utilizando-se do Código do Pedido retornado.
        Conexao con3 = new Conexao();
        con3.conectar();

        int contadorVolta = 0;
        int numLinhas = dt.Rows.Count;
        string[] prodArray = {""};
        int? codProduto1 = 0;
        int? codProduto2 = 0;
        string produto = "";
        int quantidade = 0;

            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < numLinhas && contadorVolta < numLinhas; i++)
                {
                    produto = dt.Rows[i]["Produtos"].ToString();
                    quantidade = Convert.ToInt32(dt.Rows[i]["Quantidade"]);
                    //Se a pizza for meio a meio
                    if (produto.Contains("/"))
                    {
                        string produtos = dt.Rows[i]["Produtos"].ToString();
                        prodArray = produtos.Split('/');

                        foreach (DataTable table in ds.Tables)
                        {
                            foreach (DataRow row2 in table.Rows)
                            {
                                if (prodArray[0].ToString().Trim() == row2["Nome_Produto"].ToString())
                                {
                                    codProduto1 = Convert.ToInt32(row2["Cod_Produto"]);
                                }
                                if (prodArray[1].ToString().Trim() == row2["Nome_Produto"].ToString())
                                {
                                    codProduto2 = Convert.ToInt32(row2["Cod_Produto"]);
                                }
                                if (codProduto1 != 0 && codProduto2 != 0)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    //Se a pizza NÃO é meio a meio
                    if (!produto.Contains('/'))
                    {
                        foreach (DataTable table in ds.Tables)
                        {
                            foreach (DataRow row2 in table.Rows)
                            {
                                //Pesquisando o produto dessa volta no DS
                                if (produto == row2["Nome_Produto"].ToString())
                                {
                                    codProduto1 = Convert.ToInt32(row2["Cod_Produto"]);
                                    codProduto2 = 0;
                                    break;
                                }
                            }
                        }
                    }
                    for (int j = 1; j <= quantidade; j++)
                    {
                        if (codProduto2 == 0)
                        {
                            con3.command.Parameters.Add("@CodPedido" + contadorVolta.ToString(), SqlDbType.Int).Value = codUltimoPedido;
                            con3.command.Parameters.Add("@CodProduto" + contadorVolta.ToString(), SqlDbType.Int).Value = codProduto1;
                            con3.command.Parameters.Add("@CodProdutoMeio" + contadorVolta.ToString(), SqlDbType.Int).Value = DBNull.Value;
                            con3.command.CommandText = "insert into Detalhe_Pedido(Cod_Pedido,Cod_Produto,Cod_Produto2)" + "values(@CodPedido" + contadorVolta.ToString() + ",@CodProduto" + contadorVolta.ToString() + ",@CodProdutoMeio" + contadorVolta.ToString() + ")";
                            con3.command.ExecuteNonQuery();
                            contadorVolta++;
                        }
                        else
                        {
                            con3.command.Parameters.Add("@CodPedido" + contadorVolta.ToString(), SqlDbType.Int).Value = codUltimoPedido;
                            con3.command.Parameters.Add("@CodProduto" + contadorVolta.ToString(), SqlDbType.Int).Value = codProduto1;
                            con3.command.Parameters.Add("@CodProdutoMeio" + contadorVolta.ToString(), SqlDbType.Int).Value = codProduto2;
                            con3.command.CommandText = "insert into Detalhe_Pedido(Cod_Pedido,Cod_Produto,Cod_Produto2)" + "values(@CodPedido" + contadorVolta.ToString() + ",@CodProduto" + contadorVolta.ToString() + ",@CodProdutoMeio" + contadorVolta.ToString() + ")";
                            con3.command.ExecuteNonQuery();
                            contadorVolta++;
                        }
                    }
                }
        }

        con3.fechaConexao();
        Session.Clear();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "ScriptManager1", "alert('Pedido Registrado com Sucesso !!');window.location='" + Request.ApplicationPath + "/aspx/pedir.aspx';", true);
    }
}//Chave Final