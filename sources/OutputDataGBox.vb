Public Class OutputDataGBox

    Private isOpen As Boolean

    Private _defaultHeigh As Integer


    Public Event DataChanged()

    Public Event AccordionChanged(state As Boolean)


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        _defaultHeigh = Me.Height

        accordionPictureBox.Image = ButtonImageList.Images(0)

        isOpen = True

    End Sub



    Private Sub LabelTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles FieldNameTextBox.Validating

        If Me.FieldNameTextBox.Text.Trim() = "" Then
            Me.FieldNameTextBox.Text = "DATA"
        End If

        'GenerateCode(Me.lastOutputData)
        RaiseEvent DataChanged()
    End Sub



    Private Sub DataTypeInput_DataChanged() Handles DataTypeInput.DataChanged

        If DataTypeInput.CodeLanguage = DataTypeInputControl.Language_CODE.BASIC Then
            FieldNameLabel.Visible = False
            FieldNameTextBox.Visible = False
        Else
            FieldNameLabel.Visible = True
            FieldNameTextBox.Visible = True
        End If

        RaiseEvent DataChanged()
    End Sub



    Private Sub accordionPictureBox_Click(sender As Object, e As EventArgs) Handles accordionPictureBox.Click
        Me.isOpen = Not isOpen

        If Me.isOpen = True Then
            Me.Height = _defaultHeigh
            accordionPictureBox.Image = ButtonImageList.Images(0)
        Else
            Me.Height = upperPanel.Height + 8 + DownPictureBox.Height
            accordionPictureBox.Image = ButtonImageList.Images(1)
        End If

        RaiseEvent AccordionChanged(Me.isOpen)

    End Sub



End Class
