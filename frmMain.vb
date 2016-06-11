 Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        choiceStart.Hide()
    End Sub
     
    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.MouseHover
        btnConfig.Cursor = Cursors.Hand
        btnConfig.Image = Global.NkulBeyem_Duala.My.Resources.Resources.setting_h
    End Sub

    Private Sub btnConfig_MouseLeave(sender As Object, e As EventArgs) Handles btnConfig.MouseLeave
        btnConfig.Image = Global.NkulBeyem_Duala.My.Resources.Resources.setting
    End Sub

    Private Sub btnConfig_Click_1(sender As Object, e As EventArgs) Handles btnConfig.Click
        chgBackground.Show()
    End Sub

    Private Sub pbDictionary_Click(sender As Object, e As EventArgs) Handles pbDictionary.Click
        frmDictionary.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmPresentation.Show()
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        StartScreen.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmAlphabet.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frmTon.Show() 
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmDialog.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        frmExpression.Show()
    End Sub

    Private Sub pbProverb_Click(sender As Object, e As EventArgs) Handles pbProverb.Click
        frmProverb.Show()
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover  
        lblPresent.BackColor=Color.SkyBlue 
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        lblPresent.BackColor=System.Drawing.SystemColors.Control
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        lblGrammaire.BackColor=Color.SkyBlue 
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
          lblGrammaire.BackColor=System.Drawing.SystemColors.Control
    End Sub

    Private Sub PictureBox6_MouseHover(sender As Object, e As EventArgs) Handles PictureBox6.MouseHover
        lblTon.BackColor=Color.SkyBlue 
    End Sub
    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        lblTon.BackColor=System.Drawing.SystemColors.Control
    End Sub

    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        lblDialog.BackColor=Color.SkyBlue 
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        lblDialog.BackColor=System.Drawing.SystemColors.Control
    End Sub

    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        lblPhrase.BackColor=Color.SkyBlue 
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        lblPhrase.BackColor=System.Drawing.SystemColors.Control
    End Sub

    Private Sub pbProverb_MouseHover(sender As Object, e As EventArgs) Handles pbProverb.MouseHover
        lblProverb.BackColor=Color.SkyBlue
    End Sub

    Private Sub pbProverb_MouseLeave(sender As Object, e As EventArgs) Handles pbProverb.MouseLeave
        lblProverb.BackColor=System.Drawing.SystemColors.Control
    End Sub

    Private Sub pbDictionary_MouseHover(sender As Object, e As EventArgs) Handles pbDictionary.MouseHover
        lblDictionary.BackColor=Color.SkyBlue
    End Sub

    Private Sub pbDictionary_MouseLeave(sender As Object, e As EventArgs) Handles pbDictionary.MouseLeave
        lblDictionary.BackColor=System.Drawing.SystemColors.Control
    End Sub
     

    Private Sub PictureBox7_MouseHover(sender As Object, e As EventArgs) Handles PictureBox7.MouseHover
        lblJeux.BackColor=Color.SkyBlue
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        lblJeux.BackColor=System.Drawing.SystemColors.Control
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        frmCulture.Show()
    End Sub
    
    Private Sub PictureBox10_MouseHover(sender As Object, e As EventArgs) Handles PictureBox10.MouseHover
        lblCulture.BackColor=Color.SkyBlue
    End Sub

    Private Sub PictureBox10_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox10.MouseLeave
        lblCulture.BackColor=System.Drawing.SystemColors.Control
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        frmJeux.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        frmChant.Show()
    End Sub
     Private Sub PictureBox11_MouseHover(sender As Object, e As EventArgs) Handles PictureBox11.MouseHover
        lblChant.BackColor=Color.SkyBlue
    End Sub

    Private Sub PictureBox11_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox11.MouseLeave
        lblChant.BackColor=System.Drawing.SystemColors.Control
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        choiceStart.Show()
    End Sub

    Private Sub PictureBox12_H(sender As Object, e As EventArgs) Handles PictureBox12.MouseHover
        PictureBox12.BorderStyle=BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox12_C(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Help.Show()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

    End Sub
End Class
