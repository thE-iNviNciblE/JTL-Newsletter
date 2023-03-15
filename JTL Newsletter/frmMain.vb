Public Class frmMain
    Public clsDB As New clsDatenbank
    Private bIsLoading As Boolean = True
    Public bLoadError As Boolean = False



    '#################################################
    '# >> getCmbPositionByName
    '# Combobox Verändern auf aktuellen Wert 
    '#################################################
    Public Function getCmbPositionByName(ByVal cmb As ComboBox, ByVal strProfilName As String) As Integer
        Dim iRes As Integer = -1
        Try
            For i As Integer = 0 To cmb.Items.Count - 1
                If cmb.Items(i) = clsDB.getMandantbyDBName(strProfilName) Then
                    iRes = i
                    Exit For
                End If
            Next
            Return iRes
        Catch ex As Exception
            MessageBox.Show("Fehler bei: " & ex.Message, "Fehler bei getCmbPositionByName()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '#######################################
            '# >> Debug - Testen der Einstellungen 
            '#######################################
            'Call getSettings()
            'Call setInitSettingsByPosition(49)

            '# Dateiname für Update 
            Dim strFilename As String = Application.StartupPath & "\SQL\Update.sql"
            bIsLoading = True
            '# Keine Datenbankverbindungsmöglichkeiten vorhanden erster Start 
            If My.Settings.mandant_position = -1 Then
                Dim frmDBSetting As New frmDatenbankEinstellungen
                frmDBSetting.ShowDialog()
            End If



            '# Prüfung ob my.settings.mandant_position außerhalb des Index
            Try
                If My.Settings.db_server(My.Settings.mandant_position) = "" Then

                End If
            Catch ex As Exception
                '# Außerhalb des Index default Datenbank laden, falls vorhanden 
                MainMenuStrip.Text = "Fehler: aktuelle Position innerhalb der Einstellungen '" & My.Settings.mandant_position & "' - lade Standard Werte"
                My.Settings.mandant_position = getMySettingsPositionByDatabase("eazybusiness")
            End Try

            If My.Settings.db_server(My.Settings.mandant_position) = "" Or My.Settings.db_datenbankname(My.Settings.mandant_position) = "" Or My.Settings.db_passwort(My.Settings.mandant_position) = "" Or My.Settings.db_username(My.Settings.mandant_position) = "" Then
                Dim frmDBSetting As New frmDatenbankEinstellungen
                frmDBSetting.ShowDialog()
            End If

            '# Datenbank Verbindung initialisieren
            Call setDBSettings(True)


            '# Updates installieren, wenn Update.sql vorhanden ist!
            If IO.File.Exists(strFilename) = True Then
                Call clsDB.setInstallUpdateAllMandant(strFilename, cmbMandant)
            End If

            '# Verschlüsseln / Entschlüsseln der Einstellungen 
            'Dim crypto As New clsCryptoAPI
            'If My.Settings.first_start = True Then
            '    crypto.setInitKeyIV()
            'End If
            'MessageBox.Show(crypto.setSettingsCrypto_encrypt(My.Settings.db_passwort))
            'MessageBox.Show(crypto.setSettingsCrypto_decrypt(crypto.setSettingsCrypto_encrypt(My.Settings.db_passwort)))

            '# Synchronisieren der JTL Daten mit der illixi_newsletter Datei 
            Dim frmStatus As New frmJTLSync
            frmStatus.ShowDialog(Me)

            '# Laden bei Mandantenwechsel 
            Call getLoadSettingsMandantWechsel(False)
            bIsLoading = False
        Catch ex As Exception
            MessageBox.Show("Fehler bei frmMain_Load: " & ex.Message, "frmMain_load", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bIsLoading = False
        End Try

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
                        My.Settings.template_pfad.Insert(iCount, "")
                        My.Settings.template_betreff.Insert(iCount, "")
                        My.Settings.testlauf_anzahl.Insert(iCount, "")
                        My.Settings.testlauf_aktiv.Insert(iCount, "")
                        My.Settings.testlauf_email.Insert(iCount, "")
                        My.Settings.email_absende_name.Insert(iCount, "")
                        My.Settings.email_pop_port.Insert(iCount, "")
                        My.Settings.email_pop3_before_smtp.Insert(iCount, "")
                        My.Settings.email_pwd.Insert(iCount, "")
                        My.Settings.email_smtp.Insert(iCount, "")
                        My.Settings.email_smtp_port.Insert(iCount, "")
                        My.Settings.email_username.Insert(iCount, "")
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
    Private Sub setDBSettings(ByVal bLoadMandantenCombo As Boolean)
        '# Mandanten Datenbank 
        ' If Not cmbMandant.Text = "" Then

        '##################################################
        '# easzybusiness Connection 
        '##################################################
        If clsDB.strConnectionString_eazybusiness = "" Then
            My.Settings.mandant_position = getMySettingsPositionByDatabase("eazybusiness")
            Dim strCon As String = "server=" & My.Settings.db_server.Item(My.Settings.mandant_position) & ";uid=" & My.Settings.db_username.Item(My.Settings.mandant_position) & ";pwd=" & My.Settings.db_passwort.Item(My.Settings.mandant_position) & ";database=" & My.Settings.db_datenbankname.Item(My.Settings.mandant_position) & ";"
            If clsDB.getDBConnect(strCon, True) = False Then
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
            My.Settings.db_datenbankname.Item(My.Settings.mandant_position) = clsDB.getMandantDatabaseByMandantName(cmbMandant.Text)
            My.Settings.Save()

            If My.Settings.db_datenbankname.Item(My.Settings.mandant_position) = "" Then
                My.Settings.db_datenbankname.Item(My.Settings.mandant_position) = "eazybusiness"
                Call setSettingsInit(My.Settings.mandant_position)
                My.Settings.mandant_position = clsDB.chkMandantPosition(My.Settings.db_datenbankname.Item(My.Settings.mandant_position))
            End If

            'End If        
            Dim strConDB As String = "server=" & My.Settings.db_server.Item(My.Settings.mandant_position) & ";uid=" & My.Settings.db_username.Item(My.Settings.mandant_position) & ";pwd=" & My.Settings.db_passwort.Item(My.Settings.mandant_position) & ";database=" & My.Settings.db_datenbankname.Item(My.Settings.mandant_position) & ";"
            If clsDB.getDBConnect(strConDB) = False Then
                Dim frmDBSetting As New frmDatenbankEinstellungen
                frmDBSetting.ShowDialog()
            End If
        Else
            MessageBox.Show("Es wurde kein Mandant gefunden!", "Combobox Mandant nicht geladen ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
    Private Sub btnEinlesen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEinlesen.Click
        btnEinlesen.Enabled = False

        If clsDB.strConnectionString = "" Then
            '# Datenbank Verbindung initialisieren
            clsDB.strConnectionString = clsDB.strConnectionString_eazybusiness
        End If

        Dim strWhere As String = clsDB.getJTLKundenData_Where(optNewsletterAbschicken, optNewsletterVerschickt, optAngemeldet, optAbgemeldet)
        clsDB.getJTLKundenData_send(lvwJTLKunden, strWhere)

        btnEinlesen.Enabled = True
        msgMaster.Text = "Kunden für Mandant " & cmbMandant.Text & " eingelesen: " & lvwJTLKunden.Items.Count
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        '# Keine Kunden 
        If lvwJTLKunden.Items.Count = 0 Then
            MessageBox.Show("Bitte lesen Sie die JTL Kunden Daten zuerst ein!", "JTL Kunden einlesen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        '# Kein Betreff 
        If txteMailBetreff.Text.Length = 0 Then
            TabControl1.SelectedIndex = 1
            MessageBox.Show("Bitte tragen Sie einen Newsletter Betreff ein!", "Betreff fehlt", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                Call setSendNewsletter(lvwJTLKunden)
            Else
                TabControl1.SelectedIndex = 1
                MessageBox.Show("Ihre Newsletter Vorlage kann nicht mehr geöffnet werden, weil Sie nicht mehr existiert!", "JTL Newsletter - keine Vorlage", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            TabControl1.SelectedIndex = 1
            MessageBox.Show("Bitte ein Newsletter Template auswählen!", "JTL Newsletter - keine Vorlage", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Function setSendNewsletter(ByVal lvwJTLKunden As ListView) As Boolean
        Try
            Dim iCount As Integer = 0
            Dim strNewsletterVorlage As String = ""
            Dim clsMail As New clsMail
            clsMail.bError = False
            Dim strSendContent As String = ""
            Dim strEmail As String = ""
            Dim strBetreff As String = ""
            Dim strBetreff_tmp As String = txteMailBetreff.Text

            msgMaster.Text = "Lade Vorlage '" & My.Settings.template_pfad(My.Settings.mandant_position) & "'"
            strNewsletterVorlage = My.Computer.FileSystem.ReadAllText(My.Settings.template_pfad(My.Settings.mandant_position))
            masterpgr.Visible = True
            masterpgr.Value = 0
            masterpgr.Maximum = lvwJTLKunden.Items.Count

            For iCount = 0 To lvwJTLKunden.Items.Count - 1

                ' Template variablen füllen
                strSendContent = clsMail.getTemplate(strNewsletterVorlage, lvwJTLKunden.Items(iCount))
                strBetreff = clsMail.getTemplate(strBetreff_tmp, lvwJTLKunden.Items(iCount))
                '# Prüfung ob Kunde in TMP Existiert 
                'If clsDB.chkJTLKundeExists(lvwJTLKunden.Items(iCount).Text) = False Then
                'clsDB.setJTLKundeTMP_new(lvwJTLKunden.Items(iCount))

                '# Newsletter Abschicken
                If My.Settings.testlauf_aktiv(My.Settings.mandant_position) = False Then
                    strEmail = lvwJTLKunden.Items(iCount).SubItems(4).Text
                Else

                    If iCount + 1 = Convert.ToInt16(txtTestlaufAnzahl.Text) Then
                        masterpgr.Visible = False
                        MessageBox.Show("Testlaufende erreicht!", "Testlaufende", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Function
                    End If

                    strEmail = My.Settings.testlauf_email(My.Settings.mandant_position)
                End If

                msgMaster.Text = "Versende Email an '" & lvwJTLKunden.Items(iCount).SubItems(1).Text & " " & lvwJTLKunden.Items(iCount).SubItems(2).Text & "' (" & strEmail & ")"
                msgMaster.Text = "eMail abschicken an '" & strEmail & "'"
                If clsMail.setSendMail(strEmail, strSendContent, strBetreff) = True Then
                    '# Email als verschickt makieren
                    If My.Settings.testlauf_aktiv(My.Settings.mandant_position) = False Then
                        msgMaster.Text = "Kunde '" & lvwJTLKunden.Items(iCount).SubItems(2).Text & "' auf verschickt stellen..."
                        clsDB.setJTLKundeUpdateSended(lvwJTLKunden.Items(iCount))
                    End If
                End If

                '# Email Versandfehler aufgetretten
                If clsMail.bError = True Then
                    MessageBox.Show("Fehler beim SMTP Versand, bitte überprüfen Sie ihre Mailserver Einstellungen!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    masterpgr.Visible = False
                    Exit Function
                End If

                lvwJTLKunden.Items(iCount).Selected = True
                lvwJTLKunden.EnsureVisible(iCount)
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

    Private Sub NewsletterNeustartenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewsletterNeustartenToolStripMenuItem.Click
        If MessageBox.Show("Möchten Sie eine neue Newsletter Aktion starten?", "Neuer Newsletter?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            clsDB.setNewsletterNew()
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

    Private Sub NeuToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuToolStripButton.Click
        If DHTMLControll.DocumentHTML.Length > 0 Then

            If MessageBox.Show("Soll die geöffnete Datei wirklich geschlossen werden, um ein leeres Dokument anzulegen?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                DHTMLControll.DocumentHTML = ""
            End If
        End If
    End Sub

    Private Sub ÖffnenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖffnenToolStripButton.Click
        Call OpenFile()
    End Sub

    Private Sub OpenFile()

        OpenFileDialog1.Title = "JTL Newsletter -> HTML Import"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            'strPathVorlage = OpenFileDialog1.FileName

            DHTMLControll.DOM.body.innerHTML = ""
            txtVorlageQuellcode.Text = ""
            txtVorlagePfad.Text = OpenFileDialog1.FileName
            My.Settings.template_pfad(My.Settings.mandant_position) = txtVorlagePfad.Text
            My.Settings.Save()
            If LinkLabel1.Text = "HTML" Then
                DHTMLControll.DOM.body.innerHTML = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Else
                txtVorlageQuellcode.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            End If

            msgMaster.Text = "Lade Vorlage: " & OpenFileDialog1.FileName
        End If

    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked


        If LinkLabel1.Text = "HTML" Then
            LinkLabel1.Text = "Design"
            txtVorlageQuellcode.Visible = True
            txtVorlageQuellcode.Text = DHTMLControll.DOM.body.innerHTML
            DHTMLControll.Visible = False
        Else
            LinkLabel1.Text = "HTML"
            DHTMLControll.DOM.body.innerHTML = txtVorlageQuellcode.Text
            txtVorlageQuellcode.Visible = False
            DHTMLControll.Visible = True
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Static bIsClicked As Boolean = False

        If bIsClicked = False Then
            DHTMLControll.BrowseMode = True
            LinkLabel2.Text = "Browseransicht aktiv"
            bIsClicked = True
        Else
            DHTMLControll.BrowseMode = False
            LinkLabel2.Text = "Browseransicht inaktiv"
            bIsClicked = False
        End If
    End Sub

    Private Sub SpeichernToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernToolStripButton.Click
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


        If LinkLabel1.Text = "HTML" Then
            My.Computer.FileSystem.WriteAllText(strHTMLExport, DHTMLControll.DOM.body.innerHTML, False)
        Else
            My.Computer.FileSystem.WriteAllText(strHTMLExport, txtVorlageQuellcode.Text, False)
        End If

        txtVorlagePfad.Text = strHTMLExport
        MsgBox("Datei wurde unter '" & strHTMLExport & "' gespeichert", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "JTL Newsletter - Datei gespeichert")

    End Sub

    Private Sub DruckenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenToolStripButton.Click
        DHTMLControll.PrintDocument()
    End Sub

    Private Sub Bold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bold.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_BOLD)
    End Sub

    Private Sub Hyperlink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hyperlink.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_HYPERLINK)
    End Sub

    Private Sub Suchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Suchen.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_FINDTEXT)
    End Sub

    Private Sub Bild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bild.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_IMAGE)
    End Sub

    Private Sub Redo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Redo.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_REDO)
    End Sub

    Private Sub Undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Undo.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_UNDO)
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
        My.Settings.Save()
    End Sub

    Private Sub chkTestlauf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTestlauf.CheckedChanged

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
            My.Computer.FileSystem.WriteAllText(txtVorlagePfad.Text, DHTMLControll.DOM.body.innerHTML, False)
            My.Computer.FileSystem.WriteAllText(txtVorlagePfad.Text, txtVorlageQuellcode.Text, False)
        End If

    End Sub

    Private Sub JTLShopEinstellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JTLShopEinstellungenToolStripMenuItem.Click
        Dim frmJTLShopEinstellungen As New frmJTLEinstellungen
        frmJTLShopEinstellungen.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMandant.SelectedIndexChanged
        Call setComboFrmMainMandantWechsel()
        msgMaster.Text = "Neuer Mandant ausgewählt " & cmbMandant.Text & " bei Einstellungsposition " & My.Settings.mandant_position
        bIsLoading = False ' fehler bei setComboFrmMainMandantWechsel möglich bei true
    End Sub
    '#############################################################
    '# >> setComboFrmMainMandantWechsel
    '# Combobox Wechsel laden 
    '#############################################################
    Public Function setComboFrmMainMandantWechsel() As Boolean
        Try
            If bIsLoading = False Then
                My.Settings.mandant_letzter_name = cmbMandant.Text
                My.Settings.mandant_position = clsDB.chkMandantPosition(clsDB.getMandantDatabaseByMandantName(My.Settings.mandant_letzter_name))

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
    Private Sub NewsletterAbmeldenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewsletterAbmeldenToolStripMenuItem.Click
        If lvwJTLKunden.SelectedItems(0).SubItems(11).Text = "Ja" Then

            clsDB.setNewsletterAbAnmelden(lvwJTLKunden.SelectedItems(0).SubItems(0).Text, True)
            msgMaster.Text = "Kunde '" & lvwJTLKunden.SelectedItems(0).SubItems(1).Text & " " & lvwJTLKunden.SelectedItems(0).SubItems(2).Text & "' (" & lvwJTLKunden.SelectedItems(0).SubItems(4).Text & ") wurde abgemeldet"
            lvwJTLKunden.SelectedItems(0).Remove()            
        Else
            clsDB.setNewsletterAbAnmelden(lvwJTLKunden.SelectedItems(0).SubItems(0).Text, False)
            msgMaster.Text = "Kunde '" & lvwJTLKunden.SelectedItems(0).SubItems(1).Text & " " & lvwJTLKunden.SelectedItems(0).SubItems(2).Text & "' (" & lvwJTLKunden.SelectedItems(0).SubItems(4).Text & ") wurde angemeldet"
        End If
    End Sub
 
    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Not optNewsletterAbschicken.Checked = True Then
            VerschicktEinstellenToolStripMenuItem.Visible = False
        End If
        If lvwJTLKunden.SelectedItems(0).SubItems(11).Text = "Ja" Then
            NewsletterAbmeldenToolStripMenuItem.Text = "Newsletter a&bmelden"
        Else
            NewsletterAbmeldenToolStripMenuItem.Text = "Newsletter a&nmelden"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        txtVorlageQuellcode.Text = My.Computer.FileSystem.ReadAllText(txtVorlagePfad.Text)
        txtVorlageQuellcode.Visible = False
        DHTMLControll.DOM.body.innerHTML = txtVorlageQuellcode.Text
        Timer1.Enabled = False
    End Sub

    Private Sub lblHilfe_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblHilfe.LinkClicked
        Dim frmNewsletterTemplateHilfe As New frmNewsletterTemplateHilfe
        frmNewsletterTemplateHilfe.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim frmNewsletterTemplateBetreffHilfe As New frmNewsletterTemplateHilfe
        frmNewsletterTemplateBetreffHilfe.bBetreff = True
        frmNewsletterTemplateBetreffHilfe.Show()
    End Sub
 

    Private Sub txtToolTipSuche_TextChanged(sender As Object, e As System.EventArgs) Handles txtToolTipSuche.TextChanged
        Call clsDB.getJTLKundenData_send(lvwJTLKunden, " AND cFirma LIKE '%" & txtToolTipSuche.Text & "%' OR cVorname LIKE '%" & txtToolTipSuche.Text & "%' OR cName LIKE '%" & txtToolTipSuche.Text & "%'")
    End Sub

    Private Sub VerschicktEinstellenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerschicktEinstellenToolStripMenuItem.Click
        If lvwJTLKunden.SelectedItems.Count > 0 Then
            clsDB.setJTLKundeUpdateSended(lvwJTLKunden.SelectedItems(0))
            lvwJTLKunden.SelectedItems(0).Remove()
        End If        
    End Sub

    Private Sub AusschneidenToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles AusschneidenToolStripButton.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_CUT)
    End Sub

    Private Sub KopierenToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles KopierenToolStripButton.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_COPY)
    End Sub

    Private Sub EinfügenToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles EinfügenToolStripButton.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_PASTE)
    End Sub

    Private Sub tabelle_Click(sender As System.Object, e As System.EventArgs) Handles tabelle.Click
        DHTMLControll.ExecCommand(DHTMLEDLib.DHTMLEDITCMDID.DECMD_INSERTTABLE)
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
            My.Computer.FileSystem.WriteAllText(txtVorlagePfad.Text, txtVorlageQuellcode.Text, False)
        End If                
    End Sub

    Private Sub DHTMLControll_Leave(sender As System.Object, e As System.EventArgs) Handles DHTMLControll.Leave
        If IO.File.Exists(txtVorlagePfad.Text) = True Then
            My.Computer.FileSystem.WriteAllText(txtVorlagePfad.Text, DHTMLControll.DOM.body.innerHTML, False)
        End If
    End Sub

    Private Sub EinstellungenDebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungenDebugToolStripMenuItem.Click
        Dim frmDebugSettings As New frmDebug
        frmDebugSettings.Show()
    End Sub
End Class
