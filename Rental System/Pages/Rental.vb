Imports System.Data.SqlClient
Imports System.Globalization
Public Class Rental
    Dim dt As New dsRental
    Private Sub Rental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display()
        'Invoiceno()

    End Sub
    Sub Display()
        Reload("Select * from Stockmast", BunifuDataGridView1)
        ComboFeed("Select name from customers", cbCustname, 0)
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
            lblItemCost.Text = row.Cells(7).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        txtAmt.Text = Val(txtPrice.Text) * Val(txtQty.Text)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        For Each row As DataGridViewRow In gvRentals.Rows
            If lblItemName.Text = row.Cells(0).Value Then
                MsgBox("Item already added")
                Exit Sub
            End If
        Next
        gvRentals.Rows.Add(lblItemName.Text, txtPrice.Text, txtQty.Text, txtAmt.Text, txtCat.Text, txtColour.Text, txtSize.Text, lblItemCost.Text)
        For Each control As Control In Me.BunifuGroupBox1.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
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

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Try
            If gvRentals.Rows.Count = 0 Then
                MsgBox("Kindly select items to rent")
                Exit Sub
            End If

            If cbCustname.Text = "" Or cbCustname.SelectedIndex = -1 Or txtContact.Text = "" Or txtLocation.Text = "" Then
                MsgBox("Select or enter Customer details to Proceed")
                cbCustname.Focus()
                Exit Sub
            End If

            If Val(txtCashPaid.Text) <= 0 Then
                MsgBox("Only Cash Paid Rentals are allowed")
                Exit Sub
            End If
            Insert("insert into Rentalconfig(Customername,location,contact,total,status,Deliverylocation,DeliveryDate,RentedStamp) values('" + cbCustname.Text + "','" + txtLocation.Text + "','" + txtContact.Text + "','" + lblTotal.Text + "','" + "Booked" + "','" + txtDelLocation.Text + "','" + dpDelDate.Text + "',convert(datetime,'" + DateTime.Now + "',105))")

            Invoiceno()

            For Each row As DataGridViewRow In gvRentals.Rows
                Insert("insert into rentaltranx(invoiceno,Customername,tel,location,itemname,qty,price,amount,category,size,colour,Deliverylocation,DeliveryDate,cashdeposited,DeliveryCost,Itemcost,rentedstamp) values('" + lblinvoice.Text + "','" + cbCustname.Text + "','" + txtContact.Text + "','" + txtLocation.Text + "','" + row.Cells(0).Value + "','" + row.Cells(2).Value + "','" + row.Cells(1).Value + "','" + row.Cells(3).Value + "','" + row.Cells(4).Value + "','" + row.Cells(6).Value + "','" + row.Cells(5).Value + "','" + txtDelLocation.Text + "','" + dpDelDate.Text + "','" + txtCashPaid.Text + "','" + txtdelcost.Text + "','" + row.Cells(7).Value + "',convert(datetime,'" + DateTime.Now + "',105))")
            Next

            For k = 0 To gvRentals.RowCount - 1
                If RentCon.State = ConnectionState.Closed Then
                    RentCon.Open()
                End If
                Dim sqll = "Select * from StockMast where itemname='" + gvRentals.Rows(k).Cells(0).Value + "'"
                cmd = New SqlCommand(sqll, RentCon)
                dr = cmd.ExecuteReader
                While dr.Read
                    Dim query = "update StockMast set qty = '" & dr.Item("Qty") - gvRentals.Rows(k).Cells(2).Value & "' where itemname= '" & gvRentals.Rows(k).Cells(0).Value & "'"
                    cmd = New SqlCommand(query, RentCon)
                    cmd.ExecuteNonQuery()
                End While
            Next
            If RentCon.State = ConnectionState.Closed Then
                RentCon.Open()
            End If
            cmd = New SqlCommand("Select customerbalance from customers where name='" + cbCustname.Text + "'", RentCon)
            dr = cmd.ExecuteReader
            While dr.Read
                cmd = New SqlCommand("update customers set customerbalance = '" & dr.Item("customerbalance") + Val(lblTotal.Text) + Val(txtdelcost.Text) - Val(txtCashPaid.Text) & "' where name= '" & cbCustname.Text & "'", RentCon)
                cmd.ExecuteNonQuery()
            End While
            RentCon.Close()
            Clear()
            gvRentals.Rows.Clear()
            Display()
            BunifuSnackbar1.Show(Me.FindForm, "Success")
            Rentalinvoice()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Rentalinvoice()
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

        Dim report As New rptRentedInvoice
        report.SetDataSource(dt)

        If ckPrint.Checked = True Then
            report.PrintToPrinter(1, True, 0, 0)
        End If
        If ckPreview.Checked = True Then
            Reports.CrystalReportViewer1.ReportSource = report
            Reports.Hide()
            Reports.Show()
            Reports.CrystalReportViewer1.Refresh()
        End If

    End Sub
    Sub Invoiceno()
        If RentCon.State = ConnectionState.Closed Then
            RentCon.Open()
        End If
        cmd = New SqlCommand("select invoiceno from rentalconfig", RentCon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        If tbl.Rows.Count = 0 Then
            lblinvoice.Text = 1
        Else
            Dim index = tbl.Rows.Count() - 1
            lblinvoice.Text = tbl.Rows(index)(0).ToString
        End If
        RentCon.Close()
    End Sub
    Public Sub Clear()
        For Each control As Control In Me.GroupBox1.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
            If TypeOf control Is ComboBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Private Sub cbCustname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustname.SelectedIndexChanged
        If RentCon.State = ConnectionState.Closed Then
            RentCon.Open()
        End If
        cmd = New SqlCommand("select * from Customers where name='" + cbCustname.Text + "'", RentCon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        If tbl.Rows.Count = 0 Then
            lblinvoice.Text = 1
        Else

            txtContact.Text = tbl.Rows(0)(2).ToString
            txtLocation.Text = tbl.Rows(0)(3).ToString
        End If
        RentCon.Close()
    End Sub

    Private Sub lblItemName_Click(sender As Object, e As EventArgs) Handles lblItemName.Click
        'MsgBox(DateTimePicker1.Value)
        'Dim outto As DateTime
        'DateTime.TryParseExact(BunifuDatePicker1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, outto)
        'MsgBox(BunifuDatePicker1.Text)
        'If RentCon.State = ConnectionState.Closed Then
        '    RentCon.Open()
        'End If
        'cmd = New SqlCommand("select * from RentalTranx where CONVERT(VARCHAR(10), rentedstamp, 103) ='" + DateTimePicker1.Value + "'", RentCon)
        'da = New SqlDataAdapter(cmd)
        'tbl = New DataTable
        'da.Fill(tbl)
        'BunifuDataGridView1.DataSource = tbl
        'If tbl.Rows.Count = 0 Then
        '    MsgBox("Yawa")
        'Else
        'End If
        'RentCon.Close()

        'lblItemName.Text = DateTime.Now

        'Dim myDateTime As Date = Date.Parse(lblItemName.Text)
        'Dim MyDate As Date = myDateTime.Date()

        'MsgBox(MyDate)
        'DateTime.Parse(lblItemName.Text)
        'MsgBox(DateTime.Parse(DateTime.Now))
    End Sub

    Private Sub Rental_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Display()
        Invoiceno()
    End Sub


End Class
