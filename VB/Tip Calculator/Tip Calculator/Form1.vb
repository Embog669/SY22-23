Public Class Form1
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Bill As Decimal
        Decimal.TryParse(BillTextBox.Text, Bill)
        Dim Total As Decimal
        Total = Bill * 1.08
        TotalTextBox.Text = Total.ToString("C2")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim Bill As Decimal
        Decimal.TryParse(BillTextBox.Text, Bill)
        Dim Total As Decimal
        Total = Bill * 1.15
        TotalTextBox.Text = Total.ToString("C2")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim Bill As Decimal
        Decimal.TryParse(BillTextBox.Text, Bill)
        Dim Total As Decimal
        Total = Bill * 1.2
        TotalTextBox.Text = Total.ToString("C2")
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        Dim Bill As Decimal
        Decimal.TryParse(BillTextBox.Text, Bill)
        Dim Total As Decimal
        Total = Bill * 1.5
        TotalTextBox.Text = Total.ToString("C2")
    End Sub

    Private Sub Button100_Click(sender As Object, e As EventArgs) Handles Button100.Click
        Dim Bill As Decimal
        Decimal.TryParse(BillTextBox.Text, Bill)
        Dim Total As Decimal
        Total = Bill * 2
        TotalTextBox.Text = Total.ToString("C2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
