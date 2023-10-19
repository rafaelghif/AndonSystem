Imports System.IO

Public Class LoginForm
    Private ReadOnly localPath = "C:\ANDON\localSetup.ini"
    Private ReadOnly userPath As String = GetIniValue("SETUP", "userPath", localPath)

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialization()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        AuthenticateUser()
    End Sub

    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            AuthenticateUser()
        End If
    End Sub

    Private Sub Initialization()
        TxtUsername.Text = ""
        TxtPassword.Text = ""

        TxtUsername.Focus()
    End Sub

    Private Sub AuthenticateUser()
        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text

        Dim userData As String = FindUserData(username)

        If String.IsNullOrEmpty(userData) Then
            ShowErrorMessage("Username not found, please contact engineering!")
            Initialization()
            Exit Sub
        End If

        Dim userParts As String() = userData.Split(",")
        Dim userPassword As String = userParts(1)
        Dim userType As String = userParts(2)

        If password <> userPassword Then
            TxtPassword.Text = ""
            TxtPassword.Focus()
            ShowErrorMessage("Wrong password!")
            Exit Sub
        End If

        Close()

        Dim labelForm As String = LblForm.Text

        If labelForm = "Accept" Then
            ShowAcceptForm(username, userType)
        ElseIf labelForm = "Arrive" Then
            ShowArriveForm(username, userType)
        ElseIf labelForm = "Close" Then
            ShowCloseForm(username, userType)
        End If
    End Sub

    Private Function FindUserData(username As String) As String
        Dim users As String() = File.ReadAllLines(userPath)
        For Each user As String In users
            If user.ToUpper.Contains(username.ToUpper) Then
                Return user
            End If
        Next
        Return Nothing
    End Function

    Private Sub ShowErrorMessage(message As String)
        MsgBox(message, MsgBoxStyle.Critical)
    End Sub

    Private Sub ShowAcceptForm(username As String, userType As String)
        AcceptForm.LblUsername.Text = username
        AcceptForm.LblType.Text = userType
        AcceptForm.Show()
    End Sub

    Private Sub ShowArriveForm(username As String, userType As String)
        ArriveForm.LblUsername.Text = username
        ArriveForm.LblType.Text = userType
        ArriveForm.Show()
    End Sub

    Private Sub ShowCloseForm(username As String, userType As String)
        CloseForm.LblUsername.Text = username
        CloseForm.LblType.Text = userType
        CloseForm.Show()
    End Sub
End Class