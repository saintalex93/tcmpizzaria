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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.gbp_produtos = new System.Windows.Forms.GroupBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.chk_site = new System.Windows.Forms.CheckBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtg_produtos = new System.Windows.Forms.DataGridView();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscaPorNome = new System.Windows.Forms.TextBox();
            this.txtBuscaPorID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbp_produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbp_produtos
            // 
            this.gbp_produtos.Controls.Add(this.txtPreco);
            this.gbp_produtos.Controls.Add(this.chk_site);
            this.gbp_produtos.Controls.Add(this.txt_nome);
            this.gbp_produtos.Controls.Add(this.label2);
            this.gbp_produtos.Controls.Add(this.label1);
            this.gbp_produtos.Controls.Add(this.btn_inserir);
            this.gbp_produtos.Location = new System.Drawing.Point(12, 12);
            this.gbp_produtos.Name = "gbp_produtos";
            this.gbp_produtos.Size = new System.Drawing.Size(395, 52);
            this.gbp_produtos.TabIndex = 10;
            this.gbp_produtos.TabStop = false;
            this.gbp_produtos.Text = "Dados do produto";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(209, 18);
            this.txtPreco.MaxLength = 5;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(44, 20);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // chk_site
            // 
            this.chk_site.AutoSize = true;
            this.chk_site.Location = new System.Drawing.Point(259, 21);
            this.chk_site.Name = "chk_site";
            this.chk_site.Size = new System.Drawing.Size(92, 17);
            this.chk_site.TabIndex = 3;
            this.chk_site.Text = "Visível no site";
            this.chk_site.UseVisualStyleBackColor = true;
            this.chk_site.CheckedChanged += new System.EventHandler(this.chk_site_CheckedChanged);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(47, 19);
            this.txt_nome.MaxLength = 40;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(95, 20);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.Enter += new System.EventHandler(this.txt_nome_Enter);
            this.txt_nome.Leave += new System.EventHandler(this.txt_nome_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço: R$";
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
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(357, 18);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(23, 23);
            this.btn_inserir.TabIndex = 4;
            this.btn_inserir.Text = "+";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-9, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 37);
            this.label5.TabIndex = 5;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtg_produtos
            // 
            this.dtg_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_produtos.Location = new System.Drawing.Point(6, 51);
            this.dtg_produtos.Name = "dtg_produtos";
            this.dtg_produtos.ReadOnly = true;
            this.dtg_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_produtos.Size = new System.Drawing.Size(383, 150);
            this.dtg_produtos.TabIndex = 11;
            this.dtg_produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_produtos_CellContentClick);
            this.dtg_produtos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_produtos_CellDoubleClick);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(286, 19);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizar.TabIndex = 6;
            this.btn_atualizar.Text = "Alterar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(366, 19);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(23, 23);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "-";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(332, 287);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 9;
            this.btn_sair.Text = "Voltar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // txtBuscaPorNome
            // 
            this.txtBuscaPorNome.Location = new System.Drawing.Point(50, 22);
            this.txtBuscaPorNome.Name = "txtBuscaPorNome";
            this.txtBuscaPorNome.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaPorNome.TabIndex = 14;
            this.txtBuscaPorNome.TextChanged += new System.EventHandler(this.txtBuscaPorNome_TextChanged);
            // 
            // txtBuscaPorID
            // 
            this.txtBuscaPorID.Location = new System.Drawing.Point(180, 22);
            this.txtBuscaPorID.Name = "txtBuscaPorID";
            this.txtBuscaPorID.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaPorID.TabIndex = 15;
            this.txtBuscaPorID.TextChanged += new System.EventHandler(this.txtBuscaPorID_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscaPorNome);
            this.groupBox1.Controls.Add(this.txtBuscaPorID);
            this.groupBox1.Controls.Add(this.dtg_produtos);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.btn_atualizar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 211);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar produtos";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 314);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.gbp_produtos);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Insumo_Load);
            this.EnabledChanged += new System.EventHandler(this.Produtos_EnabledChanged);
            this.gbp_produtos.ResumeLayout(false);
            this.gbp_produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbp_produtos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_site;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.DataGridView dtg_produtos;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscaPorNome;
        private System.Windows.Forms.TextBox txtBuscaPorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txt_nome;
    }
}