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
            //conexao = "Data Source=localhost; Initial Catalog=Pizzaria; Persist Security Info = True; User ID=SA; Password=peganomeupau";
            SqlConnection conn = new SqlConnection(conexao);

            conn.Open();
            SqlCommand sqlComm = new SqlCommand(busca, conn);
            //            sqlComm.ExecuteNonQuery();
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

       /* public void atualizarRegistro()
        {
            cod_cliente = dtgw_dados.CurrentRow.Cells[0].Value.ToString();


            strIncluir = "update cliente set Nome_Cliente = '" + txt_nome.Text + "',CPF_Cliente = '" + mtxt_cpf.Text + "',Endereco_Cliente = '" + txt_endereco.Text + "',Complemento_Cliente ='" + txt_complemento.Text + "',Numero_Residencia = '" + txt_numero.Text + "',CEP_Cliente = '" + mtxt_cep.Text + "',Estado_Cliente = '" + cb_uf.Text + "',Cidade_Cliente = '" + txt_cidade.Text + "' ,Email_Cliente = '" + txtEmail.Text + "' ,Telefone_Cliente = '" + mtxt_telefone.Text + "' ,Celular_Cliente = '" + mtxt_celular.Text + "' ,Bairro_Cliente = '" + txt_bairro.Text + "' where Cod_Cliente =  '" + cod_cliente + "'";

            preencherGrid(strIncluir, dtgw_dados);

            
        }*/

        private void btn_gravar_Click_1(object sender, EventArgs e)
        {

            if (!validaCampos())
                return;

            // preencherGrid("insert into Cliente (Nome_Cliente,CPF_Cliente,Endereco_Cliente,Complemento_Cliente ,Numero_Residencia ,CEP_Cliente,Estado_Cliente,Cidade_Cliente ,Email_Cliente ,Telefone_Cliente ,Celular_Cliente ,Bairro_Cliente) values ('" + txt_nome.Text + "','" + mtxt_cpf.Text + "','" + txt_endereco.Text + "','" + txt_complemento.Text + "','" + txt_numero.Text + "','" + mtxt_cep.Text + "','" + cb_uf.Text + "','" + txt_cidade.Text + "','" + txtEmail.Text + "','" + mtxt_telefone.Text + "','" + mtxt_celular.Text + "','" + txt_bairro.Text + "')", dtgw_dados);
            // txt_bairro.Text + "')", dtgw_dados);
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
            

            //btn_excluir.Enabled = true;
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
//                btn_excluir.Enabled = true;
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

/*        public Boolean ValidaCampos()
        {

            // MessageBox.Show("teste");
            if (txt_nome.TextLength > 1)
            {
                if (mtxt_cpf.Text.Replace(" ", "").Length == 14)
                {
                    if (mtxt_telefone.Text.Replace(" ", "").Length == 13)
                    {
                        //  MessageBox.Show(mtxt_telefone.Text.Replace("i", "").Length.ToString());
                        //    MessageBox.Show(mtxt_cpf.Text.Replace("i", "").Length.ToString());
                        // if (txt_nome.TextLength > 3 && txt_telefone.TextLength > 9 && mtxt_telefone.Text.Replace(" ", "").Length == 13 && mtxt_celular.TextLength > 8 && mtxt_cpf.Text.Replace(" ", "").Length == 14)
                        //   {

                        //   if (txt_endereco.TextLength > 6 && txt_bairro.TextLength > 6 && txt_complemento.TextLength > 6 && txt_cidade.TextLength > 6 && txt_numero.TextLength > 6 && cb_uf.SelectionLength > 6)
                        //    {


                        if (txt_nome.TextLength > 3)
                        {
                            nome = txt_nome.Text.ToString();
                        }
                        else
                        {
                            nome = "";

                        }
                        // MessageBox.Show(mtxt_telefone.Text);
                        telefone = mtxt_telefone.Text;
                        if (txtEmail.TextLength > 3)
                        {
                            email = txtEmail.Text;
                        }
                        else
                        {
                            email = "";
                        }
                        if (mtxt_celular.Text.Replace(" ", "").Length > 3)
                        {
                            cel = mtxt_celular.Text;
                        }
                        else { cel = ""; }
                        if (mtxt_cep.Text.Replace(" ", "").Length > 3)
                        {
                            cep = mtxt_cep.Text;
                        }
                        else { cep = ""; }
                        if (mtxt_cpf.Text.Replace(" ", "").Length > 3)
                        {
                            cpf = mtxt_cpf.Text;
                        }
                        else { cpf = ""; }
                        if (txt_endereco.TextLength > 3)
                        {
                            endereco = txt_endereco.Text.ToString();
                        }
                        else { endereco = ""; }
                        if (txt_bairro.TextLength > 3)
                        {
                            bairro = txt_bairro.Text;
                        }
                        else { bairro = ""; }
                        if (txt_cidade.TextLength > 3)
                        {
                            cidade = txt_cidade.Text.ToString();
                        }
                        else { cidade = ""; }
                        if (txt_complemento.TextLength > 3)
                        {
                            complemento = txt_complemento.Text.ToString();
                        }
                        else { complemento = ""; }
                        if (txt_numero.TextLength != 0)
                        {
                            num_endereco = Convert.ToInt32(txt_numero.Text.ToString());
                        }
                        else { num_endereco = 0; }
                        if (cb_uf.SelectedIndex < 1)
                        {
                            uf = cb_uf.SelectedIndex.ToString();
                        }
                        else { uf = ""; }
                       // MessageBox.Show(dtp_datanasc.Value.Date.ToString());
                       // MessageBox.Show("fim");
                        //MessageBox.Show(cb_uf.SelectedItem.ToString());
                        // MessageBox.Show(cb_uf.SelectedIndex.ToString());

                        return true;



                    }

                    else
                    {
                        MessageBox.Show("Telefone Incorreto!");
                    }
                }
                else
                {
                    MessageBox.Show("CPF Incorreto!");
                }
            }
            else
            {
                MessageBox.Show("Nome incorreto!");
            }
            return false;

        }*/

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
           /* txtBuscaPorNome.Text = "";

            string cpfOriginal = mtxtBuscaPorCPF.Text/*.Replace(" ", "").Replace(".", "").Replace(" ","")*/;
            /*
            string cpfCorrigido = "";
            bool primeiroNumeroDoStringEncontardo = false;
            int i = 0;

            if (mtxtBuscaPorCPF.Text != "   .   .   -")
            {
                while (!primeiroNumeroDoStringEncontardo)
                {
                    if (char.IsNumber(cpfOriginal[i]))
                        break;
                    i++;
                }

                for (int j = i; j < cpfOriginal.Length; j++)
                    if (cpfOriginal[j].ToString() != " ")
                        cpfCorrigido += cpfOriginal[j].ToString();
                    else
                        break;
            }

            preencherGrid("select Cod_Cliente, Nome_Cliente ,CPF_Cliente from cliente where CPF_Cliente like ('%" + cpfCorrigido + "%')", dtgw_dados);
            */
            /*            txt_nome.Clear();
                        txtPalavraChave.Clear();
                        txtIDProduto.Clear();
                        btn_inserir.Enabled = false;
                        limparGrid(gridProdutosEncontrados);
                        limparGrid(gridProdutosConsumidos);
                        btn_remover.Enabled = false;*/


            clsCliente teste = new clsCliente();
            clsClienteBLL teste1 = new clsClienteBLL();
            //teste.Cpf_Cliente = mtxtBuscaPorCPF.Text.ToString().replace(replace(replace(Replace("-", ""), ".", ""), "_", ""), " ", "");
            teste.Cpf_Cliente = mtxtBuscaPorCPF.Text.ToString().Replace("-","").Replace(".","").Replace("_","").Replace(" ","");
            //teste1.SelectCliente(teste);

            dtgw_dados.DataSource = teste1.SelectCliente(teste);
        }

    }


}
