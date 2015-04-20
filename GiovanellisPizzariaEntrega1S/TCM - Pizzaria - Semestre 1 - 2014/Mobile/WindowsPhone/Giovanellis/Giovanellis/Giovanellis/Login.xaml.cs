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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        // Simple button Click event handler to take us to the second page
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void txtLogin_LayoutUpdated(object sender, EventArgs e)
        {
            
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Home.xaml", UriKind.Relative));
        }

        private void txtLogin_Tap(object sender, GestureEventArgs e)
        {
            if (txtLogin.Text == "Login")
                txtLogin.Text = "";
        }

        private void txtSenha_Tap(object sender, GestureEventArgs e)
        {
            if (txtSenha.Text == "Senha")
                txtSenha.Text = "";
        }

        private void txtSenha_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtSenha.Text == "")
                txtSenha.Text = "Senha"; 
        }

        private void txtLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text == "")
                txtLogin.Text = "Login";
        }
    }
}