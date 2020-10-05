
Public Class Blob
    Public Const size As Integer = 15
    Public Const first_part_height = size
    Public Const first_part_width = size

    Public sped_up_multiplier As Double = 5
    Public initial_multiplier As Double = size

    Public positionX As Integer
    Public positionY As Integer
    Public positionX2 As Integer
    Public positionY2 As Integer
    Public width As Integer = size
    Public height As Integer = size

    Public multiplier As Integer = initial_multiplier
    Public current_direction As String

    Public Sub New(Optional new_positionX As Integer = -1, Optional new_positionY As Integer = -1, Optional new_width As Integer = size, Optional new_height As Integer = size)
        Try
            width = new_width
            height = new_height

            If new_positionX = -1 And new_positionY = -1 Then
                ' put the player in the middle
                positionX = blobform.blob_picture.Width \ 2
                positionY = blobform.blob_picture.Height \ 2
            Else
                positionX = new_positionX
                positionY = new_positionY
            End If
        Catch ex As Exception
            MsgBox("gay")
        End Try

    End Sub

    Public Sub Draw(g As Graphics)

        Dim brush As New SolidBrush(Color.DarkGreen)

        g.FillRectangle(brush, positionX, positionY, width, height)

    End Sub

    Public Sub Move(direction As String)


        Select Case direction
            Case "N"
                positionY -= first_part_height \ multiplier
            Case "W"
                positionX -= first_part_width \ multiplier
            Case "S"
                positionY += first_part_height \ multiplier
            Case "E"
                positionX += first_part_width \ multiplier
            Case "NE"
                positionX += first_part_width \ multiplier
                positionY -= first_part_height \ multiplier
            Case "NW"
                positionX -= first_part_width \ multiplier
                positionY -= first_part_height \ multiplier
            Case "SE"
                positionX += first_part_width \ multiplier
                positionY += first_part_height \ multiplier
            Case "SW"
                positionX -= first_part_width \ multiplier
                positionY += first_part_height \ multiplier
            Case "run"
                If multiplier = sped_up_multiplier Then
                    multiplier = initial_multiplier

                ElseIf multiplier = initial_multiplier Then
                    multiplier = sped_up_multiplier
                End If
        End Select
        If positionX > blobform.blob_picture.Width Then
            blobform.dead()
            'positionX = blobform.blob_picture.Width - width ^ 0.5
        ElseIf positionX < 0 Then
            'positionX = first_part_width ^ 0.5
            'current_direction = ""
            blobform.dead()
        End If

        If positionY > blobform.blob_picture.Height Then
            blobform.dead()
            'positionY = blobform.blob_picture.Height - height ^ 0.5
        ElseIf positionY < 0 Then
            blobform.dead()
            'positionY = first_part_height ^ 0.5
            'current_direction = ""
        End If


    End Sub


    Public Sub find_point(x1, y1, x2, y2, x, y, ByRef hit)
        If (x > x1 And x < x2 And y > y1 And y < y2) Then
            hit = True
        End If
    End Sub
    Public Function hasithit(x As Integer, y As Integer, ob_width As Integer, ob_height As Integer) As Boolean
        Dim hit As Boolean

        Dim a As Integer = x + ob_width
        Dim b As Integer = y + ob_height
        Dim c As Integer = positionX + width - 1
        Dim d As Integer = positionY + height - 1


        find_point(x, y, a, b, positionX, positionY, hit)
        find_point(x, y, a, b, c, positionY, hit)
        find_point(x, y, a, b, positionX, d, hit)
        find_point(x, y, a, b, c, d, hit)

        Return hit
    End Function
    Sub backup()
        'If blobform.number_of_obsticles * blobform.number_of_player_parts < 30 Then
        'For n = positionX To positionX + width - 1
        '
        ' find_point(x, y, x + ob_width, y + ob_height, n, positionY, hit)
        '     find_point(x, y, x + ob_width, y + ob_height, n, positionY + height, hit)

        '       Next
        '       For m = positionY To positionY + height - 1
        '       find_point(x, y, x + ob_width, y + ob_height, positionX, m, hit)
        '      find_point(x, y, x + ob_width, y + ob_height, positionX + width, m, hit)
        '       Else
        '       find_point(x, y, x + ob_width, y + ob_height, positionX, positionY, hit)
        '       find_point(x, y, x + ob_width, y + ob_height, positionX + width - 1, positionY, hit)
        '      find_point(x, y, x + ob_width, y + ob_height, positionX, positionY + height - 1, hit)
        '      find_point(x, y, x + ob_width, y + ob_height, positionX + width - 1, positionY + height - 1, hit)
        '      End If
    End Sub
End Class
