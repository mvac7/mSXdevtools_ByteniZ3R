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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CopyAllButton = New mSXdevtools.GUI.piXelST.pxButton()
        Me.PiXelGroupBox1 = New mSXdevtools.GUI.piXelST.pxGroupBox()
        Me.OutputButtonsPanel = New System.Windows.Forms.Panel()
        Me.SaveSourceButton = New mSXdevtools.GUI.piXelST.pxButton()
        Me.SaveCompressFileButton = New mSXdevtools.GUI.piXelST.pxButton()
        Me.DataTypeInput = New mSXdevtools.GUI.Controls.DataTypeInputControl()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.PiXelGroupBox1.SuspendLayout()
        Me.OutputButtonsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CopyAllButton
        '
        Me.CopyAllButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CopyAllButton.ButtonType = mSXdevtools.GUI.piXelST.pxButton.Button_TYPES.Confirmation
        Me.CopyAllButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CopyAllButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CopyAllButton.Location = New System.Drawing.Point(0, 0)
        Me.CopyAllButton.Name = "CopyAllButton"
        Me.CopyAllButton.Padding = New System.Windows.Forms.Padding(4)
        Me.CopyAllButton.Size = New System.Drawing.Size(156, 32)
        Me.CopyAllButton.TabIndex = 41
        Me.CopyAllButton.Text = "Copy All"
        Me.CopyAllButton.Tooltip = "Copy all source code to clipboard [Ctrl+A]"
        '
        'PiXelGroupBox1
        '
        Me.PiXelGroupBox1.Controls.Add(Me.OutputButtonsPanel)
        Me.PiXelGroupBox1.Controls.Add(Me.DataTypeInput)
        Me.PiXelGroupBox1.Controls.Add(Me.OutputTextBox)
        Me.PiXelGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PiXelGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.PiXelGroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PiXelGroupBox1.MinimumSize = New System.Drawing.Size(600, 260)
        Me.PiXelGroupBox1.Name = "PiXelGroupBox1"
        Me.PiXelGroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.PiXelGroupBox1.Size = New System.Drawing.Size(810, 260)
        Me.PiXelGroupBox1.TabIndex = 5
        Me.PiXelGroupBox1.TabStop = False
        Me.PiXelGroupBox1.Text = "Output Data"
        '
        'OutputButtonsPanel
        '
        Me.OutputButtonsPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputButtonsPanel.BackColor = System.Drawing.Color.Transparent
        Me.OutputButtonsPanel.Controls.Add(Me.CopyAllButton)
        Me.OutputButtonsPanel.Controls.Add(Me.SaveSourceButton)
        Me.OutputButtonsPanel.Controls.Add(Me.SaveCompressFileButton)
        Me.OutputButtonsPanel.Location = New System.Drawing.Point(224, 214)
        Me.OutputButtonsPanel.Name = "OutputButtonsPanel"
        Me.OutputButtonsPanel.Size = New System.Drawing.Size(572, 32)
        Me.OutputButtonsPanel.TabIndex = 70
        '
        'SaveSourceButton
        '
        Me.SaveSourceButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SaveSourceButton.ButtonType = mSXdevtools.GUI.piXelST.pxButton.Button_TYPES.Save
        Me.SaveSourceButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveSourceButton.ForeColor = System.Drawing.Color.Black
        Me.SaveSourceButton.Location = New System.Drawing.Point(156, 0)
        Me.SaveSourceButton.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.SaveSourceButton.Name = "SaveSourceButton"
        Me.SaveSourceButton.Padding = New System.Windows.Forms.Padding(4)
        Me.SaveSourceButton.Size = New System.Drawing.Size(208, 32)
        Me.SaveSourceButton.TabIndex = 42
        Me.SaveSourceButton.Text = "Save Source"
        Me.SaveSourceButton.Tooltip = Nothing
        '
        'SaveCompressFileButton
        '
        Me.SaveCompressFileButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SaveCompressFileButton.ButtonType = mSXdevtools.GUI.piXelST.pxButton.Button_TYPES.Save
        Me.SaveCompressFileButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveCompressFileButton.ForeColor = System.Drawing.Color.Black
        Me.SaveCompressFileButton.Location = New System.Drawing.Point(364, 0)
        Me.SaveCompressFileButton.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.SaveCompressFileButton.Name = "SaveCompressFileButton"
        Me.SaveCompressFileButton.Padding = New System.Windows.Forms.Padding(4)
        Me.SaveCompressFileButton.Size = New System.Drawing.Size(208, 32)
        Me.SaveCompressFileButton.TabIndex = 43
        Me.SaveCompressFileButton.Text = "Save Binary"
        Me.SaveCompressFileButton.Tooltip = Nothing
        '
        'DataTypeInput
        '
        Me.DataTypeInput.AsmDataByteCommand = ""
        Me.DataTypeInput.AsmDataWordCommand = ""
        Me.DataTypeInput.BackColor = System.Drawing.Color.Transparent
        Me.DataTypeInput.BASIClineInterval = 10
        Me.DataTypeInput.BASIClineNumber = 10000
        Me.DataTypeInput.BASICremoveZeros = False
        Me.DataTypeInput.CompressType = mSXdevtools.GUI.Controls.DataTypeInputControl.COMPRESS_TYPE.RAW
        Me.DataTypeInput.EnableAssemblerIndex = False
        Me.DataTypeInput.EnableCompress = False
        Me.DataTypeInput.EnableDataLineSize = False
        Me.DataTypeInput.FieldName = "DATA"
        Me.DataTypeInput.LanguageCode = mSXdevtools.DataStructures.SourceCodeInfo.LANGUAGE_CODE.BASIC
        Me.DataTypeInput.LineSizeIndex = 6
        Me.DataTypeInput.Location = New System.Drawing.Point(14, 26)
        Me.DataTypeInput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataTypeInput.Name = "DataTypeInput"
        Me.DataTypeInput.NumeralSystem = -1
        Me.DataTypeInput.Size = New System.Drawing.Size(782, 117)
        Me.DataTypeInput.TabIndex = 68
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputTextBox.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputTextBox.ForeColor = System.Drawing.Color.Black
        Me.OutputTextBox.Location = New System.Drawing.Point(14, 150)
        Me.OutputTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputTextBox.Size = New System.Drawing.Size(782, 58)
        Me.OutputTextBox.TabIndex = 40
        Me.OutputTextBox.TabStop = False
        '
        'OutputDataGBox
        '
        Me.Controls.Add(Me.PiXelGroupBox1)
        Me.MinimumSize = New System.Drawing.Size(714, 260)
        Me.Name = "OutputDataGBox"
        Me.Size = New System.Drawing.Size(810, 260)
        Me.PiXelGroupBox1.ResumeLayout(False)
        Me.PiXelGroupBox1.PerformLayout()
        Me.OutputButtonsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents DataTypeInput As mSXdevtools.GUI.Controls.DataTypeInputControl
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents OutputButtonsPanel As Panel
    Friend WithEvents CopyAllButton As pxButton
    Friend WithEvents SaveSourceButton As pxButton
    Friend WithEvents SaveCompressFileButton As pxButton
    Friend WithEvents PiXelGroupBox1 As pxGroupBox
End Class
