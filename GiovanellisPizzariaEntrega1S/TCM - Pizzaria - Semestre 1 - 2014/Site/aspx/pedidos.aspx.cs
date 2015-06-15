using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_pedidos : System.Web.UI.Page
{
    int codCli;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["nome"] != null)
        {
            if (Request.Cookies["nome"].Value == "0")
            {
                Response.Write("<script>alert('Você deve estar logado para acessar esta página.')</script>");
                Response.Write("<script>history.go(-1)</script>");
            }
            else
            {
                codCli = Convert.ToInt32(Request.Cookies["cod"].Value);
                //Chamando método que atualiza a tabela com os pedidos ANTERIORES
                refresh();

                    //Populando a tabela que possui o pedido ATUAL(o que está Na Fila)
                    DataSet ds = new DataSet();
                    SqlDataAdapter dAdapter = new SqlDataAdapter();

                    Conexao con = new Conexao();
                    con.conectar();
                    con.command.CommandText = "USP_ASP_Pedidos_PedidoAtual";
                    con.command.CommandType = CommandType.StoredProcedure;
                    con.command.Parameters.AddWithValue("@codCliente", codCli);

                    dAdapter.SelectCommand = con.command;
                    dAdapter.Fill(ds);
                    con.fechaConexao();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Produtos");
                    dt.Columns.Add("Quantidade");

                    int linhas = ds.Tables[0].Rows.Count - 1;

                    if (linhas >= 0)
                    {
                        int contadorVolta = 0;

                        int codigoDetalhe = 0;

                        int? codigoProduto = 0;
                        int? codigoProduto2 = 0;

                        int quantidadeMeio = 0;
                        int quantidade = 1;

                        foreach (DataTable table in ds.Tables)
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                codigoDetalhe = Convert.ToInt32(row["Cod_Detalhe"]);

                                if (ds.Tables[0].DefaultView[contadorVolta].Row["Cod_Produto2"] == DBNull.Value)
                                {
                                    codigoProduto = Convert.ToInt32(ds.Tables[0].DefaultView[contadorVolta].Row["Cod_Produto"]);
                                    codigoProduto2 = null;
                                }
                                else
                                {
                                    codigoProduto = Convert.ToInt32(ds.Tables[0].DefaultView[contadorVolta].Row["Cod_Produto"]);
                                    codigoProduto2 = Convert.ToInt32(ds.Tables[0].DefaultView[contadorVolta].Row["Cod_Produto2"]);
                                }

                                DataRow linha = dt.NewRow();

                                //Se o código 2 é diferente de 0 ou nulo, é uma pizza meio a meio, então é concatenado com o próximo produto
                                if (codigoProduto2 != 0 && codigoProduto2 != null)
                                {
                                    int linhaRepetida = 0;

                                    /* Varrendo o DataTable a procura de nomes iguais
                                     * para não haver repetição.
                                    */
                                    foreach (DataRow row2 in dt.Rows)
                                    {
                                        if (row2[0].ToString() == ds.Tables[0].DefaultView[contadorVolta - 1].Row["Nome_Produto"].ToString() + " / " + ds.Tables[0].DefaultView[contadorVolta].Row["Nome_Produto"].ToString() || row2[0].ToString() == ds.Tables[0].DefaultView[contadorVolta].Row["Nome_Produto"].ToString() + " / " + ds.Tables[0].DefaultView[contadorVolta - 1].Row["Nome_Produto"].ToString())
                                        {
                                            linhaRepetida++;
                                        }
                                    }

                                    if (linhaRepetida > 0)
                                    {
                                        for (int j = dt.Rows.Count - 1; j >= 0; j--)
                                        {
                                            if (dt.Rows[j][0].ToString() == ds.Tables[0].DefaultView[contadorVolta - 1].Row["Nome_Produto"].ToString() + " / " + ds.Tables[0].DefaultView[contadorVolta].Row["Nome_Produto"].ToString() || dt.Rows[j][0].ToString() == ds.Tables[0].DefaultView[contadorVolta].Row["Nome_Produto"].ToString() + " / " + ds.Tables[0].DefaultView[contadorVolta - 1].Row["Nome_Produto"].ToString() && codigoDetalhe == Convert.ToInt32(ds.Tables[0].DefaultView[contadorVolta - 1].Row["Cod_Detalhe"]))
                                            {
                                                dt.Rows[j][1] = quantidadeMeio += 1;
                                            }
                                        }
                                        contadorVolta++;
                                    }
                                    else
                                    {
                                        linha["Produtos"] = row["Nome_Produto"] + " / " + ds.Tables[0].DefaultView[contadorVolta + 1].Row["Nome_Produto"].ToString();
                                        contadorVolta += 1;
                                    }
                                }
                                //Senão, a pizza é inteira, ou é uma bebida.
                                else
                                {
                                    int linhaRepetida = 0;

                                    /* Varrendo o DataTable a procura de nomes iguais
                                     * para não haver repetição.
                                    */
                                    foreach (DataRow row2 in dt.Rows)
                                    {
                                        if (row2[0].ToString() == ds.Tables[0].DefaultView[contadorVolta].Row["Nome_Produto"].ToString())
                                        {
                                            linhaRepetida++;
                                        }
                                    }

                                    //Varrendo todas as linhas em busca de pizzas repetidas, para adicionar na quantidade.
                                    for (int i = 0; i <= linhas; i++)
                                    {
                                        /* Se o código do produto for o mesmo e o código de detalhe for diferente,
                                         * então deve ser adicionado na quantidade e impedir que se crie outra linha repetida.
                                        */

                                        if (codigoDetalhe == Convert.ToInt32(ds.Tables[0].DefaultView[i].Row["Cod_Detalhe"]) && codigoProduto == Convert.ToInt32(ds.Tables[0].DefaultView[i].Row["Cod_Produto"]))
                                        {
                                            /* Se houver alguma linha repetida, é alterado a quantidade do produto
                                             * diretamente na DataTable
                                            */
                                            if (linhaRepetida > 0)
                                            {
                                                for (int j = dt.Rows.Count - 1; j >= 0; j--)
                                                {
                                                    if (dt.Rows[j][0].ToString() == ds.Tables[0].DefaultView[contadorVolta].Row["Nome_Produto"].ToString())
                                                    {
                                                        dt.Rows[j][1] = quantidade += 1;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                linha["Produtos"] = ds.Tables[0].DefaultView[contadorVolta].Row["Nome_Produto"].ToString();
                                            }

                                        }
                                        /* Verificando se não foi adicionado mais que uma pizza no momento do pedido,
                                         * através do codigoDetalhe e do codProduto. 
                                         * Se eles forem únicos, apenas uma pizzas deve ser contabilizada aqui.
                                        */
                                    }

                                    linha["Quantidade"] = quantidade.ToString();
                                    contadorVolta++;
                                }
                                //Adicionando a linha na DataTable
                                if (linha["Produtos"].ToString() != "" && linha["Produtos"] != null)
                                {
                                    dt.Rows.Add(linha);
                                }
                            }
                        }

                        gdPedidoAtual.DataSource = dt;
                        gdPedidoAtual.DataBind();
                    }
                    else
                    {
                        gdPedidoAtual.EmptyDataText = "Não há pedidos em andamento";
                        gdPedidoAtual.DataBind();
                    }
                }
            }
        else
        {
            Response.Write("<script>alert('Você deve estar logado para acessar esta página.')</script>");
            Response.Write("<script>history.go(-1)</script>");
        }
    }

    protected void refresh()
    {
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();
        con.command.CommandText = "USP_ASP_Pedidos_FiltraPedido";
        //Declarando que o tipo de comando é uma stored procedure
        con.command.CommandType = CommandType.StoredProcedure;
        //Passando Parâmetros
        con.command.Parameters.AddWithValue("botaoClicado", 1);
        con.command.Parameters.AddWithValue("codCliente", codCli);
        //dAdapter seleciona o comando con.command
        dAdapter2.SelectCommand = con.command;
        //Preencho meu DataSet com informações que o dAdapter "traduziu" pra ele.
        dAdapter2.Fill(ds2);
        //Pego as informações do DataSet, e preencho a tabela com elas.
        datagPedidos.DataSource = ds2;
        //Renderizando as informações na tabela com DataBind()
        datagPedidos.DataBind();
        con.fechaConexao();
    }
    protected void refreshDataAntiga()
    {
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.command.CommandText = "USP_ASP_Pedidos_FiltraPedido";
        //Declarando que o tipo de comando é uma stored procedure
        con.command.CommandType = CommandType.StoredProcedure;
        //Passando Parâmetros
        con.command.Parameters.AddWithValue("botaoClicado", 2);
        con.command.Parameters.AddWithValue("codCliente", codCli);
        //dAdapter seleciona o comando con.command
        dAdapter.SelectCommand = con.command;
        //Preencho meu DataSet com informações que o dAdapter "traduziu" pra ele.
        dAdapter.Fill(ds);
        //Pego as informações do DataSet, e preencho a tabela com elas.
        datagPedidos.DataSource = ds;
        //Renderizando as informações na tabela com DataBind()
        datagPedidos.DataBind();
        con.fechaConexao();
    }
    protected void refreshOrdenaValor()
    {
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.command.CommandText = "USP_ASP_Pedidos_FiltraPedido";
        //Declarando que o tipo de comando é uma stored procedure
        con.command.CommandType = CommandType.StoredProcedure;
        //Passando Parâmetros
        con.command.Parameters.AddWithValue("botaoClicado", 3);
        con.command.Parameters.AddWithValue("codCliente", codCli);
        //dAdapter seleciona o comando con.command
        dAdapter.SelectCommand = con.command;
        //Preencho meu DataSet com informações que o dAdapter "traduziu" pra ele.
        dAdapter.Fill(ds);
        //Pego as informações do DataSet, e preencho a tabela com elas.
        datagPedidos.DataSource = ds;
        //Renderizando as informações na tabela com DataBind()
        datagPedidos.DataBind();
        con.fechaConexao();
    }
    protected void refreshOrdenaValorBarato()
    {
        Conexao con = new Conexao();
        con.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.command.CommandText = "USP_ASP_Pedidos_FiltraPedido";
        //Declarando que o tipo de comando é uma stored procedure
        con.command.CommandType = CommandType.StoredProcedure;
        //Passando Parâmetros
        con.command.Parameters.AddWithValue("botaoClicado", 4);
        con.command.Parameters.AddWithValue("codCliente", codCli);
        //dAdapter seleciona o comando con.command
        dAdapter.SelectCommand = con.command;
        //Preencho meu DataSet com informações que o dAdapter "traduziu" pra ele.
        dAdapter.Fill(ds);
        //Pego as informações do DataSet, e preencho a tabela com elas.
        datagPedidos.DataSource = ds;
        //Renderizando as informações na tabela com DataBind()
        datagPedidos.DataBind();
        con.fechaConexao();
    }

    protected void btnOrdenarData_Click(object sender, EventArgs e)
    {
        refresh();
    }
    protected void btnOrdenarPreco_Click(object sender, EventArgs e)
    {
        refreshOrdenaValor();
    }

    protected void btnOrdenarBarato_Click(object sender, EventArgs e)
    {
        refreshOrdenaValorBarato();
    }
    protected void btnOrdenarDataAntiga_Click(object sender, EventArgs e)
    {
        refreshDataAntiga();
    }

    protected void cancelar(object sender, EventArgs e)
    {
        int? ultimoPedido = 0;

        Conexao con = new Conexao();
        con.conectar();
        con.command.CommandText = "select MAX(Cod_Pedido) from Pedido as p where Estado = 'Na Fila' and Cod_Cliente = " + codCli;
        if (con.command.ExecuteScalar() == DBNull.Value)
        {
            ultimoPedido = null;
        }
        else
        {
            ultimoPedido = Convert.ToInt32(con.command.ExecuteScalar());
        }
        con.fechaConexao();

        if (ultimoPedido != null)
        {
            con.conectar();
            con.command.CommandText = "USP_ASP_Pedidos_CancelarPedido";
            con.command.CommandType = CommandType.StoredProcedure;
            con.command.Parameters.AddWithValue("@codPedido", ultimoPedido);
            con.command.ExecuteNonQuery();
            con.fechaConexao();
        }
        Server.Transfer(Request.ApplicationPath + "/aspx/pedidos.aspx");
    }
}