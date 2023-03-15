<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbNewsletter = New System.Windows.Forms.TabPage
        Me.tbEditor = New System.Windows.Forms.TabPage
        Me.optNewsletter = New System.Windows.Forms.RadioButton
        Me.optAlle = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.lvwJTLKunden = New System.Windows.Forms.ListView
        Me.colID = New System.Windows.Forms.ColumnHeader
        Me.colVorname = New System.Windows.Forms.ColumnHeader
        Me.colNachname = New System.Windows.Forms.ColumnHeader
        Me.colOrt = New System.Windows.Forms.ColumnHeader
        Me.colEmail = New System.Windows.Forms.ColumnHeader
        Me.colFirma = New System.Windows.Forms.ColumnHeader
        Me.colKDNR = New System.Windows.Forms.ColumnHeader
        Me.colStrasse = New System.Windows.Forms.ColumnHeader
        Me.colLand = New System.Windows.Forms.ColumnHeader
        Me.btnEinlesen = New System.Windows.Forms.Button
        Me.btnSend = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.msgMaster = New System.Windows.Forms.ToolStripStatusLabel
        Me.masterpgr = New System.Windows.Forms.ToolStripProgressBar
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WerkzeugeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewsletterNeustartenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatenbankeinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MailserverEinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DHTMLControll = New AxDHTMLEDLib.AxDHTMLEdit
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NeuToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ÖffnenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SpeichernToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.DruckenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.AusschneidenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.KopierenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.EinfügenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Bold = New System.Windows.Forms.ToolStripButton
        Me.Hyperlink = New System.Windows.Forms.ToolStripButton
        Me.Suchen = New System.Windows.Forms.ToolStripButton
        Me.Bild = New System.Windows.Forms.ToolStripButton
        Me.Redo = New System.Windows.Forms.ToolStripButton
        Me.Undo = New System.Windows.Forms.ToolStripButton
        Me.tabelle = New System.Windows.Forms.ToolStripButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtVorlageQuellcode = New System.Windows.Forms.TextBox
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.TabControl1.SuspendLayout()
        Me.tbNewsletter.SuspendLayout()
        Me.tbEditor.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DHTMLControll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tbNewsletter)
        Me.TabControl1.Controls.Add(Me.tbEditor)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 691)
        Me.TabControl1.TabIndex = 0
        '
        'tbNewsletter
        '
        Me.tbNewsletter.Controls.Add(Me.btnSend)
        Me.tbNewsletter.Controls.Add(Me.btnEinlesen)
        Me.tbNewsletter.Controls.Add(Me.lvwJTLKunden)
        Me.tbNewsletter.Controls.Add(Me.optNewsletter)
        Me.tbNewsletter.Controls.Add(Me.optAlle)
        Me.tbNewsletter.Controls.Add(Me.Label1)
        Me.tbNewsletter.Location = New System.Drawing.Point(4, 25)
        Me.tbNewsletter.Name = "tbNewsletter"
        Me.tbNewsletter.Padding = New System.Windows.Forms.Padding(3)
        Me.tbNewsletter.Size = New System.Drawing.Size(976, 662)
        Me.tbNewsletter.TabIndex = 0
        Me.tbNewsletter.Text = "Newsletter"
        Me.tbNewsletter.UseVisualStyleBackColor = True
        '
        'tbEditor
        '
        Me.tbEditor.Controls.Add(Me.Panel1)
        Me.tbEditor.Location = New System.Drawing.Point(4, 25)
        Me.tbEditor.Name = "tbEditor"
        Me.tbEditor.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEditor.Size = New System.Drawing.Size(976, 662)
        Me.tbEditor.TabIndex = 1
        Me.tbEditor.Text = "HTML Editor"
        Me.tbEditor.UseVisualStyleBackColor = True
        '
        'optNewsletter
        '
        Me.optNewsletter.AutoSize = True
        Me.optNewsletter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optNewsletter.Checked = True
        Me.optNewsletter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optNewsletter.Location = New System.Drawing.Point(87, 40)
        Me.optNewsletter.Name = "optNewsletter"
        Me.optNewsletter.Size = New System.Drawing.Size(97, 17)
        Me.optNewsletter.TabIndex = 9
        Me.optNewsletter.TabStop = True
        Me.optNewsletter.Text = "&Abschick bereit"
        Me.optNewsletter.UseVisualStyleBackColor = True
        '
        'optAlle
        '
        Me.optAlle.AutoSize = True
        Me.optAlle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optAlle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAlle.Location = New System.Drawing.Point(222, 40)
        Me.optAlle.Name = "optAlle"
        Me.optAlle.Size = New System.Drawing.Size(74, 17)
        Me.optAlle.TabIndex = 8
        Me.optAlle.Text = "&Verschickt"
        Me.optAlle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Suchkriterien"
        '
        'lvwJTLKunden
        '
        Me.lvwJTLKunden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwJTLKunden.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colVorname, Me.colNachname, Me.colOrt, Me.colEmail, Me.colFirma, Me.colKDNR, Me.colStrasse, Me.colLand})
        Me.lvwJTLKunden.FullRowSelect = True
        Me.lvwJTLKunden.GridLines = True
        Me.lvwJTLKunden.HideSelection = False
        Me.lvwJTLKunden.Location = New System.Drawing.Point(18, 86)
        Me.lvwJTLKunden.Name = "lvwJTLKunden"
        Me.lvwJTLKunden.Size = New System.Drawing.Size(940, 573)
        Me.lvwJTLKunden.TabIndex = 10
        Me.lvwJTLKunden.UseCompatibleStateImageBehavior = False
        Me.lvwJTLKunden.View = System.Windows.Forms.View.Details
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
        'btnEinlesen
        '
        Me.btnEinlesen.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnEinlesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEinlesen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEinlesen.Location = New System.Drawing.Point(335, 40)
        Me.btnEinlesen.Name = "btnEinlesen"
        Me.btnEinlesen.Size = New System.Drawing.Size(197, 23)
        Me.btnEinlesen.TabIndex = 11
        Me.btnEinlesen.Text = "&Einlesen"
        Me.btnEinlesen.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(761, 40)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(197, 23)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "&Abschicken"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msgMaster, Me.masterpgr})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 708)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'msgMaster
        '
        Me.msgMaster.Name = "msgMaster"
        Me.msgMaster.Size = New System.Drawing.Size(0, 17)
        '
        'masterpgr
        '
        Me.masterpgr.Name = "masterpgr"
        Me.masterpgr.Size = New System.Drawing.Size(600, 16)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.WerkzeugeToolStripMenuItem, Me.EinstellungenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'WerkzeugeToolStripMenuItem
        '
        Me.WerkzeugeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewsletterNeustartenToolStripMenuItem})
        Me.WerkzeugeToolStripMenuItem.Name = "WerkzeugeToolStripMenuItem"
        Me.WerkzeugeToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.WerkzeugeToolStripMenuItem.Text = "&Werkzeuge"
        '
        'NewsletterNeustartenToolStripMenuItem
        '
        Me.NewsletterNeustartenToolStripMenuItem.Name = "NewsletterNeustartenToolStripMenuItem"
        Me.NewsletterNeustartenToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.NewsletterNeustartenToolStripMenuItem.Text = "&Newsletter neustarten..."
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankeinstellungenToolStripMenuItem, Me.MailserverEinstellungenToolStripMenuItem})
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.EinstellungenToolStripMenuItem.Text = "&Einstellungen"
        '
        'DatenbankeinstellungenToolStripMenuItem
        '
        Me.DatenbankeinstellungenToolStripMenuItem.Name = "DatenbankeinstellungenToolStripMenuItem"
        Me.DatenbankeinstellungenToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.DatenbankeinstellungenToolStripMenuItem.Text = "Datenbankeinstellungen..."
        '
        'MailserverEinstellungenToolStripMenuItem
        '
        Me.MailserverEinstellungenToolStripMenuItem.Name = "MailserverEinstellungenToolStripMenuItem"
        Me.MailserverEinstellungenToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MailserverEinstellungenToolStripMenuItem.Text = "Mailserver Einstellungen..."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.txtVorlageQuellcode)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.DHTMLControll)
        Me.Panel1.Location = New System.Drawing.Point(3, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 544)
        Me.Panel1.TabIndex = 76
        '
        'DHTMLControll
        '
        Me.DHTMLControll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DHTMLControll.Enabled = True
        Me.DHTMLControll.Location = New System.Drawing.Point(0, 0)
        Me.DHTMLControll.Name = "DHTMLControll"
        Me.DHTMLControll.OcxState = CType(resources.GetObject("DHTMLControll.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DHTMLControll.Size = New System.Drawing.Size(967, 544)
        Me.DHTMLControll.TabIndex = 76
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripButton, Me.ÖffnenToolStripButton, Me.SpeichernToolStripButton, Me.DruckenToolStripButton, Me.toolStripSeparator, Me.AusschneidenToolStripButton, Me.KopierenToolStripButton, Me.EinfügenToolStripButton, Me.toolStripSeparator2, Me.Bold, Me.Hyperlink, Me.Suchen, Me.Bild, Me.Redo, Me.Undo, Me.tabelle})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(967, 25)
        Me.ToolStrip1.TabIndex = 77
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NeuToolStripButton
        '
        Me.NeuToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NeuToolStripButton.Image = CType(resources.GetObject("NeuToolStripButton.Image"), System.Drawing.Image)
        Me.NeuToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NeuToolStripButton.Name = "NeuToolStripButton"
        Me.NeuToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NeuToolStripButton.Text = "&Neu"
        '
        'ÖffnenToolStripButton
        '
        Me.ÖffnenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ÖffnenToolStripButton.Image = CType(resources.GetObject("ÖffnenToolStripButton.Image"), System.Drawing.Image)
        Me.ÖffnenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ÖffnenToolStripButton.Name = "ÖffnenToolStripButton"
        Me.ÖffnenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ÖffnenToolStripButton.Text = "Ö&ffnen"
        '
        'SpeichernToolStripButton
        '
        Me.SpeichernToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SpeichernToolStripButton.Image = CType(resources.GetObject("SpeichernToolStripButton.Image"), System.Drawing.Image)
        Me.SpeichernToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SpeichernToolStripButton.Name = "SpeichernToolStripButton"
        Me.SpeichernToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SpeichernToolStripButton.Text = "&Speichern"
        '
        'DruckenToolStripButton
        '
        Me.DruckenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DruckenToolStripButton.Image = CType(resources.GetObject("DruckenToolStripButton.Image"), System.Drawing.Image)
        Me.DruckenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DruckenToolStripButton.Name = "DruckenToolStripButton"
        Me.DruckenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DruckenToolStripButton.Text = "&Drucken"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'AusschneidenToolStripButton
        '
        Me.AusschneidenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AusschneidenToolStripButton.Image = CType(resources.GetObject("AusschneidenToolStripButton.Image"), System.Drawing.Image)
        Me.AusschneidenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AusschneidenToolStripButton.Name = "AusschneidenToolStripButton"
        Me.AusschneidenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AusschneidenToolStripButton.Text = "&Ausschneiden"
        '
        'KopierenToolStripButton
        '
        Me.KopierenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KopierenToolStripButton.Image = CType(resources.GetObject("KopierenToolStripButton.Image"), System.Drawing.Image)
        Me.KopierenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KopierenToolStripButton.Name = "KopierenToolStripButton"
        Me.KopierenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.KopierenToolStripButton.Text = "&Kopieren"
        '
        'EinfügenToolStripButton
        '
        Me.EinfügenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EinfügenToolStripButton.Image = CType(resources.GetObject("EinfügenToolStripButton.Image"), System.Drawing.Image)
        Me.EinfügenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EinfügenToolStripButton.Name = "EinfügenToolStripButton"
        Me.EinfügenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EinfügenToolStripButton.Text = "&Einfügen"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Bold
        '
        Me.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bold.Image = CType(resources.GetObject("Bold.Image"), System.Drawing.Image)
        Me.Bold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bold.Name = "Bold"
        Me.Bold.Size = New System.Drawing.Size(23, 22)
        Me.Bold.Text = "Fett schreiben"
        '
        'Hyperlink
        '
        Me.Hyperlink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Hyperlink.Image = CType(resources.GetObject("Hyperlink.Image"), System.Drawing.Image)
        Me.Hyperlink.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Hyperlink.Name = "Hyperlink"
        Me.Hyperlink.Size = New System.Drawing.Size(23, 22)
        Me.Hyperlink.Text = "Hyperlink"
        '
        'Suchen
        '
        Me.Suchen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Suchen.Image = CType(resources.GetObject("Suchen.Image"), System.Drawing.Image)
        Me.Suchen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Suchen.Name = "Suchen"
        Me.Suchen.Size = New System.Drawing.Size(23, 22)
        Me.Suchen.Text = "Suchen"
        '
        'Bild
        '
        Me.Bild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bild.Image = CType(resources.GetObject("Bild.Image"), System.Drawing.Image)
        Me.Bild.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bild.Name = "Bild"
        Me.Bild.Size = New System.Drawing.Size(23, 22)
        Me.Bild.Text = "Bild einfügen"
        '
        'Redo
        '
        Me.Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Redo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Redo.Name = "Redo"
        Me.Redo.Size = New System.Drawing.Size(23, 22)
        Me.Redo.Text = "Vorwärts"
        '
        'Undo
        '
        Me.Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Undo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Undo.Name = "Undo"
        Me.Undo.Size = New System.Drawing.Size(23, 22)
        Me.Undo.Text = "Zurück"
        '
        'tabelle
        '
        Me.tabelle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tabelle.Image = CType(resources.GetObject("tabelle.Image"), System.Drawing.Image)
        Me.tabelle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tabelle.Name = "tabelle"
        Me.tabelle.Size = New System.Drawing.Size(23, 22)
        Me.tabelle.Text = "Tabelle einfügen"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtVorlageQuellcode
        '
        Me.txtVorlageQuellcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVorlageQuellcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtVorlageQuellcode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVorlageQuellcode.Location = New System.Drawing.Point(0, 25)
        Me.txtVorlageQuellcode.Multiline = True
        Me.txtVorlageQuellcode.Name = "txtVorlageQuellcode"
        Me.txtVorlageQuellcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVorlageQuellcode.Size = New System.Drawing.Size(967, 519)
        Me.txtVorlageQuellcode.TabIndex = 78
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(406, 9)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(79, 13)
        Me.LinkLabel2.TabIndex = 80
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Browseransicht"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(362, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(38, 13)
        Me.LinkLabel1.TabIndex = 79
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "HTML"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JTL Newsletter"
        Me.TabControl1.ResumeLayout(False)
        Me.tbNewsletter.ResumeLayout(False)
        Me.tbNewsletter.PerformLayout()
        Me.tbEditor.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DHTMLControll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbNewsletter As System.Windows.Forms.TabPage
    Friend WithEvents tbEditor As System.Windows.Forms.TabPage
    Friend WithEvents lvwJTLKunden As System.Windows.Forms.ListView
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVorname As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNachname As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOrt As System.Windows.Forms.ColumnHeader
    Friend WithEvents colEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFirma As System.Windows.Forms.ColumnHeader
    Friend WithEvents colKDNR As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStrasse As System.Windows.Forms.ColumnHeader
    Friend WithEvents optNewsletter As System.Windows.Forms.RadioButton
    Friend WithEvents optAlle As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colLand As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnEinlesen As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents msgMaster As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents masterpgr As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WerkzeugeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewsletterNeustartenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankeinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MailserverEinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DHTMLControll As AxDHTMLEDLib.AxDHTMLEdit
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NeuToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ÖffnenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SpeichernToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DruckenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AusschneidenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents KopierenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EinfügenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Bold As System.Windows.Forms.ToolStripButton
    Friend WithEvents Hyperlink As System.Windows.Forms.ToolStripButton
    Friend WithEvents Suchen As System.Windows.Forms.ToolStripButton
    Friend WithEvents Bild As System.Windows.Forms.ToolStripButton
    Friend WithEvents Redo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Undo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabelle As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtVorlageQuellcode As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
