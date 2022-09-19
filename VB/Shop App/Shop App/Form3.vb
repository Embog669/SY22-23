Public Class Form3
    Dim cup As Integer
    Dim popper As Integer
    Dim arch As Integer
    Dim metal As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Integer.TryParse(TextBox1.Text, arch)
        Integer.TryParse(TextBox2.Text, popper)
        Integer.TryParse(TextBox3.Text, cup)
        Integer.TryParse(TextBox4.Text, metal)
        party = arch + popper + cup + metal
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Integer.TryParse(TextBox1.Text, arch)
        Integer.TryParse(TextBox2.Text, popper)
        Integer.TryParse(TextBox3.Text, cup)
        Integer.TryParse(TextBox4.Text, metal)
        party = arch + popper + cup + metal
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Integer.TryParse(TextBox1.Text, arch)
        Integer.TryParse(TextBox2.Text, popper)
        Integer.TryParse(TextBox3.Text, cup)
        Integer.TryParse(TextBox4.Text, metal)
        party = arch + popper + cup + metal
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Integer.TryParse(TextBox1.Text, arch)
        Integer.TryParse(TextBox2.Text, popper)
        Integer.TryParse(TextBox3.Text, cup)
        Integer.TryParse(TextBox4.Text, metal)
        party = arch + popper + cup + metal
    End Sub
End Class