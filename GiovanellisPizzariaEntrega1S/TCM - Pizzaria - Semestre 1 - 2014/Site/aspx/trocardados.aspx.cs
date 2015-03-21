using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class aspx_trocardados : System.Web.UI.Page
{
    int codCli;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            codCli = Convert.ToInt32(Request.Cookies["cod"].Value);
            Conexao con = new Conexao();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.conectar();
            con.command.CommandText = "select * from Cliente where Cod_Cliente =" + codCli;
            dAdapter.SelectCommand = con.command;
            dAdapter.Fill(ds);
            ds.Tables[0].DefaultView[0].Row[0].ToString();
            con.fechaConexao();
            txtNome.Text = ds.Tables[0].DefaultView[0].Row["Nome_Cliente"].ToString();
            txtTel.Text = ds.Tables[0].DefaultView[0].Row["Telefone_Cliente"].ToString();
            txtCel.Text = ds.Tables[0].DefaultView[0].Row["Celular_Cliente"].ToString();
            txtEmail.Text = ds.Tables[0].DefaultView[0].Row["Email_Cliente"].ToString();
            txtCpf.Text = ds.Tables[0].DefaultView[0].Row["CPF_Cliente"].ToString();
            txtDtNasc.Text = ds.Tables[0].DefaultView[0].Row["DataNascimento"].ToString();
            DDLEstado.SelectedItem.Value = ds.Tables[0].DefaultView[0].Row["Estado_Cliente"].ToString();
            txtCidade.Text = ds.Tables[0].DefaultView[0].Row["Cidade_Cliente"].ToString();
            txtRua.Text = ds.Tables[0].DefaultView[0].Row["Endereco_Cliente"].ToString();
            txtComplemento.Text = ds.Tables[0].DefaultView[0].Row["Complemento_Cliente"].ToString();
            txtNumCasa.Text = ds.Tables[0].DefaultView[0].Row["Numero_Residencia"].ToString();
            txtNumApart.Text = ds.Tables[0].DefaultView[0].Row["Numero_Apartamento"].ToString();
            txtBairro.Text = ds.Tables[0].DefaultView[0].Row["Bairro_Cliente"].ToString();
            txtCep.Text = ds.Tables[0].DefaultView[0].Row["CEP_Cliente"].ToString();
        }
        catch(Exception ex){
            Response.Write("<script>alert('Você não está autorizado.');</script>");
            Response.Write("<script>history.go(-1);</script>");
        }
    }
}