<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ToolLabel = New System.Windows.Forms.Label()
        Me.TimestampLabel = New System.Windows.Forms.Label()
        Me.PFXPathLabel = New System.Windows.Forms.Label()
        Me.ToolText = New System.Windows.Forms.TextBox()
        Me.PFXFileText = New System.Windows.Forms.TextBox()
        Me.PFXPassLabel = New System.Windows.Forms.Label()
        Me.PFXPassText = New System.Windows.Forms.TextBox()
        Me.FilePathLabel = New System.Windows.Forms.Label()
        Me.FileText = New System.Windows.Forms.TextBox()
        Me.ToolButton = New System.Windows.Forms.Button()
        Me.TimestampButton = New System.Windows.Forms.Button()
        Me.PFXFileButton = New System.Windows.Forms.Button()
        Me.PFXPassButton = New System.Windows.Forms.Button()
        Me.FileButton = New System.Windows.Forms.Button()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.SaveCheck = New System.Windows.Forms.CheckBox()
        Me.FBButton = New System.Windows.Forms.Button()
        Me.DCButton = New System.Windows.Forms.Button()
        Me.MailButton = New System.Windows.Forms.Button()
        Me.DonateButton = New System.Windows.Forms.Button()
        Me.PTButton = New System.Windows.Forms.Button()
        Me.TimestampDrop = New System.Windows.Forms.ComboBox()
        Me.ToolLink = New System.Windows.Forms.LinkLabel()
        Me.InvalidLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(12, 36)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(642, 36)
        Me.TitleLabel.TabIndex = 12
        Me.TitleLabel.Text = "ClarkTribeGames Code Signing Tool"
        '
        'ToolLabel
        '
        Me.ToolLabel.Location = New System.Drawing.Point(25, 100)
        Me.ToolLabel.Name = "ToolLabel"
        Me.ToolLabel.Size = New System.Drawing.Size(115, 21)
        Me.ToolLabel.TabIndex = 13
        Me.ToolLabel.Text = "Sign Tool Path:"
        Me.ToolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimestampLabel
        '
        Me.TimestampLabel.Location = New System.Drawing.Point(25, 152)
        Me.TimestampLabel.Name = "TimestampLabel"
        Me.TimestampLabel.Size = New System.Drawing.Size(115, 21)
        Me.TimestampLabel.TabIndex = 14
        Me.TimestampLabel.Text = "Timestamp URL:"
        Me.TimestampLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PFXPathLabel
        '
        Me.PFXPathLabel.Location = New System.Drawing.Point(25, 204)
        Me.PFXPathLabel.Name = "PFXPathLabel"
        Me.PFXPathLabel.Size = New System.Drawing.Size(115, 21)
        Me.PFXPathLabel.TabIndex = 15
        Me.PFXPathLabel.Text = "PFX File Path:"
        Me.PFXPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolText
        '
        Me.ToolText.BackColor = System.Drawing.SystemColors.Desktop
        Me.ToolText.ForeColor = System.Drawing.SystemColors.Window
        Me.ToolText.Location = New System.Drawing.Point(150, 100)
        Me.ToolText.Name = "ToolText"
        Me.ToolText.ReadOnly = True
        Me.ToolText.Size = New System.Drawing.Size(400, 21)
        Me.ToolText.TabIndex = 0
        '
        'PFXFileText
        '
        Me.PFXFileText.BackColor = System.Drawing.SystemColors.Desktop
        Me.PFXFileText.ForeColor = System.Drawing.SystemColors.Window
        Me.PFXFileText.Location = New System.Drawing.Point(150, 204)
        Me.PFXFileText.Name = "PFXFileText"
        Me.PFXFileText.ReadOnly = True
        Me.PFXFileText.Size = New System.Drawing.Size(400, 21)
        Me.PFXFileText.TabIndex = 4
        '
        'PFXPassLabel
        '
        Me.PFXPassLabel.Location = New System.Drawing.Point(25, 256)
        Me.PFXPassLabel.Name = "PFXPassLabel"
        Me.PFXPassLabel.Size = New System.Drawing.Size(115, 21)
        Me.PFXPassLabel.TabIndex = 16
        Me.PFXPassLabel.Text = "PFX Password:"
        Me.PFXPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PFXPassText
        '
        Me.PFXPassText.BackColor = System.Drawing.SystemColors.Desktop
        Me.PFXPassText.ForeColor = System.Drawing.SystemColors.Window
        Me.PFXPassText.Location = New System.Drawing.Point(150, 256)
        Me.PFXPassText.Name = "PFXPassText"
        Me.PFXPassText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PFXPassText.Size = New System.Drawing.Size(400, 21)
        Me.PFXPassText.TabIndex = 6
        '
        'FilePathLabel
        '
        Me.FilePathLabel.Location = New System.Drawing.Point(25, 308)
        Me.FilePathLabel.Name = "FilePathLabel"
        Me.FilePathLabel.Size = New System.Drawing.Size(115, 21)
        Me.FilePathLabel.TabIndex = 17
        Me.FilePathLabel.Text = "File to Sign:"
        Me.FilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FileText
        '
        Me.FileText.BackColor = System.Drawing.SystemColors.Desktop
        Me.FileText.ForeColor = System.Drawing.SystemColors.Window
        Me.FileText.Location = New System.Drawing.Point(150, 308)
        Me.FileText.Name = "FileText"
        Me.FileText.ReadOnly = True
        Me.FileText.Size = New System.Drawing.Size(400, 21)
        Me.FileText.TabIndex = 8
        '
        'ToolButton
        '
        Me.ToolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolButton.Location = New System.Drawing.Point(575, 99)
        Me.ToolButton.Name = "ToolButton"
        Me.ToolButton.Size = New System.Drawing.Size(75, 25)
        Me.ToolButton.TabIndex = 1
        Me.ToolButton.Text = "Select"
        Me.ToolButton.UseVisualStyleBackColor = True
        '
        'TimestampButton
        '
        Me.TimestampButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TimestampButton.Location = New System.Drawing.Point(575, 151)
        Me.TimestampButton.Name = "TimestampButton"
        Me.TimestampButton.Size = New System.Drawing.Size(75, 25)
        Me.TimestampButton.TabIndex = 3
        Me.TimestampButton.Text = "Confirm"
        Me.TimestampButton.UseVisualStyleBackColor = True
        '
        'PFXFileButton
        '
        Me.PFXFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PFXFileButton.Location = New System.Drawing.Point(575, 203)
        Me.PFXFileButton.Name = "PFXFileButton"
        Me.PFXFileButton.Size = New System.Drawing.Size(75, 25)
        Me.PFXFileButton.TabIndex = 5
        Me.PFXFileButton.Text = "Select"
        Me.PFXFileButton.UseVisualStyleBackColor = True
        '
        'PFXPassButton
        '
        Me.PFXPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PFXPassButton.Location = New System.Drawing.Point(575, 255)
        Me.PFXPassButton.Name = "PFXPassButton"
        Me.PFXPassButton.Size = New System.Drawing.Size(75, 25)
        Me.PFXPassButton.TabIndex = 7
        Me.PFXPassButton.Text = "Confirm"
        Me.PFXPassButton.UseVisualStyleBackColor = True
        '
        'FileButton
        '
        Me.FileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FileButton.Location = New System.Drawing.Point(575, 307)
        Me.FileButton.Name = "FileButton"
        Me.FileButton.Size = New System.Drawing.Size(75, 25)
        Me.FileButton.TabIndex = 9
        Me.FileButton.Text = "Select"
        Me.FileButton.UseVisualStyleBackColor = True
        '
        'GoButton
        '
        Me.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoButton.Location = New System.Drawing.Point(575, 359)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(75, 25)
        Me.GoButton.TabIndex = 11
        Me.GoButton.Text = "Execute"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'SaveCheck
        '
        Me.SaveCheck.Location = New System.Drawing.Point(428, 357)
        Me.SaveCheck.Name = "SaveCheck"
        Me.SaveCheck.Size = New System.Drawing.Size(122, 29)
        Me.SaveCheck.TabIndex = 10
        Me.SaveCheck.Text = "Save Settings"
        Me.SaveCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveCheck.UseVisualStyleBackColor = True
        '
        'FBButton
        '
        Me.FBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FBButton.Location = New System.Drawing.Point(24, 359)
        Me.FBButton.Name = "FBButton"
        Me.FBButton.Size = New System.Drawing.Size(75, 25)
        Me.FBButton.TabIndex = 19
        Me.FBButton.Text = "Facebook"
        Me.FBButton.UseVisualStyleBackColor = True
        '
        'DCButton
        '
        Me.DCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DCButton.Location = New System.Drawing.Point(105, 359)
        Me.DCButton.Name = "DCButton"
        Me.DCButton.Size = New System.Drawing.Size(75, 25)
        Me.DCButton.TabIndex = 20
        Me.DCButton.Text = "Discord"
        Me.DCButton.UseVisualStyleBackColor = True
        '
        'MailButton
        '
        Me.MailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MailButton.Location = New System.Drawing.Point(185, 359)
        Me.MailButton.Name = "MailButton"
        Me.MailButton.Size = New System.Drawing.Size(75, 25)
        Me.MailButton.TabIndex = 21
        Me.MailButton.Text = "E-Mail"
        Me.MailButton.UseVisualStyleBackColor = True
        '
        'DonateButton
        '
        Me.DonateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DonateButton.Location = New System.Drawing.Point(265, 359)
        Me.DonateButton.Name = "DonateButton"
        Me.DonateButton.Size = New System.Drawing.Size(75, 25)
        Me.DonateButton.TabIndex = 22
        Me.DonateButton.Text = "Donate"
        Me.DonateButton.UseVisualStyleBackColor = True
        '
        'PTButton
        '
        Me.PTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PTButton.Location = New System.Drawing.Point(345, 359)
        Me.PTButton.Name = "PTButton"
        Me.PTButton.Size = New System.Drawing.Size(75, 25)
        Me.PTButton.TabIndex = 23
        Me.PTButton.Text = "Patreon"
        Me.PTButton.UseVisualStyleBackColor = True
        '
        'TimestampDrop
        '
        Me.TimestampDrop.AutoCompleteCustomSource.AddRange(New String() {"http://timestamp.verisign.com/scripts/timstamp.dll", "http://timestamp.globalsign.com/scripts/timstamp.dll", "http://timestamp.comodoca.com/authenticode", "http://tsa.starfieldtech.com", "http://timestamp.digicert.com"})
        Me.TimestampDrop.BackColor = System.Drawing.SystemColors.Desktop
        Me.TimestampDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TimestampDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TimestampDrop.ForeColor = System.Drawing.SystemColors.Window
        Me.TimestampDrop.FormattingEnabled = True
        Me.TimestampDrop.Items.AddRange(New Object() {"http://timestamp.digicert.com"})
        Me.TimestampDrop.Location = New System.Drawing.Point(150, 152)
        Me.TimestampDrop.Name = "TimestampDrop"
        Me.TimestampDrop.Size = New System.Drawing.Size(400, 23)
        Me.TimestampDrop.TabIndex = 24
        '
        'ToolLink
        '
        Me.ToolLink.AutoSize = True
        Me.ToolLink.LinkColor = System.Drawing.Color.Yellow
        Me.ToolLink.Location = New System.Drawing.Point(150, 128)
        Me.ToolLink.Name = "ToolLink"
        Me.ToolLink.Size = New System.Drawing.Size(322, 15)
        Me.ToolLink.TabIndex = 25
        Me.ToolLink.TabStop = True
        Me.ToolLink.Text = "Download Microsoft SDK to obtain SignTool.exe"
        Me.ToolLink.VisitedLinkColor = System.Drawing.Color.Red
        '
        'InvalidLabel
        '
        Me.InvalidLabel.AutoSize = True
        Me.InvalidLabel.ForeColor = System.Drawing.Color.Red
        Me.InvalidLabel.Location = New System.Drawing.Point(150, 284)
        Me.InvalidLabel.Name = "InvalidLabel"
        Me.InvalidLabel.Size = New System.Drawing.Size(406, 15)
        Me.InvalidLabel.TabIndex = 26
        Me.InvalidLabel.Text = "Invalid Character:  ' "" : ; & and {space} are not allowed!"
        Me.InvalidLabel.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsMenuItem
        '
        Me.OptionsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadMenuItem, Me.SaveMenuItem, Me.ClearMenuItem, Me.CheckMenuItem, Me.ExitMenuItem})
        Me.OptionsMenuItem.ForeColor = System.Drawing.Color.Black
        Me.OptionsMenuItem.Name = "OptionsMenuItem"
        Me.OptionsMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsMenuItem.Text = "Options"
        '
        'LoadMenuItem
        '
        Me.LoadMenuItem.Name = "LoadMenuItem"
        Me.LoadMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LoadMenuItem.Text = "Load Settings"
        '
        'SaveMenuItem
        '
        Me.SaveMenuItem.Name = "SaveMenuItem"
        Me.SaveMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SaveMenuItem.Text = "Save Settings"
        '
        'ClearMenuItem
        '
        Me.ClearMenuItem.Name = "ClearMenuItem"
        Me.ClearMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ClearMenuItem.Text = "Clear Fields"
        '
        'CheckMenuItem
        '
        Me.CheckMenuItem.Name = "CheckMenuItem"
        Me.CheckMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CheckMenuItem.Text = "Check For Updates"
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.Name = "ExitMenuItem"
        Me.ExitMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ExitMenuItem.Text = "Exit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(684, 411)
        Me.Controls.Add(Me.InvalidLabel)
        Me.Controls.Add(Me.ToolLink)
        Me.Controls.Add(Me.TimestampDrop)
        Me.Controls.Add(Me.PTButton)
        Me.Controls.Add(Me.DonateButton)
        Me.Controls.Add(Me.MailButton)
        Me.Controls.Add(Me.DCButton)
        Me.Controls.Add(Me.FBButton)
        Me.Controls.Add(Me.SaveCheck)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.FileButton)
        Me.Controls.Add(Me.PFXPassButton)
        Me.Controls.Add(Me.PFXFileButton)
        Me.Controls.Add(Me.TimestampButton)
        Me.Controls.Add(Me.ToolButton)
        Me.Controls.Add(Me.FileText)
        Me.Controls.Add(Me.FilePathLabel)
        Me.Controls.Add(Me.PFXPassText)
        Me.Controls.Add(Me.PFXPassLabel)
        Me.Controls.Add(Me.PFXFileText)
        Me.Controls.Add(Me.ToolText)
        Me.Controls.Add(Me.PFXPathLabel)
        Me.Controls.Add(Me.TimestampLabel)
        Me.Controls.Add(Me.ToolLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.Text = "ClarkTribeGames Code Signing Tool"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents ToolLabel As Label
    Friend WithEvents TimestampLabel As Label
    Friend WithEvents PFXPathLabel As Label
    Friend WithEvents ToolText As TextBox
    Friend WithEvents PFXFileText As TextBox
    Friend WithEvents PFXPassLabel As Label
    Friend WithEvents PFXPassText As TextBox
    Friend WithEvents FilePathLabel As Label
    Friend WithEvents FileText As TextBox
    Friend WithEvents ToolButton As Button
    Friend WithEvents TimestampButton As Button
    Friend WithEvents PFXFileButton As Button
    Friend WithEvents PFXPassButton As Button
    Friend WithEvents FileButton As Button
    Friend WithEvents GoButton As Button
    Friend WithEvents SaveCheck As CheckBox
    Friend WithEvents FBButton As Button
    Friend WithEvents DCButton As Button
    Friend WithEvents MailButton As Button
    Friend WithEvents DonateButton As Button
    Friend WithEvents PTButton As Button
    Friend WithEvents TimestampDrop As ComboBox
    Friend WithEvents ToolLink As LinkLabel
    Friend WithEvents InvalidLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsMenuItem As ToolStripMenuItem
    Friend WithEvents LoadMenuItem As ToolStripMenuItem
    Friend WithEvents SaveMenuItem As ToolStripMenuItem
    Friend WithEvents ClearMenuItem As ToolStripMenuItem
    Friend WithEvents CheckMenuItem As ToolStripMenuItem
    Friend WithEvents ExitMenuItem As ToolStripMenuItem
End Class
