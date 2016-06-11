<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dictSalutation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dictSalutation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mpProf = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PictureBox24 = New System.Windows.Forms.PictureBox()
        Me.VolumeBar = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlayBar = New System.Windows.Forms.HScrollBar()
        Me.DurationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmEnd = New System.Windows.Forms.Timer(Me.components)
        Me.tmStart = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox29 = New System.Windows.Forms.PictureBox()
        Me.PictureBox28 = New System.Windows.Forms.PictureBox()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox32 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mpProf,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox24,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.VolumeBar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox10,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox14,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox12,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox29,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox28,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox26,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox20,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox32,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.Label1.Size = New System.Drawing.Size(262, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Les Salutations"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.NkulBeyem_Duala.My.Resources.Resources.play1
        Me.PictureBox1.Location = New System.Drawing.Point(232, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 54)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = false
        '
        'mpProf
        '
        Me.mpProf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.mpProf.Enabled = true
        Me.mpProf.Location = New System.Drawing.Point(824, 348)
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
        Me.PictureBox24.Location = New System.Drawing.Point(857, 103)
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
        Me.VolumeBar.Location = New System.Drawing.Point(889, 516)
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
        Me.PlayBar.Location = New System.Drawing.Point(824, 272)
        Me.PlayBar.Name = "PlayBar"
        Me.PlayBar.Size = New System.Drawing.Size(162, 15)
        Me.PlayBar.TabIndex = 24
        '
        'DurationTimer
        '
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Power___Shut_Down
        Me.PictureBox4.Location = New System.Drawing.Point(956, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "SORTIR")
        '
        'tmStart
        '
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox5.Location = New System.Drawing.Point(355, 69)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = false
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox3.Location = New System.Drawing.Point(374, 160)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = false
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox10.Location = New System.Drawing.Point(374, 245)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 39
        Me.PictureBox10.TabStop = false
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox14.Location = New System.Drawing.Point(409, 335)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 43
        Me.PictureBox14.TabStop = false
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox12.Location = New System.Drawing.Point(374, 427)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 45
        Me.PictureBox12.TabStop = false
        '
        'PictureBox29
        '
        Me.PictureBox29.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox29.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox29.Location = New System.Drawing.Point(758, 69)
        Me.PictureBox29.Name = "PictureBox29"
        Me.PictureBox29.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox29.TabIndex = 50
        Me.PictureBox29.TabStop = false
        '
        'PictureBox28
        '
        Me.PictureBox28.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox28.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox28.Location = New System.Drawing.Point(748, 160)
        Me.PictureBox28.Name = "PictureBox28"
        Me.PictureBox28.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox28.TabIndex = 51
        Me.PictureBox28.TabStop = false
        '
        'PictureBox26
        '
        Me.PictureBox26.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox26.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox26.Location = New System.Drawing.Point(748, 245)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox26.TabIndex = 53
        Me.PictureBox26.TabStop = false
        '
        'PictureBox20
        '
        Me.PictureBox20.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox20.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox20.Location = New System.Drawing.Point(748, 335)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox20.TabIndex = 58
        Me.PictureBox20.TabStop = false
        '
        'PictureBox32
        '
        Me.PictureBox32.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox32.Image = Global.NkulBeyem_Duala.My.Resources.Resources.audio
        Me.PictureBox32.Location = New System.Drawing.Point(645, 427)
        Me.PictureBox32.Name = "PictureBox32"
        Me.PictureBox32.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox32.TabIndex = 61
        Me.PictureBox32.TabStop = false
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = true
        Me.Panel1.Controls.Add(Me.PictureBox32)
        Me.Panel1.Controls.Add(Me.PictureBox20)
        Me.Panel1.Controls.Add(Me.PictureBox26)
        Me.Panel1.Controls.Add(Me.PictureBox28)
        Me.Panel1.Controls.Add(Me.PictureBox29)
        Me.Panel1.Controls.Add(Me.PictureBox12)
        Me.Panel1.Controls.Add(Me.PictureBox14)
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(19, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 493)
        Me.Panel1.TabIndex = 21
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.NkulBeyem_Duala.My.Resources.Resources.salutation1
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(799, 493)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = false
        '
        'dictSalutation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = Global.NkulBeyem_Duala.My.Resources.Resources.fond_dic
        Me.ClientSize = New System.Drawing.Size(989, 733)
        Me.ControlBox = false
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PlayBar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VolumeBar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mpProf)
        Me.Controls.Add(Me.PictureBox24)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "dictSalutation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dictionnaire - SALUTATIONS"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mpProf,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox24,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.VolumeBar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox14,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox12,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox29,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox28,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox26,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox20,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox32,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
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
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tmEnd As Timer
    Friend WithEvents tmStart As Timer
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox29 As PictureBox
    Friend WithEvents PictureBox28 As PictureBox
    Friend WithEvents PictureBox26 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox32 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
