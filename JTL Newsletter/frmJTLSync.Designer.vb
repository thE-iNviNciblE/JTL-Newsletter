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
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'pgrStatus
        '
        Me.pgrStatus.Location = New System.Drawing.Point(12, 77)
        Me.pgrStatus.Name = "pgrStatus"
        Me.pgrStatus.Size = New System.Drawing.Size(540, 23)
        Me.pgrStatus.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "JTL Kunden synchronisieren..."
        '
        'lvwJTLKunden
        '
        Me.lvwJTLKunden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwJTLKunden.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colVorname, Me.colNachname, Me.colOrt, Me.colEmail, Me.colFirma, Me.colKDNR, Me.colStrasse, Me.colLand})
        Me.lvwJTLKunden.FullRowSelect = True
        Me.lvwJTLKunden.GridLines = True
        Me.lvwJTLKunden.HideSelection = False
        Me.lvwJTLKunden.Location = New System.Drawing.Point(12, 106)
        Me.lvwJTLKunden.Name = "lvwJTLKunden"
        Me.lvwJTLKunden.Size = New System.Drawing.Size(329, 247)
        Me.lvwJTLKunden.TabIndex = 11
        Me.lvwJTLKunden.UseCompatibleStateImageBehavior = False
        Me.lvwJTLKunden.View = System.Windows.Forms.View.Details
        Me.lvwJTLKunden.Visible = False
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 100
        '
        'colVorname
        '
        Me.colVorname.Text = "Vorname"
        Me.colVorname.Width = 120
        '
        'colNachname
        '
        Me.colNachname.Text = "Nachname"
        Me.colNachname.Width = 120
        '
        'colOrt
        '
        Me.colOrt.Text = "Stadt"
        Me.colOrt.Width = 150
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
        Me.Timer1.Interval = 1000
        '
        'frmJTLSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 150)
        Me.Controls.Add(Me.lvwJTLKunden)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pgrStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJTLSync"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JTL Datenbestand für Newsletter synchronisieren"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pgrStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
End Class
