<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class choiceStart
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.llStart = New System.Windows.Forms.LinkLabel()
        Me.pbChoiceLang = New System.Windows.Forms.PictureBox()
        Me.pbChoice = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.pbChoiceLang,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbChoice,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox15,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'llStart
        '
        Me.llStart.AutoSize = true
        Me.llStart.BackColor = System.Drawing.Color.White
        Me.llStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llStart.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.llStart.LinkColor = System.Drawing.Color.Aqua
        Me.llStart.Location = New System.Drawing.Point(1, 616)
        Me.llStart.Name = "llStart"
        Me.llStart.Size = New System.Drawing.Size(391, 20)
        Me.llStart.TabIndex = 1
        Me.llStart.TabStop = true
        Me.llStart.Text = "Cliquez pour apprendre le Duala -  - Djokoua Douala"
        Me.llStart.Visible = false
        '
        'pbChoiceLang
        '
        Me.pbChoiceLang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbChoiceLang.Image = Global.NkulBeyem_Duala.My.Resources.Resources.btnchoice
        Me.pbChoiceLang.Location = New System.Drawing.Point(60, 384)
        Me.pbChoiceLang.Name = "pbChoiceLang"
        Me.pbChoiceLang.Size = New System.Drawing.Size(345, 67)
        Me.pbChoiceLang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChoiceLang.TabIndex = 2
        Me.pbChoiceLang.TabStop = false
        '
        'pbChoice
        '
        Me.pbChoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbChoice.Image = Global.NkulBeyem_Duala.My.Resources.Resources.drapeau1
        Me.pbChoice.Location = New System.Drawing.Point(0, 0)
        Me.pbChoice.Name = "pbChoice"
        Me.pbChoice.Size = New System.Drawing.Size(465, 639)
        Me.pbChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbChoice.TabIndex = 0
        Me.pbChoice.TabStop = false
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Power___Shut_Down
        Me.PictureBox15.Location = New System.Drawing.Point(435, 0)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 27
        Me.PictureBox15.TabStop = false
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = true
        Me.LinkLabel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(70, 393)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(314, 23)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = true
        Me.LinkLabel1.Text = "Cliquez pour apprendre la langue "
        '
        'choiceStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 639)
        Me.ControlBox = false
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.pbChoiceLang)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.llStart)
        Me.Controls.Add(Me.pbChoice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "choiceStart"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = true
        CType(Me.pbChoiceLang,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbChoice,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox15,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents pbChoice As PictureBox
    Friend WithEvents llStart As LinkLabel
    Friend WithEvents pbChoiceLang As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
