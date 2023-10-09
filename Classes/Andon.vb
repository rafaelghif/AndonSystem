Imports System.Globalization
Imports System.IO
Imports System.Net.NetworkInformation

Public Class Andon
    Private ReadOnly localPath = "C:\ANDON\localSetup.ini"
    Private ReadOnly alarmPath = GetIniValue("SETUP", "alarmPath", localPath)
    Private ReadOnly andonLogPath = GetIniValue("SETUP", "andonLogPath", localPath)
    Private ReadOnly checkerReg = GetIniValue("SETUP", "checkerReg", localPath)
    Private ReadOnly checkerName = GetIniValue("SETUP", "checkerName", localPath)
    Private ReadOnly line = GetIniValue("SETUP", "line", localPath)
    Private ReadOnly department = GetIniValue("SETUP", "department", localPath)

    Private ReadOnly alarmLock As New Object()
    Private ReadOnly logLock As New Object()

    Private Sub EnsureDirectoryExists(directoryPath As String)
        If Not Directory.Exists(directoryPath) Then
            Throw New Exception($"Directory '{directoryPath}' does not exist. Please contact engineering!")
        End If
    End Sub

    Public Sub GenerateAndonAlarm(failName As String, Optional andonType As String = "Engineering")
        Dim currentDate As Date = Date.Now

        failName = failName.Replace(vbCrLf, "")

        Dim computerName As String = Environment.MachineName

        EnsureDirectoryExists(alarmPath)
        EnsureDirectoryExists(andonLogPath)

        Dim logFileName As String = $"{currentDate.ToString("MMM-yy", CultureInfo.InvariantCulture)}.txt"
        Dim andonIdFormat As String = $"{currentDate.ToString("MMM-yy", CultureInfo.InvariantCulture)}-{{0}}"
        Dim newAndonId As String

        Dim macAddress As String = GetMacAddress()

        Dim fileContents As String() = If(File.Exists(Path.Combine(andonLogPath, logFileName)), File.ReadAllLines(Path.Combine(andonLogPath, logFileName)), Nothing)

        SyncLock logLock
            Using andonLogWriter As StreamWriter = File.AppendText(Path.Combine(andonLogPath, logFileName))
                If fileContents Is Nothing Then
                    newAndonId = String.Format(andonIdFormat, 1)
                Else
                    Dim andonIdArray As String() = fileContents(fileContents.Length - 1).Split(",")(0).Split("-")
                    Dim nextSequenceId As Integer = CInt(andonIdArray(2)) + 1
                    newAndonId = String.Format(andonIdFormat, nextSequenceId)
                End If

                Dim andonLogMessage As String = $"{newAndonId},{department},{computerName},{line},{checkerReg},{checkerName},{failName},{andonType},ISSUE,Category,Action,{currentDate.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)},AcceptDateTime,acceptBy,ArriveDateTime,arriveBy,CloseDateTime,closeBy,{macAddress}"
                andonLogWriter.WriteLine(andonLogMessage)
            End Using
        End SyncLock

        SyncLock alarmLock
            Using alarmWriter As StreamWriter = File.AppendText(Path.Combine(alarmPath, logFileName))
                Dim alarmMessage As String = $"{newAndonId},{line}, {checkerReg} - {checkerName},{currentDate.ToString("HH:mm:ss", CultureInfo.InvariantCulture)},ENG"
                alarmWriter.WriteLine(alarmMessage)
            End Using
        End SyncLock
    End Sub

    Public Sub ReWriteAlarmContent(alarmPath As String, alarmContents As String(), andonId As String)
        If alarmContents IsNot Nothing Then
            SyncLock alarmLock
                Using alarmWriter As New StreamWriter(alarmPath, False)
                    For Each alarm As String In alarmContents
                        Dim alarmParts As String() = alarm.Split(",")

                        If alarmParts(0) = andonId Then
                            alarmParts(4) = "ENGOK"
                        End If

                        alarmWriter.WriteLine(String.Join(",", alarmParts))
                    Next
                End Using
            End SyncLock
        End If
    End Sub

    Public Function CompareMacAddress(andonId As String, andonLogContents As String()) As Boolean
        Dim currentMac As String = GetMacAddress()

        Dim isValid = True

        If andonLogContents?.Length > 0 Then
            For Each andonLogContent In andonLogContents
                Dim anDonData As String() = andonLogContent.Split(",")
                If andonId = anDonData(0) Then
                    If anDonData.Length = 19 Then
                        isValid = currentMac = anDonData(18)
                        Exit For
                    End If
                End If
            Next
        End If

        Return isValid
    End Function

    Public Sub ReWriteAlarmContentAndRemoveId(alarmPath As String, alarmContents As String(), andonId As String)
        If alarmContents IsNot Nothing Then
            SyncLock alarmLock
                Using alarmWriter As New StreamWriter(alarmPath, False)
                    For Each alarm As String In alarmContents
                        Dim alarmParts As String() = alarm.Split(",")

                        If alarmParts(0) = andonId Then
                            Continue For
                        End If

                        alarmWriter.WriteLine(String.Join(",", alarmParts))
                    Next
                End Using
            End SyncLock
        End If
    End Sub

    Public Sub ReWriteLogContent(andonLogPath As String, andonLogContents As String(), andonId As String, username As String, status As String, Optional category As String = "", Optional picAction As String = "")
        Dim currentDate As Date = Date.Now
        If andonLogContents IsNot Nothing Then
            SyncLock logLock
                Using logWriter As New StreamWriter(andonLogPath, False)
                    For Each logEntry As String In andonLogContents
                        Dim logEntryParts As String() = logEntry.Split(",")

                        If logEntryParts(0) = andonId Then
                            logEntryParts(8) = status
                            If status = "ACCEPT" Then
                                logEntryParts(12) = currentDate.ToString("yyyy-MM-dd HH:mm:ss")
                                logEntryParts(13) = username
                            ElseIf status = "ARRIVE" Then
                                logEntryParts(14) = currentDate.ToString("yyyy-MM-dd HH:mm:ss")
                                logEntryParts(15) = username
                            ElseIf status = "COMPLETE" Then
                                logEntryParts(9) = category
                                logEntryParts(10) = picAction
                                logEntryParts(16) = currentDate.ToString("yyyy-MM-dd HH:mm:ss")
                                logEntryParts(17) = username
                            End If
                        End If

                        logWriter.WriteLine(String.Join(",", logEntryParts))
                    Next
                End Using
            End SyncLock
        End If
    End Sub

    Private Function GetMacAddress() As String
        Dim macAddress As String = String.Empty

        Dim networkInterfaces() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()

        For Each networkInterface As NetworkInterface In networkInterfaces
            ' Check if the network interface is operational and not a loopback or tunnel interface
            If networkInterface.OperationalStatus = OperationalStatus.Up AndAlso
               networkInterface.NetworkInterfaceType <> NetworkInterfaceType.Loopback AndAlso
               networkInterface.NetworkInterfaceType <> NetworkInterfaceType.Tunnel Then

                Dim physicalAddress As PhysicalAddress = networkInterface.GetPhysicalAddress()
                macAddress = BitConverter.ToString(physicalAddress.GetAddressBytes())
                Exit For
            End If
        Next

        Return macAddress
    End Function
End Class
