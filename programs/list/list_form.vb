Imports System.IO
Public Class names_form



    Private file_name As String

    Private Sub names_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading(Me)
        select_text_box()
    End Sub

    Private Sub Hello_Click(sender As Object, e As EventArgs) Handles Hello.Click

        MsgBox("Hello " & name_text_box.Text)

    End Sub

    Private Sub add_name_to_list_Click(sender As Object, e As EventArgs) Handles add_name_to_list.Click
        add_name_text_list(name_text_box.Text)
    End Sub

    Private Sub name_text_box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles name_text_box.KeyPress

        If e.KeyChar = Chr(13) Then
            add_name_text_list(name_text_box.Text)
        End If
    End Sub

    Private Sub names_list_box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles names_list_box.KeyPress
        If e.KeyChar = Chr(8) Then
            remove_name_list_box()
        End If
    End Sub

    Private Sub names_list_box_Click(sender As Object, e As EventArgs) Handles names_list_box.Click
        If names_list_box.Items.Count <> 0 Then
            names_list_box.SetSelected(0, True)
        End If
    End Sub

    Private Sub load_button_Click(sender As Object, e As EventArgs) Handles load_button.Click
        load_file()
    End Sub

    Private Sub add_name_text_list(ByRef text As String)

        text = text.ToLower



        If text = "" Then
            MsgBox("Please enter a name")
            Exit Sub
        End If


        If names_list_box.Items.Contains(text) = True Then
            MsgBox("you can't use the same name twice")
            Exit Sub
        End If


        names_list_box.Items.Add(text)
        text = ""

    End Sub

    Private Sub remove_name_list_box()
        names_list_box.Items.Remove(names_list_box.SelectedItems)
        select_text_box()
    End Sub

    Private Sub load_file()

        Dim file_dialog As New OpenFileDialog

        Dim input_file As StreamReader
        Dim line As String

        file_dialog.InitialDirectory = ("M:\")

        If file_dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            file_name = file_dialog.FileName
            input_file = New StreamReader(file_name)
            While Not input_file.EndOfStream
                line = input_file.ReadLine
                names_list_box.Items.Add(line)
            End While
        End If

    End Sub

    Private Sub names_form_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        'select_text_box()
    End Sub

    Private Sub select_text_box()
        name_text_box.Select()
        names_list_box.ClearSelected()

    End Sub

    Private Sub remove_button_Click(sender As Object, e As EventArgs) Handles remove_button.Click
        remove_name_list_box()

    End Sub

    Private Sub save_button_Click(sender As Object, e As EventArgs) Handles save_button.Click




    End Sub

    Private Sub names_list_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles names_list_box.SelectedIndexChanged

    End Sub

    Private Sub names_form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        main_form.Show()
    End Sub

    Private Sub search_button_Click(sender As Object, e As EventArgs) Handles search_button.Click
        Dim items As String() = names_list_box.Items.OfType(Of String).ToArray()
        Dim index As Integer = 0

        linear_search(items, search_box.Text, index)
        If index <> Nothing Then
            names_list_box.SelectedIndex = index
        Else
            names_list_box.ClearSelected()
        End If


    End Sub

    Private Sub names_form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
