<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.WaveFreqTextBox = New mSXdevtools.GUI.piXelST.pxTextBox()
        Me.WaveMinTextBox = New mSXdevtools.GUI.piXelST.pxTextBox()
        Me.WaveMaxTextBox = New mSXdevtools.GUI.piXelST.pxTextBox()
        Me.WaveLengthTextBox = New mSXdevtools.GUI.piXelST.pxTextBox()
        Me.RandomButton = New mSXdevtools.GUI.piXelST.pxButton()
        Me.PhaseTextBox = New mSXdevtools.GUI.piXelST.pxTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.LoadButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveAsButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProjectNameTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ProjectInfoButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfigButton = New System.Windows.Forms.ToolStripButton()
        Me.Help_Button = New System.Windows.Forms.ToolStripButton()
        Me.AboutButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.PiXelGroupBox1 = New mSXdevtools.GUI.piXelST.pxGroupBox()
        Me.WaveLengthTrackBar = New mSXdevtools.GUI.piXelST.pxSlider()
        Me.SignedRulerPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New mSXdevtools.GUI.piXelST.pxLabel()
        Me.SignComboBox = New mSXdevtools.GUI.piXelST.pxComboBox()
        Me.DrawPanel = New System.Windows.Forms.Panel()
        Me.GFXoutputPictureBox = New System.Windows.Forms.PictureBox()
        Me.UnsignedRulerPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label13 = New mSXdevtools.GUI.piXelST.pxLabel()
        Me.Label14 = New mSXdevtools.GUI.piXelST.pxLabel()
        Me.WaveMinTrackBar = New mSXdevtools.GUI.piXelST.pxSlider()
        Me.WaveMaxTrackBar = New mSXdevtools.GUI.piXelST.pxSlider()
        Me.WavePhaseTrackBar = New mSXdevtools.GUI.piXelST.pxSlider()
        Me.LabelFreq = New mSXdevtools.GUI.piXelST.pxLabel()
        Me.WaveFreqTrackBar = New mSXdevtools.GUI.piXelST.pxSlider()
        Me.LabelPhase = New mSXdevtools.GUI.piXelST.pxLabel()
        Me.Label4 = New mSXdevtools.GUI.piXelST.pxLabel()
        Me.WaveTypeComboBox = New mSXdevtools.GUI.piXelST.pxComboBox()
        Me.Label12 = New mSXdevtools.GUI.piXelST.pxLabel()
        Me.WindowControlBarPanel = New System.Windows.Forms.Panel()
        Me.Title_Label = New mSXdevtools.GUI.piXelST.pxLabel()
        Me.MaximizeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.anOutputDataGBox = New mSXdevtools.ByteniZ3R.OutputDataGBox()
        Me.ToolStrip1.SuspendLayout()
        Me.PiXelGroupBox1.SuspendLayout()
        CType(Me.SignedRulerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DrawPanel.SuspendLayout()
        CType(Me.GFXoutputPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnsignedRulerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WindowControlBarPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 7000
        Me.ToolTip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'WaveFreqTextBox
        '
        Me.WaveFreqTextBox.ItsAnumber = True
        Me.WaveFreqTextBox.Location = New System.Drawing.Point(419, 190)
        Me.WaveFreqTextBox.MaxLength = 3
        Me.WaveFreqTextBox.Name = "WaveFreqTextBox"
        Me.WaveFreqTextBox.Size = New System.Drawing.Size(70, 24)
        Me.WaveFreqTextBox.TabIndex = 12
        Me.WaveFreqTextBox.Text = "1"
        Me.WaveFreqTextBox.Tooltip = Nothing
        Me.ToolTip1.SetToolTip(Me.WaveFreqTextBox, "Frequency from 1 to (Length/4)")
        Me.WaveFreqTextBox.Value = 1
        '
        'WaveMinTextBox
        '
        Me.WaveMinTextBox.ItsAnumber = True
        Me.WaveMinTextBox.Location = New System.Drawing.Point(419, 92)
        Me.WaveMinTextBox.MaxLength = 4
        Me.WaveMinTextBox.Name = "WaveMinTextBox"
        Me.WaveMinTextBox.Size = New System.Drawing.Size(70, 24)
        Me.WaveMinTextBox.TabIndex = 6
        Me.WaveMinTextBox.Text = "0"
        Me.WaveMinTextBox.Tooltip = Nothing
        Me.ToolTip1.SetToolTip(Me.WaveMinTextBox, "(0-255)")
        '
        'WaveMaxTextBox
        '
        Me.WaveMaxTextBox.ItsAnumber = True
        Me.WaveMaxTextBox.Location = New System.Drawing.Point(419, 124)
        Me.WaveMaxTextBox.MaxLength = 4
        Me.WaveMaxTextBox.Name = "WaveMaxTextBox"
        Me.WaveMaxTextBox.Size = New System.Drawing.Size(70, 24)
        Me.WaveMaxTextBox.TabIndex = 8
        Me.WaveMaxTextBox.Text = "0"
        Me.WaveMaxTextBox.Tooltip = Nothing
        Me.ToolTip1.SetToolTip(Me.WaveMaxTextBox, "(0-255)")
        '
        'WaveLengthTextBox
        '
        Me.WaveLengthTextBox.ItsAnumber = True
        Me.WaveLengthTextBox.Location = New System.Drawing.Point(419, 59)
        Me.WaveLengthTextBox.MaxLength = 5
        Me.WaveLengthTextBox.Maximum = 2048
        Me.WaveLengthTextBox.Minimum = 8
        Me.WaveLengthTextBox.Name = "WaveLengthTextBox"
        Me.WaveLengthTextBox.Size = New System.Drawing.Size(70, 24)
        Me.WaveLengthTextBox.TabIndex = 4
        Me.WaveLengthTextBox.Text = "8"
        Me.WaveLengthTextBox.Tooltip = Nothing
        Me.ToolTip1.SetToolTip(Me.WaveLengthTextBox, "Total of values (8 to 1024).")
        Me.WaveLengthTextBox.Value = 8
        '
        'RandomButton
        '
        Me.RandomButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RandomButton.Location = New System.Drawing.Point(419, 29)
        Me.RandomButton.Name = "RandomButton"
        Me.RandomButton.Size = New System.Drawing.Size(70, 24)
        Me.RandomButton.TabIndex = 2
        Me.RandomButton.Text = "Rnd"
        Me.RandomButton.Tooltip = "Generate a new random data."
        '
        'PhaseTextBox
        '
        Me.PhaseTextBox.ItsAnumber = True
        Me.PhaseTextBox.Location = New System.Drawing.Point(419, 157)
        Me.PhaseTextBox.MaxLength = 3
        Me.PhaseTextBox.Name = "PhaseTextBox"
        Me.PhaseTextBox.Size = New System.Drawing.Size(70, 24)
        Me.PhaseTextBox.TabIndex = 10
        Me.PhaseTextBox.Text = "0"
        Me.PhaseTextBox.Tooltip = Nothing
        Me.ToolTip1.SetToolTip(Me.PhaseTextBox, "Phase (0-359)")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.LoadButton, Me.SaveButton, Me.SaveAsButton, Me.ToolStripSeparator2, Me.ProjectNameTextBox, Me.ProjectInfoButton, Me.ToolStripSeparator1, Me.ConfigButton, Me.Help_Button, Me.AboutButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 33)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(893, 39)
        Me.ToolStrip1.TabIndex = 113
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewButton
        '
        Me.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewButton.Image = Global.mSXdevtools.ByteniZ3R.My.Resources.Resources.ico_new_32px
        Me.NewButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(36, 36)
        Me.NewButton.Text = "ToolStripButton1"
        Me.NewButton.ToolTipText = "New Project [Ctrl+N]"
        '
        'LoadButton
        '
        Me.LoadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LoadButton.Image = Global.mSXdevtools.ByteniZ3R.My.Resources.Resources.ico_load_32px
        Me.LoadButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LoadButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(36, 36)
        Me.LoadButton.Text = "ToolStripButton1"
        Me.LoadButton.ToolTipText = "Load Project [Ctrl+O]"
        '
        'SaveButton
        '
        Me.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveButton.Image = Global.mSXdevtools.ByteniZ3R.My.Resources.Resources.ico_save_32px
        Me.SaveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(36, 36)
        Me.SaveButton.Text = "ToolStripButton1"
        Me.SaveButton.ToolTipText = "Save Project"
        '
        'SaveAsButton
        '
        Me.SaveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveAsButton.Image = Global.mSXdevtools.ByteniZ3R.My.Resources.Resources.ico_save_as_32px
        Me.SaveAsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveAsButton.Name = "SaveAsButton"
        Me.SaveAsButton.Size = New System.Drawing.Size(36, 36)
        Me.SaveAsButton.Text = "ToolStripButton1"
        Me.SaveAsButton.ToolTipText = "Save As Project [Ctrl+S]"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ProjectNameTextBox
        '
        Me.ProjectNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProjectNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProjectNameTextBox.Name = "ProjectNameTextBox"
        Me.ProjectNameTextBox.ReadOnly = True
        Me.ProjectNameTextBox.Size = New System.Drawing.Size(280, 39)
        '
        'ProjectInfoButton
        '
        Me.ProjectInfoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProjectInfoButton.Image = Global.mSXdevtools.ByteniZ3R.My.Resources.Resources.ico_config_prj_32px
        Me.ProjectInfoButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProjectInfoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ProjectInfoButton.Name = "ProjectInfoButton"
        Me.ProjectInfoButton.Size = New System.Drawing.Size(36, 36)
        Me.ProjectInfoButton.Text = "ToolStripButton1"
        Me.ProjectInfoButton.ToolTipText = "Edit Project Info"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ConfigButton
        '
        Me.ConfigButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConfigButton.Image = Global.mSXdevtools.ByteniZ3R.My.Resources.Resources.ico_config_app_32px
        Me.ConfigButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfigButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConfigButton.Name = "ConfigButton"
        Me.ConfigButton.Size = New System.Drawing.Size(36, 36)
        Me.ConfigButton.Text = "ToolStripButton1"
        Me.ConfigButton.ToolTipText = "Application Settings"
        '
        'Help_Button
        '
        Me.Help_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Help_Button.Image = Global.mSXdevtools.ByteniZ3R.My.Resources.Resources.ico_help_32px
        Me.Help_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Help_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Help_Button.Name = "Help_Button"
        Me.Help_Button.Size = New System.Drawing.Size(36, 36)
        Me.Help_Button.Text = "ToolStripButton1"
        Me.Help_Button.ToolTipText = "Help [F1]"
        '
        'AboutButton
        '
        Me.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AboutButton.Image = Global.mSXdevtools.ByteniZ3R.My.Resources.Resources.ico_about_32px
        Me.AboutButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(36, 36)
        Me.AboutButton.Text = "ToolStripButton1"
        Me.AboutButton.ToolTipText = "About this Application"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 692)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(893, 20)
        Me.StatusStrip1.TabIndex = 119
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'PiXelGroupBox1
        '
        Me.PiXelGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PiXelGroupBox1.Controls.Add(Me.WaveLengthTrackBar)
        Me.PiXelGroupBox1.Controls.Add(Me.SignedRulerPictureBox)
        Me.PiXelGroupBox1.Controls.Add(Me.Label1)
        Me.PiXelGroupBox1.Controls.Add(Me.SignComboBox)
        Me.PiXelGroupBox1.Controls.Add(Me.DrawPanel)
        Me.PiXelGroupBox1.Controls.Add(Me.UnsignedRulerPictureBox)
        Me.PiXelGroupBox1.Controls.Add(Me.Label13)
        Me.PiXelGroupBox1.Controls.Add(Me.Label14)
        Me.PiXelGroupBox1.Controls.Add(Me.WaveFreqTextBox)
        Me.PiXelGroupBox1.Controls.Add(Me.WaveMinTrackBar)
        Me.PiXelGroupBox1.Controls.Add(Me.WaveMaxTrackBar)
        Me.PiXelGroupBox1.Controls.Add(Me.WaveMinTextBox)
        Me.PiXelGroupBox1.Controls.Add(Me.WavePhaseTrackBar)
        Me.PiXelGroupBox1.Controls.Add(Me.LabelFreq)
        Me.PiXelGroupBox1.Controls.Add(Me.WaveFreqTrackBar)
        Me.PiXelGroupBox1.Controls.Add(Me.LabelPhase)
        Me.PiXelGroupBox1.Controls.Add(Me.Label4)
        Me.PiXelGroupBox1.Controls.Add(Me.WaveMaxTextBox)
        Me.PiXelGroupBox1.Controls.Add(Me.WaveLengthTextBox)
        Me.PiXelGroupBox1.Controls.Add(Me.WaveTypeComboBox)
        Me.PiXelGroupBox1.Controls.Add(Me.RandomButton)
        Me.PiXelGroupBox1.Controls.Add(Me.Label12)
        Me.PiXelGroupBox1.Controls.Add(Me.PhaseTextBox)
        Me.PiXelGroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.PiXelGroupBox1.Name = "PiXelGroupBox1"
        Me.PiXelGroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.PiXelGroupBox1.Size = New System.Drawing.Size(869, 300)
        Me.PiXelGroupBox1.TabIndex = 120
        Me.PiXelGroupBox1.TabStop = False
        Me.PiXelGroupBox1.Text = "Waveform"
        '
        'WaveLengthTrackBar
        '
        Me.WaveLengthTrackBar.Location = New System.Drawing.Point(160, 59)
        Me.WaveLengthTrackBar.Maximum = 2048
        Me.WaveLengthTrackBar.Minimum = 8
        Me.WaveLengthTrackBar.Name = "WaveLengthTrackBar"
        Me.WaveLengthTrackBar.Size = New System.Drawing.Size(255, 24)
        Me.WaveLengthTrackBar.TabIndex = 39
        Me.WaveLengthTrackBar.Tooltip = Nothing
        Me.WaveLengthTrackBar.Value = 8
        '
        'SignedRulerPictureBox
        '
        Me.SignedRulerPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.SignedRulerPictureBox.BackgroundImage = Global.mSXdevtools.ByteniZ3R.My.Resources.Resources.signed_display_ruler
        Me.SignedRulerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SignedRulerPictureBox.Location = New System.Drawing.Point(474, 278)
        Me.SignedRulerPictureBox.Name = "SignedRulerPictureBox"
        Me.SignedRulerPictureBox.Size = New System.Drawing.Size(30, 267)
        Me.SignedRulerPictureBox.TabIndex = 38
        Me.SignedRulerPictureBox.TabStop = False
        Me.SignedRulerPictureBox.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 26)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Tooltip = Nothing
        '
        'SignComboBox
        '
        Me.SignComboBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SignComboBox.ForeColor = System.Drawing.Color.Black
        Me.SignComboBox.Items.Add("8bits Unsigned")
        Me.SignComboBox.Items.Add("8bits Signed")
        Me.SignComboBox.Location = New System.Drawing.Point(164, 227)
        Me.SignComboBox.MinimumSize = New System.Drawing.Size(202, 24)
        Me.SignComboBox.Name = "SignComboBox"
        Me.SignComboBox.SelectedIndex = 0
        Me.SignComboBox.Size = New System.Drawing.Size(242, 24)
        Me.SignComboBox.TabIndex = 36
        Me.SignComboBox.Tooltip = "Select the 8-bit output data type (signed/unsigned)"
        '
        'DrawPanel
        '
        Me.DrawPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawPanel.AutoScroll = True
        Me.DrawPanel.BackColor = System.Drawing.Color.LightSlateGray
        Me.DrawPanel.BackgroundImage = Global.mSXdevtools.ByteniZ3R.My.Resources.Resources.textu00
        Me.DrawPanel.Controls.Add(Me.GFXoutputPictureBox)
        Me.DrawPanel.Location = New System.Drawing.Point(535, 18)
        Me.DrawPanel.Name = "DrawPanel"
        Me.DrawPanel.Size = New System.Drawing.Size(322, 256)
        Me.DrawPanel.TabIndex = 35
        '
        'GFXoutputPictureBox
        '
        Me.GFXoutputPictureBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GFXoutputPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.GFXoutputPictureBox.Name = "GFXoutputPictureBox"
        Me.GFXoutputPictureBox.Size = New System.Drawing.Size(256, 192)
        Me.GFXoutputPictureBox.TabIndex = 28
        Me.GFXoutputPictureBox.TabStop = False
        '
        'UnsignedRulerPictureBox
        '
        Me.UnsignedRulerPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.UnsignedRulerPictureBox.BackgroundImage = Global.mSXdevtools.ByteniZ3R.My.Resources.Resources.unsigned_display_ruler
        Me.UnsignedRulerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UnsignedRulerPictureBox.Location = New System.Drawing.Point(505, 14)
        Me.UnsignedRulerPictureBox.Name = "UnsignedRulerPictureBox"
        Me.UnsignedRulerPictureBox.Size = New System.Drawing.Size(30, 267)
        Me.UnsignedRulerPictureBox.TabIndex = 34
        Me.UnsignedRulerPictureBox.TabStop = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(4, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 26)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Max value"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Tooltip = Nothing
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(4, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 26)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Waveform"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Tooltip = Nothing
        '
        'WaveMinTrackBar
        '
        Me.WaveMinTrackBar.Location = New System.Drawing.Point(160, 91)
        Me.WaveMinTrackBar.Maximum = 254
        Me.WaveMinTrackBar.Name = "WaveMinTrackBar"
        Me.WaveMinTrackBar.Size = New System.Drawing.Size(255, 24)
        Me.WaveMinTrackBar.TabIndex = 5
        Me.WaveMinTrackBar.Tooltip = Nothing
        '
        'WaveMaxTrackBar
        '
        Me.WaveMaxTrackBar.Location = New System.Drawing.Point(160, 124)
        Me.WaveMaxTrackBar.Minimum = 1
        Me.WaveMaxTrackBar.Name = "WaveMaxTrackBar"
        Me.WaveMaxTrackBar.Size = New System.Drawing.Size(255, 24)
        Me.WaveMaxTrackBar.TabIndex = 7
        Me.WaveMaxTrackBar.Tooltip = Nothing
        Me.WaveMaxTrackBar.Value = 1
        '
        'WavePhaseTrackBar
        '
        Me.WavePhaseTrackBar.LargeChange = 15
        Me.WavePhaseTrackBar.Location = New System.Drawing.Point(160, 157)
        Me.WavePhaseTrackBar.Maximum = 359
        Me.WavePhaseTrackBar.Name = "WavePhaseTrackBar"
        Me.WavePhaseTrackBar.Size = New System.Drawing.Size(255, 24)
        Me.WavePhaseTrackBar.TabIndex = 9
        Me.WavePhaseTrackBar.Tooltip = Nothing
        '
        'LabelFreq
        '
        Me.LabelFreq.Location = New System.Drawing.Point(4, 193)
        Me.LabelFreq.Name = "LabelFreq"
        Me.LabelFreq.Size = New System.Drawing.Size(150, 26)
        Me.LabelFreq.TabIndex = 33
        Me.LabelFreq.Text = "Frequency"
        Me.LabelFreq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelFreq.Tooltip = Nothing
        '
        'WaveFreqTrackBar
        '
        Me.WaveFreqTrackBar.Location = New System.Drawing.Point(160, 190)
        Me.WaveFreqTrackBar.Maximum = 256
        Me.WaveFreqTrackBar.Minimum = 1
        Me.WaveFreqTrackBar.Name = "WaveFreqTrackBar"
        Me.WaveFreqTrackBar.Size = New System.Drawing.Size(255, 24)
        Me.WaveFreqTrackBar.TabIndex = 11
        Me.WaveFreqTrackBar.Tooltip = Nothing
        Me.WaveFreqTrackBar.Value = 1
        '
        'LabelPhase
        '
        Me.LabelPhase.Location = New System.Drawing.Point(4, 160)
        Me.LabelPhase.Name = "LabelPhase"
        Me.LabelPhase.Size = New System.Drawing.Size(150, 26)
        Me.LabelPhase.TabIndex = 30
        Me.LabelPhase.Text = "Phase"
        Me.LabelPhase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelPhase.Tooltip = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 26)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Length"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Tooltip = Nothing
        '
        'WaveTypeComboBox
        '
        Me.WaveTypeComboBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.WaveTypeComboBox.ForeColor = System.Drawing.Color.Black
        Me.WaveTypeComboBox.Items.Add("Sine")
        Me.WaveTypeComboBox.Items.Add("1/2 Sine Upper")
        Me.WaveTypeComboBox.Items.Add("1/2 Sine Lower")
        Me.WaveTypeComboBox.Items.Add("Cosine")
        Me.WaveTypeComboBox.Items.Add("Square")
        Me.WaveTypeComboBox.Items.Add("Triangle")
        Me.WaveTypeComboBox.Items.Add("Sawtooth")
        Me.WaveTypeComboBox.Items.Add("Reverse Sawtooth")
        Me.WaveTypeComboBox.Items.Add("Noise")
        Me.WaveTypeComboBox.Location = New System.Drawing.Point(164, 29)
        Me.WaveTypeComboBox.MinimumSize = New System.Drawing.Size(202, 24)
        Me.WaveTypeComboBox.Name = "WaveTypeComboBox"
        Me.WaveTypeComboBox.SelectedIndex = 0
        Me.WaveTypeComboBox.Size = New System.Drawing.Size(242, 24)
        Me.WaveTypeComboBox.TabIndex = 1
        Me.WaveTypeComboBox.Tooltip = Nothing
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(4, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 26)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Min value"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Tooltip = Nothing
        '
        'WindowControlBarPanel
        '
        Me.WindowControlBarPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.WindowControlBarPanel.Controls.Add(Me.Title_Label)
        Me.WindowControlBarPanel.Controls.Add(Me.MaximizeButton)
        Me.WindowControlBarPanel.Controls.Add(Me.ExitButton)
        Me.WindowControlBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowControlBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.WindowControlBarPanel.Name = "WindowControlBarPanel"
        Me.WindowControlBarPanel.Size = New System.Drawing.Size(893, 33)
        Me.WindowControlBarPanel.TabIndex = 294
        '
        'Title_Label
        '
        Me.Title_Label.CausesValidation = False
        Me.Title_Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title_Label.ForeColor = System.Drawing.Color.White
        Me.Title_Label.Location = New System.Drawing.Point(0, 0)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Padding = New System.Windows.Forms.Padding(8, 4, 4, 4)
        Me.Title_Label.Rounded = False
        Me.Title_Label.Size = New System.Drawing.Size(827, 33)
        Me.Title_Label.TabIndex = 290
        Me.Title_Label.Text = "Output Data"
        Me.Title_Label.Tooltip = Nothing
        '
        'MaximizeButton
        '
        Me.MaximizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaximizeButton.FlatAppearance.BorderSize = 0
        Me.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaximizeButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeButton.ForeColor = System.Drawing.Color.White
        Me.MaximizeButton.Image = CType(resources.GetObject("MaximizeButton.Image"), System.Drawing.Image)
        Me.MaximizeButton.Location = New System.Drawing.Point(827, 0)
        Me.MaximizeButton.Name = "MaximizeButton"
        Me.MaximizeButton.Size = New System.Drawing.Size(33, 33)
        Me.MaximizeButton.TabIndex = 292
        Me.MaximizeButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.Location = New System.Drawing.Point(860, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(33, 33)
        Me.ExitButton.TabIndex = 291
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'anOutputDataGBox
        '
        Me.anOutputDataGBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.anOutputDataGBox.AsmDataByteCommand = ""
        Me.anOutputDataGBox.AsmDataWordCommand = ""
        Me.anOutputDataGBox.BASIClineInterval = 10
        Me.anOutputDataGBox.BASIClineNumber = 10000
        Me.anOutputDataGBox.BASICremoveZeros = False
        Me.anOutputDataGBox.Compress = mSXdevtools.GUI.Controls.DataTypeInputControl.COMPRESS_TYPE.RAW
        Me.anOutputDataGBox.EnableAssemblerIndex = False
        Me.anOutputDataGBox.EnableCompress = False
        Me.anOutputDataGBox.EnableDataSizeLine = False
        Me.anOutputDataGBox.Extension_dataType = Nothing
        Me.anOutputDataGBox.FieldName = "DATA"
        Me.anOutputDataGBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anOutputDataGBox.HasSign = False
        Me.anOutputDataGBox.LanguageCode = mSXdevtools.DataStructures.SourceCodeInfo.LANGUAGE_CODE.BASIC
        Me.anOutputDataGBox.LineSizeIndex = 6
        Me.anOutputDataGBox.Location = New System.Drawing.Point(12, 400)
        Me.anOutputDataGBox.MinimumSize = New System.Drawing.Size(600, 260)
        Me.anOutputDataGBox.Name = "anOutputDataGBox"
        Me.anOutputDataGBox.NumeralSystem = -1
        Me.anOutputDataGBox.OutputText = ""
        Me.anOutputDataGBox.Size = New System.Drawing.Size(869, 300)
        Me.anOutputDataGBox.Suffix_dataType = Nothing
        Me.anOutputDataGBox.TabIndex = 117
        '
        'MainForm
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(893, 712)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.WindowControlBarPanel)
        Me.Controls.Add(Me.PiXelGroupBox1)
        Me.Controls.Add(Me.anOutputDataGBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(909, 700)
        Me.Name = "MainForm"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PiXelGroupBox1.ResumeLayout(False)
        CType(Me.SignedRulerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DrawPanel.ResumeLayout(False)
        CType(Me.GFXoutputPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnsignedRulerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WindowControlBarPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents WaveLengthTextBox As pxTextBox
    Friend WithEvents WaveMaxTextBox As pxTextBox
    Friend WithEvents WaveMinTextBox As pxTextBox
    Friend WithEvents Label4 As pxLabel
    Friend WithEvents Label12 As pxLabel
    Friend WithEvents Label13 As pxLabel
    Friend WithEvents Label14 As pxLabel
    Friend WithEvents LabelPhase As pxLabel
    Friend WithEvents LabelFreq As pxLabel
    Friend WithEvents WaveTypeComboBox As pxComboBox
    Friend WithEvents GFXoutputPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents WavePhaseTrackBar As pxSlider
    Friend WithEvents PhaseTextBox As pxTextBox
    Friend WithEvents WaveMaxTrackBar As pxSlider
    Friend WithEvents RandomButton As pxButton
    Friend WithEvents WaveMinTrackBar As pxSlider
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LoadButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProjectNameTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Help_Button As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConfigButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProjectInfoButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents WaveFreqTrackBar As pxSlider
    Friend WithEvents WaveFreqTextBox As pxTextBox
    Friend WithEvents UnsignedRulerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents anOutputDataGBox As OutputDataGBox
    Friend WithEvents SaveAsButton As ToolStripButton
    Friend WithEvents PiXelGroupBox1 As pxGroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents DrawPanel As Panel
    Friend WithEvents SignComboBox As pxComboBox
    Friend WithEvents SignedRulerPictureBox As PictureBox
    Friend WithEvents Label1 As pxLabel
    Friend WithEvents WaveLengthTrackBar As pxSlider
    Friend WithEvents WindowControlBarPanel As Panel
    Friend WithEvents Title_Label As pxLabel
    Friend WithEvents MaximizeButton As Button
    Friend WithEvents ExitButton As Button
End Class
