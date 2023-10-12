Imports System.Globalization
Imports System.IO

Public Class ArriveForm
    Private ReadOnly localPath = "C:\ANDON\localSetup.ini"

    Private ReadOnly alarmPath = GetIniValue("SETUP", "alarmPath", localPath)
    Private ReadOnly andonLogPath = GetIniValue("SETUP", "andonLogPath", localPath)

    Private andon As New Andon()
    Private listDatabases As New List(Of String)

    Private Sub AcceptForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialization()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim andonId As String = CmbSupportList.SelectedItem

        If String.IsNullOrEmpty(andonId) Then
            MsgBox("Please select list", MsgBoxStyle.Critical)
            Exit Sub
        End If

        HandleSubmit(andonId)
    End Sub

    Private Sub CmbSupportList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSupportList.SelectedIndexChanged
        Dim selectedItem As String = CmbSupportList.SelectedItem.ToString()

        Dim supportData As String = listDatabases.FirstOrDefault(Function(data) data.Contains(selectedItem))

        If supportData IsNot Nothing Then
            Dim supportDataParts As String() = supportData.Split(",")

            Dim department As String = supportDataParts(1)
            Dim line As String = supportDataParts(3)
            Dim checkerRegistration As String = supportDataParts(4)
            Dim checkerName As String = supportDataParts(5)
            Dim problem As String = supportDataParts(6)
            Dim issueDate As String = supportDataParts(11)

            TxtDepartment.Text = department
            TxtLine.Text = line
            TxtCheckerRegistration.Text = checkerRegistration
            TxtCheckerName.Text = checkerName
            TxtIssueDate.Text = issueDate
            TxtProblem.Text = problem
        End If
    End Sub

    Private Sub Initialization()
        Dim userType As String = LblType.Text

        Dim currentDate As Date = Date.Now
        Dim oneMonthAgo As Date = currentDate.AddMonths(-1)

        Dim logFileName As String = $"{currentDate.ToString("MMM-yy", CultureInfo.InvariantCulture)}.txt"
        Dim oneMonthAgoLogFileName As String = $"{oneMonthAgo.ToString("MMM-yy", CultureInfo.InvariantCulture)}.txt"

        Dim logFilePath As String = Path.Combine(andonLogPath, logFileName)
        Dim oneMonthAgoFilePath As String = Path.Combine(andonLogPath, oneMonthAgoLogFileName)

        Dim currentMonthDatabase As String() = LoadData(logFilePath)
        Dim oneMonthAgoDatabase As String() = LoadData(oneMonthAgoFilePath)

        Dim combinedDatabases As String() = CombineLogData(currentMonthDatabase, oneMonthAgoDatabase)

        listDatabases = GetAccpetList(combinedDatabases)

        Dim supportLists As List(Of String) = GetSupportLists(userType, combinedDatabases)

        CmbSupportList.Items.Clear()
        CmbSupportList.Items.AddRange(supportLists.ToArray())

        TxtDepartment.Text = ""
        TxtLine.Text = ""
        TxtCheckerRegistration.Text = ""
        TxtCheckerName.Text = ""
        TxtIssueDate.Text = ""
        TxtProblem.Text = ""
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

    Private Function GetAccpetList(databases As String()) As List(Of String)
        Dim acceptLists As New List(Of String)

        If databases IsNot Nothing Then
            For Each acceptList As String In databases
                If acceptList.Contains("ACCEPT") Then
                    acceptLists.Add(acceptList)
                End If
            Next
        End If

        Return acceptLists
    End Function

    Private Function GetSupportLists(userType As String, databases As String()) As List(Of String)
        Dim supportLists As New List(Of String)

        If databases IsNot Nothing Then
            For Each supportList As String In databases
                Dim supportListParts As String() = supportList.Split(",")

                Dim supportId As String = supportListParts(0)
                Dim supportType As String = supportListParts(7)
                Dim supportStatus As String = supportListParts(8)

                If supportStatus = "ACCEPT" AndAlso supportType = userType Then
                    supportLists.Add(supportId)
                End If
            Next
        End If

        Return supportLists
    End Function

    Private Sub HandleSubmit(andonId As String)
        Dim currentDate As Date = Date.Now
        Dim oneMonthAgo As Date = currentDate.AddMonths(-1)

        Dim logFileNames As String() = {$"{oneMonthAgo.ToString("MMM-yy", CultureInfo.InvariantCulture)}.txt", $"{currentDate.ToString("MMM-yy", CultureInfo.InvariantCulture)}.txt"}
        Dim alarmPaths As String() = logFileNames.Select(Function(logFileName) Path.Combine(alarmPath, logFileName)).ToArray()
        Dim andonLogPaths As String() = logFileNames.Select(Function(logFileName) Path.Combine(andonLogPath, logFileName)).ToArray()

        For i As Integer = 0 To logFileNames.Length - 1
            Dim logFileName As String = logFileNames(i)
            Dim alarmPath As String = alarmPaths(i)
            Dim andonLogPath As String = andonLogPaths(i)

            Dim alarmContents As String() = LoadData(alarmPath)
            Dim andonLogContents As String() = LoadData(andonLogPath)

            If andon.CompareMacAddress(andonId, andonLogContents) = False Then
                MsgBox("Please arrive in the correct checker!", MsgBoxStyle.Information)
                Initialization()
                Exit Sub
            End If

            andon.ReWriteAlarmContent(alarmPath, alarmContents, andonId)
            andon.ReWriteLogContent(andonLogPath, andonLogContents, andonId, LblUsername.Text, "ARRIVE")
        Next

        MsgBox($"Success Arrive Andon {andonId}", MsgBoxStyle.Information)
        Initialization()
    End Sub
End Class