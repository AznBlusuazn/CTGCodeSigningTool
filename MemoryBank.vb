Public Class MemoryBank
    Public Shared VersionNumber As String, AvailableVersion As String
    Public Shared UpdateURL As String
    Public Shared UpdaterName As String = "CTGUpdater.exe"
    Public Shared UpdaterDate As String
    Public Shared SettingsFile As String = "CTGCodeSigningTool.config"
    Public Shared AllMagicComesWithAPrice As String = ((FileVersionInfo.
        GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly().Location)).
        CompanyName).Substring(0, ((FileVersionInfo.GetVersionInfo(System.
        Reflection.Assembly.GetEntryAssembly().Location)).CompanyName).Length - 4)
    Public Shared KeyInMemory As String = ""
End Class
