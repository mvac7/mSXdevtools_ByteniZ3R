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
        Me.NumFormatComboBox = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BASICinitLineTextBox = New System.Windows.Forms.TextBox()
        Me.BASICincLineslTextBox = New System.Windows.Forms.TextBox()
        Me.BASICdataTextBox = New System.Windows.Forms.TextBox()
        Me.BASICcommentComboBox = New System.Windows.Forms.ComboBox()
        Me.AsmWordDataTextBox = New System.Windows.Forms.TextBox()
        Me.AsmByteDataTextBox = New System.Windows.Forms.TextBox()
        Me.CByteDataTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Color0Button = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.OutputINKcolorButton = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.OutputBGcolorButton = New System.Windows.Forms.Button()
        Me.GroupNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BottonsPanel = New System.Windows.Forms.Panel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.DataOutputTab = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.arrow2PictureBox = New System.Windows.Forms.PictureBox()
        Me.arrow1PictureBox = New System.Windows.Forms.PictureBox()
        Me.AsmWordValuesComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AsmByteValuesComboBox = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CompressTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.BASICGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RemoveZerosCheck = New System.Windows.Forms.CheckBox()
        Me.LineNumberLabel = New System.Windows.Forms.Label()
        Me.IntervalLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SizeLineComboBox = New System.Windows.Forms.ComboBox()
        Me.CodeOutputComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OthersTab = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridColorButton = New System.Windows.Forms.Button()
        Me.OutputdataGroupBox = New System.Windows.Forms.GroupBox()
        Me.OutputText = New System.Windows.Forms.TextBox()
        Me.ColorConfigsLabel = New System.Windows.Forms.Label()
        Me.ColorConfigsComboBox = New System.Windows.Forms.ComboBox()
        Me.InitProjectGroupBox = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BottonsPanel.SuspendLayout()
        Me.DataOutputTab.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.arrow2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrow1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BASICGroupBox.SuspendLayout()
        Me.OthersTab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.OutputdataGroupBox.SuspendLayout()
        Me.InitProjectGroupBox.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'DataLabelTextBox
        '
        Me.DataLabelTextBox.Location = New System.Drawing.Point(133, 122)
        Me.DataLabelTextBox.Name = "DataLabelTextBox"
        Me.DataLabelTextBox.Size = New System.Drawing.Size(221, 22)
        Me.DataLabelTextBox.TabIndex = 252
        Me.ToolTip1.SetToolTip(Me.DataLabelTextBox, "Data definition command (DB, BYTE, DEFB, etc.)")
        '
        'NumFormatComboBox
        '
        Me.NumFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NumFormatComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NumFormatComboBox.FormattingEnabled = True
        Me.NumFormatComboBox.Items.AddRange(New Object() {"dec n", "dec nnn", "dec nnnd", "hex FF", "hex $FF", "hex #FF", "hex 0FFh", "hex 0xFF", "hex &HFF", "binary 00000000", "binary 00000000b", "binary %00000000", "binary 0b00000000", "binary &B00000000"})
        Me.NumFormatComboBox.Location = New System.Drawing.Point(133, 38)
        Me.NumFormatComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumFormatComboBox.Name = "NumFormatComboBox"
        Me.NumFormatComboBox.Size = New System.Drawing.Size(221, 22)
        Me.NumFormatComboBox.TabIndex = 246
        Me.ToolTip1.SetToolTip(Me.NumFormatComboBox, "Computer number format")
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(468, 94)
        Me.TextBox1.MaxLength = 3
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(52, 22)
        Me.TextBox1.TabIndex = 260
        Me.TextBox1.Text = "128"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Interval lines (for BASIC)")
        Me.TextBox1.Visible = False
        '
        'BASICinitLineTextBox
        '
        Me.BASICinitLineTextBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BASICinitLineTextBox.Location = New System.Drawing.Point(491, 21)
        Me.BASICinitLineTextBox.MaxLength = 5
        Me.BASICinitLineTextBox.Name = "BASICinitLineTextBox"
        Me.BASICinitLineTextBox.Size = New System.Drawing.Size(52, 22)
        Me.BASICinitLineTextBox.TabIndex = 254
        Me.BASICinitLineTextBox.Text = "10000"
        Me.BASICinitLineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.BASICinitLineTextBox, "Initial number of line (for BASIC)")
        '
        'BASICincLineslTextBox
        '
        Me.BASICincLineslTextBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BASICincLineslTextBox.Location = New System.Drawing.Point(491, 49)
        Me.BASICincLineslTextBox.MaxLength = 3
        Me.BASICincLineslTextBox.Name = "BASICincLineslTextBox"
        Me.BASICincLineslTextBox.Size = New System.Drawing.Size(52, 22)
        Me.BASICincLineslTextBox.TabIndex = 255
        Me.BASICincLineslTextBox.Text = "10"
        Me.BASICincLineslTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.BASICincLineslTextBox, "Interval lines (for BASIC)")
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
        'AsmWordDataTextBox
        '
        Me.AsmWordDataTextBox.Location = New System.Drawing.Point(117, 49)
        Me.AsmWordDataTextBox.Name = "AsmWordDataTextBox"
        Me.AsmWordDataTextBox.Size = New System.Drawing.Size(220, 22)
        Me.AsmWordDataTextBox.TabIndex = 247
        Me.ToolTip1.SetToolTip(Me.AsmWordDataTextBox, "Word Data command definition (DW, WORD, DEFW...)")
        '
        'AsmByteDataTextBox
        '
        Me.AsmByteDataTextBox.Location = New System.Drawing.Point(117, 21)
        Me.AsmByteDataTextBox.Name = "AsmByteDataTextBox"
        Me.AsmByteDataTextBox.Size = New System.Drawing.Size(220, 22)
        Me.AsmByteDataTextBox.TabIndex = 247
        Me.ToolTip1.SetToolTip(Me.AsmByteDataTextBox, "Byte Data command definition.")
        '
        'CByteDataTextBox
        '
        Me.CByteDataTextBox.Location = New System.Drawing.Point(119, 21)
        Me.CByteDataTextBox.Name = "CByteDataTextBox"
        Me.CByteDataTextBox.Size = New System.Drawing.Size(220, 22)
        Me.CByteDataTextBox.TabIndex = 261
        Me.ToolTip1.SetToolTip(Me.CByteDataTextBox, "Byte Data command definition for C")
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(125, 21)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(303, 22)
        Me.UserNameTextBox.TabIndex = 254
        Me.ToolTip1.SetToolTip(Me.UserNameTextBox, "Username to assign the author by default in the project information.")
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
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(11, 51)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 22)
        Me.Label14.TabIndex = 259
        Me.Label14.Text = "Ink Color"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label14, "Username to assign the author by default in the project information.")
        '
        'OutputINKcolorButton
        '
        Me.OutputINKcolorButton.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputINKcolorButton.Location = New System.Drawing.Point(150, 50)
        Me.OutputINKcolorButton.Name = "OutputINKcolorButton"
        Me.OutputINKcolorButton.Size = New System.Drawing.Size(108, 26)
        Me.OutputINKcolorButton.TabIndex = 260
        Me.ToolTip1.SetToolTip(Me.OutputINKcolorButton, "Define a color for the color zero to differentiate it from black.")
        Me.OutputINKcolorButton.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 83)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 22)
        Me.Label15.TabIndex = 261
        Me.Label15.Text = "Background Color"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label15, "Username to assign the author by default in the project information.")
        '
        'OutputBGcolorButton
        '
        Me.OutputBGcolorButton.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputBGcolorButton.Location = New System.Drawing.Point(150, 82)
        Me.OutputBGcolorButton.Name = "OutputBGcolorButton"
        Me.OutputBGcolorButton.Size = New System.Drawing.Size(108, 26)
        Me.OutputBGcolorButton.TabIndex = 262
        Me.ToolTip1.SetToolTip(Me.OutputBGcolorButton, "Define a color for the color zero to differentiate it from black.")
        Me.OutputBGcolorButton.UseVisualStyleBackColor = True
        '
        'GroupNameTextBox
        '
        Me.GroupNameTextBox.Location = New System.Drawing.Point(125, 49)
        Me.GroupNameTextBox.Name = "GroupNameTextBox"
        Me.GroupNameTextBox.Size = New System.Drawing.Size(303, 22)
        Me.GroupNameTextBox.TabIndex = 256
        Me.ToolTip1.SetToolTip(Me.GroupNameTextBox, "Username to assign the author by default in the project information.")
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
        'BottonsPanel
        '
        Me.BottonsPanel.BackColor = System.Drawing.Color.Transparent
        Me.BottonsPanel.Controls.Add(Me.OK_Button)
        Me.BottonsPanel.Controls.Add(Me.Cancel_Button)
        Me.BottonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottonsPanel.Location = New System.Drawing.Point(0, 496)
        Me.BottonsPanel.Name = "BottonsPanel"
        Me.BottonsPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.BottonsPanel.Size = New System.Drawing.Size(624, 45)
        Me.BottonsPanel.TabIndex = 257
        '
        'OK_Button
        '
        Me.OK_Button.BackColor = System.Drawing.Color.Transparent
        Me.OK_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.OK_Button.FlatAppearance.BorderSize = 0
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OK_Button.Image = CType(resources.GetObject("OK_Button.Image"), System.Drawing.Image)
        Me.OK_Button.Location = New System.Drawing.Point(380, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(130, 37)
        Me.OK_Button.TabIndex = 3
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.ForeColor = System.Drawing.Color.Black
        Me.Cancel_Button.Image = CType(resources.GetObject("Cancel_Button.Image"), System.Drawing.Image)
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancel_Button.Location = New System.Drawing.Point(510, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(110, 37)
        Me.Cancel_Button.TabIndex = 4
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'DataOutputTab
        '
        Me.DataOutputTab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataOutputTab.Controls.Add(Me.GroupBox3)
        Me.DataOutputTab.Controls.Add(Me.GroupBox2)
        Me.DataOutputTab.Controls.Add(Me.Label21)
        Me.DataOutputTab.Controls.Add(Me.CompressTypeComboBox)
        Me.DataOutputTab.Controls.Add(Me.BASICGroupBox)
        Me.DataOutputTab.Controls.Add(Me.TextBox1)
        Me.DataOutputTab.Controls.Add(Me.DataLabelTextBox)
        Me.DataOutputTab.Controls.Add(Me.Label6)
        Me.DataOutputTab.Controls.Add(Me.SizeLineComboBox)
        Me.DataOutputTab.Controls.Add(Me.NumFormatComboBox)
        Me.DataOutputTab.Controls.Add(Me.CodeOutputComboBox)
        Me.DataOutputTab.Controls.Add(Me.Label5)
        Me.DataOutputTab.Controls.Add(Me.Label1)
        Me.DataOutputTab.Controls.Add(Me.Label2)
        Me.DataOutputTab.Controls.Add(Me.Label3)
        Me.DataOutputTab.Location = New System.Drawing.Point(4, 23)
        Me.DataOutputTab.Name = "DataOutputTab"
        Me.DataOutputTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DataOutputTab.Size = New System.Drawing.Size(592, 450)
        Me.DataOutputTab.TabIndex = 1
        Me.DataOutputTab.Text = "Default Data Output"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CByteDataTextBox)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 255)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 54)
        Me.GroupBox3.TabIndex = 268
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "C"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.arrow2PictureBox)
        Me.GroupBox2.Controls.Add(Me.AsmByteDataTextBox)
        Me.GroupBox2.Controls.Add(Me.arrow1PictureBox)
        Me.GroupBox2.Controls.Add(Me.AsmWordDataTextBox)
        Me.GroupBox2.Controls.Add(Me.AsmWordValuesComboBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.AsmByteValuesComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 83)
        Me.GroupBox2.TabIndex = 267
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Assembler"
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
        Me.Label21.Location = New System.Drawing.Point(17, 10)
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
        Me.CompressTypeComboBox.Items.AddRange(New Object() {"RAW", "RLE", "RLEWB", "Pletter"})
        Me.CompressTypeComboBox.Location = New System.Drawing.Point(133, 94)
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
        Me.BASICGroupBox.Controls.Add(Me.BASICcommentComboBox)
        Me.BASICGroupBox.Controls.Add(Me.Label13)
        Me.BASICGroupBox.Controls.Add(Me.Label9)
        Me.BASICGroupBox.Controls.Add(Me.BASICdataTextBox)
        Me.BASICGroupBox.Controls.Add(Me.RemoveZerosCheck)
        Me.BASICGroupBox.Controls.Add(Me.LineNumberLabel)
        Me.BASICGroupBox.Controls.Add(Me.BASICincLineslTextBox)
        Me.BASICGroupBox.Controls.Add(Me.BASICinitLineTextBox)
        Me.BASICGroupBox.Controls.Add(Me.IntervalLabel)
        Me.BASICGroupBox.ForeColor = System.Drawing.Color.Black
        Me.BASICGroupBox.Location = New System.Drawing.Point(17, 323)
        Me.BASICGroupBox.Name = "BASICGroupBox"
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
        'Label6
        '
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(368, 94)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 22)
        Me.Label6.TabIndex = 259
        Me.Label6.Text = "RLE WB DC"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'SizeLineComboBox
        '
        Me.SizeLineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SizeLineComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SizeLineComboBox.FormattingEnabled = True
        Me.SizeLineComboBox.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "24", "32"})
        Me.SizeLineComboBox.Location = New System.Drawing.Point(133, 66)
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
        Me.CodeOutputComboBox.Items.AddRange(New Object() {"Assembler default", "Assembler SJasm", "Assembler SDCC", "BASIC", "C"})
        Me.CodeOutputComboBox.Location = New System.Drawing.Point(133, 10)
        Me.CodeOutputComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CodeOutputComboBox.Name = "CodeOutputComboBox"
        Me.CodeOutputComboBox.Size = New System.Drawing.Size(221, 22)
        Me.CodeOutputComboBox.TabIndex = 241
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(19, 122)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 22)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "Label:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 22)
        Me.Label1.TabIndex = 248
        Me.Label1.Text = "Number system:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 22)
        Me.Label2.TabIndex = 249
        Me.Label2.Text = "Line size:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 22)
        Me.Label3.TabIndex = 250
        Me.Label3.Text = "Compress:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OthersTab
        '
        Me.OthersTab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OthersTab.Controls.Add(Me.GroupBox1)
        Me.OthersTab.Controls.Add(Me.OutputdataGroupBox)
        Me.OthersTab.Controls.Add(Me.InitProjectGroupBox)
        Me.OthersTab.Location = New System.Drawing.Point(4, 23)
        Me.OthersTab.Name = "OthersTab"
        Me.OthersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.OthersTab.Size = New System.Drawing.Size(592, 450)
        Me.OthersTab.TabIndex = 2
        Me.OthersTab.Text = "General"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridColorButton)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Color0Button)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 93)
        Me.GroupBox1.TabIndex = 262
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colors"
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
        'OutputdataGroupBox
        '
        Me.OutputdataGroupBox.Controls.Add(Me.OutputText)
        Me.OutputdataGroupBox.Controls.Add(Me.OutputBGcolorButton)
        Me.OutputdataGroupBox.Controls.Add(Me.Label15)
        Me.OutputdataGroupBox.Controls.Add(Me.OutputINKcolorButton)
        Me.OutputdataGroupBox.Controls.Add(Me.Label14)
        Me.OutputdataGroupBox.Controls.Add(Me.ColorConfigsLabel)
        Me.OutputdataGroupBox.Controls.Add(Me.ColorConfigsComboBox)
        Me.OutputdataGroupBox.Location = New System.Drawing.Point(38, 268)
        Me.OutputdataGroupBox.Name = "OutputdataGroupBox"
        Me.OutputdataGroupBox.Size = New System.Drawing.Size(535, 118)
        Me.OutputdataGroupBox.TabIndex = 261
        Me.OutputdataGroupBox.TabStop = False
        Me.OutputdataGroupBox.Text = "Output Data colors"
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
        Me.ColorConfigsLabel.Size = New System.Drawing.Size(130, 22)
        Me.ColorConfigsLabel.TabIndex = 242
        Me.ColorConfigsLabel.Text = "Palettes:"
        Me.ColorConfigsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ColorConfigsComboBox
        '
        Me.ColorConfigsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ColorConfigsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ColorConfigsComboBox.FormattingEnabled = True
        Me.ColorConfigsComboBox.Items.AddRange(New Object() {"Gray (default)", "Blue MSX BASIC", "GreenBoy"})
        Me.ColorConfigsComboBox.Location = New System.Drawing.Point(150, 21)
        Me.ColorConfigsComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ColorConfigsComboBox.Name = "ColorConfigsComboBox"
        Me.ColorConfigsComboBox.Size = New System.Drawing.Size(124, 22)
        Me.ColorConfigsComboBox.TabIndex = 243
        '
        'InitProjectGroupBox
        '
        Me.InitProjectGroupBox.Controls.Add(Me.GroupNameTextBox)
        Me.InitProjectGroupBox.Controls.Add(Me.Label16)
        Me.InitProjectGroupBox.Controls.Add(Me.UserNameTextBox)
        Me.InitProjectGroupBox.Controls.Add(Me.Label10)
        Me.InitProjectGroupBox.Enabled = False
        Me.InitProjectGroupBox.Location = New System.Drawing.Point(38, 28)
        Me.InitProjectGroupBox.Name = "InitProjectGroupBox"
        Me.InitProjectGroupBox.Size = New System.Drawing.Size(535, 119)
        Me.InitProjectGroupBox.TabIndex = 256
        Me.InitProjectGroupBox.TabStop = False
        Me.InitProjectGroupBox.Text = "Default Project Info"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.OthersTab)
        Me.TabControl1.Controls.Add(Me.DataOutputTab)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(600, 477)
        Me.TabControl1.TabIndex = 256
        '
        'MiniConfigWin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(624, 541)
        Me.ControlBox = False
        Me.Controls.Add(Me.BottonsPanel)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MiniConfigWin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "devTools Config"
        Me.BottonsPanel.ResumeLayout(False)
        Me.DataOutputTab.ResumeLayout(False)
        Me.DataOutputTab.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.arrow2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrow1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BASICGroupBox.ResumeLayout(False)
        Me.BASICGroupBox.PerformLayout()
        Me.OthersTab.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.OutputdataGroupBox.ResumeLayout(False)
        Me.OutputdataGroupBox.PerformLayout()
        Me.InitProjectGroupBox.ResumeLayout(False)
        Me.InitProjectGroupBox.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BottonsPanel As Panel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents DataOutputTab As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CByteDataTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents BASICGroupBox As GroupBox
    Friend WithEvents BASICcommentComboBox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BASICdataTextBox As TextBox
    Friend WithEvents RemoveZerosCheck As CheckBox
    Friend WithEvents LineNumberLabel As Label
    Friend WithEvents BASICincLineslTextBox As TextBox
    Friend WithEvents BASICinitLineTextBox As TextBox
    Friend WithEvents IntervalLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataLabelTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SizeLineComboBox As ComboBox
    Friend WithEvents NumFormatComboBox As ComboBox
    Friend WithEvents CodeOutputComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OthersTab As TabPage
    Friend WithEvents OutputdataGroupBox As GroupBox
    Friend WithEvents OutputBGcolorButton As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents OutputINKcolorButton As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents ColorConfigsLabel As Label
    Friend WithEvents ColorConfigsComboBox As ComboBox
    Friend WithEvents GridColorButton As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Color0Button As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents InitProjectGroupBox As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents OutputText As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupNameTextBox As TextBox
    Friend WithEvents Label16 As Label
End Class
