﻿Public Class dictSalutation
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

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\salutation\BONJOUR.wav"
        mpProf.Ctlcontrols.play() 
    End Sub
     
     

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click 
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\salutation\BONSOIR.wav"
        mpProf.Ctlcontrols.play() 
    End Sub 

    Private Sub PictureBox10_Click_1(sender As Object, e As EventArgs) Handles PictureBox10.Click 
        DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\salutation\BONNE NUIT.wav"
        mpProf.Ctlcontrols.play() 
    End Sub
     

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
           DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\salutation\BONNE APPETIT.wav"
        mpProf.Ctlcontrols.play()  
    End Sub
     

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
           DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\salutation\COMMENT VA TU.wav"
        mpProf.Ctlcontrols.play()  
    End Sub
     

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
           DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\salutation\BONNE JOURNEE.wav"
        mpProf.Ctlcontrols.play()  
    End Sub 

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
           DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\salutation\BONNE ANNEE.wav"
        mpProf.Ctlcontrols.play()  
    End Sub 

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
           DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\salutation\BON VOYAGE.wav"
        mpProf.Ctlcontrols.play()  
    End Sub 

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
           DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\salutation\BONNE FETE.wav"
        mpProf.Ctlcontrols.play()  
    End Sub
     

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
           DurationTimer.Enabled = True
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\dictionnary\salutation\SALUT.wav"
        mpProf.Ctlcontrols.play()  
    End Sub
     
     
End Class