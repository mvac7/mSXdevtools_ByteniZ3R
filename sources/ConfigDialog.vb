Imports System.IO


''' <summary>
''' 
''' </summary>
Public Class ConfigDialog

    Private AppConfig As Config

    Private AppType As CONFIG_TYPE


    'Private Enum Language_CODE_index As Integer
    '    BASIC
    '    C
    '    Assembler_Default
    '    Assembler_asMSX
    '    Assembler_tniASM
    '    Assembler_SJasm
    '    Assembler_SDCC
    'End Enum


    Public Shadows Enum CONFIG_TAB As Integer
        MISCELANEA
        SOURCE_CODE
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


    Public Shadows Enum PALETTE_TYPE As Integer
        LIGHT_SIDE_FORCE
        DARK_KNIGHT
        MSX_BLUE
        GREEN_BOY
        NUTCILLA
        GREEN_PHOSPHOR
        AMBAR_PHOSPHOR
    End Enum



    Public ReadOnly Property ProgrammingLanguage As CodeInfo.PROGRAMMING_LANGUAGE
        Get
            Dim codeformat As New CodeInfo
            Return codeformat.GetProgrammingLanguageByLanguageCode(Me.CodeOutputComboBox.SelectedIndex)
        End Get
    End Property



    Public ReadOnly Property LanguageCode As CodeInfo.LANGUAGE_CODE
        Get
            Return Me.CodeOutputComboBox.SelectedIndex
        End Get
    End Property



    Public Sub New(ByRef _config As Config, ByVal aType As CONFIG_TYPE) 'ByVal _workPathType As Integer, ByVal _workPath As String, ByVal _codeOutput As Integer, ByVal _codeNumberFormat As Integer, ByVal _codeSizeLine As Integer, ByVal _codeCompressType As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        Me.Size = New System.Drawing.Size(628, 580)

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.AppConfig = _config
        Me.AppType = aType

    End Sub







    Private Sub ConfigWin_Load(sender As Object, e As EventArgs) Handles Me.Load

        SetConfigTab(CONFIG_TAB.MISCELANEA)

        Me.SourceCodePanel.Location = MiscPanel.Location

        Me.CodeOutputComboBox.SelectedIndex = Me.AppConfig.CodeOutput

        Me.NumberSystemCombo.SelectedIndex = Me.AppConfig.CodeNumberSystem
        Me.SizeLineComboBox.SelectedIndex = Me.AppConfig.CodeLineSize
        Me.CompressTypeComboBox.SelectedIndex = Me.AppConfig.CodeCompressType
        Me.AsmByteDataTextBox.Text = Me.AppConfig.AsmDataByteCommand
        Me.AsmWordDataTextBox.Text = Me.AppConfig.AsmDataWordCommand
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

        ShowLanguageStatus()


        Me.UserNameTextBox.Text = Me.AppConfig.Author
        Me.GroupNameTextBox.Text = Me.AppConfig.Group

        SetColor(Me.Color0Button, Me.AppConfig.Color_Zero)
        SetColor(Me.GridColorButton, Me.AppConfig.Color_Grid)

        SetColor(Me.OutputINKcolorButton, Me.AppConfig.Color_OUTPUT_INK)
        SetColor(Me.OutputBGcolorButton, Me.AppConfig.Color_OUTPUT_BG)

        Select Case Me.AppType
            Case CONFIG_TYPE.OTHER
                ProjectInfoGroupBox.Enabled = False
                DefaultColorsGroupBox.Enabled = False


        End Select


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

            Case PALETTE_TYPE.NUTCILLA
                SetColor(Me.OutputINKcolorButton, Color.White) 'FromArgb(255, 255, 255)
                SetColor(Me.OutputBGcolorButton, Color.FromArgb(&H6C, &H3B, &H1E)) '6c3b1e

            Case PALETTE_TYPE.DARK_KNIGHT
                SetColor(Me.OutputINKcolorButton, Color.WhiteSmoke)
                SetColor(Me.OutputBGcolorButton, Color.FromArgb(22, 22, 33))

            Case PALETTE_TYPE.GREEN_PHOSPHOR
                SetColor(Me.OutputINKcolorButton, Color.FromArgb(255, 52, 255, 93))
                SetColor(Me.OutputBGcolorButton, Color.FromArgb(255, 0, 52, 12))

            Case PALETTE_TYPE.AMBAR_PHOSPHOR
                SetColor(Me.OutputINKcolorButton, Color.FromArgb(255, 255, 170, 16)) '255, 227, 52
                SetColor(Me.OutputBGcolorButton, Color.FromArgb(255, 85, 20, 0))

            Case PALETTE_TYPE.MSX_BLUE
                SetColor(Me.OutputINKcolorButton, Color.FromArgb(255, 255, 255, 255))   'White
                SetColor(Me.OutputBGcolorButton, Color.FromArgb(255, 84, 85, 237))      'TMS9918A Dark Blue

            Case PALETTE_TYPE.GREEN_BOY
                SetColor(Me.OutputINKcolorButton, Color.FromArgb(255, 15, 56, 15))    ' light green
                SetColor(Me.OutputBGcolorButton, Color.FromArgb(255, 202, 220, 159))  ' dark green

            Case Else
                ' default PALETTE_TYPE.LIGHT_SIDE_FORCE
                SetColor(Me.OutputINKcolorButton, Me.AppConfig.def_Color_OUTPUT_INK)
                SetColor(Me.OutputBGcolorButton, Me.AppConfig.def_Color_OUTPUT_BG)

        End Select

    End Sub



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_Button.Click

        ' ######################################################################
        ' update config data        

        Me.AppConfig.CodeOutput = Me.LanguageCode

        Me.AppConfig.CodeNumberSystem = Me.NumberSystemCombo.SelectedIndex
        Me.AppConfig.CodeLineSize = Me.SizeLineComboBox.SelectedIndex
        Me.AppConfig.CodeCompressType = Me.CompressTypeComboBox.SelectedIndex
        Me.AppConfig.AsmDataByteCommand = Me.AsmByteDataTextBox.Text
        Me.AppConfig.AsmDataWordCommand = Me.AsmWordDataTextBox.Text
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
        AdjustValuesByLanguage()
        ShowLanguageStatus()
    End Sub



    Private Sub ShowLanguageStatus()


        If Me.ProgrammingLanguage = CodeInfo.PROGRAMMING_LANGUAGE.BASIC Then
            DataLabelLabel.Enabled = False
            DataLabelTextBox.Enabled = False
        Else
            DataLabelLabel.Enabled = True
            DataLabelTextBox.Enabled = True
        End If


        Select Case Me.LanguageCode

            Case CodeInfo.LANGUAGE_CODE.BASIC

                AssemblerGroupBox.Enabled = False
                CGroupBox.Enabled = False
                BASICGroupBox.Enabled = True
                Me.NumberSystemLabel.Enabled = True
                Me.NumberSystemCombo.Enabled = True


            Case CodeInfo.LANGUAGE_CODE.C

                AssemblerGroupBox.Enabled = False
                CGroupBox.Enabled = True
                BASICGroupBox.Enabled = False
                Me.NumberSystemLabel.Enabled = True
                Me.NumberSystemCombo.Enabled = True


            Case CodeInfo.LANGUAGE_CODE.ASSEMBLER_SDCC

                SetAssemblerFieldsStatus(False)


            Case CodeInfo.LANGUAGE_CODE.ASSEMBLER_SJasm

                SetAssemblerFieldsStatus(False)


            Case CodeInfo.LANGUAGE_CODE.ASSEMBLER_asMSX, CodeInfo.LANGUAGE_CODE.ASSEMBLER_tniASM

                SetAssemblerFieldsStatus(False)


            Case CodeInfo.LANGUAGE_CODE.ASSEMBLER_default

                SetAssemblerFieldsStatus(True)


        End Select


    End Sub



    Private Sub AdjustValuesByLanguage()



        Select Case Me.LanguageCode

            Case CodeInfo.LANGUAGE_CODE.BASIC

                'Me.RemoveZerosCheck.Enabled = True
                Select Case Me.NumberSystemCombo.SelectedIndex
                    Case CodeInfo.DataType.DECIMAL_n To CodeInfo.DataType.DECIMAL_nnnd
                        Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.DECIMAL_n
                    Case CodeInfo.DataType.BINARY_n To CodeInfo.DataType.BINARY_BASIC
                        Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.BINARY_BASIC
                    Case Else
                        Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.HEXADECIMAL_BASIC
                End Select


            Case CodeInfo.LANGUAGE_CODE.C

                Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.HEXADECIMAL_C


            Case CodeInfo.LANGUAGE_CODE.ASSEMBLER_SDCC

                Me.AsmByteDataTextBox.Text = ".db"
                Me.AsmWordDataTextBox.Text = ".dw"

                Select Case Me.NumberSystemCombo.SelectedIndex
                    Case CodeInfo.DataType.DECIMAL_n To CodeInfo.DataType.DECIMAL_nnnd
                        Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.DECIMAL_n
                    Case CodeInfo.DataType.BINARY_n To CodeInfo.DataType.BINARY_BASIC
                        Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.BINARY_C
                    Case Else
                        Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.HEXADECIMAL_C
                End Select


            Case CodeInfo.LANGUAGE_CODE.ASSEMBLER_SJasm

                Me.AsmByteDataTextBox.Text = "<tab>DB"
                Me.AsmWordDataTextBox.Text = "<tab>DW"

                Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.HEXADECIMAL_Snn


            Case CodeInfo.LANGUAGE_CODE.ASSEMBLER_asMSX, CodeInfo.LANGUAGE_CODE.ASSEMBLER_tniASM

                Me.AsmByteDataTextBox.Text = "DB"
                Me.AsmWordDataTextBox.Text = "DW"

                Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.HEXADECIMAL_Snn


            Case CodeInfo.LANGUAGE_CODE.ASSEMBLER_default

                Me.AsmByteDataTextBox.Text = Me.AppConfig.AsmDataByteCommand
                Me.AsmWordDataTextBox.Text = Me.AppConfig.AsmDataWordCommand

                Me.NumberSystemCombo.SelectedIndex = CodeInfo.DataType.HEXADECIMAL_Snn

        End Select


    End Sub



    Private Sub SetAssemblerFieldsStatus(ByVal state As Boolean)

        CGroupBox.Enabled = False
        BASICGroupBox.Enabled = False

        Me.AssemblerGroupBox.Enabled = state
        Me.NumberSystemLabel.Enabled = state
        Me.NumberSystemCombo.Enabled = state

    End Sub


    Private Sub PiXelST_HorizontalTab1_TabChanged(index As Integer) Handles PiXelST_HorizontalTab1.TabChanged

        SetConfigTab(index)

    End Sub


    Private Sub SetConfigTab(index As CONFIG_TAB)

        Dim panelState As Boolean

        If index = CONFIG_TAB.MISCELANEA Then
            panelState = True
        Else
            panelState = False
        End If

        Me.MiscPanel.Visible = panelState
        Me.SourceCodePanel.Visible = Not panelState

    End Sub

End Class