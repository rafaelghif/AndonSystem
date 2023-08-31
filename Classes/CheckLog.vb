Public Class CheckLog
    Private ReadOnly logPath As String = ""
    Private ReadOnly logType As String = ""
    Private ReadOnly horizontalLog As HorizontalLog
    Private ReadOnly memoLog As MemoLog
    Private ReadOnly brackedLog As BracketLog

    Public Sub New(paramLogPath As String, paramLogType As String)
        logPath = paramLogPath
        logType = paramLogType
        horizontalLog = New HorizontalLog()
        memoLog = New MemoLog()
        brackedLog = New BracketLog()
    End Sub

    Public Sub StartCheckLog()
        Select Case logType
            Case "Type1"
                horizontalLog.CheckLogType(logPath, 5)
            Case "Type2"
                horizontalLog.CheckLogType(logPath, 7)
            Case "Type3"
                memoLog.CheckLogType(logPath)
            Case "Type4"
                brackedLog.CheckLogType(logPath)
        End Select
    End Sub
End Class
