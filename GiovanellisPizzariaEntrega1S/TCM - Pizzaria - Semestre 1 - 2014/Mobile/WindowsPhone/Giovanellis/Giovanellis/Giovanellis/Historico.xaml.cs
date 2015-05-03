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
    public partial class Historico : PhoneApplicationPage
    {
        String[] registro = null;

        List<string[]> historico = new List<string[]>();

        public Historico()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            lstHistorico.Items.Clear();

            //lstHistorico.bru

            WebClient wc = new WebClient();

            wc.DownloadStringAsync(new Uri("http://localhost/Giovanellis/consulta_listaHistorico.aspx?Cod_Funcionario=" + MainPage.codFuncionario + "&NoCache=" + Environment.TickCount));

            wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(wc_DownloadStringCompleted);
        }

        private void lstHistorico_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstHistorico.Items.Count > 0)
                if (lstHistorico.Items[0].ToString()[0] != 'N')
                {
                    Home.codPedidoDesfecho = Int32.Parse(historico[lstHistorico.SelectedIndex][0]);

                    Home.enderecoCompleto = historico[lstHistorico.SelectedIndex][1];

                    NavigationService.Navigate(new Uri("/DesfechoPedido.xaml", UriKind.Relative));
                }
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
                        if (texto[i] != ';')
                            aux += texto[i];

                        else if (texto[i] == ';')
                        {
                            /*
                             As posições de "registro" serão:
                             * 0- Código do pedido
                             * 1- Logradouro
                             * 2- Número residencial
                             * 3- Número do apartamento
                             * 4- Quantidade de produtos no pedido
                             * 5- Logradouro alternativo fornecido no pedido
                             * 6- Número residencial alternativo fornecido no pedido
                             * 7- Número do apartamento alternativo fornecido no pedido
                             */

                            registro = aux.Split(',');

                            registro[4] = registro[4].Replace('-', '/');

                            historico.Add(getObjeto(registro));

                            lstHistorico.Items.Add(getItem(registro));

                            aux = "";
                            mensagem = "";
                        }
                }
            }

            if (lstHistorico.Items.Count == 0)
                lstHistorico.Items.Add("Não há pedidos no histórico");
        }

        ListBoxItem getItem(String[] registro)
        {
            string mensagem = "";

            //Primeira linha: dados gerais
            mensagem += "#" + registro[0] + " - " + registro[7] + " produto";

            if (Int32.Parse(registro[7]) > 1)
                mensagem += "s";

            mensagem += " - " + registro[6] + "\n";

            //Segunda linha: dados de endereço
            if (registro[8].Length == 0)
            {
                mensagem += registro[1] + ", " + registro[2];

                if (registro[3].Length > 0)
                    mensagem += ", Ap: " + registro[3];
            }
            else if (registro[8].Length > 0)
            {
                mensagem += registro[8] + ", " + registro[9];

                if (registro.Length == 10)
                    if (registro[10].Length > 0)
                        mensagem += ", Ap: " + registro[10];
            }
            else
            {
                MessageBox.Show("Erro");
            }

            mensagem += "\n";

            //Terceira linha: dia e hora do pedido
            mensagem += registro[4] + " - " + registro[5] + "\n";

            var item = new ListBoxItem { Content = mensagem };

            if (item.Content.ToString().Contains("Realizado"))
                item.Foreground = new SolidColorBrush(Colors.Green);
            else if (item.Content.ToString().Contains("Cancelad"))
                item.Foreground = new SolidColorBrush(Colors.Red);
            else
                MessageBox.Show("Erro - Criação de objetos");

            return item;
        }

        String[] getObjeto(String[] registro)
        {
            string[] mensagem = new string [2];

            //Primeira linha: dados gerais
            mensagem[0] = registro[0];

            //Segunda linha: dados de endereço
            if (registro[8].Length == 0)
            {
                mensagem[1] += registro[1] + ", " + registro[2];

                if (registro[3].Length > 0)
                    mensagem[1] += ", Ap: " + registro[3];
            }
            else if (registro[8].Length > 0)
            {
                mensagem[1] += registro[8] + ", " + registro[9];

                if (registro.Length == 10)
                    if (registro[10].Length > 0)
                        mensagem[1] += ", Ap: " + registro[10];
            }
            else
            {
                MessageBox.Show("Erro");
            }

            mensagem[1] += "\n";

            return mensagem;
        }

        private void lstHistorico_Hold(object sender, GestureEventArgs e)
        {
            
        }
    }
}