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
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.LabelTextBox = New System.Windows.Forms.TextBox()
        Me.LabelLabel = New System.Windows.Forms.Label()
        Me.CopyAllButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.WaveLengthTextBox = New System.Windows.Forms.TextBox()
        Me.PhaseTextBox = New System.Windows.Forms.TextBox()
        Me.RandomButton = New System.Windows.Forms.Button()
        Me.FileLengthTextBox = New System.Windows.Forms.TextBox()
        Me.FreqTextBox = New System.Windows.Forms.TextBox()
        Me.WaveMaxTextBox = New System.Windows.Forms.TextBox()
        Me.WaveMinTextBox = New System.Windows.Forms.TextBox()
        Me.BinaryFillValueTextBox = New System.Windows.Forms.TextBox()
        Me.BinaryLengthTextBox = New System.Windows.Forms.TextBox()
        Me.BinaryInitTextBox = New System.Windows.Forms.TextBox()
        Me.BinaryNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataTypeInput = New ByteniZ3R.DataTypeInputControl()
        Me.ToolTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.aHexDump = New ByteniZ3R.HexDump()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkipLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProjectNameTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.LoadButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveButton = New System.Windows.Forms.ToolStripButton()
        Me.ProjectInfoButton = New System.Windows.Forms.ToolStripButton()
        Me.ConfigButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Help_Button = New System.Windows.Forms.ToolStripButton()
        Me.AboutButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GFXoutputPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SelectBinaryButton = New System.Windows.Forms.Button()
        Me.SavebinButton = New System.Windows.Forms.Button()
        Me.SaveAsButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.ToolTabControl.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.WaveFreqTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WavePhaseTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveMaxTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveMinTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveLengthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GFXoutputPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OutputText
        '
        Me.OutputText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputText.Location = New System.Drawing.Point(9, 154)
        Me.OutputText.Multiline = True
        Me.OutputText.Name = "OutputText"
        Me.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputText.Size = New System.Drawing.Size(637, 133)
        Me.OutputText.TabIndex = 48
        '
        'GenerateButton
        '
        Me.GenerateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GenerateButton.BackColor = System.Drawing.Color.LightGreen
        Me.GenerateButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateButton.Location = New System.Drawing.Point(9, 293)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(111, 31)
        Me.GenerateButton.TabIndex = 60
        Me.GenerateButton.Text = "Get Data!"
        Me.ToolTip1.SetToolTip(Me.GenerateButton, "Get data.")
        Me.GenerateButton.UseVisualStyleBackColor = False
        '
        'LabelTextBox
        '
        Me.LabelTextBox.Location = New System.Drawing.Point(118, 127)
        Me.LabelTextBox.Name = "LabelTextBox"
        Me.LabelTextBox.Size = New System.Drawing.Size(141, 21)
        Me.LabelTextBox.TabIndex = 46
        Me.LabelTextBox.Text = "DATA"
        '
        'LabelLabel
        '
        Me.LabelLabel.Location = New System.Drawing.Point(35, 130)
        Me.LabelLabel.Name = "LabelLabel"
        Me.LabelLabel.Size = New System.Drawing.Size(80, 13)
        Me.LabelLabel.TabIndex = 9
        Me.LabelLabel.Text = "Field name:"
        Me.LabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CopyAllButton
        '
        Me.CopyAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyAllButton.BackColor = System.Drawing.Color.LightGray
        Me.CopyAllButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyAllButton.Location = New System.Drawing.Point(539, 293)
        Me.CopyAllButton.Name = "CopyAllButton"
        Me.CopyAllButton.Size = New System.Drawing.Size(107, 31)
        Me.CopyAllButton.TabIndex = 64
        Me.CopyAllButton.Text = "Copy All"
        Me.ToolTip1.SetToolTip(Me.CopyAllButton, "Copy all output text " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to clipboard.")
        Me.CopyAllButton.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.BackColor = System.Drawing.Color.LightSalmon
        Me.ClearButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(126, 293)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(77, 31)
        Me.ClearButton.TabIndex = 61
        Me.ClearButton.Text = "Clear!"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear output text.")
        Me.ClearButton.UseVisualStyleBackColor = False
        Me.ClearButton.Visible = False
        '
        'WaveLengthTextBox
        '
        Me.WaveLengthTextBox.Location = New System.Drawing.Point(272, 40)
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
        Me.PhaseTextBox.Location = New System.Drawing.Point(283, 124)
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
        Me.RandomButton.Location = New System.Drawing.Point(272, 12)
        Me.RandomButton.Name = "RandomButton"
        Me.RandomButton.Size = New System.Drawing.Size(44, 22)
        Me.RandomButton.TabIndex = 2
        Me.RandomButton.Text = "Rnd!"
        Me.ToolTip1.SetToolTip(Me.RandomButton, "Generate a new random data.")
        Me.RandomButton.UseVisualStyleBackColor = False
        '
        'FileLengthTextBox
        '
        Me.FileLengthTextBox.Location = New System.Drawing.Point(430, 13)
        Me.FileLengthTextBox.MaxLength = 3
        Me.FileLengthTextBox.Name = "FileLengthTextBox"
        Me.FileLengthTextBox.ReadOnly = True
        Me.FileLengthTextBox.Size = New System.Drawing.Size(63, 21)
        Me.FileLengthTextBox.TabIndex = 23
        Me.FileLengthTextBox.TabStop = False
        Me.FileLengthTextBox.Text = "0"
        Me.FileLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.FileLengthTextBox, "File length.")
        '
        'FreqTextBox
        '
        Me.FreqTextBox.Location = New System.Drawing.Point(283, 152)
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
        Me.WaveMaxTextBox.Location = New System.Drawing.Point(283, 95)
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
        Me.WaveMinTextBox.Location = New System.Drawing.Point(283, 67)
        Me.WaveMinTextBox.MaxLength = 3
        Me.WaveMinTextBox.Name = "WaveMinTextBox"
        Me.WaveMinTextBox.Size = New System.Drawing.Size(33, 21)
        Me.WaveMinTextBox.TabIndex = 6
        Me.WaveMinTextBox.Text = "0"
        Me.WaveMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.WaveMinTextBox, "(0-255)")
        '
        'BinaryFillValueTextBox
        '
        Me.BinaryFillValueTextBox.Location = New System.Drawing.Point(397, 40)
        Me.BinaryFillValueTextBox.MaxLength = 3
        Me.BinaryFillValueTextBox.Name = "BinaryFillValueTextBox"
        Me.BinaryFillValueTextBox.Size = New System.Drawing.Size(33, 21)
        Me.BinaryFillValueTextBox.TabIndex = 27
        Me.BinaryFillValueTextBox.Text = "255"
        Me.BinaryFillValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.BinaryFillValueTextBox, "Fill value if the size is larger " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "than containing the file. (decimal)")
        '
        'BinaryLengthTextBox
        '
        Me.BinaryLengthTextBox.Location = New System.Drawing.Point(256, 40)
        Me.BinaryLengthTextBox.MaxLength = 5
        Me.BinaryLengthTextBox.Name = "BinaryLengthTextBox"
        Me.BinaryLengthTextBox.Size = New System.Drawing.Size(60, 21)
        Me.BinaryLengthTextBox.TabIndex = 25
        Me.BinaryLengthTextBox.Text = "0"
        Me.BinaryLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.BinaryLengthTextBox, "File size (max 65536) ")
        '
        'BinaryInitTextBox
        '
        Me.BinaryInitTextBox.Location = New System.Drawing.Point(97, 40)
        Me.BinaryInitTextBox.MaxLength = 4
        Me.BinaryInitTextBox.Name = "BinaryInitTextBox"
        Me.BinaryInitTextBox.Size = New System.Drawing.Size(50, 21)
        Me.BinaryInitTextBox.TabIndex = 22
        Me.BinaryInitTextBox.Text = "0"
        Me.BinaryInitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.BinaryInitTextBox, "(0-1024)")
        '
        'BinaryNameTextBox
        '
        Me.BinaryNameTextBox.AllowDrop = True
        Me.BinaryNameTextBox.Location = New System.Drawing.Point(97, 13)
        Me.BinaryNameTextBox.Name = "BinaryNameTextBox"
        Me.BinaryNameTextBox.Size = New System.Drawing.Size(296, 21)
        Me.BinaryNameTextBox.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.BinaryNameTextBox, "Files that do not exceed 64k in size.")
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataTypeInput)
        Me.GroupBox1.Controls.Add(Me.SavebinButton)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.SaveAsButton)
        Me.GroupBox1.Controls.Add(Me.CopyAllButton)
        Me.GroupBox1.Controls.Add(Me.OutputText)
        Me.GroupBox1.Controls.Add(Me.LabelTextBox)
        Me.GroupBox1.Controls.Add(Me.LabelLabel)
        Me.GroupBox1.Controls.Add(Me.GenerateButton)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 330)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Output Data"
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
        'ToolTabControl
        '
        Me.ToolTabControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolTabControl.Controls.Add(Me.TabPage3)
        Me.ToolTabControl.Controls.Add(Me.TabPage2)
        Me.ToolTabControl.Location = New System.Drawing.Point(14, 34)
        Me.ToolTabControl.Name = "ToolTabControl"
        Me.ToolTabControl.SelectedIndex = 0
        Me.ToolTabControl.Size = New System.Drawing.Size(655, 216)
        Me.ToolTabControl.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage3.Controls.Add(Me.GFXoutputPictureBox)
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Controls.Add(Me.WaveFreqTrackBar)
        Me.TabPage3.Controls.Add(Me.FreqTextBox)
        Me.TabPage3.Controls.Add(Me.LabelFreq)
        Me.TabPage3.Controls.Add(Me.RandomButton)
        Me.TabPage3.Controls.Add(Me.WavePhaseTrackBar)
        Me.TabPage3.Controls.Add(Me.WaveMaxTrackBar)
        Me.TabPage3.Controls.Add(Me.WaveMinTrackBar)
        Me.TabPage3.Controls.Add(Me.PhaseTextBox)
        Me.TabPage3.Controls.Add(Me.LabelPhase)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.WaveTypeComboBox)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.WaveLengthTextBox)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.WaveMaxTextBox)
        Me.TabPage3.Controls.Add(Me.WaveMinTextBox)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.WaveLengthTrackBar)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(647, 190)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Waveform"
        '
        'WaveFreqTrackBar
        '
        Me.WaveFreqTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.WaveFreqTrackBar.LargeChange = 8
        Me.WaveFreqTrackBar.Location = New System.Drawing.Point(83, 153)
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
        Me.LabelFreq.Location = New System.Drawing.Point(8, 155)
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
        Me.WavePhaseTrackBar.Location = New System.Drawing.Point(83, 125)
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
        Me.WaveMaxTrackBar.Location = New System.Drawing.Point(83, 96)
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
        Me.WaveMinTrackBar.Location = New System.Drawing.Point(83, 67)
        Me.WaveMinTrackBar.Maximum = 254
        Me.WaveMinTrackBar.Name = "WaveMinTrackBar"
        Me.WaveMinTrackBar.Size = New System.Drawing.Size(200, 45)
        Me.WaveMinTrackBar.TabIndex = 5
        Me.WaveMinTrackBar.TickFrequency = 32
        '
        'LabelPhase
        '
        Me.LabelPhase.Location = New System.Drawing.Point(8, 127)
        Me.LabelPhase.Name = "LabelPhase"
        Me.LabelPhase.Size = New System.Drawing.Size(80, 13)
        Me.LabelPhase.TabIndex = 30
        Me.LabelPhase.Text = "Phase:"
        Me.LabelPhase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 16)
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
        Me.WaveTypeComboBox.Location = New System.Drawing.Point(91, 13)
        Me.WaveTypeComboBox.Name = "WaveTypeComboBox"
        Me.WaveTypeComboBox.Size = New System.Drawing.Size(176, 21)
        Me.WaveTypeComboBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Length:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Min value:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 98)
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
        Me.WaveLengthTrackBar.Location = New System.Drawing.Point(83, 40)
        Me.WaveLengthTrackBar.Maximum = 1024
        Me.WaveLengthTrackBar.Name = "WaveLengthTrackBar"
        Me.WaveLengthTrackBar.Size = New System.Drawing.Size(194, 45)
        Me.WaveLengthTrackBar.TabIndex = 3
        Me.WaveLengthTrackBar.TickFrequency = 64
        Me.WaveLengthTrackBar.Value = 8
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage2.Controls.Add(Me.aHexDump)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.BinaryFillValueTextBox)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.BinaryLengthTextBox)
        Me.TabPage2.Controls.Add(Me.FileLengthTextBox)
        Me.TabPage2.Controls.Add(Me.SkipLabel)
        Me.TabPage2.Controls.Add(Me.BinaryInitTextBox)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.BinaryNameTextBox)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.SelectBinaryButton)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(647, 190)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Binary File"
        '
        'aHexDump
        '
        Me.aHexDump.Location = New System.Drawing.Point(66, 81)
        Me.aHexDump.Name = "aHexDump"
        Me.aHexDump.Size = New System.Drawing.Size(550, 91)
        Me.aHexDump.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(322, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Fill value:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(181, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Length:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SkipLabel
        '
        Me.SkipLabel.Location = New System.Drawing.Point(8, 43)
        Me.SkipLabel.Name = "SkipLabel"
        Me.SkipLabel.Size = New System.Drawing.Size(86, 13)
        Me.SkipLabel.TabIndex = 21
        Me.SkipLabel.Text = "Init:"
        Me.SkipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "File:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.ToolStrip1.Size = New System.Drawing.Size(684, 31)
        Me.ToolStrip1.TabIndex = 113
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
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
        'GFXoutputPictureBox
        '
        Me.GFXoutputPictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GFXoutputPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.GFXoutputPictureBox.Location = New System.Drawing.Point(357, 13)
        Me.GFXoutputPictureBox.Name = "GFXoutputPictureBox"
        Me.GFXoutputPictureBox.Size = New System.Drawing.Size(280, 160)
        Me.GFXoutputPictureBox.TabIndex = 28
        Me.GFXoutputPictureBox.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.ByteniZ3R.My.Resources.Resources.display_ruler
        Me.PictureBox2.Location = New System.Drawing.Point(327, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 175)
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ByteniZ3R.My.Resources.Resources.info_blue_16
        Me.PictureBox1.Location = New System.Drawing.Point(153, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Remove n bytes from header. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Example: 7 for MSX Basic binary files)")
        '
        'SelectBinaryButton
        '
        Me.SelectBinaryButton.BackColor = System.Drawing.Color.Gainsboro
        Me.SelectBinaryButton.Image = Global.ByteniZ3R.My.Resources.Resources.load2_x16
        Me.SelectBinaryButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SelectBinaryButton.Location = New System.Drawing.Point(396, 12)
        Me.SelectBinaryButton.Name = "SelectBinaryButton"
        Me.SelectBinaryButton.Size = New System.Drawing.Size(28, 23)
        Me.SelectBinaryButton.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.SelectBinaryButton, "Load binary file.")
        Me.SelectBinaryButton.UseVisualStyleBackColor = False
        '
        'SavebinButton
        '
        Me.SavebinButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SavebinButton.BackColor = System.Drawing.Color.LightGray
        Me.SavebinButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavebinButton.Image = Global.ByteniZ3R.My.Resources.Resources.save3_x24
        Me.SavebinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SavebinButton.Location = New System.Drawing.Point(313, 293)
        Me.SavebinButton.Name = "SavebinButton"
        Me.SavebinButton.Padding = New System.Windows.Forms.Padding(2, 5, 3, 3)
        Me.SavebinButton.Size = New System.Drawing.Size(107, 31)
        Me.SavebinButton.TabIndex = 62
        Me.SavebinButton.Text = "Save BIN"
        Me.SavebinButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.SavebinButton, "Save data to binary file.")
        Me.SavebinButton.UseVisualStyleBackColor = False
        '
        'SaveAsButton
        '
        Me.SaveAsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveAsButton.BackColor = System.Drawing.Color.LightGray
        Me.SaveAsButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAsButton.Image = Global.ByteniZ3R.My.Resources.Resources.save3_x24
        Me.SaveAsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveAsButton.Location = New System.Drawing.Point(426, 293)
        Me.SaveAsButton.Name = "SaveAsButton"
        Me.SaveAsButton.Padding = New System.Windows.Forms.Padding(2, 5, 3, 3)
        Me.SaveAsButton.Size = New System.Drawing.Size(107, 31)
        Me.SaveAsButton.TabIndex = 63
        Me.SaveAsButton.Text = "Save TXT"
        Me.SaveAsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.SaveAsButton, "Save output to TXT file.")
        Me.SaveAsButton.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AcceptButton = Me.GenerateButton
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(684, 602)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ToolTabControl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 600)
        Me.Name = "MainForm"
        Me.Text = "Bytes Gen!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolTabControl.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.WaveFreqTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WavePhaseTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveMaxTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveMinTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveLengthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GFXoutputPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OutputText As System.Windows.Forms.TextBox
    Friend WithEvents GenerateButton As System.Windows.Forms.Button
    Friend WithEvents LabelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LabelLabel As System.Windows.Forms.Label
    Friend WithEvents CopyAllButton As System.Windows.Forms.Button
    Friend WithEvents SaveAsButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SelectBinaryButton As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BinaryNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SkipLabel As System.Windows.Forms.Label
    Friend WithEvents BinaryInitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WaveLengthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents WaveMaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WaveMinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents WaveTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents GFXoutputPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents WavePhaseTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents LabelPhase As System.Windows.Forms.Label
    Friend WithEvents PhaseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WaveMaxTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents SavebinButton As System.Windows.Forms.Button
    Friend WithEvents RandomButton As System.Windows.Forms.Button
    Friend WithEvents FileLengthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WaveMinTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BinaryFillValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BinaryLengthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents aHexDump As ByteniZ3R.HexDump
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

End Class
