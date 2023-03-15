<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJTLSync
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJTLSync))
        Me.pgrStatus = New System.Windows.Forms.ProgressBar()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lvwJTLKunden = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNachname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOrt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFirma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKDNR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStrasse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnStopSync = New System.Windows.Forms.Button()
        Me.lblNeueJTLNewsletterKunden = New System.Windows.Forms.Label()
        Me.lblJTLNewsletterKundenExist = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pgrStatus
        '
        Me.pgrStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgrStatus.Location = New System.Drawing.Point(12, 51)
        Me.pgrStatus.Name = "pgrStatus"
        Me.pgrStatus.Size = New System.Drawing.Size(547, 23)
        Me.pgrStatus.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(14, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(547, 24)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "JTL Wawi Kunden mit Newsletter Tabelle synchronisieren"
        '
        'lvwJTLKunden
        '
        Me.lvwJTLKunden.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwJTLKunden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwJTLKunden.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colVorname, Me.colNachname, Me.colOrt, Me.colEmail, Me.colFirma, Me.colKDNR, Me.colStrasse, Me.colLand})
        Me.lvwJTLKunden.FullRowSelect = True
        Me.lvwJTLKunden.GridLines = True
        Me.lvwJTLKunden.HideSelection = False
        Me.lvwJTLKunden.Location = New System.Drawing.Point(12, 230)
        Me.lvwJTLKunden.Name = "lvwJTLKunden"
        Me.lvwJTLKunden.Size = New System.Drawing.Size(540, 171)
        Me.lvwJTLKunden.TabIndex = 11
        Me.lvwJTLKunden.UseCompatibleStateImageBehavior = False
        Me.lvwJTLKunden.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 0
        '
        'colVorname
        '
        Me.colVorname.Text = "Vorname"
        Me.colVorname.Width = 102
        '
        'colNachname
        '
        Me.colNachname.Text = "Nachname"
        Me.colNachname.Width = 102
        '
        'colOrt
        '
        Me.colOrt.Text = "Stadt"
        Me.colOrt.Width = 102
        '
        'colEmail
        '
        Me.colEmail.Text = "Email-Adresse"
        Me.colEmail.Width = 150
        '
        'colFirma
        '
        Me.colFirma.Text = "Firma"
        Me.colFirma.Width = 120
        '
        'colKDNR
        '
        Me.colKDNR.Text = "Kundennummer"
        Me.colKDNR.Width = 80
        '
        'colStrasse
        '
        Me.colStrasse.Text = "Straße"
        Me.colStrasse.Width = 150
        '
        'colLand
        '
        Me.colLand.Text = "Land"
        Me.colLand.Width = 120
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(12, 90)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(547, 73)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "..."
        '
        'btnStopSync
        '
        Me.btnStopSync.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStopSync.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnStopSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopSync.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStopSync.Location = New System.Drawing.Point(12, 187)
        Me.btnStopSync.Name = "btnStopSync"
        Me.btnStopSync.Size = New System.Drawing.Size(547, 23)
        Me.btnStopSync.TabIndex = 12
        Me.btnStopSync.Text = "Synchronisation  überspringen / beenden"
        Me.btnStopSync.UseVisualStyleBackColor = False
        '
        'lblNeueJTLNewsletterKunden
        '
        Me.lblNeueJTLNewsletterKunden.AutoSize = True
        Me.lblNeueJTLNewsletterKunden.Location = New System.Drawing.Point(249, 165)
        Me.lblNeueJTLNewsletterKunden.Name = "lblNeueJTLNewsletterKunden"
        Me.lblNeueJTLNewsletterKunden.Size = New System.Drawing.Size(0, 13)
        Me.lblNeueJTLNewsletterKunden.TabIndex = 14
        '
        'lblJTLNewsletterKundenExist
        '
        Me.lblJTLNewsletterKundenExist.AutoSize = True
        Me.lblJTLNewsletterKundenExist.Location = New System.Drawing.Point(15, 163)
        Me.lblJTLNewsletterKundenExist.Name = "lblJTLNewsletterKundenExist"
        Me.lblJTLNewsletterKundenExist.Size = New System.Drawing.Size(0, 13)
        Me.lblJTLNewsletterKundenExist.TabIndex = 15
        '
        'frmJTLSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 222)
        Me.Controls.Add(Me.lblJTLNewsletterKundenExist)
        Me.Controls.Add(Me.lblNeueJTLNewsletterKunden)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnStopSync)
        Me.Controls.Add(Me.lvwJTLKunden)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.pgrStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJTLSync"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JTL Wawi Kunden für Newsletter synchronisieren & Newsletter Abmeldungen holen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pgrStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lvwJTLKunden As System.Windows.Forms.ListView
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVorname As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNachname As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOrt As System.Windows.Forms.ColumnHeader
    Friend WithEvents colEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFirma As System.Windows.Forms.ColumnHeader
    Friend WithEvents colKDNR As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStrasse As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLand As System.Windows.Forms.ColumnHeader
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnStopSync As System.Windows.Forms.Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblNeueJTLNewsletterKunden As Label
    Friend WithEvents lblJTLNewsletterKundenExist As Label
End Class
