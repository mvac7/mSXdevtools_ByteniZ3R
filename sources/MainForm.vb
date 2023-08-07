Imports System.IO
Imports System.Xml


''' <summary>
''' ByteniZ3R devtool
''' Waveform data table generator
''' 
''' Copyright (C) 2023 mvac7
''' This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
''' the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
''' 
''' This program is distributed in the hope that it will be useful,
''' but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
''' See the GNU General Public License for more details.
''' 
''' You should have received a copy of the GNU General Public License along with this program.  If not, see http://www.gnu.org/licenses/.
''' </summary>
''' <remarks></remarks>
Public Class MainForm

    Private Const Version_Stage = "-beta"


    Private AppConfig As Config

    Private Const AppID As String = "ByteniZ3R"

    Private helpURL As String = Application.StartupPath + System.IO.Path.DirectorySeparatorChar + "Help" + System.IO.Path.DirectorySeparatorChar + AppID + System.IO.Path.DirectorySeparatorChar + AppID + "_UserGuide.html"

    Private aMSXDataFormat As New DataFormat

    'Private workBitmap As Bitmap
    Private aGraphics As Graphics

    Private lastOutputData As Byte()
    Private outputDataSize As Integer

    Private Path_Project As String
    Private Path_binary As String
    Private Path_source As String

    Private Info As ProjectInfo

    Private Const MaxLength = 2048

    Private Progress As ProgressController


    Private Const defaultWaveLength = 32



    Public Shadows Enum WAVE_TYPE As Integer
        SINE
        SINE_UPPER
        SINE_DOWN
        COSINE
        SQUARE
        TRIANGLE
        SAWTOOTH
        SAWTOOTH_REVERSE
        NOISE
    End Enum




    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        Me.Info = New ProjectInfo

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.AppConfig = New Config(AppID) 'Application.StartupPath + Path.DirectorySeparatorChar + ConfigFileName) 'System.AppDomain.CurrentDomain.BaseDirectory
        'Me.AppConfig.Load()

    End Sub



    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' si no encuentra el fichero de ayuda, inhabilita el boton 
        'If Not System.IO.File.Exists(Me.helpURL) Then
        '    Help_Button.Enabled = False
        'End If

        Me.Progress = New ProgressController(Me)

        If Not Me.AppConfig.Load() Then
            ' if not exist config file
            ShowAbout(True)
        End If

        Me.WaveLengthTrackBar.Maximum = MaxLength
        Me.WaveLengthTrackBar.TickFrequency = MaxLength / 8

        'Me.OutputText.BackColor = Me.AppConfig.Color_OUTPUT_BG
        'Me.OutputText.ForeColor = Me.AppConfig.Color_OUTPUT_INK

        Me.anOutputDataGBox.InitControl(Me.AppConfig)

        'Me.anOutputDataGBox.DataTypeInput.FieldName = Me.AppConfig.DataLabel

        'SetOutputtextSize()

        NewProject()

        SetTitle(Me.Info.Name)

        DrawPanel.Size = New Drawing.Size(DrawPanel.Width, 256 + SystemInformation.HorizontalScrollBarHeight)

        SetDrawImage(WaveLengthTrackBar.Value)

        GenerateData()

        AddHandlers()

        Application.DoEvents()

        WaveTypeComboBox.Focus()

    End Sub


    Private Sub SetDrawImage(ByVal waveLength As Integer)
        'Dim workBitmap As New Bitmap(Me.GFXoutputPictureBox.Width, Me.GFXoutputPictureBox.Height)
        Dim workBitmap As New Bitmap(waveLength, 256)
        Me.GFXoutputPictureBox.Size = New Drawing.Size(waveLength, 256)
        Me.aGraphics = Graphics.FromImage(workBitmap)
        Me.GFXoutputPictureBox.Image = workBitmap
    End Sub


    Private Sub SetTitle(filename As String)
        If Not filename = "" Then
            filename = " · [" + filename + "]"
        End If

        Me.Text = My.Application.Info.Title + " " + filename
    End Sub


    Private Sub AddHandlers()
        AddHandler WaveTypeComboBox.SelectedIndexChanged, AddressOf WaveTypeComboBox_SelectedIndexChanged
        AddHandler WaveLengthTrackBar.ValueChanged, AddressOf WaveLengthTrackBar_ValueChanged
        AddHandler WavePhaseTrackBar.ValueChanged, AddressOf PhaseTrackBar_ValueChanged
        AddHandler WaveMaxTrackBar.ValueChanged, AddressOf WaveMaxTrackBar_ValueChanged
        AddHandler WaveMinTrackBar.ValueChanged, AddressOf WaveMinTrackBar_ValueChanged
        AddHandler WaveFreqTrackBar.ValueChanged, AddressOf FreqTrackBar_ValueChanged

        AddHandler anOutputDataGBox.DataChanged, AddressOf anOutputDataGBox_DataChanged
    End Sub



    Private Sub RemoveHandlers()
        RemoveHandler WaveTypeComboBox.SelectedIndexChanged, AddressOf WaveTypeComboBox_SelectedIndexChanged
        RemoveHandler WaveLengthTrackBar.ValueChanged, AddressOf WaveLengthTrackBar_ValueChanged
        RemoveHandler WavePhaseTrackBar.ValueChanged, AddressOf PhaseTrackBar_ValueChanged
        RemoveHandler WaveMaxTrackBar.ValueChanged, AddressOf WaveMaxTrackBar_ValueChanged
        RemoveHandler WaveMinTrackBar.ValueChanged, AddressOf WaveMinTrackBar_ValueChanged
        RemoveHandler WaveFreqTrackBar.ValueChanged, AddressOf FreqTrackBar_ValueChanged

        RemoveHandler anOutputDataGBox.DataChanged, AddressOf anOutputDataGBox_DataChanged
    End Sub



    Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim result As System.Windows.Forms.DialogResult
        Dim MessageWin As New MessageDialog

        Application.DoEvents()

        Beep()

        result = MessageWin.ShowDialog(Me, "Closing Application!", "Are you sure you want to close " + My.Application.Info.Title + "?", MessageDialog.DIALOG_TYPE.YES_NO) '+ vbCrLf

        If result = Windows.Forms.DialogResult.Yes Then
            Me.AppConfig.Save()
        Else
            e.Cancel = True 'cancela la salida de la aplicacion
        End If

    End Sub



    Private Sub NewProject()

        Me.WaveTypeComboBox.SelectedIndex = 0

        SetWaveLength(256)
        SetWaveState(0)

        SetWaveMin(0)
        SetWaveMax(255)
        SetWavePhase(0)
        SetWaveFreq(1)

        Me.Path_Project = ""
        Me.Path_source = ""
        Me.Path_binary = ""

        Info.Clear()
        Me.ProjectNameTextBox.Text = Info.Name

        SetTitle(Me.Info.Name)

    End Sub



    Private Sub NewProjectDialog()
        Dim MessageWin As New MessageDialog
        Dim result As DialogResult

        Beep()
        result = MessageWin.ShowDialog(Me, "New Project", "This option will erase all data." + vbCrLf + "Do you want to continue?", MessageDialog.DIALOG_TYPE.YES_NO) '+ vbCrLf

        If result = DialogResult.Yes Then
            RemoveHandlers()
            NewProject()
            GenerateData()
            AddHandlers()
        End If
    End Sub



    Private Sub GenerateData()

        Me.lastOutputData = GetWaveTable()
        DrawWave(Me.lastOutputData)

        Me.outputDataSize = Me.lastOutputData.Length

        GenerateCode(Me.lastOutputData)

    End Sub



    Private Sub GenerateCode(data() As Byte)

        Dim comments As New ArrayList

        Dim labelName As String = Me.anOutputDataGBox.DataTypeInput.FieldName

        Dim infoData As String = ""

        If comments Is Nothing Then
            comments = New ArrayList
        End If

        comments.Add(My.Application.Info.ProductName + " v" + My.Application.Info.Version.ToString + Version_Stage)
        comments.Add("Project: " + Me.Info.Name)
        comments.Add(CStr(Me.WaveTypeComboBox.SelectedItem))

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

        Me.anOutputDataGBox.ShowData(data, comments)

        'Select Case anOutputDataGBox.DataTypeInput.CodeLanguage
        '    Case DataFormat.ProgrammingLanguage.C
        '        OutputText.Text = Me.aMSXDataFormat.GetCcode(data, CInt(Me.anOutputDataGBox.DataTypeInput.SizeLine), Me.anOutputDataGBox.DataTypeInput.NumeralSystem, labelName, comments, Me.AppConfig.CByteCommand)
        '    Case DataFormat.ProgrammingLanguage.ASSEMBLER
        '        OutputText.Text = Me.aMSXDataFormat.GetAssemblerCode(data, CInt(Me.anOutputDataGBox.DataTypeInput.SizeLine), Me.anOutputDataGBox.DataTypeInput.NumeralSystem, labelName, comments, Me.AppConfig.AsmByteCommand)
        '    Case DataFormat.ProgrammingLanguage.BASIC
        '        OutputText.Text = Me.aMSXDataFormat.GetBASICcode(data, CInt(Me.anOutputDataGBox.DataTypeInput.SizeLine), Me.anOutputDataGBox.DataTypeInput.NumeralSystem, Me.anOutputDataGBox.DataTypeInput.BASICremoveZeros, Me.anOutputDataGBox.DataTypeInput.BASIClineNumber, Me.anOutputDataGBox.DataTypeInput.BASICInterval, comments) 'Me.aMSXDataFormat.lastLineNumber
        'End Select

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
            Case WAVE_TYPE.SINE_UPPER
                tmpData = GetUpperSineTable(tableLength, minValueRange, maxValueRange, freq)

            Case WAVE_TYPE.SINE_DOWN
                tmpData = GetDownSineTable(tableLength, minValueRange, maxValueRange, freq)

            Case WAVE_TYPE.COSINE
                tmpData = GetCosineTable(tableLength, minValueRange, maxValueRange, phase, freq)

            Case WAVE_TYPE.SQUARE
                tmpData = GetSquareTable(tableLength, minValueRange, maxValueRange, phase, freq)

            Case WAVE_TYPE.TRIANGLE
                tmpData = GetTriangleTable(tableLength, minValueRange, maxValueRange, phase, freq)

            Case WAVE_TYPE.SAWTOOTH
                tmpData = GetSawtoothTable(tableLength, minValueRange, maxValueRange, phase, freq)

            Case WAVE_TYPE.SAWTOOTH_REVERSE
                tmpData = GetReverseSawtoothTable(tableLength, minValueRange, maxValueRange, phase, freq)

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

        Dim wave_size As Integer = length / freq
        Dim calcPhase As Integer = (wave_size / 360) * phase

        If amplitude < 1 Then
            amplitude = 15
        End If

        For BC As Integer = 0 To length
            If wave_size < 1 Then
                ' para evitar una excepcion en el calculo
                tmpData(BC) = 0
            Else
                tmpData(BC) = CByte(((Math.Sin(((BC + calcPhase) * (Math.PI * 2)) / wave_size) * amplitude) + amplitude) / 2) + minValueRange
            End If
        Next

        Return tmpData

    End Function



    Private Function GetDownSineTable(ByVal length As Short, ByVal minValueRange As Short, ByVal maxValueRange As Short, ByVal freq As Integer) As Byte()

        Dim tmpData(length) As Byte

        Dim amplitude As Integer = maxValueRange - minValueRange

        Dim wave_size As Integer = length / freq
        'Dim calcPhase As Integer = (wave_size / 360) * 360
        Dim wave_pos As Integer

        If amplitude < 1 Then
            amplitude = 15
        End If

        For BC As Integer = 0 To length

            wave_pos = BC - (Fix(BC / wave_size) * wave_size)

            If wave_size < 1 Then
                ' para evitar una excepcion en el calculo
                tmpData(BC) = 0
            Else
                tmpData(BC) = CByte(amplitude - Math.Sin((wave_pos * Math.PI) / wave_size) * amplitude) + minValueRange
            End If

        Next
        Return tmpData

    End Function



    Private Function GetUpperSineTable(ByVal length As Short, ByVal minValueRange As Short, ByVal maxValueRange As Short, ByVal freq As Integer) As Byte()

        Dim tmpData(length) As Byte

        Dim amplitude As Integer = maxValueRange - minValueRange

        Dim wave_size As Integer = length / freq
        'Dim calcPhase As Integer = (wave_size / 180) * phase

        Dim wave_pos As Integer

        If amplitude < 1 Then
            amplitude = 15
        End If

        For BC As Integer = 0 To length

            wave_pos = BC - (Fix(BC / wave_size) * wave_size)

            If wave_size < 1 Then
                ' para evitar una excepcion en el calculo
                tmpData(BC) = 0
            Else
                tmpData(BC) = CByte(Math.Sin((wave_pos * Math.PI) / wave_size) * amplitude) + minValueRange
            End If

        Next

        Return tmpData

    End Function



    Private Function GetCosineTable(ByVal length As Short, ByVal minValueRange As Short, ByVal maxValueRange As Short, ByVal phase As Integer, ByVal freq As Integer) As Byte()

        Dim tmpData(length) As Byte

        Dim amplitude As Integer = maxValueRange - minValueRange

        Dim wave_size As Integer = length / freq
        Dim calcPhase As Integer = (wave_size / 360) * phase

        If amplitude < 1 Then
            amplitude = 15
        End If

        For BC As Integer = 0 To length
            If wave_size < 1 Then
                ' para evitar una excepcion en el calculo
                tmpData(BC) = 0
            Else
                tmpData(BC) = CByte(((Math.Cos(((BC + calcPhase) * (Math.PI * 2)) / wave_size) * amplitude) + amplitude) / 2) + minValueRange
            End If
        Next

        Return tmpData

    End Function



    Private Function GetSquareTable(ByVal length As Short, ByVal minValueRange As Short, ByVal maxValueRange As Short, ByVal phase As Integer, ByVal freq As Integer) As Byte()

        Dim tmpData(length) As Byte

        Dim wave_size As Integer = length / freq
        Dim calcPhase As Integer = (wave_size / 360) * phase

        For BC As Integer = 0 To length
            If wave_size < 1 Then
                ' para evitar una excepcion en el calculo
                tmpData(BC) = 0
            Else
                'y[k] = Math.Sin(freq * k)>=0?A:-1*A;
                If Math.Sin(((BC + calcPhase) * (Math.PI * 2)) / wave_size) >= 0 Then
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
        Dim wave_size As Double

        wave_size = length / freq

        amplitude = maxValueRange - minValueRange
        interval = (2 * Math.PI) / wave_size
        conta = ((wave_size * phase) / 360) * interval

        For BC As Integer = 0 To length

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
        Dim amplitude As Integer
        Dim wave_size As Double
        Dim tmpValue As Short

        wave_size = length / freq

        amplitude = maxValueRange - minValueRange
        interval = amplitude / wave_size

        value = ((wave_size / 360) * phase) * interval

        For BC As Integer = 0 To length

            tmpValue = Fix(value)  'Math.Ceiling Floor

            If tmpValue < 0 Then
                tmpValue = 0
            End If

            If tmpValue > amplitude Then
                tmpValue = amplitude
            End If

            tmpData(BC) = CByte(tmpValue + minValueRange)

            value += interval
            If Fix(value) > amplitude Then
                value = 0
            End If

        Next

        Return tmpData
    End Function




    Private Function GetReverseSawtoothTable(ByVal length As Short, ByVal minValueRange As Short, ByVal maxValueRange As Short, ByVal phase As Integer, ByVal freq As Integer) As Byte()

        Dim tmpData(length) As Byte
        Dim value As Double
        Dim interval As Double
        Dim amplitude As Integer
        Dim wave_size As Double
        Dim tmpValue As Short

        wave_size = length / freq

        amplitude = maxValueRange - minValueRange
        interval = amplitude / wave_size

        value = ((wave_size / 360) * phase) * interval

        value = amplitude - value

        For BC As Integer = 0 To length

            tmpValue = Fix(value)  'Math.Ceiling Floor

            If tmpValue < 0 Then
                tmpValue = 0
            End If

            If tmpValue > amplitude Then
                tmpValue = amplitude
            End If

            tmpData(BC) = CByte(tmpValue + minValueRange)

            value -= interval
            If value < 0 Then
                value = amplitude
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

        For BC As Integer = 0 To length
            tmpData(BC) = rnd1.Next(minValueRange, maxValueRange)
        Next

        Return tmpData

    End Function





    Private Sub DrawWave(ByRef data As Byte())

        'Dim aGraphics As Graphics

        Dim GFXwidth As Integer
        Dim GFXheight As Integer

        Dim length As Integer

        Dim posX As Double = 0
        Dim Xinterval As Double

        Dim interval As Double
        Dim valueConta As Double = 0

        Dim point1 As New Point
        Dim point2 As New Point

        Dim aPen As Pen

        If data Is Nothing Then
            Exit Sub
        End If

        SetDrawImage(WaveLengthTrackBar.Value)

        GFXwidth = Me.GFXoutputPictureBox.Width
        GFXheight = Me.GFXoutputPictureBox.Height


        Try

            aPen = New Pen(Me.AppConfig.Color_OUTPUT_INK) 'Color.FromArgb(255, 48, 98, 48)

            Me.aGraphics.Clear(Me.AppConfig.Color_OUTPUT_BG)

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



            Me.aGraphics.Flush()
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




    Private Sub MainForm_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        Dim s() As String = e.Data.GetData("FileDrop", False)
        Dim tmpFilePath As String = s(0)

        If Path.GetExtension(tmpFilePath).ToUpper = ("." + Config.Extension_byteGEN) Then
            If LoadProject(tmpFilePath) = True Then
                Me.Path_Project = tmpFilePath
                Me.Path_source = ""
                Me.Path_binary = ""
                SetTitle(Path.GetFileName(Me.Path_Project))
                'Me.AppConfig.PathByteGen.UpdateLastPath(Path.GetDirectoryName(Me.Path_Project))
            End If
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
        ValidateFreqValue(Me.WaveFreqTrackBar.Value)
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



    Private Sub WaveLengthTrackBar_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles WaveLengthTrackBar.MouseUp, WaveMinTrackBar.MouseUp, WaveMaxTrackBar.MouseUp, WavePhaseTrackBar.MouseUp, WaveFreqTrackBar.MouseUp
        GenerateData()
    End Sub



    Private Sub WaveLengthTrackBar_KeyUp(sender As Object, e As KeyEventArgs) Handles WaveLengthTrackBar.KeyUp, WaveMinTrackBar.KeyUp, WaveMaxTrackBar.KeyUp, WavePhaseTrackBar.KeyUp, WaveFreqTrackBar.KeyUp
        GenerateData()
    End Sub



    Private Sub WaveTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetWaveState(WaveTypeComboBox.SelectedIndex)
        GenerateData()
    End Sub



    Private Sub SetWaveState(ByVal index As WAVE_TYPE)

        If index = WAVE_TYPE.NOISE Then
            Me.LabelFreq.Enabled = False
            Me.WaveFreqTrackBar.Enabled = False
            Me.FreqTextBox.Enabled = False

            Me.LabelPhase.Enabled = False
            Me.WavePhaseTrackBar.Enabled = False
            Me.PhaseTextBox.Enabled = False

            Me.RandomButton.Visible = True
        ElseIf index = WAVE_TYPE.SINE_UPPER Or index = WAVE_TYPE.SINE_DOWN Then
            Me.LabelFreq.Enabled = True
            Me.WaveFreqTrackBar.Enabled = True
            Me.FreqTextBox.Enabled = True

            Me.LabelPhase.Enabled = True
            Me.WavePhaseTrackBar.Enabled = False
            Me.PhaseTextBox.Enabled = True

            Me.RandomButton.Visible = False
        Else
            Me.LabelFreq.Enabled = True
            Me.WaveFreqTrackBar.Enabled = True
            Me.FreqTextBox.Enabled = True

            Me.LabelPhase.Enabled = True
            Me.WavePhaseTrackBar.Enabled = True
            Me.PhaseTextBox.Enabled = True

            Me.RandomButton.Visible = False
        End If

    End Sub



    Private Sub RandomButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RandomButton.Click
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

        Dim WaveLengthValue As Integer = WaveLengthTrackBar.Value

        If WaveLengthValue < value * 4 Then
            value = WaveLengthValue / 4
        ElseIf value > 255 Then
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
        If value > MaxLength Then
            value = MaxLength
        ElseIf value < 8 Then
            value = 8
        End If

        SetWaveLength(value)
    End Sub



    Private Sub WaveLengthTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles WaveLengthTextBox.Validating
        If Not IsNumeric(WaveLengthTextBox.Text) Then
            WaveLengthTextBox.Text = CStr(defaultWaveLength)
        Else
            ValidateWaveLength(CInt(WaveLengthTextBox.Text))
            ValidateFreqValue(Me.WaveFreqTrackBar.Value)
        End If
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



    ''' <summary>
    ''' Muestra la ventana de dialogo para la carga de un proyecto
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadProjectDialog()

        If Me.Path_Project = "" Then
            Me.OpenFileDialog1.FileName = Me.Info.Name
            'Me.OpenFileDialog1.InitialDirectory = Me.AppConfig.PathByteGen.Path
        Else
            Me.OpenFileDialog1.FileName = Path.GetFileName(Me.Path_Project)
            Me.OpenFileDialog1.InitialDirectory = Path.GetDirectoryName(Me.Path_Project)
        End If

        'Me.OpenFileDialog1.DefaultExt = "*.*"
        Me.OpenFileDialog1.Filter = "ByteniZ3R Project file|*." + Config.Extension_byteGEN

        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then

            If LoadProject(OpenFileDialog1.FileName) = True Then
                Me.Path_Project = OpenFileDialog1.FileName
                Me.Path_source = ""
                Me.Path_binary = ""
                SetTitle(Path.GetFileName(Me.Path_Project))
                'Me.AppConfig.PathByteGen.UpdateLastPath(Path.GetDirectoryName(Me.Path_Project))
            End If

        End If

    End Sub



    ''' <summary>
    ''' Loads a project, from an absolute path.
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <remarks></remarks>
    Private Function LoadProject(ByVal filePath As String) As Boolean

        Dim aXmlDoc As New XmlDocument
        Dim aNode As XmlNode
        Dim subNode As XmlNode
        Dim attrNode As XmlNode

        Dim result As Boolean = False

        If System.IO.File.Exists(filePath) Then

            RemoveHandlers()

            Me.Progress.ShowProgressWin()


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
                        Me.AppConfig.CodeOutput = CInt(attrNode.InnerText)
                    End If
                    'ChangeLanguage(Me.LanguageComboBox.SelectedIndex)

                    attrNode = subNode.SelectSingleNode("@NumberSystem")
                    If attrNode Is Nothing Then
                        'Me.DataFormatComboB.SelectedIndex = Me.AppConfig.defCodeNumberFormat
                    Else
                        Me.AppConfig.CodeNumberSystem = CInt(attrNode.InnerText)
                    End If

                    'attrNode = subNode.SelectSingleNode("@CodeCompressType")
                    'If attrNode Is Nothing Then
                    '    'Me.CompressionCB.SelectedIndex = Me.AppConfig.defCodeCompressType
                    'Else
                    '    Me.AppConfig.lastCodeCompressType = CInt(attrNode.InnerText)
                    'End If

                    attrNode = subNode.SelectSingleNode("@SizeLine")
                    If attrNode Is Nothing Then
                        'Me.ItemsPerLineComboBox.SelectedIndex = Me.AppConfig.defCodeSizeLine
                    Else
                        Me.AppConfig.CodeLineSize = CInt(attrNode.InnerText)
                    End If

                    attrNode = subNode.SelectSingleNode("@AsmDataByteCommand")
                    If attrNode Is Nothing Then
                        'Me.AsmCommandTextBox.Text = Me.AppConfig.defAsmByteCommand
                    Else
                        Me.AppConfig.AsmDataByteCommand = attrNode.InnerText
                    End If

                    attrNode = subNode.SelectSingleNode("@BASICinitLine")
                    If attrNode Is Nothing Then
                        'Me.BASICinitLineTextBox.Text = CStr(Me.AppConfig.defBASICinitLine)
                    Else
                        Me.AppConfig.BASIC_initLine = CInt(attrNode.InnerText)
                        'Me.BASICinitLineTextBox.Text = attrNode.InnerText
                    End If

                    attrNode = subNode.SelectSingleNode("@BASICincLines")
                    If attrNode Is Nothing Then
                        'Me.BASICincLineslTextBox.Text = CStr(Me.AppConfig.defBASICincLines)
                    Else
                        Me.AppConfig.BASIC_incLines = CInt(attrNode.InnerText)
                        'Me.BASICincLineslTextBox.Text = attrNode.InnerText
                    End If

                    attrNode = subNode.SelectSingleNode("@Remove0")
                    If attrNode Is Nothing Then
                        'Me.Remove0Check.Checked = Me.AppConfig.defBASICremove0
                    Else
                        Me.AppConfig.BASIC_remove0 = CBool(attrNode.InnerText.ToUpper = "TRUE")
                        'Me.Remove0Check.Checked = CBool(attrNode.InnerText.ToUpper = "TRUE")
                    End If

                    attrNode = subNode.SelectSingleNode("@Label")
                    If attrNode Is Nothing Then
                        Me.anOutputDataGBox.DataTypeInput.FieldName = "DATA"
                    Else
                        Me.anOutputDataGBox.DataTypeInput.FieldName = CStr(attrNode.InnerText)
                    End If


                    Me.anOutputDataGBox.InitControl(Me.AppConfig)  '<--- refresh data 
                    'anOutputDataGBox.DataTypeInput.SizeLineIndex

                End If
                ' END Output Data Config ###############################################


                AddHandlers()

                result = True

                'Me.ASM_COMMAND = Me.AsmCommandTextBox.Text
                GenerateData()

                'The purpose of displaying the progress bar is to let the user know that it has been executed successfully.
                'I apply a short wait for the progress window to show without closing too quickly.
                System.Threading.Thread.Sleep(200) 'wait

                Me.Progress.CloseProgressWin()

            Else
                Me.Progress.CloseProgressWin()

                Dim MessageWin As New MessageDialog
                MessageWin.ShowDialog(Me, "Load Project", "This file does not contain the correct format.", MessageDialog.DIALOG_TYPE.ALERT) '+ vbCrLf
            End If


        Else
            ' en el caso de que no exista
            Dim MessageWin As New MessageDialog
            MessageWin.ShowDialog(Me, "Load Project", "The file does not exist.", MessageDialog.DIALOG_TYPE.ALERT) '+ vbCrLf

        End If

        Return result

    End Function



    ''' <summary>
    ''' Muestra la ventana de dialogo para el guardado de un proyecto
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveProjectDialog()

        If Me.Path_Project = "" Then
            Me.SaveFileDialog1.FileName = Me.Info.Name_without_Spaces
            'Me.SaveFileDialog1.InitialDirectory = Me.AppConfig.PathByteGen.Path
        Else
            Me.SaveFileDialog1.FileName = Path.GetFileName(Me.Path_Project)
            Me.SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(Me.Path_Project)
        End If

        Me.SaveFileDialog1.Filter = "ByteniZ3R Project file|*." + Config.Extension_byteGEN

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            SaveProject(SaveFileDialog1.FileName)
            Me.Path_Project = SaveFileDialog1.FileName
            SetTitle(Path.GetFileName(Me.Path_Project))
            'Me.AppConfig.PathByteGen.UpdateLastPath(Path.GetDirectoryName(Me.Path_Project))
        End If

    End Sub



    ''' <summary>
    ''' Save a project, from an absolute path.
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <remarks></remarks>
    Private Sub SaveProject(ByVal filePath As String) 'As Boolean

        Dim aXmlDoc As New XmlDocument
        Dim rootElement As XmlElement
        Dim anElement As XmlElement
        Dim anItemElement As XmlElement
        Dim anAttribute As XmlAttribute

        'Dim result As Boolean = False

        Me.Progress.ShowProgressWin()

        ' crea el nodo root
        rootElement = aXmlDoc.CreateElement("msxdevtools")
        aXmlDoc.AppendChild(rootElement)

        anAttribute = aXmlDoc.CreateAttribute("app")
        anAttribute.Value = My.Application.Info.Title
        rootElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("version")
        anAttribute.Value = My.Application.Info.Version.ToString + Version_Stage
        rootElement.SetAttributeNode(anAttribute)


        anElement = aXmlDoc.CreateElement(AppID)
        rootElement.AppendChild(anElement)


        anItemElement = GetInfoElement(aXmlDoc, Me.Info)
        anElement.AppendChild(anItemElement)



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



        ' Output Data Config ###################################################
        anItemElement = aXmlDoc.CreateElement("OutputConfig")
        anElement.AppendChild(anItemElement)
        '
        anAttribute = aXmlDoc.CreateAttribute("LanguageCode")
        anAttribute.Value = CStr(Me.anOutputDataGBox.DataTypeInput.LanguageCode)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("NumberSystem")
        anAttribute.Value = CStr(Me.anOutputDataGBox.DataTypeInput.NumeralSystem) 'Me.DataFormatComboB.SelectedIndex)
        anItemElement.SetAttributeNode(anAttribute)

        'anAttribute = aXmlDoc.CreateAttribute("CodeCompressType")
        'anAttribute.Value = CStr(Me.anOutputDataGBox.DataTypeInput.Compress) 'Me.CompressionCB.SelectedIndex)
        'anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("LineSize")
        anAttribute.Value = CStr(Me.anOutputDataGBox.DataTypeInput.LineSize) 'Me.ItemsPerLineComboBox.SelectedIndex)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("AsmDataByteCommand")
        anAttribute.Value = Me.anOutputDataGBox.DataTypeInput.AsmDataByteCommand 'Me.AsmCommandTextBox.Text)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("BASICinitLine")
        anAttribute.Value = CStr(Me.anOutputDataGBox.DataTypeInput.BASIClineNumber) 'Me.BASICinitLineTextBox.Text)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("BASICincLines")
        anAttribute.Value = CStr(Me.anOutputDataGBox.DataTypeInput.BASICInterval) 'Me.BASICincLineslTextBox.Text)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("Remove0")
        anAttribute.Value = CStr(Me.anOutputDataGBox.DataTypeInput.BASICremoveZeros) 'Me.Remove0Check.Checked)
        anItemElement.SetAttributeNode(anAttribute)

        anAttribute = aXmlDoc.CreateAttribute("Label")
        anAttribute.Value = CStr(Me.anOutputDataGBox.DataTypeInput.FieldName)
        anItemElement.SetAttributeNode(anAttribute)
        ' END Output Data Config ################################################


        '
        aXmlDoc.Save(filePath)

        'The purpose of displaying the progress bar is to let the user know that it has been executed successfully.
        'I apply a short wait for the progress window to show without closing too quickly.
        System.Threading.Thread.Sleep(200) 'wait

        Me.Progress.CloseProgressWin()


        Me.AppConfig.AddRecentProject(Me.Path_Project, AppID)

        'result = True

        'Return result

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



    Private Sub ShowAbout(isOnInitialization As Boolean)
        Dim newAboutWin As New AboutWin
        newAboutWin.SetIcon = Global.ByteniZ3R.My.Resources.icon_byteniZ3R_128px
        newAboutWin.SetLogo = Global.ByteniZ3R.My.Resources.ByteniZ3R_logo
        'newAboutWin.Width = 660
        If isOnInitialization = True Then
            newAboutWin.StartPosition = FormStartPosition.CenterScreen
        End If
        newAboutWin.ShowDialog()
    End Sub



    ''' <summary>
    ''' Opens the project information editing window.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetProjectInfo()

        Dim ProjectProperties As New ProjectPropertiesDialog(Me.AppConfig, Me.Info) 'Path_Project

        If ProjectProperties.ShowDialog = DialogResult.OK Then

            Me.Info = ProjectProperties.GetProjectInfo()
            Me.ProjectNameTextBox.Text = Me.Info.Name
            SetTitle(Me.Info.Name)

            GenerateData()

        End If

    End Sub



    Private Sub SetConfig()

        Dim aConfig As New ConfigDialog(Me.AppConfig, ConfigDialog.CONFIG_TYPE.BYTENIZ3R)

        If aConfig.ShowDialog() = DialogResult.OK Then
            Me.AppConfig.Save()

            Me.anOutputDataGBox.RefreshControl()

            GenerateData()
        End If

    End Sub



    'Private Sub SetOutputtextSize()
    '    OutputText.Location = New Point(OutputText.Location.X, anOutputDataGBox.Location.Y + anOutputDataGBox.Height + 10)
    '    OutputText.Height = (SaveoutputPanel.Location.Y - OutputText.Location.Y) - 10
    'End Sub



    Private Sub NewButton_Click(sender As System.Object, e As System.EventArgs) Handles NewButton.Click
        NewProjectDialog()
    End Sub



    Private Sub LoadButton_Click(sender As System.Object, e As System.EventArgs) Handles LoadButton.Click
        LoadProjectDialog()
    End Sub



    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        If Me.Path_Project = "" Then
            SaveProjectDialog()
        Else
            SaveProject(Me.Path_Project)
        End If
    End Sub



    Private Sub SaveAsButton_Click(sender As Object, e As EventArgs) Handles SaveAsButton.Click
        SaveProjectDialog()
    End Sub



    Private Sub ProjectInfoButton_Click(sender As System.Object, e As System.EventArgs) Handles ProjectInfoButton.Click
        SetProjectInfo()
    End Sub



    Private Sub ConfigButton1_Click(sender As System.Object, e As System.EventArgs) Handles ConfigButton.Click
        SetConfig()
    End Sub



    Private Sub HelpButton_Click(sender As System.Object, e As System.EventArgs) Handles Help_Button.Click
        'Dim helper As New HelpWin(Me.Name, helpURL)
        'helper.ShowDialog()
    End Sub



    Private Sub AboutButton1_Click(sender As System.Object, e As System.EventArgs) Handles AboutButton.Click
        ShowAbout(False)
    End Sub



    Private Sub anOutputDataGBox_DataChanged()
        GenerateData()
    End Sub


End Class
