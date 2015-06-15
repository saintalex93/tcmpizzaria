namespace Pizzaria
{
    partial class Compras
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
            this.groupCompras = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoverCompra = new System.Windows.Forms.Button();
            this.groupRegistrar = new System.Windows.Forms.GroupBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.dtCompra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionarCompra = new System.Windows.Forms.Button();
            this.btnAlterarCompra = new System.Windows.Forms.Button();
            this.gridCompras = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.btnNovoFornecedor = new System.Windows.Forms.Button();
            this.groupFornecedores = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDFornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gridFornecedores = new System.Windows.Forms.DataGridView();
            this.txtPalavraChave = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupDetalhes = new System.Windows.Forms.GroupBox();
            this.groupAdicionarInsumos = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbInsumo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreçoUnitario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numQuantidadeInsumo = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionarInsumoNaCompra = new System.Windows.Forms.Button();
            this.btnRemoverInsumoDaCompra = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gridInsumos = new System.Windows.Forms.DataGridView();
            this.groupCompras.SuspendLayout();
            this.groupRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).BeginInit();
            this.groupFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedores)).BeginInit();
            this.groupDetalhes.SuspendLayout();
            this.groupAdicionarInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCompras
            // 
            this.groupCompras.Controls.Add(this.label2);
            this.groupCompras.Controls.Add(this.btnRemoverCompra);
            this.groupCompras.Controls.Add(this.groupRegistrar);
            this.groupCompras.Controls.Add(this.btnAlterarCompra);
            this.groupCompras.Controls.Add(this.gridCompras);
            this.groupCompras.Location = new System.Drawing.Point(12, 248);
            this.groupCompras.Name = "groupCompras";
            this.groupCompras.Size = new System.Drawing.Size(309, 280);
            this.groupCompras.TabIndex = 6;
            this.groupCompras.TabStop = false;
            this.groupCompras.Text = "Compras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Compras com fornecedor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRemoverCompra
            // 
            this.btnRemoverCompra.Location = new System.Drawing.Point(270, 93);
            this.btnRemoverCompra.Name = "btnRemoverCompra";
            this.btnRemoverCompra.Size = new System.Drawing.Size(23, 23);
            this.btnRemoverCompra.TabIndex = 12;
            this.btnRemoverCompra.Text = "-";
            this.btnRemoverCompra.UseVisualStyleBackColor = true;
            this.btnRemoverCompra.Click += new System.EventHandler(this.btnRemoverCompra_Click);
            // 
            // groupRegistrar
            // 
            this.groupRegistrar.Controls.Add(this.cbFuncionario);
            this.groupRegistrar.Controls.Add(this.dtCompra);
            this.groupRegistrar.Controls.Add(this.label5);
            this.groupRegistrar.Controls.Add(this.label4);
            this.groupRegistrar.Controls.Add(this.btnAdicionarCompra);
            this.groupRegistrar.Location = new System.Drawing.Point(15, 19);
            this.groupRegistrar.Name = "groupRegistrar";
            this.groupRegistrar.Size = new System.Drawing.Size(278, 68);
            this.groupRegistrar.TabIndex = 6;
            this.groupRegistrar.TabStop = false;
            this.groupRegistrar.Text = "Registrar";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(22, 35);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(121, 21);
            this.cbFuncionario.TabIndex = 7;
            // 
            // dtCompra
            // 
            this.dtCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCompra.Location = new System.Drawing.Point(149, 35);
            this.dtCompra.Name = "dtCompra";
            this.dtCompra.Size = new System.Drawing.Size(81, 20);
            this.dtCompra.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data da compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Funcionário que comprou";
            // 
            // btnAdicionarCompra
            // 
            this.btnAdicionarCompra.Location = new System.Drawing.Point(236, 33);
            this.btnAdicionarCompra.Name = "btnAdicionarCompra";
            this.btnAdicionarCompra.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionarCompra.TabIndex = 7;
            this.btnAdicionarCompra.Text = "+";
            this.btnAdicionarCompra.UseVisualStyleBackColor = true;
            this.btnAdicionarCompra.Click += new System.EventHandler(this.btnAdicionarCompra_Click);
            // 
            // btnAlterarCompra
            // 
            this.btnAlterarCompra.Location = new System.Drawing.Point(204, 93);
            this.btnAlterarCompra.Name = "btnAlterarCompra";
            this.btnAlterarCompra.Size = new System.Drawing.Size(60, 23);
            this.btnAlterarCompra.TabIndex = 18;
            this.btnAlterarCompra.Text = "Alterar";
            this.btnAlterarCompra.UseVisualStyleBackColor = true;
            this.btnAlterarCompra.Click += new System.EventHandler(this.btnAlterarCompra_Click);
            // 
            // gridCompras
            // 
            this.gridCompras.AllowUserToAddRows = false;
            this.gridCompras.AllowUserToDeleteRows = false;
            this.gridCompras.AllowUserToResizeColumns = false;
            this.gridCompras.AllowUserToResizeRows = false;
            this.gridCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompras.Location = new System.Drawing.Point(15, 122);
            this.gridCompras.MultiSelect = false;
            this.gridCompras.Name = "gridCompras";
            this.gridCompras.ReadOnly = true;
            this.gridCompras.Size = new System.Drawing.Size(278, 150);
            this.gridCompras.TabIndex = 17;
            this.gridCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCompras_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Location = new System.Drawing.Point(321, 94);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(50, 20);
            this.txtTotalCompra.TabIndex = 17;
            // 
            // btnNovoFornecedor
            // 
            this.btnNovoFornecedor.Location = new System.Drawing.Point(613, 13);
            this.btnNovoFornecedor.Name = "btnNovoFornecedor";
            this.btnNovoFornecedor.Size = new System.Drawing.Size(102, 23);
            this.btnNovoFornecedor.TabIndex = 10;
            this.btnNovoFornecedor.Text = "Novo fornecedor";
            this.btnNovoFornecedor.UseVisualStyleBackColor = true;
            this.btnNovoFornecedor.Click += new System.EventHandler(this.btnNovoFornecedor_Click);
            // 
            // groupFornecedores
            // 
            this.groupFornecedores.Controls.Add(this.label7);
            this.groupFornecedores.Controls.Add(this.txtIDFornecedor);
            this.groupFornecedores.Controls.Add(this.btnNovoFornecedor);
            this.groupFornecedores.Controls.Add(this.label6);
            this.groupFornecedores.Controls.Add(this.gridFornecedores);
            this.groupFornecedores.Controls.Add(this.txtPalavraChave);
            this.groupFornecedores.Location = new System.Drawing.Point(12, 12);
            this.groupFornecedores.Name = "groupFornecedores";
            this.groupFornecedores.Size = new System.Drawing.Size(721, 230);
            this.groupFornecedores.TabIndex = 6;
            this.groupFornecedores.TabStop = false;
            this.groupFornecedores.Text = "Buscar fornecedores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID";
            // 
            // txtIDFornecedor
            // 
            this.txtIDFornecedor.Location = new System.Drawing.Point(121, 39);
            this.txtIDFornecedor.Name = "txtIDFornecedor";
            this.txtIDFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtIDFornecedor.TabIndex = 1;
            this.txtIDFornecedor.TextChanged += new System.EventHandler(this.txtIDFornecedor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Palavra-chave";
            // 
            // gridFornecedores
            // 
            this.gridFornecedores.AllowUserToAddRows = false;
            this.gridFornecedores.AllowUserToDeleteRows = false;
            this.gridFornecedores.AllowUserToResizeColumns = false;
            this.gridFornecedores.AllowUserToResizeRows = false;
            this.gridFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFornecedores.Location = new System.Drawing.Point(15, 65);
            this.gridFornecedores.MultiSelect = false;
            this.gridFornecedores.Name = "gridFornecedores";
            this.gridFornecedores.ReadOnly = true;
            this.gridFornecedores.Size = new System.Drawing.Size(697, 150);
            this.gridFornecedores.TabIndex = 7;
            this.gridFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFornecedores_CellClick);
            // 
            // txtPalavraChave
            // 
            this.txtPalavraChave.Location = new System.Drawing.Point(15, 39);
            this.txtPalavraChave.Name = "txtPalavraChave";
            this.txtPalavraChave.Size = new System.Drawing.Size(100, 20);
            this.txtPalavraChave.TabIndex = 13;
            this.txtPalavraChave.TextChanged += new System.EventHandler(this.txtPalavraChave_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(658, 534);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupDetalhes
            // 
            this.groupDetalhes.Controls.Add(this.label12);
            this.groupDetalhes.Controls.Add(this.groupAdicionarInsumos);
            this.groupDetalhes.Controls.Add(this.btnRemoverInsumoDaCompra);
            this.groupDetalhes.Controls.Add(this.label9);
            this.groupDetalhes.Controls.Add(this.gridInsumos);
            this.groupDetalhes.Controls.Add(this.txtTotalCompra);
            this.groupDetalhes.Location = new System.Drawing.Point(327, 251);
            this.groupDetalhes.Name = "groupDetalhes";
            this.groupDetalhes.Size = new System.Drawing.Size(406, 277);
            this.groupDetalhes.TabIndex = 6;
            this.groupDetalhes.TabStop = false;
            this.groupDetalhes.Text = "Detalhes da compra";
            // 
            // groupAdicionarInsumos
            // 
            this.groupAdicionarInsumos.Controls.Add(this.label13);
            this.groupAdicionarInsumos.Controls.Add(this.cbInsumo);
            this.groupAdicionarInsumos.Controls.Add(this.label3);
            this.groupAdicionarInsumos.Controls.Add(this.txtPreçoUnitario);
            this.groupAdicionarInsumos.Controls.Add(this.label10);
            this.groupAdicionarInsumos.Controls.Add(this.numQuantidadeInsumo);
            this.groupAdicionarInsumos.Controls.Add(this.btnAdicionarInsumoNaCompra);
            this.groupAdicionarInsumos.Location = new System.Drawing.Point(9, 19);
            this.groupAdicionarInsumos.Name = "groupAdicionarInsumos";
            this.groupAdicionarInsumos.Size = new System.Drawing.Size(322, 65);
            this.groupAdicionarInsumos.TabIndex = 6;
            this.groupAdicionarInsumos.TabStop = false;
            this.groupAdicionarInsumos.Text = "Adicionar insumo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Preço unitário";
            // 
            // cbInsumo
            // 
            this.cbInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInsumo.Enabled = false;
            this.cbInsumo.FormattingEnabled = true;
            this.cbInsumo.Location = new System.Drawing.Point(13, 35);
            this.cbInsumo.Name = "cbInsumo";
            this.cbInsumo.Size = new System.Drawing.Size(121, 21);
            this.cbInsumo.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Quantidade";
            // 
            // txtPreçoUnitario
            // 
            this.txtPreçoUnitario.Location = new System.Drawing.Point(226, 35);
            this.txtPreçoUnitario.Name = "txtPreçoUnitario";
            this.txtPreçoUnitario.Size = new System.Drawing.Size(54, 20);
            this.txtPreçoUnitario.TabIndex = 17;
            this.txtPreçoUnitario.Text = "0,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Adicionar insumo à compra";
            // 
            // numQuantidadeInsumo
            // 
            this.numQuantidadeInsumo.DecimalPlaces = 3;
            this.numQuantidadeInsumo.Location = new System.Drawing.Point(150, 36);
            this.numQuantidadeInsumo.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numQuantidadeInsumo.Name = "numQuantidadeInsumo";
            this.numQuantidadeInsumo.Size = new System.Drawing.Size(61, 20);
            this.numQuantidadeInsumo.TabIndex = 21;
            this.numQuantidadeInsumo.ThousandsSeparator = true;
            // 
            // btnAdicionarInsumoNaCompra
            // 
            this.btnAdicionarInsumoNaCompra.Location = new System.Drawing.Point(287, 35);
            this.btnAdicionarInsumoNaCompra.Name = "btnAdicionarInsumoNaCompra";
            this.btnAdicionarInsumoNaCompra.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionarInsumoNaCompra.TabIndex = 19;
            this.btnAdicionarInsumoNaCompra.Text = "+";
            this.btnAdicionarInsumoNaCompra.UseVisualStyleBackColor = true;
            this.btnAdicionarInsumoNaCompra.Click += new System.EventHandler(this.btnAdicionarInsumoNaCompra_Click);
            // 
            // btnRemoverInsumoDaCompra
            // 
            this.btnRemoverInsumoDaCompra.Location = new System.Drawing.Point(377, 93);
            this.btnRemoverInsumoDaCompra.Name = "btnRemoverInsumoDaCompra";
            this.btnRemoverInsumoDaCompra.Size = new System.Drawing.Size(23, 23);
            this.btnRemoverInsumoDaCompra.TabIndex = 20;
            this.btnRemoverInsumoDaCompra.Text = "-";
            this.btnRemoverInsumoDaCompra.UseVisualStyleBackColor = true;
            this.btnRemoverInsumoDaCompra.Click += new System.EventHandler(this.btnRemoverInsumoDaCompra_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Insumos na compra";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridInsumos
            // 
            this.gridInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInsumos.Location = new System.Drawing.Point(9, 119);
            this.gridInsumos.MultiSelect = false;
            this.gridInsumos.Name = "gridInsumos";
            this.gridInsumos.ReadOnly = true;
            this.gridInsumos.Size = new System.Drawing.Size(391, 150);
            this.gridInsumos.TabIndex = 18;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 565);
            this.ControlBox = false;
            this.Controls.Add(this.groupDetalhes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupFornecedores);
            this.Controls.Add(this.groupCompras);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.groupCompras.ResumeLayout(false);
            this.groupCompras.PerformLayout();
            this.groupRegistrar.ResumeLayout(false);
            this.groupRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).EndInit();
            this.groupFornecedores.ResumeLayout(false);
            this.groupFornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedores)).EndInit();
            this.groupDetalhes.ResumeLayout(false);
            this.groupDetalhes.PerformLayout();
            this.groupAdicionarInsumos.ResumeLayout(false);
            this.groupAdicionarInsumos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCompras;
        private System.Windows.Forms.DateTimePicker dtCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNovoFornecedor;
        private System.Windows.Forms.Button btnAdicionarCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.GroupBox groupFornecedores;
        private System.Windows.Forms.DataGridView gridFornecedores;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPalavraChave;
        private System.Windows.Forms.Button btnAlterarCompra;
        private System.Windows.Forms.DataGridView gridCompras;
        private System.Windows.Forms.GroupBox groupDetalhes;
        private System.Windows.Forms.Button btnRemoverInsumoDaCompra;
        private System.Windows.Forms.Button btnAdicionarInsumoNaCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbInsumo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gridInsumos;
        private System.Windows.Forms.Button btnRemoverCompra;
        private System.Windows.Forms.GroupBox groupRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupAdicionarInsumos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numQuantidadeInsumo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPreçoUnitario;
    }
}