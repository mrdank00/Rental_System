<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rental
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rental))
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RentDashboard1 = New Rental_System.RentDashboard()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NewRent1 = New Rental_System.newRent()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuButton21 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton2()
        Me.BunifuDataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuSnackbar1 = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage3)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1176, 623)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 0
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RentDashboard1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1168, 575)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DashBoard"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RentDashboard1
        '
        Me.RentDashboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RentDashboard1.Location = New System.Drawing.Point(3, 3)
        Me.RentDashboard1.Name = "RentDashboard1"
        Me.RentDashboard1.Size = New System.Drawing.Size(1162, 569)
        Me.RentDashboard1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.NewRent1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1168, 575)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rent"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'NewRent1
        '
        Me.NewRent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewRent1.Location = New System.Drawing.Point(3, 3)
        Me.NewRent1.Name = "NewRent1"
        Me.NewRent1.Size = New System.Drawing.Size(1162, 569)
        Me.NewRent1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.BunifuButton21)
        Me.TabPage3.Controls.Add(Me.BunifuDataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1168, 575)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Deliveries"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Todays Deliveries"
        '
        'BunifuButton21
        '
        Me.BunifuButton21.AllowAnimations = True
        Me.BunifuButton21.AllowMouseEffects = True
        Me.BunifuButton21.AllowToggling = False
        Me.BunifuButton21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.BunifuButton21.CustomizableEdges = BorderEdges3
        Me.BunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed
        Me.BunifuButton21.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BunifuButton21.Location = New System.Drawing.Point(891, 501)
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
        Me.BunifuButton21.Size = New System.Drawing.Size(248, 64)
        Me.BunifuButton21.TabIndex = 1
        Me.BunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton21.TextMarginLeft = 0
        Me.BunifuButton21.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton21.UseDefaultRadiusAndThickness = True
        '
        'BunifuDataGridView1
        '
        Me.BunifuDataGridView1.AllowCustomTheming = False
        Me.BunifuDataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.BunifuDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle9
        Me.BunifuDataGridView1.EnableHeadersVisualStyles = False
        Me.BunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.BunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.Location = New System.Drawing.Point(31, 42)
        Me.BunifuDataGridView1.Name = "BunifuDataGridView1"
        Me.BunifuDataGridView1.RowHeadersVisible = False
        Me.BunifuDataGridView1.RowTemplate.Height = 40
        Me.BunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView1.Size = New System.Drawing.Size(1131, 453)
        Me.BunifuDataGridView1.TabIndex = 0
        Me.BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'Column4
        '
        Me.Column4.HeaderText = "Colour"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 82
        '
        'ItemCost
        '
        Me.ItemCost.HeaderText = "ItemCost"
        Me.ItemCost.Name = "ItemCost"
        Me.ItemCost.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ItemName"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 110
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
        'Column6
        '
        Me.Column6.HeaderText = "Amount"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 92
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
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        Me.Category.Width = 101
        '
        'Column3
        '
        Me.Column3.HeaderText = "Qty"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 59
        '
        'Rental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.Name = "Rental"
        Me.Size = New System.Drawing.Size(1176, 623)
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents ItemCost As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents BunifuSnackbar1 As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents NewRent1 As newRent
    Friend WithEvents RentDashboard1 As RentDashboard
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents BunifuButton21 As Bunifu.UI.WinForms.BunifuButton.BunifuButton2
    Friend WithEvents BunifuDataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Label1 As Label
End Class
