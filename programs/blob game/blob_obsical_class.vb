Public Class blob_obsical_class
    Public X As Integer
    Public Y As Integer
    Public X2 As Integer
    Public Y2 As Integer
    Public width As Integer
    Public height As Integer
    Public length As Integer
    Shared rnd As New Random
    Private proportions As Integer
    Private again As Boolean



    Public Sub New2()
        Do
            proportions = random_number(0, 1)
            If proportions = 0 Then
                width = rnd.Next(1, blobform.blob_picture.Width \ 13)
                length = rnd.Next(blobform.blob_picture.Height \ 10, blobform.blob_picture.Height \ 5)
            Else
                width = rnd.Next(blobform.blob_picture.Width \ 10, blobform.blob_picture.Width \ 5)
                length = rnd.Next(1, blobform.blob_picture.Height \ 13)
            End If
        Loop Until proportions <> 0

        again = False
        Do
            X = rnd.Next(1, blobform.blob_picture.Width - width)
            For n = -Blob.size To Blob.size
                For m = 0 To blobform.number_of_player_parts - 1
                    If X = blobform.player(m).positionX + n Then
                        again = True
                    End If
                Next
            Next

        Loop Until again = False

        again = False
        Do
            again = False
            Y = rnd.Next(1, blobform.blob_picture.Height - length)

            For n = -Blob.size To (2 * Blob.size)
                For m = 0 To blobform.number_of_player_parts - 1
                    If Y = blobform.player(m).positionY + n Then
                        again = True
                    End If
                Next
            Next

        Loop Until again = False


    End Sub
    Public Sub New(ByRef box As PictureBox, Optional number_of_obsticles As Integer = 0)

        Dim again As Boolean

        Do
            again = False
            Try
                X = rnd.Next(1, box.Width)
                Y = rnd.Next(0, box.Height)

                If number_of_obsticles > 0 Then
                    width = rnd.Next(box.Width \ (number_of_obsticles * 2), box.Width \ number_of_obsticles)
                    height = rnd.Next(box.Height \ (number_of_obsticles * 2), box.Height \ number_of_obsticles)
                End If

                If number_of_obsticles = 0 Then
                    width = rnd.Next(box.Width \ 10, box.Width \ 5)
                    height = rnd.Next(box.Height \ 10, box.Height \ 5)
                End If

                X2 = X + width
                Y2 = Y + height

            Catch ex As Exception
                MsgBox("there was an error")
            End Try
            For n = 0 To blobform.number_of_player_parts - 1
                find_point(X, Y, X2, Y2, blobform.player(n).positionX, blobform.player(n).positionY, again)

            Next
            find_point(X, Y, X2, Y2, blobform.pelet.X, blobform.pelet.Y, again)
            find_point(X, Y, X2, Y2, blobform.pelet.X + blobform.pelet.width, blobform.pelet.Y, again)
            find_point(X, Y, X2, Y2, blobform.pelet.X, blobform.pelet.Y + blobform.pelet.length, again)
            find_point(X, Y, X2, Y2, blobform.pelet.X + blobform.pelet.width, blobform.pelet.Y + blobform.pelet.length, again)
        Loop Until again = False
    End Sub

    Public Sub draw_rectangle(g As Graphics)

        Dim brush As New SolidBrush(Color.Black)

        g.FillRectangle(brush, X, Y, width, height)

    End Sub
    Public Sub find_point(x1, y1, x2, y2, x, y, ByRef again)
        If (x > x1 And x < x2 And y > y1 And y < y2) Then
            again = True
        End If
    End Sub
    Public Sub move(box As PictureBox)

        X += rnd.Next(-1, 1)
        Y += rnd.Next(-1, 1)
        X2 = X + width
        Y2 = Y + height

    End Sub
End Class
