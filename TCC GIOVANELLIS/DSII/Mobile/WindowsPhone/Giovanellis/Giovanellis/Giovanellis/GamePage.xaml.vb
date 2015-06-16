Partial Public Class GamePage
    Inherits PhoneApplicationPage
    Private contentManager As ContentManager
    Private timer As GameTimer
    Private spriteBatch As SpriteBatch

    Public Sub New()
        InitializeComponent()

        ' Get the content manager from the application
        contentManager = DirectCast(Application.Current, App).Content

        ' Create a timer for this page
        timer = New GameTimer()
        timer.UpdateInterval = TimeSpan.FromTicks(333333)
        AddHandler timer.Update, AddressOf OnUpdate
        AddHandler timer.Draw, AddressOf OnDraw
    End Sub

    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
        ' Set the sharing mode of the graphics device to turn on XNA rendering
        SharedGraphicsDeviceManager.Current.GraphicsDevice.SetSharingMode(True)

        ' Create a new SpriteBatch, which can be used to draw textures.
        spriteBatch = New SpriteBatch(SharedGraphicsDeviceManager.Current.GraphicsDevice)

        ' TODO: use Me.content to load your game content here

        ' Start the timer
        timer.Start()

        MyBase.OnNavigatedTo(e)
    End Sub

    Protected Overrides Sub OnNavigatedFrom(e As NavigationEventArgs)
        ' Stop the timer
        timer.Stop()

        ' Set the sharing mode of the graphics device to turn off XNA rendering
        SharedGraphicsDeviceManager.Current.GraphicsDevice.SetSharingMode(False)

        MyBase.OnNavigatedFrom(e)
    End Sub

    ''' <summary>
    ''' Allows the page to run logic such as updating the world,
    ''' checking for collisions, gathering input, and playing audio.
    ''' </summary>
    Private Sub OnUpdate(sender As Object, e As GameTimerEventArgs)
        ' TODO: Add your update logic here
    End Sub

    ''' <summary>
    ''' Allows the page to draw itself.
    ''' </summary>
    Private Sub OnDraw(sender As Object, e As GameTimerEventArgs)
        SharedGraphicsDeviceManager.Current.GraphicsDevice.Clear(Color.CornflowerBlue)

        ' TODO: Add your drawing code here
    End Sub
End Class
