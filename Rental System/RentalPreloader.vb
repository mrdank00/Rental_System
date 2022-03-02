Public Class RentalPreloader

    Private Sub RentalPreloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ''Timer1.Enabled = True
        'BunifuCircleProgress2.Increment(1)
        'Dim per As String
        'per = Convert.ToString(BunifuCircleProgress2.Value)
        'BunifuCircleProgress2.Value = per

        'Try
        '    RentCon.Open()
        '    If RentCon.State = ConnectionState.Open Then
        '        RentCon.Close()

        '        If BunifuCircleProgress2.Value = 100 Then
        '            'Dim f2 As New Form1
        '            'f2.Show()
        '            'Me.Close()
        '            Timer1.Enabled = False
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
End Class