Imports System.IO


''' <summary>
''' 
''' </summary>
Public Class ConfigDialog

    Private AppConfig As Config

    Private _type As CONFIG_TYPE


    Private Enum Language_CODE As Integer
        ASSEMBLER_default
        ASSEMBLER_SJasm
        ASSEMBLER_SDCC
        BASIC
        C
    End Enum


    Public Shadows Enum CONFIG_TYPE As Integer
        TMSGFX
        SPRITESX
        MAPSX
        TILESETSX
        PALETTESX
        SQUAREDSX
        BYTENIZ3R
        OAMSX
        PAINTSX
        OTHER
    End Enum


    Public ReadOnly Property CodeLanguage As DataFormat.ProgrammingLanguage
        Get
            Dim value As DataFormat.ProgrammingLanguage

            Select Case Me.CodeOutputComboBox.SelectedIndex
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



    Public Sub New(ByRef _config As Config, ByVal aType As CONFIG_TYPE) 'ByVal _workPathType As Integer, ByVal _workPath As String, ByVal _codeOutput As Integer, ByVal _codeNumberFormat As Integer, ByVal _codeSizeLine As Integer, ByVal _codeCompressType As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.AppConfig = _config
        Me._type = aType

    End Sub



    Private Sub ConfigWin_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Me.CodeOutputComboBox.SelectedIndex = Me.AppConfig.CodeOutput
        Select Case Me.AppConfig.CodeOutput
            Case DataFormat.ProgrammingLanguage.C
                Me.CodeOutputComboBox.SelectedIndex = Language_CODE.C

            Case DataFormat.ProgrammingLanguage.BASIC
                Me.CodeOutputComboBox.SelectedIndex = Language_CODE.BASIC

            Case Else
                Me.CodeOutputComboBox.SelectedIndex = Language_CODE.ASSEMBLER_default

        End Select

        Me.NumFormatComboBox.SelectedIndex = Me.AppConfig.CodeNumberSystem
        Me.SizeLineComboBox.SelectedIndex = Me.AppConfig.CodeLineSize
        Me.CompressTypeComboBox.SelectedIndex = Me.AppConfig.CodeCompressType
        Me.AsmByteDataTextBox.Text = Me.AppConfig.AsmByteCommand
        Me.AsmWordDataTextBox.Text = Me.AppConfig.AsmWordDataCommand
        Me.CByteDataTextBox.Text = Me.AppConfig.CdataType

        Me.BASICdataTextBox.Text = Me.AppConfig.BASIC_DataInstruction
        Me.BASICcommentComboBox.SelectedIndex = GetBASIC_CommentInstruction_Index(Me.AppConfig.BASIC_CommentInstruction)
        Me.BASICinitLineTextBox.Text = CStr(Me.AppConfig.BASIC_initLine)
        Me.BASICincLineslTextBox.Text = CStr(Me.AppConfig.BASIC_incLines)
        Me.RemoveZerosCheck.Checked = Me.AppConfig.BASIC_remove0

        If Me.AppConfig.DataLabel = "" Then
            Me.DataLabelTextBox.Text = Config.def_DataLabel
        Else
            Me.DataLabelTextBox.Text = Me.AppConfig.DataLabel
        End If


        Me.UserNameTextBox.Text = Me.AppConfig.Author
        Me.GroupNameTextBox.Text = Me.AppConfig.Group

        SetColor(Me.Color0Button, Me.AppConfig.Color_Zero)
        SetColor(Me.GridColorButton, Me.AppConfig.Color_Grid)

        SetColor(Me.OutputINKcolorButton, Me.AppConfig.Color_OUTPUT_INK)
        SetColor(Me.OutputBGcolorButton, Me.AppConfig.Color_OUTPUT_BG)


        'If Not Me.AppConfig.PathLastProject = "" Then
        '    Me.PathLastPRJTextBox.Text = Path.GetFileName(Me.AppConfig.PathLastProject)
        '    Me.ToolTip1.SetToolTip(Me.PathLastPRJTextBox, Me.AppConfig.PathLastProject)
        'End If


        'Select Case Me.AppConfig.firstProjectType
        '    Case Config.FIRST_PROJECT.NEWPROJECT
        '        Me.RadioButton2.Checked = True

        '    Case Config.FIRST_PROJECT.LASTPROJECT
        '        Me.RadioButton3.Checked = True

        '    Case Else
        '        Me.RadioButton1.Checked = True
        'End Select


        ' draw gradient in window-form background
        Dim gradientBG As New Bitmap(Me.Width, Me.Height)
        Dim newBrush As New Drawing.Drawing2D.LinearGradientBrush(New PointF(0, 0), New PointF(0, gradientBG.Height), Color.Gainsboro, Color.SlateGray)
        Dim oneGraphic As Graphics = Graphics.FromImage(gradientBG)
        oneGraphic.FillRectangle(newBrush, New RectangleF(0, 0, gradientBG.Width, gradientBG.Height))
        Me.BackgroundImage = gradientBG


        AddHandlers()

    End Sub



    Private Sub AddHandlers()
        AddHandler Me.CodeOutputComboBox.SelectedIndexChanged, AddressOf CodeOutputComboBox_SelectedIndexChanged
    End Sub



    Private Sub RemoveHandlers()
        RemoveHandler Me.CodeOutputComboBox.SelectedIndexChanged, AddressOf CodeOutputComboBox_SelectedIndexChanged
    End Sub



    Public Function GetBASIC_CommentInstruction_Index(value As String) As Integer
        If value.ToUpper = "REM" Then
            Return 0
        Else
            Return 1
        End If
    End Function



    Private Sub BASICinitLineText_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles BASICinitLineTextBox.Validating
        Dim value As Integer

        If Not IsNumeric(Me.BASICinitLineTextBox.Text) Then
            value = 1000
        Else
            value = CInt(Me.BASICinitLineTextBox.Text)

            If value > 30000 Then
                value = 1000
            ElseIf value < 1 Then
                value = 1
            End If
        End If

        Me.BASICinitLineTextBox.Text = CStr(value)
    End Sub



    Private Sub BASICincLineslTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles BASICincLineslTextBox.Validating
        Dim value As Integer

        If Not IsNumeric(Me.BASICincLineslTextBox.Text) Then
            value = 10
        Else
            value = CInt(Me.BASICincLineslTextBox.Text)

            If value > 255 Then
                value = 255
            ElseIf value < 1 Then
                value = 1
            End If
        End If

        Me.BASICincLineslTextBox.Text = CStr(value)
    End Sub



    Private Sub Color0Button_Click(sender As Object, e As EventArgs) Handles Color0Button.Click, GridColorButton.Click, OutputINKcolorButton.Click, OutputBGcolorButton.Click
        Dim aButtom As Button = CType(sender, Button)
        Me.ColorDialog1.Color = aButtom.BackColor
        Me.ColorDialog1.ShowDialog()
        SetColor(aButtom, Me.ColorDialog1.Color)
    End Sub



    Private Sub SetColor(ByRef aButton As Button, ByVal newColor As Color)
        aButton.BackColor = newColor
        aButton.Text = newColor.Name
        If newColor.GetBrightness > 0.7 Then
            aButton.ForeColor = Color.Black
        Else
            aButton.ForeColor = Color.White
        End If

        Select Case aButton.Name
            Case "OutputINKcolorButton"
                OutputText.ForeColor = newColor

            Case "OutputBGcolorButton"
                OutputText.BackColor = newColor
        End Select
    End Sub



    Private Sub AsmByteValuesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AsmByteValuesComboBox.SelectedIndexChanged
        AsmByteDataTextBox.Text = AsmByteValuesComboBox.SelectedItem
    End Sub



    Private Sub AsmWordComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AsmWordValuesComboBox.SelectedIndexChanged
        AsmWordDataTextBox.Text = AsmWordValuesComboBox.SelectedItem
    End Sub



    Private Sub ColorConfigsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ColorConfigsComboBox.SelectedIndexChanged

        Select Case ColorConfigsComboBox.SelectedIndex
            Case 1
                ' blue MSX BASIC
                SetColor(Me.OutputINKcolorButton, Color.FromArgb(255, 255, 255, 255))   'White
                SetColor(Me.OutputBGcolorButton, Color.FromArgb(255, 84, 85, 237))      'TMS9918A Dark Blue

            Case 2
                ' green GB
                SetColor(Me.OutputINKcolorButton, Color.FromArgb(255, 15, 56, 15))    ' light green
                SetColor(Me.OutputBGcolorButton, Color.FromArgb(255, 202, 220, 159))  ' dark green

            Case Else
                ' default
                SetColor(Me.OutputINKcolorButton, Me.AppConfig.def_Color_OUTPUT_INK)
                SetColor(Me.OutputBGcolorButton, Me.AppConfig.def_Color_OUTPUT_BG)

        End Select

    End Sub



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        ' ######################################################################
        ' update config data        

        Me.AppConfig.CodeOutput = Me.CodeLanguage ' <<<<<<<--------------- OJO!

        Me.AppConfig.CodeNumberSystem = Me.NumFormatComboBox.SelectedIndex
        Me.AppConfig.CodeLineSize = Me.SizeLineComboBox.SelectedIndex
        Me.AppConfig.CodeCompressType = Me.CompressTypeComboBox.SelectedIndex
        Me.AppConfig.AsmByteCommand = Me.AsmByteDataTextBox.Text
        Me.AppConfig.AsmWordDataCommand = Me.AsmWordDataTextBox.Text
        Me.AppConfig.CdataType = Me.CByteDataTextBox.Text
        Me.AppConfig.BASIC_initLine = CInt(Me.BASICinitLineTextBox.Text)
        Me.AppConfig.BASIC_incLines = CInt(Me.BASICincLineslTextBox.Text)
        Me.AppConfig.BASIC_remove0 = Me.RemoveZerosCheck.Checked
        Me.AppConfig.BASIC_DataInstruction = Me.BASICdataTextBox.Text

        If Me.BASICcommentComboBox.SelectedIndex = 1 Then
            Me.AppConfig.BASIC_CommentInstruction = "'" 'defBASIC_CommentInstruction
        Else
            Me.AppConfig.BASIC_CommentInstruction = "REM" 'defBASIC_CommentInstruction
        End If

        Me.AppConfig.DataLabel = Me.DataLabelTextBox.Text 'defDataLabel

        Me.AppConfig.Author = Me.UserNameTextBox.Text
        Me.AppConfig.Group = Me.GroupNameTextBox.Text

        'If Me.RadioButton2.Checked = True Then
        '    Me.AppConfig.firstProjectType = Config.FIRST_PROJECT.NEWPROJECT
        'ElseIf Me.RadioButton3.Checked = True Then
        '    Me.AppConfig.firstProjectType = Config.FIRST_PROJECT.LASTPROJECT
        'Else
        '    Me.AppConfig.firstProjectType = Config.FIRST_PROJECT.PRESENTATION
        'End If


        Me.AppConfig.Color_Zero = Me.Color0Button.BackColor
        Me.AppConfig.Color_Grid = Me.GridColorButton.BackColor
        Me.AppConfig.Color_OUTPUT_INK = Me.OutputINKcolorButton.BackColor
        Me.AppConfig.Color_OUTPUT_BG = Me.OutputBGcolorButton.BackColor


        'Me.AppConfig.InitOutputInfo()
        ' ######################################################################

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub



    Private Sub CodeOutputComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) 'Handles CodeOutputComboBox.SelectedIndexChanged

        ShowLanguageStatus()

    End Sub



    Private Sub ShowLanguageStatus()

        Select Case CodeLanguage

            Case DataFormat.ProgrammingLanguage.BASIC  'basic

                'Me.RemoveZerosCheck.Enabled = True
                Select Case Me.NumFormatComboBox.SelectedIndex
                    Case DataFormat.DataType.DECIMAL_n To DataFormat.DataType.DECIMAL_nnnd
                        Me.NumFormatComboBox.SelectedIndex = DataFormat.DataType.DECIMAL_n
                    Case DataFormat.DataType.BINARY_n To DataFormat.DataType.BINARY_BASIC
                        Me.NumFormatComboBox.SelectedIndex = DataFormat.DataType.BINARY_BASIC
                    Case Else
                        Me.NumFormatComboBox.SelectedIndex = DataFormat.DataType.HEXADECIMAL_BASIC
                End Select

            Case DataFormat.ProgrammingLanguage.C

                SetSDCC_CodeFormat()

            Case DataFormat.ProgrammingLanguage.ASSEMBLER

                If Me.CodeOutputComboBox.SelectedIndex = Language_CODE.ASSEMBLER_SDCC Then

                    Me.AsmByteDataTextBox.Text = ".db"
                    Me.AsmWordDataTextBox.Text = ".dw"

                    SetSDCC_CodeFormat()

                Else
                    If Me.CodeOutputComboBox.SelectedIndex = Language_CODE.ASSEMBLER_SJasm Then
                        Me.AsmByteDataTextBox.Text = "<tab>DB"
                        Me.AsmWordDataTextBox.Text = "<tab>DW"
                    Else
                        Me.AsmByteDataTextBox.Text = "DB"
                        Me.AsmWordDataTextBox.Text = "DW"
                    End If


                    Select Case Me.NumFormatComboBox.SelectedIndex
                        Case DataFormat.DataType.DECIMAL_n To DataFormat.DataType.DECIMAL_nnnd
                            Me.NumFormatComboBox.SelectedIndex = DataFormat.DataType.DECIMAL_nnnd      '?? default
                        Case DataFormat.DataType.BINARY_n To DataFormat.DataType.BINARY_BASIC
                            Me.NumFormatComboBox.SelectedIndex = DataFormat.DataType.BINARY_nb         '?? default
                        Case Else
                            Me.NumFormatComboBox.SelectedIndex = DataFormat.DataType.HEXADECIMAL_Snn   '?? default
                    End Select

                End If


        End Select

        If Me.NumFormatComboBox.SelectedIndex >= DataFormat.DataType.BINARY_n Then
            Me.SizeLineComboBox.SelectedIndex = 0
        Else
            Me.SizeLineComboBox.SelectedIndex = Me.AppConfig.CodeLineSize
        End If

    End Sub



    Private Sub SetSDCC_CodeFormat()
        Select Case Me.NumFormatComboBox.SelectedIndex
            Case DataFormat.DataType.DECIMAL_n To DataFormat.DataType.DECIMAL_nnnd
                Me.NumFormatComboBox.SelectedIndex = DataFormat.DataType.DECIMAL_n
            Case DataFormat.DataType.BINARY_n To DataFormat.DataType.BINARY_BASIC
                Me.NumFormatComboBox.SelectedIndex = DataFormat.DataType.BINARY_C
            Case Else
                Me.NumFormatComboBox.SelectedIndex = DataFormat.DataType.HEXADECIMAL_C
        End Select
    End Sub



End Class