<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class category_form
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
        Me.assorted_button = New System.Windows.Forms.Button()
        Me.usefull_button = New System.Windows.Forms.Button()
        Me.project_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'assorted_button
        '
        Me.assorted_button.Dock = System.Windows.Forms.DockStyle.Left
        Me.assorted_button.Location = New System.Drawing.Point(0, 0)
        Me.assorted_button.Name = "assorted_button"
        Me.assorted_button.Size = New System.Drawing.Size(222, 501)
        Me.assorted_button.TabIndex = 0
        Me.assorted_button.Text = "random"
        Me.assorted_button.UseVisualStyleBackColor = True
        '
        'usefull_button
        '
        Me.usefull_button.Dock = System.Windows.Forms.DockStyle.Left
        Me.usefull_button.Location = New System.Drawing.Point(222, 0)
        Me.usefull_button.Name = "usefull_button"
        Me.usefull_button.Size = New System.Drawing.Size(197, 501)
        Me.usefull_button.TabIndex = 1
        Me.usefull_button.Text = "Useful"
        Me.usefull_button.UseVisualStyleBackColor = True
        '
        'project_button
        '
        Me.project_button.Dock = System.Windows.Forms.DockStyle.Left
        Me.project_button.Location = New System.Drawing.Point(419, 0)
        Me.project_button.Name = "project_button"
        Me.project_button.Size = New System.Drawing.Size(205, 501)
        Me.project_button.TabIndex = 2
        Me.project_button.Text = "project"
        Me.project_button.UseVisualStyleBackColor = True
        '
        'category_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 501)
        Me.Controls.Add(Me.project_button)
        Me.Controls.Add(Me.usefull_button)
        Me.Controls.Add(Me.assorted_button)
        Me.Name = "category_form"
        Me.Text = "category_form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents assorted_button As System.Windows.Forms.Button
    Friend WithEvents usefull_button As System.Windows.Forms.Button
    Friend WithEvents project_button As System.Windows.Forms.Button
End Class
