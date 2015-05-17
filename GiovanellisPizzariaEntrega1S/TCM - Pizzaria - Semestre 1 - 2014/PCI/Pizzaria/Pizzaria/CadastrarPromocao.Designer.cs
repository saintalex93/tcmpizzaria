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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarPromocao));
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.gridProdutosNaPromocao = new System.Windows.Forms.DataGridView();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridBuscaProdutos = new System.Windows.Forms.DataGridView();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtProdutoID = new System.Windows.Forms.TextBox();
            this.txtProdutoPalavraChave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckAcessivelATodos = new System.Windows.Forms.CheckBox();
            this.ckSobeSite = new System.Windows.Forms.CheckBox();
            this.dataVigencia = new System.Windows.Forms.DateTimePicker();
            this.btnCriarPromocoes = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescricaoPromocao = new System.Windows.Forms.TextBox();
            this.txtTituloPromocao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoverPromocao = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gridPromocoesEncontradas = new System.Windows.Forms.DataGridView();
            this.txtPromocaoID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPromocaoPalavraChave = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosNaPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscaProdutos)).BeginInit();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromocoesEncontradas)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.gridProdutosNaPromocao);
            this.grpProdutos.Controls.Add(this.btnRemoverProduto);
            this.grpProdutos.Controls.Add(this.label6);
            this.grpProdutos.Controls.Add(this.label2);
            this.grpProdutos.Controls.Add(this.gridBuscaProdutos);
            this.grpProdutos.Controls.Add(this.btnAdicionarProduto);
            this.grpProdutos.Controls.Add(this.txtProdutoID);
            this.grpProdutos.Controls.Add(this.txtProdutoPalavraChave);
            this.grpProdutos.Controls.Add(this.label3);
            this.grpProdutos.Controls.Add(this.label1);
            this.grpProdutos.Location = new System.Drawing.Point(12, 326);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Size = new System.Drawing.Size(678, 224);
            this.grpProdutos.TabIndex = 4;
            this.grpProdutos.TabStop = false;
            this.grpProdutos.Text = "Busca de Produtos";
            // 
            // gridProdutosNaPromocao
            // 
            this.gridProdutosNaPromocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridProdutosNaPromocao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridProdutosNaPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutosNaPromocao.Location = new System.Drawing.Point(351, 58);
            this.gridProdutosNaPromocao.Name = "gridProdutosNaPromocao";
            this.gridProdutosNaPromocao.ReadOnly = true;
            this.gridProdutosNaPromocao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridProdutosNaPromocao.Size = new System.Drawing.Size(317, 150);
            this.gridProdutosNaPromocao.TabIndex = 31;
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Enabled = false;
            this.btnRemoverProduto.Location = new System.Drawing.Point(648, 32);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(20, 20);
            this.btnRemoverProduto.TabIndex = 17;
            this.btnRemoverProduto.Text = "-";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Produtos encontrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produtos na promoção";
            // 
            // gridBuscaProdutos
            // 
            this.gridBuscaProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.gridBuscaProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridBuscaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuscaProdutos.Location = new System.Drawing.Point(9, 58);
            this.gridBuscaProdutos.Name = "gridBuscaProdutos";
            this.gridBuscaProdutos.ReadOnly = true;
            this.gridBuscaProdutos.Size = new System.Drawing.Size(300, 150);
            this.gridBuscaProdutos.TabIndex = 30;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Enabled = false;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(315, 120);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(30, 20);
            this.btnAdicionarProduto.TabIndex = 13;
            this.btnAdicionarProduto.Text = ">>";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtProdutoID
            // 
            this.txtProdutoID.Location = new System.Drawing.Point(238, 19);
            this.txtProdutoID.Name = "txtProdutoID";
            this.txtProdutoID.Size = new System.Drawing.Size(71, 20);
            this.txtProdutoID.TabIndex = 9999;
            this.txtProdutoID.TextChanged += new System.EventHandler(this.txtBuscaProdutoPorID_TextChanged);
            this.txtProdutoID.Enter += new System.EventHandler(this.txtBuscaProdutoPorID_Enter);
            this.txtProdutoID.Leave += new System.EventHandler(this.txtBuscaProdutoPorID_Leave);
            // 
            // txtProdutoPalavraChave
            // 
            this.txtProdutoPalavraChave.Location = new System.Drawing.Point(47, 19);
            this.txtProdutoPalavraChave.Name = "txtProdutoPalavraChave";
            this.txtProdutoPalavraChave.Size = new System.Drawing.Size(100, 20);
            this.txtProdutoPalavraChave.TabIndex = 999;
            this.txtProdutoPalavraChave.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtProdutoPalavraChave.Enter += new System.EventHandler(this.txtBuscaPalavraChave_Enter_1);
            this.txtProdutoPalavraChave.Leave += new System.EventHandler(this.txtBuscaPalavraChave_Leave_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(615, 556);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.label12);
            this.grpDados.Controls.Add(this.txtDesconto);
            this.grpDados.Controls.Add(this.label5);
            this.grpDados.Controls.Add(this.ckAcessivelATodos);
            this.grpDados.Controls.Add(this.ckSobeSite);
            this.grpDados.Controls.Add(this.dataVigencia);
            this.grpDados.Controls.Add(this.btnCriarPromocoes);
            this.grpDados.Controls.Add(this.label11);
            this.grpDados.Controls.Add(this.txtDescricaoPromocao);
            this.grpDados.Controls.Add(this.txtTituloPromocao);
            this.grpDados.Controls.Add(this.label8);
            this.grpDados.Controls.Add(this.label7);
            this.grpDados.Location = new System.Drawing.Point(12, 12);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(678, 127);
            this.grpDados.TabIndex = 20;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados da Promoção";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(653, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "%";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(628, 13);
            this.txtDesconto.MaxLength = 3;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(26, 20);
            this.txtDesconto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Desconto -";
            // 
            // ckAcessivelATodos
            // 
            this.ckAcessivelATodos.AutoSize = true;
            this.ckAcessivelATodos.Location = new System.Drawing.Point(531, 45);
            this.ckAcessivelATodos.Name = "ckAcessivelATodos";
            this.ckAcessivelATodos.Size = new System.Drawing.Size(111, 17);
            this.ckAcessivelATodos.TabIndex = 3;
            this.ckAcessivelATodos.Text = "Acessível à todos";
            this.ckAcessivelATodos.UseVisualStyleBackColor = true;
            this.ckAcessivelATodos.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckSobeSite
            // 
            this.ckSobeSite.AutoSize = true;
            this.ckSobeSite.Location = new System.Drawing.Point(422, 45);
            this.ckSobeSite.Name = "ckSobeSite";
            this.ckSobeSite.Size = new System.Drawing.Size(103, 17);
            this.ckSobeSite.TabIndex = 4;
            this.ckSobeSite.Text = "Sobe para o site";
            this.ckSobeSite.UseVisualStyleBackColor = true;
            this.ckSobeSite.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataVigencia
            // 
            this.dataVigencia.Checked = false;
            this.dataVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVigencia.Location = new System.Drawing.Point(463, 13);
            this.dataVigencia.Name = "dataVigencia";
            this.dataVigencia.Size = new System.Drawing.Size(100, 20);
            this.dataVigencia.TabIndex = 2;
            this.dataVigencia.ValueChanged += new System.EventHandler(this.dataPrazo_ValueChanged);
            // 
            // btnCriarPromocoes
            // 
            this.btnCriarPromocoes.Location = new System.Drawing.Point(648, 42);
            this.btnCriarPromocoes.Name = "btnCriarPromocoes";
            this.btnCriarPromocoes.Size = new System.Drawing.Size(20, 20);
            this.btnCriarPromocoes.TabIndex = 6;
            this.btnCriarPromocoes.Text = "+";
            this.btnCriarPromocoes.UseVisualStyleBackColor = true;
            this.btnCriarPromocoes.Click += new System.EventHandler(this.btnCriarPromocoes_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(409, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Vigência -";
            // 
            // txtDescricaoPromocao
            // 
            this.txtDescricaoPromocao.Location = new System.Drawing.Point(11, 68);
            this.txtDescricaoPromocao.Multiline = true;
            this.txtDescricaoPromocao.Name = "txtDescricaoPromocao";
            this.txtDescricaoPromocao.Size = new System.Drawing.Size(657, 47);
            this.txtDescricaoPromocao.TabIndex = 1;
            this.txtDescricaoPromocao.Enter += new System.EventHandler(this.txtDescricaoPromocao_Enter);
            this.txtDescricaoPromocao.Leave += new System.EventHandler(this.txtDescricaoPromocao_Leave);
            // 
            // txtTituloPromocao
            // 
            this.txtTituloPromocao.Location = new System.Drawing.Point(303, 13);
            this.txtTituloPromocao.Name = "txtTituloPromocao";
            this.txtTituloPromocao.Size = new System.Drawing.Size(100, 20);
            this.txtTituloPromocao.TabIndex = 0;
            this.txtTituloPromocao.TextChanged += new System.EventHandler(this.txtTituloPromocao_TextChanged);
            this.txtTituloPromocao.Enter += new System.EventHandler(this.txtTituloPromocao_Enter);
            this.txtTituloPromocao.Leave += new System.EventHandler(this.txtTituloPromocao_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Título -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Promoções encontradas";
            // 
            // btnRemoverPromocao
            // 
            this.btnRemoverPromocao.Location = new System.Drawing.Point(645, 19);
            this.btnRemoverPromocao.Name = "btnRemoverPromocao";
            this.btnRemoverPromocao.Size = new System.Drawing.Size(23, 23);
            this.btnRemoverPromocao.TabIndex = 10;
            this.btnRemoverPromocao.Text = "-";
            this.btnRemoverPromocao.UseVisualStyleBackColor = true;
            this.btnRemoverPromocao.Click += new System.EventHandler(this.btnRemoverPromocao_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(564, 19);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gridPromocoesEncontradas
            // 
            this.gridPromocoesEncontradas.AllowUserToAddRows = false;
            this.gridPromocoesEncontradas.AllowUserToDeleteRows = false;
            this.gridPromocoesEncontradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridPromocoesEncontradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridPromocoesEncontradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPromocoesEncontradas.Location = new System.Drawing.Point(11, 48);
            this.gridPromocoesEncontradas.Name = "gridPromocoesEncontradas";
            this.gridPromocoesEncontradas.ReadOnly = true;
            this.gridPromocoesEncontradas.RowTemplate.Height = 50;
            this.gridPromocoesEncontradas.Size = new System.Drawing.Size(657, 114);
            this.gridPromocoesEncontradas.TabIndex = 32;
            this.gridPromocoesEncontradas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPromocoesEncontradas_CellContentClick);
            this.gridPromocoesEncontradas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPromocoesEncontradas_CellDoubleClick);
            // 
            // txtPromocaoID
            // 
            this.txtPromocaoID.Location = new System.Drawing.Point(519, 19);
            this.txtPromocaoID.Name = "txtPromocaoID";
            this.txtPromocaoID.Size = new System.Drawing.Size(39, 20);
            this.txtPromocaoID.TabIndex = 8;
            this.txtPromocaoID.TextChanged += new System.EventHandler(this.txtBuscaPorID_TextChanged);
            this.txtPromocaoID.Enter += new System.EventHandler(this.txtBuscaPromocaoPorID_Enter);
            this.txtPromocaoID.Leave += new System.EventHandler(this.txtBuscaPromocaoPorID_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(495, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "ID -";
            // 
            // txtPromocaoPalavraChave
            // 
            this.txtPromocaoPalavraChave.Location = new System.Drawing.Point(389, 19);
            this.txtPromocaoPalavraChave.Name = "txtPromocaoPalavraChave";
            this.txtPromocaoPalavraChave.Size = new System.Drawing.Size(100, 20);
            this.txtPromocaoPalavraChave.TabIndex = 7;
            this.txtPromocaoPalavraChave.TextChanged += new System.EventHandler(this.txtBuscaPorTitulo_TextChanged);
            this.txtPromocaoPalavraChave.Enter += new System.EventHandler(this.txtBuscaPorTitulo_Enter);
            this.txtPromocaoPalavraChave.Leave += new System.EventHandler(this.txtBuscaPorTitulo_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Palavra-chave -";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gridPromocoesEncontradas);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtPromocaoID);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.btnRemoverPromocao);
            this.groupBox5.Controls.Add(this.txtPromocaoPalavraChave);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btnAlterar);
            this.groupBox5.Location = new System.Drawing.Point(12, 145);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(678, 175);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscar Promoções";
            // 
            // CadastrarPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 585);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.grpProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Promoções";
            this.Load += new System.EventHandler(this.CadastrarPromocao_Load);
            this.Shown += new System.EventHandler(this.CadastrarPromocao_Shown);
            this.grpProdutos.ResumeLayout(false);
            this.grpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosNaPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscaProdutos)).EndInit();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromocoesEncontradas)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProdutos;
        private System.Windows.Forms.TextBox txtProdutoID;
        private System.Windows.Forms.TextBox txtProdutoPalavraChave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridBuscaProdutos;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.TextBox txtDescricaoPromocao;
        private System.Windows.Forms.TextBox txtTituloPromocao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCriarPromocoes;
        private System.Windows.Forms.DataGridView gridPromocoesEncontradas;
        private System.Windows.Forms.TextBox txtPromocaoID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPromocaoPalavraChave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dataVigencia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemoverPromocao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ckAcessivelATodos;
        private System.Windows.Forms.CheckBox ckSobeSite;
        private System.Windows.Forms.DataGridView gridProdutosNaPromocao;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;

    }
}