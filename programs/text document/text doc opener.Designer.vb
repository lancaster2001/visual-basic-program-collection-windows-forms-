<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class text_doc_opener
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
        Me.textbox = New System.Windows.Forms.TextBox()
        Me.load_button = New System.Windows.Forms.Button()
        Me.saveas_button = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.save_button = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.add_tab_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textbox
        '
        Me.textbox.AcceptsReturn = True
        Me.textbox.AllowDrop = True
        Me.textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox.Location = New System.Drawing.Point(3, 112)
        Me.textbox.Multiline = True
        Me.textbox.Name = "textbox"
        Me.textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textbox.Size = New System.Drawing.Size(478, 381)
        Me.textbox.TabIndex = 0
        '
        'load_button
        '
        Me.load_button.Location = New System.Drawing.Point(12, 6)
        Me.load_button.Name = "load_button"
        Me.load_button.Size = New System.Drawing.Size(108, 70)
        Me.load_button.TabIndex = 1
        Me.load_button.Text = "Load"
        Me.load_button.UseVisualStyleBackColor = True
        '
        'saveas_button
        '
        Me.saveas_button.Location = New System.Drawing.Point(238, 6)
        Me.saveas_button.Name = "saveas_button"
        Me.saveas_button.Size = New System.Drawing.Size(99, 70)
        Me.saveas_button.TabIndex = 2
        Me.saveas_button.Text = "Save as"
        Me.saveas_button.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(487, 112)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(236, 381)
        Me.WebBrowser1.TabIndex = 3
        '
        'save_button
        '
        Me.save_button.Location = New System.Drawing.Point(126, 6)
        Me.save_button.Name = "save_button"
        Me.save_button.Size = New System.Drawing.Size(106, 70)
        Me.save_button.TabIndex = 4
        Me.save_button.Text = "Save"
        Me.save_button.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 77)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(720, 30)
        Me.ListBox1.TabIndex = 5
        '
        'add_tab_button
        '
        Me.add_tab_button.Location = New System.Drawing.Point(343, 6)
        Me.add_tab_button.Name = "add_tab_button"
        Me.add_tab_button.Size = New System.Drawing.Size(102, 70)
        Me.add_tab_button.TabIndex = 6
        Me.add_tab_button.Text = "Add Tab"
        Me.add_tab_button.UseVisualStyleBackColor = True
        '
        'text_doc_opener
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 521)
        Me.Controls.Add(Me.add_tab_button)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.save_button)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.saveas_button)
        Me.Controls.Add(Me.load_button)
        Me.Controls.Add(Me.textbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "text_doc_opener"
        Me.Text = "text_doc_opener"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textbox As System.Windows.Forms.TextBox
    Friend WithEvents load_button As System.Windows.Forms.Button
    Friend WithEvents saveas_button As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents save_button As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents add_tab_button As System.Windows.Forms.Button
End Class
