Public Class Form2
    Dim root As Integer
    Dim wel As Integer
    Dim fruit As Integer
    Dim pizza As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Integer.TryParse(TextBox3.Text, pizza)
        Integer.TryParse(TextBox2.Text, root)
        Integer.TryParse(TextBox1.Text, fruit)
        Integer.TryParse(TextBox4.Text, wel)
        Food = wel + fruit + root + pizza
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Integer.TryParse(TextBox3.Text, pizza)
        Integer.TryParse(TextBox2.Text, root)
        Integer.TryParse(TextBox1.Text, fruit)
        Integer.TryParse(TextBox4.Text, wel)
        Food = wel + fruit + root + pizza
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Integer.TryParse(TextBox3.Text, pizza)
        Integer.TryParse(TextBox2.Text, root)
        Integer.TryParse(TextBox1.Text, fruit)
        Integer.TryParse(TextBox4.Text, wel)
        Food = wel + fruit + root + pizza
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Integer.TryParse(TextBox3.Text, pizza)
        Integer.TryParse(TextBox2.Text, root)
        Integer.TryParse(TextBox1.Text, fruit)
        Integer.TryParse(TextBox4.Text, wel)
        Food = wel + fruit + root + pizza
    End Sub
End Class