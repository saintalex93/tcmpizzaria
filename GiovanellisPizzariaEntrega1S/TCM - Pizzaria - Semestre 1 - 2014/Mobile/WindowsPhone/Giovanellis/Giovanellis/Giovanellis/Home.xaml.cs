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
    public partial class Home : PhoneApplicationPage
    {
        public static string enderecoCompleto = "";

        public static int qtdeProdutos;
        public static int codPedido;
        public static int codPedidoDesfecho;

        public Home()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            txtUsuario.Text = MainPage.nomeFuncionario;

            WebClient wc = new WebClient();

            wc.DownloadStringAsync(new Uri("http://localhost/Giovanellis/consulta_listaPedidosAEntregar.aspx?Cod_Funcionario=" + MainPage.codFuncionario));

            wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(wc_DownloadStringCompleted);

            if (lstPedidos.Items.Count == 0)
                lstPedidos.Items.Add("Não há pedidos a serem entregues.");
        }

        private void btnHistorico_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Historico.xaml", UriKind.Relative));
        }

        private void lstPedidos_Hold(object sender, GestureEventArgs e)
        {

        }

        private void lstPedidos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            codPedido = 
            
            NavigationService.Navigate(new Uri("/Detalhes.xaml", UriKind.Relative));
        }

        void wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null) //&& !e.Cancelled)
            {
                string texto, aux = "";
                int i;
                texto = e.Result;

                int tamanho = texto.Length;
                bool achou = false;

                int numeroPedido = 0;
                int qtdProdutos = 0;
                int coluna = 0;

                string endereco = "";
                String numRes = "";
                String numAp = "";


                String enderecoAlt = "";
                String numResAlt = "";
                String numApAlt = "";

                String mensagem = "";

                for (i = 0; i < tamanho; i++)
                {
                    if (texto[i] == '#')
                    {
                        achou = true;
                        i++; //Pula o caracter "#", para ignorá-lo ao concatenar
                    }

                    if (texto[i] == '^')
                        achou = false;

                    if (achou)
                        if (texto[i] != ';' && texto[i] != ',')
                            aux = aux + texto[i];

                        else if (texto[i] == ',')
                        {
                            coluna++;
                            switch (coluna)
                            {
                                case 1:
                                    numeroPedido = Int32.Parse(aux);
                                    break;

                                case 2:
                                    endereco = aux;
                                    break;

                                case 3:
                                    numRes = aux;
                                    break;

                                case 4:
                                    numAp = aux;
                                    break;

                                case 5:
                                    qtdProdutos = Int32.Parse(aux);
                                    break;

                                case 6:
                                    enderecoAlt = aux;
                                    break;

                                case 7:
                                    numResAlt = aux;
                                    break;

                            }

                            /*TODO: 
                             * Essa linha foi colocada aqui, porque o algoritmo acima, quando achava um ponto e virgula (;)
                             * partia para o próximo campo, sem inserir o valor de aux à numApAlt, fazendo o número alternativo
                             * do apartamento não aparecer.
                             * 
                             * Ficar ligado nisso aqui...
                            */
                            numApAlt = aux;

                            aux = "";
                        }
                        else if (texto[i] == ';')
                        {
                            coluna = 0;

                            if (enderecoAlt.Length == 0)

                                if (numAp.Length == 0)
                                    mensagem = "#" + numeroPedido + " - " + endereco + ", " + numRes + " (" + qtdProdutos + ")";
                                else
                                    mensagem = "#" + numeroPedido + " - " + endereco + ", " + numRes + ", Ap: " + numAp + " (" + qtdProdutos + ")";

                            else

                                if (numApAlt.Length == 0)
                                    mensagem = "#" + numeroPedido + " - " + enderecoAlt + ", " + numResAlt + " (" + qtdProdutos + ")";
                                else
                                    mensagem = "#" + numeroPedido + " - " + enderecoAlt + ", " + numResAlt + ", Ap: " + numApAlt + " (" + qtdProdutos + ")";

                            aux = "";
                            enderecoAlt = "";
                            numResAlt = "";
                            numApAlt = "";

                            lstPedidos.Items.Add(mensagem);
                        }
                }
            }
        }

    }
}