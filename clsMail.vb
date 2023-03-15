Imports System.ComponentModel
Imports System.Net

Public Class clsMail
    Public bError As Boolean = False
    Public strArtikelPromo As String = ""
    Public strErrorKunden As String = ""
    Private Shared mailSent As Boolean = False

    '####################################################################
    '# >> Template laden 
    '####################################################################
    Public Async Function getTemplate(ByVal strTemplate As String, ByVal lvwItem As ListViewItem, strProdukte As String, strBild As String, strBeschreibung As String, strProdukte2 As String, strBild2 As String, strBeschreibung2 As String, strProdukte3 As String, strBild3 As String, strBeschreibung3 As String, strProdukte4 As String, strProdukte5 As String, strBild4 As String, strBild5 As String, strBeschreibung4 As String, strBeschreibung5 As String, strBildlink1 As String, strBildLink2 As String, strBildLink3 As String, strBildLink4 As String, strBildLink5 As String) As Threading.Tasks.Task(Of String)
        Try

            If strProdukte.Length > 0 Then
                ' Nur 1x einlesen für alle Emails
                If strArtikelPromo = "" Then
                    strTemplate = strTemplate.Replace("###SHOPPRODUKTE_1###", Await frmMain.clsDB.getShopProdukts(strProdukte))
                End If

            End If
            strTemplate = strTemplate.Replace("###SHOPBESCHREIBUNG_1###", strBeschreibung)

            Dim strVarBild As String = ""
            If strBildlink1.Length > 0 Then
                strVarBild = "<a href=""" & strBildlink1 & """>"
                strVarBild &= "<img class=""img-max"" style=""max-width: 100%;height: auto;"" src=""" & strBild & """ border=""0""/>"
                strVarBild &= "</a>"
            Else
                If strBild.Length > 0 Then
                    strVarBild = "<img class=""img-max"" style=""max-width: 100%;height: auto;"" src=""" & strBild & """ border=""0""/>"
                Else
                    strVarBild = ""
                End If
            End If

            strTemplate = strTemplate.Replace("###SHOPBILD_1###", strVarBild)

            strTemplate = strTemplate.Replace("###SHOPPRODUKTE_1###", strArtikelPromo)

            If strProdukte2.Length > 0 Then
                ' Nur 1x einlesen für alle Emails
                strTemplate = strTemplate.Replace("###SHOPPRODUKTE_2###", Await frmMain.clsDB.getShopProdukts(strProdukte2))
            Else
                strTemplate = strTemplate.Replace("###SHOPPRODUKTE_2###", "")
            End If

            strTemplate = strTemplate.Replace("###SHOPBESCHREIBUNG_2###", strBeschreibung2)

            If strBild2.Length > 0 Then
                strVarBild = "<a href=""" & strBildLink2 & """>"
                strVarBild &= "<img class=""img-max"" style=""max-width: 100%;height: auto;"" src=""" & strBild2 & """ border=""0""/>"
                strVarBild &= "</a>"
            Else
                If strBild2.Length > 0 Then
                    strVarBild = "<img class=""img-max"" style=""max-width: 100%;height: auto;"" src=""" & strBild2 & """ border=""0""/>"
                Else
                    strVarBild = ""
                End If

            End If

            strTemplate = strTemplate.Replace("###SHOPBILD_2###", strVarBild)

            If strProdukte3.Length > 0 Then
                ' Nur 1x einlesen für alle Emails
                strTemplate = strTemplate.Replace("###SHOPPRODUKTE_3###", Await frmMain.clsDB.getShopProdukts(strProdukte3))
            Else
                strTemplate = strTemplate.Replace("###SHOPPRODUKTE_3###", "")
            End If

            strTemplate = strTemplate.Replace("###SHOPBESCHREIBUNG_3###", strBeschreibung3)

            If strBildLink3.Length > 0 Then
                strVarBild = "<a href=""" & strBildLink3 & """>"
                strVarBild &= "<img class=""img-max"" style=""max-width: 100%;height: auto;"" src=""" & strBild3 & """ border=""0""/>"
                strVarBild &= "</a>"
            Else
                If strBild3.Length > 0 Then
                    strVarBild = "<img class=""img-max"" style=""max-width: 100%;height: auto;"" src=""" & strBild3 & """ border=""0""/>"
                Else
                    strVarBild = ""
                End If


            End If

            strTemplate = strTemplate.Replace("###SHOPBILD_3###", strVarBild)

            If strProdukte4.Length > 0 Then
                ' Nur 1x einlesen für alle Emails
                strTemplate = strTemplate.Replace("###SHOPPRODUKTE_4###", Await frmMain.clsDB.getShopProdukts(strProdukte4))
            Else
                strTemplate = strTemplate.Replace("###SHOPPRODUKTE_4###", "")
            End If

            strTemplate = strTemplate.Replace("###SHOPBESCHREIBUNG_4###", strBeschreibung4)

            If strBildLink4.Length > 0 Then
                strVarBild = "<a href=""" & strBildLink4 & """>"
                strVarBild &= "<img class=""img-max"" style=""max-width: 100%;height: auto;"" src=""" & strBild4 & """ border=""0""/>"
                strVarBild &= "</a>"
            Else
                If strBild4.Length > 0 Then
                    strVarBild = "<img class=""img-max"" style=""max-width: 100%;height: auto;"" src=""" & strBild4 & """ border=""0""/>"
                Else
                    strVarBild = ""
                End If
            End If

            strTemplate = strTemplate.Replace("###SHOPBILD_4###", strVarBild)

            If strProdukte5.Length > 0 Then
                ' Nur 1x einlesen für alle Emails
                strTemplate = strTemplate.Replace("###SHOPPRODUKTE_5###", Await frmMain.clsDB.getShopProdukts(strProdukte5))
            Else
                strTemplate = strTemplate.Replace("###SHOPPRODUKTE_5###", "")
            End If

            strTemplate = strTemplate.Replace("###SHOPBESCHREIBUNG_5###", strBeschreibung5)

            If strBildLink5.Length > 0 Then
                strVarBild = "<a href=""" & strBildLink5 & """>"
                strVarBild &= "<img class=""img-max"" style=""max-width: 100%;height: auto;"" src=""" & strBild5 & """ border=""0""/>"
                strVarBild &= "</a>"
            Else
                If strBild5.Length > 0 Then
                    strVarBild = "<img class=""img-max"" style=""max-width: 100%;height: auto;"" src=""" & strBild5 & """ border=""0""/>"
                Else
                    strVarBild = ""
                End If

            End If

            strTemplate = strTemplate.Replace("###SHOPBILD_5###", strVarBild)

            Return strTemplate

        Catch ex As Exception
            'Call debug_message(ex, "getTemplate")
            Return "false"
        End Try
    End Function
    Private Shared Sub SendCompletedCallback(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        ' Get the unique identifier for this asynchronous operation.
        Dim token As String = CStr(e.UserState)

        If e.Cancelled Then
            Console.WriteLine("[{0}] Send canceled.", token)
        End If
        If e.Error IsNot Nothing Then
            Console.WriteLine("[{0}] {1}", token, e.Error.ToString())
        Else
            Console.WriteLine("Message sent.")
        End If
        mailSent = True
    End Sub

    '###############################################################
    '# >> eMail Senden 
    '###############################################################
    Public Function setSendMail(ByVal strKundenemail As String, ByVal strContent As String, ByVal strBetreff As String, Optional bTestModus As Boolean = True) As Boolean
        Dim SmtpObj As New System.Net.Mail.SmtpClient
        Dim pop3Client As New OpenPop.Pop3.Pop3Client
        Try
            ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications

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
                    pop3Client.Connect(My.Settings.email_pop3(My.Settings.mandant_position), CInt(My.Settings.email_pop_port(My.Settings.mandant_position)), False)
                    pop3Client.Authenticate(My.Settings.email_username_user(My.Settings.mandant_position), My.Settings.email_pwd(My.Settings.mandant_position))
                Catch ex As Exception
                    MessageBox.Show("Fehler bei POP3: " & ex.Message, "Fehler bei POP3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If

            Dim MailNachricht As New System.Net.Mail.MailMessage()
            SmtpObj.Credentials = New System.Net.NetworkCredential(My.Settings.email_username_user(My.Settings.mandant_position), My.Settings.email_pwd(My.Settings.mandant_position))
            SmtpObj.Port = CInt(My.Settings.email_smtp_port(My.Settings.mandant_position))

            If CBool(My.Settings.emailssl(My.Settings.mandant_position)) = True Then
                SmtpObj.EnableSsl = True
            Else
                SmtpObj.EnableSsl = False
            End If

            'If My.Settings.email_istTestmodus = True Then
            ' strKundenemail = My.Settings.developer_email_check
            'End If

            SmtpObj.Host = My.Settings.email_smtp(My.Settings.mandant_position)  '"mail.gmx.net"
            AddHandler SmtpObj.SendCompleted, AddressOf SendCompletedCallback

            Try
                With MailNachricht
                    .From = New System.Net.Mail.MailAddress(My.Settings.email_username(My.Settings.mandant_position), My.Settings.email_absende_name(My.Settings.mandant_position))
                    .BodyEncoding = System.Text.Encoding.UTF8
                    .To.Add(strKundenemail)
                    .Subject = strBetreff
                    .IsBodyHtml = True  'My.Settings.email_isthtml
                    .Body = strContent
                End With

            Catch ex As Exception
                strErrorKunden &= ex.Message & vbCrLf

            End Try

            MailNachricht.Attachments.Clear()


            'Dim userState As String = "message " + strKundenemail
            If bTestModus = True Then
                SmtpObj.Send(MailNachricht)
            Else
                Try
                    SmtpObj.Send(MailNachricht)
                Catch ex As Exception
                    If ex.Message.IndexOf("Fehler bei der Transaktion. Die Serverantwort war 5.7.0") >= 0 Then
                        MessageBox.Show("E-Mail Limitierung entdeckt." & vbCrLf & vbCrLf & ex.Message, "Mailserver Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        frmMain.bAbort_senden = True
                    Else
                        strErrorKunden &= ex.Message & vbCrLf
                    End If

                End Try
            End If



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
