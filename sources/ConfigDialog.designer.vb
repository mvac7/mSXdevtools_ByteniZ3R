<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigDialog))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataLabelTextBox = New System.Windows.Forms.TextBox()
        Me.NumberSystemCombo = New System.Windows.Forms.ComboBox()
        Me.CByteDataTextBox = New System.Windows.Forms.TextBox()
        Me.AsmByteDataTextBox = New System.Windows.Forms.TextBox()
        Me.AsmWordDataTextBox = New System.Windows.Forms.TextBox()
        Me.BASICcommentComboBox = New System.Windows.Forms.ComboBox()
        Me.BASICdataTextBox = New System.Windows.Forms.TextBox()
        Me.BASICincLineslTextBox = New System.Windows.Forms.TextBox()
        Me.BASICinitLineTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupNameTextBox = New System.Windows.Forms.TextBox()
        Me.InkLabel = New System.Windows.Forms.Label()
        Me.OutputINKcolorButton = New System.Windows.Forms.Button()
        Me.BackgroundLabel = New System.Windows.Forms.Label()
        Me.OutputBGcolorButton = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Color0Button = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.CGroupBox = New ByteniZ3R.piXelST_GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AssemblerGroupBox = New ByteniZ3R.piXelST_GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.arrow2PictureBox = New System.Windows.Forms.PictureBox()
        Me.arrow1PictureBox = New System.Windows.Forms.PictureBox()
        Me.AsmWordValuesComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AsmByteValuesComboBox = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CompressTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.BASICGroupBox = New ByteniZ3R.piXelST_GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RemoveZerosCheck = New System.Windows.Forms.CheckBox()
        Me.LineNumberLabel = New System.Windows.Forms.Label()
        Me.IntervalLabel = New System.Windows.Forms.Label()
        Me.SizeLineComboBox = New System.Windows.Forms.ComboBox()
        Me.CodeOutputComboBox = New System.Windows.Forms.ComboBox()
        Me.DataLabelLabel = New System.Windows.Forms.Label()
        Me.NumberSystemLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BottonsPanel = New System.Windows.Forms.Panel()
        Me.Ok_Button = New ByteniZ3R.piXelST_Button()
        Me.Cancel_Button = New ByteniZ3R.piXelST_Button()
        Me.Title_Label = New ByteniZ3R.piXelST_Label()
        Me.MiscPanel = New System.Windows.Forms.Panel()
        Me.DefaultColorsGroupBox = New ByteniZ3R.piXelST_GroupBox()
        Me.GridColorButton = New System.Windows.Forms.Button()
        Me.ProjectInfoGroupBox = New ByteniZ3R.piXelST_GroupBox()
        Me.OutputdataColorsGroupBox = New ByteniZ3R.piXelST_GroupBox()
        Me.OutputText = New System.Windows.Forms.TextBox()
        Me.ColorConfigsLabel = New System.Windows.Forms.Label()
        Me.ColorConfigsComboBox = New System.Windows.Forms.ComboBox()
        Me.SourceCodePanel = New System.Windows.Forms.Panel()
        Me.PiXelST_HorizontalTab1 = New ByteniZ3R.piXelST_HorizontalTab()
        Me.CGroupBox.SuspendLayout()
        Me.AssemblerGroupBox.SuspendLayout()
        CType(Me.arrow2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrow1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BASICGroupBox.SuspendLayout()
        Me.BottonsPanel.SuspendLayout()
        Me.MiscPanel.SuspendLayout()
        Me.DefaultColorsGroupBox.SuspendLayout()
        Me.ProjectInfoGroupBox.SuspendLayout()
        Me.OutputdataColorsGroupBox.SuspendLayout()
        Me.SourceCodePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'DataLabelTextBox
        '
        Me.DataLabelTextBox.Location = New System.Drawing.Point(133, 126)
        Me.DataLabelTextBox.Name = "DataLabelTextBox"
        Me.DataLabelTextBox.Size = New System.Drawing.Size(221, 22)
        Me.DataLabelTextBox.TabIndex = 252
        Me.ToolTip1.SetToolTip(Me.DataLabelTextBox, "Data definition command (DB, BYTE, DEFB, etc.)")
        '
        'NumberSystemCombo
        '
        Me.NumberSystemCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NumberSystemCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NumberSystemCombo.FormattingEnabled = True
        Me.NumberSystemCombo.Items.AddRange(New Object() {"dec n", "dec nnn", "dec nnnd", "hex FF", "hex $FF", "hex #FF", "hex 0FFh", "hex 0xFF", "hex &HFF", "binary 00000000", "binary 00000000b", "binary %00000000", "binary 0b00000000", "binary &B00000000"})
        Me.NumberSystemCombo.Location = New System.Drawing.Point(133, 42)
        Me.NumberSystemCombo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumberSystemCombo.Name = "NumberSystemCombo"
        Me.NumberSystemCombo.Size = New System.Drawing.Size(221, 22)
        Me.NumberSystemCombo.TabIndex = 246
        Me.ToolTip1.SetToolTip(Me.NumberSystemCombo, "Computer number format")
        '
        'CByteDataTextBox
        '
        Me.CByteDataTextBox.Location = New System.Drawing.Point(119, 21)
        Me.CByteDataTextBox.Name = "CByteDataTextBox"
        Me.CByteDataTextBox.Size = New System.Drawing.Size(220, 22)
        Me.CByteDataTextBox.TabIndex = 261
        Me.ToolTip1.SetToolTip(Me.CByteDataTextBox, "Byte Data command definition for C")
        '
        'AsmByteDataTextBox
        '
        Me.AsmByteDataTextBox.Location = New System.Drawing.Point(117, 21)
        Me.AsmByteDataTextBox.Name = "AsmByteDataTextBox"
        Me.AsmByteDataTextBox.Size = New System.Drawing.Size(220, 22)
        Me.AsmByteDataTextBox.TabIndex = 247
        Me.ToolTip1.SetToolTip(Me.AsmByteDataTextBox, "Byte Data command definition.")
        '
        'AsmWordDataTextBox
        '
        Me.AsmWordDataTextBox.Location = New System.Drawing.Point(117, 49)
        Me.AsmWordDataTextBox.Name = "AsmWordDataTextBox"
        Me.AsmWordDataTextBox.Size = New System.Drawing.Size(220, 22)
        Me.AsmWordDataTextBox.TabIndex = 247
        Me.ToolTip1.SetToolTip(Me.AsmWordDataTextBox, "Word Data command definition (DW, WORD, DEFW...)")
        '
        'BASICcommentComboBox
        '
        Me.BASICcommentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BASICcommentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BASICcommentComboBox.FormattingEnabled = True
        Me.BASICcommentComboBox.Items.AddRange(New Object() {"REM", "' (apostrophe)"})
        Me.BASICcommentComboBox.Location = New System.Drawing.Point(162, 49)
        Me.BASICcommentComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BASICcommentComboBox.Name = "BASICcommentComboBox"
        Me.BASICcommentComboBox.Size = New System.Drawing.Size(128, 22)
        Me.BASICcommentComboBox.TabIndex = 267
        Me.ToolTip1.SetToolTip(Me.BASICcommentComboBox, "Instruction for comments")
        '
        'BASICdataTextBox
        '
        Me.BASICdataTextBox.Location = New System.Drawing.Point(162, 21)
        Me.BASICdataTextBox.Name = "BASICdataTextBox"
        Me.BASICdataTextBox.Size = New System.Drawing.Size(128, 22)
        Me.BASICdataTextBox.TabIndex = 263
        Me.BASICdataTextBox.Text = "DATA"
        Me.ToolTip1.SetToolTip(Me.BASICdataTextBox, "Instruction for datas")
        '
        'BASICincLineslTextBox
        '
        Me.BASICincLineslTextBox.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BASICincLineslTextBox.Location = New System.Drawing.Point(491, 49)
        Me.BASICincLineslTextBox.MaxLength = 3
        Me.BASICincLineslTextBox.Name = "BASICincLineslTextBox"
        Me.BASICincLineslTextBox.Size = New System.Drawing.Size(52, 25)
        Me.BASICincLineslTextBox.TabIndex = 255
        Me.BASICincLineslTextBox.Text = "10"
        Me.BASICincLineslTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.BASICincLineslTextBox, "Interval lines (for BASIC)")
        '
        'BASICinitLineTextBox
        '
        Me.BASICinitLineTextBox.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BASICinitLineTextBox.Location = New System.Drawing.Point(491, 21)
        Me.BASICinitLineTextBox.MaxLength = 5
        Me.BASICinitLineTextBox.Name = "BASICinitLineTextBox"
        Me.BASICinitLineTextBox.Size = New System.Drawing.Size(52, 25)
        Me.BASICinitLineTextBox.TabIndex = 254
        Me.BASICinitLineTextBox.Text = "10000"
        Me.BASICinitLineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.BASICinitLineTextBox, "Initial number of line (for BASIC)")
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(11, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 22)
        Me.Label10.TabIndex = 255
        Me.Label10.Text = "Username"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label10, "Username to assign the author by default in the project information.")
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(125, 21)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(303, 22)
        Me.UserNameTextBox.TabIndex = 254
        Me.ToolTip1.SetToolTip(Me.UserNameTextBox, "Username to assign the author by default in the project information.")
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(11, 49)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 22)
        Me.Label16.TabIndex = 257
        Me.Label16.Text = "Group"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label16, "Username to assign the author by default in the project information.")
        '
        'GroupNameTextBox
        '
        Me.GroupNameTextBox.Location = New System.Drawing.Point(125, 49)
        Me.GroupNameTextBox.Name = "GroupNameTextBox"
        Me.GroupNameTextBox.Size = New System.Drawing.Size(303, 22)
        Me.GroupNameTextBox.TabIndex = 256
        Me.ToolTip1.SetToolTip(Me.GroupNameTextBox, "Username to assign the author by default in the project information.")
        '
        'InkLabel
        '
        Me.InkLabel.Location = New System.Drawing.Point(11, 51)
        Me.InkLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.InkLabel.Name = "InkLabel"
        Me.InkLabel.Size = New System.Drawing.Size(100, 22)
        Me.InkLabel.TabIndex = 259
        Me.InkLabel.Text = "Ink"
        Me.InkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.InkLabel, "Username to assign the author by default in the project information.")
        '
        'OutputINKcolorButton
        '
        Me.OutputINKcolorButton.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputINKcolorButton.Location = New System.Drawing.Point(111, 50)
        Me.OutputINKcolorButton.Name = "OutputINKcolorButton"
        Me.OutputINKcolorButton.Size = New System.Drawing.Size(108, 26)
        Me.OutputINKcolorButton.TabIndex = 260
        Me.ToolTip1.SetToolTip(Me.OutputINKcolorButton, "Define a color for the color zero to differentiate it from black.")
        Me.OutputINKcolorButton.UseVisualStyleBackColor = True
        '
        'BackgroundLabel
        '
        Me.BackgroundLabel.Location = New System.Drawing.Point(8, 83)
        Me.BackgroundLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BackgroundLabel.Name = "BackgroundLabel"
        Me.BackgroundLabel.Size = New System.Drawing.Size(100, 22)
        Me.BackgroundLabel.TabIndex = 261
        Me.BackgroundLabel.Text = "Background"
        Me.BackgroundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.BackgroundLabel, "Username to assign the author by default in the project information.")
        '
        'OutputBGcolorButton
        '
        Me.OutputBGcolorButton.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputBGcolorButton.Location = New System.Drawing.Point(111, 80)
        Me.OutputBGcolorButton.Name = "OutputBGcolorButton"
        Me.OutputBGcolorButton.Size = New System.Drawing.Size(108, 26)
        Me.OutputBGcolorButton.TabIndex = 262
        Me.ToolTip1.SetToolTip(Me.OutputBGcolorButton, "Define a color for the color zero to differentiate it from black.")
        Me.OutputBGcolorButton.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(12, 56)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 22)
        Me.Label12.TabIndex = 259
        Me.Label12.Text = "Grid Color"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label12, "Username to assign the author by default in the project information.")
        '
        'Color0Button
        '
        Me.Color0Button.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Color0Button.Location = New System.Drawing.Point(150, 23)
        Me.Color0Button.Name = "Color0Button"
        Me.Color0Button.Size = New System.Drawing.Size(108, 26)
        Me.Color0Button.TabIndex = 258
        Me.ToolTip1.SetToolTip(Me.Color0Button, "Define a color for the color zero to differentiate it from black.")
        Me.Color0Button.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(12, 24)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 22)
        Me.Label11.TabIndex = 257
        Me.Label11.Text = "Zero Color"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label11, "Username to assign the author by default in the project information.")
        '
        'CGroupBox
        '
        Me.CGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.CGroupBox.BGColor = System.Drawing.Color.LightGray
        Me.CGroupBox.Controls.Add(Me.CByteDataTextBox)
        Me.CGroupBox.Controls.Add(Me.Label8)
        Me.CGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CGroupBox.LineColor = System.Drawing.Color.DimGray
        Me.CGroupBox.Location = New System.Drawing.Point(17, 259)
        Me.CGroupBox.Name = "CGroupBox"
        Me.CGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.CGroupBox.Size = New System.Drawing.Size(559, 54)
        Me.CGroupBox.TabIndex = 268
        Me.CGroupBox.TabStop = False
        Me.CGroupBox.Text = "C"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(5, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 22)
        Me.Label8.TabIndex = 262
        Me.Label8.Text = "C Byte:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AssemblerGroupBox
        '
        Me.AssemblerGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.AssemblerGroupBox.BGColor = System.Drawing.Color.LightGray
        Me.AssemblerGroupBox.Controls.Add(Me.Label4)
        Me.AssemblerGroupBox.Controls.Add(Me.arrow2PictureBox)
        Me.AssemblerGroupBox.Controls.Add(Me.AsmByteDataTextBox)
        Me.AssemblerGroupBox.Controls.Add(Me.arrow1PictureBox)
        Me.AssemblerGroupBox.Controls.Add(Me.AsmWordDataTextBox)
        Me.AssemblerGroupBox.Controls.Add(Me.AsmWordValuesComboBox)
        Me.AssemblerGroupBox.Controls.Add(Me.Label7)
        Me.AssemblerGroupBox.Controls.Add(Me.AsmByteValuesComboBox)
        Me.AssemblerGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AssemblerGroupBox.LineColor = System.Drawing.Color.DimGray
        Me.AssemblerGroupBox.Location = New System.Drawing.Point(17, 162)
        Me.AssemblerGroupBox.Name = "AssemblerGroupBox"
        Me.AssemblerGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.AssemblerGroupBox.Size = New System.Drawing.Size(559, 83)
        Me.AssemblerGroupBox.TabIndex = 267
        Me.AssemblerGroupBox.TabStop = False
        Me.AssemblerGroupBox.Text = "Assembler"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 22)
        Me.Label4.TabIndex = 251
        Me.Label4.Text = "Asm Byte:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'arrow2PictureBox
        '
        Me.arrow2PictureBox.Image = CType(resources.GetObject("arrow2PictureBox.Image"), System.Drawing.Image)
        Me.arrow2PictureBox.Location = New System.Drawing.Point(343, 49)
        Me.arrow2PictureBox.Name = "arrow2PictureBox"
        Me.arrow2PictureBox.Size = New System.Drawing.Size(24, 24)
        Me.arrow2PictureBox.TabIndex = 266
        Me.arrow2PictureBox.TabStop = False
        '
        'arrow1PictureBox
        '
        Me.arrow1PictureBox.Image = CType(resources.GetObject("arrow1PictureBox.Image"), System.Drawing.Image)
        Me.arrow1PictureBox.Location = New System.Drawing.Point(343, 20)
        Me.arrow1PictureBox.Name = "arrow1PictureBox"
        Me.arrow1PictureBox.Size = New System.Drawing.Size(24, 24)
        Me.arrow1PictureBox.TabIndex = 265
        Me.arrow1PictureBox.TabStop = False
        '
        'AsmWordValuesComboBox
        '
        Me.AsmWordValuesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AsmWordValuesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AsmWordValuesComboBox.FormattingEnabled = True
        Me.AsmWordValuesComboBox.Items.AddRange(New Object() {".dw", "dw", "DW", "WORD", "DEFW", "<tab>DW", "<tab>WORD", "<tab>DEFW"})
        Me.AsmWordValuesComboBox.Location = New System.Drawing.Point(372, 50)
        Me.AsmWordValuesComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AsmWordValuesComboBox.Name = "AsmWordValuesComboBox"
        Me.AsmWordValuesComboBox.Size = New System.Drawing.Size(171, 22)
        Me.AsmWordValuesComboBox.TabIndex = 264
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(3, 49)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 22)
        Me.Label7.TabIndex = 251
        Me.Label7.Text = "Asm Word:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AsmByteValuesComboBox
        '
        Me.AsmByteValuesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AsmByteValuesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AsmByteValuesComboBox.FormattingEnabled = True
        Me.AsmByteValuesComboBox.Items.AddRange(New Object() {".db", "db", "DB", "BYTE", "DEFB", "DEFM", "<tab>DB", "<tab>BYTE", "<tab>DEFB", "<tab>DEFM"})
        Me.AsmByteValuesComboBox.Location = New System.Drawing.Point(372, 21)
        Me.AsmByteValuesComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AsmByteValuesComboBox.Name = "AsmByteValuesComboBox"
        Me.AsmByteValuesComboBox.Size = New System.Drawing.Size(171, 22)
        Me.AsmByteValuesComboBox.TabIndex = 263
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(17, 14)
        Me.Label21.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(110, 22)
        Me.Label21.TabIndex = 239
        Me.Label21.Text = "Language:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompressTypeComboBox
        '
        Me.CompressTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompressTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CompressTypeComboBox.FormattingEnabled = True
        Me.CompressTypeComboBox.Items.AddRange(New Object() {"RAW", "RLE", "WRLE", "Pletter5"})
        Me.CompressTypeComboBox.Location = New System.Drawing.Point(133, 98)
        Me.CompressTypeComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CompressTypeComboBox.Name = "CompressTypeComboBox"
        Me.CompressTypeComboBox.Size = New System.Drawing.Size(221, 22)
        Me.CompressTypeComboBox.TabIndex = 243
        '
        'BASICGroupBox
        '
        Me.BASICGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BASICGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.BASICGroupBox.BGColor = System.Drawing.Color.LightGray
        Me.BASICGroupBox.Controls.Add(Me.BASICcommentComboBox)
        Me.BASICGroupBox.Controls.Add(Me.Label13)
        Me.BASICGroupBox.Controls.Add(Me.Label9)
        Me.BASICGroupBox.Controls.Add(Me.BASICdataTextBox)
        Me.BASICGroupBox.Controls.Add(Me.RemoveZerosCheck)
        Me.BASICGroupBox.Controls.Add(Me.LineNumberLabel)
        Me.BASICGroupBox.Controls.Add(Me.BASICincLineslTextBox)
        Me.BASICGroupBox.Controls.Add(Me.BASICinitLineTextBox)
        Me.BASICGroupBox.Controls.Add(Me.IntervalLabel)
        Me.BASICGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BASICGroupBox.LineColor = System.Drawing.Color.DimGray
        Me.BASICGroupBox.Location = New System.Drawing.Point(17, 327)
        Me.BASICGroupBox.Name = "BASICGroupBox"
        Me.BASICGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.BASICGroupBox.Size = New System.Drawing.Size(559, 109)
        Me.BASICGroupBox.TabIndex = 249
        Me.BASICGroupBox.TabStop = False
        Me.BASICGroupBox.Text = "BASIC"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 49)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 22)
        Me.Label13.TabIndex = 266
        Me.Label13.Text = "Comment Instruction:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(11, 21)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 22)
        Me.Label9.TabIndex = 264
        Me.Label9.Text = "Data Instruction:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RemoveZerosCheck
        '
        Me.RemoveZerosCheck.BackColor = System.Drawing.Color.Transparent
        Me.RemoveZerosCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoveZerosCheck.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveZerosCheck.Location = New System.Drawing.Point(418, 78)
        Me.RemoveZerosCheck.Name = "RemoveZerosCheck"
        Me.RemoveZerosCheck.Size = New System.Drawing.Size(125, 22)
        Me.RemoveZerosCheck.TabIndex = 258
        Me.RemoveZerosCheck.Text = "Remove zeros:"
        Me.RemoveZerosCheck.UseVisualStyleBackColor = False
        '
        'LineNumberLabel
        '
        Me.LineNumberLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LineNumberLabel.Location = New System.Drawing.Point(380, 21)
        Me.LineNumberLabel.Name = "LineNumberLabel"
        Me.LineNumberLabel.Size = New System.Drawing.Size(110, 22)
        Me.LineNumberLabel.TabIndex = 256
        Me.LineNumberLabel.Text = "Line number:"
        Me.LineNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IntervalLabel
        '
        Me.IntervalLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntervalLabel.Location = New System.Drawing.Point(377, 49)
        Me.IntervalLabel.Name = "IntervalLabel"
        Me.IntervalLabel.Size = New System.Drawing.Size(110, 22)
        Me.IntervalLabel.TabIndex = 257
        Me.IntervalLabel.Text = "Interval:"
        Me.IntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SizeLineComboBox
        '
        Me.SizeLineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SizeLineComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SizeLineComboBox.FormattingEnabled = True
        Me.SizeLineComboBox.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "24", "32"})
        Me.SizeLineComboBox.Location = New System.Drawing.Point(133, 70)
        Me.SizeLineComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SizeLineComboBox.Name = "SizeLineComboBox"
        Me.SizeLineComboBox.Size = New System.Drawing.Size(221, 22)
        Me.SizeLineComboBox.TabIndex = 242
        '
        'CodeOutputComboBox
        '
        Me.CodeOutputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CodeOutputComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CodeOutputComboBox.FormattingEnabled = True
        Me.CodeOutputComboBox.Items.AddRange(New Object() {"BASIC", "C", "Assembler default", "Assembler asMSX", "Assembler tniASM", "Assembler SJasm", "Assembler SDCC"})
        Me.CodeOutputComboBox.Location = New System.Drawing.Point(133, 14)
        Me.CodeOutputComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CodeOutputComboBox.Name = "CodeOutputComboBox"
        Me.CodeOutputComboBox.Size = New System.Drawing.Size(221, 22)
        Me.CodeOutputComboBox.TabIndex = 241
        '
        'DataLabelLabel
        '
        Me.DataLabelLabel.Location = New System.Drawing.Point(19, 126)
        Me.DataLabelLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.DataLabelLabel.Name = "DataLabelLabel"
        Me.DataLabelLabel.Size = New System.Drawing.Size(110, 22)
        Me.DataLabelLabel.TabIndex = 253
        Me.DataLabelLabel.Text = "Label:"
        Me.DataLabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumberSystemLabel
        '
        Me.NumberSystemLabel.Location = New System.Drawing.Point(17, 42)
        Me.NumberSystemLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.NumberSystemLabel.Name = "NumberSystemLabel"
        Me.NumberSystemLabel.Size = New System.Drawing.Size(110, 22)
        Me.NumberSystemLabel.TabIndex = 248
        Me.NumberSystemLabel.Text = "Number system:"
        Me.NumberSystemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 22)
        Me.Label2.TabIndex = 249
        Me.Label2.Text = "Line size:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 22)
        Me.Label3.TabIndex = 250
        Me.Label3.Text = "Compress:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BottonsPanel
        '
        Me.BottonsPanel.BackColor = System.Drawing.Color.Transparent
        Me.BottonsPanel.Controls.Add(Me.Ok_Button)
        Me.BottonsPanel.Controls.Add(Me.Cancel_Button)
        Me.BottonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottonsPanel.Location = New System.Drawing.Point(0, 534)
        Me.BottonsPanel.Name = "BottonsPanel"
        Me.BottonsPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.BottonsPanel.Size = New System.Drawing.Size(1227, 44)
        Me.BottonsPanel.TabIndex = 257
        '
        'Ok_Button
        '
        Me.Ok_Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Ok_Button.ButtonColor = System.Drawing.Color.Gray
        Me.Ok_Button.ButtonType = ByteniZ3R.piXelST_Button.Button_TYPES.Confirmation
        Me.Ok_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ok_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Ok_Button.FlatAppearance.BorderSize = 0
        Me.Ok_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ok_Button.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ok_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Ok_Button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Ok_Button.Location = New System.Drawing.Point(996, 4)
        Me.Ok_Button.Name = "Ok_Button"
        Me.Ok_Button.Padding = New System.Windows.Forms.Padding(4)
        Me.Ok_Button.Size = New System.Drawing.Size(125, 36)
        Me.Ok_Button.TabIndex = 127
        Me.Ok_Button.TabStop = False
        Me.Ok_Button.Text = "Ok"
        Me.Ok_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Cancel_Button.ButtonColor = System.Drawing.Color.Gray
        Me.Cancel_Button.ButtonType = ByteniZ3R.piXelST_Button.Button_TYPES.Cancellation
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancel_Button.Location = New System.Drawing.Point(1121, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Padding = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Size = New System.Drawing.Size(102, 36)
        Me.Cancel_Button.TabIndex = 128
        Me.Cancel_Button.TabStop = False
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Title_Label
        '
        Me.Title_Label.BackColor = System.Drawing.Color.RoyalBlue
        Me.Title_Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Title_Label.ForeColor = System.Drawing.Color.White
        Me.Title_Label.Location = New System.Drawing.Point(0, 0)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Padding = New System.Windows.Forms.Padding(8, 4, 4, 4)
        Me.Title_Label.Size = New System.Drawing.Size(1227, 32)
        Me.Title_Label.TabIndex = 258
        Me.Title_Label.Text = "Application Settings"
        Me.Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiscPanel
        '
        Me.MiscPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MiscPanel.Controls.Add(Me.DefaultColorsGroupBox)
        Me.MiscPanel.Controls.Add(Me.ProjectInfoGroupBox)
        Me.MiscPanel.Controls.Add(Me.OutputdataColorsGroupBox)
        Me.MiscPanel.Location = New System.Drawing.Point(12, 82)
        Me.MiscPanel.Name = "MiscPanel"
        Me.MiscPanel.Size = New System.Drawing.Size(592, 443)
        Me.MiscPanel.TabIndex = 259
        '
        'DefaultColorsGroupBox
        '
        Me.DefaultColorsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.DefaultColorsGroupBox.BGColor = System.Drawing.Color.LightGray
        Me.DefaultColorsGroupBox.Controls.Add(Me.GridColorButton)
        Me.DefaultColorsGroupBox.Controls.Add(Me.Label11)
        Me.DefaultColorsGroupBox.Controls.Add(Me.Color0Button)
        Me.DefaultColorsGroupBox.Controls.Add(Me.Label12)
        Me.DefaultColorsGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DefaultColorsGroupBox.LineColor = System.Drawing.Color.DimGray
        Me.DefaultColorsGroupBox.Location = New System.Drawing.Point(31, 160)
        Me.DefaultColorsGroupBox.Name = "DefaultColorsGroupBox"
        Me.DefaultColorsGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.DefaultColorsGroupBox.Size = New System.Drawing.Size(535, 93)
        Me.DefaultColorsGroupBox.TabIndex = 262
        Me.DefaultColorsGroupBox.TabStop = False
        Me.DefaultColorsGroupBox.Text = "Colors"
        '
        'GridColorButton
        '
        Me.GridColorButton.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColorButton.Location = New System.Drawing.Point(150, 55)
        Me.GridColorButton.Name = "GridColorButton"
        Me.GridColorButton.Size = New System.Drawing.Size(108, 26)
        Me.GridColorButton.TabIndex = 260
        Me.GridColorButton.UseVisualStyleBackColor = True
        '
        'ProjectInfoGroupBox
        '
        Me.ProjectInfoGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ProjectInfoGroupBox.BGColor = System.Drawing.Color.LightGray
        Me.ProjectInfoGroupBox.Controls.Add(Me.GroupNameTextBox)
        Me.ProjectInfoGroupBox.Controls.Add(Me.Label16)
        Me.ProjectInfoGroupBox.Controls.Add(Me.UserNameTextBox)
        Me.ProjectInfoGroupBox.Controls.Add(Me.Label10)
        Me.ProjectInfoGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProjectInfoGroupBox.LineColor = System.Drawing.Color.DimGray
        Me.ProjectInfoGroupBox.Location = New System.Drawing.Point(31, 27)
        Me.ProjectInfoGroupBox.Name = "ProjectInfoGroupBox"
        Me.ProjectInfoGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.ProjectInfoGroupBox.Size = New System.Drawing.Size(535, 119)
        Me.ProjectInfoGroupBox.TabIndex = 256
        Me.ProjectInfoGroupBox.TabStop = False
        Me.ProjectInfoGroupBox.Text = "Default Project Info"
        '
        'OutputdataColorsGroupBox
        '
        Me.OutputdataColorsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.OutputdataColorsGroupBox.BGColor = System.Drawing.Color.LightGray
        Me.OutputdataColorsGroupBox.Controls.Add(Me.OutputText)
        Me.OutputdataColorsGroupBox.Controls.Add(Me.OutputBGcolorButton)
        Me.OutputdataColorsGroupBox.Controls.Add(Me.BackgroundLabel)
        Me.OutputdataColorsGroupBox.Controls.Add(Me.OutputINKcolorButton)
        Me.OutputdataColorsGroupBox.Controls.Add(Me.InkLabel)
        Me.OutputdataColorsGroupBox.Controls.Add(Me.ColorConfigsLabel)
        Me.OutputdataColorsGroupBox.Controls.Add(Me.ColorConfigsComboBox)
        Me.OutputdataColorsGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OutputdataColorsGroupBox.LineColor = System.Drawing.Color.DimGray
        Me.OutputdataColorsGroupBox.Location = New System.Drawing.Point(31, 267)
        Me.OutputdataColorsGroupBox.Name = "OutputdataColorsGroupBox"
        Me.OutputdataColorsGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.OutputdataColorsGroupBox.Size = New System.Drawing.Size(535, 118)
        Me.OutputdataColorsGroupBox.TabIndex = 261
        Me.OutputdataColorsGroupBox.TabStop = False
        Me.OutputdataColorsGroupBox.Text = "Output Data colors"
        '
        'OutputText
        '
        Me.OutputText.BackColor = System.Drawing.Color.SlateBlue
        Me.OutputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutputText.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputText.ForeColor = System.Drawing.Color.White
        Me.OutputText.Location = New System.Drawing.Point(292, 22)
        Me.OutputText.Margin = New System.Windows.Forms.Padding(4)
        Me.OutputText.Multiline = True
        Me.OutputText.Name = "OutputText"
        Me.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputText.Size = New System.Drawing.Size(232, 84)
        Me.OutputText.TabIndex = 263
        Me.OutputText.Text = "msXdevtool output" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ok"
        '
        'ColorConfigsLabel
        '
        Me.ColorConfigsLabel.Location = New System.Drawing.Point(11, 21)
        Me.ColorConfigsLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ColorConfigsLabel.Name = "ColorConfigsLabel"
        Me.ColorConfigsLabel.Size = New System.Drawing.Size(100, 22)
        Me.ColorConfigsLabel.TabIndex = 242
        Me.ColorConfigsLabel.Text = "Palettes:"
        Me.ColorConfigsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ColorConfigsComboBox
        '
        Me.ColorConfigsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ColorConfigsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ColorConfigsComboBox.FormattingEnabled = True
        Me.ColorConfigsComboBox.Items.AddRange(New Object() {"Light Side of the Force", "Dark Knight", "Blue MSX", "GreenBoy", "Nutcilla", "Green Phosphor", "Ambar Phosphor"})
        Me.ColorConfigsComboBox.Location = New System.Drawing.Point(111, 21)
        Me.ColorConfigsComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ColorConfigsComboBox.Name = "ColorConfigsComboBox"
        Me.ColorConfigsComboBox.Size = New System.Drawing.Size(163, 22)
        Me.ColorConfigsComboBox.TabIndex = 243
        '
        'SourceCodePanel
        '
        Me.SourceCodePanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SourceCodePanel.Controls.Add(Me.CGroupBox)
        Me.SourceCodePanel.Controls.Add(Me.Label21)
        Me.SourceCodePanel.Controls.Add(Me.AssemblerGroupBox)
        Me.SourceCodePanel.Controls.Add(Me.Label3)
        Me.SourceCodePanel.Controls.Add(Me.Label2)
        Me.SourceCodePanel.Controls.Add(Me.CompressTypeComboBox)
        Me.SourceCodePanel.Controls.Add(Me.NumberSystemLabel)
        Me.SourceCodePanel.Controls.Add(Me.BASICGroupBox)
        Me.SourceCodePanel.Controls.Add(Me.DataLabelLabel)
        Me.SourceCodePanel.Controls.Add(Me.CodeOutputComboBox)
        Me.SourceCodePanel.Controls.Add(Me.DataLabelTextBox)
        Me.SourceCodePanel.Controls.Add(Me.NumberSystemCombo)
        Me.SourceCodePanel.Controls.Add(Me.SizeLineComboBox)
        Me.SourceCodePanel.Location = New System.Drawing.Point(621, 82)
        Me.SourceCodePanel.Name = "SourceCodePanel"
        Me.SourceCodePanel.Size = New System.Drawing.Size(592, 443)
        Me.SourceCodePanel.TabIndex = 260
        '
        'PiXelST_HorizontalTab1
        '
        Me.PiXelST_HorizontalTab1.BackColor = System.Drawing.Color.Gainsboro
        Me.PiXelST_HorizontalTab1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PiXelST_HorizontalTab1.Items = New String() {"Miscelanea", "Source Code"}
        Me.PiXelST_HorizontalTab1.Location = New System.Drawing.Point(12, 48)
        Me.PiXelST_HorizontalTab1.Margin = New System.Windows.Forms.Padding(0)
        Me.PiXelST_HorizontalTab1.MinimumSize = New System.Drawing.Size(256, 32)
        Me.PiXelST_HorizontalTab1.Name = "PiXelST_HorizontalTab1"
        Me.PiXelST_HorizontalTab1.Padding = New System.Windows.Forms.Padding(2, 4, 0, 0)
        Me.PiXelST_HorizontalTab1.Size = New System.Drawing.Size(592, 34)
        Me.PiXelST_HorizontalTab1.TabIndex = 261
        Me.PiXelST_HorizontalTab1.TabStop = False
        '
        'ConfigDialog
        '
        Me.AcceptButton = Me.Ok_Button
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1227, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.PiXelST_HorizontalTab1)
        Me.Controls.Add(Me.SourceCodePanel)
        Me.Controls.Add(Me.MiscPanel)
        Me.Controls.Add(Me.Title_Label)
        Me.Controls.Add(Me.BottonsPanel)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ConfigDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.CGroupBox.ResumeLayout(False)
        Me.CGroupBox.PerformLayout()
        Me.AssemblerGroupBox.ResumeLayout(False)
        Me.AssemblerGroupBox.PerformLayout()
        CType(Me.arrow2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrow1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BASICGroupBox.ResumeLayout(False)
        Me.BASICGroupBox.PerformLayout()
        Me.BottonsPanel.ResumeLayout(False)
        Me.MiscPanel.ResumeLayout(False)
        Me.DefaultColorsGroupBox.ResumeLayout(False)
        Me.ProjectInfoGroupBox.ResumeLayout(False)
        Me.ProjectInfoGroupBox.PerformLayout()
        Me.OutputdataColorsGroupBox.ResumeLayout(False)
        Me.OutputdataColorsGroupBox.PerformLayout()
        Me.SourceCodePanel.ResumeLayout(False)
        Me.SourceCodePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents CGroupBox As piXelST_GroupBox
    Friend WithEvents CByteDataTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents AssemblerGroupBox As piXelST_GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents arrow2PictureBox As PictureBox
    Friend WithEvents AsmByteDataTextBox As TextBox
    Friend WithEvents arrow1PictureBox As PictureBox
    Friend WithEvents AsmWordDataTextBox As TextBox
    Friend WithEvents AsmWordValuesComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AsmByteValuesComboBox As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents CompressTypeComboBox As ComboBox
    Friend WithEvents BASICGroupBox As piXelST_GroupBox
    Friend WithEvents BASICcommentComboBox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BASICdataTextBox As TextBox
    Friend WithEvents RemoveZerosCheck As CheckBox
    Friend WithEvents LineNumberLabel As Label
    Friend WithEvents BASICincLineslTextBox As TextBox
    Friend WithEvents BASICinitLineTextBox As TextBox
    Friend WithEvents IntervalLabel As Label
    Friend WithEvents DataLabelTextBox As TextBox
    Friend WithEvents SizeLineComboBox As ComboBox
    Friend WithEvents NumberSystemCombo As ComboBox
    Friend WithEvents CodeOutputComboBox As ComboBox
    Friend WithEvents DataLabelLabel As Label
    Friend WithEvents NumberSystemLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BottonsPanel As Panel
    Friend WithEvents Ok_Button As piXelST_Button
    Friend WithEvents Cancel_Button As piXelST_Button
    Friend WithEvents Title_Label As piXelST_Label
    Friend WithEvents MiscPanel As Panel
    Friend WithEvents DefaultColorsGroupBox As piXelST_GroupBox
    Friend WithEvents GridColorButton As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Color0Button As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents ProjectInfoGroupBox As piXelST_GroupBox
    Friend WithEvents GroupNameTextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents OutputdataColorsGroupBox As piXelST_GroupBox
    Friend WithEvents OutputText As TextBox
    Friend WithEvents OutputBGcolorButton As Button
    Friend WithEvents BackgroundLabel As Label
    Friend WithEvents OutputINKcolorButton As Button
    Friend WithEvents InkLabel As Label
    Friend WithEvents ColorConfigsLabel As Label
    Friend WithEvents ColorConfigsComboBox As ComboBox
    Friend WithEvents SourceCodePanel As Panel
    Friend WithEvents PiXelST_HorizontalTab1 As piXelST_HorizontalTab
End Class
