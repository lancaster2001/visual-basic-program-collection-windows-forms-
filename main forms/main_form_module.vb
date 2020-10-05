Module main_form_module

    Public Sub main_form_organiser(form As Form, buttons() As Object, number_of_buttons() As String, number_of_rows As Integer, Optional additional_object As Object = Nothing)
        Dim tab As Integer = 1
        Dim x As Integer = 0

        For m = 0 To number_of_rows - 1
            Try
                x += number_of_buttons(m - 1)
            Catch ex As Exception

            End Try

            For n = 0 To number_of_buttons(m) - 1
                Dim hj As Integer = buttons(n + x).Width
                buttons(n + x).Width = (form.Width \ number_of_buttons(m))
                buttons(n + x).Height = ((form.Height - additional_object.Height) \ number_of_rows)
                buttons(n + x).Left = (form.Width \ number_of_buttons(m)) * n
                buttons(n + x).top = (((form.Height - additional_object.Height) \ number_of_rows) * m) + (additional_object.Height)
                buttons(n + x).TabIndex = tab
                tab += 1


            Next
        Next
    End Sub
    Public Sub main_menu_dialog_load()
        menu_dialog.Show()
    End Sub
    Public Sub main_menu_dialog_close()

    End Sub
End Module
