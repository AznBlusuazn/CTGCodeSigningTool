Public Class Init
    Public Shared Sub Init()
        InitStartup()
        InitLibs()
        InitFields()
        InitCheck()
    End Sub
    Private Shared Sub InitStartup()
        Dim VersionParts() As String = Strings.Split((System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()), ".", 4)
        MemoryBank.VersionNumber = VersionParts(0) & "." & VersionParts(1) & "." & Tools.VersionConverter(VersionParts(2), 3) & "." &
            Tools.VersionConverter(VersionParts(3), 4)
        If System.IO.File.Exists(MemoryBank.UpdaterName) Then
            If System.IO.File.GetLastWriteTime(MemoryBank.UpdaterName) < Convert.ToDateTime(MemoryBank.UpdaterDate) Then
                System.IO.File.Delete(MemoryBank.UpdaterName)
                PlaceUpdater()
                InitStartup()
            End If
        End If
        Try
            MemoryBank.AvailableVersion = CTGMySQL.CTGMySQL.Query(LCase(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name.ToString()))
            Updater.CheckForUpdate(0, MemoryBank.VersionNumber, MemoryBank.AvailableVersion)
        Catch ex As Exception
            Logger.Logger.WriteToLog(2, "UpdateCheck", "Could not find update server.", ex)
        End Try
        If Not System.IO.File.Exists(MemoryBank.UpdaterName) Then
            PlaceUpdater()
            InitStartup()
        End If
        Tools.HideFile(MemoryBank.SettingsFile)
        Tools.HideFile(MemoryBank.UpdaterName)
    End Sub
    Private Shared Sub InitLibs()
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf Tools.CTGEncoderLoader
    End Sub
    Public Shared Sub InitFields()
        MainForm.ToolText.Text = ""
        MainForm.FileText.Text = ""
        MainForm.TimestampDrop.SelectedIndex = 0
        MainForm.PFXFileText.Text = ""
        MainForm.PFXPassText.Text = ""
        MainForm.PFXPassText.ReadOnly = False
        MainForm.PFXPassButton.Text = "Confirm"
        Tools.ButtonChange(MainForm.PFXPassButton, False)
    End Sub
    Private Shared Sub InitCheck()
        If System.IO.File.Exists(MemoryBank.SettingsFile) Then
            Settings.SettingsAction("load", MemoryBank.SettingsFile)
        End If
    End Sub
    Private Shared Sub PlaceUpdater()
        System.IO.File.WriteAllBytes(MemoryBank.UpdaterName, My.Resources.CTGUpdater)
    End Sub

End Class
