<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJeux
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDictionary = New System.Windows.Forms.Label()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pbDictionary = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbDictionary,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choisir le jeux"
        '
        'lblDictionary
        '
        Me.lblDictionary.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblDictionary.AutoSize = true
        Me.lblDictionary.BackColor = System.Drawing.SystemColors.Control
        Me.lblDictionary.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDictionary.Location = New System.Drawing.Point(57, 218)
        Me.lblDictionary.Name = "lblDictionary"
        Me.lblDictionary.Size = New System.Drawing.Size(134, 50)
        Me.lblDictionary.TabIndex = 19
        Me.lblDictionary.Text = "Le "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Dictionnaire"
        Me.lblDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPhrase
        '
        Me.lblPhrase.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPhrase.AutoSize = true
        Me.lblPhrase.BackColor = System.Drawing.SystemColors.Control
        Me.lblPhrase.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPhrase.Location = New System.Drawing.Point(464, 218)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(137, 50)
        Me.lblPhrase.TabIndex = 21
        Me.lblPhrase.Text = "    Phrases    "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"   usuelles  "
        Me.lblPhrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Messaging
        Me.PictureBox5.Location = New System.Drawing.Point(464, 84)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(137, 140)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = false
        '
        'pbDictionary
        '
        Me.pbDictionary.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbDictionary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDictionary.Image = Global.NkulBeyem_Duala.My.Resources.Resources.traduction
        Me.pbDictionary.Location = New System.Drawing.Point(57, 84)
        Me.pbDictionary.Name = "pbDictionary"
        Me.pbDictionary.Size = New System.Drawing.Size(134, 135)
        Me.pbDictionary.TabIndex = 18
        Me.pbDictionary.TabStop = false
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Power___Shut_Down
        Me.PictureBox1.Location = New System.Drawing.Point(639, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = false
        '
        'frmJeux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 313)
        Me.ControlBox = false
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lblDictionary)
        Me.Controls.Add(Me.pbDictionary)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmJeux"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choisir votre jeux"
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbDictionary,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblDictionary As Label
    Friend WithEvents pbDictionary As PictureBox
    Friend WithEvents lblPhrase As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
