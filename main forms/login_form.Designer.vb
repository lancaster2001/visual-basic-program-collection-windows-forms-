<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_form
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
        Me.username_text_box = New System.Windows.Forms.TextBox()
        Me.username_label = New System.Windows.Forms.Label()
        Me.password_label = New System.Windows.Forms.Label()
        Me.password_text_box = New System.Windows.Forms.TextBox()
        Me.login_button = New System.Windows.Forms.Button()
        Me.register_button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.exit_button = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.matrix_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.color_button1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username_text_box
        '
        Me.username_text_box.Location = New System.Drawing.Point(77, 24)
        Me.username_text_box.Name = "username_text_box"
        Me.username_text_box.Size = New System.Drawing.Size(195, 20)
        Me.username_text_box.TabIndex = 0
        '
        'username_label
        '
        Me.username_label.AutoSize = True
        Me.username_label.Location = New System.Drawing.Point(12, 24)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(55, 13)
        Me.username_label.TabIndex = 1
        Me.username_label.Text = "Username"
        '
        'password_label
        '
        Me.password_label.AutoSize = True
        Me.password_label.Location = New System.Drawing.Point(12, 57)
        Me.password_label.Name = "password_label"
        Me.password_label.Size = New System.Drawing.Size(53, 13)
        Me.password_label.TabIndex = 2
        Me.password_label.Text = "Password"
        '
        'password_text_box
        '
        Me.password_text_box.Location = New System.Drawing.Point(77, 54)
        Me.password_text_box.Name = "password_text_box"
        Me.password_text_box.Size = New System.Drawing.Size(195, 20)
        Me.password_text_box.TabIndex = 3
        '
        'login_button
        '
        Me.login_button.Location = New System.Drawing.Point(77, 80)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(87, 40)
        Me.login_button.TabIndex = 4
        Me.login_button.Text = "login"
        Me.login_button.UseVisualStyleBackColor = True
        '
        'register_button
        '
        Me.register_button.Location = New System.Drawing.Point(182, 80)
        Me.register_button.Name = "register_button"
        Me.register_button.Size = New System.Drawing.Size(90, 40)
        Me.register_button.TabIndex = 5
        Me.register_button.Text = "register"
        Me.register_button.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'exit_button
        '
        Me.exit_button.Location = New System.Drawing.Point(131, 138)
        Me.exit_button.Name = "exit_button"
        Me.exit_button.Size = New System.Drawing.Size(75, 23)
        Me.exit_button.TabIndex = 9
        Me.exit_button.Text = "Exit"
        Me.exit_button.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(444, -12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(802, 485)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'matrix_timer
        '
        Me.matrix_timer.Enabled = True
        Me.matrix_timer.Interval = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "press esc to leave a form or quit the program"
        '
        'ColorDialog1
        '
        Me.ColorDialog1.FullOpen = True
        '
        'color_button1
        '
        Me.color_button1.Location = New System.Drawing.Point(278, 57)
        Me.color_button1.Name = "color_button1"
        Me.color_button1.Size = New System.Drawing.Size(75, 23)
        Me.color_button1.TabIndex = 12
        Me.color_button1.Text = "Colour"
        Me.color_button1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'login_form
        '
        Me.AcceptButton = Me.login_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 485)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.color_button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exit_button)
        Me.Controls.Add(Me.register_button)
        Me.Controls.Add(Me.login_button)
        Me.Controls.Add(Me.password_text_box)
        Me.Controls.Add(Me.password_label)
        Me.Controls.Add(Me.username_label)
        Me.Controls.Add(Me.username_text_box)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "login_form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents username_label As System.Windows.Forms.Label
    Friend WithEvents password_label As System.Windows.Forms.Label
    Friend WithEvents login_button As System.Windows.Forms.Button
    Friend WithEvents register_button As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents username_text_box As System.Windows.Forms.TextBox
    Public WithEvents password_text_box As System.Windows.Forms.TextBox
    Friend WithEvents exit_button As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents matrix_timer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents color_button1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
