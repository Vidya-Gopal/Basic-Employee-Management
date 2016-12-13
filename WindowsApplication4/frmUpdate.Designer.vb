<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Dim lblFname As System.Windows.Forms.Label
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblGen = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.lblSal = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.txtSal = New System.Windows.Forms.TextBox()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.txtEmp = New System.Windows.Forms.TextBox()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        lblFname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(71, 284)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(109, 49)
        Me.btnUp.TabIndex = 0
        Me.btnUp.Text = "Update"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(266, 282)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 51)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblFname
        '
        lblFname.AutoSize = True
        lblFname.Location = New System.Drawing.Point(68, 60)
        lblFname.Name = "lblFname"
        lblFname.Size = New System.Drawing.Size(76, 17)
        lblFname.TabIndex = 2
        lblFname.Text = "First Name"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(68, 99)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(76, 17)
        Me.lblLname.TabIndex = 3
        Me.lblLname.Text = "Last Name"
        '
        'lblGen
        '
        Me.lblGen.AutoSize = True
        Me.lblGen.Location = New System.Drawing.Point(68, 137)
        Me.lblGen.Name = "lblGen"
        Me.lblGen.Size = New System.Drawing.Size(56, 17)
        Me.lblGen.TabIndex = 4
        Me.lblGen.Text = "Gender"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Location = New System.Drawing.Point(68, 179)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(82, 17)
        Me.lblDept.TabIndex = 5
        Me.lblDept.Text = "Department"
        '
        'lblSal
        '
        Me.lblSal.AutoSize = True
        Me.lblSal.Location = New System.Drawing.Point(68, 218)
        Me.lblSal.Name = "lblSal"
        Me.lblSal.Size = New System.Drawing.Size(48, 17)
        Me.lblSal.TabIndex = 6
        Me.lblSal.Text = "Salary"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(255, 60)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(146, 22)
        Me.txtFname.TabIndex = 7
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(255, 99)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(146, 22)
        Me.txtLname.TabIndex = 8
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(255, 177)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(146, 22)
        Me.txtDept.TabIndex = 10
        '
        'txtSal
        '
        Me.txtSal.Location = New System.Drawing.Point(255, 218)
        Me.txtSal.Name = "txtSal"
        Me.txtSal.Size = New System.Drawing.Size(146, 22)
        Me.txtSal.TabIndex = 11
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Location = New System.Drawing.Point(68, 25)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(87, 17)
        Me.lblEmp.TabIndex = 12
        Me.lblEmp.Text = "Employee ID"
        '
        'txtEmp
        '
        Me.txtEmp.Location = New System.Drawing.Point(255, 22)
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.Size = New System.Drawing.Size(146, 22)
        Me.txtEmp.TabIndex = 13
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Location = New System.Drawing.Point(255, 137)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(59, 21)
        Me.rdbMale.TabIndex = 14
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Location = New System.Drawing.Point(322, 138)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(75, 21)
        Me.rdbFemale.TabIndex = 15
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 364)
        Me.Controls.Add(Me.rdbFemale)
        Me.Controls.Add(Me.rdbMale)
        Me.Controls.Add(Me.txtEmp)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.txtSal)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.lblSal)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.lblGen)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(lblFname)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUp)
        Me.Name = "frmUpdate"
        Me.Text = "Update Employee Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUp As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblLname As Label
    Friend WithEvents lblGen As Label
    Friend WithEvents lblDept As Label
    Friend WithEvents lblSal As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtDept As TextBox
    Friend WithEvents txtSal As TextBox
    Friend WithEvents lblEmp As Label
    Friend WithEvents txtEmp As TextBox
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents rdbFemale As RadioButton
End Class
