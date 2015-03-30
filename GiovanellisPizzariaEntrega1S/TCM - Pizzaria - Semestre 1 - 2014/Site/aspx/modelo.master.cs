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
    bool x = true;

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
                if (Request.Cookies["pizzas"] != null)
                {
                    try
                    {
                        string numpizzas = Request.Cookies["pizzas"].Value;
                        string[] numpizzas2 = numpizzas.Split('/');
                        for (int i = 0; i <= numpizzas2.Length; i++)
                        {
                            lblProdutosCarrinho.Text = "Seu carrinho tem " + i.ToString() + " produto(s).";
                        }
                    }
                    catch
                    {
                        lblProdutosCarrinho.Text = "Não há pizzas no seu carrinho.";
                    }
                }
                else
                {
                    lblProdutosCarrinho.Text = "Não há pizzas no seu carrinho.";
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
        validacao();
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
                
                con.command.CommandText = "select Cod_Cliente from Cliente where Login_Cliente=@email and Senha_Cliente=@senha";
                dAdapter.SelectCommand = con.command;
                dAdapter.Fill(dt);
                con.fechaConexao();

                //Conexão que vai recuperar o NOME do cliente pelo email e senha digitados.

                Conexao con2 = new Conexao();
                con2.conectar();

                con2.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                con2.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                con2.command.CommandText = "select Nome_Cliente from Cliente where Login_Cliente=@email and Senha_Cliente=@senha";
                dAdapter2.SelectCommand = con2.command;
                dAdapter2.Fill(dt2);
                con2.fechaConexao();

                //Pegando as informações do DataSet e jogando em variáveis.

                nome = dt2.Tables[0].DefaultView[0].Row["Nome_Cliente"].ToString();
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

    protected void validacao()
    {
        if (txtEmail.Text.Length < 1)
        {
            x = false;
            Response.Write("<script>alert('Email não foi preenchido corretamente !!')</script>");
            txtEmail.Focus();
        }
        else if (txtSenha.Text.Length < 6)
        {
            x = false;
            Response.Write("<script>alert('Senha não foi preenchida corretamente !!')</script>");
            txtSenha.Focus();
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
