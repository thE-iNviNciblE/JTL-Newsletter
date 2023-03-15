Imports System.Threading.Tasks
Imports CefSharp.WinForms

Public Class frmMain
    Public clsDB As New clsDatenbank

    Private bIsLoading As Boolean = True
    Public bLoadError As Boolean = False
    Public clsMail As New clsMail
    Public bAbort_senden As Boolean = False
    Public bNoMessage As Boolean = False
    Private col As Integer

    '#################################################
    '# >> getCmbPositionByName
    '# Combobox Verändern auf aktuellen Wert 
    '#################################################
    'Public Function getCmbPositionByName(ByVal cmb As ComboBox, ByVal strProfilName As String) As Integer
    '    Dim iRes As Integer = -1
    '    Try
    '        For i As Integer = 0 To cmb.Items.Count - 1
    '            If cmb.Items(i) = clsDB.getMandantbyDBName(strProfilName) Then
    '                iRes = i
    '                Exit For
    '            End If
    '        Next
    '        Return iRes
    '    Catch ex As Exception
    '        MessageBox.Show("Fehler bei: " & ex.Message, "Fehler bei getCmbPositionByName()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Function
    '#################################################################
    '# >> Sortieren 
    '#################################################################
    Public Function setSort(ByRef lvwData As ListView, ByVal e As _
      System.Windows.Forms.ColumnClickEventArgs) As Boolean
        Try

            If col = e.Column Then
                If lvwData.Sorting = SortOrder.Descending Then
                    lvwData.Sorting = SortOrder.Ascending
                Else
                    lvwData.Sorting = SortOrder.Descending
                End If
            Else
                lvwData.Sorting = SortOrder.Ascending
            End If

            col = e.Column

            Select Case lvwData.Name
                Case "lvwJTLKunden"
                    Select Case e.Column
                        Case 12
                            lvwData.ListViewItemSorter = New lvsorter(Of Date)(e.Column)
                        Case 13
                            lvwData.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                        Case 14
                            lvwData.ListViewItemSorter = New lvsorter(Of Integer)(e.Column)
                        Case 15
                            lvwData.ListViewItemSorter = New lvsorter(Of Double)(e.Column)
                        Case Else
                            lvwData.ListViewItemSorter = New lvsorter(Of String)(e.Column)
                    End Select
            End Select

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Async Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '# Dateiname für Update 
            Dim strFilename As String = Application.StartupPath & "\SQL\Update.sql"
            bIsLoading = True

            Call setMainWindowTitle("JTL Newsletter", Me)

            gbl_KeyCode = getWMI_KeyCode()
            Dim strServerInfo() As String = getHTTPResponseMessage("https://api.bludau-media.de/SafeSandy/IsRegistered.php?key=" & gbl_KeyCode & "&versionsnummer=" & strVersionsNummer, mgetUpdaterMessage.getIstBuyed, True)
            If Not strServerInfo(0) = "GEKAUFT" Then
                Dim frmRegisterJTLBridge As New frmDemoVersion
                frmRegisterJTLBridge.ShowDialog()
            End If

            '# Keine Datenbankverbindungsmöglichkeiten vorhanden erster Start 
            If My.Settings.mandant_position = -1 Then
                Dim frmDBSetting As New frmDatenbankEinstellungen
                frmDBSetting.ShowDialog()
            End If

            ''# Prüfung ob my.settings.mandant_position außerhalb des Index
            Try
                If My.Settings.db_server(My.Settings.mandant_position) = "" Then

                End If
            Catch ex As Exception
                '# Außerhalb des Index default Datenbank laden, falls vorhanden 
                MainMenuStrip.Text = "Fehler: aktuelle Position innerhalb der Einstellungen '" & My.Settings.mandant_position & "' - lade Standard Werte"
                Dim frmDBSetting As New frmDatenbankEinstellungen
                frmDBSetting.ShowDialog()
                'My.Settings.mandant_position = getMySettingsPositionByDatabase("eazybusiness")
            End Try

            '##################################################
            '# >> Standarddatenbank easzybusiness Connection 
            '##################################################
            If clsDB.strConnectionString_eazybusiness = "" Then
                Dim iDefaultDB As Integer = getMySettingsPositionByDatabase("eazybusiness")

                '# Es konnte keine Standarddatenbank gefunden werden 
                If iDefaultDB = -1 Then
                    iDefaultDB = 0
                End If

                Dim strCon2 As String = "server=" & My.Settings.db_server.Item(iDefaultDB) & ";uid=" & My.Settings.db_username.Item(iDefaultDB) & ";pwd=" & My.Settings.db_passwort.Item(iDefaultDB) & ";database=" & My.Settings.db_datenbankname.Item(iDefaultDB) & ";"
                If Await clsDB.getDBConnect(strCon2, True) = False Then
                    Dim frmDBSetting As New frmDatenbankEinstellungen
                    frmDBSetting.ShowDialog()
                End If
            End If

            '######################################################
            '# >> Mandantendatenbank auswählen 
            '######################################################
            If My.Settings.db_server(My.Settings.mandant_position) = "" Or My.Settings.db_datenbankname(My.Settings.mandant_position) = "" Or My.Settings.db_passwort(My.Settings.mandant_position) = "" Or My.Settings.db_username(My.Settings.mandant_position) = "" Then
                Dim frmDBSetting As New frmDatenbankEinstellungen
                frmDBSetting.ShowDialog()
            End If
            Dim strCon As String = "server=" & My.Settings.db_server.Item(My.Settings.mandant_position) & ";uid=" & My.Settings.db_username.Item(My.Settings.mandant_position) & ";pwd=" & My.Settings.db_passwort.Item(My.Settings.mandant_position) & ";database=" & My.Settings.db_datenbankname.Item(My.Settings.mandant_position) & ";"
            If Await clsDB.getDBConnect(strCon) = False Then
                Dim frmDBSetting As New frmDatenbankEinstellungen
                frmDBSetting.ShowDialog()
            End If

            '# Datenbank Verbindung initialisieren
            'Call setDBSettings(True)

            '#################################################################
            '# >> Standardmandanten laden - eazybusiness Standarddatenbank
            '#################################################################
            Await clsDB.setMandantbyCombobox(cmbMandant, False)

            '# Updates installieren, wenn Update.sql vorhanden ist!
            If IO.File.Exists(strFilename) = True Then
                Await clsDB.setInstallUpdateAllMandant(strFilename, cmbMandant)
            End If

            '# Verschlüsseln / Entschlüsseln der Einstellungen 
            'Dim crypto As New clsCryptoAPI
            'If My.Settings.first_start = True Then
            '    crypto.setInitKeyIV()
            'End If
            'MessageBox.Show(crypto.setSettingsCrypto_encrypt(My.Settings.db_passwort))
            'MessageBox.Show(crypto.setSettingsCrypto_decrypt(crypto.setSettingsCrypto_encrypt(My.Settings.db_passwort)))

            txtShopURL = My.Settings.shop_abmelden_url(My.Settings.mandant_position)

            '# Synchronisieren der JTL Daten mit der cubss_newsletter Datei 
            Dim frmStatus As New frmJTLSync
            frmStatus.ShowDialog(Me)

            '# Init GUI from Settings

            chkEmailServerLimitierungen.Checked = My.Settings.core_mailserver_limitierungen
            txtEmailServerLimitierungen_anzahl_pro_stunde.Text = My.Settings.core_mailserver_anzahl_emails_pro_stunde
            txtCore_mail_bis.Text = My.Settings.core_mailserver_anzahl_emails_pro_stunde
            txtCore_wartezeit.Text = My.Settings.core_mailserver_wartezeit

            chkTestlauf.Text = "Testlauf an: " & My.Settings.testlauf_email(My.Settings.mandant_position)

            txtSektion1_shopartikelbySKU.Text = My.Settings.jtlshop_produkte_1(My.Settings.mandant_position)
            Try
                txtSektion2_artikelliste.Text = My.Settings.jtlshop_produkte_2(My.Settings.mandant_position)
            Catch ex As Exception
                My.Settings.jtlshop_produkte_2.Add("")
            End Try

            Try
                txtSektion3_artikelliste.Text = My.Settings.jtlshop_produkte_3(My.Settings.mandant_position)

            Catch ex As Exception
                My.Settings.jtlshop_produkte_3.Add("")
            End Try

            Try
                txtSektion4_artikelliste.Text = My.Settings.jtlshop_produkte_4(My.Settings.mandant_position)

            Catch ex As Exception
                My.Settings.jtlshop_produkte_4.Add("")
            End Try

            Try
                txtSektion5_artikelliste.Text = My.Settings.jtlshop_produkte_5(My.Settings.mandant_position)

            Catch ex As Exception
                My.Settings.jtlshop_produkte_5.Add("")
            End Try

            Try
                txtSektion1_header_bild.Text = My.Settings.jtlshop_bild_1(My.Settings.mandant_position)

            Catch ex As Exception
                My.Settings.jtlshop_bild_1.Add("")
            End Try

            Try
                txtSektion2_bild.Text = My.Settings.jtlshop_bild_2(My.Settings.mandant_position)

            Catch ex As Exception
                My.Settings.jtlshop_bild_2.Add("")
            End Try

            Try
                txtSektion3_bild.Text = My.Settings.jtlshop_bild_3(My.Settings.mandant_position)

            Catch ex As Exception
                My.Settings.jtlshop_bild_3.Add("")
            End Try

            Try
                txtSektion4_bild.Text = My.Settings.jtlshop_bild_4(My.Settings.mandant_position)

            Catch ex As Exception
                My.Settings.jtlshop_bild_4.Add("")
            End Try

            Try
                txtSektion5_bild.Text = My.Settings.jtlshop_bild_5(My.Settings.mandant_position)

            Catch ex As Exception
                My.Settings.jtlshop_bild_5.Add("")
            End Try

            Try
                txtSektion1_beschreibung.Text = My.Settings.jtlshop_beschreibung_1(My.Settings.mandant_position)
            Catch ex As Exception
                My.Settings.jtlshop_beschreibung_1.Add("")
            End Try

            Try
                txtSektion2_beschreibung.Text = My.Settings.jtlshop_beschreibung_2(My.Settings.mandant_position)
            Catch ex As Exception
                My.Settings.jtlshop_beschreibung_2.Add("")
            End Try

            Try
                txtSektion3_beschreibung.Text = My.Settings.jtlshop_beschreibung_3(My.Settings.mandant_position)
            Catch ex As Exception
                My.Settings.jtlshop_beschreibung_3.Add("")
            End Try

            Try
                txtSektion4_beschreibung.Text = My.Settings.jtlshop_beschreibung_4(My.Settings.mandant_position)
            Catch ex As Exception
                My.Settings.jtlshop_beschreibung_4.Add("")
            End Try

            Try
                txtSektion5_beschreibung.Text = My.Settings.jtlshop_beschreibung_5(My.Settings.mandant_position)
            Catch ex As Exception
                My.Settings.jtlshop_beschreibung_5.Add("")
            End Try

            Try
                txtBildLink.Text = My.Settings.jtlshop_bildlink1(My.Settings.mandant_position)
            Catch ex As Exception
                My.Settings.jtlshop_bildlink1.Add("")
            End Try

            Try
                txtBildLink2.Text = My.Settings.jtlshop_bildlink2(My.Settings.mandant_position)
            Catch ex As Exception
                My.Settings.jtlshop_bildlink2.Add("")
            End Try

            Try
                txtBildLink3.Text = My.Settings.jtlshop_bildlink3(My.Settings.mandant_position)
            Catch ex As Exception
                My.Settings.jtlshop_bildlink3.Add("")
            End Try

            Try
                txtBildlink4.Text = My.Settings.jtlshop_bildlink4(My.Settings.mandant_position)
            Catch ex As Exception
                My.Settings.jtlshop_bildlink4.Add("")
            End Try

            Try
                txtBildlink5.Text = My.Settings.jtlshop_bildlink5(My.Settings.mandant_position)
            Catch ex As Exception
                My.Settings.jtlshop_bildlink5.Add("")
            End Try


            Await clsDB.getKundenKategorie(cmbKundenKategorie)
            cmbKundenKategorie.SelectedIndex = 0

            Await clsDB.getKundenSprache(cmbSprache)
            cmbSprache.SelectedIndex = 0

            Await clsDB.getKundenGruppe(cmbKundengruppe)
            cmbKundengruppe.SelectedIndex = 0

            Await clsDB.getKundenOptionCount()

            '# Laden bei Mandantenwechsel 
            Call getLoadSettingsMandantWechsel(False)

            bIsLoading = False

        Catch ex As Exception
            MessageBox.Show("Fehler bei frmMain_Load: " & ex.Message, "frmMain_load", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bIsLoading = False
        End Try

        '# Programm beenden, weil Demoversion
        If bExitProgramm = True Then
            Me.Close()
        End If

        Dim strServerInfo1() As String = getHTTPResponseMessage("https://api.bludau-media.de/SafeSandy/Update.php?key=" & gbl_KeyCode & "&programID=3&versionsnummer=" & strVersionsNummer & "&KeinUpdate=1", mgetUpdaterMessage.getProgramUpdateCheck, True)

        If Not strServerInfo1(0) = "VERSION_AKTUELL" Then
            Dim frmUpdater As New frmUpdater
            frmUpdater.ShowDialog()
        End If

    End Sub


    '##################################################################################
    '# >> getLoadSettingsMandantWechsel
    '# - Einstellungen neu laden für den aktuellen Mandanten
    '##################################################################################
    Private Sub getLoadSettingsMandantWechsel(bLoadDBSettings As Boolean)
        Try
            Try
                txtTestlaufAnzahl.Text = My.Settings.testlauf_anzahl(My.Settings.mandant_position)
            Catch ex As Exception
                If ex.Message.ToString.IndexOf("ndex was out of range") > 0 Then
                    Dim frmDatenbankEinstellungen As New frmDatenbankEinstellungen
                    frmDatenbankEinstellungen.Show()
                End If
            End Try

            '# Out of Range...
            txtVorlagePfad.Text = My.Settings.template_pfad(My.Settings.mandant_position)
            txteMailBetreff.Text = My.Settings.template_betreff(My.Settings.mandant_position)
            txtTestlaufEmail.Text = My.Settings.testlauf_email(My.Settings.mandant_position)

            If My.Settings.testlauf_aktiv(My.Settings.mandant_position) = "" Then
                chkTestlauf.Checked = True
            Else
                chkTestlauf.Checked = Convert.ToBoolean(My.Settings.testlauf_aktiv(My.Settings.mandant_position))
            End If


            '# Prüfen ob Datenbank verfügbar ist 
            If bLoadDBSettings = True Then
                Call setDBSettings(False)
            End If

        Catch ex As Exception
            MessageBox.Show("Fehler bei Mandantenwechsel: " & ex.Message, "getLoadSettingsMandantWechsel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '##################################################################################
    '# >> geteazybusinessSettings()
    '# Findet die Position an der Sich die Hauptdatenbank befindet 
    '##################################################################################
    Public Function getMySettingsPositionByDatabase(strDatabaseName As String) As Integer
        Try
            Dim i As Byte
            Dim iGefunden As Integer = -1
            Dim bGefunden As Boolean = False

            '# Keine Einstellung gefunden 
            If My.Settings.db_datenbankname.Count = 0 Then
                Return -1
                Exit Function
            End If

            For i = 0 To My.Settings.db_datenbankname.Count - 1
                If My.Settings.db_datenbankname(i) = strDatabaseName Then
                    bGefunden = True
                    iGefunden = i
                    Exit For
                End If
            Next
            '# Nicht gefunden Position 0 
            If bGefunden = False Then
                iGefunden = -1
            End If

            My.Settings.Save()
            Return iGefunden
        Catch ex As Exception
            MessageBox.Show("Fehler: " & ex.Message, "geteMySettingsbyDatabase()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function
    '#################################################
    '# >> setSettingsInit
    '# My.Settings.xxx String Collection initalisieren
    '#################################################
    Public Function setSettingsInit(ByVal iSize As Integer) As Integer
        Try
            Dim txtShopURL_test As String = ""
            Dim iCount_insert As Integer = 0

            If My.Settings.db_server.Count - 1 < iSize Then
                For iCount As Integer = My.Settings.db_server.Count To iSize
                    Try
                        txtShopURL_test = My.Settings.shop_abmelden_url(iCount).ToString
                    Catch ex As Exception
                        My.Settings.db_server.Insert(iCount, "")
                        My.Settings.db_datenbankname.Insert(iCount, "")
                        My.Settings.db_username.Insert(iCount, "")
                        My.Settings.db_passwort.Insert(iCount, "")
                        My.Settings.template_pfad.Insert(iCount, Application.StartupPath & "\Newsletter Vorlagen\Beispiel Vorlage.html")
                        My.Settings.template_betreff.Insert(iCount, "")
                        My.Settings.testlauf_anzahl.Insert(iCount, "2")
                        My.Settings.testlauf_aktiv.Insert(iCount, "true")
                        My.Settings.testlauf_email.Insert(iCount, "")
                        My.Settings.email_absende_name.Insert(iCount, "")
                        My.Settings.email_pop_port.Insert(iCount, "")
                        My.Settings.email_pop3.Insert(iCount, "")
                        My.Settings.email_pop3_before_smtp.Insert(iCount, "false")
                        My.Settings.email_pwd.Insert(iCount, "")
                        My.Settings.email_smtp.Insert(iCount, "")
                        My.Settings.email_smtp_port.Insert(iCount, "")
                        My.Settings.email_username.Insert(iCount, "")
                        My.Settings.shop_abmelden_url.Insert(iCount, "")
                        My.Settings.jtlshop_connector.Insert(iCount, "")
                        My.Settings.emailssl.Insert(iCount, "")
                        My.Settings.email_username_user.Insert(iCount, "")

                        iCount_insert += 1
                    End Try
                Next

            End If
            Return iCount_insert
        Catch ex As Exception
            MessageBox.Show("Fehler bei setInitSettings: " & ex.Message, "setInitSettings()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function
    '#################################################
    '# >> setSettingsDelete
    '# My.Settings.xxx String Collection alle löschen
    '#################################################
    Public Function setSettingsDelete() As Boolean
        Dim i As Integer
        For i = 0 To My.Settings.db_server.Count - 1
            Try
                My.Settings.db_server.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.db_datenbankname.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.db_username.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.db_passwort.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.template_pfad.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.template_betreff.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_absende_name.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_pop_port.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_pop3_before_smtp.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_pwd.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_smtp.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_smtp_port.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.email_username.RemoveAt(0)
            Catch ex As Exception

            End Try
            msgMaster.Text = "Es existieren noch " & My.Settings.db_server.Count & " Einstellungen"
        Next
        Return True
    End Function

    '##################################################################################
    '# >> chkDBSettings
    '# - Prüfen ob Datenbank verfügbar ist 
    '##################################################################################
    Private Async Sub setDBSettings(ByVal bLoadMandantenCombo As Boolean)
        '# Mandanten Datenbank 
        ' If Not cmbMandant.Text = "" Then

        '##################################################
        '# easzybusiness Connection 
        '##################################################
        If clsDB.strConnectionString_eazybusiness = "" Then
            My.Settings.mandant_position = getMySettingsPositionByDatabase("eazybusiness")
            Dim strCon As String = "server=" & My.Settings.db_server.Item(My.Settings.mandant_position) & ";uid=" & My.Settings.db_username.Item(My.Settings.mandant_position) & ";pwd=" & My.Settings.db_passwort.Item(My.Settings.mandant_position) & ";database=" & My.Settings.db_datenbankname.Item(My.Settings.mandant_position) & ";"
            If Await clsDB.getDBConnect(strCon, True) = False Then
                Dim frmDBSetting As New frmDatenbankEinstellungen
                frmDBSetting.ShowDialog()
            End If
        End If

        '# Mandanten abrufen und in die combobox kopieren
        If bLoadMandantenCombo = True Then
            Call clsDB.setMandantbyCombobox(cmbMandant, False)
        End If

        '###################################################
        '# >> Normale Datenbankverbindung 
        '###################################################
        If Not cmbMandant.Text = "" Then
            My.Settings.db_datenbankname.Item(My.Settings.mandant_position) = Await clsDB.getMandantDatabaseByMandantName(cmbMandant.Text)
            My.Settings.Save()

            If My.Settings.db_datenbankname.Item(My.Settings.mandant_position) = "" Then
                My.Settings.db_datenbankname.Item(My.Settings.mandant_position) = "eazybusiness"
                Call setSettingsInit(My.Settings.mandant_position)
                My.Settings.mandant_position = Await clsDB.chkMandantPosition(My.Settings.db_datenbankname.Item(My.Settings.mandant_position))
            End If

            'End If        
            Dim strConDB As String = "server=" & My.Settings.db_server.Item(My.Settings.mandant_position) & ";uid=" & My.Settings.db_username.Item(My.Settings.mandant_position) & ";pwd=" & My.Settings.db_passwort.Item(My.Settings.mandant_position) & ";database=" & My.Settings.db_datenbankname.Item(My.Settings.mandant_position) & ";"
            If Await clsDB.getDBConnect(strConDB) = False Then
                Dim frmDBSetting As New frmDatenbankEinstellungen
                frmDBSetting.ShowDialog()
            End If
        Else
            MessageBox.Show("Es wurde kein Mandant gefunden!", "Combobox Mandant nicht geladen werden", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
    Private Async Sub btnEinlesen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEinlesen.Click
        '    btnEinlesen.Enabled = False
        If btnEinlesen.Text = "Stoppen" Then
            bAbbruch = True
            Exit Sub
        End If

        btnEinlesen.Text = "Stoppen"
        btnSend.Enabled = False
        optNewsletterAbschicken.Enabled = False
        optNewsletterVerschickt.Enabled = False
        optAngemeldet.Enabled = False
        optAbgemeldet.Enabled = False
        chkNichtAmazon.Enabled = False
        cmbMandant.Enabled = False
        cmbKundenKategorie.Enabled = False
        cmbSprache.Enabled = False
        cmbKundengruppe.Enabled = False
        optNewsletterYES.Enabled = False

        If clsDB.strConnectionString = "" Then
            '# Datenbank Verbindung initialisieren
            clsDB.strConnectionString = clsDB.strConnectionString_eazybusiness
        End If

        Dim strWhere As String = Await clsDB.getJTLKundenData_Where(optNewsletterAbschicken, optNewsletterVerschickt, optAngemeldet, optAbgemeldet, chkNichtAmazon)
        lvwJTLKunden.BeginUpdate()

        Await clsDB.getJTLKundenData(lvwJTLKunden, strWhere, Me)

        lvwJTLKunden.EndUpdate()
        If lvwJTLKunden.Items.Count > 0 Then
            btnSend.Enabled = True
        Else
            btnSend.Enabled = False
        End If

        ' btnEinlesen.Enabled = True
        btnSend.Enabled = True
        cmbKundenKategorie.Enabled = True
        optNewsletterAbschicken.Enabled = True
        optNewsletterVerschickt.Enabled = True
        optAngemeldet.Enabled = True
        optAbgemeldet.Enabled = True
        chkNichtAmazon.Enabled = True
        cmbMandant.Enabled = True
        masterpgr.Visible = False
        cmbSprache.Enabled = True
        cmbKundengruppe.Enabled = True
        optNewsletterYES.Enabled = True

        btnEinlesen.Text = "JTL WaWi Kunden &einlesen"

        msgMaster.Text = "Kunden für Mandant " & cmbMandant.Text & " eingelesen: " & lvwJTLKunden.Items.Count
    End Sub

    Private Async Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        btnEinlesen.Enabled = False
        'btnSend.Enabled = False
        optNewsletterAbschicken.Enabled = False
        optNewsletterVerschickt.Enabled = False
        optAngemeldet.Enabled = False
        optAbgemeldet.Enabled = False
        chkNichtAmazon.Enabled = False
        cmbMandant.Enabled = False
        cmbKundenKategorie.Enabled = False

        If btnSend.Text = "&Newsletter Versand starten" Or btnSend.Text = "&Testlauf Newsletter mit Echtdaten" Then
            btnSend.Text = "Newsletter Stoppen"
        Else
            bAbort_senden = True
            btnSend.Text = "&Newsletter Versand starten"
        End If

        '# Keine Kunden 
        If lvwJTLKunden.Items.Count = 0 Then
            MessageBox.Show("Bitte lesen Sie die JTL Kunden Daten zuerst ein!", "JTL Kunden einlesen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        '# Kein Betreff 
        If txteMailBetreff.Text.Length = 0 Then
            TabControl1.SelectedIndex = 1
            MessageBox.Show("Bitte tragen Sie einen Newsletter Betreff ein!", "Email Betreff fehlt", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txteMailBetreff.Focus()
            Exit Sub
        End If

        '# Fehlerprüfung Mailserver
        If My.Settings.email_smtp(My.Settings.mandant_position).Length = 0 Or My.Settings.email_smtp_port(My.Settings.mandant_position).Length = 0 Or My.Settings.email_username(My.Settings.mandant_position).Length = 0 Or My.Settings.email_pwd(My.Settings.mandant_position).Length = 0 Or My.Settings.email_absende_name(My.Settings.mandant_position).Length = 0 Then
            MessageBox.Show("Sie haben den Mailserver noch nicht komplett konfiguriert!", "Mailserver Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frmMailServerSetup As New frmMailServer
            frmMailServerSetup.ShowDialog()
            Exit Sub
        End If
        If My.Settings.email_pop3_before_smtp(My.Settings.mandant_position).Length = True Then
            If My.Settings.email_pop_port(My.Settings.mandant_position).Length = 0 Or My.Settings.email_pop3(My.Settings.mandant_position).Length = 0 Then
                Dim frmMailServerSetup As New frmMailServer
                frmMailServerSetup.ShowDialog()
                Exit Sub
            End If
        End If

        If My.Settings.shop_abmelden_url(My.Settings.mandant_position).Length = 0 Then
            MessageBox.Show("Sie müssen eine Newsletterabmelde URL vergeben, vorhher kann kein Newsletter abgeschickt werden", "Newsletter Abmeldung", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frmShopURL As New frmJTLEinstellungen
            frmShopURL.ShowDialog(Me)
            Exit Sub
        End If

        '##############################
        '# Testlaufeinstellungen
        '##############################
        If chkTestlauf.Checked = True Then
            If txtTestlaufEmail.Text.Length = 0 Or Not txtTestlaufEmail.Text.IndexOf("@") > 0 Then
                MessageBox.Show("Es wurde keine gültige eMail für den Testlauf eingetragen!", "Testlaufeinstellungen - eMail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TabControl1.SelectedIndex = 2
                Exit Sub
            End If
            If txtTestlaufAnzahl.Text.Length = 0 Or IsNumeric(txtTestlaufAnzahl.Text) = False Then
                MessageBox.Show("Es wurde keine gültige Anzahl von Testlauf eMails für den Testlauf eingetragen!", "Testlaufeinstellungen - Anzahl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TabControl1.SelectedIndex = 2
                Exit Sub
            End If
        End If

        If My.Settings.template_pfad(My.Settings.mandant_position).Length > 0 Then
            If IO.File.Exists(My.Settings.template_pfad(My.Settings.mandant_position)) = True Then

                Await setSendNewsletter(lvwJTLKunden)

                If CBool(My.Settings.testlauf_aktiv(My.Settings.mandant_position)) = False Then

                    If bNoMessage = False Then
                        MessageBox.Show("Es wurden alle Newsletter an die Kunden abgeschickt", "JTL Wawi Newsletter abgeschickt!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If


                    If clsMail.strErrorKunden.Length > 0 Then
                        Dim frmLogbuch As New frmMailLogbuch
                        frmLogbuch.strErrorLog = clsMail.strErrorKunden
                        frmLogbuch.Show()
                    End If
                Else
                    If bNoMessage = False Then
                        MessageBox.Show("Test-Newsletter wurde an '" & txtTestlaufEmail.Text & "' abgeschickt", "JTL Wawi Newsletter abgeschickt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End If
            Else
                TabControl1.SelectedIndex = 1
                'If bNoMessage = False Then
                MessageBox.Show("Ihre Newsletter Vorlage kann nicht mehr geöffnet werden, weil Sie nicht mehr existiert!", "JTL Wawi Newsletter - keine Vorlage", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If

            End If

        Else
            TabControl1.SelectedIndex = 1
            MessageBox.Show("Bitte ein Newsletter Template auswählen!", "JTL Newsletter - keine Vorlage", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        bAbort_senden = False

        If CBool(My.Settings.testlauf_aktiv(My.Settings.mandant_position)) = True Then
            btnSend.Text = "&Testlauf Newsletter mit Echtdaten"
        Else
            btnSend.Text = "&Newsletter Versand starten"
        End If


        btnEinlesen.Enabled = True
        btnSend.Enabled = True
        optNewsletterAbschicken.Enabled = True
        optNewsletterVerschickt.Enabled = True
        optAngemeldet.Enabled = True
        optAbgemeldet.Enabled = True
        chkNichtAmazon.Enabled = True
        cmbMandant.Enabled = True
        cmbKundenKategorie.Enabled = True


    End Sub

    Private Async Function setSendNewsletter(ByVal lvwJTLKunden As ListView) As Task(Of Boolean)
        Try
            Dim iCount As Integer = 0
            Dim strNewsletterVorlage As String = ""
            Dim strNewsletterVorlage_orginal As String = ""

            clsMail.bError = False
            Dim strSendContent As String = ""
            Dim strSendContent_orginal As String = ""
            Dim strEmail As String = ""
            Dim strBetreff As String = ""
            Dim strBetreff_tmp As String = txteMailBetreff.Text

            msgMaster.Text = "Lade Vorlage '" & My.Settings.template_pfad(My.Settings.mandant_position) & "'"
            strNewsletterVorlage_orginal = My.Computer.FileSystem.ReadAllText(My.Settings.template_pfad(My.Settings.mandant_position))
            masterpgr.Visible = True
            masterpgr.Value = 0
            masterpgr.Maximum = lvwJTLKunden.Items.Count

            strSendContent_orginal = Await clsMail.getTemplate(strNewsletterVorlage_orginal, lvwJTLKunden.Items(0), txtSektion1_shopartikelbySKU.Text, txtSektion1_header_bild.Text, txtSektion1_beschreibung.Text, txtSektion2_artikelliste.Text, txtSektion2_bild.Text, txtSektion2_beschreibung.Text, txtSektion3_artikelliste.Text, txtSektion3_bild.Text, txtSektion3_beschreibung.Text, txtSektion4_artikelliste.Text, txtSektion5_artikelliste.Text, txtSektion4_bild.Text, txtSektion5_bild.Text, txtSektion4_beschreibung.Text, txtSektion5_beschreibung.Text, txtBildLink.Text, txtBildLink2.Text, txtBildLink3.Text, txtBildlink4.Text, txtBildlink5.Text)


            For iCount = 0 To lvwJTLKunden.Items.Count - 1

                '# Abbrechen einbauen
                If bAbort_senden = True Then
                    Exit For
                End If


                '# Template Marker 
                strSendContent = strSendContent_orginal.Replace("###VORNAME###", lvwJTLKunden.Items(0).SubItems(1).Text)
                strSendContent = strSendContent.Replace("###NACHNAME###", lvwJTLKunden.Items(0).SubItems(2).Text)
                strSendContent = strSendContent.Replace("###PLZ###", lvwJTLKunden.Items(0).SubItems(10).Text)
                strSendContent = strSendContent.Replace("###ORT###", lvwJTLKunden.Items(0).SubItems(3).Text)
                strSendContent = strSendContent.Replace("###FIRMA###", lvwJTLKunden.Items(0).SubItems(5).Text)
                strSendContent = strSendContent.Replace("###EMAIL###", lvwJTLKunden.Items(0).SubItems(4).Text)
                strSendContent = strSendContent.Replace("###KDNR###", lvwJTLKunden.Items(0).SubItems(6).Text)
                strSendContent = strSendContent.Replace("###STRASSE###", lvwJTLKunden.Items(0).SubItems(7).Text)
                strSendContent = strSendContent.Replace("###LAND###", lvwJTLKunden.Items(0).SubItems(8).Text)
                strSendContent = strSendContent.Replace("###ANREDE###", lvwJTLKunden.Items(0).SubItems(9).Text)

                'strTemplate = strTemplate.Replace("###UID###", getUIDLink(lvwItem.SubItems(11).Text, lvwItem.SubItems(8).Text))
                strSendContent = strSendContent.Replace("###ABMELDENLINK###", clsMail.getAbmeldeLink(lvwJTLKunden.Items(0).SubItems(4).Text, lvwJTLKunden.Items(0).Text))

                ' Template variablen füllen

                strBetreff = strBetreff_tmp.Replace("###VORNAME###", lvwJTLKunden.Items(0).SubItems(1).Text)
                strBetreff = strBetreff.Replace("###NACHNAME###", lvwJTLKunden.Items(0).SubItems(2).Text)
                strBetreff = strBetreff.Replace("###PLZ###", lvwJTLKunden.Items(0).SubItems(10).Text)
                strBetreff = strBetreff.Replace("###ORT###", lvwJTLKunden.Items(0).SubItems(3).Text)
                strBetreff = strBetreff.Replace("###FIRMA###", lvwJTLKunden.Items(0).SubItems(5).Text)
                strBetreff = strBetreff.Replace("###EMAIL###", lvwJTLKunden.Items(0).SubItems(4).Text)
                strBetreff = strBetreff.Replace("###KDNR###", lvwJTLKunden.Items(0).SubItems(6).Text)
                strBetreff = strBetreff.Replace("###STRASSE###", lvwJTLKunden.Items(0).SubItems(7).Text)
                strBetreff = strBetreff.Replace("###LAND###", lvwJTLKunden.Items(0).SubItems(8).Text)
                strBetreff = strBetreff.Replace("###ANREDE###", lvwJTLKunden.Items(0).SubItems(9).Text)

                'strBetreff = Await clsMail.getTemplate(strBetreff_tmp, lvwJTLKunden.Items(0), txtSektion1_shopartikelbySKU.Text, txtSektion1_header_bild.Text, txtSektion1_beschreibung.Text, txtSektion2_artikelliste.Text, txtSektion2_bild.Text, txtSektion2_beschreibung.Text, txtSektion3_artikelliste.Text, txtSektion3_bild.Text, txtSektion3_beschreibung.Text, txtSektion4_artikelliste.Text, txtSektion5_artikelliste.Text, txtSektion4_bild.Text, txtSektion5_header_bild.Text, txtSektion4_beschreibung.Text, txtSektion5_beschreibung.Text, txtBildLink.Text, txtBildLink2.Text, txtBildLink3.Text, txtBildlink4.Text, txtBildlink5.Text)
                '# Prüfung ob Kunde in TMP Existiert 
                'If clsDB.chkJTLKundeExists(lvwJTLKunden.Items(0).Text) = False Then
                'clsDB.setJTLKundeTMP_new(lvwJTLKunden.Items(0))

                '# Newsletter Abschicken
                If CBool(My.Settings.testlauf_aktiv(My.Settings.mandant_position)) = False Then
                    strEmail = lvwJTLKunden.Items(0).SubItems(4).Text
                Else

                    If iCount = Convert.ToInt16(txtTestlaufAnzahl.Text) Then
                        masterpgr.Visible = False
                        If bNoMessage = False Then
                            MessageBox.Show("Testlaufende erreicht!" & vbCrLf & strEmail, "JTL Newsletter - Testlaufende", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        Exit Function
                    End If

                    strEmail = My.Settings.testlauf_email(My.Settings.mandant_position)
                End If

                msgMaster.Text = "Versende Email an '" & lvwJTLKunden.Items(0).SubItems(1).Text & " " & lvwJTLKunden.Items(0).SubItems(2).Text & "' (" & strEmail & ")"
                msgMaster.Text = "eMail abschicken an '" & strEmail & "'"

                If clsMail.setSendMail(strEmail, strSendContent, strBetreff, False) = True Then

                    '# Email als verschickt makieren
                    If CBool(My.Settings.testlauf_aktiv(My.Settings.mandant_position)) = False Then
                        msgMaster.Text = "Kunde '" & lvwJTLKunden.Items(0).SubItems(2).Text & "' auf verschickt stellen..."
                        Dim t As Task = Task.Run(Sub() clsDB.setJTLKundeUpdateSended(lvwJTLKunden.Items(0)))
                        t.Wait()

                        '# Email Limitierungen
                        If My.Settings.core_mailserver_limitierungen = True Then

                            txtCore_Mail_bei.Text = CType((CType(txtCore_Mail_bei.Text, Integer) + 1), String)

                            '# Bis z.B. 500 Emails dann Wartepause
                            If txtCore_Mail_bei.Text = txtCore_Mail_bei.Text Then
                                bNoMessage = True
                                tmr_core_mailserver_wait.Interval = 3600000
                                masterpgr.Value = 0
                                masterpgr.Maximum = 3600000
                                tmr_waittime_visual.Enabled = True

                                tmr_core_mailserver_wait.Enabled = False
                                tmr_core_mailserver_wait.Enabled = True
                                Exit Function
                            End If


                        End If
                    Else
                        '# Email Limitierungen
                        If My.Settings.core_mailserver_limitierungen = True Then

                            txtCore_Mail_bei.Text = CType((CType(txtCore_Mail_bei.Text, Integer) + 1), String)

                            '# Bis z.B. 500 Emails dann Wartepause
                            If txtCore_Mail_bei.Text = txtCore_Mail_bei.Text Then
                                bNoMessage = True
                                tmr_core_mailserver_wait.Interval = CInt(My.Settings.core_mailserver_wartezeit)
                                masterpgr.Value = 0
                                masterpgr.Maximum = CInt(My.Settings.core_mailserver_wartezeit)
                                tmr_waittime_visual.Enabled = True

                                tmr_core_mailserver_wait.Enabled = False
                                tmr_core_mailserver_wait.Enabled = True
                                Exit Function
                            End If


                        End If
                    End If
                End If

                '# Email Versandfehler aufgetretten
                If clsMail.bError = True Then
                    MessageBox.Show("Fehler beim SMTP-Server Versand, bitte überprüfen Sie ihre Mailserver Einstellungen!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    masterpgr.Visible = False
                    Exit Function
                End If

                lvwJTLKunden.Items(0).Remove()

                'lvwJTLKunden.EnsureVisible(iCount)

                masterpgr.Value = iCount

                Application.DoEvents()
            Next

            masterpgr.Visible = False
            Return True
        Catch ex As Exception
            MessageBox.Show("Fehler beim eMailversand: " & ex.Message & vbCrLf & vbCrLf & "Bitte Kundenbestand erneut einlesen und mit den vorhanden eMails fortfahren! ", "Fehler beim Abschicken...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Async Sub NewsletterNeustartenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewsletterNeustartenToolStripMenuItem.Click
        If MessageBox.Show("Möchten Sie eine neue Newsletter Aktion starten?", "Neuer Newsletter?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Await clsDB.setNewsletterNew()
            msgMaster.Text = "Newsletter Kunden zurückgestellt.."
        End If
    End Sub

    Private Sub DatenbankeinstellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatenbankeinstellungenToolStripMenuItem.Click
        Dim frmDB As New frmDatenbankEinstellungen
        frmDB.ShowDialog(Me)
    End Sub

    Private Sub MailserverEinstellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MailserverEinstellungenToolStripMenuItem.Click
        Dim frmMail As New frmMailServer
        frmMail.ShowDialog(Me)
    End Sub

    Private Sub ÖffnenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call OpenFile()
    End Sub

    Private Sub OpenFile()
        Dim strVorlageInhalt As String
        OpenFileDialog1.Title = "JTL Newsletter -> HTML Import"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            'strPathVorlage = OpenFileDialog1.FileName

            txtVorlageQuellcode.Text = ""
            txtVorlagePfad.Text = OpenFileDialog1.FileName
            My.Settings.template_pfad(My.Settings.mandant_position) = txtVorlagePfad.Text
            My.Settings.Save()
            strVorlageInhalt = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

            '# Enthält <link href=" Fehler beim Laden, nur Textansicht
            If strVorlageInhalt.IndexOf("type=""text/css""") > 0 Then

                Panel1.Visible = False
                txtVorlageQuellcode.Visible = True
                txtVorlageQuellcode.Text = strVorlageInhalt
            Else

                txtVorlageQuellcode.Text = strVorlageInhalt

            End If

            msgMaster.Text = "Lade Vorlage: " & OpenFileDialog1.FileName
        End If

    End Sub


    Private Sub SpeichernToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strHTMLExport As String = ""
        Dim wRes As Windows.Forms.DialogResult

        SaveFileDialog1.Title = "JTL Newsletter -> HTML Export"
        wRes = SaveFileDialog1.ShowDialog()
        If wRes = Windows.Forms.DialogResult.OK Then
            strHTMLExport = SaveFileDialog1.FileName
        ElseIf wRes = Windows.Forms.DialogResult.Abort Then
            MsgBox("Sie haben den Speichervorgang abgebrochen!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "JTL Newsletter -> Fehler beim Speichern")
        Else
            MsgBox("Es ist ein Fehler beim Speichern aufgetretten", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "JTL Newsletter -> Fehler beim Speichern")
            Exit Sub
        End If

        My.Computer.FileSystem.WriteAllText(strHTMLExport, txtVorlageQuellcode.Text, False)


        txtVorlagePfad.Text = strHTMLExport
        MsgBox("Datei wurde unter '" & strHTMLExport & "' gespeichert", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "JTL Newsletter - Datei gespeichert")

    End Sub

    Private Sub btnPfadÖffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPfadÖffnen.Click
        Call OpenFile()
    End Sub

    Private Sub txtVorlagePfad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVorlagePfad.TextChanged
        My.Settings.template_pfad(My.Settings.mandant_position) = txtVorlagePfad.Text
        My.Settings.Save()
    End Sub

    Private Sub txteMailBetreff_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txteMailBetreff.TextChanged
        My.Settings.template_betreff(My.Settings.mandant_position) = txteMailBetreff.Text
        My.Settings.Save()
    End Sub

    Private Sub VorschauToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VorschauToolStripMenuItem.Click
        If lvwJTLKunden.SelectedItems.Count > 0 Then
            Dim frmVorschau As New frmMailVorschau
            frmVorschau.iSelectedIndex = lvwJTLKunden.SelectedItems(0).Index
            frmVorschau.lvwKunde = lvwJTLKunden
            frmVorschau.ShowDialog(Me)
        End If
    End Sub

    Private Sub txtTestlaufEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTestlaufEmail.TextChanged
        My.Settings.testlauf_email(My.Settings.mandant_position) = txtTestlaufEmail.Text
        chkTestlauf.Text = "Testlauf an: " & txtTestlaufEmail.Text

        My.Settings.Save()
    End Sub

    Private Sub chkTestlauf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If chkTestlauf.Checked = True Then
            btnSend.Text = "&Testlauf starten"
        Else
            btnSend.Text = "&Newsletter Versand starten"
        End If

        My.Settings.testlauf_aktiv(My.Settings.mandant_position) = chkTestlauf.Checked
        My.Settings.Save()
    End Sub

    Private Sub txtTestlaufAnzahl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTestlaufAnzahl.TextChanged
        My.Settings.testlauf_anzahl(My.Settings.mandant_position) = txtTestlaufAnzahl.Text
        My.Settings.Save()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            If IO.File.Exists(txtVorlagePfad.Text) = True Then
                Timer1.Enabled = True
            End If
        End If
        If IO.File.Exists(txtVorlagePfad.Text) = True Then
            'My.Computer.FileSystem.WriteAllText(txtVorlagePfad.Text, DHTMLControll.DOM.body.innerHTML, False)
            ' My.Computer.FileSystem.WriteAllText(txtVorlagePfad.Text, txtVorlageQuellcode.Text, False)
        End If

    End Sub

    Private Sub JTLShopEinstellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JTLShopEinstellungenToolStripMenuItem.Click
        Dim frmJTLShopEinstellungen As New frmJTLEinstellungen
        frmJTLShopEinstellungen.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMandant.SelectedIndexChanged
        If bIsLoading = False Then


            Call setComboFrmMainMandantWechsel()
            msgMaster.Text = "Neuer Mandant ausgewählt " & cmbMandant.Text
            Call setMainWindowTitle("JTL Newsletter", Me)
            Dim frmJTLNewsletterSync As New frmJTLSync
            msgMaster.Text = "Synchronisieren gestartet... " & cmbMandant.Text
            frmJTLNewsletterSync.ShowDialog()
        End If
        bIsLoading = False ' fehler bei setComboFrmMainMandantWechsel möglich bei true
    End Sub
    '#############################################################
    '# >> setComboFrmMainMandantWechsel
    '# Combobox Wechsel laden 
    '#############################################################
    Public Async Function setComboFrmMainMandantWechsel() As Task(Of Boolean)
        Try
            If bIsLoading = False Then
                My.Settings.mandant_letzter_name = cmbMandant.Text
                My.Settings.mandant_position = Await clsDB.chkMandantPosition(Await clsDB.getMandantDatabaseByMandantName(My.Settings.mandant_letzter_name))

                '# Settings initalisieren 
                Call setSettingsInit(My.Settings.mandant_position)

                '# Fehlerfall Profil wird angezeigt, es wurden aber keine Benutzerdaten hinterlegt 
                If My.Settings.db_username(My.Settings.mandant_position) = "" And Not My.Settings.db_datenbankname(My.Settings.mandant_position) = "" Then
                    msgMaster.Text = "Es muss das Datenbankprofil für ' " & My.Settings.mandant_letzter_name & "' vervollständigt werden!"
                    Dim frmDatenbankEinstellungen As New frmDatenbankEinstellungen
                    frmDatenbankEinstellungen.Show()
                End If

                My.Settings.Save()
                Call getLoadSettingsMandantWechsel(True)
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show("Fehler bei setComboFrmMainMandantWechsel: " & ex.Message, "setComboFrmMainMandantWechsel()", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
    End Function
    Private Async Sub NewsletterAbmeldenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewsletterAbmeldenToolStripMenuItem.Click
        If lvwJTLKunden.SelectedItems(0).SubItems(11).Text = "Ja" Then

            Await clsDB.setNewsletterAbAnmelden(lvwJTLKunden.SelectedItems(0).SubItems(0).Text, True)
            msgMaster.Text = "Kunde '" & lvwJTLKunden.SelectedItems(0).SubItems(1).Text & " " & lvwJTLKunden.SelectedItems(0).SubItems(2).Text & "' (" & lvwJTLKunden.SelectedItems(0).SubItems(4).Text & ") wurde abgemeldet"
            lvwJTLKunden.SelectedItems(0).Remove()
        Else
            Await clsDB.setNewsletterAbAnmelden(lvwJTLKunden.SelectedItems(0).SubItems(0).Text, False)
            msgMaster.Text = "Kunde '" & lvwJTLKunden.SelectedItems(0).SubItems(1).Text & " " & lvwJTLKunden.SelectedItems(0).SubItems(2).Text & "' (" & lvwJTLKunden.SelectedItems(0).SubItems(4).Text & ") wurde angemeldet"
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Not optNewsletterAbschicken.Checked = True Then
            VerschicktEinstellenToolStripMenuItem.Visible = False
        End If
        If lvwJTLKunden.SelectedItems.Count > 0 Then
            If lvwJTLKunden.SelectedItems(0).SubItems(11).Text = "Ja" Then
                NewsletterAbmeldenToolStripMenuItem.Text = "Newsletter a&bmelden"
            Else
                NewsletterAbmeldenToolStripMenuItem.Text = "Newsletter a&nmelden"
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'txtVorlageQuellcode.Text = My.Computer.FileSystem.ReadAllText(txtVorlagePfad.Text)
        'txtVorlageQuellcode.Visible = False
        'DHTMLControll.DOM.body.innerHTML = txtVorlageQuellcode.Text
        Dim strVorlageInhalt As String

        If IO.File.Exists(txtVorlagePfad.Text) = True Then

            strVorlageInhalt = My.Computer.FileSystem.ReadAllText(txtVorlagePfad.Text)

            '# Enthält <link href=" Fehler beim Laden, nur Textansicht
            If strVorlageInhalt.IndexOf("type=""text/css""") > 0 Then

                Panel1.Visible = False
                txtVorlageQuellcode.Visible = True
                txtVorlageQuellcode.Text = strVorlageInhalt
            Else

                txtVorlageQuellcode.Text = strVorlageInhalt

            End If
        End If
        Timer1.Enabled = False
    End Sub

    Private Sub lblHilfe_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim frmNewsletterTemplateHilfe As New frmNewsletterTemplateHilfe
        frmNewsletterTemplateHilfe.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim frmNewsletterTemplateBetreffHilfe As New frmNewsletterTemplateHilfe
        frmNewsletterTemplateBetreffHilfe.bBetreff = True
        frmNewsletterTemplateBetreffHilfe.Show()
    End Sub


    Private Async Function txtToolTipSuche_TextChangedAsync(sender As Object, e As System.EventArgs) As Task Handles txtToolTipSuche.TextChanged
        Await clsDB.getJTLKundenData(lvwJTLKunden, " AND cFirma LIKE '%" & txtToolTipSuche.Text & "%' OR cVorname LIKE '%" & txtToolTipSuche.Text & "%' OR cNachname LIKE '%" & txtToolTipSuche.Text & "%'", Me)
    End Function

    Private Sub VerschicktEinstellenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerschicktEinstellenToolStripMenuItem.Click
        If lvwJTLKunden.SelectedItems.Count > 0 Then
            clsDB.setJTLKundeUpdateSended(lvwJTLKunden.SelectedItems(0))
            lvwJTLKunden.SelectedItems(0).Remove()
        End If
    End Sub


    Private Sub optNewsletterAbschicken_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optNewsletterAbschicken.CheckedChanged
        msgMaster.Text = "Kunden anzeigen die für den Newsletter vorbereit sind"
    End Sub

    Private Sub optNewsletterVerschickt_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optNewsletterVerschickt.CheckedChanged
        msgMaster.Text = "Zeigt die Kunden an, welche schon verschickt wurden"
    End Sub

    Private Sub optAngemeldet_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optAngemeldet.CheckedChanged
        msgMaster.Text = "Zeigt alle Kunden an, welche angemeldet sind"
    End Sub

    Private Sub optAbgemeldet_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optAbgemeldet.CheckedChanged
        msgMaster.Text = "Zeigt alle Kunden an, welche abgemeldet sind"
    End Sub

    Private Sub txtVorlageQuellcode_Leave(sender As System.Object, e As System.EventArgs) Handles txtVorlageQuellcode.Leave
        If IO.File.Exists(txtVorlagePfad.Text) = True Then
            If txtVorlageQuellcode.Text.Length > 0 Then
                My.Computer.FileSystem.WriteAllText(txtVorlagePfad.Text, txtVorlageQuellcode.Text, False)
            End If
        End If
    End Sub

    Private Sub EinstellungenDebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungenDebugToolStripMenuItem.Click
        Dim frmDebugSettings As New frmDebug
        frmDebugSettings.Show()
    End Sub

    Private Sub CubssnetWebseiteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CubssnetWebseiteToolStripMenuItem.Click
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        Dim strFile As String = "https://bludau-media.de/"
        ExterneAnwendung.StartInfo.FileName = strFile
        ExterneAnwendung.Start()
        Application.Exit()
    End Sub

    Private Sub CubssnetKontaktToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CubssnetKontaktToolStripMenuItem.Click
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        Dim strFile As String = "https://bludau-media.de/"
        ExterneAnwendung.StartInfo.FileName = strFile
        ExterneAnwendung.Start()
        Application.Exit()
    End Sub

    Private Sub JTLNewsletterUpdatesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles JTLNewsletterUpdatesToolStripMenuItem.Click
        Dim frmUpdater As New frmUpdater
        frmUpdater.ShowDialog()
    End Sub

    Private Sub NewsletterAbmeldungenHolenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewsletterAbmeldungenHolenToolStripMenuItem.Click
        Dim frmNewsletterAbmelden As New frmJTLSync
        frmNewsletterAbmelden.ShowDialog()
    End Sub

    Private Sub btnAbmeldeURL_Click(sender As System.Object, e As System.EventArgs) Handles btnAbmeldeURL.Click
        Dim frmAbmelden As New frmJTLEinstellungen
        frmAbmelden.ShowDialog()
    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub chkNichtAmazon_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkNichtAmazon.CheckedChanged

    End Sub

    Private Sub tbNewsletter_Click(sender As System.Object, e As System.EventArgs) Handles tbNewsletter.Click

    End Sub


    Private Sub txtSektion2_artikelliste_TextChanged(sender As Object, e As EventArgs) Handles txtSektion2_artikelliste.TextChanged
        My.Settings.jtlshop_produkte_2(My.Settings.mandant_position) = txtSektion2_artikelliste.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion3_artikelliste_TextChanged(sender As Object, e As EventArgs) Handles txtSektion3_artikelliste.TextChanged
        My.Settings.jtlshop_produkte_3(My.Settings.mandant_position) = txtSektion3_artikelliste.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion4_artikelliste_TextChanged(sender As Object, e As EventArgs) Handles txtSektion4_artikelliste.TextChanged
        My.Settings.jtlshop_produkte_4(My.Settings.mandant_position) = txtSektion4_artikelliste.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion1_header_bild_TextChanged(sender As Object, e As EventArgs) Handles txtSektion1_header_bild.TextChanged
        My.Settings.jtlshop_bild_1(My.Settings.mandant_position) = txtSektion1_header_bild.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion2_bild_TextChanged(sender As Object, e As EventArgs) Handles txtSektion2_bild.TextChanged
        My.Settings.jtlshop_bild_2(My.Settings.mandant_position) = txtSektion2_bild.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion3_bild_TextChanged(sender As Object, e As EventArgs) Handles txtSektion3_bild.TextChanged
        My.Settings.jtlshop_bild_3(My.Settings.mandant_position) = txtSektion3_bild.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion4_bild_TextChanged(sender As Object, e As EventArgs) Handles txtSektion4_bild.TextChanged
        My.Settings.jtlshop_bild_4(My.Settings.mandant_position) = txtSektion4_bild.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion1_shopartikelbySKU_TextChanged(sender As Object, e As EventArgs) Handles txtSektion1_shopartikelbySKU.TextChanged
        My.Settings.jtlshop_produkte_1(My.Settings.mandant_position) = txtSektion1_shopartikelbySKU.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion1_beschreibung_TextChanged(sender As Object, e As EventArgs) Handles txtSektion1_beschreibung.TextChanged
        My.Settings.jtlshop_beschreibung_1(My.Settings.mandant_position) = txtSektion1_beschreibung.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion2_beschreibung_TextChanged(sender As Object, e As EventArgs) Handles txtSektion2_beschreibung.TextChanged
        My.Settings.jtlshop_beschreibung_2(My.Settings.mandant_position) = txtSektion2_beschreibung.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion3_beschreibung_TextChanged(sender As Object, e As EventArgs) Handles txtSektion3_beschreibung.TextChanged
        My.Settings.jtlshop_beschreibung_3(My.Settings.mandant_position) = txtSektion3_beschreibung.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion4_beschreibung_TextChanged(sender As Object, e As EventArgs) Handles txtSektion4_beschreibung.TextChanged
        My.Settings.jtlshop_beschreibung_4(My.Settings.mandant_position) = txtSektion4_beschreibung.Text
        My.Settings.Save()
    End Sub

    Private Sub txtBildLink_TextChanged(sender As Object, e As EventArgs) Handles txtBildLink.TextChanged
        My.Settings.jtlshop_bildlink1(My.Settings.mandant_position) = txtBildLink.Text
        My.Settings.Save()
    End Sub

    Private Sub txtBildLink2_TextChanged(sender As Object, e As EventArgs) Handles txtBildLink2.TextChanged
        My.Settings.jtlshop_bildlink2(My.Settings.mandant_position) = txtBildLink2.Text
        My.Settings.Save()
    End Sub

    Private Sub txtBildLink3_TextChanged(sender As Object, e As EventArgs) Handles txtBildLink3.TextChanged
        My.Settings.jtlshop_bildlink3(My.Settings.mandant_position) = txtBildLink3.Text
        My.Settings.Save()
    End Sub

    Private Sub txtBildlink4_TextChanged(sender As Object, e As EventArgs) Handles txtBildlink4.TextChanged
        My.Settings.jtlshop_bildlink4(My.Settings.mandant_position) = txtBildlink4.Text
        My.Settings.Save()
    End Sub

    Private Sub tbProduktverwaltung_newsletter_Click(sender As Object, e As EventArgs) Handles tbProduktverwaltung_newsletter.Click

    End Sub

    Private Sub txtSektion5_header_bild_TextChanged(sender As Object, e As EventArgs) Handles txtSektion5_bild.TextChanged
        My.Settings.jtlshop_bild_5(My.Settings.mandant_position) = txtSektion5_bild.Text
        My.Settings.Save()
    End Sub

    Private Sub txtBildlink5_TextChanged(sender As Object, e As EventArgs) Handles txtBildlink5.TextChanged
        My.Settings.jtlshop_bildlink5(My.Settings.mandant_position) = txtBildlink5.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion5_beschreibung_TextChanged(sender As Object, e As EventArgs) Handles txtSektion5_beschreibung.TextChanged
        My.Settings.jtlshop_beschreibung_5(My.Settings.mandant_position) = txtSektion5_beschreibung.Text
        My.Settings.Save()
    End Sub

    Private Sub txtSektion5_artikelliste_TextChanged(sender As Object, e As EventArgs) Handles txtSektion5_artikelliste.TextChanged
        My.Settings.jtlshop_produkte_5(My.Settings.mandant_position) = txtSektion5_artikelliste.Text
        My.Settings.Save()

    End Sub

    Private Sub txtVorlageQuellcode_TextChanged(sender As Object, e As EventArgs) Handles txtVorlageQuellcode.TextChanged

    End Sub

    Private Sub btnVorlagespeichern_Click(sender As Object, e As EventArgs) Handles btnVorlagespeichern.Click

        btnVorlagespeichern.Enabled = False
        If IO.File.Exists(txtVorlagePfad.Text) = True Then
            My.Computer.FileSystem.WriteAllText(txtVorlagePfad.Text, txtVorlageQuellcode.Text, False)
        Else
            MessageBox.Show("Datei '" & txtVorlagePfad.Text & "' wurde nicht gefunden.", "Überprüfen Sie Ihren Speicherpfad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        btnVorlagespeichern.Enabled = True
    End Sub

    Private Async Sub cmbKundenKategorie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKundenKategorie.SelectedIndexChanged


    End Sub

    Private Sub chkEmailServerLimitierungen_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmailServerLimitierungen.CheckedChanged
        My.Settings.core_mailserver_limitierungen = chkEmailServerLimitierungen.Checked

        If My.Settings.core_mailserver_limitierungen = True Then
            lblCore_Mail_bei.Visible = True
            lblCore_mail_bis.Visible = True
            txtCore_Mail_bei.Visible = True
            txtCore_mail_bis.Visible = True
        Else
            lblCore_Mail_bei.Visible = False
            lblCore_mail_bis.Visible = False
            txtCore_Mail_bei.Visible = False
            txtCore_mail_bis.Visible = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub txtEmailServerLimitierungen_anzahl_pro_stunde_TextChanged(sender As Object, e As EventArgs) Handles txtEmailServerLimitierungen_anzahl_pro_stunde.TextChanged


        If IsNumeric(txtEmailServerLimitierungen_anzahl_pro_stunde.Text) = True Then
            txtCore_mail_bis.Text = txtEmailServerLimitierungen_anzahl_pro_stunde.Text
            My.Settings.core_mailserver_anzahl_emails_pro_stunde = txtEmailServerLimitierungen_anzahl_pro_stunde.Text
            My.Settings.Save()
            txtEmailServerLimitierungen_anzahl_pro_stunde.BackColor = Color.White
        Else
            txtEmailServerLimitierungen_anzahl_pro_stunde.BackColor = Color.CadetBlue
        End If

    End Sub

    Private Sub chkTestlauf_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkTestlauf.CheckedChanged

        My.Settings.testlauf_aktiv(My.Settings.mandant_position) = chkTestlauf.Checked

        If chkTestlauf.Checked = True Then
            btnSend.Text = "&Testlauf Newsletter mit Echtdaten"
        Else
            btnSend.Text = "&Newsletter Versand starten"
        End If

    End Sub

    Private Sub tmr_core_mailserver_wait_Tick(sender As Object, e As EventArgs) Handles tmr_core_mailserver_wait.Tick
        txtCore_Mail_bei.Text = 0
        tmr_waittime_visual.Enabled = False
        btnSend.PerformClick()
    End Sub

    Private Sub tmr_waittime_visual_Tick(sender As Object, e As EventArgs) Handles tmr_waittime_visual.Tick
        masterpgr.Value = masterpgr.Value + 1000
        msgMaster.Text = masterpgr.Value & " / " & My.Settings.core_mailserver_wartezeit
    End Sub

    Private Sub txtCore_wartezeit_TextChanged(sender As Object, e As EventArgs) Handles txtCore_wartezeit.TextChanged
        If IsNumeric(txtCore_wartezeit.Text) = True Then
            My.Settings.core_mailserver_wartezeit = txtCore_wartezeit.Text
            My.Settings.Save()
            txtCore_wartezeit.BackColor = Color.White
        Else
            txtCore_wartezeit.BackColor = Color.CadetBlue
        End If

    End Sub

    Private Sub lvwJTLKunden_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvwJTLKunden.ColumnClick
        Call setSort(lvwJTLKunden, e)
    End Sub
End Class
