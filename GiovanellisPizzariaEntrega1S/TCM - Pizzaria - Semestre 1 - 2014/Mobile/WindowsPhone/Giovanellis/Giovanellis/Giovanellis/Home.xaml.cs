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
//using System.Microsoft.Controls.CustomMessageBox;

namespace Giovanellis
{
    public partial class Home : PhoneApplicationPage
    {
        public static string enderecoCompleto = "";

        public static int qtdeProdutos;
        public static int codPedido;
        public static int codPedidoDesfecho;

        List<string[]> pedidos = new List<string[]>();

        public Home()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            lstPedidos.Items.Clear();

            txtUsuario.Text = MainPage.nomeFuncionario;

            WebClient wc = new WebClient();

            wc.DownloadStringAsync(new Uri("http://localhost/Giovanellis/consulta_listaPedidosAEntregar.aspx?Cod_Funcionario=" + MainPage.codFuncionario + "&NoCache=" + Environment.TickCount));

            try
            {
                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(wc_DownloadStringCompleted);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnHistorico_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Historico.xaml", UriKind.Relative));
        }

        private void lstPedidos_Hold(object sender, GestureEventArgs e)
        {
            if (lstPedidos.Items[0].ToString()[0] != 'N')
            {
                string text = (e.OriginalSource as TextBlock).Text;

                enderecoCompleto = getEnderecoHold(text);

                codPedidoDesfecho = getCodPedidoDesfechoHold(text);

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

                string[] dadosPedidos = null;

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
                            dadosPedidos = aux.Split(',');

                            lstPedidos.Items.Add(getItem(dadosPedidos));

                            pedidos.Add(getObjeto(dadosPedidos));

                            aux = "";
                        }
                        else 
                        {
                            MessageBox.Show("Erro na busca de dados no banco.");
                        }
                }
            }

            if (lstPedidos.Items.Count == 0)
                lstPedidos.Items.Add("Não há pedidos a serem entregues.");
        }

        string [] getMensagem(String[] dadosPedido)
        {
            String[] objeto = null;

            //Pegar objeto de quantidade de produtos
            String objetoQtdeProdutos = dadosPedido[4] + " produto";

            if (Int32.Parse(dadosPedido[4]) > 1)
                objetoQtdeProdutos += "s";

            objeto[0] = "#" + dadosPedido[0] + " - " + objetoQtdeProdutos + "\n";

            //Pegando endereço do cliente
            if (dadosPedido.Length <= 5)
            {
                objeto[1] += dadosPedido[1] + ", " + dadosPedido[2];


                //Se tiver apartamento, adicionar
                if (dadosPedido[3].Length > 0)
                    objeto[1] += ", Ap: " + dadosPedido[3];
            }
            //Se pedido vier com endereço alternativo, pegar no lugar do endereço do cliente
            else if (dadosPedido.Length > 5)
            {
                objeto[1] += dadosPedido[5] + ", " + dadosPedido[6];

                if (dadosPedido.Length == 8)
                    if (dadosPedido[7].Length > 0)
                        objeto[1] += ", Ap: " + dadosPedido[7];
            }

            objeto[1] += "\n";

            return objeto;
        }

        private void lstPedidos_Tap(object sender, GestureEventArgs e)
        {
            if (lstPedidos.Items[lstPedidos.SelectedIndex].ToString()[0] != 'N') 
            {
                enderecoCompleto = pedidos[lstPedidos.SelectedIndex][1];

                codPedido = Int32.Parse(pedidos[lstPedidos.SelectedIndex][0]);

                qtdeProdutos = Int32.Parse(pedidos[lstPedidos.SelectedIndex][2]);

                NavigationService.Navigate(new Uri("/Detalhes.xaml", UriKind.Relative));
            }
            
        }

        string getEnderecoHold(string text)
        {
            int i = 1;

            bool comecou = false;

            String resultado = "";

            for (i = 1; i < text.Length - 2 ; i++)
            {
                if (comecou)
                    resultado += text[i];

                if (text[i] == '\n')
                    comecou = true;
            }

            return resultado;
        }

        String[] getObjeto(String[] registro)
        {
            string[] mensagem = new string[3];

            //Primeira linha: dados gerais
            mensagem[0] = registro[0];

            //Segunda linha: dados de endereço
            if (registro[7].Length == 0)
            {
                mensagem[1] += registro[1] + ", " + registro[2];

                if (registro[3].Length > 0)
                    mensagem[1] += ", Ap: " + registro[3];
            }
            else if (registro[5].Length > 0)
            {
                mensagem[1] += registro[5] + ", " + registro[6];

                if (registro.Length == 7)
                    if (registro[7].Length > 0)
                        mensagem[1] += ", Ap: " + registro[7];
            }
            else
            {
                MessageBox.Show("Erro");
            }

            //Terceira linha: quantidade de produtos
            mensagem[2] = registro[4];

            return mensagem;
        }
        
        ListBoxItem getItem(String[] dadosPedidos)
        {
            string mensagem = "";

            //Pegar o código do pedido
            mensagem = "#" + dadosPedidos[0];

            //Pegar mensagem de quantidade de produtos
            mensagem += " - " + dadosPedidos[4] + " produto";

            //Checa se mensagem deve vir no plural ou singuçar
            if (dadosPedidos[4] != "1")
                mensagem += "s";

            mensagem += "\n";

            //Verifica se pedido veio sem endereço alternativo
            //Se pedido vier sem endereço alternativo, pegar o endereço do cliente
            if (dadosPedidos[5].Length == 0)
            {
                mensagem += dadosPedidos[1] + ", " + dadosPedidos[2];

                //Se tiver apartamento, adicionar
                if (dadosPedidos[3].Length > 0)
                    mensagem += ", Ap: " + dadosPedidos[3];
            }
            //Se pedido vier com endereço alternativo, pegar no lugar do endereço do cliente
            else if (dadosPedidos[5].Length > 0)
            {
                mensagem += dadosPedidos[5] + ", " + dadosPedidos[6];

                //Se tiver apartamento, adicionar
                if (dadosPedidos.Length == 8)
                    if (dadosPedidos[7].Length > 0)
                        mensagem += ", Ap: " + dadosPedidos[7];
            }

            mensagem += "\n";

            var item = new ListBoxItem { Content = mensagem };

            return item;
        }

        int getCodPedidoDesfechoHold(string text) 
        {
            int i = 1;

            string resultado = "";

            while(text[i] != '-')
            {
                resultado += text[i];
                i++;
            }

            return Int32.Parse(resultado);
        }

    }
}