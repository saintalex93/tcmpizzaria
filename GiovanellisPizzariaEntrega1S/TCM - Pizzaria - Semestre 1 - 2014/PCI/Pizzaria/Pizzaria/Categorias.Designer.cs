namespace Pizzaria
{
    partial class Categorias
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
            this.btnAdicionarCategoria = new System.Windows.Forms.Button();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.btnRemoverProdutoCategoria = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.btnRemoverCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.btnAdicionarProdutoCategoria = new System.Windows.Forms.Button();
            this.lstProdutosCategoria = new System.Windows.Forms.ListBox();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.grpConteudo = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbInsumos = new System.Windows.Forms.ComboBox();
            this.btnRemoverInsumoCategoria = new System.Windows.Forms.Button();
            this.lstInsumosCategoria = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionarInsumoCategoria = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDados.SuspendLayout();
            this.grpConteudo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(92, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adicione um nome para uma nova categoria";
            // 
            // btnAdicionarCategoria
            // 
            this.btnAdicionarCategoria.Location = new System.Drawing.Point(327, 19);
            this.btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            this.btnAdicionarCategoria.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionarCategoria.TabIndex = 10;
            this.btnAdicionarCategoria.Text = "+";
            this.btnAdicionarCategoria.UseVisualStyleBackColor = true;
            this.btnAdicionarCategoria.Click += new System.EventHandler(this.btnAdicionarCategoria_Click);
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(95, 48);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(255, 20);
            this.txtNomeCategoria.TabIndex = 15;
            // 
            // btnRemoverProdutoCategoria
            // 
            this.btnRemoverProdutoCategoria.Location = new System.Drawing.Point(177, 54);
            this.btnRemoverProdutoCategoria.Name = "btnRemoverProdutoCategoria";
            this.btnRemoverProdutoCategoria.Size = new System.Drawing.Size(23, 23);
            this.btnRemoverProdutoCategoria.TabIndex = 15;
            this.btnRemoverProdutoCategoria.Text = "-";
            this.btnRemoverProdutoCategoria.UseVisualStyleBackColor = true;
            this.btnRemoverProdutoCategoria.Click += new System.EventHandler(this.btnRemoverProdutoCategoria_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(401, 399);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 11;
            this.btnFinalizar.Text = "Voltar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cbCategorias
            // 
            this.cbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(95, 102);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(255, 21);
            this.cbCategorias.TabIndex = 13;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            this.cbCategorias.Leave += new System.EventHandler(this.cbCategorias_Leave);
            // 
            // btnRemoverCategoria
            // 
            this.btnRemoverCategoria.Location = new System.Drawing.Point(246, 129);
            this.btnRemoverCategoria.Name = "btnRemoverCategoria";
            this.btnRemoverCategoria.Size = new System.Drawing.Size(23, 23);
            this.btnRemoverCategoria.TabIndex = 16;
            this.btnRemoverCategoria.Text = "-";
            this.btnRemoverCategoria.UseVisualStyleBackColor = true;
            this.btnRemoverCategoria.Click += new System.EventHandler(this.btnRemoverCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(170, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Escolha uma Categoria";
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Location = new System.Drawing.Point(275, 129);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Produtos na Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Adicionar produto:\r\n";
            // 
            // cbProdutos
            // 
            this.cbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(9, 43);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(117, 21);
            this.cbProdutos.TabIndex = 26;
            // 
            // btnAdicionarProdutoCategoria
            // 
            this.btnAdicionarProdutoCategoria.Location = new System.Drawing.Point(132, 43);
            this.btnAdicionarProdutoCategoria.Name = "btnAdicionarProdutoCategoria";
            this.btnAdicionarProdutoCategoria.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionarProdutoCategoria.TabIndex = 27;
            this.btnAdicionarProdutoCategoria.Text = "+";
            this.btnAdicionarProdutoCategoria.UseVisualStyleBackColor = true;
            this.btnAdicionarProdutoCategoria.Click += new System.EventHandler(this.btnAdicionarProdutoCategoria_Click);
            // 
            // lstProdutosCategoria
            // 
            this.lstProdutosCategoria.FormattingEnabled = true;
            this.lstProdutosCategoria.Location = new System.Drawing.Point(10, 83);
            this.lstProdutosCategoria.Name = "lstProdutosCategoria";
            this.lstProdutosCategoria.Size = new System.Drawing.Size(190, 95);
            this.lstProdutosCategoria.TabIndex = 20;
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.grpConteudo);
            this.grpDados.Controls.Add(this.btnAlterar);
            this.grpDados.Controls.Add(this.label1);
            this.grpDados.Controls.Add(this.btnRemoverCategoria);
            this.grpDados.Controls.Add(this.cbCategorias);
            this.grpDados.Controls.Add(this.txtNomeCategoria);
            this.grpDados.Controls.Add(this.btnAdicionarCategoria);
            this.grpDados.Controls.Add(this.label2);
            this.grpDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grpDados.Location = new System.Drawing.Point(12, 12);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(464, 381);
            this.grpDados.TabIndex = 7;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Gerenciar categorias";
            // 
            // grpConteudo
            // 
            this.grpConteudo.Controls.Add(this.groupBox3);
            this.grpConteudo.Controls.Add(this.groupBox1);
            this.grpConteudo.Enabled = false;
            this.grpConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grpConteudo.Location = new System.Drawing.Point(9, 155);
            this.grpConteudo.Name = "grpConteudo";
            this.grpConteudo.Size = new System.Drawing.Size(443, 218);
            this.grpConteudo.TabIndex = 19;
            this.grpConteudo.TabStop = false;
            this.grpConteudo.Text = "Conteúdo das categorias";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbInsumos);
            this.groupBox3.Controls.Add(this.btnRemoverInsumoCategoria);
            this.groupBox3.Controls.Add(this.lstInsumosCategoria);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnAdicionarInsumoCategoria);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(228, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 191);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insumos";
            // 
            // cbInsumos
            // 
            this.cbInsumos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbInsumos.FormattingEnabled = true;
            this.cbInsumos.Location = new System.Drawing.Point(8, 43);
            this.cbInsumos.Name = "cbInsumos";
            this.cbInsumos.Size = new System.Drawing.Size(117, 21);
            this.cbInsumos.TabIndex = 32;
            // 
            // btnRemoverInsumoCategoria
            // 
            this.btnRemoverInsumoCategoria.Location = new System.Drawing.Point(176, 54);
            this.btnRemoverInsumoCategoria.Name = "btnRemoverInsumoCategoria";
            this.btnRemoverInsumoCategoria.Size = new System.Drawing.Size(23, 23);
            this.btnRemoverInsumoCategoria.TabIndex = 28;
            this.btnRemoverInsumoCategoria.Text = "-";
            this.btnRemoverInsumoCategoria.UseVisualStyleBackColor = true;
            this.btnRemoverInsumoCategoria.Click += new System.EventHandler(this.btnRemoverInsumoCategoria_Click);
            // 
            // lstInsumosCategoria
            // 
            this.lstInsumosCategoria.FormattingEnabled = true;
            this.lstInsumosCategoria.Location = new System.Drawing.Point(9, 83);
            this.lstInsumosCategoria.Name = "lstInsumosCategoria";
            this.lstInsumosCategoria.Size = new System.Drawing.Size(190, 95);
            this.lstInsumosCategoria.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(5, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Insumos na Categoria";
            // 
            // btnAdicionarInsumoCategoria
            // 
            this.btnAdicionarInsumoCategoria.Location = new System.Drawing.Point(131, 43);
            this.btnAdicionarInsumoCategoria.Name = "btnAdicionarInsumoCategoria";
            this.btnAdicionarInsumoCategoria.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionarInsumoCategoria.TabIndex = 33;
            this.btnAdicionarInsumoCategoria.Text = "+";
            this.btnAdicionarInsumoCategoria.UseVisualStyleBackColor = true;
            this.btnAdicionarInsumoCategoria.Click += new System.EventHandler(this.btnAdicionarInsumoCategoria_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(5, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Adicionar insumo\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnRemoverProdutoCategoria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbProdutos);
            this.groupBox1.Controls.Add(this.btnAdicionarProdutoCategoria);
            this.groupBox1.Controls.Add(this.lstProdutosCategoria);
            this.groupBox1.Location = new System.Drawing.Point(10, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 191);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(320, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 431);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.btnFinalizar);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpConteudo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionarCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Button btnRemoverProdutoCategoria;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoverCategoria;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionarProdutoCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProdutos;
        private System.Windows.Forms.ListBox lstProdutosCategoria;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.GroupBox grpConteudo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbInsumos;
        private System.Windows.Forms.Button btnRemoverInsumoCategoria;
        private System.Windows.Forms.ListBox lstInsumosCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionarInsumoCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;

    }
}