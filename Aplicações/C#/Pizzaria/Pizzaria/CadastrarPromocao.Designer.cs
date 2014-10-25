namespace Pizzaria
{
    partial class CadastrarPromocao
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbProdutosPromocao = new System.Windows.Forms.ListBox();
            this.lbBuscaProdutos = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtBuscaID = new System.Windows.Forms.TextBox();
            this.txtBuscaPalavraChave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgProdutosNaPromocao = new System.Windows.Forms.DataGridView();
            this.dtgBuscaProdutos = new System.Windows.Forms.DataGridView();
            this.lblPreço = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutosNaPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produtos na promoção";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPreço);
            this.groupBox1.Controls.Add(this.lbProdutosPromocao);
            this.groupBox1.Controls.Add(this.lbBuscaProdutos);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBuscaID);
            this.groupBox1.Controls.Add(this.txtBuscaPalavraChave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca de produtos";
            // 
            // lbProdutosPromocao
            // 
            this.lbProdutosPromocao.FormattingEnabled = true;
            this.lbProdutosPromocao.Location = new System.Drawing.Point(350, 76);
            this.lbProdutosPromocao.Name = "lbProdutosPromocao";
            this.lbProdutosPromocao.Size = new System.Drawing.Size(238, 160);
            this.lbProdutosPromocao.TabIndex = 8;
            // 
            // lbBuscaProdutos
            // 
            this.lbBuscaProdutos.FormattingEnabled = true;
            this.lbBuscaProdutos.Location = new System.Drawing.Point(16, 76);
            this.lbBuscaProdutos.Name = "lbBuscaProdutos";
            this.lbBuscaProdutos.Size = new System.Drawing.Size(247, 160);
            this.lbBuscaProdutos.TabIndex = 7;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(269, 148);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(269, 119);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtBuscaID
            // 
            this.txtBuscaID.Location = new System.Drawing.Point(165, 49);
            this.txtBuscaID.Name = "txtBuscaID";
            this.txtBuscaID.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaID.TabIndex = 3;
            this.txtBuscaID.TextChanged += new System.EventHandler(this.txtBuscaID_TextChanged);
            // 
            // txtBuscaPalavraChave
            // 
            this.txtBuscaPalavraChave.Location = new System.Drawing.Point(165, 23);
            this.txtBuscaPalavraChave.Name = "txtBuscaPalavraChave";
            this.txtBuscaPalavraChave.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaPalavraChave.TabIndex = 2;
            this.txtBuscaPalavraChave.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBuscaPalavraChave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Busca por ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar pelo nome do produto";
            // 
            // dtgProdutosNaPromocao
            // 
            this.dtgProdutosNaPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutosNaPromocao.Location = new System.Drawing.Point(382, 568);
            this.dtgProdutosNaPromocao.Name = "dtgProdutosNaPromocao";
            this.dtgProdutosNaPromocao.Size = new System.Drawing.Size(240, 150);
            this.dtgProdutosNaPromocao.TabIndex = 7;
            this.dtgProdutosNaPromocao.Visible = false;
            // 
            // dtgBuscaProdutos
            // 
            this.dtgBuscaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscaProdutos.Location = new System.Drawing.Point(28, 568);
            this.dtgBuscaProdutos.Name = "dtgBuscaProdutos";
            this.dtgBuscaProdutos.Size = new System.Drawing.Size(247, 150);
            this.dtgBuscaProdutos.TabIndex = 4;
            this.dtgBuscaProdutos.Visible = false;
            // 
            // lblPreço
            // 
            this.lblPreço.AutoSize = true;
            this.lblPreço.Location = new System.Drawing.Point(347, 239);
            this.lblPreço.Name = "lblPreço";
            this.lblPreço.Size = new System.Drawing.Size(61, 13);
            this.lblPreço.TabIndex = 9;
            this.lblPreço.Text = "Preço total:";
            this.lblPreço.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CadastrarPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 620);
            this.Controls.Add(this.dtgProdutosNaPromocao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgBuscaProdutos);
            this.Name = "CadastrarPromocao";
            this.Text = "CadastrarPromocao";
            this.Shown += new System.EventHandler(this.CadastrarPromocao_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutosNaPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscaID;
        private System.Windows.Forms.TextBox txtBuscaPalavraChave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgBuscaProdutos;
        private System.Windows.Forms.DataGridView dtgProdutosNaPromocao;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lbProdutosPromocao;
        private System.Windows.Forms.ListBox lbBuscaProdutos;
        private System.Windows.Forms.Label lblPreço;

    }
}