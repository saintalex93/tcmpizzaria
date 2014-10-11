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
    public partial class Home : Form
    {
        public Home()
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


            while (Home.ActiveForm.MdiChildren.Length > 0)
            {
                Home.ActiveForm.ActiveMdiChild.Close();




            }
       
            Funcionario Func = new Funcionario();
            Func.MdiParent = this; //Abrir Novo Formulário Pai
            Func.Show(); // Referenciando Objetos para  Navegaçã

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            while (Home.ActiveForm.MdiChildren.Length > 0)
            {
                Home.ActiveForm.ActiveMdiChild.Close();




            }


            CadastroCliente frm2 = new CadastroCliente();
            frm2.MdiParent = this;
            frm2.Show();
          



        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cobrancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (Home.ActiveForm.MdiChildren.Length > 0)
            {
                Home.ActiveForm.ActiveMdiChild.Close();




            }
            Pedidos Pedid = new Pedidos();
            Pedid.MdiParent = this;
            Pedid.Show();
          

           
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {


          
          
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {


            while (Home.ActiveForm.MdiChildren.Length > 0)
            {
                Home.ActiveForm.ActiveMdiChild.Close();




            }
            Produtos Prod = new Produtos();
            Prod.MdiParent = this;
            Prod.Show();
          
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (Home.ActiveForm.MdiChildren.Length > 0)
            {
                Home.ActiveForm.ActiveMdiChild.Close();




            }
            Compras Comp = new Compras();
            Comp.MdiParent = this;
            Comp.Show();
          
        }

        private void cadastrarPromoçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            while (Home.ActiveForm.MdiChildren.Length > 0)
            {
                Home.ActiveForm.ActiveMdiChild.Close();




            }
            Pedidos Ped = new Pedidos();
            Ped.MdiParent = this;
            Ped.Show();
          
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc"); 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

            //Maximiza a tela
            Screen tela = Screen.FromPoint(this.Location);
            this.Size = tela.WorkingArea.Size;
            this.Location = Point.Empty;
        }

        private void pnl_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void promoçõesAtivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (Home.ActiveForm.MdiChildren.Length > 0)
                Home.ActiveForm.ActiveMdiChild.Close();

            Promocao Promo = new Promocao();
            Promo.MdiParent = this;
            Promo.Show();
        }
    }
}
