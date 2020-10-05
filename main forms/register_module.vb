Imports System.IO
Module register_module
    Sub main_register(ByRef user_login As String, ByRef user_password As String, Optional user_display_name As String = "create user name")
        Dim main_new_account As StreamWriter
        Dim main_account_details As String = ""
        Dim blank As Boolean = True

        Dim account_maker As StreamWriter
        Dim account_maker_details As String = ""


        If user_login.Trim = "" Or user_password.Trim = "" Then
            Exit Sub
        End If

        main_account_details = ("un:" & user_login.Trim & ",p:" & user_password.Trim & ",")
        main_new_account = New StreamWriter("main_Accounts.txt", True)
        main_new_account.Write(main_account_details)
        main_new_account.Close()

        Directory.CreateDirectory("settings\user_settings\" & user_login & "\")


        account_maker_details = ("log:" & user_login.Trim & ",pas:" & user_password.Trim & ",dis:" & user_display_name)
        account_maker = New StreamWriter("settings\user_settings\" & user_login & "\details.txt")
        account_maker.Write(account_maker_details)
        account_maker.Close()
        Login_dialog.Show()
        Login_dialog.username_textbox.Text = register_dialog.username_textbox.Text
        Login_dialog.password_textbox.Text = register_dialog.password_textbox.Text
        register_dialog.Close()
    End Sub
End Module
