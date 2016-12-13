<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsert
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(68, 44)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(76, 17)
        Me.lblFname.TabIndex = 0
        Me.lblFname.Text = "First Name"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(68, 108)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(76, 17)
        Me.lblLname.TabIndex = 1
        Me.lblLname.Text = "Last Name"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(68, 165)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(56, 17)
        Me.lblGender.TabIndex = 2
        Me.lblGender.Text = "Gender"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Location = New System.Drawing.Point(68, 215)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(82, 17)
        Me.lblDept.TabIndex = 3
        Me.lblDept.Text = "Department"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(68, 267)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(48, 17)
        Me.lblSalary.TabIndex = 4
        Me.lblSalary.Text = "Salary"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(222, 39)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(134, 22)
        Me.txtFname.TabIndex = 5
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(222, 108)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(134, 22)
        Me.txtLname.TabIndex = 6
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(222, 212)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(134, 22)
        Me.txtDept.TabIndex = 7
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(222, 262)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(134, 22)
        Me.txtSalary.TabIndex = 8
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Location = New System.Drawing.Point(222, 165)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(59, 21)
        Me.rdbMale.TabIndex = 9
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Location = New System.Drawing.Point(286, 165)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(75, 21)
        Me.rdbFemale.TabIndex = 10
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(158, 314)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(93, 40)
        Me.btnInsert.TabIndex = 11
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(297, 314)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 37)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 378)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.rdbFemale)
        Me.Controls.Add(Me.rdbMale)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblFname)
        Me.Name = "frmInsert"
        Me.Text = "Insert Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFname As Label
    Friend WithEvents lblLname As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblDept As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtDept As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnCancel As Button
End Class
