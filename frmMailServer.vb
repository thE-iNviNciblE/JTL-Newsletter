Public Class frmMailServer
    Dim bIsLoading As Boolean = False
    Dim clsMail As New clsMail

    Private Sub cmbSMTPAnbieter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSMTPAnbieter.SelectedIndexChanged
        Select Case cmbSMTPAnbieter.Text
            Case "GMX"
                txtSMTPPort.Text = "25"
                txtPOP3Port.Text = "110"
                txtSMTPServer.Text = "mail.gmx.net"
                txtPOP3Server.Text = "pop.gmx.net"

            Case "Web"
                txtSMTPPort.Text = "25"
                txtPOP3Port.Text = "110"
                txtSMTPServer.Text = "smtp.web.de"
                txtPOP3Server.Text = "pop3.web.de"
            Case "Live"
                txtSMTPPort.Text = "25"
                txtPOP3Port.Text = "110"
                txtSMTPServer.Text = "smtp.live.com"
                txtPOP3Server.Text = "pop3.live.com"
            Case "Google Mail"
                txtSMTPPort.Text = "465"
                txtPOP3Port.Text = "587"
                txtSMTPServer.Text = "smtp.googlemail.com"
                txtPOP3Server.Text = "pop.googlemail.com "
            Case "Yahoo"
                txtSMTPPort.Text = "25"
                txtPOP3Port.Text = "110"
                txtSMTPServer.Text = "smtp.mail.yahoo.de"
                txtPOP3Server.Text = "pop.mail.yahoo.com"
            Case "Keine Auswahl"
                txtSMTPPort.Text = ""
                txtPOP3Port.Text = ""
                txtSMTPServer.Text = ""
                txtPOP3Server.Text = ""
        End Select
    End Sub

    Private Sub frmMailServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setMainWindowTitle("Mailserver Setup", Me)
        Try
            txtSMTPServer.Text = My.Settings.email_smtp_port(My.Settings.mandant_position)
        Catch ex As Exception
            My.Settings.email_smtp_port.Add("")
        End Try

        Try
            txtPOP3Server.Text = My.Settings.email_pop3(My.Settings.mandant_position)
        Catch ex As Exception
            My.Settings.email_pop3.Add("")
        End Try

        Try
            txtPOP3Port.Text = My.Settings.email_pop_port(My.Settings.mandant_position)
        Catch ex As Exception
            My.Settings.email_pop_port.Add("")
        End Try

        Try
            txteMailUser.Text = My.Settings.email_username(My.Settings.mandant_position)
        Catch ex As Exception
            My.Settings.email_username.Add("")
        End Try

        Try
            txteMailPassword.Text = My.Settings.email_pwd(My.Settings.mandant_position)
        Catch ex As Exception
            My.Settings.email_pwd.Add("")
        End Try

        Try
            txtEmailAbsendeName.Text = My.Settings.email_absende_name(My.Settings.mandant_position)
        Catch ex As Exception
            My.Settings.email_absende_name.Add("")
        End Try

        Try
            chkPop3BeforeSMTP.Checked = My.Settings.email_pop3_before_smtp(My.Settings.mandant_position)
        Catch ex As Exception
            My.Settings.email_pop3_before_smtp.Add("")
        End Try

        Try
            txtEmailUsername.Text = My.Settings.email_username_user(My.Settings.mandant_position)
        Catch ex As Exception
            My.Settings.email_username_user.Add("")
        End Try

        Try
            chkemail_ssl.Checked = My.Settings.emailssl(My.Settings.mandant_position)
        Catch ex As Exception
            chkemail_ssl.Checked = True
        End Try

    End Sub

    Private Sub txtSMTPServer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSMTPServer.TextChanged
        If bIsLoading = False Then
            My.Settings.email_smtp(My.Settings.mandant_position) = txtSMTPServer.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtSMTPPort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSMTPPort.TextChanged
        If bIsLoading = False Then
            My.Settings.email_smtp_port(My.Settings.mandant_position) = txtSMTPPort.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtPOP3Server_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPOP3Server.TextChanged
        If bIsLoading = False Then
            My.Settings.email_pop3(My.Settings.mandant_position) = txtPOP3Server.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtPOP3Port_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPOP3Port.TextChanged
        If bIsLoading = False Then
            My.Settings.email_pop_port(My.Settings.mandant_position) = txtPOP3Port.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txteMailUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txteMailUser.TextChanged
        If bIsLoading = False Then
            My.Settings.email_username(My.Settings.mandant_position) = txteMailUser.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txteMailPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txteMailPassword.TextChanged
        If bIsLoading = False Then
            My.Settings.email_pwd(My.Settings.mandant_position) = txteMailPassword.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub txtEmailAbsendeName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmailAbsendeName.TextChanged
        If bIsLoading = False Then
            My.Settings.email_absende_name(My.Settings.mandant_position) = txtEmailAbsendeName.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnTesteMail_Click(sender As System.Object, e As System.EventArgs) Handles btnTesteMail.Click

        If txtSMTPServer.Text.Length = 0 Then
            MessageBox.Show("Bitte einen SMTP Server eintragen!", "SMTP Server", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSMTPServer.Focus()
        End If
        If txtSMTPPort.Text.Length = 0 Then
            MessageBox.Show("Bitte einen SMTP Port eintragen!", "SMTP Port", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSMTPPort.Focus()
        End If
        If txteMailUser.Text.Length = 0 Then
            MessageBox.Show("Bitte eine Email-Adresse eintragen!", "Emailadresse", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txteMailUser.Focus()
        End If
        If txteMailPassword.Text.Length = 0 Then
            MessageBox.Show("Bitte ein Email Passwort eintragen!", "Email Passwort", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txteMailPassword.Focus()
        End If
        If txtEmailAbsendeName.Text.Length = 0 Then
            MessageBox.Show("Bitte ein Email Absendernamen eintragen!", "Email Absendernamen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEmailAbsendeName.Focus()
        End If

        If clsMail.setSendMail(My.Settings.email_username(My.Settings.mandant_position), "Ich bin eine Testnachricht von JTL Shop Newsletter", "JTL Shop Newsletter Testnachricht", True) = True Then
            MessageBox.Show("Testnachricht wurde erfolgreich an '" & My.Settings.email_username(My.Settings.mandant_position) & "' gesendet'", "Testnachricht verschickt", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub chkPop3BeforeSMTP_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPop3BeforeSMTP.CheckedChanged
        My.Settings.email_pop3_before_smtp(My.Settings.mandant_position) = chkPop3BeforeSMTP.Checked
        My.Settings.Save()
    End Sub

    Private Sub txtEmailUsername_TextChanged(sender As Object, e As EventArgs) Handles txtEmailUsername.TextChanged
        My.Settings.email_username_user(My.Settings.mandant_position) = txtEmailUsername.Text
        My.Settings.Save()
    End Sub

    Private Sub chkemail_ssl_CheckedChanged(sender As Object, e As EventArgs) Handles chkemail_ssl.CheckedChanged
        My.Settings.emailssl(My.Settings.mandant_position) = chkemail_ssl.Checked
        My.Settings.Save()
    End Sub
End Class