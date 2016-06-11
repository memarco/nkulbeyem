Public Class frmAlphabet


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

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\07CONJUGAISON\ETRE AU PRESENT.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\07CONJUGAISON\AVOIR AU PRESENT.wav"
        mpProf.Ctlcontrols.play() 
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\07CONJUGAISON\MANGER AU PRESENT.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\07CONJUGAISON\ETRE AU PASSE UN.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\07CONJUGAISON\MANGER AU PASSE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\07CONJUGAISON\ETRE AU  FUTUR.wav"
        mpProf.Ctlcontrols.play() 
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\07CONJUGAISON\AVOIR AU FUTUR.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\07CONJUGAISON\MANGER AU FUTUR UN.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click 
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\04LESVOYELLES\LES VOYELLES.wav"
        mpProf.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\05LESCONSONNES\LES CONSONNES.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Me.Close()
    End Sub
End Class