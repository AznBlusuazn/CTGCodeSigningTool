Public Class Settings
    Public Shared Sub SettingsAction(type As String, filename As String)
        Select Case LCase(type)
            Case "new"
                CreateSettings(filename)
            Case "load"
                LoadSettings(filename)
            Case "save"
                SaveSettings(filename)
        End Select
    End Sub
    Private Shared Sub CreateSettings(filename As String)
        Dim ep As String = "", TheDarkOne As String = MemoryBank.AllMagicComesWithAPrice, TheLock As String
        If Not MainForm.PFXPassButton.Text = "Loaded" Then
            TheLock = MainForm.PFXPassText.Text
        Else
            MemoryBank.KeyInMemory = Tools.FindStartsWithInFile(filename, "Key=").Replace("Key=", "")
            Dim wrapper As New ClarkTribeGames.Coder(TheDarkOne)
            Dim dec As String = Tools.CTGExtractor(MemoryBank.KeyInMemory)
            TheLock = wrapper.DecryptData(dec)
        End If
        If Not System.IO.File.Exists(filename) Then
            Try
                Dim fs As System.IO.FileStream = System.IO.File.Create(filename)
                Dim info As Byte() = New System.Text.UTF8Encoding(True).GetBytes("[CTGCodeSigningTool Settings]" & vbCrLf)
                fs.Write(info, 0, info.Length)
                fs.Dispose()
                fs.Close()
            Catch ex As Exception
                Logger.Logger.WriteToLog(0, "CreateSettings-FileCreation",
                    "Something went wrong with creating settings during file creation.", ex)
            End Try
        Else
            Try
                Tools.UnhideFile(MemoryBank.SettingsFile)
                System.IO.File.WriteAllText(filename, "[CTGCodeSigningTool Settings]" & vbCrLf)
            Catch ex As Exception
                Logger.Logger.WriteToLog(0, "CreateSettings-CreateNew",
                "Something went wrong with creating settings during new creation of config.", ex)
            End Try
        End If
        Try
            Dim wrapper As New ClarkTribeGames.Coder(TheDarkOne)
            ep = wrapper.EncryptData(TheLock)
        Catch ex As Exception
            Logger.Logger.WriteToLog(0, "CreateSettings-Encoder",
                "Something went wrong with creating settings during encryption.", ex)
        End Try
        Dim SettingsBuilder As New System.Text.StringBuilder
        SettingsBuilder.Append("Tool=").Append(MainForm.ToolText.Text).Append(vbCrLf).Append("Stamp=").
            Append(MainForm.TimestampDrop.Text).Append(vbCrLf).Append("PFX=").Append(MainForm.PFXFileText.Text).
            Append(vbCrLf).Append("Key=").Append(Tools.CTGRBuilder(ep).ToString).Append(vbCrLf).Append("File=").
            Append(MainForm.FileText.Text).Append(vbCrLf).Append("Answer=").Append(TheLock)
        Try
            Tools.TextWriter(filename, SettingsBuilder.ToString, True)
        Catch ex As Exception
            Logger.Logger.WriteToLog(0, "CreateSettings-Writing",
                "Something went wrong with creating settings during writing.", ex)
        End Try
        MemoryBank.KeyInMemory = ""
    End Sub
    Private Shared Sub LoadSettings(filename As String)
        If Not (Tools.FindStartsWithInFile(filename, "[CTGCodeSigningTool Settings]")) = "[CTGCodeSigningTool Settings]" Then
            MsgBox("Invalid Settings File.", vbCritical + vbOKOnly)
            Exit Sub
        End If
        MainForm.ToolText.Text = Tools.FindStartsWithInFile(filename, "Tool=").Replace("Tool=", "")
        MainForm.TimestampDrop.SelectedIndex = 0
        MainForm.PFXFileText.Text = Tools.FindStartsWithInFile(filename, "PFX=").Replace("PFX=", "")
        MemoryBank.KeyInMemory = Tools.FindStartsWithInFile(filename, "Key=").Replace("Key=", "")
        MainForm.FileText.Text = Tools.FindStartsWithInFile(filename, "File=").Replace("File=", "")
        MainForm.PFXPassButton.Text = "Loaded"
        Tools.ButtonChange(MainForm.PFXPassButton, False)
        MainForm.PFXPassText.Text = ""
        MainForm.PFXPassText.Enabled = False
        MainForm.SaveCheck.CheckState = CheckState.Checked
    End Sub
    Private Shared Sub SaveSettings(filename As String)
        If Execute.NothingEmpty() = False Then Exit Sub
        CreateSettings(filename)
        MainForm.SaveCheck.CheckState = CheckState.Checked
    End Sub

End Class
