﻿Imports System.ComponentModel
Imports System.Globalization
Imports System.IO

Public Class DisplayForm
    Private ReadOnly localPath = "C:\ANDON\localSetup.ini"
    Private ReadOnly andonLogPath = GetIniValue("SETUP", "andonLogPath", localPath)
    Private listDatabases As New List(Of String)

    Private Sub DisplayForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialization()
        BackColor = ColorTranslator.FromHtml("#1f1f2b")

        RefreshAndonTimer.Interval = 5000
        RefreshAndonTimer.Start()
    End Sub

    Private Sub Initialization()
        Dim currentDate As Date = Date.Now
        Dim oneMonthAgo As Date = currentDate.AddMonths(-1)

        Dim logFileName As String = $"{currentDate.ToString("MMM-yy", CultureInfo.InvariantCulture)}.txt"
        Dim oneMonthAgoLogFileName As String = $"{oneMonthAgo.ToString("MMM-yy", CultureInfo.InvariantCulture)}.txt"

        Dim logFilePath As String = Path.Combine(andonLogPath, logFileName)
        Dim oneMonthAgoFilePath As String = Path.Combine(andonLogPath, oneMonthAgoLogFileName)

        Dim currentMonthDatabase As String() = LoadData(logFilePath)
        Dim oneMonthAgoDatabase As String() = LoadData(oneMonthAgoFilePath)

        Dim combinedDatabases As String() = CombineLogData(currentMonthDatabase, oneMonthAgoDatabase)

        Try
            Array.Reverse(combinedDatabases)
        Catch ex As Exception

        End Try

        listDatabases = GetAndonList(combinedDatabases)
        GenerateAndonList()
    End Sub

    Private Function LoadData(filePath As String) As String()
        If File.Exists(filePath) Then
            Try
                Return File.ReadAllLines(filePath)
            Catch ex As Exception
                Return Nothing
            End Try
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
            New TextboxProperties() With {.NamePrefix = "lineTextBox", .PositionX = 0, .SizeWidth = 142, .TextAlign = HorizontalAlignment.Left},
            New TextboxProperties() With {.NamePrefix = "checkerNameTextBox", .PositionX = 142, .SizeWidth = 126, .TextAlign = HorizontalAlignment.Left},
            New TextboxProperties() With {.NamePrefix = "problemTextBox", .PositionX = 268, .SizeWidth = 250, .TextAlign = HorizontalAlignment.Left},
            New TextboxProperties() With {.NamePrefix = "issueDateTextBox", .PositionX = 518, .SizeWidth = 100, .TextAlign = HorizontalAlignment.Center},
            New TextboxProperties() With {.NamePrefix = "status", .PositionX = 618, .SizeWidth = 80, .TextAlign = HorizontalAlignment.Center},
            New TextboxProperties() With {.NamePrefix = "picTextBox", .PositionX = 698, .SizeWidth = 80, .TextAlign = HorizontalAlignment.Center},
            New TextboxProperties() With {.NamePrefix = "supportTypeTextBox", .PositionX = 778, .SizeWidth = 90, .TextAlign = HorizontalAlignment.Center}
        }

        Panel1.Controls.Clear()

        Dim currentIndex As Integer = 0

        For Each listDatabase As String In listDatabases
            Dim andonParts As String() = listDatabase.Split(",")

            Dim andonList As New List(Of String)

            Dim line As String = andonParts(3)
            Dim checkerName As String = andonParts(5)
            Dim problem As String = andonParts(6)
            Dim status As String = andonParts(8)
            Dim issueDate As String = andonParts(11).Split(" ")(1)
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
            andonList.Add(status)
            andonList.Add(pic)
            andonList.Add(supportType)

            Dim propIndex As Integer = 0
            For Each prop In textboxProperties
                Dim textBox As TextBox = CreateTextBox(currentIndex, andonList(propIndex), prop.PositionX, positionY, prop.SizeWidth, prop.TextAlign)
                Panel1.Controls.Add(textBox)
                propIndex += 1
            Next

            positionY += 31
            currentIndex += 1
        Next
    End Sub

    Private Function CreateTextBox(indexNumber As Integer, value As String, positionX As Integer, positionY As Integer, width As Integer, Optional textAlign As HorizontalAlignment = HorizontalAlignment.Left) As TextBox
        Dim ticketType As String = value

        If value = "Engineering" Then
            ticketType = "ENG"
        ElseIf value = "Production" Then
            ticketType = "PROD"
        End If

        Dim textBox As New TextBox With {
           .Name = $"picTextBox{indexNumber}",
           .Text = ticketType,
           .Location = New Point(positionX, positionY),
           .[ReadOnly] = True,
           .BorderStyle = BorderStyle.FixedSingle,
           .Font = New Font("Source Sans Pro", 13.8),
           .Size = New Size(width, 29),
           .TextAlign = textAlign,
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

