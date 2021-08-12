Public Class Logger
    Public Class Logger
        Public Shared Sub WriteToLog(type As Integer, section As String, reason As String, ex As Exception)
            Dim DateStamp As String = DateTime.Now.ToString("yyyyMMdd")
            Dim TimeStamp As String = DateTime.Now.ToString("HHmm")
            Dim LogFile As String = "Log_" & DateStamp & ".log"
            Dim fs As New System.IO.FileStream(LogFile, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite)
            Dim s As New System.IO.StreamWriter(fs)
            s.Close()
            fs.Close()
            Dim fs1 As New System.IO.FileStream(LogFile, System.IO.FileMode.Append, System.IO.FileAccess.Write)
            Dim s1 As New System.IO.StreamWriter(fs1)
            If Len(section) > 0 Then s1.Write("Section: " & section & vbCrLf)
            s1.Write("Date/Time:" & DateStamp & "_" & TimeStamp & vbCrLf)
            If Len(reason) > 0 Then s1.Write("Reason: " & reason & vbCrLf)
            s1.Write("Exception: " & vbCrLf & ex.ToString & vbCrLf)
            s1.Write("================================================" & vbCrLf)
            s1.Close()
            fs1.Close()
            Select Case (type)
                Case 0
                    MsgBox("Error: " & reason & vbCrLf & "Check Log File", vbCritical + vbOKOnly)
                    Exiter.ExitTheApp()
                Case 1
                    'Silence
                Case Else
                    MsgBox("Error: " & reason & vbCrLf & "Check Log File", vbCritical + vbOKOnly)
            End Select
        End Sub
    End Class

End Class
