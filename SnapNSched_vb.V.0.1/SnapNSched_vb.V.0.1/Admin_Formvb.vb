Public Class Admin_Formvb
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EmployeeFormInstance As New EmployeeForm()

        ' Show Form2
        EmployeeFormInstance.Show()

        ' Close Form1
        Me.Close()
    End Sub
End Class