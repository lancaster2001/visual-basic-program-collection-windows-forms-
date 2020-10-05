<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class names_form
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
        Me.name_label = New System.Windows.Forms.Label()
        Me.Hello = New System.Windows.Forms.Button()
        Me.name_text_box = New System.Windows.Forms.TextBox()
        Me.names_list_box = New System.Windows.Forms.ListBox()
        Me.add_name_to_list = New System.Windows.Forms.Button()
        Me.save_button = New System.Windows.Forms.Button()
        Me.remove_button = New System.Windows.Forms.Button()
        Me.load_button = New System.Windows.Forms.Button()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.search_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'name_label
        '
        Me.name_label.AutoSize = True
        Me.name_label.Location = New System.Drawing.Point(3, 31)
        Me.name_label.Name = "name_label"
        Me.name_label.Size = New System.Drawing.Size(35, 13)
        Me.name_label.TabIndex = 0
        Me.name_label.Text = "Name"
        '
        'Hello
        '
        Me.Hello.Location = New System.Drawing.Point(206, 28)
        Me.Hello.Name = "Hello"
        Me.Hello.Size = New System.Drawing.Size(75, 23)
        Me.Hello.TabIndex = 1
        Me.Hello.Text = "Hello"
        Me.Hello.UseVisualStyleBackColor = True
        '
        'name_text_box
        '
        Me.name_text_box.Location = New System.Drawing.Point(44, 28)
        Me.name_text_box.Name = "name_text_box"
        Me.name_text_box.Size = New System.Drawing.Size(156, 20)
        Me.name_text_box.TabIndex = 2
        '
        'names_list_box
        '
        Me.names_list_box.AllowDrop = True
        Me.names_list_box.FormattingEnabled = True
        Me.names_list_box.HorizontalScrollbar = True
        Me.names_list_box.Location = New System.Drawing.Point(12, 54)
        Me.names_list_box.Name = "names_list_box"
        Me.names_list_box.Size = New System.Drawing.Size(120, 186)
        Me.names_list_box.TabIndex = 4
        '
        'add_name_to_list
        '
        Me.add_name_to_list.Location = New System.Drawing.Point(138, 57)
        Me.add_name_to_list.Name = "add_name_to_list"
        Me.add_name_to_list.Size = New System.Drawing.Size(75, 23)
        Me.add_name_to_list.TabIndex = 5
        Me.add_name_to_list.Text = "Add"
        Me.add_name_to_list.UseVisualStyleBackColor = True
        '
        'save_button
        '
        Me.save_button.Location = New System.Drawing.Point(138, 115)
        Me.save_button.Name = "save_button"
        Me.save_button.Size = New System.Drawing.Size(75, 23)
        Me.save_button.TabIndex = 6
        Me.save_button.Text = "Save"
        Me.save_button.UseVisualStyleBackColor = True
        '
        'remove_button
        '
        Me.remove_button.Location = New System.Drawing.Point(138, 86)
        Me.remove_button.Name = "remove_button"
        Me.remove_button.Size = New System.Drawing.Size(75, 23)
        Me.remove_button.TabIndex = 7
        Me.remove_button.Text = "Remove"
        Me.remove_button.UseVisualStyleBackColor = True
        '
        'load_button
        '
        Me.load_button.Location = New System.Drawing.Point(138, 145)
        Me.load_button.Name = "load_button"
        Me.load_button.Size = New System.Drawing.Size(75, 23)
        Me.load_button.TabIndex = 8
        Me.load_button.Text = "Load"
        Me.load_button.UseVisualStyleBackColor = True
        '
        'search_box
        '
        Me.search_box.Location = New System.Drawing.Point(219, 177)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(48, 20)
        Me.search_box.TabIndex = 9
        '
        'search_button
        '
        Me.search_button.Location = New System.Drawing.Point(138, 174)
        Me.search_button.Name = "search_button"
        Me.search_button.Size = New System.Drawing.Size(75, 23)
        Me.search_button.TabIndex = 10
        Me.search_button.Text = "Search"
        Me.search_button.UseVisualStyleBackColor = True
        '
        'names_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.search_button)
        Me.Controls.Add(Me.search_box)
        Me.Controls.Add(Me.load_button)
        Me.Controls.Add(Me.remove_button)
        Me.Controls.Add(Me.save_button)
        Me.Controls.Add(Me.add_name_to_list)
        Me.Controls.Add(Me.names_list_box)
        Me.Controls.Add(Me.name_text_box)
        Me.Controls.Add(Me.Hello)
        Me.Controls.Add(Me.name_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "names_form"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents name_label As System.Windows.Forms.Label
    Friend WithEvents Hello As System.Windows.Forms.Button
    Friend WithEvents name_text_box As System.Windows.Forms.TextBox
    Friend WithEvents names_list_box As System.Windows.Forms.ListBox
    Friend WithEvents add_name_to_list As System.Windows.Forms.Button
    Friend WithEvents save_button As System.Windows.Forms.Button
    Friend WithEvents remove_button As System.Windows.Forms.Button
    Friend WithEvents load_button As System.Windows.Forms.Button
    Friend WithEvents search_box As System.Windows.Forms.TextBox
    Friend WithEvents search_button As System.Windows.Forms.Button

End Class
