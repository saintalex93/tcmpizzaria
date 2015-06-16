Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Simple button Click event handler to take us to the second page
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        NavigationService.Navigate(New Uri("/GamePage.xaml", UriKind.Relative))
    End Sub
End Class
