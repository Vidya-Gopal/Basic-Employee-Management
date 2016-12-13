<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetails
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dataDetails = New System.Windows.Forms.DataGridView()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dataDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dataDetails)
        Me.Panel1.Controls.Add(Me.lblEmp)
        Me.Panel1.Location = New System.Drawing.Point(236, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 497)
        Me.Panel1.TabIndex = 1
        '
        'dataDetails
        '
        Me.dataDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataDetails.Location = New System.Drawing.Point(0, 0)
        Me.dataDetails.Name = "dataDetails"
        Me.dataDetails.RowTemplate.Height = 24
        Me.dataDetails.Size = New System.Drawing.Size(704, 497)
        Me.dataDetails.TabIndex = 6
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Location = New System.Drawing.Point(257, 22)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(117, 17)
        Me.lblEmp.TabIndex = 5
        Me.lblEmp.Text = "Employee Details"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnUp)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnGet)
        Me.Panel2.Location = New System.Drawing.Point(3, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 497)
        Me.Panel2.TabIndex = 2
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(33, 341)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(135, 48)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(33, 253)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(135, 49)
        Me.btnUp.TabIndex = 2
        Me.btnUp.Text = "Update Details"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(33, 160)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 50)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add Details"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(33, 73)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(135, 49)
        Me.btnGet.TabIndex = 0
        Me.btnGet.Text = "Show Details"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'frmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 534)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDetails"
        Me.Text = "Employee Detail Management System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dataDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnGet As Button
    Friend WithEvents lblEmp As Label
    Friend WithEvents dataDetails As DataGridView
End Class
