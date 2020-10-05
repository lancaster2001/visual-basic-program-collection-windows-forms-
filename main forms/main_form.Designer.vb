<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_form))
        Me.name_list_button = New System.Windows.Forms.Button()
        Me.bubbles_button = New System.Windows.Forms.Button()
        Me.blob_button = New System.Windows.Forms.Button()
        Me.OX_Game_button = New System.Windows.Forms.Button()
        Me.RPG = New System.Windows.Forms.Button()
        Me.text_doc_opener_button = New System.Windows.Forms.Button()
        Me.console_program_button = New System.Windows.Forms.Button()
        Me.graph_button = New System.Windows.Forms.Button()
        Me.main_toolstrip = New System.Windows.Forms.ToolStrip()
        Me.main_menu_dialog_button = New System.Windows.Forms.ToolStripButton()
        Me.scrambler_button = New System.Windows.Forms.Button()
        Me.main_toolstrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'name_list_button
        '
        Me.name_list_button.Location = New System.Drawing.Point(302, 0)
        Me.name_list_button.Name = "name_list_button"
        Me.name_list_button.Size = New System.Drawing.Size(138, 182)
        Me.name_list_button.TabIndex = 3
        Me.name_list_button.Text = "Names list"
        Me.name_list_button.UseVisualStyleBackColor = True
        '
        'bubbles_button
        '
        Me.bubbles_button.AutoSize = True
        Me.bubbles_button.Location = New System.Drawing.Point(152, 0)
        Me.bubbles_button.Name = "bubbles_button"
        Me.bubbles_button.Size = New System.Drawing.Size(153, 182)
        Me.bubbles_button.TabIndex = 2
        Me.bubbles_button.Text = "bubbles"
        Me.bubbles_button.UseVisualStyleBackColor = True
        '
        'blob_button
        '
        Me.blob_button.Location = New System.Drawing.Point(3, 0)
        Me.blob_button.Name = "blob_button"
        Me.blob_button.Size = New System.Drawing.Size(152, 182)
        Me.blob_button.TabIndex = 1
        Me.blob_button.Text = "blob"
        Me.blob_button.UseVisualStyleBackColor = True
        '
        'OX_Game_button
        '
        Me.OX_Game_button.Location = New System.Drawing.Point(434, 0)
        Me.OX_Game_button.Name = "OX_Game_button"
        Me.OX_Game_button.Size = New System.Drawing.Size(149, 182)
        Me.OX_Game_button.TabIndex = 4
        Me.OX_Game_button.Text = "OX Game"
        Me.OX_Game_button.UseVisualStyleBackColor = True
        '
        'RPG
        '
        Me.RPG.Location = New System.Drawing.Point(3, 324)
        Me.RPG.Name = "RPG"
        Me.RPG.Size = New System.Drawing.Size(152, 166)
        Me.RPG.TabIndex = 6
        Me.RPG.Text = "RPG"
        Me.RPG.UseVisualStyleBackColor = True
        '
        'text_doc_opener_button
        '
        Me.text_doc_opener_button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.text_doc_opener_button.Location = New System.Drawing.Point(3, 179)
        Me.text_doc_opener_button.Name = "text_doc_opener_button"
        Me.text_doc_opener_button.Size = New System.Drawing.Size(152, 146)
        Me.text_doc_opener_button.TabIndex = 5
        Me.text_doc_opener_button.Text = "text opener"
        Me.text_doc_opener_button.UseVisualStyleBackColor = True
        '
        'console_program_button
        '
        Me.console_program_button.Location = New System.Drawing.Point(152, 179)
        Me.console_program_button.Name = "console_program_button"
        Me.console_program_button.Size = New System.Drawing.Size(153, 146)
        Me.console_program_button.TabIndex = 7
        Me.console_program_button.Text = "Console Program"
        Me.console_program_button.UseVisualStyleBackColor = True
        '
        'graph_button
        '
        Me.graph_button.Location = New System.Drawing.Point(302, 179)
        Me.graph_button.Name = "graph_button"
        Me.graph_button.Size = New System.Drawing.Size(138, 146)
        Me.graph_button.TabIndex = 8
        Me.graph_button.Text = "Graphs"
        Me.graph_button.UseVisualStyleBackColor = True
        '
        'main_toolstrip
        '
        Me.main_toolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.main_menu_dialog_button})
        Me.main_toolstrip.Location = New System.Drawing.Point(0, 0)
        Me.main_toolstrip.Name = "main_toolstrip"
        Me.main_toolstrip.Size = New System.Drawing.Size(1057, 25)
        Me.main_toolstrip.TabIndex = 9
        Me.main_toolstrip.Text = "ToolStrip1"
        '
        'main_menu_dialog_button
        '
        Me.main_menu_dialog_button.CheckOnClick = True
        Me.main_menu_dialog_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.main_menu_dialog_button.Image = CType(resources.GetObject("main_menu_dialog_button.Image"), System.Drawing.Image)
        Me.main_menu_dialog_button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.main_menu_dialog_button.Name = "main_menu_dialog_button"
        Me.main_menu_dialog_button.Size = New System.Drawing.Size(23, 22)
        Me.main_menu_dialog_button.Text = "ToolStripButton1"
        '
        'scrambler_button
        '
        Me.scrambler_button.Location = New System.Drawing.Point(589, 28)
        Me.scrambler_button.Name = "scrambler_button"
        Me.scrambler_button.Size = New System.Drawing.Size(143, 154)
        Me.scrambler_button.TabIndex = 9
        Me.scrambler_button.Text = "Scrambler"
        Me.scrambler_button.UseVisualStyleBackColor = True
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 488)
        Me.Controls.Add(Me.main_toolstrip)
        Me.Controls.Add(Me.graph_button)
        Me.Controls.Add(Me.console_program_button)
        Me.Controls.Add(Me.text_doc_opener_button)
        Me.Controls.Add(Me.RPG)
        Me.Controls.Add(Me.OX_Game_button)
        Me.Controls.Add(Me.blob_button)
        Me.Controls.Add(Me.bubbles_button)
        Me.Controls.Add(Me.name_list_button)
        Me.Controls.Add(Me.scrambler_button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "main_form"
        Me.main_toolstrip.ResumeLayout(False)
        Me.main_toolstrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents name_list_button As System.Windows.Forms.Button
    Friend WithEvents bubbles_button As System.Windows.Forms.Button
    Friend WithEvents OX_Game_button As System.Windows.Forms.Button
    Friend WithEvents RPG As System.Windows.Forms.Button
    Friend WithEvents text_doc_opener_button As System.Windows.Forms.Button
    Friend WithEvents console_program_button As System.Windows.Forms.Button
    Friend WithEvents graph_button As System.Windows.Forms.Button
    Friend WithEvents main_toolstrip As System.Windows.Forms.ToolStrip
    Friend WithEvents main_menu_dialog_button As System.Windows.Forms.ToolStripButton
    Public WithEvents blob_button As System.Windows.Forms.Button
    Friend WithEvents scrambler_button As System.Windows.Forms.Button
End Class
