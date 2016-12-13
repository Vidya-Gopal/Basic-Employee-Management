Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Imports DBConnect
Public Class frmDetails
    Dim con As SqlConnection = DBConnect.GetConnection()
    Dim myDA As SqlDataAdapter
    Dim empTable As New DataTable

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click



        ''----------EXECUTING STORED PROCEDURES------------
        dataDetails.DataSource = Nothing
        Dim cmd As New SqlCommand("GOKRISH.TASK_EMPLOYEE_GET", con)
        If con.State = ConnectionState.Closed Then con.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        myDA = New SqlDataAdapter(cmd)
        myDA.Update(empTable)

        myDA.Fill(empTable)
        dataDetails.DataSource = empTable.DefaultView







    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        My.Forms.frmInsert.Show()

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        My.Forms.frmDel.Show()

    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        My.Forms.frmUpdate.Show()
    End Sub
End Class
