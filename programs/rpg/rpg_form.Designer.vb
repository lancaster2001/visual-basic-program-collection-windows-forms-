<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpg_form
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
        Me.pick_character_button = New System.Windows.Forms.Button()
        Me.create_character_button = New System.Windows.Forms.Button()
        Me.user_input_test = New System.Windows.Forms.TextBox()
        Me.button_test = New System.Windows.Forms.Button()
        Me.label_test = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pick_character_button
        '
        Me.pick_character_button.Location = New System.Drawing.Point(33, 12)
        Me.pick_character_button.Name = "pick_character_button"
        Me.pick_character_button.Size = New System.Drawing.Size(170, 55)
        Me.pick_character_button.TabIndex = 0
        Me.pick_character_button.Text = "pick character"
        Me.pick_character_button.UseVisualStyleBackColor = True
        '
        'create_character_button
        '
        Me.create_character_button.Location = New System.Drawing.Point(304, 12)
        Me.create_character_button.Name = "create_character_button"
        Me.create_character_button.Size = New System.Drawing.Size(146, 55)
        Me.create_character_button.TabIndex = 1
        Me.create_character_button.Text = "create character"
        Me.create_character_button.UseVisualStyleBackColor = True
        '
        'user_input_test
        '
        Me.user_input_test.Location = New System.Drawing.Point(81, 104)
        Me.user_input_test.Name = "user_input_test"
        Me.user_input_test.Size = New System.Drawing.Size(100, 20)
        Me.user_input_test.TabIndex = 2
        '
        'button_test
        '
        Me.button_test.Location = New System.Drawing.Point(187, 102)
        Me.button_test.Name = "button_test"
        Me.button_test.Size = New System.Drawing.Size(75, 23)
        Me.button_test.TabIndex = 4
        Me.button_test.Text = "enter"
        Me.button_test.UseVisualStyleBackColor = True
        '
        'label_test
        '
        Me.label_test.AutoSize = True
        Me.label_test.Location = New System.Drawing.Point(86, 88)
        Me.label_test.Name = "label_test"
        Me.label_test.Size = New System.Drawing.Size(49, 13)
        Me.label_test.TabIndex = 5
        Me.label_test.Text = "label test"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(177, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rpg_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 460)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.label_test)
        Me.Controls.Add(Me.button_test)
        Me.Controls.Add(Me.user_input_test)
        Me.Controls.Add(Me.create_character_button)
        Me.Controls.Add(Me.pick_character_button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "rpg_form"
        Me.Text = "rpg_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pick_character_button As System.Windows.Forms.Button
    Friend WithEvents create_character_button As System.Windows.Forms.Button
    Friend WithEvents user_input_test As System.Windows.Forms.TextBox
    Friend WithEvents button_test As System.Windows.Forms.Button
    Friend WithEvents label_test As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
