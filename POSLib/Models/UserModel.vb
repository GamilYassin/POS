


Namespace POSLibrary.Models
    Public Class UserModel
        Public UserName As String
        Public Password As String
        Public Privilage As UserPrivilages
    End Class

    Public Enum UserPrivilages As Integer
        SuperUser = 1
        Admin = 2
        Cashier = 3
    End Enum
End Namespace
