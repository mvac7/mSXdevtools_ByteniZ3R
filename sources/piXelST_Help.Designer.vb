<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class piXelST_Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(piXelST_Help))
        Me.HelpTextPanel = New System.Windows.Forms.Panel()
        Me.HelpPictureBox = New System.Windows.Forms.PictureBox()
        Me.piXelS_font = New System.Windows.Forms.PictureBox()
        Me.HelpTextPanel.SuspendLayout()
        CType(Me.HelpPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piXelS_font, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HelpTextPanel
        '
        Me.HelpTextPanel.BackColor = System.Drawing.Color.DimGray
        Me.HelpTextPanel.Controls.Add(Me.HelpPictureBox)
        Me.HelpTextPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpTextPanel.Location = New System.Drawing.Point(0, 0)
        Me.HelpTextPanel.Name = "HelpTextPanel"
        Me.HelpTextPanel.Size = New System.Drawing.Size(512, 320)
        Me.HelpTextPanel.TabIndex = 2
        '
        'HelpPictureBox
        '
        Me.HelpPictureBox.BackColor = System.Drawing.Color.SlateGray
        Me.HelpPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.HelpPictureBox.Name = "HelpPictureBox"
        Me.HelpPictureBox.Size = New System.Drawing.Size(256, 192)
        Me.HelpPictureBox.TabIndex = 0
        Me.HelpPictureBox.TabStop = False
        '
        'piXelS_font
        '
        Me.piXelS_font.BackColor = System.Drawing.Color.DarkGray
        Me.piXelS_font.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.piXelS_font.Image = CType(resources.GetObject("piXelS_font.Image"), System.Drawing.Image)
        Me.piXelS_font.Location = New System.Drawing.Point(0, 241)
        Me.piXelS_font.Name = "piXelS_font"
        Me.piXelS_font.Size = New System.Drawing.Size(512, 79)
        Me.piXelS_font.TabIndex = 0
        Me.piXelS_font.TabStop = False
        Me.piXelS_font.Visible = False
        '
        'piXelHelp
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Controls.Add(Me.piXelS_font)
        Me.Controls.Add(Me.HelpTextPanel)
        Me.DoubleBuffered = True
        Me.Name = "piXelHelp"
        Me.Size = New System.Drawing.Size(512, 320)
        Me.HelpTextPanel.ResumeLayout(False)
        CType(Me.HelpPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piXelS_font, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents piXelS_font As PictureBox
    Friend WithEvents HelpTextPanel As Panel
    Friend WithEvents HelpPictureBox As PictureBox
End Class
