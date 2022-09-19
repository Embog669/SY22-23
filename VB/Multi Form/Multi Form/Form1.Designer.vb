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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.aTextBox = New System.Windows.Forms.TextBox()
        Me.bTextBox = New System.Windows.Forms.TextBox()
        Me.cTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'aTextBox
        '
        Me.aTextBox.Location = New System.Drawing.Point(208, 62)
        Me.aTextBox.Name = "aTextBox"
        Me.aTextBox.Size = New System.Drawing.Size(100, 25)
        Me.aTextBox.TabIndex = 3
        '
        'bTextBox
        '
        Me.bTextBox.Location = New System.Drawing.Point(208, 118)
        Me.bTextBox.Name = "bTextBox"
        Me.bTextBox.Size = New System.Drawing.Size(100, 25)
        Me.bTextBox.TabIndex = 4
        '
        'cTextBox
        '
        Me.cTextBox.Location = New System.Drawing.Point(208, 174)
        Me.cTextBox.Name = "cTextBox"
        Me.cTextBox.Size = New System.Drawing.Size(100, 25)
        Me.cTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(375, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Get Values"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(375, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 49)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Form3"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(375, 174)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 49)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Form4"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 534)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cTextBox)
        Me.Controls.Add(Me.bTextBox)
        Me.Controls.Add(Me.aTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Multi Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents aTextBox As TextBox
    Friend WithEvents bTextBox As TextBox
    Friend WithEvents cTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
