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
            this.gpb_compras = new System.Windows.Forms.GroupBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.txt_qdtcomprada = new System.Windows.Forms.TextBox();
            this.txt_vlrunitario = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_qtdcomprada = new System.Windows.Forms.Label();
            this.lbl_valorunitario = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.dtg_gravacao = new System.Windows.Forms.DataGridView();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.dtp_datarecebimento = new System.Windows.Forms.DateTimePicker();
            this.lbl_datarecebimento = new System.Windows.Forms.Label();
            this.lbl_fornecedor = new System.Windows.Forms.Label();
            this.cb_fornecedores = new System.Windows.Forms.ComboBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_totalnota = new System.Windows.Forms.TextBox();
            this.gpb_compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_gravacao)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_compras
            // 
            this.gpb_compras.Controls.Add(this.cmb_categoria);
            this.gpb_compras.Controls.Add(this.txt_qdtcomprada);
            this.gpb_compras.Controls.Add(this.txt_vlrunitario);
            this.gpb_compras.Controls.Add(this.txt_nome);
            this.gpb_compras.Controls.Add(this.lbl_qtdcomprada);
            this.gpb_compras.Controls.Add(this.lbl_valorunitario);
            this.gpb_compras.Controls.Add(this.lbl_categoria);
            this.gpb_compras.Controls.Add(this.lbl_nome);
            this.gpb_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_compras.Location = new System.Drawing.Point(12, 28);
            this.gpb_compras.Name = "gpb_compras";
            this.gpb_compras.Size = new System.Drawing.Size(595, 174);
            this.gpb_compras.TabIndex = 0;
            this.gpb_compras.TabStop = false;
            this.gpb_compras.Text = "Cadastro de Compras";
            this.gpb_compras.Enter += new System.EventHandler(this.gpb_compras_Enter);
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
            this.cmb_categoria.Location = new System.Drawing.Point(159, 72);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cmb_categoria.TabIndex = 16;
            // 
            // txt_qdtcomprada
            // 
            this.txt_qdtcomprada.Location = new System.Drawing.Point(437, 99);
            this.txt_qdtcomprada.Name = "txt_qdtcomprada";
            this.txt_qdtcomprada.Size = new System.Drawing.Size(100, 20);
            this.txt_qdtcomprada.TabIndex = 12;
            this.txt_qdtcomprada.TextChanged += new System.EventHandler(this.txt_qdtcomprada_TextChanged);
            // 
            // txt_vlrunitario
            // 
            this.txt_vlrunitario.Location = new System.Drawing.Point(159, 117);
            this.txt_vlrunitario.Name = "txt_vlrunitario";
            this.txt_vlrunitario.Size = new System.Drawing.Size(121, 20);
            this.txt_vlrunitario.TabIndex = 10;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(159, 34);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(359, 20);
            this.txt_nome.TabIndex = 9;
            // 
            // lbl_qtdcomprada
            // 
            this.lbl_qtdcomprada.AutoSize = true;
            this.lbl_qtdcomprada.Location = new System.Drawing.Point(304, 102);
            this.lbl_qtdcomprada.Name = "lbl_qtdcomprada";
            this.lbl_qtdcomprada.Size = new System.Drawing.Size(113, 13);
            this.lbl_qtdcomprada.TabIndex = 6;
            this.lbl_qtdcomprada.Text = "Quantidade Comprada";
            this.lbl_qtdcomprada.Click += new System.EventHandler(this.lbl_qtdcomprada_Click);
            // 
            // lbl_valorunitario
            // 
            this.lbl_valorunitario.AutoSize = true;
            this.lbl_valorunitario.Location = new System.Drawing.Point(28, 120);
            this.lbl_valorunitario.Name = "lbl_valorunitario";
            this.lbl_valorunitario.Size = new System.Drawing.Size(70, 13);
            this.lbl_valorunitario.TabIndex = 2;
            this.lbl_valorunitario.Text = "Valor Unitário";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(28, 75);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(52, 13);
            this.lbl_categoria.TabIndex = 1;
            this.lbl_categoria.Text = "Categoria";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(28, 37);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(90, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome do Produto";
            // 
            // dtg_gravacao
            // 
            this.dtg_gravacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_gravacao.Location = new System.Drawing.Point(12, 401);
            this.dtg_gravacao.Name = "dtg_gravacao";
            this.dtg_gravacao.Size = new System.Drawing.Size(595, 150);
            this.dtg_gravacao.TabIndex = 1;
            this.dtg_gravacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_gravacao_CellContentClick);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(270, 353);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 2;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(12, 596);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 3;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(160, 596);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_gravar.TabIndex = 4;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(384, 596);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(532, 596);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // dtp_datarecebimento
            // 
            this.dtp_datarecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datarecebimento.Location = new System.Drawing.Point(334, 299);
            this.dtp_datarecebimento.Name = "dtp_datarecebimento";
            this.dtp_datarecebimento.Size = new System.Drawing.Size(96, 20);
            this.dtp_datarecebimento.TabIndex = 15;
            // 
            // lbl_datarecebimento
            // 
            this.lbl_datarecebimento.AutoSize = true;
            this.lbl_datarecebimento.Location = new System.Drawing.Point(194, 305);
            this.lbl_datarecebimento.Name = "lbl_datarecebimento";
            this.lbl_datarecebimento.Size = new System.Drawing.Size(111, 13);
            this.lbl_datarecebimento.TabIndex = 14;
            this.lbl_datarecebimento.Text = "Data de Recebimento";
            // 
            // lbl_fornecedor
            // 
            this.lbl_fornecedor.AutoSize = true;
            this.lbl_fornecedor.Location = new System.Drawing.Point(194, 232);
            this.lbl_fornecedor.Name = "lbl_fornecedor";
            this.lbl_fornecedor.Size = new System.Drawing.Size(61, 13);
            this.lbl_fornecedor.TabIndex = 16;
            this.lbl_fornecedor.Text = "Fornecedor";
            // 
            // cb_fornecedores
            // 
            this.cb_fornecedores.FormattingEnabled = true;
            this.cb_fornecedores.Location = new System.Drawing.Point(334, 229);
            this.cb_fornecedores.Name = "cb_fornecedores";
            this.cb_fornecedores.Size = new System.Drawing.Size(121, 21);
            this.cb_fornecedores.TabIndex = 17;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(194, 266);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(72, 13);
            this.lbl_total.TabIndex = 18;
            this.lbl_total.Text = "Total da Nota";
            // 
            // lbl_totalnota
            // 
            this.lbl_totalnota.Location = new System.Drawing.Point(334, 263);
            this.lbl_totalnota.Name = "lbl_totalnota";
            this.lbl_totalnota.Size = new System.Drawing.Size(121, 20);
            this.lbl_totalnota.TabIndex = 19;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 651);
            this.Controls.Add(this.lbl_totalnota);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.cb_fornecedores);
            this.Controls.Add(this.lbl_fornecedor);
            this.Controls.Add(this.dtp_datarecebimento);
            this.Controls.Add(this.lbl_datarecebimento);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.dtg_gravacao);
            this.Controls.Add(this.gpb_compras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.gpb_compras.ResumeLayout(false);
            this.gpb_compras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_gravacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_compras;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.DataGridView dtg_gravacao;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.TextBox txt_qdtcomprada;
        private System.Windows.Forms.TextBox txt_vlrunitario;
        private System.Windows.Forms.Label lbl_qtdcomprada;
        private System.Windows.Forms.Label lbl_valorunitario;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.DateTimePicker dtp_datarecebimento;
        private System.Windows.Forms.Label lbl_datarecebimento;
        private System.Windows.Forms.Label lbl_fornecedor;
        private System.Windows.Forms.ComboBox cb_fornecedores;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox lbl_totalnota;
    }
}