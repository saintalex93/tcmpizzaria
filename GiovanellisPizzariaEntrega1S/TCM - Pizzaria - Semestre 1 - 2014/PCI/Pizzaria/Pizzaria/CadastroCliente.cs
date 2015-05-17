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
using Microsoft.VisualBasic;

using BLL;
using DAL.Model;

namespace Pizzaria
{
    public partial class CadastroCliente : Form
    {

        public CadastroCliente()
        {
            
            InitializeComponent();
        }

        public Form FormHome { get; set; }

        //Variaveis de dados
        string conexao = "";
        SqlConnection conn;
        string cod_cliente, nome = "", cep="",email = "", endereco = "", bairro = "", cidade = "", uf = "", complemento = "", telefone = "", cel = "", cpf = "",strIncluir = "";
        DateTime datanasc;
        int num_endereco = 0;
        
        //Validar se e update ou insert
        Boolean valida = false;

        public void preencherGrid(string busca, DataGridView tabela)
        {
            SqlConnection conn = new SqlConnection(conexao);

            conn.Open();
            SqlCommand sqlComm = new SqlCommand(busca, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabela.DataSource = dt;
            conn.Close();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.FormHome.Show();
            Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {}

        private void CadastroCliente_Load_1(object sender, EventArgs e)
        {
            //conexao = Acesso.Conexao;
            
            preenchegrid();
            
           // this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_gravar_Click_1(object sender, EventArgs e)
        {

            if (!validaCampos())
                return;

            clsCliente teste = new clsCliente();

            teste.Nome_Cliente = txt_nome.Text.ToString();
            teste.Cpf_Cliente = mtxt_cpf.Text.ToString();
            teste.Endereco_Cliente = txt_endereco.Text.ToString();
            teste.Complemento_Cliente = txt_complemento.Text.ToString();
            teste.Numero_Residencia = Int32.Parse(txt_numero.Text.ToString());
            teste.Cep_Cliente = mtxt_cep.Text.ToString();
            teste.Estado_Cliente = cb_uf.SelectedItem.ToString();
            teste.Cidade_Cliente = txt_cidade.Text.ToString();
            teste.Email_Cliente = txtEmail.Text.ToString();
            teste.Telefone_Cliente = mtxt_telefone.Text.ToString();
            teste.Celular_Cliente = mtxt_celular.Text.ToString();
            teste.Bairro_Cliente = txt_bairro.Text.ToString();
            teste.Numero_Apartamento = Int32.Parse(txt_Num_Apt.Text.ToString());
            teste.DataCadastro = DateTime.Today.ToString("yyyy/MM/dd");
            datanasc = dtp_datanasc.Value;
            teste.DataNascimento = datanasc.ToString("yyyy/MM/dd");
            teste.Senha_Cliente = textBox1.Text.ToString();

            clsClienteBLL teste1 = new clsClienteBLL();

            dtgw_dados.DataSource = teste1.InsereCliente(teste);

            btn_alterar.Enabled = false;

            preenchegrid();

            limparCampos();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (mtxt_cpf.Text.Replace(" ", "").Length == 14)
            {
                cpf = mtxt_cpf.Text;
                strIncluir = "select * from CLiente where CPF_Cliente = '" + cpf + "'";
                Buscar(strIncluir);
            }

            else
            {
                strIncluir = "select * from CLiente";
                Buscar(strIncluir);
            }

        }

        private void dtgw_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nome.Text = dtgw_dados.CurrentRow.Cells[1].Value.ToString();
            mtxt_cpf.Text = dtgw_dados.CurrentRow.Cells[2].Value.ToString();
            txt_endereco.Text = dtgw_dados.CurrentRow.Cells[3].Value.ToString();
            txt_complemento.Text = dtgw_dados.CurrentRow.Cells[10].Value.ToString();
            txt_Num_Apt.Text = dtgw_dados.CurrentRow.Cells[5].Value.ToString();
            txt_numero.Text = dtgw_dados.CurrentRow.Cells[4].Value.ToString();
            mtxt_cep.Text = dtgw_dados.CurrentRow.Cells[6].Value.ToString();
            //Verificar logica para selecionar de acordo com o texto
            //cb_uf.SelectedText.Text = dtgw_dados.CurrentRow.Cells[7].Value.ToString();
            txt_cidade.Text = dtgw_dados.CurrentRow.Cells[9].Value.ToString();
            txtEmail.Text = dtgw_dados.CurrentRow.Cells[13].Value.ToString();
            textBox1.Text = dtgw_dados.CurrentRow.Cells[14].Value.ToString();
            mtxt_telefone.Text = dtgw_dados.CurrentRow.Cells[11].Value.ToString();
            mtxt_celular.Text = dtgw_dados.CurrentRow.Cells[12].Value.ToString();
            txt_bairro.Text = dtgw_dados.CurrentRow.Cells[6].Value.ToString();
            mtxt_cep.Text = dtgw_dados.CurrentRow.Cells[7].Value.ToString();

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            
            btn_alterar.Enabled = true;
            btn_alterar.Text = "Alterar";
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (btn_alterar.Text == "Alterar")
            {
                btn_alterar.Text = "Salvar";
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                valida = true;
            }

            else 
            {
                if (!validaCampos())
                    return;

                btn_alterar.Text = "Alterar";

                string idCliente = dtgw_dados.CurrentRow.Cells[0].Value.ToString();

                clsCliente teste = new clsCliente();
                teste.Cod_Cliente = Int32.Parse(idCliente);
                teste.Nome_Cliente = txt_nome.Text.ToString();
                teste.Cpf_Cliente = mtxt_cpf.Text.ToString();
                teste.Endereco_Cliente = txt_endereco.Text.ToString();
                teste.Complemento_Cliente = txt_complemento.Text.ToString();
                teste.Numero_Residencia = Int32.Parse(txt_numero.Text.ToString());
                teste.Cep_Cliente = mtxt_cep.Text.ToString();
                teste.Estado_Cliente = cb_uf.SelectedItem.ToString();
                teste.Cidade_Cliente = txt_cidade.Text.ToString();
                teste.Email_Cliente = txtEmail.Text.ToString();
                teste.Telefone_Cliente = mtxt_telefone.Text.ToString();
                teste.Celular_Cliente = mtxt_celular.Text.ToString();
                teste.Bairro_Cliente = txt_bairro.Text.ToString();
                teste.Numero_Apartamento = Int32.Parse(txt_Num_Apt.Text.ToString());
                teste.DataCadastro = DateTime.Today.ToString("yyyy/MM/dd");
                datanasc = dtp_datanasc.Value;
                teste.DataNascimento = datanasc.ToString("yyyy/MM/dd");
                teste.Senha_Cliente = textBox1.Text.ToString();

                clsClienteBLL teste1 = new clsClienteBLL();
                
                dtgw_dados.DataSource = teste1.AtualizaCliente(teste);
                btn_alterar.Enabled = false;
                preenchegrid();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Dados();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult decisao = MessageBox.Show("Tem certeza que deseja remover esse registro?", "Remover Registro", MessageBoxButtons.YesNo);
            if (decisao == DialogResult.Yes)
            {
                int idCliente = Convert.ToInt32(dtgw_dados.CurrentRow.Cells[0].Value);

                preencherGrid("UPDATE Pedido set Cod_Cliente = 1 where Cod_Cliente = " + idCliente, dtgw_dados);

                preencherGrid("DELETE FROM cliente where Cod_cliente =" + idCliente, dtgw_dados);

                preenchegrid();
            }
        }

        public void Clear_Dados()
        {

            txt_nome.Text = "";
            mtxt_telefone.Text = "";
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

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }

        public void preenchegrid()
        {
            clsCliente teste = new clsCliente();     
            clsClienteBLL teste1 = new clsClienteBLL();
            dtgw_dados.DataSource = teste1.SelectCliente(teste);
        }

        public bool validaNome()
        {
            bool estado = true;

            if (txt_nome.Text.Length == 0)
            {
                Home.mensagemDeErro("Não é permitido inserir um usuário sem nome.", "Falta de informações");
                
                txt_nome.Focus();

                estado = false;
            }

            if (txt_nome.Text.Length < 4)
            {
                Home.mensagemDeErro("Nome de usuário não permitido.", "Informações inadequada");

                txt_nome.Focus();

                estado = false;
            }

            return estado;
        }

        public bool validaTelefone() 
        {
            bool estado = true;

            if (mtxt_telefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Length > 10)
            {
                Home.mensagemDeErro("O telefone fornecido não é válido.", "Telefone inválido");

                mtxt_telefone.Focus();

                estado = false;
            }
            return estado;
        }

        public bool validaCelular()
        {
            bool estado = true;

            if (mtxt_celular.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Length > 11)
            {
                Home.mensagemDeErro("O celular fornecido não é válido.", "Telefone inválido");

                mtxt_celular.Focus();

                estado = false;
            }

            return estado;

        }

        public bool validaCPF()
        {
            bool estado = true;

            if (mtxt_cpf.Text.Replace(".","").Replace(" ","").Replace("-","").Replace("_","").Length < 11)
            {
                Home.mensagemDeErro("CPF inválido. Por favor, verifique sua validade", "CPF inválido");

                mtxt_cpf.Focus();

                estado = false;
            }

            return estado;
        }

        private bool validaEmail()
        {
            //Validação email do Responsável
            string email = txtEmail.Text;
            bool arroba = false;
            bool dominio = false;
            bool ponto = false;
            bool final = false;

            if (txtEmail.Text.Length == 0)
            {
                Home.mensagemDeErro("Não é permitido inserir um usuário sem email de contato.", "Usuário sem email");

                txtEmail.Focus();

                return false;
            }

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
                Home.mensagemDeErro("Infelizmente, o endereço fornecido no campo \"Email\" não é válido. Por favor, utilize um endereço de email válido.","Email inválido");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        public bool validaEndereco()
        {
            if (txt_endereco.Text.Length < 4)
            {
                Home.mensagemDeErro("Nome de rua inválido. Por favor, certifique-se de que ele esteja correto", "Nome de rua inválido");

                txt_endereco.Focus();

                return false;
            }

            return true;
        }

        public bool validaNumero()
        {
            if (txt_numero.Text.Length < 2)
            {
                Home.mensagemDeErro("Número de residência inválido. Por favor, certifique-se de que ele esteja correto", "Número de residência inválido");

                txt_numero.Focus();

                return false;
            }

            return true;
        }

        public bool validaBairro()
        {
            if (txt_bairro.Text.Length < 4)
            {
                Home.mensagemDeErro("Bairro inválido. Por favor, certifique-se de que ele esteja correto", "Bairro inválido");

                txt_bairro.Focus();

                return false;
            }

            return true;
        }

        public bool validaCEP()
        {
            if (mtxt_cep.Text.Replace(".", "").Replace("-", "").Replace(" ", "").Length < 8)
            {
                Home.mensagemDeErro("CEP inválido. Por favor, certifique-se de que ele esteja correto", "CEP inválido");

                mtxt_cep.Focus();

                return false;
            }

            return true;
        }

        public bool validaEstado()
        {
            if (cb_uf.Text.Length != 2)
            {
                Home.mensagemDeErro("Por favor, selecione um estado", "Estado inválido");

                cb_uf.Focus();

                return false;
            }

            return true;
        }

        public bool validaCampos() 
        {
            if (!validaNome())
                return false;

            if (!validaTelefone())
                return false;

            if (!validaCelular())
                return false;

            if (!validaCPF())
                return false;

            if (!validaEmail())
                return false;

            if (!validaEndereco())
                return false;

            if (!validaNumero())
                return false;

            if (!validaBairro())
                return false;

            if (!validaCEP())
                return false;

            if (!validaEstado())
                return false;
            
            return true;
        }

        public void limparCampos() 
        {
            txt_bairro.Clear();
            txt_cidade.Clear();
            txt_complemento.Clear();
            txt_endereco.Clear();
            txt_nome.Clear();
            txt_numero.Clear();
            txtEmail.Clear();
            mtxt_celular.Clear();
            mtxt_cep.Clear();
            mtxt_cpf.Clear();
            mtxt_telefone.Clear();
            dtp_datanasc.Value = DateTime.Today;
        }

        private DataTable Buscar(string strIncluir)
        {
            SqlConnection conn = new SqlConnection(conexao);

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
                    dtgw_dados.Columns.Clear();
                    dtgw_dados.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nenhum cliente com este CPF foi encontrado");
                }

                return dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao conectar ao Bano de Dados, Contate seu suporte");

                return dt;
            }
            conn.Close();
        }

        private void txt_nome_Leave(object sender, EventArgs e)
        {

        }

        private void txtBuscaPorNome_TextChanged(object sender, EventArgs e)
        {
            clsCliente teste = new clsCliente();
            clsClienteBLL teste1 = new clsClienteBLL();
            teste.Nome_Cliente = txtBuscaPorNome.Text.ToString();
            dtgw_dados.DataSource = teste1.SelectCliente(teste);

        }

        private void mtxtBuscaPorCPF_TextChanged(object sender, EventArgs e)
        {
            clsCliente teste = new clsCliente();
            clsClienteBLL teste1 = new clsClienteBLL();
            teste.Cpf_Cliente = mtxtBuscaPorCPF.Text.ToString().Replace("-","").Replace(".","").Replace("_","").Replace(" ","");

            dtgw_dados.DataSource = teste1.SelectCliente(teste);
        }
    }
}
