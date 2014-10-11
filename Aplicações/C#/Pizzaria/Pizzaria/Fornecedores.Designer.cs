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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.Documento = new System.Windows.Forms.Label();
            this.rdCPF = new System.Windows.Forms.RadioButton();
            this.rdCNPJ = new System.Windows.Forms.RadioButton();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailResponsavel = new System.Windows.Forms.TextBox();
            this.grpDadosBancarios = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.grpDadosFornecedor.SuspendLayout();
            this.grpDadosBancarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosFornecedor
            // 
            this.grpDadosFornecedor.Controls.Add(this.txtEmailResponsavel);
            this.grpDadosFornecedor.Controls.Add(this.label4);
            this.grpDadosFornecedor.Controls.Add(this.txtDocumento);
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
            this.grpDadosFornecedor.Size = new System.Drawing.Size(402, 173);
            this.grpDadosFornecedor.TabIndex = 0;
            this.grpDadosFornecedor.TabStop = false;
            this.grpDadosFornecedor.Text = "Dados do Fornecedor";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome fantasia";
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
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(87, 21);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(242, 20);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(87, 47);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(242, 20);
            this.txtNomeFantasia.TabIndex = 4;
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(87, 73);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(242, 20);
            this.txtResponsavel.TabIndex = 5;
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
            // 
            // rdCNPJ
            // 
            this.rdCNPJ.AutoSize = true;
            this.rdCNPJ.Location = new System.Drawing.Point(138, 111);
            this.rdCNPJ.Name = "rdCNPJ";
            this.rdCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rdCNPJ.TabIndex = 8;
            this.rdCNPJ.TabStop = true;
            this.rdCNPJ.Text = "CNPJ";
            this.rdCNPJ.UseVisualStyleBackColor = true;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(196, 110);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(113, 20);
            this.txtDocumento.TabIndex = 9;
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
            // txtEmailResponsavel
            // 
            this.txtEmailResponsavel.Location = new System.Drawing.Point(125, 144);
            this.txtEmailResponsavel.Name = "txtEmailResponsavel";
            this.txtEmailResponsavel.Size = new System.Drawing.Size(204, 20);
            this.txtEmailResponsavel.TabIndex = 11;
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
            this.grpDadosBancarios.Size = new System.Drawing.Size(402, 194);
            this.grpDadosBancarios.TabIndex = 1;
            this.grpDadosBancarios.TabStop = false;
            this.grpDadosBancarios.Text = "Dados bancários";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Banco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Agência";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Conta";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(63, 32);
            this.txtBanco.MaxLength = 3;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(100, 20);
            this.txtBanco.TabIndex = 3;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(63, 66);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(100, 20);
            this.txtAgencia.TabIndex = 4;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(125, 124);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 5;
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 481);
            this.Controls.Add(this.grpDadosBancarios);
            this.Controls.Add(this.grpDadosFornecedor);
            this.Name = "Fornecedores";
            this.Text = "Gerenciamento de Fornecedores";
            this.grpDadosFornecedor.ResumeLayout(false);
            this.grpDadosFornecedor.PerformLayout();
            this.grpDadosBancarios.ResumeLayout(false);
            this.grpDadosBancarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosFornecedor;
        private System.Windows.Forms.TextBox txtEmailResponsavel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumento;
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
    }
}