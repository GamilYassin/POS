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
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.dgvProducts = New System.Windows.Forms.DataGridView()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnProdClearText = New System.Windows.Forms.Button()
		Me.btnProdDelete = New System.Windows.Forms.Button()
		Me.btnProdSave = New System.Windows.Forms.Button()
		Me.txtProdQty = New System.Windows.Forms.TextBox()
		Me.txtProdSellPrice = New System.Windows.Forms.TextBox()
		Me.txtProdBuyPrice = New System.Windows.Forms.TextBox()
		Me.txtProdDescription = New System.Windows.Forms.TextBox()
		Me.txtProdBarcode = New System.Windows.Forms.TextBox()
		Me.txtProductId = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.MenuStrip1.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersManagmentToolStripMenuItem, Me.mnuExit})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1076, 28)
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
		Me.mnuUsersMgr.Size = New System.Drawing.Size(182, 26)
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
		Me.TabControl1.Size = New System.Drawing.Size(1076, 557)
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
		Me.TabPage1.Size = New System.Drawing.Size(1068, 528)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Products"
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
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(1060, 520)
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
		Me.dgvProducts.Size = New System.Drawing.Size(654, 491)
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
		Me.GroupBox1.Location = New System.Drawing.Point(663, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(394, 491)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
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
		'txtProdQty
		'
		Me.txtProdQty.Location = New System.Drawing.Point(86, 170)
		Me.txtProdQty.Name = "txtProdQty"
		Me.txtProdQty.Size = New System.Drawing.Size(285, 22)
		Me.txtProdQty.TabIndex = 6
		'
		'txtProdSellPrice
		'
		Me.txtProdSellPrice.Location = New System.Drawing.Point(86, 139)
		Me.txtProdSellPrice.Name = "txtProdSellPrice"
		Me.txtProdSellPrice.Size = New System.Drawing.Size(285, 22)
		Me.txtProdSellPrice.TabIndex = 5
		'
		'txtProdBuyPrice
		'
		Me.txtProdBuyPrice.Location = New System.Drawing.Point(86, 108)
		Me.txtProdBuyPrice.Name = "txtProdBuyPrice"
		Me.txtProdBuyPrice.Size = New System.Drawing.Size(285, 22)
		Me.txtProdBuyPrice.TabIndex = 4
		'
		'txtProdDescription
		'
		Me.txtProdDescription.Location = New System.Drawing.Point(86, 77)
		Me.txtProdDescription.Name = "txtProdDescription"
		Me.txtProdDescription.Size = New System.Drawing.Size(285, 22)
		Me.txtProdDescription.TabIndex = 3
		'
		'txtProdBarcode
		'
		Me.txtProdBarcode.Location = New System.Drawing.Point(86, 46)
		Me.txtProdBarcode.Name = "txtProdBarcode"
		Me.txtProdBarcode.Size = New System.Drawing.Size(285, 22)
		Me.txtProdBarcode.TabIndex = 2
		'
		'txtProductId
		'
		Me.txtProductId.Enabled = False
		Me.txtProductId.Location = New System.Drawing.Point(86, 15)
		Me.txtProductId.Name = "txtProductId"
		Me.txtProductId.Size = New System.Drawing.Size(285, 22)
		Me.txtProductId.TabIndex = 1
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
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(17, 146)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(63, 17)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "SellPrice"
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
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(1, 82)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(79, 17)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Description"
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
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(74, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Product ID"
		'
		'TabPage2
		'
		Me.TabPage2.BackColor = System.Drawing.Color.PaleGreen
		Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
		Me.TabPage2.Location = New System.Drawing.Point(4, 25)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(1068, 528)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Transactions"
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.29007!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.70993!))
		Me.TableLayoutPanel2.Controls.Add(Me.DataGridView1, 0, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 1)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 2
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.03846!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.96154!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(1060, 520)
		Me.TableLayoutPanel2.TabIndex = 0
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView1.Location = New System.Drawing.Point(3, 75)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowTemplate.Height = 24
		Me.DataGridView1.Size = New System.Drawing.Size(686, 442)
		Me.DataGridView1.TabIndex = 0
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.TextBox2)
		Me.GroupBox2.Controls.Add(Me.Label8)
		Me.GroupBox2.Controls.Add(Me.TextBox1)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(686, 66)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		'
		'TextBox2
		'
		Me.TextBox2.Enabled = False
		Me.TextBox2.Location = New System.Drawing.Point(90, 39)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(285, 22)
		Me.TextBox2.TabIndex = 3
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(46, 44)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(38, 17)
		Me.Label8.TabIndex = 2
		Me.Label8.Text = "Date"
		'
		'TextBox1
		'
		Me.TextBox1.Enabled = False
		Me.TextBox1.Location = New System.Drawing.Point(90, 11)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(285, 22)
		Me.TextBox1.TabIndex = 3
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(6, 16)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(78, 17)
		Me.Label7.TabIndex = 2
		Me.Label7.Text = "Receipt No"
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.ColumnCount = 1
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.GroupBox3, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.GroupBox4, 0, 1)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(695, 75)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 2
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(362, 442)
		Me.TableLayoutPanel3.TabIndex = 4
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.Button1)
		Me.GroupBox3.Controls.Add(Me.Button2)
		Me.GroupBox3.Controls.Add(Me.Button3)
		Me.GroupBox3.Controls.Add(Me.ComboBox1)
		Me.GroupBox3.Controls.Add(Me.TextBox3)
		Me.GroupBox3.Controls.Add(Me.TextBox4)
		Me.GroupBox3.Controls.Add(Me.TextBox5)
		Me.GroupBox3.Controls.Add(Me.Label10)
		Me.GroupBox3.Controls.Add(Me.Label11)
		Me.GroupBox3.Controls.Add(Me.Label12)
		Me.GroupBox3.Controls.Add(Me.Label9)
		Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(356, 370)
		Me.GroupBox3.TabIndex = 2
		Me.GroupBox3.TabStop = False
		'
		'Button1
		'
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(241, 158)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(104, 32)
		Me.Button1.TabIndex = 13
		Me.Button1.Text = "Clear Text"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(119, 158)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(104, 32)
		Me.Button2.TabIndex = 12
		Me.Button2.Text = "Delete"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Location = New System.Drawing.Point(2, 158)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(99, 32)
		Me.Button3.TabIndex = 11
		Me.Button3.Text = "Save"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(90, 15)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(251, 24)
		Me.ComboBox1.TabIndex = 10
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(90, 114)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(251, 22)
		Me.TextBox3.TabIndex = 9
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(90, 83)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(251, 22)
		Me.TextBox4.TabIndex = 8
		'
		'TextBox5
		'
		Me.TextBox5.Enabled = False
		Me.TextBox5.Location = New System.Drawing.Point(90, 52)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(251, 22)
		Me.TextBox5.TabIndex = 7
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(54, 117)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(30, 17)
		Me.Label10.TabIndex = 4
		Me.Label10.Text = "Qty"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(5, 87)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(79, 17)
		Me.Label11.TabIndex = 5
		Me.Label11.Text = "Description"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(10, 53)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(74, 17)
		Me.Label12.TabIndex = 6
		Me.Label12.Text = "Product ID"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(23, 17)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(61, 17)
		Me.Label9.TabIndex = 2
		Me.Label9.Text = "Barcode"
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.Button5)
		Me.GroupBox4.Controls.Add(Me.Button4)
		Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox4.Location = New System.Drawing.Point(3, 379)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(356, 60)
		Me.GroupBox4.TabIndex = 3
		Me.GroupBox4.TabStop = False
		'
		'Button5
		'
		Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button5.Location = New System.Drawing.Point(185, 11)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(99, 32)
		Me.Button5.TabIndex = 11
		Me.Button5.Text = "Save"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Location = New System.Drawing.Point(64, 11)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(99, 32)
		Me.Button4.TabIndex = 11
		Me.Button4.Text = "Save"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'TabPage3
		'
		Me.TabPage3.BackColor = System.Drawing.Color.LightSalmon
		Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TabPage3.Location = New System.Drawing.Point(4, 25)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Size = New System.Drawing.Size(1068, 528)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "Reports"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1076, 585)
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
		Me.TabPage2.ResumeLayout(False)
		Me.TableLayoutPanel2.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
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
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents Button5 As Button
	Friend WithEvents Button4 As Button
End Class
