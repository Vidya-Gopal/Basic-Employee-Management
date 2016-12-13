<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDel
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
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblDel = New System.Windows.Forms.Label()
        Me.txtDel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(87, 115)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(89, 39)
        Me.btnDel.TabIndex = 0
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(255, 115)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(91, 40)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblDel
        '
        Me.lblDel.AutoSize = True
        Me.lblDel.Location = New System.Drawing.Point(84, 52)
        Me.lblDel.Name = "lblDel"
        Me.lblDel.Size = New System.Drawing.Size(125, 17)
        Me.lblDel.TabIndex = 2
        Me.lblDel.Text = "Enter Employee ID"
        '
        'txtDel
        '
        Me.txtDel.Location = New System.Drawing.Point(246, 51)
        Me.txtDel.Name = "txtDel"
        Me.txtDel.Size = New System.Drawing.Size(100, 22)
        Me.txtDel.TabIndex = 3
        '
        'frmDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 223)
        Me.Controls.Add(Me.txtDel)
        Me.Controls.Add(Me.lblDel)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDel)
        Me.Name = "frmDel"
        Me.Text = "Delete Employee Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDel As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblDel As Label
    Friend WithEvents txtDel As TextBox
End Class
