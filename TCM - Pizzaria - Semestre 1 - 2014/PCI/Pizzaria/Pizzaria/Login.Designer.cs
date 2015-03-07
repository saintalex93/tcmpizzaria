namespace Pizzaria
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnl_login = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.tbp_Acesso = new System.Windows.Forms.TabControl();
            this.tbp_alterarLogin = new System.Windows.Forms.TabPage();
            this.btn_Acessa = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.pnl_login.SuspendLayout();
            this.tbp_Acesso.SuspendLayout();
            this.tbp_alterarLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_login
            // 
            resources.ApplyResources(this.pnl_login, "pnl_login");
            this.pnl_login.Controls.Add(this.label1);
            this.pnl_login.Controls.Add(this.btnConfiguracoes);
            this.pnl_login.Controls.Add(this.tbp_Acesso);
            this.pnl_login.Name = "pnl_login";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConfiguracoes
            // 
            resources.ApplyResources(this.btnConfiguracoes, "btnConfiguracoes");
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnRede_Click);
            // 
            // tbp_Acesso
            // 
            this.tbp_Acesso.Controls.Add(this.tbp_alterarLogin);
            resources.ApplyResources(this.tbp_Acesso, "tbp_Acesso");
            this.tbp_Acesso.Name = "tbp_Acesso";
            this.tbp_Acesso.SelectedIndex = 0;
            // 
            // tbp_alterarLogin
            // 
            this.tbp_alterarLogin.Controls.Add(this.btn_Acessa);
            this.tbp_alterarLogin.Controls.Add(this.txt_senha);
            this.tbp_alterarLogin.Controls.Add(this.txt_usuario);
            this.tbp_alterarLogin.Controls.Add(this.lbl_Senha);
            this.tbp_alterarLogin.Controls.Add(this.lbl_usuario);
            resources.ApplyResources(this.tbp_alterarLogin, "tbp_alterarLogin");
            this.tbp_alterarLogin.Name = "tbp_alterarLogin";
            this.tbp_alterarLogin.UseVisualStyleBackColor = true;
            // 
            // btn_Acessa
            // 
            this.btn_Acessa.Image = global::Pizzaria.Properties.Resources.Crystal_Clear_app_clean;
            resources.ApplyResources(this.btn_Acessa, "btn_Acessa");
            this.btn_Acessa.Name = "btn_Acessa";
            this.btn_Acessa.UseVisualStyleBackColor = true;
            this.btn_Acessa.Click += new System.EventHandler(this.btn_Acessa_Click);
            // 
            // txt_senha
            // 
            resources.ApplyResources(this.txt_senha, "txt_senha");
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            this.txt_senha.Enter += new System.EventHandler(this.txt_senha_Enter);
            this.txt_senha.Leave += new System.EventHandler(this.txt_senha_Leave);
            // 
            // txt_usuario
            // 
            resources.ApplyResources(this.txt_usuario, "txt_usuario");
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // lbl_Senha
            // 
            resources.ApplyResources(this.lbl_Senha, "lbl_Senha");
            this.lbl_Senha.Name = "lbl_Senha";
            // 
            // lbl_usuario
            // 
            resources.ApplyResources(this.lbl_usuario, "lbl_usuario");
            this.lbl_usuario.Name = "lbl_usuario";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.Shown += new System.EventHandler(this.Login_Shown_1);
            this.pnl_login.ResumeLayout(false);
            this.tbp_Acesso.ResumeLayout(false);
            this.tbp_alterarLogin.ResumeLayout(false);
            this.tbp_alterarLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.TabControl tbp_Acesso;
        private System.Windows.Forms.TabPage tbp_alterarLogin;
        private System.Windows.Forms.Button btn_Acessa;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Label label1;

    }
}