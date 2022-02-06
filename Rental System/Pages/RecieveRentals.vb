Imports System.Data.SqlClient
Public Class RecieveRentals
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click

    End Sub
    Sub Display()
        Reload("select * from rentalconfig", gvRentalConfig)
    End Sub

    Private Sub RecieveRentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub gvRentalConfig_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvRentalConfig.CellClick
        Try
            Dim row As DataGridViewRow = gvRentalConfig.Rows(e.RowIndex)
            lblinvoice.Text = row.Cells(0).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cmd = New SqlCommand("select * from RentalTranx where invoiceno='" + lblinvoice.Text + "'", RentCon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        For k = 0 To tbl.Rows.Count
            gvRentals.Rows.Add(tbl.Rows(k)(0).ToString, tbl.Rows(k)(1).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(5).ToString)
        Next

    End Sub
End Class
