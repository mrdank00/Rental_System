<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecieveItems
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecieveItems))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Me.BunifuDataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Amount = New System.Windows.Forms.TextBox()
        Me.gvRecieveItem = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.lblItemname = New System.Windows.Forms.Label()
        Me.BunifuButton21 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbSupplier = New System.Windows.Forms.ComboBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dpDAte = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblActualQty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInvoiceno = New System.Windows.Forms.TextBox()
        Me.BunifuSnackbar1 = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRecieveItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDataGridView1
        '
        Me.BunifuDataGridView1.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuDataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.BunifuDataGridView1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.BunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuDataGridView1.EnableHeadersVisualStyles = False
        Me.BunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.BunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.Location = New System.Drawing.Point(16, 57)
        Me.BunifuDataGridView1.Name = "BunifuDataGridView1"
        Me.BunifuDataGridView1.ReadOnly = True
        Me.BunifuDataGridView1.RowHeadersVisible = False
        Me.BunifuDataGridView1.RowTemplate.Height = 40
        Me.BunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView1.Size = New System.Drawing.Size(249, 325)
        Me.BunifuDataGridView1.TabIndex = 40
        Me.BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(345, 57)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(63, 27)
        Me.txtQty.TabIndex = 41
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(414, 57)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(77, 27)
        Me.txtPrice.TabIndex = 42
        '
        'Amount
        '
        Me.Amount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount.Location = New System.Drawing.Point(503, 57)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(68, 27)
        Me.Amount.TabIndex = 43
        '
        'gvRecieveItem
        '
        Me.gvRecieveItem.AllowCustomTheming = False
        Me.gvRecieveItem.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.gvRecieveItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvRecieveItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gvRecieveItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvRecieveItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.gvRecieveItem.BackgroundColor = System.Drawing.Color.DarkGray
        Me.gvRecieveItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvRecieveItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvRecieveItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvRecieveItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gvRecieveItem.ColumnHeadersHeight = 40
        Me.gvRecieveItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.gvRecieveItem.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRecieveItem.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvRecieveItem.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvRecieveItem.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRecieveItem.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gvRecieveItem.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.gvRecieveItem.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRecieveItem.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.gvRecieveItem.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.gvRecieveItem.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gvRecieveItem.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gvRecieveItem.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gvRecieveItem.CurrentTheme.Name = Nothing
        Me.gvRecieveItem.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gvRecieveItem.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gvRecieveItem.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gvRecieveItem.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRecieveItem.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvRecieveItem.DefaultCellStyle = DataGridViewCellStyle6
        Me.gvRecieveItem.EnableHeadersVisualStyles = False
        Me.gvRecieveItem.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvRecieveItem.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.gvRecieveItem.HeaderBgColor = System.Drawing.Color.Empty
        Me.gvRecieveItem.HeaderForeColor = System.Drawing.Color.White
        Me.gvRecieveItem.Location = New System.Drawing.Point(278, 146)
        Me.gvRecieveItem.Name = "gvRecieveItem"
        Me.gvRecieveItem.ReadOnly = True
        Me.gvRecieveItem.RowHeadersVisible = False
        Me.gvRecieveItem.RowTemplate.Height = 40
        Me.gvRecieveItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvRecieveItem.Size = New System.Drawing.Size(353, 180)
        Me.gvRecieveItem.TabIndex = 44
        Me.gvRecieveItem.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'lblItemname
        '
        Me.lblItemname.AutoSize = True
        Me.lblItemname.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemname.Location = New System.Drawing.Point(273, 100)
        Me.lblItemname.Name = "lblItemname"
        Me.lblItemname.Size = New System.Drawing.Size(160, 37)
        Me.lblItemname.TabIndex = 45
        Me.lblItemname.Text = "Item Name"
        '
        'BunifuButton21
        '
        Me.BunifuButton21.AllowAnimations = True
        Me.BunifuButton21.AllowMouseEffects = True
        Me.BunifuButton21.AllowToggling = False
        Me.BunifuButton21.AnimationSpeed = 200
        Me.BunifuButton21.AutoGenerateColors = False
        Me.BunifuButton21.AutoRoundBorders = False
        Me.BunifuButton21.AutoSizeLeftIcon = True
        Me.BunifuButton21.AutoSizeRightIcon = True
        Me.BunifuButton21.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton21.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.BackgroundImage = CType(resources.GetObject("BunifuButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.ButtonText = "SAVE"
        Me.BunifuButton21.ButtonTextMarginLeft = 0
        Me.BunifuButton21.ColorContrastOnClick = 45
        Me.BunifuButton21.ColorContrastOnHover = 45
        Me.BunifuButton21.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton21.CustomizableEdges = BorderEdges1
        Me.BunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.BunifuButton21.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton21.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton21.IconMarginLeft = 11
        Me.BunifuButton21.IconPadding = 10
        Me.BunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton21.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton21.IconSize = 25
        Me.BunifuButton21.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.IdleBorderRadius = 25
        Me.BunifuButton21.IdleBorderThickness = 1
        Me.BunifuButton21.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.IdleIconLeftImage = Nothing
        Me.BunifuButton21.IdleIconRightImage = Nothing
        Me.BunifuButton21.IndicateFocus = False
        Me.BunifuButton21.Location = New System.Drawing.Point(644, 340)
        Me.BunifuButton21.Name = "BunifuButton21"
        Me.BunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton21.OnDisabledState.BorderRadius = 25
        Me.BunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.OnDisabledState.BorderThickness = 1
        Me.BunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton21.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton21.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton21.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton21.onHoverState.BorderRadius = 25
        Me.BunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.onHoverState.BorderThickness = 1
        Me.BunifuButton21.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton21.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton21.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton21.onHoverState.IconRightImage = Nothing
        Me.BunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.OnIdleState.BorderRadius = 25
        Me.BunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.OnIdleState.BorderThickness = 1
        Me.BunifuButton21.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton21.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton21.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton21.OnPressedState.BorderRadius = 25
        Me.BunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid
        Me.BunifuButton21.OnPressedState.BorderThickness = 1
        Me.BunifuButton21.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton21.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton21.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton21.Size = New System.Drawing.Size(188, 45)
        Me.BunifuButton21.TabIndex = 46
        Me.BunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton21.TextMarginLeft = 0
        Me.BunifuButton21.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton21.UseDefaultRadiusAndThickness = True
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(22, 21)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(62, 20)
        Me.txtCat.TabIndex = 47
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(90, 21)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(62, 20)
        Me.txtSize.TabIndex = 48
        '
        'txtColour
        '
        Me.txtColour.Location = New System.Drawing.Point(159, 21)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.Size = New System.Drawing.Size(62, 20)
        Me.txtColour.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 15)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Size"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(156, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Colour"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(587, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'cbSupplier
        '
        Me.cbSupplier.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSupplier.FormattingEnabled = True
        Me.cbSupplier.Location = New System.Drawing.Point(637, 95)
        Me.cbSupplier.Name = "cbSupplier"
        Me.cbSupplier.Size = New System.Drawing.Size(195, 29)
        Me.cbSupplier.TabIndex = 54
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(657, 258)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(40, 47)
        Me.lbltotal.TabIndex = 55
        Me.lbltotal.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(641, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Total:"
        '
        'dpDAte
        '
        Me.dpDAte.BackColor = System.Drawing.Color.Transparent
        Me.dpDAte.BorderColor = System.Drawing.Color.Silver
        Me.dpDAte.BorderRadius = 1
        Me.dpDAte.Color = System.Drawing.Color.Silver
        Me.dpDAte.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dpDAte.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dpDAte.DisabledColor = System.Drawing.Color.Gray
        Me.dpDAte.DisplayWeekNumbers = False
        Me.dpDAte.DPHeight = 0
        Me.dpDAte.FillDatePicker = False
        Me.dpDAte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dpDAte.ForeColor = System.Drawing.Color.Black
        Me.dpDAte.Icon = CType(resources.GetObject("dpDAte.Icon"), System.Drawing.Image)
        Me.dpDAte.IconColor = System.Drawing.Color.Gray
        Me.dpDAte.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dpDAte.LeftTextMargin = 5
        Me.dpDAte.Location = New System.Drawing.Point(637, 146)
        Me.dpDAte.MinimumSize = New System.Drawing.Size(0, 32)
        Me.dpDAte.Name = "dpDAte"
        Me.dpDAte.Size = New System.Drawing.Size(195, 32)
        Me.dpDAte.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(634, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Choose Supplier:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(640, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 15)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Date Recieved:"
        '
        'lblActualQty
        '
        Me.lblActualQty.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualQty.Location = New System.Drawing.Point(278, 57)
        Me.lblActualQty.Name = "lblActualQty"
        Me.lblActualQty.Size = New System.Drawing.Size(63, 27)
        Me.lblActualQty.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(637, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Invoice No:"
        '
        'txtInvoiceno
        '
        Me.txtInvoiceno.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceno.Location = New System.Drawing.Point(637, 199)
        Me.txtInvoiceno.Name = "txtInvoiceno"
        Me.txtInvoiceno.Size = New System.Drawing.Size(195, 27)
        Me.txtInvoiceno.TabIndex = 62
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
        'Column1
        '
        Me.Column1.HeaderText = "Itemname"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 107
        '
        'Column2
        '
        Me.Column2.HeaderText = "Price"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 69
        '
        'Column3
        '
        Me.Column3.HeaderText = "Qty"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 59
        '
        'Column4
        '
        Me.Column4.HeaderText = "Amount"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 92
        '
        'Column5
        '
        Me.Column5.HeaderText = "Category"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 101
        '
        'Column6
        '
        Me.Column6.HeaderText = "Colour"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 82
        '
        'Column7
        '
        Me.Column7.HeaderText = "Size"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 62
        '
        'Column8
        '
        Me.Column8.HeaderText = "OldQty"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 85
        '
        'Column9
        '
        Me.Column9.HeaderText = "NewQty"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 92
        '
        'RecieveItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtInvoiceno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblActualQty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dpDAte)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.cbSupplier)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtColour)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.BunifuButton21)
        Me.Controls.Add(Me.lblItemname)
        Me.Controls.Add(Me.gvRecieveItem)
        Me.Controls.Add(Me.Amount)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.BunifuDataGridView1)
        Me.Name = "RecieveItems"
        Me.Size = New System.Drawing.Size(835, 400)
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRecieveItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuDataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Amount As TextBox
    Friend WithEvents gvRecieveItem As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents lblItemname As Label
    Friend WithEvents BunifuButton21 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents txtCat As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtColour As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbSupplier As ComboBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dpDAte As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblActualQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInvoiceno As TextBox
    Friend WithEvents BunifuSnackbar1 As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
