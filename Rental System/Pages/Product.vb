
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
        Reload("select * from stockMast", BunifuDataGridView1)
    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If lblId.Text = "-" Then
            MsgBox("Kindly select item to Update")
            Exit Sub
        End If
        Insert("update stockmast set itemname='" + txtname.Text + "', price='" + txtPrice.Text + "',qty='" + txtqty.Text + "',category='" + cbCat.Text + "',colour='" + cbcolour.Text + "',size='" + cbSize.Text + "' where itemid='" + lblId.Text + "'")
        Display()
        Clear()
        lblId.Text = "-"
        BunifuSnackbar1.Show(Me.FindForm, "Sucess")
    End Sub

    Private Sub BunifuDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellClick
        Try
            Dim row As DataGridViewRow = BunifuDataGridView1.Rows(e.RowIndex)
            txtqty.Text = row.Cells(3).Value.ToString()
            txtPrice.Text = row.Cells(2).Value.ToString()
            txtname.Text = row.Cells(1).Value.ToString()
            cbSize.Text = row.Cells(6).Value.ToString()
            cbcolour.Text = row.Cells(5).Value.ToString()
            cbCat.Text = row.Cells(4).Value.ToString()
            lblId.Text = row.Cells(0).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If lblId.Text = "-" Then
            MsgBox("Kindly select item to Delete")
            Exit Sub
        End If
        Insert("delete from Stockmast where itemid='" + lblId.Text + "' and qty=0")
        Display()
        Clear()
        lblId.Text = "-"
        BunifuSnackbar1.Show(Me.FindForm, "Sucess")
    End Sub
End Class
