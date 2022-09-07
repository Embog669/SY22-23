Public Class Form1
    Dim Num1 As Decimal
    Dim Num2 As Decimal
    Dim Mem As Decimal
    Dim Oper As String

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button9.Click, ButtonDecimal.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Button0.Click
        DisplayTextBox.Text = DisplayTextBox.Text + sender.text
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayTextBox.Text = Nothing
    End Sub

    Private Sub PlusButton_Click(sender As Object, e As EventArgs) Handles PlusButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        Oper = "+"
        DisplayTextBox.Clear()
    End Sub

    Private Sub EqualsButton_Click(sender As Object, e As EventArgs) Handles EqualsButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num2)
        If Oper = "-" Then
            DisplayTextBox.Text = Num1 - Num2
        End If
        If Oper = "+" Then
            DisplayTextBox.Text = Num1 + Num2
        End If
        If Oper = "/" Then
            DisplayTextBox.Text = Num1 / Num2
        End If
        If Oper = "*" Then
            DisplayTextBox.Text = Num1 * Num2
        End If
    End Sub

    Private Sub MinusButton_Click(sender As Object, e As EventArgs) Handles MinusButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        Oper = "-"
        DisplayTextBox.Clear()
    End Sub

    Private Sub DividButton_Click(sender As Object, e As EventArgs) Handles DividButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        Oper = "/"
        DisplayTextBox.Clear()
    End Sub

    Private Sub MultiplyButton_Click(sender As Object, e As EventArgs) Handles MultiplyButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        Oper = "*"
        DisplayTextBox.Clear()
    End Sub

    Private Sub SquareRootButton_Click(sender As Object, e As EventArgs) Handles SquareRootButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        DisplayTextBox.Text = Math.Sqrt(Num1)
    End Sub

    Private Sub SinButton_Click(sender As Object, e As EventArgs) Handles SinButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        DisplayTextBox.Text = Math.Sin(Num1)
    End Sub

    Private Sub CosButton_Click(sender As Object, e As EventArgs) Handles CosButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        DisplayTextBox.Text = Math.Cos(Num1)
    End Sub

    Private Sub TanButton_Click(sender As Object, e As EventArgs) Handles TanButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Num1)
        DisplayTextBox.Text = Math.Tan(Num1)
    End Sub

    Private Sub PiButton_Click(sender As Object, e As EventArgs) Handles PiButton.Click
        DisplayTextBox.Text = Math.PI
    End Sub

    Private Sub MemoryPlusButton_Click(sender As Object, e As EventArgs) Handles MemoryPlusButton.Click
        Decimal.TryParse(DisplayTextBox.Text, Mem)
    End Sub

    Private Sub MemoryButton_Click(sender As Object, e As EventArgs) Handles MemoryButton.Click
        DisplayTextBox.Text = Mem
    End Sub

    Private Sub MemoryClearButton_Click(sender As Object, e As EventArgs) Handles MemoryClearButton.Click
        Mem = 0
    End Sub
End Class