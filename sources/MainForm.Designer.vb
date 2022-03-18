<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.OutputText = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.WaveLengthTextBox = New System.Windows.Forms.TextBox()
        Me.PhaseTextBox = New System.Windows.Forms.TextBox()
        Me.RandomButton = New System.Windows.Forms.Button()
        Me.FreqTextBox = New System.Windows.Forms.TextBox()
        Me.WaveMaxTextBox = New System.Windows.Forms.TextBox()
        Me.WaveMinTextBox = New System.Windows.Forms.TextBox()
        Me.CopyAllButton = New System.Windows.Forms.Button()
        Me.SaveBinaryFileButton = New System.Windows.Forms.Button()
        Me.SaveSourceButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.WaveFreqTrackBar = New System.Windows.Forms.TrackBar()
        Me.LabelFreq = New System.Windows.Forms.Label()
        Me.WavePhaseTrackBar = New System.Windows.Forms.TrackBar()
        Me.WaveMaxTrackBar = New System.Windows.Forms.TrackBar()
        Me.WaveMinTrackBar = New System.Windows.Forms.TrackBar()
        Me.LabelPhase = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.WaveTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.WaveLengthTrackBar = New System.Windows.Forms.TrackBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.LoadButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProjectNameTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ProjectInfoButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfigButton = New System.Windows.Forms.ToolStripButton()
        Me.Help_Button = New System.Windows.Forms.ToolStripButton()
        Me.AboutButton = New System.Windows.Forms.ToolStripButton()
        Me.waveform_Panel = New System.Windows.Forms.Panel()
        Me.GFXoutputPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RightLinePictureBox = New System.Windows.Forms.PictureBox()
        Me.LeftLinePictureBox = New System.Windows.Forms.PictureBox()
        Me.DownPictureBox = New System.Windows.Forms.PictureBox()
        Me.waveform_up_PictureBox = New System.Windows.Forms.PictureBox()
        Me.SaveoutputPanel = New System.Windows.Forms.Panel()
        Me.anOutputDataGBox = New ByteniZ3R.OutputDataGBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveFreqTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WavePhaseTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveMaxTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveMinTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveLengthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.waveform_Panel.SuspendLayout()
        CType(Me.GFXoutputPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightLinePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftLinePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DownPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.waveform_up_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaveoutputPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'OutputText
        '
        Me.OutputText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OutputText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OutputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutputText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputText.ForeColor = System.Drawing.Color.DimGray
        Me.OutputText.Location = New System.Drawing.Point(12, 490)
        Me.OutputText.Multiline = True
        Me.OutputText.Name = "OutputText"
        Me.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputText.Size = New System.Drawing.Size(762, 101)
        Me.OutputText.TabIndex = 0
        Me.OutputText.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'WaveLengthTextBox
        '
        Me.WaveLengthTextBox.Location = New System.Drawing.Point(272, 48)
        Me.WaveLengthTextBox.MaxLength = 5
        Me.WaveLengthTextBox.Name = "WaveLengthTextBox"
        Me.WaveLengthTextBox.Size = New System.Drawing.Size(44, 21)
        Me.WaveLengthTextBox.TabIndex = 4
        Me.WaveLengthTextBox.Text = "32"
        Me.WaveLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.WaveLengthTextBox, "Total of values (8 to 1024).")
        '
        'PhaseTextBox
        '
        Me.PhaseTextBox.Location = New System.Drawing.Point(283, 132)
        Me.PhaseTextBox.MaxLength = 3
        Me.PhaseTextBox.Name = "PhaseTextBox"
        Me.PhaseTextBox.Size = New System.Drawing.Size(33, 21)
        Me.PhaseTextBox.TabIndex = 10
        Me.PhaseTextBox.Text = "0"
        Me.PhaseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.PhaseTextBox, "Phase (0-359)")
        '
        'RandomButton
        '
        Me.RandomButton.BackColor = System.Drawing.Color.Gainsboro
        Me.RandomButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RandomButton.Location = New System.Drawing.Point(272, 20)
        Me.RandomButton.Name = "RandomButton"
        Me.RandomButton.Size = New System.Drawing.Size(44, 23)
        Me.RandomButton.TabIndex = 2
        Me.RandomButton.Text = "Rnd!"
        Me.ToolTip1.SetToolTip(Me.RandomButton, "Generate a new random data.")
        Me.RandomButton.UseVisualStyleBackColor = False
        '
        'FreqTextBox
        '
        Me.FreqTextBox.Location = New System.Drawing.Point(283, 160)
        Me.FreqTextBox.MaxLength = 3
        Me.FreqTextBox.Name = "FreqTextBox"
        Me.FreqTextBox.Size = New System.Drawing.Size(33, 21)
        Me.FreqTextBox.TabIndex = 12
        Me.FreqTextBox.Text = "0"
        Me.FreqTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.FreqTextBox, "Frequency (1-256)")
        '
        'WaveMaxTextBox
        '
        Me.WaveMaxTextBox.Location = New System.Drawing.Point(283, 103)
        Me.WaveMaxTextBox.MaxLength = 3
        Me.WaveMaxTextBox.Name = "WaveMaxTextBox"
        Me.WaveMaxTextBox.Size = New System.Drawing.Size(33, 21)
        Me.WaveMaxTextBox.TabIndex = 8
        Me.WaveMaxTextBox.Text = "0"
        Me.WaveMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.WaveMaxTextBox, "(0-255)")
        '
        'WaveMinTextBox
        '
        Me.WaveMinTextBox.Location = New System.Drawing.Point(283, 75)
        Me.WaveMinTextBox.MaxLength = 3
        Me.WaveMinTextBox.Name = "WaveMinTextBox"
        Me.WaveMinTextBox.Size = New System.Drawing.Size(33, 21)
        Me.WaveMinTextBox.TabIndex = 6
        Me.WaveMinTextBox.Text = "0"
        Me.WaveMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.WaveMinTextBox, "(0-255)")
        '
        'CopyAllButton
        '
        Me.CopyAllButton.BackColor = System.Drawing.Color.Transparent
        Me.CopyAllButton.FlatAppearance.BorderSize = 0
        Me.CopyAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyAllButton.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyAllButton.Image = Global.ByteniZ3R.My.Resources.Resources.button_CopyAll
        Me.CopyAllButton.Location = New System.Drawing.Point(180, 6)
        Me.CopyAllButton.Name = "CopyAllButton"
        Me.CopyAllButton.Size = New System.Drawing.Size(152, 38)
        Me.CopyAllButton.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.CopyAllButton, "Copy everything you see in the output to the clipboard.")
        Me.CopyAllButton.UseVisualStyleBackColor = False
        '
        'SaveBinaryFileButton
        '
        Me.SaveBinaryFileButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveBinaryFileButton.FlatAppearance.BorderSize = 0
        Me.SaveBinaryFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBinaryFileButton.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBinaryFileButton.Image = Global.ByteniZ3R.My.Resources.Resources.button_savebinary
        Me.SaveBinaryFileButton.Location = New System.Drawing.Point(548, 6)
        Me.SaveBinaryFileButton.Name = "SaveBinaryFileButton"
        Me.SaveBinaryFileButton.Size = New System.Drawing.Size(204, 38)
        Me.SaveBinaryFileButton.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.SaveBinaryFileButton, "Save binary file")
        Me.SaveBinaryFileButton.UseVisualStyleBackColor = False
        '
        'SaveSourceButton
        '
        Me.SaveSourceButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveSourceButton.FlatAppearance.BorderSize = 0
        Me.SaveSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveSourceButton.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveSourceButton.Image = Global.ByteniZ3R.My.Resources.Resources.button_savesource
        Me.SaveSourceButton.Location = New System.Drawing.Point(338, 6)
        Me.SaveSourceButton.Name = "SaveSourceButton"
        Me.SaveSourceButton.Size = New System.Drawing.Size(204, 38)
        Me.SaveSourceButton.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.SaveSourceButton, "Save output Source")
        Me.SaveSourceButton.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.ByteniZ3R.My.Resources.Resources.ByteniZ3R_logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(466, 42)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(311, 70)
        Me.LogoPictureBox.TabIndex = 115
        Me.LogoPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.LogoPictureBox, "Formerly known as BytesGen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The new name is due to a brain process of @Fubukimar" &
        "u")
        '
        'WaveFreqTrackBar
        '
        Me.WaveFreqTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.WaveFreqTrackBar.LargeChange = 8
        Me.WaveFreqTrackBar.Location = New System.Drawing.Point(83, 161)
        Me.WaveFreqTrackBar.Maximum = 256
        Me.WaveFreqTrackBar.Minimum = 1
        Me.WaveFreqTrackBar.Name = "WaveFreqTrackBar"
        Me.WaveFreqTrackBar.Size = New System.Drawing.Size(200, 45)
        Me.WaveFreqTrackBar.TabIndex = 11
        Me.WaveFreqTrackBar.TickFrequency = 32
        Me.WaveFreqTrackBar.Value = 1
        '
        'LabelFreq
        '
        Me.LabelFreq.Location = New System.Drawing.Point(8, 163)
        Me.LabelFreq.Name = "LabelFreq"
        Me.LabelFreq.Size = New System.Drawing.Size(80, 13)
        Me.LabelFreq.TabIndex = 33
        Me.LabelFreq.Text = "Frequency:"
        Me.LabelFreq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WavePhaseTrackBar
        '
        Me.WavePhaseTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.WavePhaseTrackBar.LargeChange = 15
        Me.WavePhaseTrackBar.Location = New System.Drawing.Point(83, 133)
        Me.WavePhaseTrackBar.Maximum = 359
        Me.WavePhaseTrackBar.Name = "WavePhaseTrackBar"
        Me.WavePhaseTrackBar.Size = New System.Drawing.Size(200, 45)
        Me.WavePhaseTrackBar.TabIndex = 9
        Me.WavePhaseTrackBar.TickFrequency = 45
        '
        'WaveMaxTrackBar
        '
        Me.WaveMaxTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.WaveMaxTrackBar.LargeChange = 8
        Me.WaveMaxTrackBar.Location = New System.Drawing.Point(83, 104)
        Me.WaveMaxTrackBar.Maximum = 255
        Me.WaveMaxTrackBar.Minimum = 1
        Me.WaveMaxTrackBar.Name = "WaveMaxTrackBar"
        Me.WaveMaxTrackBar.Size = New System.Drawing.Size(200, 45)
        Me.WaveMaxTrackBar.TabIndex = 7
        Me.WaveMaxTrackBar.TickFrequency = 32
        Me.WaveMaxTrackBar.Value = 1
        '
        'WaveMinTrackBar
        '
        Me.WaveMinTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.WaveMinTrackBar.LargeChange = 8
        Me.WaveMinTrackBar.Location = New System.Drawing.Point(83, 75)
        Me.WaveMinTrackBar.Maximum = 254
        Me.WaveMinTrackBar.Name = "WaveMinTrackBar"
        Me.WaveMinTrackBar.Size = New System.Drawing.Size(200, 45)
        Me.WaveMinTrackBar.TabIndex = 5
        Me.WaveMinTrackBar.TickFrequency = 32
        '
        'LabelPhase
        '
        Me.LabelPhase.Location = New System.Drawing.Point(8, 135)
        Me.LabelPhase.Name = "LabelPhase"
        Me.LabelPhase.Size = New System.Drawing.Size(80, 13)
        Me.LabelPhase.TabIndex = 30
        Me.LabelPhase.Text = "Phase:"
        Me.LabelPhase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Type:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WaveTypeComboBox
        '
        Me.WaveTypeComboBox.FormattingEnabled = True
        Me.WaveTypeComboBox.Items.AddRange(New Object() {"Sine", "Cosine", "Square", "Triangle", "Sawtooth", "Reverse Sawtooth", "Noise (Random)"})
        Me.WaveTypeComboBox.Location = New System.Drawing.Point(91, 21)
        Me.WaveTypeComboBox.Name = "WaveTypeComboBox"
        Me.WaveTypeComboBox.Size = New System.Drawing.Size(176, 21)
        Me.WaveTypeComboBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Length:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Min value:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Max value:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WaveLengthTrackBar
        '
        Me.WaveLengthTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.WaveLengthTrackBar.LargeChange = 8
        Me.WaveLengthTrackBar.Location = New System.Drawing.Point(83, 48)
        Me.WaveLengthTrackBar.Maximum = 1024
        Me.WaveLengthTrackBar.Name = "WaveLengthTrackBar"
        Me.WaveLengthTrackBar.Size = New System.Drawing.Size(194, 45)
        Me.WaveLengthTrackBar.TabIndex = 3
        Me.WaveLengthTrackBar.TickFrequency = 64
        Me.WaveLengthTrackBar.Value = 8
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.LoadButton, Me.SaveButton, Me.ToolStripSeparator2, Me.ProjectNameTextBox, Me.ProjectInfoButton, Me.ToolStripSeparator1, Me.ConfigButton, Me.Help_Button, Me.AboutButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 31)
        Me.ToolStrip1.TabIndex = 113
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewButton
        '
        Me.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewButton.Image = Global.ByteniZ3R.My.Resources.Resources.new_24
        Me.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(28, 28)
        Me.NewButton.Text = "ToolStripButton1"
        Me.NewButton.ToolTipText = "New Project"
        '
        'LoadButton
        '
        Me.LoadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LoadButton.Image = Global.ByteniZ3R.My.Resources.Resources.Load_file2_x24
        Me.LoadButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(28, 28)
        Me.LoadButton.Text = "ToolStripButton1"
        Me.LoadButton.ToolTipText = "Load Project"
        '
        'SaveButton
        '
        Me.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveButton.Image = Global.ByteniZ3R.My.Resources.Resources.save3_x24
        Me.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(28, 28)
        Me.SaveButton.Text = "ToolStripButton1"
        Me.SaveButton.ToolTipText = "Save Project"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ProjectNameTextBox
        '
        Me.ProjectNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProjectNameTextBox.Name = "ProjectNameTextBox"
        Me.ProjectNameTextBox.ReadOnly = True
        Me.ProjectNameTextBox.Size = New System.Drawing.Size(200, 31)
        '
        'ProjectInfoButton
        '
        Me.ProjectInfoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProjectInfoButton.Image = Global.ByteniZ3R.My.Resources.Resources.project_properties_24p
        Me.ProjectInfoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ProjectInfoButton.Name = "ProjectInfoButton"
        Me.ProjectInfoButton.Size = New System.Drawing.Size(28, 28)
        Me.ProjectInfoButton.Text = "ToolStripButton1"
        Me.ProjectInfoButton.ToolTipText = "Edit Project Info"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ConfigButton
        '
        Me.ConfigButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConfigButton.Image = Global.ByteniZ3R.My.Resources.Resources.config_x24
        Me.ConfigButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConfigButton.Name = "ConfigButton"
        Me.ConfigButton.Size = New System.Drawing.Size(28, 28)
        Me.ConfigButton.Text = "ToolStripButton1"
        Me.ConfigButton.ToolTipText = "Config devtools"
        '
        'Help_Button
        '
        Me.Help_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Help_Button.Enabled = False
        Me.Help_Button.Image = Global.ByteniZ3R.My.Resources.Resources.help_x24
        Me.Help_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Help_Button.Name = "Help_Button"
        Me.Help_Button.Size = New System.Drawing.Size(28, 28)
        Me.Help_Button.Text = "ToolStripButton1"
        Me.Help_Button.ToolTipText = "Help!"
        '
        'AboutButton
        '
        Me.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AboutButton.Image = Global.ByteniZ3R.My.Resources.Resources.about_24
        Me.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(28, 28)
        Me.AboutButton.Text = "ToolStripButton1"
        Me.AboutButton.ToolTipText = "About this Application"
        '
        'waveform_Panel
        '
        Me.waveform_Panel.Controls.Add(Me.GFXoutputPictureBox)
        Me.waveform_Panel.Controls.Add(Me.PictureBox2)
        Me.waveform_Panel.Controls.Add(Me.RightLinePictureBox)
        Me.waveform_Panel.Controls.Add(Me.LeftLinePictureBox)
        Me.waveform_Panel.Controls.Add(Me.Label13)
        Me.waveform_Panel.Controls.Add(Me.DownPictureBox)
        Me.waveform_Panel.Controls.Add(Me.FreqTextBox)
        Me.waveform_Panel.Controls.Add(Me.waveform_up_PictureBox)
        Me.waveform_Panel.Controls.Add(Me.WaveMinTextBox)
        Me.waveform_Panel.Controls.Add(Me.LabelFreq)
        Me.waveform_Panel.Controls.Add(Me.LabelPhase)
        Me.waveform_Panel.Controls.Add(Me.WaveMaxTextBox)
        Me.waveform_Panel.Controls.Add(Me.Label14)
        Me.waveform_Panel.Controls.Add(Me.RandomButton)
        Me.waveform_Panel.Controls.Add(Me.PhaseTextBox)
        Me.waveform_Panel.Controls.Add(Me.Label12)
        Me.waveform_Panel.Controls.Add(Me.WaveTypeComboBox)
        Me.waveform_Panel.Controls.Add(Me.WaveLengthTextBox)
        Me.waveform_Panel.Controls.Add(Me.Label4)
        Me.waveform_Panel.Controls.Add(Me.WaveFreqTrackBar)
        Me.waveform_Panel.Controls.Add(Me.WavePhaseTrackBar)
        Me.waveform_Panel.Controls.Add(Me.WaveMaxTrackBar)
        Me.waveform_Panel.Controls.Add(Me.WaveMinTrackBar)
        Me.waveform_Panel.Controls.Add(Me.WaveLengthTrackBar)
        Me.waveform_Panel.Location = New System.Drawing.Point(10, 118)
        Me.waveform_Panel.Name = "waveform_Panel"
        Me.waveform_Panel.Size = New System.Drawing.Size(766, 196)
        Me.waveform_Panel.TabIndex = 118
        '
        'GFXoutputPictureBox
        '
        Me.GFXoutputPictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GFXoutputPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.GFXoutputPictureBox.Location = New System.Drawing.Point(370, 23)
        Me.GFXoutputPictureBox.Name = "GFXoutputPictureBox"
        Me.GFXoutputPictureBox.Size = New System.Drawing.Size(380, 160)
        Me.GFXoutputPictureBox.TabIndex = 28
        Me.GFXoutputPictureBox.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.ByteniZ3R.My.Resources.Resources.display_ruler
        Me.PictureBox2.Location = New System.Drawing.Point(340, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 175)
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'RightLinePictureBox
        '
        Me.RightLinePictureBox.BackColor = System.Drawing.Color.Black
        Me.RightLinePictureBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightLinePictureBox.Location = New System.Drawing.Point(762, 14)
        Me.RightLinePictureBox.Name = "RightLinePictureBox"
        Me.RightLinePictureBox.Size = New System.Drawing.Size(4, 178)
        Me.RightLinePictureBox.TabIndex = 4
        Me.RightLinePictureBox.TabStop = False
        '
        'LeftLinePictureBox
        '
        Me.LeftLinePictureBox.BackColor = System.Drawing.Color.Black
        Me.LeftLinePictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftLinePictureBox.Location = New System.Drawing.Point(0, 14)
        Me.LeftLinePictureBox.Name = "LeftLinePictureBox"
        Me.LeftLinePictureBox.Size = New System.Drawing.Size(4, 178)
        Me.LeftLinePictureBox.TabIndex = 3
        Me.LeftLinePictureBox.TabStop = False
        '
        'DownPictureBox
        '
        Me.DownPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DownPictureBox.Image = Global.ByteniZ3R.My.Resources.Resources.piXel_panel_XL_down
        Me.DownPictureBox.Location = New System.Drawing.Point(0, 192)
        Me.DownPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.DownPictureBox.Name = "DownPictureBox"
        Me.DownPictureBox.Size = New System.Drawing.Size(766, 4)
        Me.DownPictureBox.TabIndex = 2
        Me.DownPictureBox.TabStop = False
        '
        'waveform_up_PictureBox
        '
        Me.waveform_up_PictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.waveform_up_PictureBox.Image = Global.ByteniZ3R.My.Resources.Resources.piXel_panel_XL_up_waveform
        Me.waveform_up_PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.waveform_up_PictureBox.Name = "waveform_up_PictureBox"
        Me.waveform_up_PictureBox.Size = New System.Drawing.Size(766, 14)
        Me.waveform_up_PictureBox.TabIndex = 0
        Me.waveform_up_PictureBox.TabStop = False
        '
        'SaveoutputPanel
        '
        Me.SaveoutputPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaveoutputPanel.BackColor = System.Drawing.Color.Transparent
        Me.SaveoutputPanel.BackgroundImage = Global.ByteniZ3R.My.Resources.Resources.piXel_pane_XL
        Me.SaveoutputPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SaveoutputPanel.Controls.Add(Me.CopyAllButton)
        Me.SaveoutputPanel.Controls.Add(Me.SaveBinaryFileButton)
        Me.SaveoutputPanel.Controls.Add(Me.SaveSourceButton)
        Me.SaveoutputPanel.Location = New System.Drawing.Point(10, 599)
        Me.SaveoutputPanel.Name = "SaveoutputPanel"
        Me.SaveoutputPanel.Size = New System.Drawing.Size(767, 52)
        Me.SaveoutputPanel.TabIndex = 116
        '
        'anOutputDataGBox
        '
        Me.anOutputDataGBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anOutputDataGBox.Location = New System.Drawing.Point(10, 331)
        Me.anOutputDataGBox.Name = "anOutputDataGBox"
        Me.anOutputDataGBox.Size = New System.Drawing.Size(766, 153)
        Me.anOutputDataGBox.TabIndex = 117
        '
        'MainForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.waveform_Panel)
        Me.Controls.Add(Me.anOutputDataGBox)
        Me.Controls.Add(Me.SaveoutputPanel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.OutputText)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 39)
        Me.Name = "MainForm"
        Me.Text = "ByteniZ3R"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveFreqTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WavePhaseTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveMaxTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveMinTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveLengthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.waveform_Panel.ResumeLayout(False)
        Me.waveform_Panel.PerformLayout()
        CType(Me.GFXoutputPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightLinePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftLinePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DownPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.waveform_up_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaveoutputPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OutputText As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WaveLengthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents WaveMaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WaveMinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents WaveTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GFXoutputPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents WavePhaseTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents LabelPhase As System.Windows.Forms.Label
    Friend WithEvents PhaseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WaveMaxTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents RandomButton As System.Windows.Forms.Button
    Friend WithEvents WaveMinTrackBar As System.Windows.Forms.TrackBar
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
    Friend WithEvents WaveFreqTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents FreqTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LabelFreq As System.Windows.Forms.Label
    Friend WithEvents WaveLengthTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents SaveoutputPanel As Panel
    Friend WithEvents CopyAllButton As Button
    Friend WithEvents SaveBinaryFileButton As Button
    Friend WithEvents SaveSourceButton As Button
    Friend WithEvents anOutputDataGBox As OutputDataGBox
    Friend WithEvents waveform_Panel As Panel
    Friend WithEvents waveform_up_PictureBox As PictureBox
    Friend WithEvents DownPictureBox As PictureBox
    Friend WithEvents LeftLinePictureBox As PictureBox
    Friend WithEvents RightLinePictureBox As PictureBox
End Class
