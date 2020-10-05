Module main_menu_dialog_module
    Dim username As String
    Public Sub menu_dialog_loader()
        If Login_dialog.CanSelect = True Then
            username = Login_dialog.user.username
        End If
    End Sub
End Module
