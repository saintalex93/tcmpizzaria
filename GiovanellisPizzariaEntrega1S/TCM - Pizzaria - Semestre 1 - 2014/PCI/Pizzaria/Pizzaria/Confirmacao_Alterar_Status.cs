using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Model;


namespace Pizzaria
{
    public partial class Confirmacao_Alterar_Status : Form
    {
        private Alterar_Status alterar_Status;

        public Confirmacao_Alterar_Status(Alterar_Status alterar_Status)
        {
            InitializeComponent();
            this.alterar_Status = alterar_Status;
        }

       /* public Confirmacao_Alterar_Status(Alterar_Status alterar_Status)
        {
            // TODO: Complete member initialization
            this.alterar_Status = alterar_Status;
        }*/

        private void btnSim_Click(object sender, EventArgs e)
        {
            clsGerenciamentoEntregaBLL teste = new clsGerenciamentoEntregaBLL();
            clsPedido teste1 = new clsPedido();

            teste1.Estado = alterar_Status.status;
            teste1.Cod_Pedido = alterar_Status.cod;
            teste.UpdatePedidos(teste1);
            this.Dispose();

        }
    }
}
