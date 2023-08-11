''' <summary>
''' GUI controller to manage the output format to source code.
''' Requires the enums that are in the DataFormat class. 
''' </summary>
Public Class DataTypeInputControl

    Private AppConfig As Config

    'Private _sizesForColors As Boolean = False

    Private _enableAsmIndex As Boolean = False
    Private _enableCompress As Boolean = True
    Private _enableDataSizeLine As Boolean = False

    Private _compressType As COMPRESS_TYPE = COMPRESS_TYPE.RAW

    Private _dataFormat As New DataFormat



    Public Event DataChanged()




    Public Shadows Enum COMPRESS_TYPE As Integer
        RAW
        RLE
        RLEWB
        PLETTER5
    End Enum




    Public Property LanguageCode As CodeInfo.LANGUAGE_CODE
        Get
            Return Me.LanguageComboBox.SelectedIndex
        End Get
        Set(value As CodeInfo.LANGUAGE_CODE)
            Me.LanguageComboBox.SelectedIndex = value
        End Set
    End Property





    Public ReadOnly Property ProgrammingLanguage As CodeInfo.PROGRAMMING_LANGUAGE
        Get
            Dim aCodeFormat As New CodeInfo
            Return aCodeFormat.GetProgrammingLanguageByLanguageCode(LanguageComboBox.SelectedIndex)
        End Get
    End Property



    Public Property NumeralSystem As Integer
        Get
            Return Me.NumberSystemCombo.SelectedIndex
        End Get
        Set(value As Integer)
            Me.NumberSystemCombo.SelectedIndex = value
        End Set
    End Property



    Public Property EnableDataLineSize As Boolean
        Get
            Return Me._enableDataSizeLine
        End Get
        Set(value As Boolean)
            Me._enableDataSizeLine = value
        End Set
    End Property




    ''' <summary>
    ''' number of items to output data line: 8,16,24,32
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property LineSize As Integer
        Get
            If IsNumeric(Me.SizeLineComboBox.SelectedItem) Then
                Return CInt(Me.SizeLineComboBox.SelectedItem)
            Else
                Return -1
            End If
        End Get
    End Property



    Public Property LineSizeIndex As Integer
        Get
            Return Me.SizeLineComboBox.SelectedIndex
        End Get
        Set(value As Integer)
            If value < 0 Or value > Me.SizeLineComboBox.Items.Count Then
                value = Me.SizeLineComboBox.Items.Count - 1
            End If
            Me.SizeLineComboBox.SelectedIndex = value
        End Set
    End Property



    Public Property CompressType As COMPRESS_TYPE
        Get
            Return Me._compressType
        End Get
        Set(value As COMPRESS_TYPE)
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
            ShowIndex()
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


    Public Property AsmDataByteCommand As String
        Get
            Return Me.AsmByteDataTextBox.Text
        End Get
        Set(value As String)
            Me.AsmByteDataTextBox.Text = value
        End Set
    End Property



    Public Property AsmDataWordCommand As String
        Get
            Return Me.AsmWordDataTextBox.Text
        End Get
        Set(value As String)
            Me.AsmWordDataTextBox.Text = value
        End Set
    End Property



    Public Property BASIClineNumber As Integer
        Get
            Return GetValidateLineNum(Me.LineNumberText.Text)
        End Get
        Set(value As Integer)
            Me.LineNumberText.Text = value
        End Set
    End Property



    Public Property BASIClineInterval As Integer
        Get
            Return GetValidateInterval(Me.IntervalText.Text)
        End Get
        Set(value As Integer)
            Me.IntervalText.Text = value
        End Set
    End Property



    Public Property BASICremoveZeros As Boolean
        Get
            Return Me.RemoveZerosCheck.Checked
        End Get
        Set(value As Boolean)
            Me.RemoveZerosCheck.Checked = value
        End Set
    End Property



    Public Property FieldName As String
        Get
            If ProgrammingLanguage = CodeInfo.Programming_Language.ASSEMBLER Then
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

        If Me._enableCompress = False Then
            CompressLabel.Enabled = False
            CompressComboBox.Enabled = False
        End If

        If Me._enableDataSizeLine = True Then
            Me.SizeLineComboBox.Items.Add("line")
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

        RefreshControl()

    End Sub



    Public Sub RefreshControl()

        RemoveHandlers()

        Me.LanguageComboBox.SelectedIndex = Me.AppConfig.CodeOutput

        Me.NumberSystemCombo.SelectedIndex = Me.AppConfig.CodeNumberSystem ' lastCodeNumberSystem
        Me.SizeLineComboBox.SelectedIndex = Me.AppConfig.CodeLineSize

        'If _enableCompress = True Then
        '    Me.CompressComboBox.SelectedIndex = Me.AppConfig.CodeCompressType
        'Else
        '    Me.CompressComboBox.SelectedIndex = _compressType
        'End If
        If _enableCompress = True Then
            _compressType = Me.AppConfig.CodeCompressType
        End If
        Me.CompressComboBox.SelectedIndex = _compressType

        Me.FieldName = Me.AppConfig.DataLabel

        Me.AsmByteDataTextBox.Text = Me.AppConfig.AsmDataByteCommand
        Me.AsmWordDataTextBox.Text = Me.AppConfig.AsmDataWordCommand

        Me.CdataTypeTextBox.Text = Me.AppConfig.CdataType

        Me.LineNumberText.Text = CStr(Me.AppConfig.BASIC_initLine)
        Me.IntervalText.Text = CStr(Me.AppConfig.BASIC_incLines)
        Me.RemoveZerosCheck.Checked = Me.AppConfig.BASIC_remove0

        ShowIndex()

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



    Private Sub ShowIndex()
        Try

            Me.AddIndexCheck.Visible = Me._enableAsmIndex
            WordDataLabel.Visible = Me._enableAsmIndex
            AsmWordDataTextBox.Visible = Me._enableAsmIndex

            AsmFieldNameTextBox.Enabled = Not Me._enableAsmIndex
            CesFieldNameTextBox.Enabled = Not Me._enableAsmIndex

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
        Select Case LanguageComboBox.SelectedIndex
            Case CodeInfo.Language_CODE.BASIC

                'Me.RemoveZerosCheck.Enabled = True
                Select Case Me.NumberSystemCombo.SelectedIndex
                    Case CodeInfo.DataType.DECIMAL_n To CodeInfo.DataType.DECIMAL_nnnd
                        Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.DECIMAL_n
                    Case CodeInfo.DataType.BINARY_n To CodeInfo.DataType.BINARY_BASIC
                        Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.BINARY_BASIC
                    Case Else
                        Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.HEXADECIMAL_BASIC
                End Select


            Case CodeInfo.Language_CODE.C

                Set_C_CodeFormat()


            Case CodeInfo.Language_CODE.ASSEMBLER_SDCC

                Me.AsmByteDataTextBox.Text = ".DB"
                Me.AsmWordDataTextBox.Text = ".DW"

                Set_C_CodeFormat()

            Case CodeInfo.Language_CODE.ASSEMBLER_SJasm

                Me.AsmByteDataTextBox.Text = "<tab>DB"
                Me.AsmWordDataTextBox.Text = "<tab>DW"

                SetAssemblerNumericSystem()

            Case CodeInfo.Language_CODE.ASSEMBLER_asMSX, CodeInfo.Language_CODE.ASSEMBLER_tniASM

                Me.AsmByteDataTextBox.Text = "DB"
                Me.AsmWordDataTextBox.Text = "DW"

                SetAssemblerNumericSystem()

            Case CodeInfo.Language_CODE.ASSEMBLER_default

                Me.AsmByteDataTextBox.Text = Me.AppConfig.AsmDataByteCommand
                Me.AsmWordDataTextBox.Text = Me.AppConfig.AsmDataWordCommand

                SetAssemblerNumericSystem()

        End Select

        If Me.NumberSystemCombo.SelectedIndex >= CodeInfo.DataType.BINARY_n Then
            Me.SizeLineComboBox.SelectedIndex = 0
        Else
            Me.SizeLineComboBox.SelectedIndex = Me.AppConfig.CodeLineSize
        End If
        ' ----------------------------------------------------------------------------------------- END default values


        AddHandlers()

        RaiseEvent DataChanged()

    End Sub



    Private Sub ShowLanguageStatus()

        Select Case ProgrammingLanguage

            Case CodeInfo.Programming_Language.BASIC  'basic
                Me.BasicPanel.Visible = True
                Me.AssemblerPanel.Visible = False
                Me.CesPanel.Visible = False

            Case CodeInfo.Programming_Language.C
                Me.BasicPanel.Visible = False
                Me.AssemblerPanel.Visible = False
                Me.CesPanel.Visible = True

            Case CodeInfo.Programming_Language.ASSEMBLER
                Me.BasicPanel.Visible = False
                Me.AssemblerPanel.Visible = True
                Me.CesPanel.Visible = False

        End Select

    End Sub



    Private Sub Set_C_CodeFormat()
        Select Case Me.NumberSystemCombo.SelectedIndex
            Case CodeInfo.DataType.DECIMAL_n To CodeInfo.DataType.DECIMAL_nnnd
                Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.DECIMAL_n
            Case CodeInfo.DataType.BINARY_n To CodeInfo.DataType.BINARY_BASIC
                Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.BINARY_C
            Case Else
                Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.HEXADECIMAL_C
        End Select
    End Sub



    Private Sub SetAssemblerNumericSystem()
        Select Case Me.NumberSystemCombo.SelectedIndex
            Case CodeInfo.DataType.DECIMAL_n To CodeInfo.DataType.DECIMAL_nnnd
                Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.DECIMAL_nnnd      '?? default
            Case CodeInfo.DataType.BINARY_n To CodeInfo.DataType.BINARY_BASIC
                Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.BINARY_nb         '?? default
            Case Else
                Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.HEXADECIMAL_Snn   '?? default
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
        Me._compressType = CompressComboBox.SelectedIndex 'Me.AppConfig.CodeCompressType
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

        Dim outputInfo As String = ""

        'Dim compressController As New Compress


        'If Not Me.CompressComboBox.SelectedIndex = 0 Then
        '    outputInfo = "_" + compressController.CompresorsAbbreviationList(Me.CompressComboBox.SelectedIndex)
        'End If

        Select Case Me.CompressComboBox.SelectedIndex

            Case COMPRESS_TYPE.RLE
                outputInfo = "_RLE"

            Case COMPRESS_TYPE.RLEWB
                outputInfo = "_RLEWB"

            Case COMPRESS_TYPE.PLETTER5
                outputInfo = "_PLT5"

            Case Else
                outputInfo = ""

        End Select

        Return outputInfo

    End Function



    Private Sub AsmFieldNameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AsmFieldNameTextBox.Validating

        Me.AsmFieldNameTextBox.Text = _dataFormat.GetAsmFieldFormat(Me.AsmFieldNameTextBox.Text)

        RaiseEvent DataChanged()
    End Sub



    Private Sub CesFieldNameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CesFieldNameTextBox.Validating

        Me.CesFieldNameTextBox.Text = _dataFormat.GetCvariableNameFormat(Me.CesFieldNameTextBox.Text)

        RaiseEvent DataChanged()
    End Sub



    Public Function GetCodeFormat() As CodeInfo

        Dim aCodeFormat As New CodeInfo

        aCodeFormat.LanguageCode = Me.LanguageCode
        aCodeFormat.NumeralSystem = Me.NumeralSystem
        aCodeFormat.LineSize = Me.LineSize
        aCodeFormat.CompressType = Me.CompressType

        aCodeFormat.DataLabel = Me.FieldName

        aCodeFormat.AsmDataByteCommand = Me.AsmDataByteCommand
        aCodeFormat.AsmDataWordCommand = Me.AsmDataWordCommand

        aCodeFormat.CdataType = Me.CdataType

        aCodeFormat.BASIC_DataInstruction = Me.AppConfig.BASIC_DataInstruction
        aCodeFormat.BASIC_CommentInstruction = Me.AppConfig.BASIC_CommentInstruction
        aCodeFormat.BASIC_initLine = Me.BASIClineNumber
        aCodeFormat.BASIC_incLines = Me.BASIClineInterval
        aCodeFormat.BASIC_remove0 = Me.BASICremoveZeros

        Return aCodeFormat

    End Function



End Class
