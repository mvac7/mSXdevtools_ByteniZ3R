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



    Private Sub LabelTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LabelTextBox.Validating

        If Me.LabelTextBox.Text.Trim() = "" Then
            Me.LabelTextBox.Text = "DATA"
        End If

        'GenerateCode(Me.lastOutputData)
        RaiseEvent DataChanged()
    End Sub



    Private Sub DataTypeInput_DataChanged() Handles DataTypeInput.DataChanged
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
