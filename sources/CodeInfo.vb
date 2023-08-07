Public Class CodeInfo

    Public Shadows Enum DataType As Byte
        DECIMAL_n = 0         '1
        DECIMAL_nnn = 1      '001  - 11
        DECIMAL_nnnd = 2      '001d - 1

        HEXADECIMAL_nn = 3    'FF   - 2
        HEXADECIMAL_Snn = 4   '$FF  - 4
        HEXADECIMAL_4nn = 5   '#FF  - 5
        HEXADECIMAL_0nnh = 6  '0FFh - 6
        HEXADECIMAL_C = 7  '0xFF - 3
        HEXADECIMAL_BASIC = 8  '&hFF - 7

        BINARY_n = 9          ' 00000000   - 8
        BINARY_nb = 10        ' 00000000b  - 9
        BINARY_percentn = 11  ' %00000000
        BINARY_C = 12         ' 0B00000000
        BINARY_BASIC = 13     ' &B00000000
    End Enum


    Public Shadows Enum PROGRAMMING_LANGUAGE As Integer
        BASIC
        C
        ASSEMBLER
    End Enum



    Public Shadows Enum LANGUAGE_CODE As Integer
        BASIC
        C
        ASSEMBLER_default
        ASSEMBLER_asMSX
        ASSEMBLER_tniASM
        ASSEMBLER_SJasm
        ASSEMBLER_SDCC
    End Enum


    Public LanguageCode As LANGUAGE_CODE
    Public NumeralSystem As DataType
    Public LineSize As Integer
    Public CompressType As Integer

    Public DataLabel As String

    Public AsmDataByteCommand As String
    Public AsmDataWordCommand As String

    Public CdataType As String

    Public BASIC_DataInstruction As String = "DATA"
    Public BASIC_CommentInstruction As String = "REM"
    Public BASIC_initLine As Integer
    Public BASIC_incLines As Integer
    Public BASIC_remove0 As Boolean = False



    Public ReadOnly Property ProgrammingLanguage() As PROGRAMMING_LANGUAGE
        Get
            Return GetProgrammingLanguageByLanguageCode(Me.LanguageCode)
        End Get
    End Property


    Public Function GetProgrammingLanguageByLanguageCode(ByVal code As LANGUAGE_CODE) As PROGRAMMING_LANGUAGE
        Dim value As PROGRAMMING_LANGUAGE

        Select Case code
            Case LANGUAGE_CODE.BASIC
                value = PROGRAMMING_LANGUAGE.BASIC
            Case LANGUAGE_CODE.C
                value = PROGRAMMING_LANGUAGE.C
            Case Else
                value = PROGRAMMING_LANGUAGE.ASSEMBLER
        End Select
        Return value
    End Function


End Class
