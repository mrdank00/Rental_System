﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecieveRentals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecieveRentals))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblinvoice = New System.Windows.Forms.Label()
        Me.cbCustname = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gvRentals = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvRentalConfig = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.txtRetuned = New System.Windows.Forms.TextBox()
        Me.txtMissing = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BunifuSnackbar1 = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ckPreview = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ckPrint = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.gvRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRentalConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblinvoice
        '
        Me.lblinvoice.AutoSize = True
        Me.lblinvoice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvoice.Location = New System.Drawing.Point(909, 23)
        Me.lblinvoice.Name = "lblinvoice"
        Me.lblinvoice.Size = New System.Drawing.Size(72, 17)
        Me.lblinvoice.TabIndex = 66
        Me.lblinvoice.Text = "InvoiceNO"
        Me.lblinvoice.Visible = False
        '
        'cbCustname
        '
        Me.cbCustname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cbCustname.Enabled = False
        Me.cbCustname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCustname.FormattingEnabled = True
        Me.cbCustname.Location = New System.Drawing.Point(950, 262)
        Me.cbCustname.Name = "cbCustname"
        Me.cbCustname.Size = New System.Drawing.Size(172, 29)
        Me.cbCustname.TabIndex = 65
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(147, 17)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Total Missing Payable:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(97, 116)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 47)
        Me.lblTotal.TabIndex = 61
        Me.lblTotal.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-3, 288)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 17)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Location:"
        '
        'txtLocation
        '
        Me.txtLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtLocation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(950, 333)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.ReadOnly = True
        Me.txtLocation.Size = New System.Drawing.Size(172, 27)
        Me.txtLocation.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1, 255)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Contact:"
        '
        'txtContact
        '
        Me.txtContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtContact.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(950, 300)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(172, 27)
        Me.txtContact.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(2, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Name:"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(6, 72)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(185, 45)
        Me.lblItemName.TabIndex = 54
        Me.lblItemName.Text = "Item Name"
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.BunifuThinButton22.Location = New System.Drawing.Point(976, 509)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(155, 65)
        Me.BunifuThinButton22.TabIndex = 53
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(385, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 17)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Customer Name:"
        Me.Label5.Visible = False
        '
        'gvRentals
        '
        Me.gvRentals.AllowCustomTheming = False
        Me.gvRentals.AllowUserToAddRows = False
        Me.gvRentals.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        Me.gvRentals.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.gvRentals.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvRentals.BackgroundColor = System.Drawing.Color.White
        Me.gvRentals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvRentals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvRentals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvRentals.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.gvRentals.ColumnHeadersHeight = 40
        Me.gvRentals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.ItemCost, Me.Column3, Me.Column7, Me.Column8, Me.Column6, Me.Category, Me.Column4, Me.Column5, Me.Column2})
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
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvRentals.DefaultCellStyle = DataGridViewCellStyle15
        Me.gvRentals.EnableHeadersVisualStyles = False
        Me.gvRentals.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRentals.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.gvRentals.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvRentals.HeaderForeColor = System.Drawing.Color.White
        Me.gvRentals.Location = New System.Drawing.Point(370, 174)
        Me.gvRentals.Name = "gvRentals"
        Me.gvRentals.ReadOnly = True
        Me.gvRentals.RowHeadersVisible = False
        Me.gvRentals.RowTemplate.Height = 40
        Me.gvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvRentals.Size = New System.Drawing.Size(516, 390)
        Me.gvRentals.TabIndex = 38
        Me.gvRentals.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'Column1
        '
        Me.Column1.HeaderText = "ItemName"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 110
        '
        'ItemCost
        '
        Me.ItemCost.HeaderText = "ItemCost"
        Me.ItemCost.Name = "ItemCost"
        Me.ItemCost.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "QtyRented"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 112
        '
        'Column7
        '
        Me.Column7.HeaderText = "QtyReturned"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 127
        '
        'Column8
        '
        Me.Column8.HeaderText = "QtyMissing"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 115
        '
        'Column6
        '
        Me.Column6.HeaderText = "Amount"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 92
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        Me.Category.Width = 101
        '
        'Column4
        '
        Me.Column4.HeaderText = "Colour"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 82
        '
        'Column5
        '
        Me.Column5.HeaderText = "Size"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 62
        '
        'Column2
        '
        Me.Column2.HeaderText = "Price"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 69
        '
        'gvRentalConfig
        '
        Me.gvRentalConfig.AllowCustomTheming = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        Me.gvRentalConfig.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.gvRentalConfig.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gvRentalConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvRentalConfig.BackgroundColor = System.Drawing.Color.Silver
        Me.gvRentalConfig.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvRentalConfig.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvRentalConfig.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvRentalConfig.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.gvRentalConfig.ColumnHeadersHeight = 40
        Me.gvRentalConfig.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRentalConfig.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvRentalConfig.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvRentalConfig.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRentalConfig.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gvRentalConfig.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.gvRentalConfig.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRentalConfig.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.gvRentalConfig.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.gvRentalConfig.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvRentalConfig.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gvRentalConfig.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gvRentalConfig.CurrentTheme.Name = Nothing
        Me.gvRentalConfig.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvRentalConfig.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvRentalConfig.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvRentalConfig.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRentalConfig.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvRentalConfig.DefaultCellStyle = DataGridViewCellStyle18
        Me.gvRentalConfig.EnableHeadersVisualStyles = False
        Me.gvRentalConfig.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRentalConfig.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.gvRentalConfig.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvRentalConfig.HeaderForeColor = System.Drawing.Color.White
        Me.gvRentalConfig.Location = New System.Drawing.Point(12, 89)
        Me.gvRentalConfig.Name = "gvRentalConfig"
        Me.gvRentalConfig.ReadOnly = True
        Me.gvRentalConfig.RowHeadersVisible = False
        Me.gvRentalConfig.RowTemplate.Height = 40
        Me.gvRentalConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvRentalConfig.Size = New System.Drawing.Size(343, 475)
        Me.gvRentalConfig.TabIndex = 36
        Me.gvRentalConfig.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(474, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(394, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "QtyReturned"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(659, 89)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(85, 37)
        Me.txtPrice.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Rented Qty"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(376, 89)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(80, 37)
        Me.txtQty.TabIndex = 39
        '
        'txtAmt
        '
        Me.txtAmt.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.Location = New System.Drawing.Point(754, 89)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(80, 37)
        Me.txtAmt.TabIndex = 43
        '
        'txtRetuned
        '
        Me.txtRetuned.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetuned.Location = New System.Drawing.Point(470, 89)
        Me.txtRetuned.Name = "txtRetuned"
        Me.txtRetuned.Size = New System.Drawing.Size(85, 37)
        Me.txtRetuned.TabIndex = 67
        '
        'txtMissing
        '
        Me.txtMissing.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMissing.Location = New System.Drawing.Point(561, 89)
        Me.txtMissing.Name = "txtMissing"
        Me.txtMissing.Size = New System.Drawing.Size(85, 37)
        Me.txtMissing.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(198, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "QtyMissing"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(300, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Price"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblItemName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(364, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 117)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quantities"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(888, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 419)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total"
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
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(912, 555)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Preview"
        '
        'ckPreview
        '
        Me.ckPreview.AllowBindingControlAnimation = True
        Me.ckPreview.AllowBindingControlColorChanges = False
        Me.ckPreview.AllowBindingControlLocation = True
        Me.ckPreview.AllowCheckBoxAnimation = False
        Me.ckPreview.AllowCheckmarkAnimation = True
        Me.ckPreview.AllowOnHoverStates = True
        Me.ckPreview.Anchor = System.Windows.Forms.AnchorStyles.Bottom
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
        Me.ckPreview.Location = New System.Drawing.Point(889, 554)
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
        Me.ckPreview.OnHoverUnchecked.BorderColor = System.Drawing.Color.Black
        Me.ckPreview.OnHoverUnchecked.BorderRadius = 12
        Me.ckPreview.OnHoverUnchecked.BorderThickness = 2
        Me.ckPreview.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckPreview.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.ckPreview.OnUncheck.BorderRadius = 12
        Me.ckPreview.OnUncheck.BorderThickness = 1
        Me.ckPreview.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ckPreview.Size = New System.Drawing.Size(17, 17)
        Me.ckPreview.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.ckPreview.TabIndex = 76
        Me.ckPreview.ThreeState = False
        Me.ckPreview.ToolTipText = Nothing
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(912, 522)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Print"
        '
        'ckPrint
        '
        Me.ckPrint.AllowBindingControlAnimation = True
        Me.ckPrint.AllowBindingControlColorChanges = False
        Me.ckPrint.AllowBindingControlLocation = True
        Me.ckPrint.AllowCheckBoxAnimation = False
        Me.ckPrint.AllowCheckmarkAnimation = True
        Me.ckPrint.AllowOnHoverStates = True
        Me.ckPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
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
        Me.ckPrint.Location = New System.Drawing.Point(889, 521)
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
        Me.ckPrint.TabIndex = 74
        Me.ckPrint.ThreeState = False
        Me.ckPrint.ToolTipText = Nothing
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(343, 29)
        Me.ComboBox1.TabIndex = 77
        '
        'RecieveRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ckPreview)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ckPrint)
        Me.Controls.Add(Me.txtMissing)
        Me.Controls.Add(Me.txtRetuned)
        Me.Controls.Add(Me.lblinvoice)
        Me.Controls.Add(Me.cbCustname)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gvRentals)
        Me.Controls.Add(Me.gvRentalConfig)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "RecieveRentals"
        Me.Size = New System.Drawing.Size(1136, 588)
        CType(Me.gvRentals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRentalConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblinvoice As Label
    Friend WithEvents cbCustname As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label5 As Label
    Friend WithEvents gvRentals As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents gvRentalConfig As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtAmt As TextBox
    Friend WithEvents txtRetuned As TextBox
    Friend WithEvents txtMissing As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BunifuSnackbar1 As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents Label13 As Label
    Friend WithEvents ckPreview As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ckPrint As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemCost As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
End Class
