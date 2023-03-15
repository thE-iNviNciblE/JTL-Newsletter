Imports System.Net
Imports System.IO

Public Class frmJTLSync
    Public bServerError As Boolean = False

    Private Sub frmJTLSync_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call frmLoad()
    End Sub

    '##########################################################
    '# frmLoad()
    '# Laden von JTL Sync
    '##########################################################
    Private Sub frmLoad()
        Dim strRes As String = ""
        Try
            Try
                '# Überlauf bei den Settings 
                strRes = My.Settings.shop_abmelden_url(My.Settings.mandant_position).Length
            Catch ex As Exception
                frmMain.msgMaster.Text = "Fehler beim Synchronisieren der JTL Kunden für den Newsletter"
                frmMain.bLoadError = True
                Me.Close()
                Exit Sub
            End Try

            If strRes > 0 Then
                If getNewsletterAbmeldung() = True Then
                    'Timer1.Enabled = True
                    Call getNewsletterAbmeldungINIT()
                Else
                    'Timer1.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Fehler bei: " & ex.Message, "frmLoad")
        End Try
    End Sub
    '##########################################################
    '# getNewsletterAbmeldung()
    '# Vom Newsletter abmelden
    '##########################################################
    Private Function getNewsletterAbmeldung() As Boolean
        Try
            Dim client As New WebClient()
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")

            Dim data As Stream = client.OpenRead(My.Settings.shop_abmelden_url(My.Settings.mandant_position) & "?action=fetch_illixi")
            Dim reader As New StreamReader(data)
            Dim s As String = reader.ReadToEnd()
            Dim str() As String = s.Split(vbLf)
            Dim iCount As Integer = 0
            Dim strData() As String

            For iCount = 0 To str.Length - 1
                strData = str(iCount).Split("|")
                If frmMain.clsDB.setNewsletterAbmeldung(strData(0)) = False Then
                    MessageBox.Show("Problem beim Abmelden von " & strData(1) & "(" & strData(0) & ")", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Next iCount

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

    Private Function getNewsletterAbmeldungINIT() As Boolean
        lvwJTLKunden.BeginUpdate()
        frmMain.clsDB.getJTLKundenData(lvwJTLKunden)
        lvwJTLKunden.EndUpdate()
        pgrStatus.Maximum = lvwJTLKunden.Items.Count - 1

        For iCount = 0 To lvwJTLKunden.Items.Count - 1

            pgrStatus.Value = iCount
            Application.DoEvents()
            '# Prüfung ob Kunde in TMP Existiert 
            If frmMain.clsDB.chkJTLKundeExists(lvwJTLKunden.Items(iCount).Text) = False Then
                frmMain.clsDB.setJTLKundeTMP_new(lvwJTLKunden.Items(iCount))
            End If
        Next
        'frmMain.msgMaster.Text = "Kunden eingelesen: " & lvwJTLKunden.Items.Count - 1
        Me.Close()
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
End Class