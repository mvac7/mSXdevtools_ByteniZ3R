﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataTypeInputControl
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataTypeInputControl))
        Me.WordDataLabel = New System.Windows.Forms.Label()
        Me.AsmWordDataTextBox = New System.Windows.Forms.TextBox()
        Me.AddIndexCheck = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AsmByteDataTextBox = New System.Windows.Forms.TextBox()
        Me.SizeLineComboBox = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NumberSystemLabel = New System.Windows.Forms.Label()
        Me.CompressComboBox = New System.Windows.Forms.ComboBox()
        Me.CompressLabel = New System.Windows.Forms.Label()
        Me.LineNumberLabel = New System.Windows.Forms.Label()
        Me.IntervalText = New System.Windows.Forms.TextBox()
        Me.LineNumberText = New System.Windows.Forms.TextBox()
        Me.IntervalLabel = New System.Windows.Forms.Label()
        Me.RemoveZerosCheck = New System.Windows.Forms.CheckBox()
        Me.NumberSystemCombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LanguageComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UnsignedByteDefTextBox = New System.Windows.Forms.TextBox()
        Me.BasicPanel = New System.Windows.Forms.Panel()
        Me.AssemblerPanel = New System.Windows.Forms.Panel()
        Me.AsmFieldNameTextBox = New System.Windows.Forms.TextBox()
        Me.AsmFieldNameLabel = New System.Windows.Forms.Label()
        Me.CesPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SignedByteDefTextBox = New System.Windows.Forms.TextBox()
        Me.CesFieldNameTextBox = New System.Windows.Forms.TextBox()
        Me.CesFieldNameLabel = New System.Windows.Forms.Label()
        Me.BasicPanel.SuspendLayout()
        Me.AssemblerPanel.SuspendLayout()
        Me.CesPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'WordDataLabel
        '
        Me.WordDataLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WordDataLabel.ForeColor = System.Drawing.Color.Black
        Me.WordDataLabel.Location = New System.Drawing.Point(10, 61)
        Me.WordDataLabel.Name = "WordDataLabel"
        Me.WordDataLabel.Size = New System.Drawing.Size(94, 21)
        Me.WordDataLabel.TabIndex = 271
        Me.WordDataLabel.Text = "Word data:"
        Me.WordDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AsmWordDataTextBox
        '
        Me.AsmWordDataTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AsmWordDataTextBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsmWordDataTextBox.ForeColor = System.Drawing.Color.Black
        Me.AsmWordDataTextBox.Location = New System.Drawing.Point(107, 61)
        Me.AsmWordDataTextBox.MaxLength = 128
        Me.AsmWordDataTextBox.Name = "AsmWordDataTextBox"
        Me.AsmWordDataTextBox.Size = New System.Drawing.Size(120, 22)
        Me.AsmWordDataTextBox.TabIndex = 270
        '
        'AddIndexCheck
        '
        Me.AddIndexCheck.AutoSize = True
        Me.AddIndexCheck.BackColor = System.Drawing.Color.Transparent
        Me.AddIndexCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddIndexCheck.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddIndexCheck.ForeColor = System.Drawing.Color.Black
        Me.AddIndexCheck.Location = New System.Drawing.Point(31, 88)
        Me.AddIndexCheck.Name = "AddIndexCheck"
        Me.AddIndexCheck.Size = New System.Drawing.Size(90, 18)
        Me.AddIndexCheck.TabIndex = 269
        Me.AddIndexCheck.Text = "Add Index"
        Me.AddIndexCheck.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Byte data:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AsmByteDataTextBox
        '
        Me.AsmByteDataTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AsmByteDataTextBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsmByteDataTextBox.ForeColor = System.Drawing.Color.Black
        Me.AsmByteDataTextBox.Location = New System.Drawing.Point(107, 34)
        Me.AsmByteDataTextBox.MaxLength = 128
        Me.AsmByteDataTextBox.Name = "AsmByteDataTextBox"
        Me.AsmByteDataTextBox.Size = New System.Drawing.Size(120, 22)
        Me.AsmByteDataTextBox.TabIndex = 14
        '
        'SizeLineComboBox
        '
        Me.SizeLineComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SizeLineComboBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SizeLineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SizeLineComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SizeLineComboBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SizeLineComboBox.ForeColor = System.Drawing.Color.Black
        Me.SizeLineComboBox.FormattingEnabled = True
        Me.SizeLineComboBox.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "24", "32"})
        Me.SizeLineComboBox.Location = New System.Drawing.Point(101, 84)
        Me.SizeLineComboBox.Name = "SizeLineComboBox"
        Me.SizeLineComboBox.Size = New System.Drawing.Size(150, 22)
        Me.SizeLineComboBox.TabIndex = 259
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(0, 84)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 21)
        Me.Label17.TabIndex = 258
        Me.Label17.Text = "Line size:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumberSystemLabel
        '
        Me.NumberSystemLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberSystemLabel.ForeColor = System.Drawing.Color.Black
        Me.NumberSystemLabel.Location = New System.Drawing.Point(0, 29)
        Me.NumberSystemLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NumberSystemLabel.Name = "NumberSystemLabel"
        Me.NumberSystemLabel.Size = New System.Drawing.Size(100, 21)
        Me.NumberSystemLabel.TabIndex = 257
        Me.NumberSystemLabel.Text = "Number sys:"
        Me.NumberSystemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompressComboBox
        '
        Me.CompressComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompressComboBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CompressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompressComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CompressComboBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompressComboBox.ForeColor = System.Drawing.Color.Black
        Me.CompressComboBox.FormattingEnabled = True
        Me.CompressComboBox.Items.AddRange(New Object() {"RAW", "RLE", "WRLE", "Pletter5c"})
        Me.CompressComboBox.Location = New System.Drawing.Point(101, 57)
        Me.CompressComboBox.Name = "CompressComboBox"
        Me.CompressComboBox.Size = New System.Drawing.Size(150, 22)
        Me.CompressComboBox.TabIndex = 256
        '
        'CompressLabel
        '
        Me.CompressLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompressLabel.ForeColor = System.Drawing.Color.Black
        Me.CompressLabel.Location = New System.Drawing.Point(0, 56)
        Me.CompressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CompressLabel.Name = "CompressLabel"
        Me.CompressLabel.Size = New System.Drawing.Size(100, 21)
        Me.CompressLabel.TabIndex = 255
        Me.CompressLabel.Text = "Compress:"
        Me.CompressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LineNumberLabel
        '
        Me.LineNumberLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LineNumberLabel.ForeColor = System.Drawing.Color.Black
        Me.LineNumberLabel.Location = New System.Drawing.Point(14, 10)
        Me.LineNumberLabel.Name = "LineNumberLabel"
        Me.LineNumberLabel.Size = New System.Drawing.Size(100, 14)
        Me.LineNumberLabel.TabIndex = 13
        Me.LineNumberLabel.Text = "Line number:"
        Me.LineNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IntervalText
        '
        Me.IntervalText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.IntervalText.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntervalText.ForeColor = System.Drawing.Color.Black
        Me.IntervalText.Location = New System.Drawing.Point(117, 34)
        Me.IntervalText.MaxLength = 3
        Me.IntervalText.Name = "IntervalText"
        Me.IntervalText.Size = New System.Drawing.Size(52, 22)
        Me.IntervalText.TabIndex = 4
        Me.IntervalText.Text = "10"
        Me.IntervalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LineNumberText
        '
        Me.LineNumberText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LineNumberText.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LineNumberText.ForeColor = System.Drawing.Color.Black
        Me.LineNumberText.Location = New System.Drawing.Point(117, 7)
        Me.LineNumberText.MaxLength = 5
        Me.LineNumberText.Name = "LineNumberText"
        Me.LineNumberText.Size = New System.Drawing.Size(52, 22)
        Me.LineNumberText.TabIndex = 3
        Me.LineNumberText.Text = "10000"
        Me.LineNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IntervalLabel
        '
        Me.IntervalLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntervalLabel.ForeColor = System.Drawing.Color.Black
        Me.IntervalLabel.Location = New System.Drawing.Point(14, 37)
        Me.IntervalLabel.Name = "IntervalLabel"
        Me.IntervalLabel.Size = New System.Drawing.Size(100, 14)
        Me.IntervalLabel.TabIndex = 14
        Me.IntervalLabel.Text = "Interval:"
        Me.IntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RemoveZerosCheck
        '
        Me.RemoveZerosCheck.AutoSize = True
        Me.RemoveZerosCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoveZerosCheck.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveZerosCheck.ForeColor = System.Drawing.Color.Black
        Me.RemoveZerosCheck.Location = New System.Drawing.Point(15, 62)
        Me.RemoveZerosCheck.Name = "RemoveZerosCheck"
        Me.RemoveZerosCheck.Size = New System.Drawing.Size(115, 18)
        Me.RemoveZerosCheck.TabIndex = 8
        Me.RemoveZerosCheck.Text = "Remove zeros"
        Me.RemoveZerosCheck.UseVisualStyleBackColor = True
        '
        'NumberSystemCombo
        '
        Me.NumberSystemCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberSystemCombo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NumberSystemCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NumberSystemCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumberSystemCombo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberSystemCombo.ForeColor = System.Drawing.Color.Black
        Me.NumberSystemCombo.FormattingEnabled = True
        Me.NumberSystemCombo.Items.AddRange(New Object() {"decimal n", "decimal nnn", "decimal nnnd", "hexadecimal FF", "hexadecimal $FF", "hexadecimal #FF", "hexadecimal 0FFh", "hexadecimal 0xFF", "hexadecimal &HFF", "binary 00000000", "binary 00000000b", "binary %00000000", "binary 0b00000000", "binary &B00000000"})
        Me.NumberSystemCombo.Location = New System.Drawing.Point(101, 30)
        Me.NumberSystemCombo.Name = "NumberSystemCombo"
        Me.NumberSystemCombo.Size = New System.Drawing.Size(150, 22)
        Me.NumberSystemCombo.TabIndex = 252
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 253
        Me.Label1.Text = "Language:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LanguageComboBox
        '
        Me.LanguageComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LanguageComboBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LanguageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LanguageComboBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LanguageComboBox.ForeColor = System.Drawing.Color.Black
        Me.LanguageComboBox.FormattingEnabled = True
        Me.LanguageComboBox.Items.AddRange(New Object() {"BASIC", "C", "Assembler default", "Assembler asMSX", "Assembler tniASM", "Assembler SJasm", "Assembler SDCC"})
        Me.LanguageComboBox.Location = New System.Drawing.Point(101, 3)
        Me.LanguageComboBox.Name = "LanguageComboBox"
        Me.LanguageComboBox.Size = New System.Drawing.Size(150, 22)
        Me.LanguageComboBox.TabIndex = 251
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Unsigned:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UnsignedByteDefTextBox
        '
        Me.UnsignedByteDefTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UnsignedByteDefTextBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnsignedByteDefTextBox.ForeColor = System.Drawing.Color.Black
        Me.UnsignedByteDefTextBox.Location = New System.Drawing.Point(107, 34)
        Me.UnsignedByteDefTextBox.MaxLength = 128
        Me.UnsignedByteDefTextBox.Name = "UnsignedByteDefTextBox"
        Me.UnsignedByteDefTextBox.Size = New System.Drawing.Size(120, 22)
        Me.UnsignedByteDefTextBox.TabIndex = 14
        '
        'BasicPanel
        '
        Me.BasicPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BasicPanel.BackColor = System.Drawing.Color.Transparent
        Me.BasicPanel.BackgroundImage = CType(resources.GetObject("BasicPanel.BackgroundImage"), System.Drawing.Image)
        Me.BasicPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BasicPanel.Controls.Add(Me.LineNumberLabel)
        Me.BasicPanel.Controls.Add(Me.LineNumberText)
        Me.BasicPanel.Controls.Add(Me.IntervalText)
        Me.BasicPanel.Controls.Add(Me.RemoveZerosCheck)
        Me.BasicPanel.Controls.Add(Me.IntervalLabel)
        Me.BasicPanel.Location = New System.Drawing.Point(258, 4)
        Me.BasicPanel.Name = "BasicPanel"
        Me.BasicPanel.Size = New System.Drawing.Size(241, 111)
        Me.BasicPanel.TabIndex = 262
        '
        'AssemblerPanel
        '
        Me.AssemblerPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AssemblerPanel.BackColor = System.Drawing.Color.Transparent
        Me.AssemblerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AssemblerPanel.Controls.Add(Me.AsmFieldNameTextBox)
        Me.AssemblerPanel.Controls.Add(Me.AsmFieldNameLabel)
        Me.AssemblerPanel.Controls.Add(Me.WordDataLabel)
        Me.AssemblerPanel.Controls.Add(Me.AsmByteDataTextBox)
        Me.AssemblerPanel.Controls.Add(Me.AsmWordDataTextBox)
        Me.AssemblerPanel.Controls.Add(Me.Label7)
        Me.AssemblerPanel.Controls.Add(Me.AddIndexCheck)
        Me.AssemblerPanel.Location = New System.Drawing.Point(258, 120)
        Me.AssemblerPanel.Name = "AssemblerPanel"
        Me.AssemblerPanel.Size = New System.Drawing.Size(241, 111)
        Me.AssemblerPanel.TabIndex = 263
        '
        'AsmFieldNameTextBox
        '
        Me.AsmFieldNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AsmFieldNameTextBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsmFieldNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.AsmFieldNameTextBox.Location = New System.Drawing.Point(107, 7)
        Me.AsmFieldNameTextBox.Name = "AsmFieldNameTextBox"
        Me.AsmFieldNameTextBox.Size = New System.Drawing.Size(120, 22)
        Me.AsmFieldNameTextBox.TabIndex = 273
        Me.AsmFieldNameTextBox.Text = "DATA"
        '
        'AsmFieldNameLabel
        '
        Me.AsmFieldNameLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsmFieldNameLabel.ForeColor = System.Drawing.Color.Black
        Me.AsmFieldNameLabel.Location = New System.Drawing.Point(10, 7)
        Me.AsmFieldNameLabel.Name = "AsmFieldNameLabel"
        Me.AsmFieldNameLabel.Size = New System.Drawing.Size(94, 21)
        Me.AsmFieldNameLabel.TabIndex = 272
        Me.AsmFieldNameLabel.Text = "Field name:"
        Me.AsmFieldNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CesPanel
        '
        Me.CesPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CesPanel.BackColor = System.Drawing.Color.Transparent
        Me.CesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CesPanel.Controls.Add(Me.Label2)
        Me.CesPanel.Controls.Add(Me.SignedByteDefTextBox)
        Me.CesPanel.Controls.Add(Me.Label4)
        Me.CesPanel.Controls.Add(Me.CesFieldNameTextBox)
        Me.CesPanel.Controls.Add(Me.UnsignedByteDefTextBox)
        Me.CesPanel.Controls.Add(Me.CesFieldNameLabel)
        Me.CesPanel.Location = New System.Drawing.Point(258, 237)
        Me.CesPanel.Name = "CesPanel"
        Me.CesPanel.Size = New System.Drawing.Size(241, 111)
        Me.CesPanel.TabIndex = 264
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 277
        Me.Label2.Text = "Signed:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SignedByteDefTextBox
        '
        Me.SignedByteDefTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SignedByteDefTextBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignedByteDefTextBox.ForeColor = System.Drawing.Color.Black
        Me.SignedByteDefTextBox.Location = New System.Drawing.Point(107, 62)
        Me.SignedByteDefTextBox.MaxLength = 128
        Me.SignedByteDefTextBox.Name = "SignedByteDefTextBox"
        Me.SignedByteDefTextBox.Size = New System.Drawing.Size(120, 22)
        Me.SignedByteDefTextBox.TabIndex = 276
        '
        'CesFieldNameTextBox
        '
        Me.CesFieldNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CesFieldNameTextBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CesFieldNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.CesFieldNameTextBox.Location = New System.Drawing.Point(107, 7)
        Me.CesFieldNameTextBox.Name = "CesFieldNameTextBox"
        Me.CesFieldNameTextBox.Size = New System.Drawing.Size(120, 22)
        Me.CesFieldNameTextBox.TabIndex = 275
        Me.CesFieldNameTextBox.Text = "DATA"
        '
        'CesFieldNameLabel
        '
        Me.CesFieldNameLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CesFieldNameLabel.ForeColor = System.Drawing.Color.Black
        Me.CesFieldNameLabel.Location = New System.Drawing.Point(10, 7)
        Me.CesFieldNameLabel.Name = "CesFieldNameLabel"
        Me.CesFieldNameLabel.Size = New System.Drawing.Size(94, 21)
        Me.CesFieldNameLabel.TabIndex = 274
        Me.CesFieldNameLabel.Text = "Field name:"
        Me.CesFieldNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataTypeInputControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.CesPanel)
        Me.Controls.Add(Me.AssemblerPanel)
        Me.Controls.Add(Me.BasicPanel)
        Me.Controls.Add(Me.SizeLineComboBox)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.NumberSystemLabel)
        Me.Controls.Add(Me.CompressComboBox)
        Me.Controls.Add(Me.CompressLabel)
        Me.Controls.Add(Me.NumberSystemCombo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LanguageComboBox)
        Me.Name = "DataTypeInputControl"
        Me.Size = New System.Drawing.Size(500, 353)
        Me.BasicPanel.ResumeLayout(False)
        Me.BasicPanel.PerformLayout()
        Me.AssemblerPanel.ResumeLayout(False)
        Me.AssemblerPanel.PerformLayout()
        Me.CesPanel.ResumeLayout(False)
        Me.CesPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WordDataLabel As System.Windows.Forms.Label
    Friend WithEvents AsmWordDataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddIndexCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AsmByteDataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SizeLineComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents NumberSystemLabel As System.Windows.Forms.Label
    Friend WithEvents CompressComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CompressLabel As System.Windows.Forms.Label
    Friend WithEvents LineNumberLabel As System.Windows.Forms.Label
    Friend WithEvents IntervalText As System.Windows.Forms.TextBox
    Friend WithEvents LineNumberText As System.Windows.Forms.TextBox
    Friend WithEvents IntervalLabel As System.Windows.Forms.Label
    Friend WithEvents RemoveZerosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents NumberSystemCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LanguageComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UnsignedByteDefTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BasicPanel As Panel
    Friend WithEvents AssemblerPanel As Panel
    Friend WithEvents AsmFieldNameTextBox As TextBox
    Friend WithEvents AsmFieldNameLabel As Label
    Friend WithEvents CesPanel As Panel
    Friend WithEvents CesFieldNameTextBox As TextBox
    Friend WithEvents CesFieldNameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SignedByteDefTextBox As TextBox
End Class
