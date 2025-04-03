Imports System.Data.SqlClient

Public Class AddEmployeeForm

    Private connectionString As String = "Data Source=HANIE\MSSQLSERVER01;Initial Catalog=TESTRUNDB;Integrated Security=True"
    Private connection As SqlConnection
    Private dataAdapter As SqlDataAdapter
    Private employeesTable As DataTable

    Public Sub New(ByRef employeesTable As DataTable, ByRef dataAdapter As SqlDataAdapter)
        InitializeComponent()
        Me.employeesTable = employeesTable
        Me.dataAdapter = dataAdapter
    End Sub

    Private Sub AddEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate Role and Status comboboxes
        cboRole.Items.AddRange({"Barber", "Senior Barber", "Junior Barber", "Cashier", "Manager"})
        cboStatus.Items.AddRange({"Active", "Inactive", "In Training"})
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Get values from input fields
            Dim id As String = txtEmployeeID.Text
            Dim name As String = txtName.Text
            Dim role As String = cboRole.SelectedItem.ToString()
            Dim contact As String = txtContactInfo.Text
            Dim status As String = cboStatus.SelectedItem.ToString()

            ' Add new row to data table
            Dim newRow As DataRow = employeesTable.NewRow()
            newRow("EmployeeID") = id
            newRow("Name") = name
            newRow("Role") = role
            newRow("ContactInfo") = contact
            newRow("Status") = status
            employeesTable.Rows.Add(newRow)

            ' Update the database
            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)
            dataAdapter.Update(employeesTable)

            MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK ' Indicate success
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error adding employee: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel ' Indicate cancel
        Me.Close()
    End Sub
End Class