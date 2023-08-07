<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageDialog))
        Me.ico64PictureBox = New System.Windows.Forms.PictureBox()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.ico64ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.BottonsPanel = New System.Windows.Forms.Panel()
        Me.Ok_Button = New piXelST_Button()
        Me.Cancel_Button = New piXelST_Button()
        Me.Title_Label = New piXelST_Label()
        CType(Me.ico64PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottonsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ico64PictureBox
        '
        Me.ico64PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.ico64PictureBox.Location = New System.Drawing.Point(12, 45)
        Me.ico64PictureBox.Name = "ico64PictureBox"
        Me.ico64PictureBox.Size = New System.Drawing.Size(64, 64)
        Me.ico64PictureBox.TabIndex = 5
        Me.ico64PictureBox.TabStop = False
        '
        'MessageLabel
        '
        Me.MessageLabel.BackColor = System.Drawing.Color.Transparent
        Me.MessageLabel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.ForeColor = System.Drawing.Color.Black
        Me.MessageLabel.Location = New System.Drawing.Point(92, 45)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(330, 134)
        Me.MessageLabel.TabIndex = 6
        Me.MessageLabel.Text = "Message"
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ico64ImageList
        '
        Me.ico64ImageList.ImageStream = CType(resources.GetObject("ico64ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ico64ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ico64ImageList.Images.SetKeyName(0, "ico64_Alert_pixel2.png")
        Me.ico64ImageList.Images.SetKeyName(1, "ico64_About_pixel2.png")
        Me.ico64ImageList.Images.SetKeyName(2, "ico64_Help_pixel2.png")
        '
        'BottonsPanel
        '
        Me.BottonsPanel.Controls.Add(Me.Ok_Button)
        Me.BottonsPanel.Controls.Add(Me.Cancel_Button)
        Me.BottonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottonsPanel.Location = New System.Drawing.Point(0, 190)
        Me.BottonsPanel.Name = "BottonsPanel"
        Me.BottonsPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.BottonsPanel.Size = New System.Drawing.Size(434, 44)
        Me.BottonsPanel.TabIndex = 7
        '
        'Ok_Button
        '
        Me.Ok_Button.ButtonColor = System.Drawing.Color.Gray
        Me.Ok_Button.ButtonType = piXelST_Button.Button_TYPES.Confirmation
        Me.Ok_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ok_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Ok_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Ok_Button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Ok_Button.Location = New System.Drawing.Point(203, 4)
        Me.Ok_Button.Name = "Ok_Button"
        Me.Ok_Button.Padding = New System.Windows.Forms.Padding(4)
        Me.Ok_Button.Size = New System.Drawing.Size(125, 36)
        Me.Ok_Button.TabIndex = 127
        Me.Ok_Button.TabStop = False
        Me.Ok_Button.Text = "Ok"
        Me.Ok_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.ButtonColor = System.Drawing.Color.Gray
        Me.Cancel_Button.ButtonType = piXelST_Button.Button_TYPES.Cancellation
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancel_Button.Location = New System.Drawing.Point(328, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Padding = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Size = New System.Drawing.Size(102, 36)
        Me.Cancel_Button.TabIndex = 128
        Me.Cancel_Button.TabStop = False
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Title_Label
        '
        Me.Title_Label.BackColor = System.Drawing.Color.RoyalBlue
        Me.Title_Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Title_Label.ForeColor = System.Drawing.Color.White
        Me.Title_Label.Location = New System.Drawing.Point(0, 0)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Padding = New System.Windows.Forms.Padding(8, 4, 4, 4)
        Me.Title_Label.Size = New System.Drawing.Size(434, 32)
        Me.Title_Label.TabIndex = 28
        Me.Title_Label.Text = "Title"
        Me.Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MessageDialog
        '
        Me.AcceptButton = Me.Ok_Button
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(434, 234)
        Me.ControlBox = False
        Me.Controls.Add(Me.Title_Label)
        Me.Controls.Add(Me.BottonsPanel)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.ico64PictureBox)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessageDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.ico64PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottonsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ico64PictureBox As PictureBox
    Friend WithEvents MessageLabel As Label
    Friend WithEvents ico64ImageList As ImageList
    Friend WithEvents BottonsPanel As Panel
    Friend WithEvents Title_Label As piXelST_Label
    Friend WithEvents Ok_Button As piXelST_Button
    Friend WithEvents Cancel_Button As piXelST_Button
End Class
