Public Class Form1
    'Don't mess with the code below, this updates the game
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateGame()
    End Sub
    Public Function Collision(p1 As PictureBox, p2 As PictureBox) As Boolean
        Debug.Print(p1.Name + " ran into " + p2.Name)

        'Any pictureboxes whose name start with TARGET that get run into will be removed
        If p2.Name.ToUpper.StartsWith("black") Then 'remove targets when they are hit
            Remove(p2)
        End If
        If p2.Name.ToUpper.StartsWith("white") Then 'remove targets when they are hit
            Remove(p2)
        End If

        'Any BULLET pictures will be removed when they collide
        If p1.Name.ToUpper.StartsWith("BULLET") Then
            '(don't remove them if they collide with the player - like when they start out
            If Not p2.Name.ToUpper.StartsWith("PLAYER") Then 'remove bullets when they collide with others
                Remove(p1)
            End If
        End If

        'Anything that runs into a wall will stop
        If p2.Name.ToUpper.StartsWith("WALL") Then
            Return False 'don't let anything through walls
        End If

        'if none of the above happened, let the object move
        Return True ' let it move
    End Function
    Dim Offset As Point
    Private Sub whitepawn0_MouseDown(sender As Object, e As MouseEventArgs) Handles whitepawn0.MouseDown
        Offset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub whitepawn0_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles whitepawn0.MouseMove, whitepawn1.MouseMove, whitepawn2.MouseMove, whitepawn3.MouseMove, whitepawn4.MouseMove, whitepawn5.MouseMove, whitepawn6.MouseMove, whitepawn7.MouseMove, whiterook0.MouseMove, whiterook1.MouseMove, whiteknight0.MouseMove, whiteknight1.MouseMove, whitebishop0.MouseMove, whitebishop1.MouseMove, whiteking.MouseMove, whitequeen.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim Pos As Point = Me.PointToClient(MousePosition)
            Pos.Offset(Offset.X, Offset.Y)
            sender.Location = Pos
        End If
    End Sub
    Private Sub blackpawn0_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles blackpawn0.MouseMove, blackpawn1.MouseMove, blackpawn2.MouseMove, blackpawn3.MouseMove, blackpawn4.MouseMove, blackpawn5.MouseMove, blackpawn6.MouseMove, blackpawn7.MouseMove, blackrook0.MouseMove, blackrook1.MouseMove, blackknight0.MouseMove, blackknight1.MouseMove, blackbishop0.MouseMove, blackbishop1.MouseMove, blackking.MouseMove, blackqueen.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim Pos As Point = Me.PointToClient(MousePosition)
            Pos.Offset(Offset.X, Offset.Y)
            sender.Location = Pos
        End If
    End Sub
End Class
