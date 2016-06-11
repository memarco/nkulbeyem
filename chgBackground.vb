Public NotInheritable Class chgBackground

    Private Sub chgBackground_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Définissez le titre du formulaire.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        rdBtn1.Select()
        frmMain.BackgroundImage = My.Resources.Abstract_blue_background
    End Sub

    Private Sub btnValBack_Click(sender As Object, e As EventArgs) Handles btnValBack.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        rbBtn2.Select()
        frmMain.BackgroundImage = My.Resources.monliberté
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        rbBtn3.Select()
        frmMain.BackgroundImage = My.Resources.fond
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        rbBtn4.Select()
        frmMain.BackgroundImage = My.Resources._140705221903
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        rbBtn5.Select()
        frmMain.BackgroundImage = My.Resources.bg21
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        rbBtn6.Select()
        frmMain.BackgroundImage = My.Resources.bg1
    End Sub

    Private Sub rdBtn1_CheckedChanged(sender As Object, e As EventArgs) Handles rdBtn1.CheckedChanged 

        frmMain.BackgroundImage = My.Resources.Abstract_blue_background
    End Sub

    Private Sub rbBtn2_CheckedChanged(sender As Object, e As EventArgs) Handles rbBtn2.CheckedChanged
        
        frmMain.BackgroundImage = My.Resources.monliberté
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub
End Class
