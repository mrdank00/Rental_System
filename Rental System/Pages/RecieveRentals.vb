Imports System.Data.SqlClient
Public Class RecieveRentals
    Dim dt As New dsRental

    Sub Display()
        Reload("select * from rentalconfig where status ='" + "Booked" + "'", gvRentalConfig)
    End Sub

    Private Sub RecieveRentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display()
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
            If tbl.Rows.Count = 0 Then
                MsgBox("This is invalid")
                Insert("delete from rentalconfig where invoiceno='" + lblinvoice.Text + "'")
                Display()
                Exit Sub
            End If
            cbCustname.Text = tbl.Rows(0)(1).ToString
            txtContact.Text = tbl.Rows(0)(2).ToString
            txtLocation.Text = tbl.Rows(0)(3).ToString
            For k = 0 To tbl.Rows.Count - 1
                gvRentals.Rows.Add(tbl.Rows(k)(4).ToString, tbl.Rows(k)(22).ToString, tbl.Rows(k)(5).ToString, tbl.Rows(k)(13).ToString, tbl.Rows(k)(14).ToString, 0, tbl.Rows(k)(8).ToString, tbl.Rows(k)(10).ToString, tbl.Rows(k)(9).ToString, tbl.Rows(k)(6).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub gvRentals_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvRentals.CellClick
        Try
            Dim row As DataGridViewRow = gvRentals.Rows(e.RowIndex)
            txtQty.Text = row.Cells(2).Value.ToString()
            txtPrice.Text = row.Cells(1).Value.ToString()
            lblItemName.Text = row.Cells(0).Value.ToString()
        Catch ex As Exception

        End Try

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
        Clear()
    End Sub

    Public Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Try
            If gvRentals.Rows.Count = 0 Then
                MsgBox("Kindly select a Rental to Recieve")
                Exit Sub
            End If


            If RentCon.State = ConnectionState.Closed Then
                RentCon.Open()
            End If
            For Each row As DataGridViewRow In gvRentals.Rows
                ' Insert("update Rentaltranx set qtyReturned ='" + row.Cells(3).Value.ToString + "',qtymissing='" + row.Cells(4).Value + "',amountmissing='" + row.Cells(5).Value + "' where itemname='" + row.Cells(0).Value + "' and invoiceno='" + lblinvoice.Text + "'")
                Dim query = "update Rentaltranx set qtyReturned =@Qtyreturned,qtymissing=@qtymissing,amountmissing=@amountmissing,Recievedstamp=convert(datetime,'" + DateTime.Now + "',105) where itemname='" + row.Cells(0).Value + "' and invoiceno='" + lblinvoice.Text + "'"
                cmd = New SqlCommand(query, RentCon)
                With cmd
                    .Parameters.AddWithValue("@Qtyreturned", SqlDbType.Float).Value = row.Cells(3).Value.ToString
                    .Parameters.AddWithValue("@qtymissing", row.Cells(4).Value)
                    .Parameters.AddWithValue("@amountMissing", row.Cells(5).Value)
                    .ExecuteNonQuery()
                End With
            Next
            For k = 0 To gvRentals.RowCount - 1
                If RentCon.State = ConnectionState.Closed Then
                    RentCon.Open()
                End If
                Dim sqll = "Select * from StockMast where itemname='" + gvRentals.Rows(k).Cells(0).Value + "'"
                cmd = New SqlCommand(sqll, RentCon)
                dr = cmd.ExecuteReader
                While dr.Read
                    Dim query = "update StockMast set qty = '" & dr.Item("Qty") + gvRentals.Rows(k).Cells(3).Value & "' where itemname= '" & gvRentals.Rows(k).Cells(0).Value & "'"
                    cmd = New SqlCommand(query, RentCon)
                    cmd.ExecuteNonQuery()
                End While
            Next
            Insert("update RentalConfig set status='" + "Returned" + "' where invoiceno='" + lblinvoice.Text + "'")
            If RentCon.State = ConnectionState.Closed Then
                RentCon.Open()
            End If
            cmd = New SqlCommand("Select customerbalance from customers where name='" + cbCustname.Text + "'", RentCon)
            dr = cmd.ExecuteReader
            While dr.Read
                cmd = New SqlCommand("update customers set customerbalance = '" & dr.Item("customerbalance") + Val(lblTotal.Text) & "' where name= '" & cbCustname.Text & "'", RentCon)
                cmd.ExecuteNonQuery()
            End While
            RentCon.Close()
            Rentalreturninvoice()
            Display()
            gvRentals.Rows.Clear()
            Clear()
            BunifuSnackbar1.Show(Me.FindForm, "sucess")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Rentalreturninvoice()
        Dim query = "select * from RentalTranx where invoiceno='" + lblinvoice.Text + "'"
        cmd = New SqlCommand(query, RentCon)
        dt.Tables("RentalTranx").Rows.Clear()
        da.SelectCommand = cmd
        da.Fill(dt, "RentalTranx")

        Dim sql = "select * from ClientReg"
        dt.Tables("ClientReg").Rows.Clear()
        cmd = New SqlCommand(sql, RentCon)
        da.SelectCommand = cmd
        da.Fill(dt, "ClientReg")

        Dim report As New rptRentalRecieveInvoice
        report.SetDataSource(dt)
        If ckPreview.Checked = True Then
            Reports.CrystalReportViewer1.ReportSource = report
            Reports.Show()
            Reports.CrystalReportViewer1.Refresh()
        End If
        If ckPrint.Checked = True Then
            report.PrintToPrinter(1, True, 0, 0)
        End If
    End Sub

    Private Sub gvRentals_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles gvRentals.RowsAdded

    End Sub
    Public Sub Clear()
        For Each control As Control In Me.Controls
            'If TypeOf control Is TextBox Then
            '    control.Text = ""
            'End If
            'If TypeOf control Is ComboBox Then
            '    control.Text = ""
            'End If
        Next
        txtMissing.Text = ""
        txtQty.Text = ""
        txtPrice.Text = ""
        txtRetuned.Text = ""
        txtAmt.Text = ""
    End Sub

    Private Sub cbCustname_MouseClick(sender As Object, e As MouseEventArgs) Handles cbCustname.MouseClick
        Display()
    End Sub

    Private Sub RecieveRentals_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Display()
    End Sub
End Class
