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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.PiXelGroupBox1 = New ByteniZ3R.piXelGroupBox()
        Me.DrawPanel = New System.Windows.Forms.Panel()
        Me.GFXoutputPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.WaveLengthTrackBar = New System.Windows.Forms.TrackBar()
        Me.FreqTextBox = New System.Windows.Forms.TextBox()
        Me.WaveMinTrackBar = New System.Windows.Forms.TrackBar()
        Me.WaveMaxTrackBar = New System.Windows.Forms.TrackBar()
        Me.WaveMinTextBox = New System.Windows.Forms.TextBox()
        Me.WavePhaseTrackBar = New System.Windows.Forms.TrackBar()
        Me.LabelFreq = New System.Windows.Forms.Label()
        Me.WaveFreqTrackBar = New System.Windows.Forms.TrackBar()
        Me.LabelPhase = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WaveMaxTextBox = New System.Windows.Forms.TextBox()
        Me.WaveLengthTextBox = New System.Windows.Forms.TextBox()
        Me.WaveTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.RandomButton = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PhaseTextBox = New System.Windows.Forms.TextBox()
        Me.anOutputDataGBox = New ByteniZ3R.OutputDataGBox()
        Me.ToolStrip1.SuspendLayout()
        Me.PiXelGroupBox1.SuspendLayout()
        Me.DrawPanel.SuspendLayout()
        CType(Me.GFXoutputPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveLengthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveMinTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveMaxTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WavePhaseTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaveFreqTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.LoadButton, Me.SaveButton, Me.SaveAsButton, Me.ToolStripSeparator2, Me.ProjectNameTextBox, Me.ProjectInfoButton, Me.ToolStripSeparator1, Me.ConfigButton, Me.Help_Button, Me.AboutButton})
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
        'SaveAsButton
        '
        Me.SaveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveAsButton.Image = Global.ByteniZ3R.My.Resources.Resources.save_as3_x24
        Me.SaveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveAsButton.Name = "SaveAsButton"
        Me.SaveAsButton.Size = New System.Drawing.Size(28, 28)
        Me.SaveAsButton.Text = "ToolStripButton1"
        Me.SaveAsButton.ToolTipText = "Save As Project"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ProjectNameTextBox
        '
        Me.ProjectNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke
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
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 639)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 119
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'PiXelGroupBox1
        '
        Me.PiXelGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PiXelGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.PiXelGroupBox1.Controls.Add(Me.DrawPanel)
        Me.PiXelGroupBox1.Controls.Add(Me.PictureBox2)
        Me.PiXelGroupBox1.Controls.Add(Me.Label13)
        Me.PiXelGroupBox1.Controls.Add(Me.Label14)
        Me.PiXelGroupBox1.Controls.Add(Me.WaveLengthTrackBar)
        Me.PiXelGroupBox1.Controls.Add(Me.FreqTextBox)
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
        Me.PiXelGroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PiXelGroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.PiXelGroupBox1.Name = "PiXelGroupBox1"
        Me.PiXelGroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.PiXelGroupBox1.Size = New System.Drawing.Size(760, 310)
        Me.PiXelGroupBox1.TabIndex = 120
        Me.PiXelGroupBox1.TabStop = False
        Me.PiXelGroupBox1.Text = "Waveform"
        '
        'DrawPanel
        '
        Me.DrawPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawPanel.AutoScroll = True
        Me.DrawPanel.BackColor = System.Drawing.Color.LightSlateGray
        Me.DrawPanel.BackgroundImage = Global.ByteniZ3R.My.Resources.Resources.textu00
        Me.DrawPanel.Controls.Add(Me.GFXoutputPictureBox)
        Me.DrawPanel.Location = New System.Drawing.Point(392, 21)
        Me.DrawPanel.Name = "DrawPanel"
        Me.DrawPanel.Size = New System.Drawing.Size(350, 256)
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
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.ByteniZ3R.My.Resources.Resources.display_ruler
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Location = New System.Drawing.Point(362, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 267)
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(13, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 24)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Max value:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(13, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Type:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WaveLengthTrackBar
        '
        Me.WaveLengthTrackBar.AutoSize = False
        Me.WaveLengthTrackBar.BackColor = System.Drawing.Color.LightGray
        Me.WaveLengthTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.WaveLengthTrackBar.LargeChange = 8
        Me.WaveLengthTrackBar.Location = New System.Drawing.Point(88, 60)
        Me.WaveLengthTrackBar.Maximum = 1024
        Me.WaveLengthTrackBar.Name = "WaveLengthTrackBar"
        Me.WaveLengthTrackBar.Size = New System.Drawing.Size(200, 26)
        Me.WaveLengthTrackBar.TabIndex = 3
        Me.WaveLengthTrackBar.TickFrequency = 64
        Me.WaveLengthTrackBar.Value = 8
        '
        'FreqTextBox
        '
        Me.FreqTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreqTextBox.Location = New System.Drawing.Point(288, 187)
        Me.FreqTextBox.MaxLength = 3
        Me.FreqTextBox.Name = "FreqTextBox"
        Me.FreqTextBox.Size = New System.Drawing.Size(49, 21)
        Me.FreqTextBox.TabIndex = 12
        Me.FreqTextBox.Text = "0"
        Me.FreqTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.FreqTextBox, "Frequency from 1 to (Length/4)")
        '
        'WaveMinTrackBar
        '
        Me.WaveMinTrackBar.AutoSize = False
        Me.WaveMinTrackBar.BackColor = System.Drawing.Color.LightGray
        Me.WaveMinTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.WaveMinTrackBar.LargeChange = 8
        Me.WaveMinTrackBar.Location = New System.Drawing.Point(88, 91)
        Me.WaveMinTrackBar.Maximum = 254
        Me.WaveMinTrackBar.Name = "WaveMinTrackBar"
        Me.WaveMinTrackBar.Size = New System.Drawing.Size(200, 26)
        Me.WaveMinTrackBar.TabIndex = 5
        Me.WaveMinTrackBar.TickFrequency = 32
        '
        'WaveMaxTrackBar
        '
        Me.WaveMaxTrackBar.AutoSize = False
        Me.WaveMaxTrackBar.BackColor = System.Drawing.Color.LightGray
        Me.WaveMaxTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.WaveMaxTrackBar.LargeChange = 8
        Me.WaveMaxTrackBar.Location = New System.Drawing.Point(88, 124)
        Me.WaveMaxTrackBar.Maximum = 255
        Me.WaveMaxTrackBar.Minimum = 1
        Me.WaveMaxTrackBar.Name = "WaveMaxTrackBar"
        Me.WaveMaxTrackBar.Size = New System.Drawing.Size(200, 26)
        Me.WaveMaxTrackBar.TabIndex = 7
        Me.WaveMaxTrackBar.TickFrequency = 32
        Me.WaveMaxTrackBar.Value = 1
        '
        'WaveMinTextBox
        '
        Me.WaveMinTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaveMinTextBox.Location = New System.Drawing.Point(288, 90)
        Me.WaveMinTextBox.MaxLength = 3
        Me.WaveMinTextBox.Name = "WaveMinTextBox"
        Me.WaveMinTextBox.Size = New System.Drawing.Size(49, 21)
        Me.WaveMinTextBox.TabIndex = 6
        Me.WaveMinTextBox.Text = "0"
        Me.WaveMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.WaveMinTextBox, "(0-255)")
        '
        'WavePhaseTrackBar
        '
        Me.WavePhaseTrackBar.AutoSize = False
        Me.WavePhaseTrackBar.BackColor = System.Drawing.Color.LightGray
        Me.WavePhaseTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.WavePhaseTrackBar.LargeChange = 15
        Me.WavePhaseTrackBar.Location = New System.Drawing.Point(88, 157)
        Me.WavePhaseTrackBar.Maximum = 359
        Me.WavePhaseTrackBar.Name = "WavePhaseTrackBar"
        Me.WavePhaseTrackBar.Size = New System.Drawing.Size(200, 26)
        Me.WavePhaseTrackBar.TabIndex = 9
        Me.WavePhaseTrackBar.TickFrequency = 45
        '
        'LabelFreq
        '
        Me.LabelFreq.Location = New System.Drawing.Point(13, 189)
        Me.LabelFreq.Name = "LabelFreq"
        Me.LabelFreq.Size = New System.Drawing.Size(80, 24)
        Me.LabelFreq.TabIndex = 33
        Me.LabelFreq.Text = "Frequency:"
        Me.LabelFreq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WaveFreqTrackBar
        '
        Me.WaveFreqTrackBar.AutoSize = False
        Me.WaveFreqTrackBar.BackColor = System.Drawing.Color.LightGray
        Me.WaveFreqTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.WaveFreqTrackBar.LargeChange = 8
        Me.WaveFreqTrackBar.Location = New System.Drawing.Point(88, 189)
        Me.WaveFreqTrackBar.Maximum = 256
        Me.WaveFreqTrackBar.Minimum = 1
        Me.WaveFreqTrackBar.Name = "WaveFreqTrackBar"
        Me.WaveFreqTrackBar.Size = New System.Drawing.Size(200, 26)
        Me.WaveFreqTrackBar.TabIndex = 11
        Me.WaveFreqTrackBar.TickFrequency = 32
        Me.WaveFreqTrackBar.Value = 1
        '
        'LabelPhase
        '
        Me.LabelPhase.Location = New System.Drawing.Point(13, 157)
        Me.LabelPhase.Name = "LabelPhase"
        Me.LabelPhase.Size = New System.Drawing.Size(80, 24)
        Me.LabelPhase.TabIndex = 30
        Me.LabelPhase.Text = "Phase:"
        Me.LabelPhase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(13, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Length:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WaveMaxTextBox
        '
        Me.WaveMaxTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaveMaxTextBox.Location = New System.Drawing.Point(288, 122)
        Me.WaveMaxTextBox.MaxLength = 3
        Me.WaveMaxTextBox.Name = "WaveMaxTextBox"
        Me.WaveMaxTextBox.Size = New System.Drawing.Size(49, 21)
        Me.WaveMaxTextBox.TabIndex = 8
        Me.WaveMaxTextBox.Text = "0"
        Me.WaveMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.WaveMaxTextBox, "(0-255)")
        '
        'WaveLengthTextBox
        '
        Me.WaveLengthTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaveLengthTextBox.Location = New System.Drawing.Point(288, 59)
        Me.WaveLengthTextBox.MaxLength = 5
        Me.WaveLengthTextBox.Name = "WaveLengthTextBox"
        Me.WaveLengthTextBox.Size = New System.Drawing.Size(49, 21)
        Me.WaveLengthTextBox.TabIndex = 4
        Me.WaveLengthTextBox.Text = "8888"
        Me.WaveLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.WaveLengthTextBox, "Total of values (8 to 1024).")
        '
        'WaveTypeComboBox
        '
        Me.WaveTypeComboBox.FormattingEnabled = True
        Me.WaveTypeComboBox.Items.AddRange(New Object() {"Sine", "1/2 Sine Upper", "1/2 Sine Lower", "Cosine", "Square", "Triangle", "Sawtooth", "Reverse Sawtooth", "Noise (Random)"})
        Me.WaveTypeComboBox.Location = New System.Drawing.Point(96, 29)
        Me.WaveTypeComboBox.Name = "WaveTypeComboBox"
        Me.WaveTypeComboBox.Size = New System.Drawing.Size(186, 22)
        Me.WaveTypeComboBox.TabIndex = 1
        '
        'RandomButton
        '
        Me.RandomButton.BackColor = System.Drawing.Color.Gainsboro
        Me.RandomButton.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RandomButton.Location = New System.Drawing.Point(288, 28)
        Me.RandomButton.Name = "RandomButton"
        Me.RandomButton.Size = New System.Drawing.Size(49, 23)
        Me.RandomButton.TabIndex = 2
        Me.RandomButton.Text = "New"
        Me.ToolTip1.SetToolTip(Me.RandomButton, "Generate a new random data.")
        Me.RandomButton.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(13, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 24)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Min value:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhaseTextBox
        '
        Me.PhaseTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhaseTextBox.Location = New System.Drawing.Point(288, 155)
        Me.PhaseTextBox.MaxLength = 3
        Me.PhaseTextBox.Name = "PhaseTextBox"
        Me.PhaseTextBox.Size = New System.Drawing.Size(49, 21)
        Me.PhaseTextBox.TabIndex = 10
        Me.PhaseTextBox.Text = "0"
        Me.PhaseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.PhaseTextBox, "Phase (0-359)")
        '
        'anOutputDataGBox
        '
        Me.anOutputDataGBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.anOutputDataGBox.Compress = ByteniZ3R.DataTypeInputControl.Compress_Type.RAW
        Me.anOutputDataGBox.EnableAssemblerIndex = False
        Me.anOutputDataGBox.EnableCompress = False
        Me.anOutputDataGBox.EnableDataSizeLine = False
        Me.anOutputDataGBox.FieldName = "DATA"
        Me.anOutputDataGBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anOutputDataGBox.Location = New System.Drawing.Point(12, 372)
        Me.anOutputDataGBox.MinimumSize = New System.Drawing.Size(600, 260)
        Me.anOutputDataGBox.Name = "anOutputDataGBox"
        Me.anOutputDataGBox.Size = New System.Drawing.Size(760, 268)
        Me.anOutputDataGBox.SizeLineIndex = 6
        Me.anOutputDataGBox.TabIndex = 117
        '
        'MainForm
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.PiXelGroupBox1)
        Me.Controls.Add(Me.anOutputDataGBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 680)
        Me.Name = "MainForm"
        Me.Text = "ByteniZ3R"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PiXelGroupBox1.ResumeLayout(False)
        Me.PiXelGroupBox1.PerformLayout()
        Me.DrawPanel.ResumeLayout(False)
        CType(Me.GFXoutputPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveLengthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveMinTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveMaxTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WavePhaseTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaveFreqTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents anOutputDataGBox As OutputDataGBox
    Friend WithEvents SaveAsButton As ToolStripButton
    Friend WithEvents PiXelGroupBox1 As piXelGroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents DrawPanel As Panel
End Class
