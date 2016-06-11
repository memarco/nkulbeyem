<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.lblProverb = New System.Windows.Forms.Label()
        Me.pbDictionary = New System.Windows.Forms.PictureBox()
        Me.pbProverb = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblDictionary = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblPresent = New System.Windows.Forms.Label()
        Me.lblGrammaire = New System.Windows.Forms.Label()
        Me.lblDialog = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblTon = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblJeux = New System.Windows.Forms.Label()
        Me.cpyRight = New System.Windows.Forms.PictureBox()
        Me.btnConfig = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.lblCulture = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.lblChant = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        CType(Me.pbDictionary,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbProverb,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cpyRight,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.btnConfig,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox9,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox10,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox11,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox12,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lblPhrase
        '
        Me.lblPhrase.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPhrase.AutoSize = true
        Me.lblPhrase.BackColor = System.Drawing.SystemColors.Control
        Me.lblPhrase.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPhrase.Location = New System.Drawing.Point(80, 512)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(137, 50)
        Me.lblPhrase.TabIndex = 10
        Me.lblPhrase.Text = "    Phrases    "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"   usuelles  "
        Me.lblPhrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProverb
        '
        Me.lblProverb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblProverb.AutoSize = true
        Me.lblProverb.BackColor = System.Drawing.SystemColors.Control
        Me.lblProverb.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblProverb.Location = New System.Drawing.Point(302, 512)
        Me.lblProverb.Name = "lblProverb"
        Me.lblProverb.Size = New System.Drawing.Size(142, 50)
        Me.lblProverb.TabIndex = 15
        Me.lblProverb.Text = "  Quelques "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  Proverbes   "
        '
        'pbDictionary
        '
        Me.pbDictionary.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbDictionary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDictionary.Image = Global.NkulBeyem_Duala.My.Resources.Resources.traduction
        Me.pbDictionary.Location = New System.Drawing.Point(748, 379)
        Me.pbDictionary.Name = "pbDictionary"
        Me.pbDictionary.Size = New System.Drawing.Size(134, 135)
        Me.pbDictionary.TabIndex = 16
        Me.pbDictionary.TabStop = false
        '
        'pbProverb
        '
        Me.pbProverb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbProverb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbProverb.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Proverb_Large1
        Me.pbProverb.Location = New System.Drawing.Point(303, 379)
        Me.pbProverb.Name = "pbProverb"
        Me.pbProverb.Size = New System.Drawing.Size(140, 140)
        Me.pbProverb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProverb.TabIndex = 14
        Me.pbProverb.TabStop = false
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Messaging
        Me.PictureBox5.Location = New System.Drawing.Point(80, 379)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(137, 140)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = false
        '
        'lblDictionary
        '
        Me.lblDictionary.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblDictionary.AutoSize = true
        Me.lblDictionary.BackColor = System.Drawing.SystemColors.Control
        Me.lblDictionary.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDictionary.Location = New System.Drawing.Point(748, 512)
        Me.lblDictionary.Name = "lblDictionary"
        Me.lblDictionary.Size = New System.Drawing.Size(134, 50)
        Me.lblDictionary.TabIndex = 17
        Me.lblDictionary.Text = "Le "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Dictionnaire"
        Me.lblDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Documents
        Me.PictureBox1.Location = New System.Drawing.Point(75, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = false
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Notepad
        Me.PictureBox3.Location = New System.Drawing.Point(304, 40)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(140, 136)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = false
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox4.BackColor = System.Drawing.Color.NavajoWhite
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Live_Messenger_alt_1
        Me.PictureBox4.Location = New System.Drawing.Point(961, 40)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(140, 136)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = false
        '
        'lblPresent
        '
        Me.lblPresent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPresent.AutoSize = true
        Me.lblPresent.BackColor = System.Drawing.SystemColors.Control
        Me.lblPresent.Font = New System.Drawing.Font("Century Gothic", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPresent.Location = New System.Drawing.Point(75, 149)
        Me.lblPresent.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPresent.Name = "lblPresent"
        Me.lblPresent.Size = New System.Drawing.Size(150, 27)
        Me.lblPresent.TabIndex = 8
        Me.lblPresent.Text = "Présentation"
        '
        'lblGrammaire
        '
        Me.lblGrammaire.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblGrammaire.AutoSize = true
        Me.lblGrammaire.BackColor = System.Drawing.SystemColors.Control
        Me.lblGrammaire.Font = New System.Drawing.Font("Century Gothic", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblGrammaire.Location = New System.Drawing.Point(304, 150)
        Me.lblGrammaire.Name = "lblGrammaire"
        Me.lblGrammaire.Size = New System.Drawing.Size(140, 27)
        Me.lblGrammaire.TabIndex = 9
        Me.lblGrammaire.Text = "Grammaire"
        '
        'lblDialog
        '
        Me.lblDialog.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDialog.AutoSize = true
        Me.lblDialog.BackColor = System.Drawing.SystemColors.Control
        Me.lblDialog.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDialog.Location = New System.Drawing.Point(961, 152)
        Me.lblDialog.Name = "lblDialog"
        Me.lblDialog.Size = New System.Drawing.Size(140, 25)
        Me.lblDialog.TabIndex = 11
        Me.lblDialog.Text = "   Dialogue   "
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Microphone_2
        Me.PictureBox6.Location = New System.Drawing.Point(742, 40)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(140, 136)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = false
        '
        'lblTon
        '
        Me.lblTon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTon.AutoSize = true
        Me.lblTon.BackColor = System.Drawing.SystemColors.Control
        Me.lblTon.Font = New System.Drawing.Font("Century Gothic", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTon.Location = New System.Drawing.Point(742, 151)
        Me.lblTon.Name = "lblTon"
        Me.lblTon.Padding = New System.Windows.Forms.Padding(1)
        Me.lblTon.Size = New System.Drawing.Size(140, 29)
        Me.lblTon.TabIndex = 13
        Me.lblTon.Text = "   Les Tons   "
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Games_alt
        Me.PictureBox7.Location = New System.Drawing.Point(969, 379)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(132, 140)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 19
        Me.PictureBox7.TabStop = false
        '
        'lblJeux
        '
        Me.lblJeux.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblJeux.AutoSize = true
        Me.lblJeux.BackColor = System.Drawing.SystemColors.Control
        Me.lblJeux.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblJeux.Location = New System.Drawing.Point(970, 512)
        Me.lblJeux.Name = "lblJeux"
        Me.lblJeux.Size = New System.Drawing.Size(132, 50)
        Me.lblJeux.TabIndex = 20
        Me.lblJeux.Text = "      Jeux      "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Excercices"
        Me.lblJeux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cpyRight
        '
        Me.cpyRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.cpyRight.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cpyRight.Image = Global.NkulBeyem_Duala.My.Resources.Resources.logowinwordnew
        Me.cpyRight.Location = New System.Drawing.Point(1, 517)
        Me.cpyRight.Name = "cpyRight"
        Me.cpyRight.Size = New System.Drawing.Size(130, 45)
        Me.cpyRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.cpyRight.TabIndex = 21
        Me.cpyRight.TabStop = false
        '
        'btnConfig
        '
        Me.btnConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnConfig.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnConfig.Image = Global.NkulBeyem_Duala.My.Resources.Resources.setting
        Me.btnConfig.Location = New System.Drawing.Point(1107, 40)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(70, 70)
        Me.btnConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnConfig.TabIndex = 22
        Me.btnConfig.TabStop = false
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Cameroun
        Me.PictureBox2.Location = New System.Drawing.Point(2, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = false
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox8.Image = Global.NkulBeyem_Duala.My.Resources.Resources.logodoul
        Me.PictureBox8.Location = New System.Drawing.Point(457, 473)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(275, 89)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 25
        Me.PictureBox8.TabStop = false
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PictureBox9.Image = Global.NkulBeyem_Duala.My.Resources.Resources.OIF_rvb_couleur
        Me.PictureBox9.Location = New System.Drawing.Point(1021, 483)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(165, 79)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 26
        Me.PictureBox9.TabStop = false
        '
        'lblCulture
        '
        Me.lblCulture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCulture.AutoSize = true
        Me.lblCulture.BackColor = System.Drawing.SystemColors.Control
        Me.lblCulture.Font = New System.Drawing.Font("Century Gothic", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCulture.Location = New System.Drawing.Point(307, 324)
        Me.lblCulture.Name = "lblCulture"
        Me.lblCulture.Size = New System.Drawing.Size(136, 27)
        Me.lblCulture.TabIndex = 28
        Me.lblCulture.Text = " La Culture "
        '
        'PictureBox10
        '
        Me.PictureBox10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox10.Image = Global.NkulBeyem_Duala.My.Resources.Resources.ngondo8
        Me.PictureBox10.Location = New System.Drawing.Point(303, 215)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(141, 136)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox10.TabIndex = 27
        Me.PictureBox10.TabStop = false
        '
        'lblChant
        '
        Me.lblChant.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblChant.AutoSize = true
        Me.lblChant.BackColor = System.Drawing.SystemColors.Control
        Me.lblChant.Font = New System.Drawing.Font("Century Gothic", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblChant.Location = New System.Drawing.Point(747, 324)
        Me.lblChant.Name = "lblChant"
        Me.lblChant.Size = New System.Drawing.Size(134, 27)
        Me.lblChant.TabIndex = 30
        Me.lblChant.Text = "     Chant    "
        '
        'PictureBox11
        '
        Me.PictureBox11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox11.Image = Global.NkulBeyem_Duala.My.Resources.Resources.Audacity
        Me.PictureBox11.Location = New System.Drawing.Point(747, 215)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(135, 136)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 29
        Me.PictureBox11.TabStop = false
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(831, 28)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Avec  le  soutien de  l'Organisation Internationale  de la  Francophonie"
        '
        'PictureBox12
        '
        Me.PictureBox12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox12.Image = Global.NkulBeyem_Duala.My.Resources.Resources._Default
        Me.PictureBox12.Location = New System.Drawing.Point(1124, 116)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 32
        Me.PictureBox12.TabStop = false
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.NkulBeyem_Duala.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1183, 602)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblChant)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.lblCulture)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.lblJeux)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.lblDictionary)
        Me.Controls.Add(Me.pbDictionary)
        Me.Controls.Add(Me.lblProverb)
        Me.Controls.Add(Me.pbProverb)
        Me.Controls.Add(Me.lblTon)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.lblDialog)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.lblGrammaire)
        Me.Controls.Add(Me.lblPresent)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cpyRight)
        Me.Controls.Add(Me.PictureBox9)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NKULBEYEM *** Langue DOUALA ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbDictionary,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbProverb,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cpyRight,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.btnConfig,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox11,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox12,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblPhrase As Label
    Friend WithEvents pbProverb As PictureBox
    Friend WithEvents lblProverb As Label
    Friend WithEvents pbDictionary As PictureBox
    Friend WithEvents lblDictionary As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblPresent As Label
    Friend WithEvents lblGrammaire As Label
    Friend WithEvents lblDialog As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblTon As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblJeux As Label
    Friend WithEvents cpyRight As PictureBox
    Friend WithEvents btnConfig As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents lblCulture As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents lblChant As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox12 As PictureBox
End Class
