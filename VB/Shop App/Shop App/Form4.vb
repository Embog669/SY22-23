Public Class Form4
    Dim Round As Integer
    Dim skeleton As Integer
    Dim Rectangle As Integer
    Dim Box As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Integer.TryParse(TextBox1.Text, skeleton)
        Integer.TryParse(TextBox2.Text, Round)
        Integer.TryParse(TextBox3.Text, Box)
        Integer.TryParse(TextBox4.Text, Rectangle)
        containers = Round + skeleton + Rectangle + Box
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Integer.TryParse(TextBox1.Text, skeleton)
        Integer.TryParse(TextBox2.Text, Round)
        Integer.TryParse(TextBox3.Text, Box)
        Integer.TryParse(TextBox4.Text, Rectangle)
        containers = Round + skeleton + Rectangle + Box
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Integer.TryParse(TextBox1.Text, skeleton)
        Integer.TryParse(TextBox2.Text, Round)
        Integer.TryParse(TextBox3.Text, Box)
        Integer.TryParse(TextBox4.Text, Rectangle)
        containers = Round + skeleton + Rectangle + Box


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Integer.TryParse(TextBox1.Text, skeleton)
        Integer.TryParse(TextBox2.Text, Round)
        Integer.TryParse(TextBox3.Text, Box)
        Integer.TryParse(TextBox4.Text, Rectangle)
        containers = Round + skeleton + Rectangle + Box
    End Sub
End Class