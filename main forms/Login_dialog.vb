Imports System.Windows.Forms
Imports System.IO
Public Class Login_dialog

    Public user As New user
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

   

    Private Sub Login_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OK_Button.Hide()
        Dim user_details As New user_details

    End Sub





    Public ticker As Boolean
    Public number_of_items_in_column_of_listbox1 As Integer = 1
    Public number_of_columns As Double = 5
    Dim rnd As New Random
    Public frequency As Integer = 10  '1/x
    Public number_of_columns2 As Integer = 50
    Public number_of_rows As Integer = (((number_of_columns2 * (2 / 3))) - 1)
    Public matrix_array(number_of_columns2, number_of_rows) As String
    Dim back_color_dialog As ColorDialog
    Dim back_color As Color



    Private Sub password_textbox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            login_sub(username_textbox.Text, password_textbox.Text)
        End If
    End Sub

    Private Sub login_button_Click(sender As Object, e As EventArgs) Handles login_menu_login_button.Click

        user.logged_in = login_sub(username_textbox.Text, password_textbox.Text)
        If user.logged_in = True Then
            set_user_details()
        End If
    End Sub



    Private Sub username_textbox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(Asc("ArrowDown")) Then
            password_textbox.Select()
        End If


    End Sub

    Private Sub login_form_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        username_textbox.Clear()
        password_textbox.Clear()
        username_textbox.Select()
    End Sub

    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_load()

    End Sub


    Private Sub login_form_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            Me.Location = New Point(0, 0)

            WindowState = FormWindowState.Maximized
            username_textbox.Width = Me.Width \ 5
            username_textbox.Height = Me.Height \ 50
            password_textbox.Width = Me.Width \ 5
            password_textbox.Height = Me.Width \ 50



        Catch ex As Exception

        End Try
    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub login_form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        form_load()
    End Sub
    Public Sub form_load()
        menu_dialog.Hide()
        login_dialog_load_settings(user.file_location)

        username_textbox.Select()


        bubbles.PictureBox.SendToBack()
        username_textbox.Text.Remove(0, username_textbox.Text.Length)
        password_textbox.Text.Remove(0, password_textbox.Text.Length)

        PictureBox1.Width = Me.Width
        PictureBox1.Height = Me.Height

        'PictureBox1.BackColor = colours(0)

    End Sub
    Sub closing_form()


        Me.Close()
    End Sub


    Private Sub login_form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            user.logged_in = login_sub(username_textbox.Text, password_textbox.Text)
            If user.logged_in = True Then
                set_user_details()
            End If
        End If
    End Sub

    Private Sub login_form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If MousePosition.Y >= (Me.Height \ 20) Then

        End If
    End Sub

    Private Sub hides()
        Me.Hide()
        bubbles.Close()
        bubbles.speed = bubbles.initial_speed
        bubbles.Timer1.Stop()
    End Sub


    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Dim f As Font = New Font("Arial", (PictureBox1.Width \ number_of_columns2), FontStyle.Regular)
        Dim t As String
        For m = 0 To number_of_rows
            For n = 0 To number_of_columns2 - 1
                Try
                    Dim x As Integer = (n * (PictureBox1.Width / number_of_columns2)) \ 1
                    Dim y As Integer = ((m - 2) * (PictureBox1.Height / number_of_rows)) \ 1
                    If matrix_array(n, m) = Nothing Then

                    ElseIf matrix_array(n, m) = "0" Then
                        t = "0"
                        e.Graphics.DrawString(t, f, Brushes.DarkGreen, x, y)
                    ElseIf matrix_array(n, m) = "0*" Then
                        t = "0"
                        e.Graphics.DrawString(t, f, Brushes.White, x, y)
                    ElseIf matrix_array(n, m) = "0**" Then
                        t = "0"
                        e.Graphics.DrawString(t, f, Brushes.LimeGreen, x, y)
                    ElseIf matrix_array(n, m) = "1" Then
                        t = "1"
                        e.Graphics.DrawString(t, f, Brushes.White, x, y)
                    End If
                Catch ex As Exception

                End Try
            Next
        Next
    End Sub

    Private Sub matrix_timer_Tick(sender As Object, e As EventArgs) Handles matrix_timer.Tick
        Dim x As Integer

        For n = 0 To number_of_columns2 - 1
            For m = 0 To number_of_rows - 2

                matrix_array(number_of_columns2 - 1 - n, number_of_rows - 1 - m) = matrix_array(number_of_columns2 - 1 - n, number_of_rows - 2 - m)

            Next

        Next

        For n = 0 To number_of_columns2 - 1
            x = rnd.Next(1, frequency)
            If x = 1 Then
                ' matrix_array(n, 3) = "1"
                '  matrix_array(n, 2) = "0*"
                ' matrix_array(n, 1) = "0**"
                matrix_array(n, 0) = "1"
            End If
        Next


        For m = 1 To number_of_columns2
            If matrix_array(number_of_columns2 - m, 3) = "1" Then
                matrix_array(number_of_columns2 - m, 2) = "0*"
                matrix_array(number_of_columns2 - m, 1) = "0**"
                matrix_array(number_of_columns2 - m, 0) = "0"
            ElseIf matrix_array(number_of_columns2 - m, 2) = "1" Then
                matrix_array(number_of_columns2 - m, 1) = "0*"
                matrix_array(number_of_columns2 - m, 0) = "0**"
            ElseIf matrix_array(number_of_columns2 - m, 1) = "1" Then
                matrix_array(number_of_columns2 - m, 0) = "0*"
            End If
        Next

        For n = 0 To number_of_columns2 - 1
            For m = 0 To number_of_rows - 5
                If matrix_array(number_of_columns2 - 1 - n, number_of_rows - 1 - m) = ("1") And matrix_array(number_of_columns2 - 1 - n, number_of_rows - 2 - m) = matrix_array(number_of_columns2 - 1 - n, number_of_rows - 5 - m) = ("0") Then
                    matrix_array(number_of_columns2 - 1 - n, number_of_rows - 5 - m) = Nothing
                End If


            Next
        Next
        PictureBox1.Refresh()
    End Sub



    Private Sub color_button1_Click(sender As Object, e As EventArgs) Handles color_button1.Click

    End Sub
    


    Private Sub register_button_Click_1(sender As Object, e As EventArgs) Handles register_button.Click
        Me.Hide()
        register_dialog.Show()
    End Sub
    Private Sub set_user_details()
        user.username = username_textbox.Text.Trim
        user.password = password_textbox.Text.Trim
        user.file_location = ("settings\user_settings\" & user.username & "\")
        user.displayname = login_dialog_load_display_name(user.file_location)
        Me.Close()
        main_menu_dialog_load()
    End Sub

    Private Sub Login_dialog_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        main_form.Show()
    End Sub
End Class
