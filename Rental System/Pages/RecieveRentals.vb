Imports System.Data.SqlClient
Public Class RecieveRentals

    Sub Display()
        Reload("select * from rentalconfig", gvRentalConfig)
    End Sub

    Private Sub RecieveRentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        Clear()
    End Sub

    Private Sub gvRentalConfig_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvRentalConfig.CellClick
        Try
            Dim row As DataGridViewRow = gvRentalConfig.Rows(e.RowIndex)
            lblinvoice.Text = row.Cells(0).Value.ToString()
            gvRentals.Rows.Clear()
            cmd = New SqlCommand("select * from RentalTranx where invoiceno='" + lblinvoice.Text + "'", RentCon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable
            da.Fill(tbl)
            cbCustname.Text = tbl.Rows(0)(1).ToString
            txtContact.Text = tbl.Rows(0)(2).ToString
            txtLocation.Text = tbl.Rows(0)(3).ToString
            For k = 0 To tbl.Rows.Count - 1
                gvRentals.Rows.Add(tbl.Rows(k)(4).ToString, tbl.Rows(k)(6).ToString, tbl.Rows(k)(5).ToString, "", "", 0, tbl.Rows(k)(8).ToString, tbl.Rows(k)(10).ToString, tbl.Rows(k)(9).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub gvRentals_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvRentals.CellClick
        Dim row As DataGridViewRow = gvRentals.Rows(e.RowIndex)
        txtQty.Text = row.Cells(2).Value.ToString()
        txtPrice.Text = row.Cells(1).Value.ToString()
        lblItemName.Text = row.Cells(0).Value.ToString()
    End Sub

    Private Sub txtRetuned_TextChanged(sender As Object, e As EventArgs) Handles txtRetuned.TextChanged
        If Val(txtRetuned.Text) > Val(txtQty.Text) Then
            MsgBox("Enter a valid Quantity")
            txtRetuned.Text = ""
            txtRetuned.Focus()
            Exit Sub
        End If
        txtMissing.Text = Val(txtQty.Text) - Val(txtRetuned.Text)
        txtAmt.Text = Val(txtMissing.Text) * Val(txtPrice.Text)
    End Sub

    Private Sub txtMissing_TextChanged(sender As Object, e As EventArgs) Handles txtMissing.TextChanged
        If Val(txtMissing.Text) > Val(txtQty.Text) Then
            MsgBox("Enter a valid Quantity")
            txtMissing.Text = ""
            txtMissing.Focus()
            Exit Sub
        End If
        txtRetuned.Text = Val(txtQty.Text) - Val(txtMissing.Text)
        txtAmt.Text = Val(txtMissing.Text) * Val(txtPrice.Text)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        For Each row As DataGridViewRow In gvRentals.Rows
            If lblItemName.Text = row.Cells(0).Value Then
                row.Cells(3).Value = Val(txtRetuned.Text)
                row.Cells(4).Value = Val(txtMissing.Text)
                row.Cells(5).Value = Val(txtAmt.Text)
            End If
        Next
        Dim sum As Decimal
        For k = 0 To gvRentals.RowCount - 1
            sum += gvRentals.Rows(k).Cells(5).Value
        Next
        lblTotal.Text = sum
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If RentCon.State = ConnectionState.Closed Then
            RentCon.Open()
        End If
        For Each row As DataGridViewRow In gvRentals.Rows
            ' Insert("update Rentaltranx set qtyReturned ='" + row.Cells(3).Value.ToString + "',qtymissing='" + row.Cells(4).Value + "',amountmissing='" + row.Cells(5).Value + "' where itemname='" + row.Cells(0).Value + "' and invoiceno='" + lblinvoice.Text + "'")
            Dim query = "update Rentaltranx set qtyReturned =@Qtyreturned,qtymissing=@qtymissing,amountmissing=@amountmissing where itemname='" + row.Cells(0).Value + "' and invoiceno='" + lblinvoice.Text + "'"
            cmd = New SqlCommand(query, RentCon)
            With cmd
                .Parameters.AddWithValue("@Qtyreturned", SqlDbType.Float).Value = row.Cells(3).Value.ToString
                .Parameters.AddWithValue("@qtymissing", row.Cells(4).Value)
                .Parameters.AddWithValue("@amountMissing", row.Cells(5).Value)
                .ExecuteNonQuery()
            End With
        Next
        Clear()
        MsgBox("Saved")
    End Sub

    Private Sub gvRentals_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles gvRentals.RowsAdded

    End Sub
    Public Sub Clear()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
            If TypeOf control Is ComboBox Then
                control.Text = ""
            End If
        Next
    End Sub
End Class
