Public Class Exiter
    Public Shared Sub ExitTheApp()
        GC.Collect()
        MainForm.Dispose()
        MainForm.Close()
    End Sub
End Class
