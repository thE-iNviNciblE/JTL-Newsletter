Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.IO

Public Class clsDatenbank
    Public strConnectionString As String
    Public strConnectionString_eazybusiness As String = ""

    Public iKID As Integer = -1

    '##########################################################
    '# >> Verbindung aufbauen + Connection String 
    '##########################################################
    Public Async Function getDBConnect(ByVal strConnection As String, Optional bEazybusiness As Boolean = False) As Threading.Tasks.Task(Of Boolean)
        Dim sqlConn As New SqlConnection(strConnection)

        Try

            If strConnection.IndexOf("eazybusiness") > 0 Then
                bEazybusiness = True
                strConnectionString = strConnection
            End If


            Await sqlConn.OpenAsync()
            'If bEazybusiness = False And strConnection.IndexOf("eazybusiness") < 0 Then
            If bEazybusiness = False Then
                strConnectionString = strConnection
            Else
                strConnectionString_eazybusiness = strConnection
                'strConnectionString = strConnection
            End If

            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler bei Verbindung getDBConnect()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '##########################################################
    '# >> setConnectionString
    '# Datenbankverbindungsstring setzen 
    '##########################################################
    Public Function setConnectionString(strConnection As String, bMainDB As Boolean) As String
        Try
            If bMainDB = True Then
                strConnectionString_eazybusiness = strConnection
            Else
                strConnectionString = strConnection
            End If
            Return "1"
        Catch ex As Exception
            MessageBox.Show("Fehler bei setConnectionString: " & ex.Message & vbCrLf & ex.StackTrace, "setConnectionString()", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return "0"
        End Try
    End Function
    '##########################################################
    '# >> Existiert der Mandant welcher eingelesen wird
    '##########################################################
    Public Async Function chkMandantExists(strMandant_db As String) As Threading.Tasks.Task(Of Boolean)
        Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
        Try
            Await sqlConn.OpenAsync()
            Dim sqlComm As New SqlCommand("USE " & strMandant_db, sqlConn)
            Await sqlComm.ExecuteNonQueryAsync()
            sqlConn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    '##########################################################
    '# >> chkMandantPosition
    '# Mandanten Position innerhalb der tMandant bestimmen
    '##########################################################
    Public Async Function chkMandantPosition(strMandantDBName As String) As Threading.Tasks.Task(Of Integer)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            Dim iCount As Byte = 0
            Await sqlConn.OpenAsync()

            Dim sqlComm As New SqlCommand("SELECT * FROM tMandant WHERE cDB='" & strMandantDBName & "' ORDER BY cNAME ASC", sqlConn)
            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

            While Await r.ReadAsync()
                If Await chkMandantExists(r("cdb").ToString) = True Then
                    If strMandantDBName = r("cDB").ToString Then
                        My.Settings.mandant_position = r("kMandant").ToString
                        My.Settings.Save()
                        Exit While
                    End If
                End If
                iCount += 1
            End While

            Return My.Settings.mandant_position
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler bei chkMandantPosition abrufen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function
    '##########################################################
    '# >> setMandantbyCombobox
    '# Mandanten in Combobox einlesen
    '##########################################################
    Public Async Function setMandantbyCombobox(ByVal cmbMandant As ComboBox, ByVal bAllDBs As Boolean) As Threading.Tasks.Task(Of Boolean)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            Await sqlConn.OpenAsync()

            '# Combobox löschen 
            cmbMandant.Items.Clear()
            Dim sqlComm As New SqlCommand("SELECT * FROM tMandant ORDER BY cNAME ASC", sqlConn)
            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

            While r.Read()
                '# Prüfen ob Datenbank überhaupt angelegt ist 
                If Await chkMandantExists(r("cDB").ToString) = True Then
                    Dim lvwItem As New ListViewItem

                    '# Nur Verfügbare Datenbanken eintragen, wenn Setting gefunden wurde und bAllDbs nicht True ist 
                    If bAllDBs = True Then
                        cmbMandant.Items.Add(r("cName").ToString)
                    Else
                        If frmMain.getMySettingsPositionByDatabase(r("cDB").ToString) >= 0 Then
                            cmbMandant.Items.Add(r("cName").ToString)
                        End If
                    End If

                End If
            End While

            If cmbMandant.Items.Count > 0 Then
                If cmbMandant.Items.Count - 1 > 0 Then
                    For i As Byte = 0 To cmbMandant.Items.Count - 1
                        If My.Settings.mandant_letzter_name = cmbMandant.Items(i) Then
                            cmbMandant.SelectedIndex = i
                            My.Settings.mandant_letzter_name = cmbMandant.Text
                            Exit For
                        End If
                    Next
                Else
                    cmbMandant.SelectedIndex = 0
                    My.Settings.mandant_letzter_name = cmbMandant.Text
                End If

            End If
            My.Settings.Save()
            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim JTL Mandant abrufen getMandant()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Async Function getKundenKategorie(cmb As ComboBox) As Threading.Tasks.Task(Of Boolean)
        Try

            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            Await sqlConn.OpenAsync()

            '# Combobox löschen 
            cmb.Items.Clear()
            Dim sqlComm As New SqlCommand("SELECT * FROM tKundenKategorie ORDER BY cName ASC", sqlConn)
            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

            cmb.Items.Add("Alle Kundenkategorien")

            While Await r.ReadAsync()

                cmb.Items.Add(r("cName").ToString & " | " & Await getKundenkategorie_count(r("kKundenKategorie").ToString))

            End While
            sqlConn.Close()
            Return True

        Catch ex As Exception

            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim JTL Mandant abrufen getMandant()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Async Function getKundenSprache_count(strSprache_id As String) As Threading.Tasks.Task(Of Integer)
        Try

            Dim iAnzahl As Integer = 0
            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            Await sqlConn.OpenAsync()

            Dim sqlComm As New SqlCommand("SELECT count(kKunde) as anzahl FROM tkunde WHERE kSprache='" & strSprache_id & "'", sqlConn)
            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

            While Await r.ReadAsync()

                iAnzahl = CInt(r("anzahl").ToString)

            End While
            sqlConn.Close()
            Return iAnzahl
        Catch ex As Exception

            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler bei getKundenSprache_count()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try

    End Function
    Public Async Function getKundenkategorie_count(strKundenkategorie_id As String) As Threading.Tasks.Task(Of Integer)
        Try

            Dim iAnzahl As Integer = 0
            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            Await sqlConn.OpenAsync()

            Dim sqlComm As New SqlCommand("SELECT count(kKundenKategorie) as anzahl FROM tkunde WHERE kKundenKategorie='" & strKundenkategorie_id & "'", sqlConn)
            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

            While Await r.ReadAsync()

                iAnzahl = CInt(r("anzahl").ToString)

            End While
            sqlConn.Close()
            Return iAnzahl
        Catch ex As Exception

            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler bei getKundenSprache_count()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try

    End Function

    Public Async Function getKundenGruppe_count(strKundengruppe_id As String) As Threading.Tasks.Task(Of Integer)
        Try

            Dim iAnzahl As Integer = 0
            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            Await sqlConn.OpenAsync()

            Dim sqlComm As New SqlCommand("SELECT count(kKunde) as anzahl FROM tkunde WHERE kKundenGruppe='" & strKundengruppe_id & "'", sqlConn)
            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

            While Await r.ReadAsync()

                iAnzahl = CInt(r("anzahl").ToString)

            End While
            sqlConn.Close()
            Return iAnzahl
        Catch ex As Exception

            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler bei getKundenSprache_count()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try

    End Function
    Public Async Function getKundenOptionCount() As Threading.Tasks.Task(Of String)

        Try
            Dim strWhere As String = ""

            If frmMain.chkNichtAmazon.Checked = True Then
                strWhere = strWhere & " AND tAdresse.cMail NOT LIKE '%marketplace.amazon.%' AND tAdresse.cMail  != ''"
            Else
                strWhere = strWhere & " AND tAdresse.cMail LIKE '%marketplace.amazon.%' AND tAdresse.cMail != ''"
            End If

            If Not My.Settings.jtlshop_kunde_kategorie = "" Then
                strWhere = strWhere & " AND tkunde.kKundenKategorie = '" & My.Settings.jtlshop_kunde_kategorie & "'"
            End If

            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            Await sqlConn.OpenAsync()

            Dim sqlComm As New SqlCommand("SELECT count(tkunde.kKunde) as anzahl FROM tkunde LEFT JOIN cubss_newsletter ON tkunde.kKunde = cubss_newsletter.kunde_id LEFT JOIN tAdresse ON tAdresse.kKunde = tkunde.kKunde WHERE cubss_newsletter.sended = 'Y'" & strWhere, sqlConn)
            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

            While Await r.ReadAsync()
                frmMain.optNewsletterVerschickt.Text = "Verschickt (" & r("anzahl").ToString & ")"
            End While
            sqlConn.Close()



            Dim sqlConn2 As New SqlConnection(strConnectionString_eazybusiness)
            Await sqlConn2.OpenAsync()

            Dim sqlComm2 As New SqlCommand("SELECT count(tkunde.kKunde) as anzahl FROM tkunde LEFT JOIN cubss_newsletter ON tkunde.kKunde = cubss_newsletter.kunde_id LEFT JOIN tAdresse ON tAdresse.kKunde = tkunde.kKunde WHERE cubss_newsletter.getnewsletter = 'Y'" & strWhere, sqlConn2)
            Dim r2 As SqlDataReader = Await sqlComm2.ExecuteReaderAsync()

            While Await r2.ReadAsync()
                frmMain.optNewsletterAbschicken.Text = "&Abschick bereit (" & r2("anzahl").ToString & ")"
            End While
            sqlConn2.Close()


            Dim sqlConn3 As New SqlConnection(strConnectionString_eazybusiness)
            Await sqlConn3.OpenAsync()

            Dim sqlComm3 As New SqlCommand("SELECT count(tkunde.kKunde) as anzahl FROM tkunde LEFT JOIN cubss_newsletter ON tkunde.kKunde = cubss_newsletter.kunde_id LEFT JOIN tAdresse ON tAdresse.kKunde = tkunde.kKunde WHERE cubss_newsletter.getnewsletter = 'N'" & strWhere, sqlConn3)
            Dim r3 As SqlDataReader = Await sqlComm3.ExecuteReaderAsync()

            While Await r3.ReadAsync()
                frmMain.optAbgemeldet.Text = "&Abgemeldet (" & r3("anzahl").ToString & ")"
            End While
            sqlConn3.Close()


            Dim sqlConn4 As New SqlConnection(strConnectionString_eazybusiness)
            Await sqlConn4.OpenAsync()

            Dim sqlComm4 As New SqlCommand("SELECT count(tkunde.kKunde) as anzahl FROM tkunde LEFT JOIN cubss_newsletter ON tkunde.kKunde = cubss_newsletter.kunde_id LEFT JOIN tAdresse ON tAdresse.kKunde = tkunde.kKunde WHERE cubss_newsletter.sended = 'N'" & strWhere, sqlConn4)
            Dim r4 As SqlDataReader = Await sqlComm4.ExecuteReaderAsync()

            While Await r4.ReadAsync()
                frmMain.optAngemeldet.Text = "&Angemeldet (" & r4("anzahl").ToString & ")"
            End While
            sqlConn4.Close()

            Dim sqlConn5 As New SqlConnection(strConnectionString_eazybusiness)
            Await sqlConn5.OpenAsync()

            Dim sqlComm5 As New SqlCommand("SELECT count(tkunde.kKunde) as anzahl FROM tkunde LEFT JOIN cubss_newsletter ON tkunde.kKunde = cubss_newsletter.kunde_id LEFT JOIN tAdresse ON tAdresse.kKunde = tkunde.kKunde WHERE tkunde.cNewsletter = 'Y'" & strWhere, sqlConn5)
            Dim r5 As SqlDataReader = Await sqlComm5.ExecuteReaderAsync()

            While Await r5.ReadAsync()
                frmMain.optNewsletterYES.Text = "&Newsletter Wawi (Ja) (" & r5("anzahl").ToString & ")"
            End While
            sqlConn5.Close()

            Return strWhere
        Catch ex As Exception
            MessageBox.Show("Es gab einen Fehler: " & ex.Message & vbCrLf & ex.StackTrace, "Fehler in getJTLKundenData_Where", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "-1"
        End Try

    End Function
    Public Async Function getKundenGruppe(cmb As ComboBox) As Threading.Tasks.Task(Of Boolean)
        Try

            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            Await sqlConn.OpenAsync()

            '# Combobox löschen 
            cmb.Items.Clear()
            Dim sqlComm As New SqlCommand("SELECT * FROM tKundenGruppe ORDER BY kKundenGruppe ASC", sqlConn)
            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

            cmb.Items.Add("Alle Kundengruppen")

            While Await r.ReadAsync()

                cmb.Items.Add(r("cName").ToString & " | " & Await getKundenGruppe_count(r("kKundenGruppe").ToString) & " | " & Math.Round(CDbl(r("fRabatt")), 2) & "%")

            End While
            sqlConn.Close()

            Return True

        Catch ex As Exception

            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler bei getKundenGruppe()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Async Function getKundenSprache(cmb As ComboBox) As Threading.Tasks.Task(Of Boolean)
        Try

            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            Await sqlConn.OpenAsync()

            '# Combobox löschen 
            cmb.Items.Clear()
            Dim sqlComm As New SqlCommand("SELECT * FROM tSpracheUsed ORDER BY kSprache ASC", sqlConn)
            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

            cmb.Items.Add("Alle Sprachen")

            While Await r.ReadAsync()

                cmb.Items.Add(r("cNameDeu").ToString & " | " & Await getKundenSprache_count(r("kSprache").ToString))

            End While
            sqlConn.Close()

            Return True

        Catch ex As Exception

            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler bei getKundenSprache()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    '##########################################################
    '# >> getMandantbyName
    '# Mandant DB Name einlesen
    '# Returns DB-Name
    '##########################################################
    Public Async Function getMandantDatabaseByMandantName(strMandantName As String) As Threading.Tasks.Task(Of String)
        Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
        Try

            Dim strDBName As String = ""

            Await sqlConn.OpenAsync()
            '# Datenbank einlesen 
            Dim sqlComm As New SqlCommand("SELECT * FROM tMandant WHERE cName='" & strMandantName & "'", sqlConn)
            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

            While Await r.ReadAsync()
                Dim lvwItem As New ListViewItem
                strDBName = r("cDB").ToString
            End While

            sqlConn.Close()
            Return strDBName
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "getMandantbyName()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    '##########################################################
    '# >> getMandantbyDBName
    '# Mandant DB Name einlesen
    '# Returns Profil-Name
    '##########################################################
    Public Async Function getMandantbyDBName(strMandantDB As String) As Threading.Tasks.Task(Of String)
        Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
        Try

            Dim strMandantName As String = ""

            Await sqlConn.OpenAsync()
            '# Datenbank einlesen 
            Dim sqlComm As New SqlCommand("SELECT * FROM  tMandant WHERE cDB='" & strMandantDB & "'", sqlConn)
            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

            While Await r.ReadAsync()
                Dim lvwItem As New ListViewItem
                strMandantName = r("cName").ToString
            End While

            sqlConn.Close()
            Return strMandantName
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "getMandantbyDBName()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '###########################################################
    '#  >> getJTLKundenData_Where
    '###########################################################
    Public Async Function getJTLKundenData_Where(optNewsletterAbschicken As RadioButton, optNewsletterVerschickt As RadioButton, optAngemeldet As RadioButton, optAbgemeldet As RadioButton, chkNichtAmazon As CheckBox) As Threading.Tasks.Task(Of String)
        Dim strWhere As String = ""
        Try
            '# Nur JTL Wawi Newsleter  = Y
            'If frmMain.optNewsletterYES.Checked = True Then
            '    strWhere = " AND  tkunde.cNewsletter = 'Y'"
            'Else

            '    If optAngemeldet.Checked = False And optAbgemeldet.Checked = False Then
            '        If optNewsletterAbschicken.Checked = False Then
            '            strWhere = " AND cubss_newsletter.sended = 'Y'"
            '        Else
            '            strWhere = " AND cubss_newsletter.sended = 'N' AND cubss_newsletter.getnewsletter = 'Y'"
            '        End If
            '    Else
            '        If optAngemeldet.Checked = True Then
            '            strWhere = " AND cubss_newsletter.getnewsletter = 'Y'"
            '        Else
            '            strWhere = " AND cubss_newsletter.getnewsletter = 'N'"
            '        End If
            '    End If

            'End If

            If frmMain.optNewsletterYES.Checked = True Then
                strWhere = "   tkunde.cNewsletter = 'Y'"
            Else

                If optAngemeldet.Checked = False And optAbgemeldet.Checked = False Then
                    If optNewsletterAbschicken.Checked = False Then
                        strWhere = "  cubss_newsletter.sended = 'Y'"
                    Else
                        strWhere = "  cubss_newsletter.sended = 'N' AND cubss_newsletter.getnewsletter = 'Y'"
                    End If
                Else
                    If optAngemeldet.Checked = True Then
                        strWhere = "  cubss_newsletter.getnewsletter = 'Y'"
                    Else
                        strWhere = "  cubss_newsletter.getnewsletter = 'N'"
                    End If
                End If

            End If

            If chkNichtAmazon.Checked = True Then
                strWhere = strWhere & " AND tAdresse.cMail NOT LIKE '%marketplace.amazon.%'"
            Else
                strWhere = strWhere & " AND tAdresse.cMail LIKE '%marketplace.amazon.%'"
            End If

            If Not My.Settings.jtlshop_kunde_kategorie = "" Then
                strWhere = strWhere & " AND kKundenKategorie = '" & My.Settings.jtlshop_kunde_kategorie & "'"
            End If

            Return strWhere
        Catch ex As Exception
            MessageBox.Show("Es gab einen Fehler: " & ex.Message & vbCrLf & ex.StackTrace, "Fehler in getJTLKundenData_Where", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "-1"
        End Try
    End Function
    Public Async Function getJTLKundenData_bestellsumme(strkKunde As String) As Task(Of Double)

        Dim sqlConn2 As New SqlConnection(strConnectionString)
        Await sqlConn2.OpenAsync()
        Dim sqlComm2 As New SqlCommand("SELECT sum(fVKPreis) as fVKPreis_agg  FROM tBestellung JOIN tbestellpos ON tBestellung.kBestellung = tbestellpos.tBestellung_kBestellung WHERE tBestellung.tKunde_kKunde='" & strkKunde & "'", sqlConn2)
        Dim r2 As SqlDataReader = Await sqlComm2.ExecuteReaderAsync()

        Dim dblSum As Double = 0

        While Await r2.ReadAsync()
            Try
                dblSum = CDbl(r2("fVKPreis_agg"))
            Catch ex As Exception

            End Try

        End While

        sqlConn2.Close()

        Return dblSum

    End Function
    '##########################################################
    '# >> Kundendaten einlesen
    '##########################################################
    Public Async Function getJTLKundenData(ByVal lvwJTLKunden As ListView, ByVal strWhere As String, ByVal frmMain As frmMain) As Threading.Tasks.Task(Of Boolean)
        Try

            '#############################################
            '# >> Kundensprache
            '#############################################

            Dim strSprachen_id As String = ""
            Dim sqlSprachen_alle As String = ""
            Dim strSprachen_input() As String = frmMain.cmbSprache.Text.Split("|")

            If Not frmMain.cmbSprache.Text = "Alle Sprachen" Then
                Dim con_kunden_sprachen As New SqlConnection(strConnectionString)
                Await con_kunden_sprachen.OpenAsync()
                Dim cmd_kunden_sprachen As New SqlCommand("SELECT kSprache FROM  tSpracheUsed WHERE cNameDeu='" & strSprachen_input(0).Trim & "'", con_kunden_sprachen)
                Dim read_kunden_sprache As SqlDataReader = Await cmd_kunden_sprachen.ExecuteReaderAsync()

                While Await read_kunden_sprache.ReadAsync()
                    strSprachen_id = read_kunden_sprache("kSprache").ToString
                End While

                sqlSprachen_alle = " AND tKunde.kSprache='" & strSprachen_id & "' "
                con_kunden_sprachen.Close()
            End If

            '#############################################
            '# >> Kundengruppe
            '#############################################

            Dim strKundengruppe_id As String = ""
            Dim sqlKundengruppe_alle As String = ""
            Dim strKundengruppe_input() As String = frmMain.cmbKundengruppe.Text.Split("|")

            If Not frmMain.cmbKundengruppe.Text = "Alle Kundengruppen" Then
                Dim con_kunden_gruppen As New SqlConnection(strConnectionString)
                Await con_kunden_gruppen.OpenAsync()
                Dim cmd_kunden_gruppen As New SqlCommand("SELECT kKundenGruppe FROM  tKundenGruppe WHERE cName='" & strKundengruppe_input(0).Trim & "'", con_kunden_gruppen)
                Dim read_kunden_gruppen As SqlDataReader = Await cmd_kunden_gruppen.ExecuteReaderAsync()

                While Await read_kunden_gruppen.ReadAsync()
                    strKundengruppe_id = read_kunden_gruppen("kKundenGruppe").ToString
                End While

                sqlKundengruppe_alle = " AND tKunde.kKundenGruppe='" & strKundengruppe_id & "' "
                con_kunden_gruppen.Close()
            End If

            '#############################################
            '# >> Kundenkategorie
            '#############################################

            Dim strKundenkategorie_id As String = ""
            Dim sqlKundenkategorie_alle As String = ""
            Dim strKundenkategorie_input() As String = frmMain.cmbKundenKategorie.Text.Split("|")

            If Not frmMain.cmbKundenKategorie.Text = "Alle Kundenkategorien" Then
                Dim con_kunden_kategorie As New SqlConnection(strConnectionString)
                Await con_kunden_kategorie.OpenAsync()
                Dim cmd_kunden_kategorie As New SqlCommand("SELECT kKundenKategorie FROM  tKundenKategorie WHERE cName='" & strKundenkategorie_input(0).Trim & "'", con_kunden_kategorie)
                Dim read_kunden_gruppen As SqlDataReader = Await cmd_kunden_kategorie.ExecuteReaderAsync()

                While Await read_kunden_gruppen.ReadAsync()
                    strKundenkategorie_id = read_kunden_gruppen("kKundenKategorie").ToString
                End While

                sqlKundengruppe_alle = " AND tKunde.kKundenKategorie='" & strKundenkategorie_id & "' "
                con_kunden_kategorie.Close()
            End If

            '#############################################
            '# >> Kunden zählen
            '#############################################

            Dim con_count_kunden As New SqlConnection(strConnectionString)
            Await con_count_kunden.OpenAsync()

            Dim sqlComm_count_kunden As New SqlCommand("SELECT count(*) as anzahl FROM cubss_newsletter LEFT JOIN tKunde ON tKunde.kKunde = cubss_newsletter.kunde_id LEFT JOIN tAdresse ON tKunde.kKunde = tAdresse.kKunde  WHERE " & strWhere & sqlSprachen_alle & sqlKundengruppe_alle & sqlKundengruppe_alle, con_count_kunden)

            Dim rKunden_count As SqlDataReader = Await sqlComm_count_kunden.ExecuteReaderAsync()
            Dim iMax As Integer = 0
            While Await rKunden_count.ReadAsync()
                iMax = Convert.ToInt32(rKunden_count("anzahl").ToString)
            End While
            con_count_kunden.Close()

            Dim iCount As Integer = 0
            frmMain.tss_main_text.Text = iCount & " / " & iMax
            frmMain.masterpgr.Value = iCount
            frmMain.masterpgr.Maximum = iMax
            frmMain.masterpgr.Visible = True

            Dim sqlConn As New SqlConnection(strConnectionString)
            Await sqlConn.OpenAsync()
            lvwJTLKunden.Items.Clear()

            'SELECT * FROM  tAdresse LEFT JOIN tKunde ON tKunde.kKunde = tAdresse.kKunde LEFT JOIN cubss_newsletter ON tKunde.kKunde = cubss_newsletter.kunde_id  WHERE tAdresse.cmail !='' AND tAdresse.cMail NOT LIKE '%@marketplace.amazon.%'
            Dim strQuery As String = "SELECT *,tAdresse.cMail as Email FROM cubss_newsletter LEFT JOIN tKunde ON tKunde.kKunde = cubss_newsletter.kunde_id LEFT JOIN tAdresse ON tKunde.kKunde = tAdresse.kKunde  WHERE " & strWhere & " AND (tAdresse.cmail !='' AND tAdresse.cMail NOT LIKE '%@marketplace.amazon.%') " & sqlSprachen_alle & sqlKundengruppe_alle & " ORDER BY tAdresse.cMail ASC"
            Dim sqlComm As New SqlCommand(strQuery, sqlConn)

            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()
            Dim tmpKunde_id As String = ""
            While Await r.ReadAsync()

                If r("Email").ToString = tmpKunde_id Then

                Else
                    Dim lvwItem As New ListViewItem
                    lvwItem.Text = r("kKunde").ToString
                    lvwItem.SubItems.Add(r("cVorname").ToString)
                    lvwItem.SubItems.Add(r("cName").ToString)
                    lvwItem.SubItems.Add(r("cOrt").ToString)
                    lvwItem.SubItems.Add(r("Email").ToString)
                    lvwItem.SubItems.Add(r("cFirma").ToString)
                    lvwItem.SubItems.Add(r("cKundenNr").ToString)
                    lvwItem.SubItems.Add(r("cStrasse").ToString)
                    lvwItem.SubItems.Add(r("cLand").ToString)
                    lvwItem.SubItems.Add(r("cAnrede").ToString)
                    lvwItem.SubItems.Add(r("cPLZ").ToString)

                    If r("getNewsletter").ToString = "Y" Then
                        lvwItem.SubItems.Add("Ja")
                    Else
                        lvwItem.SubItems.Add("Nein")
                    End If

                    lvwItem.SubItems.Add(r("dErstellt").ToString)
                    Dim dblUmsatz = Math.Round(Await getJTLKundenData_bestellsumme(r("kKunde").ToString), 2)
                    lvwItem.SubItems.Add(CStr(dblUmsatz))

                    Try
                        Dim datum1 As Date = Date.Parse(CType(r("dErstellt"), String))
                        Dim datum2 As Date = Now
                        ' Anzahl der Tage berechnen
                        Dim days As Long = DateDiff(DateInterval.Day, datum1, datum2)
                        lvwItem.SubItems.Add(CStr(days))

                        lvwItem.SubItems.Add(CStr(Math.Round(dblUmsatz / days, 2)))

                    Catch ex As Exception
                        lvwItem.SubItems.Add("NaN")
                        lvwItem.SubItems.Add("NaN")
                    End Try

                    lvwJTLKunden.Items.Add(lvwItem)

                    If bAbbruch = True Then
                        bAbbruch = False
                        Exit Function
                    End If

                    iCount = iCount + 1

                End If

                frmMain.masterpgr.Value = iCount
                frmMain.tss_main_text.Text = iCount & " / " & iMax
                Application.DoEvents()
                tmpKunde_id = r("Email").ToString


            End While
            ' lvwJTLKunden.EndUpdate()
            frmMain.tss_main_text.Text = CType(lvwJTLKunden.Items.Count - 1, String)

            sqlConn.Close()
            Return True
        Catch ex As Exception
            lvwJTLKunden.EndUpdate()
            If ex.Message.IndexOf("cubss_newsletter") > 0 Then
                If MessageBox.Show("Datenbanktabelle cubss_newsletter fehlt, möchten Sie diese jetzt installlieren?" & vbCrLf & ex.Message, "getJTLKundenData_send", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim frmDBSetting As New frmDatenbankEinstellungen
                    frmDBSetting.ShowDialog()
                End If
            Else
                MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler bei getJTLKundenData", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return False
        End Try
    End Function

    '##########################################################
    '# >> Kundendaten einlesen
    '##########################################################
    Public Async Function getSYNC_JTL_WAWI_KUNDEN(ByVal lvwJTLKunden As ListView, ByVal frmStatus As frmJTLSync) As Threading.Tasks.Task(Of Boolean)
        Try
            'Dim sqlConn As New SqlConnection(strConnectionString)
            Dim strWhere As String = ""
            'Await sqlConn.OpenAsync()
            lvwJTLKunden.Items.Clear()

            'SELECT 
            'count(tKunde.kKunde) As anzahl,
            'tAdresse.cName,
            'tAdresse.cOrt

            'From tAdresse Left outer Join tKunde On tKunde.kKunde = tAdresse.kKunde Group By tAdresse.cName, tAdresse.cOrt Order By cName DESC '# Einträge zählen

            frmStatus.pgrStatus.Value = 0
            frmStatus.pgrStatus.Visible = True

            Dim strQuery_count As String = "SELECT 
count(tAdresse.kKunde) as anzahl
FROM tAdresse right Join tKunde ON tKunde.kKunde = tAdresse.kKunde WHERE (tAdresse.cMail IS NOT NULL AND tAdresse.cMail !='' AND tAdresse.cMail NOT LIKE '%@marketplace.amazon.%')"

            Dim sqlConn_group_by_count As New SqlConnection(strConnectionString)
            Await sqlConn_group_by_count.OpenAsync()

            Dim sqlComm_group_by_count As New SqlCommand(strQuery_count, sqlConn_group_by_count)
            Dim rGroup_by_count As SqlDataReader = Await sqlComm_group_by_count.ExecuteReaderAsync()

            Dim iMax As Int64


            While Await rGroup_by_count.ReadAsync()
                iMax += CLng(rGroup_by_count("anzahl").ToString)
            End While

            sqlConn_group_by_count.Close()

            '  MsgBox(iMax)
            Dim strQuery As String = "SELECT 
tKunde.kKunde,*
FROM tAdresse right Join tKunde ON tKunde.kKunde = tAdresse.kKunde WHERE (tAdresse.cMail IS NOT NULL AND tAdresse.cMail !='' AND tAdresse.cMail NOT LIKE '%@marketplace.amazon.%') ORDER BY tKunde.kKunde ASC"

            Dim sqlConn_group_by As New SqlConnection(strConnectionString)
            Await sqlConn_group_by.OpenAsync()

            Dim sqlComm_group_by As New SqlCommand(strQuery, sqlConn_group_by)
            Dim rGroup_by As SqlDataReader = Await sqlComm_group_by.ExecuteReaderAsync()


            Dim iCount As Integer = 0
            Dim iCount_neu As Integer = 0
            Dim iCount_exist As Integer = 0
            frmStatus.lblJTLNewsletterKundenExist.Text = iCount_exist & ": Kunde existiert"
            frmStatus.lblNeueJTLNewsletterKunden.Text = iCount_exist & ": neuer Newsletter Kunde"
            Dim strKunde_id As String = ""
            frmStatus.pgrStatus.Maximum = CInt(iMax)
            While Await rGroup_by.ReadAsync()

                If frmStatus.bStopSync = True Then
                    Exit While
                End If

                If strKunde_id = rGroup_by("kKunde").ToString Then

                Else

                    strKunde_id = rGroup_by("kKunde").ToString

                    If frmStatus.bStopSync = True Then
                        Exit While
                    End If

                    '# Prüfung ob Kunde in TMP Existiert
                    If CBool(My.Settings.bKomplettSync(My.Settings.mandant_position)) = False Then

                        If Await frmMain.clsDB.ChkJTLKundeExistByKunden_id(rGroup_by("kKunde").ToString) = False Then

                            frmStatus.lblStatus.Text = iCount + 1 & " / " & iMax & " | Füge hinzu: " & rGroup_by("cKundenNr").ToString & " / " & rGroup_by("cVorname").ToString & " " & rGroup_by("cName").ToString & " | " & rGroup_by("cOrt").ToString & " / " & rGroup_by("cFirma").ToString

                            ' Datensatz in Listview anlegen
                            Dim lvwItem As New ListViewItem
                            lvwItem.Text = rGroup_by("kKunde").ToString
                            lvwItem.SubItems.Add(rGroup_by("cVorname").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cName").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cOrt").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cMail").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cFirma").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cKundenNr").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cStrasse").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cLand").ToString)
                            lvwJTLKunden.Items.Add(lvwItem)

                            ' JTL Newsletter Kunden anzulegen
                            Await frmMain.clsDB.setJTLKundeTMP_new(lvwJTLKunden.Items(lvwJTLKunden.Items.Count - 1))
                            iCount_neu += 1

                            frmStatus.lblNeueJTLNewsletterKunden.Text = iCount_neu & ": neuer Newsletter Kunde"

                        Else

                            frmStatus.lblStatus.Text = iCount + 1 & " / " & iMax & " | Existiert bereits: " & rGroup_by("cKundenNr").ToString & " / " & rGroup_by("cVorname").ToString & " " & rGroup_by("cName").ToString & " | " & rGroup_by("cOrt").ToString & " / " & rGroup_by("cFirma").ToString
                            Exit While

                        End If

                    Else

                        frmStatus.lblStatus.Text = iCount + 1 & " / " & iMax & " | Existiert bereits: " & rGroup_by("cKundenNr").ToString & " / " & rGroup_by("cVorname").ToString & " " & rGroup_by("cName").ToString & " | " & rGroup_by("cOrt").ToString & " / " & rGroup_by("cFirma").ToString

                        ' Existiert der JTL Wawi Kunde schon?
                        If Await frmMain.clsDB.ChkJTLKundeExistByKunden_id(rGroup_by("kKunde").ToString) = False Then

                            frmStatus.lblStatus.Text = iCount + 1 & " / " & iMax & " | Füge hinzu: " & rGroup_by("cKundenNr").ToString & " / " & rGroup_by("cVorname").ToString & " " & rGroup_by("cName").ToString & " | " & rGroup_by("cOrt").ToString & " / " & rGroup_by("cFirma").ToString

                            ' Datensatz in Listview anlegen
                            Dim lvwItem As New ListViewItem
                            lvwItem.Text = rGroup_by("kKunde").ToString
                            lvwItem.SubItems.Add(rGroup_by("cVorname").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cName").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cOrt").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cMail").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cFirma").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cKundenNr").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cStrasse").ToString)
                            lvwItem.SubItems.Add(rGroup_by("cLand").ToString)
                            lvwJTLKunden.Items.Add(lvwItem)

                            'Neuen JTL Wawi Kunden hinzufügen
                            Await frmMain.clsDB.setJTLKundeTMP_new(lvwJTLKunden.Items(lvwJTLKunden.Items.Count - 1))
                            iCount_neu += 1

                            frmStatus.lblNeueJTLNewsletterKunden.Text = iCount_neu & ": neuer Newsletter Kunde"
                        Else
                            iCount_exist += 1

                            frmStatus.lblJTLNewsletterKundenExist.Text = iCount_exist & ": Kunde existiert"
                        End If
                    End If

                End If

                Try
                    frmStatus.pgrStatus.Value = iCount

                Catch ex As Exception

                End Try

                '  Await sqlConn.OpenAsync()

                '# 1.3.x tKunde zu 1.4.x tinetkunde
                'Dim sqlComm As New SqlCommand("SELECT tAdresse.cName,tAdresse.cOrt,tAdresse.kAdresse as kAdresse_adresse, tAdresse.*,tKunde.* FROM tAdresse LEFT JOIN tKunde ON tKunde.kKunde = tAdresse.kKunde WHERE tAdresse.cName ='" & rGroup_by("cName").ToString.Replace("'", "''") & "' AND tAdresse.cOrt='" & rGroup_by("cOrt").ToString.Replace("'", "''") & "' AND tAdresse.cStrasse='" & rGroup_by("cStrasse").ToString.Replace("'", "''") & "'", sqlConn)

                ' MsgBox("SELECT tAdresse.cName,tAdresse.cOrt,tAdresse.kAdresse as kAdresse_adresse, tAdresse.*,tKunde.* FROM tAdresse LEFT JOIN tKunde ON tKunde.kKunde = tAdresse.kKunde WHERE tAdresse.cName ='" & rGroup_by("cName").ToString & "' AND tAdresse.cOrt='" & rGroup_by("cOrt").ToString & "' AND tAdresse.cStrasse='" & rGroup_by("cStrasse").ToString & "'")
                ' Clipboard.SetText("SELECT tAdresse.cName,tAdresse.cOrt,tAdresse.kAdresse as kAdresse_adresse, tAdresse.*,tKunde.* FROM tAdresse LEFT JOIN tKunde ON tKunde.kKunde = tAdresse.kKunde WHERE tAdresse.cName ='" & rGroup_by("cName").ToString & "' AND tAdresse.cOrt='" & rGroup_by("cOrt").ToString & "' AND tAdresse.cStrasse='" & rGroup_by("cStrasse").ToString & "'")

                '  Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()


                '  While Await r.ReadAsync()



                '   End While
                '  sqlConn.Close()
                iCount = iCount + 1
            End While

            sqlConn_group_by.Close()
            'sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim JTL Kunden abrufen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    '##########################################################
    '# >> chkJTLKundeExistByKunden_id
    '##########################################################
    Public Async Function ChkJTLKundeExistByKunden_id(ByVal strKID As String) As Threading.Tasks.Task(Of Boolean)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Await sqlConn.OpenAsync()

            If strKID.Length > 0 Then

                Dim sqlComm As New SqlCommand("SELECT * FROM  cubss_newsletter WHERE kunde_id =" & strKID, sqlConn)
                Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

                While Await r.ReadAsync()
                    sqlConn.Close()
                    Return True
                End While

                sqlConn.Close()

            End If

            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '##########################################################
    '# >> JTLKundeExistByEmail
    '##########################################################
    Public Async Function JTLKundeExistByEmail(ByVal strKID As String) As Threading.Tasks.Task(Of Boolean)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Await sqlConn.OpenAsync()

            If strKID.Length > 0 Then
                Dim sqlComm As New SqlCommand("SELECT * FROM  cubss_newsletter WHERE kunde_id=" & strKID, sqlConn)
                Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

                While Await r.ReadAsync()
                    sqlConn.Close()
                    Return True
                End While

                sqlConn.Close()
                Return False
            End If
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '##########################################################
    '# >> Kunde Existiert in Temptabelle
    '##########################################################
    Public Async Function chkJTLKundeExistByEmail(ByVal strEmail As String) As Threading.Tasks.Task(Of Boolean)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Await sqlConn.OpenAsync()

            If strEmail.Length > 0 Then

                Dim sqlComm As New SqlCommand("SELECT * FROM  tAdresse WHERE cMail='" & strEmail & "'", sqlConn)
                Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

                While Await r.ReadAsync()

                    Dim bOK As Boolean = Await JTLKundeExistByEmail(r("kKunde").ToString)

                    sqlConn.Close()
                    Return bOK
                End While

                sqlConn.Close()

            End If

            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '####################################################################
    '# >> Maximale ID ermitteln
    '####################################################################
    Public Async Function getJTLID_MAX(ByVal strTabelle As String, ByVal strSpalte As String) As Threading.Tasks.Task(Of Integer)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Await sqlConn.OpenAsync()
            Dim strData As String = ""
            Dim iNr As Integer = 0
            Dim sqlComm As New SqlCommand("SELECT max(" & strSpalte & ") as max FROM " & strTabelle, sqlConn)
            Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

            While Await r.ReadAsync()
                strData = r("max").ToString
                If strData = "" Then
                    strData = 0
                End If
            End While

            iNr = CInt(strData) + 1
            sqlConn.Close()
            Return iNr

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim Abrufen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function
    '####################################################################
    '# >> In TMP Tabelle einfügen 
    '####################################################################
    Public Async Function setJTLKundeTMP_newKID(ByVal strEmail As String) As Threading.Tasks.Task(Of Boolean)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Await sqlConn.OpenAsync()

            Dim strQuery As String = ""


            strQuery = "INSERT INTO tkunde(fRabatt,nMahnstopp,nMahnrhythmus,fSkonto,nSkontoInTagen) VALUES("
            strQuery &= "0,0,0,0,0)"


            Dim sqlComm2 As New SqlCommand(strQuery, sqlConn)
            'sqlComm2.Parameters.Add("@bRowversion", SqlDbType.Timestamp).Value = DateTime.Now.ToLongTimeString

            Dim InsertID_tkunde As Integer = CType(Await sqlComm2.ExecuteScalarAsync(), Integer)

            strQuery = "INSERT INTO tAdresse(kAdresse,kKunde,bRowversion) VALUES("
            strQuery &= Await getJTLID_MAX("tAdresse", "kAdresse") & "," & InsertID_tkunde & ")"


            Dim sqlComm3 As New SqlCommand(strQuery, sqlConn)
            sqlComm3.Parameters.Add("@bRowversion", SqlDbType.DateTime2).Value = DateTime.Now
            Dim InsertID_tadresse As Integer = CType(Await sqlComm3.ExecuteScalarAsync(), Integer)


            strQuery = "INSERT INTO cubss_newsletter(id,kunde_id,sended,getnewsletter) VALUES("
            strQuery &= Await getJTLID_MAX("cubss_newsletter", "id") & ","
            strQuery &= "'" & InsertID_tkunde & "',"
            strQuery &= "'N',"
            strQuery &= "'Y')"

            Dim sqlComm As New SqlCommand(strQuery, sqlConn)
            Await sqlComm.ExecuteNonQueryAsync()
            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    '####################################################################
    '# >> In TMP Tabelle einfügen 
    '####################################################################
    Public Async Function setJTLKundeTMP_new(ByVal lvwItem As ListViewItem) As Threading.Tasks.Task(Of Boolean)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Await sqlConn.OpenAsync()

            Dim strQuery As String = ""

            strQuery = "INSERT INTO cubss_newsletter(id,kunde_id,sended,getnewsletter) VALUES("
            strQuery &= Await getJTLID_MAX("cubss_newsletter", "id") & ","
            strQuery &= "'" & lvwItem.Text & "',"
            strQuery &= "'N',"
            strQuery &= "'Y')"

            Dim sqlComm As New SqlCommand(strQuery, sqlConn)
            Await sqlComm.ExecuteNonQueryAsync()
            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '####################################################################
    '# >> setJTLKundeUpdateSended
    '# Auf verschickt stellen  
    '####################################################################
    Public Async Sub setJTLKundeUpdateSended(ByVal lvwitem As ListViewItem)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Await sqlConn.OpenAsync()

            Dim strQuery As String = ""

            strQuery = "UPDATE cubss_newsletter SET sended='Y' WHERE kunde_id=" & lvwitem.Text

            Dim sqlComm As New SqlCommand(strQuery, sqlConn)
            Await sqlComm.ExecuteNonQueryAsync()
            sqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '####################################################################
    '# >> Neue Newsletter Aktion 
    '####################################################################
    Public Async Function setNewsletterNew() As Threading.Tasks.Task(Of Boolean)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Await sqlConn.OpenAsync()

            Dim strQuery As String = ""

            strQuery = "UPDATE cubss_newsletter SET sended='N'"

            Dim sqlComm As New SqlCommand(strQuery, sqlConn)
            Await sqlComm.ExecuteNonQueryAsync()
            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '####################################################################
    '# >> setNewsletterAbmeldung by Kunden_id
    '####################################################################
    Public Async Function setNewsletterAbmeldung(ByVal strKID As String) As Threading.Tasks.Task(Of Boolean)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Await sqlConn.OpenAsync()

            Dim strQuery As String = ""

            strQuery = "UPDATE cubss_newsletter SET getnewsletter='N' WHERE kunde_id='" & strKID & "'"

            Dim sqlComm As New SqlCommand(strQuery, sqlConn)
            Await sqlComm.ExecuteNonQueryAsync()
            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim JTL Wawi Kunden Newsletter abmelden", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '####################################################################
    '# >> setNewsletterAbmeldungByEmail by Email 
    '####################################################################
    Public Async Function setNewsletterAbmeldungByEmail(ByVal strEmail As String) As Threading.Tasks.Task(Of Boolean)
        Try

            If strEmail.ToString.Contains("@") = True Then
                Dim strQuery_update As String = ""
                Dim strQuery_Adresse As String = "SELECT kKunde FROM tAdresse  WHERE cMail='" & strEmail & "'"
                Dim sqlConn_update As New SqlConnection(strConnectionString)
                Dim sqlConn_email As New SqlConnection(strConnectionString)
                Dim sqlComm_update As New SqlCommand
                Await sqlConn_email.OpenAsync()


                Dim sqlComm_email As New SqlCommand(strQuery_Adresse, sqlConn_email)
                sqlComm_email.CommandTimeout = 50

                Dim rAdressse_email As SqlDataReader = Await sqlComm_email.ExecuteReaderAsync()

                While Await rAdressse_email.ReadAsync()

                    If Not sqlConn_update.State = ConnectionState.Open Then
                        Await sqlConn_update.OpenAsync()
                    End If

                    strQuery_update = "UPDATE cubss_newsletter SET getnewsletter='N' WHERE kunde_id='" & rAdressse_email("kKunde").ToString & "'"

                    sqlComm_update.CommandText = strQuery_update
                    sqlComm_update.Connection = sqlConn_update
                    sqlComm_update.CommandTimeout = 50

                    Await sqlComm_update.ExecuteNonQueryAsync()
                    sqlConn_update.Close()
                    'sqlConn_update.ClearAllPools()
                End While
                sqlConn_email.Close()
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Clipboard.SetText(ex.Message)
            Return False
        End Try
    End Function

    '####################################################################
    '# >> chkInstallTableExists
    '# Überprüft ob eine Tabelle exisitert
    '# returns 1 OK / -1 unbekannter FEHLER / Name der fehlenden Tabelle
    '####################################################################
    Public Async Function chkInstallTableExists(strFilename As String) As Threading.Tasks.Task(Of String)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Dim strDataFile As String = ""
            Dim strDataFile_split() As String
            Await sqlConn.OpenAsync()

            Dim strQuery As String = ""

            '# Datei einlesen 

            strDataFile = My.Computer.FileSystem.ReadAllText(strFilename)
            strDataFile_split = strDataFile.Split(vbCrLf)

            '# Alle Tabellen durchgehen 
            For i As Byte = 0 To strDataFile_split.Length - 1
                strQuery = "SELECT *  FROM " & strDataFile_split(i)
                Try
                    Dim sqlComm As New SqlCommand(strQuery, sqlConn)
                    Await sqlComm.ExecuteNonQueryAsync()
                    sqlConn.Close()
                Catch ex As Exception
                    '# Fehler bei der Tabelle übergeben 
                    Return strDataFile_split(i)
                End Try
            Next
            Return "1"
        Catch ex As Exception
            MessageBox.Show("Fehler bei chkInstallTablesExists()" & ex.Message & vbCrLf & ex.StackTrace, "chkInstallTableExists()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "-1"
        End Try
    End Function
    '####################################################################
    '# >> setInstallUpdateByDatabase
    '# Neue Tabellen installieren, z.B. wenn neuer Mandant angelegt 
    '# wird in den Datenbankeinstellungen
    '####################################################################
    Public Async Function setInstallUpdateByDatabase(strFileName As String, strMandant_db As String) As Threading.Tasks.Task(Of Boolean)

        Dim strContent As String = My.Computer.FileSystem.ReadAllText(strFileName)
        Dim strContent_split() As String = strContent.Split(vbCrLf)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Await sqlConn.OpenAsync()

            For i As Integer = 0 To strContent_split.Length - 1
                Try
                    Dim strQuery As String = ""
                    strQuery = "USE " & strMandant_db & vbCrLf & strContent_split(i)
                    Dim sqlComm As New SqlCommand(strQuery, sqlConn)
                    Await sqlComm.ExecuteNonQueryAsync()
                Catch ex As SqlException
                    MessageBox.Show("Zeile: " & i & " " & ex.Message, "SQL Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Next

            sqlConn.Close()
            Return True
        Catch ex As Exception
            '# 0: In der Datenbank ist bereits ein Objekt mit dem Namen 'illixi_newsletter' vorhanden.

            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim Hinzufügen der neuen Datenbank Tabelle", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    '####################################################################
    '# >> setInstallUpdateAllMandant
    '# Installieren des Updates für alle Mandanten
    '####################################################################
    Public Async Function setInstallUpdateAllMandant(strFileName As String, cmbMandanten As ComboBox) As Threading.Tasks.Task(Of Boolean)
        Dim strMandant_db As String = ""
        Try
            If IO.File.Exists(strFileName) = True Then
                For i As Integer = 0 To cmbMandanten.Items.Count - 1
                    strMandant_db = Await getMandantDatabaseByMandantName(cmbMandanten.Items(i))
                    If Await setInstallUpdateByDatabase(strFileName, strMandant_db) = True Then
                        My.Settings.first_start = False
                        My.Settings.Save()
                    Else
                        MessageBox.Show("Datenbanktabelle cubss_newsletter konnte nicht angelegt werden", "Datenbank: Installation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Next

                Dim strFileNameNew() As String = strFileName.Split("\")
                Dim strFileNameNew_complete As String = Application.StartupPath & "\SQL\" & strFileNameNew(strFileNameNew.Length - 1).Replace(".", " " & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & " " & Date.Now.Hour & "-" & Date.Now.Minute & "-" & Date.Now.Second & ".")
                IO.File.Move(strFileName, strFileNameNew_complete)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Fehler bei setInstallUpdateAllMandant: " & ex.Message & vbCrLf & ex.StackTrace, "setInstallUpdateAllMandant()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
    '######################################################################
    '# >> setNewsletterAbAnmelden
    '# Newsletter anmelden abmelden Kontextmenü
    '######################################################################
    Public Async Function setNewsletterAbAnmelden(iKundenID As Integer, bAbmelden As Boolean) As Threading.Tasks.Task(Of Boolean)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Dim strQuery As String = ""
            Dim strAbmelden As String = ""
            Await sqlConn.OpenAsync()

            If bAbmelden = True Then
                strAbmelden = "N"
            Else
                strAbmelden = "Y"
            End If

            strQuery = "UPDATE cubss_newsletter SET getnewsletter='" & strAbmelden & "' WHERE kunde_id='" & iKundenID & "'"

            Dim sqlComm As New SqlCommand(strQuery, sqlConn)
            Await sqlComm.ExecuteNonQueryAsync()
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler bei setNewsletterAbAnmelden", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Async Function getShopProdukts(strProduktList As String) As Threading.Tasks.Task(Of String)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Await sqlConn.OpenAsync()
            Dim strData As String = ""
            Dim strArtikelNr() As String = strProduktList.Split(";")
            Dim iCount As Integer = 0
            Dim iCount_clear As Integer = 1
            Dim strArtikel As String = ""
            ' Alle Produkte durchlaufen


            For iCount = 0 To strArtikelNr.Length - 1

                If strArtikelNr(iCount) = "" Then
                    Exit For
                End If

                Dim strQuery As String = "SELECT * FROM tartikel  WHERE cArtNr='" & strArtikelNr(iCount) & "'"
                If sqlConn.State = ConnectionState.Closed Then
                    sqlConn.Open()
                End If

                Dim sqlComm As New SqlCommand(strQuery, sqlConn)
                Dim r As SqlDataReader = Await sqlComm.ExecuteReaderAsync()

                '                MessageBox.Show(strQuery)

                While Await r.ReadAsync()
                    'cName
                    'fVKBrutto
                    'cPath
                    'http://www.chic-net.de/connector/jtl-shop-connector.php?modus=newsletter&iArtikelID=3168

                    '    MessageBox.Show("gefunden...")

                    Dim client As New WebClient()
                    client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")
                    Try
                        ' Abruf vom JTL Shop Plugin
                        Dim data As Stream = client.OpenRead(My.Settings.jtlshop_connector(My.Settings.mandant_position) & "?modus=newsletter&kArtikel=" & r("kArtikel").ToString)
                        Dim reader2 As New StreamReader(data, System.Text.Encoding.Default)
                        Dim strDataString As String = reader2.ReadToEnd()
                        ' mod_pagespeed fix
                        Dim iBis = strDataString.IndexOf("<script pagespeed")
                        If Not iBis = -1 Then
                            strArtikel = strDataString.Substring(0, iBis)
                        Else
                            strArtikel = strDataString
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler beim Datenabrufen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try

                    strData &= strArtikel

                    'If iCount_clear = 2 Then
                    '    strData &= "<div style=""clear:both""></div>"
                    '    iCount_clear = 1
                    'Else
                    '    iCount_clear += 1
                    'End If

                    Exit While

                End While
                sqlConn.Close()
            Next
            strData &= "<div style=""clear:both""></div>"

            strData = strData.Replace("ä", "&auml;")
            strData = strData.Replace("ö", "&ouml;")
            strData = strData.Replace("ü", "&uuml;")
            strData = strData.Replace("Ä", "&Auml;")
            strData = strData.Replace("Ö", "&Ouml;")
            strData = strData.Replace("Ü", "&Uuml;")
            strData = strData.Replace("ß", "&szlig;")

            Return strData

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Fehler bei getShopProdukts", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
End Class
