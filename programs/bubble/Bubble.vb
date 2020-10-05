Public Class Bubble

    Private PositionX As Integer
    Private PositionY As Double
    Public Radius As Integer
    Public speed As Integer
    Private bubble_num As Integer
    Private colour As Color = Color.DarkBlue
    Shared rnd As New Random


    Public Sub New(X As Integer, Y As Integer, R As Integer, num As Integer)
        PositionX = X
        PositionY = Y
        Radius = R
        bubble_num = num
        speed = rnd.Next(5, 15)
    End Sub


    Public Sub Move(speed)
        If PositionY + Radius < 1 Then
            If rnd.Next(0, 20) = 1 Then
                bubbles.new_bubble(bubble_num)
            End If
        End If


        ' PositionX += 0
        'PositionY -= 1
        PositionY -= Radius / speed
        PositionX += rnd.Next(-1, 1)
    End Sub

    Public Sub Paint(g As Graphics)
        Dim Pen As New Pen(colour, 1)
        g.DrawEllipse(Pen, PositionX, (PositionY \ 1), Radius, Radius)
    End Sub

End Class
