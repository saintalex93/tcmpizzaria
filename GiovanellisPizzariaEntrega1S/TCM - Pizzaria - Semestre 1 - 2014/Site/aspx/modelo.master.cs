using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class modelo : System.Web.UI.MasterPage
{
    int codcliente;
    string nome;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["nome"] != null)
        {
            if (Request.Cookies["nome"].Value == "0")
            {
                pnl_logado.Visible = false;
                linkCadastro.Visible = true;
                linkConta.Visible = false;
            }
            else if (Request.Cookies["nome"].Value != "0")
            {
                linkCadastro.Visible = false;
                linkConta.Visible = true;
                pnl.Visible = false;
                pnl_logado.Visible = true;
                lblNomeUsuario.Text = Request.Cookies["nome"].Value;
                linkCadastro_rodape.Text = "meus pedidos";
                linkCadastro_rodape.NavigateUrl = "pedidos.aspx";
                if (Session["carrinho"] != null)
                {
                    try
                    {
                        DataTable dt = (DataTable)Session["carrinho"];
                        int numprods = dt.Rows.Count;
                            if (numprods == 1)
                            {
                                lblProdutosCarrinho.Text = "Seu carrinho tem " + numprods.ToString() + " produto.";
                            }
                            else
                            {
                                lblProdutosCarrinho.Text = "Seu carrinho tem " + numprods.ToString() + " produtos.";
                            }
                    }
                    catch
                    {
                        lblProdutosCarrinho.Text = "Não há produtos no seu carrinho.";
                    }
                }
                else
                {
                    lblProdutosCarrinho.Text = "Não há produtos no seu carrinho.";
                }
            }
        }
        else
        {
            pnl_logado.Visible = false;
            linkCadastro.Visible = true;
            linkConta.Visible = false;
        }
    }

    protected void btnLogar_Click(object sender, EventArgs e)
    {
        //Chamando o método de validação que torna os campos txtEmail e txtSenha obrigatórios.
        bool x = validacao();
        //Verifico se a variável global x é true.Se for, ele passou pela validação dos campos obrigatórios.
        if (x == true)
        {
            try
            {
                //Criação dos DataAdapter's e dos DataSet's
                DataSet dt = new DataSet();
                SqlDataAdapter dAdapter = new SqlDataAdapter();

                SqlDataAdapter dAdapter2 = new SqlDataAdapter();
                DataSet dt2 = new DataSet();

                //Declaração da variáveis que recuperam o login e senha digitados
                String email = txtEmail.Text.Trim();
                String senha = txtSenha.Text.Trim();

                //Conexão que vai recuperar o CÓDIGO do cliente pelo email e senha digitados.
                Conexao con = new Conexao();
                con.conectar();

                con.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                con.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                
                con.command.CommandText = "select Nome_Cliente,Cod_Cliente from Cliente where Login_Cliente=@email and Senha_Cliente=@senha";
                dAdapter.SelectCommand = con.command;
                dAdapter.Fill(dt);
                con.fechaConexao();

                //Pegando as informações do DataSet e jogando em variáveis.

                nome = dt.Tables[0].DefaultView[0].Row["Nome_Cliente"].ToString();
                codcliente = Convert.ToInt32(dt.Tables[0].DefaultView[0].Row["Cod_Cliente"]);

                /*Verificando se o nome não é nulo.
                Se não for, dois cookies são criados,
                um com nome dele para mostrar depois,
                e outro com ID dele, para manipulação de dados. */

                if (nome != null)
                {
                    Response.Cookies["nome"].Value = nome;
                    Response.Cookies["cod"].Value = codcliente.ToString();
                    lblNomeUsuario.Text = Request.Cookies["nome"].Value;
                    pnl.Visible = false;
                    pnl_logado.Visible = true;
                    Response.Redirect("../index.aspx");
                }
                else
                {
                    lblLoginInc.Text = "Login e/ou Senha incorreto(s)";
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Sua string de conexão está errada cara, que loucura')</script>");
            }
        }
    }

    protected bool validacao()
    {
        if (txtEmail.Text.Length < 1)
        {
            Response.Write("<script>alert('Email não foi preenchido corretamente !!')</script>");
            txtEmail.Focus();
            return false;
        }
        else if (txtSenha.Text.Length < 6)
        {
            Response.Write("<script>alert('Senha não foi preenchida corretamente !!')</script>");
            txtSenha.Focus();
            return false;
        }
        else
        {
            return true;
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Cookies["nome"].Value = "0";
        Response.Cookies["cod"].Value = "0";

        lblLoginInc.Text = "";
        txtEmail.Text = "";
        txtSenha.Text = "";
        Response.Redirect("../index.aspx");
    }
}
