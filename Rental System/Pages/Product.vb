
Imports System.Data.SqlClient
Public Class Product
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click

        cmd = New SqlCommand("select itemname,category,colour,size from Stockmast where itemname='" + txtname.Text + "' and category='" + cbCat.Text + "'", RentCon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        If tbl.Rows.Count <> 0 Then
            MsgBox("Item Name already Exits")
            Exit Sub
        End If

        Insert("insert into Stockmast(Itemname,price,Qty,category,colour,Size) values('" + txtname.Text + "','" + txtPrice.Text + "','" + txtqty.Text + "','" + cbCat.Text + "','" + cbcolour.Text + "','" + cbSize.Text + "')")
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
        Reload("select * from stockMast", BunifuDataGridView1)
    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub
End Class
