Public Class blobform
    Public Const number_of_obsticles = 10
    Public Const max_number_of_player_parts = 20

    Dim rnd As New Random
    Public number_of_player_parts As Integer = 1
    Private score As Integer = 0
    Public player(max_number_of_player_parts) As Blob
    Public obstical(number_of_obsticles) As blob_obsical_class
    Public pelet As pelet2
    Private Key As String

    Private Sub blobform_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        blob_picture.Width = Me.Width
        blob_picture.Height = Me.Height

    End Sub



    Private Sub blob_picture_Paint(sender As Object, e As PaintEventArgs) Handles blob_picture.Paint
        For n = 0 To number_of_player_parts - 1
            player(n).Draw(e.Graphics)
        Next

        For n = 0 To number_of_obsticles - 1
            obstical(n).draw_rectangle(e.Graphics)
        Next
        pelet.draw_rectangle(e.Graphics)
    End Sub

    Private Sub blobform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading(Me)
        pelet = New pelet2
        For n = 0 To number_of_player_parts - 1
            player(n) = New Blob
        Next

        For n = 0 To number_of_obsticles - 1
            obstical(n) = New blob_obsical_class(blob_picture, number_of_obsticles)
        Next
        pelet = New pelet2
    End Sub

 
    Private Sub blob_picture_Resize(sender As Object, e As EventArgs) Handles blob_picture.Resize
        blob_picture.Width = Me.Width
        blob_picture.Height = Me.Height
    End Sub

    Private Sub detect_Collision(n As Integer)
        Dim hit As Boolean = False
        Dim pelet_hit As Boolean = False
        For n = 0 To number_of_player_parts - 1
            For m = 0 To number_of_obsticles - 1
                hit = player(n).hasithit(obstical(m).X, obstical(m).Y, obstical(m).width, obstical(m).height)


                If hit = True Then
                    dead()
                    Exit Sub
                End If
            Next
        Next
        For n = 0 To number_of_player_parts - 1
            pelet_hit = player(n).hasithit(pelet.X, pelet.Y, pelet.width, pelet.length)


            If pelet_hit = True Then
                score += 1000 * (number_of_player_parts * 0.5)
                number_of_player_parts += 1
                player(number_of_player_parts - 1) = New Blob(pelet.X, pelet.Y, pelet.width, pelet.length)

                player(number_of_player_parts - 1).current_direction = player(0).current_direction
                player(number_of_player_parts - 1).multiplier = player(0).multiplier
                player(number_of_player_parts - 1).sped_up_multiplier = player(0).sped_up_multiplier
                player(number_of_player_parts - 1).Move(player(number_of_player_parts - 1).current_direction)


                pelet = New pelet2
                'For n = 0 To number_of_obsticles - 1
                'obstical(n) = New blob_obsical_class
                'Next
            End If
        Next
    End Sub

    Private Sub blobform_Keypress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        Key = e.KeyCode.ToString.ToUpper
        For n = 0 To number_of_player_parts - 1


            Select Case Key
                Case "W"

                    player(n).current_direction = ("N")

                Case "A"

                    player(n).current_direction = ("W")

                Case "S"

                    player(n).current_direction = ("S")

                Case "D"

                    player(n).current_direction = ("E")

                Case "E"

                    player(n).current_direction = ("NE")

                Case "Q"

                    player(n).current_direction = ("NW")

                Case "C"

                    player(n).current_direction = ("SE")

                Case "Z"

                    player(n).current_direction = ("SW")

                Case "X"
                    If player(n).multiplier = player(n).sped_up_multiplier Then
                        player(n).multiplier = player(n).initial_multiplier

                    ElseIf player(n).multiplier = player(n).initial_multiplier Then
                        player(n).multiplier = player(n).sped_up_multiplier
                    End If
                Case "P"
                    main_form.Show()
                    Me.Close()
            End Select
        Next

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            For n = 0 To number_of_player_parts - 1
                player(n).Move(player(0).current_direction)
            Next

            For n = 0 To number_of_obsticles - 1
                detect_Collision(n)
            Next
            blob_picture.Refresh()




            Try
                Timer1.Interval = ((number_of_obsticles * 1000) \ score)
                For n = 0 To number_of_obsticles - 1
                    Dim try3 As Integer = rnd.Next(0, number_of_obsticles - 1)
                    Dim try2 As Integer = rnd.Next(0, number_of_obsticles - 1)
                    If try2 = try3 Then
                        obstical(n).move(blob_picture)

                    End If

                Next
                blob_picture.Refresh()
            Catch ex As Exception
            End Try

        Catch ex As Exception

        End Try

    End Sub

    Private Sub blobform_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        main_form.Show()

    End Sub

    Private Sub blob_score_TextChanged(sender As Object, e As EventArgs) Handles blob_score.TextChanged

    End Sub


    Public Sub dead()


        Me.Close()



    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            For n = 0 To number_of_player_parts - 1
                If player(n).current_direction <> "" Then
                    score -= 1
                    blob_score.Text = ("Score:" & score)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

End Class