Public Class Customer
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Insert("insert into Customers(name,contact,location,CustomerId,CustomerBalance) values('" + txtCustName.Text + "','" + txtContact.Text + "','" + txtLocation.Text + "','" + txtCustomerID.Text + "','" + txtBal.Text + "')")
        Clear()
        Display()
        BunifuSnackbar1.Show(Me.FindForm, "sucess")
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

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        BunifuSnackbar1.Show(Me.FindForm, "sucess")
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        BunifuSnackbar1.Show(Me.FindForm, "sucess")
    End Sub
End Class
