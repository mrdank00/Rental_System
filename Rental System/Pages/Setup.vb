Imports System.Data.SqlClient
Imports System.IO
Public Class Setup
    Private Sub BunifuButton21_Click(sender As Object, e As EventArgs) Handles BunifuButton21.Click
        Try
            If RentCon.State = ConnectionState.Closed Then
                RentCon.Open()
            End If

            Dim ms As New MemoryStream
            pbLogo.Image.Save(ms, pbLogo.Image.RawFormat)

            Dim query = "update ClientReg Set Companyname='" + txtName.Text + "',location= '" + txtAddress.Text + "',Termsandconditions='" + txttandC.Text + "',branch='" + txtBranch.Text + "',Contact='" + txtContact.Text + "',Description='" + txtBusDesc.Text + "',Website='" + txtWebsite.Text + "',Email='" + txtEmail.Text + "',logo=@img"
            cmd = New SqlCommand(query, RentCon)
            With cmd
                .Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
                .ExecuteNonQuery()
            End With
            MsgBox("Company details Successfully updated")
            RentCon.Close()
            search()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*GIF,*ICO)|*.jpg;*.png;*.gif*.ICO"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbLogo.Image = Image.FromFile(opf.FileName)
            txtimglnk.Text = opf.FileName.ToString()
        End If
    End Sub
    Public Sub search()
        Try
            'Dim arrimage As Byte
            If RentCon.State = ConnectionState.Closed Then
                RentCon.Open()
            End If
            Dim query = "select * from ClientReg"
            cmd = New SqlCommand(query, RentCon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            If tbl.Rows.Count() = 0 Then
            Else
                txtName.Text = tbl.Rows(0)(1).ToString()
                txtAddress.Text = tbl.Rows(0)(2).ToString()
                txtContact.Text = tbl.Rows(0)(3).ToString()
                txtBranch.Text = tbl.Rows(0)(4).ToString()
                txtEmail.Text = tbl.Rows(0)(5).ToString()
                txtWebsite.Text = tbl.Rows(0)(6).ToString()
                txtBusDesc.Text = tbl.Rows(0)(7).ToString()
                txttandC.Text = tbl.Rows(0)(8).ToString()

                'arrimage = table.Rows(0)(9).ToString
                'Dim mstream As New System.IO.MemoryStream(arrimage)
                'pblogo.Image = Image.FromStream(mstream)

            End If
            showimage()
            RentCon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Sub showimage()
        Dim quer = "select logo from clientreg"
        cmd = New SqlCommand(quer, RentCon)
        'dr = cmd.ExecuteReader
        'dr.Read()
        'Try


        '    If dr.HasRows Then
        '        Dim logo As Byte
        '        logo = dr("Companylogo")
        '        Dim ms As New MemoryStream(logo)
        '        pblogo.Image = Image.FromStream(ms)
        '        pblogo.SizeMode = PictureBoxSizeMode.StretchImage
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        da = New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds, "clientreg")
        If ds.Tables.Count = 0 Then
            Exit Sub
        End If
        Dim c As Integer = ds.Tables(0).Rows.Count
        If c > 0 Then
            Dim bytBLOBData() As Byte =
                ds.Tables(0).Rows(c - 1)("logo")
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            pbLogo.Image = Image.FromStream(stmBLOBData)

        End If
    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        search()
    End Sub
End Class
