
Public Class OXGame
    Public Const size = 3

    Private grid(size - 1, size - 1) As Char
    Private player As Char
    Private streak As Integer


    Public Sub New()

        NewGame()

    End Sub
    Public Sub win()
        OX.Close()
        main_form.Show()
    End Sub

    Public Sub check_for_win(player As String, row As Integer, column As Integer)
        streak = 0
        For n = 0 To 2

            For m = -1 To 1

                streak = 0
                If n <> 0 And m <> 0 Then
                    Try
                        If player = grid(row + n, column + m) Then
                            For b = 1 To size - 1
                                If player = grid(row + (b * n), column + (b * m)) Then
                                    streak += 1
                                    If streak = size - 1 Then
                                        'win()

                                    End If
                                Else

                                    streak = 0
                                End If
                            Next
                        End If

                    Catch ex As Exception
                        streak = 0
                    End Try
                End If
            Next
        Next

    End Sub

    Public Sub Click(Row As Integer, Column As Integer)

        If grid(Row, Column) = " " Then
            grid(Row, Column) = player

            check_for_win(player, Row, Column)

            If player = "X" Then
                player = "O"
            Else
                player = "X"
            End If
        End If

    End Sub

    Public Sub Draw(g As Graphics)

        ' draw the grid
        Dim pen As New Pen(Brushes.Black, 5)
        For n = 1 To size - 1
            g.DrawLine(pen, ((OX.ox_PictureBox1.Width \ size) * n), 0, (OX.ox_PictureBox1.Width \ size) * n, OX.ox_PictureBox1.Height)
            g.DrawLine(pen, 0, ((OX.ox_PictureBox1.Height \ size) * n), OX.ox_PictureBox1.Width, ((OX.ox_PictureBox1.Height \ size) * n))
        Next

        For Row = 0 To size - 1
            For Column = 0 To size - 1
                Dim X As Integer = Column * (OX.ox_PictureBox1.Width \ size)
                Dim Y As Integer = Row * (OX.ox_PictureBox1.Height \ size)
                If grid(Row, Column) = "X" Then
                    g.DrawLine(pen, X, Y, X + (OX.ox_PictureBox1.Width \ size), Y + (OX.ox_PictureBox1.Height \ size))
                    g.DrawLine(pen, X + (OX.ox_PictureBox1.Width \ size), Y, X, Y + (OX.ox_PictureBox1.Height \ size))
                ElseIf grid(Row, Column) = "O" Then
                    g.DrawEllipse(pen, X, Y, (OX.ox_PictureBox1.Width \ size), (OX.ox_PictureBox1.Height \ size))
                End If
            Next
        Next

        ShowPlayer()

    End Sub

    Private Sub ShowPlayer()
        OX.PlayerLabel.Text = String.Format("Player {0} it's your turn", player)
    End Sub

    Public Sub NewGame()

        For R = 0 To size - 1
            For C = 0 To size - 1
                grid(R, C) = " "
            Next
        Next

        player = "X"

    End Sub



End Class

