Imports System.IO

Public Class MemoLog
    Private ReadOnly andon As Andon

    Public Sub New()
        andon = New Andon()
    End Sub

    Public Sub CheckLogType(filePath As String)
        Dim fileContents As String() = File.ReadAllLines(filePath)
        Dim testResult As String = Nothing

        For Each fileContent As String In fileContents
            If fileContent.Contains("Result           :") Then
                testResult = GetTestResult(fileContent)
            ElseIf ShouldGenerateAndon(testResult, fileContent) Then
                Dim failName As String = GetFailName(fileContent)
                andon.GenerateAndonAlarm(failName)
                Exit For
            End If
        Next
    End Sub

    Private Function GetTestResult(content As String) As String
        Dim resultValue As String = content.Substring(18).Trim()
        Return If(resultValue = "NG", "FAIL", resultValue)
    End Function

    Private Function ShouldGenerateAndon(testResult As String, content As String) As Boolean
        Return testResult = "FAIL" AndAlso content.Contains("Memo             :")
    End Function

    Private Function GetFailName(content As String) As String
        Dim failNameParts As String() = content.Split(":").Skip(1).ToArray()
        Return String.Join(":", failNameParts).Trim()
    End Function
End Class
