Imports System.IO

Public Class OutputDataGBox

    Private AppConfig As New Config

    Private fileData() As Byte
    'Private _outputData() As Byte
    Private Comments As ArrayList

    Private Project_Path As String
    Private Project_Name As String

    Public Extension_Binary As String = ".bin"

    Public Event DataChanged()


    Public Property HasSign As Boolean = False


    Public Property OutputText As String
        Get
            Return Me.OutputTextBox.Text
        End Get
        Set(value As String)
            Me.OutputTextBox.Text = value
        End Set
    End Property



    Public Property LanguageCode As CodeInfo.LANGUAGE_CODE
        Get
            Return DataTypeInput.LanguageCode
        End Get
        Set(value As CodeInfo.LANGUAGE_CODE)
            Me.DataTypeInput.LanguageCode = value
        End Set
    End Property



    Public Property NumeralSystem As Integer
        Get
            Return DataTypeInput.NumeralSystem
        End Get
        Set(value As Integer)
            DataTypeInput.NumeralSystem = value
        End Set
    End Property



    Public Property EnableDataSizeLine As Boolean
        Get
            Return DataTypeInput.EnableDataLineSize
        End Get
        Set(value As Boolean)
            DataTypeInput.EnableDataLineSize = value
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
            Return DataTypeInput.LineSize
        End Get
    End Property



    Public Property LineSizeIndex As Integer
        Get
            Return DataTypeInput.LineSizeIndex
        End Get
        Set(value As Integer)
            DataTypeInput.LineSizeIndex = value
        End Set
    End Property



    Public Property Compress As DataTypeInputControl.COMPRESS_TYPE
        Get
            Return DataTypeInput.CompressType
        End Get
        Set(value As DataTypeInputControl.COMPRESS_TYPE)
            DataTypeInput.CompressType = value
        End Set
    End Property



    'Public Property DropDown As Boolean
    '    Get
    '        Return Me.isOpen
    '    End Get
    '    Set(value As Boolean)

    '        Me.isOpen = value

    '        If isInit = True Then
    '            SetDropDown(Me.isOpen)
    '        End If

    '    End Set
    'End Property


    Public Property EnableCompress As Boolean
        Get
            Return DataTypeInput.EnableCompress
        End Get
        Set(value As Boolean)
            DataTypeInput.EnableCompress = value
        End Set
    End Property



    ''' <summary>
    ''' Activa el checkbuttom en el menu de assembler para la generación de un indice de los datos
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public Property EnableAssemblerIndex As Boolean
        Get
            Return DataTypeInput.EnableAssemblerIndex
        End Get
        Set(value As Boolean)
            DataTypeInput.EnableAssemblerIndex = value
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
            Return DataTypeInput.ASMaddIndex
        End Get
    End Property



    Public ReadOnly Property C_UnsignedByteTypeDef As String
        Get
            Return DataTypeInput.C_UnsignedByteTypeDef
        End Get
    End Property



    Public ReadOnly Property C_SignedByteTypeDef As String
        Get
            Return DataTypeInput.C_SignedByteTypeDef
        End Get
    End Property



    Public Property AsmDataByteCommand As String
        Get
            Return DataTypeInput.AsmDataByteCommand
        End Get
        Set(value As String)
            DataTypeInput.AsmDataByteCommand = value
        End Set
    End Property



    Public Property AsmDataWordCommand As String
        Get
            Return DataTypeInput.AsmDataWordCommand
        End Get
        Set(value As String)
            DataTypeInput.AsmDataWordCommand = value
        End Set
    End Property



    Public Property BASIClineNumber As Integer
        Get
            Return DataTypeInput.BASIClineNumber
        End Get
        Set(value As Integer)
            DataTypeInput.BASIClineNumber = value
        End Set
    End Property



    Public Property BASIClineInterval As Integer
        Get
            Return DataTypeInput.BASIClineInterval
        End Get
        Set(value As Integer)
            DataTypeInput.BASIClineInterval = value
        End Set
    End Property



    Public Property BASICremoveZeros As Boolean
        Get
            Return DataTypeInput.BASICremoveZeros
        End Get
        Set(value As Boolean)
            DataTypeInput.BASICremoveZeros = value
        End Set
    End Property



    Public Property FieldName As String
        Get
            Return DataTypeInput.FieldName
        End Get
        Set(value As String)
            DataTypeInput.FieldName = value
        End Set
    End Property



    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        '_defaultHeigh = Me.Height

        'accordionPictureBox.Image = ButtonImageList.Images(0)

    End Sub



    Private Sub OutputDataGBox_Load(sender As Object, e As EventArgs) Handles Me.Load

        'isInit = True
        'SetDropDown(Me.isOpen)

        Me.OutputTextBox.BackColor = Me.AppConfig.Color_OUTPUT_BG
        Me.OutputTextBox.ForeColor = Me.AppConfig.Color_OUTPUT_INK

    End Sub



    Public Sub InitControl(ByRef _config As Config)

        Me.AppConfig = _config

        DataTypeInput.InitControl(Me.AppConfig)

        Me.OutputTextBox.BackColor = Me.AppConfig.Color_OUTPUT_BG
        Me.OutputTextBox.ForeColor = Me.AppConfig.Color_OUTPUT_INK

    End Sub



    Public Sub RefreshControl()

        DataTypeInput.RefreshControl()

        Me.OutputTextBox.BackColor = Me.AppConfig.Color_OUTPUT_BG
        Me.OutputTextBox.ForeColor = Me.AppConfig.Color_OUTPUT_INK

    End Sub



    Private Sub DataTypeInput_DataChanged() Handles DataTypeInput.DataChanged
        'RaiseEvent DataChanged()
        ShowData()
    End Sub



    Public Sub InitFileInfo(filePath As String)

        Me.Project_Path = Path.GetDirectoryName(filePath)
        Me.Project_Name = Path.GetFileName(filePath)

    End Sub



    ''' <summary>
    ''' Copy output data to clipboard
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CopyAll()

        Try

            My.Computer.Clipboard.SetText(Me.OutputTextBox.Text)

        Catch ex As Exception

        End Try

    End Sub



    Public Sub ClearOutput()
        OutputTextBox.Text = ""
    End Sub




    Private Sub ShowData()

        Dim _assembler As New AssemblerFormat
        Dim newComments As New ArrayList
        Dim tmpComment As String

        If Not Me.fileData Is Nothing Then

            newComments.AddRange(Me.Comments)

            tmpComment = _assembler.GetCommentWithAssemble(LanguageCode, False)
            If tmpComment IsNot "" Then newComments.Add(tmpComment)

            Me.OutputTextBox.Text = GetFormatData(Me.fileData, newComments)
        End If

    End Sub



    Public Sub ShowData(ByVal data As Byte(), ByVal newComments As ArrayList)

        Me.fileData = data
        Me.Comments = newComments

        ShowData()

    End Sub



    Private Function GetFormatData(ByRef data As Byte(), ByRef comments As ArrayList) As String

        Dim sourceCode As String

        Dim fieldName As String = ""
        Dim singValues() As SByte

        Dim aMSXDataFormat As New DataFormat
        aMSXDataFormat.Comment_BASIC = Me.AppConfig.BASIC_CommentInstruction
        aMSXDataFormat.BASIC_Line = DataTypeInput.BASIClineNumber
        aMSXDataFormat.BASIC_increment = DataTypeInput.BASIClineInterval

        If Not DataTypeInput.ProgrammingLanguage = CodeInfo.PROGRAMMING_LANGUAGE.BASIC Then
            fieldName = DataTypeInput.FieldName
        End If

        If HasSign Then
            ReDim singValues(data.Length - 1)

            For i As Integer = 0 To data.Length - 1
                singValues(i) = CSByte(data(i) - 128)
            Next
            sourceCode = aMSXDataFormat.GetSourceCode(fieldName, DataTypeInput.GetCodeFormat(), singValues, comments).SourceCode
        Else
            sourceCode = aMSXDataFormat.GetSourceCode(fieldName, DataTypeInput.GetCodeFormat(), data, comments).SourceCode

        End If

        Return sourceCode

    End Function



    'Private Function GetCompressData(ByVal data As Byte()) As Byte()

    '    Dim outputSource As String = ""

    '    Dim outputData As Byte()

    '    Dim packer As iCompressEncoder


    '    If Me.DataTypeInput.Compress = iCompressEncoder.COMPRESS_TYPE.RAW Then

    '        outputData = data

    '    Else

    '        Select Case Me.DataTypeInput.Compress

    '            Case iCompressEncoder.COMPRESS_TYPE.RLEWB
    '                packer = New RLEWB

    '            Case iCompressEncoder.COMPRESS_TYPE.PLETTER
    '                packer = New Pletter

    '            Case Else
    '                packer = New RLE

    '        End Select

    '        outputData = packer.Compress(data)

    '    End If

    '    Return outputData

    'End Function



    Private Sub SaveSource_Dialog()

        If Me.OutputTextBox.Text = "" Then
            'messageWin.ShowDialog(Me, "Alert!", "There is nothing to save.", MessageDialog.DIALOG_TYPE.ALERT)
        Else

            Select Case DataTypeInput.ProgrammingLanguage
                Case CodeInfo.PROGRAMMING_LANGUAGE.BASIC
                    Me.SaveFileDialog1.DefaultExt = "BAS"
                    Me.SaveFileDialog1.Filter = "BASIC file|*.BAS"

                Case CodeInfo.PROGRAMMING_LANGUAGE.C
                    Me.SaveFileDialog1.DefaultExt = "c"
                    Me.SaveFileDialog1.Filter = "C file|*.c|Header file|*.h"

                Case Else 'ASSEMBLER
                    Me.SaveFileDialog1.DefaultExt = "asm"
                    Me.SaveFileDialog1.Filter = "ASM file|*.asm|ASM file|*.s"
            End Select

            If Me.Project_Path = "" Then
                Me.Project_Path = Application.StartupPath
            End If
            Me.SaveFileDialog1.InitialDirectory = Me.Project_Path
            Me.SaveFileDialog1.FileName = Path.GetFileNameWithoutExtension(Me.Project_Name)

            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                SaveSourceCode(SaveFileDialog1.FileName)

            End If

        End If

    End Sub



    Private Sub SaveSourceCode(ByVal filePath As String)

        Dim aStreamWriterFile As System.IO.StreamWriter

        aStreamWriterFile = New System.IO.StreamWriter(filePath)
        aStreamWriterFile.WriteLine(Me.OutputTextBox.Text)
        aStreamWriterFile.Close()

    End Sub



    Private Sub SaveBinaryDialog()

        If Me.Project_Path = "" Then
            Me.Project_Path = Application.StartupPath
        End If
        Me.SaveFileDialog1.InitialDirectory = Me.Project_Path
        'Me.SaveFileDialog1.DefaultExt = Me.Extension_Binary
        Me.SaveFileDialog1.Filter = "All files|*.*"
        Me.SaveFileDialog1.FileName = Path.GetFileNameWithoutExtension(Me.Project_Name) + "_RLEWB" + Me.Extension_Binary

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Me.Path_SC2 = Path.GetDirectoryName(SaveFileDialog1.FileName)
            SaveBinary(SaveFileDialog1.FileName, Me.fileData)

            Me.Extension_Binary = Path.GetExtension(SaveFileDialog1.FileName)
        End If

    End Sub



    Public Sub SaveBinary(ByVal filePath As String, ByRef data As Byte())

        Dim aStream As System.IO.FileStream

        If data IsNot Nothing Then

            aStream = New System.IO.FileStream(filePath, IO.FileMode.Create)
            aStream.Write(data, 0, data.Length)
            aStream.Close()

        End If

    End Sub




    Private Sub CopyAllButton_Click(sender As Object, e As EventArgs) Handles CopyAllButton.Click
        CopyAll()
    End Sub

    Private Sub SaveSourceButton_Click(sender As Object, e As EventArgs) Handles SaveSourceButton.Click
        SaveSource_Dialog()
    End Sub

    Private Sub SaveCompressFileButton_Click(sender As Object, e As EventArgs) Handles SaveCompressFileButton.Click
        SaveBinaryDialog()
    End Sub


End Class
