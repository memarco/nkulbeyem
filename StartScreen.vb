Public NotInheritable Class StartScreen

    'TODO: ce formulaire peut facilement être configuré comme écran de démarrage de l'application en accédant à l'onglet "Application"
    '  du Concepteur de projets ("Propriétés" sous le menu "Projet").

    Dim tmrDelay As New Timer()

    Public Sub New()
        InitializeComponent()
        tmrDelay.Interval = 10000
        AddHandler tmrDelay.Tick, AddressOf tmrDelay_Tick
    End Sub


    Private Sub tmrDelay_Tick(sender As System.Object, e As System.EventArgs)
        tmrDelay.Stop()
        tmEnd.Start()
    End Sub

    Private Sub tmStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmStart.Tick
        Me.Opacity += 0.05
        If Me.Opacity = 1 Then
            tmStart.Enabled = False
            tmrDelay.Start()  'Start Your 10 second delay here.
        End If
    End Sub

    Private Sub tmEnd_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmEnd.Tick
        Me.Opacity -= 0.05
        If Me.Opacity = 0 Then
            tmEnd.Enabled = False
            choiceStart.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub StartScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mpIntro.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\intro.wma"
        mpIntro.Ctlcontrols.play()
        Me.Opacity = 0
        tmStart.Enabled = True
    End Sub

End Class
