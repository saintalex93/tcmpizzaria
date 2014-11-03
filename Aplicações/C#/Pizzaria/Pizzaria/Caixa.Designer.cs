namespace Pizzaria
{
    partial class Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.rdDiario = new System.Windows.Forms.RadioButton();
            this.rdSemanal = new System.Windows.Forms.RadioButton();
            this.rdMensal = new System.Windows.Forms.RadioButton();
            this.rdSemestral = new System.Windows.Forms.RadioButton();
            this.rdAnual = new System.Windows.Forms.RadioButton();
            this.rdEspecifico = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dpFim = new System.Windows.Forms.DateTimePicker();
            this.dpComeco = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gridRegistros = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(547, 310);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // rdDiario
            // 
            this.rdDiario.AutoSize = true;
            this.rdDiario.Location = new System.Drawing.Point(6, 19);
            this.rdDiario.Name = "rdDiario";
            this.rdDiario.Size = new System.Drawing.Size(52, 17);
            this.rdDiario.TabIndex = 1;
            this.rdDiario.TabStop = true;
            this.rdDiario.Text = "Diário";
            this.rdDiario.UseVisualStyleBackColor = true;
            this.rdDiario.CheckedChanged += new System.EventHandler(this.rdDiario_CheckedChanged);
            // 
            // rdSemanal
            // 
            this.rdSemanal.AutoSize = true;
            this.rdSemanal.Location = new System.Drawing.Point(7, 42);
            this.rdSemanal.Name = "rdSemanal";
            this.rdSemanal.Size = new System.Drawing.Size(66, 17);
            this.rdSemanal.TabIndex = 2;
            this.rdSemanal.TabStop = true;
            this.rdSemanal.Text = "Semanal";
            this.rdSemanal.UseVisualStyleBackColor = true;
            this.rdSemanal.CheckedChanged += new System.EventHandler(this.rdSemanal_CheckedChanged);
            // 
            // rdMensal
            // 
            this.rdMensal.AutoSize = true;
            this.rdMensal.Location = new System.Drawing.Point(7, 65);
            this.rdMensal.Name = "rdMensal";
            this.rdMensal.Size = new System.Drawing.Size(59, 17);
            this.rdMensal.TabIndex = 3;
            this.rdMensal.TabStop = true;
            this.rdMensal.Text = "Mensal";
            this.rdMensal.UseVisualStyleBackColor = true;
            this.rdMensal.CheckedChanged += new System.EventHandler(this.rdMensal_CheckedChanged);
            // 
            // rdSemestral
            // 
            this.rdSemestral.AutoSize = true;
            this.rdSemestral.Location = new System.Drawing.Point(7, 88);
            this.rdSemestral.Name = "rdSemestral";
            this.rdSemestral.Size = new System.Drawing.Size(71, 17);
            this.rdSemestral.TabIndex = 4;
            this.rdSemestral.TabStop = true;
            this.rdSemestral.Text = "Semestral";
            this.rdSemestral.UseVisualStyleBackColor = true;
            this.rdSemestral.CheckedChanged += new System.EventHandler(this.rdSemestral_CheckedChanged);
            // 
            // rdAnual
            // 
            this.rdAnual.AutoSize = true;
            this.rdAnual.Location = new System.Drawing.Point(6, 111);
            this.rdAnual.Name = "rdAnual";
            this.rdAnual.Size = new System.Drawing.Size(52, 17);
            this.rdAnual.TabIndex = 5;
            this.rdAnual.TabStop = true;
            this.rdAnual.Text = "Anual";
            this.rdAnual.UseVisualStyleBackColor = true;
            this.rdAnual.CheckedChanged += new System.EventHandler(this.rdAnual_CheckedChanged);
            // 
            // rdEspecifico
            // 
            this.rdEspecifico.AutoSize = true;
            this.rdEspecifico.Location = new System.Drawing.Point(6, 134);
            this.rdEspecifico.Name = "rdEspecifico";
            this.rdEspecifico.Size = new System.Drawing.Size(80, 17);
            this.rdEspecifico.TabIndex = 6;
            this.rdEspecifico.TabStop = true;
            this.rdEspecifico.Text = "Especificar:";
            this.rdEspecifico.UseVisualStyleBackColor = true;
            this.rdEspecifico.CheckedChanged += new System.EventHandler(this.rdEspecifico_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dpFim);
            this.groupBox1.Controls.Add(this.dpComeco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdDiario);
            this.groupBox1.Controls.Add(this.rdEspecifico);
            this.groupBox1.Controls.Add(this.rdSemanal);
            this.groupBox1.Controls.Add(this.rdAnual);
            this.groupBox1.Controls.Add(this.rdMensal);
            this.groupBox1.Controls.Add(this.rdSemestral);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 298);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(17, 259);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dpFim
            // 
            this.dpFim.Enabled = false;
            this.dpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFim.Location = new System.Drawing.Point(7, 225);
            this.dpFim.Name = "dpFim";
            this.dpFim.Size = new System.Drawing.Size(95, 20);
            this.dpFim.TabIndex = 8;
            // 
            // dpComeco
            // 
            this.dpComeco.Enabled = false;
            this.dpComeco.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpComeco.Location = new System.Drawing.Point(7, 174);
            this.dpComeco.Name = "dpComeco";
            this.dpComeco.Size = new System.Drawing.Size(95, 20);
            this.dpComeco.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(146, 313);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(47, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "0000,00";
            // 
            // gridRegistros
            // 
            this.gridRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.gridRegistros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegistros.Location = new System.Drawing.Point(146, 12);
            this.gridRegistros.Name = "gridRegistros";
            this.gridRegistros.Size = new System.Drawing.Size(476, 282);
            this.gridRegistros.TabIndex = 15;
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 342);
            this.ControlBox = false;
            this.Controls.Add(this.gridRegistros);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton rdDiario;
        private System.Windows.Forms.RadioButton rdSemanal;
        private System.Windows.Forms.RadioButton rdMensal;
        private System.Windows.Forms.RadioButton rdSemestral;
        private System.Windows.Forms.RadioButton rdAnual;
        private System.Windows.Forms.RadioButton rdEspecifico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpFim;
        private System.Windows.Forms.DateTimePicker dpComeco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView gridRegistros;
        private System.Windows.Forms.Button btnBuscar;
    }
}