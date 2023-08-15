Public Class piXelST_HorizontalTab

    Private _selectedTab As Integer = -1

    Private PiXelSTtext As piXelST_Text

    Private Tab_Height As Integer = 32



    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.PiXelSTtext = New piXelST_Text()

    End Sub


    ' EVENTs ###########################################################################################################################

    Public Event TabChanged(ByVal index As Integer)

    ' ####################################################################################################################### END EVENTs


    Public Property Items As String() = {"item0"}


    Private tabList As New ArrayList()



    Public ReadOnly Property SelectedTab As Integer
        Get
            Return _selectedTab
        End Get
    End Property



    Private Sub VerttiTAB_Load(sender As Object, e As EventArgs) Handles Me.Load


        Dim index As Integer = 0
        Dim TabItem As PictureBox

        Me.Tab_Height = Me.Height - Padding.Top

        Me.SuspendLayout()

        If Me.Items IsNot Nothing Then

            'For i As Integer = 0 To Me.Items.Length - 1
            For Each item As String In Me.Items
                'TabButton = GetTabButton(Me.Items(i), i)
                TabItem = GetTab(item, index)
                index += 1
                Me.Controls.Add(TabItem)
                tabList.Add(TabItem)
                TabItem.BringToFront()
                TabItem.Dock = System.Windows.Forms.DockStyle.Left
                AddHandler TabItem.Click, AddressOf Me.TabItem_Click
            Next

            'For Each item As String In Me.Items

            'Next
        End If

        Me.ResumeLayout(False)


        SetTab(0)

    End Sub


    'Private Sub piXelST_HorizontalTAB_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint


    'End Sub



    Public Sub SetTab(index As Integer)

        Dim TabItem As PictureBox

        If Me._selectedTab >= 0 Then
            TabItem = Me.tabList.Item(Me._selectedTab)
            'TabButton.ButtonType = piXelST_Button.Button_TYPES.Tab_Unselected
            TabItem.Image = GetTabImage(TabItem.Text, False)
            TabItem.Refresh()
        End If

        TabItem = Me.tabList.Item(index)
        TabItem.Image = GetTabImage(TabItem.Text, True)
        'TabButton.ButtonType = piXelST_Button.Button_TYPES.Tab_Selected
        TabItem.Refresh()
        Me._selectedTab = index

    End Sub



    Private Sub TabItem_Click(sender As Object, e As EventArgs)
        Dim TabItem As PictureBox = sender
        SetTab(TabItem.TabIndex)
        RaiseEvent TabChanged(TabItem.TabIndex)
    End Sub



    Private Function GetTab(ByVal aName As String, ByVal index As Integer) As PictureBox

        Dim tabImage As Bitmap = GetTabImage(aName, False)

        Dim TabButton = New PictureBox()

        'TabButton.BackColor = Me.BackColor

        'TabButton.ButtonColor = Me.ForeColor
        'TabButton.ButtonType = piXelST_Button.Button_TYPES.Tab_Unselected

        'TabButton.ButtonColor = System.Drawing.Color.LightGray
        'TabButton.FlatAppearance.BorderSize = 0
        'TabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        'TabButton.ImageIndex = 1
        'TabButton.ImageList = Me.ImageList1
        'TabButton.Location = New System.Drawing.Point(0, 0)
        'TabButton.Margin = New System.Windows.Forms.Padding(0)
        'TabButton.Padding = New Padding(2)

        TabButton.Name = aName
        TabButton.Text = aName
        TabButton.TabIndex = index
        TabButton.Size = New System.Drawing.Size(tabImage.Width, Tab_Height)
        TabButton.BackgroundImageLayout = ImageLayout.None
        TabButton.BackgroundImage = tabImage
        TabButton.Cursor = Cursors.Hand

        Return TabButton

    End Function



    Private Function GetTabImage(ByVal aName As String, ByVal isSelected As Boolean) As Bitmap

        Dim posX As Integer
        Dim posY As Integer
        Dim buttonTop As Integer

        Dim newTextBitmap As Bitmap
        Dim tabImage As Bitmap
        Dim tabGraphics As Graphics

        Dim buttonBrush As Brush

        Dim newButtonColor As Color

        Dim tabWidth As Integer

        If isSelected Then
            newButtonColor = Me.ForeColor
            buttonTop = 0
            'posY = buttonTop + 4

        Else
            newButtonColor = Color.FromArgb(170, 170, 170)
            buttonTop = 2
            'posY = 6
        End If

        PiXelSTtext.ForeColor = Color.FromArgb(255, 42, 83, 138)
        PiXelSTtext.BackColor = Color.Transparent   'Me.BackColor
        PiXelSTtext.Enabled = Me.Enabled
        newTextBitmap = PiXelSTtext.GetTextBitmap(aName)

        If newTextBitmap IsNot Nothing Then
            tabWidth = newTextBitmap.Width + 32
        Else
            tabWidth = 32
        End If

        tabImage = New Bitmap(tabWidth, Tab_Height)
        tabGraphics = Graphics.FromImage(tabImage)
        tabGraphics.Clear(Me.BackColor)

        buttonBrush = New SolidBrush(newButtonColor)
        tabGraphics.FillRectangle(buttonBrush, 2, buttonTop, tabWidth - 6, 2)
        tabGraphics.FillRectangle(buttonBrush, 0, buttonTop + 2, tabWidth - 2, Tab_Height - buttonTop)

        If newTextBitmap IsNot Nothing Then
            posX = (tabWidth / 2) - (newTextBitmap.Width / 2) - 2
            posY = ((Tab_Height - 16) / 2) + Padding.Top + buttonTop - 4
            tabGraphics.DrawImage(newTextBitmap, posX, posY, newTextBitmap.Width, 16)
        End If

        Return tabImage

    End Function



End Class
