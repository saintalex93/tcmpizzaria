namespace Pizzaria
{
    partial class Fornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedores));
            this.grpDadosFornecedor = new System.Windows.Forms.GroupBox();
            this.grpResponsável = new System.Windows.Forms.GroupBox();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailResponsavel = new System.Windows.Forms.TextBox();
            this.mtxtTelefoneDeContato = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.rdCNPJ = new System.Windows.Forms.RadioButton();
            this.rdCPF = new System.Windows.Forms.RadioButton();
            this.Documento = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDadosBancarios = new System.Windows.Forms.GroupBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNomeDaRua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dtgvFornecedores = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpDadosFornecedor.SuspendLayout();
            this.grpResponsável.SuspendLayout();
            this.grpDadosBancarios.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDadosFornecedor
            // 
            this.grpDadosFornecedor.Controls.Add(this.grpResponsável);
            this.grpDadosFornecedor.Controls.Add(this.mtxtTelefoneDeContato);
            this.grpDadosFornecedor.Controls.Add(this.label13);
            this.grpDadosFornecedor.Controls.Add(this.mtxtCNPJ);
            this.grpDadosFornecedor.Controls.Add(this.mtxtCPF);
            this.grpDadosFornecedor.Controls.Add(this.rdCNPJ);
            this.grpDadosFornecedor.Controls.Add(this.rdCPF);
            this.grpDadosFornecedor.Controls.Add(this.Documento);
            this.grpDadosFornecedor.Controls.Add(this.txtNomeFantasia);
            this.grpDadosFornecedor.Controls.Add(this.txtRazaoSocial);
            this.grpDadosFornecedor.Controls.Add(this.label2);
            this.grpDadosFornecedor.Controls.Add(this.label1);
            this.grpDadosFornecedor.Location = new System.Drawing.Point(12, 12);
            this.grpDadosFornecedor.Name = "grpDadosFornecedor";
            this.grpDadosFornecedor.Size = new System.Drawing.Size(340, 253);
            this.grpDadosFornecedor.TabIndex = 0;
            this.grpDadosFornecedor.TabStop = false;
            this.grpDadosFornecedor.Text = "Dados do Fornecedor";
            // 
            // grpResponsável
            // 
            this.grpResponsável.Controls.Add(this.mtxtCelular);
            this.grpResponsável.Controls.Add(this.label3);
            this.grpResponsável.Controls.Add(this.label17);
            this.grpResponsável.Controls.Add(this.txtResponsavel);
            this.grpResponsável.Controls.Add(this.label4);
            this.grpResponsável.Controls.Add(this.txtEmailResponsavel);
            this.grpResponsável.Location = new System.Drawing.Point(8, 144);
            this.grpResponsável.Name = "grpResponsável";
            this.grpResponsável.Size = new System.Drawing.Size(326, 100);
            this.grpResponsável.TabIndex = 17;
            this.grpResponsável.TabStop = false;
            this.grpResponsável.Text = "Responsável";
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Location = new System.Drawing.Point(71, 73);
            this.mtxtCelular.Mask = "(99) 99999-9999";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(100, 20);
            this.mtxtCelular.TabIndex = 9;
            this.mtxtCelular.Enter += new System.EventHandler(this.mtxtCelular_Enter);
            this.mtxtCelular.Leave += new System.EventHandler(this.mtxtCelular_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Celular*";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(71, 22);
            this.txtResponsavel.MaxLength = 30;
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(242, 20);
            this.txtResponsavel.TabIndex = 7;
            this.txtResponsavel.Enter += new System.EventHandler(this.txtResponsavel_Enter);
            this.txtResponsavel.Leave += new System.EventHandler(this.txtResponsavel_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email*";
            // 
            // txtEmailResponsavel
            // 
            this.txtEmailResponsavel.Location = new System.Drawing.Point(71, 48);
            this.txtEmailResponsavel.MaxLength = 50;
            this.txtEmailResponsavel.Name = "txtEmailResponsavel";
            this.txtEmailResponsavel.Size = new System.Drawing.Size(204, 20);
            this.txtEmailResponsavel.TabIndex = 8;
            this.txtEmailResponsavel.Enter += new System.EventHandler(this.txtEmailResponsavel_Enter);
            this.txtEmailResponsavel.Leave += new System.EventHandler(this.txtEmailResponsavel_Leave);
            // 
            // mtxtTelefoneDeContato
            // 
            this.mtxtTelefoneDeContato.Location = new System.Drawing.Point(88, 72);
            this.mtxtTelefoneDeContato.Mask = "(99) 9999-9999";
            this.mtxtTelefoneDeContato.Name = "mtxtTelefoneDeContato";
            this.mtxtTelefoneDeContato.Size = new System.Drawing.Size(100, 20);
            this.mtxtTelefoneDeContato.TabIndex = 3;
            this.mtxtTelefoneDeContato.Enter += new System.EventHandler(this.mtxtTelefoneDeContato_Enter);
            this.mtxtTelefoneDeContato.Leave += new System.EventHandler(this.mtxtTelefoneDeContato_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Telefone*";
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Enabled = false;
            this.mtxtCNPJ.Location = new System.Drawing.Point(145, 109);
            this.mtxtCNPJ.Mask = "99,999,999/9999-99";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(105, 20);
            this.mtxtCNPJ.TabIndex = 6;
            this.mtxtCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCNPJ_MaskInputRejected);
            this.mtxtCNPJ.Enter += new System.EventHandler(this.mtxtCNPJ_Enter);
            this.mtxtCNPJ.Leave += new System.EventHandler(this.mtxtCNPJ_Leave);
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Enabled = false;
            this.mtxtCPF.Location = new System.Drawing.Point(145, 109);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(105, 20);
            this.mtxtCPF.TabIndex = 12;
            // 
            // rdCNPJ
            // 
            this.rdCNPJ.AutoSize = true;
            this.rdCNPJ.Location = new System.Drawing.Point(87, 121);
            this.rdCNPJ.Name = "rdCNPJ";
            this.rdCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rdCNPJ.TabIndex = 5;
            this.rdCNPJ.TabStop = true;
            this.rdCNPJ.Text = "CNPJ";
            this.rdCNPJ.UseVisualStyleBackColor = true;
            this.rdCNPJ.CheckedChanged += new System.EventHandler(this.rdCNPJ_CheckedChanged);
            // 
            // rdCPF
            // 
            this.rdCPF.AutoSize = true;
            this.rdCPF.Location = new System.Drawing.Point(87, 99);
            this.rdCPF.Name = "rdCPF";
            this.rdCPF.Size = new System.Drawing.Size(45, 17);
            this.rdCPF.TabIndex = 4;
            this.rdCPF.TabStop = true;
            this.rdCPF.Text = "CPF";
            this.rdCPF.UseVisualStyleBackColor = true;
            this.rdCPF.CheckedChanged += new System.EventHandler(this.rdCPF_CheckedChanged);
            // 
            // Documento
            // 
            this.Documento.AutoSize = true;
            this.Documento.Location = new System.Drawing.Point(19, 112);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(66, 13);
            this.Documento.TabIndex = 30;
            this.Documento.Text = "Documento*";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(87, 47);
            this.txtNomeFantasia.MaxLength = 50;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(242, 20);
            this.txtNomeFantasia.TabIndex = 2;
            this.txtNomeFantasia.Enter += new System.EventHandler(this.txtNomeFantasia_Enter);
            this.txtNomeFantasia.Leave += new System.EventHandler(this.txtNomeFantasia_Leave);
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(87, 21);
            this.txtRazaoSocial.MaxLength = 50;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(242, 20);
            this.txtRazaoSocial.TabIndex = 1;
            this.txtRazaoSocial.Enter += new System.EventHandler(this.txtRazaoSocial_Enter);
            this.txtRazaoSocial.Leave += new System.EventHandler(this.txtRazaoSocial_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome fantasia*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razão Social*";
            // 
            // grpDadosBancarios
            // 
            this.grpDadosBancarios.Controls.Add(this.txtConta);
            this.grpDadosBancarios.Controls.Add(this.txtAgencia);
            this.grpDadosBancarios.Controls.Add(this.txtBanco);
            this.grpDadosBancarios.Controls.Add(this.label7);
            this.grpDadosBancarios.Controls.Add(this.label6);
            this.grpDadosBancarios.Controls.Add(this.label5);
            this.grpDadosBancarios.Location = new System.Drawing.Point(12, 271);
            this.grpDadosBancarios.Name = "grpDadosBancarios";
            this.grpDadosBancarios.Size = new System.Drawing.Size(340, 53);
            this.grpDadosBancarios.TabIndex = 1;
            this.grpDadosBancarios.TabStop = false;
            this.grpDadosBancarios.Text = "Dados bancários";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(272, 20);
            this.txtConta.MaxLength = 8;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(56, 20);
            this.txtConta.TabIndex = 12;
            this.txtConta.Enter += new System.EventHandler(this.txtConta_Enter);
            this.txtConta.Leave += new System.EventHandler(this.txtConta_Leave);
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(159, 20);
            this.txtAgencia.MaxLength = 8;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(56, 20);
            this.txtAgencia.TabIndex = 11;
            this.txtAgencia.Enter += new System.EventHandler(this.txtAgencia_Enter);
            this.txtAgencia.Leave += new System.EventHandler(this.txtAgencia_Leave);
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(53, 20);
            this.txtBanco.MaxLength = 3;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(38, 20);
            this.txtBanco.TabIndex = 10;
            this.txtBanco.TextChanged += new System.EventHandler(this.txtBanco_TextChanged);
            this.txtBanco.Enter += new System.EventHandler(this.txtBanco_Enter);
            this.txtBanco.Leave += new System.EventHandler(this.txtBanco_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Conta*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Agência*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Banco*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbxUF);
            this.groupBox1.Controls.Add(this.mtxtCEP);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtNomeDaRua);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de localidade";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(83, 118);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(123, 20);
            this.txtComplemento.TabIndex = 19;
            this.txtComplemento.Enter += new System.EventHandler(this.txtComplemento_Enter);
            this.txtComplemento.Leave += new System.EventHandler(this.txtComplemento_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Complemento";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(84, 95);
            this.txtCidade.MaxLength = 40;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 20);
            this.txtCidade.TabIndex = 18;
            this.txtCidade.Enter += new System.EventHandler(this.txtCidade_Enter);
            this.txtCidade.Leave += new System.EventHandler(this.txtCidade_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Cidade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(238, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "UF";
            // 
            // cbxUF
            // 
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
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
            this.cbxUF.Location = new System.Drawing.Point(262, 69);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(59, 21);
            this.cbxUF.TabIndex = 17;
            this.cbxUF.Enter += new System.EventHandler(this.cbxUF_Enter);
            this.cbxUF.Leave += new System.EventHandler(this.cbxUF_Leave);
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Location = new System.Drawing.Point(262, 43);
            this.mtxtCEP.Mask = "99999-999";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(59, 20);
            this.mtxtCEP.TabIndex = 15;
            this.mtxtCEP.Enter += new System.EventHandler(this.mtxtCEP_Enter);
            this.mtxtCEP.Leave += new System.EventHandler(this.mtxtCEP_Leave);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(83, 69);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(123, 20);
            this.txtBairro.TabIndex = 16;
            this.txtBairro.Enter += new System.EventHandler(this.txtBairro_Enter);
            this.txtBairro.Leave += new System.EventHandler(this.txtBairro_Leave);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(84, 43);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(52, 20);
            this.txtNumero.TabIndex = 14;
            this.txtNumero.Enter += new System.EventHandler(this.txtNumero_Enter);
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // txtNomeDaRua
            // 
            this.txtNomeDaRua.Location = new System.Drawing.Point(84, 17);
            this.txtNomeDaRua.MaxLength = 40;
            this.txtNomeDaRua.Name = "txtNomeDaRua";
            this.txtNomeDaRua.Size = new System.Drawing.Size(237, 20);
            this.txtNomeDaRua.TabIndex = 13;
            this.txtNomeDaRua.Enter += new System.EventHandler(this.txtNomeDaRua_Enter);
            this.txtNomeDaRua.Leave += new System.EventHandler(this.txtNomeDaRua_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "CEP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bairro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Número";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nome da rua";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(220, 676);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dtgvFornecedores
            // 
            this.dtgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFornecedores.Location = new System.Drawing.Point(12, 491);
            this.dtgvFornecedores.Name = "dtgvFornecedores";
            this.dtgvFornecedores.Size = new System.Drawing.Size(340, 150);
            this.dtgvFornecedores.TabIndex = 4;
            this.dtgvFornecedores.SelectionChanged += new System.EventHandler(this.dtgvFornecedores_SelectionChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(56, 647);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Adicionar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(137, 676);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(56, 676);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(137, 647);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(220, 647);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 710);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtgvFornecedores);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDadosBancarios);
            this.Controls.Add(this.grpDadosFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Fornecedores";
            this.Load += new System.EventHandler(this.Fornecedores_Load);
            this.Shown += new System.EventHandler(this.Fornecedores_Shown);
            this.grpDadosFornecedor.ResumeLayout(false);
            this.grpDadosFornecedor.PerformLayout();
            this.grpResponsável.ResumeLayout(false);
            this.grpResponsável.PerformLayout();
            this.grpDadosBancarios.ResumeLayout(false);
            this.grpDadosBancarios.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosFornecedor;
        private System.Windows.Forms.TextBox txtEmailResponsavel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdCNPJ;
        private System.Windows.Forms.RadioButton rdCPF;
        private System.Windows.Forms.Label Documento;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDadosBancarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNomeDaRua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dtgvFornecedores;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MaskedTextBox mtxtCNPJ;
        private System.Windows.Forms.MaskedTextBox mtxtTelefoneDeContato;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox grpResponsável;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.Button btnLimpar;
    }
}