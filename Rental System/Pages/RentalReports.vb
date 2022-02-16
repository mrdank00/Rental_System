Imports System.Data.SqlClient
Public Class RentalReports
    Dim dt As New dsRental
    Private Sub BunifuButton21_Click(sender As Object, e As EventArgs) Handles BunifuButton21.Click
        Dim sreport = cbReport.SelectedIndex
        Select Case sreport
            Case 0
                Dim query = "select * from Stockmast"
                cmd = New SqlCommand(query, RentCon)
                dt.Tables("Stockmast").Rows.Clear()
                da.SelectCommand = cmd
                da.Fill(dt, "stockmast")

                'Dim sql = "select * from ClientReg"
                'dt.Tables("ClientReg").Rows.Clear()
                'cmd = New SqlCommand(sql, FleetCon)
                'da.SelectCommand = cmd
                'da.Fill(dt, "ClientReg")

                Dim report As New rptItemPerCategory
                report.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = report
                CrystalReportViewer1.Refresh()
            Case 1
                Dim query = "select * from Customers"
                cmd = New SqlCommand(query, RentCon)
                dt.Tables("Customers").Rows.Clear()
                da.SelectCommand = cmd
                da.Fill(dt, "Customers")

                'Dim sql = "select * from ClientReg"
                'dt.Tables("ClientReg").Rows.Clear()
                'cmd = New SqlCommand(sql, FleetCon)
                'da.SelectCommand = cmd
                'da.Fill(dt, "ClientReg")

                Dim report As New rptCustomersInfo
                report.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = report
                CrystalReportViewer1.Refresh()

            Case 2
                Dim query = "select * from Rentaltranx"
                cmd = New SqlCommand(query, RentCon)
                dt.Tables("Rentaltranx").Rows.Clear()
                da.SelectCommand = cmd
                da.Fill(dt, "Rentaltranx")

                'Dim sql = "select * from ClientReg"
                'dt.Tables("ClientReg").Rows.Clear()
                'cmd = New SqlCommand(sql, FleetCon)
                'da.SelectCommand = cmd
                'da.Fill(dt, "ClientReg")

                Dim report As New rptRentalsperDate
                report.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = report
                CrystalReportViewer1.Refresh()
            Case Else
        End Select
    End Sub
End Class
