Public Class dictMaison
    Private PlayAgain As Boolean
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

    Private Sub StartScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load       
        Me.Opacity = 0
        tmStart.Enabled = True
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click 

        ' Test whether Windows Media Player is in the playing state. 
        If (mpProf.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
            mpProf.Ctlcontrols.pause()
        Else
            mpProf.Ctlcontrols.play()
        End If
    End Sub
    Private Sub PlaySong()
        If mpProf.URL <> "" Then
            mpProf.Ctlcontrols.play()
            DurationTimer.Enabled = True
        Else
            DurationTimer.Enabled = False
        End If
    End Sub
    Private Sub PauseSong()
        mpProf.Ctlcontrols.pause()
    End Sub

    Private Sub StopSong()
        mpProf.Ctlcontrols.stop()
        mpProf.Text = "00:00"
        DurationTimer.Enabled = False
        PlayBar.Value = 0
    End Sub
    Private Sub PlayBar_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles PlayBar.Scroll 
        Try
            If (mpProf.currentMedia.duration <> 0) Then
                Dim NewPerc As Double = Convert.ToDouble(PlayBar.Value) / 100
                Dim DurationVar As Integer = Convert.ToInt32(mpProf.currentMedia.duration * 1000) ' milliseconds
                Dim NewPos As Integer = (DurationVar * NewPerc) / 1000


                mpProf.Ctlcontrols.currentPosition = NewPos
            Else
                PlayBar.Value = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DurationTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DurationTimer.Tick 
        ' Update the trackbar.
        Dim CurPos As Integer = Convert.ToInt32(mpProf.Ctlcontrols.currentPosition * 1000) ' milliseconds
        Dim DurationVar As Integer = Convert.ToInt32(mpProf.currentMedia.duration * 1000) ' milliseconds
        If DurationVar > 0 Then
            PlayBar.Value = Convert.ToInt32((CurPos * 100) / DurationVar) ' % complete
        End If


        If mpProf.playState = WMPLib.WMPPlayState.wmppsStopped Then
            DurationTimer.Enabled = False
            PlayBar.Value = 0
        End If
        If PlayAgain = False Then
        Else
            If mpProf.playState = WMPLib.WMPPlayState.wmppsStopped Then
                PlaySong()
            Else
            End If
        End If
    End Sub

    Private Sub VolumeBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolumeBar.Scroll 
        mpProf.settings.volume = VolumeBar.Value
    End Sub

    Private Sub frmPresentation_Load(sender As Object, e As EventArgs) Handles Me.Load
        DurationTimer.Enabled = True
        mpProf.settings.autoStart = True
        mpProf.settings.volume = VolumeBar.Value
        mpProf.settings.enableErrorDialogs = False
        mpProf.enableContextMenu = False
    End Sub
     

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
    

    Private Sub PictureBox3_Click_2(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\ARMOIRE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA BROSSE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA CHAISE.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA CHAMBRE.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox23_Click_1(sender As Object, e As EventArgs) Handles PictureBox23.Click
        
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA COUR.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE COUTEAU.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA CUILLERE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox25_Click_1(sender As Object, e As EventArgs) Handles PictureBox25.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA CUISINE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA DOUCHE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox9_Click_1(sender As Object, e As EventArgs)  
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE COUSCOUS.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox10_Click_1(sender As Object, e As EventArgs) 
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE maison.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox11_Click_1(sender As Object, e As EventArgs) Handles PictureBox11.Click 
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE DRAPS.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox12_Click_1(sender As Object, e As EventArgs) Handles PictureBox12.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA MAISON.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox13_Click_2(sender As Object, e As EventArgs) 
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\ORANGE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox14_Click_1(sender As Object, e As EventArgs) 
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\PAPAYE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox15_Click_1(sender As Object, e As EventArgs) 
        
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE PIMENT.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox16_Click_1(sender As Object, e As EventArgs) 
        
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE PLANTAIN.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox17_Click_1(sender As Object, e As EventArgs) Handles PictureBox17.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\EAU.wav"
        mpProf.Ctlcontrols.play()


    End Sub

    Private Sub PictureBox18_Click_1(sender As Object, e As EventArgs) Handles PictureBox18.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE FEUX.wav"
        mpProf.Ctlcontrols.play()


    End Sub

    Private Sub PictureBox19_Click_1(sender As Object, e As EventArgs) Handles PictureBox19.Click
        
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA FLEUR.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
         
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA LAMPE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox20_Click_1(sender As Object, e As EventArgs) Handles PictureBox20.Click
        
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE LIT.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox21_Click_1(sender As Object, e As EventArgs) Handles PictureBox21.Click
        
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA LUMIER.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox22_Click_1(sender As Object, e As EventArgs) Handles PictureBox22.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE SAVON.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE MIROIR.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox26_Click_1(sender As Object, e As EventArgs) 
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA MANGUE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox27_Click_1(sender As Object, e As EventArgs) 
        
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE RIZ.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA MARMITE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE MORTIER.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) 
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\TOMATE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) 
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE VENDEUR.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) 
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA VIANDE.wav"
        mpProf.Ctlcontrols.play()


    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\OREILLER.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA PHOTO.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE PILON.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
         
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE PLAT.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA PORTE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA FENETRE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\SALON.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox32_Click_1(sender As Object, e As EventArgs) Handles PictureBox32.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE SOL.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox31_Click_1(sender As Object, e As EventArgs) Handles PictureBox31.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA TABLE.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox30_Click_1(sender As Object, e As EventArgs) Handles PictureBox30.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE TOIT.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA VERANDA.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LE VERRE.wav"
        mpProf.Ctlcontrols.play()


    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\W.C.wav"
        mpProf.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\maison\LA LOUCHE.wav"
        mpProf.Ctlcontrols.play()
    End Sub
End Class