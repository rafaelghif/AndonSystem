Imports System.IO

Public Class BracketLog
    Private ReadOnly andon As Andon

    Public Sub New()
        andon = New Andon()
    End Sub

    Public Sub CheckLogType(filePath As String)
        Dim fileContents As String() = File.ReadAllLines(filePath)

        Dim testResult As String = "FAIL"
        Dim testName As String = Nothing

        For Each fileContent As String In fileContents
            If fileContent.Contains("[RESULT]") Then
                testResult = GetTestResult(fileContent)
                testResult = If(testResult = "NG", "FAIL", testResult)
                Exit For
            ElseIf IsTestNameLine(fileContent) Then
                testName = GetTestName(fileContent)
            End If
        Next

        If testResult = "FAIL" Then
            andon.GenerateAndonAlarm(testName)
        End If
    End Sub

    Private Function GetTestResult(content As String) As String
        Return content.Split("=")(1).Trim()
    End Function

    Private Function IsTestNameLine(content As String) As Boolean
        Return content.Contains("[") AndAlso content.Contains("]") AndAlso Not content.Contains("[TESTTIME]")
    End Function

    Private Function GetTestName(content As String) As String
        Return content.Replace("[FAIL]", "").Replace("[", "").Replace("]", "").Trim()
    End Function
End Class