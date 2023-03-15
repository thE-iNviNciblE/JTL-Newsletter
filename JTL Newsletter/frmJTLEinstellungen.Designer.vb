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
        Me.SuspendLayout()
        '
        'txtShopURL
        '
        Me.txtShopURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShopURL.Location = New System.Drawing.Point(15, 25)
        Me.txtShopURL.Name = "txtShopURL"
        Me.txtShopURL.Size = New System.Drawing.Size(300, 20)
        Me.txtShopURL.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "JTL Newsletter Abmelden"
        '
        'btnSpeichernOK
        '
        Me.btnSpeichernOK.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnSpeichernOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeichernOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeichernOK.Location = New System.Drawing.Point(15, 51)
        Me.btnSpeichernOK.Name = "btnSpeichernOK"
        Me.btnSpeichernOK.Size = New System.Drawing.Size(89, 23)
        Me.btnSpeichernOK.TabIndex = 12
        Me.btnSpeichernOK.Text = "&Speichern"
        Me.btnSpeichernOK.UseVisualStyleBackColor = False
        '
        'chkProgramSettingsDelete
        '
        Me.chkProgramSettingsDelete.AutoSize = True
        Me.chkProgramSettingsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkProgramSettingsDelete.Location = New System.Drawing.Point(15, 88)
        Me.chkProgramSettingsDelete.Name = "chkProgramSettingsDelete"
        Me.chkProgramSettingsDelete.Size = New System.Drawing.Size(178, 17)
        Me.chkProgramSettingsDelete.TabIndex = 13
        Me.chkProgramSettingsDelete.Text = "Programmeinstellungen löschen?"
        Me.chkProgramSettingsDelete.UseVisualStyleBackColor = True
        '
        'frmJTLEinstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 117)
        Me.Controls.Add(Me.chkProgramSettingsDelete)
        Me.Controls.Add(Me.btnSpeichernOK)
        Me.Controls.Add(Me.txtShopURL)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmJTLEinstellungen"
        Me.Text = "JTL Einstellungen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtShopURL As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSpeichernOK As System.Windows.Forms.Button
    Friend WithEvents chkProgramSettingsDelete As System.Windows.Forms.CheckBox
End Class
