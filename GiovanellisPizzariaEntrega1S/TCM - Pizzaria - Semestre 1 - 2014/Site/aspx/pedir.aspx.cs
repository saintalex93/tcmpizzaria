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
    string endereco = "";
    string numero = "";
    string bairro = "";
    string numApart = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["cod"] == null || Request.Cookies["cod"].Value == "0")
        {
            Response.Write("<script>alert('Você deve estar logado para acessar esta página.')</script>");
            Response.Write("<script>history.go(-1)</script>");
        }
        else
        {
            txtObservacoes.Attributes.Add("placeholder", "Ex: Pizza Mussarela sem cebola");

            codCli = Convert.ToInt32(Request.Cookies["cod"].Value);

            //Conexão que pega o endereço do usuário logado no momento.
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

            //Conexão que cria um DataSet com os valores de cada produto e coloca em uma sessão.
            Conexao con2 = new Conexao();
            SqlDataAdapter dAdapter2 = new SqlDataAdapter();
            DataSet ds2 = new DataSet();

            con2.conectar();
            con2.command.CommandText = "select Nome_Produto,Valor_Venda from Produto as p inner join Categoria as c on c.NomeCategoria = 'Pizza'";
            dAdapter2.SelectCommand = con2.command;
            dAdapter2.Fill(ds2);
            Session["valorPizza"] = ds2;
            Session.Timeout = 60;
            con2.fechaConexao();
            codCli = Convert.ToInt32(Request.Cookies["cod"].Value);

            Conexao con3 = new Conexao();
            SqlDataAdapter dAdapter3 = new SqlDataAdapter();
            DataSet ds3 = new DataSet();

            con3.conectar();
            con3.command.CommandText = "select Valor_Venda from Produto as p inner join Categoria as c on c.NomeCategoria = 'Pizza'";
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
                    string teste = row.Cells[2].Text;
                    precoTotal += Convert.ToDouble(teste.Substring(2));
                    lblPrecoTotal.Text = precoTotal.ToString();
                }
            }
        }
        //Session.Clear();
    }
    //Fim Page_Load

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
    /* FIM CARREGA BEBIDAS */

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

    /* MÉTODO QUE ADICIONA MAIS DROPDOWNS DE BEBIDAS PARA ESCOLHA */
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
    /* FIM ADICIONAR BEBIDAS */

    /* REMOVER BEBIDAS */
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
    /* FIM REMOVER BEBIDAS */

    public string retornaPrecoBebida(DropDownList drop)
    {
        DataSet ds = (DataSet)Session["valorBebida"];
        string a = "";
        return a;
    }

    /* MÉTODO DOS CHECKBOXES */
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
    /* FIM MÉTODO DOS CHECKBOXES */

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
            selecionado1 = Convert.ToDouble(ds.Tables[0].DefaultView[Convert.ToInt32(drop.SelectedValue) - 1].Row["Valor_Venda"]);
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

    //Método para adicionar pizzas no carrinho
    protected void AdicionarProdutosCarrinho(object sender, EventArgs e)
    {
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
                    foreach(Control ctr2 in ctr.Controls)
                    {
                        if (ctr2 is CheckBox)
                        {
                            CheckBox chk = (CheckBox)ctr2;
                            int selecionado = 0;
                            int selecionado2 = 0;
                            string nome = "";
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
                                                pnlCarrinhoPedido.Visible = false;
                                                break;
                                            }
                                            else
                                            {
                                                selecionado = Convert.ToInt32(drop.SelectedItem.Value);
                                                nome = ds.Tables[0].DefaultView[selecionado - 1].Row["Nome_Produto"].ToString();
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
                                                    double valor = Convert.ToDouble(preco) / Convert.ToInt32(quantidade);
                                                    valorFinal += valor * qtd;
                                                    linha2["Quantidade"] = qtd;
                                                    linha2["Valor"] = "R$ " + valorFinal;
                                                    contadorVolta++;
                                                    contadorRepetido++;
                                                    break;
                                                }
                                            }
                                        }
                                        //Se for a primeira vez que ele está adicionando pizzas
                                        else if(numLinhas == 0)
                                        {
                                            DataRow linha = dt.NewRow();
                                            linha["Produtos"] = nome;
                                            linha["Quantidade"] = quantidade;
                                            linha["Valor"] = "R$ " + preco;
                                            dt.Rows.Add(linha);
                                            contadorVolta++;
                                        }
                                        //Se não houve repetição, e se não é mais a primeira pizza que o usuário tenta adicionar
                                        if(contadorRepetido == 0 && contadorVolta >= 1 && numLinhas >= 1)
                                        {
                                            DataRow linha = dt.NewRow();
                                            linha["Produtos"] = nome;
                                            linha["Quantidade"] = quantidade;
                                            linha["Valor"] = "R$ " + preco;
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
                                            lblPrecoTotal.Text = precoTotal.ToString();
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
                                    if (ctr3 is DropDownList && ctr3.ID.Contains("1") || ctr3.ID.Contains("3") || ctr3.ID.Contains("5") || ctr3.ID.Contains("7") || ctr3.ID.Contains("9"))
                                    {
                                        drop = (DropDownList)ctr3;
                                        if (drop.SelectedItem.Value == "Selecione uma Pizza")
                                        {
                                            ScriptManager.RegisterStartupScript(Page, GetType(), "ScriptManager1", "alert('Selecione uma pizza, por favor !');", true);
                                            pnlCarrinhoPedido.Visible = false;
                                            break;
                                        }
                                    }
                                    else if (ctr3 is DropDownList && ctr3.ID.Contains("2") || ctr3.ID.Contains("4") || ctr3.ID.Contains("6") || ctr3.ID.Contains("8") || ctr3.ID.Contains("0"))
                                    {
                                        drop2 = (DropDownList)ctr3;
                                        if (drop2.SelectedItem.Value == "Selecione uma Pizza")
                                        {
                                            ScriptManager.RegisterStartupScript(Page, GetType(), "ScriptManager1", "alert('Selecione uma pizza, por favor !');", true);
                                            break;
                                        }
                                    }
                                    else if (ctr3 is Label && ctr3.ID.Contains("lblPreco"))
                                    {
                                        lbl = (Label)ctr3;
                                        preco = lbl.Text;
                                    }
                                    
                                    selecionado = Convert.ToInt32(drop.SelectedItem.Value);
                                    selecionado2 = Convert.ToInt32(drop2.SelectedItem.Value);
                                    nome = ds.Tables[0].DefaultView[selecionado - 1].Row["Nome_Produto"].ToString() + " , " + ds.Tables[0].DefaultView[selecionado2 - 1].Row["Nome_Produto"].ToString();

                                    //Criando colunas que vão para o DataTable
                                    dt.Columns.Add("Produtos", System.Type.GetType("System.String"));
                                    dt.Columns.Add("Quantidade", System.Type.GetType("System.String"));
                                    dt.Columns.Add("Valor", System.Type.GetType("System.String"));

                                    contadorVolta += 1;

                                    DataRow linha = dt.NewRow();
                                    linha["Produtos"] = nome;
                                    linha["Valor"] = preco;
                                    dt.Rows.Add(linha);

                                    pnlCarrinhoPedido.Visible = true;

                                    gdCarrinho.DataSource = dt;
                                    gdCarrinho.DataBind();
                                }
                            }
                        }
                    }
                }
            }
            //Se for o painel de bebidas
            else if (ctr.Parent.ID.Contains("pnlPedindoBebidas"))
            {
                ScriptManager.RegisterStartupScript(Page, GetType(), "ScriptManager1","alert('Bebidas');", true);
                break;
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
        lbl.Text = preco;
    }
    //FIM Método para trocar o preço de acordo com a quantidade

    protected void limparCarrinho(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("pedir.aspx");
    }

    protected void finalizaPedido(object sender, EventArgs e)
    {
        string enderecoF = "";
        string bairroF = "";
        string numeroF = "";
        string numapartF = "";
        foreach (GridViewRow row in gdCarrinho.Rows)
        {
            string teste = row.Cells[0].Text;
        }
        //Variáveis para inserção no banco
        DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        DateTime time = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
        double preco = Convert.ToDouble(lblPrecoTotal.Text);
        if (rbtnEnd.SelectedItem.Value == "2")
        {
            enderecoF = txtEnderecoPedido.Text;
            numeroF = txtNum.Text;
            bairroF = txtBairro.Text;
            numapartF = txtNumApart.Text;
        }

        Conexao con = new Conexao();
        con.conectar();
        con.command.CommandText = "insert into Pedido(Data,Hora,Valor,Cod_Funcionario,Cod_Cliente, Observacao,Origem,Estado, EnderecoAlt, NumeroResidencialAlt, NumeroApartamentoAlt ,FormaDePagamento,ValorPago)" + "values(@data, @hora,@valor,@codFunc,@codCliente,@obs,@origem,@estado,@enderecoAlt,@numAlt,@bairroAlt,@numApartAlt,@pagamento,@valorPago)";
        con.command.Parameters.Add("@data", SqlDbType.Date).Value = date;
        con.command.Parameters.Add("@hora", SqlDbType.VarChar).Value = time;
        con.command.Parameters.Add("@valor", SqlDbType.Decimal).Value = preco;
        con.command.Parameters.Add("@codFunc", SqlDbType.Int).Value = 1;
        con.command.Parameters.Add("@codCliente", SqlDbType.Int).Value = codCli;
        con.command.Parameters.Add("@obs", SqlDbType.VarChar).Value = txtObservacoes.Text;
        con.command.Parameters.Add("@origem", SqlDbType.VarChar).Value = "Site";
        con.command.Parameters.Add("@estado", SqlDbType.VarChar).Value = "A caminho";
        con.command.Parameters.Add("@enderecoAlt", SqlDbType.VarChar).Value = enderecoF;
        con.command.Parameters.Add("@numAlt", SqlDbType.VarChar).Value = numeroF;
        con.command.Parameters.Add("@hora", SqlDbType.VarChar).Value = bairroF;
        con.command.Parameters.Add("@hora", SqlDbType.VarChar).Value = numapartF;
        con.command.ExecuteNonQuery();
        con.fechaConexao();
    }
    /* ADICIONAR MAIS DOIS PARÂMETROS PARA INSERT E COLOCAR TAMBÉM O INSERT PARA DETALHES DO PEDIDO
    /@pagamento,@valorPago
      */
}//Chave Final