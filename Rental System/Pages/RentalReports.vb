Imports System.Data.SqlClient
Public Class RentalReports
    Dim dt As New dsRental
    Private Sub BunifuButton21_Click(sender As Object, e As EventArgs) Handles BunifuButton21.Click
        Try
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
                    Reports.CrystalReportViewer1.ReportSource = report
                    Reports.CrystalReportViewer1.Refresh()

                    With Reports
                        .TopLevel = False
                        Panel1.Controls.Add(Reports)
                        .BringToFront()
                        .Show()
                        .WindowState = FormWindowState.Maximized

                    End With

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
                    Reports.CrystalReportViewer1.ReportSource = report
                    Reports.CrystalReportViewer1.Refresh()
                    With Reports
                        .TopLevel = False
                        Panel1.Controls.Add(Reports)
                        .BringToFront()
                        .Show()
                        .WindowState = FormWindowState.Maximized

                    End With
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
                    Reports.CrystalReportViewer1.ReportSource = report
                    Reports.CrystalReportViewer1.Refresh()
                    With Reports
                        .TopLevel = False
                        Panel1.Controls.Add(Reports)
                        .BringToFront()
                        .Show()
                        .WindowState = FormWindowState.Maximized

                    End With
                Case Else
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RentalReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
