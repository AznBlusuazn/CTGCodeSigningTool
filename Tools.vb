Public Class Tools
    Public Shared Sub TextWriter(file As String, text As String, type As Boolean)
        Dim TextWriter As New System.IO.StreamWriter(file, type)
        TextWriter.WriteLine(text)
        TextWriter.Dispose()
        TextWriter.Close()
    End Sub
    Public Shared Function TestKeyPress(key As String) As Boolean
        Dim AllowedKeys As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-.0123456789!@#$%^*()_+|}{?><,./[]\-=~`"
        If Not AllowedKeys.Contains(key) Then
            MainForm.InvalidLabel.Visible = True
            WarningSound()
            Return True
        Else
            MainForm.InvalidLabel.Visible = False
            Return False
        End If
    End Function
    Public Shared Function ControlToString(sender As Object) As String
        Return DirectCast(sender, Object).Name.ToLower.Replace("clear", "")
    End Function
    Public Shared Sub ButtonChange(button As Button, action As Boolean)
        button.Enabled = action
        If action = True Then button.BackColor = SystemColors.Desktop Else button.BackColor = Color.DarkGray
    End Sub
    Public Shared Function CTGEncoderLoader(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("CTGCodeSigningTool.CTGEncoder.dll")
            Dim assemblyData = New Byte(stream.Length - 1) {}
            stream.Read(assemblyData, 0, assemblyData.Length)
            Return System.Reflection.Assembly.Load(assemblyData)
        End Using
    End Function
    Public Shared Function CTGRBuilder(text As String)
        Dim TimeLimit As Integer = text.Length, Playground As String =
            "1234567890-=qwertyuiop[]\asdfghjkl;zxcvbnm,./?><MNBVCXZ:LKJHGFDSA}{POIUYTREWQ+_)(*^%$#@!~` ",
            FunTime As New System.Text.StringBuilder, Recess As New System.Text.StringBuilder,
            Whistle As New System.Text.StringBuilder
        For i = 1 To TimeLimit
            FunTime.Append(Playground.Substring(Int((90 * Rnd()) + 1), 1))
        Next
        Whistle.Append(CStr(Int((99 * Rnd()) + 10))).Append(TimeLimit).Append(FunTime.ToString).Append(text).Append(Chr(39)).
            Append(CStr(Int((99 * Rnd()) + 10)))
        For i = 1 To (Int((999 * Rnd()) + 1))
            Recess.Append(Playground.Substring(Int((90 * Rnd()) + 1), 1))
        Next
        Whistle.Append(Recess.ToString)
        Return Whistle
    End Function

    Public Shared Function CTGExtractor(text As String) As String
        Dim SealTeam As Integer = CInt(text.Substring(2, 2)), DivideAndConquer As String = text.Split(Chr(39))(0)
        Dim FinalS As String = DivideAndConquer.Substring(SealTeam + 4, DivideAndConquer.Length - SealTeam - 4)
        Return FinalS
    End Function
    Public Shared Function FindStartsWithInFile(filename As String, startingtext As String)
        Dim lines = System.IO.File.ReadAllLines(filename), FoundIt As String = ""
        For i = 0 To lines.Length - 1
            If lines(i).StartsWith(startingtext) Then
                FoundIt = lines(i).ToString
            End If
        Next
        Return FoundIt
    End Function
    Public Shared Sub WarningSound()
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
    End Sub
End Class
