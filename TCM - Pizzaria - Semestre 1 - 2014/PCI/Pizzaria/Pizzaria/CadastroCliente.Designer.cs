namespace Pizzaria
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_datanasc = new System.Windows.Forms.DateTimePicker();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_celular = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_datanasc = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_uf = new System.Windows.Forms.ComboBox();
            this.mtxt_cep = new System.Windows.Forms.MaskedTextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_uf = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.dtgw_dados = new System.Windows.Forms.DataGridView();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaPorNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtBuscaPorCPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_datanasc);
            this.groupBox1.Controls.Add(this.mtxt_cpf);
            this.groupBox1.Controls.Add(this.mtxt_celular);
            this.groupBox1.Controls.Add(this.mtxt_telefone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.lbl_cpf);
            this.groupBox1.Controls.Add(this.lbl_celular);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_datanasc);
            this.groupBox1.Controls.Add(this.lbl_telefone);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 127);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // dtp_datanasc
            // 
            this.dtp_datanasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datanasc.Location = new System.Drawing.Point(116, 71);
            this.dtp_datanasc.Name = "dtp_datanasc";
            this.dtp_datanasc.Size = new System.Drawing.Size(100, 20);
            this.dtp_datanasc.TabIndex = 4;
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Location = new System.Drawing.Point(326, 71);
            this.mtxt_cpf.Mask = "000,000,000-00";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(100, 20);
            this.mtxt_cpf.TabIndex = 5;
            // 
            // mtxt_celular
            // 
            this.mtxt_celular.Location = new System.Drawing.Point(326, 45);
            this.mtxt_celular.Mask = "(00) 00000-0000";
            this.mtxt_celular.Name = "mtxt_celular";
            this.mtxt_celular.Size = new System.Drawing.Size(100, 20);
            this.mtxt_celular.TabIndex = 3;
            // 
            // mtxt_telefone
            // 
            this.mtxt_telefone.Location = new System.Drawing.Point(116, 45);
            this.mtxt_telefone.Mask = "(00) 0000-0000";
            this.mtxt_telefone.Name = "mtxt_telefone";
            this.mtxt_telefone.Size = new System.Drawing.Size(100, 20);
            this.mtxt_telefone.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(116, 19);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(310, 20);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.Leave += new System.EventHandler(this.txt_nome_Leave);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(293, 76);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 5;
            this.lbl_cpf.Text = "CPF";
            this.lbl_cpf.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(281, 48);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(39, 13);
            this.lbl_celular.TabIndex = 4;
            this.lbl_celular.Text = "Celular";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(74, 97);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_datanasc
            // 
            this.lbl_datanasc.AutoSize = true;
            this.lbl_datanasc.Location = new System.Drawing.Point(6, 72);
            this.lbl_datanasc.Name = "lbl_datanasc";
            this.lbl_datanasc.Size = new System.Drawing.Size(104, 13);
            this.lbl_datanasc.TabIndex = 2;
            this.lbl_datanasc.Text = "Data de Nascimento";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(61, 45);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 1;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(75, 22);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_uf);
            this.groupBox2.Controls.Add(this.mtxt_cep);
            this.groupBox2.Controls.Add(this.txt_numero);
            this.groupBox2.Controls.Add(this.txt_complemento);
            this.groupBox2.Controls.Add(this.txt_cidade);
            this.groupBox2.Controls.Add(this.txt_bairro);
            this.groupBox2.Controls.Add(this.txt_endereco);
            this.groupBox2.Controls.Add(this.lbl_uf);
            this.groupBox2.Controls.Add(this.lbl_cep);
            this.groupBox2.Controls.Add(this.lbl_numero);
            this.groupBox2.Controls.Add(this.lbl_complemento);
            this.groupBox2.Controls.Add(this.lbl_cidade);
            this.groupBox2.Controls.Add(this.lbl_bairro);
            this.groupBox2.Controls.Add(this.lbl_endereco);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 134);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados de Localidade";
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
            this.cb_uf.Location = new System.Drawing.Point(361, 71);
            this.cb_uf.Name = "cb_uf";
            this.cb_uf.Size = new System.Drawing.Size(65, 21);
            this.cb_uf.TabIndex = 12;
            // 
            // mtxt_cep
            // 
            this.mtxt_cep.Location = new System.Drawing.Point(361, 45);
            this.mtxt_cep.Mask = "00000-000";
            this.mtxt_cep.Name = "mtxt_cep";
            this.mtxt_cep.Size = new System.Drawing.Size(65, 20);
            this.mtxt_cep.TabIndex = 10;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(361, 19);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(65, 20);
            this.txt_numero.TabIndex = 8;
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(87, 100);
            this.txt_complemento.Multiline = true;
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(339, 23);
            this.txt_complemento.TabIndex = 13;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(87, 74);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(218, 20);
            this.txt_cidade.TabIndex = 11;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(87, 48);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(218, 20);
            this.txt_bairro.TabIndex = 9;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(87, 19);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(218, 20);
            this.txt_endereco.TabIndex = 7;
            // 
            // lbl_uf
            // 
            this.lbl_uf.AutoSize = true;
            this.lbl_uf.Location = new System.Drawing.Point(327, 71);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(21, 13);
            this.lbl_uf.TabIndex = 6;
            this.lbl_uf.Text = "UF";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(327, 48);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(28, 13);
            this.lbl_cep.TabIndex = 5;
            this.lbl_cep.Text = "CEP";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(311, 22);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 4;
            this.lbl_numero.Text = "Número";
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Location = new System.Drawing.Point(10, 100);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(71, 13);
            this.lbl_complemento.TabIndex = 3;
            this.lbl_complemento.Text = "Complemento";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(41, 77);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_cidade.TabIndex = 2;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(47, 51);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(34, 13);
            this.lbl_bairro.TabIndex = 1;
            this.lbl_bairro.Text = "Bairro";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(28, 22);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 0;
            this.lbl_endereco.Text = "Endereco";
            // 
            // dtgw_dados
            // 
            this.dtgw_dados.AllowUserToAddRows = false;
            this.dtgw_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgw_dados.Location = new System.Drawing.Point(12, 340);
            this.dtgw_dados.Name = "dtgw_dados";
            this.dtgw_dados.ReadOnly = true;
            this.dtgw_dados.Size = new System.Drawing.Size(439, 150);
            this.dtgw_dados.TabIndex = 24;
            this.dtgw_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgw_dados_CellContentClick);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(376, 285);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_gravar.TabIndex = 14;
            this.btn_gravar.Text = "Inserir";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click_1);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(12, 496);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 16;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(93, 496);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 17;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(376, 496);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 19;
            this.btn_sair.Text = "Voltar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(174, 496);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 18;
            this.btn_Clear.Text = "Limpar";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Buscar por nome:";
            // 
            // txtBuscaPorNome
            // 
            this.txtBuscaPorNome.Location = new System.Drawing.Point(107, 314);
            this.txtBuscaPorNome.Name = "txtBuscaPorNome";
            this.txtBuscaPorNome.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaPorNome.TabIndex = 26;
            this.txtBuscaPorNome.TextChanged += new System.EventHandler(this.txtBuscaPorNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Buscar por CPF:";
            // 
            // mtxtBuscaPorCPF
            // 
            this.mtxtBuscaPorCPF.Location = new System.Drawing.Point(351, 314);
            this.mtxtBuscaPorCPF.Mask = "999,999,999-99";
            this.mtxtBuscaPorCPF.Name = "mtxtBuscaPorCPF";
            this.mtxtBuscaPorCPF.Size = new System.Drawing.Size(100, 20);
            this.mtxtBuscaPorCPF.TabIndex = 14;
            this.mtxtBuscaPorCPF.TextChanged += new System.EventHandler(this.mtxtBuscaPorCPF_TextChanged);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 531);
            this.ControlBox = false;
            this.Controls.Add(this.mtxtBuscaPorCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscaPorNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.dtgw_dados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_datanasc;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_uf;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_complemento;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.DataGridView dtgw_dados;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DateTimePicker dtp_datanasc;
        private System.Windows.Forms.MaskedTextBox mtxt_cpf;
        private System.Windows.Forms.MaskedTextBox mtxt_celular;
        private System.Windows.Forms.MaskedTextBox mtxt_telefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ComboBox cb_uf;
        private System.Windows.Forms.MaskedTextBox mtxt_cep;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaPorNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtBuscaPorCPF;
    }
}