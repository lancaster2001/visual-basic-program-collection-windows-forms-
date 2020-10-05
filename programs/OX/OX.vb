Public Class OX

    Dim game As New OXgame

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles ox_PictureBox1.Paint

        game.draw(e.Graphics)

    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ox_PictureBox1.MouseClick
        Dim Row As Integer
        Dim Column As Integer


        Column = e.X \ (ox_PictureBox1.Width / OXGame.size)
        Row = e.Y \ (ox_PictureBox1.Height / OXGame.size)
        game.Click(Row, Column)
        ox_PictureBox1.Refresh()
    End Sub

    Private Sub NewGameButton_Click(sender As Object, e As EventArgs) Handles NewGameButton.Click
        game.NewGame()
        ox_PictureBox1.Refresh()

    End Sub

    Private Sub OX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading(Me)
    End Sub

    Private Sub OX_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ox_PictureBox1.Width = Me.Width - (Me.Width \ 20) - 12
        ox_PictureBox1.Height = Me.Height - (Me.Height \ 10) - 39
        ox_PictureBox1.Refresh()



    End Sub

    Private Sub OX_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        main_form.Show()
    End Sub

    Private Sub OX_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class