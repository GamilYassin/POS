<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.UsersManagmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuUsersMgr = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.dgvProducts = New System.Windows.Forms.DataGridView()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtProductId = New System.Windows.Forms.TextBox()
		Me.txtProdBarcode = New System.Windows.Forms.TextBox()
		Me.txtProdDescription = New System.Windows.Forms.TextBox()
		Me.txtProdBuyPrice = New System.Windows.Forms.TextBox()
		Me.txtProdSellPrice = New System.Windows.Forms.TextBox()
		Me.txtProdQty = New System.Windows.Forms.TextBox()
		Me.btnProdSave = New System.Windows.Forms.Button()
		Me.btnProdDelete = New System.Windows.Forms.Button()
		Me.btnProdClearText = New System.Windows.Forms.Button()
		Me.MenuStrip1.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersManagmentToolStripMenuItem, Me.mnuExit})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1031, 28)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'UsersManagmentToolStripMenuItem
		'
		Me.UsersManagmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUsersMgr})
		Me.UsersManagmentToolStripMenuItem.Name = "UsersManagmentToolStripMenuItem"
		Me.UsersManagmentToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
		Me.UsersManagmentToolStripMenuItem.Text = "Users Managment"
		'
		'mnuUsersMgr
		'
		Me.mnuUsersMgr.Name = "mnuUsersMgr"
		Me.mnuUsersMgr.Size = New System.Drawing.Size(216, 26)
		Me.mnuUsersMgr.Text = "Users Manager"
		'
		'mnuExit
		'
		Me.mnuExit.Name = "mnuExit"
		Me.mnuExit.Size = New System.Drawing.Size(45, 24)
		Me.mnuExit.Text = "Exit"
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Location = New System.Drawing.Point(0, 28)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(1031, 507)
		Me.TabControl1.TabIndex = 1
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.Color.PowderBlue
		Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 25)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(1023, 478)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Products"
		'
		'TabPage2
		'
		Me.TabPage2.BackColor = System.Drawing.Color.PaleGreen
		Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TabPage2.Location = New System.Drawing.Point(4, 25)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(1023, 478)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Transactions"
		'
		'TabPage3
		'
		Me.TabPage3.BackColor = System.Drawing.Color.LightSalmon
		Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TabPage3.Location = New System.Drawing.Point(4, 25)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Size = New System.Drawing.Size(1023, 478)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "Reports"
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.26601!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.73399!))
		Me.TableLayoutPanel1.Controls.Add(Me.dgvProducts, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.74468!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.255319!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(1015, 470)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'dgvProducts
		'
		Me.dgvProducts.AllowUserToAddRows = False
		Me.dgvProducts.AllowUserToDeleteRows = False
		Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgvProducts.Location = New System.Drawing.Point(3, 3)
		Me.dgvProducts.MultiSelect = False
		Me.dgvProducts.Name = "dgvProducts"
		Me.dgvProducts.ReadOnly = True
		Me.dgvProducts.RowTemplate.Height = 24
		Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvProducts.Size = New System.Drawing.Size(626, 444)
		Me.dgvProducts.TabIndex = 10
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnProdClearText)
		Me.GroupBox1.Controls.Add(Me.btnProdDelete)
		Me.GroupBox1.Controls.Add(Me.btnProdSave)
		Me.GroupBox1.Controls.Add(Me.txtProdQty)
		Me.GroupBox1.Controls.Add(Me.txtProdSellPrice)
		Me.GroupBox1.Controls.Add(Me.txtProdBuyPrice)
		Me.GroupBox1.Controls.Add(Me.txtProdDescription)
		Me.GroupBox1.Controls.Add(Me.txtProdBarcode)
		Me.GroupBox1.Controls.Add(Me.txtProductId)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox1.Location = New System.Drawing.Point(635, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(377, 444)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(74, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Product ID"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(19, 50)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(61, 17)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Barcode"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(1, 82)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(79, 17)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Description"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(16, 114)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(64, 17)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "BuyPrice"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(17, 146)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(63, 17)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "SellPrice"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(50, 178)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(30, 17)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Qty"
		'
		'txtProductId
		'
		Me.txtProductId.Enabled = False
		Me.txtProductId.Location = New System.Drawing.Point(86, 15)
		Me.txtProductId.Name = "txtProductId"
		Me.txtProductId.Size = New System.Drawing.Size(285, 22)
		Me.txtProductId.TabIndex = 1
		'
		'txtProdBarcode
		'
		Me.txtProdBarcode.Location = New System.Drawing.Point(86, 46)
		Me.txtProdBarcode.Name = "txtProdBarcode"
		Me.txtProdBarcode.Size = New System.Drawing.Size(285, 22)
		Me.txtProdBarcode.TabIndex = 2
		'
		'txtProdDescription
		'
		Me.txtProdDescription.Location = New System.Drawing.Point(86, 77)
		Me.txtProdDescription.Name = "txtProdDescription"
		Me.txtProdDescription.Size = New System.Drawing.Size(285, 22)
		Me.txtProdDescription.TabIndex = 3
		'
		'txtProdBuyPrice
		'
		Me.txtProdBuyPrice.Location = New System.Drawing.Point(86, 108)
		Me.txtProdBuyPrice.Name = "txtProdBuyPrice"
		Me.txtProdBuyPrice.Size = New System.Drawing.Size(285, 22)
		Me.txtProdBuyPrice.TabIndex = 4
		'
		'txtProdSellPrice
		'
		Me.txtProdSellPrice.Location = New System.Drawing.Point(86, 139)
		Me.txtProdSellPrice.Name = "txtProdSellPrice"
		Me.txtProdSellPrice.Size = New System.Drawing.Size(285, 22)
		Me.txtProdSellPrice.TabIndex = 5
		'
		'txtProdQty
		'
		Me.txtProdQty.Location = New System.Drawing.Point(86, 170)
		Me.txtProdQty.Name = "txtProdQty"
		Me.txtProdQty.Size = New System.Drawing.Size(285, 22)
		Me.txtProdQty.TabIndex = 6
		'
		'btnProdSave
		'
		Me.btnProdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnProdSave.Location = New System.Drawing.Point(28, 212)
		Me.btnProdSave.Name = "btnProdSave"
		Me.btnProdSave.Size = New System.Drawing.Size(99, 32)
		Me.btnProdSave.TabIndex = 7
		Me.btnProdSave.Text = "Save"
		Me.btnProdSave.UseVisualStyleBackColor = True
		'
		'btnProdDelete
		'
		Me.btnProdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnProdDelete.Location = New System.Drawing.Point(145, 212)
		Me.btnProdDelete.Name = "btnProdDelete"
		Me.btnProdDelete.Size = New System.Drawing.Size(104, 32)
		Me.btnProdDelete.TabIndex = 8
		Me.btnProdDelete.Text = "Delete"
		Me.btnProdDelete.UseVisualStyleBackColor = True
		'
		'btnProdClearText
		'
		Me.btnProdClearText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnProdClearText.Location = New System.Drawing.Point(267, 212)
		Me.btnProdClearText.Name = "btnProdClearText"
		Me.btnProdClearText.Size = New System.Drawing.Size(104, 32)
		Me.btnProdClearText.TabIndex = 9
		Me.btnProdClearText.Text = "Clear Text"
		Me.btnProdClearText.UseVisualStyleBackColor = True
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1031, 535)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "frmMain"
		Me.Text = "POS"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents UsersManagmentToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents mnuUsersMgr As ToolStripMenuItem
	Friend WithEvents mnuExit As ToolStripMenuItem
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents dgvProducts As DataGridView
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnProdClearText As Button
	Friend WithEvents btnProdDelete As Button
	Friend WithEvents btnProdSave As Button
	Friend WithEvents txtProdQty As TextBox
	Friend WithEvents txtProdSellPrice As TextBox
	Friend WithEvents txtProdBuyPrice As TextBox
	Friend WithEvents txtProdDescription As TextBox
	Friend WithEvents txtProdBarcode As TextBox
	Friend WithEvents txtProductId As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
End Class
