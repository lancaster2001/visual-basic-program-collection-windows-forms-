Imports System.IO
Public Class user
    Dim user As user_details
    Dim main_menu_dialog_settings As main_menu_dialog_settings
    Public displayname As String
    Public password As String
    Public username As String
    Public logged_in As Boolean
    Public file_location As String
    Public Sub New()
        user.displayname = "Guest"
        user.logged_in = False
        user.username = "default"
        user.password = " "
        user.file_location = "settings\user_settings\default\"

        main_menu_dialog_settings.background_colour = Color.Black


    End Sub

    Public Sub get_settings()
        Dim file As StreamReader
        Dim text As String

        file = New StreamReader("settings\")

        text = file.ReadToEnd


        file.Close()


    End Sub
    Public Function give_user_details()
        Return user
    End Function
End Class
