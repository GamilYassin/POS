

Namespace POSLibrary.Handlers
    ''' <summary>
    ''' This Interface has signature for all DB Direct operations
    ''' </summary>
    Public Interface IDBManager
        ReadOnly Property DBConnectionState() As ConnectionState

        Function OpenConnection() As Boolean
        Function CloseConnection() As Boolean
        Function TestDBConnection() As Boolean

        Function GetAllRecords() As DataTable
        Function GetFilteredData() As DataTable
        Function GetMaxId() As Integer
        Function GetRecordsCount() As Integer

        Sub UpdateRow()
        Sub DeleteRow()
        Sub InsertRow()

        Sub FillDataGridView()
        Sub FillComboBox()
        Sub FillTextBox()
        Sub FillList()

        Function BackupDB(FolderLocation As String) As Boolean
        Function RestoreDB(FolderLocation As String) As Boolean
    End Interface
End Namespace