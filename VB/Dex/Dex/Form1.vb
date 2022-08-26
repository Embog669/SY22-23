Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Charizardbutton.Click
        DisplayPictureBox.Image = CharizardPictureBox.Image
        Namelabel.Text = "Charizard"
        Typelabel.Text = "Fire and Dragon"
        Genlabel.Text = "1"
        Locationlabel.Text = "Kanto"
    End Sub

    Private Sub Venusuar_Click(sender As Object, e As EventArgs) Handles Venusuar.Click
        DisplayPictureBox.Image = VenusuarPictureBox.Image
        Namelabel.Text = "Venusaur"
        Typelabel.Text = "Grass and Poison"
        Genlabel.Text = "1"
        Locationlabel.Text = "Kanto"
    End Sub

    Private Sub Blastoise_Click(sender As Object, e As EventArgs) Handles Blastoise.Click
        DisplayPictureBox.Image = BlastoiesPictureBox.Image
        Namelabel.Text = "Blastoies"
        Typelabel.Text = "Water"
        Genlabel.Text = "1"
        Locationlabel.Text = "Kanto"
    End Sub

    Private Sub Tyranitar_Click(sender As Object, e As EventArgs) Handles Tyranitar.Click
        DisplayPictureBox.Image = TyranitarPictureBox.Image
        Namelabel.Text = "Tyranitar"
        Typelabel.Text = "Dark and Rock"
        Genlabel.Text = "2"
        Locationlabel.Text = "Wild area"
    End Sub

End Class
