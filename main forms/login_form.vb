Imports System.IO
Public Class login_form
    Dim number_of_settings = 4

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

    Const default_settings = "bc:Black#c1:DarkGreen#c2:White#c3:LimeGreen"
    Const settings_file_name = "login_form_settings.txt"
    Dim settings() As String
    Dim colours() As Color


    Sub main_login(ByRef user_login As String, ByRef user_password As String)
        Dim login_details As StreamReader
        Dim login_details_array() As String

        Dim line As String = ""
        Dim username_verification As Boolean = False
        Dim password_verification As Boolean = False

        'Dim listboxs() As ListBox listboxs(0).Show()

        login_details = New StreamReader("main_Accounts.txt")

        line = login_details.ReadToEnd()

        login_details_array = line.Split(",")


        For n = 0 To (login_details_array.Length - 2)
            If (login_details_array(n) = ("un:" & user_login)) And (login_details_array(n + 1) = ("p:" & user_password)) Then
                username_verification = True
                password_verification = True

            End If
        Next

        login_details.Close()
        If username_verification = False And password_verification = False Then
            Exit Sub
        End If

        username_text_box.Clear()
        password_text_box.Clear()
        main_form.Show()
        hides()
    End Sub

    Sub main_register(ByRef user_login As String, ByRef user_password As String)
        Dim main_new_account As StreamWriter
        Dim main_account_details As String = ""
        Dim blank As Boolean = True

        If user_login.Trim = "" Or user_password.Trim = "" Then
            Exit Sub
        End If

        main_account_details = ("un:" & user_login.Trim & ",p:" & user_password.Trim & ",")

        main_new_account = New StreamWriter("main_Accounts.txt", True)

        main_new_account.Write(main_account_details)

        main_new_account.Close()

    End Sub

    Private Sub password_text_box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password_text_box.KeyPress
        If e.KeyChar = Chr(13) Then
            main_login(username_text_box.Text, password_text_box.Text)
        End If
        If e.KeyChar = Chr(13) Then

        End If
    End Sub

    Private Sub login_button_Click(sender As Object, e As EventArgs) Handles login_button.Click
        main_login(username_text_box.Text, password_text_box.Text)
    End Sub

    Private Sub register_button_Click(sender As Object, e As EventArgs) Handles register_button.Click
        main_register(username_text_box.Text, password_text_box.Text)
        username_text_box.Clear()
        password_text_box.Clear()
        username_text_box.Select()
    End Sub

    Private Sub username_text_box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username_text_box.KeyPress
        If e.KeyChar = Chr(Asc("ArrowDown")) Then
            password_text_box.Select()
        End If


    End Sub

    Private Sub login_form_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        username_text_box.Clear()
        password_text_box.Clear()
        username_text_box.Select()
    End Sub

    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_load()

    End Sub


    Private Sub login_form_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            Me.Location = New Point(0, 0)

            WindowState = FormWindowState.Maximized
            username_text_box.Width = Me.Width \ 5
            username_text_box.Height = Me.Height \ 50
            password_text_box.Width = Me.Width \ 5
            password_text_box.Height = Me.Width \ 50



        Catch ex As Exception

        End Try
    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub login_form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        form_load()
    End Sub
    Public Sub form_load()

        load_settings()

        username_text_box.Select()


        bubbles.PictureBox.SendToBack()
        username_text_box.Text.Remove(0, username_text_box.Text.Length)
        password_text_box.Text.Remove(0, password_text_box.Text.Length)

        PictureBox1.Width = Me.Width
        PictureBox1.Height = Me.Height

        'PictureBox1.BackColor = colours(0)

    End Sub
    Sub closing_form()
        Me.Close()
    End Sub

    Private Sub exit_button_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        closing_form()
    End Sub

    Private Sub login_form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

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
        Dim broshes() As Brush
        ' Dim h As Color = Color.FromName(colour.tostring)
        Dim number_of_broshes As Integer = 3
        For n = 0 To number_of_broshes - 1
            ' Dim colour As Color = (colours(n + 1))
            'Dim broshes(n) As SolidBrush(color.fromname(colour.tostring))
        Next

        For m = 0 To number_of_rows
            For n = 0 To number_of_columns2 - 1
                Try
                    Dim x As Integer = (n * (PictureBox1.Width / number_of_columns2)) \ 1
                    Dim y As Integer = ((m - 2) * (PictureBox1.Height / number_of_rows)) \ 1
                    If matrix_array(n, m) = "0" Then
                        t = "0"
                        e.Graphics.DrawString(t, f, broshes(0), x, y)
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
            x = rnd.Next(1, frequency)
            If x = 1 Then
                matrix_array(n, 2) = "1"
                matrix_array(n, 1) = "0*"
                matrix_array(n, 0) = "0**"
            End If
        Next
        PictureBox1.Refresh()
        'main_form.Refresh()
        For n = 0 To number_of_columns2 - 1
            For m = 0 To number_of_rows - 2

                matrix_array(number_of_columns2 - 1 - n, number_of_rows - 1 - m) = matrix_array(number_of_columns2 - 1 - n, number_of_rows - 2 - m)
            Next

        Next
        For n = 0 To number_of_columns2 - 1
            If matrix_array(n, 2) <> "1" Then
                matrix_array(n, 0) = ""
            End If
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If matrix_timer.Enabled = True Then
            matrix_timer.Stop()
        Else
            matrix_timer.Start()
        End If

    End Sub

    Private Sub color_button1_Click(sender As Object, e As EventArgs) Handles color_button1.Click
        ColorDialog1.ShowDialog()

        PictureBox1.BackColor = ColorDialog1.Color
    End Sub
    Sub load_settings()
        Dim text As String
        Dim again As Boolean = False
        'colours settings
        Do
            again = False

            If File.Exists("settings\" & settings_file_name) = True Then
                text = tools.file_reader("settings\" & settings_file_name)
                settings = text.Split("#")
                For n = 0 To number_of_settings - 1
                    'colours(n) = Color.FromName(settings(n).Remove(0, 3))
                Next

            ElseIf File.Exists("settings\" & settings_file_name) = False Then
                file_writer("settings\" & settings_file_name, default_settings, False, ".txt", False)
                again = True
            End If

        Loop Until again = False
        'colours settings

    End Sub



End Class