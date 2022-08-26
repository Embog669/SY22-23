Public Class Form1
    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        Dim Amount As Decimal
        Decimal.TryParse(AmtTextBox.Text, Amount)
        NameTextBox.Clear()
        CCTextBox.Clear()
        ExpTextBox.Clear()
        ZipTextBox.Clear()
        AmtTextBox.Clear()
        PictureBoxcheck.BringToFront()
        thankyoulabel.BringToFront()
        Dim fee As Decimal
        fee = Amount * 0.03
        FeeTextBox.Text = fee.ToString("C2")
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

End Class
