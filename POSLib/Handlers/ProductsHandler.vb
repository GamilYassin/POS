

Imports System.Windows.Forms
Imports POSLib.POSLibrary.Models



Namespace POSLibrary.Handlers

	Public Class ProductsHandler
		Inherits DBManager

		Public Sub New()
			MyBase.New
		End Sub

		Public Function SelectAllRecords() As DataTable
			Me.dbCommand.CommandText = "spProductsSelectAll"
			Return MyBase.SelectRows()
		End Function

		Public Shadows Sub FillDataGridView(ByRef myDataGridViewer As DataGridView)
			Me.dbCommand.Parameters.Clear()
			Me.dbCommand.CommandText = "spProductsSelectAll"
			MyBase.FillDataGridView(myDataGridViewer)
		End Sub

		Public Sub AddNewProduct(ByRef Product As ProductModel)
			Dim NextId As Integer = 0

			Me.dbCommand.CommandText = "spProductsGetMaxId"
			NextId = MyBase.GetMaxId() + 1

			With Me.dbCommand
				.Parameters.Clear()
				.CommandText = "spProductsInsertRow"
				.Parameters.Add("@Id", SqlDbType.Int).Value = NextId
				.Parameters.Add("@Barcode", SqlDbType.NVarChar, 50).Value = Product.Barcode
				.Parameters.Add("@Description", SqlDbType.NVarChar, 100).Value = Product.Description
				.Parameters.Add("@BuyPrice", SqlDbType.Money).Value = Product.BuyPrice
				.Parameters.Add("@SellPrice", SqlDbType.Money).Value = Product.SellPrice
				.Parameters.Add("@Qty", SqlDbType.Int).Value = Product.Qty
			End With
			MyBase.InsertRow()
		End Sub


		Public Sub UpdateProduct(ByRef Product As ProductModel)
			With Me.dbCommand
				.Parameters.Clear()
				.CommandText = "spProductsUpdateRow"
				.Parameters.Add("@Id", SqlDbType.Int).Value = Product.Id
				.Parameters.Add("@Barcode", SqlDbType.NVarChar, 50).Value = Product.Barcode
				.Parameters.Add("@Description", SqlDbType.NVarChar, 100).Value = Product.Description
				.Parameters.Add("@BuyPrice", SqlDbType.Money).Value = Product.BuyPrice
				.Parameters.Add("@SellPrice", SqlDbType.Money).Value = Product.SellPrice
				.Parameters.Add("@Qty", SqlDbType.Int).Value = Product.Qty
			End With
			MyBase.UpdateRow()
		End Sub


		Public Sub DeleteProduct(ByVal ProdId As Integer)
			With Me.dbCommand
				.Parameters.Clear()
				.CommandText = "spProductsDeleteRow"
				.Parameters.Add("@Id", SqlDbType.Int).Value = ProdId
			End With
			MyBase.DeleteRow()
		End Sub
	End Class
End Namespace