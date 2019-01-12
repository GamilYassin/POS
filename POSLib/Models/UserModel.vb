


Namespace POSLibrary.Models
    Public Class UserModel
        Public UserName As String
        Public Password As String
		Public Privilage As UserPrivilages

		Public Shared Function MapUserPrivilages(Value As String) As UserPrivilages
			Dim userPriv As UserPrivilages = UserPrivilages.None

			Select Case Value
				Case "None"
					userPriv = UserPrivilages.None
				Case "SuperUser"
					userPriv = UserPrivilages.SuperUser
				Case "Admin"
					userPriv = UserPrivilages.Admin
				Case "Cashier"
					userPriv = UserPrivilages.Cashier
				Case Else
					userPriv = UserPrivilages.None
			End Select
			Return userPriv
		End Function
	End Class

    Public Enum UserPrivilages As Integer
		None = 0
		SuperUser = 1
		Admin = 2
        Cashier = 3
    End Enum
End Namespace
