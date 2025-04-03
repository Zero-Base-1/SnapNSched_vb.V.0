Imports System.Data.SqlClient

' Database connection variables

Public Class EmployeeForm

    Private connectionString As String = "Data Source=HANIE\MSSQLSERVER01;Initial Catalog=TESTRUNDB;Integrated Security=True"
    Private connection As SqlConnection
    Private dataAdapter As SqlDataAdapter
    Private employeesTable As New DataTable()


    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize UI elements
        InitializeUI()

        ' Set up database connection
        SetupConnection()

        ' Load data from database
        LoadEmployeeData()

        ' Setup context menu
        SetupContextMenu()
    End Sub

    Private Sub InitializeUI()
        ' Set up role filter combo box
        cboRoleFilter.Items.Add("All Roles")
        cboRoleFilter.Items.Add("Barber")
        cboRoleFilter.Items.Add("Senior Barber")
        cboRoleFilter.Items.Add("Junior Barber")
        cboRoleFilter.Items.Add("Cashier")
        cboRoleFilter.Items.Add("Manager")
        cboRoleFilter.SelectedIndex = 0

        ' Set up status filter combo box
        cboStatusFilter.Items.Add("All Status")
        cboStatusFilter.Items.Add("Active")
        cboStatusFilter.Items.Add("Inactive")
        cboStatusFilter.Items.Add("In Training")
        cboStatusFilter.SelectedIndex = 0

        ' Set up search text box placeholder
        txtSearch.Text = "Search employees..."
        txtSearch.ForeColor = Color.Gray

        ' Format DataGridView
        FormatDataGridView()
    End Sub

    Private Sub SetupConnection()
        Try
            ' Create new database connection
            connection = New SqlConnection(connectionString)

        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadEmployeeData()
        Try
            ' Define the SQL query
            Dim query As String = "SELECT EmployeeID, Name, Role, ContactInfo, Status FROM Employees"

            ' Create command and data adapter
            Dim command As New SqlCommand(query, connection)
            dataAdapter = New SqlDataAdapter(command)

            ' Clear existing data and fill with new data
            employeesTable.Clear()
            dataAdapter.Fill(employeesTable)

            ' Set DataGridView data source
            dgvEmployees.DataSource = employeesTable

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub FormatDataGridView()
        ' Make sure we have columns before trying to format them
        If dgvEmployees.Columns.Count = 0 Then Return

        ' Rename columns for display (optional)
        dgvEmployees.Columns("EmployeeID").HeaderText = "Employee ID"
        dgvEmployees.Columns("Name").HeaderText = "Full Name"
        dgvEmployees.Columns("ContactInfo").HeaderText = "Contact Information"

        ' Set column widths
        dgvEmployees.Columns("EmployeeID").Width = 100
        dgvEmployees.Columns("Name").Width = 150
        dgvEmployees.Columns("Role").Width = 120
        dgvEmployees.Columns("ContactInfo").Width = 200
        dgvEmployees.Columns("Status").Width = 100

        ' Set other properties
        dgvEmployees.AllowUserToAddRows = False
        dgvEmployees.AllowUserToDeleteRows = False
        dgvEmployees.ReadOnly = True  ' Set to False if you want inline editing
        dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployees.MultiSelect = False

        ' Make it pretty
        dgvEmployees.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
        dgvEmployees.EnableHeadersVisualStyles = False
        dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue
        dgvEmployees.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvEmployees.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        ' Add column formatting event handler
        AddHandler dgvEmployees.CellFormatting, AddressOf DgvEmployees_CellFormatting
    End Sub

    Private Sub DgvEmployees_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        ' Check if this is the Status column
        If dgvEmployees.Columns(e.ColumnIndex).Name = "Status" AndAlso e.Value IsNot Nothing Then
            Dim status As String = e.Value.ToString().ToLower()

            ' Set background color based on status
            Select Case status
                Case "active"
                    e.CellStyle.BackColor = Color.FromArgb(220, 255, 220)  ' Light green
                    e.CellStyle.ForeColor = Color.DarkGreen
                Case "inactive"
                    e.CellStyle.BackColor = Color.FromArgb(255, 220, 220)  ' Light red
                    e.CellStyle.ForeColor = Color.DarkRed
                Case "in training"
                    e.CellStyle.BackColor = Color.FromArgb(255, 252, 220)  ' Light yellow
                    e.CellStyle.ForeColor = Color.DarkOrange
            End Select
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Only filter if not showing placeholder text
        If txtSearch.ForeColor <> Color.Gray Then
            FilterEmployees()
        End If
    End Sub

    Private Sub cboRoleFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoleFilter.SelectedIndexChanged
        FilterEmployees()
    End Sub

    Private Sub cboStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusFilter.SelectedIndexChanged
        FilterEmployees()
    End Sub

    Private Sub FilterEmployees()
        Try
            ' Get filter values
            Dim searchTerm As String = If(txtSearch.ForeColor = Color.Gray, "", txtSearch.Text.ToLower())
            Dim roleFilter As String = cboRoleFilter.SelectedItem.ToString()
            Dim statusFilter As String = cboStatusFilter.SelectedItem.ToString()

            ' Create a DataView from the main table for filtering
            Dim dv As New DataView(employeesTable)

            ' Build the filter expression
            Dim filterExpression As String = ""

            ' Add search filter
            If Not String.IsNullOrEmpty(searchTerm) Then
                filterExpression = $"(Name LIKE '%{searchTerm}%' OR EmployeeID LIKE '%{searchTerm}%')"
            End If

            ' Add role filter
            If roleFilter <> "All Roles" Then
                If Not String.IsNullOrEmpty(filterExpression) Then
                    filterExpression &= " AND "
                End If
                filterExpression &= $"Role = '{roleFilter}'"
            End If

            ' Add status filter
            If statusFilter <> "All Status" Then
                If Not String.IsNullOrEmpty(filterExpression) Then
                    filterExpression &= " AND "
                End If
                filterExpression &= $"Status = '{statusFilter}'"
            End If

            ' Apply the filter
            dv.RowFilter = filterExpression

            ' Update the DataGridView
            dgvEmployees.DataSource = dv

        Catch ex As Exception
            MessageBox.Show("Error filtering data: " & ex.Message, "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        ' Clear placeholder text when focused
        If txtSearch.Text = "Search employees..." AndAlso txtSearch.ForeColor = Color.Gray Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        ' Restore placeholder text if empty
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Search employees..."
            txtSearch.ForeColor = Color.Gray
            FilterEmployees()  ' Reset search filter
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Reload data from database
        LoadEmployeeData()

        ' Reset filters
        txtSearch.Text = "Search employees..."
        txtSearch.ForeColor = Color.Gray
        cboRoleFilter.SelectedIndex = 0
        cboStatusFilter.SelectedIndex = 0
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        ' Create and show the AddEmployeeForm
        Dim addForm As New AddEmployeeForm(employeesTable, dataAdapter)
        If addForm.ShowDialog() = DialogResult.OK Then
            ' Reload employee data if the employee was added successfully
            LoadEmployeeData()
        End If
    End Sub

    Private Sub AddNewEmployee(id As String, name As String, role As String, contact As String, status As String)
        Try
            ' Create command builder for updates
            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)

            ' Add new row to data table
            Dim newRow As DataRow = employeesTable.NewRow()
            newRow("EmployeeID") = id
            newRow("Name") = name
            newRow("Role") = role
            newRow("ContactInfo") = contact
            newRow("Status") = status
            employeesTable.Rows.Add(newRow)

            ' Update the database
            dataAdapter.Update(employeesTable)

            MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error adding employee: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetupContextMenu()
        ' Create context menu
        Dim contextMenu As New ContextMenuStrip()

        ' Add Delete menu item
        Dim deleteItem As New ToolStripMenuItem("Delete")
        AddHandler deleteItem.Click, AddressOf DeleteMenuItem_Click
        contextMenu.Items.Add(deleteItem)

        ' Assign context menu to DataGridView
        dgvEmployees.ContextMenuStrip = contextMenu
    End Sub

    Private Sub DeleteMenuItem_Click(sender As Object, e As EventArgs)
        ' Check if a row is selected
        If dgvEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an employee to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Return

        ' Get the selected employee ID
        Dim selectedRow As DataRowView = DirectCast(dgvEmployees.SelectedRows(0).DataBoundItem, DataRowView)
        Dim employeeID As String = selectedRow("EmployeeID").ToString()

        ' Delete the employee
        DeleteEmployee(employeeID)

        ' Reload the DataGridView after deletion
        LoadEmployeeData()
    End Sub

    Private Sub DeleteEmployee(employeeID As String)
        Try
            ' Create command builder
            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)

            ' Find the row to delete
            Dim rowToDelete As DataRow = Nothing
            For Each row As DataRow In employeesTable.Rows
                If row("EmployeeID").ToString() = employeeID Then
                    rowToDelete = row
                    Exit For
                End If
            Next

            ' Delete the row if found
            If rowToDelete IsNot Nothing Then
                rowToDelete.Delete()
                dataAdapter.Update(employeesTable)
                MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting employee: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub EditMenuItem_Click(sender As Object, e As EventArgs)
        ' Check if a row is selected
        If dgvEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an employee to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected employee data
        Dim selectedRow As DataRowView = DirectCast(dgvEmployees.SelectedRows(0).DataBoundItem, DataRowView)
        Dim employeeID As String = selectedRow("EmployeeID").ToString()
        Dim name As String = selectedRow("Name").ToString()
        Dim role As String = selectedRow("Role").ToString()
        Dim contactInfo As String = selectedRow("ContactInfo").ToString()
        Dim status As String = selectedRow("Status").ToString()

        ' Open edit form (you would need to create this form)
        ' For example:
        ' Dim editForm As New EditEmployeeForm(employeeID, name, role, contactInfo, status)
        ' If editForm.ShowDialog() = DialogResult.OK Then
        '     LoadEmployeeData()  ' Refresh data after edit
        ' End If

        ' For this example, we'll just show a message
        MessageBox.Show("This would open a form to edit employee: " & name, "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Clean up database connection
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub


End Class

