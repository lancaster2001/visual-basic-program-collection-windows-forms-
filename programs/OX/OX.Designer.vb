<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OX
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
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.ox_PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PlayerLabel = New System.Windows.Forms.Label()
        CType(Me.ox_PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewGameButton
        '
        Me.NewGameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewGameButton.Location = New System.Drawing.Point(193, -1)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(111, 34)
        Me.NewGameButton.TabIndex = 3
        Me.NewGameButton.Text = "New Game"
        Me.NewGameButton.UseVisualStyleBackColor = True
        '
        'ox_PictureBox1
        '
        Me.ox_PictureBox1.BackColor = System.Drawing.Color.White
        Me.ox_PictureBox1.Location = New System.Drawing.Point(12, 39)
        Me.ox_PictureBox1.Name = "ox_PictureBox1"
        Me.ox_PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.ox_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ox_PictureBox1.TabIndex = 4
        Me.ox_PictureBox1.TabStop = False
        '
        'PlayerLabel
        '
        Me.PlayerLabel.AutoSize = True
        Me.PlayerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerLabel.Location = New System.Drawing.Point(1, -1)
        Me.PlayerLabel.Name = "PlayerLabel"
        Me.PlayerLabel.Size = New System.Drawing.Size(186, 24)
        Me.PlayerLabel.TabIndex = 5
        Me.PlayerLabel.Text = "Player X it's your turn"
        '
        'OX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 425)
        Me.Controls.Add(Me.PlayerLabel)
        Me.Controls.Add(Me.ox_PictureBox1)
        Me.Controls.Add(Me.NewGameButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "OX"
        Me.Text = "OX"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ox_PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewGameButton As System.Windows.Forms.Button
    Friend WithEvents ox_PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerLabel As System.Windows.Forms.Label
End Class
