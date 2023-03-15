Module debug


    '#################################################
    '# >> getSettings
    '# Alle Settings durchgehen
    '#################################################
    Public Function getSettings() As Boolean
        Try
            For i As Integer = 0 To My.Settings.db_username.Count
                MessageBox.Show(My.Settings.db_datenbankname(i), "Einstellung " & i, MessageBoxButtons.OK, MessageBoxIcon.Information)
                debug.Print(My.Settings.db_datenbankname(i) & " -  " & " bei Einstellung " & i)
            Next
        Catch ex As Exception
            MessageBox.Show("Fehler bei: " & ex.Message, "getSettings()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Public Function setInitSettingsByPosition(ByVal iPosition As Integer) As Boolean
        Try
            My.Settings.db_server(iPosition) = "LXWServer"
            My.Settings.db_datenbankname(iPosition) = "Mandant_4"
            My.Settings.db_username(iPosition) = "sa"
            My.Settings.db_passwort(iPosition) = "lucky2000"
            My.Settings.template_pfad(iPosition) = "C:\Entwicklung\JTL Newsletter\JTL Newsletter\bin\Debug\Newsletter Vorlagen\Beispiel Vorlage.html"
            My.Settings.template_betreff(iPosition) = "JTL Newsletter"
            My.Settings.email_absende_name(iPosition) = "Bubblyfly"
            My.Settings.email_pop_port(iPosition) = "21"
            My.Settings.email_pop3_before_smtp(iPosition) = "false"
            My.Settings.email_pwd(iPosition) = ""
            My.Settings.email_smtp(iPosition) = ""
            My.Settings.email_smtp_port(iPosition) = ""
            My.Settings.email_username(iPosition) = ""
            Return True
        Catch ex As Exception
            MessageBox.Show("Fehler bei: " & ex.Message, "setInitSettingsByPosition()", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End Try
    End Function



    Private Function Print(ByVal p1 As String) As Integer
        Throw New NotImplementedException
    End Function

End Module
