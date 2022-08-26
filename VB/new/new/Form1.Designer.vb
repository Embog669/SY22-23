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
        Me.BuyButton = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CCTextBox = New System.Windows.Forms.TextBox()
        Me.ExpTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.AmtTextBox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.PictureBoxcheck = New System.Windows.Forms.PictureBox()
        Me.thankyoulabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FeeTextBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBoxcheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuyButton
        '
        Me.BuyButton.Location = New System.Drawing.Point(498, 459)
        Me.BuyButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BuyButton.Name = "BuyButton"
        Me.BuyButton.Size = New System.Drawing.Size(103, 29)
        Me.BuyButton.TabIndex = 1
        Me.BuyButton.Text = "Buy"
        Me.BuyButton.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(111, 98)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(138, 26)
        Me.NameTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Credit card#"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Exporation Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Zip Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Amout"
        '
        'CCTextBox
        '
        Me.CCTextBox.Location = New System.Drawing.Point(141, 165)
        Me.CCTextBox.Name = "CCTextBox"
        Me.CCTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CCTextBox.TabIndex = 8
        '
        'ExpTextBox
        '
        Me.ExpTextBox.Location = New System.Drawing.Point(141, 228)
        Me.ExpTextBox.Name = "ExpTextBox"
        Me.ExpTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ExpTextBox.TabIndex = 9
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(141, 295)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ZipTextBox.TabIndex = 10
        '
        'AmtTextBox
        '
        Me.AmtTextBox.Location = New System.Drawing.Point(141, 389)
        Me.AmtTextBox.Name = "AmtTextBox"
        Me.AmtTextBox.Size = New System.Drawing.Size(182, 26)
        Me.AmtTextBox.TabIndex = 11
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(753, 459)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(103, 29)
        Me.CancelButton.TabIndex = 12
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'PictureBoxcheck
        '
        Me.PictureBoxcheck.Image = Global.[new].My.Resources.Resources.check_mark
        Me.PictureBoxcheck.Location = New System.Drawing.Point(329, -18)
        Me.PictureBoxcheck.Name = "PictureBoxcheck"
        Me.PictureBoxcheck.Size = New System.Drawing.Size(742, 470)
        Me.PictureBoxcheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxcheck.TabIndex = 14
        Me.PictureBoxcheck.TabStop = False
        '
        'thankyoulabel
        '
        Me.thankyoulabel.AutoSize = True
        Me.thankyoulabel.Font = New System.Drawing.Font("Modern No. 20", 28.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thankyoulabel.Location = New System.Drawing.Point(445, 404)
        Me.thankyoulabel.Name = "thankyoulabel"
        Me.thankyoulabel.Size = New System.Drawing.Size(524, 48)
        Me.thankyoulabel.TabIndex = 15
        Me.thankyoulabel.Text = "Thank you for your order"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.[new].My.Resources.Resources.Visa
        Me.PictureBox1.Location = New System.Drawing.Point(329, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(742, 455)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 459)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Fee"
        '
        'FeeTextBox
        '
        Me.FeeTextBox.Location = New System.Drawing.Point(329, 462)
        Me.FeeTextBox.Name = "FeeTextBox"
        Me.FeeTextBox.Size = New System.Drawing.Size(162, 26)
        Me.FeeTextBox.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 562)
        Me.Controls.Add(Me.FeeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.thankyoulabel)
        Me.Controls.Add(Me.PictureBoxcheck)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AmtTextBox)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.ExpTextBox)
        Me.Controls.Add(Me.CCTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.BuyButton)
        Me.Font = New System.Drawing.Font("Modern No. 20", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "My App"
        CType(Me.PictureBoxcheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BuyButton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CCTextBox As TextBox
    Friend WithEvents ExpTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents AmtTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents PictureBoxcheck As PictureBox
    Friend WithEvents thankyoulabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FeeTextBox As TextBox
End Class
