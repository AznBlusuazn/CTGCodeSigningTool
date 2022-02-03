Public Class MainForm
    Private Sub Initialize(sender As Object, e As EventArgs) Handles MyBase.Load
        Init.Init()
        GoButton.Select()
    End Sub
    Private Sub PFXTextBox_TextChanged(sender As Object, e As EventArgs) Handles PFXPassText.TextChanged
        Execute.CheckChanges("key", SaveCheck, PFXPassText, TimestampDrop, PFXPassButton)
    End Sub

    'MenuBar
    Private Sub LoadSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadMenuItem.Click
        Settings.SettingsAction("load", MemoryBank.SettingsFile)
    End Sub
    Private Sub SaveSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveMenuItem.Click
        Settings.SettingsAction("save", MemoryBank.SettingsFile)
    End Sub
    Private Sub ClearFieldsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearMenuItem.Click
        Init.InitFields()
    End Sub
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckMenuItem.Click
        If (ClarkTribeGames.Updater.Checker(MemoryBank.VersionNumber, MemoryBank.AvailableVersion)) Then
            Dim updatetext = $"Update {MemoryBank.AvailableVersion} Available!", answer As Integer
            answer = MsgBox($"{updatetext}{vbCrLf}{vbCrLf}Would you like to update now?", vbYesNo)
            If answer = vbYes Then ClarkTribeGames.Updater.InstallUpdate(Application.ProductName, MemoryBank.UpdateURL)
        Else
            MsgBox("No Update Available!")
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitMenuItem.Click, Me.FormClosing
        Exiter.ExitTheApp()
    End Sub
    'WebButtons
    Private Sub ToolLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ToolLink.LinkClicked
        Try
            ClarkTribeGames.Web.GoToWeb("https://docs.microsoft.com/en-us/windows/win32/seccrypto/signtool")
        Catch ex As Exception
            MsgBox($"Error launch Browser!{vbCrLf}See Log File.", vbExclamation)
            Logger.Logger.WriteToLog(1, "GoToWeb", "Browser error.", ex)
        End Try

    End Sub
    Private Sub FBButton_Click(sender As Object, e As EventArgs) Handles FBButton.Click
        Try
            ClarkTribeGames.Web.FB()
        Catch ex As Exception
            MsgBox($"Error launch Browser!{vbCrLf}See Log File.", vbExclamation)
            Logger.Logger.WriteToLog(1, "GoToWeb", "Browser error.", ex)
        End Try
    End Sub
    Private Sub DCButton_Click(sender As Object, e As EventArgs) Handles DCButton.Click
        Try
            ClarkTribeGames.Web.DS()
        Catch ex As Exception
            MsgBox($"Error launch Browser!{vbCrLf}See Log File.", vbExclamation)
            Logger.Logger.WriteToLog(1, "GoToWeb", "Browser error.", ex)
        End Try
    End Sub
    Private Sub MailButton_Click(sender As Object, e As EventArgs) Handles MailButton.Click
        Try
            ClarkTribeGames.Web.EM()
        Catch ex As Exception
            MsgBox($"Error launch Browser!{vbCrLf}See Log File.", vbExclamation)
            Logger.Logger.WriteToLog(1, "GoToWeb", "Browser error.", ex)
        End Try
    End Sub
    Private Sub DonateButton_Click(sender As Object, e As EventArgs) Handles DonateButton.Click
        Try
            ClarkTribeGames.Web.PP()
        Catch ex As Exception
            MsgBox($"Error launch Browser!{vbCrLf}See Log File.", vbExclamation)
            Logger.Logger.WriteToLog(1, "GoToWeb", "Browser error.", ex)
        End Try
    End Sub
    Private Sub PTButton_Click(sender As Object, e As EventArgs) Handles PTButton.Click
        Try
            ClarkTribeGames.Web.PT()
        Catch ex As Exception
            MsgBox($"Error launch Browser!{vbCrLf}See Log File.", vbExclamation)
            Logger.Logger.WriteToLog(1, "GoToWeb", "Browser error.", ex)
        End Try
    End Sub
    'SelectButtons
    Private Sub ToolButton_Click(sender As Object, e As EventArgs) Handles ToolButton.Click
        Execute.LoadFile("tool", ToolText)
    End Sub
    Private Sub PFXFileButton_Click(sender As Object, e As EventArgs) Handles PFXFileButton.Click
        Execute.LoadFile("pfx", PFXFileText)
    End Sub
    Private Sub FileButton_Click(sender As Object, e As EventArgs) Handles FileButton.Click
        Execute.LoadFile("file", FileText)
    End Sub
    'ConfirmButtons
    Private Sub TimestampButton_Click(sender As Object, e As EventArgs) Handles TimestampButton.Click
        MsgBox(MemoryBank.SettingsFile)
        Settings.SettingsAction("new", MemoryBank.SettingsFile)
    End Sub
    Private Sub PFXPassButton_Click(sender As Object, e As EventArgs) Handles PFXPassButton.Click
        Execute.PFXPassword(PFXPassText, PFXPassButton)
    End Sub
    'ExecuteButton
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Execute.GoTime()
    End Sub

End Class
