<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newRent
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newRent))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblinvoice = New System.Windows.Forms.Label()
        Me.BunifuGroupBox1 = New Bunifu.UI.WinForms.BunifuGroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.gvRentals = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuDataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.ckPrint = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.ckPreview = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.lblActualQty = New System.Windows.Forms.Label()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCashPaid = New System.Windows.Forms.TextBox()
        Me.txtdelcost = New System.Windows.Forms.TextBox()
        Me.txtDelLocation = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.cbCustname = New System.Windows.Forms.ComboBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dpDelDate = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblItemCost = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuSnackbar1 = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.BunifuGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblinvoice
        '
        Me.lblinvoice.AutoSize = True
        Me.lblinvoice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvoice.Location = New System.Drawing.Point(408, 19)
        Me.lblinvoice.Name = "lblinvoice"
        Me.lblinvoice.Size = New System.Drawing.Size(72, 17)
        Me.lblinvoice.TabIndex = 75
        Me.lblinvoice.Text = "InvoiceNO"
        Me.lblinvoice.Visible = False
        '
        'BunifuGroupBox1
        '
        Me.BunifuGroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray
        Me.BunifuGroupBox1.BorderRadius = 1
        Me.BunifuGroupBox1.BorderThickness = 1
        Me.BunifuGroupBox1.Controls.Add(Me.lblinvoice)
        Me.BunifuGroupBox1.Controls.Add(Me.PictureBox1)
        Me.BunifuGroupBox1.Controls.Add(Me.Label3)
        Me.BunifuGroupBox1.Controls.Add(Me.txtAmt)
        Me.BunifuGroupBox1.Controls.Add(Me.Label2)
        Me.BunifuGroupBox1.Controls.Add(Me.txtPrice)
        Me.BunifuGroupBox1.Controls.Add(Me.Label1)
        Me.BunifuGroupBox1.Controls.Add(Me.txtQty)
        Me.BunifuGroupBox1.Controls.Add(Me.lblItemName)
        Me.BunifuGroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuGroupBox1.LabelIndent = 10
        Me.BunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid
        Me.BunifuGroupBox1.Location = New System.Drawing.Point(361, 27)
        Me.BunifuGroupBox1.Name = "BunifuGroupBox1"
        Me.BunifuGroupBox1.Size = New System.Drawing.Size(509, 136)
        Me.BunifuGroupBox1.TabIndex = 76
        Me.BunifuGroupBox1.TabStop = False
        Me.BunifuGroupBox1.Text = "Quantity"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(376, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(253, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Amount"
        '
        'txtAmt
        '
        Me.txtAmt.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.Location = New System.Drawing.Point(252, 50)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(80, 37)
        Me.txtAmt.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(131, 50)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(80, 37)
        Me.txtPrice.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Qty"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(5, 51)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(80, 37)
        Me.txtQty.TabIndex = 7
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(-3, 91)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(185, 45)
        Me.lblItemName.TabIndex = 22
        Me.lblItemName.Text = "Item Name"
        '
        'txtSize
        '
        Me.txtSize.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSize.Location = New System.Drawing.Point(181, 23)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(66, 22)
        Me.txtSize.TabIndex = 70
        '
        'txtColour
        '
        Me.txtColour.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColour.Location = New System.Drawing.Point(99, 23)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.Size = New System.Drawing.Size(66, 22)
        Me.txtColour.TabIndex = 68
        '
        'txtCat
        '
        Me.txtCat.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCat.Location = New System.Drawing.Point(9, 23)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(66, 22)
        Me.txtCat.TabIndex = 65
        '
        'gvRentals
        '
        Me.gvRentals.AllowCustomTheming = False
        Me.gvRentals.AllowUserToAddRows = False
        Me.gvRentals.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.gvRentals.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvRentals.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvRentals.BackgroundColor = System.Drawing.Color.Silver
        Me.gvRentals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvRentals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvRentals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvRentals.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gvRentals.ColumnHeadersHeight = 40
        Me.gvRentals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemId, Me.Column1, Me.Column2, Me.Column6, Me.Column3, Me.Column4, Me.Column5, Me.Column7})
        Me.gvRentals.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRentals.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvRentals.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvRentals.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRentals.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gvRentals.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.gvRentals.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRentals.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.gvRentals.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.gvRentals.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvRentals.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gvRentals.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gvRentals.CurrentTheme.Name = Nothing
        Me.gvRentals.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvRentals.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvRentals.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvRentals.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRentals.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvRentals.DefaultCellStyle = DataGridViewCellStyle3
        Me.gvRentals.EnableHeadersVisualStyles = False
        Me.gvRentals.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRentals.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.gvRentals.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvRentals.HeaderForeColor = System.Drawing.Color.White
        Me.gvRentals.Location = New System.Drawing.Point(361, 167)
        Me.gvRentals.Name = "gvRentals"
        Me.gvRentals.RowHeadersVisible = False
        Me.gvRentals.RowTemplate.Height = 40
        Me.gvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvRentals.Size = New System.Drawing.Size(559, 390)
        Me.gvRentals.TabIndex = 64
        Me.gvRentals.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "Item Name"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.Width = 114
        '
        'Column1
        '
        Me.Column1.HeaderText = "Price"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 69
        '
        'Column2
        '
        Me.Column2.HeaderText = "Qty"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 59
        '
        'Column6
        '
        Me.Column6.HeaderText = "Amount"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 92
        '
        'Column3
        '
        Me.Column3.HeaderText = "Category"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 101
        '
        'Column4
        '
        Me.Column4.HeaderText = "Colour"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 82
        '
        'Column5
        '
        Me.Column5.HeaderText = "Size"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 62
        '
        'Column7
        '
        Me.Column7.HeaderText = "Cost of Item"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 124
        '
        'BunifuDataGridView1
        '
        Me.BunifuDataGridView1.AllowCustomTheming = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.BunifuDataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.BunifuDataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.BunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.BunifuDataGridView1.ColumnHeadersHeight = 40
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.Name = Nothing
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.BunifuDataGridView1.EnableHeadersVisualStyles = False
        Me.BunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.BunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.Location = New System.Drawing.Point(12, 108)
        Me.BunifuDataGridView1.Name = "BunifuDataGridView1"
        Me.BunifuDataGridView1.ReadOnly = True
        Me.BunifuDataGridView1.RowHeadersVisible = False
        Me.BunifuDataGridView1.RowTemplate.Height = 40
        Me.BunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView1.Size = New System.Drawing.Size(343, 449)
        Me.BunifuDataGridView1.TabIndex = 63
        Me.BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'ckPrint
        '
        Me.ckPrint.AllowBindingControlAnimation = True
        Me.ckPrint.AllowBindingControlColorChanges = False
        Me.ckPrint.AllowBindingControlLocation = True
        Me.ckPrint.AllowCheckBoxAnimation = False
        Me.ckPrint.AllowCheckmarkAnimation = True
        Me.ckPrint.AllowOnHoverStates = True
        Me.ckPrint.AutoCheck = True
        Me.ckPrint.BackColor = System.Drawing.Color.Transparent
        Me.ckPrint.BackgroundImage = CType(resources.GetObject("ckPrint.BackgroundImage"), System.Drawing.Image)
        Me.ckPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ckPrint.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.ckPrint.BorderRadius = 12
        Me.ckPrint.Checked = True
        Me.ckPrint.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
        Me.ckPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckPrint.CustomCheckmarkImage = Nothing
        Me.ckPrint.Location = New System.Drawing.Point(888, 503)
        Me.ckPrint.MinimumSize = New System.Drawing.Size(17, 17)
        Me.ckPrint.Name = "ckPrint"
        Me.ckPrint.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.ckPrint.OnCheck.BorderRadius = 12
        Me.ckPrint.OnCheck.BorderThickness = 2
        Me.ckPrint.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.ckPrint.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.ckPrint.OnCheck.CheckmarkThickness = 2
        Me.ckPrint.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.ckPrint.OnDisable.BorderRadius = 12
        Me.ckPrint.OnDisable.BorderThickness = 2
        Me.ckPrint.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckPrint.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.ckPrint.OnDisable.CheckmarkThickness = 2
        Me.ckPrint.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckPrint.OnHoverChecked.BorderRadius = 12
        Me.ckPrint.OnHoverChecked.BorderThickness = 2
        Me.ckPrint.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckPrint.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.ckPrint.OnHoverChecked.CheckmarkThickness = 2
        Me.ckPrint.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckPrint.OnHoverUnchecked.BorderRadius = 12
        Me.ckPrint.OnHoverUnchecked.BorderThickness = 1
        Me.ckPrint.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckPrint.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.ckPrint.OnUncheck.BorderRadius = 12
        Me.ckPrint.OnUncheck.BorderThickness = 1
        Me.ckPrint.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckPrint.Size = New System.Drawing.Size(17, 17)
        Me.ckPrint.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.ckPrint.TabIndex = 78
        Me.ckPrint.ThreeState = False
        Me.ckPrint.ToolTipText = Nothing
        '
        'ckPreview
        '
        Me.ckPreview.AllowBindingControlAnimation = True
        Me.ckPreview.AllowBindingControlColorChanges = False
        Me.ckPreview.AllowBindingControlLocation = True
        Me.ckPreview.AllowCheckBoxAnimation = False
        Me.ckPreview.AllowCheckmarkAnimation = True
        Me.ckPreview.AllowOnHoverStates = True
        Me.ckPreview.AutoCheck = True
        Me.ckPreview.BackColor = System.Drawing.Color.Transparent
        Me.ckPreview.BackgroundImage = CType(resources.GetObject("ckPreview.BackgroundImage"), System.Drawing.Image)
        Me.ckPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ckPreview.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.ckPreview.BorderRadius = 12
        Me.ckPreview.Checked = False
        Me.ckPreview.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.ckPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckPreview.CustomCheckmarkImage = Nothing
        Me.ckPreview.Location = New System.Drawing.Point(888, 536)
        Me.ckPreview.MinimumSize = New System.Drawing.Size(17, 17)
        Me.ckPreview.Name = "ckPreview"
        Me.ckPreview.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.ckPreview.OnCheck.BorderRadius = 12
        Me.ckPreview.OnCheck.BorderThickness = 2
        Me.ckPreview.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.ckPreview.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.ckPreview.OnCheck.CheckmarkThickness = 2
        Me.ckPreview.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.ckPreview.OnDisable.BorderRadius = 12
        Me.ckPreview.OnDisable.BorderThickness = 2
        Me.ckPreview.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckPreview.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.ckPreview.OnDisable.CheckmarkThickness = 2
        Me.ckPreview.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckPreview.OnHoverChecked.BorderRadius = 12
        Me.ckPreview.OnHoverChecked.BorderThickness = 2
        Me.ckPreview.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckPreview.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.ckPreview.OnHoverChecked.CheckmarkThickness = 2
        Me.ckPreview.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckPreview.OnHoverUnchecked.BorderRadius = 12
        Me.ckPreview.OnHoverUnchecked.BorderThickness = 1
        Me.ckPreview.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckPreview.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.ckPreview.OnUncheck.BorderRadius = 12
        Me.ckPreview.OnUncheck.BorderThickness = 1
        Me.ckPreview.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckPreview.Size = New System.Drawing.Size(17, 17)
        Me.ckPreview.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.ckPreview.TabIndex = 80
        Me.ckPreview.ThreeState = False
        Me.ckPreview.ToolTipText = Nothing
        '
        'lblActualQty
        '
        Me.lblActualQty.AutoSize = True
        Me.lblActualQty.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualQty.Location = New System.Drawing.Point(91, 60)
        Me.lblActualQty.Name = "lblActualQty"
        Me.lblActualQty.Size = New System.Drawing.Size(38, 45)
        Me.lblActualQty.TabIndex = 73
        Me.lblActualQty.Text = "0"
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Save"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(984, 498)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(150, 65)
        Me.BunifuThinButton22.TabIndex = 72
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Actual Stock:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Category"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.txtCashPaid)
        Me.GroupBox1.Controls.Add(Me.txtdelcost)
        Me.GroupBox1.Controls.Add(Me.txtDelLocation)
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.cbCustname)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.dpDelDate)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(876, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 467)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total"
        '
        'txtCashPaid
        '
        Me.txtCashPaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtCashPaid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashPaid.Location = New System.Drawing.Point(29, 418)
        Me.txtCashPaid.Name = "txtCashPaid"
        Me.txtCashPaid.Size = New System.Drawing.Size(227, 27)
        Me.txtCashPaid.TabIndex = 40
        '
        'txtdelcost
        '
        Me.txtdelcost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtdelcost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdelcost.Location = New System.Drawing.Point(29, 368)
        Me.txtdelcost.Name = "txtdelcost"
        Me.txtdelcost.Size = New System.Drawing.Size(227, 27)
        Me.txtdelcost.TabIndex = 40
        '
        'txtDelLocation
        '
        Me.txtDelLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtDelLocation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelLocation.Location = New System.Drawing.Point(30, 240)
        Me.txtDelLocation.Name = "txtDelLocation"
        Me.txtDelLocation.Size = New System.Drawing.Size(227, 27)
        Me.txtDelLocation.TabIndex = 35
        '
        'txtLocation
        '
        Me.txtLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtLocation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(67, 157)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.ReadOnly = True
        Me.txtLocation.Size = New System.Drawing.Size(172, 27)
        Me.txtLocation.TabIndex = 28
        '
        'cbCustname
        '
        Me.cbCustname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cbCustname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCustname.FormattingEnabled = True
        Me.cbCustname.Location = New System.Drawing.Point(67, 86)
        Me.cbCustname.Name = "cbCustname"
        Me.cbCustname.Size = New System.Drawing.Size(172, 29)
        Me.cbCustname.TabIndex = 34
        '
        'txtContact
        '
        Me.txtContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtContact.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(67, 121)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(172, 27)
        Me.txtContact.TabIndex = 26
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 348)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 17)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Cost Of Delivery:"
        '
        'dpDelDate
        '
        Me.dpDelDate.BackColor = System.Drawing.Color.Transparent
        Me.dpDelDate.BorderColor = System.Drawing.Color.Silver
        Me.dpDelDate.BorderRadius = 1
        Me.dpDelDate.Color = System.Drawing.Color.Silver
        Me.dpDelDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dpDelDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpDelDate.DisabledColor = System.Drawing.Color.Gray
        Me.dpDelDate.DisplayWeekNumbers = False
        Me.dpDelDate.DPHeight = 0
        Me.dpDelDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpDelDate.FillDatePicker = False
        Me.dpDelDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dpDelDate.ForeColor = System.Drawing.Color.Black
        Me.dpDelDate.Icon = CType(resources.GetObject("dpDelDate.Icon"), System.Drawing.Image)
        Me.dpDelDate.IconColor = System.Drawing.Color.Gray
        Me.dpDelDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpDelDate.LeftTextMargin = 5
        Me.dpDelDate.Location = New System.Drawing.Point(13, 301)
        Me.dpDelDate.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dpDelDate.Name = "dpDelDate"
        Me.dpDelDate.Size = New System.Drawing.Size(220, 32)
        Me.dpDelDate.TabIndex = 39
        Me.dpDelDate.Value = New Date(2022, 3, 3, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 398)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 17)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Cash Deposited:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 220)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 17)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Delivery Location:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 282)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 17)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Delivery Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Contact:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(20, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(64, 17)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(43, 50)
        Me.lblTotal.TabIndex = 30
        Me.lblTotal.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(0, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 17)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Location:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(911, 537)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Preview"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(911, 504)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Print"
        '
        'lblItemCost
        '
        Me.lblItemCost.AutoSize = True
        Me.lblItemCost.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCost.Location = New System.Drawing.Point(284, 7)
        Me.lblItemCost.Name = "lblItemCost"
        Me.lblItemCost.Size = New System.Drawing.Size(27, 13)
        Me.lblItemCost.TabIndex = 81
        Me.lblItemCost.Text = "Size"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(180, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Size"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(98, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Colour"
        '
        'BunifuSnackbar1
        '
        Me.BunifuSnackbar1.AllowDragging = False
        Me.BunifuSnackbar1.AllowMultipleViews = True
        Me.BunifuSnackbar1.ClickToClose = True
        Me.BunifuSnackbar1.DoubleClickToClose = True
        Me.BunifuSnackbar1.DurationAfterIdle = 3000
        Me.BunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1
        Me.BunifuSnackbar1.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuSnackbar1.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.BunifuSnackbar1.ErrorOptions.IconLeftMargin = 12
        Me.BunifuSnackbar1.FadeCloseIcon = False
        Me.BunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.BunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.InformationOptions.ActionBorderRadius = 1
        Me.BunifuSnackbar1.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.BunifuSnackbar1.InformationOptions.IconLeftMargin = 12
        Me.BunifuSnackbar1.Margin = 10
        Me.BunifuSnackbar1.MaximumSize = New System.Drawing.Size(0, 0)
        Me.BunifuSnackbar1.MaximumViews = 7
        Me.BunifuSnackbar1.MessageRightMargin = 15
        Me.BunifuSnackbar1.MinimumSize = New System.Drawing.Size(0, 0)
        Me.BunifuSnackbar1.ShowBorders = False
        Me.BunifuSnackbar1.ShowCloseIcon = False
        Me.BunifuSnackbar1.ShowIcon = True
        Me.BunifuSnackbar1.ShowShadows = True
        Me.BunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1
        Me.BunifuSnackbar1.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BunifuSnackbar1.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.BunifuSnackbar1.SuccessOptions.IconLeftMargin = 12
        Me.BunifuSnackbar1.ViewsMargin = 7
        Me.BunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.WarningOptions.ActionBorderRadius = 1
        Me.BunifuSnackbar1.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BunifuSnackbar1.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.BunifuSnackbar1.WarningOptions.IconLeftMargin = 12
        Me.BunifuSnackbar1.ZoomCloseIcon = True
        '
        'newRent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuGroupBox1)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtColour)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.gvRentals)
        Me.Controls.Add(Me.BunifuDataGridView1)
        Me.Controls.Add(Me.ckPrint)
        Me.Controls.Add(Me.ckPreview)
        Me.Controls.Add(Me.lblActualQty)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblItemCost)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Name = "newRent"
        Me.Size = New System.Drawing.Size(1168, 575)
        Me.BunifuGroupBox1.ResumeLayout(False)
        Me.BunifuGroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRentals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblinvoice As Label
    Friend WithEvents BunifuGroupBox1 As Bunifu.UI.WinForms.BunifuGroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblItemName As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtColour As TextBox
    Friend WithEvents txtCat As TextBox
    Friend WithEvents gvRentals As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents BunifuDataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents ckPrint As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents ckPreview As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents lblActualQty As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCashPaid As TextBox
    Friend WithEvents txtdelcost As TextBox
    Friend WithEvents txtDelLocation As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents cbCustname As ComboBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dpDelDate As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblItemCost As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuSnackbar1 As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
