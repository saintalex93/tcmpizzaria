using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_trocarsenha : System.Web.UI.Page
{
    int codigo;
    int result;
    bool x = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        codigo = Convert.ToInt32(Request.Cookies["cod"].Value);
        if (Request.Cookies["cod"] != null)
        {
            if (Request.Cookies["cod"].Value == "0")
            {
                Response.Write("<script>alert('Você deve estar logado para acessar esta página')</script>");
                Response.Write("<script>history.go(-1)</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('Você deve estar logado para acessar esta página')</script>");
            Response.Write("<script>history.go(-1)</script>");
        }

    }
    protected void btnTrocaSenha_Click(object sender, EventArgs e)
    {
        validacao();
        if (x)
        {
            string senhaAtual = txtSenhaAtual.Text;

            SqlDataAdapter dAdapter = new SqlDataAdapter();

            Conexao con = new Conexao();
            con.conectar();

            con.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senhaAtual;
            con.command.CommandText = "select * from Cliente where " + codigo + " = Cod_Cliente and Senha_Cliente = @senha";
            result = Convert.ToInt32(con.command.ExecuteScalar());
            con.fechaConexao();
            con.command = null;

            if (result == 0)
            {
                Response.Write("<script>alert('Sua senha atual está incorreta')</script>");
            }
            else
            {
                try
                {
                    Conexao con2 = new Conexao();
                    con2.conectar();

                    string senhaNova = txtSenhaNova.Text;

                    con2.command.Parameters.Add("@novaSenha", SqlDbType.VarChar).Value = senhaNova;
                    con2.command.Parameters.Add("@senhaAntiga", SqlDbType.VarChar).Value = senhaAtual;

                    con2.command.CommandText = "update Cliente set Senha_Cliente = @novaSenha where " + codigo + " = Cod_Cliente";// and <> @senhaAntiga
                    con2.command.ExecuteNonQuery();
                    con2.fechaConexao();
                    Response.Cookies["nome"].Value = "0";
                    Response.Cookies["cod"].Value = "0";
                    Response.Redirect("../index.aspx");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Erro inesperado')</script>");
                }
            }
        }
    }
    protected void validacao()
    {
        string senhaNova = txtSenhaNova.Text;
        string senhaNovaConfirm = txtSenhaNovaConfirm.Text;

        if (senhaNova != senhaNovaConfirm)
        {
            Response.Write("<script>alert('As senhas não são iguais !')</script>");
            x = false;
        }
        else if (senhaNova.Length <= 6 || senhaNovaConfirm.Length <= 6) 
        {
            Response.Write("<script>alert('Sua nova senha deve conter mais de 6 letras !')</script>");
            x = false;
        }
    }
}