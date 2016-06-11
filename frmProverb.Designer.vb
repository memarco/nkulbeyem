<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProverb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProverb))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VolumeBar = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DurationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox37 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.mpProf = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PlayBar = New System.Windows.Forms.HScrollBar()
        Me.PictureBox24 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.VolumeBar,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        CType(Me.PictureBox6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox37,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mpProf,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox24,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox7,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.Label1.Size = New System.Drawing.Size(364, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quelques proverbes"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.NkulBeyem_Duala.My.Resources.Resources.play1
        Me.PictureBox1.Location = New System.Drawing.Point(382, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 54)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = false
        '
        'VolumeBar
        '
        Me.VolumeBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.VolumeBar.BackColor = System.Drawing.Color.BurlyWood
        Me.VolumeBar.Location = New System.Drawing.Point(1190, 454)
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
        'DurationTimer
        '
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = true
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox37)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(1, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1118, 630)
        Me.Panel1.TabIndex = 25
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Black
        Me.PictureBox6.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox6.Location = New System.Drawing.Point(1080, 546)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 51
        Me.PictureBox6.TabStop = false
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Black
        Me.PictureBox5.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox5.Location = New System.Drawing.Point(381, 506)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 50
        Me.PictureBox5.TabStop = false
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox4.Location = New System.Drawing.Point(1080, 274)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 49
        Me.PictureBox4.TabStop = false
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox3.Location = New System.Drawing.Point(381, 274)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 48
        Me.PictureBox3.TabStop = false
        '
        'PictureBox37
        '
        Me.PictureBox37.BackColor = System.Drawing.Color.Black
        Me.PictureBox37.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox37.Location = New System.Drawing.Point(741, 274)
        Me.PictureBox37.Name = "PictureBox37"
        Me.PictureBox37.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox37.TabIndex = 47
        Me.PictureBox37.TabStop = false
        Me.PictureBox37.Visible = false
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.NkulBeyem_Duala.My.Resources.Resources.proverbe
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1118, 630)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = false
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
        'PlayBar
        '
        Me.PlayBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PlayBar.Location = New System.Drawing.Point(1125, 272)
        Me.PlayBar.Name = "PlayBar"
        Me.PlayBar.Size = New System.Drawing.Size(162, 15)
        Me.PlayBar.TabIndex = 24
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
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Power___Shut_Down
        Me.PictureBox7.Location = New System.Drawing.Point(1259, 1)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 26
        Me.PictureBox7.TabStop = false
        '
        'frmProverb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NkulBeyem_Duala.My.Resources.Resources.fond_dic
        Me.ClientSize = New System.Drawing.Size(1290, 671)
        Me.ControlBox = false
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Panel1)
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
        Me.Name = "frmProverb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Les proverbes"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.VolumeBar,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        CType(Me.PictureBox6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox37,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mpProf,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox24,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox7,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VolumeBar As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents DurationTimer As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents mpProf As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PlayBar As HScrollBar
    Friend WithEvents PictureBox24 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox37 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
