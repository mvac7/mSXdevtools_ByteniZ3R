<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutWin
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
    Friend WithEvents OKButton As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutWin))
        Me.copyleftLabel = New System.Windows.Forms.Label()
        Me.versionLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.LicenseButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.iconPictureBox = New System.Windows.Forms.PictureBox()
        Me.LogoPanel = New System.Windows.Forms.Panel()
        Me.Licens3Panel = New System.Windows.Forms.Panel()
        Me.Licens3LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Licens3textLabel = New System.Windows.Forms.Label()
        Me.LicenseLabel = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogoPanel.SuspendLayout()
        Me.Licens3Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'copyleftLabel
        '
        Me.copyleftLabel.BackColor = System.Drawing.Color.Transparent
        Me.copyleftLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.copyleftLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyleftLabel.Location = New System.Drawing.Point(4, 4)
        Me.copyleftLabel.Name = "copyleftLabel"
        Me.copyleftLabel.Size = New System.Drawing.Size(447, 22)
        Me.copyleftLabel.TabIndex = 3
        Me.copyleftLabel.Text = "copyleft"
        '
        'versionLabel
        '
        Me.versionLabel.BackColor = System.Drawing.Color.Transparent
        Me.versionLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.versionLabel.Location = New System.Drawing.Point(230, 94)
        Me.versionLabel.Name = "versionLabel"
        Me.versionLabel.Size = New System.Drawing.Size(334, 18)
        Me.versionLabel.TabIndex = 4
        Me.versionLabel.Text = "version"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Version:"
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionLabel.BackColor = System.Drawing.Color.Transparent
        Me.DescriptionLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(156, 117)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(460, 58)
        Me.DescriptionLabel.TabIndex = 11
        Me.DescriptionLabel.Text = "description..."
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.BackColor = System.Drawing.Color.Transparent
        Me.OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OKButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKButton.FlatAppearance.BorderSize = 0
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButton.Image = CType(resources.GetObject("OKButton.Image"), System.Drawing.Image)
        Me.OKButton.Location = New System.Drawing.Point(486, 434)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(133, 42)
        Me.OKButton.TabIndex = 1
        Me.OKButton.TabStop = False
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'LicenseButton
        '
        Me.LicenseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LicenseButton.BackColor = System.Drawing.Color.Transparent
        Me.LicenseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LicenseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LicenseButton.FlatAppearance.BorderSize = 0
        Me.LicenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LicenseButton.Image = CType(resources.GetObject("LicenseButton.Image"), System.Drawing.Image)
        Me.LicenseButton.Location = New System.Drawing.Point(152, 413)
        Me.LicenseButton.Name = "LicenseButton"
        Me.LicenseButton.Size = New System.Drawing.Size(140, 60)
        Me.LicenseButton.TabIndex = 5
        Me.LicenseButton.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.LogoPictureBox.Location = New System.Drawing.Point(260, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(200, 70)
        Me.LogoPictureBox.TabIndex = 12
        Me.LogoPictureBox.TabStop = False
        '
        'iconPictureBox
        '
        Me.iconPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.iconPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.iconPictureBox.Name = "iconPictureBox"
        Me.iconPictureBox.Size = New System.Drawing.Size(128, 128)
        Me.iconPictureBox.TabIndex = 13
        Me.iconPictureBox.TabStop = False
        '
        'LogoPanel
        '
        Me.LogoPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoPanel.BackColor = System.Drawing.Color.Transparent
        Me.LogoPanel.Controls.Add(Me.LogoPictureBox)
        Me.LogoPanel.Location = New System.Drawing.Point(158, 12)
        Me.LogoPanel.Name = "LogoPanel"
        Me.LogoPanel.Size = New System.Drawing.Size(460, 70)
        Me.LogoPanel.TabIndex = 14
        '
        'Licens3Panel
        '
        Me.Licens3Panel.BackColor = System.Drawing.Color.LightGray
        Me.Licens3Panel.Controls.Add(Me.Licens3LinkLabel)
        Me.Licens3Panel.Controls.Add(Me.Licens3textLabel)
        Me.Licens3Panel.Controls.Add(Me.copyleftLabel)
        Me.Licens3Panel.Location = New System.Drawing.Point(158, 201)
        Me.Licens3Panel.Margin = New System.Windows.Forms.Padding(0)
        Me.Licens3Panel.Name = "Licens3Panel"
        Me.Licens3Panel.Padding = New System.Windows.Forms.Padding(4)
        Me.Licens3Panel.Size = New System.Drawing.Size(455, 209)
        Me.Licens3Panel.TabIndex = 16
        '
        'Licens3LinkLabel
        '
        Me.Licens3LinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.Licens3LinkLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Licens3LinkLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Licens3LinkLabel.Location = New System.Drawing.Point(4, 186)
        Me.Licens3LinkLabel.Name = "Licens3LinkLabel"
        Me.Licens3LinkLabel.Size = New System.Drawing.Size(447, 24)
        Me.Licens3LinkLabel.TabIndex = 16
        Me.Licens3LinkLabel.TabStop = True
        Me.Licens3LinkLabel.Text = "<https://www.gnu.org/licenses/>."
        Me.Licens3LinkLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Licens3textLabel
        '
        Me.Licens3textLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Licens3textLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Licens3textLabel.Location = New System.Drawing.Point(4, 26)
        Me.Licens3textLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.Licens3textLabel.Name = "Licens3textLabel"
        Me.Licens3textLabel.Size = New System.Drawing.Size(447, 160)
        Me.Licens3textLabel.TabIndex = 17
        Me.Licens3textLabel.Text = resources.GetString("Licens3textLabel.Text")
        '
        'LicenseLabel
        '
        Me.LicenseLabel.BackColor = System.Drawing.Color.Transparent
        Me.LicenseLabel.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenseLabel.Location = New System.Drawing.Point(158, 180)
        Me.LicenseLabel.Name = "LicenseLabel"
        Me.LicenseLabel.Size = New System.Drawing.Size(455, 20)
        Me.LicenseLabel.TabIndex = 17
        Me.LicenseLabel.Text = "License:"
        '
        'AboutWin
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(624, 481)
        Me.ControlBox = False
        Me.Controls.Add(Me.LicenseLabel)
        Me.Controls.Add(Me.Licens3Panel)
        Me.Controls.Add(Me.LogoPanel)
        Me.Controls.Add(Me.iconPictureBox)
        Me.Controls.Add(Me.LicenseButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.versionLabel)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutWin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.TransparencyKey = System.Drawing.Color.LightCoral
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogoPanel.ResumeLayout(False)
        Me.Licens3Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents copyleftLabel As System.Windows.Forms.Label
    Friend WithEvents versionLabel As System.Windows.Forms.Label
    Friend WithEvents LicenseButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents iconPictureBox As PictureBox
    Friend WithEvents LogoPanel As Panel
    Private WithEvents Licens3Panel As Panel
    Friend WithEvents Licens3LinkLabel As LinkLabel
    Friend WithEvents Licens3textLabel As Label
    Friend WithEvents LicenseLabel As Label
End Class
