Imports System.IO
Public Class Form1

    'MEMBERS
    Private currentIndex As Integer
    Private population As Integer
    Private tree(1) As Person
    Private adminKey As Boolean = False

    'MEMBER FUNCTIONS
    'manageOption

    'Given an index, we manage the display of pictures and names

    'Parameters:
    '   Integer i   Index of the person from the data base
    'Returns:
    '   void
    Private Sub manageOption(ByVal i As Integer)
        Label1.Text = "ID: " & i.ToString() 'Helps the developer to check indices from the database
        'Reset components
        cboxChildren.Items.Clear()
        'Load the pictures
        loadPictures(i)
        'If the admin is logged in, then we must enable the addition and deletion buttons
        If adminKey = True Then
            buttonAddMember.Enabled = True
            buttonAddMember.Visible = True
            buttonAddSideMember.Enabled = True
            buttonAddSideMember.Visible = True
        End If
        'Set the right name
        labelName.Text = tree(i).getFullName()
        'Navigation buttons are displayed depending on the category of the person (ancestor, non-parent or parent that is not an ancestor)
        If tree(i).Children.Count = 0 Then
            cboxChildren.Visible = False
            cboxChildren.Enabled = False
            labelFather.Text = "Father: " & tree(tree(i).FatherIndex).getFullName()
            labelMother.Text = "Mother: " & tree(tree(i).MotherIndex).getFullName()
            buttonChild.Enabled = False
            buttonFather.Enabled = True
            buttonMother.Enabled = True
        ElseIf tree(i).IsAncestor Then
            cboxChildren.Visible = True
            cboxChildren.Enabled = True
            cboxChildren.Text = tree(tree(i).Children(0)).getFullName()
            For j As Integer = 0 To tree(i).Children.Count - 1
                cboxChildren.Items.Add(tree(CType(tree(i).Children(j).ToString(), Integer)).getFullName())
            Next
            labelFather.Text = "Father: Unknown"
            labelMother.Text = "Mother: Unknown"
            buttonChild.Enabled = True
            buttonFather.Enabled = False
            buttonMother.Enabled = False
        Else
            cboxChildren.Visible = True
            cboxChildren.Enabled = True
            cboxChildren.Text = tree(tree(i).Children(0)).getFullName()
            For j As Integer = 0 To tree(i).Children.Count - 1
                cboxChildren.Items.Add(tree(CType(tree(i).Children(j).ToString(), Integer)).getFullName())
            Next
            labelFather.Text = "Father: " & tree(tree(i).FatherIndex).getFullName()
            labelMother.Text = "Mother: " & tree(tree(i).MotherIndex).getFullName()
            buttonChild.Enabled = True
            buttonFather.Enabled = True
            buttonMother.Enabled = True
        End If
    End Sub

    'loadTree

    'Load the family tree from the database

    'Parameters:
    '   void
    'Returns:
    '   void
    Private Sub loadTree()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim auxString As String
        Dim auxArray(1) As String
        Dim ancestors As Integer = countLines("Surnames.txt")
        population = countLines("Names.txt")
        ReDim tree(population - 1)
        Dim fIndices(population - 1) As Integer
        Dim mIndices(population - 1) As Integer
        Dim names(population - 1) As String
        Dim surnames(ancestors - 1) As String
        Dim additInfo(population - 1) As String
        Dim fileNumber As Integer = FreeFile()
        Dim namesFilePath As String = Application.StartupPath & "\Names.txt"
        Dim surnamesFilePath As String = Application.StartupPath & "\Surnames.txt"
        Dim indicesFilePath As String = Application.StartupPath & "\Parent_Indices.txt"
        Dim additionalInfoFilePath As String = Application.StartupPath & "\Additional_Info.txt"
        FileOpen(fileNumber, namesFilePath, OpenMode.Input)
        Do Until EOF(fileNumber)
            names(i) = LineInput(fileNumber)
            i += 1
        Loop
        FileClose(fileNumber)
        i = 0
        fileNumber = FreeFile()
        FileOpen(fileNumber, surnamesFilePath, OpenMode.Input)
        Do Until EOF(fileNumber)
            surnames(i) = LineInput(fileNumber)
            i += 1
        Loop
        FileClose(fileNumber)
        i = 0
        fileNumber = FreeFile()
        FileOpen(fileNumber, indicesFilePath, OpenMode.Input)
        Do Until EOF(fileNumber)
            auxString = LineInput(fileNumber)
            auxArray = auxString.Split(" ")
            fIndices(i) = CType(auxArray(0), Integer)
            mIndices(i) = CType(auxArray(1), Integer)
            i += 1
        Loop
        FileClose(fileNumber)
        i = 0
        fileNumber = FreeFile()
        FileOpen(fileNumber, additionalInfoFilePath, OpenMode.Input)
        Do Until EOF(fileNumber)
            additInfo(i) = LineInput(fileNumber)
            i += 1
        Loop
        FileClose(fileNumber)
        i = 0
        While i <> population
            tree(i) = New Person(names(i), fIndices(i), mIndices(i), additInfo(i))
            If fIndices(i) = mIndices(i) And fIndices(i) = 0 Then
                tree(i).FatherName = surnames(j)
                tree(i).IsAncestor = True
                j += 1
            ElseIf fIndices(i) = mIndices(i) Then
                tree(i).FatherName = tree(fIndices(i)).FatherName
                tree(i).MotherName = tree(mIndices(i)).MotherName
                tree(tree(i).FatherIndex).AddChild(i)
            Else
                tree(tree(i).FatherIndex).AddChild(i)
                tree(tree(i).MotherIndex).AddChild(i)
                tree(i).FatherName = tree(fIndices(i)).FatherName
                tree(i).MotherName = tree(mIndices(i)).FatherName
            End If
            i += 1
        End While
    End Sub

    'countLines

    'Counts the lines in a text file given its name

    'Parameters:
    '   String txtFileName  The name of the text file
    'Returns:
    '   Integer c           The number of lines that the text file has
    Private Function countLines(ByVal txtFileName As String) As Integer
        'Set auxiliar variables
        Dim c As Integer = 0
        Dim fileNumber As Integer = FreeFile()
        Dim sTrash As String
        Dim filePath As String = Application.StartupPath & "\" & txtFileName
        'Open, traverse, and close
        FileOpen(fileNumber, filePath, OpenMode.Input)
        Do Until EOF(fileNumber)
            sTrash = LineInput(fileNumber)
            c += 1
        Loop
        FileClose(fileNumber)
        Return c
    End Function

    'logIn

    'Handles the log in of the user, there's an admin already set. The one who began this instance of the program

    'Parameters:
    '   void
    'Returns:
    '   void
    Private Sub logIn()
        'Enter name
        Dim name As String = InputBox("Please enter you full name", "Log In")
        Dim i As Integer = 0
        'Find the guy
        While i < population
            If name.ToUpper() = tree(i).getFullName().ToUpper() Then
                currentIndex = i
                'THE ADMIN HAS TO BE PRE-DEFINED
                If currentIndex = 6 Then
                    adminKey = True
                End If
                i = population
            End If
            i += 1
        End While
        'If we didn't find it, then we go to some random guy
        If i = population Then
            currentIndex = 1
        End If
    End Sub

    'indexOf

    'Gets the index from the database of the guy we're trying to find

    'Parameters:
    '   String name     Name of the guy we're looking for
    'Returns:
    '   Integer i       Index of the guy from the database (-1 if not found)
    Private Function indexOf(ByVal name As String) As Integer
        Dim i As Integer = 0
        While i <> population
            If tree(i).getFullName() = name Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    'addMember

    'Adds a member to the tree, who's parents already belonged to the family

    'Parameters:
    '   String name     Name of the guy we're looking for
    'Returns:
    '   Integer i       Index of the guy from the database
    Private Sub addMember(ByVal i As Integer)
        Dim fileNumber As Integer = FreeFile()
        Dim filePath As String = Application.StartupPath & "\" & "Names.txt"
        'Print newline and name in the names file
        FileOpen(fileNumber, filePath, OpenMode.Append)
        Print(fileNumber, vbNewLine)
        Print(fileNumber, tree(i).Name)
        FileClose(fileNumber)
        fileNumber = FreeFile()
        filePath = Application.StartupPath & "\" & "Surnames.txt"
        'Print newline and father name in the Surnames file (since he's not an ancestor, NOT supported yet)
        FileOpen(fileNumber, filePath, OpenMode.Append)
        Print(fileNumber, vbNewLine)
        Print(fileNumber, tree(i).FatherName)
        FileClose(fileNumber)
        fileNumber = FreeFile()
        filePath = Application.StartupPath & "\" & "Parent_Indices.txt"
        'Print the father's and mother's index in the indices file
        FileOpen(fileNumber, filePath, OpenMode.Append)
        Print(fileNumber, vbNewLine)
        Dim printIndices As String = tree(i).FatherIndex.ToString() & " " & tree(i).MotherIndex.ToString()
        Print(fileNumber, printIndices)
        'Print newline and gender in the additional information file
        FileClose(fileNumber)
        fileNumber = FreeFile()
        filePath = Application.StartupPath & "\" & "Additional_Info.txt"
        FileOpen(fileNumber, filePath, OpenMode.Append)
        Print(fileNumber, vbNewLine)
        Print(fileNumber, tree(i).Gender)
        FileClose(fileNumber)
    End Sub

    'loadPictures

    'Depending on the person, we display the pictures of himself and his/her parents (if applicable)

    'Parameters:
    '   Integer i   Index of the person
    'Returns:
    '   void
    Private Sub loadPictures(ByVal i As Integer)
        Dim pictureFile As String = Application.StartupPath & "\Photos\" & tree(i).getFullName() & ".jpg"
        Dim pictureFileF As String = Application.StartupPath & "\Photos\" & tree(tree(i).FatherIndex).getFullName() & ".jpg"
        Dim pictureFileM As String = Application.StartupPath & "\Photos\" & tree(tree(i).MotherIndex).getFullName() & ".jpg"
        'Try to find the guy's picture, if not found then we display the default picture
        Try
            picboxPhoto.Image = Image.FromFile(pictureFile)
        Catch e As FileNotFoundException
            If tree(i).Gender = "M" Then
                pictureFile = Application.StartupPath & "\Photos\Default_Man.jpg"
                picboxPhoto.Image = Image.FromFile(pictureFile)
            Else
                pictureFile = Application.StartupPath & "\Photos\Default_Woman.jpg"
                picboxPhoto.Image = Image.FromFile(pictureFile)
            End If
        End Try
        If tree(i).IsAncestor Then
            picboxPhotoF.Visible = False
            picboxPhotoF.Enabled = False
            picboxPhotoM.Visible = False
            picboxPhotoM.Enabled = False
        Else
            picboxPhotoF.Visible = True
            picboxPhotoF.Enabled = True
            picboxPhotoM.Visible = True
            picboxPhotoM.Enabled = True
            'Try to find the father's picture, if not found then we display the default picture
            Try
                picboxPhotoF.Image = Image.FromFile(pictureFileF)
            Catch e As FileNotFoundException
                If tree(tree(i).FatherIndex).Gender = "M" Then
                    pictureFile = Application.StartupPath & "\Photos\Default_Man.jpg"
                    picboxPhotoF.Image = Image.FromFile(pictureFile)
                Else
                    pictureFile = Application.StartupPath & "\Photos\Default_Woman.jpg"
                    picboxPhotoF.Image = Image.FromFile(pictureFile)
                End If
            End Try
            'Try to find the mother's picture, if not found then we display the default picture
            Try
                picboxPhotoM.Image = Image.FromFile(pictureFileM)
            Catch e As FileNotFoundException
                If tree(tree(i).MotherIndex).Gender = "M" Then
                    pictureFile = Application.StartupPath & "\Photos\Default_Man.jpg"
                    picboxPhotoM.Image = Image.FromFile(pictureFile)
                Else
                    pictureFile = Application.StartupPath & "\Photos\Default_Woman.jpg"
                    picboxPhotoM.Image = Image.FromFile(pictureFile)
                End If
            End Try
        End If
    End Sub

    'Form1_Load

    'Loads the form1 by loading the tree from the database, log the user in and manage its profile

    'Parameters:
    '   Object sender
    '   EventArgs e
    'Returns:
    '   void
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTree()
        logIn()
        manageOption(currentIndex)
    End Sub

    'buttonFather_Click

    'Click to the button that takes us to the father

    'Parameters:
    '   Object sender
    '   EventArgs e
    'Returns:
    '   void
    Private Sub buttonFather_Click(sender As Object, e As EventArgs) Handles buttonFather.Click
        currentIndex = tree(currentIndex).FatherIndex
        manageOption(currentIndex)
    End Sub

    'buttonMother_Click

    'Click to the button that takes us to the mother

    'Parameters:
    '   Object sender
    '   EventArgs e
    'Returns:
    '   void
    Private Sub buttonMother_Click(sender As Object, e As EventArgs) Handles buttonMother.Click
        currentIndex = tree(currentIndex).MotherIndex
        manageOption(currentIndex)
    End Sub

    'buttonChild_Click

    'Click to the button that takes us to a child, determined by the selection
    'From the combo box that contains the names of all the children
    'The default child selected is the first one in the combo box

    'Parameters:
    '   Object sender
    '   EventArgs e
    'Returns:
    '   void
    Private Sub buttonChild_Click(sender As Object, e As EventArgs) Handles buttonChild.Click
        Try
            currentIndex = tree(currentIndex).Children(cboxChildren.SelectedIndex)
        Catch f As ArgumentOutOfRangeException
            currentIndex = tree(currentIndex).Children(0)
        End Try
        manageOption(currentIndex)
    End Sub

    'buttonAddSideMember_Click

    'Adds the spouse of an existing member, it's reachable if his/her spouse and him have a child and is later added

    'Parameters:
    '   Object sender
    '   EventArgs e
    'Returns:
    '   void
    Private Sub buttonAddSideMember_Click(sender As Object, e As EventArgs) Handles buttonAddSideMember.Click
        Dim relative As String = InputBox("Enter the name of the full name of the husband or wife belonging to the family", "Add Side Family Member")
        Dim relIndex As Integer = indexOf(relative)
        If relIndex <> -1 Then
            Dim nameLogging As String = InputBox("Please enter the names only", "Add Side Member")
            Dim lastnameLogging As String = InputBox("Please enter the last name only", "Add Side Member")
            Dim gender As String = InputBox("Please enter the gender: (M) for men and (W) for women", "Add Side Member")
            population += 1
            ReDim Preserve tree(population - 1)
            tree(population - 1) = New Person(nameLogging, 0, 0, gender)
            tree(population - 1).IsAncestor = True
            tree(population - 1).FatherName = lastnameLogging
            addMember(population - 1)
        Else
            MsgBox("The family member you provided doesn't exist yet", MsgBoxStyle.OkOnly, "Unsuccessful Addition")
        End If
    End Sub

    'buttonAddMember_Click

    'Adds a member that is descendant from existing (in the tree) parents

    'Parameters:
    '   Object sender
    '   EventArgs e
    'Returns:
    Private Sub buttonAddMember_Click(sender As Object, e As EventArgs) Handles buttonAddMember.Click
        Dim father As String = InputBox("Enter the name of the full name of the father", "Add Family Member")
        Dim mother As String = InputBox("Enter the name of the full name of the mother", "Add Family Member")
        Dim dadIndex As Integer = indexOf(father)
        Dim momIndex As Integer = indexOf(mother)
        If dadIndex <> -1 And momIndex <> -1 Then
            Dim nameLogging As String = InputBox("Please enter the name only", "Add Family Member")
            Dim gender As String = InputBox("Please enter the gender: (M) for men and (W) for women", "Add Family Member")
            population += 1
            ReDim Preserve tree(population - 1)
            tree(population - 1) = New Person(nameLogging, dadIndex, momIndex, gender)
            tree(population - 1).FatherName = tree(dadIndex).FatherName
            tree(population - 1).MotherName = tree(momIndex).FatherName
            tree(dadIndex).AddChild(population - 1)
            tree(momIndex).AddChild(population - 1)
            addMember(population - 1)
        Else
            MsgBox("The father or mother of the family member you were about to provide doesn't exist", MsgBoxStyle.OkOnly, "Unsuccessful Addition")
        End If
    End Sub
End Class