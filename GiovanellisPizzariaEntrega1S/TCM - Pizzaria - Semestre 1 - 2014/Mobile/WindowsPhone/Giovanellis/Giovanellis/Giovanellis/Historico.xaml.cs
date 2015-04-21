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
        public Historico()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (lstHistorico.Items.Count == 0)
                lstHistorico.Items.Add("Não há pedidos no histórico");
        }

        private void lstHistorico_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
//            if(lstHistorico.Selected
        }
    }
}