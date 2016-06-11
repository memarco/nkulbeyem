Public Class frmExpression


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
      
    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
    mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\A DEMAIN.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\ALLONS- Y.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\AU REVOIR.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\BON APPETIT.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox9_Click_1(sender As Object, e As EventArgs) Handles PictureBox9.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\BONJOUR.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox10_Click_1(sender As Object, e As EventArgs) Handles PictureBox10.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\BONNE NUIT.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox11_Click_1(sender As Object, e As EventArgs) Handles PictureBox11.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\COMMENT T APPEL TU.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox12_Click_1(sender As Object, e As EventArgs) Handles PictureBox12.Click
        
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\COMMENT VA TON PERE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox13_Click_1(sender As Object, e As EventArgs) Handles PictureBox13.Click
        
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\COMMENT VA TU.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\EST TU MALADE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\IL EST MORT.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\IL SE SONT MARIERS HIER.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\IL AIME LA MUSIQUE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\IL APPREND LA LANGUE DOUALA.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\J ARRIVE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE ME LAVE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE NE PARLE PAS BIEN LA LANGUE DOUALA.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE NE SAIS PAS.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE PARLE BIEN LA LANGUE DOUALA.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE REVIENT DU VILLAGE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE SAIS.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE SUIS CHEZ MOI.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE SUIS FRANCAIS.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE T'AIME.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE T EXPLIQUERAI PLUS TARD.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True


    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE POSE UNE QUESTION.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE VAIS A LA MAISON.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True


    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        
        mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE VAIS  AU TRAVAIL.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JE VAIS EN FRANCE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JOYEUX ANINVERSAIRE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
            
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) 
        
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JOYEUX ANINVERSAIRE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) 
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\JOYEUX ANINVERSAIRE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\OU VA TU.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\QUELLE HEUR EST IL.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click 
        
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\QUE TU EST BELLE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox40_Click_1(sender As Object, e As EventArgs) Handles PictureBox40.Click 
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\QUELLE EST TON PROBLEME.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True
    End Sub

    Private Sub PictureBox38_Click_1(sender As Object, e As EventArgs) Handles PictureBox38.Click
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\QUI EST TA MERE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\QUI EST TON PERE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\TU DANCE BIEN.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\TU ECRIS BIEN.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\TU EST DOU.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True

    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\TU EST TETU.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True    

    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\VA A L' ECOLE.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True    

    End Sub

    Private Sub PictureBox48_Click(sender As Object, e As EventArgs) Handles PictureBox48.Click
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\VA TE COUCHER.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True    

    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        
          mpProf.URL = My.Computer.FileSystem.CurrentDirectory + "\audio\08PHRASESUSUELLES\VIENS ICI.wav"
        mpProf.Ctlcontrols.play()
        DurationTimer.Enabled = True    

    End Sub

    Private Sub PictureBox50_Click(sender As Object, e As EventArgs) Handles PictureBox50.Click
        Me.Close()
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click

    End Sub
End Class