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

using BLL;
using DAL.Model;

namespace Pizzaria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        static public int acesso = 0;

        clsLoginBLL login = new clsLoginBLL();

        private void btn_Acessa_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            clsFuncionario objFuncionario = new clsFuncionario();
            objFuncionario.Login_Funcionario = txt_usuario.Text;
            objFuncionario.Senha_Funcionario = txt_senha.Text;

            int codFuncionario = ValidarUsuario(objFuncionario);

            if (codFuncionario == 0)
                return;
            else
            {
                acesso = codFuncionario;

                Home home = new Home();
                home.Show();
                this.Visible = false;
            }
        }

        bool ValidarCampos() 
        {
            if (txt_usuario.Text.Length == 0)
            {
                MessageBox.Show("Por favor, insira um LOGIN de usuário para entrar no sistema.","Falha de login");

                return false;
            }

            return true;
        }

        int ValidarUsuario(clsFuncionario objFuncionario)
        {
            int codFuncionario = 0;
 
            try
            {
                codFuncionario = (int) login.ValidarUsuario(objFuncionario).Rows[0][0];
            }
            catch (Exception e){}


            if (codFuncionario == 0)
            {
                Home.mensagemDeErro("Não constam registros com o LOGIN e SENHA fornecidos.\n\nPor favor, certifique-se de que estão corretos e tente novamente.", "Falha de login");

                return 0;
            }
            return codFuncionario;
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void Login_Shown(object sender, EventArgs e)
        {
            
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            Rede.DEBUG_conectarAutomaticamente();
            txt_usuario.Text = "Admin";
            txt_senha.Text = "123";
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
            txt_usuario.Text = "Admin";
            txt_senha.Text = "123";
        }
    }
}