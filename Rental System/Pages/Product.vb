﻿
Imports System.Data.SqlClient
Public Class Product
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)


    End Sub
    Public Sub Clear()
        For Each control As Control In Me.TabPage1.Controls
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
        ComboFeed("select category from combofeed", cbCat, 0)
        ComboFeed("select size from combofeed", cbSize, 0)
        ComboFeed("select colour from combofeed", cbcolour, 0)
    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs)
        If lblId.Text = "-" Then
            MsgBox("Kindly select item to Delete")
            Exit Sub
        End If
        Insert("delete from Stockmast where itemid='" + lblId.Text + "' and qty=0")
        Display()
        Clear()
        lblId.Text = "-"
        BunifuSnackbar1.Show(Me.FindForm, "Success")
    End Sub

    Private Sub Product_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Display()
    End Sub

    Private Sub BunifuThinButton22_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        cmd = New SqlCommand("select itemname,category,colour,size from Stockmast where itemname='" + txtname.Text + "' and category='" + cbCat.Text + "'", RentCon)
        da = New SqlDataAdapter(cmd)
        tbl = New DataTable
        da.Fill(tbl)
        If tbl.Rows.Count <> 0 Then
            MsgBox("Item Name already Exits")
            Exit Sub
        End If
        Insert("insert into Stockmast(Itemname,price,Qty,category,colour,Size) values('" + txtname.Text + "','" + txtPrice.Text + "','" + txtqty.Text + "','" + cbCat.Text + "','" + cbcolour.Text + "','" + cbSize.Text + "')")
        If cbCat.SelectedIndex = -1 Then
            cmd = New SqlCommand("select category from combofeed where category='" + cbCat.Text + "'", RentCon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable
            da.Fill(tbl)
            If tbl.Rows.Count = 0 Then
                Insert("insert into combofeed(category) values('" + cbCat.Text + "')")
            End If

        End If
        If cbcolour.SelectedIndex = -1 Then
            cmd = New SqlCommand("select colour from combofeed where colour='" + cbcolour.Text + "'", RentCon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable
            da.Fill(tbl)
            If tbl.Rows.Count = 0 Then
                Insert("insert into combofeed(colour) values('" + cbcolour.Text + "')")
            End If

        End If
        If cbSize.SelectedIndex = -1 Then
            cmd = New SqlCommand("select size from combofeed where size='" + cbSize.Text + "'", RentCon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable
            da.Fill(tbl)
            If tbl.Rows.Count = 0 Then
                Insert("insert into combofeed(size) values('" + cbSize.Text + "')")
            End If

        End If

        Clear()
        Display()
        BunifuSnackbar1.Show(Me.FindForm, "Success")
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If lblId.Text = "-" Then
            MsgBox("Kindly select item to Update")
            Exit Sub
        End If
        Insert("update stockmast set itemname='" + txtname.Text + "', price='" + txtPrice.Text + "',qty='" + txtqty.Text + "',category='" + cbCat.Text + "',colour='" + cbcolour.Text + "',size='" + cbSize.Text + "' where itemid='" + lblId.Text + "'")
        Display()
        Clear()
        lblId.Text = "-"
        BunifuSnackbar1.Show(Me.FindForm, "Success")
    End Sub

    Private Sub BunifuThinButton23_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If lblId.Text = "-" Then
            MsgBox("Kindly select item to Delete")
            Exit Sub
        End If
        Insert("delete from Stockmast where itemid='" + lblId.Text + "' and qty=0")
        Display()
        Clear()
        lblId.Text = "-"
        BunifuSnackbar1.Show(Me.FindForm, "Success")
    End Sub

    Private Sub BunifuDataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellClick
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
End Class
