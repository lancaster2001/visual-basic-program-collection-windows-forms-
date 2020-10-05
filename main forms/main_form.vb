Public Class main_form
    'variables]
    Const number_of_rows = 3
    Dim number_of_buttons() As String = {5, 3, 1}
    Dim buttons() As Object


    'variables



    'load
    Private Sub main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading(Me)
        Dim user_details As New user
  
    End Sub
    'load



    'clicks
    Private Sub name_list_button_Click(sender As Object, e As EventArgs) Handles name_list_button.Click
        names_form.Show()
        Me.Hide()
    End Sub
    Private Sub bubbles_button_Click(sender As Object, e As EventArgs) Handles bubbles_button.Click
        bubbles.Show()
        Me.Hide()
    End Sub
    Private Sub blob_button_Click(sender As Object, e As EventArgs) Handles blob_button.Click
        blobform.Show()
        Me.Hide()
    End Sub
    Private Sub OX_Game_Click(sender As Object, e As EventArgs) Handles OX_Game_button.Click
        OX.Show()
        Me.Hide()
    End Sub
    Private Sub RPG_Click(sender As Object, e As EventArgs) Handles RPG.Click
        rpg_form.Show()
        Me.Hide()
    End Sub
    Private Sub text_doc_opener_button_Click(sender As Object, e As EventArgs) Handles text_doc_opener_button.Click
        text_doc_opener.Show()
        Me.Hide()

    End Sub
    Private Sub console_program_button_Click(sender As Object, e As EventArgs) Handles console_program_button.Click
        MsgBox("WIP")
    End Sub
    Private Sub graph_button_Click(sender As Object, e As EventArgs) Handles graph_button.Click
        graphs_form.Show()
        Me.Hide()
    End Sub
    'clicks


    'close
    Private Sub main_form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub
    'close



    'paints
    Private Sub console_program_button_Paint(sender As Object, e As PaintEventArgs) Handles console_program_button.Paint
        button_paint(e.Graphics, console_program_button.Location.X, console_program_button.Location.Y)
    End Sub
    Private Sub bubbles_button_Paint(sender As Object, e As PaintEventArgs) Handles bubbles_button.Paint
        button_paint(e.Graphics, bubbles_button.Location.X, bubbles_button.Location.Y)
    End Sub
    Private Sub blob_button_Paint(sender As Object, e As PaintEventArgs) Handles blob_button.Paint
        button_paint(e.Graphics, blob_button.Location.X, blob_button.Location.Y)
    End Sub
    Private Sub name_list_button_Paint(sender As Object, e As PaintEventArgs) Handles name_list_button.Paint
        button_paint(e.Graphics, name_list_button.Location.X, name_list_button.Location.Y)
    End Sub
    Private Sub OX_Game_button_Paint(sender As Object, e As PaintEventArgs) Handles OX_Game_button.Paint
        button_paint(e.Graphics, OX_Game_button.Location.X, OX_Game_button.Location.Y)
    End Sub
    Private Sub text_doc_opener_button_Paint(sender As Object, e As PaintEventArgs) Handles text_doc_opener_button.Paint
        button_paint(e.Graphics, text_doc_opener_button.Location.X, text_doc_opener_button.Location.Y)
    End Sub
    Private Sub graph_button_Paint(sender As Object, e As PaintEventArgs) Handles graph_button.Paint
        button_paint(e.Graphics, graph_button.Location.X, graph_button.Location.Y)
    End Sub
    Private Sub RPG_Paint(sender As Object, e As PaintEventArgs) Handles RPG.Paint
        button_paint(e.Graphics, RPG.Location.X, RPG.Location.Y)
    End Sub
    Sub button_paint(e As Graphics, x2 As Integer, y2 As Integer)

    End Sub

    'paints




    Private Sub main_form_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        buttons = {blob_button, bubbles_button, name_list_button, OX_Game_button, scrambler_button,
                text_doc_opener_button, console_program_button, graph_button,
                RPG}

        main_form_organiser(Me, buttons, number_of_buttons, number_of_rows, main_toolstrip)
    End Sub
    

    Private Sub main_form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.E Then
            main_form_organiser(Me, buttons, number_of_buttons, number_of_rows)
        End If
    End Sub

    Private Sub main_menu_dialog_button_Click(sender As Object, e As EventArgs) Handles main_menu_dialog_button.Click
        If sender.checked = True Then
            main_menu_dialog_load()
        ElseIf sender.checked = False Then
            main_menu_dialog_close()
        End If
    End Sub

    Private Sub scrambler_button_Click(sender As Object, e As EventArgs) Handles scrambler_button.Click
        scrambler_form.Show()
        Me.Hide()
    End Sub
End Class