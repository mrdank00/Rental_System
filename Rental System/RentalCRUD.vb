﻿Imports System.Data.SqlClient
Imports System.Globalization
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Module RentalCRUD
    Public result As String
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public tbl As New DataTable
    Public ds As New DataSet
    Public dr As SqlDataReader



    Public Sub Insert(ByVal sql As String)
        Try
            If RentCon.State = ConnectionState.Closed Then
                RentCon.Open()
            End If
            'HOLDS THE DATA TO BE EXECUTED
            With cmd
                .Connection = RentCon
                .CommandText = sql
                'EXECUTE THE DATA
                result = cmd.ExecuteNonQuery
                'CHECKING IF THE DATA HAS EXECUTED OR NOT AND THEN THE POP UP MESSAGE WILL APPEAR
                If result = 0 Then
                    MessageBox.Show("Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
            RentCon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            RentCon.Close()
        End Try

    End Sub

    Public Sub Reload(ByVal sql As String, dgv As DataGridView)
        Try
            If RentCon.State = ConnectionState.Closed Then
                RentCon.Open()
            End If
            'HOLDS THE DATA TO BE EXECUTED
            With cmd
                .Connection = RentCon
                .CommandText = sql
                'EXECUTE THE DATA
                result = cmd.ExecuteNonQuery
                tbl = New DataTable
                da = New SqlDataAdapter(cmd)
                da.Fill(tbl)
                dgv.DataSource = tbl
            End With
            RentCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            RentCon.Close()
        End Try
    End Sub
    Public Sub ComboFeed(ByVal sql As String, combo As ComboBox, row As Integer)
        If RentCon.State = ConnectionState.Closed Then
            RentCon.Open()
        End If
        With cmd
            .Connection = RentCon
            .CommandText = sql
            dr = cmd.ExecuteReader
            combo.Items.Clear()
            While dr.Read
                combo.Items.Add(dr(row))
            End While

        End With
        RentCon.Close()
    End Sub

    Public Sub CheckBooking(ByVal sql As String)
        Try
            If RentCon.State = ConnectionState.Closed Then
                RentCon.Open()
            End If
            cmd = New SqlCommand(sql, RentCon)
            da = New SqlDataAdapter(cmd)
            tbl = New DataTable()
            da.Fill(tbl)
            For k = 0 To tbl.Rows.Count - 1
                If CDate(tbl.Rows(k)(1).ToString) <= DateTime.Now.ToShortDateString Then
                    Insert("update Drivers set Status = '" + "Available" + "' where DriverNO='" + tbl.Rows(k)(2).ToString + "'")
                    Insert("update Vehicle set Status = '" + "Available" + "' where VehicleID='" + tbl.Rows(k)(3).ToString + "'")
                    Dim out As DateTime
                    cmd = New SqlCommand("delete from Activetrips where arrivaldate <=@date", RentCon)
                    DateTime.TryParseExact(Date.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out)
                    cmd.Parameters.Add("date", sqlDbType:=SqlDbType.Date).Value = out
                    da.SelectCommand = cmd
                    da.Fill(tbl)

                End If
            Next

            RentCon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    'Public Sub Report(ByVal sql As String, ByVal sql2 As String, ByVal tbl As String, ByVal tbl2 As String, rpt As ReportClass, rptviewer As CrystalReportViewer)
    '    Try

    '        RentCon.Open()
    '        cmd = New SqlCommand(sql, RentCon)
    '        dt.Tables(tbl).Rows.Clear()
    '        da.SelectCommand = cmd
    '        da.Fill(dt, tbl)

    '        dt.Tables(tbl2).Rows.Clear()
    '        cmd = New SqlCommand(sql2, RentCon)
    '        da.SelectCommand = cmd
    '        da.Fill(dt, tbl2)

    '        'Dim report As New rptSalesPerDate
    '        rpt.SetDataSource(dt)
    '        rptviewer.ReportSource = rpt
    '        rptviewer.Refresh()
    '        cmd.Dispose()
    '        da.Dispose()
    '        RentCon.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try

End Module
