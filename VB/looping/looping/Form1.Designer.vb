<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.badguy1 = New System.Windows.Forms.PictureBox()
        Me.player = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.badguy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "For Looping"
        '
        'badguy1
        '
        Me.badguy1.Image = Global.looping.My.Resources.Resources.images
        Me.badguy1.Location = New System.Drawing.Point(303, 106)
        Me.badguy1.Name = "badguy1"
        Me.badguy1.Size = New System.Drawing.Size(49, 39)
        Me.badguy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.badguy1.TabIndex = 1
        Me.badguy1.TabStop = False
        '
        'player
        '
        Me.player.Image = Global.looping.My.Resources.Resources.pikachu
        Me.player.Location = New System.Drawing.Point(579, 175)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(83, 105)
        Me.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player.TabIndex = 0
        Me.player.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.badguy1)
        Me.Controls.Add(Me.player)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.badguy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents player As PictureBox
    Friend WithEvents badguy1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
