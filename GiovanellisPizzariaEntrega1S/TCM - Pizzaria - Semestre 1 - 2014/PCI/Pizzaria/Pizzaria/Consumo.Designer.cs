namespace Pizzaria
{
    partial class Consumo
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
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.cbInsumo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridConsumo = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscaProdutoNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscaProdutoID = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscaInsumoNome = new System.Windows.Forms.TextBox();
            this.txtBuscaInsumoID = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsumo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numQuantidade
            // 
            this.numQuantidade.DecimalPlaces = 3;
            this.numQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numQuantidade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numQuantidade.Location = new System.Drawing.Point(138, 73);
            this.numQuantidade.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(54, 20);
            this.numQuantidade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade de consumo";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.cbInsumo);
            this.grpDados.Controls.Add(this.label6);
            this.grpDados.Controls.Add(this.btnAdicionar);
            this.grpDados.Controls.Add(this.numQuantidade);
            this.grpDados.Controls.Add(this.cbProduto);
            this.grpDados.Controls.Add(this.label1);
            this.grpDados.Controls.Add(this.label2);
            this.grpDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grpDados.Location = new System.Drawing.Point(257, 12);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(205, 130);
            this.grpDados.TabIndex = 4;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados do consumo";
            // 
            // cbInsumo
            // 
            this.cbInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbInsumo.FormattingEnabled = true;
            this.cbInsumo.Location = new System.Drawing.Point(71, 46);
            this.cbInsumo.Name = "cbInsumo";
            this.cbInsumo.Size = new System.Drawing.Size(121, 21);
            this.cbInsumo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(21, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Insumo";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(169, 99);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbProduto
            // 
            this.cbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(71, 19);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(121, 21);
            this.cbProduto.TabIndex = 4;
            this.cbProduto.SelectionChangeCommitted += new System.EventHandler(this.cbProduto_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produto\r\n";
            // 
            // gridConsumo
            // 
            this.gridConsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.gridConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsumo.Location = new System.Drawing.Point(6, 97);
            this.gridConsumo.Name = "gridConsumo";
            this.gridConsumo.Size = new System.Drawing.Size(444, 150);
            this.gridConsumo.TabIndex = 4;
            this.gridConsumo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsumo_CellValueChanged);
            this.gridConsumo.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsumo_RowLeave);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(395, 409);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(239, 136);
            this.label3.TabIndex = 6;
            this.label3.Text = "Esta é a tela de consumo. Nela é definido quanto de insumos serão usados em cada " +
    "produto.\r\n\r\nEsta etapa é obrgatória para adicionar um produto no sistema.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscaProdutoNome
            // 
            this.txtBuscaProdutoNome.Location = new System.Drawing.Point(6, 32);
            this.txtBuscaProdutoNome.Name = "txtBuscaProdutoNome";
            this.txtBuscaProdutoNome.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaProdutoNome.TabIndex = 6;
            this.txtBuscaProdutoNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome - Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(126, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID - Produto";
            // 
            // txtBuscaProdutoID
            // 
            this.txtBuscaProdutoID.Location = new System.Drawing.Point(112, 32);
            this.txtBuscaProdutoID.Name = "txtBuscaProdutoID";
            this.txtBuscaProdutoID.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaProdutoID.TabIndex = 8;
            this.txtBuscaProdutoID.TextChanged += new System.EventHandler(this.txtBuscaID_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(427, 68);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "-";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBuscaInsumoNome);
            this.groupBox1.Controls.Add(this.txtBuscaInsumoID);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.gridConsumo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBuscaProdutoNome);
            this.groupBox1.Controls.Add(this.txtBuscaProdutoID);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 255);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(17, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome - Insumo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(128, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID - Insumo";
            // 
            // txtBuscaInsumoNome
            // 
            this.txtBuscaInsumoNome.Location = new System.Drawing.Point(8, 71);
            this.txtBuscaInsumoNome.Name = "txtBuscaInsumoNome";
            this.txtBuscaInsumoNome.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaInsumoNome.TabIndex = 12;
            this.txtBuscaInsumoNome.TextChanged += new System.EventHandler(this.txtBuscaInsumoNome_TextChanged);
            // 
            // txtBuscaInsumoID
            // 
            this.txtBuscaInsumoID.Location = new System.Drawing.Point(114, 71);
            this.txtBuscaInsumoID.Name = "txtBuscaInsumoID";
            this.txtBuscaInsumoID.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaInsumoID.TabIndex = 14;
            this.txtBuscaInsumoID.TextChanged += new System.EventHandler(this.txtBuscaInsumoID_TextChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Location = new System.Drawing.Point(346, 68);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(314, 409);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(229, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 30);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Apenas produtos\r\nsem insumos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Consumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 436);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.grpDados);
            this.Name = "Consumo";
            this.Text = "Consumo";
            this.Load += new System.EventHandler(this.Consumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsumo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridConsumo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtBuscaProdutoNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscaProdutoID;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cbInsumo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBuscaInsumoNome;
        private System.Windows.Forms.TextBox txtBuscaInsumoID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}