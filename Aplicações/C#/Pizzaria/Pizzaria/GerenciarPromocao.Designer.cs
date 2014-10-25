namespace Pizzaria
{
    partial class GerenciarPromocao
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
            this.lbl_promocaoativa = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_resumopromo = new System.Windows.Forms.Label();
            this.txt_resumopromocao = new System.Windows.Forms.TextBox();
            this.lbl_promocaoinativa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_promocaoativa
            // 
            this.lbl_promocaoativa.AutoSize = true;
            this.lbl_promocaoativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_promocaoativa.Location = new System.Drawing.Point(35, 29);
            this.lbl_promocaoativa.Name = "lbl_promocaoativa";
            this.lbl_promocaoativa.Size = new System.Drawing.Size(136, 20);
            this.lbl_promocaoativa.TabIndex = 0;
            this.lbl_promocaoativa.Text = "Promoções Ativas";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 108);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(358, 74);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(186, 108);
            this.listBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Habilitar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Desabilitar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbl_resumopromo
            // 
            this.lbl_resumopromo.AutoSize = true;
            this.lbl_resumopromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resumopromo.Location = new System.Drawing.Point(173, 222);
            this.lbl_resumopromo.Name = "lbl_resumopromo";
            this.lbl_resumopromo.Size = new System.Drawing.Size(199, 24);
            this.lbl_resumopromo.TabIndex = 6;
            this.lbl_resumopromo.Text = "Resumo da Promoção";
            // 
            // txt_resumopromocao
            // 
            this.txt_resumopromocao.Location = new System.Drawing.Point(7, 268);
            this.txt_resumopromocao.Multiline = true;
            this.txt_resumopromocao.Name = "txt_resumopromocao";
            this.txt_resumopromocao.Size = new System.Drawing.Size(527, 92);
            this.txt_resumopromocao.TabIndex = 7;
            // 
            // lbl_promocaoinativa
            // 
            this.lbl_promocaoinativa.AutoSize = true;
            this.lbl_promocaoinativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_promocaoinativa.Location = new System.Drawing.Point(373, 29);
            this.lbl_promocaoinativa.Name = "lbl_promocaoinativa";
            this.lbl_promocaoinativa.Size = new System.Drawing.Size(148, 20);
            this.lbl_promocaoinativa.TabIndex = 8;
            this.lbl_promocaoinativa.Text = "Promoções Inativas";
            // 
            // Promocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 410);
            this.Controls.Add(this.lbl_promocaoinativa);
            this.Controls.Add(this.txt_resumopromocao);
            this.Controls.Add(this.lbl_resumopromo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_promocaoativa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Promocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Promocões";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_promocaoativa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_resumopromo;
        private System.Windows.Forms.TextBox txt_resumopromocao;
        private System.Windows.Forms.Label lbl_promocaoinativa;
    }
}