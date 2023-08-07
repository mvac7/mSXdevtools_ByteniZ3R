Imports System.Drawing.Imaging

Public Class piXelST_GroupBox

    Private PiXelSTtext As piXelST_Text


    'Private charSize As Byte() = {6, 3, 4, 6, 6, 7, 8, 4, 5, 5, 7, 7, 3, 6, 3, 8, 7, 4, 7, 6, 7, 7, 7, 7, 7, 7, 3, 3, 5, 5, 5, 7,
    '                              8, 7, 7, 6, 7, 7, 7, 7, 7, 3, 7, 7, 6, 8, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 7, 7, 4, 8, 4, 6, 7,
    '                              6, 7, 7, 6, 7, 7, 6, 7, 7, 3, 4, 7, 3, 8, 7, 7, 7, 7, 6, 6, 7, 7, 7, 8, 8, 7, 7, 6, 6, 6, 6, 6}


    Private _BGColor As Color = Color.LightGray
    Private _LineColor As Color = Color.DimGray


    Public Property BGColor() As Color
        Get
            Return Me._BGColor
        End Get
        Set(value As Color)
            Me._BGColor = value
        End Set
    End Property


    Public Property LineColor() As Color
        Get
            Return Me._LineColor
        End Get
        Set(value As Color)
            Me._LineColor = value
        End Set
    End Property



    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.PiXelSTtext = New piXelST_Text()

        Me.BackColor = Color.Transparent '   LightGray
        Me.ForeColor = Color.FromArgb(255, 42, 83, 138)
        'Me.Padding = New System.Windows.Forms.Padding(0)

    End Sub



    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        'MyBase.OnPaint(e)

        Dim newTextBitmap As Bitmap

        Dim tmpLineColor As Color

        Dim linePen As Pen
        Dim posX As Integer = Me.Padding.Left + 2
        Dim posY As Integer = Me.Padding.Top + 8
        Dim boxWidth As Integer = Me.Width - (posX + Me.Padding.Right + 2)
        Dim boxHeight As Integer = Me.Height - (posY + Me.Padding.Bottom + 2)


        If Me.Enabled Then
            tmpLineColor = Me._LineColor
        Else
            tmpLineColor = Me._BGColor
        End If

        Me.PiXelSTtext.ForeColor = Me.ForeColor
        Me.PiXelSTtext.BackColor = Me.BackColor
        Me.PiXelSTtext.Enabled = Me.Enabled

        newTextBitmap = PiXelSTtext.GetTextBitmap(Me.Text)

        e.Graphics.FillRectangle(New SolidBrush(Me._BGColor), posX, posY, boxWidth, boxHeight)

        linePen = New Pen(tmpLineColor, 4)

        If Me.Enabled And Not newTextBitmap Is Nothing Then
            e.Graphics.DrawLine(linePen, posX, posY, posX + 10, posY)
            e.Graphics.DrawLine(linePen, posX + newTextBitmap.Width + 16, posY, posX + boxWidth, posY)
        Else
            e.Graphics.DrawLine(linePen, posX, posY, posX + boxWidth, posY)
        End If

        e.Graphics.DrawLine(linePen, posX, posY, posX, posY + boxHeight)
        e.Graphics.DrawLine(linePen, posX + boxWidth, posY, posX + boxWidth, posY + boxHeight)
        e.Graphics.DrawLine(linePen, posX, posY + boxHeight, posX + boxWidth, posY + boxHeight)

        If Not newTextBitmap Is Nothing Then
            e.Graphics.DrawImage(newTextBitmap, posX + 12, Me.Padding.Top, newTextBitmap.Width, 16)
        End If

    End Sub


End Class
