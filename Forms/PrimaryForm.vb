Imports System.IO

Public Class PrimaryForm
    Private ReadOnly localPath = "C:\ANDON\localSetup.ini"
    Private ReadOnly isManual As Boolean = GetIniValue("SETUP", "isManual", localPath)
    Private logPath As String
    Private logType As String
    Private logFileType As String
    Private logCount As Integer
    Private Sub PrimaryForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialization()
    End Sub

    Private Sub Initialization()
        If isManual = False Then
            'Initialization Automatically Andon
            logPath = GetIniValue("SETUP", "logPath", localPath)
            logType = GetIniValue("SETUP", "logType", localPath)
            logFileType = GetIniValue("SETUP", "logFileType", localPath)

            logCount = Directory.GetFiles(logPath, $"*.{logFileType}", SearchOption.AllDirectories).Count

            WatchLogTimer.Interval = 5000
            WatchLogTimer.Start()
        End If
    End Sub

    Private Sub WatchLogTimer_Tick(sender As Object, e As EventArgs) Handles WatchLogTimer.Tick
        Dim currentLogCount As Integer = GetLogFilesCount()

        If logCount <> currentLogCount Then
            If currentLogCount > 0 Then
                Dim newFilePath As String = GetLatestLogFilePath()
                Try
                    Dim testOpen As String() = File.ReadAllLines(newFilePath)
                    Dim checkLog As New CheckLog(newFilePath, logType)
                    checkLog.StartCheckLog()

                    logCount = currentLogCount
                Catch ex As Exception
                    Exit Sub
                End Try
            Else
                logCount = currentLogCount
            End If
        End If
    End Sub

    Private Function GetLogFilesCount() As Integer
        Return Directory.GetFiles(logPath, $"*.{logFileType}", SearchOption.AllDirectories).Length
    End Function

    Private Function GetLatestLogFilePath() As String
        Return Directory.GetFiles(logPath, $"*.{logFileType}", SearchOption.AllDirectories) _
                        .OrderByDescending(Function(f) New FileInfo(f).LastWriteTime) _
                        .FirstOrDefault()
    End Function

    Private Sub BtnIssue_Click(sender As Object, e As EventArgs) Handles BtnIssue.Click
        IssueForm.ShowDialog()
    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        LoginForm.LblForm.Text = "Accept"
        LoginForm.Show()
    End Sub

    Private Sub BtnArrive_Click(sender As Object, e As EventArgs) Handles BtnArrive.Click
        LoginForm.LblForm.Text = "Arrive"
        LoginForm.Show()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        LoginForm.LblForm.Text = "Close"
        LoginForm.Show()
    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        DisplayForm.Show()
    End Sub
End Class
