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

         private void txt_nome_Leave(object sender, EventArgs e)
         {
             txt_nome.BackColor = Color.White;
         }

         private void txt_nome_Enter(object sender, EventArgs e)
         {
             txt_nome.BackColor = Color.Aquamarine;
         }

         private void cmb_categoria_Leave(object sender, EventArgs e)
         {
             cmb_categoria.BackColor = Color.White;
         }

         private void cmb_categoria_Enter(object sender, EventArgs e)
         {
             cmb_categoria.BackColor = Color.Aquamarine;
         }

         private void txt_qdtcomprada_Leave(object sender, EventArgs e)
         {
             txt_qdtcomprada.BackColor = Color.White;
         }

         private void txt_qdtcomprada_Enter(object sender, EventArgs e)
         {
             txt_qdtcomprada.BackColor = Color.Aquamarine;
         }

         private void txt_vlrunitario_Leave(object sender, EventArgs e)
         {
             txt_vlrunitario.BackColor = Color.White;
         }

         private void txt_vlrunitario_Enter(object sender, EventArgs e)
         {
             txt_vlrunitario.BackColor = Color.Aquamarine;
         }

         private void cb_fornecedores_Leave(object sender, EventArgs e)
         {
             cb_fornecedores.BackColor = Color.White;
         }

         private void cb_fornecedores_Enter(object sender, EventArgs e)
         {
             cb_fornecedores.BackColor = Color.Aquamarine;
         }

         private void lbl_totalnota_Leave(object sender, EventArgs e)
         {
             lbl_total.BackColor = Color.White;
         }

         private void lbl_totalnota_Enter(object sender, EventArgs e)
         {
             lbl_total.BackColor = Color.Aquamarine;
         }

         private void dtp_datarecebimento_Enter(object sender, EventArgs e)
         {
             dtp_datarecebimento.BackColor = Color.Aquamarine;
         }

         private void dtp_datarecebimento_Leave(object sender, EventArgs e)
         {
             dtp_datarecebimento.BackColor = Color.White;
         }
    }
}
