Imports System.Drawing.Imaging



Public Class piXelST_Button
    Inherits System.Windows.Forms.Button

    'Private textBitmap As New piXelST_TextBitmap
    Private PiXelSTtext As piXelST_Text

    Private mouseOver As Boolean


    Public TextSize As Integer = 0


    Public Shadows Enum Button_TYPES As Integer
        None
        Confirmation
        Cancellation
        Load
        Save
        Action
    End Enum


    Private Const TEXT_MARGING = 3


    Public Property ButtonColor As Color = Color.Gray

    Public Property ButtonType As Button_TYPES = Button_TYPES.None


    'Public Property ButtonWidth As Integer

    'Public Property ButtonHeight As Integer




    Public Sub New()

        'Me.FlatStyle = FlatStyle.Flat

        'Me.Invalidate()
        Me.PiXelSTtext = New piXelST_Text()

        Me.ForeColor = Color.FromArgb(255, 42, 83, 138)

        Me.Cursor = Cursors.Hand

        mouseOver = False

        'Select Case ButtonType
        '    Case Button_TYPES.Confirmation
        '        Me.DialogResult = DialogResult.OK

        '    Case Button_TYPES.Cancellation
        '        Me.DialogResult = DialogResult.Cancel

        'End Select

    End Sub



    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        Dim posX As Integer
        Dim posY As Integer '= Me.Padding.Top

        Dim newTextBitmap As Bitmap
        Dim textBitmapWidth As Integer

        Dim buttonBrush As Brush

        Dim buttonWidth As Integer
        Dim buttonHeight As Integer
        Dim buttonTop As Integer

        Dim iconWidth As Integer = 0
        Dim iconTop As Integer

        Dim newButtonColor As Color

        Dim newBackgroundColor As Color

        Dim itemGraphics As Graphics = e.Graphics



        'Me.BackColor = Me.Parent.BackColor  'Color.Transparent

        Select Case ButtonType
            Case Button_TYPES.Confirmation
                newButtonColor = Color.FromArgb(94, 220, 120) '3 — light green
                buttonHeight = 28

            Case Button_TYPES.Cancellation
                newButtonColor = Color.FromArgb(255, 121, 120) '9 - light red
                buttonHeight = 24

            Case Button_TYPES.Load
                newButtonColor = Color.FromArgb(230, 206, 128) '11 - light yellow
                buttonHeight = 28

            Case Button_TYPES.Save
                newButtonColor = Color.FromArgb(125, 118, 252) '5 — light blue  (137, 130, 252)
                buttonHeight = 28

            Case Button_TYPES.Action
                newButtonColor = Color.FromArgb(66, 235, 245)  '7 - cyan
                buttonHeight = 28

                'Case Button_TYPES.Tab_Selected
                '    newButtonColor = Me.ButtonColor 'Color.FromArgb(192, 192, 192)
                '    Me.Enabled = True
                '    Me.Padding = New Padding(2, 4, 0, 0)
                '    Me.ImageAlign = ContentAlignment.TopCenter
                '    buttonHeight = Me.Height - Me.Padding.Top

                'Case Button_TYPES.Tab_Unselected
                '    newButtonColor = Color.FromArgb(170, 170, 170)
                '    Me.Enabled = True
                '    Me.Padding = New Padding(2, 6, 0, 0)
                '    Me.ImageAlign = ContentAlignment.TopCenter
                '    buttonHeight = Me.Height - Me.Padding.Top

            Case Else
                buttonHeight = Me.Height - (Me.Padding.Top + Me.Padding.Bottom)
                newButtonColor = Me.ButtonColor

        End Select

        buttonWidth = Me.Width - (Me.Padding.Left + Me.Padding.Right)

        'If Not ButtonType = Button_TYPES.Tab_Selected And Not ButtonType = Button_TYPES.Tab_Unselected Then

        Select Case Me.ImageAlign
            Case ContentAlignment.TopLeft, ContentAlignment.TopCenter, ContentAlignment.TopRight
                buttonTop = Padding.Top

            Case ContentAlignment.BottomLeft, ContentAlignment.BottomCenter, ContentAlignment.BottomRight
                buttonTop = Me.Height - (buttonHeight + Padding.Bottom)

            Case Else
                buttonTop = (Me.Height / 2) - (buttonHeight / 2)

        End Select

        'End If

        ' draw background button form -----------------------------------

        If mouseOver Then

            Dim aColor As Color = Me.Parent.BackColor

            Dim redColor As Integer = LightUpColor(Me.BackColor.R)
            Dim greenColor As Integer = LightUpColor(Me.BackColor.G)
            Dim blueColor As Integer = LightUpColor(Me.BackColor.B)

            newBackgroundColor = Color.FromArgb(Me.BackColor.A, redColor, greenColor, blueColor)

            'If Me.BackColor = Color.WhiteSmoke Then
            '    newBackgroundColor = Color.White
            'Else
            '    newBackgroundColor = Color.WhiteSmoke
            'End If


        Else
            newBackgroundColor = Me.BackColor
            'newBackgroundColor = Color.Transparent
        End If

        buttonBrush = New SolidBrush(newButtonColor)
        itemGraphics.Clear(newBackgroundColor)
        itemGraphics.FillRectangle(buttonBrush, Me.Padding.Left + 2, buttonTop, buttonWidth - 4, 2)
        itemGraphics.FillRectangle(buttonBrush, Me.Padding.Left, buttonTop + 2, buttonWidth, buttonHeight - 4)
        itemGraphics.FillRectangle(buttonBrush, Me.Padding.Left + 2, buttonTop + (buttonHeight - 2), buttonWidth - 4, 2)


        ' draw icon -----------------------------------------------------
        If Not Me.Image Is Nothing Then
            iconWidth = Me.Image.Width  '+ (8 - TEXT_MARGING)
            iconTop = buttonTop + (buttonHeight / 2) - (Me.Image.Height / 2)
            itemGraphics.DrawImage(Me.Image, 8, iconTop, Me.Image.Width, Me.Image.Height)
        End If


        ' draw the text with piXelST font -------------------------------
        'Me.PiXelSTtext.Text = Me.Text
        Me.PiXelSTtext.ForeColor = Me.ForeColor
        Me.PiXelSTtext.BackColor = Color.Transparent   'Me.BackColor
        Me.PiXelSTtext.Enabled = Me.Enabled

        newTextBitmap = PiXelSTtext.GetTextBitmap(Me.Text)

        If Not newTextBitmap Is Nothing Then

            textBitmapWidth = newTextBitmap.Width + 2

            ' calculates position for text alignment
            Select Case Me.TextAlign
                Case ContentAlignment.MiddleLeft, ContentAlignment.MiddleCenter, ContentAlignment.MiddleRight
                    posY = buttonTop + ((buttonHeight - 16) / 2)

                Case ContentAlignment.BottomLeft, ContentAlignment.BottomCenter, ContentAlignment.BottomRight
                    posY = buttonTop + buttonHeight - (16 + TEXT_MARGING)
                    '(((Me.Height - buttonHeight) / 2) + buttonHeight) - (16 + 4)

                Case Else 'ContentAlignment.TopLeft, ContentAlignment.TopCenter, ContentAlignment.TopRight
                    posY = buttonTop + TEXT_MARGING
                    '((Me.Height - buttonHeight) / 2) + 4

            End Select


            Select Case Me.TextAlign
                Case ContentAlignment.BottomLeft, ContentAlignment.MiddleLeft, ContentAlignment.TopLeft
                    iconWidth += TEXT_MARGING
                    posX = Me.Padding.Left + iconWidth + 4

                Case ContentAlignment.BottomRight, ContentAlignment.MiddleRight, ContentAlignment.TopRight
                    posX = (Me.Width - textBitmapWidth) - (Me.Padding.Right + TEXT_MARGING + 4)

                Case Else 'ContentAlignment.BottomCenter, ContentAlignment.MiddleCenter, ContentAlignment.TopCenter
                    posX = (((Me.Width - iconWidth) / 2) - (textBitmapWidth / 2)) + iconWidth
                    'posX = iconWidth + ((Me.Width - (iconWidth + Me.Padding.Left + Me.Padding.Right)) / 2) - (textBitmapWidth / 2)

            End Select

            itemGraphics.DrawImage(newTextBitmap, posX, posY, newTextBitmap.Width, 16)
        End If


        ' change colors in disabled mode
        If Me.Enabled = False Then
            'buttonTop = (Me.Height / 2) - (buttonHeight / 2)
            buttonBrush = New SolidBrush(Color.FromArgb(128, 200, 200, 200))
            itemGraphics.FillRectangle(buttonBrush, Me.Padding.Left + 2, buttonTop, buttonWidth - 4, 2)
            itemGraphics.FillRectangle(buttonBrush, Me.Padding.Left, buttonTop + 2, buttonWidth, buttonHeight - 4)
            itemGraphics.FillRectangle(buttonBrush, Me.Padding.Left + 2, buttonTop + (buttonHeight - 2), buttonWidth - 4, 2)
        End If

    End Sub


    Private Function LightUpColor(ByVal aColor As Integer) As Integer
        aColor += 10
        If aColor > 255 Then
            aColor = 255
        End If
        Return aColor
    End Function


    Private Sub piXelST_Button_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        mouseOver = True
    End Sub

    Private Sub piXelST_Button_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        mouseOver = False
    End Sub


End Class
