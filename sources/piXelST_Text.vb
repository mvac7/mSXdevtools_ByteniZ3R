Imports System.Drawing.Imaging


Public Class piXelST_Text

    Private tilesetBitmap As Bitmap

    Private charSize As Byte() = {6, 3, 4, 6, 6, 7, 8, 4, 5, 5, 7, 7, 3, 6, 3, 8, 7, 4, 7, 6, 7, 7, 7, 7, 7, 7, 3, 3, 5, 5, 5, 7,
                                  8, 7, 7, 6, 7, 7, 7, 7, 7, 3, 7, 7, 6, 8, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 7, 7, 4, 8, 4, 6, 7,
                                  6, 7, 7, 6, 7, 7, 6, 7, 7, 3, 4, 7, 3, 8, 7, 7, 7, 7, 6, 6, 7, 7, 7, 8, 8, 7, 7, 6, 6, 6, 6, 6}


    'Private _text As String = "PiXelST_Text"


    'Public Property TextValue() As String
    '    Get
    '        Return Me._text
    '    End Get
    '    Set(value As String)
    '        Me._text = value
    '    End Set
    'End Property



    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.tilesetBitmap = piXelS_font.Image
        'Me.tilesetBitmap = Global.mSXdevtools.GUI.Controls.My.Resources.Resources.piXelS_font_x2

        Me.ForeColor = Color.FromArgb(255, 42, 83, 138)

        Me.Visible = False

    End Sub



    'Private Sub piXelST_Text_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

    '    Dim newTextBitmap As Bitmap = GetTextBitmap(Me.Text)

    '    If Not newTextBitmap Is Nothing Then
    '        e.Graphics.DrawImage(newTextBitmap, 0, 0, newTextBitmap.Width, 16)
    '        Me.Width = newTextBitmap.Width
    '        Me.Height = 16
    '    End If

    'End Sub


    Public Function GetTextWidth(aText As String) As Integer

        Dim textBitmapWidth As Integer = 0

        Dim nchar As Integer

        For i = 0 To aText.Length - 1
            nchar = AscW(aText.Chars(i)) - 32
            If nchar >= 0 And nchar < 96 Then
                textBitmapWidth += (charSize(nchar) * 2)
            End If
        Next

        Return textBitmapWidth

    End Function



    Public Function GetTextBitmap(aText As String) As Bitmap

        Dim textBitmap As Bitmap
        Dim textGraphics As Graphics

        Dim textBitmapWidth As Integer

        Dim char_Color As Color
        'Dim char_Size As Integer

        Dim charAttributes As ImageAttributes

        Dim nchar As Integer
        Dim charBitmap As Bitmap

        Dim posChar As Integer = 0
        'Dim posY As Integer = 0

        If Me.Enabled Then
            char_Color = ForeColor
        Else
            char_Color = Color.FromArgb(128, ForeColor.R, ForeColor.G, ForeColor.B)
        End If

        charAttributes = GetAttributeColors(char_Color)

        If Not aText = "" Then

            textBitmapWidth = 0
            For i = 0 To aText.Length - 1
                nchar = AscW(aText.Chars(i)) - 32
                If nchar >= 0 And nchar < 96 Then
                    textBitmapWidth += (charSize(nchar) * 2)
                End If
            Next

            textBitmap = New Bitmap(textBitmapWidth, 16, PixelFormat.Format32bppArgb)
            textGraphics = Graphics.FromImage(textBitmap)

            For i = 0 To aText.Length - 1

                nchar = AscW(aText.Chars(i)) - 32
                charBitmap = GetTile(nchar)
                'char_Size = CharSize(nchar) * 2
                textGraphics.DrawImage(charBitmap, New Rectangle(posChar, 0, charBitmap.Width, 16), 0, 0, charBitmap.Width, 16, GraphicsUnit.Pixel, charAttributes)
                posChar += charBitmap.Width

            Next

            Return textBitmap

        Else

            Return Nothing

        End If

    End Function




    Private Function GetTile(ByVal nchar As Integer) As Bitmap
        ' This function creates a cropped instance of the input bitmap, at coordiates and of the size specified.
        'nchar -= 32
        If nchar < 0 Or nchar > 95 Then
            nchar = 0
        End If
        Dim posY As Short = Fix(nchar / 32)
        Dim posX As Short = nchar - (posY * 32)
        Dim char_Size As Integer = charSize(nchar) * 2
        Dim rect As New Rectangle(posX * 16, posY * 16, char_Size, 16)
        Return Me.tilesetBitmap.Clone(rect, Me.tilesetBitmap.PixelFormat)
    End Function



    Private Function GetAttributeColors(ByVal inkColor As Color) As ImageAttributes

        Dim imageAttributes = New ImageAttributes()
        Dim colorItem = New ColorMap()
        Dim colorBG = New ColorMap()
        Dim remapTable(0) As ColorMap

        colorItem.OldColor = Color.FromArgb(255, 42, 83, 138)
        colorItem.NewColor = inkColor
        remapTable(0) = colorItem

        imageAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap)

        Return imageAttributes

    End Function


End Class
