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
            this.label6 = new System.Windows.Forms.Label();
            this.dtgProdutosNaPromocao = new System.Windows.Forms.DataGridView();
            this.lblPreço = new System.Windows.Forms.Label();
            this.lbProdutosPromocao = new System.Windows.Forms.ListBox();
            this.dtgBuscaProdutos = new System.Windows.Forms.DataGridView();
            this.lbBuscaProdutos = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtBuscaID = new System.Windows.Forms.TextBox();
            this.txtBuscaPalavraChave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNovoPreco = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutosNaPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produtos na promoção";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtgProdutosNaPromocao);
            this.groupBox1.Controls.Add(this.lblPreço);
            this.groupBox1.Controls.Add(this.lbProdutosPromocao);
            this.groupBox1.Controls.Add(this.dtgBuscaProdutos);
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
            this.groupBox1.Size = new System.Drawing.Size(582, 331);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca de produtos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Resultado da busca";
            // 
            // dtgProdutosNaPromocao
            // 
            this.dtgProdutosNaPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutosNaPromocao.Location = new System.Drawing.Point(516, 207);
            this.dtgProdutosNaPromocao.Name = "dtgProdutosNaPromocao";
            this.dtgProdutosNaPromocao.Size = new System.Drawing.Size(273, 150);
            this.dtgProdutosNaPromocao.TabIndex = 7;
            this.dtgProdutosNaPromocao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutosNaPromocao_CellContentClick);
            // 
            // lblPreço
            // 
            this.lblPreço.AutoSize = true;
            this.lblPreço.Location = new System.Drawing.Point(213, 303);
            this.lblPreço.Name = "lblPreço";
            this.lblPreço.Size = new System.Drawing.Size(61, 13);
            this.lblPreço.TabIndex = 9;
            this.lblPreço.Text = "Preço total:";
            this.lblPreço.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProdutosPromocao
            // 
            this.lbProdutosPromocao.FormattingEnabled = true;
            this.lbProdutosPromocao.Location = new System.Drawing.Point(280, 139);
            this.lbProdutosPromocao.Name = "lbProdutosPromocao";
            this.lbProdutosPromocao.Size = new System.Drawing.Size(111, 160);
            this.lbProdutosPromocao.TabIndex = 8;
            this.lbProdutosPromocao.SelectedIndexChanged += new System.EventHandler(this.lbProdutosPromocao_SelectedIndexChanged);
            // 
            // dtgBuscaProdutos
            // 
            this.dtgBuscaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscaProdutos.Location = new System.Drawing.Point(516, 25);
            this.dtgBuscaProdutos.Name = "dtgBuscaProdutos";
            this.dtgBuscaProdutos.Size = new System.Drawing.Size(234, 150);
            this.dtgBuscaProdutos.TabIndex = 4;
            // 
            // lbBuscaProdutos
            // 
            this.lbBuscaProdutos.FormattingEnabled = true;
            this.lbBuscaProdutos.Location = new System.Drawing.Point(15, 139);
            this.lbBuscaProdutos.Name = "lbBuscaProdutos";
            this.lbBuscaProdutos.Size = new System.Drawing.Size(104, 160);
            this.lbBuscaProdutos.TabIndex = 7;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(280, 91);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(280, 62);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtBuscaID
            // 
            this.txtBuscaID.Location = new System.Drawing.Point(122, 88);
            this.txtBuscaID.Name = "txtBuscaID";
            this.txtBuscaID.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaID.TabIndex = 3;
            this.txtBuscaID.TextChanged += new System.EventHandler(this.txtBuscaID_TextChanged);
            // 
            // txtBuscaPalavraChave
            // 
            this.txtBuscaPalavraChave.Location = new System.Drawing.Point(122, 41);
            this.txtBuscaPalavraChave.Name = "txtBuscaPalavraChave";
            this.txtBuscaPalavraChave.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaPalavraChave.TabIndex = 2;
            this.txtBuscaPalavraChave.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBuscaPalavraChave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Busca por ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar pelo nome do produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quem terá acesso à promoção?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(106, 372);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(170, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Somente usuários cadastrados";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(106, 395);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(144, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Qualquer visitante no site";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Preço da promoção";
            // 
            // txtNovoPreco
            // 
            this.txtNovoPreco.Location = new System.Drawing.Point(128, 458);
            this.txtNovoPreco.Name = "txtNovoPreco";
            this.txtNovoPreco.Size = new System.Drawing.Size(100, 20);
            this.txtNovoPreco.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(186, 504);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(105, 504);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // CadastrarPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 540);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNovoPreco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastrarPromocao";
            this.Text = "\\";
            this.Shown += new System.EventHandler(this.CadastrarPromocao_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutosNaPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNovoPreco;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label6;

    }
}