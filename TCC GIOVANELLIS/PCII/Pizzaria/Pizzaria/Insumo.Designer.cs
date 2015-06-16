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
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.dtg_gravacao = new System.Windows.Forms.DataGridView();
            this.gpb_compras = new System.Windows.Forms.GroupBox();
            this.numQuantidadeEmEstoque = new System.Windows.Forms.NumericUpDown();
            this.numQuantidadeRecomendada = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_medida = new System.Windows.Forms.ComboBox();
            this.dtp_datafabricacao = new System.Windows.Forms.DateTimePicker();
            this.dtp_datavalidade = new System.Windows.Forms.DateTimePicker();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_datafabricacao = new System.Windows.Forms.Label();
            this.lbl_medida = new System.Windows.Forms.Label();
            this.lbl_validade = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarPorNome = new System.Windows.Forms.TextBox();
            this.txtBuscarPorID = new System.Windows.Forms.TextBox();
            this.Busca = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_gravacao)).BeginInit();
            this.gpb_compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeEmEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeRecomendada)).BeginInit();
            this.Busca.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(442, 409);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 15;
            this.btn_sair.Text = "Voltar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(474, 38);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(23, 23);
            this.btn_excluir.TabIndex = 14;
            this.btn_excluir.Text = "-";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(393, 38);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 11;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(477, 128);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(23, 23);
            this.btn_inserir.TabIndex = 10;
            this.btn_inserir.Text = "+";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // dtg_gravacao
            // 
            this.dtg_gravacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_gravacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_gravacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_gravacao.Location = new System.Drawing.Point(7, 67);
            this.dtg_gravacao.MultiSelect = false;
            this.dtg_gravacao.Name = "dtg_gravacao";
            this.dtg_gravacao.ReadOnly = true;
            this.dtg_gravacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_gravacao.Size = new System.Drawing.Size(490, 150);
            this.dtg_gravacao.TabIndex = 23;
            // 
            // gpb_compras
            // 
            this.gpb_compras.Controls.Add(this.numQuantidadeEmEstoque);
            this.gpb_compras.Controls.Add(this.numQuantidadeRecomendada);
            this.gpb_compras.Controls.Add(this.label2);
            this.gpb_compras.Controls.Add(this.label1);
            this.gpb_compras.Controls.Add(this.cmb_medida);
            this.gpb_compras.Controls.Add(this.btn_inserir);
            this.gpb_compras.Controls.Add(this.dtp_datafabricacao);
            this.gpb_compras.Controls.Add(this.dtp_datavalidade);
            this.gpb_compras.Controls.Add(this.txt_nome);
            this.gpb_compras.Controls.Add(this.lbl_datafabricacao);
            this.gpb_compras.Controls.Add(this.lbl_medida);
            this.gpb_compras.Controls.Add(this.lbl_validade);
            this.gpb_compras.Controls.Add(this.lbl_nome);
            this.gpb_compras.Location = new System.Drawing.Point(9, 12);
            this.gpb_compras.Name = "gpb_compras";
            this.gpb_compras.Size = new System.Drawing.Size(508, 159);
            this.gpb_compras.TabIndex = 22;
            this.gpb_compras.TabStop = false;
            this.gpb_compras.Text = "Cadastro de Insumos";
            this.gpb_compras.Enter += new System.EventHandler(this.gpb_compras_Enter);
            // 
            // numQuantidadeEmEstoque
            // 
            this.numQuantidadeEmEstoque.DecimalPlaces = 3;
            this.numQuantidadeEmEstoque.Location = new System.Drawing.Point(141, 103);
            this.numQuantidadeEmEstoque.Name = "numQuantidadeEmEstoque";
            this.numQuantidadeEmEstoque.Size = new System.Drawing.Size(100, 20);
            this.numQuantidadeEmEstoque.TabIndex = 24;
            // 
            // numQuantidadeRecomendada
            // 
            this.numQuantidadeRecomendada.DecimalPlaces = 3;
            this.numQuantidadeRecomendada.Location = new System.Drawing.Point(401, 102);
            this.numQuantidadeRecomendada.Name = "numQuantidadeRecomendada";
            this.numQuantidadeRecomendada.Size = new System.Drawing.Size(99, 20);
            this.numQuantidadeRecomendada.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantidade em estoque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quantidade recomendada";
            // 
            // cmb_medida
            // 
            this.cmb_medida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_medida.FormattingEnabled = true;
            this.cmb_medida.Items.AddRange(new object[] {
            "Kg",
            "Un"});
            this.cmb_medida.Location = new System.Drawing.Point(141, 49);
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
            this.dtp_datavalidade.Location = new System.Drawing.Point(401, 79);
            this.dtp_datavalidade.Name = "dtp_datavalidade";
            this.dtp_datavalidade.Size = new System.Drawing.Size(99, 20);
            this.dtp_datavalidade.TabIndex = 8;
            this.dtp_datavalidade.Enter += new System.EventHandler(this.dtp_datavalidade_Enter);
            this.dtp_datavalidade.Leave += new System.EventHandler(this.dtp_datavalidade_Leave);
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
            this.lbl_medida.Location = new System.Drawing.Point(93, 52);
            this.lbl_medida.Name = "lbl_medida";
            this.lbl_medida.Size = new System.Drawing.Size(42, 13);
            this.lbl_medida.TabIndex = 5;
            this.lbl_medida.Text = "Medida";
            // 
            // lbl_validade
            // 
            this.lbl_validade.AutoSize = true;
            this.lbl_validade.Location = new System.Drawing.Point(301, 83);
            this.lbl_validade.Name = "lbl_validade";
            this.lbl_validade.Size = new System.Drawing.Size(89, 13);
            this.lbl_validade.TabIndex = 4;
            this.lbl_validade.Text = "Data de Validade";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID";
            // 
            // txtBuscarPorNome
            // 
            this.txtBuscarPorNome.Location = new System.Drawing.Point(9, 41);
            this.txtBuscarPorNome.Name = "txtBuscarPorNome";
            this.txtBuscarPorNome.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarPorNome.TabIndex = 26;
            this.txtBuscarPorNome.TextChanged += new System.EventHandler(this.txtBuscarPorNome_TextChanged);
            // 
            // txtBuscarPorID
            // 
            this.txtBuscarPorID.Location = new System.Drawing.Point(115, 41);
            this.txtBuscarPorID.Name = "txtBuscarPorID";
            this.txtBuscarPorID.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarPorID.TabIndex = 27;
            this.txtBuscarPorID.TextChanged += new System.EventHandler(this.txtBuscarPorID_TextChanged);
            // 
            // Busca
            // 
            this.Busca.Controls.Add(this.label3);
            this.Busca.Controls.Add(this.txtBuscarPorID);
            this.Busca.Controls.Add(this.dtg_gravacao);
            this.Busca.Controls.Add(this.txtBuscarPorNome);
            this.Busca.Controls.Add(this.btn_alterar);
            this.Busca.Controls.Add(this.label4);
            this.Busca.Controls.Add(this.btn_excluir);
            this.Busca.Location = new System.Drawing.Point(12, 177);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(505, 226);
            this.Busca.TabIndex = 28;
            this.Busca.TabStop = false;
            this.Busca.Text = "Buscar";
            // 
            // Insumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 438);
            this.ControlBox = false;
            this.Controls.Add(this.Busca);
            this.Controls.Add(this.btn_sair);
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
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeEmEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeRecomendada)).EndInit();
            this.Busca.ResumeLayout(false);
            this.Busca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.DataGridView dtg_gravacao;
        private System.Windows.Forms.GroupBox gpb_compras;
        private System.Windows.Forms.ComboBox cmb_medida;
        private System.Windows.Forms.DateTimePicker dtp_datafabricacao;
        private System.Windows.Forms.DateTimePicker dtp_datavalidade;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_datafabricacao;
        private System.Windows.Forms.Label lbl_medida;
        private System.Windows.Forms.Label lbl_validade;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarPorNome;
        private System.Windows.Forms.TextBox txtBuscarPorID;
        private System.Windows.Forms.GroupBox Busca;
        private System.Windows.Forms.NumericUpDown numQuantidadeRecomendada;
        private System.Windows.Forms.NumericUpDown numQuantidadeEmEstoque;

    }
}