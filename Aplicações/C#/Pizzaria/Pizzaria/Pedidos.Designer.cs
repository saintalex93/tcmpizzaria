namespace Pizzaria
{
    partial class Pedidos
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
            this.gpb_detalhamento = new System.Windows.Forms.GroupBox();
            this.txt_idproduto = new System.Windows.Forms.TextBox();
            this.txt_palavrachave = new System.Windows.Forms.TextBox();
            this.lbl_idproduto = new System.Windows.Forms.Label();
            this.lbl_palavrachave = new System.Windows.Forms.Label();
            this.gpb_dadoscliente = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.dtgw_resultado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.dgvw_produtosconsumidos = new System.Windows.Forms.DataGridView();
            this.lbl_produtosconsumidos = new System.Windows.Forms.Label();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_ajuste = new System.Windows.Forms.Label();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_ajuste = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.gpb_detalhamento.SuspendLayout();
            this.gpb_dadoscliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_produtosconsumidos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_detalhamento
            // 
            this.gpb_detalhamento.Controls.Add(this.txt_idproduto);
            this.gpb_detalhamento.Controls.Add(this.txt_palavrachave);
            this.gpb_detalhamento.Controls.Add(this.lbl_idproduto);
            this.gpb_detalhamento.Controls.Add(this.lbl_palavrachave);
            this.gpb_detalhamento.Location = new System.Drawing.Point(12, 12);
            this.gpb_detalhamento.Name = "gpb_detalhamento";
            this.gpb_detalhamento.Size = new System.Drawing.Size(692, 100);
            this.gpb_detalhamento.TabIndex = 0;
            this.gpb_detalhamento.TabStop = false;
            this.gpb_detalhamento.Text = "Detalhamento do Pedido";
            // 
            // txt_idproduto
            // 
            this.txt_idproduto.Location = new System.Drawing.Point(560, 41);
            this.txt_idproduto.Name = "txt_idproduto";
            this.txt_idproduto.Size = new System.Drawing.Size(100, 20);
            this.txt_idproduto.TabIndex = 3;
            // 
            // txt_palavrachave
            // 
            this.txt_palavrachave.Location = new System.Drawing.Point(114, 28);
            this.txt_palavrachave.Name = "txt_palavrachave";
            this.txt_palavrachave.Size = new System.Drawing.Size(100, 20);
            this.txt_palavrachave.TabIndex = 1;
            // 
            // lbl_idproduto
            // 
            this.lbl_idproduto.AutoSize = true;
            this.lbl_idproduto.Location = new System.Drawing.Point(446, 44);
            this.lbl_idproduto.Name = "lbl_idproduto";
            this.lbl_idproduto.Size = new System.Drawing.Size(58, 13);
            this.lbl_idproduto.TabIndex = 2;
            this.lbl_idproduto.Text = "ID Produto";
            // 
            // lbl_palavrachave
            // 
            this.lbl_palavrachave.AutoSize = true;
            this.lbl_palavrachave.Location = new System.Drawing.Point(20, 35);
            this.lbl_palavrachave.Name = "lbl_palavrachave";
            this.lbl_palavrachave.Size = new System.Drawing.Size(77, 13);
            this.lbl_palavrachave.TabIndex = 0;
            this.lbl_palavrachave.Text = "Palavra Chave";
            // 
            // gpb_dadoscliente
            // 
            this.gpb_dadoscliente.Controls.Add(this.maskedTextBox1);
            this.gpb_dadoscliente.Controls.Add(this.txt_nome);
            this.gpb_dadoscliente.Controls.Add(this.lbl_cpf);
            this.gpb_dadoscliente.Controls.Add(this.lbl_nome);
            this.gpb_dadoscliente.Location = new System.Drawing.Point(12, 776);
            this.gpb_dadoscliente.Name = "gpb_dadoscliente";
            this.gpb_dadoscliente.Size = new System.Drawing.Size(692, 70);
            this.gpb_dadoscliente.TabIndex = 1;
            this.gpb_dadoscliente.TabStop = false;
            this.gpb_dadoscliente.Text = "Dados do Cliente";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(499, 27);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(114, 27);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(229, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(446, 30);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 1;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(29, 30);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(22, 140);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_resultado.TabIndex = 2;
            this.lbl_resultado.Text = "Resultado";
            // 
            // dtgw_resultado
            // 
            this.dtgw_resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Preço});
            this.dtgw_resultado.Location = new System.Drawing.Point(12, 171);
            this.dtgw_resultado.Name = "dtgw_resultado";
            this.dtgw_resultado.Size = new System.Drawing.Size(692, 150);
            this.dtgw_resultado.TabIndex = 3;
            this.dtgw_resultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.Location = new System.Drawing.Point(25, 366);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(62, 13);
            this.lbl_qtd.TabIndex = 5;
            this.lbl_qtd.Text = "Quantidade";
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(536, 366);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 6;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(104, 363);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(100, 20);
            this.txt_quantidade.TabIndex = 7;
            // 
            // dgvw_produtosconsumidos
            // 
            this.dgvw_produtosconsumidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_produtosconsumidos.Location = new System.Drawing.Point(12, 453);
            this.dgvw_produtosconsumidos.Name = "dgvw_produtosconsumidos";
            this.dgvw_produtosconsumidos.Size = new System.Drawing.Size(692, 150);
            this.dgvw_produtosconsumidos.TabIndex = 8;
            // 
            // lbl_produtosconsumidos
            // 
            this.lbl_produtosconsumidos.AutoSize = true;
            this.lbl_produtosconsumidos.Location = new System.Drawing.Point(25, 427);
            this.lbl_produtosconsumidos.Name = "lbl_produtosconsumidos";
            this.lbl_produtosconsumidos.Size = new System.Drawing.Size(109, 13);
            this.lbl_produtosconsumidos.TabIndex = 10;
            this.lbl_produtosconsumidos.Text = "Produtos Consumidos";
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(266, 633);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 11;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(388, 633);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 12;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(41, 695);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(34, 13);
            this.lbl_saldo.TabIndex = 13;
            this.lbl_saldo.Text = "Saldo";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(41, 742);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(31, 13);
            this.lbl_total.TabIndex = 14;
            this.lbl_total.Text = "Total";
            // 
            // lbl_ajuste
            // 
            this.lbl_ajuste.AutoSize = true;
            this.lbl_ajuste.Location = new System.Drawing.Point(434, 695);
            this.lbl_ajuste.Name = "lbl_ajuste";
            this.lbl_ajuste.Size = new System.Drawing.Size(36, 13);
            this.lbl_ajuste.TabIndex = 15;
            this.lbl_ajuste.Text = "Ajuste";
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(135, 695);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(147, 20);
            this.txt_saldo.TabIndex = 16;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(135, 739);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(147, 20);
            this.txt_total.TabIndex = 17;
            // 
            // txt_ajuste
            // 
            this.txt_ajuste.Location = new System.Drawing.Point(511, 695);
            this.txt_ajuste.Name = "txt_ajuste";
            this.txt_ajuste.Size = new System.Drawing.Size(100, 20);
            this.txt_ajuste.TabIndex = 18;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(161, 876);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(331, 876);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 20;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(512, 876);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 21;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.button3_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 933);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_ajuste);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.lbl_ajuste);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.lbl_produtosconsumidos);
            this.Controls.Add(this.dgvw_produtosconsumidos);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.dtgw_resultado);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.gpb_dadoscliente);
            this.Controls.Add(this.gpb_detalhamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.gpb_detalhamento.ResumeLayout(false);
            this.gpb_detalhamento.PerformLayout();
            this.gpb_dadoscliente.ResumeLayout(false);
            this.gpb_dadoscliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_produtosconsumidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_detalhamento;
        private System.Windows.Forms.TextBox txt_idproduto;
        private System.Windows.Forms.TextBox txt_palavrachave;
        private System.Windows.Forms.Label lbl_idproduto;
        private System.Windows.Forms.Label lbl_palavrachave;
        private System.Windows.Forms.GroupBox gpb_dadoscliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.DataGridView dtgw_resultado;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.DataGridView dgvw_produtosconsumidos;
        private System.Windows.Forms.Label lbl_produtosconsumidos;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_ajuste;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_ajuste;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
    }
}