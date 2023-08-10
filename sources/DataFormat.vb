Public Class DataFormat

    ''' <summary>
    ''' Provides the last line number used in BASIC, with its increase.
    ''' </summary>
    Public BASIC_Line As Short = 10000

    Public BASIC_increment As Byte = 10

    Public Shadows Const Comment_Assembler As String = ";"
    Public Shadows Const Comment_C As String = "//"


    Private BASICdataInst As String = "DATA"
    Public Property BASIC_DataInstruction As String
        Get
            Return Me.BASICdataInst
        End Get
        Set(value As String)
            Me.BASICdataInst = value
        End Set
    End Property


    Private BASICcomment As String = "REM"
    Public Property Comment_BASIC As String
        Get
            Return Me.BASICcomment
        End Get
        Set(value As String)
            Me.BASICcomment = value
        End Set
    End Property



    'Public Function GetProgrammingLanguageByLanguageCode(ByVal code As CodeInfo.Language_CODE) As CodeInfo.Programming_Language
    '    Dim value As CodeInfo.Programming_Language

    '    Select Case code
    '        Case CodeInfo.Language_CODE.BASIC
    '            value = CodeInfo.Programming_Language.BASIC
    '        Case CodeInfo.Language_CODE.C
    '            value = CodeInfo.Programming_Language.C
    '        Case Else
    '            value = CodeInfo.Programming_Language.ASSEMBLER
    '    End Select
    '    Return value
    'End Function


    Public Class DataItem
        Public Name As String
        Public SourceCode As String
        Public Data As Byte()

        Public Sub New(ByVal name As String, ByRef _sourceCode As String, ByRef _data As Byte())
            Me.Name = name
            Me.SourceCode = _sourceCode.Clone
            Me.Data = _data.Clone
        End Sub

    End Class



    Public Function GetSourceCode(ByVal name As String, ByRef _codeFormat As CodeInfo, ByRef tmpData As Array, ByVal comments As ArrayList) As DataItem  'ByRef tmpData() As Byte

        Dim sourceCode As String = ""

        'Dim compressData As New Compress

        Dim newComments As New ArrayList

        'Dim tmpData As Byte()

        Me.Comment_BASIC = _codeFormat.BASIC_CommentInstruction

        If _codeFormat.ProgrammingLanguage = CodeInfo.PROGRAMMING_LANGUAGE.BASIC And Not name = "" Then
            newComments.Add("Name=" + name)
        End If
        newComments.AddRange(comments)


        'If _codeFormat.CompressType = iCompressEncoder.COMPRESS_TYPE.RAW Then
        '    tmpData = data
        '    newComments.Add("Size=" + CStr(data.Length))
        'Else
        '    tmpData = compressData.GetCompressData(_codeFormat.CompressType, data)
        '    newComments.Add(compressData.Compresors_List(_codeFormat.CompressType) + " compressed - Original size=" + CStr(data.Length) + " - Compress size=" + CStr(tmpData.Length))
        'End If

        Select Case _codeFormat.ProgrammingLanguage
            Case CodeInfo.PROGRAMMING_LANGUAGE.C
                sourceCode = GetCcode(tmpData, name, _codeFormat.LineSize, _codeFormat.NumeralSystem, _codeFormat.CdataType, newComments)

            Case CodeInfo.PROGRAMMING_LANGUAGE.ASSEMBLER
                sourceCode = GetAssemblerCode(tmpData, name, _codeFormat.LineSize, _codeFormat.NumeralSystem, _codeFormat.AsmDataByteCommand, newComments)

            Case CodeInfo.PROGRAMMING_LANGUAGE.BASIC
                sourceCode = GetBASICcode(tmpData, _codeFormat.LineSize, _codeFormat.NumeralSystem, _codeFormat.BASIC_remove0, Me.BASIC_Line, _codeFormat.BASIC_incLines, newComments)

        End Select


        Return New DataItem(name, sourceCode, tmpData)

    End Function




    ''' <summary>
    ''' Provides a text with the data formatted in MSX BASIC programming language.
    ''' </summary>
    ''' <param name="tmpData">Data</param>
    ''' <param name="itemsPerLine">Items per line</param>
    ''' <param name="format">Data format</param>
    ''' <param name="removeZeros">Remove zeros state</param>
    ''' <param name="firstNumLine">Value of the first line</param>
    ''' <param name="incLine">Value of the increment</param>
    ''' <param name="comments">Comments list</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBASICcode(ByVal tmpData As Array, ByVal itemsPerLine As Byte, ByVal format As CodeInfo.DataType, ByVal removeZeros As Boolean, ByVal firstNumLine As Short, ByVal incLine As Byte, ByVal comments As ArrayList) As String

        Dim outputString As String

        Dim contador As Integer = 0

        Dim line As String

        Dim i As Integer
        Dim o As Integer

        Dim tmpCalc As Short

        Dim tableSize As Short
        tableSize = tmpData.Length - 1

        Me.BASIC_Line = firstNumLine
        Me.BASIC_increment = incLine

        outputString = GetComments(comments, CodeInfo.Programming_Language.BASIC) 'GetBASICComments(comment, firstNumLine, incLine)

        If itemsPerLine < 1 Then
            itemsPerLine = 32 ' maximum data per line
        End If

        tmpCalc = -Int(-((tableSize + 1) / itemsPerLine))

        For i = 1 To tmpCalc
            line = CStr(Me.BASIC_Line) + " " + Me.BASICdataInst + " "
            For o = 0 To itemsPerLine - 2
                If (contador < tableSize) Then
                    line += GetBasicFormatedValue(tmpData(contador), format, removeZeros) + ","
                    contador += 1
                ElseIf (contador = tableSize) Then  ' ultimo de la linea
                    line += GetBasicFormatedValue(tmpData(contador), format, removeZeros)
                    contador += 1
                End If
            Next
            If Not (contador > tableSize) Then ' ultimo de la linea
                line += GetBasicFormatedValue(tmpData(contador), format, removeZeros)
                contador += 1
            End If

            outputString += line + vbNewLine
            Me.BASIC_Line += incLine
        Next

        Return outputString

    End Function



    ''' <summary>
    ''' Provides a text with the data formatted in C programming language.
    ''' </summary>
    ''' <param name="tmpData">Data</param>
    ''' <param name="variableName">Field name</param>
    ''' <param name="itemsPerLine">Items per line</param>
    ''' <param name="format">Data format</param>
    ''' <param name="arrayDeclaration">Array declaration in C</param>
    ''' <param name="comments">Comments list</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetCcode(ByVal tmpData As Array, ByVal variableName As String, ByVal itemsPerLine As Byte, ByVal format As CodeInfo.DataType, ByVal arrayDeclaration As String, ByVal comments As ArrayList) As String

        Dim outputString As String

        Dim contador As Integer = 0
        Dim line As String

        Dim i As Integer
        Dim o As Integer

        Dim totalLines As Short

        'Dim tmpValue As Object
        Dim formatedVale As String

        Dim tableSize As Integer
        tableSize = tmpData.Length - 1

        outputString = GetComments(comments, CodeInfo.Programming_Language.C)

        line = arrayDeclaration + " " + GetCvariableNameFormat(variableName) + "[]={"
        outputString += line + vbNewLine

        If itemsPerLine < 1 Then
            itemsPerLine = 32 ' maximum data per line
        End If

        totalLines = -Int(-((tableSize + 1) / itemsPerLine))

        For i = 1 To totalLines
            line = ""
            For o = 0 To itemsPerLine - 1

                If Not (contador > tableSize) Then

                    formatedVale = GetFormatedValue(tmpData(contador), format)

                    If (contador < tableSize) Then
                        line += formatedVale + ","
                        contador += 1
                    ElseIf (contador = tableSize) Then
                        line += formatedVale + "};"
                        contador += 1
                    End If

                End If

            Next

            outputString += line + vbNewLine
        Next

        Return outputString

    End Function



    ''' <summary>
    ''' Provides a text with the data formatted in Assembler programming language.
    ''' </summary>
    ''' <param name="tmpData">Data</param>
    ''' <param name="fieldName">Field name</param>
    ''' <param name="itemsPerLine">Items per line</param>
    ''' <param name="format">Data format</param>
    ''' <param name="dataCommand">Command for the data</param>
    ''' <param name="comments">Comments list</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetAssemblerCode(ByVal tmpData As Array, ByVal fieldName As String, ByVal itemsPerLine As Byte, ByVal format As CodeInfo.DataType, ByVal dataCommand As String, ByVal comments As ArrayList) As String

        Dim outputString As String

        Dim contador As Integer = 0
        Dim line As String

        Dim i As Integer
        Dim o As Integer

        Dim totalLines As Short

        Dim formatedVale As String

        Dim tableSize As Short
        tableSize = tmpData.Length - 1

        outputString = GetComments(comments, CodeInfo.Programming_Language.ASSEMBLER)

        If Not fieldName = "" Then
            outputString += GetAsmFieldFormat(fieldName) + ":" + vbNewLine
        End If

        If itemsPerLine < 1 Then
            itemsPerLine = 32 ' maximum data per line
        End If

        totalLines = -Int(-((tableSize + 1) / itemsPerLine))

        If dataCommand.Contains("<tab>") Then
            dataCommand = dataCommand.Replace("<tab>", vbTab)
        End If

        If dataCommand.Contains("<TAB>") Then
            dataCommand = dataCommand.Replace("<TAB>", vbTab)
        End If

        For i = 1 To totalLines

            line = dataCommand + " "

            For o = 0 To itemsPerLine - 1

                If Not (contador > tableSize) Then

                    formatedVale = GetFormatedValue(tmpData(contador), format)

                    If (o = itemsPerLine - 1) Or (contador = tableSize) Then
                        line += formatedVale
                    Else
                        line += formatedVale + ","
                    End If
                    contador += 1

                End If
            Next

            outputString += line + vbNewLine
        Next

        Return outputString

    End Function



    ''' <summary>
    ''' Provides a value formatted for BASIC
    ''' </summary>
    ''' <param name="value"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetBasicFormatedValue(ByVal value As Object, ByVal format As CodeInfo.DataType, ByVal removeZeros As Boolean) As String

        Dim outputData As String = ""

        If IsNumeric(value) Then
            If removeZeros Then
                If value = 0 Then
                    outputData = ""
                Else
                    If format = CodeInfo.DataType.HEXADECIMAL_nn Then
                        outputData = Hex(value)
                    Else
                        outputData = GetFormatedValue(value, format)
                    End If
                End If
            Else
                outputData = GetFormatedValue(value, format)
            End If
        End If

        Return outputData

    End Function



    ''' <summary>
    ''' Provides a value formatted in different types
    ''' </summary>
    ''' <param name="value"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    Public Function GetFormatedValue(ByVal value As Object, ByVal format As CodeInfo.DataType) As String

        Dim outputData As String = "0"

        Dim decSize As Integer = 3
        Dim hexSize As Integer = 2
        Dim binSize As Integer = 8


        If TypeOf value Is Short Then
            decSize = 5
            hexSize = 4
            binSize = 16
        End If


        Select Case format

            Case CodeInfo.DataType.DECIMAL_n
                outputData = CStr(value)

            Case CodeInfo.DataType.DECIMAL_nnn
                outputData = CStr(value).PadLeft(decSize, "0"c)

            Case CodeInfo.DataType.DECIMAL_nnnd
                outputData = CStr(value).PadLeft(decSize, "0"c) + "d"

            Case CodeInfo.DataType.HEXADECIMAL_nn
                outputData = Hex(value).PadLeft(hexSize, "0"c)

            Case CodeInfo.DataType.HEXADECIMAL_0nnh
                outputData = "0" + Hex(value).PadLeft(hexSize, "0"c) + "h"

            Case CodeInfo.DataType.HEXADECIMAL_C
                outputData = "0x" + Hex(value).PadLeft(hexSize, "0"c)

            Case CodeInfo.DataType.HEXADECIMAL_4nn
                outputData = "#" + Hex(value).PadLeft(hexSize, "0"c)

            Case CodeInfo.DataType.HEXADECIMAL_Snn
                outputData = "$" + Hex(value).PadLeft(hexSize, "0"c)

            Case CodeInfo.DataType.HEXADECIMAL_BASIC
                outputData = "&H" + Hex(value).PadLeft(hexSize, "0"c)

            Case CodeInfo.DataType.BINARY_n
                outputData = Convert.ToString(value, 2).PadLeft(binSize, "0"c)

            Case CodeInfo.DataType.BINARY_nb
                outputData = Convert.ToString(value, 2).PadLeft(binSize, "0"c) + "b"

            Case CodeInfo.DataType.BINARY_percentn
                outputData = "%" + Convert.ToString(value, 2).PadLeft(binSize, "0"c)

            Case CodeInfo.DataType.BINARY_C
                outputData = "0b" + Convert.ToString(value, 2).PadLeft(binSize, "0"c)

            Case CodeInfo.DataType.BINARY_BASIC
                outputData = "&B" + Convert.ToString(value, 2).PadLeft(binSize, "0"c)

        End Select

        Return outputData

    End Function




    ''' <summary>
    ''' Provides an 8-bit hexadecimal value
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetHexByte(ByVal value As Byte) As String
        Return Hex(value).PadLeft(2, "0"c)
    End Function



    ''' <summary>
    ''' Provides a 16-bit hexadecimal value
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetHexWord(ByVal value As Short) As String
        Return Hex(value).PadLeft(4, "0"c)
    End Function



    '''' <summary>
    '''' Provides a String formatted from an Array of Bytes, to be used in XML files.
    '''' </summary>
    '''' <param name="aData"></param>
    '''' <returns></returns>
    Public Function JoinDataHex(ByVal aData As Byte()) As String
        Dim anOutput As String = ""
        Dim i As Integer

        For i = 0 To aData.Length - 1
            anOutput += GetHexByte(aData(i))
        Next

        Return anOutput
    End Function



    ''' <summary>
    ''' Provides an Array of Bytes from a String formatted by JoinDataHex(). For reading data from files in XML.
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    Public Function ByteSpliterHex(ByVal data As String) As Byte()
        Dim tmpData As Byte()

        Dim size As Integer = (data.Length / 2) - 1
        ReDim tmpData(size)

        For i As Integer = 0 To size
            tmpData(i) = Byte.Parse((data.Substring(i * 2, 2)), System.Globalization.NumberStyles.HexNumber)
        Next

        Return tmpData
    End Function



    Public Function ByteSpliter(ByVal data As String, ByVal size As Integer, ByVal initpos As Integer) As Byte()
        If data.IndexOf(",") = -1 Then
            Return ByteSpliterHex(data, size, initpos)
        Else
            Return ByteSpliter(data, size, initpos, 0)
        End If
    End Function



    ''' <summary>
    ''' Provides an Array of Bytes from a String formatted by JoinDataHex(). For reading data from files in XML.
    ''' </summary>
    ''' <param name="data"></param>
    ''' <param name="size"></param>
    ''' <param name="initpos"></param>
    ''' <returns></returns>
    Public Function ByteSpliterHex(ByVal data As String, ByVal size As Integer, ByVal initpos As Integer) As Byte()
        Dim tmpData As Byte()
        Dim counter As Integer = 0

        ReDim tmpData(size)

        If (data.Length / 2) < (size + 1) Then
            data += New String("0", 64) 'add 32(*2) hex values
        End If

        For i As Integer = initpos To initpos + size
            tmpData(counter) = Byte.Parse((data.Substring(i * 2, 2)), System.Globalization.NumberStyles.HexNumber)
            counter += 1
        Next

        Return tmpData
    End Function



    ''' <summary>
    ''' DEPRECATED, Para compatibilidad con el formato del MSXtiles devtool.
    ''' </summary>
    ''' <param name="data"></param>
    ''' <param name="size"></param>
    ''' <param name="initpos"></param>
    ''' <param name="defaultvalue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ByteSpliter(ByVal data As String, ByVal size As Integer, ByVal initpos As Integer, ByVal defaultvalue As Byte) As Byte()
        Dim tmpData As Byte()
        Dim numitems As Integer = 0
        Dim counter As Integer = 0

        Dim defaultString As String = "," + CStr(defaultvalue)

        For i As Integer = 0 To 31
            data += defaultString
        Next

        ReDim tmpData(size)

        Dim splitdata As String() = data.Split(",")
        numitems = splitdata.GetLength(0)

        For i As Integer = initpos To initpos + size
            tmpData(counter) = CByte(splitdata(i))
            counter += 1
        Next

        Return tmpData
    End Function



    Public Function GetAsmFieldFormat(ByVal field As String) As String
        Dim formatedField As String

        formatedField = field.Trim
        formatedField = formatedField.Replace(" ", "_")
        formatedField = formatedField.Replace(".", "_")
        formatedField = formatedField.Replace("(", "")
        formatedField = formatedField.Replace(")", "")

        Return formatedField
    End Function



    Public Function GetCvariableNameFormat(ByVal vName As String) As String

        Dim specialChars As String() = {"(", ")", "{", "}", ";", ":", "#", "!", "?", "+", "@", "%", "*", ",", "'"}

        Dim formatedField As String

        'cannot contain spaces
        formatedField = vName.Trim
        formatedField = formatedField.Replace(" ", "_")

        'formatedField = formatedField.Replace(".", "_")  ' <--- dots dont filtering for use in objects in c++ ?

        ' cannot be a number
        If formatedField = "" Or IsNumeric(formatedField) Then
            Return "DATA" 'default value
        End If

        'cannot contain special characters
        For Each oldValue As String In specialChars
            formatedField = formatedField.Replace(oldValue, "")
        Next

        '  first char must be a letter or an underscore 
        If IsNumeric(formatedField.Substring(0, 1)) Then
            formatedField = "_" + formatedField.Substring(1)
        End If

        ' Reserved words filtering not implemented

        Return formatedField

    End Function



    ''' <summary>
    ''' Provides a String from a list of comments, in the indicated Programming Language format.
    ''' </summary>
    ''' <param name="comments"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    Public Function GetComments(ByVal comments As ArrayList, ByVal format As CodeInfo.Programming_Language) As String

        Dim outputString As String = ""

        If Not comments Is Nothing Then
            For Each commentItem As String In comments

                outputString += GetComment(commentItem, format)

            Next
        End If

        Return outputString

    End Function



    ''' <summary>
    ''' Provides a String from a comment, in the indicated Programming Language format.
    ''' </summary>
    ''' <param name="comment"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    Public Function GetComment(ByVal comment As String, ByVal format As CodeInfo.Programming_Language) As String

        Dim outputString As String = ""

        If Not comment = "" Then

            Select Case format
                Case CodeInfo.Programming_Language.BASIC
                    outputString += CStr(Me.BASIC_Line) + " " + Me.BASICcomment + " " + comment + vbNewLine
                    Me.BASIC_Line += Me.BASIC_increment

                Case CodeInfo.Programming_Language.C
                    outputString += Comment_C + " " + comment + vbNewLine

                Case Else
                    'ProgrammingLanguage.ASSEMBLER
                    outputString += Comment_Assembler + " " + comment + vbNewLine

            End Select

        End If

        Return outputString

    End Function



    ''' <summary>
    ''' Provides a comment with a horizontal line
    ''' </summary>
    ''' <param name="format"></param>
    ''' <returns></returns>
    Public Function GetCommentHorizontalLine(ByVal format As CodeInfo.Programming_Language) As String

        Dim outputString As String = ""

        Dim lineSize As Integer

        Select Case format
            Case CodeInfo.Programming_Language.BASIC
                outputString += CStr(Me.BASIC_Line) + " " + Me.BASICcomment + " "
                Me.BASIC_Line += Me.BASIC_increment

                lineSize = 40 - outputString.Length

            Case CodeInfo.Programming_Language.C
                outputString += Comment_C + " "

                lineSize = 80 - outputString.Length

            Case Else
                'ProgrammingLanguage.ASSEMBLER
                outputString += Comment_Assembler + " "

                lineSize = 80 - outputString.Length

        End Select

        Return outputString + Strings.StrDup(lineSize, "-") + vbNewLine

    End Function



    'Public Function GetProjectInfoComments(ByVal prjinfo As ProjectInfo, ByVal code As CodeInfo.Language_CODE) As String

    '    Dim outputSource As String

    '    Dim comments As New ArrayList
    '    Dim tmpInfo As String = ""

    '    Dim _codeInfo As New CodeInfo
    '    Dim _assembler As New AssemblerFormat

    '    Dim langFormat As CodeInfo.Programming_Language = _codeInfo.GetProgrammingLanguageByLanguageCode(code)

    '    comments.Add(My.Application.Info.ProductName + " v" + My.Application.Info.Version.ToString)

    '    If Not prjinfo.ProjectName = "" Then
    '        comments.Add("Project: " + prjinfo.ProjectName)
    '    End If

    '    If Not prjinfo.Name = "" Then
    '        comments.Add("Subproject: " + prjinfo.Name)
    '    End If

    '    If Not prjinfo.Author = "" Then
    '        tmpInfo = "Author: " + prjinfo.Author
    '    End If

    '    If Not prjinfo.Group = "" Then
    '        If Not tmpInfo = "" Then
    '            tmpInfo += " - "
    '        End If
    '        tmpInfo += "Group: " + prjinfo.Group
    '    End If

    '    If Not tmpInfo = "" Then
    '        comments.Add(tmpInfo)
    '    End If


    '    If Not prjinfo.Description = "" Then
    '        comments.Add("Description: " + prjinfo.Description)
    '    End If


    '    outputSource = GetCommentHorizontalLine(langFormat)
    '    outputSource += GetComments(comments, langFormat)
    '    outputSource += _assembler.GetCommentWithAssemble(code)  'this function only provides a value for assembler
    '    outputSource += GetCommentHorizontalLine(langFormat)

    '    Return outputSource

    'End Function


End Class

