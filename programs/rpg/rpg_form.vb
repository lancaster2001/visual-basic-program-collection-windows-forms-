Imports System.Threading
Public Class rpg_form
    Dim clicked As Boolean = False
    Dim questions() As String = {"what is your character's gender?", "how old is your character?", "?"}

    Private Structure createing_character_structure

    End Structure


    Private Sub pick_character_button_Click(sender As Object, e As EventArgs) Handles pick_character_button.Click
        'pick_character()
    End Sub

    Private Sub create_character_button_Click(sender As Object, e As EventArgs) Handles create_character_button.Click
        'rpg.create_character(login_form.username_text_box.Text.ToString)
        create_character()
    End Sub

    Private Sub rpg_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading(Me)
        button_test.Hide()
        label_test.Hide()
        user_input_test.Hide()
        Button1.Hide()
        Button2.Hide()
    End Sub
    Public Sub create_character()
        pick_character_button.Hide()
        create_character_button.Hide()

        button_test.Show()


        'question gender
        label_test.Show()
        label_test.Text.Remove(0, label_test.Text.Length - 1)
        label_test.Text.Insert(0, questions(1))
        Button1.Text = "male"
        Button1.Show()
        Button1.Text = "female"
        Button2.Show()

        'question gender

        '



        While clicked = False
            Thread.Sleep(100)
            Application.DoEvents()
        End While
        clicked = False
    End Sub

    Private Sub button_test_Click(sender As Object, e As EventArgs) Handles button_test.Click
        clicked = True
    End Sub

    Private Sub rpg_form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        main_form.Show()
    End Sub

    Private Sub rpg_form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class