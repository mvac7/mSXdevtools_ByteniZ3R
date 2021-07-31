﻿Imports System.IO
Imports System.Xml
Imports System.Windows.Forms


'v0.7.1.0 
'* basic line changes do increase to 10 (before = 15). 
'* drag & drop a file from the system to the input file (binary file).
'* Added new output formats data (hex).
'* Output is cleared when switching tabs.

'v0.7.2.0
'* Output Textbox and buttons, added to the Output GroupBox.
'* clear button


''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class MainForm



    'Public Shadows Const Extension_byteGEN As String = "XBYT"


    Private AppConfig As Config

    Private Const AppID As String = "ByteniZ3R"

    Private helpURL As String = Application.StartupPath + System.IO.Path.DirectorySeparatorChar + "Help" + System.IO.Path.DirectorySeparatorChar + AppID + System.IO.Path.DirectorySeparatorChar + AppID + "_UserGuide.html"


    Private aMSXDataFormat As New DataFormat

    Private workBitmap As Bitmap

    Private binaryFilePath As String

    Private lastOutputData As Byte()
    Private outputDataSize As Integer

    'Private ASM_COMMAND As String

    Private _projectPath As String
    Private _binaryPath As String
    Private _txtPath As String

    Private Info As ProjectInfo


    Private Const defaultWaveLength = 32


    Public Shadows Enum DATA_TYPE As Integer
        WAVE
        BINARY
    End Enum


    Public Shadows Enum WAVE_TYPE As Integer
        SINE
        COSINE
        SQUARE
        TRIANGLE
        SAWTOOTH
        NOISE
    End Enum




    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        Me.Info = New ProjectInfo

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.AppConfig = New Config(AppID) 'Application.StartupPath + Path.DirectorySeparatorChar + ConfigFileName) 'System.AppDomain.CurrentDomain.BaseDirectory
        Me.AppConfig.Load()

    End Sub



    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Text = My.Application.Info.Title + " v " + My.Application.Info.Version.ToString + "b" + " · " + My.Application.Info.Copyright

        ' si no encuentra el fichero de ayuda, inhabilita el boton 
        'If Not System.IO.File.Exists(Me.helpURL) Then
        '    Help_Button.Enabled = False
        'End If


        If Not Me.AppConfig.Load() Then
            Dim about As New AboutWin()
            about.StartPosition = FormStartPosition.CenterScreen
            about.ShowDialog()
        End If


        Me.DataTypeInput.AppConfig = Me.AppConfig
        Me.DataTypeInput.InitControl()

        Me.LabelTextBox.Text = Me.AppConfig.defDataLabel

        NewProject()

        AddHandlers()

    End Sub



    Private Sub AddHandlers()
        AddHandler WaveTypeComboBox.SelectedIndexChanged, AddressOf WaveTypeComboBox_SelectedIndexChanged
        AddHandler WaveLengthTrackBar.ValueChanged, AddressOf WaveLengthTrackBar_ValueChanged
        AddHandler WavePhaseTrackBar.ValueChanged, AddressOf PhaseTrackBar_ValueChanged
        AddHandler WaveMaxTrackBar.ValueChanged, AddressOf WaveMaxTrackBar_ValueChanged
        AddHandler WaveMinTrackBar.ValueChanged, AddressOf WaveMinTrackBar_ValueChanged
        AddHandler WaveFreqTrackBar.ValueChanged, AddressOf FreqTrackBar_ValueChanged
    End Sub


    Private Sub RemoveHandlers()
        RemoveHandler WaveTypeComboBox.SelectedIndexChanged, AddressOf WaveTypeComboBox_SelectedIndexChanged
        RemoveHandler WaveLengthTrackBar.ValueChanged, AddressOf WaveLengthTrackBar_ValueChanged
        RemoveHandler WavePhaseTrackBar.ValueChanged, AddressOf PhaseTrackBar_ValueChanged
        RemoveHandler WaveMaxTrackBar.ValueChanged, AddressOf WaveMaxTrackBar_ValueChanged
        RemoveHandler WaveMinTrackBar.ValueChanged, AddressOf WaveMinTrackBar_ValueChanged
        RemoveHandler WaveFreqTrackBar.ValueChanged, AddressOf FreqTrackBar_ValueChanged
    End Sub



    Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As System.Windows.Forms.DialogResult

        Me.AppConfig.Save()

        Beep()

        result = MessageBox.Show(Me, "Are you sure you want to close ByteGen?", "Closing Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.No Then
            e.Cancel = True 'cancela la salida de la aplicacion
        End If

    End Sub



    Private Sub NewProject()

        Me.Info.Clear()

        Me.WaveTypeComboBox.SelectedIndex = 0

        SetWaveLength(defaultWaveLength)
        SetWaveState(0)

        SetWaveMin(0)
        SetWaveMax(255)
        SetWavePhase(0)
        SetWaveFreq(1)

        Me.ProjectNameTextBox.Text = Me.Info.Name

        Me._projectPath = ""

        GenerateData()

    End Sub



    Private Sub GenerateData()

        Dim aRLE As New RLE
        Dim tmpData As Byte()

        Select Case ToolTabControl.SelectedIndex

            Case DATA_TYPE.BINARY
                'If System.IO.File.Exists(Me.binaryFilePath) Then
                tmpData = GetBinaryFileData()

            Case Else 'DATA_TYPE.WAVE
                tmpData = GetWaveTable()
                DrawWave(tmpData)

        End Select


        If tmpData Is Nothing Then
            Return
        End If


        Me.outputDataSize = tmpData.Length

        'data compression
        Select Case Me.DataTypeInput.Compress 'CompressionCB.SelectedIndex

            Case 1
                Me.lastOutputData = aRLE.GetRLE(tmpData)

            Case 2
                Me.lastOutputData = aRLE.GetRLE_WB(tmpData)

            Case Else
                Me.lastOutputData = tmpData

        End Select

        GenerateCode(Me.lastOutputData)
    End Sub



    Private Sub GenerateCode(data() As Byte)

        Dim comments As New ArrayList

        Select Case ToolTabControl.SelectedIndex
            Case DATA_TYPE.WAVE
                ShowData(data, CStr(Me.WaveTypeComboBox.SelectedItem), comments)

            Case DATA_TYPE.BINARY
                'If System.IO.File.Exists(Me.binaryFilePath) Then
                comments.Add(Path.GetFileName(Me.binaryFilePath))
                ShowData(data, "BinaryFile", comments)
                'Else
                '    MsgBox("I need you to select a file.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                'End If

                'Case 3 
                ' More here --->

        End Select
    End Sub



    Private Sub ShowWave()
        Dim tmpData As Byte()

        If Not WaveLengthTrackBar.Value > 7 Then
            Return
        End If

        tmpData = GetWaveTable()
        DrawWave(tmpData)
    End Sub



    ''' <summary>
    ''' Generate a table from a wave.
    ''' </summary>
    ''' <remarks></remarks>
    Private Function GetWaveTable() As Byte()

        Dim tmpData() As Byte

        Dim tableLength As Short
        Dim minValueRange As Short
        Dim maxValueRange As Short

        Dim freq As Integer
        Dim phase As Integer

        tableLength = WaveLengthTrackBar.Value - 1 ' CShort(Me.WaveLengthTextBox.Text) - 1

        minValueRange = CByte(WaveMinTrackBar.Value)   'Me.WaveMinTextBox.Text)
        maxValueRange = CByte(WaveMaxTrackBar.Value)   'Me.WaveMaxTextBox.Text)

        freq = WaveFreqTrackBar.Value
        phase = WavePhaseTrackBar.Value

        Select Case Me.WaveTypeComboBox.SelectedIndex
            Case WAVE_TYPE.COSINE
                tmpData = GetCosineTable(tableLength, minValueRange, maxValueRange, phase, freq)

            Case WAVE_TYPE.SQUARE
                tmpData = GetSquareTable(tableLength, minValueRange, maxValueRange, phase, freq)

            Case WAVE_TYPE.TRIANGLE
                tmpData = GetTriangleTable(tableLength, minValueRange, maxValueRange, phase, freq)

            Case WAVE_TYPE.SAWTOOTH
                tmpData = GetSawtoothTable(tableLength, minValueRange, maxValueRange, phase, freq)

            Case WAVE_TYPE.NOISE
                tmpData = GetRandomTable(tableLength, minValueRange, maxValueRange)

            Case Else
                'sine
                tmpData = GetSineTable(tableLength, minValueRange, maxValueRange, phase, freq)

        End Select


        Return tmpData

    End Function




    Private Function GetSineTable(ByVal length As Short, ByVal minValueRange As Short, ByVal maxValueRange As Short, ByVal phase As Integer, ByVal freq As Integer) As Byte()

        Dim tmpData(length) As Byte

        Dim amplitude As Integer = maxValueRange - minValueRange

        Dim psize As Integer = length / freq

        Dim calcPhase As Integer = (psize / 360) * phase

        If amplitude < 1 Then
            amplitude = 15
        End If

        For BC As Integer = 0 To length
            If psize = 0 Then
                ' para evitar una excepcion en el calculo
                tmpData(BC) = 0
            Else
                tmpData(BC) = CByte(((Math.Sin(((BC + calcPhase) * (Math.PI * 2)) / psize) * amplitude) + amplitude) / 2) + minValueRange
            End If
        Next

        Return tmpData
    End Function



    'GetCosineTable
    Private Function GetCosineTable(ByVal length As Short, ByVal minValueRange As Short, ByVal maxValueRange As Short, ByVal phase As Integer, ByVal freq As Integer) As Byte()

        Dim tmpData(length) As Byte

        Dim amplitude As Integer = maxValueRange - minValueRange

        Dim psize As Integer = length / freq

        Dim calcPhase As Integer = (psize / 360) * phase

        If amplitude < 1 Then
            amplitude = 15
        End If

        For BC As Integer = 0 To length
            If psize = 0 Then
                ' para evitar una excepcion en el calculo
                tmpData(BC) = 0
            Else
                tmpData(BC) = CByte(((Math.Cos(((BC + calcPhase) * (Math.PI * 2)) / psize) * amplitude) + amplitude) / 2) + minValueRange
            End If
        Next

        Return tmpData
    End Function



    Private Function GetSquareTable(ByVal length As Short, ByVal minValueRange As Short, ByVal maxValueRange As Short, ByVal phase As Integer, ByVal freq As Integer) As Byte()
        Dim tmpData(length) As Byte

        Dim psize As Integer = length / freq
        Dim calcPhase As Integer = (psize / 360) * phase

        For BC As Integer = 0 To length
            If psize = 0 Then
                ' para evitar una excepcion en el calculo
                tmpData(BC) = 0
            Else
                'y[k] = Math.Sin(freq * k)>=0?A:-1*A;
                If Math.Sin(((BC + calcPhase) * (Math.PI * 2)) / psize) >= 0 Then
                    tmpData(BC) = maxValueRange
                Else
                    tmpData(BC) = minValueRange
                End If
            End If
        Next

        Return tmpData
    End Function



    Private Function GetTriangleTable(ByVal length As Short, ByVal minValueRange As Short, ByVal maxValueRange As Short, ByVal phase As Integer, ByVal freq As Integer) As Byte()

        Dim tmpData(length) As Byte
        Dim value As Double
        Dim interval As Double
        Dim amplitude As Integer
        Dim conta As Double

        amplitude = maxValueRange - minValueRange
        interval = (2 * Math.PI) / (length / freq)
        conta = (((length / freq) * phase) / 360) * interval

        For BC = 0 To length

            If conta < Math.PI Then
                value = ((conta / Math.PI) * amplitude) + minValueRange
            Else
                value = ((((2 * Math.PI) - conta) / Math.PI) * amplitude) + minValueRange
            End If

            If value < 0 Then
                value = 0
            End If
            If value > 255 Then
                value = 255
            End If

            tmpData(BC) = CByte(value)

            conta = conta + interval
            If conta > (2 * Math.PI) Then
                conta = 0
            End If

        Next

        Return tmpData
    End Function



    Private Function GetSawtoothTable(ByVal length As Short, ByVal minValueRange As Short, ByVal maxValueRange As Short, ByVal phase As Integer, ByVal freq As Integer) As Byte()

        Dim tmpData(length) As Byte
        Dim value As Double
        Dim interval As Double
        Dim conta As Double
        Dim amplitude As Integer

        amplitude = maxValueRange - minValueRange
        interval = (Math.PI) / (length / freq)
        conta = (((length / freq) * phase) / 360) * interval

        For BC = 0 To length

            value = ((((Math.PI) - conta) / Math.PI) * amplitude) + minValueRange

            If value < 0 Then
                value = 0
            End If
            If value > 255 Then
                value = 255
            End If

            tmpData(BC) = CByte(value)

            conta = conta + interval
            If conta > (Math.PI) Then
                conta = 0
            End If

        Next

        Return tmpData
    End Function



    ''' <summary>
    ''' Generate a random values.
    ''' </summary>
    ''' <remarks></remarks>
    Private Function GetRandomTable(ByVal length As Short, ByVal minValueRange As Short, ByVal maxValueRange As Short) As Byte()

        Dim rnd1 As New Random()

        Dim tmpData(length) As Byte

        For i As Integer = 0 To length
            tmpData(i) = rnd1.Next(minValueRange, maxValueRange)
        Next

        Return tmpData

    End Function





    Private Sub DrawWave(ByVal data As Byte())

        Dim aGraphics As Graphics

        Dim GFXwidth As Integer = Me.GFXoutputPictureBox.Width

        Dim GFXheight As Integer = Me.GFXoutputPictureBox.Height

        Dim length As Integer

        Dim posX As Double = 0
        Dim Xinterval As Double

        Dim interval As Double
        Dim valueConta As Double = 0

        Dim point1 As New Point
        Dim point2 As New Point


        Try

            If Not Me.workBitmap Is Nothing Then
                Me.workBitmap.Dispose()
            End If
            Me.workBitmap = New Bitmap(GFXwidth, GFXheight)
            aGraphics = Graphics.FromImage(Me.workBitmap)
            Me.GFXoutputPictureBox.Image = workBitmap


            Dim aPen As New Pen(Color.FromArgb(255, 48, 98, 48)) 'dark green

            If data.Length > (GFXwidth - 1) Then
                interval = (data.Length - 1) / GFXwidth
                'Xinterval = 1
                length = GFXwidth - 1
            Else
                interval = 1
                Xinterval = GFXwidth / data.Length
                length = data.Length
                'Xinterval = GFXwidth / (data.Length - 1)
                'length = (data.Length - 1)
            End If

            point1.X = posX
            point1.Y = getY(data(valueConta))

            If length < (GFXwidth - 1) Then

                For t As Integer = 0 To length
                    posX = posX + Xinterval
                    point2.X = CInt(posX)
                    point2.Y = point1.Y

                    aGraphics.DrawLine(aPen, point1, point2)

                    point1.X = point2.X
                    point1.Y = point2.Y

                    valueConta = valueConta + interval
                    If valueConta > (data.Length - 1) Then
                        valueConta = (data.Length - 1)
                    End If
                    point2.X = point1.X
                    point2.Y = getY(data(Fix(valueConta)))
                    aGraphics.DrawLine(aPen, point1, point2)
                    point1.X = point2.X
                    point1.Y = point2.Y
                Next

            Else

                For t As Integer = 0 To length
                    valueConta = valueConta + interval
                    If valueConta > (data.Length - 1) Then
                        valueConta = (data.Length - 1)
                    End If
                    point2.X = point1.X + 1
                    point2.Y = getY(data(Fix(valueConta)))
                    aGraphics.DrawLine(aPen, point1, point2)
                    point1.X = point2.X
                    point1.Y = point2.Y
                Next

            End If



            aGraphics.Flush()
            Me.GFXoutputPictureBox.Refresh()


        Catch ex As Exception
            'An exception is thrown when the main window loses focus and then recovers it
            'the width attribute of the GFXoutputPictureBox object is equal to 0
        End Try


    End Sub



    Private Function getY(ByVal value As Integer) As Integer
        Dim GFXheight As Integer = Me.GFXoutputPictureBox.Height
        Return (GFXheight - 1) - Fix((GFXheight * value) / 256)
    End Function



    ''' <summary>
    ''' Generate data from binary file.
    ''' </summary>
    ''' <remarks></remarks>
    Private Function GetBinaryFileData() As Byte()
        Dim aFileData As Byte()
        Dim outputData(1) As Byte
        'Dim fileLength As Integer
        Dim fileOutputSize As Integer

        Dim fillValue As Byte = CByte(Me.BinaryFillValueTextBox.Text)
        Dim initValue As Byte = CByte(Me.BinaryInitTextBox.Text)
        Dim outputLength As Integer = CInt(BinaryLengthTextBox.Text)



        If System.IO.File.Exists(Me.binaryFilePath) Then

            aFileData = LoadBinary(Me.binaryFilePath)

            'fileLength = aFileData.Length - 1
            fileOutputSize = (aFileData.Length - 1) - initValue


            ReDim outputData(outputLength - 1)


            If outputLength > fileOutputSize Then

                ' rellena con el valor dado en el campo BinaryFillValueTextBox
                For i As Integer = fileOutputSize To outputLength - 1
                    outputData(i) = fillValue
                Next


            End If


            Array.Copy(aFileData, initValue, outputData, 0, fileOutputSize)

        End If

        Return outputData

    End Function



    ''' <summary>
    ''' Show source data according to the selected format.
    ''' </summary>
    ''' <param name="data"></param>
    ''' <param name="dataType"></param>
    ''' <remarks></remarks>
    Private Sub ShowData(ByVal data As Byte(), ByVal dataType As String, ByVal comments As ArrayList)

        Dim labelName As String = Me.LabelTextBox.Text

        Dim infoData As String = ""

        If comments Is Nothing Then
            comments = New ArrayList
        End If

        comments.Add(dataType)

        Select Case Me.DataTypeInput.Compress  'CompressionCB.SelectedIndex

            Case 1
                comments.Add("RLE compressed - Original size=" + CStr(Me.outputDataSize) + " - Compress size=" + CStr(data.Length))
            Case 2
                comments.Add("RLE WB compressed - Original size=" + CStr(Me.outputDataSize) + " - Compress size=" + CStr(data.Length))

                'Case 3


            Case Else
                If ToolTabControl.SelectedIndex = DATA_TYPE.BINARY Then
                    comments.Add("Size=" + CStr(Me.outputDataSize))
                End If
        End Select


        If ToolTabControl.SelectedIndex = DATA_TYPE.WAVE Then

            Dim tableLength As Short = WaveLengthTrackBar.Value - 1
            Dim minValueRange As Short = CByte(WaveMinTrackBar.Value)
            Dim maxValueRange As Short = CByte(WaveMaxTrackBar.Value)

            Dim freq As Integer = WaveFreqTrackBar.Value
            Dim phase As Integer = WavePhaseTrackBar.Value

            infoData = "Length=" + CStr(tableLength + 1) + "; Min=" + CStr(minValueRange) + "; Max=" + CStr(maxValueRange)

            If Not Me.WaveTypeComboBox.SelectedIndex = WAVE_TYPE.NOISE Then
                infoData += "; Phase=" + CStr(phase) + "; Freq=" + CStr(freq)
            End If
            comments.Add(infoData)
        End If


        Select Case DataTypeInput.CodeLanguage
            Case DataFormat.ProgrammingLanguage.C
                OutputText.Text = Me.aMSXDataFormat.GetCcode(data, CInt(Me.DataTypeInput.SizeLine), Me.DataTypeInput.NumeralSystem, labelName, comments, Me.AppConfig.lastCByteCommand)
            Case DataFormat.ProgrammingLanguage.ASSEMBLER
                OutputText.Text = Me.aMSXDataFormat.GetAssemblerCode(data, CInt(Me.DataTypeInput.SizeLine), Me.DataTypeInput.NumeralSystem, labelName, comments, Me.AppConfig.lastAsmByteCommand)
            Case DataFormat.ProgrammingLanguage.BASIC
                OutputText.Text = Me.aMSXDataFormat.GetBASICcode(data, CInt(Me.DataTypeInput.SizeLine), Me.DataTypeInput.NumeralSystem, Me.DataTypeInput.BASICremoveZeros, Me.DataTypeInput.BASIClineNumber, Me.DataTypeInput.BASICInterval, comments) 'Me.aMSXDataFormat.lastLineNumber
        End Select


    End Sub



    Private Sub CopyAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyAllButton.Click
        CopyAll()
    End Sub



    ''' <summary>
    ''' Copy output to clipboard
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CopyAll()
        My.Computer.Clipboard.SetText(Me.OutputText.Text)
    End Sub



    Private Sub SelectBinaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectBinaryButton.Click
        LoadBinaryFileDialog()
    End Sub



    ''' <summary>
    ''' Select a binary file.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadBinaryFileDialog()

        If Me.binaryFilePath = "" Then
            Me.OpenFileDialog1.FileName = ""
            Me.OpenFileDialog1.InitialDirectory = Me.AppConfig.PathItemBinary.Path
        Else
            Me.OpenFileDialog1.FileName = Path.GetFileName(Me.binaryFilePath)
            Me.OpenFileDialog1.InitialDirectory = Path.GetDirectoryName(Me.binaryFilePath)
        End If

        'Me.OpenFileDialog1.DefaultExt = "prj"
        Me.OpenFileDialog1.Filter = "All files|*.*|Binary files|*.bin|SC2 files|*.SC2|SCn files|*.SC*"

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SetBinFile(OpenFileDialog1.FileName)
        End If

    End Sub



    ''' <summary>
    ''' Init Binary file type project
    ''' </summary>
    ''' <param name="filepath"></param>
    ''' <remarks></remarks>
    Private Sub SetBinFile(ByVal filepath As String)

        Dim aFile As FileInfo

        If File.Exists(filepath) Then

            aFile = New FileInfo(filepath)

            If aFile.Length <= 65536 Then

                Me.binaryFilePath = filepath
                Me.Info.Name = Path.GetFileNameWithoutExtension(filepath)

                Me.BinaryNameTextBox.Text = Path.GetFileName(Me.binaryFilePath)
                Me.FileLengthTextBox.Text = CStr(My.Computer.FileSystem.GetFileInfo(Me.binaryFilePath).Length)
                Me.BinaryLengthTextBox.Text = CStr(getBinaryFinalLength())  'Me.FileLengthTextBox.Text
                Me.ProjectNameTextBox.Text = Me.Info.Name

                aHexDump.BinaryData = LoadBinary(Me.binaryFilePath)

                Me.AppConfig.PathItemBinary.UpdateLastPath(Path.GetDirectoryName(Me.binaryFilePath))

                ClearOutput()

            Else

                MsgBox("Only supports files up to 64k.", MsgBoxStyle.Exclamation, "Alert")

            End If

        End If


    End Sub



    ''' <summary>
    ''' Load binary file.
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LoadBinary(ByVal filePath As String) As Byte()

        Dim aStream As FileStream
        Dim aFile As New FileInfo(filePath)

        Dim aFileData As Byte()

        Dim conta As Integer = 7

        Dim filesize As Long = aFile.Length


        If filesize > 65536 Then
            Return Nothing
        End If

        aStream = New System.IO.FileStream(filePath, FileMode.Open)

        ReDim aFileData(filesize)

        aStream.Read(aFileData, 0, filesize)
        aStream.Close()

        Return aFileData

    End Function



    Private Sub SaveAsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsButton.Click

        If Me.OutputText.Text = "" Then
            MsgBox("Nothing to save for you...", MsgBoxStyle.Exclamation, "Alert")

        Else

            If Me._txtPath = "" Then
                Me.SaveFileDialog1.FileName = Me.Info.Name
                Me.SaveFileDialog1.InitialDirectory = Me.AppConfig.PathItemProject.Path
            Else
                Me.SaveFileDialog1.FileName = Path.GetFileName(Me._txtPath)
                Me.SaveFileDialog1.FileName = Path.GetDirectoryName(Me._txtPath)
            End If

            Select Case DataTypeInput.CodeLanguage
                Case DataFormat.ProgrammingLanguage.BASIC
                    Me.SaveFileDialog1.DefaultExt = "BAS"
                    Me.SaveFileDialog1.Filter = "BASIC file|*.BAS"
                Case DataFormat.ProgrammingLanguage.C
                    Me.SaveFileDialog1.DefaultExt = "c"
                    Me.SaveFileDialog1.Filter = "C file|*.c"
                Case DataFormat.ProgrammingLanguage.ASSEMBLER
                    Me.SaveFileDialog1.DefaultExt = "asm"
                    Me.SaveFileDialog1.Filter = "ASM file|*.asm|ASM file|*.s"
            End Select


            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                Me.saveCode(SaveFileDialog1.FileName)

            End If

        End If

    End Sub



    ''' <summary>
    ''' Save source output.
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <remarks></remarks>
    Private Sub saveCode(ByVal filePath As String)
        Dim aStreamWriterFile As New System.IO.StreamWriter(filePath)
        aStreamWriterFile.WriteLine(Me.OutputText.Text)
        aStreamWriterFile.Close()
    End Sub



    Private Sub ToolTabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolTabControl.SelectedIndexChanged
        ClearOutput()
    End Sub



    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ClearOutput()
    End Sub



    Private Sub ClearOutput()
        OutputText.Text = ""
    End Sub



    Private Sub MainForm_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        Dim s() As String = e.Data.GetData("FileDrop", False)
        Dim tmpFilePath As String = s(0)

        If Path.GetExtension(tmpFilePath).ToUpper = ("." + Config.Extension_byteGEN) Then
            LoadProject(tmpFilePath)
        Else
            SetBinFile(tmpFilePath)
            ToolTabControl.SelectTab(1)
        End If

    End Sub



    Private Sub MainForm_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub







    Private Sub ValidateMinValue(ByVal minValue As Integer)
        Dim maxValue As Integer = CInt(Me.WaveMaxTextBox.Text)

        If minValue > maxValue Then
            minValue = maxValue - 1
        End If

        If minValue > 254 Then
            minValue = CStr(maxValue - 1)
        ElseIf minValue < 0 Then
            minValue = 0
        End If

        SetWaveMin(minValue)

    End Sub



    Private Sub SetWaveMin(value As Integer)
        Me.WaveMinTextBox.Text = CStr(value)
        Me.WaveMinTrackBar.Value = value
    End Sub



    Private Sub ValidateMaxValue(ByVal maxValue As Integer)
        Dim minValue As Integer = CInt(Me.WaveMinTextBox.Text)

        If maxValue < minValue Then
            maxValue = minValue + 1
        End If

        If maxValue > 255 Then
            maxValue = 255
        ElseIf maxValue < 1 Then
            maxValue = 1
        End If

        SetWaveMax(maxValue)

    End Sub



    Private Sub SetWaveMax(value As Integer)
        Me.WaveMaxTextBox.Text = CStr(value)
        Me.WaveMaxTrackBar.Value = value
    End Sub


    Private Sub SetWavePhase(value As Integer)
        Me.PhaseTextBox.Text = CStr(value)
        Me.WavePhaseTrackBar.Value = value
    End Sub



    Private Sub SetWaveFreq(value As Integer)
        Me.FreqTextBox.Text = CStr(value)
        Me.WaveFreqTrackBar.Value = value
    End Sub



    Private Sub WaveLengthTrackBar_ValueChanged(sender As System.Object, e As System.EventArgs) ' Handles WaveLengthTrackBar.ValueChanged
        ValidateWaveLength(Me.WaveLengthTrackBar.Value)
        ShowWave()
        'GenerateData()
    End Sub

    Private Sub WaveMaxTrackBar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ValidateMaxValue(Me.WaveMaxTrackBar.Value)
        ShowWave()
        'GenerateData()
    End Sub

    Private Sub WaveMinTrackBar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles WaveMinTrackBar.ValueChanged
        ValidateMinValue(Me.WaveMinTrackBar.Value)
        ShowWave()
        'GenerateData()
    End Sub

    Private Sub PhaseTrackBar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) ' Handles WavePhaseTrackBar.ValueChanged
        ValidatePhaseValue(Me.WavePhaseTrackBar.Value)
        ShowWave()
        'GenerateData()
    End Sub

    Private Sub FreqTrackBar_ValueChanged(sender As System.Object, e As System.EventArgs) 'Handles WaveFreqTrackBar.ValueChanged
        ValidateFreqValue(Me.WaveFreqTrackBar.Value)
        ShowWave()
        'GenerateData()
    End Sub



    Private Sub WaveLengthTrackBar_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles WaveLengthTrackBar.MouseUp
        GenerateData()
    End Sub

    Private Sub WaveMinTrackBar_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles WaveMinTrackBar.MouseUp
        GenerateData()
    End Sub

    Private Sub WaveMaxTrackBar_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles WaveMaxTrackBar.MouseUp
        GenerateData()
    End Sub

    Private Sub WavePhaseTrackBar_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles WavePhaseTrackBar.MouseUp
        GenerateData()
    End Sub

    Private Sub WaveFreqTrackBar_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles WaveFreqTrackBar.MouseUp
        GenerateData()
    End Sub




    Private Sub WaveTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetWaveState(WaveTypeComboBox.SelectedIndex)
        GenerateData()
    End Sub



    Private Sub SetWaveState(ByVal index As WAVE_TYPE)
        Dim state As Boolean

        If index = WAVE_TYPE.NOISE Then
            state = False
        Else
            state = True
        End If

        Me.LabelFreq.Enabled = state
        Me.WaveFreqTrackBar.Enabled = state
        Me.FreqTextBox.Enabled = state

        Me.LabelPhase.Enabled = state
        Me.WavePhaseTrackBar.Enabled = state
        Me.PhaseTextBox.Enabled = state

        Me.RandomButton.Visible = Not state
    End Sub



    Private Sub SavebinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavebinButton.Click

        If Me.lastOutputData.Length < 1 Then
            MsgBox("Nothing to save for you...", MsgBoxStyle.Exclamation, "Alert")

        Else

            If Me._binaryPath = "" Then
                Me.SaveFileDialog1.FileName = Me.Info.Name
                Me.SaveFileDialog1.InitialDirectory = Me.AppConfig.PathItemBinary.Path
            Else
                Me.SaveFileDialog1.FileName = Path.GetFileName(Me._binaryPath)
                Me.SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(Me._binaryPath)
            End If

            Me.SaveFileDialog1.DefaultExt = "BIN"
            Me.SaveFileDialog1.Filter = "Binary file|*.BIN"

            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                SaveBinary(SaveFileDialog1.FileName, Me.lastOutputData)
                Me._binaryPath = SaveFileDialog1.FileName

            End If

        End If
    End Sub



    Private Sub SaveBinary(ByVal filePath As String, ByVal data As Byte())

        Dim aStream As New System.IO.FileStream(filePath, IO.FileMode.Create)
        aStream.Write(data, 0, data.Length)
        aStream.Close()

    End Sub



    Private Sub RandomButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RandomButton.Click
        GenerateData()
    End Sub



    Private Sub GenerateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateButton.Click
        GenerateData()
    End Sub



    Private Sub ValidatePhaseValue(ByVal value As Integer)

        If value > 359 Then
            value = 359
        ElseIf value < 0 Then
            value = 0
        End If

        SetWavePhase(value)
    End Sub



    Private Sub ValidateFreqValue(ByVal value As Integer)

        If value > 255 Then
            value = 255
        ElseIf value < 1 Then
            value = 1
        End If

        SetWaveFreq(value)
    End Sub


    Private Sub SetWaveLength(value As Integer)
        Me.WaveLengthTextBox.Text = CStr(value)
        Me.WaveLengthTrackBar.Value = value
    End Sub


    Private Sub ValidateWaveLength(ByVal value As Integer)
        If value > 1024 Then
            value = 1024
        ElseIf value < 8 Then
            value = 8
        End If

        SetWaveLength(value)
    End Sub




    Private Sub WaveLengthTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles WaveLengthTextBox.Validating
        If Not IsNumeric(WaveLengthTextBox.Text) Then
            WaveLengthTextBox.Text = CStr(defaultWaveLength)
        End If
        ValidateWaveLength(CInt(WaveLengthTextBox.Text))
        GenerateData()
    End Sub


    Private Sub WaveMinTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles WaveMinTextBox.Validating
        If Not IsNumeric(Me.WaveMinTextBox.Text) Then
            Me.WaveMinTextBox.Text = "0"
        End If
        ValidateMinValue(CInt(Me.WaveMinTextBox.Text))
        GenerateData()
    End Sub


    Private Sub WaveMaxTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles WaveMaxTextBox.Validating
        If Not IsNumeric(Me.WaveMaxTextBox.Text) Then
            Me.WaveMaxTextBox.Text = "255"
        End If
        ValidateMaxValue(CInt(Me.WaveMaxTextBox.Text))
        GenerateData()
    End Sub


    Private Sub PhaseTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PhaseTextBox.Validating
        If Not IsNumeric(Me.PhaseTextBox.Text) Then
            Me.PhaseTextBox.Text = "0"
        End If
        ValidatePhaseValue(CInt(Me.PhaseTextBox.Text))
        GenerateData()
    End Sub


    Private Sub FreqTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles FreqTextBox.Validating
        If Not IsNumeric(Me.FreqTextBox.Text) Then
            Me.FreqTextBox.Text = "1"
        End If
        ValidateFreqValue(CInt(Me.FreqTextBox.Text))
        GenerateData()
    End Sub



    Private Sub LabelTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LabelTextBox.Validating

        If Me.LabelTextBox.Text.Trim() = "" Then
            Me.LabelTextBox.Text = "DATA"
        End If

        GenerateCode(Me.lastOutputData)
    End Sub



    ' valida el campo de inicio del fichero, para remover cabeceras
    Private Sub BinaryInitTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles BinaryInitTextBox.Validating
        Dim value As Integer

        If Not IsNumeric(Me.BinaryInitTextBox.Text) Then
            value = 0
        Else
            value = CInt(Me.BinaryInitTextBox.Text)

            If value > 1024 Then
                value = 1024
            ElseIf value < 0 Then
                value = 0
            End If
        End If

        Me.BinaryInitTextBox.Text = CStr(value)

        BinaryLengthTextBox.Text = CStr(getBinaryFinalLength())

    End Sub



    'valida el campo de valor para relleno
    Private Sub BinaryFillValueTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles BinaryFillValueTextBox.Validating

        Dim value As Integer

        If IsNumeric(BinaryFillValueTextBox.Text) Then
            value = CInt(BinaryFillValueTextBox.Text)
            If value > 255 Then
                BinaryFillValueTextBox.Text = "255"
            End If
        Else
            ' si no es un numerico mete el valor por defecto
            BinaryFillValueTextBox.Text = "255"
        End If

    End Sub



    ' valida el campo de valor de tamaño de la salida
    Private Sub BinaryLengthTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles BinaryLengthTextBox.Validating
        Dim value As Integer
        Dim initPos As Integer = CInt(BinaryInitTextBox.Text)

        If Not Me.FileLengthTextBox.Text = "" Then
            If IsNumeric(BinaryLengthTextBox.Text) Then
                value = CInt(BinaryLengthTextBox.Text)
                If value < initPos Or value > 65536 Then
                    BinaryLengthTextBox.Text = CStr(getBinaryFinalLength())
                End If
            Else
                ' si no es un numerico mete el valor por defecto
                BinaryLengthTextBox.Text = CStr(getBinaryFinalLength())
            End If
        End If

    End Sub



    Private Function getBinaryFinalLength()
        Dim initPos As Integer = CInt(BinaryInitTextBox.Text)
        Dim fileLength As Integer = CInt(Me.FileLengthTextBox.Text)
        Dim outputLength As Integer

        outputLength = fileLength - initPos
        '(fileLength - 1) - initPos

        Return outputLength

    End Function




    ''' <summary>
    ''' Muestra la ventana de dialogo para la carga de un proyecto
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadProjectDialog()

        If Me._projectPath = "" Then
            Me.OpenFileDialog1.FileName = Me.Info.Name
            Me.OpenFileDialog1.InitialDirectory = Me.AppConfig.PathByteGen.Path
        Else
            Me.OpenFileDialog1.FileName = Path.GetFileName(Me._projectPath)
            Me.OpenFileDialog1.InitialDirectory = Path.GetDirectoryName(Me._projectPath)
        End If

        'Me.OpenFileDialog1.DefaultExt = "*.*"
        Me.OpenFileDialog1.Filter = "byteGEN Project file|*." + Config.Extension_byteGEN

        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Me._projectPath = OpenFileDialog1.FileName
            LoadProject(Me._projectPath)
            Me.AppConfig.PathByteGen.UpdateLastPath(Path.GetDirectoryName(Me._projectPath))
        End If

    End Sub




    ''' <summary>
    ''' Loads a project, from an absolute path.
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <remarks></remarks>
    Private Sub LoadProject(ByVal filePath As String)

        Dim aXmlDoc As New XmlDocument
        Dim aNode As XmlNode
        Dim subNode As XmlNode
        Dim attrNode As XmlNode


        ' comprueba si existe el fichero
        If System.IO.File.Exists(filePath) Then

            RemoveHandlers()

            'Me._ProgressController.ShowProgressWin()


            aXmlDoc.Load(filePath)

            aNode = aXmlDoc.SelectSingleNode("msxdevtools/" + AppID)
            If Not aNode Is Nothing Then

                ' Project Info
                subNode = aNode.SelectSingleNode("info")
                If subNode Is Nothing Then
                    Me.Info = New ProjectInfo()
                Else
                    Me.Info = GetInfoFromNode(subNode, "project0")
                End If
                Me.ProjectNameTextBox.Text = Me.Info.Name
                ' END Project Info


                subNode = aNode.SelectSingleNode("dataTYPE")
                If subNode Is Nothing Then
                    Me.ToolTabControl.SelectedIndex = 0
                Else
                    Me.ToolTabControl.SelectedIndex = CInt(subNode.InnerText)
                End If



                ' Binary file ###################################################
                subNode = aNode.SelectSingleNode("binary")
                If subNode Is Nothing Then
                    '
                    'Me.BinaryInitTextBox.Text = "0"
                    'Me.BinaryLengthTextBox.Text = "0"
                    'Me.BinaryFillValueTextBox.Text = "255"
                Else
                    If System.IO.File.Exists(subNode.InnerText) Then

                        SetBinFile(subNode.InnerText)
                        'Me.binaryFilePath = subNode.InnerText
                        'Me.BinaryNameTextBox.Text = Me.binaryFilePath

                        attrNode = subNode.SelectSingleNode("@init")
                        If attrNode Is Nothing Then
                            Me.BinaryInitTextBox.Text = "0"
                        Else
                            Me.BinaryInitTextBox.Text = attrNode.InnerText
                        End If

                        attrNode = subNode.SelectSingleNode("@length")
                        If attrNode Is Nothing Then
                            Me.BinaryLengthTextBox.Text = "0"
                        Else
                            Me.BinaryLengthTextBox.Text = attrNode.InnerText
                        End If

                        attrNode = subNode.SelectSingleNode("@fillValue")
                        If attrNode Is Nothing Then
                            Me.BinaryFillValueTextBox.Text = "255"
                        Else
                            Me.BinaryFillValueTextBox.Text = attrNode.InnerText
                        End If
                    End If


                End If
                ' END Binary file ###############################################



                ' Wave data ###################################################
                subNode = aNode.SelectSingleNode("waveform")
                If subNode Is Nothing Then
                    ' no hay na!

                    'defaultizar! ;)

                Else

                    attrNode = subNode.SelectSingleNode("@type")
                    If attrNode Is Nothing Then
                        Me.WaveTypeComboBox.SelectedIndex = WAVE_TYPE.SINE
                    Else
                        Me.WaveTypeComboBox.SelectedIndex = CInt(attrNode.InnerText)
                    End If
                    SetWaveState(Me.WaveTypeComboBox.SelectedIndex)

                    attrNode = subNode.SelectSingleNode("@size")
                    If attrNode Is Nothing Then
                        SetWaveLength(defaultWaveLength)
                    Else
                        SetWaveLength(CInt(attrNode.InnerText))
                    End If

                    attrNode = subNode.SelectSingleNode("@minValue")
                    If attrNode Is Nothing Then
                        SetWaveMin(0)
                    Else
                        SetWaveMin(CInt(attrNode.InnerText))
                    End If

                    attrNode = subNode.SelectSingleNode("@maxValue")
                    If attrNode Is Nothing Then
                        SetWaveMax(255)
                    Else
                        SetWaveMax(CInt(attrNode.InnerText))
                    End If

                    attrNode = subNode.SelectSingleNode("@phase")
                    If attrNode Is Nothing Then
                        SetWavePhase(0)
                    Else
                        SetWavePhase(CInt(attrNode.InnerText))
                    End If

                    attrNode = subNode.SelectSingleNode("@freq")
                    If attrNode Is Nothing Then
                        SetWaveFreq(1)
                    Else
                        SetWaveFreq(CInt(attrNode.InnerText))
                    End If

                End If
                ' END Wave data ###############################################



                'Output Data Config ###################################################
                subNode = aNode.SelectSingleNode("OutputConfig")
                If subNode Is Nothing Then
                    ' no hay na!

                    'defaultizar! ;)

                Else

                    attrNode = subNode.SelectSingleNode("@CodeType")
                    If attrNode Is Nothing Then
                        'Me.LanguageComboBox.SelectedIndex = Me.AppConfig.defCodeOutput
                    Else
                        Me.AppConfig.lastCodeOutput = CInt(attrNode.InnerText)
                    End If
                    'ChangeLanguage(Me.LanguageComboBox.SelectedIndex)

                    attrNode = subNode.SelectSingleNode("@DataFormat")
                    If attrNode Is Nothing Then
                        'Me.DataFormatComboB.SelectedIndex = Me.AppConfig.defCodeNumberFormat
                    Else
                        Me.AppConfig.lastCodeNumberFormat = CInt(attrNode.InnerText)
                    End If

                    attrNode = subNode.SelectSingleNode("@CodeCompressType")
                    If attrNode Is Nothing Then
                        'Me.CompressionCB.SelectedIndex = Me.AppConfig.defCodeCompressType
                    Else
                        Me.AppConfig.lastCodeCompressType = CInt(attrNode.InnerText)
                    End If

                    attrNode = subNode.SelectSingleNode("@SizeLine")
                    If attrNode Is Nothing Then
                        'Me.ItemsPerLineComboBox.SelectedIndex = Me.AppConfig.defCodeSizeLine
                    Else
                        Me.AppConfig.lastCodeSizeLine = CInt(attrNode.InnerText)
                    End If

                    attrNode = subNode.SelectSingleNode("@AsmCommand")
                    If attrNode Is Nothing Then
                        'Me.AsmCommandTextBox.Text = Me.AppConfig.defAsmByteCommand
                    Else
                        Me.AppConfig.lastAsmByteCommand = attrNode.InnerText
                    End If

                    attrNode = subNode.SelectSingleNode("@BASICinitLine")
                    If attrNode Is Nothing Then
                        'Me.BASICinitLineTextBox.Text = CStr(Me.AppConfig.defBASICinitLine)
                    Else
                        Me.AppConfig.lastBASICinitLine = CInt(attrNode.InnerText)
                        'Me.BASICinitLineTextBox.Text = attrNode.InnerText
                    End If

                    attrNode = subNode.SelectSingleNode("@BASICincLines")
                    If attrNode Is Nothing Then
                        'Me.BASICincLineslTextBox.Text = CStr(Me.AppConfig.defBASICincLines)
                    Else
                        Me.AppConfig.lastBASICincLines = CInt(attrNode.InnerText)
                        'Me.BASICincLineslTextBox.Text = attrNode.InnerText
                    End If

                    attrNode = subNode.SelectSingleNode("@Remove0")
                    If attrNode Is Nothing Then
                        'Me.Remove0Check.Checked = Me.AppConfig.defBASICremove0
                    Else
                        Me.AppConfig.lastBASICremove0 = CBool(attrNode.InnerText.ToUpper = "TRUE")
                        'Me.Remove0Check.Checked = CBool(attrNode.InnerText.ToUpper = "TRUE")
                    End If

                    attrNode = subNode.SelectSingleNode("@Label")
                    If attrNode Is Nothing Then
                        Me.LabelTextBox.Text = "DATA"
                    Else
                        Me.LabelTextBox.Text = CStr(attrNode.InnerText)
                    End If


                    Me.DataTypeInput.InitControl()  '<--- refresh data 

                End If
                ' END Output Data Config ###############################################

                AddHandlers()



                'Me.ASM_COMMAND = Me.AsmCommandTextBox.Text
                GenerateData()


            Else
                MsgBox("This file does not contain the correct format.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Load Project")
            End If


            'Me._ProgressController.CloseProgressWin()


        Else
            ' en el caso de que no exista
            MsgBox("The file does not exist!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Load Project")
            'Exit Sub
        End If

    End Sub



    ''' <summary>
    ''' Muestra la ventana de dialogo para el guardado de un proyecto
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveProjectDialog()

        If Me._projectPath = "" Then
            Me.SaveFileDialog1.FileName = Me.Info.Name
            Me.SaveFileDialog1.InitialDirectory = Me.AppConfig.PathByteGen.Path
        Else
            Me.SaveFileDialog1.FileName = Path.GetFileName(Me._projectPath)
            Me.SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(Me._projectPath)
        End If

        Me.SaveFileDialog1.Filter = "byteGEN Project file|*." + Config.Extension_byteGEN

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Me._projectPath = SaveFileDialog1.FileName
            SaveProject(Me._projectPath)
            Me.AppConfig.PathByteGen.UpdateLastPath(Path.GetDirectoryName(Me._projectPath))
        End If

    End Sub




    ''' <summary>
    ''' Save a project, from an absolute path.
    ''' coded (18/10/2017) listening Massive Attack (Live at Melt Music Festival) https://youtu.be/TqYA7uJUbqE
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <remarks></remarks>
    Private Sub SaveProject(ByVal filePath As String)


        Dim aXmlDoc As New XmlDocument
        Dim rootElement As XmlElement
        Dim txtElement As XmlText
        Dim anElement As XmlElement
        'Dim subElement As XmlElement
        Dim anItemElement As XmlElement
        Dim anAttribute As XmlAttribute


        'Me._ProgressController.ShowProgressWin()


        ' crea el nodo root
        rootElement = aXmlDoc.CreateElement("msxdevtools")
        aXmlDoc.AppendChild(rootElement)

        anAttribute = aXmlDoc.CreateAttribute("app")
        anAttribute.Value = My.Application.Info.Title
        rootElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("version")
        anAttribute.Value = My.Application.Info.Version.ToString
        rootElement.SetAttributeNode(anAttribute)


        anElement = aXmlDoc.CreateElement(AppID)
        rootElement.AppendChild(anElement)


        anItemElement = GetInfoElement(aXmlDoc, Me.Info)
        anElement.AppendChild(anItemElement)


        anItemElement = aXmlDoc.CreateElement("dataTYPE")
        anElement.AppendChild(anItemElement)
        txtElement = aXmlDoc.CreateTextNode(CStr(Me.ToolTabControl.SelectedIndex))
        anItemElement.AppendChild(txtElement)


        If Me.ToolTabControl.SelectedIndex = 1 Then

            ' Binary file ###################################################
            anItemElement = aXmlDoc.CreateElement("binary")
            anElement.AppendChild(anItemElement)
            txtElement = aXmlDoc.CreateTextNode(Me.binaryFilePath)
            anItemElement.AppendChild(txtElement)

            anAttribute = aXmlDoc.CreateAttribute("init")
            anAttribute.Value = Me.BinaryInitTextBox.Text
            anItemElement.SetAttributeNode(anAttribute)

            anAttribute = aXmlDoc.CreateAttribute("length")
            anAttribute.Value = Me.BinaryLengthTextBox.Text
            anItemElement.SetAttributeNode(anAttribute)

            anAttribute = aXmlDoc.CreateAttribute("fillValue")
            anAttribute.Value = Me.BinaryFillValueTextBox.Text
            anItemElement.SetAttributeNode(anAttribute)
            ' END Binary file ###############################################

        Else


            ' Waveform data ###################################################
            anItemElement = aXmlDoc.CreateElement("waveform")
            anElement.AppendChild(anItemElement)
            '
            anAttribute = aXmlDoc.CreateAttribute("type")
            anAttribute.Value = CStr(Me.WaveTypeComboBox.SelectedIndex)
            anItemElement.SetAttributeNode(anAttribute)
            anAttribute = aXmlDoc.CreateAttribute("size")
            anAttribute.Value = WaveLengthTextBox.Text
            anItemElement.SetAttributeNode(anAttribute)
            anAttribute = aXmlDoc.CreateAttribute("minValue")
            anAttribute.Value = WaveMinTextBox.Text
            anItemElement.SetAttributeNode(anAttribute)
            anAttribute = aXmlDoc.CreateAttribute("maxValue")
            anAttribute.Value = WaveMaxTextBox.Text
            anItemElement.SetAttributeNode(anAttribute)
            anAttribute = aXmlDoc.CreateAttribute("phase")
            anAttribute.Value = PhaseTextBox.Text
            anItemElement.SetAttributeNode(anAttribute)
            anAttribute = aXmlDoc.CreateAttribute("freq")
            anAttribute.Value = FreqTextBox.Text
            anItemElement.SetAttributeNode(anAttribute)
            ' END Wave data ################################################

        End If




        ' Output Data Config ###################################################
        anItemElement = aXmlDoc.CreateElement("OutputConfig")
        anElement.AppendChild(anItemElement)
        '
        anAttribute = aXmlDoc.CreateAttribute("CodeType")
        anAttribute.Value = CStr(Me.DataTypeInput.CodeLanguage)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("DataFormat")
        anAttribute.Value = CStr(Me.DataTypeInput.NumeralSystem) 'Me.DataFormatComboB.SelectedIndex)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("CodeCompressType")
        anAttribute.Value = CStr(Me.DataTypeInput.Compress) 'Me.CompressionCB.SelectedIndex)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("SizeLine")
        anAttribute.Value = CStr(Me.DataTypeInput.SizeLineIndex) 'Me.ItemsPerLineComboBox.SelectedIndex)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("AsmCommand")
        anAttribute.Value = Me.DataTypeInput.AsmByteCommand 'Me.AsmCommandTextBox.Text)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("BASICinitLine")
        anAttribute.Value = CStr(Me.DataTypeInput.BASIClineNumber) 'Me.BASICinitLineTextBox.Text)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("BASICincLines")
        anAttribute.Value = CStr(Me.DataTypeInput.BASICInterval) 'Me.BASICincLineslTextBox.Text)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("Remove0")
        anAttribute.Value = CStr(Me.DataTypeInput.BASICremoveZeros) 'Me.Remove0Check.Checked)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("Label")
        anAttribute.Value = CStr(Me.LabelTextBox.Text)
        anItemElement.SetAttributeNode(anAttribute)
        ' END Output Data Config ################################################


        '
        aXmlDoc.Save(filePath)

        'Me._ProgressController.CloseProgressWin()


        Me.AppConfig.AddRecentProject(Me._projectPath, AppID)


    End Sub



    Public Function GetInfoElement(ByRef aXmlDoc As XmlDocument, ByRef infoData As ProjectInfo) As XmlElement

        Dim anElement As XmlElement
        Dim anItemElement As XmlElement
        Dim anAttribute As XmlAttribute
        Dim txtElement As XmlText


        ' project data ##############################################
        anElement = aXmlDoc.CreateElement("info")

        anAttribute = aXmlDoc.CreateAttribute("name")
        anAttribute.Value = infoData.Name
        anElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("group")
        anAttribute.Value = infoData.Group
        anElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("version")
        anAttribute.Value = infoData.Version
        anElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("author")
        anAttribute.Value = infoData.Author
        anElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("startDate")
        anAttribute.Value = CStr(infoData.StartDate)
        anElement.SetAttributeNode(anAttribute)

        infoData.LastUpdate = DateTime.Today.Ticks
        anAttribute = aXmlDoc.CreateAttribute("lastUpdate")
        anAttribute.Value = CStr(infoData.LastUpdate)
        anElement.SetAttributeNode(anAttribute)

        anItemElement = aXmlDoc.CreateElement("description")
        txtElement = aXmlDoc.CreateTextNode(infoData.Description)
        anItemElement.AppendChild(txtElement)
        anElement.AppendChild(anItemElement)
        'END project data ##############################################

        Return anElement

    End Function



    Public Function GetInfoFromNode(ByVal aDataNode As XmlNode, ByVal defName As String) As ProjectInfo

        Dim newInfo As New ProjectInfo
        Dim aNode As XmlNode
        'Dim anAttribute As XmlAttribute



        ' get project info ############################################
        aNode = aDataNode.SelectSingleNode("@name")
        If aNode Is Nothing Then
            newInfo.Name = defName
        Else
            newInfo.Name = aNode.InnerText
        End If

        aNode = aDataNode.SelectSingleNode("@version")
        If aNode Is Nothing Then
            newInfo.Version = ""
        Else
            newInfo.Version = aNode.InnerText
        End If

        aNode = aDataNode.SelectSingleNode("@group")
        If aNode Is Nothing Then
            newInfo.Group = ""
        Else
            newInfo.Group = aNode.InnerText
        End If

        aNode = aDataNode.SelectSingleNode("@author")
        If aNode Is Nothing Then
            newInfo.Author = ""
        Else
            newInfo.Author = aNode.InnerText
        End If

        aNode = aDataNode.SelectSingleNode("@startDate")
        If aNode Is Nothing Then
            newInfo.StartDate = DateTime.Today.Ticks
        Else
            newInfo.StartDate = CLng(aNode.InnerText)
        End If

        aNode = aDataNode.SelectSingleNode("@lastUpdate")
        If aNode Is Nothing Then
            newInfo.LastUpdate = DateTime.Today.Ticks
        Else
            newInfo.LastUpdate = CLng(aNode.InnerText)
        End If

        aNode = aDataNode.SelectSingleNode("description")
        If aNode Is Nothing Then
            newInfo.Description = ""
        Else
            newInfo.Description = aNode.InnerText
        End If

        Return newInfo

    End Function




    ''' <summary>
    ''' Opens the project information editing window.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetProjectInfo()

        Dim ProjectProperties As New ProjectPropertiesDialog(Me.AppConfig, Me.Info) '_projectPath

        If ProjectProperties.ShowDialog = DialogResult.OK Then

            Me.Info = ProjectProperties.GetProjectInfo()
            Me.ProjectNameTextBox.Text = Me.Info.Name

        End If

    End Sub



    Private Sub SetConfig()
        Dim aConfig As New ConfigWin(Me.AppConfig, ConfigWin.CONFIG_TYPE.BYTEGEN)

        If aConfig.ShowDialog() = DialogResult.OK Then
            Me.AppConfig.Save()
        End If
    End Sub



    Private Sub NewButton_Click(sender As System.Object, e As System.EventArgs) Handles NewButton.Click
        RemoveHandlers()
        NewProject()
        AddHandlers()
    End Sub

    Private Sub LoadButton_Click(sender As System.Object, e As System.EventArgs) Handles LoadButton.Click
        LoadProjectDialog()
    End Sub

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        SaveProjectDialog()
    End Sub

    Private Sub ProjectInfoButton_Click(sender As System.Object, e As System.EventArgs) Handles ProjectInfoButton.Click
        SetProjectInfo()
    End Sub

    Private Sub ConfigButton1_Click(sender As System.Object, e As System.EventArgs) Handles ConfigButton1.Click
        SetConfig()
    End Sub

    Private Sub HelpButton_Click(sender As System.Object, e As System.EventArgs) Handles Help_Button.Click
        'Dim helper As New HelpWin(Me.Name, helpURL)
        'helper.ShowDialog()
    End Sub

    Private Sub AboutButton1_Click(sender As System.Object, e As System.EventArgs) Handles AboutButton1.Click
        ShowAbout()
    End Sub



    Private Sub ShowAbout()
        Dim about As New AboutWin()
        about.ShowDialog()
    End Sub



    Private Sub DataTypeInput_DataChanged() Handles DataTypeInput.DataChanged
        GenerateData()
    End Sub

    Private Sub GFXoutputPictureBox_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ShowWave()
    End Sub
End Class
