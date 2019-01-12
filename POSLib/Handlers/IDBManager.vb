

Imports System.Windows.Forms

Namespace POSLibrary.Handlers
    ''' <summary>
    ''' This Interface has signature for all DB Direct operations
    ''' </summary>
    Public Interface IDBManager
        ReadOnly Property DBConnectionState() As ConnectionState

        Function OpenConnection() As Boolean
        Function CloseConnection() As Boolean
        Function TestDBConnection() As Boolean

        Function SelectRows() As DataTable
        Function GetMaxId() As Integer
        Function GetRecordsCount() As Integer

        Sub UpdateRow()
        Sub DeleteRow()
        Sub InsertRow()

        Sub FillDataGridView(ByRef myDataGridViewer As DataGridView)
        Sub FillComboBox(ByRef myComboBox As ComboBox)
        Sub FillTextBox(ByRef myTextBox As TextBox)
        Sub FillList()

        Function BackupDB(FolderLocation As String) As Boolean
        Function RestoreDB(FolderLocation As String) As Boolean
    End Interface
End Namespace