Public Class HelpDialog

    Dim help_Text As String

    Public WriteOnly Property HorizontalRuleChar As Char
        Set(value As Char)
            Me.HelpController.HorizontalRuleChar = value
        End Set
    End Property



    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub



    Public Sub New(ByVal width As Integer, ByVal height As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Size = New Size(width, height)

    End Sub



    Overloads Function ShowDialog(ByRef owner As IWin32Window, ByVal tittle As String, ByVal helpText As String) As DialogResult

        Me.Title_Label.Text = tittle

        Me.help_Text = helpText

        Me.Select()

        Return Me.ShowDialog(owner)

    End Function



    Private Sub HelpDialog_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.HelpController.SetHelpText(Me.help_Text)
    End Sub



    'Public Sub LoadText(ByVal filePath As String)

    '    Dim helpText As String

    '    If File.Exists(filePath) Then

    '        helpText = My.Computer.FileSystem.ReadAllText(filePath)
    '        SetHelpByText(helpText)

    '    End If

    'End Sub




#Region "WindowControlBar functions"


    Private posX As Integer
    Private posY As Integer
    Private enableDragDialog As Boolean = False



    Private Sub ControlBarPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles Title_Label.MouseDown
        'AddHandler ControlBarPanel.MouseMove, AddressOf Me.ControlBarPanel_MouseMove
        If enableDragDialog = False Then
            If e.Button = MouseButtons.Left Then
                enableDragDialog = True
                posX = Cursor.Position.X   'e.X
                posY = Cursor.Position.Y
            End If
        End If

    End Sub


    Private Sub ControlBarPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles Title_Label.MouseMove

        Dim newX As Integer
        Dim newY As Integer

        If enableDragDialog = True Then
            If e.Button = MouseButtons.Left Then
                newX = Me.Location.X + (Cursor.Position.X - posX)
                newY = Me.Location.Y + (Cursor.Position.Y - posY)
                Me.Location = New Point(newX, newY)
                posX = Cursor.Position.X
                posY = Cursor.Position.Y
            End If
        End If

    End Sub


    Private Sub ControlBarPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles Title_Label.MouseUp
        enableDragDialog = False
    End Sub


    Private Sub MaximizeButton_Click(sender As Object, e As EventArgs) Handles MaximizeButton.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub


#End Region


End Class