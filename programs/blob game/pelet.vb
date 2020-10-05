Public Class pelet2
    Public X As Integer
    Public Y As Integer
    Public width As Integer
    Public length As Integer
    Shared rnd As New Random
    Private again As Boolean
    Private size As Integer



    Public Sub New()
        size = ((blobform.blob_picture.Width \ 100) * (blobform.blob_picture.Height \ 100))


        width = size \ (rnd.Next(((size ^ 0.5) \ 2), ((size ^ 0.5) \ 1)))
        length = size \ width

        Try
            Do
                X = rnd.Next(1, blobform.blob_picture.Width - width)
                again = False
                For m = 0 To blobform.number_of_obsticles - 1


                    For n = 0 To blobform.obstical(m).width
                        If X = blobform.obstical(m).X + n Then
                            again = True
                        End If
                    Next


                Next
            Loop Until again = False

            Do
                again = False
                Y = rnd.Next(1, blobform.blob_picture.Height - length)
                For m = 0 To blobform.number_of_obsticles - 1


                    For n = 0 To blobform.obstical(m).height
                        If Y = blobform.obstical(m).Y + n Then
                            again = True
                        End If
                    Next


                Next
            Loop Until again = False
        Catch ex As Exception

        End Try
    End Sub

    Public Sub draw_rectangle(g As Graphics)

        Dim brush As New SolidBrush(Color.Blue)

        g.FillRectangle(brush, X, Y, width, length)
    End Sub
End Class
