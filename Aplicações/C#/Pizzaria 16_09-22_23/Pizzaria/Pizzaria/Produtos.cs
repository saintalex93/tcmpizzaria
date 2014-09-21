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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        string conexao = "Data Source=LAB21T-10;Initial Catalog=Cadastro; Persist Security Info = True; User ID=aluno; Password=etesp";

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();

        }

   

        private void btn_gravar_Click(object sender, EventArgs e)
        {/*
            SqlConnection conn = new SqlConnection(conexao);
            string strIncluir = "insert into tb_Cadastro values('" + txt_nome.Text + "', '" + dtp_datanasc.Text + "', '" + mtxt_cpf.Text + "', '" + mtxt_rg.Text + "', '" + txt_mensagem.Text + "')";
            conn.Open();
            SqlCommand comando = new SqlCommand(strIncluir, conn);

            int retorno = (int)comando.ExecuteNonQuery();

            if (retorno > 0)
            {

                MessageBox.Show("Gravação realizada com sucesso!");
            }

            else
            {
                MessageBox.Show("Erro na gavação, verifique");

            }*/
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {/*
            string[] mItens = new string[]
            {
            txt_nome.Text,
            cmb_categoria.SelectedItem.ToString(),
            cmb_medida.SelectedItem.ToString(),
            txt_vlrunitario.Text,
            txt_qdtcomprada.Text,
            dtp_datarecebimento.Text,
            dtp_datafabricacao.Text,
            dtp_datavalidade.Text,
            txt_fornecedor.Text,


      
            };
            ListViewItem lvi = new ListViewItem(mItens);
            lstv_Gravacao.Items.Add(lvi);*/

        }

        public string txt { get; set; }

        public string dtp { get; set; }
    }
}
