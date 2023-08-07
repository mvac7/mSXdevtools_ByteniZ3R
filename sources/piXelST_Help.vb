Imports System.Drawing.Imaging
Imports System.IO



''' <summary>
''' Control de Interfaz de Usuario para mostrar textos de ayuda en formato MarkDown y visualizado con estilo retro (ordenadores 8/16bits).
''' 
''' - PHUI0003 replace leading spaces with tabs
''' - definir colores en tags al inicio del doc?
''' - bug hay un excepcion al mostrar textos en bold dentro de las tablas, cuando se marca al final de la celda y hay un espacio despues.
''' 
''' MarkDown:
''' https://docs.github.com/es/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax
''' 
''' </summary>
Public Class piXelST_Help

    Public Event HelpExit()


    ' -----------------------------------------------------------
    Public Color_Background As Color
    Public Property Color_Background_Gradient As Color = Color.Indigo

    Public Color_Text As Color = Color.Gainsboro

    Public Color_Line As Color = Color.White

    Public Color_Table As Color = Color.White
    Public Color_Table_Tittle As Color = Color.White

    Public Color_Tittle1 As Color = Color.FromArgb(255, &HA0, &HE0, &HFF)
    Public Color_Tittle2 As Color = Color.LightSkyBlue
    Public Color_Tittle3 As Color = Color.DeepSkyBlue
    Public Color_Tittle4 As Color = Color.CornflowerBlue

    Public Color_List As Color = Color.Turquoise
    Public Color_NumericList As Color = Color.WhiteSmoke

    Public Color_Bold As Color = Color.Lime

    Public Color_Link As Color = Color.DodgerBlue

    Public Color_Code As Color = Color.ForestGreen  'DarkGreen
    Public Color_Code_Background As Color = Color.PaleGreen
    ' -----------------------------------------------------------

    Public is_BG_Gradient As Boolean = False


    Private State_Quoting As Boolean = False
    Private State_Code_Block As Boolean = False
    Private State_Bold As Boolean = False
    Private State_Link As Boolean = False


    Private Help_Lines As New ArrayList


    Private posX As Integer = 0
    Private posY As Integer = 0

    Private oneGraphic As Graphics
    Private tilesetBitmap As Bitmap

    Private _lastColor As Color = Color.White

    Private _columns As Integer



    Private Const HorizontalRule = "---"
    Private Const QuotingCode = "```"
    Private Const LineBreak = "<br/>"


    ' font character sizes
    'Private charSize As Byte() = {6, 3, 4, 6, 6, 7, 8, 4, 5, 5, 7, 7, 3, 6, 3, 8, 7, 4, 7, 6, 7, 7, 7, 7, 7, 7, 3, 3, 5, 5, 5, 7,
    '                              8, 7, 7, 6, 7, 7, 7, 7, 7, 3, 7, 7, 6, 8, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 7, 7, 4, 8, 4, 6, 7,
    '                              6, 7, 7, 6, 7, 7, 6, 7, 7, 3, 4, 7, 3, 8, 7, 7, 7, 7, 6, 6, 7, 7, 7, 8, 8, 7, 7, 6, 6, 6, 6, 6,
    '                              8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8}


    Public Enum COLUMN_ALIGN As Integer
        LEFT
        CENTER
        RIGHT
    End Enum


    Private Const piXel_font_SPACE = 128  '+ 28

    Private Const piXel_font_UPPER_LEFT_CORNER = 128 + 24
    Private Const piXel_font_UPPER_RIGHT_CORNER = 128 + 25
    Private Const piXel_font_LOWER_LEFT_CORNER = 128 + 26
    Private Const piXel_font_LOWER_RIGHT_CORNER = 128 + 27

    Private Const piXel_font_HORIZONTAL_LINE = 128 + 23
    Private Const piXel_font_VERTICAL_LINE = 128 + 22


    'Private Class piXel_Cell
    '    Public Text As String
    '    Public Align As COLUMN_ALIGN
    '    Public Size As Integer
    'End Class

    'Private Class piXel_TableLine
    '    Public Text As String
    '    Public multiline As Boolean = False

    '    Public Sub New(ByVal aText As String, ByVal aMultiline As Boolean)
    '        Me.Text = aText
    '        Me.multiline = aMultiline
    '    End Sub

    'End Class




    Public Property BackgroundGradient() As Boolean
        Set(value As Boolean)
            Me.is_BG_Gradient = value
        End Set
        Get
            Return Me.is_BG_Gradient
        End Get
    End Property








    Public Sub New()

        Me.BackColor = Color.SlateGray

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.tilesetBitmap = piXelS_font.Image

    End Sub



    Private Sub piXelHelp_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Color_Background = Me.BackColor

        HelpTextPanel.BackColor = Color.Transparent 'Me.BackColor  'Me.Color_Background
        HelpPictureBox.BackColor = Color.Transparent   'Me.Color_Background

        'AddHeaderInfo()
        '#If DEBUG Then
        '        Test_TextBox.Visible = True
        '#End If

        Me.BringToFront()

        If is_BG_Gradient Then
            ShowBGgradient()
        End If

        State_Code_Block = False

        Me._columns = CInt(Math.Floor((HelpTextPanel.Width - SystemInformation.VerticalScrollBarWidth) / 16))

        AddHandler MyBase.Resize, AddressOf piXelHelp_Resize

        'AddHandler Me.ParentForm.KeyDown, AddressOf piXelHelp_KeyDown   ' solution for when keyboard events are not collected in the usercontrol 

    End Sub



    Private Sub piXelHelp_Resize(sender As Object, e As EventArgs) 'Handles MyBase.Resize

        'System.Threading.Thread.Sleep(10)
        Application.DoEvents()

        Dim new_columns As Integer = CInt(Math.Floor((HelpTextPanel.Width - SystemInformation.VerticalScrollBarWidth) / 16))

        If new_columns < 40 Then
            Exit Sub
        End If


        'If is_BG_Gradient Then
        '    ShowBGgradient()
        'End If


        If Not new_columns = Me._columns Then
            Me._columns = new_columns
            RefreshHelp()
        End If

    End Sub



    Public Sub Initialice()
        Me.Location = New System.Drawing.Point(0, 0)
        'Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "piXelHelp"
        Me.Size = New System.Drawing.Size(80 * 16, 24 * 16)
        Me.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabIndex = 39
        Me.BackColor = Color.DimGray
        Me.BackgroundGradient = True
    End Sub



    Private Sub ShowBGgradient()
        Dim gradientBG As New Bitmap(1, Me.Height) 'Me.Width
        Dim newBrush As New Drawing.Drawing2D.LinearGradientBrush(New PointF(0, 0), New PointF(2, gradientBG.Height), Color_Background, Color_Background_Gradient)
        Dim oneGraphic As Graphics = Graphics.FromImage(gradientBG)
        oneGraphic.FillRectangle(newBrush, New RectangleF(0, 0, 2, gradientBG.Height)) 'gradientBG.Width
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = gradientBG
        'Me.Refresh()
    End Sub



    Private Sub Initialice_formsize(ByVal numLines As Integer)

        Dim bitmapHeight As Integer

        If Not tilesetBitmap Is Nothing Then

            If HelpTextPanel.Width = 0 Then
                Exit Sub 'when the window is minimized??
            End If

            'HelpTextPanel.BackColor = Me.Color_Background
            'HelpPictureBox.BackColor = Me.Color_Background

            Application.DoEvents()

            'Me._columns = new_columns 'CInt(Math.Floor(HelpTextPanel.Width / 16))

            bitmapHeight = numLines * 16  'GetHeight()

            If bitmapHeight < HelpTextPanel.Height Then
                HelpTextPanel.AutoScroll = False
                bitmapHeight = HelpTextPanel.Height
            Else
                HelpTextPanel.AutoScroll = True
            End If

            Me.HelpPictureBox.Size = New Size(HelpTextPanel.Width - SystemInformation.VerticalScrollBarWidth, bitmapHeight)

            Dim gradientBG = New Bitmap(HelpPictureBox.Width, HelpPictureBox.Height)
            oneGraphic = Graphics.FromImage(gradientBG)
            Me.HelpPictureBox.Image = gradientBG
        End If

    End Sub



    'Public Sub LoadText(ByVal filePath As String)

    '    Dim helpText As String

    '    If File.Exists(filePath) Then

    '        helpText = My.Computer.FileSystem.ReadAllText(filePath)
    '        SetHelpByText(helpText)

    '    End If

    'End Sub



    Public Sub SetHelpText(ByVal helpText As String)

        Dim aLine As String
        Dim commandLine As String
        Dim newLine As String
        Dim tmpLines As New ArrayList()

        Dim emptyLines As Integer = 0

        Dim firstWord As String


        Help_Lines.Clear()

        State_Code_Block = False

        tmpLines.AddRange(helpText.Trim.Split(vbCr))


        ' process lines
        aLine = ""
        For i As Integer = 0 To tmpLines.Count - 1

            newLine = CStr(tmpLines.Item(i))
            newLine = newLine.Replace(vbLf, "")
            commandLine = newLine.Trim
            'aLine += tmpLine

            'If commandLine.ToLower = LineBreak Or commandLine = "" Then

            'End If

            If commandLine = QuotingCode Then
                If Not aLine = "" Then
                    AddNewLine(aLine)
                End If
                AddNewLine(commandLine)
                emptyLines = 0
                aLine = ""
                State_Code_Block = Not State_Code_Block

            ElseIf State_Code_Block = True Then
                newLine = newLine.Replace(" ", Chr(piXel_font_SPACE))
                AddNewLine(newLine)
                emptyLines = 0
                aLine = ""
            Else

                If commandLine = "" Then

                    If Not aLine = "" Then
                        AddNewLine(aLine)
                        aLine = ""
                        emptyLines = 0
                    End If

                    If emptyLines = 0 Then
                        AddNewLine("")
                        emptyLines += 1
                    End If

                ElseIf commandLine.ToLower = LineBreak Then

                    AddNewLine("")

                ElseIf commandLine = HorizontalRule Or commandLine.StartsWith("#") Or commandLine.StartsWith("|") Then
                    ' 
                    If Not aLine = "" Then
                        AddNewLine(aLine)
                    End If

                    emptyLines = 0
                    AddNewLine(commandLine)
                    aLine = ""

                ElseIf commandLine.StartsWith("-") Or commandLine.StartsWith("*") Then
                    ' List
                    If Not aLine = "" Then
                        AddNewLine(aLine)
                    End If
                    aLine = newLine
                    emptyLines = 0

                ElseIf newLine.Contains(".") Then
                    'numbered list
                    firstWord = newLine.Substring(0, newLine.IndexOf("."))
                    If IsNumeric(firstWord) Then
                        If Not aLine = "" Then
                            AddNewLine(aLine)
                        End If
                        aLine = newLine
                        emptyLines = 0

                    Else
                        aLine += newLine
                        If newLine.EndsWith(".") Then
                            aLine += " "
                        End If
                    End If

                Else
                    'is a paragraph
                    aLine += newLine
                End If

            End If

        Next

        If aLine IsNot "" Then
            AddNewLine(aLine)
        End If

        RefreshHelp()

    End Sub



    'Private Sub AddHeaderInfo()
    '    AddNewLine("# Help from " + My.Application.Info.Title + " v" + My.Application.Info.Version.ToString + "-beta")
    '    AddNewLine("## " + My.Application.Info.Description)
    '    AddNewLine(HorizontalRule)
    'End Sub



    ''' <summary>
    ''' Displays the help text adapted to the size of the graphic control.
    ''' </summary>
    Public Sub RefreshHelp()

        Dim Doc_Lines As ArrayList

        Dim _TMP_doc As String = ""

        If Me.Help_Lines.Count = 0 Then
            Exit Sub
        End If

        Doc_Lines = GetDocLines(Me.Help_Lines, Me._columns)

        Initialice_formsize(Doc_Lines.Count)

        For Each aLine As String In Doc_Lines
            PrintLine(aLine)
            _TMP_doc += aLine + vbCrLf
        Next

    End Sub



    Public Sub AddRC()
        AddNewLine("")
    End Sub



    Public Sub AddNewLine(ByVal aLine As String)
        Dim newLine As String
        Dim CRposition As Integer


        If Not aLine.TrimStart.StartsWith("|") Then
            'This is processed only when it is not a line in a table

            ' ------------------- replace leading spaces with tabs - PHUI0003
            If aLine.StartsWith("      ") Then
                aLine = vbTab + vbTab + vbTab + aLine.Substring(6)
            ElseIf aLine.StartsWith("    ") Then
                aLine = vbTab + vbTab + aLine.Substring(4)
            ElseIf aLine.StartsWith("  ") Then
                aLine = vbTab + aLine.Substring(2)
            End If

            'Do While aLine.StartsWith("  ")
            '    aLine = vbTab + aLine.Substring(2)
            'Loop
            ' ----------------------------------------------------


            ' HTML Tag for Carriage Return
            If aLine.ToLower = LineBreak Then
                ' only one CR
                aLine = ""
            Else

                Do While aLine.ToLower.Contains(LineBreak)
                    ' contains one or more CRs embedded in a text
                    CRposition = aLine.ToLower.IndexOf(LineBreak)

                    newLine = aLine.Substring(0, CRposition)

                    Me.Help_Lines.Add(newLine)

                    aLine = aLine.Substring(CRposition + 5)

                Loop

            End If

        End If

        Me.Help_Lines.Add(aLine)

    End Sub



    ''' <summary>
    ''' Returns a list of lines with the size of the space of the area where the help is displayed
    ''' </summary>
    ''' <param name="help_width">Size in characters of the width of the visible area.</param>
    ''' <returns>Total number of lines</returns>
    Private Function GetDocLines(ByVal text_lines As ArrayList, ByVal help_width As Integer) As ArrayList

        Dim Doc_Lines As New ArrayList
        Dim Table_Lines As New ArrayList

        Dim Is_a_Table As Boolean = False

        State_Quoting = False
        State_Code_Block = False
        State_Bold = False
        State_Link = False

        posX = 0
        posY = 0

        Me._lastColor = Me.Color_Text

        For Each aLine As String In text_lines

            If aLine.TrimStart.StartsWith("|") Then
                If Not Is_a_Table Then
                    Is_a_Table = True
                    Table_Lines.Clear()
                End If
                Table_Lines.Add(aLine.TrimStart)
            Else
                If Is_a_Table Then
                    Is_a_Table = False
                    Doc_Lines.AddRange(GetTableLines(Table_Lines, help_width))
                End If

                If aLine.Trim = QuotingCode Then
                    State_Code_Block = Not State_Code_Block
                    Doc_Lines.Add(aLine.Trim)
                Else
                    If Not State_Code_Block Then
                        Doc_Lines.AddRange(GetLinesByWidth(aLine, help_width))
                    Else
                        Doc_Lines.AddRange(GetLinesCodeBlockByWidth(aLine, help_width))
                    End If
                End If

            End If
        Next

        If Is_a_Table Then
            Doc_Lines.AddRange(GetTableLines(Table_Lines, help_width))
        End If

        Return Doc_Lines

    End Function




    Private Function GetTableLines(ByRef Table_Lines As ArrayList, ByVal help_width As Integer) As ArrayList

        Dim Table_render As New ArrayList
        Dim cell_lines As ArrayList

        Dim n_line As Integer
        Dim n_column As Integer

        Dim column_align As COLUMN_ALIGN
        Dim column_size As Integer
        Dim _bigColumnIndex As Integer

        Dim TAGoffset As Integer
        Dim tmp_cell As String
        Dim tmp_cellLines As New ArrayList
        Dim formated_cellLines As New ArrayList
        Dim CRposition As Integer

        'Dim tmp_line As String

        Dim table_Columns As String()
        Dim aLine As String 'piXel_TableLine
        'Dim lineText As String
        Dim newLine As String
        Dim aCell As String

        Dim number_of_columns As Integer

        Dim col_sizes As New ArrayList
        Dim col_align As New ArrayList ' 0 - left, 1 - center, 2 - right

        Dim aling_line As String

        ' identifica el numero de columnas y el alineamiento de estas
        aling_line = Table_Lines.Item(1).Trim  'Text
        If aling_line.Contains(HorizontalRule) Then

            If aling_line.EndsWith("|") Then
                'delete the last table marker
                aling_line = aling_line.Substring(1, aling_line.Length - 2)
            End If

            table_Columns = aling_line.Trim.Split("|")

            number_of_columns = table_Columns.Length

            For Each a_column As String In table_Columns
                aCell = a_column.Trim

                If aCell.StartsWith(":---") Then
                    col_align.Add(COLUMN_ALIGN.LEFT) ' left

                ElseIf aCell.EndsWith("---:") Then
                    col_align.Add(COLUMN_ALIGN.RIGHT) ' right

                Else
                    col_align.Add(COLUMN_ALIGN.CENTER) ' center

                End If
            Next

            Table_Lines.RemoveAt(1)
        End If


        ' identifica los tamaños de las columnas
        For n_line = 0 To Table_Lines.Count - 1

            aLine = Table_Lines.Item(n_line).Trim
            'lineText = aLine.Trim 'Text

            If aLine.StartsWith("|") Then
                aLine = aLine.Substring(1, aLine.Length - 1)
            End If

            If aLine.EndsWith("|") Then
                aLine = aLine.Substring(0, aLine.Length - 1)
            End If

            Table_Lines(n_line) = aLine  'New piXel_TableLine(lineText, False)

            table_Columns = aLine.Trim.Split("|")

            For n_column = 0 To table_Columns.Length - 1
                aCell = table_Columns(n_column).Trim

                If aCell.ToLower.Contains(LineBreak) Then
                    tmp_cell = aCell.ToLower

                    tmp_cellLines.Clear()

                    ' contains one or more CRs embedded in a text
                    Do While tmp_cell.Contains(LineBreak)

                        CRposition = tmp_cell.IndexOf(LineBreak)

                        tmp_cellLines.Add(tmp_cell.Substring(0, CRposition))

                        tmp_cell = tmp_cell.Substring(CRposition + 5)

                    Loop
                    tmp_cellLines.Add(tmp_cell)

                    column_size = 0

                    For Each tmp_cell In tmp_cellLines
                        TAGoffset = GetTextOffset(tmp_cell)
                        If tmp_cell.Length - TAGoffset > column_size Then
                            column_size = tmp_cell.Length - TAGoffset
                        End If
                    Next

                Else
                    column_size = aCell.Length - GetTextOffset(aCell)
                End If

                If n_line = 0 Then
                    col_sizes.Add(column_size)
                ElseIf n_column < col_sizes.Count Then
                    If column_size > col_sizes.Item(n_column) Then
                        col_sizes.Item(n_column) = column_size
                    End If
                End If

            Next

        Next


        ' -----------------------------------------------------------------------------------------------
        'ajustar el valor de la columna más grande al resto de la suma de las otras con respecto al total
        '
        'add ajuste para cuando hay varias columnas con celdas cuyo contenido sobrepoasa el espacio de la tabla <<<<<<<<<<<<<<<<<<<<<<< OJO
        '
        column_size = 0
        For n_column = 0 To number_of_columns - 1
            column_size += col_sizes(n_column)
        Next

        If column_size > (help_width - (number_of_columns + 2)) Then
            column_size = 0
            For n_column = 0 To number_of_columns - 1
                If col_sizes(n_column) > column_size Then
                    _bigColumnIndex = n_column
                    column_size = col_sizes(n_column)
                End If
            Next

            column_size = 0
            For n_column = 0 To number_of_columns - 1
                If Not n_column = _bigColumnIndex Then
                    column_size += col_sizes(n_column) + 1  'añade un espacio para la linea de la celda
                End If
            Next

            col_sizes(_bigColumnIndex) = help_width - (column_size + 2)  ' ajusta el ancho de la columna más gruesa

        End If
        ' -----------------------------------------------------------------------------------------------



        ' -----------------------------------------------------------------------------------------------
        ' genera primera linea (marco):
        newLine = Chr(piXel_font_UPPER_LEFT_CORNER)
        For n_column = 0 To number_of_columns - 1
            column_size = col_sizes(n_column)
            newLine += Strings.StrDup(column_size, Chr(piXel_font_HORIZONTAL_LINE))
            If n_column < (number_of_columns - 1) Then
                newLine += Chr(128 + 18)
            End If
        Next
        newLine += Chr(piXel_font_UPPER_RIGHT_CORNER)
        Table_render.Add(newLine)


        ' -----------------------------------------------------------------------------------------------
        ' genera celdas de la tabla
        n_line = 0
        Do

            aLine = Table_Lines.Item(n_line)

            table_Columns = aLine.Trim.Split("|")  'Text

            tmp_cellLines.Clear()

            Dim line_cells(number_of_columns) As String

            For n_column = 0 To number_of_columns - 1

                'column_align = col_align(n_column)
                column_size = col_sizes(n_column)


                If (table_Columns.Length <= n_column) Then
                    line_cells(n_column) = ""
                    'aCell = ""
                Else
                    aCell = table_Columns(n_column).Trim

                    'procesar texto de la celda de la columna
                    cell_lines = GetLinesByWidth(aCell, column_size)

                    If cell_lines.Count > 1 Then
                        'preCells = ""
                        'postCells = ""

                        'For o = 0 To n_column - 1
                        '    'tmpCells += Strings.StrDup(col_sizes(o), Chr(piXel_font_SPACE)) + Chr(piXel_font_VERTICAL_LINE)
                        '    preCells += "|"
                        'Next

                        'For o = n_column + 1 To number_of_columns - 1
                        '    postCells += "|"
                        'Next

                        For numNewCell As Integer = 0 To cell_lines.Count - 1

                            If numNewCell < tmp_cellLines.Count Then

                                ' ###########################################################################################
                                ' insertar en la linea el texto
                                tmp_cellLines.Item(numNewCell)(n_column) = cell_lines.Item(numNewCell)


                                ' ###########################################################################################

                            Else

                                Dim new_line_cells(number_of_columns) As String

                                new_line_cells(n_column) = cell_lines.Item(numNewCell)

                                'aCell = preCells + cell_lines.Item(numNewCell) + postCells
                                'newLine += GetFormatCell(aCell, column_size, column_align) + Chr(piXel_font_VERTICAL_LINE)

                                tmp_cellLines.Add(new_line_cells)

                            End If

                            'Table_Lines.Insert(n_line + numNewCell, New piXel_TableLine(preCells + cell_lines.Item(numNewCell) + postCells, (numNewCell < cell_lines.Count - 1)))
                        Next

                        'aLine.multiline = True

                    Else

                        If tmp_cellLines.Count = 0 Then
                            line_cells(n_column) = cell_lines.Item(0)
                            tmp_cellLines.Add(line_cells)
                        Else
                            tmp_cellLines.Item(0)(n_column) = cell_lines.Item(0)
                        End If

                        'aCell = cell_lines.Item(0)
                        'newLine += GetFormatCell(aCell, column_size, column_align) + Chr(piXel_font_VERTICAL_LINE)
                        'tmp_cellLines.Add(newLine)
                    End If

                End If

            Next

            formated_cellLines.Clear()
            For Each _line_cells() As String In tmp_cellLines

                newLine = Chr(piXel_font_VERTICAL_LINE)

                For n_column = 0 To number_of_columns - 1
                    column_align = col_align(n_column)
                    column_size = col_sizes(n_column)

                    aCell = _line_cells(n_column)
                    If aCell Is Nothing Then
                        aCell = ""
                    End If

                    newLine += GetFormatCell(aCell, column_size, column_align) + Chr(piXel_font_VERTICAL_LINE)
                Next
                formated_cellLines.Add(newLine)
            Next



            Table_render.AddRange(formated_cellLines)

            ' add horizontal line
            If n_line < (Table_Lines.Count - 1) Then 'aLine.multiline = False And
                newLine = Chr(128 + 20)
                For n_column = 0 To number_of_columns - 1
                    column_size = col_sizes(n_column)
                    newLine += Strings.StrDup(column_size, Chr(piXel_font_HORIZONTAL_LINE))
                    If n_column < (number_of_columns - 1) Then
                        newLine += Chr(128 + 21)
                    End If
                Next
                newLine += Chr(128 + 19)
                Table_render.Add(newLine)

            End If

            n_line += 1 'tmp_cellLines.Count
        Loop While n_line < Table_Lines.Count


        ' last line
        newLine = Chr(piXel_font_LOWER_LEFT_CORNER)
        For n_column = 0 To number_of_columns - 1
            column_size = col_sizes(n_column)
            newLine += Strings.StrDup(column_size, Chr(piXel_font_HORIZONTAL_LINE))
            If n_column < (number_of_columns - 1) Then
                newLine += Chr(128 + 17)
            End If
        Next
        newLine += Chr(piXel_font_LOWER_RIGHT_CORNER)
        Table_render.Add(newLine)

        Table_Lines.Clear()

        Return Table_render

    End Function



    Private Function GetTextOffset(ByVal aText As String) As Integer
        Dim TAGoffset As Integer

        ' <<<----------------------------------------------------- << Extraer URLs de Imagenes

        Do While aText.Contains("[#") And aText.Contains("]")
            aText = aText.Remove(aText.IndexOf("[#"), 9)
            TAGoffset += 9
        Loop

        Do While aText.Contains("`")
            aText = aText.Remove(aText.IndexOf("`"), 1)
            TAGoffset += 1
        Loop

        Do While aText.Contains("**")
            aText = aText.Remove(aText.IndexOf("**"), 2)
            TAGoffset += 2
        Loop


        Return TAGoffset
    End Function




    ''' <summary>
    ''' Provides the text of a Line formatted, in one or several lines, depending on the size of the column.
    ''' </summary>
    ''' <param name="aLine"></param>
    ''' <param name="line_width"></param>
    ''' <returns></returns>
    Private Function GetLinesByWidth(ByVal aLine As String, ByVal line_width As Integer) As ArrayList

        Dim lines As New ArrayList

        Dim _posX As Integer

        Dim nchar As Integer

        Dim char16 As Char
        'Dim char16B As Char
        Dim char8 As Byte

        'Dim tmpWord As String
        Dim aWord As String
        Dim firstWord As String
        Dim wordsList As ArrayList

        Dim newLine As String
        Dim tmpLine As String

        Dim TAGoffset As Integer

        Dim posInitTAG As Integer
        Dim posEndTAG As Integer

        Dim RCmargin As Integer = 0

        Dim isWordWrap As Boolean = False


        State_Quoting = False
        State_Bold = False


        tmpLine = aLine.Trim
        If tmpLine = QuotingCode Or tmpLine = HorizontalRule Then
            lines.Add(tmpLine)
            Return lines
        End If



        ' image URL
        If aLine.Contains("![") Then
            posInitTAG = aLine.IndexOf("![")
            'posEndTAG = aText.IndexOf("](", posInitTAG)
            'aText = aText.Substring(0, posInitTAG) + "<image>" + aText.Substring(aText.IndexOf(")", posInitTAG + 2) + 1)
            'aText = aText.Substring(0, posInitTAG) + "<" + aText.Substring(posInitTAG + 2, posEndTAG - posInitTAG - 2) + ">" + aText.Substring(aText.IndexOf(")", posInitTAG) + 1)
            aLine = aLine.Substring(0, posInitTAG) + "" + aLine.Substring(aLine.IndexOf(")", posInitTAG + 2) + 1)

            If aLine = "" Then Return lines
        End If


        ' ---------------------------------------------------- for real line length calculate
        ' Link
        Do While aLine.Contains("](") And aLine.Contains("[")
            posEndTAG = aLine.IndexOf("](")
            posInitTAG = aLine.LastIndexOf("[", posEndTAG)
            aLine = aLine.Substring(0, posInitTAG) + GetColorTag(Color_Link) + aLine.Substring(posInitTAG + 1, posEndTAG - posInitTAG - 1) + GetColorTag(Color_Text) + " " + aLine.Substring(posEndTAG + 1)
            TAGoffset += 18    ' 9 (ColorTag) * 2       (19)???
        Loop
        ' ----------------------------------------------------


        'calculate offset by control characters -------------- 
        tmpLine = aLine
        Do While tmpLine.Contains("`")
            tmpLine = tmpLine.Remove(tmpLine.IndexOf("`"), 1)
            TAGoffset += 1
        Loop

        Do While tmpLine.Contains("**")
            tmpLine = tmpLine.Remove(tmpLine.IndexOf("**"), 2)
            TAGoffset += 2
        Loop
        ' ----------------------------------------------------


        If (aLine.Length - 1) <= (line_width + TAGoffset) And Not tmpLine.ToLower.Contains(LineBreak) Then

            ' ------------------------------------------------- <<< only one line
            lines.Add(aLine)
            ' ------------------------------------------------- <<<





        Else
            ' ------------------------------------------------- <<< there are several lines

            _posX = 0

            newLine = ""

            wordsList = GetSplitLineToWords(aLine)
            firstWord = wordsList.Item(0)


            Select Case firstWord

                Case "#"


                Case "##"


                Case "###"


                Case "####"


                Case "-", "*"  'List level 1

                    RCmargin = 1


                Case vbTab + "-", vbTab + "*" 'List level 2

                    RCmargin = 2


                Case vbTab + vbTab + "-", vbTab + vbTab + "*" 'List level 3

                    RCmargin = 3



            End Select

            If RCmargin > 0 Then
                _posX = (RCmargin - 1) * 2
            Else
                _posX = 0
            End If



            For i As Integer = 0 To wordsList.Count - 1

                aWord = wordsList.Item(i)

                If isWordWrap = True Then
                    If aWord = " " And newLine = "" Then
                        aWord = ""
                    End If
                    isWordWrap = False
                End If


                If Not aWord = "" Then

                    If aWord.StartsWith("[#") And aWord.EndsWith("]") Then
                        newLine += aWord
                        'TAGoffset += 9


                    ElseIf aWord = "`" Then
                        State_Quoting = Not State_Quoting
                        newLine += aWord
                        'TAGoffset += 1

                    ElseIf aWord = "**" Then

                        State_Bold = Not State_Bold
                        newLine += "**"
                        'TAGoffset -= 2

                        'ElseIf aWord = "```" Then

                        '    newLine += "```"
                        'TAGoffset -= 3

                    Else


                        If (_posX + aWord.Length) > line_width Then
                            ' --------------------------------------- << word wrap

                            newLine = newLine.TrimEnd

                            If Not newLine = "" Then
                                If State_Quoting Then
                                    newLine += "`"
                                ElseIf State_Bold Then
                                    newLine += "**"
                                End If

                                lines.Add(newLine)

                                isWordWrap = True
                                'Else
                                '    If aWord.Length > line_width Then
                                '        newLine = aWord.Substring(0, line_width)
                                '        lines.Add(newLine)
                                '        newLine = aWord.Substring(line_width)
                                '        lines.Add(newLine)
                                '    End If
                            End If



                            newLine = Strings.StrDup(RCmargin, vbTab)
                            _posX = RCmargin * 2

                            If State_Quoting Then
                                newLine += "`"
                                'TAGoffset += 1

                            ElseIf State_Bold Then
                                newLine += "**"
                                'TAGoffset += 2
                                'Else
                                '    newLine = ""
                            End If


                            If aWord = " " Then  '------ >> State_Code_Block ???
                                aWord = ""
                            End If

                        End If


                        If aWord = " " Then

                            newLine += " "
                            _posX += 1

                        Else

                            ' proces word
                            For nchar = 0 To aWord.Length - 1
                                char16 = aWord.Chars(nchar)
                                char8 = Asc(char16)
                                'If nchar < aWord.Length - 2 Then
                                '    char16B = aWord.Chars(nchar + 1)
                                'Else
                                '    char16B = ChrW(0)
                                'End If

                                'If char16 = "*" And nchar < aWord.Length - 1 Then
                                '    If aWord.Chars(nchar + 1) = "*" Then
                                '        State_Bold = Not State_Bold
                                '        TAGoffset -= 2
                                '        newLine += "**"
                                '        nchar += 1

                                '    End If

                                'Else

                                'If char16 = "`" Then
                                '    'TAGoffset -= 1
                                '    newLine += "`"

                                If char16 = vbCr Then
                                    '_posX = 0
                                    'TAGoffset = 0

                                    'newLine = newLine.Replace(" ", Chr(piXel_font_SPACE))
                                    newLine = newLine.TrimEnd

                                    If State_Quoting Then
                                        newLine += "`"
                                    ElseIf State_Bold Then
                                        newLine += "**"
                                    End If

                                    lines.Add(newLine)

                                    isWordWrap = True

                                    newLine = Strings.StrDup(RCmargin, vbTab)
                                    _posX = RCmargin * 2

                                    If State_Quoting Then
                                        newLine += "`"
                                        'TAGoffset += 1
                                    ElseIf State_Bold Then
                                        newLine += "**"
                                        'TAGoffset += 2
                                        'Else
                                        '    newLine = ""
                                    End If

                                ElseIf char16 = vbTab Then

                                    newLine += char16

                                    _posX += 2
                                    '_posX = CInt(Math.Floor(_posX / 2)) * 2


                                ElseIf char8 > 31 Then

                                    _posX += 1
                                    newLine += char16

                                    If _posX >= line_width Then
                                        '_posX = 0

                                        newLine = newLine.TrimEnd

                                        If State_Quoting Then
                                            newLine += "`"
                                        ElseIf State_Bold Then
                                            newLine += "**"
                                        End If

                                        lines.Add(newLine)

                                        isWordWrap = True

                                        newLine = Strings.StrDup(RCmargin, vbTab)
                                        _posX = RCmargin * 2

                                        If State_Quoting Then
                                            newLine += "`"
                                            'TAGoffset += 1
                                        ElseIf State_Bold Then
                                            newLine += "**"
                                            'TAGoffset += 2
                                            'Else
                                            '    newLine = ""
                                        End If
                                    End If

                                End If

                            Next


                            'If Not newLine = "" And Not newLine = "`" And Not newLine = "**" And i < (wordsList.Count - 1) Then

                            '    nextWord = wordsList.Item(i + 1)

                            '    If Not aWord = "`" And Not (State_Quoting And nextWord = "`") And Not nextWord = vbCr Then
                            '        _posX += 1
                            '        newLine += " "
                            '    End If

                            '    'If Not (State_Quoting And wordsList.Item(i + 1) = "`") Then
                            '    '    _posX += 1
                            '    '    newLine += " "
                            '    'End If

                            'End If


                        End If

                    End If

                End If


            Next


            If Not newLine = "" Then
                lines.Add(newLine)
            End If

        End If


        Return lines

    End Function


    Private Function GetLinesCodeBlockByWidth(ByVal aLine As String, ByVal line_width As Integer) As ArrayList

        Dim lines As New ArrayList
        Do While aLine.Length > line_width
            lines.Add(aLine.Substring(0, line_width))
            aLine = aLine.Substring(line_width)
        Loop
        lines.Add(aLine)

        'If aLine.Length > line_width Then
        '    lines.Add(aLine.Substring(0, line_width))
        '    aLine = aLine.Substring(line_width)
        'Else
        '    lines.Add(aLine)
        'End If

        Return lines

    End Function




    Private Function GetFormatCell(ByVal cellText As String, ByVal column_size As Integer, ByVal _align As COLUMN_ALIGN) As String

        Dim newCell As String '= ""
        Dim tmpCell As String = cellText

        Dim TAGoffset As Integer = 0

        ' add spaces for strings that are not displayed (tags)
        Do While tmpCell.Contains("[#") And tmpCell.Contains("]")
            tmpCell = tmpCell.Remove(tmpCell.IndexOf("[#"), 9)
            TAGoffset += 9
        Loop

        Do While tmpCell.Contains("`")
            tmpCell = tmpCell.Remove(tmpCell.IndexOf("`"), 1)
            TAGoffset += 1
        Loop

        Do While tmpCell.Contains("**")
            tmpCell = tmpCell.Remove(tmpCell.IndexOf("**"), 2)
            TAGoffset += 2
        Loop

        column_size += TAGoffset

        'If cellText.EndsWith("**") Then
        '    cellText += " "
        'End If

        'If cellText.Length >= column_size Then
        '    If cellText.EndsWith("** ") Then
        '        newCell = cellText.PadRight(column_size + 1, Chr(piXel_font_SPACE))
        '    Else
        '        newCell = cellText
        '    End If

        'Else

        If _align = COLUMN_ALIGN.LEFT Then
            newCell = cellText.PadRight(column_size, Chr(piXel_font_SPACE))
        ElseIf _align = COLUMN_ALIGN.RIGHT Then
            newCell = cellText.PadLeft(column_size, Chr(piXel_font_SPACE)) '<-- another space char
        Else
            ' CENTER
            If (cellText.Length - TAGoffset) < column_size Then
                cellText = Strings.StrDup(CInt(column_size / 2), Chr(piXel_font_SPACE)) + cellText + Strings.StrDup(CInt(column_size / 2), Chr(piXel_font_SPACE))
                newCell = cellText.Substring(CInt((cellText.Length - column_size) / 2), column_size)
            Else
                newCell = cellText
            End If
        End If


        'End If


        Return newCell

    End Function





    Private Sub PrintLine(ByVal aLine As String)

        Dim posInitTAG As Integer
        'Dim posEndTAG As Integer

        Dim RCmargin As Integer = 0
        Dim fixColor As Boolean = False

        Dim Color_Ink As Color = Me._lastColor
        Dim color_BG As Color = Color.Transparent

        Dim firstWord As String
        Dim aWord As String
        Dim nextWord As String
        Dim colorTag As String
        Dim wordsList As ArrayList

        'Dim tmpWord As String
        'Dim tmpWordsList As New ArrayList

        Dim TAGoffset As Integer = 0


        ' image URL
        'If aLine.Contains("![") Then
        '    posInitTAG = aLine.IndexOf("![")
        '    'posEndTAG = aLine.IndexOf("](", posInitTAG)
        '    'aLine = aLine.Substring(0, posInitTAG) + "<" + aLine.Substring(posInitTAG + 2, posEndTAG - posInitTAG - 2) + ">" + aLine.Substring(aLine.IndexOf(")", posInitTAG) + 1)
        '    aLine = aLine.Substring(0, posInitTAG) + "" + aLine.Substring(aLine.IndexOf(")", posInitTAG + 2) + 1)
        'End If

        ' Link
        If aLine.Contains("](") And aLine.Contains("[") Then
            State_Link = True
            aLine = aLine.Replace("](", "] (")
        Else
            State_Link = False
        End If


        'Dim isBold As Boolean = False

        'Do While aLine.Contains("**")
        '    isBold = Not isBold
        '    posInitTAG = aLine.IndexOf("**")

        '    If isBold Then
        '        colorTag = GetColorTag(Color_Bold)
        '    Else
        '        colorTag = GetColorTag(Me._lastColor)
        '    End If

        '    aLine = aLine.Substring(0, posInitTAG) + colorTag + aLine.Substring(posInitTAG + 2)

        'Loop

        wordsList = GetSplitLineToWords(aLine)

        firstWord = wordsList.Item(0)

        If State_Code_Block And Not firstWord = QuotingCode Then
            AddCodeBlockLine()
        End If



        If firstWord.EndsWith(".") Then
            'aWord = aWord.Substring(0, aWord.Length - 1)
            If IsNumeric(firstWord) Then
                PrintWord(firstWord, Color_NumericList, color_BG) 'aWord.PadLeft(2, " ") + "."
                wordsList.RemoveAt(0)
            End If

        Else

            Select Case firstWord

                Case "#"
                    fixColor = True
                    Color_Ink = Color_Tittle1
                    color_BG = Color.Transparent
                    wordsList.RemoveAt(0)
                    If posX > 0 And wordsList.Count > 0 Then
                        posX = 0
                    End If

                Case "##"
                    fixColor = True
                    Color_Ink = Color_Tittle2
                    color_BG = Color.Transparent
                    wordsList.RemoveAt(0)
                    If posX > 0 And wordsList.Count > 0 Then
                        posX = 0
                    End If

                Case "###"
                    fixColor = True
                    Color_Ink = Color_Tittle3
                    color_BG = Color.Transparent
                    wordsList.RemoveAt(0)
                    If posX > 0 And wordsList.Count > 0 Then
                        posX = 0
                    End If

                Case "####"
                    fixColor = True
                    Color_Ink = Color_Tittle4
                    color_BG = Color.Transparent
                    wordsList.RemoveAt(0)
                    If posX > 0 And wordsList.Count > 0 Then
                        posX = 0
                    End If

                Case "-", "*"  'List level 1
                    PrintWord(Chr(129), Color_List, Color.Transparent)
                    wordsList.RemoveAt(0)
                    RCmargin = 1

                Case vbTab + "-", vbTab + "*" 'List level 2
                    PrintWord(vbTab + Chr(130), Color_List, Color.Transparent)
                    wordsList.RemoveAt(0)
                    RCmargin = 2

                Case vbTab + vbTab + "-", vbTab + vbTab + "*" 'List level 3
                    PrintWord(vbTab + vbTab + Chr(131), Color_List, Color.Transparent)
                    wordsList.RemoveAt(0)
                    RCmargin = 3

                Case HorizontalRule '+ Chr(13)
                    PrintWord(Strings.StrDup(Me._columns, "-") + Chr(13), Color_Line, Color.Transparent)
                    wordsList.RemoveAt(0)

                Case QuotingCode '+ Chr(13)  'code block
                    State_Code_Block = Not State_Code_Block
                    'wordsList.RemoveAt(0)
                    Exit Sub

            End Select

        End If



        'For i As Integer = 0 To wordsList.Count - 1

        '    tmpWord = wordsList.Item(i)

        '    tmpWordsList.Clear()

        '    'separa comandos de color dentro de un word
        '    If tmpWord.Contains("[#") And tmpWord.Contains("]") Then

        '        Do While tmpWord.Contains("[#") And tmpWord.Contains("]")

        '            If tmpWord.IndexOf("[#") > 0 Then
        '                aWord = tmpWord.Substring(0, tmpWord.IndexOf("[#"))
        '                tmpWordsList.Add(aWord)
        '                tmpWord = tmpWord.Remove(0, tmpWord.IndexOf("[#"))
        '            End If

        '            aWord = tmpWord.Substring(0, 9)
        '            tmpWordsList.Add(aWord)
        '            tmpWord = tmpWord.Remove(0, 9)

        '        Loop

        '    End If

        '    If Not tmpWord = "" Then
        '        tmpWordsList.Add(tmpWord)
        '    End If



        'For Each aWord In wordsList
        For i As Integer = 0 To wordsList.Count - 1

            aWord = wordsList.Item(i)

            If aWord = " " Then

                If State_Quoting And Not State_Code_Block Then
                    AddSpaceChar()
                End If

                posX += 1 'add space char

            ElseIf aWord = "`" Then

                State_Quoting = Not State_Quoting

            ElseIf aWord.StartsWith("[#") Then

                colorTag = aWord.Substring(aWord.IndexOf("[#"), 9)
                'aWord = aWord.Replace(colorTag, "")

                Me._lastColor = GetColorFromTag(colorTag)
                Color_Ink = Me._lastColor


            Else

                If aWord.StartsWith("**") Then
                    State_Bold = Not State_Bold
                    aWord = aWord.Substring(2)
                End If

                If Not fixColor Then
                    If State_Quoting Or State_Code_Block Then
                        Color_Ink = Color_Code
                        color_BG = Color_Code_Background
                    ElseIf State_Link Then
                        Color_Ink = Color_Link
                    ElseIf State_Bold Then
                        Color_Ink = Color_Bold
                    Else
                        Color_Ink = Me._lastColor
                        color_BG = Color.Transparent
                    End If
                End If

                If aWord.EndsWith("**") Then
                    State_Bold = Not State_Bold
                    aWord = aWord.Substring(0, aWord.Length - 2)
                End If

                ' ---------------------------------------------------- LINK
                If State_Link Then
                    Color_Ink = Color_Link
                    If aWord.StartsWith("[") Then
                        aWord = aWord.Substring(1, aWord.Length - 1)
                    End If
                End If

                If State_Link And aWord.EndsWith("]") Then
                    aWord = aWord.Remove(aWord.IndexOf("]"), 1)
                    'Color_Ink = Color_Link
                    State_Link = False
                End If
                ' ---------------------------------------------------- END LINK

                'If (posX + aWord.Length) > Me._columns + TAGoffset Then ' * 16 > HelpPictureBox.Width Then
                '    posX = (RCmargin * 2)  'margen izq. 
                '    posY += 1
                '    If State_Code_Block Then
                '        AddCodeBlockLine()
                '    End If

                'End If

                PrintWord(aWord, Color_Ink, color_BG)


                If i < (wordsList.Count - 1) Then

                    nextWord = wordsList.Item(i + 1)

                    If Not aWord = Chr(piXel_font_VERTICAL_LINE) And Not nextWord = Chr(piXel_font_VERTICAL_LINE) Then
                        If posX + 1 > Me._columns Then
                            posX = (RCmargin * 2)
                            posY += 1
                            If State_Code_Block Then
                                AddCodeBlockLine()
                            End If


                        Else

                            'If Not (State_Quoting And nextWord = "`") Then

                            '    If State_Quoting And Not State_Code_Block Then
                            '        AddSpaceChar()
                            '        posX += 1 'add space char
                            '    End If

                            'End If

                        End If

                    End If

                End If

            End If

        Next

        posX = 0
        posY += 1

    End Sub



    Private Sub PrintWord(ByVal aWord As String, ByVal inkColor As Color, ByVal backgroundColor As Color)

        Dim charX As Short
        Dim charY As Short

        Dim char16 As Char
        Dim char8 As Byte

        Dim imageAttributes As ImageAttributes
        Dim tmp_imgAttributes As ImageAttributes


        If Not aWord = "" Then

            imageAttributes = GetAttributeColors(inkColor, backgroundColor)

            ' proces word
            For i = 0 To aWord.Length - 1
                char16 = aWord.Chars(i)
                char8 = Asc(char16)

                If char16 = vbTab Then
                    posX += 2
                    posX = CInt(Math.Floor(posX / 2)) * 2

                    'ElseIf char16 = "`" Then

                    '    State_Quoting = Not State_Quoting

                    '    If State_Quoting Then
                    '        imageAttributes = GetAttributeColors(Color_Code, Color_Code_Background)
                    '    Else
                    '        imageAttributes = GetAttributeColors(Me._lastColor, Color.Transparent)
                    '    End If

                    'Test_TextBox.Text += vbTab

                ElseIf char8 > 31 Then

                    If char8 > 144 And char8 < 156 Then
                        ' color table tiles
                        tmp_imgAttributes = GetAttributeColors(Me.Color_Table, Color.Transparent)
                    Else
                        tmp_imgAttributes = imageAttributes
                    End If

                    char8 -= 32
                    charY = Fix(char8 / 32)
                    charX = char8 - (charY * 32)
                    oneGraphic.DrawImage(tilesetBitmap, New Rectangle(posX * 16, posY * 16, 16, 16), charX * 16, charY * 16, 16, 16, GraphicsUnit.Pixel, tmp_imgAttributes)
                    'oneGraphic.Flush()
                    posX += 1

                    'Test_TextBox.Text += char16

                End If

                If i < (aWord.Length - 1) Then
                    If posX > Me._columns Then
                        posX = 0
                        posY += 1
                        If State_Code_Block Then
                            AddCodeBlockLine()
                        End If

                        'Test_TextBox.Text += vbCrLf

                    End If
                End If

            Next

        End If

    End Sub




    Private Function GetSplitLineToWords(ByVal aLine As String) As ArrayList

        Dim wordsList As New ArrayList

        Dim tmpLine As String

        Dim char16 As Char
        Dim char16B As Char
        Dim char16C As Char
        Dim command2 As String
        Dim command3 As String

        'Dim RCmargin As Integer

        Dim aWord As String = ""

        Dim firstword As String '= aLine.TrimStart


        If Not aLine = "" Then

            If aLine = QuotingCode Or aLine = HorizontalRule Then

                wordsList.Add(aLine)



            Else

                If aLine.Contains(LineBreak) Then
                    aLine = aLine.Replace(LineBreak, vbCr)
                End If

                If aLine.Contains(LineBreak) Then
                    aLine = aLine.Replace(LineBreak, vbCr)
                End If

                ' -------------------------------------------------------- <<< check if the first word is a tag (titles or lists)
                If aLine.TrimStart.Contains(" ") Then

                    tmpLine = aLine.TrimStart
                    tmpLine = tmpLine.Substring(tmpLine.IndexOf(" "))
                    tmpLine = tmpLine.TrimStart

                    firstword = aLine.Substring(0, aLine.IndexOf(" "))

                    Select Case firstword

                        Case "#"
                            wordsList.Add(firstword)
                            aLine = tmpLine

                        Case "##"
                            wordsList.Add(firstword)
                            aLine = tmpLine

                        Case "###"
                            wordsList.Add(firstword)
                            aLine = tmpLine

                        Case "####"
                            wordsList.Add(firstword)
                            aLine = tmpLine

                        Case "-", "*"  'List level 1
                            wordsList.Add(firstword)
                            wordsList.Add(" ")
                            aLine = tmpLine

                        Case vbTab + "-", vbTab + "*" 'List level 2
                            wordsList.Add(firstword)
                            wordsList.Add(" ")
                            aLine = tmpLine

                        Case vbTab + vbTab + "-", vbTab + vbTab + "*" 'List level 3
                            wordsList.Add(firstword)
                            wordsList.Add(" ")
                            aLine = tmpLine

                            'Case QuotingCode
                            '    wordsList.Add(firstword)
                            '    aLine = tmpLine

                    End Select
                End If


                For i = 0 To aLine.Length - 1
                    char16 = aLine.Chars(i)
                    If i < aLine.Length - 1 Then
                        char16B = aLine.Chars(i + 1)
                    Else
                        char16B = ""
                    End If
                    If i < aLine.Length - 2 Then
                        char16C = aLine.Chars(i + 2)
                    Else
                        char16C = ""
                    End If
                    command2 = char16 + char16B
                    command3 = command2 + char16C

                    If char16 = " " Then

                        If char16B = " " Then
                            Do
                                i += 1
                            Loop While (i < (aLine.Length - 1) And aLine.Chars(i) = " ")
                        End If

                        If Not aWord = "" Then
                            wordsList.Add(aWord)
                            aWord = ""
                        End If
                        'aWord = ""
                        wordsList.Add(" ")


                    ElseIf command2 = "**" Then 'char16 = "*" And char16B = "*" Then
                        If Not aWord = "" Then
                            wordsList.Add(aWord)
                            aWord = ""
                        End If
                        wordsList.Add("**")
                        i += 1

                        'If aWord = "" Then
                        '    aWord = "**"
                        '    i += 1
                        'Else
                        '    wordsList.Add(aWord + "**")
                        '    'wordsList.Add("**")
                        '    aWord = ""
                        '    i += 1
                        'End If

                        'ElseIf command3 = QuotingCode Then  '"```"
                        '    If Not aWord = "" Then
                        '        wordsList.Add(aWord)
                        '        aWord = ""
                        '    End If
                        '    wordsList.Add(QuotingCode)
                        '    i += 2

                    ElseIf char16 = Chr(piXel_font_VERTICAL_LINE) Or char16 = vbCr Or char16 = "`" Then

                        ' ------------------------------------------- <<< special chars
                        If Not aWord = "" Then
                            wordsList.Add(aWord)
                            aWord = ""
                        End If
                        wordsList.Add(char16)


                    ElseIf char16 = "[" And char16B = "#" Then

                        ' ------------------------------------------- <<< color TAG 
                        If aLine.IndexOf("]", i) > -1 Then
                            If Not aWord = "" Then
                                wordsList.Add(aWord)
                            End If
                            aWord = aLine.Substring(i, 9)
                            wordsList.Add(aWord)
                            aWord = ""
                            i += 8
                        End If

                    Else
                        aWord += char16
                    End If

                Next

                If Not aWord = "" Then
                    wordsList.Add(aWord)
                End If



            End If

        Else

            wordsList.Add(vbCr)

        End If


        'If wordsList.Count = 0 Then
        '    wordsList.Add("")
        'End If

        Return wordsList

    End Function




    Private Function GetAttributeColors(ByVal inkColor As Color, ByVal BGcolor As Color) As ImageAttributes

        Dim imageAttributes = New ImageAttributes()
        Dim colorItem = New ColorMap()
        Dim colorBG = New ColorMap()
        Dim remapTable(1) As ColorMap

        colorItem.OldColor = Color.FromArgb(255, 255, 255, 255)
        colorItem.NewColor = inkColor
        remapTable(0) = colorItem

        colorBG.OldColor = Color.FromArgb(0, 255, 255, 255) 'transparent background color in bitmap
        colorBG.NewColor = BGcolor
        remapTable(1) = colorBG

        imageAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap)

        Return imageAttributes

    End Function



    Public Function GetColorTag(ByVal aColor As Color) As String

        Dim outputTAG As String = "[#"

        outputTAG += Hex(aColor.R).PadLeft(2, "0"c) ' Red
        outputTAG += Hex(aColor.G).PadLeft(2, "0"c) ' Green
        outputTAG += Hex(aColor.B).PadLeft(2, "0"c) ' Blue

        Return outputTAG + "]" 'add a space to render as a word 

    End Function



    Public Function GetColorFromTag(ByVal colorTag As String) As Color

        Dim RGBvalues(2) As Integer

        colorTag = colorTag.Substring(2, 6)

        For item As Integer = 0 To 2
            RGBvalues(item) = Integer.Parse((colorTag.Substring(item * 2, 2)), System.Globalization.NumberStyles.HexNumber)
        Next

        return  Color.FromArgb(RGBvalues(0), RGBvalues(1), RGBvalues(2))

    End Function



    Private Sub AddSpaceChar()
        oneGraphic.FillRectangle(New Drawing.SolidBrush(Color_Code_Background), New Rectangle(posX * 16, posY * 16, 16, 16))
        oneGraphic.Flush()
    End Sub



    Private Sub AddCodeBlockLine()
        oneGraphic.FillRectangle(New Drawing.SolidBrush(Color_Code_Background), New Rectangle(0, posY * 16, Me._columns * 16, 16))
        oneGraphic.Flush()
    End Sub



End Class
