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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbNewsletter = New System.Windows.Forms.TabPage()
        Me.optAngemeldet = New System.Windows.Forms.RadioButton()
        Me.optAbgemeldet = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbMandant = New System.Windows.Forms.ComboBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnEinlesen = New System.Windows.Forms.Button()
        Me.lvwJTLKunden = New System.Windows.Forms.ListView()
        Me.colKundenID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNachname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOrt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFirma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKDNR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStrasse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAnrede = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPLZ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGetNewsletter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VorschauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsletterAbmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtToolTipSuche = New System.Windows.Forms.ToolStripTextBox()
        Me.VerschicktEinstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.optNewsletterAbschicken = New System.Windows.Forms.RadioButton()
        Me.optNewsletterVerschickt = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbEditor = New System.Windows.Forms.TabPage()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.txteMailBetreff = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPfadÖffnen = New System.Windows.Forms.Button()
        Me.txtVorlagePfad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHilfe = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NeuToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ÖffnenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SpeichernToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DruckenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.AusschneidenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.KopierenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EinfügenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Bold = New System.Windows.Forms.ToolStripButton()
        Me.Hyperlink = New System.Windows.Forms.ToolStripButton()
        Me.Suchen = New System.Windows.Forms.ToolStripButton()
        Me.Bild = New System.Windows.Forms.ToolStripButton()
        Me.Redo = New System.Windows.Forms.ToolStripButton()
        Me.Undo = New System.Windows.Forms.ToolStripButton()
        Me.tabelle = New System.Windows.Forms.ToolStripButton()
        Me.txtVorlageQuellcode = New System.Windows.Forms.TextBox()
        Me.DHTMLControll = New AxDHTMLEDLib.AxDHTMLEdit()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtTestlaufAnzahl = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTestlaufEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkTestlauf = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.msgMaster = New System.Windows.Forms.ToolStripStatusLabel()
        Me.masterpgr = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WerkzeugeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsletterNeustartenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankeinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailserverEinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JTLShopEinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.EinstellungenDebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.tbNewsletter.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.tbEditor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DHTMLControll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.AllowDrop = True
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tbNewsletter)
        Me.TabControl1.Controls.Add(Me.tbEditor)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 678)
        Me.TabControl1.TabIndex = 0
        '
        'tbNewsletter
        '
        Me.tbNewsletter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNewsletter.Controls.Add(Me.optAngemeldet)
        Me.tbNewsletter.Controls.Add(Me.optAbgemeldet)
        Me.tbNewsletter.Controls.Add(Me.Label6)
        Me.tbNewsletter.Controls.Add(Me.cmbMandant)
        Me.tbNewsletter.Controls.Add(Me.btnSend)
        Me.tbNewsletter.Controls.Add(Me.btnEinlesen)
        Me.tbNewsletter.Controls.Add(Me.lvwJTLKunden)
        Me.tbNewsletter.Controls.Add(Me.optNewsletterAbschicken)
        Me.tbNewsletter.Controls.Add(Me.optNewsletterVerschickt)
        Me.tbNewsletter.Controls.Add(Me.Label1)
        Me.tbNewsletter.Location = New System.Drawing.Point(4, 25)
        Me.tbNewsletter.Name = "tbNewsletter"
        Me.tbNewsletter.Padding = New System.Windows.Forms.Padding(3)
        Me.tbNewsletter.Size = New System.Drawing.Size(976, 649)
        Me.tbNewsletter.TabIndex = 0
        Me.tbNewsletter.Text = "Newsletter abschicken"
        Me.tbNewsletter.UseVisualStyleBackColor = True
        '
        'optAngemeldet
        '
        Me.optAngemeldet.AutoSize = True
        Me.optAngemeldet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optAngemeldet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAngemeldet.Location = New System.Drawing.Point(285, 60)
        Me.optAngemeldet.Name = "optAngemeldet"
        Me.optAngemeldet.Size = New System.Drawing.Size(80, 17)
        Me.optAngemeldet.TabIndex = 16
        Me.optAngemeldet.Text = "&Angemeldet"
        Me.optAngemeldet.UseVisualStyleBackColor = True
        '
        'optAbgemeldet
        '
        Me.optAbgemeldet.AutoSize = True
        Me.optAbgemeldet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optAbgemeldet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAbgemeldet.Location = New System.Drawing.Point(397, 60)
        Me.optAbgemeldet.Name = "optAbgemeldet"
        Me.optAbgemeldet.Size = New System.Drawing.Size(80, 17)
        Me.optAbgemeldet.TabIndex = 15
        Me.optAbgemeldet.Text = "&Abgemeldet"
        Me.optAbgemeldet.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Mandantenwechsel"
        '
        'cmbMandant
        '
        Me.cmbMandant.DropDownHeight = 110
        Me.cmbMandant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMandant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMandant.FormattingEnabled = True
        Me.cmbMandant.IntegralHeight = False
        Me.cmbMandant.Location = New System.Drawing.Point(18, 39)
        Me.cmbMandant.Name = "cmbMandant"
        Me.cmbMandant.Size = New System.Drawing.Size(173, 21)
        Me.cmbMandant.TabIndex = 13
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(718, 35)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(240, 23)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "&Newsletter Versand starten"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnEinlesen
        '
        Me.btnEinlesen.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnEinlesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEinlesen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEinlesen.Location = New System.Drawing.Point(497, 35)
        Me.btnEinlesen.Name = "btnEinlesen"
        Me.btnEinlesen.Size = New System.Drawing.Size(197, 23)
        Me.btnEinlesen.TabIndex = 11
        Me.btnEinlesen.Text = "JTL Kunden &einlesen"
        Me.btnEinlesen.UseVisualStyleBackColor = False
        '
        'lvwJTLKunden
        '
        Me.lvwJTLKunden.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwJTLKunden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwJTLKunden.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKundenID, Me.colVorname, Me.colNachname, Me.colOrt, Me.colEmail, Me.colFirma, Me.colKDNR, Me.colStrasse, Me.colLand, Me.colAnrede, Me.colPLZ, Me.colGetNewsletter})
        Me.lvwJTLKunden.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvwJTLKunden.FullRowSelect = True
        Me.lvwJTLKunden.GridLines = True
        Me.lvwJTLKunden.HideSelection = False
        Me.lvwJTLKunden.Location = New System.Drawing.Point(18, 90)
        Me.lvwJTLKunden.Name = "lvwJTLKunden"
        Me.lvwJTLKunden.Size = New System.Drawing.Size(940, 552)
        Me.lvwJTLKunden.TabIndex = 10
        Me.lvwJTLKunden.UseCompatibleStateImageBehavior = False
        Me.lvwJTLKunden.View = System.Windows.Forms.View.Details
        '
        'colKundenID
        '
        Me.colKundenID.DisplayIndex = 10
        Me.colKundenID.Text = "ID"
        Me.colKundenID.Width = 0
        '
        'colVorname
        '
        Me.colVorname.DisplayIndex = 3
        Me.colVorname.Text = "Vorname"
        Me.colVorname.Width = 100
        '
        'colNachname
        '
        Me.colNachname.DisplayIndex = 4
        Me.colNachname.Text = "Nachname"
        Me.colNachname.Width = 120
        '
        'colOrt
        '
        Me.colOrt.DisplayIndex = 7
        Me.colOrt.Text = "Stadt"
        Me.colOrt.Width = 70
        '
        'colEmail
        '
        Me.colEmail.DisplayIndex = 5
        Me.colEmail.Text = "Email-Adresse"
        Me.colEmail.Width = 150
        '
        'colFirma
        '
        Me.colFirma.DisplayIndex = 0
        Me.colFirma.Text = "Firma"
        Me.colFirma.Width = 180
        '
        'colKDNR
        '
        Me.colKDNR.DisplayIndex = 1
        Me.colKDNR.Text = "KundenNr."
        Me.colKDNR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colKDNR.Width = 70
        '
        'colStrasse
        '
        Me.colStrasse.DisplayIndex = 8
        Me.colStrasse.Text = "Straße"
        Me.colStrasse.Width = 150
        '
        'colLand
        '
        Me.colLand.DisplayIndex = 9
        Me.colLand.Text = "Land"
        Me.colLand.Width = 120
        '
        'colAnrede
        '
        Me.colAnrede.DisplayIndex = 2
        Me.colAnrede.Text = "Anrede"
        Me.colAnrede.Width = 50
        '
        'colPLZ
        '
        Me.colPLZ.DisplayIndex = 6
        Me.colPLZ.Text = "PLZ"
        Me.colPLZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colPLZ.Width = 50
        '
        'colGetNewsletter
        '
        Me.colGetNewsletter.Text = "Angemeldet"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VorschauToolStripMenuItem, Me.NewsletterAbmeldenToolStripMenuItem, Me.txtToolTipSuche, Me.VerschicktEinstellenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(202, 93)
        '
        'VorschauToolStripMenuItem
        '
        Me.VorschauToolStripMenuItem.Name = "VorschauToolStripMenuItem"
        Me.VorschauToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.VorschauToolStripMenuItem.Text = "&Vorschau..."
        '
        'NewsletterAbmeldenToolStripMenuItem
        '
        Me.NewsletterAbmeldenToolStripMenuItem.Name = "NewsletterAbmeldenToolStripMenuItem"
        Me.NewsletterAbmeldenToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.NewsletterAbmeldenToolStripMenuItem.Text = "Newsletter abmelden"
        '
        'txtToolTipSuche
        '
        Me.txtToolTipSuche.Name = "txtToolTipSuche"
        Me.txtToolTipSuche.Size = New System.Drawing.Size(130, 21)
        '
        'VerschicktEinstellenToolStripMenuItem
        '
        Me.VerschicktEinstellenToolStripMenuItem.Name = "VerschicktEinstellenToolStripMenuItem"
        Me.VerschicktEinstellenToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.VerschicktEinstellenToolStripMenuItem.Text = "Auf verschickt umstellen"
        '
        'optNewsletterAbschicken
        '
        Me.optNewsletterAbschicken.AutoSize = True
        Me.optNewsletterAbschicken.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optNewsletterAbschicken.Checked = True
        Me.optNewsletterAbschicken.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optNewsletterAbschicken.Location = New System.Drawing.Point(268, 37)
        Me.optNewsletterAbschicken.Name = "optNewsletterAbschicken"
        Me.optNewsletterAbschicken.Size = New System.Drawing.Size(97, 17)
        Me.optNewsletterAbschicken.TabIndex = 9
        Me.optNewsletterAbschicken.TabStop = True
        Me.optNewsletterAbschicken.Text = "&Abschick bereit"
        Me.optNewsletterAbschicken.UseVisualStyleBackColor = True
        '
        'optNewsletterVerschickt
        '
        Me.optNewsletterVerschickt.AutoSize = True
        Me.optNewsletterVerschickt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optNewsletterVerschickt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optNewsletterVerschickt.Location = New System.Drawing.Point(403, 37)
        Me.optNewsletterVerschickt.Name = "optNewsletterVerschickt"
        Me.optNewsletterVerschickt.Size = New System.Drawing.Size(74, 17)
        Me.optNewsletterVerschickt.TabIndex = 8
        Me.optNewsletterVerschickt.Text = "&Verschickt"
        Me.optNewsletterVerschickt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Suchkriterien"
        '
        'tbEditor
        '
        Me.tbEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEditor.Controls.Add(Me.LinkLabel3)
        Me.tbEditor.Controls.Add(Me.txteMailBetreff)
        Me.tbEditor.Controls.Add(Me.Label3)
        Me.tbEditor.Controls.Add(Me.btnPfadÖffnen)
        Me.tbEditor.Controls.Add(Me.txtVorlagePfad)
        Me.tbEditor.Controls.Add(Me.Label2)
        Me.tbEditor.Controls.Add(Me.Panel1)
        Me.tbEditor.Location = New System.Drawing.Point(4, 25)
        Me.tbEditor.Name = "tbEditor"
        Me.tbEditor.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEditor.Size = New System.Drawing.Size(976, 649)
        Me.tbEditor.TabIndex = 1
        Me.tbEditor.Text = "Vorlageneditor"
        Me.tbEditor.ToolTipText = "Newslettervorlage verändern"
        Me.tbEditor.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(830, 82)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(102, 13)
        Me.LinkLabel3.TabIndex = 82
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Betreff Variablen"
        '
        'txteMailBetreff
        '
        Me.txteMailBetreff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txteMailBetreff.Location = New System.Drawing.Point(9, 80)
        Me.txteMailBetreff.Name = "txteMailBetreff"
        Me.txteMailBetreff.Size = New System.Drawing.Size(815, 20)
        Me.txteMailBetreff.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Newsletter Betreff"
        '
        'btnPfadÖffnen
        '
        Me.btnPfadÖffnen.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnPfadÖffnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPfadÖffnen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPfadÖffnen.Location = New System.Drawing.Point(830, 30)
        Me.btnPfadÖffnen.Name = "btnPfadÖffnen"
        Me.btnPfadÖffnen.Size = New System.Drawing.Size(70, 20)
        Me.btnPfadÖffnen.TabIndex = 79
        Me.btnPfadÖffnen.Text = "..."
        Me.btnPfadÖffnen.UseVisualStyleBackColor = False
        '
        'txtVorlagePfad
        '
        Me.txtVorlagePfad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVorlagePfad.Location = New System.Drawing.Point(9, 30)
        Me.txtVorlagePfad.Name = "txtVorlagePfad"
        Me.txtVorlagePfad.Size = New System.Drawing.Size(815, 20)
        Me.txtVorlagePfad.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Aktuelle Newsletter Vorlage"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lblHilfe)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.txtVorlageQuellcode)
        Me.Panel1.Controls.Add(Me.DHTMLControll)
        Me.Panel1.Location = New System.Drawing.Point(3, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 532)
        Me.Panel1.TabIndex = 76
        '
        'lblHilfe
        '
        Me.lblHilfe.AutoSize = True
        Me.lblHilfe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHilfe.Location = New System.Drawing.Point(789, 9)
        Me.lblHilfe.Name = "lblHilfe"
        Me.lblHilfe.Size = New System.Drawing.Size(152, 13)
        Me.lblHilfe.TabIndex = 81
        Me.lblHilfe.TabStop = True
        Me.lblHilfe.Text = "Newsletter Variablen Hilfe"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(406, 9)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(135, 13)
        Me.LinkLabel2.TabIndex = 80
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Browseransicht inaktiv"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripButton, Me.ÖffnenToolStripButton, Me.SpeichernToolStripButton, Me.DruckenToolStripButton, Me.toolStripSeparator, Me.AusschneidenToolStripButton, Me.KopierenToolStripButton, Me.EinfügenToolStripButton, Me.toolStripSeparator2, Me.Bold, Me.Hyperlink, Me.Suchen, Me.Bild, Me.Redo, Me.Undo, Me.tabelle})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(965, 25)
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
        Me.Bold.Image = Global.JTL_Newsletter.My.Resources.Resources.text_bold
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
        Me.Redo.Image = Global.JTL_Newsletter.My.Resources.Resources.arrow_redo_icon
        Me.Redo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Redo.Name = "Redo"
        Me.Redo.Size = New System.Drawing.Size(23, 22)
        Me.Redo.Text = "Vorwärts"
        '
        'Undo
        '
        Me.Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Undo.Image = Global.JTL_Newsletter.My.Resources.Resources.arrow_undo_icon
        Me.Undo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Undo.Name = "Undo"
        Me.Undo.Size = New System.Drawing.Size(23, 22)
        Me.Undo.Text = "Zurück"
        '
        'tabelle
        '
        Me.tabelle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tabelle.Image = Global.JTL_Newsletter.My.Resources.Resources.Mimetype_vcalendar
        Me.tabelle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tabelle.Name = "tabelle"
        Me.tabelle.Size = New System.Drawing.Size(23, 22)
        Me.tabelle.Text = "Tabelle einfügen"
        '
        'txtVorlageQuellcode
        '
        Me.txtVorlageQuellcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVorlageQuellcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVorlageQuellcode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVorlageQuellcode.Location = New System.Drawing.Point(-4, 25)
        Me.txtVorlageQuellcode.Multiline = True
        Me.txtVorlageQuellcode.Name = "txtVorlageQuellcode"
        Me.txtVorlageQuellcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVorlageQuellcode.Size = New System.Drawing.Size(969, 511)
        Me.txtVorlageQuellcode.TabIndex = 78
        Me.txtVorlageQuellcode.Visible = False
        '
        'DHTMLControll
        '
        Me.DHTMLControll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DHTMLControll.Enabled = True
        Me.DHTMLControll.Location = New System.Drawing.Point(0, 28)
        Me.DHTMLControll.Name = "DHTMLControll"
        Me.DHTMLControll.OcxState = CType(resources.GetObject("DHTMLControll.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DHTMLControll.Size = New System.Drawing.Size(965, 532)
        Me.DHTMLControll.TabIndex = 76
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.txtTestlaufAnzahl)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtTestlaufEmail)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.chkTestlauf)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(976, 649)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Testlauf Einstellungen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtTestlaufAnzahl
        '
        Me.txtTestlaufAnzahl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTestlaufAnzahl.Location = New System.Drawing.Point(26, 87)
        Me.txtTestlaufAnzahl.Name = "txtTestlaufAnzahl"
        Me.txtTestlaufAnzahl.Size = New System.Drawing.Size(52, 20)
        Me.txtTestlaufAnzahl.TabIndex = 4
        Me.txtTestlaufAnzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Anzahl der Testlauf Emails"
        '
        'txtTestlaufEmail
        '
        Me.txtTestlaufEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTestlaufEmail.Location = New System.Drawing.Point(495, 31)
        Me.txtTestlaufEmail.Name = "txtTestlaufEmail"
        Me.txtTestlaufEmail.Size = New System.Drawing.Size(300, 20)
        Me.txtTestlaufEmail.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(329, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Alle Emails im Testlauf Modus an die folgende Email Adresse senden"
        '
        'chkTestlauf
        '
        Me.chkTestlauf.AutoSize = True
        Me.chkTestlauf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTestlauf.Location = New System.Drawing.Point(26, 32)
        Me.chkTestlauf.Name = "chkTestlauf"
        Me.chkTestlauf.Size = New System.Drawing.Size(110, 17)
        Me.chkTestlauf.TabIndex = 0
        Me.chkTestlauf.Text = "Testlauf aktivieren"
        Me.chkTestlauf.UseVisualStyleBackColor = True
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
        Me.masterpgr.Visible = False
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
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'WerkzeugeToolStripMenuItem
        '
        Me.WerkzeugeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewsletterNeustartenToolStripMenuItem, Me.EinstellungenDebugToolStripMenuItem})
        Me.WerkzeugeToolStripMenuItem.Name = "WerkzeugeToolStripMenuItem"
        Me.WerkzeugeToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.WerkzeugeToolStripMenuItem.Text = "&Werkzeuge"
        '
        'NewsletterNeustartenToolStripMenuItem
        '
        Me.NewsletterNeustartenToolStripMenuItem.Name = "NewsletterNeustartenToolStripMenuItem"
        Me.NewsletterNeustartenToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.NewsletterNeustartenToolStripMenuItem.Text = "&Newsletter neustarten..."
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankeinstellungenToolStripMenuItem, Me.MailserverEinstellungenToolStripMenuItem, Me.JTLShopEinstellungenToolStripMenuItem})
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EinstellungenToolStripMenuItem.Text = "&Einstellungen"
        '
        'DatenbankeinstellungenToolStripMenuItem
        '
        Me.DatenbankeinstellungenToolStripMenuItem.Name = "DatenbankeinstellungenToolStripMenuItem"
        Me.DatenbankeinstellungenToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DatenbankeinstellungenToolStripMenuItem.Text = "Datenbankeinstellungen..."
        '
        'MailserverEinstellungenToolStripMenuItem
        '
        Me.MailserverEinstellungenToolStripMenuItem.Name = "MailserverEinstellungenToolStripMenuItem"
        Me.MailserverEinstellungenToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.MailserverEinstellungenToolStripMenuItem.Text = "Mailserver Einstellungen..."
        '
        'JTLShopEinstellungenToolStripMenuItem
        '
        Me.JTLShopEinstellungenToolStripMenuItem.Name = "JTLShopEinstellungenToolStripMenuItem"
        Me.JTLShopEinstellungenToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.JTLShopEinstellungenToolStripMenuItem.Text = "JTL Shop Einstellungen..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "HTM Dateien|*.html|HTML Dateien|*.htm *|Alle Dateien|*.*"
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "HTML Dateien|*.html"
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'Timer1
        '
        '
        'EinstellungenDebugToolStripMenuItem
        '
        Me.EinstellungenDebugToolStripMenuItem.Name = "EinstellungenDebugToolStripMenuItem"
        Me.EinstellungenDebugToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.EinstellungenDebugToolStripMenuItem.Text = "Einstellungen Debug"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JTL Newsletter"
        Me.TabControl1.ResumeLayout(False)
        Me.tbNewsletter.ResumeLayout(False)
        Me.tbNewsletter.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip1.PerformLayout()
        Me.tbEditor.ResumeLayout(False)
        Me.tbEditor.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DHTMLControll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbNewsletter As System.Windows.Forms.TabPage
    Friend WithEvents tbEditor As System.Windows.Forms.TabPage
    Friend WithEvents lvwJTLKunden As System.Windows.Forms.ListView
    Friend WithEvents colKundenID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVorname As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNachname As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOrt As System.Windows.Forms.ColumnHeader
    Friend WithEvents colEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFirma As System.Windows.Forms.ColumnHeader
    Friend WithEvents colKDNR As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStrasse As System.Windows.Forms.ColumnHeader
    Friend WithEvents optNewsletterAbschicken As System.Windows.Forms.RadioButton
    Friend WithEvents optNewsletterVerschickt As System.Windows.Forms.RadioButton
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
    Friend WithEvents btnPfadÖffnen As System.Windows.Forms.Button
    Friend WithEvents txtVorlagePfad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colAnrede As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPLZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents txteMailBetreff As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VorschauToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkTestlauf As System.Windows.Forms.CheckBox
    Friend WithEvents txtTestlaufEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTestlaufAnzahl As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents JTLShopEinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbMandant As System.Windows.Forms.ComboBox
    Friend WithEvents optAngemeldet As System.Windows.Forms.RadioButton
    Friend WithEvents optAbgemeldet As System.Windows.Forms.RadioButton
    Friend WithEvents NewsletterAbmeldenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colGetNewsletter As System.Windows.Forms.ColumnHeader
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblHilfe As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtToolTipSuche As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents VerschicktEinstellenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungenDebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
