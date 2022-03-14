Public Class RLE

    Private Const RLEWB_CONTROL As Byte = &H80 '128
    Private Const RLEWB_CODE_CDVAL As Byte = &H0
    Private Const RLEWB_CODE_END As Byte = &HFF

    ''' <summary>
    ''' Run-Length Encoding (RLE) BASIC
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Compress_RLE(ByVal data() As Byte) As Byte()
        Dim RLEtmpData As New ArrayList
        Dim RLEoutputData() As Byte
        Dim isEnd As Boolean = False
        Dim repetition As Byte = 0
        Dim position As Integer = 0
        Dim value As Byte
        'Dim nextValue As Byte

        Do
            value = data(position)
            If value = data(position + 1) Then
                repetition += 1 ' cuento las repeticiones
                If repetition = 255 Then ' control del valor maximo de repeticiones
                    RLEtmpData.Add(255)
                    RLEtmpData.Add(value)
                    repetition = 0
                End If
            Else
                ' no se repite mas, 
                RLEtmpData.Add(repetition + 1) ' escribo num repeticiones 
                RLEtmpData.Add(value) ' + valor
                repetition = 0 ' y pongo el contador de repeticiones a cero
                If position = data.Length - 2 Then ' si falta el ultimo valor
                    RLEtmpData.Add(1)
                    RLEtmpData.Add(data(data.Length - 1))
                End If
            End If
            position += 1
        Loop While (position < data.Length - 1)

        If repetition > 0 Then 'hay un valor que no se ha escrito
            RLEtmpData.Add(repetition + 1)
            RLEtmpData.Add(value)
        End If

        RLEtmpData.Add(0) ' marca de final (0)

        ReDim RLEoutputData(RLEtmpData.Count - 1)

        For i As Integer = 0 To RLEtmpData.Count - 1
            RLEoutputData(i) = RLEtmpData.Item(i)
        Next

        Return RLEoutputData


    End Function





    ''' <summary>
    ''' RLEWB encoder
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Compress_RLEWB(ByVal data() As Byte) As Byte()

        Dim RLEtmpData As New ArrayList
        Dim RLEtmpRaw As New ArrayList
        Dim isEnd As Boolean = False

        Dim num_rep As Byte = 0
        Dim num_raw As Byte = 0
        Dim code_pos As Integer = 0

        Dim position As Integer = 0
        Dim position2 As Integer = 0
        Dim value As Byte

        Do
            value = data(position)
            position2 = position + 1


            Do While position2 < data.Length AndAlso value = data(position2) And num_rep < 254
                num_rep += 1
                position2 += 1
            Loop

            If num_rep > 1 Then
                'only when they are more than 2 repetitions
                'two repeats are considered Raw. This way, 3 bytes are not wasted for two values.
                RLEtmpData.Add(RLEWB_CONTROL)
                RLEtmpData.Add(num_rep)
                RLEtmpData.Add(value)

                position = position2

            ElseIf num_rep = 1 And value = RLEWB_CONTROL Then
                ' When it is the case that the value of the Control Digit is repeated twice, we will use the repetition mechanism.
                ' 3 bytes are wasted instead of 4 (because "CD + 0" is executed twice).
                ' Improvement for the future versions: Use the value 1 in the same way as 0, to repeat the value of the Control Digit twice. Requires modifying the decoder.
                RLEtmpData.Add(RLEWB_CONTROL)
                RLEtmpData.Add(num_rep) '=1
                RLEtmpData.Add(RLEWB_CONTROL) 'delete this line for RLEWB v1.1

                position = position2
            Else
                ' write raw value
                If value = RLEWB_CONTROL Then
                    ' $80 , 0
                    RLEtmpData.Add(RLEWB_CONTROL)
                    RLEtmpData.Add(RLEWB_CODE_CDVAL)
                Else
                    ' raw
                    RLEtmpData.Add(value)
                End If
                position += 1
            End If

            num_rep = 0

        Loop While (position < data.Length)

        RLEtmpData.Add(RLEWB_CONTROL)
        RLEtmpData.Add(RLEWB_CODE_END) ' end mark

        Return RLEtmpData.ToArray(GetType(Byte))

    End Function


End Class
