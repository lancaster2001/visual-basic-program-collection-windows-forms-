<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class graphs_form
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
        Me.graph_picturebox = New System.Windows.Forms.PictureBox()
        Me.listbox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Y_textbox = New System.Windows.Forms.TextBox()
        Me.X_textbox = New System.Windows.Forms.TextBox()
        Me.Y_label = New System.Windows.Forms.Label()
        Me.X_label = New System.Windows.Forms.Label()
        Me.input_textbox = New System.Windows.Forms.TextBox()
        Me.input_button = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.scale_factor = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.graph_picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.scale_factor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'graph_picturebox
        '
        Me.graph_picturebox.BackColor = System.Drawing.Color.DarkGreen
        Me.graph_picturebox.Location = New System.Drawing.Point(12, 20)
        Me.graph_picturebox.Name = "graph_picturebox"
        Me.graph_picturebox.Size = New System.Drawing.Size(737, 450)
        Me.graph_picturebox.TabIndex = 0
        Me.graph_picturebox.TabStop = False
        '
        'listbox1
        '
        Me.listbox1.FormattingEnabled = True
        Me.listbox1.Location = New System.Drawing.Point(6, 95)
        Me.listbox1.MultiColumn = True
        Me.listbox1.Name = "listbox1"
        Me.listbox1.Size = New System.Drawing.Size(63, 355)
        Me.listbox1.TabIndex = 3
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(75, 95)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(60, 355)
        Me.ListBox2.TabIndex = 4
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(75, 45)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(60, 20)
        Me.NumericUpDown1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.Y_textbox)
        Me.GroupBox1.Controls.Add(Me.X_textbox)
        Me.GroupBox1.Controls.Add(Me.Y_label)
        Me.GroupBox1.Controls.Add(Me.X_label)
        Me.GroupBox1.Controls.Add(Me.input_textbox)
        Me.GroupBox1.Controls.Add(Me.input_button)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.scale_factor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.listbox1)
        Me.GroupBox1.Location = New System.Drawing.Point(755, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 601)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Y_textbox
        '
        Me.Y_textbox.Location = New System.Drawing.Point(35, 539)
        Me.Y_textbox.Name = "Y_textbox"
        Me.Y_textbox.Size = New System.Drawing.Size(100, 20)
        Me.Y_textbox.TabIndex = 14
        '
        'X_textbox
        '
        Me.X_textbox.Location = New System.Drawing.Point(35, 516)
        Me.X_textbox.Name = "X_textbox"
        Me.X_textbox.Size = New System.Drawing.Size(100, 20)
        Me.X_textbox.TabIndex = 13
        '
        'Y_label
        '
        Me.Y_label.AutoSize = True
        Me.Y_label.Location = New System.Drawing.Point(3, 539)
        Me.Y_label.Name = "Y_label"
        Me.Y_label.Size = New System.Drawing.Size(14, 13)
        Me.Y_label.TabIndex = 12
        Me.Y_label.Text = "Y"
        '
        'X_label
        '
        Me.X_label.AutoSize = True
        Me.X_label.Location = New System.Drawing.Point(3, 516)
        Me.X_label.Name = "X_label"
        Me.X_label.Size = New System.Drawing.Size(14, 13)
        Me.X_label.TabIndex = 7
        Me.X_label.Text = "X"
        '
        'input_textbox
        '
        Me.input_textbox.Location = New System.Drawing.Point(0, 475)
        Me.input_textbox.Name = "input_textbox"
        Me.input_textbox.Size = New System.Drawing.Size(100, 20)
        Me.input_textbox.TabIndex = 10
        '
        'input_button
        '
        Me.input_button.Location = New System.Drawing.Point(106, 472)
        Me.input_button.Name = "input_button"
        Me.input_button.Size = New System.Drawing.Size(62, 23)
        Me.input_button.TabIndex = 9
        Me.input_button.Text = "Button1"
        Me.input_button.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(21, 446)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 7
        '
        'scale_factor
        '
        Me.scale_factor.Location = New System.Drawing.Point(75, 16)
        Me.scale_factor.Name = "scale_factor"
        Me.scale_factor.Size = New System.Drawing.Size(60, 20)
        Me.scale_factor.TabIndex = 8
        Me.scale_factor.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Degree"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Scale Factor"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'graphs_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 645)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.graph_picturebox)
        Me.Name = "graphs_form"
        Me.Text = "Form1"
        CType(Me.graph_picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.scale_factor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents graph_picturebox As System.Windows.Forms.PictureBox
    Friend WithEvents listbox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents scale_factor As System.Windows.Forms.NumericUpDown
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents input_textbox As System.Windows.Forms.TextBox
    Friend WithEvents input_button As System.Windows.Forms.Button
    Friend WithEvents Y_textbox As System.Windows.Forms.TextBox
    Friend WithEvents X_textbox As System.Windows.Forms.TextBox
    Friend WithEvents Y_label As System.Windows.Forms.Label
    Friend WithEvents X_label As System.Windows.Forms.Label
End Class
