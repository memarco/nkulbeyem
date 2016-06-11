Public Class frmDictionary
    Private Sub plAnimal_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        lblAnimaux.BackColor=Color.SkyBlue
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave 
           lblAnimaux.BackColor=System.Drawing.SystemColors.Control
    End Sub
    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover 
        Label2.BackColor=Color.SkyBlue
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave 
         Label2.BackColor=System.Drawing.SystemColors.Control
    End Sub
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover 
        Label3.BackColor=Color.SkyBlue
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave 
         Label3.BackColor=System.Drawing.SystemColors.Control
    End Sub
    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover 
        Label4.BackColor=Color.SkyBlue
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave 
         Label4.BackColor=System.Drawing.SystemColors.Control
    End Sub
    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover 
        Label5.BackColor=Color.SkyBlue
    End Sub
    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave 
         Label5.BackColor=System.Drawing.SystemColors.Control
    End Sub
    Private Sub PictureBox6_MouseHover(sender As Object, e As EventArgs) Handles PictureBox6.MouseHover 
        Label6.BackColor=Color.SkyBlue
    End Sub
    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave 
         Label6.BackColor=System.Drawing.SystemColors.Control
    End Sub
     Private Sub PictureBox7_MouseHover(sender As Object, e As EventArgs) Handles PictureBox7.MouseHover
        Label7.BackColor=Color.SkyBlue
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        Label7.BackColor=System.Drawing.SystemColors.Control
    End Sub
    
     Private Sub PictureBox9_MouseHover(sender As Object, e As EventArgs) Handles PictureBox9.MouseHover
        Label9.BackColor=Color.SkyBlue
    End Sub

    Private Sub PictureBox9_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox9.MouseLeave
        Label9.BackColor=System.Drawing.SystemColors.Control
    End Sub
    
     Private Sub PictureBox8_MouseHover(sender As Object, e As EventArgs) Handles PictureBox8.MouseHover
        Label8.BackColor=Color.SkyBlue
    End Sub

    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        Label8.BackColor=System.Drawing.SystemColors.Control
    End Sub
    
     Private Sub PictureBox10_MouseHover(sender As Object, e As EventArgs) Handles PictureBox10.MouseHover
        Label10.BackColor=Color.SkyBlue
    End Sub

    Private Sub PictureBox10_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox10.MouseLeave
        Label10.BackColor=System.Drawing.SystemColors.Control
    End Sub
     Private Sub PictureBox11_MouseHover(sender As Object, e As EventArgs) Handles PictureBox11.MouseHover
        Label11.BackColor=Color.SkyBlue
    End Sub

    Private Sub PictureBox11_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox11.MouseLeave
        Label11.BackColor=System.Drawing.SystemColors.Control
    End Sub
     Private Sub PictureBox12_MouseHover(sender As Object, e As EventArgs) Handles PictureBox12.MouseHover
        Label12.BackColor=Color.SkyBlue
    End Sub

    Private Sub PictureBox12_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox12.MouseLeave
        Label12.BackColor=System.Drawing.SystemColors.Control
    End Sub
     Private Sub PictureBox13_MouseHover(sender As Object, e As EventArgs) Handles PictureBox13.MouseHover
        Label13.BackColor=Color.SkyBlue
    End Sub

    Private Sub PictureBox13_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox13.MouseLeave
        Label13.BackColor=System.Drawing.SystemColors.Control
    End Sub
     Private Sub PictureBox14_MouseHover(sender As Object, e As EventArgs) Handles PictureBox14.MouseHover
        Label14.BackColor=Color.SkyBlue
    End Sub

    Private Sub PictureBox14_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox14.MouseLeave
        Label14.BackColor=System.Drawing.SystemColors.Control
    End Sub
     Private Sub PictureBox15_MouseHover(sender As Object, e As EventArgs) Handles PictureBox15.MouseHover
        Label15.BackColor=Color.SkyBlue
    End Sub

    Private Sub PictureBox15_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox15.MouseLeave
        Label15.BackColor=System.Drawing.SystemColors.Control
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        dictAnimaux.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        dictChifreNombre.Show()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        dictPronom.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        dictCorpsHumain.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        dictHeureTemps.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        dictMoisJour.Show()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        dictVetement.Show()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        dictSalutation.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        dictEcole.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        dictMaison.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        dictMarche.Show()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        dictReligion.Show()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        dictVerbe.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        dictFamille.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        dictVilleVillage.Show()
    End Sub
End Class