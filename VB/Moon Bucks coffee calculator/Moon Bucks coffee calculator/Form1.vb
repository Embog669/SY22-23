Public Class Form1
    Dim Regular As Decimal
    Dim Decalf As Decimal
    Dim Pounds As Decimal
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = Nothing
        AdressTextBox.Text = Nothing
        CityTextBox.Text = Nothing
        StateTextbox.Text = Nothing
        ZipTextBox.Text = Nothing
        RegularTextBox.Text = Nothing
        DecalfTextBox.Text = Nothing
        PoundsTextBox.Text = Nothing
        PriceTextBox.Text = Nothing
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        PriceTextBox.Clear()
        PriceTextBox.Text = Pounds * 4.99
    End Sub

    Private Sub RegularTextBox_TextChanged(sender As Object, e As EventArgs) Handles RegularTextBox.TextChanged
        Decimal.TryParse(RegularTextBox.Text, Regular)
        RegularTextBox.Text = Regular
        Decimal.TryParse(PoundsTextBox.Text, Pounds)
        PoundsTextBox.Text = Regular + Decalf
    End Sub

    Private Sub DecalfTextBox_TextChanged(sender As Object, e As EventArgs) Handles DecalfTextBox.TextChanged
        Decimal.TryParse(DecalfTextBox.Text, Decalf)
        DecalfTextBox.Text = Decalf
        Decimal.TryParse(PoundsTextBox.Text, Pounds)
        PoundsTextBox.Text = Regular + Decalf
    End Sub
End Class
