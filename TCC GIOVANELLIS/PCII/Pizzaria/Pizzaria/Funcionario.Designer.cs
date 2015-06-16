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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
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
            this.btn_salvar = new System.Windows.Forms.Button();
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
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscaPorNome = new System.Windows.Forms.TextBox();
            this.mtxtBuscaPorCPF = new System.Windows.Forms.MaskedTextBox();
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
            this.gp_dadosfunc.Size = new System.Drawing.Size(368, 184);
            this.gp_dadosfunc.TabIndex = 0;
            this.gp_dadosfunc.TabStop = false;
            this.gp_dadosfunc.Text = "Dados do Funcionário";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(258, 124);
            this.txt_Senha.MaxLength = 20;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(100, 20);
            this.txt_Senha.TabIndex = 9;
            this.txt_Senha.Enter += new System.EventHandler(this.txt_Senha_Enter);
            this.txt_Senha.Leave += new System.EventHandler(this.txt_Senha_Leave);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(61, 124);
            this.txt_Usuario.MaxLength = 20;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(111, 20);
            this.txt_Usuario.TabIndex = 8;
            this.txt_Usuario.Enter += new System.EventHandler(this.txt_Usuario_Enter);
            this.txt_Usuario.Leave += new System.EventHandler(this.txt_Usuario_Leave);
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Location = new System.Drawing.Point(214, 128);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Senha.TabIndex = 15;
            this.Lbl_Senha.Text = "Senha";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(12, 127);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 14;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // cbox_Cargo
            // 
            this.cbox_Cargo.FormattingEnabled = true;
            this.cbox_Cargo.Location = new System.Drawing.Point(61, 150);
            this.cbox_Cargo.Name = "cbox_Cargo";
            this.cbox_Cargo.Size = new System.Drawing.Size(107, 21);
            this.cbox_Cargo.TabIndex = 7;
            this.cbox_Cargo.TabStop = false;
            this.cbox_Cargo.SelectedIndexChanged += new System.EventHandler(this.cbox_Cargo_SelectedIndexChanged);
            this.cbox_Cargo.Enter += new System.EventHandler(this.cbox_Cargo_Enter);
            this.cbox_Cargo.Leave += new System.EventHandler(this.cbox_Cargo_Leave);
            // 
            // dtp_datanasc
            // 
            this.dtp_datanasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datanasc.Location = new System.Drawing.Point(263, 46);
            this.dtp_datanasc.Name = "dtp_datanasc";
            this.dtp_datanasc.Size = new System.Drawing.Size(95, 20);
            this.dtp_datanasc.TabIndex = 3;
            this.dtp_datanasc.Enter += new System.EventHandler(this.dtp_datanasc_Enter);
            this.dtp_datanasc.Leave += new System.EventHandler(this.dtp_datanasc_Leave);
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Location = new System.Drawing.Point(61, 46);
            this.mtxt_cpf.Mask = "000,000,000-00";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(100, 20);
            this.mtxt_cpf.TabIndex = 2;
            this.mtxt_cpf.TextChanged += new System.EventHandler(this.mtxt_cpf_TextChanged);
            this.mtxt_cpf.Enter += new System.EventHandler(this.mtxt_cpf_Enter);
            this.mtxt_cpf.Leave += new System.EventHandler(this.mtxt_cpf_Leave);
            // 
            // mtxt_telefone
            // 
            this.mtxt_telefone.Location = new System.Drawing.Point(61, 72);
            this.mtxt_telefone.Mask = "(00) 0000-0000";
            this.mtxt_telefone.Name = "mtxt_telefone";
            this.mtxt_telefone.Size = new System.Drawing.Size(100, 20);
            this.mtxt_telefone.TabIndex = 4;
            this.mtxt_telefone.Enter += new System.EventHandler(this.mtxt_telefone_Enter);
            this.mtxt_telefone.Leave += new System.EventHandler(this.mtxt_telefone_Leave);
            // 
            // mtxt_celular
            // 
            this.mtxt_celular.Location = new System.Drawing.Point(263, 72);
            this.mtxt_celular.Mask = "(00) 00000-0000";
            this.mtxt_celular.Name = "mtxt_celular";
            this.mtxt_celular.Size = new System.Drawing.Size(95, 20);
            this.mtxt_celular.TabIndex = 5;
            this.mtxt_celular.Enter += new System.EventHandler(this.mtxt_celular_Enter);
            this.mtxt_celular.Leave += new System.EventHandler(this.mtxt_celular_Leave);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(61, 98);
            this.txt_email.MaxLength = 40;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(297, 20);
            this.txt_email.TabIndex = 6;
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(61, 20);
            this.txt_nome.MaxLength = 40;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(297, 20);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.Enter += new System.EventHandler(this.txt_nome_Enter);
            this.txt_nome.Leave += new System.EventHandler(this.txt_nome_Leave);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(20, 23);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Location = new System.Drawing.Point(20, 153);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(35, 13);
            this.lbl_cargo.TabIndex = 5;
            this.lbl_cargo.Text = "Cargo";
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(218, 75);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(39, 13);
            this.lbl_celular.TabIndex = 4;
            this.lbl_celular.Text = "Celular";
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Location = new System.Drawing.Point(168, 52);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(89, 13);
            this.lbl_nascimento.TabIndex = 3;
            this.lbl_nascimento.Text = "Data Nascimento";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(20, 101);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(6, 75);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 1;
            this.lbl_telefone.Text = "Telefone";
            this.lbl_telefone.Click += new System.EventHandler(this.lbl_telefone_Click);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(28, 48);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 207);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados de Localidade";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(303, 436);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 17;
            this.btn_salvar.Text = "Inserir funcionário";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click_1);
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
            this.cb_uf.Location = new System.Drawing.Point(291, 74);
            this.cb_uf.Name = "cb_uf";
            this.cb_uf.Size = new System.Drawing.Size(64, 21);
            this.cb_uf.TabIndex = 15;
            this.cb_uf.Enter += new System.EventHandler(this.cb_uf_Enter);
            this.cb_uf.Leave += new System.EventHandler(this.cb_uf_Leave);
            // 
            // mtxt_cep
            // 
            this.mtxt_cep.Location = new System.Drawing.Point(291, 50);
            this.mtxt_cep.Mask = "000,00-000";
            this.mtxt_cep.Name = "mtxt_cep";
            this.mtxt_cep.Size = new System.Drawing.Size(64, 20);
            this.mtxt_cep.TabIndex = 13;
            this.mtxt_cep.Enter += new System.EventHandler(this.mtxt_cep_Enter);
            this.mtxt_cep.Leave += new System.EventHandler(this.mtxt_cep_Leave);
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(81, 97);
            this.txt_complemento.MaxLength = 40;
            this.txt_complemento.Multiline = true;
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(153, 98);
            this.txt_complemento.TabIndex = 16;
            this.txt_complemento.Enter += new System.EventHandler(this.txt_complemento_Enter);
            this.txt_complemento.Leave += new System.EventHandler(this.txt_complemento_Leave);
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(81, 71);
            this.txt_cidade.MaxLength = 20;
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(153, 20);
            this.txt_cidade.TabIndex = 14;
            this.txt_cidade.Enter += new System.EventHandler(this.txt_cidade_Enter);
            this.txt_cidade.Leave += new System.EventHandler(this.txt_cidade_Leave);
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(81, 45);
            this.txt_bairro.MaxLength = 30;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(153, 20);
            this.txt_bairro.TabIndex = 12;
            this.txt_bairro.Enter += new System.EventHandler(this.txt_bairro_Enter);
            this.txt_bairro.Leave += new System.EventHandler(this.txt_bairro_Leave);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(291, 22);
            this.txt_numero.MaxLength = 5;
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(64, 20);
            this.txt_numero.TabIndex = 11;
            this.txt_numero.Enter += new System.EventHandler(this.txt_numero_Enter);
            this.txt_numero.Leave += new System.EventHandler(this.txt_numero_Leave);
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(81, 19);
            this.txt_endereco.MaxLength = 40;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(153, 20);
            this.txt_endereco.TabIndex = 10;
            this.txt_endereco.Enter += new System.EventHandler(this.txt_endereco_Enter);
            this.txt_endereco.Leave += new System.EventHandler(this.txt_endereco_Leave);
            // 
            // lbl_uf
            // 
            this.lbl_uf.AutoSize = true;
            this.lbl_uf.Location = new System.Drawing.Point(257, 77);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(21, 13);
            this.lbl_uf.TabIndex = 6;
            this.lbl_uf.Text = "UF";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(257, 53);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(28, 13);
            this.lbl_cep.TabIndex = 5;
            this.lbl_cep.Text = "CEP";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(242, 25);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 4;
            this.lbl_numero.Text = "Número";
            this.lbl_numero.Click += new System.EventHandler(this.label15_Click);
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Location = new System.Drawing.Point(9, 97);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(71, 13);
            this.lbl_complemento.TabIndex = 3;
            this.lbl_complemento.Text = "Complemento";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(35, 74);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_cidade.TabIndex = 2;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(41, 50);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(34, 13);
            this.lbl_bairro.TabIndex = 1;
            this.lbl_bairro.Text = "Bairro";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(22, 22);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 0;
            this.lbl_endereco.Text = "Endereço";
            // 
            // dtgv_gravacao
            // 
            this.dtgv_gravacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_gravacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_gravacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_gravacao.Cursor = System.Windows.Forms.Cursors.No;
            this.dtgv_gravacao.Location = new System.Drawing.Point(12, 486);
            this.dtgv_gravacao.MultiSelect = false;
            this.dtgv_gravacao.Name = "dtgv_gravacao";
            this.dtgv_gravacao.ReadOnly = true;
            this.dtgv_gravacao.RowHeadersVisible = false;
            this.dtgv_gravacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_gravacao.ShowCellErrors = false;
            this.dtgv_gravacao.ShowCellToolTips = false;
            this.dtgv_gravacao.ShowEditingIcon = false;
            this.dtgv_gravacao.ShowRowErrors = false;
            this.dtgv_gravacao.Size = new System.Drawing.Size(368, 143);
            this.dtgv_gravacao.TabIndex = 3;
            this.dtgv_gravacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_gravacao_CellContentClick);
            this.dtgv_gravacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_gravacao_CellDoubleClick);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(8, 635);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 19;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(170, 635);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 22;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            this.btn_excluir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_excluir_MouseMove);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(305, 659);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 23;
            this.btn_sair.Text = "Voltar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(89, 635);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 21;
            this.btn_Clear.Text = "Limpar";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Buscar por Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Buscar por CPF";
            // 
            // txtBuscaPorNome
            // 
            this.txtBuscaPorNome.Location = new System.Drawing.Point(104, 433);
            this.txtBuscaPorNome.Name = "txtBuscaPorNome";
            this.txtBuscaPorNome.Size = new System.Drawing.Size(83, 20);
            this.txtBuscaPorNome.TabIndex = 26;
            this.txtBuscaPorNome.TextChanged += new System.EventHandler(this.txtBuscaPorNome_TextChanged);
            // 
            // mtxtBuscaPorCPF
            // 
            this.mtxtBuscaPorCPF.Location = new System.Drawing.Point(104, 459);
            this.mtxtBuscaPorCPF.Mask = "999,999,999-99";
            this.mtxtBuscaPorCPF.Name = "mtxtBuscaPorCPF";
            this.mtxtBuscaPorCPF.Size = new System.Drawing.Size(83, 20);
            this.mtxtBuscaPorCPF.TabIndex = 27;
            this.mtxtBuscaPorCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtBuscaPorCPF_MaskInputRejected);
            this.mtxtBuscaPorCPF.TextChanged += new System.EventHandler(this.mtxtBuscaPorCPF_TextChanged);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(392, 694);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.mtxtBuscaPorCPF);
            this.Controls.Add(this.txtBuscaPorNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.dtgv_gravacao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gp_dadosfunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox cbox_Cargo;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscaPorNome;
        private System.Windows.Forms.MaskedTextBox mtxtBuscaPorCPF;
    }
}