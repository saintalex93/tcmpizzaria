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

        public Form FormHome { get; set; }

        public void abrirPedidos() 
        {
            Pedidos pedidos = new Pedidos();
            pedidos.FormHome = this;
            this.Visible = false;
            pedidos.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.FormHome = this;
            this.Visible = false;
            funcionario.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.FormHome = this;
            this.Visible = false;
            cadastroCliente.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cobrancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos Pedid = new Pedidos();
            Pedid.Show();
            this.Hide();
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.FormHome = this;
            this.Visible = false;
            produtos.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras Comp = new Compras();
            Comp.Show();
            this.Hide();
        }

        private void cadastrarPromoçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            abrirPedidos();
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
         if (Acesso.PermissAcesso.ToString() == "1")
            {
                
            }
            if (Acesso.PermissAcesso.ToString() == "1")
            {
  //              aplicativosToolStripMenuItem.Enabled = false;
            }
            if (Acesso.PermissAcesso.ToString() == "3")
            {
//                novoCadastroToolStripMenuItem.Visible = false;
//                aplicativosToolStripMenuItem.Enabled = false;
//                promoçõesAtivasToolStripMenuItem.Enabled = false;
//                fechamaentoToolStripMenuItem.Enabled = false;
  //              administrativoToolStripMenuItem.Enabled = false;
            }
       
        }
 
        private void pnl_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void promoçõesAtivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarPromocao Promo = new GerenciarPromocao();
            Promo.Show();
            this.Hide();
        }

        public void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.FormHome = this;
            this.Visible = false;
            fornecedores.Show();
        }

        public static void fecharJanelasFilhas() 
        {
        }

        private void tbp_alterarLogin_Click(object sender, EventArgs e)
        {

        }

        private void insumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insumo insumo = new Insumo();
            insumo.FormHome = this;
            this.Visible = false;
            insumo.Show();
        }

        private void aplicativosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirPedidos();
        }

        private void promoçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarPromocao cadastrarPromocao = new CadastrarPromocao();
            cadastrarPromocao.FormHome = this;
            this.Visible = false;
            cadastrarPromocao.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirPedidos();
        }

        private void promoçõesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastrarPromocao cadastrarPromocao = new CadastrarPromocao();
            cadastrarPromocao.FormHome = this;
            this.Visible = false;
            cadastrarPromocao.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.FormHome = this;
            this.Visible = false;
            caixa.Show();
        }



    }
}
