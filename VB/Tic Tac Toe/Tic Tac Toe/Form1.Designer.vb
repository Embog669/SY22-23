<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.B7 = New System.Windows.Forms.Button()
        Me.B8 = New System.Windows.Forms.Button()
        Me.B9 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.player1score = New System.Windows.Forms.Label()
        Me.player2score = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(155, 12)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(132, 123)
        Me.B1.TabIndex = 0
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(293, 12)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(132, 123)
        Me.B2.TabIndex = 1
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(431, 12)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(132, 123)
        Me.B3.TabIndex = 2
        Me.B3.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.Location = New System.Drawing.Point(155, 141)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(132, 123)
        Me.B4.TabIndex = 3
        Me.B4.UseVisualStyleBackColor = True
        '
        'B5
        '
        Me.B5.Location = New System.Drawing.Point(293, 141)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(132, 123)
        Me.B5.TabIndex = 4
        Me.B5.UseVisualStyleBackColor = True
        '
        'B6
        '
        Me.B6.Location = New System.Drawing.Point(431, 141)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(132, 123)
        Me.B6.TabIndex = 5
        Me.B6.UseVisualStyleBackColor = True
        '
        'B7
        '
        Me.B7.Location = New System.Drawing.Point(155, 270)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(132, 123)
        Me.B7.TabIndex = 6
        Me.B7.UseVisualStyleBackColor = True
        '
        'B8
        '
        Me.B8.Location = New System.Drawing.Point(293, 270)
        Me.B8.Name = "B8"
        Me.B8.Size = New System.Drawing.Size(132, 123)
        Me.B8.TabIndex = 7
        Me.B8.UseVisualStyleBackColor = True
        '
        'B9
        '
        Me.B9.Location = New System.Drawing.Point(431, 270)
        Me.B9.Name = "B9"
        Me.B9.Size = New System.Drawing.Size(132, 123)
        Me.B9.TabIndex = 8
        Me.B9.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(671, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 62)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Player 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Player 2:"
        '
        'player1score
        '
        Me.player1score.AutoSize = True
        Me.player1score.Location = New System.Drawing.Point(78, 136)
        Me.player1score.Name = "player1score"
        Me.player1score.Size = New System.Drawing.Size(0, 16)
        Me.player1score.TabIndex = 12
        '
        'player2score
        '
        Me.player2score.AutoSize = True
        Me.player2score.Location = New System.Drawing.Point(78, 194)
        Me.player2score.Name = "player2score"
        Me.player2score.Size = New System.Drawing.Size(0, 16)
        Me.player2score.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.player2score)
        Me.Controls.Add(Me.player1score)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.B9)
        Me.Controls.Add(Me.B8)
        Me.Controls.Add(Me.B7)
        Me.Controls.Add(Me.B6)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Name = "Form1"
        Me.Text = "Tic Tac Toe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B1 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B4 As Button
    Friend WithEvents B5 As Button
    Friend WithEvents B6 As Button
    Friend WithEvents B7 As Button
    Friend WithEvents B8 As Button
    Friend WithEvents B9 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents player1score As Label
    Friend WithEvents player2score As Label
End Class
