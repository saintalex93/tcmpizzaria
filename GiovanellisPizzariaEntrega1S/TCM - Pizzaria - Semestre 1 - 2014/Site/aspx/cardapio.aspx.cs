using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_cardapio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gdCardapio.DataSource = new List<string>();
            gdCardapio.DataBind();
        }
        gdCardapio.HeaderStyle.CssClass = "colunaheader";
        //gdCardapio.Columns[1].ItemStyle.CssClass = "colunaheader";
        refresh();
    }

    protected void refresh()
    {
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        con.command.CommandText = "select distinct p.Cod_Produto,p.Nome_Produto,count(i.Cod_Insumo) as Quantidade,p.Valor_Venda from Consumo as c inner join Produto as p on p.Cod_Produto = c.CodProduto and p.Sobe_Site = 1 inner join Insumo as i on i.Cod_Insumo = c.CodInsumo inner join ProdutoCategoria as pc on pc.CodProduto = p.Cod_Produto and pc.CodCategoria = 1 group by p.Cod_Produto,p.Nome_Produto,p.Valor_Venda order by p.Cod_Produto";
        
        dAdapter.SelectCommand = con.command;
        dAdapter.Fill(ds);

        con.fechaConexao();

        Conexao con2 = new Conexao();
        con2.conectar();
        SqlDataAdapter dAdapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();

        con2.command.CommandText = "select i.Nome_Insumo,p.Cod_Produto from Consumo as c inner join Produto as p on p.Cod_Produto = c.CodProduto inner join Insumo as i on c.CodInsumo = i.Cod_Insumo inner join ProdutoCategoria as pc on pc.CodProduto = p.Cod_Produto and pc.CodCategoria = 1 order by p.Cod_Produto";

        dAdapter2.SelectCommand = con2.command;
        dAdapter2.Fill(ds2);

        con2.fechaConexao();

        DataTable dt = new DataTable();
        dt.Columns.Add("Sabores", System.Type.GetType("System.String"));
        dt.Columns.Add("Ingredientes", System.Type.GetType("System.String"));
        dt.Columns.Add("Preço", System.Type.GetType("System.String"));

        int contador = 0;
        int totalInsumos = 0;

        foreach (DataTable table in ds.Tables)
        {
            foreach (DataRow row in table.Rows)
            {
                string insumos = "";

                //Variável que permite saber qual é o código do produto nessa volta do Foreach
                int codigoProd = Convert.ToInt32(row["Cod_Produto"]);
                int contadorQtd = 0;
                
                int codProdutoTabelaConsumo = Convert.ToInt32(ds2.Tables[0].DefaultView[totalInsumos].Row["Cod_Produto"]);

                //Fazendo um loop pra "tirar" os insumos das respectivas pizzas a quais eles pertencem
                while (codProdutoTabelaConsumo == codigoProd && contadorQtd < Convert.ToInt32(row["Quantidade"]))
                {
                    string insumoProduto = ds2.Tables[0].DefaultView[totalInsumos].Row["Nome_Insumo"].ToString();
                    if (insumoProduto == "Azeitona" || insumoProduto == "Embalagem para Pizza" || insumoProduto == "Massa para pizza" || insumoProduto == "Molho de tomate")
                    {
                        totalInsumos++;
                        contadorQtd++;
                    }
                    else
                    {
                        if (contadorQtd == 0)
                        {
                            insumos = ds2.Tables[0].DefaultView[totalInsumos].Row["Nome_Insumo"].ToString();
                            totalInsumos++;
                            contadorQtd++;
                        }
                        else
                        {
                            insumos = insumos + ", " + ds2.Tables[0].DefaultView[totalInsumos].Row["Nome_Insumo"].ToString();
                            totalInsumos++;
                            contadorQtd++;
                        }
                    }
                }
                //Criando as linhas que serão adicionadas do DataTable
                DataRow linha = dt.NewRow();
                linha["Sabores"] = row["Nome_Produto"].ToString();
                linha["Ingredientes"] = insumos;
                linha["Preço"] = "R$ " + row["Valor_Venda"].ToString();
                //Adicionando as linhas no DataTable
                dt.Rows.Add(linha);
                contador++;
            }
        }

        gdCardapio.DataSource = dt;
        gdCardapio.DataBind();
    }
}