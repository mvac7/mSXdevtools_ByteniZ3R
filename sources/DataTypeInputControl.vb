Public Class DataTypeInputControl

    Private AppConfig As Config

    'Private _sizesForColors As Boolean = False

    Private _enableAsmIndex As Boolean = False
    Private _enableCompress As Boolean = True
    Private _enableDataSizeLine As Boolean = False

    Private _compressType As Compress_Type = Compress_Type.RAW


    Private Enum Language_CODE As Integer
        ASSEMBLER_default
        ASSEMBLER_SJasm
        ASSEMBLER_SDCC
        BASIC
        C
    End Enum



    Public Shadows Enum Compress_Type As Integer
        RAW
        RLE
        RLEWB
        PLETTER
    End Enum



    Public Event DataChanged()





    Public ReadOnly Property CodeLanguage As DataFormat.ProgrammingLanguage
        Get
            Dim value As DataFormat.ProgrammingLanguage

            Select Case Me.LanguageComboBox.SelectedIndex
                Case Language_CODE.ASSEMBLER_default To Language_CODE.ASSEMBLER_SDCC
                    value = DataFormat.ProgrammingLanguage.ASSEMBLER
                Case Language_CODE.BASIC
                    value = DataFormat.ProgrammingLanguage.BASIC
                Case Language_CODE.C
                    value = DataFormat.ProgrammingLanguage.C
                Case Else
                    value = DataFormat.ProgrammingLanguage.ASSEMBLER
            End Select
            Return value
        End Get
    End Property



    Public ReadOnly Property NumeralSystem As Integer
        Get
            Return Me.NumberSystemCombo.SelectedIndex
        End Get
    End Property



    ''' <summary>
    ''' number of items to output data line: 8,16,24,32
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SizeLine As Integer
        Get
            If IsNumeric(Me.SizeLineComboBox.SelectedItem) Then
                Return CInt(Me.SizeLineComboBox.SelectedItem)
            Else
                Return -1 'line length
            End If
        End Get
    End Property



    Public Property SizeLineIndex As Integer
        Get
            Return Me.SizeLineComboBox.SelectedIndex
        End Get
        Set(value As Integer)
            If value < 0 Then
                value = Me.SizeLineComboBox.Items.Count - 1
            End If
            Me.SizeLineComboBox.SelectedIndex = value
        End Set
    End Property



    Public Property Compress As Compress_Type
        Get
            Return Me._compressType
        End Get
        Set(value As Compress_Type)
            _compressType = value
            Me.CompressComboBox.SelectedIndex = value
        End Set
    End Property



    Public Property EnableCompress As Boolean
        Get
            Return Me._enableCompress
        End Get
        Set(value As Boolean)
            Me._enableCompress = value
        End Set
    End Property



    Public Property EnableDataSizeLine As Boolean
        Get
            Return Me._enableDataSizeLine
        End Get
        Set(value As Boolean)
            Me._enableDataSizeLine = value
        End Set
    End Property



    ''' <summary>
    ''' Activa el checkbuttom en el menu de assembler para la generación de un indice de los datos
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public Property EnableAssemblerIndex As Boolean
        Get
            Return Me._enableAsmIndex
        End Get
        Set(value As Boolean)
            Me._enableAsmIndex = value
            showIndex()
        End Set
    End Property



    ''' <summary>
    ''' proporciona el estado del checkbuttom para indicar si se quiere que se genere un indice de la lista de datos en assembler
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ASMaddIndex As Boolean
        Get
            If Me.AddIndexCheck.Enabled = True Then
                Return Me.AddIndexCheck.Checked
            Else
                Return False
            End If

        End Get
    End Property



    Public ReadOnly Property CdataType As String
        Get
            Return Me.CdataTypeTextBox.Text
        End Get
    End Property


    Public ReadOnly Property AsmByteCommand As String
        Get
            Return Me.AsmByteDataTextBox.Text
        End Get
    End Property



    Public ReadOnly Property AsmWordDataCommand As String
        Get
            Return Me.AsmWordDataTextBox.Text
        End Get
    End Property



    Public ReadOnly Property BASIClineNumber As Integer
        Get
            Return GetValidateLineNum(Me.LineNumberText.Text)
        End Get
    End Property



    Public ReadOnly Property BASICInterval As Integer
        Get
            Return GetValidateInterval(Me.IntervalText.Text)
        End Get
    End Property



    Public ReadOnly Property BASICremoveZeros As Boolean
        Get
            Return Me.RemoveZerosCheck.Checked
        End Get
    End Property



    Public Property FieldName As String
        Get
            If CodeLanguage = DataFormat.ProgrammingLanguage.ASSEMBLER Then
                Return AsmFieldNameTextBox.Text
            Else
                Return CesFieldNameTextBox.Text
            End If
        End Get
        Set(value As String)
            AsmFieldNameTextBox.Text = value
            CesFieldNameTextBox.Text = value
        End Set
    End Property



    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub



    Private Sub DataTypeInputControl_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        ' posiciona la caja con campos especificos para la salida en assembler
        Me.AssemblerPanel.Location = Me.BasicPanel.Location
        Me.CesPanel.Location = Me.BasicPanel.Location

        Me.AssemblerPanel.BackgroundImage = Me.BasicPanel.BackgroundImage
        Me.CesPanel.BackgroundImage = Me.BasicPanel.BackgroundImage

        Me.LanguageComboBox.SelectedIndex = 0

        If _enableCompress = False Then
            CompressLabel.Enabled = False
            CompressComboBox.Enabled = False
        End If

    End Sub



    Private Sub DataTypeInputControl_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Me.Size = New System.Drawing.Size(Me.Size.Width, 4 + 111 + 2)
    End Sub



    ''' <summary>
    ''' Se ha de ejecutar despues de proporcionar el Config, para que se inicialice el control con los datos adecuados.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitControl(ByRef _config As Config)

        Me.AppConfig = _config

        If Me._enableDataSizeLine = True Then
            Me.SizeLineComboBox.Items.Add("line")
        End If

        RefreshControl()

    End Sub



    Public Sub RefreshControl()

        RemoveHandlers()

        'Me.LanguageComboBox.SelectedIndex = Me.AppConfig.CodeOutput
        Select Case Me.AppConfig.CodeOutput
            Case DataFormat.ProgrammingLanguage.C
                Me.LanguageComboBox.SelectedIndex = Language_CODE.C

            Case DataFormat.ProgrammingLanguage.BASIC
                Me.LanguageComboBox.SelectedIndex = Language_CODE.BASIC

            Case Else
                Me.LanguageComboBox.SelectedIndex = Language_CODE.ASSEMBLER_default

        End Select

        Me.NumberSystemCombo.SelectedIndex = Me.AppConfig.CodeNumberSystem ' lastCodeNumberSystem
        Me.SizeLineComboBox.SelectedIndex = Me.AppConfig.CodeLineSize

        If _enableCompress = True Then
            Me.CompressComboBox.SelectedIndex = Me.AppConfig.CodeCompressType
        Else
            Me.CompressComboBox.SelectedIndex = _compressType
        End If

        Me.FieldName = Me.AppConfig.DataLabel

        Me.AsmByteDataTextBox.Text = Me.AppConfig.AsmByteCommand
        Me.AsmWordDataTextBox.Text = Me.AppConfig.AsmWordDataCommand

        Me.CdataTypeTextBox.Text = Me.AppConfig.CdataType

        Me.LineNumberText.Text = CStr(Me.AppConfig.BASIC_initLine)
        Me.IntervalText.Text = CStr(Me.AppConfig.BASIC_incLines)
        Me.RemoveZerosCheck.Checked = Me.AppConfig.BASIC_remove0

        showIndex()

        ShowLanguageStatus()

        AddHandlers()

    End Sub



    Private Sub AddHandlers()
	
        AddHandler Me.LanguageComboBox.SelectedIndexChanged, AddressOf LanguageComboBox_SelectedIndexChanged
        AddHandler Me.NumberSystemCombo.SelectedIndexChanged, AddressOf NumberSystem_SelectedIndexChanged
        AddHandler Me.SizeLineComboBox.SelectedIndexChanged, AddressOf SizeLineComboBox_SelectedIndexChanged
        AddHandler Me.CompressComboBox.SelectedIndexChanged, AddressOf CompressComboBox_SelectedIndexChanged

        AddHandler Me.CdataTypeTextBox.TextChanged, AddressOf CdataTypeTextBox_TextChanged
        AddHandler Me.AsmByteDataTextBox.TextChanged, AddressOf AsmCommandTextBox_TextChanged
        AddHandler Me.AsmWordDataTextBox.TextChanged, AddressOf AsmWordDataTextBox_TextChanged

        AddHandler Me.RemoveZerosCheck.CheckedChanged, AddressOf RemoveZerosCheck_CheckedChanged
        AddHandler Me.AddIndexCheck.CheckedChanged, AddressOf AddIndexCheck_CheckedChanged

		AddHandler Me.LineNumberText.TextChanged, AddressOf Text_TextChanged
        AddHandler Me.IntervalText.TextChanged, AddressOf Text_TextChanged
        AddHandler Me.AsmByteDataTextBox.TextChanged, AddressOf Text_TextChanged
        AddHandler Me.AsmWordDataTextBox.TextChanged, AddressOf Text_TextChanged

        AddHandler Me.CdataTypeTextBox.TextChanged, AddressOf Text_TextChanged

    End Sub



    Private Sub RemoveHandlers()
	
        RemoveHandler Me.LanguageComboBox.SelectedIndexChanged, AddressOf LanguageComboBox_SelectedIndexChanged
        RemoveHandler Me.NumberSystemCombo.SelectedIndexChanged, AddressOf NumberSystem_SelectedIndexChanged
        RemoveHandler Me.SizeLineComboBox.SelectedIndexChanged, AddressOf SizeLineComboBox_SelectedIndexChanged
        RemoveHandler Me.CompressComboBox.SelectedIndexChanged, AddressOf CompressComboBox_SelectedIndexChanged

        RemoveHandler Me.CdataTypeTextBox.TextChanged, AddressOf CdataTypeTextBox_TextChanged
        RemoveHandler Me.AsmByteDataTextBox.TextChanged, AddressOf AsmCommandTextBox_TextChanged
        RemoveHandler Me.AsmWordDataTextBox.TextChanged, AddressOf AsmWordDataTextBox_TextChanged

        RemoveHandler Me.RemoveZerosCheck.CheckedChanged, AddressOf RemoveZerosCheck_CheckedChanged
        RemoveHandler Me.AddIndexCheck.CheckedChanged, AddressOf AddIndexCheck_CheckedChanged

        RemoveHandler Me.LineNumberText.TextChanged, AddressOf Text_TextChanged
        RemoveHandler Me.IntervalText.TextChanged, AddressOf Text_TextChanged
        RemoveHandler Me.AsmByteDataTextBox.TextChanged, AddressOf Text_TextChanged
        RemoveHandler Me.AsmWordDataTextBox.TextChanged, AddressOf Text_TextChanged

        RemoveHandler Me.CdataTypeTextBox.TextChanged, AddressOf Text_TextChanged

    End Sub



    Private Sub showIndex()
        Try

            Me.AddIndexCheck.Visible = Me._enableAsmIndex
            WordDataLabel.Visible = Me._enableAsmIndex
            AsmWordDataTextBox.Visible = Me._enableAsmIndex

            If Me._enableAsmIndex = True Then
                ShowWordAsmCommand()
            End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub LanguageComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) 'Handles LanguageComboBox.SelectedIndexChanged
        RemoveHandlers()
        ShowLanguageStatus()

        ' ----------------------------------------------------------------------------------------- set default values
        Select Case CodeLanguage
            Case DataFormat.ProgrammingLanguage.BASIC

                'Me.RemoveZerosCheck.Enabled = True
                Select Case Me.NumberSystemCombo.SelectedIndex
                    Case DataFormat.DataType.DECIMAL_n To DataFormat.DataType.DECIMAL_nnnd
                        Me.NumberSystemCombo.SelectedIndex = DataFormat.DataType.DECIMAL_n
                    Case DataFormat.DataType.BINARY_n To DataFormat.DataType.BINARY_BASIC
                        Me.NumberSystemCombo.SelectedIndex = DataFormat.DataType.BINARY_BASIC
                    Case Else
                        Me.NumberSystemCombo.SelectedIndex = DataFormat.DataType.HEXADECIMAL_BASIC
                End Select


            Case DataFormat.ProgrammingLanguage.C

                Set_C_CodeFormat()


            Case Else

                If Me.LanguageComboBox.SelectedIndex = Language_CODE.ASSEMBLER_SDCC Then

                    Me.AsmByteDataTextBox.Text = ".db"
                    Me.AsmWordDataTextBox.Text = ".dw"

                    Set_C_CodeFormat()

                Else
                    If Me.LanguageComboBox.SelectedIndex = Language_CODE.ASSEMBLER_SJasm Then
                        Me.AsmByteDataTextBox.Text = "<tab>DB"
                        Me.AsmWordDataTextBox.Text = "<tab>DW"
                    Else
                        Me.AsmByteDataTextBox.Text = "DB"
                        Me.AsmWordDataTextBox.Text = "DW"
                    End If


                    Select Case Me.NumberSystemCombo.SelectedIndex
                        Case DataFormat.DataType.DECIMAL_n To DataFormat.DataType.DECIMAL_nnnd
                            Me.NumberSystemCombo.SelectedIndex = DataFormat.DataType.DECIMAL_nnnd      '?? default
                        Case DataFormat.DataType.BINARY_n To DataFormat.DataType.BINARY_BASIC
                            Me.NumberSystemCombo.SelectedIndex = DataFormat.DataType.BINARY_nb         '?? default
                        Case Else
                            Me.NumberSystemCombo.SelectedIndex = DataFormat.DataType.HEXADECIMAL_Snn   '?? default
                    End Select

                End If

        End Select

        If Me.NumberSystemCombo.SelectedIndex >= DataFormat.DataType.BINARY_n Then
            Me.SizeLineComboBox.SelectedIndex = 0
        Else
            Me.SizeLineComboBox.SelectedIndex = Me.AppConfig.CodeLineSize
        End If
        ' ----------------------------------------------------------------------------------------- END default values


        AddHandlers()

        RaiseEvent DataChanged()
    End Sub



    Private Sub ShowLanguageStatus()

        Select Case CodeLanguage

            Case DataFormat.ProgrammingLanguage.BASIC  'basic
                Me.BasicPanel.Visible = True
                Me.AssemblerPanel.Visible = False
                Me.CesPanel.Visible = False

            Case DataFormat.ProgrammingLanguage.C
                Me.BasicPanel.Visible = False
                Me.AssemblerPanel.Visible = False
                Me.CesPanel.Visible = True

            Case DataFormat.ProgrammingLanguage.ASSEMBLER
                Me.BasicPanel.Visible = False
                Me.AssemblerPanel.Visible = True
                Me.CesPanel.Visible = False

        End Select

    End Sub



    Private Sub Set_C_CodeFormat()
        Select Case Me.NumberSystemCombo.SelectedIndex
            Case DataFormat.DataType.DECIMAL_n To DataFormat.DataType.DECIMAL_nnnd
                Me.NumberSystemCombo.SelectedIndex = DataFormat.DataType.DECIMAL_n
            Case DataFormat.DataType.BINARY_n To DataFormat.DataType.BINARY_BASIC
                Me.NumberSystemCombo.SelectedIndex = DataFormat.DataType.BINARY_C
            Case Else
                Me.NumberSystemCombo.SelectedIndex = DataFormat.DataType.HEXADECIMAL_C
        End Select
    End Sub



    Private Sub NumberSystem_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        'Me.AppConfig.CodeNumberSystem = NumberSystemCombo.SelectedIndex
        RaiseEvent DataChanged()
    End Sub



    Private Sub SizeLineComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        'Me.AppConfig.CodeLineSize = SizeLineComboBox.SelectedIndex
        RaiseEvent DataChanged()
    End Sub



    Private Sub CompressComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        'Me.AppConfig.CodeCompressType = CompressComboBox.SelectedIndex
        _compressType = Me.AppConfig.CodeCompressType
        RaiseEvent DataChanged()
    End Sub



    Private Sub CdataTypeTextBox_TextChanged(sender As System.Object, e As System.EventArgs) 'Handles CdataTypeTextBox.TextChanged
        'Me.AppConfig.CdataType = Me.CdataTypeTextBox.Text
        RaiseEvent DataChanged()
    End Sub



    Private Sub AsmCommandTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.AppConfig.AsmByteCommand = Me.AsmByteDataTextBox.Text
        RaiseEvent DataChanged()
    End Sub



    Private Sub AsmWordDataTextBox_TextChanged(sender As System.Object, e As System.EventArgs)
        'Me.AppConfig.AsmWordDataCommand = Me.AsmWordDataTextBox.Text
        RaiseEvent DataChanged()
    End Sub



    Private Sub RemoveZerosCheck_CheckedChanged(sender As System.Object, e As System.EventArgs) ' Handles RemoveZerosCheck.CheckedChanged
        RaiseEvent DataChanged()
    End Sub



    Private Sub Text_TextChanged(sender As Object, e As EventArgs)
        RaiseEvent DataChanged()
    End Sub



    Private Sub AddIndexCheck_CheckedChanged(sender As System.Object, e As System.EventArgs) 'Handles AddIndexCheck.CheckedChanged
        ShowWordAsmCommand()
        RaiseEvent DataChanged()
    End Sub



    Private Sub ShowWordAsmCommand()
        WordDataLabel.Enabled = AddIndexCheck.Checked
        AsmWordDataTextBox.Enabled = AddIndexCheck.Checked
    End Sub



    Private Sub LineNumberText_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LineNumberText.Validating
        Me.LineNumberText.Text = CStr(GetValidateLineNum(Me.LineNumberText.Text))
    End Sub



    Private Sub IntervalText_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles IntervalText.Validating
        Me.IntervalText.Text = GetValidateInterval(Me.IntervalText.Text)
    End Sub



    ''' <summary>
    ''' validates the value of the initial line number
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetValidateLineNum(ByVal value As String) As Integer
        Dim aNumber As Integer
        If IsNumeric(value) Then
            aNumber = CInt(value)
            If aNumber < 1 Or aNumber > 60000 Then
                aNumber = 10000
            End If
        Else
            aNumber = 10000
        End If

        Return aNumber
    End Function



    Private Function GetValidateInterval(ByVal value As String) As Integer
        Dim aNumber As Integer
        If IsNumeric(value) Then
            aNumber = CInt(value)
            If aNumber < 1 Or aNumber > 100 Then
                aNumber = 10
            End If
        Else
            aNumber = 10
        End If
        Return aNumber
    End Function



    Public Function GetInfoSuffix() As String

        Dim outputInfo As String

        Select Case Me.CompressComboBox.SelectedIndex

            Case 1
                outputInfo = "_RLE"

            Case 2
                outputInfo = "_RLEWB"

            Case 3
                outputInfo = "_PLT"

            Case Else
                outputInfo = ""

        End Select

        Return outputInfo
    End Function



    Private Sub AsmFieldNameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AsmFieldNameTextBox.Validating
        If Me.AsmFieldNameTextBox.Text.Trim() = "" Then
            Me.AsmFieldNameTextBox.Text = "DATA"
        End If
        RaiseEvent DataChanged()
    End Sub



    Private Sub CesFieldNameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CesFieldNameTextBox.Validating
        If Me.CesFieldNameTextBox.Text.Trim() = "" Then
            Me.CesFieldNameTextBox.Text = "DATA"
        End If
        RaiseEvent DataChanged()
    End Sub



End Class
