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

            mtxtCNPJ.Text = "";

            mtxtCPF.Focus();
        }

        private void rdCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCNPJ.Visible = true;
            mtxtCPF.Visible = false;

            mtxtCNPJ.Enabled = true;
            mtxtCPF.Enabled = false;

            mtxtCPF.Text = "";

            mtxtCNPJ.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            validaCampos();
        }

        private bool validaCampos() 
        {
            //Dados Dados do Fornecedor
            //Validação Razão Social/Nome Fantasia
            if (
                txtRazaoSocial.TextLength == 0 
                &&
                txtNomeFantasia.TextLength == 0
                )
            {
                mensagemDeErro("Por favor, preencha pelo menos um dos campos \"Nome Fantasia\" e/ou \"Razão Social\"  para que o processo de cadastro possa seguir até o final.");
                txtRazaoSocial.Focus();
                return false;
            }

            if (
                txtRazaoSocial.TextLength != 0
                &&
                txtRazaoSocial.TextLength < 4
                )
            {
                mensagemDeErro("O conteúdo passado no campo \"Razão Social\" não é válido. Por favor, certifique-se de que ele está correto.");
                txtRazaoSocial.Focus();
                return false;
            }

            if (
                txtNomeFantasia.TextLength != 0
                &&
                txtNomeFantasia.TextLength < 4
                )
            {
                mensagemDeErro("O conteúdo passado no campo \"Nome Fantasia\" não é válido. Por favor, certifique-se de que ele está correto.");
                txtRazaoSocial.Focus();
                return false;
            }

/*            if (
                txtRazaoSocial.TextLength < 4
                &&
                txtNomeFantasia.TextLength == 0
                )
            {
                mensagemDeErro("O conteúdo passado no campo \"Razão Social\" não é válido. Por favor, certifique-se de que ele está correto.");
                txtRazaoSocial.Focus();
                return false;
            }

            if (
                txtRazaoSocial.TextLength == 0
                &&
                txtNomeFantasia.TextLength < 4
                ) 
            {
                mensagemDeErro("O conteúdo passado no campo \"Nome Fantasia\" não é válido. Por favor, certifique-se de que ele está correto.");
                txtNomeFantasia.Focus();
                return false;
            }*/

            //Validação CPF/CNPJ
            if (
                mtxtCNPJ.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(".", "")
                .Replace("_", "")
                .Replace("/", "")
                .Replace("-", "").Length == 0
                &&
                mtxtCPF.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace("_", "")
                .Replace("-", "").Length == 0
                ) 
            {
                mensagemDeErro("Por favor, é preciso que um dos campos \"CPF\" ou \"CNPJ\" seja preenchido para que o processo de cadastro possa seguir até o final.");

                if (mtxtCPF.Visible == true)
                    mtxtCPF.Focus();
                else if (mtxtCNPJ.Visible == true)
                    mtxtCNPJ.Focus();

                return false;
            }


            if (
                mtxtCNPJ.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(".", "")
                .Replace("_", "")
                .Replace("/", "")
                .Replace("-", "").Length < 14
                &&
                mtxtCPF.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace("_", "")
                .Replace("-", "").Length == 0
                )
            {
                mensagemDeErro("Infelizmente, o valor preenchido no campo \"CNPJ\" não é válido. Por favor, utilize um valor de CNPJ válido.");

                mtxtCNPJ.Focus();

                return false;
            }
            else if (
                mtxtCNPJ.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(".", "")
                .Replace("_", "")
                .Replace("/", "")
                .Replace("-", "").Length == 0
                &&
                mtxtCPF.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace("_", "")
                .Replace("-", "").Length < 11
                )
            {
                mensagemDeErro("Infelizmente, o valor preenchido no campo \"CPF\" não é válido. Por favor, utilize um valor de CPF válido.");

                mtxtCPF.Focus();

                return false;
            }

            /*Todo o bloco a seguir foi feito antes de ser descoberto que a máscara dos campos impede que números sejam digitados nos campos com máscara, mas foi guardado, porque vaiq. - Tuca
             * string documento;
            bool ehCPF;

            if
                (mtxtCPF.Visible == true)
            {
                documento =
                    mtxtCPF.Text
                    .Replace(" ", "")
                    .Replace(".", "")
                    .Replace("/", "")
                    .Replace(",", "")
                    .Replace("_", "")
                    .Replace("-", "");

                ehCPF = true;
            }
            else
            {
                documento =
                    mtxtCNPJ.Text
                    .Replace(" ", "")
                    .Replace(".", "")
                    .Replace("/", "")
                    .Replace(",", "")
                    .Replace("_", "")
                    .Replace("-", "");

                ehCPF = false;

            }


            for( int i = 0; i < documento.Length; i++ )
                if (!char.IsNumber(documento[i]))
                {
                    if (ehCPF == true) 
                    {
                        mensagemDeErro("Não é permitido qualquer caracter que não seja um número no campo de CPF.");

                        mtxtCPF.Focus();
                    }
                    else
                    { 
                        mensagemDeErro("Não é permitido qualquer caracter que não seja um número no campo de CNPJ.");

                        mtxtCNPJ.Focus();
                    }

                    return false;
                }*/

            //Validação Telefone de contato
            if(
                mtxtTelefoneDeContato.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "").Length == 0
                )
            {
                mensagemDeErro("Por favor, é preciso que o campo \"Telefone de contato\" seja preenchido para que o processo de cadastro possa seguir até o final.");
                mtxtTelefoneDeContato.Focus();
                return false;
            }
            else if (
                mtxtTelefoneDeContato.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "").Length < 10
                ) 
            {
                mensagemDeErro("Infelizmente, o valor preenchido no campo \"Telefone de contato\" não é válido. Certifique-se de que o número está correto.");
                mtxtTelefoneDeContato.Focus();
                return false;
            }

            //Dados bancários
            //Validação Banco
            if (txtBanco.Text.Length == 0)
            {
                mensagemDeErro("Por favor, é preciso prencher o campo \"Banco\" dentro da sessão de \"Dados bancários\".");
                txtBanco.Focus();
                return false;
            }

            for (int i = 0; i < txtBanco.Text.Length; i++)
                if (!char.IsNumber(txtBanco.Text[i]))
                {
                    mensagemDeErro("É permitido apenas o uso de números no campo \"Banco\". Por favor, certifique-se de que o valor preenchido está correto.");
                    txtBanco.Focus();
                    return false;
                }
            
            if (txtBanco.Text.Length < 3) 
            {
                mensagemDeErro("Infelizmente, o valor preenchido no campo \"Banco\" não é válido. Certifique-se de que o número está correto.");
                txtBanco.Focus();
                return false;
            }

            //Validação Agência
            if (txtAgencia.Text.Length == 0)
            {
                mensagemDeErro("Por favor, é preciso prencher o campo \"Agência\" dentro da sessão de \"Dados bancários\".");
                txtAgencia.Focus();
                return false;
            }

            for (int i = 0; i < txtAgencia.Text.Length; i++)
                if (!char.IsNumber(txtAgencia.Text[i]))
                {
                    mensagemDeErro("É permitido apenas o uso de números no campo \"Agência\". Por favor, certifique-se de que o valor preenchido está correto.");
                    txtAgencia.Focus();
                    return false;
                }

            if (txtAgencia.Text.Length < 4)
            {
                mensagemDeErro("Infelizmente, o valor preenchido no campo \"Agência\" não é válido. Certifique-se de que o número está correto.");
                txtAgencia.Focus();
                return false;
            }


            //Validação Conta
            if (txtConta.Text.Length == 0)
            {
                mensagemDeErro("Por favor, é preciso prencher o campo \"Conta\" dentro da sessão de \"Dados bancários\".");
                txtConta.Focus();
                return false;
            }

            for (int i = 0; i < txtConta.Text.Length; i++)
                if (!char.IsNumber(txtConta.Text[i]))
                {
                    mensagemDeErro("É permitido apenas o uso de números no campo \"Conta\". Por favor, certifique-se de que o valor preenchido está correto.");
                    txtConta.Focus();
                    return false;
                }

            if (txtConta.Text.Length < 5)
            {
                mensagemDeErro("Infelizmente, o valor preenchido no campo \"Conta\" não é válido. Certifique-se de que o número está correto.");
                txtConta.Focus();
                return false;
            }

            return true;
        }


        public void mensagemDeErro(string erro)
        {
            MessageBox.Show
                (
                erro,
                "Erro no cadastro de Fornecedores",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
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

        private void txtBanco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
