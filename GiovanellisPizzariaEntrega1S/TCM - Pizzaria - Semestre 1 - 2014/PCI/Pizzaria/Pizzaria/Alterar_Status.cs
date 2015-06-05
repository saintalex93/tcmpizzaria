using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using 

namespace Pizzaria
{
    public partial class Alterar_Status : Form
    {
        Gerenciamento_Entregas teste; // = new Gerenciamento_Entregas();
        public string cod;
        public string status;
        public Alterar_Status(Gerenciamento_Entregas frm1)
        {
            InitializeComponent();

            teste =  frm1;
            txtCod_Pedido.Text = teste.cod;
        }

        private void Alterar_Status_Load(object sender, EventArgs e)
        {
            cmbStatus_Pedido.SelectedIndex = 0;
            txtCod_Pedido.Text = teste.cod;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Confirmacao_Alterar_Status confirma = new Confirmacao_Alterar_Status(this);
            //altera_status.MdiParent = this;
            status = cmbStatus_Pedido.SelectedItem.ToString();
            cod = txtCod_Pedido.Text;
            confirma.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
