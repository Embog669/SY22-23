Public Class Form5
    Dim mini As Integer
    Dim microphone As Integer
    Dim snake As Integer
    Dim sword As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Integer.TryParse(TextBox1.Text, mini)
        Integer.TryParse(TextBox2.Text, microphone)
        Integer.TryParse(TextBox3.Text, sword)
        Integer.TryParse(TextBox4.Text, snake)
        Toys = mini + microphone + sword + snake
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Integer.TryParse(TextBox1.Text, mini)
        Integer.TryParse(TextBox2.Text, microphone)
        Integer.TryParse(TextBox3.Text, sword)
        Integer.TryParse(TextBox4.Text, snake)
        Toys = mini + microphone + sword + snake
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Integer.TryParse(TextBox1.Text, mini)
        Integer.TryParse(TextBox2.Text, microphone)
        Integer.TryParse(TextBox3.Text, sword)
        Integer.TryParse(TextBox4.Text, snake)
        Toys = mini + microphone + sword + snake
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Integer.TryParse(TextBox1.Text, mini)
        Integer.TryParse(TextBox2.Text, microphone)
        Integer.TryParse(TextBox3.Text, sword)
        Integer.TryParse(TextBox4.Text, snake)
        Toys = mini + microphone + sword + snake
    End Sub
End Class