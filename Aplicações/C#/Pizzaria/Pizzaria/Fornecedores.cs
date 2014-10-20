using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
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
        string conexao = "Data Source=Tuca\\SQLEXPRESS ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=peganomeupau";

        SqlCommand sqlComm;

        //Usada para definir se o botão "Salvar" deverá gravar um registro ou atualizá-lo
        bool gravar;

        SqlConnection conn;

        //
        string
            cod_permissao = "",
            cod_cliente,
            usuario = "",
            senha = "",
            cargo = "",
            nome = "",
            cep = "",
            email = "",
            endereco = "",
            bairro = "",
            cidade = "",
            uf = "",
            complemento = "",
            telefone = "",
            cel = "",
            cpf = "",
            strIncluir = "insert into Fornecedor (";

        int num_endereco = 0;

        public Fornecedores()
        {
            InitializeComponent();
        }

        //        public void InsereFunc(string stringInc)
        /*{
            conn = new SqlConnection(conexao);
            conn.Open();
            try
            {

                SqlCommand sqlComm = new SqlCommand(stringInc, conn);

                sqlComm.ExecuteNonQuery();
                //Seleciona Cargo
                DataTable dt = new DataTable();
                try
                {
                    stringInc = "select cod_Permissao from Permissao where Cargo = '" + cargo + "'";
                    sqlComm = new SqlCommand(stringInc, conn);

                    sqlComm.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    da.Fill(dt);
                    cod_permissao = dt.Rows[0][0].ToString();

                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao Selecionar o Cargo");
                }

                //Cod Funcionario

                dt = new DataTable();
                try
                {
                    stringInc = "select cod_Funcionario from Funcionario where CPF_Funcionario = '" + cpf + "'";
                    sqlComm = new SqlCommand(stringInc, conn);

                    sqlComm.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    da.Fill(dt);
                    cod_cliente = dt.Rows[0][0].ToString();

                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao obter numero do Funcionario");
                }

                //insere tabela permissao funcionario

                dt = new DataTable();
                try
                {
                    stringInc = "insert into FuncPermissao (Login_,Senha,Cod_Funcionario,Cod_Permissao) values ('" + usuario + "','" + senha + "','" + cod_cliente + "','" + cod_permissao + "')";
                    sqlComm = new SqlCommand(stringInc, conn);

                    sqlComm.ExecuteNonQuery();

                    stringInc = "update FUncPermissao set Login_ = '" + usuario + "',senha='" + senha + "',cod_Permissao = '" + cod_permissao + "' where cod_Funcionario ='" + cod_cliente + "'";
                    sqlComm = new SqlCommand(stringInc, conn);
                    sqlComm.ExecuteNonQuery();

                    stringInc = "update Funcionario set cod_Permissao = '" + cod_permissao + "',Usuario_Funcionario='" + usuario + "' where cod_Funcionario ='" + cod_cliente + "'";
                    sqlComm = new SqlCommand(stringInc, conn);
                    sqlComm.ExecuteNonQuery();



                }
                catch (Exception)
                {
                    MessageBox.Show("Falha tabela de permissoes de funcionario");
                }


                MessageBox.Show("Funcionario Inserido com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao Inserir Funcionario");

            }
            conn.Close();

            preenchegrid();
            Clear_Dados();
        }
        */

        /*        public void Clear_Dados()
                {

                    txtRazaoSocial.Text = "";
                    txtNomeFantasia.Text = "";
                    mtxtTelefone.Text = "";
                    txtEmail.Text = "";
                    mtxt_celular.Text = "";
                    mtxt_cep.Text = "";
                    mtxt_cpf.Text = "";
                    txt_endereco.Text = "";
                    txt_bairro.Text = "";
                    txt_cidade.Text = "";
                    txt_complemento.Text = "";
                    txt_numero.Text = "";
                    cb_uf.Text = "";
                    txt_Senha.Text = "";
                    txt_Usuario.Text = "";

                    gp_dadosfunc.Enabled = true;
                    groupBox3.Enabled = true;
                }*/

        private bool validaRazaoSocialNomeFantasia()
        {
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

            return true;
        }

        private bool validaTelefone()
        {
            //Validação Telefone
            if (
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
                mensagemDeErro("Infelizmente, o valor preenchido no campo \"Telefone\" não é válido. Certifique-se de que o número está correto.");
                mtxtTelefoneDeContato.Focus();
                return false;
            }

            return true;
        }

        private bool validaCpfCnpj()
        {
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

                if (mtxtCPF.Visible)
                    mtxtCPF.Focus();
                else if (mtxtCNPJ.Visible)
                    mtxtCNPJ.Focus();

                return false;
            }


            if (
                mtxtCNPJ.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace("_", "")
                .Replace("/", "")
                .Replace("-", "").Length < 14
                &&
                mtxtCPF.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace("_", "")
                .Replace("/", "")
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

            string documento = "";

            if (mtxtCPF.Visible)
                documento = mtxtCPF.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace("_", "")
                .Replace("-", "");
            else if (mtxtCNPJ.Visible)
                documento = mtxtCNPJ.Text
                .Replace(" ", "")
                .Replace("/", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace("_", "")
                .Replace("-", "");

            if (!ValidaCPF(documento))
            {
                mensagemDeErro("Infelizmente, um documento com esse número já conta no banco. Certifique-se do número e tente novamente.");

                return false;
            }

            if (mtxtCPF.Visible)
                documento = mtxtCPF.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace("_", "")
                .Replace("-", "");
            else if (mtxtCNPJ.Visible)
                documento = mtxtCNPJ.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace("_", "")
                .Replace("-", "");

            return true;
        }

        private bool validaNomeResponsavel()
        {
            //Validação Nome do responsável
            if (
                txtResponsavel.Text.Length > 0
                &&
                txtResponsavel.Text.Length < 3
                )
            {
                mensagemDeErro("Infelizmente, o nome dado no campo \"Resposável\" não é válido. Certifique-se de que o nome está correto.");
                txtResponsavel.Focus();
                return false;
            }

            return true;
        }

        private bool validaEmailResponsavel()
        {
            //Validação email do Responsável
            string email = txtEmailResponsavel.Text;
            bool arroba = false;
            bool dominio = false;
            bool ponto = false;
            bool final = false;


            for (int i = 0; i < email.Length; i++)
            {
                if (email[i].ToString() == "@")
                    arroba = true;

                try
                {
                    if
                    (
                    dominio == false
                    &&
                    arroba == true
                    &&
                    email[i + 1].ToString() != "."
                    )
                        dominio = true;
                }
                catch (Exception e)
                {

                }

                if
                    (
                    arroba == true
                    &&
                    dominio == true
                    &&
                    email[i].ToString() == "."
                    )
                    ponto = true;

                if (
                    arroba == true
                    &&
                    dominio == true
                    &&
                    ponto == true
                    &&
                        (
                        email.Substring(i + 1, email.Length - i - 1).ToString().Contains("com")
                        ||
                        email.Substring(i + 1, email.Length - i - 1).ToString().Contains("net")
                        ||
                        email.Substring(i + 1, email.Length - i - 1).ToString().Contains("gov")
                        ||
                        email.Substring(i + 1, email.Length - i - 1).ToString().Contains("br")
                        ||
                        email.Substring(i + 1, email.Length - i - 1).ToString().Contains("inf")
                        )
                    )
                    final = true;
            }

            if
                (
                arroba == false
                ||
                dominio == false
                ||
                ponto == false
                ||
                final == false
                )
            {
                mensagemDeErro("Infelizmente, o endereço fornecido no campo \"Email\" não é válido. Por favor, utilize um endereço de email válido.");
                txtEmailResponsavel.Focus();
                return false;
            }

            return true;
        }

        private bool validaCelular()
        {
            //Validação de celular
            if (
                mtxtCelular.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "").Length == 0
                )
            {
                mensagemDeErro("Por favor, é preciso que o campo \"Celular\" seja preenchido para que o processo de cadastro possa seguir até o final.");
                mtxtCelular.Focus();
                return false;
            }
            else if (
                mtxtCelular.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "").Length > 0
                &&
                mtxtCelular.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "").Length < 11
                )
            {
                mensagemDeErro("Infelizmente, o valor preenchido no campo \"Celular\" não é válido. Certifique-se de que o número está correto.");
                mtxtCelular.Focus();
                return false;
            }

            return true;
        }

        private bool validaBanco()
        {
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

            return true;

        }

        private bool validaAgencia()
        {
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
            return true;
        }

        private bool validaConta()
        {
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

        private bool validaNomeDeRua()
        {

            if (
                txtNomeDaRua.TextLength > 0
                &&
                txtNomeDaRua.TextLength < 5
                )
            {
                mensagemDeErro("Infelizmente, o valor preenchido no campo \"Nome da Rua\" não é válido. Certifique-se de que o nome está correto.");
                txtNomeDaRua.Focus();
                return false;
            }
            return true;
        }

        private bool validaNumeroFornecedor()
        {

            if (txtNumero.Text.Length != 0)
                for (int i = 0; i < txtNumero.Text.Length; i++)
                    if (!char.IsNumber(txtNumero.Text[i]))
                    {
                        mensagemDeErro("É permitido apenas o uso de números no campo \"Número\" na sessão de \"Dados de localidade\". Por favor, certifique-se de que o valor preenchido está correto.");
                        txtNumero.Focus();
                        return false;
                    }
            return true;
        }

        private bool validaCEP()
        {
            string CEP =
            mtxtCEP.Text
            .Replace("_", "")
            .Replace("-", "")
            .Replace(" ", "");

            if (CEP.Length != 0 && CEP.Length < 8)
            {
                mensagemDeErro("Infelizmente, o valor preenchido no campo \"CEP\" não é válido. Certifique-se de que o número está correto.");
                mtxtCEP.Focus();
                return false;
            }
            return true;
        }

        private bool validaBairro()
        {
            if (txtBairro.TextLength > 0
                &&
                txtBairro.TextLength < 5
                )
            {
                mensagemDeErro("Infelizmente, o valor preenchido no campo \"Bairro\" não é válido. Certifique-se de que o número está correto.");
                txtBairro.Focus();
                return false;
            }
            return true;
        }

        private bool validaCidade()
        {

            if (
                txtCidade.TextLength > 0
                &&
                txtCidade.TextLength < 3
                )
            {
                mensagemDeErro("Infelizmente, o conteúdo preenchido no campo \"Cidade\" não é válido. Certifique-se de que o conteúdo está correto.");
                txtBairro.Focus();

                return false;
            }
            return true;
        }

        private bool validaCampos()
        {

            if(!validaRazaoSocialNomeFantasia())
                return false;

            if (!validaTelefone())
                return false;

            if (!validaCpfCnpj())
                return false;

            if (!validaNomeResponsavel())
                return false;

            if (!validaEmailResponsavel())
                return false;

            if (!validaCelular())
                return false;

            if (!validaBanco())
                return false;

            if (!validaAgencia())
                return false;

            if (!validaConta())
                return false;

            if (!validaNomeDeRua())
                return false;

            if (!validaNumeroFornecedor())
                return false;

            if (!validaBairro())
                return false;

            if (!validaCEP())
                return false;

            if (!validaCidade())
                return false;

            return true;
        }

        private int verificarSeExiste(string strValida) 
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

//                if (dt.Rows.Count > 0)
                
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao consultar o documento do Fornecedor");
            }

            return dt.Rows.Count;

            conn.Close();
        }

        public bool validaBusca()
        {
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
                mensagemDeErro("Para buscar um fornecedor, o campo de Documento tem que estar preenchido. Por favor, certifique-se de que uma informação válida foi passada e tente novamente.");

                setFocusDocumento();

                return false;
            }

            if (
                mtxtCPF.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(".", "")
                .Replace("_", "")
                .Replace("/", "")
                .Replace("-", "").Length == 0
                &&
                mtxtCNPJ.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace("_", "")
                .Replace("-", "").Length < 14
                )
            {
                mensagemDeErro("Infelizmente, o número de CNPJ passado é inválido. Por favor, certifique-se de que o valor digitado está correto.");

                setFocusDocumento();

                return false;

            }

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
                .Replace("-", "").Length < 11
                )
            {
                mensagemDeErro("Infelizmente, o número de CPF passado é inválido. Por favor, certifique-se de que o valor digitado está correto.");

                setFocusDocumento();

                return false;

            }

            return true;
        }

        public void setFocusDocumento()
        {
            if (mtxtCPF.Visible)
                mtxtCPF.Focus();
            else if (mtxtCNPJ.Visible)
                mtxtCNPJ.Focus();
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

        public void AtualizaFunc(string stringUpd)
        {
            conn = new SqlConnection(conexao);
            conn.Open();

            try
            {
                SqlCommand sqlComm = new SqlCommand(stringUpd, conn);

                sqlComm.ExecuteNonQuery();

                //Seleciona Cargo
                DataTable dt = new DataTable();
                try
                {
                    stringUpd = "select cod_Permissao from Permissao where Cargo = '" + cargo + "'";
                    sqlComm = new SqlCommand(stringUpd, conn);

                    sqlComm.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    da.Fill(dt);
                    cod_permissao = dt.Rows[0][0].ToString();

                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao Selecionar o Cargo");
                }



                stringUpd = "update FUncPermissao set Login_ = '" + usuario + "',senha='" + senha + "',cod_Permissao = '" + cod_permissao + "' where cod_Funcionario ='" + cod_cliente + "'";
                sqlComm = new SqlCommand(stringUpd, conn);
                sqlComm.ExecuteNonQuery();

                stringUpd = "update Funcionario set cod_Permissao = '" + cod_permissao + "',Usuario_Funcionario='" + usuario + "' where cod_Funcionario ='" + cod_cliente + "'";
                sqlComm = new SqlCommand(stringUpd, conn);
                sqlComm.ExecuteNonQuery();




                MessageBox.Show("Dados do funcionario Atualizado");
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao Atualizar Funcionario");



            }
            conn.Close();

            //preencherGrid();

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
                {
                    mensagemDeErro("Um fornecedor com esse documento já existe. Certifique-se de que o número do documento esteja correto e tente de novo.");

                    return false;
                }
                    
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao consultar o documento do Fornecedor");
            }

            conn.Close();

            return true;
        }

        public void preencherGrid()
        {

            string strIncluir = "select * from Fornecedor";
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();

            try
            {
                SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                //sqlComm.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgvFornecedores.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao conectar ao Bano de Dados, Contate seu suporte");
            }

            conn.Close();
        }

        public string preencherComandoInsert(TextBox campo)
        {/*(12121212112, 'razao', 'fantasia', 111, 22222222, 33333333, 'nome', '(11) 98936-1878', 'email@email.com', '(11) 1111-1111', 'nome rua', 321, '015460100', 'SP', 'Cidade', 'Bairro', 'Complemento')*/

            string comando = "";

            comando += ", '" + campo.Text + "'";

            if (comando.Length == 0)
                comando = "0";

            return comando;

        }

        public string preencherComandoInsert(MaskedTextBox campo)
        {

            string comando = "";

            comando += ", '" + campo.Text + "'";

            if (comando.Length == 0)
                comando = "0";

            return comando;

        }

        public string preencherComandoInsert(ComboBox campo)
        {

            string comando = "";

            comando += ", '" + campo.Text + "'";

            if (comando.Length == 0)
                comando = "0";

            return comando;

        }

        public void inserirFornecedor()
        {
            //Insere dados
            conn = new SqlConnection(conexao);
            /*            strIncluir = 
                            "insert into Produto (Nome_Produto, Valor_venda,validade,qtd_Estoque,cod_categoria) values ('" + nome + "','" + valoruntd + "','" + datavalidade + "','" + qtd + "','" + dt.Rows[0][0].ToString() + "')";*/

            string documento = "'";

            if (mtxtCPF.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(".", "")
                .Replace("_", "")
                .Replace("/", "")
                .Replace("-", "").Length > 0)
                documento +=mtxtCPF.Text;

            else if (mtxtCNPJ.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(".", "")
                .Replace("_", "")
                .Replace("/", "")
                .Replace("-", "").Length > 0)
                documento += mtxtCNPJ.Text;

            documento += "'";

            string CEP =
                mtxtCEP.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(".", "")
                .Replace("_", "")
                .Replace("/", "")
                .Replace("-", "");

            /*            strIncluir = "insert into Fornecedor (CNPJ_CPF,Razao_Social,Nome_Fantasia,Nome_Banco,Agencia,Conta_Corrente,Responsavel,Celular_Responsavel,Email_Responsavel,Telefone_Comercial,Endereco_Fornecedor,Numero_Residencia,CEP_Fornecedor,Estado_Fornecedor,Cidade_Fornecedor,Bairro_Fornecedor,Complemento)values(11111111111,'razao','fantasia','111','22222222','33333333','1','(11) 1111-1111','asdf!@aasdf.com','1','1','1','1','1','1','1','1')";*/

            strIncluir = "insert into Fornecedor (CNPJ_CPF, Razao_Social, Nome_Fantasia, Nome_Banco, Agencia, Conta_Corrente, Responsavel, Celular_Responsavel, Email_Responsavel, Telefone_Comercial, Endereco_Fornecedor, Numero_Residencia, CEP_Fornecedor, Estado_Fornecedor, Cidade_Fornecedor, Bairro_Fornecedor,Complemento) values (";


            strIncluir += documento;
            strIncluir += preencherComandoInsert(txtRazaoSocial);
            strIncluir += preencherComandoInsert(txtNomeFantasia);
            strIncluir += preencherComandoInsert(txtBanco);
            strIncluir += preencherComandoInsert(txtAgencia);
            strIncluir += preencherComandoInsert(txtConta);
            strIncluir += preencherComandoInsert(txtResponsavel);
            strIncluir += preencherComandoInsert(mtxtCelular);
            strIncluir += preencherComandoInsert(txtEmailResponsavel);
            strIncluir += preencherComandoInsert(mtxtTelefoneDeContato);
            strIncluir += preencherComandoInsert(txtNomeDaRua);
            strIncluir += preencherComandoInsert(txtNumero);
            strIncluir += ", '" + CEP + "'";
            strIncluir += preencherComandoInsert(cbxUF);
            strIncluir += preencherComandoInsert(txtCidade);
            strIncluir += preencherComandoInsert(txtBairro);
            strIncluir += preencherComandoInsert(txtComplemento);

            strIncluir += ")";



            conn.Open();
            sqlComm = new SqlCommand(strIncluir, conn);
            sqlComm.ExecuteNonQuery();
        }

        public DataTable Buscar(string documento)
        {
            string stringDeBusca = "select * from Fornecedor where CNPJ_CPF = '" + documento + "'"; ;

            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand sqlComm = new SqlCommand(stringDeBusca, conn);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dtgvFornecedores.DataSource = dt;

            return dt;

/*            SqlConnection conn = new SqlConnection(conexao);

            conn.Open();
            DataTable dt = new DataTable();

            try
            {


                SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                sqlComm.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dtgvFornecedores.Columns.Clear();
                    dtgvFornecedores.DataSource = dt;
                }

                return dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Infelizmente houve uma falha ao entrar em contato com o banco e a operação foi cancelada.");

                return dt;
            }
            conn.Close();*/


        }

        public void limparCampos()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);

                foreach (Control control in controls)
                    if (control is MaskedTextBox)
                        (control as MaskedTextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        public void excluirFornecedor()
        {
            conn = new SqlConnection(conexao);
            conn.Open();
            try
            {
                string documento = "";

                documento = dtgvFornecedores.CurrentRow.Cells[1].Value.ToString();

                string strExclui = "delete Fornecedor where CNPJ_CPF = '" + documento + "'";
                SqlCommand sqlComm = new SqlCommand(strExclui, conn);
                sqlComm.ExecuteNonQuery();

                sqlComm = new SqlCommand(strExclui, conn);
                sqlComm.ExecuteNonQuery();
                MessageBox.Show("Fornecedor excluído com sucesso.");
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao excluir o fornecedor.");
            }
            conn.Close();

            preencherGrid();
        }

        public bool verificarSeJaExisteFornecedor(string strDocumento) 
        {
            strDocumento = "select * from Fornecedor where CNPJ_CPF = '" + strDocumento + "'";
            SqlConnection conn = new SqlConnection(conexao);
            DataTable dt = new DataTable();
            conn.Open();

            try
            {
                SqlCommand sqlComm = new SqlCommand(strDocumento, conn);
                sqlComm.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao consultar CPF do Fornecedor");
            }

            conn.Close();

            return true;
        }

        /*
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
                {
                    mensagemDeErro("Um fornecedor com esse documento já existe. Certifique-se de que o número do documento esteja correto e tente de novo.");

                    return false;
                }
                    
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao consultar o documento do Fornecedor");
            }

            conn.Close();

            return true;*/

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

            if(!validaCampos())
                return;

            string documento = "";

            if (mtxtCPF.Visible)
                documento = mtxtCPF.Text;
            else
                documento = mtxtCNPJ.Text;

            if(ValidaCPF(documento))
                inserirFornecedor();

            preencherGrid();

        }

        private void txtBanco_TextChanged(object sender, EventArgs e)
        {

        }

        private void butto1_nClick(object sender, EventArgs e)
        {

        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {
            rdCNPJ.Checked = true;

            preencherGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Vê se CPF ou CNPJ foi preenchido
            if(!validaBusca())
                return;

            string documento = "";

            if (
                mtxtCNPJ.Text
                .Replace(" ", "")
                .Replace(".", "")
                .Replace(".", "")
                .Replace("_", "")
                .Replace("/", "")
                .Replace("-", "").Length != 0)
                documento = mtxtCNPJ.Text;
            else
                documento = mtxtCPF.Text;

            Buscar(documento);

/*            strIncluir = "select * from Fornecedor where 'CPF_CNPJ' = '" + documento + "'";
            DataTable conteudo = new DataTable();
            conteudo = Buscar(strIncluir);*/



//            txtRazaoSocial.Text = conteudo.Rows[0][1].ToString();
           /* mtxt_cpf.Text = conteudo.Rows[0][2].ToString();
            txt_endereco.Text = conteudo.Rows[0][3].ToString();
            txt_complemento.Text = conteudo.Rows[0][4].ToString();
            txt_numero.Text = conteudo.Rows[0][5].ToString();
            mtxt_cep.Text = conteudo.Rows[0][6].ToString();
            //Verificar logica para selecionar de acordo com o texto
            //cb_uf.SelectedText.Text = dtgw_dados.CurrentRow.Cells[7].Value.ToString();
            txt_cidade.Text = conteudo.Rows[0][8].ToString();
            txt_email.Text = conteudo.Rows[0][9].ToString();
            txt_bairro.Text = conteudo.Rows[0][10].ToString();
            mtxt_celular.Text = conteudo.Rows[0][11].ToString();
            mtxt_telefone.Text = conteudo.Rows[0][12].ToString();


            gp_dadosfunc.Enabled = false;
            groupBox3.Enabled = false;   */

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirFornecedor();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
