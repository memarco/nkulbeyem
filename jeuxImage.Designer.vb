<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jeuxImage
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.L2 = New System.Windows.Forms.Label()
        Me.rbrep1 = New System.Windows.Forms.RadioButton()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.notes = New System.Windows.Forms.Label()
        Me.lblResultTitre = New System.Windows.Forms.Label()
        Me.pnNote = New System.Windows.Forms.Panel()
        Me.btnRestart = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbDictionary = New System.Windows.Forms.PictureBox()
        Me.pnChrono = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnNote.SuspendLayout
        CType(Me.btnRestart,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.btnNext,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbDictionary,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnChrono.SuspendLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Cochez la réponse correspondant à l'image:"
        '
        'rb1
        '
        Me.rb1.AutoSize = true
        Me.rb1.Location = New System.Drawing.Point(65, 36)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(14, 13)
        Me.rb1.TabIndex = 25
        Me.rb1.TabStop = true
        Me.rb1.UseVisualStyleBackColor = true
        '
        'rb2
        '
        Me.rb2.AutoSize = true
        Me.rb2.Location = New System.Drawing.Point(89, 178)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(14, 13)
        Me.rb2.TabIndex = 26
        Me.rb2.TabStop = true
        Me.rb2.UseVisualStyleBackColor = true
        '
        'rb3
        '
        Me.rb3.AutoSize = true
        Me.rb3.Location = New System.Drawing.Point(89, 247)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(14, 13)
        Me.rb3.TabIndex = 27
        Me.rb3.TabStop = true
        Me.rb3.UseVisualStyleBackColor = true
        '
        'rb4
        '
        Me.rb4.AutoSize = true
        Me.rb4.Location = New System.Drawing.Point(89, 309)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(14, 13)
        Me.rb4.TabIndex = 28
        Me.rb4.TabStop = true
        Me.rb4.UseVisualStyleBackColor = true
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        Me.Timer1.Interval = 1000
        '
        'L2
        '
        Me.L2.AutoSize = true
        Me.L2.BackColor = System.Drawing.Color.Transparent
        Me.L2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.L2.Location = New System.Drawing.Point(29, 99)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(55, 22)
        Me.L2.TabIndex = 31
        Me.L2.Text = "01:00"
        '
        'rbrep1
        '
        Me.rbrep1.AutoSize = true
        Me.rbrep1.Location = New System.Drawing.Point(89, 108)
        Me.rbrep1.Name = "rbrep1"
        Me.rbrep1.Size = New System.Drawing.Size(14, 13)
        Me.rbrep1.TabIndex = 34
        Me.rbrep1.TabStop = true
        Me.rbrep1.UseVisualStyleBackColor = true
        '
        'lblNote
        '
        Me.lblNote.AutoSize = true
        Me.lblNote.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblNote.Location = New System.Drawing.Point(46, 45)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(24, 25)
        Me.lblNote.TabIndex = 37
        Me.lblNote.Text = "0"
        '
        'notes
        '
        Me.notes.AutoSize = true
        Me.notes.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.notes.Location = New System.Drawing.Point(65, 45)
        Me.notes.Name = "notes"
        Me.notes.Size = New System.Drawing.Size(34, 25)
        Me.notes.TabIndex = 39
        Me.notes.Text = "/6"
        '
        'lblResultTitre
        '
        Me.lblResultTitre.AutoSize = true
        Me.lblResultTitre.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblResultTitre.Location = New System.Drawing.Point(20, 13)
        Me.lblResultTitre.Name = "lblResultTitre"
        Me.lblResultTitre.Size = New System.Drawing.Size(90, 25)
        Me.lblResultTitre.TabIndex = 40
        Me.lblResultTitre.Text = "Résultat"
        '
        'pnNote
        '
        Me.pnNote.Controls.Add(Me.lblResultTitre)
        Me.pnNote.Controls.Add(Me.lblNote)
        Me.pnNote.Controls.Add(Me.notes)
        Me.pnNote.Location = New System.Drawing.Point(566, 347)
        Me.pnNote.Name = "pnNote"
        Me.pnNote.Size = New System.Drawing.Size(127, 83)
        Me.pnNote.TabIndex = 41
        Me.pnNote.Visible = false
        '
        'btnRestart
        '
        Me.btnRestart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestart.Image = Global.NkulBeyem_Duala.My.Resources.Resources.restart
        Me.btnRestart.Location = New System.Drawing.Point(270, 360)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(179, 71)
        Me.btnRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestart.TabIndex = 38
        Me.btnRestart.TabStop = false
        Me.btnRestart.Visible = false
        '
        'btnNext
        '
        Me.btnNext.Image = Global.NkulBeyem_Duala.My.Resources.Resources._next
        Me.btnNext.Location = New System.Drawing.Point(285, 350)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(97, 46)
        Me.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnNext.TabIndex = 35
        Me.btnNext.TabStop = false
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.NkulBeyem_Duala.My.Resources.Resources._41979
        Me.PictureBox5.Location = New System.Drawing.Point(20, 30)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(72, 66)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 32
        Me.PictureBox5.TabStop = false
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NkulBeyem_Duala.My.Resources.Resources.anim2
        Me.PictureBox1.Location = New System.Drawing.Point(65, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 273)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = false
        '
        'pbDictionary
        '
        Me.pbDictionary.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbDictionary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDictionary.Image = Global.NkulBeyem_Duala.My.Resources.Resources.reponse
        Me.pbDictionary.Location = New System.Drawing.Point(383, 108)
        Me.pbDictionary.Name = "pbDictionary"
        Me.pbDictionary.Size = New System.Drawing.Size(311, 218)
        Me.pbDictionary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDictionary.TabIndex = 19
        Me.pbDictionary.TabStop = false
        '
        'pnChrono
        '
        Me.pnChrono.Controls.Add(Me.PictureBox5)
        Me.pnChrono.Controls.Add(Me.L2)
        Me.pnChrono.Location = New System.Drawing.Point(270, 94)
        Me.pnChrono.Name = "pnChrono"
        Me.pnChrono.Size = New System.Drawing.Size(106, 189)
        Me.pnChrono.TabIndex = 42
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Power___Shut_Down
        Me.PictureBox2.Location = New System.Drawing.Point(664, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = false
        '
        'jeuxImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 437)
        Me.ControlBox = false
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pnChrono)
        Me.Controls.Add(Me.pnNote)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.rbrep1)
        Me.Controls.Add(Me.rb4)
        Me.Controls.Add(Me.rb3)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbDictionary)
        Me.Controls.Add(Me.rb1)
        Me.Name = "jeuxImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeux - IMAGE"
        Me.pnNote.ResumeLayout(false)
        Me.pnNote.PerformLayout
        CType(Me.btnRestart,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.btnNext,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbDictionary,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnChrono.ResumeLayout(false)
        Me.pnChrono.PerformLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents pbDictionary As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents L2 As Label
    Friend WithEvents rbrep1 As RadioButton
    Friend WithEvents btnNext As PictureBox
    Friend WithEvents lblNote As Label
    Friend WithEvents btnRestart As PictureBox
    Friend WithEvents notes As Label
    Friend WithEvents lblResultTitre As Label
    Friend WithEvents pnNote As Panel
    Friend WithEvents pnChrono As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
