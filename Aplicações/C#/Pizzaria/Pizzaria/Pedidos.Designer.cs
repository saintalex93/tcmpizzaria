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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAjuste = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_ajuste = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.txtPalavraChave = new System.Windows.Forms.TextBox();
            this.lbl_idproduto = new System.Windows.Forms.Label();
            this.lbl_palavrachave = new System.Windows.Forms.Label();
            this.gridProdutosEncontrados = new System.Windows.Forms.DataGridView();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.gridProdutosConsumidos = new System.Windows.Forms.DataGridView();
            this.gpb_dadoscliente = new System.Windows.Forms.GroupBox();
            this.btnRemoverPedido = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridPedidosClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gridClientesEncontrados = new System.Windows.Forms.DataGridView();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btnGravarAjuste = new System.Windows.Forms.Button();
            this.gpb_detalhamento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosEncontrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosConsumidos)).BeginInit();
            this.gpb_dadoscliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidosClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesEncontrados)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_detalhamento
            // 
            this.gpb_detalhamento.Controls.Add(this.groupBox1);
            this.gpb_detalhamento.Controls.Add(this.label1);
            this.gpb_detalhamento.Controls.Add(this.txtIDProduto);
            this.gpb_detalhamento.Controls.Add(this.txtPalavraChave);
            this.gpb_detalhamento.Controls.Add(this.lbl_idproduto);
            this.gpb_detalhamento.Controls.Add(this.lbl_palavrachave);
            this.gpb_detalhamento.Controls.Add(this.gridProdutosEncontrados);
            this.gpb_detalhamento.Controls.Add(this.lbl_resultado);
            this.gpb_detalhamento.Controls.Add(this.btn_inserir);
            this.gpb_detalhamento.Controls.Add(this.btn_remover);
            this.gpb_detalhamento.Controls.Add(this.gridProdutosConsumidos);
            this.gpb_detalhamento.Location = new System.Drawing.Point(381, 12);
            this.gpb_detalhamento.Name = "gpb_detalhamento";
            this.gpb_detalhamento.Size = new System.Drawing.Size(373, 499);
            this.gpb_detalhamento.TabIndex = 0;
            this.gpb_detalhamento.TabStop = false;
            this.gpb_detalhamento.Text = "Detalhamento do Pedido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGravarAjuste);
            this.groupBox1.Controls.Add(this.txtAjuste);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.lbl_saldo);
            this.groupBox1.Controls.Add(this.lbl_ajuste);
            this.groupBox1.Controls.Add(this.lbl_total);
            this.groupBox1.Location = new System.Drawing.Point(12, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 77);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // txtAjuste
            // 
            this.txtAjuste.Location = new System.Drawing.Point(182, 19);
            this.txtAjuste.Name = "txtAjuste";
            this.txtAjuste.Size = new System.Drawing.Size(40, 20);
            this.txtAjuste.TabIndex = 21;
            this.txtAjuste.TextChanged += new System.EventHandler(this.txtAjuste_TextChanged);
            this.txtAjuste.Leave += new System.EventHandler(this.txtAjuste_Leave_1);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(304, 19);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(40, 20);
            this.txtTotal.TabIndex = 20;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(71, 19);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(40, 20);
            this.txtSaldo.TabIndex = 19;
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(8, 22);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(57, 13);
            this.lbl_saldo.TabIndex = 13;
            this.lbl_saldo.Text = "Saldo - R$";
            // 
            // lbl_ajuste
            // 
            this.lbl_ajuste.AutoSize = true;
            this.lbl_ajuste.Location = new System.Drawing.Point(117, 22);
            this.lbl_ajuste.Name = "lbl_ajuste";
            this.lbl_ajuste.Size = new System.Drawing.Size(59, 13);
            this.lbl_ajuste.TabIndex = 15;
            this.lbl_ajuste.Text = "Ajuste - R$";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(244, 22);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(54, 13);
            this.lbl_total.TabIndex = 14;
            this.lbl_total.Text = "Total - R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Produtos consumidos";
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Enabled = false;
            this.txtIDProduto.Location = new System.Drawing.Point(262, 26);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(100, 20);
            this.txtIDProduto.TabIndex = 3;
            this.txtIDProduto.TextChanged += new System.EventHandler(this.txtIDProduto_TextChanged);
            this.txtIDProduto.Enter += new System.EventHandler(this.txtIDProduto_Enter);
            this.txtIDProduto.Leave += new System.EventHandler(this.txtIDProduto_Leave);
            // 
            // txtPalavraChave
            // 
            this.txtPalavraChave.Enabled = false;
            this.txtPalavraChave.Location = new System.Drawing.Point(92, 26);
            this.txtPalavraChave.Name = "txtPalavraChave";
            this.txtPalavraChave.Size = new System.Drawing.Size(100, 20);
            this.txtPalavraChave.TabIndex = 1;
            this.txtPalavraChave.TextChanged += new System.EventHandler(this.txt_palavrachave_TextChanged);
            this.txtPalavraChave.Enter += new System.EventHandler(this.txtPalavraChave_Enter);
            this.txtPalavraChave.Leave += new System.EventHandler(this.txtPalavraChave_Leave);
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
            // lbl_palavrachave
            // 
            this.lbl_palavrachave.AutoSize = true;
            this.lbl_palavrachave.Location = new System.Drawing.Point(9, 29);
            this.lbl_palavrachave.Name = "lbl_palavrachave";
            this.lbl_palavrachave.Size = new System.Drawing.Size(77, 13);
            this.lbl_palavrachave.TabIndex = 0;
            this.lbl_palavrachave.Text = "Palavra Chave";
            // 
            // gridProdutosEncontrados
            // 
            this.gridProdutosEncontrados.Location = new System.Drawing.Point(12, 66);
            this.gridProdutosEncontrados.Name = "gridProdutosEncontrados";
            this.gridProdutosEncontrados.ReadOnly = true;
            this.gridProdutosEncontrados.Size = new System.Drawing.Size(355, 106);
            this.gridProdutosEncontrados.TabIndex = 3;
            this.gridProdutosEncontrados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutosEncontrados_CellClick);
            this.gridProdutosEncontrados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(9, 49);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(111, 13);
            this.lbl_resultado.TabIndex = 2;
            this.lbl_resultado.Text = "Produtos encontrados";
            // 
            // btn_inserir
            // 
            this.btn_inserir.Enabled = false;
            this.btn_inserir.Location = new System.Drawing.Point(292, 178);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 6;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Enabled = false;
            this.btn_remover.Location = new System.Drawing.Point(292, 380);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 11;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // gridProdutosConsumidos
            // 
            this.gridProdutosConsumidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutosConsumidos.Location = new System.Drawing.Point(12, 207);
            this.gridProdutosConsumidos.Name = "gridProdutosConsumidos";
            this.gridProdutosConsumidos.ReadOnly = true;
            this.gridProdutosConsumidos.Size = new System.Drawing.Size(355, 167);
            this.gridProdutosConsumidos.TabIndex = 8;
            // 
            // gpb_dadoscliente
            // 
            this.gpb_dadoscliente.Controls.Add(this.btnRemoverPedido);
            this.gpb_dadoscliente.Controls.Add(this.btnNovoPedido);
            this.gpb_dadoscliente.Controls.Add(this.label3);
            this.gpb_dadoscliente.Controls.Add(this.gridPedidosClientes);
            this.gpb_dadoscliente.Controls.Add(this.label2);
            this.gpb_dadoscliente.Controls.Add(this.gridClientesEncontrados);
            this.gpb_dadoscliente.Controls.Add(this.txtCPF);
            this.gpb_dadoscliente.Controls.Add(this.txtNome);
            this.gpb_dadoscliente.Controls.Add(this.lbl_cpf);
            this.gpb_dadoscliente.Controls.Add(this.lbl_nome);
            this.gpb_dadoscliente.Location = new System.Drawing.Point(12, 12);
            this.gpb_dadoscliente.Name = "gpb_dadoscliente";
            this.gpb_dadoscliente.Size = new System.Drawing.Size(363, 457);
            this.gpb_dadoscliente.TabIndex = 1;
            this.gpb_dadoscliente.TabStop = false;
            this.gpb_dadoscliente.Text = "Dados do Cliente";
            // 
            // btnRemoverPedido
            // 
            this.btnRemoverPedido.Enabled = false;
            this.btnRemoverPedido.Location = new System.Drawing.Point(168, 425);
            this.btnRemoverPedido.Name = "btnRemoverPedido";
            this.btnRemoverPedido.Size = new System.Drawing.Size(96, 23);
            this.btnRemoverPedido.TabIndex = 27;
            this.btnRemoverPedido.Text = "Remover";
            this.btnRemoverPedido.UseVisualStyleBackColor = true;
            this.btnRemoverPedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Enabled = false;
            this.btnNovoPedido.Location = new System.Drawing.Point(274, 425);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(83, 23);
            this.btnNovoPedido.TabIndex = 26;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.txtNovoPedido_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Clientes encontrados";
            // 
            // gridPedidosClientes
            // 
            this.gridPedidosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPedidosClientes.Location = new System.Drawing.Point(11, 269);
            this.gridPedidosClientes.Name = "gridPedidosClientes";
            this.gridPedidosClientes.ReadOnly = true;
            this.gridPedidosClientes.Size = new System.Drawing.Size(346, 150);
            this.gridPedidosClientes.TabIndex = 24;
            this.gridPedidosClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPedidosClientes_CellClick);
            this.gridPedidosClientes.DoubleClick += new System.EventHandler(this.gridPedidosClientes_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pedidos do cliente";
            // 
            // gridClientesEncontrados
            // 
            this.gridClientesEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientesEncontrados.Location = new System.Drawing.Point(10, 64);
            this.gridClientesEncontrados.Name = "gridClientesEncontrados";
            this.gridClientesEncontrados.ReadOnly = true;
            this.gridClientesEncontrados.Size = new System.Drawing.Size(347, 182);
            this.gridClientesEncontrados.TabIndex = 22;
            this.gridClientesEncontrados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientesEncontrados_CellClick);
            this.gridClientesEncontrados.DoubleClick += new System.EventHandler(this.gridClientesEncontrados_DoubleClick);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(270, 19);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(87, 20);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_MaskInputRejected);
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            this.txtCPF.Enter += new System.EventHandler(this.txtCPF_Enter);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(49, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(182, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(237, 22);
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
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(12, 488);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 21;
            this.btn_sair.Text = "Voltar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGravarAjuste
            // 
            this.btnGravarAjuste.Enabled = false;
            this.btnGravarAjuste.Location = new System.Drawing.Point(109, 45);
            this.btnGravarAjuste.Name = "btnGravarAjuste";
            this.btnGravarAjuste.Size = new System.Drawing.Size(113, 23);
            this.btnGravarAjuste.TabIndex = 22;
            this.btnGravarAjuste.Text = "Processar ajuste";
            this.btnGravarAjuste.UseVisualStyleBackColor = true;
            this.btnGravarAjuste.Click += new System.EventHandler(this.btnGravarAjuste_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 523);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.gpb_dadoscliente);
            this.Controls.Add(this.gpb_detalhamento);
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.Shown += new System.EventHandler(this.Pedidos_Shown);
            this.gpb_detalhamento.ResumeLayout(false);
            this.gpb_detalhamento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosEncontrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosConsumidos)).EndInit();
            this.gpb_dadoscliente.ResumeLayout(false);
            this.gpb_dadoscliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidosClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesEncontrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_detalhamento;
        private System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.TextBox txtPalavraChave;
        private System.Windows.Forms.Label lbl_idproduto;
        private System.Windows.Forms.Label lbl_palavrachave;
        private System.Windows.Forms.GroupBox gpb_dadoscliente;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.DataGridView gridProdutosEncontrados;
        private System.Windows.Forms.DataGridView gridProdutosConsumidos;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_ajuste;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DataGridView gridClientesEncontrados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridPedidosClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btnRemoverPedido;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.TextBox txtAjuste;
        private System.Windows.Forms.Button btnGravarAjuste;
    }
}