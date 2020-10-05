Imports System.IO
Module Login_dialog_module
    Const settings_file_name = "login_form_settings.txt"
    Const default_settings = "bc:Black#c1:DarkGreen#c2:White#c3:LimeGreen"
    Dim number_of_settings = 4
    Dim settings() As String
    Dim colours() As Color

    Public Function login_sub(username As String, password As String) As Boolean

        Dim user_login As String = username
        Dim user_password As String = password

        Dim login_details As StreamReader
        Dim login_details_array() As String

        Dim line As String = ""
        Dim username_verification As Boolean = False


        'Dim listboxs() As ListBox listboxs(0).Show()

        login_details = New StreamReader("main_Accounts.txt")

        line = login_details.ReadToEnd()

        login_details_array = line.Split(",")


        For n = 0 To (login_details_array.Length - 2)
            If (login_details_array(n) = ("un:" & user_login)) And (login_details_array(n + 1) = ("p:" & user_password)) Then
                username_verification = True
            End If
        Next

        If username_verification = True Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function login_dialog_load_display_name(ByRef file_location As String)
        Dim displayname_getter As StreamReader
        Dim splitter() As String
        Dim displayname As String

        displayname_getter = New StreamReader(file_location & "details.txt")
        displayname = displayname_getter.Read
        splitter = displayname.Split(",dis:")
        displayname = splitter(0)

        Return displayname
    End Function
    Public Sub login_dialog_load_settings(ByRef user_file_location As String)
        Dim text As String
        Dim again As Boolean = False
        'colours settings
        Do
            again = False

            If File.Exists(user_file_location & settings_file_name) = True Then
                text = tools.file_reader(user_file_location & settings_file_name)
                settings = text.Split("#")
                For n = 0 To number_of_settings - 1
                    'colours(n) = Color.FromName(settings(n).Remove(0, 3))
                Next

            ElseIf File.Exists(user_file_location & settings_file_name) = False Then
                file_writer(user_file_location & settings_file_name, default_settings, False, ".txt", False)
                again = True
            End If

        Loop Until again = False
        'colours settings

    End Sub
End Module
