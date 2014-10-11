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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        string conexao = "Data Source=ALEX\\SQLEXPRESS ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=1234";
       

         private void btn_sair_Click(object sender, EventArgs e)
         {
             Close();
         }

         private void Compras_Load(object sender, EventArgs e)
         {
        

         }

         private void gpb_compras_Enter(object sender, EventArgs e)
         {

         }

         private void btn_excluir_Click(object sender, EventArgs e)
         {

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

         private void btn_alterar_Click(object sender, EventArgs e)
         {

         }

         private void btn_inserir_Click(object sender, EventArgs e)
         {/*
             string[] mItens = new string[]
             {
             txt_nome.Text,
             cmb_categoria.SelectedItem.ToString(),
             txt_vlrunitario.Text,
             txt_qdtcomprada.Text,
             cmb_fornecedores.SelectionStart.ToString(),
             txt_totalnota.Text,
             dtp_datarecebimento.Text,
     
             };
             ListViewItem lvi = new ListViewItem(mItens);
             lstv_gravacao.Items.Add(lvi);*/
         }

         private void dtg_gravacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }

         private void lbl_qtdcomprada_Click(object sender, EventArgs e)
         {

         }

         private void txt_qdtcomprada_TextChanged(object sender, EventArgs e)
         {

         }

         private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
         {

         }
    }
}
