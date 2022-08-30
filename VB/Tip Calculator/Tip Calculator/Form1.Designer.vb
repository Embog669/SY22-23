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
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button50 = New System.Windows.Forms.Button()
        Me.Button100 = New System.Windows.Forms.Button()
        Me.BillTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1, 147)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "8% Tip"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total:"
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(82, 147)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(75, 23)
        Me.Button15.TabIndex = 2
        Me.Button15.Text = "15% Tip"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(163, 147)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(75, 23)
        Me.Button20.TabIndex = 3
        Me.Button20.Text = "20% Tip"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button50
        '
        Me.Button50.Location = New System.Drawing.Point(244, 147)
        Me.Button50.Name = "Button50"
        Me.Button50.Size = New System.Drawing.Size(75, 23)
        Me.Button50.TabIndex = 4
        Me.Button50.Text = "50% Tip"
        Me.Button50.UseVisualStyleBackColor = True
        '
        'Button100
        '
        Me.Button100.Location = New System.Drawing.Point(325, 147)
        Me.Button100.Name = "Button100"
        Me.Button100.Size = New System.Drawing.Size(75, 23)
        Me.Button100.TabIndex = 5
        Me.Button100.Text = "100% Tip"
        Me.Button100.UseVisualStyleBackColor = True
        '
        'BillTextBox
        '
        Me.BillTextBox.Location = New System.Drawing.Point(66, 51)
        Me.BillTextBox.Name = "BillTextBox"
        Me.BillTextBox.Size = New System.Drawing.Size(153, 22)
        Me.BillTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Bill:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(74, 189)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(152, 22)
        Me.TotalTextBox.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(66, 89)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(143, 20)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Was the food good"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(66, 116)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(160, 20)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "Was the service good"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(57, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 64)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BillTextBox)
        Me.Controls.Add(Me.Button100)
        Me.Controls.Add(Me.Button50)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button8)
        Me.Name = "Form1"
        Me.Text = "Tip Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button15 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button50 As Button
    Friend WithEvents Button100 As Button
    Friend WithEvents BillTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button1 As Button
End Class
