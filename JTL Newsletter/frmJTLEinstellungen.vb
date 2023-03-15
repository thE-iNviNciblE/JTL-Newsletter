Public Class frmJTLEinstellungen

    Private Sub btnSpeichernOK_Click(sender As System.Object, e As System.EventArgs) Handles btnSpeichernOK.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub frmJTLEinstellungen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtShopURL.Text = My.Settings.shop_abmelden_url(My.Settings.mandant_position)
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
End Class