<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.dgvUsers = New System.Windows.Forms.DataGridView()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.cboPrivs = New System.Windows.Forms.ComboBox()
		Me.txtPass = New System.Windows.Forms.TextBox()
		Me.txtUserName = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.67196!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.32804!))
		Me.TableLayoutPanel1.Controls.Add(Me.dgvUsers, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 1)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.38744!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.61257!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(945, 573)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'dgvUsers
		'
		Me.dgvUsers.AllowUserToAddRows = False
		Me.dgvUsers.AllowUserToDeleteRows = False
		Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgvUsers.Location = New System.Drawing.Point(3, 3)
		Me.dgvUsers.MultiSelect = False
		Me.dgvUsers.Name = "dgvUsers"
		Me.dgvUsers.ReadOnly = True
		Me.dgvUsers.RowTemplate.Height = 24
		Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvUsers.Size = New System.Drawing.Size(539, 488)
		Me.dgvUsers.TabIndex = 7
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnClear)
		Me.GroupBox1.Controls.Add(Me.btnSave)
		Me.GroupBox1.Controls.Add(Me.cboPrivs)
		Me.GroupBox1.Controls.Add(Me.txtPass)
		Me.GroupBox1.Controls.Add(Me.txtUserName)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox1.Location = New System.Drawing.Point(548, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(394, 488)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(239, 132)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(124, 34)
		Me.btnClear.TabIndex = 5
		Me.btnClear.Text = "Clear Text"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(109, 132)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(124, 34)
		Me.btnSave.TabIndex = 4
		Me.btnSave.Text = "Save Changes"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'cboPrivs
		'
		Me.cboPrivs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cboPrivs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cboPrivs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboPrivs.FormattingEnabled = True
		Me.cboPrivs.Location = New System.Drawing.Point(89, 89)
		Me.cboPrivs.Name = "cboPrivs"
		Me.cboPrivs.Size = New System.Drawing.Size(299, 24)
		Me.cboPrivs.TabIndex = 3
		'
		'txtPass
		'
		Me.txtPass.Location = New System.Drawing.Point(89, 55)
		Me.txtPass.Name = "txtPass"
		Me.txtPass.Size = New System.Drawing.Size(299, 22)
		Me.txtPass.TabIndex = 2
		'
		'txtUserName
		'
		Me.txtUserName.Location = New System.Drawing.Point(89, 21)
		Me.txtUserName.Name = "txtUserName"
		Me.txtUserName.Size = New System.Drawing.Size(299, 22)
		Me.txtUserName.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(21, 92)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(62, 17)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Privilage"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(14, 58)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(69, 17)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Password"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(4, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(79, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "User Name"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.btnClose)
		Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox2.Location = New System.Drawing.Point(548, 497)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(394, 73)
		Me.GroupBox2.TabIndex = 2
		Me.GroupBox2.TabStop = False
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(150, 21)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(124, 34)
		Me.btnClose.TabIndex = 6
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'frmUsers
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(945, 573)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "frmUsers"
		Me.Text = "Users Manager"
		Me.TableLayoutPanel1.ResumeLayout(False)
		CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents dgvUsers As DataGridView
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnClear As Button
	Friend WithEvents btnSave As Button
	Friend WithEvents cboPrivs As ComboBox
	Friend WithEvents txtPass As TextBox
	Friend WithEvents txtUserName As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents btnClose As Button
End Class
