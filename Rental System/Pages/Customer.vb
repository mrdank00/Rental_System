Public Class Customer
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)
        Insert("insert into Customers(name,contact,location,CustomerId,CustomerBalance) values('" + txtCustName.Text + "','" + txtContact.Text + "','" + txtLocation.Text + "','" + txtCustomerID.Text + "','" + txtBal.Text + "')")
        Clear()
        Display()
        BunifuSnackbar1.Show(Me.FindForm, "Success")
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
    Public Sub Display()
        Reload("select * from Customers", BunifuDataGridView1)
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        If lblId.Text = "-" Then
            MsgBox("Kindly select Customer to Edit")
            Exit Sub
        End If
        Insert("update customers set name='" + txtCustName.Text + "',contact='" + txtContact.Text + "',location='" + txtLocation.Text + "',Customerid='" + txtCustomerID.Text + "',Customerbalance='" + txtBal.Text + "' where id='" + lblId.Text + "'")
        Display()
        Clear()
        lblId.Text = "-"
        BunifuSnackbar1.Show(Me.FindForm, "Success")
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BunifuDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            Dim row As DataGridViewRow = BunifuDataGridView1.Rows(e.RowIndex)
            txtCustName.Text = row.Cells(1).Value.ToString()
            txtContact.Text = row.Cells(2).Value.ToString()
            txtLocation.Text = row.Cells(3).Value.ToString()
            txtCustomerID.Text = row.Cells(4).Value.ToString()
            txtBal.Text = row.Cells(5).Value.ToString()
            lblId.Text = row.Cells(0).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Customer_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Display()
    End Sub

    Private Sub BunifuThinButton23_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If lblId.Text = "-" Then
            MsgBox("Kindly select Customer to Edit")
            Exit Sub
        End If
        Insert("delete from customers where id='" + lblId.Text + "'")
        Display()
        Clear()
        lblId.Text = "-"
        BunifuSnackbar1.Show(Me.FindForm, "Success")
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If lblId.Text = "-" Then
            MsgBox("Kindly select Customer to Edit")
            Exit Sub
        End If
        Insert("update customers set name='" + txtCustName.Text + "',contact='" + txtContact.Text + "',location='" + txtLocation.Text + "',Customerid='" + txtCustomerID.Text + "',Customerbalance='" + txtBal.Text + "',customeremail='" + txtEmail.Text + "' where id='" + lblId.Text + "'")
        Display()
        Clear()
        lblId.Text = "-"
        BunifuSnackbar1.Show(Me.FindForm, "Success")
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        Display()
    End Sub

    Private Sub BunifuThinButton22_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Insert("insert into Customers(name,contact,location,CustomerId,CustomerBalance,CustomerEmail) values('" + txtCustName.Text + "','" + txtContact.Text + "','" + txtLocation.Text + "','" + txtCustomerID.Text + "','" + txtBal.Text + "','" + txtEmail.Text + "')")
        Clear()
        Display()
        BunifuSnackbar1.Show(Me.FindForm, "Success")
    End Sub

    Private Sub BunifuDataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellClick
        Try
            Dim row As DataGridViewRow = BunifuDataGridView1.Rows(e.RowIndex)
            txtCustName.Text = row.Cells(1).Value.ToString()
            txtContact.Text = row.Cells(2).Value.ToString()
            txtLocation.Text = row.Cells(3).Value.ToString()
            txtCustomerID.Text = row.Cells(4).Value.ToString()
            txtBal.Text = row.Cells(5).Value.ToString()
            lblId.Text = row.Cells(0).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub
End Class
