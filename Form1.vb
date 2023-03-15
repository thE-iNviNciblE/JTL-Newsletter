Public Class frmMailLogbuch

    Public strErrorLog As String
    Private Sub frmMailLogbuch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = strErrorLog

    End Sub
End Class