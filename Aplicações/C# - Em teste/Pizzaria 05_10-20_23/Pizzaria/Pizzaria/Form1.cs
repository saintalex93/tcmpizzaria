using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {


            while (Form1.ActiveForm.MdiChildren.Length > 0)
            {
                Form1.ActiveForm.ActiveMdiChild.Close();




            }
            frmCadastro frm1 = new frmCadastro();
            frm1.Show();
          

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            while (Form1.ActiveForm.MdiChildren.Length > 0)
            {
                Form1.ActiveForm.ActiveMdiChild.Close();




            }


            frmCadastro2 frm2 = new frmCadastro2();
            
            frm2.MdiParent = this;
            frm2.Show();
          



        }
    }
}
