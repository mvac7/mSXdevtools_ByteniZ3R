<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpDialog))
        Me.ExitPanel = New System.Windows.Forms.Panel()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.WindowControlBarPanel = New System.Windows.Forms.Panel()
        Me.Title_Label = New piXelST_Label()
        Me.MaximizeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.icoButton = New System.Windows.Forms.Button()
        Me.HelpController = New piXelST_Help()
        Me.ExitPanel.SuspendLayout()
        Me.WindowControlBarPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitPanel
        '
        Me.ExitPanel.BackColor = System.Drawing.Color.Transparent
        Me.ExitPanel.Controls.Add(Me.Exit_Button)
        Me.ExitPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ExitPanel.Location = New System.Drawing.Point(0, 536)
        Me.ExitPanel.Name = "ExitPanel"
        Me.ExitPanel.Size = New System.Drawing.Size(684, 32)
        Me.ExitPanel.TabIndex = 2
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.Transparent
        Me.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Exit_Button.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Exit_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Exit_Button.FlatAppearance.BorderSize = 0
        Me.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_Button.Image = CType(resources.GetObject("Exit_Button.Image"), System.Drawing.Image)
        Me.Exit_Button.Location = New System.Drawing.Point(568, 0)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(116, 32)
        Me.Exit_Button.TabIndex = 127
        Me.Exit_Button.TabStop = False
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 568)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(684, 16)
        Me.StatusStrip1.TabIndex = 33
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'WindowControlBarPanel
        '
        Me.WindowControlBarPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.WindowControlBarPanel.Controls.Add(Me.Title_Label)
        Me.WindowControlBarPanel.Controls.Add(Me.MaximizeButton)
        Me.WindowControlBarPanel.Controls.Add(Me.ExitButton)
        Me.WindowControlBarPanel.Controls.Add(Me.icoButton)
        Me.WindowControlBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowControlBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.WindowControlBarPanel.Name = "WindowControlBarPanel"
        Me.WindowControlBarPanel.Size = New System.Drawing.Size(684, 33)
        Me.WindowControlBarPanel.TabIndex = 294
        '
        'Title_Label
        '
        Me.Title_Label.BackColor = System.Drawing.Color.Transparent
        Me.Title_Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title_Label.ForeColor = System.Drawing.Color.White
        Me.Title_Label.Location = New System.Drawing.Point(33, 0)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Padding = New System.Windows.Forms.Padding(8, 4, 4, 4)
        Me.Title_Label.Size = New System.Drawing.Size(585, 33)
        Me.Title_Label.TabIndex = 296
        Me.Title_Label.Text = "Help"
        Me.Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaximizeButton
        '
        Me.MaximizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaximizeButton.FlatAppearance.BorderSize = 0
        Me.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaximizeButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeButton.ForeColor = System.Drawing.Color.White
        Me.MaximizeButton.Image = CType(resources.GetObject("MaximizeButton.Image"), System.Drawing.Image)
        Me.MaximizeButton.Location = New System.Drawing.Point(618, 0)
        Me.MaximizeButton.Name = "MaximizeButton"
        Me.MaximizeButton.Size = New System.Drawing.Size(33, 33)
        Me.MaximizeButton.TabIndex = 292
        Me.MaximizeButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.Location = New System.Drawing.Point(651, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(33, 33)
        Me.ExitButton.TabIndex = 291
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'icoButton
        '
        Me.icoButton.BackColor = System.Drawing.Color.Transparent
        Me.icoButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.icoButton.FlatAppearance.BorderSize = 0
        Me.icoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.icoButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icoButton.ForeColor = System.Drawing.Color.White
        Me.icoButton.Image = CType(resources.GetObject("icoButton.Image"), System.Drawing.Image)
        Me.icoButton.Location = New System.Drawing.Point(0, 0)
        Me.icoButton.Name = "icoButton"
        Me.icoButton.Size = New System.Drawing.Size(33, 33)
        Me.icoButton.TabIndex = 297
        Me.icoButton.UseVisualStyleBackColor = False
        '
        'HelpController
        '
        Me.HelpController.BackColor = System.Drawing.Color.SlateGray
        Me.HelpController.BackgroundGradient = False
        Me.HelpController.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HelpController.Color_Background_Gradient = System.Drawing.Color.Indigo
        Me.HelpController.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpController.Location = New System.Drawing.Point(0, 33)
        Me.HelpController.Name = "HelpController"
        Me.HelpController.Size = New System.Drawing.Size(684, 503)
        Me.HelpController.TabIndex = 295
        '
        'HelpDialog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.Exit_Button
        Me.ClientSize = New System.Drawing.Size(684, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.HelpController)
        Me.Controls.Add(Me.WindowControlBarPanel)
        Me.Controls.Add(Me.ExitPanel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "HelpDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ExitPanel.ResumeLayout(False)
        Me.WindowControlBarPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExitPanel As Panel
    Friend WithEvents Exit_Button As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents WindowControlBarPanel As Panel
    Friend WithEvents MaximizeButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Title_Label As piXelST_Label
    Friend WithEvents HelpController As piXelST_Help
    Friend WithEvents icoButton As Button
End Class
