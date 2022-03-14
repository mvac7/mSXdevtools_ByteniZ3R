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
        Me.LabelTextBox = New System.Windows.Forms.TextBox()
        Me.LabelLabel = New System.Windows.Forms.Label()
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
        Me.OutputDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.DataTypeInput = New ByteniZ3R.DataTypeInputControl()
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
        Me.ConfigButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Help_Button = New System.Windows.Forms.ToolStripButton()
        Me.AboutButton1 = New System.Windows.Forms.ToolStripButton()
        Me.WaveformGroupBox = New System.Windows.Forms.GroupBox()
        Me.GFXoutputPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel05 = New System.Windows.Forms.Panel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.OutputDataGroupBox.SuspendLayout()
        CType(Me.WaveFreqTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WavePhaseTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveMaxTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveMinTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveLengthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.WaveformGroupBox.SuspendLayout()
        CType(Me.GFXoutputPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel05.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OutputText
        '
        Me.OutputText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputText.Location = New System.Drawing.Point(12, 470)
        Me.OutputText.Multiline = True
        Me.OutputText.Name = "OutputText"
        Me.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputText.Size = New System.Drawing.Size(757, 101)
        Me.OutputText.TabIndex = 48
        '
        'LabelTextBox
        '
        Me.LabelTextBox.Location = New System.Drawing.Point(605, 20)
        Me.LabelTextBox.Name = "LabelTextBox"
        Me.LabelTextBox.Size = New System.Drawing.Size(140, 21)
        Me.LabelTextBox.TabIndex = 46
        Me.LabelTextBox.Text = "DATA"
        '
        'LabelLabel
        '
        Me.LabelLabel.Location = New System.Drawing.Point(506, 19)
        Me.LabelLabel.Name = "LabelLabel"
        Me.LabelLabel.Size = New System.Drawing.Size(93, 21)
        Me.LabelLabel.TabIndex = 9
        Me.LabelLabel.Text = "Field name:"
        Me.LabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'WaveLengthTextBox
        '
        Me.WaveLengthTextBox.Location = New System.Drawing.Point(271, 47)
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
        Me.PhaseTextBox.Location = New System.Drawing.Point(282, 131)
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
        Me.RandomButton.Location = New System.Drawing.Point(271, 19)
        Me.RandomButton.Name = "RandomButton"
        Me.RandomButton.Size = New System.Drawing.Size(44, 23)
        Me.RandomButton.TabIndex = 2
        Me.RandomButton.Text = "Rnd!"
        Me.ToolTip1.SetToolTip(Me.RandomButton, "Generate a new random data.")
        Me.RandomButton.UseVisualStyleBackColor = False
        '
        'FreqTextBox
        '
        Me.FreqTextBox.Location = New System.Drawing.Point(282, 159)
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
        Me.WaveMaxTextBox.Location = New System.Drawing.Point(282, 102)
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
        Me.WaveMinTextBox.Location = New System.Drawing.Point(282, 74)
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
        'OutputDataGroupBox
        '
        Me.OutputDataGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputDataGroupBox.Controls.Add(Me.DataTypeInput)
        Me.OutputDataGroupBox.Controls.Add(Me.LabelTextBox)
        Me.OutputDataGroupBox.Controls.Add(Me.LabelLabel)
        Me.OutputDataGroupBox.Location = New System.Drawing.Point(12, 331)
        Me.OutputDataGroupBox.Name = "OutputDataGroupBox"
        Me.OutputDataGroupBox.Size = New System.Drawing.Size(757, 133)
        Me.OutputDataGroupBox.TabIndex = 22
        Me.OutputDataGroupBox.TabStop = False
        Me.OutputDataGroupBox.Text = "Output Data"
        '
        'DataTypeInput
        '
        Me.DataTypeInput.BackColor = System.Drawing.Color.Transparent
        Me.DataTypeInput.EnableDataSizeLine = False
        Me.DataTypeInput.Location = New System.Drawing.Point(6, 16)
        Me.DataTypeInput.Name = "DataTypeInput"
        Me.DataTypeInput.Size = New System.Drawing.Size(486, 110)
        Me.DataTypeInput.SizesForColors = False
        Me.DataTypeInput.TabIndex = 65
        '
        'WaveFreqTrackBar
        '
        Me.WaveFreqTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.WaveFreqTrackBar.LargeChange = 8
        Me.WaveFreqTrackBar.Location = New System.Drawing.Point(82, 160)
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
        Me.LabelFreq.Location = New System.Drawing.Point(7, 162)
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
        Me.WavePhaseTrackBar.Location = New System.Drawing.Point(82, 132)
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
        Me.WaveMaxTrackBar.Location = New System.Drawing.Point(82, 103)
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
        Me.WaveMinTrackBar.Location = New System.Drawing.Point(82, 74)
        Me.WaveMinTrackBar.Maximum = 254
        Me.WaveMinTrackBar.Name = "WaveMinTrackBar"
        Me.WaveMinTrackBar.Size = New System.Drawing.Size(200, 45)
        Me.WaveMinTrackBar.TabIndex = 5
        Me.WaveMinTrackBar.TickFrequency = 32
        '
        'LabelPhase
        '
        Me.LabelPhase.Location = New System.Drawing.Point(7, 134)
        Me.LabelPhase.Name = "LabelPhase"
        Me.LabelPhase.Size = New System.Drawing.Size(80, 13)
        Me.LabelPhase.TabIndex = 30
        Me.LabelPhase.Text = "Phase:"
        Me.LabelPhase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(7, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Type:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WaveTypeComboBox
        '
        Me.WaveTypeComboBox.FormattingEnabled = True
        Me.WaveTypeComboBox.Items.AddRange(New Object() {"Sine", "Cosine", "Square", "Triangle", "Sawtooth", "Noise (Random)"})
        Me.WaveTypeComboBox.Location = New System.Drawing.Point(90, 20)
        Me.WaveTypeComboBox.Name = "WaveTypeComboBox"
        Me.WaveTypeComboBox.Size = New System.Drawing.Size(176, 21)
        Me.WaveTypeComboBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Length:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(7, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Min value:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(7, 105)
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
        Me.WaveLengthTrackBar.Location = New System.Drawing.Point(82, 47)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.LoadButton, Me.SaveButton, Me.ToolStripSeparator2, Me.ProjectNameTextBox, Me.ProjectInfoButton, Me.ToolStripSeparator1, Me.ConfigButton1, Me.Help_Button, Me.AboutButton1})
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
        'ConfigButton1
        '
        Me.ConfigButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConfigButton1.Image = Global.ByteniZ3R.My.Resources.Resources.config_x24
        Me.ConfigButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConfigButton1.Name = "ConfigButton1"
        Me.ConfigButton1.Size = New System.Drawing.Size(28, 28)
        Me.ConfigButton1.Text = "ToolStripButton1"
        Me.ConfigButton1.ToolTipText = "Config"
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
        'AboutButton1
        '
        Me.AboutButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AboutButton1.Image = Global.ByteniZ3R.My.Resources.Resources.about_24
        Me.AboutButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AboutButton1.Name = "AboutButton1"
        Me.AboutButton1.Size = New System.Drawing.Size(28, 28)
        Me.AboutButton1.Text = "ToolStripButton1"
        Me.AboutButton1.ToolTipText = "About this Application"
        '
        'WaveformGroupBox
        '
        Me.WaveformGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WaveformGroupBox.Controls.Add(Me.GFXoutputPictureBox)
        Me.WaveformGroupBox.Controls.Add(Me.PictureBox2)
        Me.WaveformGroupBox.Controls.Add(Me.WaveFreqTrackBar)
        Me.WaveformGroupBox.Controls.Add(Me.Label13)
        Me.WaveformGroupBox.Controls.Add(Me.FreqTextBox)
        Me.WaveformGroupBox.Controls.Add(Me.WaveMinTextBox)
        Me.WaveformGroupBox.Controls.Add(Me.LabelFreq)
        Me.WaveformGroupBox.Controls.Add(Me.WaveMaxTextBox)
        Me.WaveformGroupBox.Controls.Add(Me.RandomButton)
        Me.WaveformGroupBox.Controls.Add(Me.Label12)
        Me.WaveformGroupBox.Controls.Add(Me.WavePhaseTrackBar)
        Me.WaveformGroupBox.Controls.Add(Me.WaveLengthTextBox)
        Me.WaveformGroupBox.Controls.Add(Me.WaveMaxTrackBar)
        Me.WaveformGroupBox.Controls.Add(Me.Label4)
        Me.WaveformGroupBox.Controls.Add(Me.WaveMinTrackBar)
        Me.WaveformGroupBox.Controls.Add(Me.WaveTypeComboBox)
        Me.WaveformGroupBox.Controls.Add(Me.PhaseTextBox)
        Me.WaveformGroupBox.Controls.Add(Me.Label14)
        Me.WaveformGroupBox.Controls.Add(Me.LabelPhase)
        Me.WaveformGroupBox.Controls.Add(Me.WaveLengthTrackBar)
        Me.WaveformGroupBox.Location = New System.Drawing.Point(14, 114)
        Me.WaveformGroupBox.Name = "WaveformGroupBox"
        Me.WaveformGroupBox.Size = New System.Drawing.Size(755, 211)
        Me.WaveformGroupBox.TabIndex = 114
        Me.WaveformGroupBox.TabStop = False
        Me.WaveformGroupBox.Text = "Waveform"
        '
        'GFXoutputPictureBox
        '
        Me.GFXoutputPictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GFXoutputPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.GFXoutputPictureBox.Location = New System.Drawing.Point(356, 20)
        Me.GFXoutputPictureBox.Name = "GFXoutputPictureBox"
        Me.GFXoutputPictureBox.Size = New System.Drawing.Size(380, 160)
        Me.GFXoutputPictureBox.TabIndex = 28
        Me.GFXoutputPictureBox.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.ByteniZ3R.My.Resources.Resources.display_ruler
        Me.PictureBox2.Location = New System.Drawing.Point(326, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 175)
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'Panel05
        '
        Me.Panel05.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel05.BackColor = System.Drawing.Color.Transparent
        Me.Panel05.BackgroundImage = Global.ByteniZ3R.My.Resources.Resources.piXel_pane_XL
        Me.Panel05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel05.Controls.Add(Me.CopyAllButton)
        Me.Panel05.Controls.Add(Me.SaveBinaryFileButton)
        Me.Panel05.Controls.Add(Me.SaveSourceButton)
        Me.Panel05.Location = New System.Drawing.Point(10, 579)
        Me.Panel05.Name = "Panel05"
        Me.Panel05.Size = New System.Drawing.Size(767, 52)
        Me.Panel05.TabIndex = 116
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoPictureBox.Image = Global.ByteniZ3R.My.Resources.Resources.ByteniZ3R_logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(466, 42)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(311, 70)
        Me.LogoPictureBox.TabIndex = 115
        Me.LogoPictureBox.TabStop = False
        '
        'MainForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(784, 641)
        Me.Controls.Add(Me.Panel05)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.WaveformGroupBox)
        Me.Controls.Add(Me.OutputText)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.OutputDataGroupBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 640)
        Me.Name = "MainForm"
        Me.Text = "ByteniZ3R"
        Me.OutputDataGroupBox.ResumeLayout(False)
        Me.OutputDataGroupBox.PerformLayout()
        CType(Me.WaveFreqTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WavePhaseTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveMaxTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveMinTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveLengthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.WaveformGroupBox.ResumeLayout(False)
        Me.WaveformGroupBox.PerformLayout()
        CType(Me.GFXoutputPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel05.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OutputText As System.Windows.Forms.TextBox
    Friend WithEvents LabelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LabelLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OutputDataGroupBox As System.Windows.Forms.GroupBox
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
    Friend WithEvents AboutButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Help_Button As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConfigButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProjectInfoButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents WaveFreqTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents FreqTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LabelFreq As System.Windows.Forms.Label
    Friend WithEvents WaveLengthTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DataTypeInput As ByteniZ3R.DataTypeInputControl
    Friend WithEvents WaveformGroupBox As GroupBox
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents Panel05 As Panel
    Friend WithEvents CopyAllButton As Button
    Friend WithEvents SaveBinaryFileButton As Button
    Friend WithEvents SaveSourceButton As Button
End Class
