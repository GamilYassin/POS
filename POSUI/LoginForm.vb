Imports POSLib.POSLibrary.Handlers
Imports POSLib.POSLibrary.Models

Public Class LoginForm

	Private MyUser As New UsersHandler


	Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
		Dim Priv As UserPrivilages

		Try
			If UsernameTextBox.Text.Trim = "" Then
				MsgBox("User Name is a must!", MsgBoxStyle.Critical, "User Name Is missing")
				UsernameTextBox.Focus()
				Exit Sub
			End If

			If PasswordTextBox.Text.Trim = "" Then
				MsgBox("Password Text is empty!", MsgBoxStyle.Critical, "Password Is missing")
				PasswordTextBox.Focus()
				Exit Sub
			End If

			Priv = MyUser.ValidateUser(UsernameTextBox.Text.Trim, PasswordTextBox.Text.Trim)
			If Priv <> POSLib.POSLibrary.Models.UserPrivilages.None Then
				Me.DialogResult = DialogResult.OK
				frmMain.UserPrivilage = Priv
				MsgBox("Welcome Back! Your current privilage is: " & Priv.ToString, MsgBoxStyle.Information, "Welcome")
				frmMain.UserName = UsernameTextBox.Text.Trim
			Else
				MsgBox("Not valid user name or passowrd", MsgBoxStyle.Critical, "Invalid User")
			End If
		Catch ex As Exception

		End Try
	End Sub

	Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
		Me.DialogResult = DialogResult.Cancel
	End Sub

End Class
