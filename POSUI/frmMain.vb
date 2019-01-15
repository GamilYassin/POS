





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
			MsgBox("Not Ok")
			Me.Close()
		End If
		Me.Text = "POS - " & UserName & " - " & UserPrivilage.ToString
		btnProdSave.Text = "Add Product"
		LoadProductsDgv()
	End Sub

	Private Sub LoadProductsDgv()
		ProductTable.FillDataGridView(dgvProducts)
		FillBarcodeCombo()
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

	Private Sub FillBarcodeCombo()
		If dgvProducts.Rows.Count = 0 Then Exit Sub

		cboBarcode.Items.Clear()
		For Each Row As DataGridViewRow In dgvProducts.Rows()
			cboBarcode.Items.Add(Row.Cells(1).Value)
		Next
	End Sub

	Private Sub cboBarcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBarcode.SelectedIndexChanged
		txtReceiptProdId.Text = dgvProducts.Rows(cboBarcode.SelectedIndex).Cells(0).Value
		txtReceiptQty.Text = dgvProducts.Rows(cboBarcode.SelectedIndex).Cells(5).Value
		txtReceiptDescr.Text = dgvProducts.Rows(cboBarcode.SelectedIndex).Cells(2).Value
	End Sub

	Private Sub btnReceiptAdd_Click(sender As Object, e As EventArgs) Handles btnReceiptAdd.Click
		If txtReceiptProdId.Text = "" Then Exit Sub

		Dim PQty As Integer = 1
		Dim PPrice As Single
		Dim Count As Integer
		Dim bolExists As Boolean = False

		PPrice = Single.Parse(dgvProducts.Rows(cboBarcode.SelectedIndex).Cells(4).Value)
		For Count = 0 To dgvReceipts.Rows.Count - 1
			If Integer.Parse(dgvReceipts.Rows(Count).Cells(0).Value) = Integer.Parse(txtReceiptProdId.Text) Then
				PQty = Integer.Parse(dgvReceipts.Rows(Count).Cells(2).Value) + 1
				dgvReceipts.Rows(Count).Cells(2).Value = PQty
				dgvReceipts.Rows(Count).Cells(4).Value = PQty * PPrice
				bolExists = True
			End If
		Next

		If Not bolExists Then
			dgvReceipts.Rows.Add(txtReceiptProdId.Text, txtReceiptDescr.Text, PQty, PPrice, PPrice)
		End If
	End Sub

	Private Sub btnReceiptDelete_Click(sender As Object, e As EventArgs) Handles btnReceiptDelete.Click
		If dgvReceipts.SelectedRows.Count = 0 Then Exit Sub
		dgvReceipts.Rows.Remove(dgvReceipts.SelectedRows(0))
	End Sub
End Class
