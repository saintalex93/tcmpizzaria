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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idproduto = new System.Windows.Forms.TextBox();
            this.txt_palavrachave = new System.Windows.Forms.TextBox();
            this.lbl_idproduto = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.txt_ajuste = new System.Windows.Forms.TextBox();
            this.lbl_palavrachave = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.dtgw_resultado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.lbl_ajuste = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.dgvw_produtosconsumidos = new System.Windows.Forms.DataGridView();
            this.gpb_dadoscliente = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pedidoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgvColCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_detalhamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_produtosconsumidos)).BeginInit();
            this.gpb_dadoscliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_detalhamento
            // 
            this.gpb_detalhamento.Controls.Add(this.label1);
            this.gpb_detalhamento.Controls.Add(this.txt_idproduto);
            this.gpb_detalhamento.Controls.Add(this.txt_palavrachave);
            this.gpb_detalhamento.Controls.Add(this.lbl_idproduto);
            this.gpb_detalhamento.Controls.Add(this.txt_quantidade);
            this.gpb_detalhamento.Controls.Add(this.lbl_qtd);
            this.gpb_detalhamento.Controls.Add(this.txt_ajuste);
            this.gpb_detalhamento.Controls.Add(this.lbl_palavrachave);
            this.gpb_detalhamento.Controls.Add(this.txt_total);
            this.gpb_detalhamento.Controls.Add(this.dtgw_resultado);
            this.gpb_detalhamento.Controls.Add(this.txt_saldo);
            this.gpb_detalhamento.Controls.Add(this.lbl_ajuste);
            this.gpb_detalhamento.Controls.Add(this.lbl_resultado);
            this.gpb_detalhamento.Controls.Add(this.lbl_total);
            this.gpb_detalhamento.Controls.Add(this.btn_inserir);
            this.gpb_detalhamento.Controls.Add(this.lbl_saldo);
            this.gpb_detalhamento.Controls.Add(this.btn_remover);
            this.gpb_detalhamento.Controls.Add(this.btn_alterar);
            this.gpb_detalhamento.Controls.Add(this.dgvw_produtosconsumidos);
            this.gpb_detalhamento.Location = new System.Drawing.Point(12, 277);
            this.gpb_detalhamento.Name = "gpb_detalhamento";
            this.gpb_detalhamento.Size = new System.Drawing.Size(373, 495);
            this.gpb_detalhamento.TabIndex = 0;
            this.gpb_detalhamento.TabStop = false;
            this.gpb_detalhamento.Text = "Detalhamento do Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Produtos Consumidos";
            // 
            // txt_idproduto
            // 
            this.txt_idproduto.Location = new System.Drawing.Point(262, 26);
            this.txt_idproduto.Name = "txt_idproduto";
            this.txt_idproduto.Size = new System.Drawing.Size(100, 20);
            this.txt_idproduto.TabIndex = 3;
            // 
            // txt_palavrachave
            // 
            this.txt_palavrachave.Location = new System.Drawing.Point(92, 26);
            this.txt_palavrachave.Name = "txt_palavrachave";
            this.txt_palavrachave.Size = new System.Drawing.Size(100, 20);
            this.txt_palavrachave.TabIndex = 1;
            // 
            // lbl_idproduto
            // 
            this.lbl_idproduto.AutoSize = true;
            this.lbl_idproduto.Location = new System.Drawing.Point(198, 29);
            this.lbl_idproduto.Name = "lbl_idproduto";
            this.lbl_idproduto.Size = new System.Drawing.Size(58, 13);
            this.lbl_idproduto.TabIndex = 2;
            this.lbl_idproduto.Text = "ID Produto";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(92, 167);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(97, 20);
            this.txt_quantidade.TabIndex = 7;
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.Location = new System.Drawing.Point(21, 170);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(62, 13);
            this.lbl_qtd.TabIndex = 5;
            this.lbl_qtd.Text = "Quantidade";
            // 
            // txt_ajuste
            // 
            this.txt_ajuste.Location = new System.Drawing.Point(61, 424);
            this.txt_ajuste.Name = "txt_ajuste";
            this.txt_ajuste.Size = new System.Drawing.Size(89, 20);
            this.txt_ajuste.TabIndex = 18;
            // 
            // lbl_palavrachave
            // 
            this.lbl_palavrachave.AutoSize = true;
            this.lbl_palavrachave.Location = new System.Drawing.Point(9, 29);
            this.lbl_palavrachave.Name = "lbl_palavrachave";
            this.lbl_palavrachave.Size = new System.Drawing.Size(77, 13);
            this.lbl_palavrachave.TabIndex = 0;
            this.lbl_palavrachave.Text = "Palavra Chave";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(61, 450);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(89, 20);
            this.txt_total.TabIndex = 17;
            // 
            // dtgw_resultado
            // 
            this.dtgw_resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Preço});
            this.dtgw_resultado.Location = new System.Drawing.Point(71, 65);
            this.dtgw_resultado.Name = "dtgw_resultado";
            this.dtgw_resultado.Size = new System.Drawing.Size(228, 90);
            this.dtgw_resultado.TabIndex = 3;
            this.dtgw_resultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 20;
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
            this.Preço.Width = 60;
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(61, 398);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(89, 20);
            this.txt_saldo.TabIndex = 16;
            // 
            // lbl_ajuste
            // 
            this.lbl_ajuste.AutoSize = true;
            this.lbl_ajuste.Location = new System.Drawing.Point(19, 424);
            this.lbl_ajuste.Name = "lbl_ajuste";
            this.lbl_ajuste.Size = new System.Drawing.Size(36, 13);
            this.lbl_ajuste.TabIndex = 15;
            this.lbl_ajuste.Text = "Ajuste";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(9, 49);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(102, 13);
            this.lbl_resultado.TabIndex = 2;
            this.lbl_resultado.Text = "Resultado da busca";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(24, 453);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(31, 13);
            this.lbl_total.TabIndex = 14;
            this.lbl_total.Text = "Total";
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(243, 164);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 6;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(21, 401);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(34, 13);
            this.lbl_saldo.TabIndex = 13;
            this.lbl_saldo.Text = "Saldo";
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(192, 363);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 11;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(114, 363);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 12;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // dgvw_produtosconsumidos
            // 
            this.dgvw_produtosconsumidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_produtosconsumidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pedidoID,
            this.nomePedido,
            this.precoID,
            this.quantidadeProduto});
            this.dgvw_produtosconsumidos.Location = new System.Drawing.Point(61, 219);
            this.dgvw_produtosconsumidos.Name = "dgvw_produtosconsumidos";
            this.dgvw_produtosconsumidos.Size = new System.Drawing.Size(257, 138);
            this.dgvw_produtosconsumidos.TabIndex = 8;
            // 
            // gpb_dadoscliente
            // 
            this.gpb_dadoscliente.Controls.Add(this.maskedTextBox1);
            this.gpb_dadoscliente.Controls.Add(this.txt_nome);
            this.gpb_dadoscliente.Controls.Add(this.lbl_cpf);
            this.gpb_dadoscliente.Controls.Add(this.lbl_nome);
            this.gpb_dadoscliente.Location = new System.Drawing.Point(12, 12);
            this.gpb_dadoscliente.Name = "gpb_dadoscliente";
            this.gpb_dadoscliente.Size = new System.Drawing.Size(363, 259);
            this.gpb_dadoscliente.TabIndex = 1;
            this.gpb_dadoscliente.TabStop = false;
            this.gpb_dadoscliente.Text = "Dados do Cliente";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(49, 45);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(49, 19);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(308, 20);
            this.txt_nome.TabIndex = 2;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(16, 48);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 1;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(8, 22);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(153, 778);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(243, 778);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 20;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(62, 778);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 21;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.dgvColNomeCliente,
            this.DtgvColCPF});
            this.dataGridView1.Location = new System.Drawing.Point(22, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 182);
            this.dataGridView1.TabIndex = 22;
            // 
            // pedidoID
            // 
            this.pedidoID.HeaderText = "ID";
            this.pedidoID.Name = "pedidoID";
            this.pedidoID.Width = 25;
            // 
            // nomePedido
            // 
            this.nomePedido.HeaderText = "Produto";
            this.nomePedido.Name = "nomePedido";
            // 
            // precoID
            // 
            this.precoID.HeaderText = "Preço";
            this.precoID.Name = "precoID";
            this.precoID.Width = 50;
            // 
            // quantidadeProduto
            // 
            this.quantidadeProduto.HeaderText = "Quantidade";
            this.quantidadeProduto.Name = "quantidadeProduto";
            this.quantidadeProduto.Width = 30;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "ID";
            this.idCliente.Name = "idCliente";
            // 
            // dgvColNomeCliente
            // 
            this.dgvColNomeCliente.HeaderText = "Nome";
            this.dgvColNomeCliente.Name = "dgvColNomeCliente";
            // 
            // DtgvColCPF
            // 
            this.DtgvColCPF.HeaderText = "CPF";
            this.DtgvColCPF.Name = "DtgvColCPF";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 863);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.gpb_dadoscliente);
            this.Controls.Add(this.gpb_detalhamento);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btnLimpar);
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.Shown += new System.EventHandler(this.Pedidos_Shown);
            this.gpb_detalhamento.ResumeLayout(false);
            this.gpb_detalhamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_produtosconsumidos)).EndInit();
            this.gpb_dadoscliente.ResumeLayout(false);
            this.gpb_dadoscliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dgvw_produtosconsumidos;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_ajuste;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_ajuste;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgvColCPF;
    }
}