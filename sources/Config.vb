Imports System.Xml
Imports System.IO

Public Class Config


    Public Shadows Enum FIRST_PROJECT As Integer
        PRESENTATION
        NEWPROJECT
        LASTPROJECT
    End Enum



    'Public Shadows Enum PATH_TYPE As Integer
    '    APP
    '    LAST_USED
    '    USER
    'End Enum



    Private AppID As String = "tMSgfX"

    Private ConfigPath As String


    ' -----
    'Public PathItemProject As New PathItem
    'Public PathItemMap As New PathItem
    'Public PathItemTileset As New PathItem
    'Public PathItemPalette As New PathItem
    'Public PathItemSprite As New PathItem
    'Public PathItemOAM As New PathItem
    'Public PathItemSupertile As New PathItem

    'Public PathPicture As New PathItem

    'Public PathByteGen As New PathItem

    'Public PathItemMSXBASIC As New PathItem
    'Public PathItemBinary As New PathItem
    'Public PathItemBitmap As New PathItem
    'Public PathItemNMSXtiles As New PathItem
    ' -----



    Public Shadows Const def_Author As String = ""
    Public Shadows Const def_Group As String = ""

    Public Shadows Const def_CodeOutput As CodeInfo.Language_CODE = CodeInfo.Language_CODE.ASSEMBLER_default
    Public Shadows Const def_CodeNumberSystem As CodeInfo.DataType = CodeInfo.DataType.HEXADECIMAL_Snn
    Public Shadows Const def_CodeLineSize As Integer = 3      ' 0-6 (1,2,4,8,16,24,32)
    Public Shadows Const def_CodeCompressType As Integer = 0  ' RAW
    Public Shadows Const def_AsmDataByteCommand As String = "DB"
    Public Shadows Const def_AsmDataWordCommand As String = "DW"
    Public Shadows Const def_CdataType As String = "const char"
    Public Shadows Const def_DataLabel As String = "DATA"

    Public Shadows Const def_BASIC_CommentInstruction As String = "REM"
    Public Shadows Const def_BASIC_DataInstruction As String = "DATA"
    Public Shadows Const def_BASIC_initLine As Integer = 1000
    Public Shadows Const def_BASIC_incLines As Integer = 10
    Public Shadows Const def_BASIC_remove0 As Boolean = False

    Public Shadows def_Color_Zero As Color = Color.FromArgb(255, 40, 40, 55)
    Public Shadows def_Color_Grid As Color = Color.LightSkyBlue

    Public Shadows def_Color_OUTPUT_INK As Color = Color.Black
    Public Shadows def_Color_OUTPUT_BG As Color = Color.WhiteSmoke



    Public Color_Zero As Color
    Public Color_Grid As Color

    Public Color_OUTPUT_BG As Color
    Public Color_OUTPUT_INK As Color


    Public firstProjectType As FIRST_PROJECT = FIRST_PROJECT.NEWPROJECT

    Public PathLastProject As String = ""


    Public Author As String
    Public Group As String

    Public DataLabel As String

    Public CodeOutput As CodeInfo.Language_CODE
    Public CodeNumberSystem As Integer
    Private _CodeLineSize As Integer
    Public CodeCompressType As Integer

    Public AsmDataByteCommand As String
    Public AsmDataWordCommand As String

    Public CdataType As String

    Public BASIC_DataInstruction As String
    Public BASIC_CommentInstruction As String
    Public BASIC_initLine As Integer
    Public BASIC_incLines As Integer
    Public BASIC_remove0 As Boolean = False

    Private LastProjects As New Hashtable  'RecentProjectsList



    Public Shadows Const Extension_byteGEN As String = "XBYT"

    Public Shadows Const Extension_BINARY As String = "BIN"



    ' 0-3 (8,16,24,32)
    Public Property CodeLineSize() As Integer
        Get
            Return _CodeLineSize
        End Get
        Set(value As Integer)
            If value < 7 Then
                _CodeLineSize = value
            End If
        End Set
    End Property






    Public Sub New()
        Initialize()
    End Sub



    Public Sub New(ByVal appName As String) ', ByVal _appID As String
        Me.AppID = appName
        Initialize()
    End Sub



    Private Sub Initialize()
        Me.ConfigPath = Application.StartupPath + Path.DirectorySeparatorChar + Me.AppID + ".config"
        Me.Author = Environment.UserName   'My.User.Name

        InitOutputInfo()
    End Sub


    'Public Sub SetApplicationConfig(ByVal _appID As String)
    '    Me.AppID = _appID
    'End Sub


    Public Sub AddRecentProject(ByVal path As String, ByVal appID As String)

        If Not Me.LastProjects.ContainsKey(appID) Then
            Me.LastProjects.Add(appID, New LastProjectsList)
        End If

        'Dim projectsList As RecentProjectsList = Me.RecentProjects.Item(appID)
        Me.LastProjects.Item(appID).Add(path)

    End Sub



    Public Function GetRecentProjectList(ByVal appID As String) As LastProjectsList

        If Me.LastProjects.ContainsKey(appID) Then
            Return Me.LastProjects.Item(appID)
        Else
            Return Nothing
        End If

    End Function



    Public Function Load() As Boolean

        Dim result As Boolean = False

        Try
            Dim aXmlDoc As New XmlDocument
            Dim rootNode As XmlNode
            Dim groupNode As XmlNode
            Dim aNode As XmlNode
            'Dim subNode As XmlNode
            Dim aNodeList As XmlNodeList
            Dim subnodeList As XmlNodeList
            Dim aValue As String
            'Dim anotherValue As String

            'Dim projectsList As RecentProjectsList

            Dim tmpAppID As String
            Dim tmpRecentList As LastProjectsList

            Dim tmpList As SortedList
            Dim itemIndex As Integer

            'Dim ConfigFileAdress As String = Me.ConfigPath 'System.AppDomain.CurrentDomain.BaseDirectory + Me.ConfigFileName


            If System.IO.File.Exists(Me.ConfigPath) Then

                aXmlDoc.Load(Me.ConfigPath)

                rootNode = aXmlDoc.SelectSingleNode("config")
                If rootNode IsNot Nothing Then

                    Me.LastProjects.Clear()

                    '#####################################
                    'groupNode = rootNode.SelectSingleNode("paths")
                    'If Not groupNode Is Nothing Then
                    '    aNode = groupNode.SelectSingleNode("PathProject")
                    '    Me.PathItemProject = getPathItemFromNode(aNode)

                    '    aNode = groupNode.SelectSingleNode("PathMap")
                    '    Me.PathItemMap = getPathItemFromNode(aNode)

                    '    aNode = groupNode.SelectSingleNode("PathTileset")
                    '    Me.PathItemTileset = getPathItemFromNode(aNode)

                    '    aNode = groupNode.SelectSingleNode("PathSprite")
                    '    Me.PathItemSprite = getPathItemFromNode(aNode)

                    '    aNode = groupNode.SelectSingleNode("PathOAM")
                    '    Me.PathItemOAM = getPathItemFromNode(aNode)

                    '    aNode = groupNode.SelectSingleNode("PathSupertile")
                    '    Me.PathItemSupertile = getPathItemFromNode(aNode)

                    '    aNode = groupNode.SelectSingleNode("PathPicture")
                    '    Me.PathPicture = getPathItemFromNode(aNode)

                    '    aNode = groupNode.SelectSingleNode("PathByteGen")
                    '    Me.PathByteGen = getPathItemFromNode(aNode)

                    '    aNode = groupNode.SelectSingleNode("PathPalette")
                    '    Me.PathItemPalette = getPathItemFromNode(aNode)

                    '    aNode = groupNode.SelectSingleNode("PathMSXBasic")
                    '    Me.PathItemMSXBASIC = getPathItemFromNode(aNode)

                    '    aNode = groupNode.SelectSingleNode("PathBinary")
                    '    Me.PathItemBinary = getPathItemFromNode(aNode)

                    '    aNode = groupNode.SelectSingleNode("PathBitmap")
                    '    Me.PathItemBitmap = getPathItemFromNode(aNode)

                    '    aNode = groupNode.SelectSingleNode("PathNMSXtiles")
                    '    Me.PathItemNMSXtiles = getPathItemFromNode(aNode)
                    'End If
                    '#####################################


                    '#####################################
                    groupNode = rootNode.SelectSingleNode("Code")
                    If Not groupNode Is Nothing Then
                        aNode = groupNode.SelectSingleNode("DataLabel")
                        If aNode Is Nothing Then
                            Me.DataLabel = def_DataLabel
                        Else
                            Me.DataLabel = aNode.InnerText
                        End If

                        aNode = groupNode.SelectSingleNode("CodeOutput")
                        If aNode Is Nothing Then
                            Me.CodeOutput = def_CodeOutput
                        Else
                            Me.CodeOutput = CInt(aNode.InnerText)
                        End If

                        aNode = groupNode.SelectSingleNode("CodeNumberSystem")
                        If aNode Is Nothing Then
                            Me.CodeNumberSystem = def_CodeNumberSystem
                        Else
                            Me.CodeNumberSystem = CInt(aNode.InnerText)
                        End If

                        aNode = groupNode.SelectSingleNode("CodeLineSize")
                        If aNode Is Nothing Then
                            Me.CodeLineSize = def_CodeLineSize
                        Else
                            Me.CodeLineSize = CInt(aNode.InnerText)
                        End If

                        aNode = groupNode.SelectSingleNode("CodeCompressType")
                        If aNode Is Nothing Then
                            Me.CodeCompressType = def_CodeCompressType
                        Else
                            Me.CodeCompressType = CInt(aNode.InnerText)
                        End If

                        aNode = groupNode.SelectSingleNode("AsmDataByteCommand")
                        If aNode Is Nothing Then
                            Me.AsmDataByteCommand = def_AsmDataByteCommand
                        Else
                            Me.AsmDataByteCommand = aNode.InnerText
                        End If

                        aNode = groupNode.SelectSingleNode("AsmDataWordCommand")
                        If aNode Is Nothing Then
                            Me.AsmDataWordCommand = def_AsmDataWordCommand
                        Else
                            Me.AsmDataWordCommand = aNode.InnerText
                        End If

                        aNode = groupNode.SelectSingleNode("CdataType")
                        If aNode Is Nothing Then
                            Me.CdataType = def_CdataType
                        Else
                            Me.CdataType = aNode.InnerText
                        End If


                        aNode = groupNode.SelectSingleNode("BASICdataInstruction")
                        If aNode Is Nothing Then
                            Me.BASIC_DataInstruction = def_BASIC_DataInstruction
                        Else
                            Me.BASIC_DataInstruction = aNode.InnerText
                        End If

                        aNode = groupNode.SelectSingleNode("BASICcommentInstruction")
                        If aNode Is Nothing Then
                            Me.BASIC_CommentInstruction = def_BASIC_CommentInstruction
                        Else
                            Me.BASIC_CommentInstruction = aNode.InnerText
                        End If



                        aNode = groupNode.SelectSingleNode("BASICinitLine")
                        If aNode Is Nothing Then
                            Me.BASIC_initLine = def_BASIC_initLine
                        Else
                            Me.BASIC_initLine = CInt(aNode.InnerText)
                        End If

                        aNode = groupNode.SelectSingleNode("BASICincLines")
                        If aNode Is Nothing Then
                            Me.BASIC_incLines = def_BASIC_incLines
                        Else
                            Me.BASIC_incLines = CInt(aNode.InnerText)
                        End If

                        aNode = groupNode.SelectSingleNode("BASICremove0")
                        If aNode Is Nothing Then
                            Me.BASIC_remove0 = def_BASIC_remove0
                        Else
                            Me.BASIC_remove0 = CBool(aNode.InnerText.ToUpper = "TRUE")
                        End If
                    End If
                    '#####################################




                    '#####################################
                    groupNode = rootNode.SelectSingleNode("project")
                    If Not groupNode Is Nothing Then

                        aNode = groupNode.SelectSingleNode("author")
                        If aNode Is Nothing Then
                            Me.Author = def_Author
                        Else
                            Me.Author = aNode.InnerText
                        End If

                        aNode = groupNode.SelectSingleNode("group")
                        If aNode Is Nothing Then
                            Me.Group = def_Group
                        Else
                            Me.Group = aNode.InnerText
                        End If

                    End If


                    '#####################################
                    groupNode = rootNode.SelectSingleNode("misc")
                    If Not groupNode Is Nothing Then

                        aNode = groupNode.SelectSingleNode("firstProjectType")
                        If aNode Is Nothing Then
                            Me.firstProjectType = 0
                        Else
                            Me.firstProjectType = CInt(aNode.InnerText)
                        End If

                        aNode = groupNode.SelectSingleNode("PathLastProject")
                        If aNode Is Nothing Then
                            Me.PathLastProject = ""
                        Else
                            Me.PathLastProject = aNode.InnerText
                        End If

                        aNode = groupNode.SelectSingleNode("Color_Zero")
                        If aNode Is Nothing Then
                            Me.Color_Zero = def_Color_Zero
                        Else
                            Me.Color_Zero = Color.FromArgb(CInt(aNode.InnerText))
                        End If

                        aNode = groupNode.SelectSingleNode("Color_Grid")
                        If aNode Is Nothing Then
                            Me.Color_Grid = def_Color_Grid
                        Else
                            Me.Color_Grid = Color.FromArgb(CInt(aNode.InnerText))
                        End If


                        aNode = groupNode.SelectSingleNode("Color_OutBG")
                        If aNode Is Nothing Then
                            Me.Color_OUTPUT_BG = def_Color_OUTPUT_BG
                        Else
                            Me.Color_OUTPUT_BG = Color.FromArgb(CInt(aNode.InnerText))
                        End If

                        aNode = groupNode.SelectSingleNode("Color_OutINK")
                        If aNode Is Nothing Then
                            Me.Color_OUTPUT_INK = def_Color_OUTPUT_INK
                        Else
                            Me.Color_OUTPUT_INK = Color.FromArgb(CInt(aNode.InnerText))
                        End If

                    End If
                    '#####################################



                    '#####################################
                    aNodeList = rootNode.SelectNodes("LastProjects/list")
                    If aNodeList Is Nothing Then
                        'Me.RecentProjects = New RecentProjectsList

                    Else

                        For Each nodeList As XmlNode In aNodeList

                            aNode = nodeList.SelectSingleNode("@id")
                            If Not aNode Is Nothing Then
                                tmpAppID = aNode.InnerText
                                tmpList = New SortedList

                                subnodeList = nodeList.SelectNodes("item")
                                For Each aNodeItem As XmlNode In subnodeList
                                    aNode = aNodeItem.SelectSingleNode("@index")
                                    itemIndex = CInt(aNode.InnerText)
                                    'itemIndex = CInt(aNodeItem.Attributes.GetNamedItem("index").InnerText)

                                    aNode = aNodeItem.SelectSingleNode("@path")
                                    aValue = aNode.InnerText
                                    'aValue = aNodeItem.Attributes.GetNamedItem("path").InnerText

                                    tmpList.Add(itemIndex, aValue)
                                Next

                                tmpRecentList = New LastProjectsList(tmpList)
                                Me.LastProjects.Add(tmpAppID, tmpRecentList)

                            End If

                        Next

                    End If

                    result = True

                Else
                    result = False
                End If

            Else
                result = False
            End If


        Catch ex As Exception
            ' error! No se ha podido cargar la configuración
            result = False
        End Try

        'If result = False Then
        '    Me.PathItemProject = New PathItem  'Application.StartupPath System.AppDomain.CurrentDomain.BaseDirectory
        '    Me.PathItemMap = New PathItem
        '    Me.PathItemTileset = New PathItem
        '    Me.PathItemSprite = New PathItem
        '    Me.PathItemOAM = New PathItem
        '    Me.PathItemPalette = New PathItem
        '    Me.PathItemSupertile = New PathItem

        '    Me.PathPicture = New PathItem

        '    Me.PathByteGen = New PathItem

        '    Me.PathItemMSXBASIC = New PathItem
        '    Me.PathItemBinary = New PathItem
        '    Me.PathItemBitmap = New PathItem
        '    Me.PathItemNMSXtiles = New PathItem
        'End If

        'InitOutputInfo()

        Return result

    End Function



    'Private Function getPathItemFromNode(ByRef aNode As XmlNode) As PathItem

    '    Dim _pathItem As New PathItem

    '    Dim subNode As XmlNode

    '    Try

    '        If aNode Is Nothing Then
    '            _pathItem = New PathItem
    '        Else
    '            subNode = aNode.SelectSingleNode("@type")
    '            If subNode Is Nothing Then
    '                _pathItem.TypePath = PATH_TYPE.APP
    '            Else
    '                _pathItem.TypePath = CInt(subNode.InnerText)
    '                If _pathItem.TypePath > 1 Then
    '                    _pathItem.TypePath = PATH_TYPE.APP
    '                End If
    '            End If
    '            'Me.PathItemProject.Path = aNode.InnerText

    '            subNode = aNode.SelectSingleNode("@pathUser")
    '            If Not subNode Is Nothing Then
    '                '    _pathItem.pathUser = ""
    '                'Else
    '                _pathItem.pathUser = subNode.InnerText
    '            End If

    '            subNode = aNode.SelectSingleNode("@pathLast")
    '            If subNode Is Nothing Then
    '                _pathItem.pathLast = _pathItem.pathUser
    '            Else
    '                _pathItem.pathLast = subNode.InnerText
    '            End If
    '        End If

    '    Catch ex As Exception

    '    End Try

    '    Return _pathItem

    'End Function



    Public Sub Save()
        Try

            Dim aXmlDoc As New XmlDocument
            'Dim ConfigFileAdress As String = System.AppDomain.CurrentDomain.BaseDirectory + Me.ConfigFileName
            Dim rootElement As XmlElement
            Dim groupElement As XmlElement
            Dim txtElement As XmlText
            Dim anElement As XmlElement

            Dim anAttribute As XmlAttribute

            Dim aListElement As XmlElement
            Dim anItemElement As XmlElement

            Dim tmpList As LastProjectsList

            ' crea el nodo root
            rootElement = aXmlDoc.CreateElement("config")
            aXmlDoc.AppendChild(rootElement)

            anAttribute = aXmlDoc.CreateAttribute("app")
            anAttribute.Value = My.Application.Info.ProductName
            rootElement.SetAttributeNode(anAttribute)

            anAttribute = aXmlDoc.CreateAttribute("version")
            anAttribute.Value = My.Application.Info.Version.ToString + "b"
            rootElement.SetAttributeNode(anAttribute)



            ' ################################################### Project info
            groupElement = aXmlDoc.CreateElement("project")
            rootElement.AppendChild(groupElement)

            anElement = aXmlDoc.CreateElement("author")
            txtElement = aXmlDoc.CreateTextNode(Me.Author)
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("group")
            txtElement = aXmlDoc.CreateTextNode(Me.Group)
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)
            ' ###################################################


            ' ################################################### Miscellaneous Data
            groupElement = aXmlDoc.CreateElement("misc")
            rootElement.AppendChild(groupElement)

            anElement = aXmlDoc.CreateElement("firstProjectType")
            txtElement = aXmlDoc.CreateTextNode(CStr(Me.firstProjectType))
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("PathLastProject")
            txtElement = aXmlDoc.CreateTextNode(Me.PathLastProject)
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("Color_Zero")
            txtElement = aXmlDoc.CreateTextNode(CStr(Me.Color_Zero.ToArgb))
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("Color_Grid")
            txtElement = aXmlDoc.CreateTextNode(CStr(Me.Color_Grid.ToArgb))
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("Color_OutBG")
            txtElement = aXmlDoc.CreateTextNode(CStr(Me.Color_OUTPUT_BG.ToArgb))
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("Color_OutINK")
            txtElement = aXmlDoc.CreateTextNode(CStr(Me.Color_OUTPUT_INK.ToArgb))
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)
            ' ###################################################



            ' ###################################################
            'groupElement = aXmlDoc.CreateElement("paths")
            'rootElement.AppendChild(groupElement)

            'anElement = getElementPath(aXmlDoc, "PathProject", Me.PathItemProject)
            'groupElement.AppendChild(anElement)

            'anElement = getElementPath(aXmlDoc, "PathMap", Me.PathItemMap)
            'groupElement.AppendChild(anElement)

            'anElement = getElementPath(aXmlDoc, "PathTileset", Me.PathItemTileset)
            'groupElement.AppendChild(anElement)

            'anElement = getElementPath(aXmlDoc, "PathSprite", Me.PathItemSprite)
            'groupElement.AppendChild(anElement)

            'anElement = getElementPath(aXmlDoc, "PathOAM", Me.PathItemOAM)
            'groupElement.AppendChild(anElement)

            'anElement = getElementPath(aXmlDoc, "PathSupertile", Me.PathItemSupertile)
            'groupElement.AppendChild(anElement)

            'anElement = getElementPath(aXmlDoc, "PathPicture", Me.PathPicture)
            'groupElement.AppendChild(anElement)

            'anElement = getElementPath(aXmlDoc, "PathByteGen", Me.PathByteGen)
            'groupElement.AppendChild(anElement)

            'anElement = getElementPath(aXmlDoc, "PathPalette", Me.PathItemPalette)
            'groupElement.AppendChild(anElement)

            'anElement = getElementPath(aXmlDoc, "PathMSXBasic", Me.PathItemMSXBASIC)
            'groupElement.AppendChild(anElement)

            'anElement = getElementPath(aXmlDoc, "PathBinary", Me.PathItemBinary)
            'groupElement.AppendChild(anElement)

            'anElement = getElementPath(aXmlDoc, "PathBitmap", Me.PathItemBitmap)
            'groupElement.AppendChild(anElement)

            'anElement = getElementPath(aXmlDoc, "PathNMSXtiles", Me.PathItemNMSXtiles)
            'groupElement.AppendChild(anElement)
            ' ###################################################


            ' ###################################################
            groupElement = aXmlDoc.CreateElement("Code")
            rootElement.AppendChild(groupElement)

            anElement = aXmlDoc.CreateElement("DataLabel")
            txtElement = aXmlDoc.CreateTextNode(Me.DataLabel)
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("CodeOutput")
            txtElement = aXmlDoc.CreateTextNode(CStr(Me.CodeOutput))
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("CodeNumberSystem")
            txtElement = aXmlDoc.CreateTextNode(CStr(Me.CodeNumberSystem))
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("CodeLineSize")
            txtElement = aXmlDoc.CreateTextNode(CStr(Me.CodeLineSize))
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("CodeCompressType")
            txtElement = aXmlDoc.CreateTextNode(CStr(Me.CodeCompressType))
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("AsmDataByteCommand")
            txtElement = aXmlDoc.CreateTextNode(Me.AsmDataByteCommand)
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("AsmDataWordCommand")
            txtElement = aXmlDoc.CreateTextNode(Me.AsmDataWordCommand)
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("CdataType")
            txtElement = aXmlDoc.CreateTextNode(Me.CdataType)
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("BASICcommentInstruction")
            txtElement = aXmlDoc.CreateTextNode(Me.BASIC_CommentInstruction)
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("BASICdataInstruction")
            txtElement = aXmlDoc.CreateTextNode(Me.BASIC_DataInstruction)
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("BASICinitLine")
            txtElement = aXmlDoc.CreateTextNode(CStr(Me.BASIC_initLine))
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("BASICincLines")
            txtElement = aXmlDoc.CreateTextNode(CStr(Me.BASIC_incLines))
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)

            anElement = aXmlDoc.CreateElement("BASICremove0")
            txtElement = aXmlDoc.CreateTextNode(CStr(Me.BASIC_remove0))
            anElement.AppendChild(txtElement)
            groupElement.AppendChild(anElement)
            ' ###################################################



            ' ###################################################
            anElement = aXmlDoc.CreateElement("LastProjects")
            rootElement.AppendChild(anElement)


            For Each _appID As String In Me.LastProjects.Keys
                tmpList = Me.LastProjects.Item(_appID)

                aListElement = aXmlDoc.CreateElement("list")
                anElement.AppendChild(aListElement)

                anAttribute = aXmlDoc.CreateAttribute("id")
                anAttribute.Value = _appID
                aListElement.SetAttributeNode(anAttribute)

                For i As Integer = 0 To tmpList.Count - 1
                    anItemElement = aXmlDoc.CreateElement("item")
                    aListElement.AppendChild(anItemElement)

                    anAttribute = aXmlDoc.CreateAttribute("index")
                    anAttribute.Value = CStr(i)
                    anItemElement.SetAttributeNode(anAttribute)

                    anAttribute = aXmlDoc.CreateAttribute("path")
                    anAttribute.Value = tmpList.GetFileItem(i).Path
                    anItemElement.SetAttributeNode(anAttribute)
                Next
            Next

            '
            aXmlDoc.Save(Me.ConfigPath)


        Catch ex As Exception
            ' error! No se ha podido guardar la configuración
        End Try
    End Sub



    'Private Function getElementPath(ByRef aXmlDoc As XmlDocument, _name As String, ByVal _pathItem As PathItem) As XmlElement

    '    'Dim txtElement As XmlText
    '    Dim anElement As XmlElement
    '    Dim anAttribute As XmlAttribute

    '    anElement = aXmlDoc.CreateElement(_name)

    '    'If (Not _pathItem.TypePath = PathItem.PATH_TYPE.APP) Then
    '    'txtElement = aXmlDoc.CreateTextNode(_pathItem.Path)
    '    'anElement.AppendChild(txtElement)

    '    'If Not _pathItem.pathUser = Application.StartupPath Then
    '    anAttribute = aXmlDoc.CreateAttribute("pathUser")
    '    anAttribute.Value = CStr(_pathItem.pathUser)
    '    anElement.SetAttributeNode(anAttribute)
    '    'End If

    '    'If Not _pathItem.pathLast = Application.StartupPath Then
    '    anAttribute = aXmlDoc.CreateAttribute("pathLast")
    '    anAttribute.Value = CStr(_pathItem.pathLast)
    '    anElement.SetAttributeNode(anAttribute)
    '    'End If

    '    'End If
    '    'groupElement.AppendChild(anElement)
    '    anAttribute = aXmlDoc.CreateAttribute("type")
    '    anAttribute.Value = CStr(_pathItem.TypePath)
    '    anElement.SetAttributeNode(anAttribute)

    '    Return anElement

    'End Function



    Public Sub InitOutputInfo()

        Me.CodeOutput = def_CodeOutput
        Me.CodeNumberSystem = def_CodeNumberSystem
        Me.CodeLineSize = def_CodeLineSize
        Me.CodeCompressType = def_CodeCompressType

        Me.AsmDataByteCommand = def_AsmDataByteCommand
        Me.AsmDataWordCommand = def_AsmDataWordCommand

        Me.CdataType = def_CdataType

        Me.BASIC_DataInstruction = def_BASIC_DataInstruction
        Me.BASIC_CommentInstruction = def_BASIC_CommentInstruction
        Me.BASIC_initLine = def_BASIC_initLine
        Me.BASIC_incLines = def_BASIC_incLines
        Me.BASIC_remove0 = def_BASIC_remove0

        Me.Color_Zero = def_Color_Zero
        Me.Color_Grid = def_Color_Grid

        Me.Color_OUTPUT_BG = def_Color_OUTPUT_BG
        Me.Color_OUTPUT_INK = def_Color_OUTPUT_INK

        Me.DataLabel = def_DataLabel

    End Sub





End Class
