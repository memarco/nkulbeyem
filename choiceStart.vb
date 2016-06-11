Public NotInheritable Class choiceStart
    Private Sub choiceStart_Load(sender As Object, e As EventArgs) Handles Me.Load
        pbChoiceLang.Visible=False
        LinkLabel1.Visible=False
    End Sub

    'TODO: ce formulaire peut facilement être configuré comme écran de démarrage de l'application en accédant à l'onglet "Application"
    '  du Concepteur de projets ("Propriétés" sous le menu "Projet").



    Private Sub pbChoice_MouseClick(sender As Object, e As MouseEventArgs) Handles pbChoice.MouseClick
        frmMain.Show()
        Me.Hide()
        StartScreen.mpIntro.Ctlcontrols.stop()
    End Sub


    Private Sub pbChoice_MouseLeave(sender As Object, e As EventArgs) Handles pbChoice.MouseLeave
        pbChoice.Image = Global.NkulBeyem_Duala.My.Resources.Resources.drapeau1
        pbChoiceLang.Visible = False
    End Sub

    Private Sub pbChoice_MouseMove(sender As Object, e As MouseEventArgs) Handles pbChoice.MouseMove
        pbChoice.Image = Global.NkulBeyem_Duala.My.Resources.Resources.drapeau2
        pbChoiceLang.Visible = True 
        LinkLabel1.Visible=True
        pbChoice.Cursor = Cursors.Hand
    End Sub
     
    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Me.Close()
    End Sub

    Private Sub pbChoiceLang_Click(sender As Object, e As MouseEventArgs) Handles pbChoiceLang.MouseClick, pbChoiceLang.Click
        frmMain.Show()
        Me.Hide()
        StartScreen.mpIntro.Ctlcontrols.stop()
    End Sub
 

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmMain.Show()
        Me.Hide()
        StartScreen.mpIntro.Ctlcontrols.stop()
    End Sub
End Class
