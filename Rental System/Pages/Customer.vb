Public Class Customer
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Insert("insert into Customers(name,contact,location,CustomerId,CustomerBalance) values('" + txtCustName.Text + "','" + txtContact.Text + "','" + txtLocation.Text + "','" + txtCustomerID.Text + "','" + txtBal.Text + "')")
        Clear()
        Display()
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
End Class
