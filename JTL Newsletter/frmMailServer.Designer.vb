<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMailServer
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMailServer))
        Me.txtEmailAbsendeName = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtPOP3Port = New System.Windows.Forms.TextBox()
        Me.txtSMTPPort = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.cmbSMTPAnbieter = New System.Windows.Forms.ComboBox()
        Me.txteMailPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPOP3Server = New System.Windows.Forms.TextBox()
        Me.txtSMTPServer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txteMailUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTesteMail = New System.Windows.Forms.Button()
        Me.chkPop3BeforeSMTP = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtEmailAbsendeName
        '
        Me.txtEmailAbsendeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailAbsendeName.Location = New System.Drawing.Point(16, 302)
        Me.txtEmailAbsendeName.Name = "txtEmailAbsendeName"
        Me.txtEmailAbsendeName.Size = New System.Drawing.Size(249, 20)
        Me.txtEmailAbsendeName.TabIndex = 56
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(13, 286)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(92, 13)
        Me.Label58.TabIndex = 65
        Me.Label58.Text = "Absende Name"
        '
        'txtPOP3Port
        '
        Me.txtPOP3Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPOP3Port.Location = New System.Drawing.Point(201, 133)
        Me.txtPOP3Port.Name = "txtPOP3Port"
        Me.txtPOP3Port.Size = New System.Drawing.Size(64, 20)
        Me.txtPOP3Port.TabIndex = 53
        '
        'txtSMTPPort
        '
        Me.txtSMTPPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSMTPPort.Location = New System.Drawing.Point(200, 76)
        Me.txtSMTPPort.Name = "txtSMTPPort"
        Me.txtSMTPPort.Size = New System.Drawing.Size(65, 20)
        Me.txtSMTPPort.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(199, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "POP3 Port"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(199, 60)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(68, 13)
        Me.Label57.TabIndex = 64
        Me.Label57.Text = "SMTP Port"
        '
        'cmbSMTPAnbieter
        '
        Me.cmbSMTPAnbieter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSMTPAnbieter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSMTPAnbieter.FormattingEnabled = True
        Me.cmbSMTPAnbieter.Items.AddRange(New Object() {"Keine Auswahl", "GMX", "Google Mail", "Web", "Live"})
        Me.cmbSMTPAnbieter.Location = New System.Drawing.Point(14, 32)
        Me.cmbSMTPAnbieter.Name = "cmbSMTPAnbieter"
        Me.cmbSMTPAnbieter.Size = New System.Drawing.Size(247, 21)
        Me.cmbSMTPAnbieter.TabIndex = 49
        '
        'txteMailPassword
        '
        Me.txteMailPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txteMailPassword.Location = New System.Drawing.Point(15, 254)
        Me.txteMailPassword.Name = "txteMailPassword"
        Me.txteMailPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txteMailPassword.Size = New System.Drawing.Size(250, 20)
        Me.txteMailPassword.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Email Passwort"
        '
        'txtPOP3Server
        '
        Me.txtPOP3Server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPOP3Server.Location = New System.Drawing.Point(16, 133)
        Me.txtPOP3Server.Name = "txtPOP3Server"
        Me.txtPOP3Server.Size = New System.Drawing.Size(160, 20)
        Me.txtPOP3Server.TabIndex = 51
        '
        'txtSMTPServer
        '
        Me.txtSMTPServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSMTPServer.Location = New System.Drawing.Point(16, 76)
        Me.txtSMTPServer.Name = "txtSMTPServer"
        Me.txtSMTPServer.Size = New System.Drawing.Size(159, 20)
        Me.txtSMTPServer.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "POP3-Server"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Email Anbieter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "SMTP-Server"
        '
        'txteMailUser
        '
        Me.txteMailUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txteMailUser.Location = New System.Drawing.Point(16, 201)
        Me.txteMailUser.Name = "txteMailUser"
        Me.txteMailUser.Size = New System.Drawing.Size(249, 20)
        Me.txteMailUser.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Email Adresse"
        '
        'btnTesteMail
        '
        Me.btnTesteMail.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnTesteMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTesteMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTesteMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTesteMail.ImageIndex = 6
        Me.btnTesteMail.Location = New System.Drawing.Point(12, 328)
        Me.btnTesteMail.Name = "btnTesteMail"
        Me.btnTesteMail.Size = New System.Drawing.Size(253, 26)
        Me.btnTesteMail.TabIndex = 57
        Me.btnTesteMail.Text = "&eMail Versand testen"
        Me.btnTesteMail.UseVisualStyleBackColor = False
        '
        'chkPop3BeforeSMTP
        '
        Me.chkPop3BeforeSMTP.AutoSize = True
        Me.chkPop3BeforeSMTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPop3BeforeSMTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPop3BeforeSMTP.Location = New System.Drawing.Point(16, 159)
        Me.chkPop3BeforeSMTP.Name = "chkPop3BeforeSMTP"
        Me.chkPop3BeforeSMTP.Size = New System.Drawing.Size(133, 17)
        Me.chkPop3BeforeSMTP.TabIndex = 66
        Me.chkPop3BeforeSMTP.Text = "POP3 before SMTP"
        Me.chkPop3BeforeSMTP.UseVisualStyleBackColor = True
        '
        'frmMailServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 362)
        Me.Controls.Add(Me.chkPop3BeforeSMTP)
        Me.Controls.Add(Me.txtEmailAbsendeName)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.txtPOP3Port)
        Me.Controls.Add(Me.txtSMTPPort)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.cmbSMTPAnbieter)
        Me.Controls.Add(Me.txteMailPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPOP3Server)
        Me.Controls.Add(Me.txtSMTPServer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txteMailUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnTesteMail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMailServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JTL Newsletter - Mailserver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmailAbsendeName As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtPOP3Port As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPPort As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents cmbSMTPAnbieter As System.Windows.Forms.ComboBox
    Friend WithEvents txteMailPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPOP3Server As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPServer As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txteMailUser As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnTesteMail As System.Windows.Forms.Button
    Friend WithEvents chkPop3BeforeSMTP As System.Windows.Forms.CheckBox
End Class
