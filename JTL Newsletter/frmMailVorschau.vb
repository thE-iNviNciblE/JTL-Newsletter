Public Class frmMailVorschau
    Public iSelectedIndex As Integer = 0
    Public lvwKunde As ListView

    Private Sub frmMailVorschau_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setPreview()
    End Sub

    Private Function setPreview() As Boolean
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
            strSendContent = clsMail.getTemplate(strNewsletterVorlage, lvwKunde.Items(iSelectedIndex))

            strSavePath = Application.StartupPath & "\tmp.html"
            My.Computer.FileSystem.WriteAllText(strSavePath, strSendContent, False)

            WebBrowser1.Navigate("file://" & strSavePath)

            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Function
End Class