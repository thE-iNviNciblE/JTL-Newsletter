Imports System.Net
Imports System.IO

Public Class frmJTLSync
    Public bServerError As Boolean = False
    Public bStopSync As Boolean = False
    Private Sub frmJTLSync_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setMainWindowTitle("JTL WaWi Newsletter Kunden synchronisieren", Me)
        Timer1.Enabled = True
    End Sub

    '##########################################################
    '# frmLoad()
    '# Laden von JTL Sync
    '##########################################################
    Private Async Sub frmLoad()
        Dim strRes As String = ""
        Try
            Try
                '# Überlauf bei den Settings 
                strRes = CType(My.Settings.shop_abmelden_url(My.Settings.mandant_position).Length, String)
            Catch ex As Exception
                frmMain.msgMaster.Text = "keine Webseite zum Abrufen der Newsletterabmeldungen gefunden"
                frmMain.bLoadError = True
                Me.Close()
                Exit Sub
            End Try

            If CInt(strRes) > 0 Then
                If Await getNewsletterSyncData() = True Then
                    'Timer1.Enabled = True
                    lblHeader.Text = "JTL Shop Newsletter E-Mail Abmeldungen holen..."
                    lblStatus.Text = "Bitte nicht vor dem Versand des Newsletters überspringen."

                    Await getNewsletterAbmeldungJTLShop()

                    lblHeader.Text = "JTL Newsletter Tool E-Mail Abmeldungen holen..."
                    lblStatus.Text = "Bitte nicht vor dem Versand des Newsletters überspringen."

                    Await getNewsletterAbmeldung()
                Else
                    'Timer1.Enabled = False
                End If
                Me.Close()
            Else
                frmMain.msgMaster.Text = "Es wurde noch keine Shop URL für " & My.Settings.mandant_letzter_name & " eingerichtet"
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Fehler bei: " & ex.Message, "frmLoad")
        End Try
    End Sub

    '##########################################################################################
    '# >> JTL Shop Kunden für Newsletter System holen (Newsletter Anmeldungen)
    '##########################################################################################
    Private Async Function GetJTL_Shop_newsletter_kunden() As Threading.Tasks.Task(Of Boolean)


        Dim client As New WebClient()

        client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")

        Try
            Dim data As Stream = client.OpenRead(My.Settings.jtlshop_plugin_url(My.Settings.mandant_position) & "?modus=Anmeldung&pwd=XxX412")
            Dim reader As New StreamReader(data)
            Dim s As String = reader.ReadToEnd()
            Dim str() As String = s.Split(vbLf)
            Dim iCount As Integer = 0

            pgrStatus.Maximum = str.Length - 1
            pgrStatus.Value = 0
            Dim z As Integer = 0

            For z = 0 To str.Length - 1

                iCount += 1
                If str(z).ToString.Contains("@") = True Then

                    If Await frmMain.clsDB.chkJTLKundeExistByEmail(str(z).ToString.Replace(vbTab, "")) = False Then

                        lblStatus.Text = iCount + 1 & " / " & str(z).ToString

                        ' JTL Newsletter Kunden anzulegen
                        Await frmMain.clsDB.setJTLKundeTMP_newKID(str(z).ToString)
                        iCount += 1

                        lblNeueJTLNewsletterKunden.Text = iCount & ": neuer Newsletter Kunde"

                    Else


                    End If

                End If

                pgrStatus.Value = z
                lblJTLNewsletterKundenExist.Text = CType(z, String)
                Application.DoEvents()

                'If bStopSync = True Then
                '    Exit For
                'End If
            Next


        Catch ex As Exception
            My.Settings.jtlshop_plugin_url.Add("")
            MessageBox.Show("Fehler bei: " & ex.Message & vbCrLf & ex.StackTrace, "frmLoad")
        End Try


    End Function

    '##########################################################################################
    '# >> Abmeldungen vom JTL Shop Newsletter System holen
    '##########################################################################################
    Private Async Function getNewsletterAbmeldungJTLShop() As Threading.Tasks.Task(Of Boolean)


        Dim client As New WebClient()

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")

            Try
            Dim data As Stream = client.OpenRead(My.Settings.jtlshop_plugin_url(My.Settings.mandant_position) & "?modus=Abmeldung&pwd=XxX412")
            Dim reader As New StreamReader(data)
            Dim s As String = reader.ReadToEnd()
            Dim str() As String = s.Split(vbLf)
            Dim iCount As Integer = 0

            pgrStatus.Maximum = str.Length - 1
            pgrStatus.Value = 0
            Dim z As Integer = 0

            For z = 0 To str.Length - 1

                If str(z).Contains("@") = True Then
                    If Await frmMain.clsDB.setNewsletterAbmeldungByEmail(str(z).Replace(vbTab & vbTab, "").Replace(";", "")) = False Then

                        MessageBox.Show("Problem beim Abmelden von " & str(z).Replace(vbTab & vbTab, "").Replace(";", "") & ")", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

                pgrStatus.Value = z
                lblJTLNewsletterKundenExist.Text = z
                Application.DoEvents()

                If bStopSync = True Then
                    Exit For
                End If
            Next

            'If bStopSync = True Then
            '    Exit For
            'End If

        Catch ex As Exception
                My.Settings.jtlshop_plugin_url.Add("")
                MessageBox.Show("Fehler bei: " & ex.Message & vbCrLf & ex.StackTrace, "frmLoad")
            End Try


    End Function

    '##########################################################
    '# getNewsletterAbmeldung()
    '# Vom Newsletter abmelden
    '##########################################################
    Private Async Function getNewsletterAbmeldung() As Threading.Tasks.Task(Of Boolean)
        Try
            Dim client As New WebClient()
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")

            Dim data As Stream = client.OpenRead(My.Settings.shop_abmelden_url(My.Settings.mandant_position) & "?abmelden_holen=true")
            Dim reader As New StreamReader(data)
            Dim s As String = reader.ReadToEnd()
            Dim str() As String = s.Split(vbLf)
            Dim iCount As Integer = 0
            Dim strData() As String
            Dim bIsCompleted As Boolean = True

            pgrStatus.Maximum = str.Length - 1
            pgrStatus.Value = 0
            pgrStatus.Visible = True
            lblHeader.Text = "Newsletter Abmeldungen holen..."
            For iCount = 0 To str.Length - 1

                pgrStatus.Value = iCount

                Application.DoEvents()

                If bStopSync = True Then
                    bIsCompleted = False
                    Exit For
                End If

                strData = str(iCount).Split("|")
                frmMain.msgMaster.Text = "Abmeldung von: " & strData(0)
                lblStatus.Text = "Abmeldung von: " & strData(0)

                If Await frmMain.clsDB.setNewsletterAbmeldung(strData(0)) = False Then
                    bIsCompleted = False
                    MessageBox.Show("Problem beim Abmelden von " & strData(1) & "(" & strData(0) & ")", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Next iCount

            '####################################
            '# Löschen aller Daten
            '####################################
            If bIsCompleted = True Then
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")
                data = client.OpenRead(My.Settings.shop_abmelden_url(My.Settings.mandant_position) & "?abmelden_loeschen=true")
                Dim reader2 As New StreamReader(data)
                Dim strDataString As String = reader2.ReadToEnd()
            End If

            Return True

        Catch ex As Exception

            If ex.Message.IndexOf("404", 0) > 0 Or ex.Message.IndexOf("Remotename", 0) > 0 Then
                Timer1.Enabled = False
                If bServerError = True Then
                    If MessageBox.Show("Es gibt erneut einen Fehler bei der Newsletter abemelde Datei auf dem Server '" & My.Settings.shop_abmelden_url(My.Settings.mandant_position) & "', möchten Sie überspringen?", "Fehler bei SHOP URL", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Return False
                    Else
                        bServerError = False
                        Me.Close()
                    End If
                End If
                bServerError = True
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim frmJTLSyncSettings As New frmJTLEinstellungen
                frmJTLSyncSettings.ShowDialog()
                frmLoad()
            Else
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Return False

        End Try
    End Function

    Private Async Function getNewsletterSyncData() As Threading.Tasks.Task(Of Boolean)
        lvwJTLKunden.BeginUpdate()

        Await frmMain.clsDB.getSYNC_JTL_WAWI_KUNDEN(lvwJTLKunden, Me)
        '  Await GetJTL_Shop_newsletter_kunden()
        lvwJTLKunden.EndUpdate()

        'pgrStatus.Maximum = lvwJTLKunden.Items.Count
        'pgrStatus.Value = 0
        'pgrStatus.Visible = True
        'bStopSync = False

        'For iCount = 0 To lvwJTLKunden.Items.Count - 1

        '    If bStopSync = True Then
        '        Exit For
        '    End If

        '    pgrStatus.Value = iCount
        '    Application.DoEvents()

        '    '# Prüfung ob Kunde in TMP Existiert 
        '    If Await frmMain.clsDB.chkJTLKundeExists(lvwJTLKunden.Items(iCount).Text) = False Then

        '        lblStatus.Text = iCount + 1 & " / " & lvwJTLKunden.Items.Count - 1 & " | Füge hinzu: " & lvwJTLKunden.Items(iCount).SubItems(6).Text & " / " & lvwJTLKunden.Items(iCount).SubItems(4).Text
        '        Await frmMain.clsDB.setJTLKundeTMP_new(lvwJTLKunden.Items(iCount))
        '    Else
        '        lblStatus.Text = iCount + 1 & " / " & lvwJTLKunden.Items.Count - 1 & " | Existiert bereits: " & lvwJTLKunden.Items(iCount).SubItems(6).Text & " / " & lvwJTLKunden.Items(iCount).SubItems(4).Text

        '    End If
        '    lvwJTLKunden.Items(iCount).Selected = True
        '    lvwJTLKunden.Items(iCount).EnsureVisible()

        'Next
        'frmMain.msgMaster.Text = "Kunden eingelesen: " & lvwJTLKunden.Items.Count - 1
        Return True
    End Function

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    Timer1.Enabled = False

    '    lvwJTLKunden.BeginUpdate()
    '    frmMain.clsDB.getJTLKundenData(lvwJTLKunden)
    '    lvwJTLKunden.EndUpdate()
    '    pgrStatus.Maximum = lvwJTLKunden.Items.Count - 1

    '    For iCount = 0 To lvwJTLKunden.Items.Count - 1

    '        pgrStatus.Value = iCount
    '        Application.DoEvents()
    '        '# Prüfung ob Kunde in TMP Existiert 
    '        If frmMain.clsDB.chkJTLKundeExists(lvwJTLKunden.Items(iCount).Text) = False Then
    '            frmMain.clsDB.setJTLKundeTMP_new(lvwJTLKunden.Items(iCount))
    '        End If
    '    Next
    '    'frmMain.msgMaster.Text = "Kunden eingelesen: " & lvwJTLKunden.Items.Count - 1
    '    Me.Close()
    'End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Call frmLoad()
    End Sub

    Private Async Sub btnStopSync_Click(sender As System.Object, e As System.EventArgs) Handles btnStopSync.Click
        bStopSync = True
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click

    End Sub
End Class