Public Class HexDump
    Inherits System.Windows.Forms.UserControl

    Public WriteOnly Property BinaryData() As Byte()
        Set(ByVal Value As Byte())

            Try

                HexDumpListView.Items.Clear()

                Dim item As ListViewItem

                Dim AdrData As String
                Dim hexData As String
                Dim AscData As String
                Dim Adress As Integer = 0
                Dim unk As String

                Dim valorHex As String

                Dim ch As Integer
                Dim i As Integer
                Dim o As Integer

                Dim lineSize As Integer = 16

                Dim num_bytes As Integer

                num_bytes = Value.Length - 1

                unk = Chr(191)

                Do While i <= num_bytes
                    AdrData = Hex(i).PadLeft(4, Chr(48))
                    AscData = ""
                    hexData = ""
                    For o = 0 To lineSize - 1
                        If i + o > num_bytes Then
                            hexData += "   "

                        Else
                            ch = CInt(Value(i + o))

                            valorHex = Hex(ch).PadLeft(2, Chr(48)) 'caracter cero

                            hexData += valorHex + " "
                            If ch >= 32 Then
                                AscData += Chr(ch)
                            Else
                                AscData += unk
                            End If
                        End If
                    Next o

                    item = HexDumpListView.Items.Add(AdrData)
                    item.SubItems.Add(hexData)
                    item.SubItems.Add(AscData)

                    i += lineSize

                Loop

            Catch ex As Exception

            End Try

        End Set
    End Property


   
    Public Sub Clear()

        HexDumpListView.Items.Clear()

    End Sub






#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Private WithEvents HexDumpListView As System.Windows.Forms.ListView
    Friend WithEvents hexCol As System.Windows.Forms.ColumnHeader
    Friend WithEvents addressCol As System.Windows.Forms.ColumnHeader
    Friend WithEvents asciiCol As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.HexDumpListView = New System.Windows.Forms.ListView
        Me.addressCol = New System.Windows.Forms.ColumnHeader
        Me.hexCol = New System.Windows.Forms.ColumnHeader
        Me.asciiCol = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'HexDumpListView
        '
        Me.HexDumpListView.BackColor = System.Drawing.Color.White
        Me.HexDumpListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HexDumpListView.CausesValidation = False
        Me.HexDumpListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.addressCol, Me.hexCol, Me.asciiCol})
        Me.HexDumpListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HexDumpListView.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HexDumpListView.ForeColor = System.Drawing.Color.Black
        Me.HexDumpListView.FullRowSelect = True
        Me.HexDumpListView.GridLines = True
        Me.HexDumpListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.HexDumpListView.Location = New System.Drawing.Point(0, 0)
        Me.HexDumpListView.Name = "HexDumpListView"
        Me.HexDumpListView.Size = New System.Drawing.Size(550, 76)
        Me.HexDumpListView.TabIndex = 0
        Me.HexDumpListView.UseCompatibleStateImageBehavior = False
        Me.HexDumpListView.View = System.Windows.Forms.View.Details
        '
        'addressCol
        '
        Me.addressCol.Width = 50
        '
        'hexCol
        '
        Me.hexCol.Width = 350
        '
        'asciiCol
        '
        Me.asciiCol.Width = 130
        '
        'HexDump
        '
        Me.Controls.Add(Me.HexDumpListView)
        Me.Name = "HexDump"
        Me.Size = New System.Drawing.Size(550, 76)
        Me.ResumeLayout(False)

    End Sub

#End Region


End Class
