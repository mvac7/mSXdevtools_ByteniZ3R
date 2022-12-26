Imports System.IO

Public Class OutputDataGBox

    Private UIconfig As New Config

    Private _fileData() As Byte
    Private _outputData() As Byte
    Private _comments As ArrayList

    Private Project_Path As String
    Private Project_Name As String

    Public Extension_Binary As String = "bin"

    Public Event DataChanged()

    'Public Event AccordionChanged(state As Boolean)



    Public ReadOnly Property CodeLanguage As DataFormat.ProgrammingLanguage
        Get
            Return DataTypeInput.CodeLanguage
        End Get
    End Property



    Public ReadOnly Property NumeralSystem As Integer
        Get
            Return DataTypeInput.NumeralSystem
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
            Return DataTypeInput.SizeLine
        End Get
    End Property



    Public Property SizeLineIndex As Integer
        Get
            Return DataTypeInput.SizeLineIndex
        End Get
        Set(value As Integer)
            DataTypeInput.SizeLineIndex = value
        End Set
    End Property



    Public Property Compress As DataTypeInputControl.Compress_Type
        Get
            Return DataTypeInput.Compress
        End Get
        Set(value As DataTypeInputControl.Compress_Type)
            DataTypeInput.Compress = value
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



    Public Property EnableDataSizeLine As Boolean
        Get
            Return DataTypeInput.EnableDataSizeLine
        End Get
        Set(value As Boolean)
            DataTypeInput.EnableDataSizeLine = value
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



    Public ReadOnly Property C_DataType As String
        Get
            Return DataTypeInput.C_DataType
        End Get
    End Property



    Public ReadOnly Property AsmByteCommand As String
        Get
            Return DataTypeInput.AsmByteCommand
        End Get
    End Property



    Public ReadOnly Property AsmWordDataCommand As String
        Get
            Return DataTypeInput.AsmWordDataCommand
        End Get
    End Property



    Public ReadOnly Property BASIClineNumber As Integer
        Get
            Return DataTypeInput.BASIClineNumber
        End Get
    End Property



    Public ReadOnly Property BASICInterval As Integer
        Get
            Return DataTypeInput.BASICInterval
        End Get
    End Property



    Public ReadOnly Property BASICremoveZeros As Boolean
        Get
            Return DataTypeInput.BASICremoveZeros
        End Get
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

        Me.OutputText.BackColor = Me.UIconfig.Color_OUTPUT_BG
        Me.OutputText.ForeColor = Me.UIconfig.Color_OUTPUT_INK

    End Sub



    Public Sub InitControl(ByRef _config As Config)

        Me.UIconfig = _config

        DataTypeInput.InitControl(Me.UIconfig)

        Me.OutputText.BackColor = Me.UIconfig.Color_OUTPUT_BG
        Me.OutputText.ForeColor = Me.UIconfig.Color_OUTPUT_INK

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
    Private Sub CopyAll()

        'If Not Me.compressData Is Nothing Then

        'Me.Progress.ShowProgressWin()
        Try
            My.Computer.Clipboard.SetText(Me.OutputText.Text)

            'The purpose of displaying the progress bar is to let the user know that it has been executed successfully.
            'I apply a short wait for the progress window to show without closing too quickly.
            System.Threading.Thread.Sleep(150) 'wait
        Catch ex As Exception

        End Try
        'Me.Progress.CloseProgressWin()

        'Else

        '    ' Nothing que grabar!

        'End If

    End Sub



    Public Sub ClearOutput()
        OutputText.Text = ""
    End Sub



    Public Sub WriteOutput(ByVal newtext As String)
        OutputText.Text = newtext
    End Sub



    Private Sub ShowData()

        If Not Me._fileData Is Nothing Then
            Me.OutputText.Text = GetFormatData(Me._fileData, Me._comments)
        End If

    End Sub



    Public Sub ShowData(ByVal data As Byte(), ByVal comments As ArrayList)

        Me._fileData = data
        Me._comments = comments

        If Not Me._fileData Is Nothing Then
            Me.OutputText.Text = GetFormatData(Me._fileData, Me._comments)
        End If

    End Sub



    Private Function GetFormatData(ByRef data As Byte(), ByRef comments As ArrayList) As String

        Dim aMSXDataFormat As New DataFormat

        Dim outputSource As String = ""

        'Me._outputData = GetCompressData(data)
        Me._outputData = data

        'comments.Add(My.Application.Info.ProductName + " v" + My.Application.Info.Version.ToString + Version_Stage)
        'comments.Add("File: " + FilenameTextBox.Text)


        'comments.Add(paker.Name + " compressed - Original size=" + CStr(originalLength) + " - Compress size=" + CStr(data.Length))

        ' show data in respective code language
        Select Case DataTypeInput.CodeLanguage
            Case DataFormat.ProgrammingLanguage.C
                outputSource = aMSXDataFormat.GetCcode(Me._outputData, DataTypeInput.SizeLine, DataTypeInput.NumeralSystem, DataTypeInput.FieldName, comments, DataTypeInput.C_DataType)

            Case DataFormat.ProgrammingLanguage.ASSEMBLER
                outputSource = aMSXDataFormat.GetAssemblerCode(Me._outputData, DataTypeInput.SizeLine, DataTypeInput.NumeralSystem, DataTypeInput.FieldName, comments, DataTypeInput.AsmByteCommand)

            Case Else
                outputSource = aMSXDataFormat.GetBASICcode(Me._outputData, DataTypeInput.SizeLine, DataTypeInput.NumeralSystem, DataTypeInput.BASICremoveZeros, DataTypeInput.BASIClineNumber, DataTypeInput.BASICInterval, comments)
        End Select


        Return outputSource

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

        If Me.OutputText.Text = "" Then
            'messageWin.ShowDialog(Me, "Alert!", "There is nothing to save.", MessageDialog.DIALOG_TYPE.ALERT)
        Else

            Select Case DataTypeInput.CodeLanguage
                Case DataFormat.ProgrammingLanguage.BASIC
                    Me.SaveFileDialog1.DefaultExt = "BAS"
                    Me.SaveFileDialog1.Filter = "BASIC file|*.BAS"

                Case DataFormat.ProgrammingLanguage.C
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

        'If Not Me.compressData Is Nothing Then

        'Me.Progress.ShowProgressWin()
        Try

            aStreamWriterFile = New System.IO.StreamWriter(filePath)
            aStreamWriterFile.WriteLine(Me.OutputText.Text)
            aStreamWriterFile.Close()

            'The purpose of displaying the progress bar is to let the user know that it has been executed successfully.
            'I apply a short wait for the progress window to show without closing too quickly.
            System.Threading.Thread.Sleep(150) 'wait
        Catch ex As Exception

        End Try
        'Me.Progress.CloseProgressWin()

        'Else

        '    ' Nothing que grabar!

        'End If

    End Sub



    Private Sub SaveBinaryDialog()

        If Me.Project_Path = "" Then
            Me.Project_Path = Application.StartupPath
        End If
        Me.SaveFileDialog1.InitialDirectory = Me.Project_Path
        Me.SaveFileDialog1.DefaultExt = Me.Extension_Binary
        Me.SaveFileDialog1.Filter = "Binary file|*." + Me.Extension_Binary + "|All files|*.*"
        Me.SaveFileDialog1.FileName = Path.GetFileNameWithoutExtension(Me.Project_Name)

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SaveBinary(SaveFileDialog1.FileName, _outputData)
        End If

    End Sub



    Public Sub SaveBinary(ByVal filePath As String, ByRef data As Byte())

        Dim aStream As System.IO.FileStream

        If Not data Is Nothing Then

            'Me.Progress.ShowProgressWin()

            Try

                'Dim patternData() As Byte = CType(Me.outputCompressData.ToArray(GetType(Byte)), Byte())

                aStream = New System.IO.FileStream(filePath, IO.FileMode.Create)
                aStream.Write(data, 0, data.Length)
                aStream.Close()

                'The purpose of displaying the progress bar is to let the user know that it has been executed successfully.
                'I apply a short wait for the progress window to show without closing too quickly.
                System.Threading.Thread.Sleep(150) 'wait

            Catch ex As Exception

            End Try
            'Me.Progress.CloseProgressWin()

        Else

            ' Nothing que grabar!

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
