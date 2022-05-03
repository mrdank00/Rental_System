
Public Class Rental
    Private Sub BunifuButton21_Click(sender As Object, e As EventArgs) Handles BunifuButton21.Click
        For Each row As DataGridViewRow In BunifuDataGridView1.Rows
            'If row.Cells(0).checked = True Then
            'End If
            Dim chkboxcol As New DataGridViewColumn
            Dim checkrow As Boolean = Convert.ToBoolean(row.Cells(4).Value)
            If checkrow Then
                Insert("update rentaltranx set deliverystatus='" & True & "' where invoiceno='" & row.Cells(0).Value & "'")
            End If
        Next
        display()
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
        Display
    End Sub
    Sub display()
        Reload("select distinct invoiceno,customername,total,deliverydate,deliverystatus  from rentaltranx where deliverystatus='" & False & "'and deliverydate= convert(date,'" + DateTime.Now + "',105)", BunifuDataGridView1)

    End Sub

    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        display()
    End Sub

    Private Sub NewRent1_Load(sender As Object, e As EventArgs) Handles NewRent1.Load

    End Sub
End Class
