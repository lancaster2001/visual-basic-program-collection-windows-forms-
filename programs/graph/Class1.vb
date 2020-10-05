Public Class graph_class
    Const scalething = 1
    Public picture_x As Double
    Public picture_y As Double

   

    Sub outline(scale As Integer, g As Graphics, box As PictureBox)
        Dim divert As Integer = 200
        Dim Pen As New Pen(Color.LightGray, 1)
        Dim central_point_x As Integer = (box.Width \ 2)
        Dim central_point_y As Integer = (box.Height \ 2)

        g.DrawLine(Pen, 0, (box.Height \ 2), box.Width, (box.Height \ 2))
        g.DrawLine(Pen, (box.Width \ 2), 0, (box.Width \ 2), box.Height)


        For m = 0 To (box.Width \ 2)
            If (m / (scale)) Mod 10 = 0 Then
                g.DrawLine(Pen, ((central_point_x) + m), ((central_point_y) + box.Height \ divert), ((central_point_x) + m), ((central_point_y) - box.Height \ divert))
                g.DrawLine(Pen, ((central_point_x) - m), ((central_point_y) + box.Height \ divert), ((central_point_x) - m), ((central_point_y) - box.Height \ divert))
            End If

        Next

        For m = 0 To (box.Height \ 2)
            If (m / (scale)) Mod 10 = 0 Then
                g.DrawLine(Pen, ((central_point_x) + box.Width \ divert), ((central_point_y) + m), ((central_point_x) - box.Width \ divert), ((central_point_y) + m))
                g.DrawLine(Pen, ((central_point_x) + box.Width \ divert), ((central_point_y) - m), ((central_point_x) - box.Width \ divert), ((central_point_y) - m))
            End If

        Next
    End Sub
    Sub painting2(g As Graphics, box As PictureBox, form As Form, degree_values() As String, scale_factor As Integer)
        Dim scale As Integer = scale_factor
        Dim scale_x As Integer = scale
        Dim scale_y As Integer = scale

        Dim start As Integer = -((box.Width \ 2) \ scale)
        Dim finish As Integer = ((box.Width \ 2) \ scale)

        Dim central_point_x As Integer = (box.Width \ 2)
        Dim central_point_y As Integer = (box.Height \ 2)

        Dim y As Double = 0
        Dim last_y As Double = 0
        Dim fill As Double = 0
        Dim x2 As Integer = 0

        For x = start To finish
            outline(scale, g, box)

            y = 0
            Dim Pen As New Pen(Color.Black, 1)

            For n = 0 To Int(degree_values.Length - 1)

                y += (degree_values(n) * (x ^ n))
            Next


            If x = start Then
                last_y = y
            End If
            y = -y
            Try
                g.DrawLine(Pen, ((x - 1) + (central_point_x)) * scalething, (((last_y + (central_point_y)) \ 1)) * scalething, ((x + (central_point_x))) * scalething, (((y + (central_point_y)) \ 1)) * scalething)
            Catch ex As Exception

            End Try

            last_y = y

        Next




    End Sub
End Class
