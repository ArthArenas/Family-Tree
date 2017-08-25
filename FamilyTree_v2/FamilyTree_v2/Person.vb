Public Class Person
    'CONSTRUCTORS
    'New

    'This Is the constructor without parameters

    'Parameters:
    '    void
    'Returns:
    '    It's a contructor
    Public Sub New()
        Name = "UNKNOWN"
        FatherName = "UNKNOWN"
        MotherName = "UNKNOWN"
        FatherIndex = 0
        MotherIndex = 1
        IsAncestor = False
        Gender = "M"
    End Sub

    'CONSTRUCTORS
    'New

    'This Is the constructor with parameters

    'Parameters:
    '    String name2           This is the name of the person
    '    Integer FatherIndex2   Index of the father in the database
    '    Integer MotherIndex2   Index of the mother in the database
    '    String Gender2         Gender of the person (M/F)
    'Returns:
    '    It's a contructor
    Public Sub New(ByVal Name2 As String, ByVal FatherIndex2 As Integer, ByVal MotherIndex2 As Integer, ByVal Gender2 As String)
        Name = Name2
        FatherName = "UNKNOWN"
        MotherName = "UNKNOWN"
        FatherIndex = FatherIndex2
        MotherIndex = MotherIndex2
        IsAncestor = False
        Gender = Gender2
    End Sub

    'MEMBERS
    Public Name As String
    Public FatherName As String
    Public MotherName As String
    Public FatherIndex As Integer
    Public MotherIndex As Integer
    Public Gender As Char
    Public IsAncestor As Boolean
    Public Children As New ArrayList

    'MEMBER FUNCTIONS

    'getFullName

    'Retrieves the full name of the person, if he/she is an ancestor, then
    'we only display the last name only. Supports Mexican format of the name ONLY

    'Parameters:
    '   void
    'Returns:
    '   String FullName     Full name of the person
    Public Function getFullName() As String
        Dim FullName As String
        FullName = Name & " " & FatherName
        If IsAncestor = False Then
            FullName = FullName & " " & MotherName
        End If
        Return FullName
    End Function

    'AddChild

    'Adds a child by index from the database

    'Parameters:
    '   Integer i
    'Returns:
    '   void
    Public Sub AddChild(ByVal i As Integer)
        Children.Add(i)
    End Sub
End Class
