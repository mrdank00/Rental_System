Imports System.Data.SqlClient
Module RentalCON

    Public Function RentalConnetionSting() As SqlConnection
        Return New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=K:\Daakye\Rental System\Rental System\RentalDB.mdf;Integrated Security=True;MultipleActiveResultSets=true")
        'Data Source = (LocalDB) \ MSSQLLocalDB;AttachDbFilename="C:\Users\KISSI\OneDrive - University of Ghana\Documents\Rentals.mdf";User ID=dankissi;Password=***********;Connect Timeout=30

    End Function
    Public RentCon As SqlConnection = RentalConnetionSting()
End Module
