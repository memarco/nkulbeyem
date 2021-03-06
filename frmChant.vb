﻿Public Class frmChant


    Private PlayAgain As Boolean
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DurationTimer.Enabled = True
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
 

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) 
        PresentationCommunaute.Show()
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\13DIALOGUE\communaute.mp3"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub
     

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmHymne.Show()
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\hymne.wma"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub
 

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) 
        PresentationArt.Show()
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\13DIALOGUE\art.mp3"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) 
        PresentationLitterature.Show()
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\13DIALOGUE\litterature.mp3"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) 
        PresentationSocial.Show()
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\13DIALOGUE\social.mp3"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.Close()
    End Sub
End Class