Imports System.IO
Imports System.Reflection

Public Class text_doc_opener
    Dim file As String = ""
    Dim file2 As String = ""
    Dim file3 As String = "backup.html"
    Dim file_backup(max_number_of_tabs - 1) As String
    Dim long_line As String = "-----------------------------------------------------------------"
    Dim spliter As String
    Const max_number_of_tabs = 10
    Dim tabs(max_number_of_tabs - 1) As String
    Dim tabs_link(max_number_of_tabs - 1) As String
    Dim last_selected_index As Integer = 0
    Dim highlighted As Boolean

    Private Sub text_doc_opener_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("tab1")
        ListBox1.SetSelected(0, True)
        loading(Me)

    End Sub

    Private Sub text_doc_opener_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        main_form.Show()
    End Sub

    Private Sub load_button_Click(sender As Object, e As EventArgs) Handles load_button.Click
        Try

        If textbox.Text <> "" And tabs_link(ListBox1.SelectedIndex) <> "" Then
            file_writer(tabs_link(ListBox1.SelectedIndex), textbox.Text, False, "", False)
        End If


        Dim text As String = ""

            file_reader2(text, tabs_link(ListBox1.SelectedIndex))
            For n = 0 To tabs_link.Length - 1
                If tabs_link(ListBox1.SelectedIndex) = tabs_link(n) Then
                    If ListBox1.SelectedIndex <> n Then
                        MsgBox("you can only open one instance of a file")
                        Exit Sub
                    End If
                End If
            Next
            If tabs_link(ListBox1.SelectedIndex).EndsWith("\") Then
                tabs_link(ListBox1.SelectedIndex) = file_backup(ListBox1.SelectedIndex)
                text = file_reader(tabs_link(ListBox1.SelectedIndex))
            Else
                file_backup(ListBox1.SelectedIndex) = tabs_link(ListBox1.SelectedIndex)

            End If

            textbox.Clear()
            Try
                spliter = tabs_link(ListBox1.SelectedIndex).Remove(0, tabs_link(ListBox1.SelectedIndex).LastIndexOf("."))
            Catch ex As Exception
                Exit Sub
            End Try

            textbox.AppendText(text)
            tabs_link(ListBox1.SelectedIndex) = tabs_link(ListBox1.SelectedIndex)
            tabs(ListBox1.SelectedIndex) = textbox.Text
            file2 = tabs_link(ListBox1.SelectedIndex).Remove(tabs_link(ListBox1.SelectedIndex).LastIndexOf("\"), (tabs_link(ListBox1.SelectedIndex).Length - tabs_link(ListBox1.SelectedIndex).LastIndexOf("\"))) & "\" & file3
            If textbox.Text <> "" Then
                file_writer(tabs_link(ListBox1.SelectedIndex), textbox.Text, False, "", False)
                file_writer(file2, textbox.Text & vbCrLf & long_line, True, "", True)
            End If

            If spliter = ".html" Or spliter = ".txt" Then
                WebBrowser1.Url = New Uri(tabs_link(ListBox1.SelectedIndex))
            End If
        Catch ex As NullReferenceException
            Exit Sub
        End Try
        '
    End Sub


    Private Sub text_doc_opener_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize


        load_button.Height = Me.Height * 0.15
        load_button.Width = Me.Width * 0.1
        load_button.Left = Me.Width * 0.01
        load_button.Top = Me.Height * 0.01

        save_button.Height = Me.Height * 0.15
        save_button.Width = Me.Width * 0.1
        save_button.Left = Me.Width * 0.12
        save_button.Top = Me.Height * 0.01

        saveas_button.Height = Me.Height * 0.15
        saveas_button.Width = Me.Width * 0.1
        saveas_button.Left = Me.Width * 0.23
        saveas_button.Top = Me.Height * 0.01

        add_tab_button.Height = Me.Height * 0.15
        add_tab_button.Width = Me.Width * 0.1
        add_tab_button.Left = Me.Width * 0.34
        add_tab_button.Top = Me.Height * 0.01

        textbox.Left = 0
        textbox.Top = (Me.Height * 0.2)
        textbox.Height = (Me.Height * 0.8)
        textbox.Width = Me.Width * 0.6

        ListBox1.Height = Me.Height * 0.04
        ListBox1.Width = textbox.Width
        ListBox1.Left = 0
        ListBox1.Top = ((Me.Height * 0.01) + load_button.Height)

        WebBrowser1.Left = textbox.Location.X + textbox.Width
        WebBrowser1.Top = textbox.Location.Y
        WebBrowser1.Height = textbox.Height
        WebBrowser1.Width = Me.Width - textbox.Width



    End Sub

    Private Sub textbox_TextChanged(sender As Object, e As EventArgs) Handles textbox.TextChanged
        Try
            If textbox.Text <> "" Then
                file_writer(tabs_link(ListBox1.SelectedIndex), textbox.Text, False, "", False)


                If spliter = ".html" Or spliter = ".txt" Then

                    WebBrowser1.Url = New Uri(tabs_link(ListBox1.SelectedIndex))



                End If
            End If
        Catch ex As Exception

        End Try
        tabs(ListBox1.SelectedIndex) = textbox.Text

    End Sub

    Private Sub saveas_button_Click(sender As Object, e As EventArgs) Handles saveas_button.Click
        Dim myStream As Stream
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim streamwrite As StreamWriter

        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True



        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = saveFileDialog1.OpenFile()

            If (myStream IsNot Nothing) Then
                streamwrite = New StreamWriter(myStream)
                'tabs_link(ListBox1.SelectedIndex) = myStream
                streamwrite.Write(textbox.Text)
                streamwrite.Close()
                myStream.Close()

            End If
        End If
    End Sub

    Private Sub save_button_Click(sender As Object, e As EventArgs) Handles save_button.Click
        Dim streamwrite As StreamWriter
        streamwrite = New StreamWriter(tabs_link(ListBox1.SelectedIndex))

        streamwrite.Write(textbox.Text)
        streamwrite.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim katch As Boolean = False
        If ListBox1.SelectedIndex = last_selected_index Then
            Exit Sub
        End If
        spliter = ""
        Try
            spliter = tabs_link(ListBox1.SelectedIndex).Remove(0, tabs_link(ListBox1.SelectedIndex).LastIndexOf("."))
        Catch ex As Exception

        End Try

        Do
            Try
                katch = False


                textbox.Text = tabs(ListBox1.SelectedIndex)
            Catch ex As Exception
                katch = True
                'tabs(ListBox1.SelectedIndex) = ""
            End Try
        Loop Until katch = False
        last_selected_index = ListBox1.SelectedIndex
    End Sub

    Private Sub add_tab_button_Click(sender As Object, e As EventArgs) Handles add_tab_button.Click

        tabs(ListBox1.Items.Count) = ""
        ListBox1.Items.Add("tab " & ListBox1.Items.Count + 1)

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        highlighted = True
    End Sub

    Private Sub ListBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBox1.KeyPress
        If e.KeyChar = Chr(Keys.Delete) Then
            If highlighted = True Then
                ListBox1.Items.Remove(ListBox1.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub text_doc_opener_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class