Imports System.ComponentModel
Imports System.IO

Public Class DisplayForm
    Private ReadOnly localPath = "C:\ANDON\localSetup.ini"
    Private ReadOnly andonLogPath = GetIniValue("SETUP", "andonLogPath", localPath)
    Private listDatabases As New List(Of String)

    Private Sub DisplayForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialization()
        BackColor = ColorTranslator.FromHtml("#1f1f2b")

        RefreshAndonTimer.Interval = 3000
        RefreshAndonTimer.Start()
    End Sub

    Private Sub Initialization()
        Dim currentDate As Date = Date.Now
        Dim oneMonthAgo As Date = currentDate.AddMonths(-1)

        Dim logFileName As String = $"{currentDate:MMM-yy}.txt"
        Dim oneMonthAgoLogFileName As String = $"{oneMonthAgo:MMM-yy}.txt"

        Dim logFilePath As String = Path.Combine(andonLogPath, logFileName)
        Dim oneMonthAgoFilePath As String = Path.Combine(andonLogPath, oneMonthAgoLogFileName)

        Dim currentMonthDatabase As String() = LoadData(logFilePath)
        Dim oneMonthAgoDatabase As String() = LoadData(oneMonthAgoFilePath)

        Dim combinedDatabases As String() = CombineLogData(currentMonthDatabase, oneMonthAgoDatabase)

        Array.Reverse(combinedDatabases)

        listDatabases = GetAndonList(combinedDatabases)
        GenerateAndonList()
    End Sub

    Private Function LoadData(filePath As String) As String()
        If File.Exists(filePath) Then
            Return File.ReadAllLines(filePath)
        Else
            Return Nothing
        End If
    End Function

    Private Function CombineLogData(data1 As String(), data2 As String()) As String()
        If data1 IsNot Nothing AndAlso data2 IsNot Nothing Then
            Return data1.Concat(data2).ToArray()
        ElseIf data1 IsNot Nothing Then
            Return data1
        ElseIf data2 IsNot Nothing Then
            Return data2
        Else
            Return Nothing
        End If
    End Function

    Private Function GetAndonList(databases As String()) As List(Of String)
        Dim andonLists As New List(Of String)

        If databases IsNot Nothing Then
            For Each andonList As String In databases
                If Not andonList.Contains("COMPLETE") Then
                    andonLists.Add(andonList)
                End If
            Next
        End If

        Return andonLists
    End Function

    Private Sub GenerateAndonList()

        Dim positionY As Integer = 15

        Dim textboxProperties = New List(Of TextboxProperties) From
        {
            New TextboxProperties() With {.NamePrefix = "lineTextBox", .PositionX = 0, .SizeWidth = 142},
            New TextboxProperties() With {.NamePrefix = "checkerNameTextBox", .PositionX = 148, .SizeWidth = 126},
            New TextboxProperties() With {.NamePrefix = "problemTextBox", .PositionX = 280, .SizeWidth = 190},
            New TextboxProperties() With {.NamePrefix = "issueDateTextBox", .PositionX = 476, .SizeWidth = 153},
            New TextboxProperties() With {.NamePrefix = "picTextBox", .PositionX = 635, .SizeWidth = 135},
            New TextboxProperties() With {.NamePrefix = "supportTypeTextBox", .PositionX = 775, .SizeWidth = 105}
        }

        Dim currentIndex As Integer = 0

        For Each listDatabase As String In listDatabases
            Dim andonParts As String() = listDatabase.Split(",")

            Dim andonList As New List(Of String)

            Dim line As String = andonParts(3)
            Dim checkerName As String = andonParts(2)
            Dim problem As String = andonParts(6)
            Dim status As String = andonParts(8)
            Dim issueDate As String = andonParts(11)
            Dim pic As String = "-"
            Dim supportType As String = andonParts(7)

            If status = "ISSUE" Then
                pic = "-"
            ElseIf status = "ACCEPT" Then
                pic = andonParts(13)
            ElseIf status = "ARRIVE" Then
                pic = andonParts(15)
            End If

            andonList.Add(line)
            andonList.Add(checkerName)
            andonList.Add(problem)
            andonList.Add(issueDate)
            andonList.Add(pic)
            andonList.Add(supportType)

            Dim propIndex As Integer = 0
            For Each prop In textboxProperties
                Dim textBox As TextBox = CreateTextBox(currentIndex, andonList(propIndex), prop.PositionX, positionY, prop.SizeWidth)
                Panel1.Controls.Add(textBox)
                propIndex += 1
            Next

            positionY += 24
            currentIndex += 1
        Next
    End Sub

    Private Function CreateTextBox(indexNumber As Integer, value As String, positionX As Integer, positionY As Integer, width As Integer) As TextBox
        Dim textBox As New TextBox With {
           .Name = $"picTextBox{indexNumber}",
           .Text = value,
           .Location = New Point(positionX, positionY),
           .[ReadOnly] = True,
           .BorderStyle = BorderStyle.None,
           .Font = New Font("Source Sans Pro", 13.8),
           .Size = New Size(width, 29),
           .TextAlign = HorizontalAlignment.Center,
           .BackColor = ColorTranslator.FromHtml("#1f1f2b"),
           .ForeColor = Color.White
        }
        Return textBox
    End Function

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub RefreshAndonTimer_Tick(sender As Object, e As EventArgs) Handles RefreshAndonTimer.Tick
        Initialization()
    End Sub

    Private Sub DisplayForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        RefreshAndonTimer.Stop()
    End Sub
End Class

