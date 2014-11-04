namespace Pizzaria
{
    partial class Insumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insumo));
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.dtg_gravacao = new System.Windows.Forms.DataGridView();
            this.gpb_compras = new System.Windows.Forms.GroupBox();
            this.txtbox_Recomendada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_Fornecedores = new System.Windows.Forms.ComboBox();
            this.txt_vlrunitario = new System.Windows.Forms.MaskedTextBox();
            this.cmb_medida = new System.Windows.Forms.ComboBox();
            this.dtp_datafabricacao = new System.Windows.Forms.DateTimePicker();
            this.dtp_datavalidade = new System.Windows.Forms.DateTimePicker();
            this.dtp_datarecebimento = new System.Windows.Forms.DateTimePicker();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_fornecedor = new System.Windows.Forms.Label();
            this.lbl_datafabricacao = new System.Windows.Forms.Label();
            this.lbl_medida = new System.Windows.Forms.Label();
            this.lbl_validade = new System.Windows.Forms.Label();
            this.lbl_datarecebimento = new System.Windows.Forms.Label();
            this.lbl_valorunitario = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidadeEmEstoque = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_gravacao)).BeginInit();
            this.gpb_compras.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(382, 373);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 15;
            this.btn_sair.Text = "Voltar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(301, 373);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 14;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(138, 373);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_gravar.TabIndex = 12;
            this.btn_gravar.Text = "Atualizar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click_1);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(57, 373);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 11;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(227, 188);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 10;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // dtg_gravacao
            // 
            this.dtg_gravacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_gravacao.Location = new System.Drawing.Point(12, 217);
            this.dtg_gravacao.MultiSelect = false;
            this.dtg_gravacao.Name = "dtg_gravacao";
            this.dtg_gravacao.ReadOnly = true;
            this.dtg_gravacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_gravacao.Size = new System.Drawing.Size(505, 150);
            this.dtg_gravacao.TabIndex = 23;
            this.dtg_gravacao.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_gravacao_CellDoubleClick);
            // 
            // gpb_compras
            // 
            this.gpb_compras.Controls.Add(this.txtQuantidadeEmEstoque);
            this.gpb_compras.Controls.Add(this.label2);
            this.gpb_compras.Controls.Add(this.txtbox_Recomendada);
            this.gpb_compras.Controls.Add(this.label1);
            this.gpb_compras.Controls.Add(this.cbox_Fornecedores);
            this.gpb_compras.Controls.Add(this.txt_vlrunitario);
            this.gpb_compras.Controls.Add(this.cmb_medida);
            this.gpb_compras.Controls.Add(this.dtp_datafabricacao);
            this.gpb_compras.Controls.Add(this.dtp_datavalidade);
            this.gpb_compras.Controls.Add(this.dtp_datarecebimento);
            this.gpb_compras.Controls.Add(this.txt_nome);
            this.gpb_compras.Controls.Add(this.lbl_fornecedor);
            this.gpb_compras.Controls.Add(this.lbl_datafabricacao);
            this.gpb_compras.Controls.Add(this.lbl_medida);
            this.gpb_compras.Controls.Add(this.lbl_validade);
            this.gpb_compras.Controls.Add(this.lbl_datarecebimento);
            this.gpb_compras.Controls.Add(this.lbl_valorunitario);
            this.gpb_compras.Controls.Add(this.lbl_nome);
            this.gpb_compras.Location = new System.Drawing.Point(9, 22);
            this.gpb_compras.Name = "gpb_compras";
            this.gpb_compras.Size = new System.Drawing.Size(508, 160);
            this.gpb_compras.TabIndex = 22;
            this.gpb_compras.TabStop = false;
            this.gpb_compras.Text = "Cadastro de Insumos";
            this.gpb_compras.Enter += new System.EventHandler(this.gpb_compras_Enter);
            // 
            // txtbox_Recomendada
            // 
            this.txtbox_Recomendada.Location = new System.Drawing.Point(401, 128);
            this.txtbox_Recomendada.Name = "txtbox_Recomendada";
            this.txtbox_Recomendada.Size = new System.Drawing.Size(99, 20);
            this.txtbox_Recomendada.TabIndex = 5;
            this.txtbox_Recomendada.Enter += new System.EventHandler(this.txtbox_Recomendada_Enter);
            this.txtbox_Recomendada.Leave += new System.EventHandler(this.txtbox_Recomendada_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quantidade recomendada";
            // 
            // cbox_Fornecedores
            // 
            this.cbox_Fornecedores.FormattingEnabled = true;
            this.cbox_Fornecedores.Items.AddRange(new object[] {
            "Selecione..."});
            this.cbox_Fornecedores.Location = new System.Drawing.Point(141, 101);
            this.cbox_Fornecedores.Name = "cbox_Fornecedores";
            this.cbox_Fornecedores.Size = new System.Drawing.Size(121, 21);
            this.cbox_Fornecedores.TabIndex = 9;
            this.cbox_Fornecedores.DropDown += new System.EventHandler(this.cbox_Fornecedores_DropDown);
            this.cbox_Fornecedores.Enter += new System.EventHandler(this.cbox_Fornecedores_Enter);
            this.cbox_Fornecedores.Leave += new System.EventHandler(this.cbox_Fornecedores_Leave);
            // 
            // txt_vlrunitario
            // 
            this.txt_vlrunitario.Location = new System.Drawing.Point(141, 49);
            this.txt_vlrunitario.Mask = "$ 0000,00";
            this.txt_vlrunitario.Name = "txt_vlrunitario";
            this.txt_vlrunitario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_vlrunitario.Size = new System.Drawing.Size(100, 20);
            this.txt_vlrunitario.TabIndex = 4;
            this.txt_vlrunitario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_vlrunitario_MouseClick);
            this.txt_vlrunitario.TextChanged += new System.EventHandler(this.txt_vlrunitario_TextChanged);
            this.txt_vlrunitario.Enter += new System.EventHandler(this.txt_vlrunitario_Enter);
            this.txt_vlrunitario.Leave += new System.EventHandler(this.txt_vlrunitario_Leave);
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
            this.cmb_medida.Location = new System.Drawing.Point(400, 49);
            this.cmb_medida.Name = "cmb_medida";
            this.cmb_medida.Size = new System.Drawing.Size(100, 21);
            this.cmb_medida.TabIndex = 3;
            this.cmb_medida.Enter += new System.EventHandler(this.cmb_medida_Enter);
            this.cmb_medida.Leave += new System.EventHandler(this.cmb_medida_Leave);
            // 
            // dtp_datafabricacao
            // 
            this.dtp_datafabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datafabricacao.Location = new System.Drawing.Point(141, 75);
            this.dtp_datafabricacao.Name = "dtp_datafabricacao";
            this.dtp_datafabricacao.Size = new System.Drawing.Size(100, 20);
            this.dtp_datafabricacao.TabIndex = 7;
            this.dtp_datafabricacao.ValueChanged += new System.EventHandler(this.dtp_datafabricacao_ValueChanged);
            this.dtp_datafabricacao.Enter += new System.EventHandler(this.dtp_datafabricacao_Enter);
            this.dtp_datafabricacao.Leave += new System.EventHandler(this.dtp_datafabricacao_Leave);
            // 
            // dtp_datavalidade
            // 
            this.dtp_datavalidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datavalidade.Location = new System.Drawing.Point(401, 102);
            this.dtp_datavalidade.Name = "dtp_datavalidade";
            this.dtp_datavalidade.Size = new System.Drawing.Size(99, 20);
            this.dtp_datavalidade.TabIndex = 8;
            this.dtp_datavalidade.Enter += new System.EventHandler(this.dtp_datavalidade_Enter);
            this.dtp_datavalidade.Leave += new System.EventHandler(this.dtp_datavalidade_Leave);
            // 
            // dtp_datarecebimento
            // 
            this.dtp_datarecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datarecebimento.Location = new System.Drawing.Point(400, 76);
            this.dtp_datarecebimento.Name = "dtp_datarecebimento";
            this.dtp_datarecebimento.Size = new System.Drawing.Size(100, 20);
            this.dtp_datarecebimento.TabIndex = 6;
            this.dtp_datarecebimento.Enter += new System.EventHandler(this.dtp_datarecebimento_Enter);
            this.dtp_datarecebimento.Leave += new System.EventHandler(this.dtp_datarecebimento_Leave);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(141, 23);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(359, 20);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            this.txt_nome.Enter += new System.EventHandler(this.txt_nome_Enter);
            this.txt_nome.Leave += new System.EventHandler(this.txt_nome_Leave);
            // 
            // lbl_fornecedor
            // 
            this.lbl_fornecedor.AutoSize = true;
            this.lbl_fornecedor.Location = new System.Drawing.Point(74, 107);
            this.lbl_fornecedor.Name = "lbl_fornecedor";
            this.lbl_fornecedor.Size = new System.Drawing.Size(61, 13);
            this.lbl_fornecedor.TabIndex = 8;
            this.lbl_fornecedor.Text = "Fornecedor";
            // 
            // lbl_datafabricacao
            // 
            this.lbl_datafabricacao.AutoSize = true;
            this.lbl_datafabricacao.Location = new System.Drawing.Point(34, 79);
            this.lbl_datafabricacao.Name = "lbl_datafabricacao";
            this.lbl_datafabricacao.Size = new System.Drawing.Size(101, 13);
            this.lbl_datafabricacao.TabIndex = 7;
            this.lbl_datafabricacao.Text = "Data de Fabricação";
            // 
            // lbl_medida
            // 
            this.lbl_medida.AutoSize = true;
            this.lbl_medida.Location = new System.Drawing.Point(352, 52);
            this.lbl_medida.Name = "lbl_medida";
            this.lbl_medida.Size = new System.Drawing.Size(42, 13);
            this.lbl_medida.TabIndex = 5;
            this.lbl_medida.Text = "Medida";
            // 
            // lbl_validade
            // 
            this.lbl_validade.AutoSize = true;
            this.lbl_validade.Location = new System.Drawing.Point(306, 104);
            this.lbl_validade.Name = "lbl_validade";
            this.lbl_validade.Size = new System.Drawing.Size(89, 13);
            this.lbl_validade.TabIndex = 4;
            this.lbl_validade.Text = "Data de Validade";
            // 
            // lbl_datarecebimento
            // 
            this.lbl_datarecebimento.AutoSize = true;
            this.lbl_datarecebimento.Location = new System.Drawing.Point(284, 81);
            this.lbl_datarecebimento.Name = "lbl_datarecebimento";
            this.lbl_datarecebimento.Size = new System.Drawing.Size(106, 13);
            this.lbl_datarecebimento.TabIndex = 3;
            this.lbl_datarecebimento.Text = "Data de recebimento";
            // 
            // lbl_valorunitario
            // 
            this.lbl_valorunitario.AutoSize = true;
            this.lbl_valorunitario.Location = new System.Drawing.Point(65, 52);
            this.lbl_valorunitario.Name = "lbl_valorunitario";
            this.lbl_valorunitario.Size = new System.Drawing.Size(68, 13);
            this.lbl_valorunitario.TabIndex = 2;
            this.lbl_valorunitario.Text = "Valor unitário";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(100, 26);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(220, 373);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantidade em estoque";
            // 
            // txtQuantidadeEmEstoque
            // 
            this.txtQuantidadeEmEstoque.Location = new System.Drawing.Point(141, 128);
            this.txtQuantidadeEmEstoque.MaxLength = 3;
            this.txtQuantidadeEmEstoque.Name = "txtQuantidadeEmEstoque";
            this.txtQuantidadeEmEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeEmEstoque.TabIndex = 22;
            // 
            // Insumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 423);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.dtg_gravacao);
            this.Controls.Add(this.gpb_compras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Insumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumos";
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
        private System.Windows.Forms.DateTimePicker dtp_datafabricacao;
        private System.Windows.Forms.DateTimePicker dtp_datavalidade;
        private System.Windows.Forms.DateTimePicker dtp_datarecebimento;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_fornecedor;
        private System.Windows.Forms.Label lbl_datafabricacao;
        private System.Windows.Forms.Label lbl_medida;
        private System.Windows.Forms.Label lbl_validade;
        private System.Windows.Forms.Label lbl_datarecebimento;
        private System.Windows.Forms.Label lbl_valorunitario;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.MaskedTextBox txt_vlrunitario;
        private System.Windows.Forms.ComboBox cbox_Fornecedores;
        private System.Windows.Forms.TextBox txtbox_Recomendada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidadeEmEstoque;
        private System.Windows.Forms.Label label2;

    }
}