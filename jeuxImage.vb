Public Class jeuxImage
    
    Dim M As Int32
    Dim S As Int32
    Dim T As Int32
     

    Private Sub jeuxImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        T = 60
    End Sub
     
     Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
       T -= 1
        If T > 0 Then
            M = Int(T / 60)
            S = T - (M * 60)
            Dim D As New Date(1900, 1, 1, 0, M, S)
            L2.Text = Format(D, "mm:ss")
        Else If T=0 Then 
                L2.Text = "00:00" 
                'Stop 
            'Code à traiter quand le temps est écouler  
            Dim result As Integer = MessageBox.Show("Votre temps est écoulé !", "Résultat", MessageBoxButtons.RetryCancel, MessageBoxIcon.None)
                If result = DialogResult.Cancel Then
                    Me.Close
                ElseIf result = DialogResult.Retry Then
                    T=60
                End If
        End If
    End Sub 

     
     
     
     
    Public Function AreSameImage(ByVal I1 As Image, ByVal I2 As Image) As Boolean
          Dim BM1 As Bitmap = I1
          Dim BM2 As Bitmap = I2
          For X = 0 To BM1.Width - 1
            For y = 0 To BM2.Height - 1
              If BM1.GetPixel(X, y) <> BM2.GetPixel(X, y) Then
                Return False
             'MessageBox.Show("Different images")
              End If
            Next
          Next
          Return True
                 ' MessageBox.Show("Same image")
    End Function
   
    Dim lion As Image = My.Resources.reponse 'imported from a file called lion
    Dim lievre As Image = My.Resources.lievre 'imported from a file called Swamp.jpg
    Dim lezard As Image = My.Resources.lezard 'imported from a file called Swamp.jpg
    Dim chien As Image = My.Resources.dog_jeux 'imported from a file called Swamp.jpg
    Dim chevre As Image = My.Resources.chevre 'imported from a file called Swamp.jpg
    Dim moustique As Image = My.Resources.mouscito 'imported from a file called Swamp.jpg
    Dim chevaux As Image = My.Resources.chevaux 'imported from a file called Swamp.jpg
    Dim elephant As Image = My.Resources.elphanto 'imported from a file called Swamp.jpg
    Dim anim_lion As Image = My.Resources.anim31 'imported from a file called Swamp.jpg
    Dim anim_lez As Image = My.Resources.anim_lez 'imported from a file called Swamp.jpg
    Dim anim_dog As Image = My.Resources.anim_dog 'imported from a file called Swamp.jpg
    Dim anim_chevre As Image = My.Resources.anim_chevre 'imported from a file called Swamp.jpg
    Dim anim_eleph As Image = My.Resources.anim_elephant 'imported from a file called Swamp.jpg  
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim rs1 As Boolean = AreSameImage(pbDictionary.Image, lion)
        Dim rs2 As Boolean = AreSameImage(pbDictionary.Image, moustique)
        Dim rs3 As Boolean = AreSameImage(pbDictionary.Image, lezard)
        Dim rs4 As Boolean = AreSameImage(pbDictionary.Image, chien)
        Dim rs5 As Boolean = AreSameImage(pbDictionary.Image, chevre)
        Dim rs8 As Boolean = AreSameImage(pbDictionary.Image, elephant) 
         
        If rs1 = True Then
            If rb3.Checked=True
            GlobalVariable.NoteIm=GlobalVariable.NoteIm+1
            End If
            pbDictionary.Image=chevre 
            PictureBox1.Image=anim_chevre
        End If 
        If rs3 = True Then
            If rb3.Checked=True
            GlobalVariable.NoteIm=GlobalVariable.NoteIm+1
            End If
            pbDictionary.Image=chien
            PictureBox1.Image=anim_dog
        End If 
        If rs4 = True Then
            If rbrep1.Checked=True
            GlobalVariable.NoteIm=GlobalVariable.NoteIm+1
            End If
            pbDictionary.Image=moustique
            PictureBox1.Image=anim_lion
        End If 
        If rs5 = True Then
            If rb2.Checked=True
            GlobalVariable.NoteIm=GlobalVariable.NoteIm+1
            End If
            pbDictionary.Image=elephant
            PictureBox1.Image=anim_eleph
        End If  
        If rs8 = True Then
            If rb2.Checked=True
            GlobalVariable.NoteIm=GlobalVariable.NoteIm+1
            End If
            pbDictionary.Image=lezard
            PictureBox1.Image=anim_lez
        End If  
        If rs2  =True Then 
            If rb4.Checked=True
            GlobalVariable.NoteIm=GlobalVariable.NoteIm+1
            End If
            btnNext.Hide()
            lblNote.Text=GlobalVariable.NoteIm
            btnRestart.Visible=True
            pnNote.Visible=True
            'pnChrono.Visible=False
            Timer1.Stop
        End If
        T=61
        rb1.Checked=True
        'GlobalVariable.NoteIm=GlobalVariable.NoteIm
    End Sub

    Private Sub btnRestart_Hover(sender As Object, e As EventArgs) Handles btnRestart.MouseHover
        btnRestart.BackColor=Color.AliceBlue
    End Sub
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click 
            pbDictionary.Image=lion
            PictureBox1.Image=anim_lion
            T=61
            Timer1.Start
            btnRestart.Hide()
        pnNote.Visible=False
        GlobalVariable.NoteIm=0
        btnNext.Show()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class