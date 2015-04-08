Partial Public Class App
    Inherits Application

    ''' <summary>
    ''' Provides easy access to the root frame of the Phone Application.
    ''' </summary>
    ''' <returns>The root frame of the Phone Application.</returns>
    Public ReadOnly Property RootFrame As PhoneApplicationFrame
        Get
            Return _rootFrame
        End Get
    End Property
    Private _rootFrame As PhoneApplicationFrame

    ''' <summary>
    ''' Provides access to a ContentManager for the application.
    ''' </summary>
    Public ReadOnly Property Content As ContentManager
        Get
            Return _content
        End Get
    End Property
    Private _content As ContentManager

    ''' <summary>
    ''' Provides access to a GameTimer that is set up to pump the FrameworkDispatcher.
    ''' </summary>
    Public ReadOnly Property FrameworkDispatcherTimer As GameTimer
        Get
            Return _frameworkDispatcherTimer
        End Get
    End Property
    Private _frameworkDispatcherTimer As GameTimer

    ''' <summary>
    ''' Provides access to the AppServiceProvider for the application.
    ''' </summary>
    Public ReadOnly Property Services As AppServiceProvider
        Get
            Return _appServiceProvider
        End Get
    End Property
    Private _appServiceProvider As AppServiceProvider

    ''' <summary>
    ''' Constructor for the Application object.
    ''' </summary>
    Public Sub New()
        ' Standard Silverlight initialization
        InitializeComponent()

        ' Phone-specific initialization
        InitializePhoneApplication()

        ' XNA initialization
        InitializeXnaApplication()

        ' Show graphics profiling information while debugging.
        If System.Diagnostics.Debugger.IsAttached Then
            ' Display the current frame rate counters.
            Application.Current.Host.Settings.EnableFrameRateCounter = True

            ' Show the areas of the app that are being redrawn in each frame.
            'Application.Current.Host.Settings.EnableRedrawRegions = True

            ' Enable non-production analysis visualization mode, 
            ' which shows areas of a page that are handed off to GPU accelerated with a colored overlay.
            'Application.Current.Host.Settings.EnableCacheVisualization = True

            ' Disable the application idle detection by setting the UserIdleDetectionMode property of the
            ' application's PhoneApplicationService object to Disabled.
            ' Caution:- Use this under debug mode only. Applications that disable user idle detection will continue to run
            ' and consume battery power when the user is not using the phone.
            Application.Current.Host.Settings.EnableFrameRateCounter = True
        End If
    End Sub

    ' Code to execute when the application is launching (eg, from Start)
    ' This code will not execute when the application is reactivated
    Private Sub Application_Launching(sender As Object, e As LaunchingEventArgs)
    End Sub

    ' Code to execute when the application is activated (brought to foreground)
    ' This code will not execute when the application is first launched
    Private Sub Application_Activated(sender As Object, e As ActivatedEventArgs)
    End Sub

    ' Code to execute when the application is deactivated (sent to background)
    ' This code will not execute when the application is closing
    Private Sub Application_Deactivated(sender As Object, e As DeactivatedEventArgs)
    End Sub

    ' Code to execute when the application is closing (eg, user hit Back)
    ' This code will not execute when the application is deactivated
    Private Sub Application_Closing(sender As Object, e As ClosingEventArgs)
    End Sub

    ' Code to execute if a navigation fails
    Private Sub RootFrame_NavigationFailed(sender As Object, e As NavigationFailedEventArgs)
        If System.Diagnostics.Debugger.IsAttached Then
            ' A navigation has failed; break into the debugger
            System.Diagnostics.Debugger.Break()
        End If
    End Sub

    ' Code to execute on Unhandled Exceptions
    Private Sub Application_UnhandledException(sender As Object, e As ApplicationUnhandledExceptionEventArgs) Handles Me.UnhandledException
        If System.Diagnostics.Debugger.IsAttached Then
            ' An unhandled exception has occurred; break into the debugger
            System.Diagnostics.Debugger.Break()
        End If
    End Sub

#Region "Phone application initialization"

    ' Avoid double-initialization
    Private phoneApplicationInitialized As Boolean = False

    ' Do not add any additional code to this method
    Private Sub InitializePhoneApplication()
        If phoneApplicationInitialized Then
            Return
        End If

        ' Create the frame but don't set it as RootVisual yet; this allows the splash
        ' screen to remain active until the application is ready to render.
        _rootFrame = New PhoneApplicationFrame()
        AddHandler RootFrame.Navigated, AddressOf CompleteInitializePhoneApplication

        ' Handle navigation failures
        AddHandler RootFrame.NavigationFailed, AddressOf RootFrame_NavigationFailed

        ' Ensure we don't initialize again
        phoneApplicationInitialized = True
    End Sub

    ' Do not add any additional code to this method
    Private Sub CompleteInitializePhoneApplication(sender As Object, e As NavigationEventArgs)
        ' Set the root visual to allow the application to render
        If RootVisual IsNot RootFrame Then
            RootVisual = RootFrame
        End If

        ' Remove this handler since it is no longer needed
        RemoveHandler RootFrame.Navigated, AddressOf CompleteInitializePhoneApplication
    End Sub

#End Region

#Region "XNA application initialization"

    ' Performs initialization of the XNA types required for the application.
    Private Sub InitializeXnaApplication()
        ' Create the service provider
        _appServiceProvider = New AppServiceProvider()

        ' Add the SharedGeraphicsDeviceManager to the Services as the IGraphicsDeviceService for the app
        For Each obj As Object In ApplicationLifetimeObjects
            If obj Is GetType(IGraphicsDeviceService) Then
                Services.AddService(GetType(IGraphicsDeviceService), obj)
            End If
        Next

        ' Create the ContentManager so the application can load precompiled assets
        _content = New ContentManager(Services, "Content")

        ' Create a GameTimer to pump the XNA FrameworkDispatcher
        _frameworkDispatcherTimer = New GameTimer()
        AddHandler FrameworkDispatcherTimer.FrameAction, AddressOf FrameworkDispatcherFrameAction
        FrameworkDispatcherTimer.Start()
    End Sub

    ' An event handler that pumps the FrameworkDispatcher each frame.
    ' FrameworkDispatcher is required for a lot of the XNA events and
    ' for certain functionality such as SoundEffect playback.
    Private Sub FrameworkDispatcherFrameAction(sender As Object, e As EventArgs)
        FrameworkDispatcher.Update()
    End Sub

#End Region
End Class
