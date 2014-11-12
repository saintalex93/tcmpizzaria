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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Acessa_Click(object sender, EventArgs e)
        {
            try
            {
                //istancia a classe Connection para acessar o banco com o parametros senha e usuario
                //e em seguinda verificar o nivel de acesso caso a autenticação esteja correta
                //tendo o nivel de acesso define o valor do mesmo na classe niveldeacesso, onde fica armazenado.
                Connection conec = new Connection();
                if (conec.Permisso(txt_usuario.Text, txt_senha.Text))
                {
                    Home home = new Home();
                    home.Show();
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show
                    (
                    "O nome de usuário e a senha fornecidos não correspondem às informações em nossos registros.\n\nVerifique-as e tente novamente.",
                    "Falha na conexão com o servidor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                }

            }
            catch (SqlException ee)
            {
                MessageBox.Show
                    (
                    "Servidor inacessível no momento, por favor tente mais tarde.\n\nCaso o problema prevaleça, entre em contato com seu suporte técnico.",
                    "Erro no cadastro de Fornecedores",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void Login_Shown(object sender, EventArgs e)
        {
            
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void Login_Shown_1(object sender, EventArgs e)
        {
            

            txt_usuario.Focus();
        }

        private void btnRede_Click(object sender, EventArgs e)
        {
            Rede rede = new Rede();
            rede.Show();
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            txt_usuario.BackColor = Color.Aquamarine;
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            txt_usuario.BackColor = Color.White;
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_senha_Leave(object sender, EventArgs e)
        {
            txt_senha.BackColor = Color.White;
        }

        private void txt_senha_Enter(object sender, EventArgs e)
        {
            txt_senha.BackColor = Color.Aquamarine;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "admin";
            txt_senha.Text = "123456";
        }
    }
}