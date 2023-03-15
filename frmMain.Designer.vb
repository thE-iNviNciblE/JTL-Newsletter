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
        Me.txtCore_Mail_bei = New System.Windows.Forms.TextBox()
        Me.lblCore_Mail_bei = New System.Windows.Forms.Label()
        Me.txtCore_mail_bis = New System.Windows.Forms.TextBox()
        Me.lblCore_mail_bis = New System.Windows.Forms.Label()
        Me.chkTestlauf = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cmbKundenKategorie = New System.Windows.Forms.ComboBox()
        Me.chkNichtAmazon = New System.Windows.Forms.CheckBox()
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
        Me.colKundeSeit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestellsumme = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VorschauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsletterAbmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtToolTipSuche = New System.Windows.Forms.ToolStripTextBox()
        Me.VerschicktEinstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.optNewsletterAbschicken = New System.Windows.Forms.RadioButton()
        Me.optNewsletterVerschickt = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbEditor = New System.Windows.Forms.TabPage()
        Me.lblHilfe = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.txteMailBetreff = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPfadÖffnen = New System.Windows.Forms.Button()
        Me.txtVorlagePfad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVorlagespeichern = New System.Windows.Forms.Button()
        Me.txtVorlageQuellcode = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTestlaufEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAbmeldeURL = New System.Windows.Forms.Button()
        Me.txtTestlaufAnzahl = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCore_wartezeit = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtEmailServerLimitierungen_anzahl_pro_stunde = New System.Windows.Forms.TextBox()
        Me.chkEmailServerLimitierungen = New System.Windows.Forms.CheckBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tbProduktverwaltung_newsletter = New System.Windows.Forms.TabPage()
        Me.txtBildlink5 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtSektion5_artikelliste = New System.Windows.Forms.TextBox()
        Me.txtSektion5_beschreibung = New System.Windows.Forms.TextBox()
        Me.txtSektion5_bild = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtBildlink4 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtBildLink3 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtBildLink2 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtBildLink = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtSektion4_artikelliste = New System.Windows.Forms.TextBox()
        Me.txtSektion4_beschreibung = New System.Windows.Forms.TextBox()
        Me.txtSektion4_bild = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSektion3_artikelliste = New System.Windows.Forms.TextBox()
        Me.txtSektion3_beschreibung = New System.Windows.Forms.TextBox()
        Me.txtSektion3_bild = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSektion2_artikelliste = New System.Windows.Forms.TextBox()
        Me.txtSektion2_beschreibung = New System.Windows.Forms.TextBox()
        Me.txtSektion2_bild = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSektion1_shopartikelbySKU = New System.Windows.Forms.TextBox()
        Me.txtSektion1_beschreibung = New System.Windows.Forms.TextBox()
        Me.txtSektion1_header_bild = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.msgMaster = New System.Windows.Forms.ToolStripStatusLabel()
        Me.masterpgr = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WerkzeugeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsletterNeustartenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenDebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsletterAbmeldungenHolenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankeinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailserverEinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JTLShopEinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JTLNewsletterUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CubssnetWebseiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CubssnetKontaktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmr_core_mailserver_wait = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_waittime_visual = New System.Windows.Forms.Timer(Me.components)
        Me.tss_main_text = New System.Windows.Forms.ToolStripStatusLabel()
        Me.colKundeSeit_Tage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBestellsumme_UmsatzProTag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cmbSprache = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cmbKundengruppe = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.optNewsletterYES = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tbNewsletter.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.tbEditor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbProduktverwaltung_newsletter.SuspendLayout()
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
        Me.TabControl1.Controls.Add(Me.tbProduktverwaltung_newsletter)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1347, 678)
        Me.TabControl1.TabIndex = 0
        '
        'tbNewsletter
        '
        Me.tbNewsletter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNewsletter.Controls.Add(Me.optNewsletterYES)
        Me.tbNewsletter.Controls.Add(Me.Label37)
        Me.tbNewsletter.Controls.Add(Me.Label36)
        Me.tbNewsletter.Controls.Add(Me.cmbKundengruppe)
        Me.tbNewsletter.Controls.Add(Me.Label35)
        Me.tbNewsletter.Controls.Add(Me.cmbSprache)
        Me.tbNewsletter.Controls.Add(Me.txtCore_Mail_bei)
        Me.tbNewsletter.Controls.Add(Me.lblCore_Mail_bei)
        Me.tbNewsletter.Controls.Add(Me.txtCore_mail_bis)
        Me.tbNewsletter.Controls.Add(Me.lblCore_mail_bis)
        Me.tbNewsletter.Controls.Add(Me.chkTestlauf)
        Me.tbNewsletter.Controls.Add(Me.Label32)
        Me.tbNewsletter.Controls.Add(Me.cmbKundenKategorie)
        Me.tbNewsletter.Controls.Add(Me.chkNichtAmazon)
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
        Me.tbNewsletter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNewsletter.Location = New System.Drawing.Point(4, 25)
        Me.tbNewsletter.Name = "tbNewsletter"
        Me.tbNewsletter.Padding = New System.Windows.Forms.Padding(3)
        Me.tbNewsletter.Size = New System.Drawing.Size(1339, 649)
        Me.tbNewsletter.TabIndex = 0
        Me.tbNewsletter.Text = "Newsletter abschicken"
        Me.tbNewsletter.UseVisualStyleBackColor = True
        '
        'txtCore_Mail_bei
        '
        Me.txtCore_Mail_bei.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCore_Mail_bei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCore_Mail_bei.Location = New System.Drawing.Point(1088, 65)
        Me.txtCore_Mail_bei.Name = "txtCore_Mail_bei"
        Me.txtCore_Mail_bei.Size = New System.Drawing.Size(154, 20)
        Me.txtCore_Mail_bei.TabIndex = 24
        Me.txtCore_Mail_bei.Text = "0"
        Me.txtCore_Mail_bei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCore_Mail_bei.Visible = False
        '
        'lblCore_Mail_bei
        '
        Me.lblCore_Mail_bei.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCore_Mail_bei.AutoSize = True
        Me.lblCore_Mail_bei.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCore_Mail_bei.Location = New System.Drawing.Point(1086, 48)
        Me.lblCore_Mail_bei.Name = "lblCore_Mail_bei"
        Me.lblCore_Mail_bei.Size = New System.Drawing.Size(67, 13)
        Me.lblCore_Mail_bei.TabIndex = 23
        Me.lblCore_Mail_bei.Text = "Aktuell bei"
        Me.lblCore_Mail_bei.Visible = False
        '
        'txtCore_mail_bis
        '
        Me.txtCore_mail_bis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCore_mail_bis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCore_mail_bis.Location = New System.Drawing.Point(929, 65)
        Me.txtCore_mail_bis.Name = "txtCore_mail_bis"
        Me.txtCore_mail_bis.Size = New System.Drawing.Size(154, 20)
        Me.txtCore_mail_bis.TabIndex = 22
        Me.txtCore_mail_bis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCore_mail_bis.Visible = False
        '
        'lblCore_mail_bis
        '
        Me.lblCore_mail_bis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCore_mail_bis.AutoSize = True
        Me.lblCore_mail_bis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCore_mail_bis.Location = New System.Drawing.Point(927, 48)
        Me.lblCore_mail_bis.Name = "lblCore_mail_bis"
        Me.lblCore_mail_bis.Size = New System.Drawing.Size(109, 13)
        Me.lblCore_mail_bis.TabIndex = 21
        Me.lblCore_mail_bis.Text = "Emails pro Stunde"
        Me.lblCore_mail_bis.Visible = False
        '
        'chkTestlauf
        '
        Me.chkTestlauf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTestlauf.AutoSize = True
        Me.chkTestlauf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTestlauf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTestlauf.Location = New System.Drawing.Point(792, 80)
        Me.chkTestlauf.Name = "chkTestlauf"
        Me.chkTestlauf.Size = New System.Drawing.Size(129, 17)
        Me.chkTestlauf.TabIndex = 20
        Me.chkTestlauf.Text = "Testlauf aktivieren"
        Me.chkTestlauf.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(236, 95)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(181, 13)
        Me.Label32.TabIndex = 19
        Me.Label32.Text = "JTL Wawi Kundenkategorie"
        '
        'cmbKundenKategorie
        '
        Me.cmbKundenKategorie.DropDownHeight = 110
        Me.cmbKundenKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKundenKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKundenKategorie.FormattingEnabled = True
        Me.cmbKundenKategorie.IntegralHeight = False
        Me.cmbKundenKategorie.Location = New System.Drawing.Point(239, 113)
        Me.cmbKundenKategorie.Name = "cmbKundenKategorie"
        Me.cmbKundenKategorie.Size = New System.Drawing.Size(173, 21)
        Me.cmbKundenKategorie.TabIndex = 18
        '
        'chkNichtAmazon
        '
        Me.chkNichtAmazon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkNichtAmazon.AutoSize = True
        Me.chkNichtAmazon.Checked = True
        Me.chkNichtAmazon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNichtAmazon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNichtAmazon.Location = New System.Drawing.Point(792, 55)
        Me.chkNichtAmazon.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNichtAmazon.Name = "chkNichtAmazon"
        Me.chkNichtAmazon.Size = New System.Drawing.Size(132, 17)
        Me.chkNichtAmazon.TabIndex = 17
        Me.chkNichtAmazon.Text = "Nicht Amazon Kunden "
        Me.chkNichtAmazon.UseVisualStyleBackColor = True
        '
        'optAngemeldet
        '
        Me.optAngemeldet.AutoSize = True
        Me.optAngemeldet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAngemeldet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAngemeldet.Location = New System.Drawing.Point(458, 75)
        Me.optAngemeldet.Name = "optAngemeldet"
        Me.optAngemeldet.Size = New System.Drawing.Size(90, 17)
        Me.optAngemeldet.TabIndex = 16
        Me.optAngemeldet.Text = "&Angemeldet"
        Me.optAngemeldet.UseVisualStyleBackColor = True
        '
        'optAbgemeldet
        '
        Me.optAbgemeldet.AutoSize = True
        Me.optAbgemeldet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAbgemeldet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAbgemeldet.Location = New System.Drawing.Point(667, 75)
        Me.optAbgemeldet.Name = "optAbgemeldet"
        Me.optAbgemeldet.Size = New System.Drawing.Size(90, 17)
        Me.optAbgemeldet.TabIndex = 15
        Me.optAbgemeldet.Text = "&Abgemeldet"
        Me.optAbgemeldet.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "JTL Wawi Firma / Mandant"
        '
        'cmbMandant
        '
        Me.cmbMandant.DropDownHeight = 110
        Me.cmbMandant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMandant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMandant.FormattingEnabled = True
        Me.cmbMandant.IntegralHeight = False
        Me.cmbMandant.Location = New System.Drawing.Point(17, 66)
        Me.cmbMandant.Name = "cmbMandant"
        Me.cmbMandant.Size = New System.Drawing.Size(213, 21)
        Me.cmbMandant.TabIndex = 13
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnSend.Enabled = False
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(1041, 108)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(281, 57)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "&Wawi Newsletter Versand starten"
        Me.ToolTip1.SetToolTip(Me.btnSend, "Startet je nach Bezeichnung den Testlauflauf oder den ""Newsletter Versand starten" &
        """")
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnEinlesen
        '
        Me.btnEinlesen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEinlesen.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnEinlesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEinlesen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEinlesen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEinlesen.Location = New System.Drawing.Point(792, 108)
        Me.btnEinlesen.Name = "btnEinlesen"
        Me.btnEinlesen.Size = New System.Drawing.Size(244, 57)
        Me.btnEinlesen.TabIndex = 11
        Me.btnEinlesen.Text = "JTL Wawi Kunden &einlesen"
        Me.ToolTip1.SetToolTip(Me.btnEinlesen, "Baut eine Liste mit Kunden auf, welche Sie abschicken können")
        Me.btnEinlesen.UseVisualStyleBackColor = False
        '
        'lvwJTLKunden
        '
        Me.lvwJTLKunden.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwJTLKunden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwJTLKunden.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKundenID, Me.colVorname, Me.colNachname, Me.colOrt, Me.colEmail, Me.colFirma, Me.colKDNR, Me.colStrasse, Me.colLand, Me.colAnrede, Me.colPLZ, Me.colGetNewsletter, Me.colKundeSeit, Me.colBestellsumme, Me.colKundeSeit_Tage, Me.colBestellsumme_UmsatzProTag})
        Me.lvwJTLKunden.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvwJTLKunden.FullRowSelect = True
        Me.lvwJTLKunden.GridLines = True
        Me.lvwJTLKunden.HideSelection = False
        Me.lvwJTLKunden.Location = New System.Drawing.Point(18, 171)
        Me.lvwJTLKunden.Name = "lvwJTLKunden"
        Me.lvwJTLKunden.Size = New System.Drawing.Size(1304, 471)
        Me.lvwJTLKunden.TabIndex = 10
        Me.lvwJTLKunden.UseCompatibleStateImageBehavior = False
        Me.lvwJTLKunden.View = System.Windows.Forms.View.Details
        '
        'colKundenID
        '
        Me.colKundenID.DisplayIndex = 14
        Me.colKundenID.Text = "ID"
        Me.colKundenID.Width = 0
        '
        'colVorname
        '
        Me.colVorname.DisplayIndex = 7
        Me.colVorname.Text = "Vorname"
        Me.colVorname.Width = 100
        '
        'colNachname
        '
        Me.colNachname.DisplayIndex = 8
        Me.colNachname.Text = "Nachname"
        Me.colNachname.Width = 120
        '
        'colOrt
        '
        Me.colOrt.DisplayIndex = 11
        Me.colOrt.Text = "Stadt"
        Me.colOrt.Width = 70
        '
        'colEmail
        '
        Me.colEmail.DisplayIndex = 9
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
        Me.colKDNR.DisplayIndex = 5
        Me.colKDNR.Text = "KundenNr."
        Me.colKDNR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colKDNR.Width = 70
        '
        'colStrasse
        '
        Me.colStrasse.DisplayIndex = 12
        Me.colStrasse.Text = "Straße"
        Me.colStrasse.Width = 150
        '
        'colLand
        '
        Me.colLand.DisplayIndex = 13
        Me.colLand.Text = "Land"
        Me.colLand.Width = 120
        '
        'colAnrede
        '
        Me.colAnrede.DisplayIndex = 6
        Me.colAnrede.Text = "Anrede"
        Me.colAnrede.Width = 50
        '
        'colPLZ
        '
        Me.colPLZ.Text = "PLZ"
        Me.colPLZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colPLZ.Width = 50
        '
        'colGetNewsletter
        '
        Me.colGetNewsletter.DisplayIndex = 15
        Me.colGetNewsletter.Text = "Angemeldet"
        '
        'colKundeSeit
        '
        Me.colKundeSeit.DisplayIndex = 1
        Me.colKundeSeit.Text = "Kunde Seit"
        Me.colKundeSeit.Width = 120
        '
        'colBestellsumme
        '
        Me.colBestellsumme.DisplayIndex = 2
        Me.colBestellsumme.Text = "Bestellsumme"
        Me.colBestellsumme.Width = 80
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VorschauToolStripMenuItem, Me.NewsletterAbmeldenToolStripMenuItem, Me.txtToolTipSuche, Me.VerschicktEinstellenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(205, 95)
        '
        'VorschauToolStripMenuItem
        '
        Me.VorschauToolStripMenuItem.Name = "VorschauToolStripMenuItem"
        Me.VorschauToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.VorschauToolStripMenuItem.Text = "&Vorschau..."
        '
        'NewsletterAbmeldenToolStripMenuItem
        '
        Me.NewsletterAbmeldenToolStripMenuItem.Name = "NewsletterAbmeldenToolStripMenuItem"
        Me.NewsletterAbmeldenToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.NewsletterAbmeldenToolStripMenuItem.Text = "Newsletter abmelden"
        '
        'txtToolTipSuche
        '
        Me.txtToolTipSuche.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtToolTipSuche.Name = "txtToolTipSuche"
        Me.txtToolTipSuche.Size = New System.Drawing.Size(130, 23)
        '
        'VerschicktEinstellenToolStripMenuItem
        '
        Me.VerschicktEinstellenToolStripMenuItem.Name = "VerschicktEinstellenToolStripMenuItem"
        Me.VerschicktEinstellenToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.VerschicktEinstellenToolStripMenuItem.Text = "Auf verschickt umstellen"
        '
        'optNewsletterAbschicken
        '
        Me.optNewsletterAbschicken.AutoSize = True
        Me.optNewsletterAbschicken.Checked = True
        Me.optNewsletterAbschicken.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optNewsletterAbschicken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNewsletterAbschicken.Location = New System.Drawing.Point(458, 52)
        Me.optNewsletterAbschicken.Name = "optNewsletterAbschicken"
        Me.optNewsletterAbschicken.Size = New System.Drawing.Size(112, 17)
        Me.optNewsletterAbschicken.TabIndex = 9
        Me.optNewsletterAbschicken.TabStop = True
        Me.optNewsletterAbschicken.Text = "&Abschick bereit"
        Me.optNewsletterAbschicken.UseVisualStyleBackColor = True
        '
        'optNewsletterVerschickt
        '
        Me.optNewsletterVerschickt.AutoSize = True
        Me.optNewsletterVerschickt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optNewsletterVerschickt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNewsletterVerschickt.Location = New System.Drawing.Point(667, 52)
        Me.optNewsletterVerschickt.Name = "optNewsletterVerschickt"
        Me.optNewsletterVerschickt.Size = New System.Drawing.Size(84, 17)
        Me.optNewsletterVerschickt.TabIndex = 8
        Me.optNewsletterVerschickt.Text = "&Verschickt"
        Me.optNewsletterVerschickt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Filterkriterien Setup"
        '
        'tbEditor
        '
        Me.tbEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEditor.Controls.Add(Me.lblHilfe)
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
        Me.tbEditor.Size = New System.Drawing.Size(1010, 649)
        Me.tbEditor.TabIndex = 1
        Me.tbEditor.Text = "Vorlageneditor"
        Me.tbEditor.ToolTipText = "Newslettervorlage verändern"
        Me.tbEditor.UseVisualStyleBackColor = True
        '
        'lblHilfe
        '
        Me.lblHilfe.AutoSize = True
        Me.lblHilfe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHilfe.Location = New System.Drawing.Point(832, 64)
        Me.lblHilfe.Name = "lblHilfe"
        Me.lblHilfe.Size = New System.Drawing.Size(152, 13)
        Me.lblHilfe.TabIndex = 83
        Me.lblHilfe.TabStop = True
        Me.lblHilfe.Text = "Newsletter Variablen Hilfe"
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
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Betreffzeile des Newsletters"
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
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "HTML-Vorlage für den Newsletter"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnVorlagespeichern)
        Me.Panel1.Controls.Add(Me.txtVorlageQuellcode)
        Me.Panel1.Location = New System.Drawing.Point(3, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 535)
        Me.Panel1.TabIndex = 76
        '
        'btnVorlagespeichern
        '
        Me.btnVorlagespeichern.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnVorlagespeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVorlagespeichern.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVorlagespeichern.Location = New System.Drawing.Point(6, 501)
        Me.btnVorlagespeichern.Name = "btnVorlagespeichern"
        Me.btnVorlagespeichern.Size = New System.Drawing.Size(991, 31)
        Me.btnVorlagespeichern.TabIndex = 80
        Me.btnVorlagespeichern.Text = "Speichern in HTMl-Vorlagepfad"
        Me.btnVorlagespeichern.UseVisualStyleBackColor = False
        '
        'txtVorlageQuellcode
        '
        Me.txtVorlageQuellcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVorlageQuellcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVorlageQuellcode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVorlageQuellcode.Location = New System.Drawing.Point(6, 3)
        Me.txtVorlageQuellcode.Multiline = True
        Me.txtVorlageQuellcode.Name = "txtVorlageQuellcode"
        Me.txtVorlageQuellcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVorlageQuellcode.Size = New System.Drawing.Size(991, 492)
        Me.txtVorlageQuellcode.TabIndex = 78
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1010, 649)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Testlauf Einstellungen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtTestlaufEmail)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnAbmeldeURL)
        Me.GroupBox2.Controls.Add(Me.txtTestlaufAnzahl)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(996, 230)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Emailversand Testlauf-Einstellungen"
        '
        'txtTestlaufEmail
        '
        Me.txtTestlaufEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTestlaufEmail.Location = New System.Drawing.Point(19, 58)
        Me.txtTestlaufEmail.Name = "txtTestlaufEmail"
        Me.txtTestlaufEmail.Size = New System.Drawing.Size(679, 20)
        Me.txtTestlaufEmail.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtTestlaufEmail, "Legen Sie hier Ihre Emailadresse fest, an welche alle Emails gesendet werden soll" &
        "en.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(395, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Alle Emails im Testlauf Modus an die folgende Email Adresse senden"
        '
        'btnAbmeldeURL
        '
        Me.btnAbmeldeURL.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnAbmeldeURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbmeldeURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbmeldeURL.Location = New System.Drawing.Point(19, 156)
        Me.btnAbmeldeURL.Name = "btnAbmeldeURL"
        Me.btnAbmeldeURL.Size = New System.Drawing.Size(679, 23)
        Me.btnAbmeldeURL.TabIndex = 13
        Me.btnAbmeldeURL.Text = "&Newsletter Abmeldung festlegen..."
        Me.btnAbmeldeURL.UseVisualStyleBackColor = False
        '
        'txtTestlaufAnzahl
        '
        Me.txtTestlaufAnzahl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTestlaufAnzahl.Location = New System.Drawing.Point(20, 119)
        Me.txtTestlaufAnzahl.Name = "txtTestlaufAnzahl"
        Me.txtTestlaufAnzahl.Size = New System.Drawing.Size(52, 20)
        Me.txtTestlaufAnzahl.TabIndex = 4
        Me.txtTestlaufAnzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtTestlaufAnzahl, "Wie weit soll die Liste abgearbeitet werden (wieviele echte Testkunden) ?")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Anzahl der Testlauf Emails"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCore_wartezeit)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.txtEmailServerLimitierungen_anzahl_pro_stunde)
        Me.GroupBox1.Controls.Add(Me.chkEmailServerLimitierungen)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 245)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(996, 396)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Email-Server Limitierungen"
        '
        'txtCore_wartezeit
        '
        Me.txtCore_wartezeit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCore_wartezeit.Location = New System.Drawing.Point(20, 134)
        Me.txtCore_wartezeit.Name = "txtCore_wartezeit"
        Me.txtCore_wartezeit.Size = New System.Drawing.Size(154, 20)
        Me.txtCore_wartezeit.TabIndex = 6
        Me.txtCore_wartezeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(18, 117)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(242, 13)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "Wartezeit in Millisekunden (1000 = 1 sek)"
        '
        'txtEmailServerLimitierungen_anzahl_pro_stunde
        '
        Me.txtEmailServerLimitierungen_anzahl_pro_stunde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailServerLimitierungen_anzahl_pro_stunde.Location = New System.Drawing.Point(19, 86)
        Me.txtEmailServerLimitierungen_anzahl_pro_stunde.Name = "txtEmailServerLimitierungen_anzahl_pro_stunde"
        Me.txtEmailServerLimitierungen_anzahl_pro_stunde.Size = New System.Drawing.Size(154, 20)
        Me.txtEmailServerLimitierungen_anzahl_pro_stunde.TabIndex = 4
        Me.txtEmailServerLimitierungen_anzahl_pro_stunde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkEmailServerLimitierungen
        '
        Me.chkEmailServerLimitierungen.AutoSize = True
        Me.chkEmailServerLimitierungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEmailServerLimitierungen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEmailServerLimitierungen.Location = New System.Drawing.Point(21, 34)
        Me.chkEmailServerLimitierungen.Name = "chkEmailServerLimitierungen"
        Me.chkEmailServerLimitierungen.Size = New System.Drawing.Size(233, 17)
        Me.chkEmailServerLimitierungen.TabIndex = 1
        Me.chkEmailServerLimitierungen.Text = "Email-Server Limitierungen aktivieren"
        Me.chkEmailServerLimitierungen.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(17, 69)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(109, 13)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Emails pro Stunde"
        '
        'tbProduktverwaltung_newsletter
        '
        Me.tbProduktverwaltung_newsletter.AutoScroll = True
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtBildlink5)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label27)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion5_artikelliste)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion5_beschreibung)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion5_bild)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label28)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label29)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label30)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label31)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtBildlink4)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label26)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtBildLink3)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label25)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtBildLink2)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label24)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtBildLink)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label23)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion4_artikelliste)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion4_beschreibung)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion4_bild)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label19)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label20)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label21)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label22)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion3_artikelliste)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion3_beschreibung)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion3_bild)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label15)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label16)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label17)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label18)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion2_artikelliste)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion2_beschreibung)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion2_bild)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label7)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label12)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label13)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label14)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion1_shopartikelbySKU)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion1_beschreibung)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.txtSektion1_header_bild)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label11)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label10)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label9)
        Me.tbProduktverwaltung_newsletter.Controls.Add(Me.Label8)
        Me.tbProduktverwaltung_newsletter.Location = New System.Drawing.Point(4, 25)
        Me.tbProduktverwaltung_newsletter.Margin = New System.Windows.Forms.Padding(2)
        Me.tbProduktverwaltung_newsletter.Name = "tbProduktverwaltung_newsletter"
        Me.tbProduktverwaltung_newsletter.Padding = New System.Windows.Forms.Padding(2)
        Me.tbProduktverwaltung_newsletter.Size = New System.Drawing.Size(1010, 649)
        Me.tbProduktverwaltung_newsletter.TabIndex = 3
        Me.tbProduktverwaltung_newsletter.Text = "Newsletter Produktverwaltung"
        Me.tbProduktverwaltung_newsletter.UseVisualStyleBackColor = True
        '
        'txtBildlink5
        '
        Me.txtBildlink5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBildlink5.Location = New System.Drawing.Point(165, 1461)
        Me.txtBildlink5.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBildlink5.Name = "txtBildlink5"
        Me.txtBildlink5.Size = New System.Drawing.Size(314, 20)
        Me.txtBildlink5.TabIndex = 59
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(16, 1465)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(117, 13)
        Me.Label27.TabIndex = 58
        Me.Label27.Text = "Sektion Bild-Link"
        '
        'txtSektion5_artikelliste
        '
        Me.txtSektion5_artikelliste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion5_artikelliste.Location = New System.Drawing.Point(165, 1661)
        Me.txtSektion5_artikelliste.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion5_artikelliste.Multiline = True
        Me.txtSektion5_artikelliste.Name = "txtSektion5_artikelliste"
        Me.txtSektion5_artikelliste.Size = New System.Drawing.Size(639, 60)
        Me.txtSektion5_artikelliste.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.txtSektion5_artikelliste, "Bitte Artikel Nr durch "";"" trennen")
        '
        'txtSektion5_beschreibung
        '
        Me.txtSektion5_beschreibung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion5_beschreibung.Location = New System.Drawing.Point(165, 1504)
        Me.txtSektion5_beschreibung.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion5_beschreibung.Multiline = True
        Me.txtSektion5_beschreibung.Name = "txtSektion5_beschreibung"
        Me.txtSektion5_beschreibung.Size = New System.Drawing.Size(639, 134)
        Me.txtSektion5_beschreibung.TabIndex = 56
        '
        'txtSektion5_bild
        '
        Me.txtSektion5_bild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion5_bild.Location = New System.Drawing.Point(165, 1428)
        Me.txtSektion5_bild.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion5_bild.Name = "txtSektion5_bild"
        Me.txtSektion5_bild.Size = New System.Drawing.Size(314, 20)
        Me.txtSektion5_bild.TabIndex = 55
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(16, 1661)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 13)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Sektion Artikel"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(16, 1504)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(148, 13)
        Me.Label29.TabIndex = 53
        Me.Label29.Text = "Sektion Beschreibung"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(16, 1432)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(84, 13)
        Me.Label30.TabIndex = 52
        Me.Label30.Text = "Sektion Bild"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(14, 1395)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(131, 26)
        Me.Label31.TabIndex = 51
        Me.Label31.Text = "Sektion 5"
        '
        'txtBildlink4
        '
        Me.txtBildlink4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBildlink4.Location = New System.Drawing.Point(167, 1126)
        Me.txtBildlink4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBildlink4.Name = "txtBildlink4"
        Me.txtBildlink4.Size = New System.Drawing.Size(314, 20)
        Me.txtBildlink4.TabIndex = 50
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(18, 1130)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(117, 13)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "Sektion Bild-Link"
        '
        'txtBildLink3
        '
        Me.txtBildLink3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBildLink3.Location = New System.Drawing.Point(167, 791)
        Me.txtBildLink3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBildLink3.Name = "txtBildLink3"
        Me.txtBildLink3.Size = New System.Drawing.Size(314, 20)
        Me.txtBildLink3.TabIndex = 48
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(18, 795)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(117, 13)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "Sektion Bild-Link"
        '
        'txtBildLink2
        '
        Me.txtBildLink2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBildLink2.Location = New System.Drawing.Point(167, 427)
        Me.txtBildLink2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBildLink2.Name = "txtBildLink2"
        Me.txtBildLink2.Size = New System.Drawing.Size(314, 20)
        Me.txtBildLink2.TabIndex = 46
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(18, 431)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(117, 13)
        Me.Label24.TabIndex = 45
        Me.Label24.Text = "Sektion Bild-Link"
        '
        'txtBildLink
        '
        Me.txtBildLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBildLink.Location = New System.Drawing.Point(167, 80)
        Me.txtBildLink.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBildLink.Name = "txtBildLink"
        Me.txtBildLink.Size = New System.Drawing.Size(314, 20)
        Me.txtBildLink.TabIndex = 44
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(18, 84)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(117, 13)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "Sektion Bild-Link"
        '
        'txtSektion4_artikelliste
        '
        Me.txtSektion4_artikelliste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion4_artikelliste.Location = New System.Drawing.Point(167, 1326)
        Me.txtSektion4_artikelliste.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion4_artikelliste.Multiline = True
        Me.txtSektion4_artikelliste.Name = "txtSektion4_artikelliste"
        Me.txtSektion4_artikelliste.Size = New System.Drawing.Size(639, 60)
        Me.txtSektion4_artikelliste.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.txtSektion4_artikelliste, "Bitte Artikel Nr durch "";"" trennen")
        '
        'txtSektion4_beschreibung
        '
        Me.txtSektion4_beschreibung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion4_beschreibung.Location = New System.Drawing.Point(167, 1169)
        Me.txtSektion4_beschreibung.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion4_beschreibung.Multiline = True
        Me.txtSektion4_beschreibung.Name = "txtSektion4_beschreibung"
        Me.txtSektion4_beschreibung.Size = New System.Drawing.Size(639, 134)
        Me.txtSektion4_beschreibung.TabIndex = 41
        '
        'txtSektion4_bild
        '
        Me.txtSektion4_bild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion4_bild.Location = New System.Drawing.Point(167, 1093)
        Me.txtSektion4_bild.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion4_bild.Name = "txtSektion4_bild"
        Me.txtSektion4_bild.Size = New System.Drawing.Size(314, 20)
        Me.txtSektion4_bild.TabIndex = 40
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(18, 1326)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 13)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Sektion Artikel"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(18, 1169)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(148, 13)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Sektion Beschreibung"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(18, 1097)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 13)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Sektion Bild"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 1060)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(131, 26)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Sektion 4"
        '
        'txtSektion3_artikelliste
        '
        Me.txtSektion3_artikelliste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion3_artikelliste.Location = New System.Drawing.Point(167, 989)
        Me.txtSektion3_artikelliste.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion3_artikelliste.Multiline = True
        Me.txtSektion3_artikelliste.Name = "txtSektion3_artikelliste"
        Me.txtSektion3_artikelliste.Size = New System.Drawing.Size(639, 60)
        Me.txtSektion3_artikelliste.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.txtSektion3_artikelliste, "Bitte Artikel Nr durch "";"" trennen")
        '
        'txtSektion3_beschreibung
        '
        Me.txtSektion3_beschreibung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion3_beschreibung.Location = New System.Drawing.Point(167, 832)
        Me.txtSektion3_beschreibung.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion3_beschreibung.Multiline = True
        Me.txtSektion3_beschreibung.Name = "txtSektion3_beschreibung"
        Me.txtSektion3_beschreibung.Size = New System.Drawing.Size(639, 134)
        Me.txtSektion3_beschreibung.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.txtSektion3_beschreibung, "Bitte Artikel Nr durch "";"" trennen")
        '
        'txtSektion3_bild
        '
        Me.txtSektion3_bild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion3_bild.Location = New System.Drawing.Point(167, 754)
        Me.txtSektion3_bild.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion3_bild.Name = "txtSektion3_bild"
        Me.txtSektion3_bild.Size = New System.Drawing.Size(314, 20)
        Me.txtSektion3_bild.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 989)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Sektion Artikel"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 832)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(148, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Sektion Beschreibung"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 758)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Sektion Bild"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 722)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(131, 26)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Sektion 3"
        '
        'txtSektion2_artikelliste
        '
        Me.txtSektion2_artikelliste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion2_artikelliste.Location = New System.Drawing.Point(167, 619)
        Me.txtSektion2_artikelliste.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion2_artikelliste.Multiline = True
        Me.txtSektion2_artikelliste.Name = "txtSektion2_artikelliste"
        Me.txtSektion2_artikelliste.Size = New System.Drawing.Size(639, 60)
        Me.txtSektion2_artikelliste.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.txtSektion2_artikelliste, "Bitte Artikel Nr durch "";"" trennen")
        '
        'txtSektion2_beschreibung
        '
        Me.txtSektion2_beschreibung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion2_beschreibung.Location = New System.Drawing.Point(167, 462)
        Me.txtSektion2_beschreibung.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion2_beschreibung.Multiline = True
        Me.txtSektion2_beschreibung.Name = "txtSektion2_beschreibung"
        Me.txtSektion2_beschreibung.Size = New System.Drawing.Size(639, 134)
        Me.txtSektion2_beschreibung.TabIndex = 27
        '
        'txtSektion2_bild
        '
        Me.txtSektion2_bild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion2_bild.Location = New System.Drawing.Point(167, 396)
        Me.txtSektion2_bild.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion2_bild.Name = "txtSektion2_bild"
        Me.txtSektion2_bild.Size = New System.Drawing.Size(314, 20)
        Me.txtSektion2_bild.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 619)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Sektion Artikel"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 462)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Sektion Beschreibung"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 400)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Sektion Bild"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 363)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 26)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Sektion 2"
        '
        'txtSektion1_shopartikelbySKU
        '
        Me.txtSektion1_shopartikelbySKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion1_shopartikelbySKU.Location = New System.Drawing.Point(167, 273)
        Me.txtSektion1_shopartikelbySKU.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion1_shopartikelbySKU.Multiline = True
        Me.txtSektion1_shopartikelbySKU.Name = "txtSektion1_shopartikelbySKU"
        Me.txtSektion1_shopartikelbySKU.Size = New System.Drawing.Size(639, 60)
        Me.txtSektion1_shopartikelbySKU.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.txtSektion1_shopartikelbySKU, "Bitte Artikel Nr durch "";"" trennen")
        '
        'txtSektion1_beschreibung
        '
        Me.txtSektion1_beschreibung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion1_beschreibung.Location = New System.Drawing.Point(167, 116)
        Me.txtSektion1_beschreibung.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion1_beschreibung.Multiline = True
        Me.txtSektion1_beschreibung.Name = "txtSektion1_beschreibung"
        Me.txtSektion1_beschreibung.Size = New System.Drawing.Size(639, 134)
        Me.txtSektion1_beschreibung.TabIndex = 20
        '
        'txtSektion1_header_bild
        '
        Me.txtSektion1_header_bild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSektion1_header_bild.Location = New System.Drawing.Point(167, 46)
        Me.txtSektion1_header_bild.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSektion1_header_bild.Name = "txtSektion1_header_bild"
        Me.txtSektion1_header_bild.Size = New System.Drawing.Size(314, 20)
        Me.txtSektion1_header_bild.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Sektion Artikel"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Sektion Beschreibung"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Sektion Bild"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 26)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Sektion 1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msgMaster, Me.masterpgr, Me.tss_main_text})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 708)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1371, 22)
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
        Me.masterpgr.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.WerkzeugeToolStripMenuItem, Me.EinstellungenToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1371, 24)
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
        Me.BeendenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'WerkzeugeToolStripMenuItem
        '
        Me.WerkzeugeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewsletterNeustartenToolStripMenuItem, Me.EinstellungenDebugToolStripMenuItem, Me.NewsletterAbmeldungenHolenToolStripMenuItem})
        Me.WerkzeugeToolStripMenuItem.Name = "WerkzeugeToolStripMenuItem"
        Me.WerkzeugeToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.WerkzeugeToolStripMenuItem.Text = "&Werkzeuge"
        '
        'NewsletterNeustartenToolStripMenuItem
        '
        Me.NewsletterNeustartenToolStripMenuItem.Name = "NewsletterNeustartenToolStripMenuItem"
        Me.NewsletterNeustartenToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.NewsletterNeustartenToolStripMenuItem.Text = "&Newsletter neustarten..."
        '
        'EinstellungenDebugToolStripMenuItem
        '
        Me.EinstellungenDebugToolStripMenuItem.Name = "EinstellungenDebugToolStripMenuItem"
        Me.EinstellungenDebugToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.EinstellungenDebugToolStripMenuItem.Text = "Einstellungen Debug"
        Me.EinstellungenDebugToolStripMenuItem.Visible = False
        '
        'NewsletterAbmeldungenHolenToolStripMenuItem
        '
        Me.NewsletterAbmeldungenHolenToolStripMenuItem.Name = "NewsletterAbmeldungenHolenToolStripMenuItem"
        Me.NewsletterAbmeldungenHolenToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.NewsletterAbmeldungenHolenToolStripMenuItem.Text = "Newsletter Abmeldungen holen..."
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankeinstellungenToolStripMenuItem, Me.MailserverEinstellungenToolStripMenuItem, Me.JTLShopEinstellungenToolStripMenuItem, Me.JTLNewsletterUpdatesToolStripMenuItem})
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
        'JTLShopEinstellungenToolStripMenuItem
        '
        Me.JTLShopEinstellungenToolStripMenuItem.Name = "JTLShopEinstellungenToolStripMenuItem"
        Me.JTLShopEinstellungenToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.JTLShopEinstellungenToolStripMenuItem.Text = "JTL Shop Einstellungen..."
        '
        'JTLNewsletterUpdatesToolStripMenuItem
        '
        Me.JTLNewsletterUpdatesToolStripMenuItem.Name = "JTLNewsletterUpdatesToolStripMenuItem"
        Me.JTLNewsletterUpdatesToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.JTLNewsletterUpdatesToolStripMenuItem.Text = "JTL Newsletter Updates..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CubssnetWebseiteToolStripMenuItem, Me.CubssnetKontaktToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'CubssnetWebseiteToolStripMenuItem
        '
        Me.CubssnetWebseiteToolStripMenuItem.Name = "CubssnetWebseiteToolStripMenuItem"
        Me.CubssnetWebseiteToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CubssnetWebseiteToolStripMenuItem.Text = "Bludau Media Webseite..."
        '
        'CubssnetKontaktToolStripMenuItem
        '
        Me.CubssnetKontaktToolStripMenuItem.Name = "CubssnetKontaktToolStripMenuItem"
        Me.CubssnetKontaktToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CubssnetKontaktToolStripMenuItem.Text = "Bludau Media Kontakt..."
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
        'tmr_core_mailserver_wait
        '
        Me.tmr_core_mailserver_wait.Interval = 3600000
        '
        'tmr_waittime_visual
        '
        Me.tmr_waittime_visual.Interval = 1000
        '
        'tss_main_text
        '
        Me.tss_main_text.Name = "tss_main_text"
        Me.tss_main_text.Size = New System.Drawing.Size(0, 17)
        '
        'colKundeSeit_Tage
        '
        Me.colKundeSeit_Tage.DisplayIndex = 3
        Me.colKundeSeit_Tage.Text = "Tage Kunde"
        Me.colKundeSeit_Tage.Width = 72
        '
        'colBestellsumme_UmsatzProTag
        '
        Me.colBestellsumme_UmsatzProTag.DisplayIndex = 4
        Me.colBestellsumme_UmsatzProTag.Text = "Umsatz pro Tag"
        Me.colBestellsumme_UmsatzProTag.Width = 100
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(236, 48)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(123, 13)
        Me.Label35.TabIndex = 26
        Me.Label35.Text = "JTL Wawi Sprache"
        '
        'cmbSprache
        '
        Me.cmbSprache.DropDownHeight = 110
        Me.cmbSprache.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSprache.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSprache.FormattingEnabled = True
        Me.cmbSprache.IntegralHeight = False
        Me.cmbSprache.Location = New System.Drawing.Point(239, 66)
        Me.cmbSprache.Name = "cmbSprache"
        Me.cmbSprache.Size = New System.Drawing.Size(173, 21)
        Me.cmbSprache.TabIndex = 25
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(14, 95)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(164, 13)
        Me.Label36.TabIndex = 28
        Me.Label36.Text = "JTL Wawi Kundengruppe"
        '
        'cmbKundengruppe
        '
        Me.cmbKundengruppe.DropDownHeight = 110
        Me.cmbKundengruppe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKundengruppe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKundengruppe.FormattingEnabled = True
        Me.cmbKundengruppe.IntegralHeight = False
        Me.cmbKundengruppe.Location = New System.Drawing.Point(17, 113)
        Me.cmbKundengruppe.Name = "cmbKundengruppe"
        Me.cmbKundengruppe.Size = New System.Drawing.Size(213, 21)
        Me.cmbKundengruppe.TabIndex = 27
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(456, 15)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(313, 18)
        Me.Label37.TabIndex = 29
        Me.Label37.Text = "Ladekriterien der Newsletterdaten"
        '
        'optNewsletterYES
        '
        Me.optNewsletterYES.AutoSize = True
        Me.optNewsletterYES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optNewsletterYES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNewsletterYES.Location = New System.Drawing.Point(459, 98)
        Me.optNewsletterYES.Name = "optNewsletterYES"
        Me.optNewsletterYES.Size = New System.Drawing.Size(144, 17)
        Me.optNewsletterYES.TabIndex = 30
        Me.optNewsletterYES.Text = "&Newsletter Ja (Wawi)"
        Me.optNewsletterYES.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 730)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JTL WaWi Newsletter"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tbNewsletter.ResumeLayout(False)
        Me.tbNewsletter.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip1.PerformLayout()
        Me.tbEditor.ResumeLayout(False)
        Me.tbEditor.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbProduktverwaltung_newsletter.ResumeLayout(False)
        Me.tbProduktverwaltung_newsletter.PerformLayout()
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtVorlageQuellcode As System.Windows.Forms.TextBox
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
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtToolTipSuche As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents VerschicktEinstellenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungenDebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CubssnetWebseiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CubssnetKontaktToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JTLNewsletterUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewsletterAbmeldungenHolenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAbmeldeURL As System.Windows.Forms.Button
    Friend WithEvents lblHilfe As System.Windows.Forms.LinkLabel
    Friend WithEvents chkNichtAmazon As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tbProduktverwaltung_newsletter As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSektion1_shopartikelbySKU As TextBox
    Friend WithEvents txtSektion1_beschreibung As TextBox
    Friend WithEvents txtSektion1_header_bild As TextBox
    Friend WithEvents txtSektion2_artikelliste As TextBox
    Friend WithEvents txtSektion2_beschreibung As TextBox
    Friend WithEvents txtSektion2_bild As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSektion3_artikelliste As TextBox
    Friend WithEvents txtSektion3_beschreibung As TextBox
    Friend WithEvents txtSektion3_bild As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtSektion4_artikelliste As TextBox
    Friend WithEvents txtSektion4_beschreibung As TextBox
    Friend WithEvents txtSektion4_bild As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtBildLink2 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtBildLink As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtBildLink3 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtBildlink4 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtBildlink5 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtSektion5_artikelliste As TextBox
    Friend WithEvents txtSektion5_beschreibung As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtSektion5_bild As TextBox
    Friend WithEvents btnVorlagespeichern As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents cmbKundenKategorie As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkEmailServerLimitierungen As CheckBox
    Friend WithEvents txtEmailServerLimitierungen_anzahl_pro_stunde As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkTestlauf As CheckBox
    Friend WithEvents tmr_core_mailserver_wait As Timer
    Friend WithEvents txtCore_Mail_bei As TextBox
    Friend WithEvents lblCore_Mail_bei As Label
    Friend WithEvents txtCore_mail_bis As TextBox
    Friend WithEvents lblCore_mail_bis As Label
    Friend WithEvents tmr_waittime_visual As Timer
    Friend WithEvents txtCore_wartezeit As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents colKundeSeit As ColumnHeader
    Friend WithEvents colBestellsumme As ColumnHeader
    Friend WithEvents tss_main_text As ToolStripStatusLabel
    Friend WithEvents colKundeSeit_Tage As ColumnHeader
    Friend WithEvents colBestellsumme_UmsatzProTag As ColumnHeader
    Friend WithEvents Label35 As Label
    Friend WithEvents cmbSprache As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents cmbKundengruppe As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents optNewsletterYES As RadioButton
End Class
