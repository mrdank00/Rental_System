<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RentalPreloader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.BunifuCircleProgress2 = New Bunifu.UI.WinForms.BunifuCircleProgress()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BunifuCircleProgress2
        '
        Me.BunifuCircleProgress2.Animated = False
        Me.BunifuCircleProgress2.AnimationInterval = 1
        Me.BunifuCircleProgress2.AnimationSpeed = 1
        Me.BunifuCircleProgress2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgress2.CircleMargin = 10
        Me.BunifuCircleProgress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCircleProgress2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCircleProgress2.IsPercentage = True
        Me.BunifuCircleProgress2.LineProgressThickness = 10
        Me.BunifuCircleProgress2.LineThickness = 10
        Me.BunifuCircleProgress2.Location = New System.Drawing.Point(161, 12)
        Me.BunifuCircleProgress2.Name = "BunifuCircleProgress2"
        Me.BunifuCircleProgress2.ProgressAnimationSpeed = 200
        Me.BunifuCircleProgress2.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgress2.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress2.ProgressColor2 = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress2.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round
        Me.BunifuCircleProgress2.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Gradient
        Me.BunifuCircleProgress2.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round
        Me.BunifuCircleProgress2.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BunifuCircleProgress2.Size = New System.Drawing.Size(253, 253)
        Me.BunifuCircleProgress2.SubScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress2.SubScriptMargin = New System.Windows.Forms.Padding(5, -20, 0, 0)
        Me.BunifuCircleProgress2.SubScriptText = ".00"
        Me.BunifuCircleProgress2.SuperScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress2.SuperScriptMargin = New System.Windows.Forms.Padding(5, 50, 0, 0)
        Me.BunifuCircleProgress2.SuperScriptText = "%"
        Me.BunifuCircleProgress2.TabIndex = 16
        Me.BunifuCircleProgress2.Text = "100"
        Me.BunifuCircleProgress2.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.BunifuCircleProgress2.Value = 100
        Me.BunifuCircleProgress2.ValueByTransition = 100
        Me.BunifuCircleProgress2.ValueMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'Timer1
        '
        '
        'RentalPreloader
        '
        Me.ClientSize = New System.Drawing.Size(616, 298)
        Me.Controls.Add(Me.BunifuCircleProgress2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RentalPreloader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCircleProgress1 As Bunifu.UI.WinForms.BunifuCircleProgress
    'Friend WithEvents BunifuProgressBar1 As BunifuProgressBar
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BunifuCircleProgress2 As Bunifu.UI.WinForms.BunifuCircleProgress
    Friend WithEvents Timer1 As Timer
End Class
