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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gridBuscaProdutos = new System.Windows.Forms.DataGridView();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtBuscaProdutoPorID = new System.Windows.Forms.TextBox();
            this.txtBuscaPalavraChave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnProcessarNovoPreco = new System.Windows.Forms.Button();
            this.txtNovoPreco = new System.Windows.Forms.TextBox();
            this.gridProdutosNaPromocao = new System.Windows.Forms.DataGridView();
            this.lblPreço = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckVisivelNoSite = new System.Windows.Forms.CheckBox();
            this.ckAcessoCadastrado = new System.Windows.Forms.CheckBox();
            this.dataPrazo = new System.Windows.Forms.DateTimePicker();
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
            this.txtBuscaPromocaoPorID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscaPorTitulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosNaPromocao)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromocoesEncontradas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produtos na promoção";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.gridBuscaProdutos);
            this.groupBox1.Controls.Add(this.btnAdicionarProduto);
            this.groupBox1.Controls.Add(this.txtBuscaProdutoPorID);
            this.groupBox1.Controls.Add(this.txtBuscaPalavraChave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 262);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca de Produtos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Resultado da busca";
            // 
            // gridBuscaProdutos
            // 
            this.gridBuscaProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.gridBuscaProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridBuscaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuscaProdutos.Location = new System.Drawing.Point(11, 74);
            this.gridBuscaProdutos.Name = "gridBuscaProdutos";
            this.gridBuscaProdutos.ReadOnly = true;
            this.gridBuscaProdutos.Size = new System.Drawing.Size(282, 150);
            this.gridBuscaProdutos.TabIndex = 23;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Enabled = false;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(191, 230);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(102, 23);
            this.btnAdicionarProduto.TabIndex = 13;
            this.btnAdicionarProduto.Text = "Adicionar produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtBuscaProdutoPorID
            // 
            this.txtBuscaProdutoPorID.Location = new System.Drawing.Point(222, 35);
            this.txtBuscaProdutoPorID.Name = "txtBuscaProdutoPorID";
            this.txtBuscaProdutoPorID.Size = new System.Drawing.Size(71, 20);
            this.txtBuscaProdutoPorID.TabIndex = 12;
            this.txtBuscaProdutoPorID.TextChanged += new System.EventHandler(this.txtBuscaProdutoPorID_TextChanged);
            this.txtBuscaProdutoPorID.Enter += new System.EventHandler(this.txtBuscaProdutoPorID_Enter);
            this.txtBuscaProdutoPorID.Leave += new System.EventHandler(this.txtBuscaProdutoPorID_Leave);
            // 
            // txtBuscaPalavraChave
            // 
            this.txtBuscaPalavraChave.Location = new System.Drawing.Point(10, 35);
            this.txtBuscaPalavraChave.Name = "txtBuscaPalavraChave";
            this.txtBuscaPalavraChave.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaPalavraChave.TabIndex = 11;
            this.txtBuscaPalavraChave.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBuscaPalavraChave.Enter += new System.EventHandler(this.txtBuscaPalavraChave_Enter_1);
            this.txtBuscaPalavraChave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtBuscaPalavraChave.Leave += new System.EventHandler(this.txtBuscaPalavraChave_Leave_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Busca por ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar pelo nome do produto";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(14, 203);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(69, 20);
            this.txtSaldo.TabIndex = 14;
            this.txtSaldo.Enter += new System.EventHandler(this.txtSaldo_Enter);
            this.txtSaldo.Leave += new System.EventHandler(this.txtSaldo_Leave);
            // 
            // btnProcessarNovoPreco
            // 
            this.btnProcessarNovoPreco.Enabled = false;
            this.btnProcessarNovoPreco.Location = new System.Drawing.Point(14, 229);
            this.btnProcessarNovoPreco.Name = "btnProcessarNovoPreco";
            this.btnProcessarNovoPreco.Size = new System.Drawing.Size(122, 23);
            this.btnProcessarNovoPreco.TabIndex = 17;
            this.btnProcessarNovoPreco.Text = "Processar novo preço";
            this.btnProcessarNovoPreco.UseVisualStyleBackColor = true;
            // 
            // txtNovoPreco
            // 
            this.txtNovoPreco.Location = new System.Drawing.Point(100, 203);
            this.txtNovoPreco.Name = "txtNovoPreco";
            this.txtNovoPreco.Size = new System.Drawing.Size(69, 20);
            this.txtNovoPreco.TabIndex = 15;
            this.txtNovoPreco.TextChanged += new System.EventHandler(this.txtNovoPreco_TextChanged);
            this.txtNovoPreco.Enter += new System.EventHandler(this.txtNovoPreco_Enter_1);
            this.txtNovoPreco.Leave += new System.EventHandler(this.txtNovoPreco_Leave_1);
            // 
            // gridProdutosNaPromocao
            // 
            this.gridProdutosNaPromocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.gridProdutosNaPromocao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridProdutosNaPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutosNaPromocao.Location = new System.Drawing.Point(14, 34);
            this.gridProdutosNaPromocao.Name = "gridProdutosNaPromocao";
            this.gridProdutosNaPromocao.ReadOnly = true;
            this.gridProdutosNaPromocao.Size = new System.Drawing.Size(273, 150);
            this.gridProdutosNaPromocao.TabIndex = 24;
            // 
            // lblPreço
            // 
            this.lblPreço.AutoSize = true;
            this.lblPreço.Location = new System.Drawing.Point(11, 187);
            this.lblPreço.Name = "lblPreço";
            this.lblPreço.Size = new System.Drawing.Size(78, 13);
            this.lblPreço.TabIndex = 9;
            this.lblPreço.Text = "Saldo produtos";
            this.lblPreço.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Novo Preço";
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Enabled = false;
            this.btnRemoverProduto.Location = new System.Drawing.Point(187, 200);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(98, 23);
            this.btnRemoverProduto.TabIndex = 16;
            this.btnRemoverProduto.Text = "Remover produto";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(538, 612);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckVisivelNoSite);
            this.groupBox2.Controls.Add(this.ckAcessoCadastrado);
            this.groupBox2.Controls.Add(this.dataPrazo);
            this.groupBox2.Controls.Add(this.btnCriarPromocoes);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDescricaoPromocao);
            this.groupBox2.Controls.Add(this.txtTituloPromocao);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 134);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Promoção";
            // 
            // ckVisivelNoSite
            // 
            this.ckVisivelNoSite.AutoSize = true;
            this.ckVisivelNoSite.Location = new System.Drawing.Point(354, 26);
            this.ckVisivelNoSite.Name = "ckVisivelNoSite";
            this.ckVisivelNoSite.Size = new System.Drawing.Size(223, 17);
            this.ckVisivelNoSite.TabIndex = 3;
            this.ckVisivelNoSite.Text = "Visível apenas para usuários cadastrados";
            this.ckVisivelNoSite.UseVisualStyleBackColor = true;
            this.ckVisivelNoSite.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckAcessoCadastrado
            // 
            this.ckAcessoCadastrado.AutoSize = true;
            this.ckAcessoCadastrado.Location = new System.Drawing.Point(474, 47);
            this.ckAcessoCadastrado.Name = "ckAcessoCadastrado";
            this.ckAcessoCadastrado.Size = new System.Drawing.Size(103, 17);
            this.ckAcessoCadastrado.TabIndex = 4;
            this.ckAcessoCadastrado.Text = "Sobe para o site";
            this.ckAcessoCadastrado.UseVisualStyleBackColor = true;
            this.ckAcessoCadastrado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataPrazo
            // 
            this.dataPrazo.Checked = false;
            this.dataPrazo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPrazo.Location = new System.Drawing.Point(241, 25);
            this.dataPrazo.Name = "dataPrazo";
            this.dataPrazo.Size = new System.Drawing.Size(100, 20);
            this.dataPrazo.TabIndex = 2;
            this.dataPrazo.ValueChanged += new System.EventHandler(this.dataPrazo_ValueChanged);
            // 
            // btnCriarPromocoes
            // 
            this.btnCriarPromocoes.Location = new System.Drawing.Point(465, 75);
            this.btnCriarPromocoes.Name = "btnCriarPromocoes";
            this.btnCriarPromocoes.Size = new System.Drawing.Size(112, 36);
            this.btnCriarPromocoes.TabIndex = 6;
            this.btnCriarPromocoes.Text = "Adicionar Nova Promoção";
            this.btnCriarPromocoes.UseVisualStyleBackColor = true;
            this.btnCriarPromocoes.Click += new System.EventHandler(this.btnCriarPromocoes_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Vigência";
            // 
            // txtDescricaoPromocao
            // 
            this.txtDescricaoPromocao.Location = new System.Drawing.Point(35, 64);
            this.txtDescricaoPromocao.Multiline = true;
            this.txtDescricaoPromocao.Name = "txtDescricaoPromocao";
            this.txtDescricaoPromocao.Size = new System.Drawing.Size(379, 47);
            this.txtDescricaoPromocao.TabIndex = 5;
            this.txtDescricaoPromocao.Enter += new System.EventHandler(this.txtDescricaoPromocao_Enter);
            this.txtDescricaoPromocao.Leave += new System.EventHandler(this.txtDescricaoPromocao_Leave);
            // 
            // txtTituloPromocao
            // 
            this.txtTituloPromocao.Location = new System.Drawing.Point(74, 25);
            this.txtTituloPromocao.Name = "txtTituloPromocao";
            this.txtTituloPromocao.Size = new System.Drawing.Size(100, 20);
            this.txtTituloPromocao.TabIndex = 1;
            this.txtTituloPromocao.TextChanged += new System.EventHandler(this.txtTituloPromocao_TextChanged);
            this.txtTituloPromocao.Enter += new System.EventHandler(this.txtTituloPromocao_Enter);
            this.txtTituloPromocao.Leave += new System.EventHandler(this.txtTituloPromocao_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Título";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Banco de Promoções";
            // 
            // btnRemoverPromocao
            // 
            this.btnRemoverPromocao.Location = new System.Drawing.Point(517, 158);
            this.btnRemoverPromocao.Name = "btnRemoverPromocao";
            this.btnRemoverPromocao.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverPromocao.TabIndex = 10;
            this.btnRemoverPromocao.Text = "Remover";
            this.btnRemoverPromocao.UseVisualStyleBackColor = true;
            this.btnRemoverPromocao.Click += new System.EventHandler(this.btnRemoverPromocao_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(436, 158);
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
            this.gridPromocoesEncontradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.gridPromocoesEncontradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridPromocoesEncontradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPromocoesEncontradas.Location = new System.Drawing.Point(6, 39);
            this.gridPromocoesEncontradas.Name = "gridPromocoesEncontradas";
            this.gridPromocoesEncontradas.ReadOnly = true;
            this.gridPromocoesEncontradas.RowTemplate.Height = 50;
            this.gridPromocoesEncontradas.Size = new System.Drawing.Size(586, 114);
            this.gridPromocoesEncontradas.TabIndex = 22;
            this.gridPromocoesEncontradas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPromocoesEncontradas_CellContentClick);
            // 
            // txtBuscaPromocaoPorID
            // 
            this.txtBuscaPromocaoPorID.Location = new System.Drawing.Point(558, 13);
            this.txtBuscaPromocaoPorID.Name = "txtBuscaPromocaoPorID";
            this.txtBuscaPromocaoPorID.Size = new System.Drawing.Size(39, 20);
            this.txtBuscaPromocaoPorID.TabIndex = 8;
            this.txtBuscaPromocaoPorID.TextChanged += new System.EventHandler(this.txtBuscaPorID_TextChanged);
            this.txtBuscaPromocaoPorID.Enter += new System.EventHandler(this.txtBuscaPromocaoPorID_Enter);
            this.txtBuscaPromocaoPorID.Leave += new System.EventHandler(this.txtBuscaPromocaoPorID_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Buscar por ID";
            // 
            // txtBuscaPorTitulo
            // 
            this.txtBuscaPorTitulo.Location = new System.Drawing.Point(374, 13);
            this.txtBuscaPorTitulo.Name = "txtBuscaPorTitulo";
            this.txtBuscaPorTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaPorTitulo.TabIndex = 7;
            this.txtBuscaPorTitulo.TextChanged += new System.EventHandler(this.txtBuscaPorTitulo_TextChanged);
            this.txtBuscaPorTitulo.Enter += new System.EventHandler(this.txtBuscaPorTitulo_Enter);
            this.txtBuscaPorTitulo.Leave += new System.EventHandler(this.txtBuscaPorTitulo_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Buscar por título";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridProdutosNaPromocao);
            this.groupBox4.Controls.Add(this.txtSaldo);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnRemoverProduto);
            this.groupBox4.Controls.Add(this.btnProcessarNovoPreco);
            this.groupBox4.Controls.Add(this.lblPreço);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtNovoPreco);
            this.groupBox4.Location = new System.Drawing.Point(319, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 261);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Conteúdo da Promoção";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gridPromocoesEncontradas);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtBuscaPromocaoPorID);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.btnRemoverPromocao);
            this.groupBox5.Controls.Add(this.txtBuscaPorTitulo);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btnAlterar);
            this.groupBox5.Location = new System.Drawing.Point(12, 152);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(607, 187);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscar Promoções";
            // 
            // CadastrarPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 647);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criação de Promoções";
            this.Load += new System.EventHandler(this.CadastrarPromocao_Load);
            this.Shown += new System.EventHandler(this.CadastrarPromocao_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosNaPromocao)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromocoesEncontradas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscaProdutoPorID;
        private System.Windows.Forms.TextBox txtBuscaPalavraChave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridBuscaProdutos;
        private System.Windows.Forms.DataGridView gridProdutosNaPromocao;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Label lblPreço;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNovoPreco;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescricaoPromocao;
        private System.Windows.Forms.TextBox txtTituloPromocao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCriarPromocoes;
        private System.Windows.Forms.DataGridView gridPromocoesEncontradas;
        private System.Windows.Forms.TextBox txtBuscaPromocaoPorID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscaPorTitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dataPrazo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemoverPromocao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnProcessarNovoPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ckVisivelNoSite;
        private System.Windows.Forms.CheckBox ckAcessoCadastrado;

    }
}