Module user_settings
    Public Structure program_settings
        Dim program_settings_list() As String

    End Structure
    Public Structure user_details
        Dim logged_in As Boolean
        Dim username As String
        Dim password As String
        Dim displayname As String
        Dim file_location As String
    End Structure
    Public Structure main_menu_dialog_settings
        Dim background_colour As Color
    End Structure
End Module
