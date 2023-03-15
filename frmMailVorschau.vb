Imports CefSharp.WinForms

Public Class frmMailVorschau
    Public iSelectedIndex As Integer = 0
    Public lvwKunde As ListView

    Private Sub frmMailVorschau_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setPreview()
    End Sub

    Private Async Function setPreview() As Threading.Tasks.Task(Of Boolean)
        Try
            Dim iCount As Integer = 0
            Dim strNewsletterVorlage As String = ""
            Dim clsMail As New clsMail
            Dim strSendContent As String = ""
            Dim strSavePath As String = ""

            If IO.File.Exists(My.Settings.template_pfad(My.Settings.mandant_position)) = False Then
                MessageBox.Show("Datei '" & My.Settings.template_pfad(My.Settings.mandant_position) & "' nicht gefunden!", "Datei nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Function
            End If
            strNewsletterVorlage = My.Computer.FileSystem.ReadAllText(My.Settings.template_pfad(My.Settings.mandant_position))

            ' Template variablen füllen
            strSendContent = Await clsMail.getTemplate(strNewsletterVorlage, frmMain.lvwJTLKunden.Items(iCount), frmMain.txtSektion1_shopartikelbySKU.Text, frmMain.txtSektion1_header_bild.Text, frmMain.txtSektion1_beschreibung.Text, frmMain.txtSektion2_artikelliste.Text, frmMain.txtSektion2_bild.Text, frmMain.txtSektion2_beschreibung.Text, frmMain.txtSektion3_artikelliste.Text, frmMain.txtSektion3_bild.Text, frmMain.txtSektion3_beschreibung.Text, frmMain.txtSektion4_artikelliste.Text, frmMain.txtSektion5_artikelliste.Text, frmMain.txtSektion4_bild.Text, frmMain.txtSektion5_bild.Text, frmMain.txtSektion4_beschreibung.Text, frmMain.txtSektion5_beschreibung.Text, frmMain.txtBildLink.Text, frmMain.txtBildLink2.Text, frmMain.txtBildLink3.Text, frmMain.txtBildlink4.Text, frmMain.txtBildlink5.Text)

            strSavePath = Application.StartupPath & "\tmp.html"
            My.Computer.FileSystem.WriteAllText(strSavePath, strSendContent, False)
            ' Dim url As 
            ' ChromiumWebBrowser1.Load("file://" & strSavePath)
            Dim browser As New ChromiumWebBrowser("file://" & strSavePath)
            'ChromiumWebBrowser1.Load()
            browser.Load("file://" & strSavePath)

            Me.Controls.Add(browser)

            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Function
End Class