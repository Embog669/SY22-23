Public Class Form1
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click
        Dim Amount As Decimal
        Decimal.TryParse(AmtTextBox.Text, Amount)
        Dim Japan As Decimal
        Dim UK As Decimal
        Dim Mexico As Decimal
        Dim China As Decimal
        Dim Germany As Decimal
        Dim Korea As Decimal
        Japan = Amount * 136.75
        JapanTextBox.Text = Japan.ToString("C2")
        UK = Amount * 0.84
        UKTextBox.Text = UK.ToString("C2")
        Mexico = Amount * 19.93
        MexicoTextBox.Text = Mexico.ToString("C2")
        China = Amount * 6.85
        ChinaTextBox.Text = China.ToString("C2")
        Germany = Amount * 1
        GermanyTextBox.Text = Germany.ToString("C2")
        Korea = Amount * 1334.38
        KoreaTextBox.Text = Korea.ToString("C2")
    End Sub
End Class
