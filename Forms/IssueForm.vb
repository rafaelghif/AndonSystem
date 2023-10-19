Imports System.IO

Public Class IssueForm
    Private andonAlarm As New Andon()
    Private ReadOnly localPath = "C:\ANDON\localSetup.ini"
    Private ReadOnly checkerReg = GetIniValue("SETUP", "checkerReg", localPath)
    Private ReadOnly checkerName = GetIniValue("SETUP", "checkerName", localPath)
    Private Sub IssueForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialization()
    End Sub

    Private Sub Initialization()
        LoadProblem()

        TxtCheckerRegistration.Text = checkerReg
        TxtCheckerName.Text = checkerName

        CmbProblem.Text = ""
        CmbProblem.Focus()
    End Sub

    Private Sub LoadProblem()
        Dim userPath As String = GetIniValue("SETUP", "userPath", localPath)
        Dim userPathArr As String() = userPath.Split("\")
        Dim ipServer As String = userPathArr(2)

        Dim problemPath As String = $"\\{ipServer}\f\ANDON SYSTEM 3\CONFIG\problem.csv"

        If File.Exists(problemPath) Then
            Try
                Dim problems As String() = File.ReadAllLines(problemPath)
                Dim filteredProblems As New List(Of String)()

                For Each line As String In problems
                    If line.Contains(checkerReg) Then
                        Dim fields As String() = line.Split(",")
                        CmbProblem.Items.Add(fields(1))
                    End If
                Next
            Catch ex As Exception
                MsgBox("Error when reading problem" + ex.ToString)
            End Try
        Else
            MsgBox("Problem path not exists, please contact engineering!")
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub IssueForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Initialization()
    End Sub

    Private Sub BtnEngSupport_Click(sender As Object, e As EventArgs) Handles BtnEngSupport.Click
        GenerateAndonAlarm("Engineering")
    End Sub

    Private Sub BtnProductionSupport_Click(sender As Object, e As EventArgs) Handles BtnProductionSupport.Click
        If MsgBox("Apakah kamu yakin ingin memanggil leader ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            GenerateAndonAlarm("Production")
        End If
    End Sub

    Private Sub GenerateAndonAlarm(type As String)
        If CmbProblem.Text = "" Then
            MsgBox("Please fill problem", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim problem As String = CmbProblem.Text.Replace(vbCrLf, ". ").Replace(",", ". ").Replace(vbCr, ". ").Replace("\r\n", ". ").Replace(Environment.NewLine, ". ")

        andonAlarm.GenerateAndonAlarm(problem, type)

        MsgBox($"Success Issue {type} Support", MsgBoxStyle.Information)
        Initialization()
    End Sub
End Class