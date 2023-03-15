Public Class frmNewsletterTemplateHilfe
    Public bBetreff As Boolean = False
    Private Sub frmNewsletterTemplateHilfe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If bBetreff = True Then
            Label1.Text = "Betreff Variablen"
            TextBox10.Visible = False
            Dim dSize As Drawing.Size
            dSize.Height = 329
            dSize.Width = 275
            Me.Size = dSize
        End If
    End Sub

    Private Sub txtVorname_Click(sender As Object, e As System.EventArgs) Handles txtVorname.Click
        txtVorname.SelectAll()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As System.EventArgs) Handles TextBox1.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As System.EventArgs) Handles TextBox2.Click
        TextBox2.SelectAll()
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As System.EventArgs) Handles TextBox3.Click
        TextBox3.SelectAll()
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As System.EventArgs) Handles TextBox4.Click
        TextBox4.SelectAll()
    End Sub

    Private Sub TextBox5_Click(sender As Object, e As System.EventArgs) Handles TextBox5.Click
        TextBox5.SelectAll()
    End Sub

    Private Sub TextBox6_Click(sender As Object, e As System.EventArgs) Handles TextBox6.Click
        TextBox6.SelectAll()
    End Sub

    Private Sub TextBox7_Click(sender As Object, e As System.EventArgs) Handles TextBox7.Click
        TextBox7.SelectAll()
    End Sub

    Private Sub TextBox8_Click(sender As Object, e As System.EventArgs) Handles TextBox8.Click
        TextBox8.SelectAll()
    End Sub

    Private Sub TextBox9_Click(sender As Object, e As System.EventArgs) Handles TextBox9.Click
        TextBox9.SelectAll()
    End Sub

    Private Sub TextBox10_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox10.TextChanged
        TextBox10.SelectAll()
    End Sub
End Class