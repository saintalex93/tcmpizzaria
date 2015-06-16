namespace Pizzaria
{
    partial class Gerenciamento_Entregas
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
            this.components = new System.ComponentModel.Container();
            this.tabGerenciamento_entrega = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dateAteHora = new System.Windows.Forms.DateTimePicker();
            this.dateDeData = new System.Windows.Forms.DateTimePicker();
            this.dateDeHora = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateAteData = new System.Windows.Forms.DateTimePicker();
            this.GridProdutosP = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.GridPedidosP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAterar_StatusP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chcNovos_Pedidos = new System.Windows.Forms.CheckBox();
            this.chcPreparo = new System.Windows.Forms.CheckBox();
            this.chcCaminho = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateAteData2 = new System.Windows.Forms.DateTimePicker();
            this.DateDeData2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chcEntregue = new System.Windows.Forms.CheckBox();
            this.chcCancelado = new System.Windows.Forms.CheckBox();
            this.GridProdutosF = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.GridPedidosF = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterar_StatusF = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tabGerenciamento_entrega.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutosP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidosP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutosF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidosF)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGerenciamento_entrega
            // 
            this.tabGerenciamento_entrega.Controls.Add(this.tabPage1);
            this.tabGerenciamento_entrega.Controls.Add(this.tabPage2);
            this.tabGerenciamento_entrega.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGerenciamento_entrega.Location = new System.Drawing.Point(5, 3);
            this.tabGerenciamento_entrega.Name = "tabGerenciamento_entrega";
            this.tabGerenciamento_entrega.SelectedIndex = 0;
            this.tabGerenciamento_entrega.Size = new System.Drawing.Size(538, 654);
            this.tabGerenciamento_entrega.TabIndex = 0;
            this.tabGerenciamento_entrega.SelectedIndexChanged += new System.EventHandler(this.tabGerenciamento_entrega_SelectedIndexChanged_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dateAteHora);
            this.tabPage1.Controls.Add(this.dateDeData);
            this.tabPage1.Controls.Add(this.dateDeHora);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dateAteData);
            this.tabPage1.Controls.Add(this.GridProdutosP);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.GridPedidosP);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnAterar_StatusP);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(530, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pendentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Voltar\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateAteHora
            // 
            this.dateAteHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateAteHora.Location = new System.Drawing.Point(354, 97);
            this.dateAteHora.Name = "dateAteHora";
            this.dateAteHora.Size = new System.Drawing.Size(78, 26);
            this.dateAteHora.TabIndex = 14;
            // 
            // dateDeData
            // 
            this.dateDeData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDeData.Location = new System.Drawing.Point(264, 39);
            this.dateDeData.Name = "dateDeData";
            this.dateDeData.Size = new System.Drawing.Size(84, 26);
            this.dateDeData.TabIndex = 13;
            // 
            // dateDeHora
            // 
            this.dateDeHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateDeHora.Location = new System.Drawing.Point(354, 39);
            this.dateDeHora.Name = "dateDeHora";
            this.dateDeHora.Size = new System.Drawing.Size(78, 26);
            this.dateDeHora.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "de";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Até";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pesquisar";
            // 
            // dateAteData
            // 
            this.dateAteData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAteData.Location = new System.Drawing.Point(265, 97);
            this.dateAteData.Name = "dateAteData";
            this.dateAteData.Size = new System.Drawing.Size(83, 26);
            this.dateAteData.TabIndex = 8;
            // 
            // GridProdutosP
            // 
            this.GridProdutosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutosP.Location = new System.Drawing.Point(24, 406);
            this.GridProdutosP.MultiSelect = false;
            this.GridProdutosP.Name = "GridProdutosP";
            this.GridProdutosP.ReadOnly = true;
            this.GridProdutosP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridProdutosP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProdutosP.Size = new System.Drawing.Size(478, 150);
            this.GridProdutosP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produtos";
            // 
            // GridPedidosP
            // 
            this.GridPedidosP.AllowUserToAddRows = false;
            this.GridPedidosP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridPedidosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPedidosP.Location = new System.Drawing.Point(24, 199);
            this.GridPedidosP.MultiSelect = false;
            this.GridPedidosP.Name = "GridPedidosP";
            this.GridPedidosP.ReadOnly = true;
            this.GridPedidosP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridPedidosP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPedidosP.Size = new System.Drawing.Size(478, 150);
            this.GridPedidosP.TabIndex = 3;
            this.GridPedidosP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPedidosP_CellClick);
            this.GridPedidosP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPedidosP_CellContentClick);
            this.GridPedidosP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridPedidosP_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedidos";
            // 
            // btnAterar_StatusP
            // 
            this.btnAterar_StatusP.Location = new System.Drawing.Point(407, 145);
            this.btnAterar_StatusP.Name = "btnAterar_StatusP";
            this.btnAterar_StatusP.Size = new System.Drawing.Size(95, 34);
            this.btnAterar_StatusP.TabIndex = 1;
            this.btnAterar_StatusP.Text = "Alterar Status";
            this.btnAterar_StatusP.UseVisualStyleBackColor = true;
            this.btnAterar_StatusP.Click += new System.EventHandler(this.btnAterar_StatusP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chcNovos_Pedidos);
            this.groupBox1.Controls.Add(this.chcPreparo);
            this.groupBox1.Controls.Add(this.chcCaminho);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exibir";
            // 
            // chcNovos_Pedidos
            // 
            this.chcNovos_Pedidos.AutoSize = true;
            this.chcNovos_Pedidos.Checked = true;
            this.chcNovos_Pedidos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcNovos_Pedidos.Location = new System.Drawing.Point(36, 89);
            this.chcNovos_Pedidos.Name = "chcNovos_Pedidos";
            this.chcNovos_Pedidos.Size = new System.Drawing.Size(122, 24);
            this.chcNovos_Pedidos.TabIndex = 2;
            this.chcNovos_Pedidos.Text = "Novos Pedidos";
            this.chcNovos_Pedidos.UseVisualStyleBackColor = true;
            this.chcNovos_Pedidos.CheckedChanged += new System.EventHandler(this.chcNovos_Pedidos_CheckedChanged);
            // 
            // chcPreparo
            // 
            this.chcPreparo.AutoSize = true;
            this.chcPreparo.Location = new System.Drawing.Point(36, 60);
            this.chcPreparo.Name = "chcPreparo";
            this.chcPreparo.Size = new System.Drawing.Size(100, 24);
            this.chcPreparo.TabIndex = 1;
            this.chcPreparo.Text = "Em Preparo";
            this.chcPreparo.UseVisualStyleBackColor = true;
            this.chcPreparo.CheckedChanged += new System.EventHandler(this.chcPreparo_CheckedChanged);
            // 
            // chcCaminho
            // 
            this.chcCaminho.AutoSize = true;
            this.chcCaminho.Location = new System.Drawing.Point(36, 31);
            this.chcCaminho.Name = "chcCaminho";
            this.chcCaminho.Size = new System.Drawing.Size(93, 24);
            this.chcCaminho.TabIndex = 0;
            this.chcCaminho.Text = "A Caminho";
            this.chcCaminho.UseVisualStyleBackColor = true;
            this.chcCaminho.CheckedChanged += new System.EventHandler(this.chcCaminho_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.dateAteData2);
            this.tabPage2.Controls.Add(this.DateDeData2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.GridProdutosF);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.GridPedidosF);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnAlterar_StatusF);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(530, 621);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Finalizados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "de";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(347, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Até";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Pesquisar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(368, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(78, 26);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(368, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(78, 26);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateAteData2
            // 
            this.dateAteData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAteData2.Location = new System.Drawing.Point(268, 94);
            this.dateAteData2.Name = "dateAteData2";
            this.dateAteData2.Size = new System.Drawing.Size(83, 26);
            this.dateAteData2.TabIndex = 17;
            // 
            // DateDeData2
            // 
            this.DateDeData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDeData2.Location = new System.Drawing.Point(268, 38);
            this.DateDeData2.Name = "DateDeData2";
            this.DateDeData2.Size = new System.Drawing.Size(84, 26);
            this.DateDeData2.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chcEntregue);
            this.groupBox2.Controls.Add(this.chcCancelado);
            this.groupBox2.Location = new System.Drawing.Point(26, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 103);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exibir";
            // 
            // chcEntregue
            // 
            this.chcEntregue.AutoSize = true;
            this.chcEntregue.Checked = true;
            this.chcEntregue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcEntregue.Location = new System.Drawing.Point(36, 60);
            this.chcEntregue.Name = "chcEntregue";
            this.chcEntregue.Size = new System.Drawing.Size(82, 24);
            this.chcEntregue.TabIndex = 1;
            this.chcEntregue.Text = "Entregue";
            this.chcEntregue.UseVisualStyleBackColor = true;
            this.chcEntregue.CheckedChanged += new System.EventHandler(this.chcEntregue_CheckedChanged);
            // 
            // chcCancelado
            // 
            this.chcCancelado.AutoSize = true;
            this.chcCancelado.Location = new System.Drawing.Point(36, 31);
            this.chcCancelado.Name = "chcCancelado";
            this.chcCancelado.Size = new System.Drawing.Size(92, 24);
            this.chcCancelado.TabIndex = 0;
            this.chcCancelado.Text = "Cancelado";
            this.chcCancelado.UseVisualStyleBackColor = true;
            this.chcCancelado.CheckedChanged += new System.EventHandler(this.chcCancelado_CheckedChanged);
            // 
            // GridProdutosF
            // 
            this.GridProdutosF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutosF.Location = new System.Drawing.Point(26, 391);
            this.GridProdutosF.MultiSelect = false;
            this.GridProdutosF.Name = "GridProdutosF";
            this.GridProdutosF.ReadOnly = true;
            this.GridProdutosF.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridProdutosF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProdutosF.Size = new System.Drawing.Size(478, 150);
            this.GridProdutosF.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Produtos";
            // 
            // GridPedidosF
            // 
            this.GridPedidosF.AllowUserToAddRows = false;
            this.GridPedidosF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridPedidosF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPedidosF.Location = new System.Drawing.Point(26, 184);
            this.GridPedidosF.MultiSelect = false;
            this.GridPedidosF.Name = "GridPedidosF";
            this.GridPedidosF.ReadOnly = true;
            this.GridPedidosF.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridPedidosF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPedidosF.Size = new System.Drawing.Size(478, 150);
            this.GridPedidosF.TabIndex = 11;
            this.GridPedidosF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPedidosF_CellClick);
            this.GridPedidosF.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridPedidosF_CellFormatting);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pedidos";
            // 
            // btnAlterar_StatusF
            // 
            this.btnAlterar_StatusF.Location = new System.Drawing.Point(409, 144);
            this.btnAlterar_StatusF.Name = "btnAlterar_StatusF";
            this.btnAlterar_StatusF.Size = new System.Drawing.Size(95, 34);
            this.btnAlterar_StatusF.TabIndex = 9;
            this.btnAlterar_StatusF.Text = "Alterar Status";
            this.btnAlterar_StatusF.UseVisualStyleBackColor = true;
            this.btnAlterar_StatusF.Click += new System.EventHandler(this.btnAlterar_StatusF_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 23;
            this.button2.Text = "Voltar\r\n";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Gerenciamento_Entregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 666);
            this.ControlBox = false;
            this.Controls.Add(this.tabGerenciamento_entrega);
            this.IsMdiContainer = true;
            this.Name = "Gerenciamento_Entregas";
            this.Text = "Gerenciamento de Entregas";
            this.Load += new System.EventHandler(this.Gerenciamento_Entregas_Load);
            this.EnabledChanged += new System.EventHandler(this.Gerenciamento_Entregas_EnabledChanged);
            this.tabGerenciamento_entrega.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutosP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidosP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutosF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidosF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGerenciamento_entrega;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView GridProdutosP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridPedidosP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAterar_StatusP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chcNovos_Pedidos;
        private System.Windows.Forms.CheckBox chcPreparo;
        private System.Windows.Forms.CheckBox chcCaminho;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chcEntregue;
        private System.Windows.Forms.CheckBox chcCancelado;
        private System.Windows.Forms.DataGridView GridProdutosF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterar_StatusF;
        private System.Windows.Forms.DateTimePicker dateDeData;
        private System.Windows.Forms.DateTimePicker dateDeHora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateAteData;
        private System.Windows.Forms.DateTimePicker dateAteHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker DateDeData2;
        private System.Windows.Forms.DateTimePicker dateAteData2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView GridPedidosF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}