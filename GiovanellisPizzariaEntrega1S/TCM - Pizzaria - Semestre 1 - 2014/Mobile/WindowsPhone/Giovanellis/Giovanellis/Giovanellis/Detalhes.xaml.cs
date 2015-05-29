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
using Microsoft.Phone.Tasks;

namespace Giovanellis
{
    public partial class Detalhes : PhoneApplicationPage
    {
        String NomeClienteString = "";
        String celular = "";
        String telefone = "";
        String hora = "";
        String FormaDepagamentoString = "";

        double valorPedido = 0;
        double valorPago = 0;

        public Detalhes()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            txtEndereco.Text = Home.enderecoCompleto;

            //Detalhes do pedido
            WebClient wc = new WebClient();
            wc.DownloadStringAsync(new Uri(
                  "http://localhost/Giovanellis/consulta_Detalhes_selectFormaPagamento.aspx?CodPedido=" + Home.codPedido
                ));
            wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(wc_DownloadStringCompleted);

            //Preenche lista de produtos
            WebClient web = new WebClient();
            web.DownloadStringAsync(new Uri(
              "http://localhost/Giovanellis/consulta_Detalhes_listaProdutos.aspx?CodPedido=" + Home.codPedido
                ));
            web.DownloadStringCompleted += new DownloadStringCompletedEventHandler(web_DownloadStringCompleted);

            txtQtdeProdutos.Text = Home.qtdeProdutos + " produto";

            if (Home.qtdeProdutos > 1)
                txtQtdeProdutos.Text += "s";

            txtQtdeProdutos.Text += ":";
        }

        //Preenche lista de produtos
        void web_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            lstProdutos.Items.Clear();

            if (e.Error == null) //&& !e.Cancelled)
            {
                string texto = "";
                string aux = "";
                string mensagem = "";

                int i;
                
                texto = e.Result;
                
                int tamanho = texto.Length;
                
                bool achou = false;

                String[] campos = new String[2];

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
    						else
						{
                            try
                            {
                                campos = aux.Split(',');

                                if (campos[1][0] == '(')
                                    mensagem = campos[0];

                                else 
                                {
                                    campos[0] = campos[0].Replace("Pizza ", "");
                                    campos[1] = campos[1].Replace("Pizza ", "");

                                    campos[1] = campos[1].Replace(" Brotinho", "");

                                    mensagem = "Pizza meia " + campos[0] + " e meia " + campos[1];
                                }

                                lstProdutos.Items.Add(mensagem);

                            }
                            catch (Exception f)
                            {
                                //Log.d("Mensagem de produtos", "Erro:" ,e);
                            }

                            aux = "";
                            campos = null;
                        }
                }
            }
        }

        //Pega detalhes do pedido
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
                        if (texto[i] != ';' && texto[i] != '.')
                            aux += texto[i];

                        else if (texto[i] == '.')
                        {
                            switch (coluna)
                            {
                                case 0:
                                    txtForma.Text = aux;
                                    break;

                                case 1:
                                    valorPedido = Double.Parse(aux.Replace(',', '.'));
                                    break;

                                case 2:
                                    valorPago = Double.Parse(aux.Replace(',', '.'));
                                    break;

                                case 3:
                                    hora = aux.Substring(0, 5);
                                    break;

                                case 4:
                                    txtNome.Text = aux;
                                    break;

                                case 5:
                                    celular = aux.Replace("-", "");
                                    break;

                                case 6:
                                    telefone = aux.Replace("-", "");
                                    break;
                            }

                            aux = "";

                            coluna++;
                        }
                        else if (texto[i] == ';')
                        {
                            telefone = aux.Replace("-", "");

                            coluna = 0;

                            txtHoraValor.Text = hora + " - R$ " + valorPedido;

                            if (txtForma.Text == "Dinheiro")
                                txtForma.Text += " - R$ " + valorPago + " (Troco: R$ " + (valorPago - valorPedido) + ")";

                            if (telefone.Length == 0)
                                btnResidencia.Visibility = Visibility.Collapsed;

                            if (celular.Length == 0)
                                btnCelular.Visibility = Visibility.Collapsed;
                        }
                }
            }
        }

        private void btnCelular_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();
            phoneCallTask.DisplayName = txtNome.Text;
            phoneCallTask.PhoneNumber = celular;
            phoneCallTask.Show();
        }

        private void btnResidencia_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();
            phoneCallTask.DisplayName = txtNome.Text;
            phoneCallTask.PhoneNumber = telefone;
            phoneCallTask.Show();
        }
    }
}