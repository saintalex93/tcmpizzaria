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
            lstPedidos.Items.Clear();

            txtUsuario.Text = MainPage.nomeFuncionario;

            WebClient wc = new WebClient();

            wc.DownloadStringAsync(new Uri("http://localhost/Giovanellis/consulta_listaPedidosAEntregar.aspx?Cod_Funcionario=" + MainPage.codFuncionario));

            wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(wc_DownloadStringCompleted);
        }

        private void btnHistorico_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Historico.xaml", UriKind.Relative));
        }

        private void lstPedidos_Hold(object sender, GestureEventArgs e)
        {
            MessageBox.Show("Hold no item " + lstPedidos.SelectedIndex);
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
                string numRes = "";
                string numAp = "";


                string enderecoAlt = "";
                string numResAlt = "";
                string numApAlt = "";

                string mensagem = "";

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
                            aux += texto[i];

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

            if (lstPedidos.Items.Count == 0)
                lstPedidos.Items.Add("Não há pedidos a serem entregues.");
        }

        string getEndereco(int position)
        {
            string endereco = "";

            try 
            {
                bool comeco = false;

                int i = 0;

                while (lstPedidos.Items[position].ToString()[i] != '(')
                {
                    if (lstPedidos.Items[position].ToString()[i] == '-')
                    {
                        comeco = true;
                        i++;
                    }

                    if (comeco)
                        endereco += lstPedidos.Items[position].ToString()[i];

                    i++;
                }
            }
            catch(Exception e)
            {
            }

            return endereco;
        }

        private void lstPedidos_Tap(object sender, GestureEventArgs e)
        {
            enderecoCompleto = getEndereco(lstPedidos.SelectedIndex);

            codPedido = getCodEndereco(lstPedidos.SelectedIndex);

            qtdeProdutos = getQtdeProdutos(lstPedidos.SelectedIndex);

            NavigationService.Navigate(new Uri("/Detalhes.xaml", UriKind.Relative));
        }

        private int getCodEndereco(int position) 
        {
            int i = 1;

            String resultado = "";

            while (lstPedidos.Items[position].ToString()[i] != ' ')
            {
                resultado += lstPedidos.Items[position].ToString()[i];

                i++;
            }

            return Int32.Parse(resultado);
        }

        private int getQtdeProdutos(int position)
        {

            int i = 1;

            bool comeco = false;

            String resultado = "";

            while (lstPedidos.Items[position].ToString()[i] != ')')
            {
                if (lstPedidos.Items[position].ToString()[i] == '(')
                {
                    comeco = true;
                    i++;
                }

                if (comeco)
                    resultado += lstPedidos.Items[position].ToString()[i];

                i++;
            }

            return Int32.Parse(resultado);
        }
    }
}