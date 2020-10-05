Public Class graphs_form
    Const max_number_degree = 10
    Public graph As New graph_class
    Const decimals = 1
    Dim wait As Integer = 1


    Dim zoom As Integer = 100
    Public Sub graphs_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading(Me)
        NumericUpDown1.Value = 3
        scale_factor.Value = 1

        graph.picture_x = (graph_picturebox.Width) '/ graph.accuracy) - 1
        graph.picture_y = (graph_picturebox.Height) '/ graph.accuracy) - 1

        input_textbox.Select()
        ListBox2.SelectedIndex = 0
    End Sub

    Private Sub graphs_form_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        graph_picturebox.SetBounds(0, 0, ((Me.Width / 10) * 9), Me.Height)
        GroupBox1.SetBounds(((Me.Width / 10) * 9), 0, (Me.Width / 10), Me.Height)

        drawing()


    End Sub


    Sub drawing2()

    End Sub

    Sub drawing()


        graph_picturebox.Refresh()

    End Sub




    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        listbox1.Items.Clear()
        ListBox2.Items.Clear()

        If NumericUpDown1.Value >= 1 Then
            listbox1.Items.Insert(0, "C")
            ListBox2.Items.Insert(0, 0)
        End If

        If NumericUpDown1.Value >= 2 Then
            listbox1.Items.Insert(1, "dx")
            ListBox2.Items.Insert(1, 0)
        End If

        If NumericUpDown1.Value >= 3 Then
            For n = 2 To NumericUpDown1.Value - 1
                listbox1.Items.Insert(n, ("dx^" & n))
                ListBox2.Items.Insert(n, 0)
            Next
        End If

        '        If listbox1.Items.Count < NumericUpDown1.Value Then
        'For n = (listbox1.Items.Count - 1) To (ListBox2.Items.Count - 2)
        'ListBox2.Items.Insert(n + 2, 0)
        '   Next
        '  End If


        If ListBox2.Items.Count > listbox1.Items.Count Then
            For n = (ListBox2.Items.Count - 1) To (listbox1.Items.Count - 1)

                ListBox2.Items.RemoveAt(n)
            Next
        End If

        If ListBox2.Items.Count < listbox1.Items.Count Then
            For n = (listbox1.Items.Count) To (ListBox2.Items.Count - 1)
                ListBox2.Items.Insert(n, 0)
            Next
        End If
    End Sub


    Private Sub graphs_form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()

            ElseIf e.KeyCode = Keys.Enter Then
                input_button.PerformClick()
            ElseIf e.KeyCode = Keys.Up Then
                If ListBox2.SelectedIndex = 0 Then
                    ListBox2.SelectedIndex = ListBox2.Items.Count - 1
                Else
                    ListBox2.SelectedIndex = ListBox2.SelectedIndex - 1
                End If
            ElseIf e.KeyCode = Keys.Down Then
                If ListBox2.SelectedIndex = ListBox2.Items.Count - 1 Then
                    ListBox2.SelectedIndex = 0
                Else
                    ListBox2.SelectedIndex = ListBox2.SelectedIndex + 1
                End If
                input_textbox.Select()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub graphs_form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        main_form.Show()
    End Sub


    Private Sub graph_picturebox_Paint(sender As Object, e As PaintEventArgs) Handles graph_picturebox.Paint

        '      For x2 = 0 To graph_picturebox.Width - 1
        'For y2 = 0 To graph_picturebox.Height - 1
        'If graph.picture(x2, y2) = 1 Then
        Dim degree_values(NumericUpDown1.Maximum) As String

        For x = 0 To NumericUpDown1.Value - 1
            ListBox2.SelectedIndex = x
            Try
                Int(ListBox2.SelectedItem)
            Catch ex As Exception
                Exit Sub
            End Try

            degree_values(x) = ListBox2.SelectedItem
        Next


        graph.painting2(e.Graphics, graph_picturebox, Me, degree_values, scale_factor.Value)
        '    End If
        '    Next
        '    Next


    End Sub

    Private Sub ListBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox2.KeyDown
        
    End Sub



    Private Sub ListBox2_DoubleClick(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick
        drawing()
    End Sub

    Private Sub input_button_Click(sender As Object, e As EventArgs) Handles input_button.Click
        insert(input_textbox.Text)

    End Sub
    Private Sub insert(e As String)
        Try

            Dim n As Integer = ListBox2.SelectedIndex
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
            ListBox2.Items.Insert(n, e)
            ListBox2.SelectedIndex = n
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedValueChanged
        input_textbox.Text = ""
        input_textbox.Select()
    End Sub



    Private Sub graph_picturebox_MouseMove(sender As Object, e As MouseEventArgs) Handles graph_picturebox.MouseMove
        X_textbox.Text = MousePosition.X
        Y_textbox.Text = MousePosition.Y
    End Sub
End Class