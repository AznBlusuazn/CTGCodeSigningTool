﻿Public Class Init
    Public Shared Sub Init()
        InitStartup()
        InitLibs()
        InitFields()
        InitCheck()
    End Sub
    Private Shared Sub InitStartup()
        Dim VersionParts() As String = Strings.Split((System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()), ".", 4)
        MemoryBank.VersionNumber = VersionParts(0) & "." & VersionParts(1) & "." & ClarkTribeGames.Converters.VersionConverter(VersionParts(2),
            3) & "." & ClarkTribeGames.Converters.VersionConverter(VersionParts(3), 4)
        MemoryBank.UpdaterDate = ClarkTribeGames.MySQLReader.Query(LCase(MemoryBank.UpdaterName).Replace(".exe", ""), "d")
        If System.IO.File.Exists(MemoryBank.UpdaterName) Then
            If System.IO.File.GetLastWriteTime(MemoryBank.UpdaterName) < Convert.ToDateTime(MemoryBank.UpdaterDate) Then
                System.IO.File.Delete(MemoryBank.UpdaterName)
                ClarkTribeGames.Updater.GetUpdater()
                InitStartup()
            End If
        Else
            ClarkTribeGames.Updater.GetUpdater()
            InitStartup()
        End If
        Try
            MemoryBank.AvailableVersion = ClarkTribeGames.MySQLReader.Query(LCase(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name.ToString()), "v")
            MemoryBank.UpdateURL = ClarkTribeGames.MySQLReader.Query(LCase(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name.ToString()), "u")
            If (ClarkTribeGames.Updater.Checker(MemoryBank.VersionNumber, MemoryBank.AvailableVersion)) Then
                Dim updatetext = "Update " & MemoryBank.AvailableVersion & " Available!", answer As Integer
                answer = MsgBox(updatetext & vbCrLf & vbCrLf & "Would you like to update now?", vbYesNo)
                If answer = vbYes Then ClarkTribeGames.Updater.InstallUpdate(Application.ProductName, MemoryBank.UpdateURL)
            End If
        Catch ex As Exception
            Logger.Logger.WriteToLog(2, "UpdateCheck", "Could not find update server.", ex)
        End Try
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
    Private Shared Sub InitCheck()
        If System.IO.File.Exists(MemoryBank.SettingsFile) Then
            Settings.SettingsAction("load", MemoryBank.SettingsFile)
        End If
    End Sub

End Class
