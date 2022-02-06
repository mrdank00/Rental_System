Public Class Rental
    Private Sub Rental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display()
    End Sub
    Sub display()
        Reload("Select * from Stockmast", BunifuDataGridView1)
        ComboFeed("Select name from customers", ComboBox1, 0)
    End Sub

    Private Sub BunifuDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellClick
        Try
            Dim row As DataGridViewRow = BunifuDataGridView1.Rows(e.RowIndex)
            lblItemName.Text = row.Cells(1).Value.ToString()
            txtPrice.Text = row.Cells(2).Value.ToString()
            txtCat.Text = row.Cells(4).Value.ToString()
            txtColour.Text = row.Cells(5).Value.ToString()
            txtSize.Text = row.Cells(6).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        txtAmt.Text = Val(txtPrice.Text) * Val(txtQty.Text)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        gvRentals.Rows.Add(lblItemName.Text, txtQty.Text, txtPrice.Text, txtAmt.Text, txtCat.Text, txtColour.Text, txtSize.Text)
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        txtAmt.Text = Val(txtPrice.Text) * Val(txtQty.Text)
    End Sub

    Private Sub gvRentals_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles gvRentals.RowsAdded
        Dim sum As Decimal
        For k = 0 To gvRentals.RowCount - 1
            sum += gvRentals.Rows(k).Cells(3).Value
        Next
        lblTotal.Text = sum
    End Sub

    Private Sub gvRentals_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles gvRentals.RowsRemoved
        Dim sum As Decimal
        For k = 0 To gvRentals.RowCount - 1
            sum += gvRentals.Rows(k).Cells(3).Value
        Next
        lblTotal.Text = sum
    End Sub
End Class
