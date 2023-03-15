<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJTLEinstellungen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJTLEinstellungen))
        Me.txtShopURL = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSpeichernOK = New System.Windows.Forms.Button()
        Me.chkProgramSettingsDelete = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLinkOnlineHelp = New System.Windows.Forms.LinkLabel()
        Me.txtJTLShopConnector = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJTLShopPlugin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.chkKomplettabgleich = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtShopURL
        '
        Me.txtShopURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShopURL.Location = New System.Drawing.Point(28, 174)
        Me.txtShopURL.Name = "txtShopURL"
        Me.txtShopURL.Size = New System.Drawing.Size(300, 20)
        Me.txtShopURL.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(307, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "JTL Newsletter Abmelden (newsletter_abmelden.php)"
        '
        'btnSpeichernOK
        '
        Me.btnSpeichernOK.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnSpeichernOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeichernOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeichernOK.Location = New System.Drawing.Point(29, 449)
        Me.btnSpeichernOK.Name = "btnSpeichernOK"
        Me.btnSpeichernOK.Size = New System.Drawing.Size(305, 23)
        Me.btnSpeichernOK.TabIndex = 12
        Me.btnSpeichernOK.Text = "&Einstellungen speichern"
        Me.btnSpeichernOK.UseVisualStyleBackColor = False
        '
        'chkProgramSettingsDelete
        '
        Me.chkProgramSettingsDelete.AutoSize = True
        Me.chkProgramSettingsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkProgramSettingsDelete.Location = New System.Drawing.Point(12, 2)
        Me.chkProgramSettingsDelete.Name = "chkProgramSettingsDelete"
        Me.chkProgramSettingsDelete.Size = New System.Drawing.Size(178, 17)
        Me.chkProgramSettingsDelete.TabIndex = 13
        Me.chkProgramSettingsDelete.Text = "Programmeinstellungen löschen?"
        Me.chkProgramSettingsDelete.UseVisualStyleBackColor = True
        Me.chkProgramSettingsDelete.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 54)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Laden Sie die JTL Shop Plugins herrunter und laden Sie im Order \includes\plugins" &
    "\ hoch gilt für die JTL Shop Plugins. newsletter_abmelden.php und .txt einfach p" &
    "er FTP ebenfalls hochladen."
        '
        'lblLinkOnlineHelp
        '
        Me.lblLinkOnlineHelp.AutoSize = True
        Me.lblLinkOnlineHelp.Location = New System.Drawing.Point(25, 91)
        Me.lblLinkOnlineHelp.Name = "lblLinkOnlineHelp"
        Me.lblLinkOnlineHelp.Size = New System.Drawing.Size(203, 13)
        Me.lblLinkOnlineHelp.TabIndex = 15
        Me.lblLinkOnlineHelp.TabStop = True
        Me.lblLinkOnlineHelp.Text = "Bludau Media JTL Newsletter Online Hilfe"
        '
        'txtJTLShopConnector
        '
        Me.txtJTLShopConnector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJTLShopConnector.Location = New System.Drawing.Point(28, 271)
        Me.txtJTLShopConnector.Name = "txtJTLShopConnector"
        Me.txtJTLShopConnector.Size = New System.Drawing.Size(300, 20)
        Me.txtJTLShopConnector.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 29)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "JTL Shop Connector (https://www.domain.de/JTLAppConnector)"
        '
        'txtJTLShopPlugin
        '
        Me.txtJTLShopPlugin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJTLShopPlugin.Location = New System.Drawing.Point(33, 364)
        Me.txtJTLShopPlugin.Name = "txtJTLShopPlugin"
        Me.txtJTLShopPlugin.Size = New System.Drawing.Size(300, 20)
        Me.txtJTLShopPlugin.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 26)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "JTL Shop Plugin (https://www.domain.de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/JBMNewsletter)"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(25, 146)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(149, 13)
        Me.LinkLabel1.TabIndex = 20
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Download PHP Abmeldescript"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(25, 247)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(197, 13)
        Me.LinkLabel2.TabIndex = 21
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Download JTL Shop Connector 4 Plugin"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(31, 339)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(198, 13)
        Me.LinkLabel3.TabIndex = 22
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Download JTL Shop 4 Newsletter Plugin"
        '
        'chkKomplettabgleich
        '
        Me.chkKomplettabgleich.AutoSize = True
        Me.chkKomplettabgleich.Location = New System.Drawing.Point(33, 406)
        Me.chkKomplettabgleich.Name = "chkKomplettabgleich"
        Me.chkKomplettabgleich.Size = New System.Drawing.Size(258, 17)
        Me.chkKomplettabgleich.TabIndex = 23
        Me.chkKomplettabgleich.Text = "Komplettabgleich aller Kunden (Aus = Quicksync)"
        Me.chkKomplettabgleich.UseVisualStyleBackColor = True
        '
        'frmJTLEinstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 484)
        Me.Controls.Add(Me.chkKomplettabgleich)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtJTLShopPlugin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJTLShopConnector)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLinkOnlineHelp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkProgramSettingsDelete)
        Me.Controls.Add(Me.btnSpeichernOK)
        Me.Controls.Add(Me.txtShopURL)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJTLEinstellungen"
        Me.Text = "JTL Wawi Connector Einstellungen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtShopURL As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSpeichernOK As System.Windows.Forms.Button
    Friend WithEvents chkProgramSettingsDelete As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLinkOnlineHelp As System.Windows.Forms.LinkLabel
    Friend WithEvents txtJTLShopConnector As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtJTLShopPlugin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents chkKomplettabgleich As CheckBox
End Class
