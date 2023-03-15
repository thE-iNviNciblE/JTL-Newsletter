Imports System.Data
Imports System.Data.SqlClient

Public Class clsDatenbank
    Public strConnectionString As String
    Public strConnectionString_eazybusiness As String = ""

    Public iKID As Integer = -1

    '##########################################################
    '# >> Verbindung aufbauen + Connection String 
    '##########################################################
    Public Function getDBConnect(ByVal strConnection As String, Optional bEazybusiness As Boolean = False) As Boolean
        Dim sqlConn As New SqlConnection(strConnection)

        Try

            If strConnection.IndexOf("eazybusiness") > 0 Then
                bEazybusiness = True
                strConnectionString = strConnection
            End If


            sqlConn.Open()
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
            MessageBox.Show(ex.Message, "Fehler bei Verbindung getDBConnect()", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("Fehler bei setConnectionString: " & ex.Message, "setConnectionString()", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return "0"
        End Try
    End Function
    '##########################################################
    '# >> Existiert der Mandant welcher eingelesen wird
    '##########################################################
    Public Function chkMandantExists(strMandant_db As String) As Boolean
        Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
        Try
            sqlConn.Open()
            Dim sqlComm As New SqlCommand("USE " & strMandant_db, sqlConn)
            sqlComm.ExecuteNonQuery()
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
    Public Function chkMandantPosition(strMandantDBName As String) As Integer
        Try
            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            Dim iCount As Byte = 0
            sqlConn.Open()

            Dim sqlComm As New SqlCommand("SELECT * FROM tMandant WHERE cDB='" & strMandantDBName & "' ORDER BY cNAME ASC", sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            While r.Read()
                If chkMandantExists(r("cdb").ToString) = True Then
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
            MessageBox.Show(ex.Message, "Fehler bei chkMandantPosition abrufen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function
    '##########################################################
    '# >> setMandantbyCombobox
    '# Mandanten in Combobox einlesen
    '##########################################################
    Public Function setMandantbyCombobox(ByVal cmbMandant As ComboBox, ByVal bAllDBs As Boolean) As Boolean
        Try
            Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
            sqlConn.Open()

            '# Combobox löschen 
            cmbMandant.Items.Clear()
            Dim sqlComm As New SqlCommand("SELECT * FROM tMandant ORDER BY cNAME ASC", sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            While r.Read()
                '# Prüfen ob Datenbank überhaupt angelegt ist 
                If chkMandantExists(r("cDB").ToString) = True Then
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
            MessageBox.Show(ex.Message, "Fehler beim JTL Mandant abrufen getMandant()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    '##########################################################
    '# >> getMandantbyName
    '# Mandant DB Name einlesen
    '# Returns DB-Name
    '##########################################################
    Public Function getMandantDatabaseByMandantName(strMandantName As String) As String
        Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
        Try

            Dim strDBName As String = ""

            sqlConn.Open()
            '# Datenbank einlesen 
            Dim sqlComm As New SqlCommand("SELECT * FROM tMandant WHERE cName='" & strMandantName & "'", sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            While r.Read()
                Dim lvwItem As New ListViewItem
                strDBName = r("cDB").ToString
            End While

            sqlConn.Close()
            Return strDBName
        Catch ex As Exception
            MessageBox.Show(ex.Message, "getMandantbyName()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    '##########################################################
    '# >> getMandantbyDBName
    '# Mandant DB Name einlesen
    '# Returns Profil-Name
    '##########################################################
    Public Function getMandantbyDBName(strMandantDB As String) As String
        Dim sqlConn As New SqlConnection(strConnectionString_eazybusiness)
        Try

            Dim strMandantName As String = ""

            sqlConn.Open()
            '# Datenbank einlesen 
            Dim sqlComm As New SqlCommand("SELECT * FROM tMandant WHERE cDB='" & strMandantDB & "'", sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            While r.Read()
                Dim lvwItem As New ListViewItem
                strMandantName = r("cName").ToString
            End While

            sqlConn.Close()
            Return strMandantName
        Catch ex As Exception
            MessageBox.Show(ex.Message, "getMandantbyDBName()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '###########################################################
    '#  >> getJTLKundenData_Where
    '###########################################################
    Public Function getJTLKundenData_Where(optNewsletterAbschicken As RadioButton, optNewsletterVerschickt As RadioButton, optAngemeldet As RadioButton, optAbgemeldet As RadioButton) As String
        Dim strWhere As String = ""
        Try
            If optAngemeldet.Checked = False And optAbgemeldet.Checked = False Then
                If optNewsletterAbschicken.Checked = False Then
                    strWhere = " AND illixi_newsletter.sended = 'Y'"
                Else
                    strWhere = " AND illixi_newsletter.sended = 'N' AND illixi_newsletter.getnewsletter = 'Y'"
                End If
            Else
                If optAngemeldet.Checked = True Then
                    strWhere = " AND illixi_newsletter.getnewsletter = 'Y'"
                Else
                    strWhere = " AND illixi_newsletter.getnewsletter = 'N'"
                End If
            End If
            Return strWhere
        Catch ex As Exception
            MessageBox.Show("Es gab einen Fehler: " & ex.Message, "Fehler in getJTLKundenData_Where", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "-1"
        End Try
    End Function
    '##########################################################
    '# >> Kundendaten einlesen
    '##########################################################
    Public Function getJTLKundenData_send(ByVal lvwJTLKunden As ListView, ByVal strWhere As String) As Boolean
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            sqlConn.Open()
            lvwJTLKunden.Items.Clear()

            Dim sqlComm As New SqlCommand("SELECT * FROM tKunde JOIN illixi_newsletter ON tKunde.kKunde = illixi_newsletter.kunde_id  WHERE tKunde.cEmail !=''" & strWhere, sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            While r.Read()
                Dim lvwItem As New ListViewItem
                lvwItem.Text = r("kKunde").ToString
                lvwItem.SubItems.Add(r("cVorname").ToString)
                lvwItem.SubItems.Add(r("cName").ToString)
                lvwItem.SubItems.Add(r("cOrt").ToString)
                lvwItem.SubItems.Add(r("cEMail").ToString)
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

                lvwJTLKunden.Items.Add(lvwItem)
            End While

            sqlConn.Close()
            Return True
        Catch ex As Exception
            If ex.Message.IndexOf("illixi_newsletter") > 0 Then
                If MessageBox.Show("Datenbanktabelle illixi_newsletter fehlt, möchten Sie diese jetzt installlieren?", "getJTLKundenData_send", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim frmDBSetting As New frmDatenbankEinstellungen
                    frmDBSetting.ShowDialog()
                End If
            Else
                MessageBox.Show(ex.Message, "Fehler bei getJTLKundenData_send", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return False
        End Try
    End Function

    '##########################################################
    '# >> Kundendaten einlesen
    '##########################################################
    Public Function getJTLKundenData(ByVal lvwJTLKunden As ListView) As Boolean
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Dim strWhere As String = ""
            sqlConn.Open()
            lvwJTLKunden.Items.Clear()


            Dim sqlComm As New SqlCommand("SELECT * FROM tKunde WHERE cEmail !=''", sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            While r.Read()
                Dim lvwItem As New ListViewItem
                lvwItem.Text = r("kKunde").ToString
                lvwItem.SubItems.Add(r("cVorname").ToString)
                lvwItem.SubItems.Add(r("cName").ToString)
                lvwItem.SubItems.Add(r("cOrt").ToString)
                lvwItem.SubItems.Add(r("cEMail").ToString)
                lvwItem.SubItems.Add(r("cFirma").ToString)
                lvwItem.SubItems.Add(r("cKundenNr").ToString)
                lvwItem.SubItems.Add(r("cStrasse").ToString)
                lvwItem.SubItems.Add(r("cLand").ToString)
                lvwJTLKunden.Items.Add(lvwItem)
            End While

            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim JTL Kunden abrufen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    '##########################################################
    '# >> Kunde Existiert in Temptabelle
    '##########################################################
    Public Function chkJTLKundeExists(ByVal strKID As String) As Boolean
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            sqlConn.Open()


            Dim sqlComm As New SqlCommand("SELECT * FROM illixi_newsletter WHERE kunde_id =" & strKID, sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            While r.Read()
                sqlConn.Close()
                Return True
            End While

            sqlConn.Close()
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '####################################################################
    '# >> Maximale ID ermitteln
    '####################################################################
    Public Function getJTLID_MAX(ByVal strTabelle As String, ByVal strSpalte As String) As Integer
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            sqlConn.Open()
            Dim strData As String = ""
            Dim iNr As Integer = 0
            Dim sqlComm As New SqlCommand("SELECT max(" & strSpalte & ") as max FROM " & strTabelle, sqlConn)
            Dim r As SqlDataReader = sqlComm.ExecuteReader()

            While r.Read()
                strData = r("max").ToString
                If strData = "" Then
                    strData = 0
                End If
            End While

            iNr = CInt(strData) + 1
            sqlConn.Close()
            Return iNr

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim Abrufen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    '####################################################################
    '# >> In TMP Tabelle einfügen 
    '####################################################################
    Public Function setJTLKundeTMP_new(ByVal lvwItem As ListViewItem) As Boolean
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            sqlConn.Open()

            Dim strQuery As String = ""

            strQuery = "INSERT INTO illixi_newsletter(id,kunde_id,sended,getnewsletter) VALUES("
            strQuery &= getJTLID_MAX("illixi_newsletter", "id") & ","
            strQuery &= "'" & lvwItem.Text & "',"
            strQuery &= "'N',"
            strQuery &= "'Y')"

            Dim sqlComm As New SqlCommand(strQuery, sqlConn)
            sqlComm.ExecuteNonQuery()
            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '####################################################################
    '# >> setJTLKundeUpdateSended
    '# Auf verschickt stellen  
    '####################################################################
    Public Function setJTLKundeUpdateSended(ByVal lvwitem As ListViewItem) As Boolean
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            sqlConn.Open()

            Dim strQuery As String = ""

            strQuery = "UPDATE illixi_newsletter SET sended='Y' WHERE kunde_id=" & lvwitem.Text

            Dim sqlComm As New SqlCommand(strQuery, sqlConn)
            sqlComm.ExecuteNonQuery()
            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '####################################################################
    '# >> Neue Newsletter Aktion 
    '####################################################################
    Public Function setNewsletterNew() As Boolean
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            sqlConn.Open()

            Dim strQuery As String = ""

            strQuery = "UPDATE illixi_newsletter SET sended='N'"

            Dim sqlComm As New SqlCommand(strQuery, sqlConn)
            sqlComm.ExecuteNonQuery()
            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    '####################################################################
    '# >> Neue Newsletter Aktion 
    '####################################################################
    Public Function setNewsletterAbmeldung(ByVal strKID As String) As Boolean
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            sqlConn.Open()

            Dim strQuery As String = ""

            strQuery = "UPDATE illixi_newsletter SET getnewsletter='N' WHERE kunde_id='" & strKID & "'"

            Dim sqlComm As New SqlCommand(strQuery, sqlConn)
            sqlComm.ExecuteNonQuery()
            sqlConn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim JTL Kunden prüfen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    '####################################################################
    '# >> chkInstallTableExists
    '# Überprüft ob eine Tabelle exisitert
    '# returns 1 OK / -1 unbekannter FEHLER / Name der fehlenden Tabelle
    '####################################################################
    Public Function chkInstallTableExists(strFilename As String) As String
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Dim strDataFile As String = ""
            Dim strDataFile_split() As String
            sqlConn.Open()

            Dim strQuery As String = ""

            '# Datei einlesen 

            strDataFile = My.Computer.FileSystem.ReadAllText(strFilename)
            strDataFile_split = strDataFile.Split(vbCrLf)

            '# Alle Tabellen durchgehen 
            For i As Byte = 0 To strDataFile_split.Length - 1
                strQuery = "SELECT *  FROM " & strDataFile_split(i)
                Try
                    Dim sqlComm As New SqlCommand(strQuery, sqlConn)
                    sqlComm.ExecuteNonQuery()
                    sqlConn.Close()
                Catch ex As Exception
                    '# Fehler bei der Tabelle übergeben 
                    Return strDataFile_split(i)
                End Try
            Next
            Return "1"
        Catch ex As Exception
            MessageBox.Show("Fehler bei chkInstallTablesExists()" & ex.Message, "chkInstallTableExists()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "-1"
        End Try
    End Function
    '####################################################################
    '# >> setInstallUpdateByDatabase
    '# Neue Tabellen installieren, z.B. wenn neuer Mandant angelegt 
    '# wird in den Datenbankeinstellungen
    '####################################################################
    Public Function setInstallUpdateByDatabase(strFileName As String, strMandant_db As String) As Boolean

        Dim strContent As String = My.Computer.FileSystem.ReadAllText(strFileName)
        Dim strContent_split() As String = strContent.Split(vbCrLf)
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            sqlConn.Open()

            For i As Integer = 0 To strContent_split.Length - 1
                Try
                    Dim strQuery As String = ""
                    strQuery = "USE " & strMandant_db & vbCrLf & strContent_split(i)
                    Dim sqlComm As New SqlCommand(strQuery, sqlConn)
                    sqlComm.ExecuteNonQuery()
                Catch ex As SqlException
                    MessageBox.Show("Zeile: " & i & " " & ex.Message, "SQL Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Next

            sqlConn.Close()
            Return True
        Catch ex As Exception
            '# 0: In der Datenbank ist bereits ein Objekt mit dem Namen 'illixi_newsletter' vorhanden.

            MessageBox.Show(ex.Message, "Fehler beim Hinzufügen der neuen Datenbank Tabelle", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    '####################################################################
    '# >> setInstallUpdateAllMandant
    '# Installieren des Updates für alle Mandanten
    '####################################################################
    Public Function setInstallUpdateAllMandant(strFileName As String, cmbMandanten As ComboBox) As Boolean
        Dim strMandant_db As String = ""
        Try
            If IO.File.Exists(strFileName) = True Then
                For i As Integer = 0 To cmbMandanten.Items.Count - 1
                    strMandant_db = getMandantDatabaseByMandantName(cmbMandanten.Items(i))
                    If setInstallUpdateByDatabase(strFileName, strMandant_db) = True Then
                        My.Settings.first_start = False
                        My.Settings.Save()
                    Else
                        MessageBox.Show("Datenbanktabelle illixi_newsletter konnte nicht angelegt werden", "Datenbank: Installation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Next

                Dim strFileNameNew() As String = strFileName.Split("\")
                Dim strFileNameNew_complete As String = Application.StartupPath & "\SQL\" & strFileNameNew(strFileNameNew.Length - 1).Replace(".", " " & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & " " & Date.Now.Hour & "-" & Date.Now.Minute & "-" & Date.Now.Second & ".")
                IO.File.Move(strFileName, strFileNameNew_complete)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Fehler bei setInstallUpdateAllMandant: " & ex.Message, "setInstallUpdateAllMandant()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
    '######################################################################
    '# >> setNewsletterAbAnmelden
    '# Newsletter anmelden abmelden Kontextmenü
    '######################################################################
    Public Function setNewsletterAbAnmelden(iKundenID As Integer, bAbmelden As Boolean) As Boolean
        Try
            Dim sqlConn As New SqlConnection(strConnectionString)
            Dim strQuery As String = ""
            Dim strAbmelden As String = ""
            sqlConn.Open()

            If bAbmelden = True Then
                strAbmelden = "N"
            Else
                strAbmelden = "Y"
            End If

            strQuery = "UPDATE illixi_newsletter SET getnewsletter='" & strAbmelden & "' WHERE kunde_id='" & iKundenID & "'"

            Dim sqlComm As New SqlCommand(strQuery, sqlConn)
            sqlComm.ExecuteNonQuery()
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler bei setNewsletterAbAnmelden", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
End Class
