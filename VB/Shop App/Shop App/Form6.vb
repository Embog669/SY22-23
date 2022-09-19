Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox6.Text = Food + party + Toys + containers
        TextBox4.Text = Food + party + Toys + containers
    End Sub
End Class