





Imports POSLib.POSLibrary.Handlers
Imports POSLib.POSLibrary.Models

Public Class frmMain



	Public UserPrivilage As UserPrivilages
	Public UserName As String

	Private ProductTable As New ProductsHandler

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoginForm.ShowDialog()

		If LoginForm.DialogResult = DialogResult.OK Then
			'MsgBox("Ok")
			'Me.Close()
		Else
			' Terminate
			MsgBox(" not Ok")
			Me.Close()
		End If
		Me.Text = "POS - " & UserName & " - " & UserPrivilage.ToString
		btnProdSave.Text = "Add Product"
		LoadProductsDgv()
	End Sub

	Private Sub LoadProductsDgv()
		ProductTable.FillDataGridView(dgvProducts)
	End Sub

	Private Sub mnuUsersMgr_Click(sender As Object, e As EventArgs) Handles mnuUsersMgr.Click
		frmUsers.ShowDialog()
	End Sub

	Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
		Me.Close()
	End Sub

	Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
	End Sub

	Private Sub btnProdClearText_Click(sender As Object, e As EventArgs) Handles btnProdClearText.Click
		txtProductId.Text = ""
		txtProdBarcode.Text = ""
		txtProdDescription.Text = ""
		txtProdBuyPrice.Text = ""
		txtProdSellPrice.Text = ""
		txtProdQty.Text = ""
		btnProdSave.Text = "Add Product"
	End Sub

	Private Sub btnProdSave_Click(sender As Object, e As EventArgs) Handles btnProdSave.Click
		Dim Product As New ProductModel

		If txtProdBarcode.Text = "" Then
			MsgBox("Barcode info is missing", MsgBoxStyle.Critical)
			txtProdBarcode.Focus()
			Exit Sub
		End If

		If txtProdDescription.Text = "" Then
			MsgBox("Description info is missing", MsgBoxStyle.Critical)
			txtProdDescription.Focus()
			Exit Sub
		End If

		If txtProdQty.Text = "" Then
			MsgBox("Qty info is missing", MsgBoxStyle.Critical)
			txtProdQty.Focus()
			Exit Sub
		End If

		If Not Integer.TryParse(txtProdQty.Text, Product.Qty) Then
			MsgBox("Qty must be valid integer number", MsgBoxStyle.Critical)
			txtProdQty.Focus()
			Exit Sub
		End If

		If txtProdSellPrice.Text = "" Then
			MsgBox("Sell Price info is missing", MsgBoxStyle.Critical)
			txtProdSellPrice.Focus()
			Exit Sub
		End If

		If Not Single.TryParse(txtProdSellPrice.Text, Product.Qty) Then
			MsgBox("Sell Price is not valid amount", MsgBoxStyle.Critical)
			txtProdSellPrice.Focus()
			Exit Sub
		End If

		If txtProdBuyPrice.Text = "" Then
			MsgBox("Buy Price info is missing", MsgBoxStyle.Critical)
			txtProdBuyPrice.Focus()
			Exit Sub
		End If

		If Not Single.TryParse(txtProdBuyPrice.Text, Product.Qty) Then
			MsgBox("Buy Price is not valid amount", MsgBoxStyle.Critical)
			txtProdBuyPrice.Focus()
			Exit Sub
		End If

		With Product
			.Barcode = txtProdBarcode.Text
			.Description = txtProdDescription.Text
			.BuyPrice = Single.Parse(txtProdBuyPrice.Text)
			.SellPrice = Single.Parse(txtProdSellPrice.Text)
			.Qty = Integer.Parse(txtProdQty.Text)
		End With


		If btnProdSave.Text = "Add Product" Then
			ProductTable.AddNewProduct(Product)
		Else
			Product.Id = Integer.Parse(txtProductId.Text)
			ProductTable.UpdateProduct(Product)
		End If
		LoadProductsDgv()
		btnProdClearText_Click(Nothing, Nothing)
	End Sub

	Private Sub btnProdDelete_Click(sender As Object, e As EventArgs) Handles btnProdDelete.Click
		If txtProductId.Text = "" Then
			MsgBox("Select One product to be deleted", MsgBoxStyle.Critical)
			dgvProducts.Focus()
			Exit Sub
		End If

		ProductTable.DeleteProduct(Integer.Parse(txtProductId.Text))
		LoadProductsDgv()
		btnProdClearText_Click(Nothing, Nothing)
	End Sub

	Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
		If dgvProducts.SelectedRows.Count = 0 Then Exit Sub

		With dgvProducts.SelectedRows(0)
			txtProductId.Text = .Cells(0).Value
			txtProdBarcode.Text = .Cells(1).Value
			txtProdDescription.Text = .Cells(2).Value
			txtProdBuyPrice.Text = .Cells(3).Value
			txtProdSellPrice.Text = .Cells(4).Value
			txtProdQty.Text = .Cells(5).Value
		End With
		btnProdSave.Text = "Update Product"
	End Sub
End Class
