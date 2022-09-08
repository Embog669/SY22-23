﻿Public Class Form1
    Dim Num1 As Decimal
    Dim Num2 As Decimal
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
        PriceTextBox.Text = Pounds * 4.99
    End Sub

    Private Sub RegularTextBox_TextChanged(sender As Object, e As EventArgs) Handles RegularTextBox.TextChanged
        Decimal.TryParse(RegularTextBox.Text, Num1)
        RegularTextBox.Text = Num1
        Decimal.TryParse(PoundsTextBox.Text, Pounds)
        PoundsTextBox.Text = Num1 + Num2
    End Sub

    Private Sub DecalfTextBox_TextChanged(sender As Object, e As EventArgs) Handles DecalfTextBox.TextChanged
        Decimal.TryParse(DecalfTextBox.Text, Num2)
        DecalfTextBox.Text = Num2
        Decimal.TryParse(PoundsTextBox.Text, Pounds)
        PoundsTextBox.Text = Num1 + Num2
    End Sub
End Class
