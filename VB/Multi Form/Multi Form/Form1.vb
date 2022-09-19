Public Class Form1
    Dim n As Integer
    Dim d As Decimal
    Dim s As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Integer.TryParse(aTextBox.Text, n)
        Decimal.TryParse(bTextBox.Text, d)
        Single.TryParse(cTextBox.Text, s)
        Label1.Text = n
        Label2.Text = d
        Label3.Text = s
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.ShowDialog()
        Label3.Text = c
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.ShowDialog()
        Label2.Text = w
    End Sub
End Class
