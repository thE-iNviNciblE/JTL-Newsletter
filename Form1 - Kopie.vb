Public Class frmMain
    Public clsDB As New clsDatenbank

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.db_server.Length = 0 Or My.Settings.db_datenbankname.Length = 0 Or My.Settings.db_passwort.Length = 0 Or My.Settings.db_username.Length = 0 Then
            Dim frmDBSetting As New frmDatenbankEinstellungen
            frmDBSetting.ShowDialog()
        End If

        Dim strCon As String = "server=" & My.Settings.db_server & ";uid=" & My.Settings.db_username & ";pwd=" & My.Settings.db_passwort & ";database=" & My.Settings.db_datenbankname & ";"

        If clsDB.getDBConnect(strCon) = False Then
            Dim frmDBSetting As New frmDatenbankEinstellungen
            frmDBSetting.ShowDialog()
        End If

        Dim frmStatus As New frmJTLSync
        frmStatus.ShowDialog(Me)

    End Sub

 

    Private Sub btnEinlesen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEinlesen.Click
        btnEinlesen.Enabled = False

        If optNewsletter.Checked = True Then
            clsDB.getJTLKundenData_send(lvwJTLKunden, False)
        Else
            clsDB.getJTLKundenData_send(lvwJTLKunden, True)
        End If

        btnEinlesen.Enabled = True
        msgMaster.Text = "Kunden eingelesen: " & lvwJTLKunden.Items.Count - 1
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Call setSendNewsletter(lvwJTLKunden)
    End Sub

    Private Function setSendNewsletter(ByVal lvwJTLKunden As ListView) As Boolean
        Try
            Dim iCount As Integer = 0

            For iCount = 0 To lvwJTLKunden.Items.Count - 1

                '# Prüfung ob Kunde in TMP Existiert 
                'If clsDB.chkJTLKundeExists(lvwJTLKunden.Items(iCount).Text) = False Then
                'clsDB.setJTLKundeTMP_new(lvwJTLKunden.Items(iCount))
                'Else
                clsDB.setJTLKundeTMP_update(lvwJTLKunden.Items(iCount))
                'End If
            Next
        Catch ex As Exception

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


        OpenFileDialog1.Title = "JTL Newsletter -> HTML Import"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            'strPathVorlage = OpenFileDialog1.FileName

            DHTMLControll.DOM.body.innerHTML = ""
            txtVorlageQuellcode.Text = ""

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
            bIsClicked = True
        Else
            DHTMLControll.BrowseMode = False
            bIsClicked = False
        End If
    End Sub

    Private Sub SpeichernToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernToolStripButton.Click
        Dim strHTMLExport As String = ""

        SaveFileDialog1.Title = "JTL Newsletter -> HTML Export"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strHTMLExport = SaveFileDialog1.FileName
        Else
            MsgBox("Es ist ein Fehler beim Speichern aufgetretten", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "JTL Newsletter -> Fehler beim Speichern")
        End If


        If LinkLabel1.Text = "HTML" Then
            My.Computer.FileSystem.WriteAllText(strHTMLExport, DHTMLControll.DOM.body.innerHTML, False)
        Else
            My.Computer.FileSystem.WriteAllText(strHTMLExport, txtVorlageQuellcode.Text, False)
        End If

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
End Class
