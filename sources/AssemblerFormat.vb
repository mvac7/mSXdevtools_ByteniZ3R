Public Class AssemblerFormat

    Public Shadows Const Comment_Assembler As String = ";"

    Public Shadows Const INCLUDE_asMSX = ".INCLUDE"
    Public Shadows Const INCLUDE_Sjasm = "INCLUDE"
    Public Shadows Const INCLUDE_tniASM = "INCLUDE"

    Public Shadows Const INCLUDEBIN_asMSX = ".INCBIN"
    Public Shadows Const INCLUDEBIN_Sjasm = "INCBIN"
    Public Shadows Const INCLUDEBIN_tniASM = "INCBIN"

    'Private _codeInfo As CodeInfo


    'Public Sub New(ByVal code_Info As CodeInfo)
    '    Me._codeInfo = code_Info
    'End Sub



    Public Function GetCommentWithAssemble(ByVal code As CodeInfo.LANGUAGE_CODE, ByVal putSymbol As Boolean) As String
        Dim tmpString As String

        Select Case code

            Case CodeInfo.LANGUAGE_CODE.ASSEMBLER_SDCC
                tmpString = "Formatted to compile with [SDCC](https://sdcc.sourceforge.net/)"

            Case CodeInfo.LANGUAGE_CODE.ASSEMBLER_asMSX
                tmpString = "Assemble with [asMSX](https://github.com/Fubukimaru/asMSX)"

            Case CodeInfo.LANGUAGE_CODE.ASSEMBLER_SJasm
                tmpString = "Assemble with [Sjasm](http://www.xl2s.tk/)"

            Case CodeInfo.LANGUAGE_CODE.ASSEMBLER_tniASM
                tmpString = "Assemble with [tniASM](http://tniasm.tni.nl/)"

            Case Else

                Return ""

        End Select

        If putSymbol Then
            tmpString = Comment_Assembler + " " + tmpString + vbNewLine
        End If

        Return tmpString

    End Function



    Public Function GetLabelsIndex(ByVal label As String, ByVal labelsList As ArrayList, ByVal dataCommand As String) As String
        Dim outputString As String
        Dim line As String
        Dim contaLines As Integer = 0
        Dim item As String
        Dim total As Integer = labelsList.Count - 1

        outputString = label + ":" + vbNewLine

        If dataCommand.Contains("<tab>") Then
            dataCommand = dataCommand.Replace("<tab>", vbTab)
        End If

        If dataCommand.Contains("<TAB>") Then
            dataCommand = dataCommand.Replace("<TAB>", vbTab)
        End If

        line = dataCommand + " "

        For i As Integer = 0 To total
            item = labelsList.Item(i)

            line += item
            contaLines += 1

            If i < total Then

                If contaLines < 4 And line.Length < 60 Then
                    line += ","
                Else
                    outputString += line + vbNewLine
                    line = dataCommand + " "
                    contaLines = 0
                End If

            Else
                outputString += line + vbNewLine
            End If


        Next

        Return outputString

    End Function




    Public Function GetInclude(ByVal filePath As String, ByVal code As CodeInfo.Language_CODE) As String
        Dim tmpString As String

        Select Case code
            Case CodeInfo.Language_CODE.ASSEMBLER_asMSX
                tmpString = INCLUDE_asMSX

            Case CodeInfo.Language_CODE.ASSEMBLER_SJasm
                tmpString = vbTab + INCLUDE_Sjasm

            Case CodeInfo.Language_CODE.ASSEMBLER_tniASM
                tmpString = vbTab + INCLUDE_tniASM

            Case Else

                Return ""

        End Select

        Return tmpString + " " + Chr(34) + filePath + Chr(34) + vbNewLine

    End Function



    Public Function GetIncludeBin(ByVal filePath As String, ByVal code As CodeInfo.Language_CODE) As String
        Dim tmpString As String

        Select Case code
            Case CodeInfo.Language_CODE.ASSEMBLER_asMSX
                tmpString = INCLUDEBIN_asMSX

            Case CodeInfo.Language_CODE.ASSEMBLER_SJasm
                tmpString = vbTab + INCLUDEBIN_Sjasm

            Case CodeInfo.Language_CODE.ASSEMBLER_tniASM
                tmpString = vbTab + INCLUDEBIN_tniASM

            Case Else

                Return ""

        End Select

        Return tmpString + " " + Chr(34) + filePath + Chr(34) + vbNewLine

    End Function



    Public Function GetAssemblerSuffix(ByVal code As CodeInfo.Language_CODE) As String
        Dim tmpString As String = ""

        Select Case code
            Case CodeInfo.Language_CODE.ASSEMBLER_asMSX
                tmpString = "_asMSX"

            Case CodeInfo.Language_CODE.ASSEMBLER_SJasm
                tmpString = "_Sjasm"

            Case CodeInfo.Language_CODE.ASSEMBLER_tniASM
                tmpString = "_tniASM"

        End Select

        Return tmpString

    End Function



    'Public Function GetIncludebinLoader(ByVal prj_info As ProjectInfo, ByVal putAnIndex As Boolean, ByVal code As CodeInfo.Language_CODE, ByVal asmWordCommand As String, ByVal fileExtension As String, ByVal _filesList As ArrayList) As String

    '    Dim tmpString As String
    '    Dim _dataFormat As New DataFormat()
    '    Dim _codeInfo As New CodeInfo
    '    Dim project_name As String = prj_info.Name

    '    If Not project_name = "" Then
    '        project_name += "_"
    '    End If

    '    tmpString = _dataFormat.GetProjectInfoComments(prj_info, code)
    '    'tmpString += GetCommentWithAssemble(code)
    '    tmpString += vbNewLine

    '    If putAnIndex = True Then
    '        tmpString += GetLabelsIndex(project_name + "INDEX", _filesList, asmWordCommand)
    '        tmpString += vbNewLine
    '    End If

    '    For Each filename As String In _filesList
    '        tmpString += filename + ":" + vbNewLine
    '        tmpString += GetIncludeBin(project_name + filename + fileExtension, code)
    '        tmpString += vbNewLine
    '    Next

    '    Return tmpString

    'End Function


End Class
