Public Class frmJeux
    Private Sub pbDictionary_Click(sender As Object, e As EventArgs) Handles pbDictionary.Click
        jeuxImage.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        jeuxMot.Show()
    End Sub

    Private Sub frmJeux_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class