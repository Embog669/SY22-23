Public Class Form1
    Dim Red As Decimal
    Dim Blue As Decimal
    Dim Green As Decimal
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub RedTextBox_TextChanged(sender As Object, e As EventArgs) Handles RedTextBox.TextChanged
        Integer.TryParse(RedTextBox.Text, Red)
        Button1.BackColor =
           Color.FromArgb(Red, Green, Blue)
    End Sub

    Private Sub BlueTextBox_TextChanged(sender As Object, e As EventArgs) Handles BlueTextBox.TextChanged
        Integer.TryParse(BlueTextBox.Text, Blue)
        Button1.BackColor =
           Color.FromArgb(Red, Green, Blue)
    End Sub

    Private Sub GreenTextBox_TextChanged(sender As Object, e As EventArgs) Handles GreenTextBox.TextChanged
        Integer.TryParse(GreenTextBox.Text, Green)
        Button1.BackColor =
           Color.FromArgb(Red, Green, Blue)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
