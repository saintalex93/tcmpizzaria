namespace Pizzaria
{
    partial class Consumo
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
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridConsumo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDown3.Location = new System.Drawing.Point(139, 137);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(147, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.numericUpDown3);
            this.grpDados.Controls.Add(this.comboBox1);
            this.grpDados.Controls.Add(this.label1);
            this.grpDados.Controls.Add(this.label2);
            this.grpDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.grpDados.Location = new System.Drawing.Point(12, 12);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(450, 206);
            this.grpDados.TabIndex = 4;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Produto: ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(136, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // gridConsumo
            // 
            this.gridConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsumo.Location = new System.Drawing.Point(12, 224);
            this.gridConsumo.Name = "gridConsumo";
            this.gridConsumo.Size = new System.Drawing.Size(450, 150);
            this.gridConsumo.TabIndex = 4;
            this.gridConsumo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsumo_CellValueChanged);
            this.gridConsumo.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsumo_RowLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Consumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridConsumo);
            this.Controls.Add(this.grpDados);
            this.Name = "Consumo";
            this.Text = "Consumo";
            this.Load += new System.EventHandler(this.Consumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsumo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridConsumo;
        private System.Windows.Forms.Button button1;

    }
}