Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection
Imports DBConnect
Public Class frmDel

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub



    Private Sub btnDel_Click_1(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim con As SqlConnection = DBConnect.GetConnection()

        Dim emp_idInt As Integer
        Dim emp_id As String = (txtDel.Text)

        If Not (Integer.TryParse(emp_id, emp_idInt)) Then
            MsgBox("Please enter valid Employee ID")
        End If

        Dim cmd As New SqlCommand("GOKRISH.TASK_EMPLOYEE_DELETE", con)
        If con.State = ConnectionState.Closed Then con.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@emp_id ", emp_id)

        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i = 1) Then
            MsgBox("Delete Successful!!")
            Me.Close()
        End If
    End Sub

    Private Sub frmDel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class