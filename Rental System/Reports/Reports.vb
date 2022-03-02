Public Class Reports
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Me.Hide()
    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        'WindowState = FormWindowState.Maximized
    End Sub
End Class