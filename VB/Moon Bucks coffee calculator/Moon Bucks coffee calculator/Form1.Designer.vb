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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AdressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextbox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.RegularTextBox = New System.Windows.Forms.TextBox()
        Me.DecalfTextBox = New System.Windows.Forms.TextBox()
        Me.PoundsTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(283, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&City:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&Adress:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "&State:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "&Decalf:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(271, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "&Regular:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(158, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "&Zip:"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(623, 290)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(129, 23)
        Me.CalculateButton.TabIndex = 8
        Me.CalculateButton.Text = "&Calculate Order"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(623, 319)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(129, 23)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "&Clear Order"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(623, 348)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(129, 23)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(620, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Total Price:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(620, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Pounds Ordered:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(63, 146)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(277, 22)
        Me.NameTextBox.TabIndex = 14
        '
        'AdressTextBox
        '
        Me.AdressTextBox.Location = New System.Drawing.Point(63, 194)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(277, 22)
        Me.AdressTextBox.TabIndex = 15
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(63, 253)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(277, 22)
        Me.CityTextBox.TabIndex = 16
        '
        'StateTextbox
        '
        Me.StateTextbox.Location = New System.Drawing.Point(63, 341)
        Me.StateTextbox.Name = "StateTextbox"
        Me.StateTextbox.Size = New System.Drawing.Size(67, 22)
        Me.StateTextbox.TabIndex = 17
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(161, 341)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(67, 22)
        Me.ZipTextBox.TabIndex = 18
        '
        'RegularTextBox
        '
        Me.RegularTextBox.Location = New System.Drawing.Point(274, 341)
        Me.RegularTextBox.Name = "RegularTextBox"
        Me.RegularTextBox.Size = New System.Drawing.Size(91, 22)
        Me.RegularTextBox.TabIndex = 19
        '
        'DecalfTextBox
        '
        Me.DecalfTextBox.Location = New System.Drawing.Point(400, 338)
        Me.DecalfTextBox.Name = "DecalfTextBox"
        Me.DecalfTextBox.Size = New System.Drawing.Size(91, 22)
        Me.DecalfTextBox.TabIndex = 20
        '
        'PoundsTextBox
        '
        Me.PoundsTextBox.Location = New System.Drawing.Point(623, 109)
        Me.PoundsTextBox.Name = "PoundsTextBox"
        Me.PoundsTextBox.Size = New System.Drawing.Size(129, 22)
        Me.PoundsTextBox.TabIndex = 21
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(623, 165)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(129, 22)
        Me.PriceTextBox.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.PoundsTextBox)
        Me.Controls.Add(Me.DecalfTextBox)
        Me.Controls.Add(Me.RegularTextBox)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.StateTextbox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AdressTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "MoonBucks Coffee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AdressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextbox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents RegularTextBox As TextBox
    Friend WithEvents DecalfTextBox As TextBox
    Friend WithEvents PoundsTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
End Class
