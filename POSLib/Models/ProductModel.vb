


Namespace POSLibrary.Models
    Public Class ProductModel
        '[Id] INT NOT NULL PRIMARY KEY, 
        '[Barcode] NVARCHAR(50) Not NULL, 
        '[Description] NVARCHAR(100) Not NULL, 
        '[BuyPrice] MONEY Not NULL, 
        '[SellPrice] MONEY Not NULL, 
        '[Qty] INT Not NULL

        Public Id As Integer
        Public Barcode As String
        Public Description As String
        Public BuyPrice As Single
        Public SellPrice As Single
        Public Qty As Integer
    End Class
End Namespace