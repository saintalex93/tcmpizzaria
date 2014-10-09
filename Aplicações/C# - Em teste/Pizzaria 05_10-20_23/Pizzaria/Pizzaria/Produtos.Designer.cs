namespace Pizzaria
{
    partial class Produtos
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
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.dtg_gravacao = new System.Windows.Forms.DataGridView();
            this.gpb_compras = new System.Windows.Forms.GroupBox();
            this.cmb_medida = new System.Windows.Forms.ComboBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.dtp_datafabricacao = new System.Windows.Forms.DateTimePicker();
            this.dtp_datavalidade = new System.Windows.Forms.DateTimePicker();
            this.dtp_datarecebimento = new System.Windows.Forms.DateTimePicker();
            this.txt_qdtcomprada = new System.Windows.Forms.TextBox();
            this.txt_fornecedor = new System.Windows.Forms.TextBox();
            this.txt_vlrunitario = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_fornecedor = new System.Windows.Forms.Label();
            this.lbl_datafabricacao = new System.Windows.Forms.Label();
            this.lbl_qtdcomprada = new System.Windows.Forms.Label();
            this.lbl_medida = new System.Windows.Forms.Label();
            this.lbl_validade = new System.Windows.Forms.Label();
            this.lbl_datarecebimento = new System.Windows.Forms.Label();
            this.lbl_valorunitario = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_gravacao)).BeginInit();
            this.gpb_compras.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(572, 573);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 13;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(397, 573);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 12;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(199, 574);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_gravar.TabIndex = 11;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click_1);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(16, 574);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 10;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(296, 323);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 9;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            // 
            // dtg_gravacao
            // 
            this.dtg_gravacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_gravacao.Location = new System.Drawing.Point(-6, 376);
            this.dtg_gravacao.Name = "dtg_gravacao";
            this.dtg_gravacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_gravacao.Size = new System.Drawing.Size(691, 150);
            this.dtg_gravacao.TabIndex = 8;
            this.dtg_gravacao.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_gravacao_CellDoubleClick);
            // 
            // gpb_compras
            // 
            this.gpb_compras.Controls.Add(this.cmb_medida);
            this.gpb_compras.Controls.Add(this.cmb_categoria);
            this.gpb_compras.Controls.Add(this.dtp_datafabricacao);
            this.gpb_compras.Controls.Add(this.dtp_datavalidade);
            this.gpb_compras.Controls.Add(this.dtp_datarecebimento);
            this.gpb_compras.Controls.Add(this.txt_qdtcomprada);
            this.gpb_compras.Controls.Add(this.txt_fornecedor);
            this.gpb_compras.Controls.Add(this.txt_vlrunitario);
            this.gpb_compras.Controls.Add(this.txt_nome);
            this.gpb_compras.Controls.Add(this.lbl_fornecedor);
            this.gpb_compras.Controls.Add(this.lbl_datafabricacao);
            this.gpb_compras.Controls.Add(this.lbl_qtdcomprada);
            this.gpb_compras.Controls.Add(this.lbl_medida);
            this.gpb_compras.Controls.Add(this.lbl_validade);
            this.gpb_compras.Controls.Add(this.lbl_datarecebimento);
            this.gpb_compras.Controls.Add(this.lbl_valorunitario);
            this.gpb_compras.Controls.Add(this.lbl_categoria);
            this.gpb_compras.Controls.Add(this.lbl_nome);
            this.gpb_compras.Location = new System.Drawing.Point(-6, 43);
            this.gpb_compras.Name = "gpb_compras";
            this.gpb_compras.Size = new System.Drawing.Size(691, 259);
            this.gpb_compras.TabIndex = 7;
            this.gpb_compras.TabStop = false;
            this.gpb_compras.Text = "Cadastro de Compras";
            // 
            // cmb_medida
            // 
            this.cmb_medida.FormattingEnabled = true;
            this.cmb_medida.Items.AddRange(new object[] {
            "Selecione...",
            "Unidade",
            "Litro",
            "Caixa",
            "Fardo",
            "Kilograma"});
            this.cmb_medida.Location = new System.Drawing.Point(515, 72);
            this.cmb_medida.Name = "cmb_medida";
            this.cmb_medida.Size = new System.Drawing.Size(100, 21);
            this.cmb_medida.TabIndex = 17;
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Items.AddRange(new object[] {
            "Selecione...",
            "Bebida alcóolica",
            "Bebida não alcóolica",
            "Itens para cozinha",
            "Ingredientes",
            "Embalagens"});
            this.cmb_categoria.Location = new System.Drawing.Point(159, 67);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cmb_categoria.TabIndex = 16;
            // 
            // dtp_datafabricacao
            // 
            this.dtp_datafabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datafabricacao.Location = new System.Drawing.Point(515, 146);
            this.dtp_datafabricacao.Name = "dtp_datafabricacao";
            this.dtp_datafabricacao.Size = new System.Drawing.Size(100, 20);
            this.dtp_datafabricacao.TabIndex = 15;
            // 
            // dtp_datavalidade
            // 
            this.dtp_datavalidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datavalidade.Location = new System.Drawing.Point(160, 187);
            this.dtp_datavalidade.Name = "dtp_datavalidade";
            this.dtp_datavalidade.Size = new System.Drawing.Size(96, 20);
            this.dtp_datavalidade.TabIndex = 14;
            // 
            // dtp_datarecebimento
            // 
            this.dtp_datarecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datarecebimento.Location = new System.Drawing.Point(160, 145);
            this.dtp_datarecebimento.Name = "dtp_datarecebimento";
            this.dtp_datarecebimento.Size = new System.Drawing.Size(96, 20);
            this.dtp_datarecebimento.TabIndex = 13;
            // 
            // txt_qdtcomprada
            // 
            this.txt_qdtcomprada.Location = new System.Drawing.Point(515, 109);
            this.txt_qdtcomprada.Name = "txt_qdtcomprada";
            this.txt_qdtcomprada.Size = new System.Drawing.Size(100, 20);
            this.txt_qdtcomprada.TabIndex = 12;
            // 
            // txt_fornecedor
            // 
            this.txt_fornecedor.Location = new System.Drawing.Point(515, 187);
            this.txt_fornecedor.Name = "txt_fornecedor";
            this.txt_fornecedor.Size = new System.Drawing.Size(100, 20);
            this.txt_fornecedor.TabIndex = 11;
            // 
            // txt_vlrunitario
            // 
            this.txt_vlrunitario.Location = new System.Drawing.Point(150, 105);
            this.txt_vlrunitario.Name = "txt_vlrunitario";
            this.txt_vlrunitario.Size = new System.Drawing.Size(121, 20);
            this.txt_vlrunitario.TabIndex = 10;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(150, 34);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(359, 20);
            this.txt_nome.TabIndex = 9;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // lbl_fornecedor
            // 
            this.lbl_fornecedor.AutoSize = true;
            this.lbl_fornecedor.Location = new System.Drawing.Point(408, 193);
            this.lbl_fornecedor.Name = "lbl_fornecedor";
            this.lbl_fornecedor.Size = new System.Drawing.Size(61, 13);
            this.lbl_fornecedor.TabIndex = 8;
            this.lbl_fornecedor.Text = "Fornecedor";
            // 
            // lbl_datafabricacao
            // 
            this.lbl_datafabricacao.AutoSize = true;
            this.lbl_datafabricacao.Location = new System.Drawing.Point(408, 152);
            this.lbl_datafabricacao.Name = "lbl_datafabricacao";
            this.lbl_datafabricacao.Size = new System.Drawing.Size(101, 13);
            this.lbl_datafabricacao.TabIndex = 7;
            this.lbl_datafabricacao.Text = "Data de Fabricação";
            // 
            // lbl_qtdcomprada
            // 
            this.lbl_qtdcomprada.AutoSize = true;
            this.lbl_qtdcomprada.Location = new System.Drawing.Point(408, 112);
            this.lbl_qtdcomprada.Name = "lbl_qtdcomprada";
            this.lbl_qtdcomprada.Size = new System.Drawing.Size(75, 13);
            this.lbl_qtdcomprada.TabIndex = 6;
            this.lbl_qtdcomprada.Text = "Qdt Comprada";
            // 
            // lbl_medida
            // 
            this.lbl_medida.AutoSize = true;
            this.lbl_medida.Location = new System.Drawing.Point(408, 75);
            this.lbl_medida.Name = "lbl_medida";
            this.lbl_medida.Size = new System.Drawing.Size(42, 13);
            this.lbl_medida.TabIndex = 5;
            this.lbl_medida.Text = "Medida";
            // 
            // lbl_validade
            // 
            this.lbl_validade.AutoSize = true;
            this.lbl_validade.Location = new System.Drawing.Point(19, 193);
            this.lbl_validade.Name = "lbl_validade";
            this.lbl_validade.Size = new System.Drawing.Size(89, 13);
            this.lbl_validade.TabIndex = 4;
            this.lbl_validade.Text = "Data de Validade";
            // 
            // lbl_datarecebimento
            // 
            this.lbl_datarecebimento.AutoSize = true;
            this.lbl_datarecebimento.Location = new System.Drawing.Point(19, 152);
            this.lbl_datarecebimento.Name = "lbl_datarecebimento";
            this.lbl_datarecebimento.Size = new System.Drawing.Size(111, 13);
            this.lbl_datarecebimento.TabIndex = 3;
            this.lbl_datarecebimento.Text = "Data de Recebimento";
            // 
            // lbl_valorunitario
            // 
            this.lbl_valorunitario.AutoSize = true;
            this.lbl_valorunitario.Location = new System.Drawing.Point(19, 112);
            this.lbl_valorunitario.Name = "lbl_valorunitario";
            this.lbl_valorunitario.Size = new System.Drawing.Size(70, 13);
            this.lbl_valorunitario.TabIndex = 2;
            this.lbl_valorunitario.Text = "Valor Unitário";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(19, 75);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(52, 13);
            this.lbl_categoria.TabIndex = 1;
            this.lbl_categoria.Text = "Categoria";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(19, 37);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 640);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.dtg_gravacao);
            this.Controls.Add(this.gpb_compras);
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_gravacao)).EndInit();
            this.gpb_compras.ResumeLayout(false);
            this.gpb_compras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.DataGridView dtg_gravacao;
        private System.Windows.Forms.GroupBox gpb_compras;
        private System.Windows.Forms.ComboBox cmb_medida;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.DateTimePicker dtp_datafabricacao;
        private System.Windows.Forms.DateTimePicker dtp_datavalidade;
        private System.Windows.Forms.DateTimePicker dtp_datarecebimento;
        private System.Windows.Forms.TextBox txt_qdtcomprada;
        private System.Windows.Forms.TextBox txt_fornecedor;
        private System.Windows.Forms.TextBox txt_vlrunitario;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_fornecedor;
        private System.Windows.Forms.Label lbl_datafabricacao;
        private System.Windows.Forms.Label lbl_qtdcomprada;
        private System.Windows.Forms.Label lbl_medida;
        private System.Windows.Forms.Label lbl_validade;
        private System.Windows.Forms.Label lbl_datarecebimento;
        private System.Windows.Forms.Label lbl_valorunitario;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_nome;

    }
}