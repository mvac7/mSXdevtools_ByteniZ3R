<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class piXelST_Text
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(piXelST_Text))
        Me.piXelS_font = New System.Windows.Forms.PictureBox()
        CType(Me.piXelS_font, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'piXelS_font
        '
        Me.piXelS_font.BackColor = System.Drawing.Color.Transparent
        Me.piXelS_font.Dock = System.Windows.Forms.DockStyle.Right
        Me.piXelS_font.Image = CType(resources.GetObject("piXelS_font.Image"), System.Drawing.Image)
        Me.piXelS_font.Location = New System.Drawing.Point(28, 0)
        Me.piXelS_font.Name = "piXelS_font"
        Me.piXelS_font.Size = New System.Drawing.Size(100, 16)
        Me.piXelS_font.TabIndex = 2
        Me.piXelS_font.TabStop = False
        Me.piXelS_font.Visible = False
        '
        'piXelST_Text
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.piXelS_font)
        Me.Name = "piXelST_Text"
        Me.Size = New System.Drawing.Size(128, 16)
        CType(Me.piXelS_font, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents piXelS_font As PictureBox
End Class
