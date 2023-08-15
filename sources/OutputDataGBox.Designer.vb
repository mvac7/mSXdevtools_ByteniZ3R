<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OutputDataGBox
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PiXelGroupBox1 = New ByteniZ3R.piXelST_GroupBox()
        Me.OutputButtonsPanel = New System.Windows.Forms.Panel()
        Me.CopyAllButton = New ByteniZ3R.piXelST_Button()
        Me.SaveSourceButton = New ByteniZ3R.piXelST_Button()
        Me.SaveCompressFileButton = New ByteniZ3R.piXelST_Button()
        Me.DataTypeInput = New ByteniZ3R.DataTypeInputControl()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PiXelGroupBox1.SuspendLayout()
        Me.OutputButtonsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PiXelGroupBox1
        '
        Me.PiXelGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.PiXelGroupBox1.BGColor = System.Drawing.Color.LightGray
        Me.PiXelGroupBox1.Controls.Add(Me.OutputButtonsPanel)
        Me.PiXelGroupBox1.Controls.Add(Me.DataTypeInput)
        Me.PiXelGroupBox1.Controls.Add(Me.OutputTextBox)
        Me.PiXelGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PiXelGroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PiXelGroupBox1.LineColor = System.Drawing.Color.DimGray
        Me.PiXelGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.PiXelGroupBox1.MinimumSize = New System.Drawing.Size(600, 260)
        Me.PiXelGroupBox1.Name = "PiXelGroupBox1"
        Me.PiXelGroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.PiXelGroupBox1.Size = New System.Drawing.Size(600, 260)
        Me.PiXelGroupBox1.TabIndex = 5
        Me.PiXelGroupBox1.TabStop = False
        Me.PiXelGroupBox1.Text = "Output Data"
        '
        'OutputButtonsPanel
        '
        Me.OutputButtonsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputButtonsPanel.BackColor = System.Drawing.Color.Transparent
        Me.OutputButtonsPanel.Controls.Add(Me.CopyAllButton)
        Me.OutputButtonsPanel.Controls.Add(Me.SaveSourceButton)
        Me.OutputButtonsPanel.Controls.Add(Me.SaveCompressFileButton)
        Me.OutputButtonsPanel.Location = New System.Drawing.Point(10, 214)
        Me.OutputButtonsPanel.Name = "OutputButtonsPanel"
        Me.OutputButtonsPanel.Size = New System.Drawing.Size(580, 40)
        Me.OutputButtonsPanel.TabIndex = 70
        '
        'CopyAllButton
        '
        Me.CopyAllButton.BackColor = System.Drawing.Color.LightGray
        Me.CopyAllButton.ButtonColor = System.Drawing.Color.Gray
        Me.CopyAllButton.ButtonType = ByteniZ3R.piXelST_Button.Button_TYPES.Confirmation
        Me.CopyAllButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CopyAllButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CopyAllButton.FlatAppearance.BorderSize = 0
        Me.CopyAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyAllButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CopyAllButton.Location = New System.Drawing.Point(10, 0)
        Me.CopyAllButton.Name = "CopyAllButton"
        Me.CopyAllButton.Padding = New System.Windows.Forms.Padding(4)
        Me.CopyAllButton.Size = New System.Drawing.Size(154, 40)
        Me.CopyAllButton.TabIndex = 41
        Me.CopyAllButton.Text = "Copy All"
        Me.ToolTip1.SetToolTip(Me.CopyAllButton, "Copy all source code to clipboard [Ctrl+A]")
        Me.CopyAllButton.UseVisualStyleBackColor = False
        '
        'SaveSourceButton
        '
        Me.SaveSourceButton.BackColor = System.Drawing.Color.LightGray
        Me.SaveSourceButton.ButtonColor = System.Drawing.Color.Gray
        Me.SaveSourceButton.ButtonType = ByteniZ3R.piXelST_Button.Button_TYPES.Save
        Me.SaveSourceButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveSourceButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveSourceButton.FlatAppearance.BorderSize = 0
        Me.SaveSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveSourceButton.ForeColor = System.Drawing.Color.Black
        Me.SaveSourceButton.Location = New System.Drawing.Point(164, 0)
        Me.SaveSourceButton.Name = "SaveSourceButton"
        Me.SaveSourceButton.Padding = New System.Windows.Forms.Padding(4)
        Me.SaveSourceButton.Size = New System.Drawing.Size(208, 40)
        Me.SaveSourceButton.TabIndex = 42
        Me.SaveSourceButton.Text = "Save Source"
        Me.SaveSourceButton.UseVisualStyleBackColor = False
        '
        'SaveCompressFileButton
        '
        Me.SaveCompressFileButton.BackColor = System.Drawing.Color.LightGray
        Me.SaveCompressFileButton.ButtonColor = System.Drawing.Color.Gray
        Me.SaveCompressFileButton.ButtonType = ByteniZ3R.piXelST_Button.Button_TYPES.Save
        Me.SaveCompressFileButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveCompressFileButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveCompressFileButton.FlatAppearance.BorderSize = 0
        Me.SaveCompressFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveCompressFileButton.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCompressFileButton.ForeColor = System.Drawing.Color.Black
        Me.SaveCompressFileButton.Location = New System.Drawing.Point(372, 0)
        Me.SaveCompressFileButton.Name = "SaveCompressFileButton"
        Me.SaveCompressFileButton.Padding = New System.Windows.Forms.Padding(4)
        Me.SaveCompressFileButton.Size = New System.Drawing.Size(208, 40)
        Me.SaveCompressFileButton.TabIndex = 43
        Me.SaveCompressFileButton.Text = "Save Binary"
        Me.SaveCompressFileButton.UseVisualStyleBackColor = False
        '
        'DataTypeInput
        '
        Me.DataTypeInput.AsmDataByteCommand = ""
        Me.DataTypeInput.AsmDataWordCommand = ""
        Me.DataTypeInput.BackColor = System.Drawing.Color.Transparent
        Me.DataTypeInput.BASIClineInterval = 10
        Me.DataTypeInput.BASIClineNumber = 10000
        Me.DataTypeInput.BASICremoveZeros = False
        Me.DataTypeInput.CompressType = ByteniZ3R.DataTypeInputControl.COMPRESS_TYPE.RAW
        Me.DataTypeInput.EnableAssemblerIndex = False
        Me.DataTypeInput.EnableCompress = False
        Me.DataTypeInput.EnableDataLineSize = False
        Me.DataTypeInput.FieldName = "DATA"
        Me.DataTypeInput.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataTypeInput.LanguageCode = ByteniZ3R.CodeInfo.LANGUAGE_CODE.BASIC
        Me.DataTypeInput.LineSizeIndex = 6
        Me.DataTypeInput.Location = New System.Drawing.Point(14, 26)
        Me.DataTypeInput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataTypeInput.Name = "DataTypeInput"
        Me.DataTypeInput.NumeralSystem = -1
        Me.DataTypeInput.Size = New System.Drawing.Size(540, 117)
        Me.DataTypeInput.TabIndex = 68
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputTextBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputTextBox.ForeColor = System.Drawing.Color.Black
        Me.OutputTextBox.Location = New System.Drawing.Point(14, 150)
        Me.OutputTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputTextBox.Size = New System.Drawing.Size(572, 58)
        Me.OutputTextBox.TabIndex = 40
        Me.OutputTextBox.TabStop = False
        '
        'OutputDataGBox
        '
        Me.Controls.Add(Me.PiXelGroupBox1)
        Me.MinimumSize = New System.Drawing.Size(600, 260)
        Me.Name = "OutputDataGBox"
        Me.Size = New System.Drawing.Size(600, 260)
        Me.PiXelGroupBox1.ResumeLayout(False)
        Me.PiXelGroupBox1.PerformLayout()
        Me.OutputButtonsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents DataTypeInput As DataTypeInputControl
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents OutputButtonsPanel As Panel
    Friend WithEvents CopyAllButton As piXelST_Button
    Friend WithEvents SaveSourceButton As piXelST_Button
    Friend WithEvents SaveCompressFileButton As piXelST_Button
    Friend WithEvents PiXelGroupBox1 As piXelST_GroupBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
