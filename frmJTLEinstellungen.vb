Imports System.Net
Imports System.IO
Public Class frmJTLEinstellungen

    Private Sub btnSpeichernOK_Click(sender As System.Object, e As System.EventArgs) Handles btnSpeichernOK.Click
        '####################################
        '# Newsletter Script prüfen
        '####################################
        Dim client As New WebClient()
        btnSpeichernOK.Enabled = False
        client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")
        Try
            Dim data As Stream = client.OpenRead(My.Settings.shop_abmelden_url(My.Settings.mandant_position) & "?abmelden_test=true")
            Dim reader2 As New StreamReader(data)
            Dim strDataString As String = reader2.ReadToEnd()
            If strDataString = "TEST_OK" Then
                My.Settings.Save()
                frmMain.msgMaster.Text = "Abmeldescript wurde erfolgreich auf dem Server eingerichtet"
                Me.Close()
            Else
                MessageBox.Show("Das Script zum abmelden wurde auf dem Server nicht gefunden!", "Abmeldescript fehlt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Das Script zum abmelden wurde auf dem Server nicht gefunden!", "Abmeldescript fehlt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnSpeichernOK.Enabled = True
        End Try
        btnSpeichernOK.Enabled = True

    End Sub

    Private Sub frmJTLEinstellungen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Call setMainWindowTitle("JTL Shop Einstellungen", Me)
            txtShopURL.Text = My.Settings.shop_abmelden_url(My.Settings.mandant_position)
            txtJTLShopConnector.Text = My.Settings.jtlshop_connector(My.Settings.mandant_position)
            txtJTLShopPlugin.Text = My.Settings.jtlshop_plugin_url(My.Settings.mandant_position)
            chkKomplettabgleich.Checked = My.Settings.bKomplettSync(My.Settings.mandant_position)
            'txtJTLShopPlugin.Text = My.Settings.jtlshop_plugin_url(My.Settings.mandant_position)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtShopURL_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtShopURL.TextChanged
        My.Settings.shop_abmelden_url(My.Settings.mandant_position) = txtShopURL.Text
        My.Settings.Save()
    End Sub

    Private Sub chkProgramSettingsDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProgramSettingsDelete.CheckedChanged
        If MessageBox.Show("Möchten Sie alle Programmeinstellungen löschen / zurücksetzen?", "Programmeinstellungen löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call frmMain.setSettingsDelete()
            MessageBox.Show("Programmeinstellungen wurden erfolgreich gelöscht", "Programmeinstellungen gelöscht", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub lblLinkOnlineHelp_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLinkOnlineHelp.LinkClicked
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        Dim strFile As String = "https://bludau-media.de/de/3521/Windows-Software/JTL-WaWi-Newsletter/"
        ExterneAnwendung.StartInfo.FileName = strFile
        ExterneAnwendung.Start()
        Application.Exit()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtJTLShopConnector.TextChanged
        ' My.Settings.jtlshop_connector.Insert(0, "")
        'My.Settings.jtlshop_connector.Insert(1, "")
        ' My.Settings.jtlshop_connector.Insert(3, "")
        My.Settings.jtlshop_connector(My.Settings.mandant_position) = txtJTLShopConnector.Text
        My.Settings.Save()
    End Sub

    Private Sub txtJTLShopPlugin_TextChanged(sender As Object, e As EventArgs) Handles txtJTLShopPlugin.TextChanged
        Try

           My.Settings.jtlshop_plugin_url(My.Settings.mandant_position) = txtJTLShopPlugin.Text
        Catch ex As Exception

            My.Settings.jtlshop_plugin_url.Add("")
        End Try
        My.Settings.Save()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        Dim strFile As String = "https://downloads.bludau-media.de/JTL%20Shop4%20Plugins/newsletter_abmelden.zip"
        ExterneAnwendung.StartInfo.FileName = strFile
        ExterneAnwendung.Start()
        Application.Exit()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        Dim strFile As String = "https://downloads.bludau-media.de/JTL%20Shop4%20Plugins/jbm_connector.zip"
        ExterneAnwendung.StartInfo.FileName = strFile
        ExterneAnwendung.Start()
        Application.Exit()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim ExterneAnwendung As New System.Diagnostics.Process()
        Dim strFile As String = "https://downloads.bludau-media.de/JTL%20Shop4%20Plugins/newsletter_abmelden.zip"
        ExterneAnwendung.StartInfo.FileName = strFile
        ExterneAnwendung.Start()
        Application.Exit()
    End Sub

    Private Sub chkKomplettabgleich_CheckedChanged(sender As Object, e As EventArgs) Handles chkKomplettabgleich.CheckedChanged

        My.Settings.bKomplettSync(My.Settings.mandant_position) = chkKomplettabgleich.Checked

        My.Settings.Save()
    End Sub
End Class