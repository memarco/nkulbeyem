<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dictVetement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dictVetement))
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
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.PictureBox25 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mpProf,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox24,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.VolumeBar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox9,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox10,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox11,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox16,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox17,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox18,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox20,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox23,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox25,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.Label1.Location = New System.Drawing.Point(12, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Les  vêtements"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.NkulBeyem_Duala.My.Resources.Resources.play1
        Me.PictureBox1.Location = New System.Drawing.Point(301, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = false
        '
        'mpProf
        '
        Me.mpProf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.mpProf.Enabled = true
        Me.mpProf.Location = New System.Drawing.Point(872, 348)
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
        Me.PictureBox24.Location = New System.Drawing.Point(905, 103)
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
        Me.VolumeBar.Location = New System.Drawing.Point(937, 524)
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
        Me.PlayBar.Location = New System.Drawing.Point(872, 272)
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
        Me.PictureBox4.Location = New System.Drawing.Point(1007, 0)
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
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox5.Image = Global.NkulBeyem_Duala.My.Resources.Resources.slip_23338
        Me.PictureBox5.Location = New System.Drawing.Point(328, 57)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(84, 73)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 33
        Me.PictureBox5.TabStop = false
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox6.Image = Global.NkulBeyem_Duala.My.Resources.Resources.d66a3754
        Me.PictureBox6.Location = New System.Drawing.Point(328, 136)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(84, 69)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 34
        Me.PictureBox6.TabStop = false
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox7.Image = Global.NkulBeyem_Duala.My.Resources.Resources.cravate
        Me.PictureBox7.Location = New System.Drawing.Point(328, 373)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(84, 73)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 35
        Me.PictureBox7.TabStop = false
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox8.Image = Global.NkulBeyem_Duala.My.Resources.Resources.paire_de_chaussures_a_lacets_52d7042b
        Me.PictureBox8.Location = New System.Drawing.Point(328, 215)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(84, 73)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 36
        Me.PictureBox8.TabStop = false
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox9.Image = Global.NkulBeyem_Duala.My.Resources.Resources.chemise
        Me.PictureBox9.Location = New System.Drawing.Point(328, 294)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(84, 73)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 37
        Me.PictureBox9.TabStop = false
        '
        'PictureBox10
        '
        Me.PictureBox10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox10.Image = Global.NkulBeyem_Duala.My.Resources.Resources.habit
        Me.PictureBox10.Location = New System.Drawing.Point(328, 453)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(84, 73)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 38
        Me.PictureBox10.TabStop = false
        '
        'PictureBox11
        '
        Me.PictureBox11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox11.BackColor = System.Drawing.Color.White
        Me.PictureBox11.Image = Global.NkulBeyem_Duala.My.Resources.Resources.jupe
        Me.PictureBox11.Location = New System.Drawing.Point(328, 532)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(84, 73)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 39
        Me.PictureBox11.TabStop = false
        '
        'PictureBox16
        '
        Me.PictureBox16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox16.Image = Global.NkulBeyem_Duala.My.Resources.Resources.pagne
        Me.PictureBox16.Location = New System.Drawing.Point(689, 57)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(84, 73)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 45
        Me.PictureBox16.TabStop = false
        '
        'PictureBox17
        '
        Me.PictureBox17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox17.Image = Global.NkulBeyem_Duala.My.Resources.Resources.pantalon
        Me.PictureBox17.Location = New System.Drawing.Point(689, 132)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(84, 73)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox17.TabIndex = 46
        Me.PictureBox17.TabStop = false
        '
        'PictureBox18
        '
        Me.PictureBox18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox18.Image = Global.NkulBeyem_Duala.My.Resources.Resources.robe
        Me.PictureBox18.Location = New System.Drawing.Point(689, 215)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(84, 73)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox18.TabIndex = 47
        Me.PictureBox18.TabStop = false
        '
        'PictureBox20
        '
        Me.PictureBox20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox20.Image = Global.NkulBeyem_Duala.My.Resources.Resources.serviette
        Me.PictureBox20.Location = New System.Drawing.Point(689, 294)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(84, 73)
        Me.PictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox20.TabIndex = 49
        Me.PictureBox20.TabStop = false
        '
        'PictureBox23
        '
        Me.PictureBox23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox23.BackColor = System.Drawing.Color.White
        Me.PictureBox23.Image = Global.NkulBeyem_Duala.My.Resources.Resources.short_tanker1
        Me.PictureBox23.Location = New System.Drawing.Point(689, 373)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(84, 73)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 52
        Me.PictureBox23.TabStop = false
        '
        'PictureBox25
        '
        Me.PictureBox25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox25.Image = Global.NkulBeyem_Duala.My.Resources.Resources.veste
        Me.PictureBox25.Location = New System.Drawing.Point(689, 452)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(84, 73)
        Me.PictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox25.TabIndex = 53
        Me.PictureBox25.TabStop = false
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.AutoScroll = true
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PictureBox25)
        Me.Panel1.Controls.Add(Me.PictureBox23)
        Me.Panel1.Controls.Add(Me.PictureBox20)
        Me.Panel1.Controls.Add(Me.PictureBox18)
        Me.Panel1.Controls.Add(Me.PictureBox17)
        Me.Panel1.Controls.Add(Me.PictureBox16)
        Me.Panel1.Controls.Add(Me.PictureBox11)
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Controls.Add(Me.PictureBox9)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(19, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 677)
        Me.Panel1.TabIndex = 21
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Goldenrod
        Me.PictureBox2.Image = Global.NkulBeyem_Duala.My.Resources.Resources.vetement
        Me.PictureBox2.Location = New System.Drawing.Point(0, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(828, 602)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = false
        '
        'dictVetement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.BackgroundImage = Global.NkulBeyem_Duala.My.Resources.Resources.fond_dic
        Me.ClientSize = New System.Drawing.Size(1037, 741)
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
        Me.Name = "dictVetement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dictionnaire - VETEMENTS"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mpProf,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox24,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.VolumeBar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox11,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox16,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox17,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox18,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox20,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox23,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox25,System.ComponentModel.ISupportInitialize).EndInit
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
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents PictureBox25 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
