Imports System.Globalization
Public Class RentDashboard
    Private Sub RentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DashboardValues("select count(distinct invoiceno) from Rentaltranx  where deliverystatus='" & True & "' and deliverydate=convert(date,'" + DateTime.Now + "',105)", Label1)
        DashboardValues("select count(distinct invoiceno) from Rentaltranx  where deliverystatus='" & False & "'and deliverydate= convert(date,'" + DateTime.Now + "',105)", Label4)
        DashboardValues("select count(distinct invoiceno) from Rentaltranx  where deliverystatus='" & False & "'", Label8)
        DashboardValues("select sum(amount) from Rentaltranx  where  deliverydate=convert(date,'" + DateTime.Now + "',105) ", Label6)
        'DashboardValues("select  distinct invoiceno ,sum(cashdeposited) from Rentaltranx  where  deliverydate=convert(date,'" + DateTime.Now + "',105) ", Label10)
        'Reload("select count(Deliverystatus) from Rentaltranx  where deliverystatus='" & True & "' and deliverydate=convert(date,'" + DateTime.Now + "',105)", DataGridView1)

        Dim dblValue As Double = Val(Label6.Text)
        Label6.Text = dblValue.ToString("N", CultureInfo.InvariantCulture)
    End Sub

    Private Sub BunifuShadowPanel1_Click(sender As Object, e As EventArgs) Handles BunifuShadowPanel1.Click
        DashboardValues("select count(distinct invoiceno) from Rentaltranx  where deliverystatus='" & True & "' and deliverydate=convert(date,'" + DateTime.Now + "',105)", Label1)
        DashboardValues("select count(distinct invoiceno) from Rentaltranx  where deliverystatus='" & False & "'and deliverydate= convert(date,'" + DateTime.Now + "',105)", Label4)
        DashboardValues("select count(distinct invoiceno) from Rentaltranx  where deliverystatus='" & False & "'", Label8)
        DashboardValues("select sum(amount) from Rentaltranx  where  deliverydate=convert(date,'" + DateTime.Now + "',105) ", Label6)
    End Sub

    Private Sub RentDashboard_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        DashboardValues("select count(distinct invoiceno) from Rentaltranx  where deliverystatus='" & True & "' and deliverydate=convert(date,'" + DateTime.Now + "',105)", Label1)
        DashboardValues("select count(distinct invoiceno) from Rentaltranx  where deliverystatus='" & False & "'and deliverydate= convert(date,'" + DateTime.Now + "',105)", Label4)
        DashboardValues("select count(distinct invoiceno) from Rentaltranx  where deliverystatus='" & False & "'", Label8)
        DashboardValues("select sum(amount) from Rentaltranx  where  deliverydate=convert(date,'" + DateTime.Now + "',105) ", Label6)
        Dim dblValue As Double = Val(Label6.Text)
        Label6.Text = dblValue.ToString("N", CultureInfo.InvariantCulture)
    End Sub

    Private Sub RentDashboard_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        DashboardValues("select count(distinct invoiceno) from Rentaltranx  where deliverystatus='" & True & "' and deliverydate=convert(date,'" + DateTime.Now + "',105)", Label1)
        DashboardValues("select count(distinct invoiceno) from Rentaltranx  where deliverystatus='" & False & "'and deliverydate= convert(date,'" + DateTime.Now + "',105)", Label4)
        DashboardValues("select count(distinct invoiceno) from Rentaltranx  where deliverystatus='" & False & "'", Label8)
        DashboardValues("select sum(amount) from Rentaltranx  where  deliverydate=convert(date,'" + DateTime.Now + "',105) ", Label6)
        'DashboardValues("select  distinct invoiceno ,sum(cashdeposited) from Rentaltranx  where  deliverydate=convert(date,'" + DateTime.Now + "',105) ", Label10)
        'Reload("select count(Deliverystatus) from Rentaltranx  where deliverystatus='" & True & "' and deliverydate=convert(date,'" + DateTime.Now + "',105)", DataGridView1)
        Dim dblValue As Double = Val(Label6.Text)
        Label6.Text = dblValue.ToString("N", CultureInfo.InvariantCulture)
        ' MsgBox("Hi")
    End Sub
End Class
