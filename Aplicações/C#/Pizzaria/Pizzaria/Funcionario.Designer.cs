namespace Pizzaria
{
    partial class Funcionario
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
            this.gp_dadosfunc = new System.Windows.Forms.GroupBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.cbox_Cargo = new System.Windows.Forms.ComboBox();
            this.dtp_datanasc = new System.Windows.Forms.DateTimePicker();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_uf = new System.Windows.Forms.ComboBox();
            this.mtxt_cep = new System.Windows.Forms.MaskedTextBox();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_uf = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.dtgv_gravacao = new System.Windows.Forms.DataGridView();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.gp_dadosfunc.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_gravacao)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_dadosfunc
            // 
            this.gp_dadosfunc.Controls.Add(this.txt_Senha);
            this.gp_dadosfunc.Controls.Add(this.txt_Usuario);
            this.gp_dadosfunc.Controls.Add(this.Lbl_Senha);
            this.gp_dadosfunc.Controls.Add(this.lbl_Usuario);
            this.gp_dadosfunc.Controls.Add(this.cbox_Cargo);
            this.gp_dadosfunc.Controls.Add(this.dtp_datanasc);
            this.gp_dadosfunc.Controls.Add(this.mtxt_cpf);
            this.gp_dadosfunc.Controls.Add(this.mtxt_telefone);
            this.gp_dadosfunc.Controls.Add(this.mtxt_celular);
            this.gp_dadosfunc.Controls.Add(this.txt_email);
            this.gp_dadosfunc.Controls.Add(this.txt_nome);
            this.gp_dadosfunc.Controls.Add(this.lbl_nome);
            this.gp_dadosfunc.Controls.Add(this.lbl_cargo);
            this.gp_dadosfunc.Controls.Add(this.lbl_celular);
            this.gp_dadosfunc.Controls.Add(this.lbl_nascimento);
            this.gp_dadosfunc.Controls.Add(this.lbl_email);
            this.gp_dadosfunc.Controls.Add(this.lbl_telefone);
            this.gp_dadosfunc.Controls.Add(this.lbl_cpf);
            this.gp_dadosfunc.Location = new System.Drawing.Point(12, 28);
            this.gp_dadosfunc.Name = "gp_dadosfunc";
            this.gp_dadosfunc.Size = new System.Drawing.Size(643, 235);
            this.gp_dadosfunc.TabIndex = 0;
            this.gp_dadosfunc.TabStop = false;
            this.gp_dadosfunc.Text = "Dados do Funcionário";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(285, 195);
            this.txt_Senha.MaxLength = 20;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(100, 20);
            this.txt_Senha.TabIndex = 17;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(116, 192);
            this.txt_Usuario.MaxLength = 20;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(111, 20);
            this.txt_Usuario.TabIndex = 16;
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Location = new System.Drawing.Point(241, 198);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Senha.TabIndex = 15;
            this.Lbl_Senha.Text = "Senha";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(7, 195);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 14;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // cbox_Cargo
            // 
            this.cbox_Cargo.FormattingEnabled = true;
            this.cbox_Cargo.Items.AddRange(new object[] {
            "Administrador",
            "Atendente",
            "Gerente"});
            this.cbox_Cargo.Location = new System.Drawing.Point(530, 151);
            this.cbox_Cargo.Name = "cbox_Cargo";
            this.cbox_Cargo.Size = new System.Drawing.Size(107, 21);
            this.cbox_Cargo.TabIndex = 13;
            this.cbox_Cargo.TabStop = false;
            // 
            // dtp_datanasc
            // 
            this.dtp_datanasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datanasc.Location = new System.Drawing.Point(530, 68);
            this.dtp_datanasc.Name = "dtp_datanasc";
            this.dtp_datanasc.Size = new System.Drawing.Size(95, 20);
            this.dtp_datanasc.TabIndex = 12;
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Location = new System.Drawing.Point(116, 71);
            this.mtxt_cpf.Mask = "000,000,000-00";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(100, 20);
            this.mtxt_cpf.TabIndex = 11;
            // 
            // mtxt_telefone
            // 
            this.mtxt_telefone.Location = new System.Drawing.Point(116, 114);
            this.mtxt_telefone.Mask = "(00) 0000-0000";
            this.mtxt_telefone.Name = "mtxt_telefone";
            this.mtxt_telefone.Size = new System.Drawing.Size(100, 20);
            this.mtxt_telefone.TabIndex = 10;
            // 
            // mtxt_celular
            // 
            this.mtxt_celular.Location = new System.Drawing.Point(530, 111);
            this.mtxt_celular.Mask = "(00) 00000-0000";
            this.mtxt_celular.Name = "mtxt_celular";
            this.mtxt_celular.Size = new System.Drawing.Size(100, 20);
            this.mtxt_celular.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(116, 151);
            this.txt_email.MaxLength = 40;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(269, 20);
            this.txt_email.TabIndex = 7;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(116, 32);
            this.txt_nome.MaxLength = 40;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(269, 20);
            this.txt_nome.TabIndex = 6;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 35);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Location = new System.Drawing.Point(417, 154);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(35, 13);
            this.lbl_cargo.TabIndex = 5;
            this.lbl_cargo.Text = "Cargo";
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(417, 114);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(39, 13);
            this.lbl_celular.TabIndex = 4;
            this.lbl_celular.Text = "Celular";
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Location = new System.Drawing.Point(417, 73);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(89, 13);
            this.lbl_nascimento.TabIndex = 3;
            this.lbl_nascimento.Text = "Data Nascimento";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(6, 154);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(6, 114);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 1;
            this.lbl_telefone.Text = "Telefone";
            this.lbl_telefone.Click += new System.EventHandler(this.lbl_telefone_Click);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(6, 73);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 0;
            this.lbl_cpf.Text = "CPF";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_uf);
            this.groupBox3.Controls.Add(this.mtxt_cep);
            this.groupBox3.Controls.Add(this.txt_complemento);
            this.groupBox3.Controls.Add(this.txt_cidade);
            this.groupBox3.Controls.Add(this.txt_bairro);
            this.groupBox3.Controls.Add(this.txt_numero);
            this.groupBox3.Controls.Add(this.txt_endereco);
            this.groupBox3.Controls.Add(this.lbl_uf);
            this.groupBox3.Controls.Add(this.lbl_cep);
            this.groupBox3.Controls.Add(this.lbl_numero);
            this.groupBox3.Controls.Add(this.lbl_complemento);
            this.groupBox3.Controls.Add(this.lbl_cidade);
            this.groupBox3.Controls.Add(this.lbl_bairro);
            this.groupBox3.Controls.Add(this.lbl_endereco);
            this.groupBox3.Location = new System.Drawing.Point(12, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 221);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados de Localidade";
            // 
            // cb_uf
            // 
            this.cb_uf.FormattingEnabled = true;
            this.cb_uf.Items.AddRange(new object[] {
            "Selecione...",
            "SP",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PR",
            "PB",
            "PA",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SE",
            "TO"});
            this.cb_uf.Location = new System.Drawing.Point(520, 125);
            this.cb_uf.Name = "cb_uf";
            this.cb_uf.Size = new System.Drawing.Size(64, 21);
            this.cb_uf.TabIndex = 13;
            // 
            // mtxt_cep
            // 
            this.mtxt_cep.Location = new System.Drawing.Point(520, 80);
            this.mtxt_cep.Mask = "000,00-000";
            this.mtxt_cep.Name = "mtxt_cep";
            this.mtxt_cep.Size = new System.Drawing.Size(64, 20);
            this.mtxt_cep.TabIndex = 12;
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(84, 168);
            this.txt_complemento.MaxLength = 40;
            this.txt_complemento.Multiline = true;
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(500, 47);
            this.txt_complemento.TabIndex = 11;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(84, 125);
            this.txt_cidade.MaxLength = 20;
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(338, 20);
            this.txt_cidade.TabIndex = 10;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(84, 78);
            this.txt_bairro.MaxLength = 30;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(338, 20);
            this.txt_bairro.TabIndex = 9;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(520, 39);
            this.txt_numero.MaxLength = 5;
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(64, 20);
            this.txt_numero.TabIndex = 8;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(84, 39);
            this.txt_endereco.MaxLength = 40;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(338, 20);
            this.txt_endereco.TabIndex = 7;
            // 
            // lbl_uf
            // 
            this.lbl_uf.AutoSize = true;
            this.lbl_uf.Location = new System.Drawing.Point(465, 128);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(21, 13);
            this.lbl_uf.TabIndex = 6;
            this.lbl_uf.Text = "UF";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(465, 83);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(28, 13);
            this.lbl_cep.TabIndex = 5;
            this.lbl_cep.Text = "CEP";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(465, 44);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 4;
            this.lbl_numero.Text = "Número";
            this.lbl_numero.Click += new System.EventHandler(this.label15_Click);
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Location = new System.Drawing.Point(6, 175);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(71, 13);
            this.lbl_complemento.TabIndex = 3;
            this.lbl_complemento.Text = "Complemento";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(6, 128);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_cidade.TabIndex = 2;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(7, 81);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(34, 13);
            this.lbl_bairro.TabIndex = 1;
            this.lbl_bairro.Text = "Bairro";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(6, 42);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 0;
            this.lbl_endereco.Text = "Endereço";
            // 
            // dtgv_gravacao
            // 
            this.dtgv_gravacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_gravacao.Cursor = System.Windows.Forms.Cursors.No;
            this.dtgv_gravacao.Location = new System.Drawing.Point(12, 507);
            this.dtgv_gravacao.MultiSelect = false;
            this.dtgv_gravacao.Name = "dtgv_gravacao";
            this.dtgv_gravacao.ReadOnly = true;
            this.dtgv_gravacao.RowHeadersVisible = false;
            this.dtgv_gravacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_gravacao.ShowCellErrors = false;
            this.dtgv_gravacao.ShowCellToolTips = false;
            this.dtgv_gravacao.ShowEditingIcon = false;
            this.dtgv_gravacao.ShowRowErrors = false;
            this.dtgv_gravacao.Size = new System.Drawing.Size(646, 80);
            this.dtgv_gravacao.TabIndex = 3;
            this.dtgv_gravacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_gravacao_CellContentClick);
            this.dtgv_gravacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_gravacao_CellDoubleClick);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(12, 608);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 4;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click_1);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(202, 608);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 5;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(486, 608);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 6;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            this.btn_excluir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_excluir_MouseMove);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(583, 608);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(393, 608);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Limpar";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(105, 608);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 9;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(295, 608);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(670, 702);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.dtgv_gravacao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gp_dadosfunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastramento de Funcionário";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.Shown += new System.EventHandler(this.Funcionario_Shown);
            this.gp_dadosfunc.ResumeLayout(false);
            this.gp_dadosfunc.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_gravacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_dadosfunc;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_uf;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_complemento;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DateTimePicker dtp_datanasc;
        private System.Windows.Forms.MaskedTextBox mtxt_cpf;
        private System.Windows.Forms.MaskedTextBox mtxt_telefone;
        private System.Windows.Forms.MaskedTextBox mtxt_celular;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ComboBox cb_uf;
        private System.Windows.Forms.MaskedTextBox mtxt_cep;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_endereco;
        internal System.Windows.Forms.DataGridView dtgv_gravacao;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cbox_Cargo;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}