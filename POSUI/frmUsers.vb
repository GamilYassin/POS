Imports POSLib.POSLibrary.Handlers
Imports POSLib.POSLibrary.Models

Public Class frmUsers
	Private UsersTable As UsersHandler

	Private Sub LoadComboBox()
		With cboPrivs
			.Items.Clear()
			.Items.Add(UserPrivilages.None.ToString)
			.Items.Add(UserPrivilages.SuperUser.ToString)
			.Items.Add(UserPrivilages.Admin.ToString)
			.Items.Add(UserPrivilages.Cashier.ToString)
		End With
	End Sub

	Private Sub LoadDataGrid()
		UsersTable.FillDataGridView(dgvUsers)
	End Sub


	Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
		UsersTable = New UsersHandler
		LoadDataGrid()
		LoadComboBox()
		btnSave.Text = "Add New User"
	End Sub


	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		txtUserName.Text = ""
		txtPass.Text = ""
		'cboPrivs.SelectedText = ""
		LoadComboBox()
		btnSave.Text = "Add New User"
	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		If MsgBox("Are You Sure to Close the Form, any unsaved data will be lost", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
			Me.Close()
		End If
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		If txtUserName.Text = "" Then
			MsgBox("User Name is a must!", MsgBoxStyle.Critical, "User Name Is missing")
			txtUserName.Focus()
			Exit Sub
		End If

		If txtPass.Text = "" Then
			MsgBox("User Password is a must!", MsgBoxStyle.Critical, "User Password Is missing")
			txtPass.Focus()
			Exit Sub
		End If

		If cboPrivs.SelectedItem = "" Then
			MsgBox("User Privilage is a must!", MsgBoxStyle.Critical, "User Privilage Is missing")
			cboPrivs.Focus()
			Exit Sub
		End If

		If btnSave.Text = "Add New User" Then
			UsersTable.AddNewUser(txtUserName.Text, txtPass.Text, UserModel.MapUserPrivilages(cboPrivs.SelectedItem))
		Else
			UsersTable.UpdateUserInfo(txtUserName.Text, txtPass.Text, UserModel.MapUserPrivilages(cboPrivs.SelectedItem))
		End If
		LoadDataGrid()
	End Sub

	Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
		If dgvUsers.SelectedRows.Count = 0 Then Exit Sub

		With dgvUsers.SelectedRows(0)
			txtUserName.Text = .Cells(0).Value
			txtPass.Text = .Cells(1).Value
			cboPrivs.SelectedItem = UserModel.MapUserPrivilages(.Cells(2).Value).ToString
		End With
		btnSave.Text = "Save Changes"
	End Sub
End Class