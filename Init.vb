Public Class Init
    Public Shared Sub Init()
        InitStartup()
        InitLibs()
        If Not System.IO.File.Exists(MemoryBank.SettingsFile) Then InitFields()
    End Sub
    Private Shared Sub InitStartup()
        MemoryBank.VersionNumber = ClarkTribeGames.Converters.GetVersion(Application.ProductVersion)
        MemoryBank.UpdaterDate = ClarkTribeGames.MySQLReader.Query(LCase(MemoryBank.UpdaterName).Replace(".exe", ""), "d")
        Tools.UpdaterCheck()
        Tools.VersionCheck()
        Settings.CheckSettings()
        ClarkTribeGames.FilesFolders.HideFile(MemoryBank.SettingsFile)
        ClarkTribeGames.FilesFolders.HideFile(MemoryBank.UpdaterName)
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

End Class
