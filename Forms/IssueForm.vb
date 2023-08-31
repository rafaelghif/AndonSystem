Public Class IssueForm
    Private andonAlarm As New Andon()
    Private ReadOnly checkerReg = GetIniValue("SETUP", "checkerReg", $"{CurrentDirectory}/CONFIG/setup.ini")
    Private ReadOnly checkerName = GetIniValue("SETUP", "checkerName", $"{CurrentDirectory}/CONFIG/setup.ini")
    Private Sub IssueForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialization()
    End Sub

    Private Sub Initialization()
        TxtCheckerRegistration.Text = checkerReg
        TxtCheckerName.Text = checkerName
        TxtProblem.Text = ""

        TxtProblem.Focus()
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
        GenerateAndonAlarm("Production")
    End Sub

    Private Sub GenerateAndonAlarm(type As String)
        andonAlarm.GenerateAndonAlarm(TxtProblem.Text, type)
        MsgBox($"Success Issue {type} Support", MsgBoxStyle.Information)
        Initialization()
    End Sub
End Class