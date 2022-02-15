Public Class Form1
    Private Sub BunifuButton21_Click(sender As Object, e As EventArgs) Handles BunifuButton21.Click
        BunifuPages1.SetPage("Customers")
        lblHeader.Text = "Customers"
    End Sub

    Private Sub BunifuButton23_Click(sender As Object, e As EventArgs) Handles BunifuButton23.Click
        BunifuPages1.SetPage("Products")
        lblHeader.Text = "Products"
    End Sub

    Private Sub BunifuButton22_Click(sender As Object, e As EventArgs) Handles BunifuButton22.Click

        BunifuPages1.SetPage("Rent")
        lblHeader.Text = "Rent"
    End Sub

    Private Sub BunifuButton24_Click(sender As Object, e As EventArgs) Handles BunifuButton24.Click
        BunifuPages1.SetPage("Report")
        lblHeader.Text = "Report"
    End Sub

    Private Sub BunifuButton25_Click(sender As Object, e As EventArgs) Handles BunifuButton25.Click
        BunifuPages1.SetPage("RentalReturns")
        lblHeader.Text = "Rental Returns"

    End Sub
End Class
