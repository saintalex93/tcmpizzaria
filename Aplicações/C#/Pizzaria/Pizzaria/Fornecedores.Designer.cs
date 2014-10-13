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
            this.grpDadosFornecedor = new System.Windows.Forms.GroupBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailResponsavel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdCNPJ = new System.Windows.Forms.RadioButton();
            this.rdCPF = new System.Windows.Forms.RadioButton();
            this.Documento = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.grpDadosFornecedor.SuspendLayout();
            this.grpDadosBancarios.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDadosFornecedor
            // 
            this.grpDadosFornecedor.Controls.Add(this.mtxtCNPJ);
            this.grpDadosFornecedor.Controls.Add(this.mtxtCPF);
            this.grpDadosFornecedor.Controls.Add(this.txtEmailResponsavel);
            this.grpDadosFornecedor.Controls.Add(this.label4);
            this.grpDadosFornecedor.Controls.Add(this.rdCNPJ);
            this.grpDadosFornecedor.Controls.Add(this.rdCPF);
            this.grpDadosFornecedor.Controls.Add(this.Documento);
            this.grpDadosFornecedor.Controls.Add(this.txtResponsavel);
            this.grpDadosFornecedor.Controls.Add(this.txtNomeFantasia);
            this.grpDadosFornecedor.Controls.Add(this.txtRazaoSocial);
            this.grpDadosFornecedor.Controls.Add(this.label3);
            this.grpDadosFornecedor.Controls.Add(this.label2);
            this.grpDadosFornecedor.Controls.Add(this.label1);
            this.grpDadosFornecedor.Location = new System.Drawing.Point(12, 12);
            this.grpDadosFornecedor.Name = "grpDadosFornecedor";
            this.grpDadosFornecedor.Size = new System.Drawing.Size(340, 173);
            this.grpDadosFornecedor.TabIndex = 0;
            this.grpDadosFornecedor.TabStop = false;
            this.grpDadosFornecedor.Text = "Dados do Fornecedor";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Enabled = false;
            this.mtxtCPF.Location = new System.Drawing.Point(196, 109);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(125, 20);
            this.mtxtCPF.TabIndex = 12;
            // 
            // txtEmailResponsavel
            // 
            this.txtEmailResponsavel.Location = new System.Drawing.Point(125, 144);
            this.txtEmailResponsavel.Name = "txtEmailResponsavel";
            this.txtEmailResponsavel.Size = new System.Drawing.Size(204, 20);
            this.txtEmailResponsavel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email do responspável";
            // 
            // rdCNPJ
            // 
            this.rdCNPJ.AutoSize = true;
            this.rdCNPJ.Location = new System.Drawing.Point(137, 110);
            this.rdCNPJ.Name = "rdCNPJ";
            this.rdCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rdCNPJ.TabIndex = 8;
            this.rdCNPJ.TabStop = true;
            this.rdCNPJ.Text = "CNPJ";
            this.rdCNPJ.UseVisualStyleBackColor = true;
            this.rdCNPJ.CheckedChanged += new System.EventHandler(this.rdCNPJ_CheckedChanged);
            // 
            // rdCPF
            // 
            this.rdCPF.AutoSize = true;
            this.rdCPF.Location = new System.Drawing.Point(87, 110);
            this.rdCPF.Name = "rdCPF";
            this.rdCPF.Size = new System.Drawing.Size(45, 17);
            this.rdCPF.TabIndex = 7;
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
            this.Documento.Size = new System.Drawing.Size(62, 13);
            this.Documento.TabIndex = 6;
            this.Documento.Text = "Documento";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(87, 73);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(242, 20);
            this.txtResponsavel.TabIndex = 5;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(87, 47);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(242, 20);
            this.txtNomeFantasia.TabIndex = 4;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(87, 21);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(242, 20);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Responsável";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome fantasia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razão Social";
            // 
            // grpDadosBancarios
            // 
            this.grpDadosBancarios.Controls.Add(this.txtConta);
            this.grpDadosBancarios.Controls.Add(this.txtAgencia);
            this.grpDadosBancarios.Controls.Add(this.txtBanco);
            this.grpDadosBancarios.Controls.Add(this.label7);
            this.grpDadosBancarios.Controls.Add(this.label6);
            this.grpDadosBancarios.Controls.Add(this.label5);
            this.grpDadosBancarios.Location = new System.Drawing.Point(12, 191);
            this.grpDadosBancarios.Name = "grpDadosBancarios";
            this.grpDadosBancarios.Size = new System.Drawing.Size(340, 53);
            this.grpDadosBancarios.TabIndex = 1;
            this.grpDadosBancarios.TabStop = false;
            this.grpDadosBancarios.Text = "Dados bancários";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(272, 20);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(56, 20);
            this.txtConta.TabIndex = 5;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(159, 20);
            this.txtAgencia.MaxLength = 8;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(56, 20);
            this.txtAgencia.TabIndex = 4;
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(53, 20);
            this.txtBanco.MaxLength = 3;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(38, 20);
            this.txtBanco.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Conta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Agência";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Banco";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de localidade";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(227, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(199, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Conjunto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "CEP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bairro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Número";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nome da rua";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(137, 541);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Location = new System.Drawing.Point(12, 348);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.Size = new System.Drawing.Size(340, 150);
            this.dgvFornecedores.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(56, 505);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(137, 505);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(218, 504);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Enabled = false;
            this.mtxtCNPJ.Location = new System.Drawing.Point(196, 109);
            this.mtxtCNPJ.Mask = "99,999,999/9999-99";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(125, 20);
            this.mtxtCNPJ.TabIndex = 13;
            this.mtxtCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCNPJ_MaskInputRejected);
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 576);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDadosBancarios);
            this.Controls.Add(this.grpDadosFornecedor);
            this.Name = "Fornecedores";
            this.Text = "Gerenciamento de Fornecedores";
            this.grpDadosFornecedor.ResumeLayout(false);
            this.grpDadosFornecedor.PerformLayout();
            this.grpDadosBancarios.ResumeLayout(false);
            this.grpDadosBancarios.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MaskedTextBox mtxtCNPJ;
    }
}