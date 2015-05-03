using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Giovanellis
{
    public partial class DesfechoPedido : PhoneApplicationPage
    {
        public DesfechoPedido()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            txtEndereco.Text = Home.enderecoCompleto;
        }

        private void btnEntregue_Click(object sender, RoutedEventArgs e)
        {
            WebClient wcRealizado = new WebClient();

            wcRealizado.DownloadStringAsync(new Uri("http://localhost/Giovanellis/update_RealizarPedido.aspx?Cod_Pedido=" + Home.codPedidoDesfecho + "&NoCache=" + Environment.TickCount));

            this.NavigationService.GoBack();
        }

        private void btnCancelado_Click(object sender, RoutedEventArgs e)
        {
            WebClient wcCancelado = new WebClient();

            wcCancelado.DownloadStringAsync(new Uri("http://localhost/Giovanellis/update_CancelarPedido.aspx?Cod_Pedido=" + Home.codPedidoDesfecho + "&NoCache=" + Environment.TickCount));

            this.NavigationService.GoBack();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}