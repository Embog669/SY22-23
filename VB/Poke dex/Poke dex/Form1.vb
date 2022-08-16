Public Class Form1
    Private Sub CharizardButton_Click(sender As Object, e As EventArgs) Handles CharizardButton.Click
        displaypicture.Image = charizardpicture.Image
        namelabel.Text = "charizard"
        Typelabel.Text = "Fire and dragon"
        Genlabel.Text = "1"
        Locationlabel.Text = "Kanto"
    End Sub

    Private Sub BlastoiseButton_Click(sender As Object, e As EventArgs) Handles BlastoiseButton.Click
        displaypicture.Image = blastoisepicture.Image
        namelabel.Text = "Blastoise"
        Typelabel.Text = "Water"
        Genlabel.Text = "1"
        Locationlabel.Text = "Kanto"
    End Sub

    Private Sub VenusaurButton_Click(sender As Object, e As EventArgs) Handles VenusaurButton.Click
        displaypicture.Image = venusaurpicture.Image
        namelabel.Text = "Venusaur"
        Typelabel.Text = "Grass and poison"
        Genlabel.Text = "1"
        Locationlabel.Text = "Kanto"
    End Sub

    Private Sub TyranitarButton_Click(sender As Object, e As EventArgs) Handles TyranitarButton.Click
        displaypicture.Image = Tyranitarpicture.Image
        namelabel.Text = "Tyranitar"
        Typelabel.Text = "Dark and rock"
        Genlabel.Text = "2"
        Locationlabel.Text = "Dust bowl"
    End Sub

    Private Sub PikachuButton_Click(sender As Object, e As EventArgs) Handles PikachuButton.Click
        displaypicture.Image = Pikachupicture.Image
        namelabel.Text = "Pikachu"
        Typelabel.Text = "Electric"
        Genlabel.Text = "1"
        Locationlabel.Text = "Obsidian Fields"
    End Sub
End Class
