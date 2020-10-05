<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrambler_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrambler_form))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.load_text_file_button = New System.Windows.Forms.ToolStripButton()
        Me.scrambler_scramble_button = New System.Windows.Forms.ToolStripButton()
        Me.scrambler_textbox = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.load_text_file_button, Me.scrambler_scramble_button})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(769, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'load_text_file_button
        '
        Me.load_text_file_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.load_text_file_button.Image = CType(resources.GetObject("load_text_file_button.Image"), System.Drawing.Image)
        Me.load_text_file_button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.load_text_file_button.Name = "load_text_file_button"
        Me.load_text_file_button.Size = New System.Drawing.Size(23, 22)
        Me.load_text_file_button.Text = "load file"
        '
        'scrambler_scramble_button
        '
        Me.scrambler_scramble_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.scrambler_scramble_button.Image = CType(resources.GetObject("scrambler_scramble_button.Image"), System.Drawing.Image)
        Me.scrambler_scramble_button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.scrambler_scramble_button.Name = "scrambler_scramble_button"
        Me.scrambler_scramble_button.Size = New System.Drawing.Size(23, 22)
        Me.scrambler_scramble_button.Text = "Scramble"
        '
        'scrambler_textbox
        '
        Me.scrambler_textbox.Location = New System.Drawing.Point(0, 28)
        Me.scrambler_textbox.Multiline = True
        Me.scrambler_textbox.Name = "scrambler_textbox"
        Me.scrambler_textbox.Size = New System.Drawing.Size(625, 371)
        Me.scrambler_textbox.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 405)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(625, 46)
        Me.ProgressBar1.TabIndex = 2
        '
        'scrambler_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 463)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.scrambler_textbox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "scrambler_form"
        Me.Text = "scrambler_form"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents load_text_file_button As System.Windows.Forms.ToolStripButton
    Friend WithEvents scrambler_textbox As System.Windows.Forms.TextBox
    Friend WithEvents scrambler_scramble_button As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
