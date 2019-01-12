Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


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
            dbConnectionString = ConfigurationManager.AppSettings.Item("Source") & ConfigurationManager.AppSettings.Item("Provider")

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







        Protected Sub UpdateRow() Implements IDBManager.UpdateRow
            Throw New NotImplementedException()
        End Sub

        Protected Sub DeleteRow() Implements IDBManager.DeleteRow
            Throw New NotImplementedException()
        End Sub

        Protected Sub InsertRow() Implements IDBManager.InsertRow
            Throw New NotImplementedException()
        End Sub

        Protected Sub FillDataGridView() Implements IDBManager.FillDataGridView
            Throw New NotImplementedException()
        End Sub

        Protected Sub FillComboBox() Implements IDBManager.FillComboBox
            Throw New NotImplementedException()
        End Sub

        Protected Sub FillTextBox() Implements IDBManager.FillTextBox
            Throw New NotImplementedException()
        End Sub

        Protected Sub FillList() Implements IDBManager.FillList
            Throw New NotImplementedException()
        End Sub


        Protected Function GetAllRecords() As DataTable Implements IDBManager.GetAllRecords
            Throw New NotImplementedException()
        End Function

        Protected Function GetFilteredData() As DataTable Implements IDBManager.GetFilteredData
            Throw New NotImplementedException()
        End Function

        Protected Function GetMaxId() As Integer Implements IDBManager.GetMaxId
            Throw New NotImplementedException()
        End Function

        Protected Function GetRecordsCount() As Integer Implements IDBManager.GetRecordsCount
            Throw New NotImplementedException()
        End Function

        Protected Function BackupDB(FolderLocation As String) As Boolean Implements IDBManager.BackupDB
            Throw New NotImplementedException()
        End Function

        Protected Function RestoreDB(FolderLocation As String) As Boolean Implements IDBManager.RestoreDB
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace

