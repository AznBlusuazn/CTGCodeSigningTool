Public Class Updater
    Public Shared Sub CheckForUpdate(type As Integer, curver As String, avaver As String)
        Dim currentver, availver As Long
        currentver = CLng(Replace(curver, ".", ""))
        availver = CLng(Replace(avaver, ".", ""))
        If availver > currentver Then
            Dim updatetext = "Update " & avaver & " Available!", answer As Integer
            answer = MsgBox(updatetext & vbCrLf & vbCrLf & "Would you like to update now?", vbYesNo)
            If answer = vbYes Then
                InstallUpdate()
            Else
                Exit Sub
            End If
        Else
            If type = 1 Then MsgBox("No Update Available!")
        End If
    End Sub
    Private Shared Sub InstallUpdate()
        Dim pHelp As New ProcessStartInfo With {
            .FileName = ".\" & MemoryBank.UpdaterName,
            .Arguments = "-Path " & Application.ProductName & " -Dir " &
            (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).Substring(6),
            .UseShellExecute = True,
            .WindowStyle = ProcessWindowStyle.Normal
        }
        Dim proc As Process = Process.Start(pHelp)
    End Sub

End Class
