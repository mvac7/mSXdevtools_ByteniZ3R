''' <summary>
''' Clase para controlar la lista de proyectos recientes
''' </summary>
''' <remarks></remarks>
Public Class LastProjectsList



    ''' <summary>
    ''' Item for list of recent projects
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ProjectFileItem

        Public Sub New(ByVal aName As String, ByVal aPath As String)
            Me.Name = aName
            Me.Path = aPath
        End Sub


        ''' <summary>
        ''' File Name
        ''' </summary>
        ''' <returns></returns>
        Public Property Name() As String


        ''' <summary>
        ''' Path
        ''' </summary>
        ''' <returns></returns>
        Public Property Path() As String



        Public Function Clone() As ProjectFileItem
            Dim tmpFileItem As New ProjectFileItem(Me.Name, Me.Path)
            Return tmpFileItem
        End Function

    End Class



    Private IndexList As New ArrayList
    Private Items As New Hashtable


    Public ReadOnly Property Count()
        Get
            Return IndexList.Count
        End Get
    End Property


    Public Sub New()

    End Sub


    Public Sub New(ByVal list As SortedList)
        For Each path As String In list.Values
            AddOrdered(path)
        Next
    End Sub


    ''' <summary>
    ''' Añade un item al final de la lista.
    ''' </summary>
    ''' <param name="path"></param>
    ''' <remarks></remarks>
    Private Sub AddOrdered(ByVal path As String)
        Dim name As String
        name = System.IO.Path.GetFileName(path)

        If Not name = "" And Not Me.Items.ContainsKey(name) Then
            Me.IndexList.Add(name)
            Me.Items.Add(name, New ProjectFileItem(name, path))
        End If

    End Sub


    ''' <summary>
    ''' Añade un item al principio de la lista a partir de la ruta absoluta. 
    ''' Utiliza el nombre de fichero con su extensión, como nombre del item.
    ''' </summary>
    ''' <param name="path"></param>
    ''' <remarks></remarks>
    Public Sub Add(ByVal path As String)
        Dim name As String

        If Not path = "" Then
            name = System.IO.Path.GetFileName(path)
            Me.Add(name, path)
        End If

    End Sub


    ''' <summary>
    ''' Añade un item al principio de la lista.
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="path"></param>
    ''' <remarks></remarks>
    Private Sub Add(ByVal name As String, ByVal path As String)

        If Me.Items.ContainsKey(name) Then
            ' si ya contiene el fichero, lo elimina de la lista para que aparezca en primera posicion
            Me.IndexList.Remove(name)
            Me.Items.Remove(name)
        End If

        Me.IndexList.Insert(0, name)
        Me.Items.Add(name, New ProjectFileItem(name, path))

        If Me.IndexList.Count > 10 Then
            name = Me.IndexList(10)
            Me.IndexList.Remove(name)
            Me.Items.Remove(name)
        End If

    End Sub



    ''' <summary>
    ''' Checks if the paths in the list exist.
    ''' </summary>
    Public Sub Refresh()

        Dim tmpItem As ProjectFileItem

        Dim tmpList() As String


        If Me.Items.Count < 1 Then
            Return
        End If

        ReDim tmpList(Me.Items.Count - 1)

        Me.Items.Keys.CopyTo(tmpList, 0)

        For Each nameItem As String In tmpList

            tmpItem = Me.Items.Item(nameItem)

            If Not System.IO.File.Exists(tmpItem.Path) Then
                Me.Items.Remove(tmpItem.Name)
                Me.IndexList.Remove(tmpItem.Name)
            End If

        Next

    End Sub



    Public Function GetFileItem(ByVal index As Integer) As ProjectFileItem
        Return Me.Items.Item(Me.IndexList(index))
    End Function



    Public Sub clear()
        Me.IndexList.Clear()
        Me.MemberwiseClone.Items.Clear()
    End Sub


End Class
