﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OutputDataGBox))
        Me.DownPictureBox = New System.Windows.Forms.PictureBox()
        Me.upperPanel = New System.Windows.Forms.Panel()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.LeftLinePictureBox = New System.Windows.Forms.PictureBox()
        Me.RightLinePictureBox = New System.Windows.Forms.PictureBox()
        Me.ContentsPanel = New System.Windows.Forms.Panel()
        Me.LabelTextBox = New System.Windows.Forms.TextBox()
        Me.LabelLabel = New System.Windows.Forms.Label()
        Me.accordionPictureBox = New System.Windows.Forms.PictureBox()
        Me.DataTypeInput = New ByteniZ3R.DataTypeInputControl()
        CType(Me.DownPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.upperPanel.SuspendLayout()
        CType(Me.LeftLinePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightLinePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContentsPanel.SuspendLayout()
        CType(Me.accordionPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DownPictureBox
        '
        Me.DownPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DownPictureBox.Image = Global.ByteniZ3R.My.Resources.Resources.piXel_panel_XL_down
        Me.DownPictureBox.Location = New System.Drawing.Point(0, 149)
        Me.DownPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.DownPictureBox.Name = "DownPictureBox"
        Me.DownPictureBox.Size = New System.Drawing.Size(766, 4)
        Me.DownPictureBox.TabIndex = 1
        Me.DownPictureBox.TabStop = False
        '
        'upperPanel
        '
        Me.upperPanel.BackColor = System.Drawing.Color.Transparent
        Me.upperPanel.BackgroundImage = Global.ByteniZ3R.My.Resources.Resources.piXel_panel_XL_up_outputdata2
        Me.upperPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.upperPanel.Controls.Add(Me.accordionPictureBox)
        Me.upperPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.upperPanel.Location = New System.Drawing.Point(0, 0)
        Me.upperPanel.Name = "upperPanel"
        Me.upperPanel.Size = New System.Drawing.Size(766, 20)
        Me.upperPanel.TabIndex = 0
        '
        'ButtonImageList
        '
        Me.ButtonImageList.ImageStream = CType(resources.GetObject("ButtonImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ButtonImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ButtonImageList.Images.SetKeyName(0, "button_close.png")
        Me.ButtonImageList.Images.SetKeyName(1, "button_open.png")
        '
        'LeftLinePictureBox
        '
        Me.LeftLinePictureBox.BackColor = System.Drawing.Color.Black
        Me.LeftLinePictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftLinePictureBox.Location = New System.Drawing.Point(0, 20)
        Me.LeftLinePictureBox.Name = "LeftLinePictureBox"
        Me.LeftLinePictureBox.Size = New System.Drawing.Size(4, 129)
        Me.LeftLinePictureBox.TabIndex = 2
        Me.LeftLinePictureBox.TabStop = False
        '
        'RightLinePictureBox
        '
        Me.RightLinePictureBox.BackColor = System.Drawing.Color.Black
        Me.RightLinePictureBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightLinePictureBox.Location = New System.Drawing.Point(762, 20)
        Me.RightLinePictureBox.Name = "RightLinePictureBox"
        Me.RightLinePictureBox.Size = New System.Drawing.Size(4, 129)
        Me.RightLinePictureBox.TabIndex = 3
        Me.RightLinePictureBox.TabStop = False
        '
        'ContentsPanel
        '
        Me.ContentsPanel.BackColor = System.Drawing.Color.Transparent
        Me.ContentsPanel.Controls.Add(Me.DataTypeInput)
        Me.ContentsPanel.Controls.Add(Me.LabelTextBox)
        Me.ContentsPanel.Controls.Add(Me.LabelLabel)
        Me.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentsPanel.Location = New System.Drawing.Point(4, 20)
        Me.ContentsPanel.Name = "ContentsPanel"
        Me.ContentsPanel.Size = New System.Drawing.Size(758, 129)
        Me.ContentsPanel.TabIndex = 4
        '
        'LabelTextBox
        '
        Me.LabelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTextBox.Location = New System.Drawing.Point(602, 8)
        Me.LabelTextBox.Name = "LabelTextBox"
        Me.LabelTextBox.Size = New System.Drawing.Size(140, 21)
        Me.LabelTextBox.TabIndex = 67
        Me.LabelTextBox.Text = "DATA"
        '
        'LabelLabel
        '
        Me.LabelLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLabel.Location = New System.Drawing.Point(503, 9)
        Me.LabelLabel.Name = "LabelLabel"
        Me.LabelLabel.Size = New System.Drawing.Size(93, 21)
        Me.LabelLabel.TabIndex = 66
        Me.LabelLabel.Text = "Field name:"
        Me.LabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'accordionPictureBox
        '
        Me.accordionPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.accordionPictureBox.Location = New System.Drawing.Point(726, 0)
        Me.accordionPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.accordionPictureBox.Name = "accordionPictureBox"
        Me.accordionPictureBox.Size = New System.Drawing.Size(20, 20)
        Me.accordionPictureBox.TabIndex = 69
        Me.accordionPictureBox.TabStop = False
        '
        'DataTypeInput
        '
        Me.DataTypeInput.BackColor = System.Drawing.Color.Transparent
        Me.DataTypeInput.EnableDataSizeLine = False
        Me.DataTypeInput.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataTypeInput.Location = New System.Drawing.Point(3, 6)
        Me.DataTypeInput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataTypeInput.Name = "DataTypeInput"
        Me.DataTypeInput.Size = New System.Drawing.Size(486, 110)
        Me.DataTypeInput.SizesForColors = False
        Me.DataTypeInput.TabIndex = 68
        '
        'OutputDataGBox
        '
        Me.Controls.Add(Me.ContentsPanel)
        Me.Controls.Add(Me.RightLinePictureBox)
        Me.Controls.Add(Me.LeftLinePictureBox)
        Me.Controls.Add(Me.DownPictureBox)
        Me.Controls.Add(Me.upperPanel)
        Me.Name = "OutputDataGBox"
        Me.Size = New System.Drawing.Size(766, 153)
        CType(Me.DownPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.upperPanel.ResumeLayout(False)
        CType(Me.LeftLinePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightLinePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContentsPanel.ResumeLayout(False)
        Me.ContentsPanel.PerformLayout()
        CType(Me.accordionPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents upperPanel As Panel
    Friend WithEvents DownPictureBox As PictureBox
    Friend WithEvents LeftLinePictureBox As PictureBox
    Friend WithEvents RightLinePictureBox As PictureBox
    Friend WithEvents ContentsPanel As Panel
    Friend WithEvents DataTypeInput As DataTypeInputControl
    Friend WithEvents LabelTextBox As TextBox
    Friend WithEvents LabelLabel As Label
    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents accordionPictureBox As PictureBox
End Class
