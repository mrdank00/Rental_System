Public Class RecieveItems
    Private Sub RecieveItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub
    Sub Display()
        Reload("Select * from Stockmast", BunifuDataGridView1)
        ComboFeed("Select distinct suppliername from Recievestock", cbSupplier, 0)
    End Sub

    Private Sub BunifuDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellClick
        Try
            Dim row As DataGridViewRow = BunifuDataGridView1.Rows(e.RowIndex)
            lblItemName.Text = row.Cells(1).Value.ToString()
            txtPrice.Text = row.Cells(2).Value.ToString()
            txtCat.Text = row.Cells(4).Value.ToString()
            txtColour.Text = row.Cells(5).Value.ToString()
            txtSize.Text = row.Cells(6).Value.ToString()
            lblActualQty.Text = row.Cells(3).Value.ToString()
            'lblItemCost.Text = row.Cells(7).Value.ToString()
            txtQty.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        Amount.Text = Val(txtPrice.Text) * Val(txtQty.Text)
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        Amount.Text = Val(txtPrice.Text) * Val(txtQty.Text)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        For Each row As DataGridViewRow In gvRecieveItem.Rows
            If lblItemname.Text = row.Cells(0).Value Then
                MsgBox("Item already added")
                Exit Sub
            End If
        Next
        gvRecieveItem.Rows.Add(lblItemname.Text, txtPrice.Text, txtQty.Text, Amount.Text, txtCat.Text, txtColour.Text, txtSize.Text, lblActualQty.Text, Val(lblActualQty.Text) + Val(txtQty.Text))
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
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

    Private Sub BunifuButton21_Click(sender As Object, e As EventArgs) Handles BunifuButton21.Click
        For Each row As DataGridViewRow In gvRecieveItem.Rows
            Insert("insert into recievestock(Itemname,price,QtyRecieved,Amount,Oldstock,Newstock,date,suppliername,invoiceno,category,colour,size) values('" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(7).Value & "','" & row.Cells(8).Value & "','" + dpDAte.Text + "','" + cbSupplier.Text + "','" + txtInvoiceno.Text + "','" & row.Cells(4).Value & "','" & row.Cells(5).Value & "','" & row.Cells(6).Value & "')")
            Insert("update stockmast set qty=qty + '" & row.Cells(2).Value & "' where itemname='" + row.Cells(0).Value + "'")
        Next
        Display()
        gvRecieveItem.Rows.Clear()
        clear
        BunifuSnackbar1.Show(Me.FindForm, "Success")
    End Sub

    Private Sub gvRecieveItem_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles gvRecieveItem.RowsAdded
        Dim sum As Decimal
        For k = 0 To gvRecieveItem.RowCount - 1
            sum += gvRecieveItem.Rows(k).Cells(3).Value
        Next
        lblTotal.Text = sum
    End Sub

    Private Sub gvRecieveItem_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles gvRecieveItem.RowsRemoved
        Dim sum As Decimal
        For k = 0 To gvRecieveItem.RowCount - 1
            sum += gvRecieveItem.Rows(k).Cells(3).Value
        Next
        lblTotal.Text = sum
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Reload("select * from Stockmast where itemname like '%" + ComboBox1.Text + "%' ", BunifuDataGridView1)
    End Sub
End Class
