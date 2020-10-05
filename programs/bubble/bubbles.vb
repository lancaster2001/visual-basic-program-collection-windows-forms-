Public Class bubbles
    Public Const initial_speed = 5
    Public speed = initial_speed
    Dim Bubble1 As Bubble
    Dim Bubble2 As Bubble
    Public Const number_of_bubbles As Integer = 100
    Dim max_size As Integer = 80

    Dim gh As Integer
    Dim bubbles_array(number_of_bubbles) As Bubble
    Private Key As String
    Shared rnd As New Random


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading(Me)
        Me.Timer1.Start()

        For n = 0 To number_of_bubbles - 1

            bubbles_array(n) = New Bubble(rnd.Next(0, PictureBox.Width - max_size), PictureBox.Height, rnd.Next(10, max_size), n)
            bubble_progress_bar.Increment(number_of_bubbles \ 100)
        Next
        bubble_progress_bar.Hide()
    End Sub
    Public Sub new_bubble(bubblenumber As Integer)



        bubbles_array(bubblenumber) = New Bubble(rnd.Next(0, PictureBox.Width - max_size), PictureBox.Height, rnd.Next(10, max_size), bubblenumber)
       

        
    End Sub


    Private Sub PictureBox_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox.Paint

 
        For n = 0 To number_of_bubbles - 1

            bubbles_array(n).Paint(e.Graphics)

        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        PictureBox.Refresh()
        For n = 0 To number_of_bubbles - 1
            Try
                bubbles_array(n).Move(speed)
            Catch ex As Exception

            End Try

        Next


    End Sub

    Private Sub bubbles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(Asc("P")) Then
            Me.Close()
            main_form.Show()
        End If
    End Sub

    Private Sub bubbles_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        PictureBox.Width = Me.Width
        PictureBox.Height = Me.Height
        bubble_progress_bar.Width = Me.Width \ 5
        bubble_progress_bar.Height = Me.Height \ 20
        bubble_progress_bar.Location.Offset(((Me.Width \ 10) * 4.5), (Me.Height \ 100))

    End Sub

    Private Sub bubbles_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        Key = e.KeyCode.ToString.ToUpper

        Select Case Key
            Case "E"
                speed = 2
        End Select
    End Sub

    Private Sub bubbles_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        speed = initial_speed
    End Sub

    Private Sub bubbles_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        main_form.Show()
    End Sub
End Class
