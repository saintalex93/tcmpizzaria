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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

          string conexao = "Data Source=LAB21T-10;Initial Catalog=Cadastro; Persist Security Info = True; User ID=aluno; Password=etesp"; 
        
          private void label10_Click(object sender, EventArgs e)
          {

          }

          private void label15_Click(object sender, EventArgs e)
          {

          }

          private void btn_sair_Click(object sender, EventArgs e)
          {
              Close();
          }

        /*  private void Funcionario_Load(object sender, EventArgs e)
          {

          }*/

          private void btn_salvar_Click(object sender, EventArgs e)
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
    }
}
