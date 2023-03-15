Public Class frmDebug

    Private Sub frmDebug_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSettings.Text = getSettingsDebug()
    End Sub
    '###############################################
    '# >> Einstellungen durchgehen
    '###############################################
    Private Function getSettingsDebug() As String
        Try
            Dim strData As String = ""
            For i As Integer = 0 To My.Settings.db_server.Count - 1
                strData &= "Server:" & My.Settings.db_server.Item(i) & vbCrLf & "Datenbank: " & My.Settings.db_datenbankname.Item(i) & vbCrLf & "Benutzername: " & My.Settings.db_username.Item(i) & vbCrLf & "Passwort: " & My.Settings.db_passwort.Item(i) & vbCrLf & vbCrLf
                'strData &= strData & vbCrLf & vbCrLf
            Next
            Return strData
        Catch ex As Exception
            MessageBox.Show(ex.Message, "getSetttings Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return "-1"
        End Try
    End Function

    Private Sub btnDBTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDBTest.Click
        Call frmMain.setSettingsDelete()
    End Sub
 

End Class