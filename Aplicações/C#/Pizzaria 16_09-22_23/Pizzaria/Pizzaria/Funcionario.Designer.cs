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
            this.dtp_datanasc = new System.Windows.Forms.DateTimePicker();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_responsavel = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_responsavel = new System.Windows.Forms.Label();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.gp_dadosbancarios = new System.Windows.Forms.GroupBox();
            this.txt_conta = new System.Windows.Forms.TextBox();
            this.txt_agencia = new System.Windows.Forms.TextBox();
            this.txt_banco = new System.Windows.Forms.TextBox();
            this.lbl_conta = new System.Windows.Forms.Label();
            this.lbl_agencia = new System.Windows.Forms.Label();
            this.lbl_banco = new System.Windows.Forms.Label();
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
            this.gp_dadosfunc.SuspendLayout();
            this.gp_dadosbancarios.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_gravacao)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_dadosfunc
            // 
            this.gp_dadosfunc.Controls.Add(this.dtp_datanasc);
            this.gp_dadosfunc.Controls.Add(this.mtxt_cpf);
            this.gp_dadosfunc.Controls.Add(this.mtxt_telefone);
            this.gp_dadosfunc.Controls.Add(this.mtxt_celular);
            this.gp_dadosfunc.Controls.Add(this.txt_responsavel);
            this.gp_dadosfunc.Controls.Add(this.txt_email);
            this.gp_dadosfunc.Controls.Add(this.txt_nome);
            this.gp_dadosfunc.Controls.Add(this.lbl_nome);
            this.gp_dadosfunc.Controls.Add(this.lbl_responsavel);
            this.gp_dadosfunc.Controls.Add(this.lbl_celular);
            this.gp_dadosfunc.Controls.Add(this.lbl_nascimento);
            this.gp_dadosfunc.Controls.Add(this.lbl_email);
            this.gp_dadosfunc.Controls.Add(this.lbl_telefone);
            this.gp_dadosfunc.Controls.Add(this.lbl_cpf);
            this.gp_dadosfunc.Location = new System.Drawing.Point(12, 28);
            this.gp_dadosfunc.Name = "gp_dadosfunc";
            this.gp_dadosfunc.Size = new System.Drawing.Size(643, 197);
            this.gp_dadosfunc.TabIndex = 0;
            this.gp_dadosfunc.TabStop = false;
            this.gp_dadosfunc.Text = "Dados do Funcionário";
            // 
            // dtp_datanasc
            // 
            this.dtp_datanasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datanasc.Location = new System.Drawing.Point(525, 74);
            this.dtp_datanasc.Name = "dtp_datanasc";
            this.dtp_datanasc.Size = new System.Drawing.Size(95, 20);
            this.dtp_datanasc.TabIndex = 12;
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Location = new System.Drawing.Point(116, 66);
            this.mtxt_cpf.Mask = "000,000,000-00";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(100, 20);
            this.mtxt_cpf.TabIndex = 11;
            // 
            // mtxt_telefone
            // 
            this.mtxt_telefone.Location = new System.Drawing.Point(116, 112);
            this.mtxt_telefone.Mask = "(00) 0000-0000";
            this.mtxt_telefone.Name = "mtxt_telefone";
            this.mtxt_telefone.Size = new System.Drawing.Size(100, 20);
            this.mtxt_telefone.TabIndex = 10;
            // 
            // mtxt_celular
            // 
            this.mtxt_celular.Location = new System.Drawing.Point(525, 121);
            this.mtxt_celular.Mask = "(00) 00000-0000";
            this.mtxt_celular.Name = "mtxt_celular";
            this.mtxt_celular.Size = new System.Drawing.Size(100, 20);
            this.mtxt_celular.TabIndex = 9;
            // 
            // txt_responsavel
            // 
            this.txt_responsavel.Location = new System.Drawing.Point(525, 159);
            this.txt_responsavel.Name = "txt_responsavel";
            this.txt_responsavel.Size = new System.Drawing.Size(100, 20);
            this.txt_responsavel.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(116, 166);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(269, 20);
            this.txt_email.TabIndex = 7;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(116, 32);
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
            // lbl_responsavel
            // 
            this.lbl_responsavel.AutoSize = true;
            this.lbl_responsavel.Location = new System.Drawing.Point(417, 167);
            this.lbl_responsavel.Name = "lbl_responsavel";
            this.lbl_responsavel.Size = new System.Drawing.Size(69, 13);
            this.lbl_responsavel.TabIndex = 5;
            this.lbl_responsavel.Text = "Responsável";
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(417, 121);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(39, 13);
            this.lbl_celular.TabIndex = 4;
            this.lbl_celular.Text = "Celular";
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Location = new System.Drawing.Point(417, 74);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(89, 13);
            this.lbl_nascimento.TabIndex = 3;
            this.lbl_nascimento.Text = "Data Nascimento";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(6, 166);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(6, 120);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 1;
            this.lbl_telefone.Text = "Telefone";
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
            // gp_dadosbancarios
            // 
            this.gp_dadosbancarios.Controls.Add(this.txt_conta);
            this.gp_dadosbancarios.Controls.Add(this.txt_agencia);
            this.gp_dadosbancarios.Controls.Add(this.txt_banco);
            this.gp_dadosbancarios.Controls.Add(this.lbl_conta);
            this.gp_dadosbancarios.Controls.Add(this.lbl_agencia);
            this.gp_dadosbancarios.Controls.Add(this.lbl_banco);
            this.gp_dadosbancarios.Location = new System.Drawing.Point(12, 257);
            this.gp_dadosbancarios.Name = "gp_dadosbancarios";
            this.gp_dadosbancarios.Size = new System.Drawing.Size(643, 72);
            this.gp_dadosbancarios.TabIndex = 1;
            this.gp_dadosbancarios.TabStop = false;
            this.gp_dadosbancarios.Text = "Dados Bancários";
            // 
            // txt_conta
            // 
            this.txt_conta.Location = new System.Drawing.Point(520, 28);
            this.txt_conta.Name = "txt_conta";
            this.txt_conta.Size = new System.Drawing.Size(100, 20);
            this.txt_conta.TabIndex = 11;
            // 
            // txt_agencia
            // 
            this.txt_agencia.Location = new System.Drawing.Point(290, 28);
            this.txt_agencia.Name = "txt_agencia";
            this.txt_agencia.Size = new System.Drawing.Size(100, 20);
            this.txt_agencia.TabIndex = 10;
            // 
            // txt_banco
            // 
            this.txt_banco.Location = new System.Drawing.Point(64, 28);
            this.txt_banco.Name = "txt_banco";
            this.txt_banco.Size = new System.Drawing.Size(100, 20);
            this.txt_banco.TabIndex = 9;
            // 
            // lbl_conta
            // 
            this.lbl_conta.AutoSize = true;
            this.lbl_conta.Location = new System.Drawing.Point(479, 31);
            this.lbl_conta.Name = "lbl_conta";
            this.lbl_conta.Size = new System.Drawing.Size(35, 13);
            this.lbl_conta.TabIndex = 8;
            this.lbl_conta.Text = "Conta";
            this.lbl_conta.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbl_agencia
            // 
            this.lbl_agencia.AutoSize = true;
            this.lbl_agencia.Location = new System.Drawing.Point(238, 31);
            this.lbl_agencia.Name = "lbl_agencia";
            this.lbl_agencia.Size = new System.Drawing.Size(46, 13);
            this.lbl_agencia.TabIndex = 7;
            this.lbl_agencia.Text = "Agência";
            // 
            // lbl_banco
            // 
            this.lbl_banco.AutoSize = true;
            this.lbl_banco.Location = new System.Drawing.Point(17, 31);
            this.lbl_banco.Name = "lbl_banco";
            this.lbl_banco.Size = new System.Drawing.Size(38, 13);
            this.lbl_banco.TabIndex = 6;
            this.lbl_banco.Text = "Banco";
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
            this.groupBox3.Location = new System.Drawing.Point(12, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 245);
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
            this.cb_uf.Location = new System.Drawing.Point(520, 123);
            this.cb_uf.Name = "cb_uf";
            this.cb_uf.Size = new System.Drawing.Size(64, 21);
            this.cb_uf.TabIndex = 13;
            // 
            // mtxt_cep
            // 
            this.mtxt_cep.Location = new System.Drawing.Point(520, 78);
            this.mtxt_cep.Mask = "000,00-000";
            this.mtxt_cep.Name = "mtxt_cep";
            this.mtxt_cep.Size = new System.Drawing.Size(64, 20);
            this.mtxt_cep.TabIndex = 12;
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(84, 175);
            this.txt_complemento.Multiline = true;
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(500, 47);
            this.txt_complemento.TabIndex = 11;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(84, 125);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(338, 20);
            this.txt_cidade.TabIndex = 10;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(84, 80);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(338, 20);
            this.txt_bairro.TabIndex = 9;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(520, 37);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(64, 20);
            this.txt_numero.TabIndex = 8;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(84, 41);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(338, 20);
            this.txt_endereco.TabIndex = 7;
            // 
            // lbl_uf
            // 
            this.lbl_uf.AutoSize = true;
            this.lbl_uf.Location = new System.Drawing.Point(465, 126);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(21, 13);
            this.lbl_uf.TabIndex = 6;
            this.lbl_uf.Text = "UF";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(462, 79);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(28, 13);
            this.lbl_cep.TabIndex = 5;
            this.lbl_cep.Text = "CEP";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(462, 40);
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
            this.dtgv_gravacao.Location = new System.Drawing.Point(12, 623);
            this.dtgv_gravacao.Name = "dtgv_gravacao";
            this.dtgv_gravacao.Size = new System.Drawing.Size(643, 150);
            this.dtgv_gravacao.TabIndex = 3;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(12, 812);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 4;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(194, 812);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 5;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(417, 812);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 6;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(580, 812);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 854);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.dtgv_gravacao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gp_dadosbancarios);
            this.Controls.Add(this.gp_dadosfunc);
            this.Name = "Funcionario";
            this.Text = "Cadastramento de Funcionário";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.gp_dadosfunc.ResumeLayout(false);
            this.gp_dadosfunc.PerformLayout();
            this.gp_dadosbancarios.ResumeLayout(false);
            this.gp_dadosbancarios.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_gravacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_dadosfunc;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_responsavel;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.GroupBox gp_dadosbancarios;
        private System.Windows.Forms.Label lbl_banco;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_conta;
        private System.Windows.Forms.Label lbl_agencia;
        private System.Windows.Forms.Label lbl_uf;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_complemento;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.DataGridView dtgv_gravacao;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DateTimePicker dtp_datanasc;
        private System.Windows.Forms.MaskedTextBox mtxt_cpf;
        private System.Windows.Forms.MaskedTextBox mtxt_telefone;
        private System.Windows.Forms.MaskedTextBox mtxt_celular;
        private System.Windows.Forms.TextBox txt_responsavel;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_conta;
        private System.Windows.Forms.TextBox txt_agencia;
        private System.Windows.Forms.TextBox txt_banco;
        private System.Windows.Forms.ComboBox cb_uf;
        private System.Windows.Forms.MaskedTextBox mtxt_cep;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_endereco;
    }
}