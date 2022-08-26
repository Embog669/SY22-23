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

    Private Const V As String = "Poke dex"

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Charizardbutton = New System.Windows.Forms.Button()
        Me.Name = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.Label()
        Me.Location = New System.Windows.Forms.Label()
        Me.Gen = New System.Windows.Forms.Label()
        Me.Namelabel = New System.Windows.Forms.Label()
        Me.Locationlabel = New System.Windows.Forms.Label()
        Me.Typelabel = New System.Windows.Forms.Label()
        Me.Genlabel = New System.Windows.Forms.Label()
        Me.Venusuar = New System.Windows.Forms.Button()
        Me.Tyranitar = New System.Windows.Forms.Button()
        Me.Pikachu = New System.Windows.Forms.Button()
        Me.Blastoise = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TyranitarPictureBox = New System.Windows.Forms.PictureBox()
        Me.BlastoiesPictureBox = New System.Windows.Forms.PictureBox()
        Me.VenusuarPictureBox = New System.Windows.Forms.PictureBox()
        Me.CharizardPictureBox = New System.Windows.Forms.PictureBox()
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TyranitarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlastoiesPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenusuarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharizardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Charizardbutton
        '
        Me.Charizardbutton.Location = New System.Drawing.Point(525, 23)
        Me.Charizardbutton.Name = "Charizardbutton"
        Me.Charizardbutton.Size = New System.Drawing.Size(119, 23)
        Me.Charizardbutton.TabIndex = 0
        Me.Charizardbutton.Text = "Charizard"
        Me.Charizardbutton.UseVisualStyleBackColor = True
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(377, 149)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(47, 16)
        Me.Name.TabIndex = 3
        Me.Name.Text = "Name:"
        '
        'Type
        '
        Me.Type.AutoSize = True
        Me.Type.Location = New System.Drawing.Point(377, 189)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(42, 16)
        Me.Type.TabIndex = 4
        Me.Type.Text = "Type:"
        '
        'Location
        '
        Me.Location.AutoSize = True
        Me.Location.Location = New System.Drawing.Point(377, 280)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(61, 16)
        Me.Location.TabIndex = 5
        Me.Location.Text = "Location:"
        '
        'Gen
        '
        Me.Gen.AutoSize = True
        Me.Gen.Location = New System.Drawing.Point(377, 229)
        Me.Gen.Name = "Gen"
        Me.Gen.Size = New System.Drawing.Size(35, 16)
        Me.Gen.TabIndex = 6
        Me.Gen.Text = "Gen:"
        '
        'Namelabel
        '
        Me.Namelabel.AutoSize = True
        Me.Namelabel.Location = New System.Drawing.Point(441, 149)
        Me.Namelabel.Name = "Namelabel"
        Me.Namelabel.Size = New System.Drawing.Size(10, 16)
        Me.Namelabel.TabIndex = 7
        Me.Namelabel.Text = " "
        '
        'Locationlabel
        '
        Me.Locationlabel.AutoSize = True
        Me.Locationlabel.Location = New System.Drawing.Point(448, 280)
        Me.Locationlabel.Name = "Locationlabel"
        Me.Locationlabel.Size = New System.Drawing.Size(10, 16)
        Me.Locationlabel.TabIndex = 8
        Me.Locationlabel.Text = " "
        '
        'Typelabel
        '
        Me.Typelabel.AutoSize = True
        Me.Typelabel.Location = New System.Drawing.Point(441, 189)
        Me.Typelabel.Name = "Typelabel"
        Me.Typelabel.Size = New System.Drawing.Size(8, 20)
        Me.Typelabel.TabIndex = 9
        Me.Typelabel.Text = " "
        Me.Typelabel.UseCompatibleTextRendering = True
        '
        'Genlabel
        '
        Me.Genlabel.AutoSize = True
        Me.Genlabel.Location = New System.Drawing.Point(441, 229)
        Me.Genlabel.Name = "Genlabel"
        Me.Genlabel.Size = New System.Drawing.Size(10, 16)
        Me.Genlabel.TabIndex = 10
        Me.Genlabel.Text = " "
        '
        'Venusuar
        '
        Me.Venusuar.Location = New System.Drawing.Point(525, 154)
        Me.Venusuar.Name = "Venusuar"
        Me.Venusuar.Size = New System.Drawing.Size(119, 23)
        Me.Venusuar.TabIndex = 11
        Me.Venusuar.Text = "Venusuar"
        Me.Venusuar.UseVisualStyleBackColor = True
        '
        'Tyranitar
        '
        Me.Tyranitar.Location = New System.Drawing.Point(662, 154)
        Me.Tyranitar.Name = "Tyranitar"
        Me.Tyranitar.Size = New System.Drawing.Size(117, 23)
        Me.Tyranitar.TabIndex = 12
        Me.Tyranitar.Text = "Tyranitar"
        Me.Tyranitar.UseVisualStyleBackColor = True
        '
        'Pikachu
        '
        Me.Pikachu.Location = New System.Drawing.Point(597, 280)
        Me.Pikachu.Name = "Pikachu"
        Me.Pikachu.Size = New System.Drawing.Size(119, 23)
        Me.Pikachu.TabIndex = 13
        Me.Pikachu.Text = "Pikachu"
        Me.Pikachu.UseVisualStyleBackColor = True
        '
        'Blastoise
        '
        Me.Blastoise.Location = New System.Drawing.Point(662, 23)
        Me.Blastoise.Name = "Blastoise"
        Me.Blastoise.Size = New System.Drawing.Size(117, 23)
        Me.Blastoise.TabIndex = 14
        Me.Blastoise.Text = "Blastoise"
        Me.Blastoise.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Dex.My.Resources.Resources.pikachu
        Me.PictureBox1.Location = New System.Drawing.Point(597, 300)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'TyranitarPictureBox
        '
        Me.TyranitarPictureBox.Image = Global.Dex.My.Resources.Resources.tyranitar
        Me.TyranitarPictureBox.Location = New System.Drawing.Point(662, 175)
        Me.TyranitarPictureBox.Name = "TyranitarPictureBox"
        Me.TyranitarPictureBox.Size = New System.Drawing.Size(117, 83)
        Me.TyranitarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TyranitarPictureBox.TabIndex = 17
        Me.TyranitarPictureBox.TabStop = False
        '
        'BlastoiesPictureBox
        '
        Me.BlastoiesPictureBox.Image = Global.Dex.My.Resources.Resources.blastoise
        Me.BlastoiesPictureBox.Location = New System.Drawing.Point(662, 42)
        Me.BlastoiesPictureBox.Name = "BlastoiesPictureBox"
        Me.BlastoiesPictureBox.Size = New System.Drawing.Size(117, 78)
        Me.BlastoiesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BlastoiesPictureBox.TabIndex = 16
        Me.BlastoiesPictureBox.TabStop = False
        '
        'VenusuarPictureBox
        '
        Me.VenusuarPictureBox.Image = Global.Dex.My.Resources.Resources.Pokémon_Venusaur
        Me.VenusuarPictureBox.Location = New System.Drawing.Point(525, 175)
        Me.VenusuarPictureBox.Name = "VenusuarPictureBox"
        Me.VenusuarPictureBox.Size = New System.Drawing.Size(118, 89)
        Me.VenusuarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VenusuarPictureBox.TabIndex = 15
        Me.VenusuarPictureBox.TabStop = False
        '
        'CharizardPictureBox
        '
        Me.CharizardPictureBox.Image = Global.Dex.My.Resources.Resources.Pokémon_Charzard
        Me.CharizardPictureBox.Location = New System.Drawing.Point(526, 42)
        Me.CharizardPictureBox.Name = "CharizardPictureBox"
        Me.CharizardPictureBox.Size = New System.Drawing.Size(117, 79)
        Me.CharizardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CharizardPictureBox.TabIndex = 2
        Me.CharizardPictureBox.TabStop = False
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.Location = New System.Drawing.Point(-1, 140)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(357, 179)
        Me.DisplayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DisplayPictureBox.TabIndex = 1
        Me.DisplayPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TyranitarPictureBox)
        Me.Controls.Add(Me.BlastoiesPictureBox)
        Me.Controls.Add(Me.VenusuarPictureBox)
        Me.Controls.Add(Me.Blastoise)
        Me.Controls.Add(Me.Pikachu)
        Me.Controls.Add(Me.Tyranitar)
        Me.Controls.Add(Me.Venusuar)
        Me.Controls.Add(Me.Genlabel)
        Me.Controls.Add(Me.Typelabel)
        Me.Controls.Add(Me.Locationlabel)
        Me.Controls.Add(Me.Namelabel)
        Me.Controls.Add(Me.Gen)
        Me.Controls.Add(Me.Location)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.CharizardPictureBox)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.CCType(Me.PictureBontrols.Add(Me.Charizardbutton)
        ox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TyranitarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlastoiesPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenusuarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharizardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Function PictureBontrols() As Object
        Throw New NotImplementedException()
    End Function

    Friend WithEvents Charizardbutton As Button
    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents CharizardPictureBox As PictureBox
    Friend WithEvents Name As Label
    Friend WithEvents Type As Label
    Friend WithEvents Location As Label
    Friend WithEvents Gen As Label
    Friend WithEvents Namelabel As Label
    Friend WithEvents Locationlabel As Label
    Friend WithEvents Typelabel As Label
    Friend WithEvents Genlabel As Label
    Friend WithEvents Venusuar As Button
    Friend WithEvents Tyranitar As Button
    Friend WithEvents Pikachu As Button
    Friend WithEvents Blastoise As Button
    Friend WithEvents VenusuarPictureBox As PictureBox
    Friend WithEvents BlastoiesPictureBox As PictureBox
    Friend WithEvents TyranitarPictureBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
