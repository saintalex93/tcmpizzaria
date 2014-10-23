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
            this.pnl_login = new System.Windows.Forms.Panel();
            this.tbp_Acesso = new System.Windows.Forms.TabControl();
            this.tbp_alterarLogin = new System.Windows.Forms.TabPage();
            this.btn_Acessa = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_login.SuspendLayout();
            this.tbp_Acesso.SuspendLayout();
            this.tbp_alterarLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_login
            // 
            this.pnl_login.AutoScroll = true;
            this.pnl_login.Controls.Add(this.tbp_Acesso);
            this.pnl_login.Location = new System.Drawing.Point(12, 12);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(494, 289);
            this.pnl_login.TabIndex = 2;
            // 
            // tbp_Acesso
            // 
            this.tbp_Acesso.Controls.Add(this.tbp_alterarLogin);
            this.tbp_Acesso.Location = new System.Drawing.Point(28, 26);
            this.tbp_Acesso.Name = "tbp_Acesso";
            this.tbp_Acesso.SelectedIndex = 0;
            this.tbp_Acesso.Size = new System.Drawing.Size(432, 230);
            this.tbp_Acesso.TabIndex = 0;
            // 
            // tbp_alterarLogin
            // 
            this.tbp_alterarLogin.Controls.Add(this.btn_Acessa);
            this.tbp_alterarLogin.Controls.Add(this.txt_senha);
            this.tbp_alterarLogin.Controls.Add(this.txt_usuario);
            this.tbp_alterarLogin.Controls.Add(this.lbl_Senha);
            this.tbp_alterarLogin.Controls.Add(this.lbl_usuario);
            this.tbp_alterarLogin.Controls.Add(this.pictureBox1);
            this.tbp_alterarLogin.Location = new System.Drawing.Point(4, 22);
            this.tbp_alterarLogin.Name = "tbp_alterarLogin";
            this.tbp_alterarLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_alterarLogin.Size = new System.Drawing.Size(424, 204);
            this.tbp_alterarLogin.TabIndex = 3;
            this.tbp_alterarLogin.Text = "Acesso";
            this.tbp_alterarLogin.UseVisualStyleBackColor = true;
            // 
            // btn_Acessa
            // 
            this.btn_Acessa.Image = global::Pizzaria.Properties.Resources.Crystal_Clear_app_clean;
            this.btn_Acessa.Location = new System.Drawing.Point(185, 120);
            this.btn_Acessa.Name = "btn_Acessa";
            this.btn_Acessa.Size = new System.Drawing.Size(100, 50);
            this.btn_Acessa.TabIndex = 5;
            this.btn_Acessa.UseVisualStyleBackColor = true;
            this.btn_Acessa.Click += new System.EventHandler(this.btn_Acessa_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(185, 69);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(100, 20);
            this.txt_senha.TabIndex = 4;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(185, 32);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 3;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(123, 76);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_Senha.TabIndex = 2;
            this.lbl_Senha.Text = "Senha";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(120, 40);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizzaria.Properties.Resources._48px_Crystal_Clear_kdm_user_male;
            this.pictureBox1.Location = new System.Drawing.Point(30, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 313);
            this.Controls.Add(this.pnl_login);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.Shown += new System.EventHandler(this.Login_Shown_1);
            this.pnl_login.ResumeLayout(false);
            this.tbp_Acesso.ResumeLayout(false);
            this.tbp_alterarLogin.ResumeLayout(false);
            this.tbp_alterarLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}