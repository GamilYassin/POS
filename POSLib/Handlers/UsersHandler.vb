


Imports System.Windows.Forms
Imports POSLib.POSLibrary.Models

Namespace POSLibrary.Handlers
	Public Class UsersHandler
		Inherits DBManager

		Public Sub New()
			MyBase.New
		End Sub

		Public Function SelectAllRecords() As DataTable
			Me.dbCommand.CommandText = "spUsersSelectAll"
			Return MyBase.SelectRows()
		End Function

		Public Function ValidateUser(ByVal UserNameIn As String, ByVal PassIn As String) As UserPrivilages
			Dim PrivilageOut As UserPrivilages = UserPrivilages.None
			Dim MyTable As DataTable
			Dim Passout As String
			' If UserName exist then True else False
			' If Pass matches then True
			'
			Try
				Me.dbCommand.Parameters.Clear()
				Me.dbCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 100).Value = UserNameIn
				Me.dbCommand.CommandText = "spUsersSelectByUserName"
				MyTable = Me.SelectRows()
				If MyTable.Rows.Count = 0 Then
					PrivilageOut = UserPrivilages.None
				Else
					Passout = MyTable.Rows(0).Item(1)
					If Passout = PassIn Then
						PrivilageOut = UserModel.MapUserPrivilages(MyTable.Rows(0).Item(2))
					Else
						PrivilageOut = UserPrivilages.None
					End If
				End If
			Catch ex As Exception
				MsgBox(ex.Message)
				Me.CloseConnection()
				PrivilageOut = UserPrivilages.None
			End Try
			Return PrivilageOut
		End Function

		Public Shadows Sub FillDataGridView(ByRef myDataGridViewer As DataGridView)
			Me.dbCommand.Parameters.Clear()
			Me.dbCommand.CommandText = "spUsersSelectAll"
			MyBase.FillDataGridView(myDataGridViewer)
		End Sub

		Public Sub AddNewUser(UserName As String, UserPass As String, UserPriv As UserPrivilages)
			Me.dbCommand.Parameters.Clear()
			Me.dbCommand.CommandText = "spUsersInsertRow"
			dbCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 100).Value = UserName
			dbCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = UserPass
			dbCommand.Parameters.Add("@Privilage", SqlDbType.NVarChar, 50).Value = UserPriv.ToString
			MyBase.InsertRow()
		End Sub

		Public Sub UpdateUserInfo(UserName As String, UserPass As String, UserPriv As UserPrivilages)
			Me.dbCommand.Parameters.Clear()
			Me.dbCommand.CommandText = "spUsersUpdateRow"
			dbCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 100).Value = UserName
			dbCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = UserPass
			dbCommand.Parameters.Add("@Privilage", SqlDbType.NVarChar, 50).Value = UserPriv.ToString
			MyBase.UpdateRow()
		End Sub
	End Class
End Namespace