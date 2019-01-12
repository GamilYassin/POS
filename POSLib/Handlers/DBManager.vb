Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms

Namespace POSLibrary.Handlers
    ''' <summary>
    ''' Implement All low-level DB operations
    ''' </summary>
    Public MustInherit Class DBManager
        Implements IDBManager

        Protected dbConnectionString As String
        Protected dbConnection As SqlConnection
        Protected dbCommand As SqlCommand
        Protected dbDataAdapter As SqlDataAdapter

        Protected Sub New()
			dbConnectionString = ConfigurationManager.AppSettings.Item("Source") '& ConfigurationManager.AppSettings.Item("Provider")

			Me.dbConnection = New SqlConnection(dbConnectionString)
            Me.dbCommand = New SqlCommand()
            Me.dbCommand.Connection = dbConnection
            Me.dbCommand.CommandType = CommandType.StoredProcedure
            Me.dbDataAdapter = New SqlDataAdapter(Me.dbCommand)
        End Sub

        Protected ReadOnly Property DBConnectionState As ConnectionState Implements IDBManager.DBConnectionState
            Get
                Return Me.dbConnection.State
            End Get
        End Property


        Protected Function OpenConnection() As Boolean Implements IDBManager.OpenConnection
            Dim Result As Boolean = True
            Try
                Me.dbConnection.Open()
                If Me.DBConnectionState = ConnectionState.Open Then
                    Result = True
                Else
                    Result = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Result = False
            End Try
            Return Result
        End Function

        Protected Function CloseConnection() As Boolean Implements IDBManager.CloseConnection
            Dim Result As Boolean = True
            Try
                Me.dbConnection.Close()
                If Me.DBConnectionState = ConnectionState.Closed Then
                    Result = True
                Else
                    Result = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Result = False
            End Try
            Return Result
        End Function

        Protected Function TestDBConnection() As Boolean Implements IDBManager.TestDBConnection
            Return Me.OpenConnection
        End Function


        Protected Function SelectRows() As DataTable Implements IDBManager.SelectRows
            Dim MyTable As New DataTable

            Try
				' Open connection
				' execute command within adapter
				' close connection
				' fill table
				'Me.dbCommand.Parameters.Clear()
				Me.OpenConnection()
                Me.dbDataAdapter.SelectCommand.ExecuteReader()
                Me.CloseConnection()
                dbDataAdapter.Fill(MyTable)
                Me.dbCommand.Parameters.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
                Me.CloseConnection()
            End Try
            Return MyTable
        End Function

        Protected Function GetMaxId() As Integer Implements IDBManager.GetMaxId
            Dim MaxId As Integer = 0

            Try
                Me.dbCommand.Parameters.Clear()
                Me.dbCommand.Parameters.Add("@MaxId", SqlDbType.Int)
                Me.dbCommand.Parameters("@MaxId").Direction = ParameterDirection.Output
                Me.OpenConnection()
                Me.dbCommand.ExecuteNonQuery()
				MaxId = Integer.Parse(dbCommand.Parameters("@MaxId").Value)
				Me.CloseConnection()
            Catch ex As Exception
                MsgBox(ex.Message)
                Me.CloseConnection()
            End Try
            Return MaxId
        End Function

        Protected Function GetRecordsCount() As Integer Implements IDBManager.GetRecordsCount
            Dim RowsCount As Integer = 0

            Try
                Me.dbCommand.Parameters.Clear()
                Me.dbCommand.Parameters.Add("@RowsCount", SqlDbType.Int)
                Me.dbCommand.Parameters("@RowsCount").Direction = ParameterDirection.Output
                Me.OpenConnection()
                Me.dbCommand.ExecuteNonQuery()
                RowsCount = dbCommand.Parameters("@RowsCount").Value
                Me.CloseConnection()
            Catch ex As Exception
                MsgBox(ex.Message)
                Me.CloseConnection()
            End Try
            Return RowsCount
        End Function

        Protected Sub FillDataGridView(ByRef myDataGridViewer As DataGridView) Implements IDBManager.FillDataGridView
			With myDataGridViewer
				.DataSource = vbNull
				'.Rows.Clear()
				'.Columns.Clear()
				.DataSource = Me.SelectRows()
			End With
		End Sub

        Protected Sub FillComboBox(ByRef myComboBox As ComboBox) Implements IDBManager.FillComboBox
            With myComboBox
                .Items.Clear()
                For Each Row As DataRow In Me.SelectRows().Rows
                    .Items.Add(Row.Item(0))
                Next
            End With
        End Sub

        Protected Sub FillTextBox(ByRef myTextBox As TextBox) Implements IDBManager.FillTextBox
            Throw New NotImplementedException()
        End Sub

        Protected Sub FillList() Implements IDBManager.FillList
            Throw New NotImplementedException()
        End Sub


        Private Sub ExecuteNonQuery()
            Try
                Me.OpenConnection()
                Me.dbCommand.ExecuteNonQuery()
                Me.CloseConnection()
            Catch ex As Exception
                MsgBox(ex.Message)
                Me.CloseConnection()
            End Try
        End Sub

        Protected Sub UpdateRow() Implements IDBManager.UpdateRow
            ExecuteNonQuery()
        End Sub

        Protected Sub DeleteRow() Implements IDBManager.DeleteRow
            ExecuteNonQuery()
        End Sub

        Protected Sub InsertRow() Implements IDBManager.InsertRow
            ExecuteNonQuery()
        End Sub


        Protected Function BackupDB(FolderLocation As String) As Boolean Implements IDBManager.BackupDB
            Throw New NotImplementedException()
        End Function

        Protected Function RestoreDB(FolderLocation As String) As Boolean Implements IDBManager.RestoreDB
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace

