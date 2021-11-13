Public Class Execute
    Public Shared Sub CheckChanges(type As String, checkbox As CheckBox, textbox As TextBox,
        drop As ComboBox, button As Button)
        Select Case LCase(type)
            Case "check"
                If checkbox.CheckState = CheckState.Checked Then
                    textbox.Text = ""
                    textbox.Enabled = True
                Else
                    textbox.Text = ""
                    textbox.Enabled = False
                End If
            Case "key"
                If textbox.TextLength > 0 Then Tools.ButtonChange(button, True) Else Tools.ButtonChange(button, False)
            Case "drop"
                If drop.Text.Length > 0 Then Tools.ButtonChange(button, True) Else Tools.ButtonChange(button, False)
        End Select
    End Sub
    Public Shared Sub LoadFile(type As String, textbox As TextBox)
        Dim Desc As String = "", SelectedDir As String = "", Ext() As String = {""}, ExtGroup As String = "",
            ExtDesc As String = "", SourceFile As String = "", NewFile As String = "",
            SelectedFileName As String = "", CertInfo As String = vbNull
        Select Case LCase(type)
            Case "tool"
                Desc = "Location of SignTool.exe"
                SelectedDir = "C:\Program Files (x86)\Windows Kits\10\bin\10.0.19041.0\x64\"
                Ext = {".exe"}
                ExtDesc = "SignTool File"
                SelectedFileName = "SignTool*"
            Case "pfx"
                Desc = "Location of the Coding Signing Certificate PFX File"
                SelectedDir = My.Computer.FileSystem.CurrentDirectory
                Ext = {".pfx"}
                ExtDesc = "PFX Files"
            Case "file"
                Desc = "Location of File to be Signed"
                SelectedDir = My.Computer.FileSystem.CurrentDirectory
                Ext = {".exe", ".ocx", ".dll", ".cab"}
                ExtDesc = "Signable Files"
        End Select
        For Each ExtName In Ext
            ExtGroup &= "*" & ExtName & ", "
        Next
        ExtGroup = ExtGroup.Substring(0, ExtGroup.Length - 2)
        ExtDesc &= " " & "(" & ExtGroup & ")|" & ExtGroup.Replace(",", ";")
        Dim fd As New OpenFileDialog With {
            .Title = Desc,
            .InitialDirectory = SelectedDir,
            .FileName = SelectedFileName,
            .Filter = ExtDesc,
            .FilterIndex = 1,
            .RestoreDirectory = True,
            .Multiselect = False
        }
        If fd.ShowDialog() = DialogResult.OK Then
            SourceFile = fd.FileName
            Dim ConfirmExt As String = LCase(SourceFile.Substring(SourceFile.Length - 4, 4))
            Select Case LCase(type)
                Case "tool"
                    Try
                        CertInfo =
                            System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromSignedFile(SourceFile).ToString(True)
                    Catch ex As Exception
                        CertInfo = ""
                    End Try
                    If Not InStr(LCase(CertInfo), "microsoft corporation", CompareMethod.Text) = 0 Then
                        textbox.Text = SourceFile
                    Else
                        MsgBox("Please select the correct version of SignTool.exe and Try Again.")
                        textbox.Text = ""
                    End If
                Case Else
                    If Not InStr(ExtGroup, ConfirmExt, CompareMethod.Text) = 0 Then
                        textbox.Text = SourceFile
                    Else
                        MsgBox("Please select the correct file type (" & ExtGroup & ") and Try Again.")
                    End If
            End Select

        End If
    End Sub
    Public Shared Sub PFXPassword(textbox As TextBox, button As Button)
        Select Case LCase(MainForm.PFXPassButton.Text)
            Case "confirm"
                button.Text = "Change"
                Tools.ButtonChange(button, True)
                textbox.ReadOnly = True
            Case "change"
                button.Text = "Confirm"
                textbox.Text = ""
                textbox.ReadOnly = False
        End Select
    End Sub
    Public Shared Sub GoTime()
        If NothingEmpty() = False Then Exit Sub
        If MainForm.SaveCheck.CheckState = CheckState.Checked Then Settings.SettingsAction("save", MemoryBank.SettingsFile)
        MemoryBank.KeyInMemory = ""
        Dim TryAgainDearie As String = ""
        If Not MainForm.PFXPassButton.Text = "Loaded" Then
            TryAgainDearie = MainForm.PFXPassText.Text
        Else
            Dim TheDagger As String = MemoryBank.AllMagicComesWithAPrice, ep As String
            MemoryBank.KeyInMemory = Tools.FindStartsWithInFile(MemoryBank.SettingsFile, "Key=").Replace("Key=", "")
            Try
                Dim wrapper As New ClarkTribeGames.Coder(TheDagger)
                ep = Tools.CTGExtractor(MemoryBank.KeyInMemory)
                TryAgainDearie = wrapper.DecryptData(ep)
            Catch ex As Exception
                Logger.Logger.WriteToLog(0, "GoTime-Decoder",
                "Something went wrong with executing during decryption.", ex)
            End Try
        End If
        Dim Args As String = "sign /tr " & Chr(34) & MainForm.TimestampDrop.Text & Chr(34) &
            " /td sha256 /fd sha256 /f " & Chr(34) & MainForm.PFXFileText.Text & Chr(34) &
            " /p " & TryAgainDearie & " " & Chr(34) & MainForm.FileText.Text & Chr(34)
        Dim pHelp As New ProcessStartInfo With {
            .FileName = MainForm.ToolText.Text,
            .Arguments = Args,
            .UseShellExecute = True,
            .WindowStyle = ProcessWindowStyle.Normal
        }
        Dim proc As Process = Process.Start(pHelp)
    End Sub
    Public Shared Function NothingEmpty() As Boolean
        Dim Message As New System.Text.StringBuilder, Counter As Integer = 0
        If MainForm.ToolText.Text = "" Then
            Message.AppendLine("Sign Tool Path is Missing!")
            Counter += 1
        End If
        If MainForm.PFXFileText.Text = "" Then
            Message.AppendLine("PFX File Path is Missing!")
            Counter += 1
        End If
        If MainForm.PFXPassButton.Text = "Confirm" Then
            Message.AppendLine("Please CONFIRM PFX Password!")
            Counter += 1
        End If
        If MainForm.FileText.Text = "" Then
            Message.AppendLine("File to Sign Path is Missing!")
            Counter += 1
        End If
        If Counter > 0 Then
            MsgBox("Warning:" & vbCrLf & vbCrLf & Message.ToString, vbCritical + vbOKOnly)
            Return False
        Else
            Return True
        End If
    End Function

End Class
