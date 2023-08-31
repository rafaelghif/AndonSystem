Imports System.IO

Public Class HorizontalLog
    Private ReadOnly andon As Andon

    Public Sub New()
        andon = New Andon()
    End Sub

    Public Sub CheckLogType(filePath As String, headerLineCount As Integer)
        Dim fileContents As String() = File.ReadAllLines(filePath)

        For currentIndex As Integer = headerLineCount To fileContents.Length - 1
            Dim fileContent As String = fileContents(currentIndex)
            Dim contentParts As String() = fileContent.Split(",")

            If contentParts.Length <> 3 Then
                Exit For
            End If

            Dim testName As String = GetTestName(contentParts(2))
            Dim testResult As String = contentParts(2).Split("=")(1).Trim()

            If testResult = "FAIL" Then
                andon.GenerateAndonAlarm(testName)
                Exit For
            End If
        Next
    End Sub

    Private Function GetTestName(dataPart As String) As String
        Return dataPart.Split("=")(0).Trim().Replace(",", "-")
    End Function
End Class
