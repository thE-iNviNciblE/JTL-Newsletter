Public Class clsMail
    Public bError As Boolean = False

    '####################################################################
    '# >> Template laden 
    '####################################################################
    Public Function getTemplate(ByVal strTemplate As String, ByVal lvwItem As ListViewItem) As String
        Try
            '# Existiert die Datei 

            '# Template Marker 
            strTemplate = strTemplate.Replace("###VORNAME###", lvwItem.SubItems(1).Text)
            strTemplate = strTemplate.Replace("###NACHNAME###", lvwItem.SubItems(3).Text)
            strTemplate = strTemplate.Replace("###PLZ###", lvwItem.SubItems(10).Text)
            strTemplate = strTemplate.Replace("###ORT###", lvwItem.SubItems(3).Text)
            strTemplate = strTemplate.Replace("###FIRMA###", lvwItem.SubItems(5).Text)
            strTemplate = strTemplate.Replace("###EMAIL###", lvwItem.SubItems(4).Text)
            strTemplate = strTemplate.Replace("###KDNR###", lvwItem.SubItems(6).Text)
            strTemplate = strTemplate.Replace("###STRASSE###", lvwItem.SubItems(7).Text)
            strTemplate = strTemplate.Replace("###LAND###", lvwItem.SubItems(8).Text)
            strTemplate = strTemplate.Replace("###ANREDE###", lvwItem.SubItems(9).Text)
            'strTemplate = strTemplate.Replace("###UID###", getUIDLink(lvwItem.SubItems(11).Text, lvwItem.SubItems(8).Text))
            strTemplate = strTemplate.Replace("###ABMELDENLINK###", getAbmeldeLink(lvwItem.SubItems(4).Text, lvwItem.Text))


            Return strTemplate

        Catch ex As Exception
            'Call debug_message(ex, "getTemplate")
            Return "false"
        End Try
    End Function

    '###############################################################
    '# >> eMail Senden 
    '###############################################################
    Public Function setSendMail(ByVal strKundenemail As String, ByVal strContent As String, ByVal strBetreff As String) As Boolean
        Dim SmtpObj As New System.Net.Mail.SmtpClient
        Dim pop3Client As New OpenPop.Pop3.Pop3Client
        Try
            '# ->> Fehlerprüfung
            If strContent.Length = 0 Then
                MsgBox("Fehler kein inhalt")
                Return False
                Exit Function
            End If
            If strBetreff.Length = 0 Then
                MsgBox("Fehler kein Betrefftext")
                Return False
                Exit Function
            End If

            '# POP3 before SMTP nur dann ausführen wenn Setting vorliegt 
            If My.Settings.email_pop3_before_smtp(My.Settings.mandant_position) = "True" Then

                Try
                    pop3Client.Connect(My.Settings.email_pop3(My.Settings.mandant_position), My.Settings.email_pop_port(My.Settings.mandant_position), False)
                    pop3Client.Authenticate(My.Settings.email_username(My.Settings.mandant_position), My.Settings.email_pwd(My.Settings.mandant_position))
                Catch ex As Exception
                    MessageBox.Show("Fehler bei POP3: " & ex.Message, "Fehler bei POP3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If

            Dim MailNachricht As New System.Net.Mail.MailMessage()
            SmtpObj.Credentials = New System.Net.NetworkCredential(My.Settings.email_username(My.Settings.mandant_position), My.Settings.email_pwd(My.Settings.mandant_position))
            SmtpObj.Port = My.Settings.email_smtp_port(My.Settings.mandant_position)

            'If My.Settings.email_istTestmodus = True Then
            ' strKundenemail = My.Settings.developer_email_check
            'End If

            SmtpObj.Host = My.Settings.email_smtp(My.Settings.mandant_position)  '"mail.gmx.net"

            With MailNachricht
                .From = New System.Net.Mail.MailAddress(My.Settings.email_username(My.Settings.mandant_position), My.Settings.email_absende_name(My.Settings.mandant_position))
                .BodyEncoding = System.Text.Encoding.UTF8
                .To.Add(strKundenemail)
                .Subject = strBetreff
                .IsBodyHtml = True  'My.Settings.email_isthtml
                .Body = strContent
            End With

            MailNachricht.Attachments.Clear()

            SmtpObj.Send(MailNachricht)

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim Email abschicken '" & strKundenemail & "'", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bError = True
            Return False
        End Try

        Return True
    End Function
    Public Function getAbmeldeLink(ByVal strEmail As String, ByVal strKID As String) As String
        'http://www.maiwell.com/newsletter_abmelden.php
        Return My.Settings.shop_abmelden_url(My.Settings.mandant_position) & "?abmelde_id_email=" & strEmail & "&UID=" & strKID & "&abmelden=true"
    End Function

    Public Function getUIDLink(ByVal strUID As String, ByVal strCRC As String) As String
        Return "?UID=" & strUID
    End Function
End Class
