Public Class scrambler_form

    Private Sub scrambler_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading(Me)
    End Sub

    Private Sub load_text_file_button_Click(sender As Object, e As EventArgs) Handles load_text_file_button.Click
        scrambler_textbox.Text = open_scrambler_text_file()

    End Sub

    Private Sub scrambler_scramble_button_Click(sender As Object, e As EventArgs) Handles scrambler_scramble_button.Click
        scrambler_textbox.Text = scrambler_text(scrambler_textbox.Text)

    End Sub

    Private Sub scrambler_form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            main_form.Show()
        End If
    End Sub
End Class