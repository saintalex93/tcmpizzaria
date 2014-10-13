using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pizzaria
{
    public partial class Fornecedores : Form
    {
        //String com informações de acesso pro BD
        string conexao = "Data Source=Tuca\\SQLEXPRESS ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=123456";

        public Fornecedores()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mtxtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void rdCPF_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCNPJ.Visible = false;
            mtxtCPF.Visible = true;

            mtxtCNPJ.Enabled = false;
            mtxtCPF.Enabled = true;
        }

        private void rdCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCPF.Visible = false;
            mtxtCNPJ.Visible = true;

            mtxtCNPJ.Enabled = true;
            mtxtCPF.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            validaCampos();
        }

        private bool validaCampos() 
        {
            string erro = "";

            if(
                erro.Length == 0 
                && 
                txtRazaoSocial.TextLength == 0 
                &&
                txtNomeFantasia.TextLength == 0
                )
                erro = "Por favor, preencha pelo menos um dos campos \"Nome Fantasia\" e/ou \"Razão Social\" preenchidos.";

            if(
                erro.Length == 0 
                && 
                txtRazaoSocial.TextLength < 4
                )
                erro = "O conteúdo passado no campo \"Razão Social\" não é válido. Por favor, certifique-se de que ele está correto.";

            if(
                erro.Length == 0 
                && 
                txtNomeFantasia.TextLength < 4
                )
                erro = "O conteúdo passado no campo \"Nome Fantasia\" não é válido. Por favor, certifique-se de que ele está correto.";

            string cpf="";
            string cnpj="";

            if (
                erro.Length == 0
                && 
                mtxtCNPJ.Text
                .Replace(" ", "")
                .Replace(".","")
                .Replace("_","")
                .Replace("-","").Length == 0
                &&
                mtxtCPF.Text
                .Replace(" ", "")
                .Replace(".","")
                .Replace("_","")
                .Replace("-","").Length == 0
                )
                erro = "Por favor, é preciso que um dos campos \"CPF\" ou \"CNPJ\" seja preenchidos.";

            if (
                erro.Length == 0
                && 
                mtxtCNPJ.Text.Replace(" ", "").Replace(".","").Replace("-","").Length == 0
                &&
                mtxtCPF.Text.Replace(" ", "").Replace(".","").Replace("-","").Length == 0
                )
                erro = "Por favor, é preciso que um dos campos \"CPF\" ou \"CNPJ\" seja preenchidos.";

            if (
                erro.Length == 0
                && .TextLength < 4
                )
                erro = "";

            if(erro.Length > 0)
            {
                MessageBox.Show
                    (
                    erro,
                    "Erro no cadastro de Fornecedores",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                return false;
            }
            else
                return true;
        }

        public Boolean ValidaCPF(string strValida)
        {
            strValida = "select * from Fornecedor where CNPJ_CPF = '" + strValida + "'";
            
            SqlConnection conn = new SqlConnection(conexao);
            DataTable dt = new DataTable();
            conn.Open();

            try
            {
                SqlCommand sqlComm = new SqlCommand(strValida, conn);

                sqlComm.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                    return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao consultar o documento do Fornecedor");
            }

            conn.Close();

            return true;


        }
    }
}
