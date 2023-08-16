Imports System.IO


Public Class ProjectPropertiesDialog


    Private projectInfo As ProjectInfo



    Public Sub New(ByVal _config As Config, ByVal projectInfoData As ProjectInfo)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.projectInfo = projectInfoData.Clone()

        'Me.Text = "Project Info (" + Me.projectInfo.Name + ")"


        Me.NameTextBox.Text = Me.projectInfo.Name
        Me.VersionTextBox.Text = Me.projectInfo.Version
        Me.GroupTextBox.Text = Me.projectInfo.Group

        If Me.projectInfo.Author = "" Then
            'Me.AuthorTextBox.Text = My.User.Name
            Me.AuthorTextBox.Text = _config.Author   'Environment.UserName
        Else
            Me.AuthorTextBox.Text = Me.projectInfo.Author
        End If

        Me.DescriptionTextBox.Text = Me.projectInfo.Description
        Me.StartDateTextBox.Text = New DateTime(Me.projectInfo.StartDate).ToShortDateString
        Me.LastUpdateTextBox.Text = New DateTime(Me.projectInfo.LastUpdate).ToShortDateString

    End Sub



    'Private Sub ProjectPropertiesDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    ' draw gradient in window-form background
    '    Dim gradientBG As New Bitmap(Me.Width, Me.Height)
    '    Dim newBrush As New Drawing.Drawing2D.LinearGradientBrush(New PointF(0, 0), New PointF(0, gradientBG.Height), Color.Gainsboro, Color.SlateGray)
    '    Dim oneGraphic As Graphics = Graphics.FromImage(gradientBG)
    '    oneGraphic.FillRectangle(newBrush, New RectangleF(0, 0, gradientBG.Width, gradientBG.Height))
    '    Me.BackgroundImage = gradientBG
    'End Sub



    Public Function GetProjectInfo() As ProjectInfo

        Me.projectInfo.Name = Me.NameTextBox.Text
        Me.projectInfo.Version = Me.VersionTextBox.Text
        Me.projectInfo.Group = Me.GroupTextBox.Text
        Me.projectInfo.Author = Me.AuthorTextBox.Text
        Me.projectInfo.Description = Me.DescriptionTextBox.Text

        Return Me.projectInfo

    End Function


End Class