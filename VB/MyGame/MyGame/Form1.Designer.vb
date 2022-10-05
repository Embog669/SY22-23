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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.whitequeen = New System.Windows.Forms.PictureBox()
        Me.whiteking = New System.Windows.Forms.PictureBox()
        Me.blackking = New System.Windows.Forms.PictureBox()
        Me.blackqueen = New System.Windows.Forms.PictureBox()
        Me.whitebishop0 = New System.Windows.Forms.PictureBox()
        Me.whitebishop1 = New System.Windows.Forms.PictureBox()
        Me.blackbishop0 = New System.Windows.Forms.PictureBox()
        Me.blackbishop1 = New System.Windows.Forms.PictureBox()
        Me.blackknight1 = New System.Windows.Forms.PictureBox()
        Me.blackknight0 = New System.Windows.Forms.PictureBox()
        Me.blackrook1 = New System.Windows.Forms.PictureBox()
        Me.blackrook0 = New System.Windows.Forms.PictureBox()
        Me.whiteknight1 = New System.Windows.Forms.PictureBox()
        Me.whiteknight0 = New System.Windows.Forms.PictureBox()
        Me.whiterook1 = New System.Windows.Forms.PictureBox()
        Me.whiterook0 = New System.Windows.Forms.PictureBox()
        Me.whitepawn7 = New System.Windows.Forms.PictureBox()
        Me.whitepawn6 = New System.Windows.Forms.PictureBox()
        Me.whitepawn5 = New System.Windows.Forms.PictureBox()
        Me.whitepawn4 = New System.Windows.Forms.PictureBox()
        Me.whitepawn3 = New System.Windows.Forms.PictureBox()
        Me.whitepawn2 = New System.Windows.Forms.PictureBox()
        Me.whitepawn1 = New System.Windows.Forms.PictureBox()
        Me.whitepawn0 = New System.Windows.Forms.PictureBox()
        Me.blackpawn6 = New System.Windows.Forms.PictureBox()
        Me.blackpawn5 = New System.Windows.Forms.PictureBox()
        Me.blackpawn4 = New System.Windows.Forms.PictureBox()
        Me.blackpawn3 = New System.Windows.Forms.PictureBox()
        Me.blackpawn0 = New System.Windows.Forms.PictureBox()
        Me.blackpawn1 = New System.Windows.Forms.PictureBox()
        Me.blackpawn2 = New System.Windows.Forms.PictureBox()
        Me.blackpawn7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.whitequeen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whiteking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackqueen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whitebishop0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whitebishop1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackbishop0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackbishop1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackknight1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackknight0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackrook1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackrook0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whiteknight1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whiteknight0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whiterook1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whiterook0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whitepawn7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whitepawn6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whitepawn5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whitepawn4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whitepawn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whitepawn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whitepawn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whitepawn0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackpawn6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackpawn5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackpawn4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackpawn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackpawn0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackpawn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackpawn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackpawn7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'whitequeen
        '
        Me.whitequeen.Image = Global.MyGame.My.Resources.Resources.white_queen
        Me.whitequeen.Location = New System.Drawing.Point(272, 442)
        Me.whitequeen.Name = "whitequeen"
        Me.whitequeen.Size = New System.Drawing.Size(36, 56)
        Me.whitequeen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whitequeen.TabIndex = 33
        Me.whitequeen.TabStop = False
        '
        'whiteking
        '
        Me.whiteking.Image = Global.MyGame.My.Resources.Resources.white_king
        Me.whiteking.Location = New System.Drawing.Point(359, 442)
        Me.whiteking.Name = "whiteking"
        Me.whiteking.Size = New System.Drawing.Size(36, 56)
        Me.whiteking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whiteking.TabIndex = 32
        Me.whiteking.TabStop = False
        '
        'blackking
        '
        Me.blackking.Image = Global.MyGame.My.Resources.Resources.black_king
        Me.blackking.Location = New System.Drawing.Point(359, 3)
        Me.blackking.Name = "blackking"
        Me.blackking.Size = New System.Drawing.Size(36, 56)
        Me.blackking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackking.TabIndex = 31
        Me.blackking.TabStop = False
        '
        'blackqueen
        '
        Me.blackqueen.Image = Global.MyGame.My.Resources.Resources.black_queen
        Me.blackqueen.Location = New System.Drawing.Point(272, 3)
        Me.blackqueen.Name = "blackqueen"
        Me.blackqueen.Size = New System.Drawing.Size(36, 56)
        Me.blackqueen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackqueen.TabIndex = 30
        Me.blackqueen.TabStop = False
        '
        'whitebishop0
        '
        Me.whitebishop0.Image = Global.MyGame.My.Resources.Resources.white_bishop
        Me.whitebishop0.Location = New System.Drawing.Point(440, 442)
        Me.whitebishop0.Name = "whitebishop0"
        Me.whitebishop0.Size = New System.Drawing.Size(36, 56)
        Me.whitebishop0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whitebishop0.TabIndex = 29
        Me.whitebishop0.TabStop = False
        '
        'whitebishop1
        '
        Me.whitebishop1.Image = Global.MyGame.My.Resources.Resources.white_bishop
        Me.whitebishop1.Location = New System.Drawing.Point(194, 442)
        Me.whitebishop1.Name = "whitebishop1"
        Me.whitebishop1.Size = New System.Drawing.Size(36, 56)
        Me.whitebishop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whitebishop1.TabIndex = 28
        Me.whitebishop1.TabStop = False
        '
        'blackbishop0
        '
        Me.blackbishop0.Image = Global.MyGame.My.Resources.Resources.black_bishop
        Me.blackbishop0.Location = New System.Drawing.Point(440, -1)
        Me.blackbishop0.Name = "blackbishop0"
        Me.blackbishop0.Size = New System.Drawing.Size(36, 56)
        Me.blackbishop0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackbishop0.TabIndex = 27
        Me.blackbishop0.TabStop = False
        '
        'blackbishop1
        '
        Me.blackbishop1.Image = Global.MyGame.My.Resources.Resources.black_bishop
        Me.blackbishop1.Location = New System.Drawing.Point(194, 3)
        Me.blackbishop1.Name = "blackbishop1"
        Me.blackbishop1.Size = New System.Drawing.Size(36, 56)
        Me.blackbishop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackbishop1.TabIndex = 26
        Me.blackbishop1.TabStop = False
        '
        'blackknight1
        '
        Me.blackknight1.Image = Global.MyGame.My.Resources.Resources.black_knight
        Me.blackknight1.Location = New System.Drawing.Point(112, -1)
        Me.blackknight1.Name = "blackknight1"
        Me.blackknight1.Size = New System.Drawing.Size(36, 56)
        Me.blackknight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackknight1.TabIndex = 25
        Me.blackknight1.TabStop = False
        '
        'blackknight0
        '
        Me.blackknight0.Image = Global.MyGame.My.Resources.Resources.black_knight
        Me.blackknight0.Location = New System.Drawing.Point(521, 3)
        Me.blackknight0.Name = "blackknight0"
        Me.blackknight0.Size = New System.Drawing.Size(36, 56)
        Me.blackknight0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackknight0.TabIndex = 24
        Me.blackknight0.TabStop = False
        '
        'blackrook1
        '
        Me.blackrook1.Image = Global.MyGame.My.Resources.Resources.black_rook
        Me.blackrook1.Location = New System.Drawing.Point(24, 3)
        Me.blackrook1.Name = "blackrook1"
        Me.blackrook1.Size = New System.Drawing.Size(36, 56)
        Me.blackrook1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackrook1.TabIndex = 23
        Me.blackrook1.TabStop = False
        '
        'blackrook0
        '
        Me.blackrook0.Image = Global.MyGame.My.Resources.Resources.black_rook
        Me.blackrook0.Location = New System.Drawing.Point(605, 3)
        Me.blackrook0.Name = "blackrook0"
        Me.blackrook0.Size = New System.Drawing.Size(36, 56)
        Me.blackrook0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackrook0.TabIndex = 22
        Me.blackrook0.TabStop = False
        '
        'whiteknight1
        '
        Me.whiteknight1.Image = Global.MyGame.My.Resources.Resources.white_knight1
        Me.whiteknight1.Location = New System.Drawing.Point(112, 442)
        Me.whiteknight1.Name = "whiteknight1"
        Me.whiteknight1.Size = New System.Drawing.Size(36, 56)
        Me.whiteknight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whiteknight1.TabIndex = 21
        Me.whiteknight1.TabStop = False
        '
        'whiteknight0
        '
        Me.whiteknight0.Image = Global.MyGame.My.Resources.Resources.white_knight1
        Me.whiteknight0.Location = New System.Drawing.Point(521, 442)
        Me.whiteknight0.Name = "whiteknight0"
        Me.whiteknight0.Size = New System.Drawing.Size(36, 56)
        Me.whiteknight0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whiteknight0.TabIndex = 20
        Me.whiteknight0.TabStop = False
        '
        'whiterook1
        '
        Me.whiterook1.Image = Global.MyGame.My.Resources.Resources.white_rook
        Me.whiterook1.Location = New System.Drawing.Point(24, 442)
        Me.whiterook1.Name = "whiterook1"
        Me.whiterook1.Size = New System.Drawing.Size(36, 56)
        Me.whiterook1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whiterook1.TabIndex = 19
        Me.whiterook1.TabStop = False
        '
        'whiterook0
        '
        Me.whiterook0.Image = Global.MyGame.My.Resources.Resources.white_rook
        Me.whiterook0.Location = New System.Drawing.Point(605, 442)
        Me.whiterook0.Name = "whiterook0"
        Me.whiterook0.Size = New System.Drawing.Size(36, 56)
        Me.whiterook0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whiterook0.TabIndex = 18
        Me.whiterook0.TabStop = False
        '
        'whitepawn7
        '
        Me.whitepawn7.Image = Global.MyGame.My.Resources.Resources.White_pawn
        Me.whitepawn7.Location = New System.Drawing.Point(24, 374)
        Me.whitepawn7.Name = "whitepawn7"
        Me.whitepawn7.Size = New System.Drawing.Size(36, 56)
        Me.whitepawn7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whitepawn7.TabIndex = 17
        Me.whitepawn7.TabStop = False
        '
        'whitepawn6
        '
        Me.whitepawn6.Image = Global.MyGame.My.Resources.Resources.White_pawn
        Me.whitepawn6.Location = New System.Drawing.Point(112, 374)
        Me.whitepawn6.Name = "whitepawn6"
        Me.whitepawn6.Size = New System.Drawing.Size(36, 56)
        Me.whitepawn6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whitepawn6.TabIndex = 16
        Me.whitepawn6.TabStop = False
        '
        'whitepawn5
        '
        Me.whitepawn5.Image = Global.MyGame.My.Resources.Resources.White_pawn
        Me.whitepawn5.Location = New System.Drawing.Point(194, 374)
        Me.whitepawn5.Name = "whitepawn5"
        Me.whitepawn5.Size = New System.Drawing.Size(36, 56)
        Me.whitepawn5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whitepawn5.TabIndex = 15
        Me.whitepawn5.TabStop = False
        '
        'whitepawn4
        '
        Me.whitepawn4.Image = Global.MyGame.My.Resources.Resources.White_pawn
        Me.whitepawn4.Location = New System.Drawing.Point(272, 374)
        Me.whitepawn4.Name = "whitepawn4"
        Me.whitepawn4.Size = New System.Drawing.Size(36, 56)
        Me.whitepawn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whitepawn4.TabIndex = 14
        Me.whitepawn4.TabStop = False
        '
        'whitepawn3
        '
        Me.whitepawn3.Image = Global.MyGame.My.Resources.Resources.White_pawn
        Me.whitepawn3.Location = New System.Drawing.Point(359, 374)
        Me.whitepawn3.Name = "whitepawn3"
        Me.whitepawn3.Size = New System.Drawing.Size(36, 56)
        Me.whitepawn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whitepawn3.TabIndex = 13
        Me.whitepawn3.TabStop = False
        '
        'whitepawn2
        '
        Me.whitepawn2.Image = Global.MyGame.My.Resources.Resources.White_pawn
        Me.whitepawn2.Location = New System.Drawing.Point(440, 374)
        Me.whitepawn2.Name = "whitepawn2"
        Me.whitepawn2.Size = New System.Drawing.Size(36, 56)
        Me.whitepawn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whitepawn2.TabIndex = 12
        Me.whitepawn2.TabStop = False
        '
        'whitepawn1
        '
        Me.whitepawn1.Image = Global.MyGame.My.Resources.Resources.White_pawn
        Me.whitepawn1.Location = New System.Drawing.Point(521, 374)
        Me.whitepawn1.Name = "whitepawn1"
        Me.whitepawn1.Size = New System.Drawing.Size(36, 56)
        Me.whitepawn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whitepawn1.TabIndex = 11
        Me.whitepawn1.TabStop = False
        '
        'whitepawn0
        '
        Me.whitepawn0.Image = Global.MyGame.My.Resources.Resources.White_pawn
        Me.whitepawn0.Location = New System.Drawing.Point(605, 374)
        Me.whitepawn0.Name = "whitepawn0"
        Me.whitepawn0.Size = New System.Drawing.Size(36, 56)
        Me.whitepawn0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whitepawn0.TabIndex = 10
        Me.whitepawn0.TabStop = False
        '
        'blackpawn6
        '
        Me.blackpawn6.Image = Global.MyGame.My.Resources.Resources.black_pawn
        Me.blackpawn6.Location = New System.Drawing.Point(112, 65)
        Me.blackpawn6.Name = "blackpawn6"
        Me.blackpawn6.Size = New System.Drawing.Size(36, 56)
        Me.blackpawn6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackpawn6.TabIndex = 9
        Me.blackpawn6.TabStop = False
        '
        'blackpawn5
        '
        Me.blackpawn5.Image = Global.MyGame.My.Resources.Resources.black_pawn
        Me.blackpawn5.Location = New System.Drawing.Point(194, 65)
        Me.blackpawn5.Name = "blackpawn5"
        Me.blackpawn5.Size = New System.Drawing.Size(36, 56)
        Me.blackpawn5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackpawn5.TabIndex = 8
        Me.blackpawn5.TabStop = False
        '
        'blackpawn4
        '
        Me.blackpawn4.Image = Global.MyGame.My.Resources.Resources.black_pawn
        Me.blackpawn4.Location = New System.Drawing.Point(272, 65)
        Me.blackpawn4.Name = "blackpawn4"
        Me.blackpawn4.Size = New System.Drawing.Size(36, 56)
        Me.blackpawn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackpawn4.TabIndex = 7
        Me.blackpawn4.TabStop = False
        '
        'blackpawn3
        '
        Me.blackpawn3.Image = Global.MyGame.My.Resources.Resources.black_pawn
        Me.blackpawn3.Location = New System.Drawing.Point(359, 65)
        Me.blackpawn3.Name = "blackpawn3"
        Me.blackpawn3.Size = New System.Drawing.Size(36, 56)
        Me.blackpawn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackpawn3.TabIndex = 6
        Me.blackpawn3.TabStop = False
        '
        'blackpawn0
        '
        Me.blackpawn0.Image = Global.MyGame.My.Resources.Resources.black_pawn
        Me.blackpawn0.Location = New System.Drawing.Point(605, 65)
        Me.blackpawn0.Name = "blackpawn0"
        Me.blackpawn0.Size = New System.Drawing.Size(36, 56)
        Me.blackpawn0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackpawn0.TabIndex = 5
        Me.blackpawn0.TabStop = False
        '
        'blackpawn1
        '
        Me.blackpawn1.Image = Global.MyGame.My.Resources.Resources.black_pawn
        Me.blackpawn1.Location = New System.Drawing.Point(521, 65)
        Me.blackpawn1.Name = "blackpawn1"
        Me.blackpawn1.Size = New System.Drawing.Size(36, 56)
        Me.blackpawn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackpawn1.TabIndex = 4
        Me.blackpawn1.TabStop = False
        '
        'blackpawn2
        '
        Me.blackpawn2.Image = Global.MyGame.My.Resources.Resources.black_pawn
        Me.blackpawn2.Location = New System.Drawing.Point(440, 65)
        Me.blackpawn2.Name = "blackpawn2"
        Me.blackpawn2.Size = New System.Drawing.Size(36, 56)
        Me.blackpawn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackpawn2.TabIndex = 3
        Me.blackpawn2.TabStop = False
        '
        'blackpawn7
        '
        Me.blackpawn7.Image = Global.MyGame.My.Resources.Resources.black_pawn
        Me.blackpawn7.Location = New System.Drawing.Point(24, 65)
        Me.blackpawn7.Name = "blackpawn7"
        Me.blackpawn7.Size = New System.Drawing.Size(36, 56)
        Me.blackpawn7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blackpawn7.TabIndex = 2
        Me.blackpawn7.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MyGame.My.Resources.Resources.chess_board
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(661, 499)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(756, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 39)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Chess"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(928, 497)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.whitequeen)
        Me.Controls.Add(Me.whiteking)
        Me.Controls.Add(Me.blackking)
        Me.Controls.Add(Me.blackqueen)
        Me.Controls.Add(Me.whitebishop0)
        Me.Controls.Add(Me.whitebishop1)
        Me.Controls.Add(Me.blackbishop0)
        Me.Controls.Add(Me.blackbishop1)
        Me.Controls.Add(Me.blackknight1)
        Me.Controls.Add(Me.blackknight0)
        Me.Controls.Add(Me.blackrook1)
        Me.Controls.Add(Me.blackrook0)
        Me.Controls.Add(Me.whiteknight1)
        Me.Controls.Add(Me.whiteknight0)
        Me.Controls.Add(Me.whiterook1)
        Me.Controls.Add(Me.whiterook0)
        Me.Controls.Add(Me.whitepawn7)
        Me.Controls.Add(Me.whitepawn6)
        Me.Controls.Add(Me.whitepawn5)
        Me.Controls.Add(Me.whitepawn4)
        Me.Controls.Add(Me.whitepawn3)
        Me.Controls.Add(Me.whitepawn2)
        Me.Controls.Add(Me.whitepawn1)
        Me.Controls.Add(Me.whitepawn0)
        Me.Controls.Add(Me.blackpawn6)
        Me.Controls.Add(Me.blackpawn5)
        Me.Controls.Add(Me.blackpawn4)
        Me.Controls.Add(Me.blackpawn3)
        Me.Controls.Add(Me.blackpawn0)
        Me.Controls.Add(Me.blackpawn1)
        Me.Controls.Add(Me.blackpawn2)
        Me.Controls.Add(Me.blackpawn7)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Chess"
        CType(Me.whitequeen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whiteking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackqueen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whitebishop0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whitebishop1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackbishop0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackbishop1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackknight1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackknight0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackrook1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackrook0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whiteknight1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whiteknight0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whiterook1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whiterook0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whitepawn7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whitepawn6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whitepawn5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whitepawn4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whitepawn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whitepawn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whitepawn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whitepawn0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackpawn6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackpawn5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackpawn4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackpawn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackpawn0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackpawn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackpawn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackpawn7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents blackpawn7 As PictureBox
    Friend WithEvents blackpawn2 As PictureBox
    Friend WithEvents blackpawn1 As PictureBox
    Friend WithEvents blackpawn0 As PictureBox
    Friend WithEvents blackpawn3 As PictureBox
    Friend WithEvents blackpawn4 As PictureBox
    Friend WithEvents blackpawn5 As PictureBox
    Friend WithEvents blackpawn6 As PictureBox
    Friend WithEvents whitepawn0 As PictureBox
    Friend WithEvents whitepawn1 As PictureBox
    Friend WithEvents whitepawn2 As PictureBox
    Friend WithEvents whitepawn3 As PictureBox
    Friend WithEvents whitepawn4 As PictureBox
    Friend WithEvents whitepawn5 As PictureBox
    Friend WithEvents whitepawn6 As PictureBox
    Friend WithEvents whitepawn7 As PictureBox
    Friend WithEvents whiterook0 As PictureBox
    Friend WithEvents whiterook1 As PictureBox
    Friend WithEvents whiteknight0 As PictureBox
    Friend WithEvents whiteknight1 As PictureBox
    Friend WithEvents blackrook0 As PictureBox
    Friend WithEvents blackrook1 As PictureBox
    Friend WithEvents blackknight0 As PictureBox
    Friend WithEvents blackknight1 As PictureBox
    Friend WithEvents blackbishop1 As PictureBox
    Friend WithEvents blackbishop0 As PictureBox
    Friend WithEvents whitebishop1 As PictureBox
    Friend WithEvents whitebishop0 As PictureBox
    Friend WithEvents blackqueen As PictureBox
    Friend WithEvents blackking As PictureBox
    Friend WithEvents whiteking As PictureBox
    Friend WithEvents whitequeen As PictureBox
    Friend WithEvents Label1 As Label
End Class
