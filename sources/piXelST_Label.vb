Public Class piXelST_Label
    Inherits System.Windows.Forms.Label


    Private PiXelSTtext As piXelST_Text



    <System.ComponentModel.Browsable(False)>
    Public Overrides Property AutoSize As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Set(value As Boolean)
            MyBase.AutoSize = False
        End Set
    End Property




    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.PiXelSTtext = New piXelST_Text()

        'MyBase.AutoSize = False
        'MyBase.Text = "label"
        MyBase.ForeColor = Color.FromArgb(255, 42, 83, 138)

    End Sub



    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        Dim posX As Integer
        Dim posY As Integer = Me.Padding.Top

        Dim newTextBitmap As Bitmap


        Me.PiXelSTtext.ForeColor = Me.ForeColor
        Me.PiXelSTtext.BackColor = Me.BackColor
        Me.PiXelSTtext.Enabled = Me.Enabled

        newTextBitmap = PiXelSTtext.GetTextBitmap(Me.Text)

        If Not newTextBitmap Is Nothing Then

            Select Case Me.TextAlign
                Case ContentAlignment.BottomLeft, ContentAlignment.BottomCenter, ContentAlignment.BottomRight
                    posY = (Me.Height - 16) - Me.Padding.Bottom

                Case ContentAlignment.MiddleLeft, ContentAlignment.MiddleCenter, ContentAlignment.MiddleRight
                    posY = (Me.Height - 16) / 2

                Case ContentAlignment.TopLeft, ContentAlignment.TopCenter, ContentAlignment.TopRight
                    posY = Me.Padding.Top

            End Select


            Select Case Me.TextAlign
                Case ContentAlignment.BottomLeft, ContentAlignment.MiddleLeft, ContentAlignment.TopLeft
                    posX = Me.Padding.Left

                Case ContentAlignment.BottomCenter, ContentAlignment.MiddleCenter, ContentAlignment.TopCenter
                    posX = (Me.Width / 2) - (newTextBitmap.Width / 2)

                Case ContentAlignment.BottomRight, ContentAlignment.MiddleRight, ContentAlignment.TopRight
                    posX = (Me.Width - newTextBitmap.Width) - Me.Padding.Right

            End Select

            e.Graphics.DrawImage(newTextBitmap, posX, posY, newTextBitmap.Width, 16)
            'e.Graphics.Flush()
        End If

    End Sub


End Class
