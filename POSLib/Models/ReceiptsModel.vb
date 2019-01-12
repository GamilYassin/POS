

Namespace POSLibrary.Models
    Public Class ReceiptsModel
        '[Id] INT Not NULL PRIMARY KEY, 
        '[SellDate] NCHAR(10) Not NULL, 
        '[TotalPrice] MONEY Not NULL, 
        '[Cashier] NVARCHAR(100) Not NULL

        Public Id As Integer
        Public SellDate As DateTime
        Public TotalPrice As Single
        Public Cashier As String

    End Class
End Namespace