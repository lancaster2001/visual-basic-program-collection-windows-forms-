Imports System.IO
Imports System.Threading
Public Module tools
    '
    Sub file_writer(ByRef file_name As String, ByRef text As String, Optional newline As Boolean = False, Optional file_type As String = ".txt", Optional append As Boolean = True)
        Dim file As StreamWriter


        file = New StreamWriter(file_name, append)

        file.Write(text)

        If newline = True Then
            file.Write(vbCrLf)
        End If

        file.Close()

    End Sub
    Public Function file_reader(ByRef file_name As String)
        Dim file As StreamReader
        Dim text As String

        file = New StreamReader(file_name)

        text = file.ReadToEnd


        file.Close()

        Return text

    End Function
    Public Sub file_reader2(ByRef text As String, ByRef file_name As String)
        Dim file_dialog As New OpenFileDialog


        Dim input_file As StreamReader
        Dim line As String



        If file_dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            file_name = file_dialog.FileName
            input_file = New StreamReader(file_name)
            While Not input_file.EndOfStream
                line = input_file.ReadLine
                text += line & (vbCrLf)
            End While
            input_file.Close()
        End If

    End Sub
    '
    Public Function random_number(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim rnd_num As New Random
        Dim random_num1 As Integer = 10
        Dim random_num As Integer = 1000



        Thread.Sleep(20)

        Randomize(random_num)

        Dim random_num2 = CInt(Int((random_num * Rnd()) + 1)) - 1

        For n = 0 To random_num2

            random_num = rnd_num.Next(num1, num2)
        Next

        Return random_num
    End Function
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Thread.Sleep(20)
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    '
    Public Sub linear_search(ByRef items As String(), ByRef item_to_find As String, ByRef index As Integer)
        index = 0
        Dim found As Boolean = False

        While found = False And index < items.Length
            If items(index) = item_to_find Then
                found = True
            Else
                index += 1
            End If
        End While

        If found = False Then
            index = Nothing
        End If


    End Sub
    Public Sub binary_search(ByRef items As String(), ByRef item_to_find As String, ByRef index As Integer, ByRef first As Integer, ByRef last As Integer)
        index = (first + last) \ 2
        Dim ingrement As Integer = 0
        Dim found As Boolean = False

        While found = False
            Try
                If items(index) = item_to_find Then
                    found = True
                Else
                    If Asc(item_to_find.Chars(ingrement)) < Asc(items(index).Chars(ingrement)) Then
                        index = (index + first) \ 2
                    ElseIf Asc(item_to_find.Chars(ingrement)) > Asc(items(index).Chars(0)) Then
                        index = (index + last) \ 2
                    ElseIf Asc(item_to_find.Chars(ingrement)) = Asc(items(index).Chars(ingrement)) Then
                        ingrement += 1
                    End If
                End If
            Catch ex As Exception
                Exit While
            End Try
        End While

    End Sub
    '
    Public Sub loading(form As Form, Optional icon_name As String = "Icon1")

        form.Location = New Point(0, 0)
        form.Size = Screen.PrimaryScreen.WorkingArea.Size
        form.FormBorderStyle = FormBorderStyle.None
        form.KeyPreview = True
        form.WindowState = FormWindowState.Maximized

        'form.Icon = Icon.ExtractAssociatedIcon(My.Resources.ResourceManager.GetObject(home_icon.ico))
        form.Icon = My.Resources.ResourceManager.GetObject(icon_name)
        'MsgBox(form.Icon)
        'fd
    End Sub
    Public Sub universal_keys(form As Form)

    End Sub

    Public Sub drawer(PictureBox As PictureBox, g As Graphics, character As String, x As Integer, y As Integer, width As Integer, height As Integer)
        Dim brush_darkgreen As New SolidBrush(color.DarkGreen)
        Dim brush_white As New SolidBrush(color.White)
        Dim brush_background As New SolidBrush(PictureBox.BackColor)
        Dim brush_lime As New SolidBrush(color.LimeGreen)
        Dim f As Font = New Font("Arial", width, FontStyle.Regular)
        If character = "0" Then

            Dim t As String = "0"
            g.DrawString(t, f, brush_darkgreen, x, y)

            'g.FillEllipse(brush_darkgreen, x, y, width, height)
            'g.FillEllipse(brush_background, x + (width \ 4), y + (height \ 4), width \ 2, height \ 2)
        ElseIf character = "0**" Then
            Dim t As String = "0"

            g.DrawString(t, f, brush_lime, x, y)
        ElseIf character = "0*" Then
            Dim t As String = "0"

            g.DrawString(t, f, brush_white, x, y)

            'g.FillEllipse(brush_white, x, y, width, height)
            'g.FillEllipse(brush_background, x + (width \ 4), y + (height \ 4), width \ 2, height \ 2)
        ElseIf character = "1" Then
            Dim t As String = "1"
            g.DrawString("1", f, brush_white, x, y)
        End If





    End Sub


End Module


