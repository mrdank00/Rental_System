Imports System.Data.SqlClient
Public Class CustomerPayment
    Sub Display()
        ComboFeed("Select name from customers", cbCustname, 0)
    End Sub
    Public Sub Clear()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
            If TypeOf control Is ComboBox Then
                control.Text = ""
            End If
            lblBals.Text = 0
            lblnewbal.Text = 0
        Next
    End Sub
    Private Sub BunifuButton21_Click(sender As Object, e As EventArgs) Handles BunifuButton21.Click
        If cbCustname.SelectedIndex = -1 Then
            MsgBox("Select a customer to make payments to")
            Exit Sub
        End If
        If txtAmtpaid.Text = "" Then
            MsgBox("Enter Amount to pay")
            Exit Sub
        End If
        Insert("insert into customerpayments(customername,oldbalance,datepaid,amtpaid,newbal,narration,paymentmode,customerid) values('" & cbCustname.Text & "','" & lblBals.Text & "',convert(datetime,'" + DateTime.Now + "',105),'" & txtAmtpaid.Text & "','" & lblnewbal.Text & "','" & txtNarration.Text & "','" & cbPaymode.Text & "','" & Label1.Text & "')")
        Insert("update customers set customerbalance='" & lblnewbal.Text & "' where id='" + Label1.Text + "'")
        Clear()
        BunifuSnackbar1.Show(Me.FindForm, "Success")
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles cbCustname.Click
        Display()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustname.SelectedIndexChanged
        Try
            If RentCon.State = ConnectionState.Closed Then
                RentCon.Open()
            End If
            Dim query = "select customerbalance,id from customers where name like '%" + cbCustname.Text + "%'"
            cmd = New SqlCommand(query, RentCon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count() = 0 Then
            Else
                lblBals.Text = tbl.Rows(0)(0).ToString
                Label1.Text = tbl.Rows(0)(1).ToString()
            End If

            RentCon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtAmtpaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmtpaid.TextChanged
        lblnewbal.Text = Val(lblBals.Text) - Val(txtAmtpaid.Text)
    End Sub
End Class
