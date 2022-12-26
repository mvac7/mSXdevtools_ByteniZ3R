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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OutputDataGBox))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.DataTypeInput = New DataTypeInputControl()
        Me.OutputText = New System.Windows.Forms.TextBox()
        Me.OutputButtonsPanel = New System.Windows.Forms.Panel()
        Me.CopyAllButton = New System.Windows.Forms.Button()
        Me.SaveSourceButton = New System.Windows.Forms.Button()
        Me.SaveCompressFileButton = New System.Windows.Forms.Button()
        Me.PiXelGroupBox1 = New piXelGroupBox()
        Me.OutputButtonsPanel.SuspendLayout()
        Me.PiXelGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataTypeInput
        '
        Me.DataTypeInput.BackColor = System.Drawing.Color.Transparent
        Me.DataTypeInput.Compress = DataTypeInputControl.Compress_Type.RAW
        Me.DataTypeInput.EnableAssemblerIndex = False
        Me.DataTypeInput.EnableCompress = False
        Me.DataTypeInput.EnableDataSizeLine = False
        Me.DataTypeInput.FieldName = "DATA"
        Me.DataTypeInput.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataTypeInput.Location = New System.Drawing.Point(14, 26)
        Me.DataTypeInput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataTypeInput.Name = "DataTypeInput"
        Me.DataTypeInput.Size = New System.Drawing.Size(510, 117)
        Me.DataTypeInput.SizeLineIndex = 6
        Me.DataTypeInput.TabIndex = 68
        '
        'OutputText
        '
        Me.OutputText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OutputText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputText.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputText.ForeColor = System.Drawing.Color.Black
        Me.OutputText.Location = New System.Drawing.Point(14, 150)
        Me.OutputText.Margin = New System.Windows.Forms.Padding(4)
        Me.OutputText.Multiline = True
        Me.OutputText.Name = "OutputText"
        Me.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputText.Size = New System.Drawing.Size(573, 50)
        Me.OutputText.TabIndex = 40
        '
        'OutputButtonsPanel
        '
        Me.OutputButtonsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputButtonsPanel.BackColor = System.Drawing.Color.Transparent
        Me.OutputButtonsPanel.Controls.Add(Me.CopyAllButton)
        Me.OutputButtonsPanel.Controls.Add(Me.SaveSourceButton)
        Me.OutputButtonsPanel.Controls.Add(Me.SaveCompressFileButton)
        Me.OutputButtonsPanel.Location = New System.Drawing.Point(13, 207)
        Me.OutputButtonsPanel.Name = "OutputButtonsPanel"
        Me.OutputButtonsPanel.Size = New System.Drawing.Size(574, 44)
        Me.OutputButtonsPanel.TabIndex = 70
        '
        'CopyAllButton
        '
        Me.CopyAllButton.BackColor = System.Drawing.Color.Transparent
        Me.CopyAllButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CopyAllButton.FlatAppearance.BorderSize = 0
        Me.CopyAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyAllButton.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyAllButton.Image = CType(resources.GetObject("CopyAllButton.Image"), System.Drawing.Image)
        Me.CopyAllButton.Location = New System.Drawing.Point(4, 0)
        Me.CopyAllButton.Name = "CopyAllButton"
        Me.CopyAllButton.Size = New System.Drawing.Size(154, 44)
        Me.CopyAllButton.TabIndex = 41
        Me.CopyAllButton.UseVisualStyleBackColor = False
        '
        'SaveSourceButton
        '
        Me.SaveSourceButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveSourceButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveSourceButton.FlatAppearance.BorderSize = 0
        Me.SaveSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveSourceButton.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveSourceButton.Image = CType(resources.GetObject("SaveSourceButton.Image"), System.Drawing.Image)
        Me.SaveSourceButton.Location = New System.Drawing.Point(158, 0)
        Me.SaveSourceButton.Name = "SaveSourceButton"
        Me.SaveSourceButton.Size = New System.Drawing.Size(208, 44)
        Me.SaveSourceButton.TabIndex = 42
        Me.SaveSourceButton.UseVisualStyleBackColor = False
        '
        'SaveCompressFileButton
        '
        Me.SaveCompressFileButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveCompressFileButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveCompressFileButton.FlatAppearance.BorderSize = 0
        Me.SaveCompressFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveCompressFileButton.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCompressFileButton.Image = CType(resources.GetObject("SaveCompressFileButton.Image"), System.Drawing.Image)
        Me.SaveCompressFileButton.Location = New System.Drawing.Point(366, 0)
        Me.SaveCompressFileButton.Name = "SaveCompressFileButton"
        Me.SaveCompressFileButton.Size = New System.Drawing.Size(208, 44)
        Me.SaveCompressFileButton.TabIndex = 43
        Me.SaveCompressFileButton.UseVisualStyleBackColor = False
        '
        'PiXelGroupBox1
        '
        Me.PiXelGroupBox1.Controls.Add(Me.OutputButtonsPanel)
        Me.PiXelGroupBox1.Controls.Add(Me.DataTypeInput)
        Me.PiXelGroupBox1.Controls.Add(Me.OutputText)
        Me.PiXelGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PiXelGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.PiXelGroupBox1.MinimumSize = New System.Drawing.Size(600, 260)
        Me.PiXelGroupBox1.Name = "PiXelGroupBox1"
        Me.PiXelGroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.PiXelGroupBox1.Size = New System.Drawing.Size(600, 260)
        Me.PiXelGroupBox1.TabIndex = 5
        Me.PiXelGroupBox1.TabStop = False
        Me.PiXelGroupBox1.Text = "Output Data"
        '
        'OutputDataGBox
        '
        Me.Controls.Add(Me.PiXelGroupBox1)
        Me.MinimumSize = New System.Drawing.Size(600, 260)
        Me.Name = "OutputDataGBox"
        Me.Size = New System.Drawing.Size(600, 260)
        Me.OutputButtonsPanel.ResumeLayout(False)
        Me.PiXelGroupBox1.ResumeLayout(False)
        Me.PiXelGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents DataTypeInput As DataTypeInputControl
    Friend WithEvents OutputText As TextBox
    Friend WithEvents OutputButtonsPanel As Panel
    Friend WithEvents CopyAllButton As Button
    Friend WithEvents SaveSourceButton As Button
    Friend WithEvents SaveCompressFileButton As Button
    Friend WithEvents PiXelGroupBox1 As piXelGroupBox
End Class
