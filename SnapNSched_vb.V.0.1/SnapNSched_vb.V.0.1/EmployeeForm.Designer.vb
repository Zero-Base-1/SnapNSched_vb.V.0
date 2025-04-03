<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeForm

    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboRoleFilter = New System.Windows.Forms.ComboBox()
        Me.cboStatusFilter = New System.Windows.Forms.ComboBox()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.btnCreateCashier = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmployees
        '
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(41, 175)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.Size = New System.Drawing.Size(665, 245)
        Me.dgvEmployees.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(70, 65)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(197, 20)
        Me.txtSearch.TabIndex = 1
        '
        'cboRoleFilter
        '
        Me.cboRoleFilter.FormattingEnabled = True
        Me.cboRoleFilter.Location = New System.Drawing.Point(290, 62)
        Me.cboRoleFilter.Name = "cboRoleFilter"
        Me.cboRoleFilter.Size = New System.Drawing.Size(121, 21)
        Me.cboRoleFilter.TabIndex = 2
        '
        'cboStatusFilter
        '
        Me.cboStatusFilter.FormattingEnabled = True
        Me.cboStatusFilter.Location = New System.Drawing.Point(438, 63)
        Me.cboStatusFilter.Name = "cboStatusFilter"
        Me.cboStatusFilter.Size = New System.Drawing.Size(121, 21)
        Me.cboStatusFilter.TabIndex = 3
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Location = New System.Drawing.Point(578, 62)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(111, 23)
        Me.btnAddEmployee.TabIndex = 4
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'btnCreateCashier
        '
        Me.btnCreateCashier.Location = New System.Drawing.Point(578, 91)
        Me.btnCreateCashier.Name = "btnCreateCashier"
        Me.btnCreateCashier.Size = New System.Drawing.Size(128, 23)
        Me.btnCreateCashier.TabIndex = 5
        Me.btnCreateCashier.Text = "Create Cashier Account"
        Me.btnCreateCashier.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(24, 24)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(79, 27)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnCreateCashier)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.cboStatusFilter)
        Me.Controls.Add(Me.cboRoleFilter)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cboRoleFilter As ComboBox
    Friend WithEvents cboStatusFilter As ComboBox
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnCreateCashier As Button
    Friend WithEvents btnRefresh As Button
End Class
