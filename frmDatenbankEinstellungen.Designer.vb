<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatenbankEinstellungen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatenbankEinstellungen))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDatenbank = New System.Windows.Forms.TextBox()
        Me.btnDBTest = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPasswort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.cmbMandant = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MainStatus = New System.Windows.Forms.StatusStrip()
        Me.msgMaster = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnDBNew = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MainStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "JTL Wawi Datenbankname"
        '
        'txtDatenbank
        '
        Me.txtDatenbank.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDatenbank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatenbank.Location = New System.Drawing.Point(15, 181)
        Me.txtDatenbank.Name = "txtDatenbank"
        Me.txtDatenbank.Size = New System.Drawing.Size(458, 20)
        Me.txtDatenbank.TabIndex = 11
        Me.txtDatenbank.Text = "eazybusiness"
        '
        'btnDBTest
        '
        Me.btnDBTest.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnDBTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDBTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBTest.Location = New System.Drawing.Point(15, 371)
        Me.btnDBTest.Name = "btnDBTest"
        Me.btnDBTest.Size = New System.Drawing.Size(265, 23)
        Me.btnDBTest.TabIndex = 15
        Me.btnDBTest.Text = "MSSQL Verbindung anlegen"
        Me.btnDBTest.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "MSSQL Passwort"
        '
        'txtPasswort
        '
        Me.txtPasswort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPasswort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswort.Location = New System.Drawing.Point(16, 293)
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswort.Size = New System.Drawing.Size(458, 20)
        Me.txtPasswort.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "MSSQL Benutzername"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Location = New System.Drawing.Point(16, 236)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(458, 20)
        Me.txtUsername.TabIndex = 12
        Me.txtUsername.Text = "sa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "JTL Wawi MSSQL Datenbank Servername \ Instanz"
        '
        'txtServerName
        '
        Me.txtServerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServerName.Location = New System.Drawing.Point(16, 125)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(458, 20)
        Me.txtServerName.TabIndex = 9
        Me.txtServerName.Text = "127.0.0.1\JTLWawi"
        '
        'cmbMandant
        '
        Me.cmbMandant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMandant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMandant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMandant.FormattingEnabled = True
        Me.cmbMandant.Location = New System.Drawing.Point(17, 341)
        Me.cmbMandant.Name = "cmbMandant"
        Me.cmbMandant.Size = New System.Drawing.Size(457, 21)
        Me.cmbMandant.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Editierbare angelegte JTL Wawi Mandanten"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(459, 84)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'MainStatus
        '
        Me.MainStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msgMaster})
        Me.MainStatus.Location = New System.Drawing.Point(0, 417)
        Me.MainStatus.Name = "MainStatus"
        Me.MainStatus.Size = New System.Drawing.Size(483, 22)
        Me.MainStatus.TabIndex = 21
        '
        'msgMaster
        '
        Me.msgMaster.Name = "msgMaster"
        Me.msgMaster.Size = New System.Drawing.Size(0, 17)
        '
        'btnDBNew
        '
        Me.btnDBNew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDBNew.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnDBNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDBNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBNew.Location = New System.Drawing.Point(286, 370)
        Me.btnDBNew.Name = "btnDBNew"
        Me.btnDBNew.Size = New System.Drawing.Size(185, 23)
        Me.btnDBNew.TabIndex = 22
        Me.btnDBNew.Text = "&Weiteren Mandant anlegen"
        Me.btnDBNew.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(224, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(250, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Jeder JTL Mandant verfügt über eigene Datenbank"
        '
        'frmDatenbankEinstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(483, 439)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDBNew)
        Me.Controls.Add(Me.MainStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbMandant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDatenbank)
        Me.Controls.Add(Me.btnDBTest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPasswort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtServerName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(308, 389)
        Me.Name = "frmDatenbankEinstellungen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "JTL Newsletter Microsoft SQL Datenbankverbindung"
        Me.MainStatus.ResumeLayout(False)
        Me.MainStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDatenbank As System.Windows.Forms.TextBox
    Friend WithEvents btnDBTest As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPasswort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents cmbMandant As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MainStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents msgMaster As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnDBNew As System.Windows.Forms.Button
    Friend WithEvents Label7 As Label
End Class
