
Public Class jeuxMot
    Dim m_MouseIsDown As Boolean
    Dim sender2 As Object
    Dim b1 As Image = My.Resources.b1 'imported from a file called Swamp.jpg
    Dim b2 As Image = My.Resources.b2 'Imported from a file called Dusty.jpg
    Dim b3 As Image = My.Resources.b3 'Imported from a file called Dusty.jpg
    Dim b4 As Image = My.Resources.b4 'Imported from a file called Dusty.jpg
    Dim b5 As Image = My.Resources.b5 'Imported from a file called Dusty.jpg
    Dim pt As Integer
    Private HighlightedPictureBox As PictureBox = Nothing  
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.a1.AllowDrop = False
        Me.a2.AllowDrop = False
        Me.a3.AllowDrop = False
        Me.a4.AllowDrop = False
        Me.a5.AllowDrop = False
        Me.c5.AllowDrop = True
        Me.c4.AllowDrop = True
        Me.c3.AllowDrop =True
        Me.c2.AllowDrop = True
        Me.c1.AllowDrop = True
        Me.r3.AllowDrop = True
        Me.r4.AllowDrop = True
        Me.r5.AllowDrop = True
        Me.r1.AllowDrop = True
        Me.r2.AllowDrop = True
       T = 150
    pt=0

    End Sub

#Region "Mouse Down"
    Private Sub Mouse_Down(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles a1.MouseDown, a2.MouseDown, a3.MouseDown,a4.MouseDown, a5.MouseDown, c5.MouseDown,c4.MouseDown, c3.MouseDown, c2.MouseDown,c1.MouseDown, r3.MouseDown, r2.MouseDown,r4.MouseDown, r5.MouseDown, r1.MouseDown

        If Not sender.Image Is Nothing Then 'On verifie que la picturebox source n'est pas vide
            m_MouseIsDown = True
        End If
    End Sub
#End Region

#Region "Mouse Move"
    Private Sub Mouse_Move(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles   a1.MouseMove, a2.MouseMove, a3.MouseMove,a4.MouseMove, a5.MouseMove,c5.MouseMove,c4.MouseMove, c3.MouseMove, c2.MouseMove,c1.MouseMove, r3.MouseMove, r2.MouseMove,r4.MouseMove, r5.MouseMove, r1.MouseMove
        If m_MouseIsDown = True Then
            sender2 = sender 'On recupére le nom d'objet de la picturebox source
            sender.DoDragDrop(sender.Image, DragDropEffects.Move) 'On lance l'operation de Drag&Drop de l'image
            
        End If
        m_MouseIsDown = False
    End Sub
#End Region

#Region "DragEnter"
    Private Sub Drag_Enter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles   a1.DragEnter, a2.DragEnter, a3.DragEnter,a4.DragEnter, a5.DragEnter,c5.DragEnter,c4.DragEnter, c3.DragEnter, c2.DragEnter,c1.DragEnter, r3.DragEnter, r2.DragEnter,r4.DragEnter, r5.DragEnter, r1.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then

            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None 'Au cas ou il y a eu un probléme dans l'envoi de l'image
        End If
    End Sub
#End Region
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
#Region "DragDrop"
    Private Sub Drag_Drop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles  c5.DragDrop,c4.DragDrop, c3.DragDrop, c2.DragDrop,c1.DragDrop, r3.DragDrop, r2.DragDrop,r4.DragDrop, r5.DragDrop, r1.DragDrop
        
        If sender.Image Is Nothing Then
        sender2.Image = Nothing 'On vide la picturebox source
        sender.Image = e.Data.GetData(DataFormats.Bitmap) 'on place l'image dans la picture box source
        Else 
                
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles r1.Click

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If r1.Image Is Nothing Or r2.Image Is Nothing Or r3.Image Is Nothing Or r4.Image Is Nothing  Or r5.Image Is Nothing   Then
            lblErreur.Visible=True
            lblErreur.Text="Veuillez compléter tous les champs S.V.P !"
        Else
            
        Dim rs1 As Boolean = AreSameImage(r1.Image, b1)
        Dim rs2 As Boolean = AreSameImage(r2.Image, b2)
        Dim rs3 As Boolean = AreSameImage(r3.Image, b3)
        Dim rs4 As Boolean = AreSameImage(r4.Image, b4)
        Dim rs5 As Boolean = AreSameImage(r5.Image, b5)
        Dim pnList(5) As Panel 
        Dim rsList(5) As Boolean
        'mois (1) contient Nothing

            pnList(0)=pn1
            pnList(1)=pn2
            pnList(2)=pn3
            pnList(3)=pn4
            pnList(4)=pn5

            rsList(0)=rs1
            rsList(1)=rs2
            rsList(2)=rs3
            rsList(3)=rs4
            rsList(4)=rs5
        
            For y = 0 To 4
              If rsList(y)=False Then
                    lblErreur.ForeColor=Color.Red
                    pnList(y).BackColor=Color.Red
                    lblErreur.Visible=True
                    lblErreur.Text="Veuillez corriger vos erreurs S.V.P."
                    btnCorection.Visible=True
                    animBox.Image= My.Resources.failed
                    animBox.Visible=True
                    Else
                        pt=pt+1
                        pnList(y).BackColor=Color.Green
                        'MessageBox.Show("Different images")
              End If
            Next 
            If rs1=True And rs2=True And rs3=True And rs3=True And rs4=True And rs5=True Then
                 lblErreur.Visible=True
                lblErreur.ForeColor=Color.Green
                animBox.Image= My.Resources.successs
                animBox.Visible=True 
                MessageBox.Show("PARFAIT ! - Vous pouvez passer au jeux suivant !", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.None)
                btnNext.Visible=True
            End If
        End If
        lblResult.Text=pt
        GlobalVariable.Note=pt
        pt=0
    End Sub

    Private Sub btnCorection_Click(sender As Object, e As EventArgs) Handles btnCorection.Click
        r1.Image=b1
        r2.Image=b2
        r3.Image=b3
        r4.Image=b4
        r5.Image=b5 
        btnNext.Visible=True
    End Sub

#End Region
    
    Dim M As Int32
    Dim S As Int32
    Dim T As Int32

 
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
       T -= 1
        If T > 0 Then
            M = Int(T / 60)
            S = T - (M * 60)
            Dim D As New Date(1900, 1, 1, 0, M, S)
            L2.Text = Format(D, "mm:ss")
        Else If T=0 Then 
                L2.Text = "00:00"
                animBox.Image= My.Resources.failed
                animBox.Visible=True 
                lblErreur.Visible=True
                lblErreur.Text="Temps écoulé !"  
                btnCorection.Visible=True
                'Stop 
            'Code à traiter quand le temps est écouler  
            Dim result As Integer = MessageBox.Show("Votre temps est écoulé !", "Résultat", MessageBoxButtons.RetryCancel, MessageBoxIcon.None)
                If result = DialogResult.Cancel Then
                    Me.Close
                ElseIf result = DialogResult.Retry Then
                    T=150
                End If
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        jeuxMot2.Show()
        Me.Hide()
    End Sub
End Class

