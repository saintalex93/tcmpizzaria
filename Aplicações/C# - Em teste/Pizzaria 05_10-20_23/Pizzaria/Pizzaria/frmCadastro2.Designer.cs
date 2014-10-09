namespace Pizzaria
{
    partial class frmCadastro2
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
            this.lbl_Titulo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Titulo2
            // 
            this.lbl_Titulo2.AutoSize = true;
            this.lbl_Titulo2.Location = new System.Drawing.Point(101, 25);
            this.lbl_Titulo2.Name = "lbl_Titulo2";
            this.lbl_Titulo2.Size = new System.Drawing.Size(37, 13);
            this.lbl_Titulo2.TabIndex = 0;
            this.lbl_Titulo2.Text = "Tela II";
            // 
            // frmCadastro2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbl_Titulo2);
            this.Name = "frmCadastro2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastro2";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo2;
    }
}