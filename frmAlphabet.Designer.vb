<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAlphabet
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlphabet))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mpProf = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PictureBox24 = New System.Windows.Forms.PictureBox()
        Me.VolumeBar = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlayBar = New System.Windows.Forms.HScrollBar()
        Me.DurationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mpProf,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox24,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.VolumeBar,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.PictureBox14,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox13,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage2.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.PictureBox12,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox11,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox10,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox9,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox15,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "La grammaire"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.NkulBeyem_Duala.My.Resources.Resources.play1
        Me.PictureBox1.Location = New System.Drawing.Point(261, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 54)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = false
        '
        'mpProf
        '
        Me.mpProf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.mpProf.Enabled = true
        Me.mpProf.Location = New System.Drawing.Point(1125, 348)
        Me.mpProf.Name = "mpProf"
        Me.mpProf.OcxState = CType(resources.GetObject("mpProf.OcxState"),System.Windows.Forms.AxHost.State)
        Me.mpProf.Size = New System.Drawing.Size(162, 42)
        Me.mpProf.TabIndex = 20
        Me.mpProf.Visible = false
        '
        'PictureBox24
        '
        Me.PictureBox24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PictureBox24.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox24.Image = Global.NkulBeyem_Duala.My.Resources.Resources.prof1
        Me.PictureBox24.Location = New System.Drawing.Point(1158, 103)
        Me.PictureBox24.Name = "PictureBox24"
        Me.PictureBox24.Size = New System.Drawing.Size(100, 166)
        Me.PictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox24.TabIndex = 19
        Me.PictureBox24.TabStop = false
        '
        'VolumeBar
        '
        Me.VolumeBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.VolumeBar.BackColor = System.Drawing.Color.BurlyWood
        Me.VolumeBar.Location = New System.Drawing.Point(1190, 516)
        Me.VolumeBar.Name = "VolumeBar"
        Me.VolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.VolumeBar.Size = New System.Drawing.Size(45, 139)
        Me.VolumeBar.TabIndex = 22
        Me.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.VolumeBar.Value = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(1176, 666)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Volume"
        '
        'PlayBar
        '
        Me.PlayBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PlayBar.Location = New System.Drawing.Point(1125, 272)
        Me.PlayBar.Name = "PlayBar"
        Me.PlayBar.Size = New System.Drawing.Size(162, 15)
        Me.PlayBar.TabIndex = 24
        '
        'DurationTimer
        '
        '
        'TabControl1
        '
        Me.TabControl1.AccessibleName = ""
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TabControl1.Location = New System.Drawing.Point(6, 78)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(15, 6)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1110, 655)
        Me.TabControl1.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = Global.NkulBeyem_Duala.My.Resources.Resources.fnd_animaux
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1102, 617)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ALPHABET"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = true
        Me.Panel1.Controls.Add(Me.PictureBox14)
        Me.Panel1.Controls.Add(Me.PictureBox13)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 611)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Bisque
        Me.PictureBox14.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox14.Location = New System.Drawing.Point(480, 233)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 31
        Me.PictureBox14.TabStop = false
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Bisque
        Me.PictureBox13.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox13.Location = New System.Drawing.Point(292, 529)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 30
        Me.PictureBox13.TabStop = false
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NkulBeyem_Duala.My.Resources.Resources.alphabet2
        Me.PictureBox2.Location = New System.Drawing.Point(-5, -3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1090, 1012)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = false
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1102, 617)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CONJUGAISON"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = true
        Me.Panel2.Controls.Add(Me.PictureBox12)
        Me.Panel2.Controls.Add(Me.PictureBox11)
        Me.Panel2.Controls.Add(Me.PictureBox10)
        Me.Panel2.Controls.Add(Me.PictureBox9)
        Me.Panel2.Controls.Add(Me.PictureBox8)
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1096, 611)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Bisque
        Me.PictureBox12.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox12.Location = New System.Drawing.Point(898, 1170)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 34
        Me.PictureBox12.TabStop = false
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Bisque
        Me.PictureBox11.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox11.Location = New System.Drawing.Point(606, 1170)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 33
        Me.PictureBox11.TabStop = false
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Bisque
        Me.PictureBox10.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox10.Location = New System.Drawing.Point(294, 1170)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 32
        Me.PictureBox10.TabStop = false
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Bisque
        Me.PictureBox9.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox9.Location = New System.Drawing.Point(865, 915)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 31
        Me.PictureBox9.TabStop = false
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.PictureBox8.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox8.Location = New System.Drawing.Point(585, 915)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 30
        Me.PictureBox8.TabStop = false
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Bisque
        Me.PictureBox7.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox7.Location = New System.Drawing.Point(281, 915)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 29
        Me.PictureBox7.TabStop = false
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Bisque
        Me.PictureBox6.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox6.Location = New System.Drawing.Point(897, 612)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 28
        Me.PictureBox6.TabStop = false
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Bisque
        Me.PictureBox5.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox5.Location = New System.Drawing.Point(604, 612)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 27
        Me.PictureBox5.TabStop = false
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Bisque
        Me.PictureBox4.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox4.Location = New System.Drawing.Point(293, 612)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 26
        Me.PictureBox4.TabStop = false
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.NkulBeyem_Duala.My.Resources.Resources.conjugaison
        Me.PictureBox3.Location = New System.Drawing.Point(-7, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1090, 1550)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = false
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Power___Shut_Down
        Me.PictureBox15.Location = New System.Drawing.Point(1260, 0)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 26
        Me.PictureBox15.TabStop = false
        '
        'frmAlphabet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NkulBeyem_Duala.My.Resources.Resources.fond_dic
        Me.ClientSize = New System.Drawing.Size(1290, 733)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PlayBar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VolumeBar)
        Me.Controls.Add(Me.mpProf)
        Me.Controls.Add(Me.PictureBox24)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmAlphabet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grammaire"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mpProf,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox24,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.VolumeBar,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.PictureBox14,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox13,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage2.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.PictureBox12,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox11,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox15,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mpProf As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox24 As PictureBox
    Friend WithEvents VolumeBar As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents PlayBar As HScrollBar
    Friend WithEvents DurationTimer As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
End Class
