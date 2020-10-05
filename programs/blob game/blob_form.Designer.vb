<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class blobform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(blobform))
        Me.blob_picture = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.blob_score = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.blob_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'blob_picture
        '
        Me.blob_picture.BackColor = System.Drawing.Color.PaleTurquoise
        resources.ApplyResources(Me.blob_picture, "blob_picture")
        Me.blob_picture.Name = "blob_picture"
        Me.blob_picture.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'blob_score
        '
        resources.ApplyResources(Me.blob_score, "blob_score")
        Me.blob_score.Name = "blob_score"
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'blobform
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.blob_score)
        Me.Controls.Add(Me.blob_picture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "blobform"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.blob_picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents blob_picture As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents blob_score As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
