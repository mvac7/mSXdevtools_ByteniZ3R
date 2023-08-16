<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectPropertiesDialog
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
        Me.Title_Label = New ByteniZ3R.piXelST_Label()
        Me.BottonsPanel = New System.Windows.Forms.Panel()
        Me.Ok_Button = New ByteniZ3R.piXelST_Button()
        Me.Cancel_Button = New ByteniZ3R.piXelST_Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LastUpdateTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StartDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VersionTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.BottonsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title_Label
        '
        Me.Title_Label.BackColor = System.Drawing.Color.RoyalBlue
        Me.Title_Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Title_Label.ForeColor = System.Drawing.Color.White
        Me.Title_Label.Location = New System.Drawing.Point(0, 0)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Padding = New System.Windows.Forms.Padding(8, 4, 4, 4)
        Me.Title_Label.Size = New System.Drawing.Size(502, 32)
        Me.Title_Label.TabIndex = 259
        Me.Title_Label.Text = "Project info"
        Me.Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BottonsPanel
        '
        Me.BottonsPanel.Controls.Add(Me.Ok_Button)
        Me.BottonsPanel.Controls.Add(Me.Cancel_Button)
        Me.BottonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottonsPanel.Location = New System.Drawing.Point(0, 316)
        Me.BottonsPanel.Name = "BottonsPanel"
        Me.BottonsPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.BottonsPanel.Size = New System.Drawing.Size(502, 44)
        Me.BottonsPanel.TabIndex = 260
        '
        'Ok_Button
        '
        Me.Ok_Button.ButtonColor = System.Drawing.Color.Gray
        Me.Ok_Button.ButtonType = ByteniZ3R.piXelST_Button.Button_TYPES.Confirmation
        Me.Ok_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ok_Button.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Ok_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Ok_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Ok_Button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Ok_Button.Location = New System.Drawing.Point(271, 4)
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
        Me.Cancel_Button.ButtonType = ByteniZ3R.piXelST_Button.Button_TYPES.Cancellation
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancel_Button.Location = New System.Drawing.Point(396, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Padding = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Size = New System.Drawing.Size(102, 36)
        Me.Cancel_Button.TabIndex = 128
        Me.Cancel_Button.TabStop = False
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(272, 135)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 28)
        Me.Label7.TabIndex = 274
        Me.Label7.Text = "Last update"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LastUpdateTextBox
        '
        Me.LastUpdateTextBox.Location = New System.Drawing.Point(371, 138)
        Me.LastUpdateTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.LastUpdateTextBox.MaxLength = 32
        Me.LastUpdateTextBox.Name = "LastUpdateTextBox"
        Me.LastUpdateTextBox.ReadOnly = True
        Me.LastUpdateTextBox.Size = New System.Drawing.Size(110, 23)
        Me.LastUpdateTextBox.TabIndex = 266
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 136)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 28)
        Me.Label6.TabIndex = 273
        Me.Label6.Text = "Start project"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StartDateTextBox
        '
        Me.StartDateTextBox.Location = New System.Drawing.Point(109, 139)
        Me.StartDateTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.StartDateTextBox.MaxLength = 32
        Me.StartDateTextBox.Name = "StartDateTextBox"
        Me.StartDateTextBox.ReadOnly = True
        Me.StartDateTextBox.Size = New System.Drawing.Size(110, 23)
        Me.StartDateTextBox.TabIndex = 265
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 104)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 28)
        Me.Label5.TabIndex = 272
        Me.Label5.Text = "Group"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupTextBox
        '
        Me.GroupTextBox.Location = New System.Drawing.Point(109, 108)
        Me.GroupTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupTextBox.MaxLength = 32
        Me.GroupTextBox.Name = "GroupTextBox"
        Me.GroupTextBox.Size = New System.Drawing.Size(372, 23)
        Me.GroupTextBox.TabIndex = 264
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 28)
        Me.Label3.TabIndex = 271
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(109, 170)
        Me.DescriptionTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DescriptionTextBox.MaxLength = 1024
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(372, 126)
        Me.DescriptionTextBox.TabIndex = 267
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(221, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 28)
        Me.Label2.TabIndex = 270
        Me.Label2.Text = "Author"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Location = New System.Drawing.Point(304, 76)
        Me.AuthorTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.AuthorTextBox.MaxLength = 32
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(177, 23)
        Me.AuthorTextBox.TabIndex = 263
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 28)
        Me.Label1.TabIndex = 269
        Me.Label1.Text = "Version"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VersionTextBox
        '
        Me.VersionTextBox.Location = New System.Drawing.Point(109, 77)
        Me.VersionTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.VersionTextBox.MaxLength = 32
        Me.VersionTextBox.Name = "VersionTextBox"
        Me.VersionTextBox.Size = New System.Drawing.Size(110, 23)
        Me.VersionTextBox.TabIndex = 262
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 42)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 28)
        Me.Label4.TabIndex = 268
        Me.Label4.Text = "Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(109, 46)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.NameTextBox.MaxLength = 32
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(372, 23)
        Me.NameTextBox.TabIndex = 261
        '
        'ProjectPropertiesDialog
        '
        Me.AcceptButton = Me.Ok_Button
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(502, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LastUpdateTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StartDateTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VersionTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.BottonsPanel)
        Me.Controls.Add(Me.Title_Label)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProjectPropertiesDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.BottonsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title_Label As piXelST_Label
    Friend WithEvents BottonsPanel As Panel
    Friend WithEvents Ok_Button As piXelST_Button
    Friend WithEvents Cancel_Button As piXelST_Button
    Private WithEvents Label7 As Label
    Private WithEvents LastUpdateTextBox As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents StartDateTextBox As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents GroupTextBox As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents DescriptionTextBox As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents AuthorTextBox As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents VersionTextBox As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents NameTextBox As TextBox
End Class
