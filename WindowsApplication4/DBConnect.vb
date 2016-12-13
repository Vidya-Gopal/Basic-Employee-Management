Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection


Public Class DBConnect

    Public Shared Function GetConnection() As SqlConnection
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-VTB5OF0\SQLEXPRESS;Initial Catalog=TASK;Integrated Security=True")
        Return con
    End Function

End Class
