Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection
Imports DBConnect
Public Class frmUpdate
    Dim con As SqlConnection = DBConnect.GetConnection()
    Dim myDA As SqlDataAdapter
    Dim empTable As New DataTable
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        Dim con As SqlConnection = DBConnect.GetConnection()
        Dim emp_id As String = txtEmp.Text
        Dim fname As String = txtFname.Text
        Dim lname As String = txtLname.Text
        Dim gender As String
        Dim dept As String = txtDept.Text
        Dim salary As String = (txtSal.Text)
        Dim empInt As Integer
        Dim salaryInt As Integer
        If String.IsNullOrEmpty(txtEmp.Text) Or String.IsNullOrEmpty(txtFname.Text) Or String.IsNullOrEmpty(txtLname.Text) Or String.IsNullOrEmpty(txtDept.Text) Or String.IsNullOrEmpty(txtSal.Text) Then
            MsgBox("Please insert all the values")
        End If
        If Not (Integer.TryParse(emp_id, empInt)) Then
            MsgBox("Please enter valid Employee ID")
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


        Dim cmd As New SqlCommand("GOKRISH.TASK_EMPLOYEE_UPDATE", con)
        If con.State = ConnectionState.Closed Then con.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@emp_id ", emp_id)
        cmd.Parameters.AddWithValue("@first_name ", fname)
        cmd.Parameters.AddWithValue("@last_name ", lname)
        cmd.Parameters.AddWithValue("@gender ", gender)
        cmd.Parameters.AddWithValue("@department ", dept)
        cmd.Parameters.AddWithValue("@salary ", salary)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i = 1) Then
            MsgBox("update Successful!!")
            Me.Close()
        End If
    End Sub
End Class