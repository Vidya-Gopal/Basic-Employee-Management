Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Imports DBConnect
Public Class frmInsert


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim con As SqlConnection = DBConnect.GetConnection()

        Dim fname As String = txtFname.Text
        Dim lname As String = txtLname.Text
        Dim gender As String
        Dim dept As String = txtDept.Text
        Dim salary As String = (txtSalary.Text)

        Dim salaryInt As Integer
        If String.IsNullOrEmpty(txtFname.Text) Or String.IsNullOrEmpty(txtLname.Text) Or String.IsNullOrEmpty(txtDept.Text) Or String.IsNullOrEmpty(txtSalary.Text) Then
            MsgBox("Please insert all the values")
        End If

        If Not (Integer.TryParse(salary, salaryInt)) Then
            MsgBox("Please enter valid Salary")
        End If

        If rdbMale.Checked Then
            gender = "Male"
        ElseIf rdbFemale.Checked Then
            gender = "Female"
        Else
            MsgBox("Please Select a Gender")
        End If


        Dim cmd As New SqlCommand("GOKRISH.TASK_EMPLOYEE_ADD", con)
        If con.State = ConnectionState.Closed Then con.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@first_name ", fname)
        cmd.Parameters.AddWithValue("@last_name ", lname)
        cmd.Parameters.AddWithValue("@gender ", gender)
        cmd.Parameters.AddWithValue("@department ", dept)
        cmd.Parameters.AddWithValue("@salary ", salary)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i = 1) Then
            MsgBox("Insert Successful!!")
            Me.Close()
        End If
    End Sub
End Class