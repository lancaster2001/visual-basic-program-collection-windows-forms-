Imports System.IO
Module scrambler_module
    Dim original_text As String = ""
    Function open_scrambler_text_file() As String
        Dim file_dialog As New OpenFileDialog
        Dim text As String = ""
        Dim input_file As StreamReader
        Dim line As String



        If file_dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim file_name As String = file_dialog.FileName
            input_file = New StreamReader(file_name)
            While Not input_file.EndOfStream
                line = input_file.ReadLine
                text += line
            End While
            input_file.Close()
        End If
        original_text = text
        Return text
    End Function
    Function scrambler_text(text As String, Optional progress_bar As ProgressBar = Nothing) As String
        Dim word_list() As String
        Dim scrambled_text As String = ""


        word_list = text.Split(" ")

        For n = 0 To word_list.Length - 1
            scrambled_text = scrambled_text & scramble_word(word_list(n)) & " "
            If IsNothing(progress_bar) = False Then
                progress_bar.Value = ((n) \ (word_list.Length - 1))
            End If
        Next

        Return scrambled_text
    End Function
    Function scramble_word2(word As String) As String
        Dim scrambled_word As String = ""
        Dim letter_queue As New Queue()
        Dim letter_queue2 As New Queue()
        Dim last_letter As String = word(word.Length - 1)

        word = word.Trim
        If word.Length < 4 Then
            Return word
            Exit Function
        ElseIf word.Length = 4 Then
            scrambled_word = word(0) & word(2) & word(1) & word(3)
            Return scrambled_word
            Exit Function
        Else
            For N = 0 To (word.Length \ 2) - 1
                letter_queue.Enqueue(word((N * 2) + 1))
                If word.Length Mod 2 = 1 And N = (word.Length \ 2) - 1 Then
                Else
                    letter_queue2.Enqueue(word(word.Length - (N * 2) - 2))
                End If
            Next
            scrambled_word = scrambled_word & word(0)
            Try
                Do
                    scrambled_word = scrambled_word & letter_queue2.Dequeue
                    scrambled_word = scrambled_word & letter_queue.Dequeue()
                Loop
            Catch ex As InvalidOperationException
                scrambled_word = scrambled_word & last_letter
            End Try
        End If
        letter_queue.Clear()
        letter_queue2.Clear()
        Return scrambled_word
    End Function
    Function scramble_word(word As String) As String


        Dim scrambled_word As String = ""
        Dim queue As New Queue
        Dim queue2 As New Queue

        Dim buffer As Integer = 0

        Dim letter_array(word.Length - 1) As String

        If word.Length < 4 Then
            Return word
            Exit Function
        End If

        scrambled_word = word(0)


        For n = 1 To word.Length - 2
            queue.Enqueue(word(n))
            queue2.Enqueue(word(word.Length - n - 1))
        Next
        Do
            scrambled_word &= queue2.Dequeue
            If queue.Count + queue2.Count <> word.Length - 2 Then
                scrambled_word &= queue.Dequeue
            End If


        Loop Until queue.Count + queue2.Count <= word.Length - 2

        scrambled_word = scrambled_word & word(word.Length - 1)
        Return scrambled_word
    End Function
    Sub scrambler_organiser()

    End Sub
End Module
