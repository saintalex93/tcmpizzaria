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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        string conexao = "Data Source=ALEX\\SQLEXPRESS ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=1234";
        

                private void button3_Click(object sender, EventArgs e)
                {
                    Close();
                }

                private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {

                }

                private void Pedidos_Load(object sender, EventArgs e)
                {

                }

                private void btn_confirmar_Click(object sender, EventArgs e)
                {
                    

                    /*

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

                private void gpb_detalhamento_Enter(object sender, EventArgs e)
                {

                }

                private void btn_alterar_Click(object sender, EventArgs e)
                {

                }
    }
}
