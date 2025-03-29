Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class Form1

    Private SelectedTable As String

    'To hide other buttons and textboxes if unnecessary
    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SgnIn_bttn.Visible = True
        CrtAcc_bttn.Visible = True
        Usr_lbl.Visible = False
        Usr_SN_txtbx.Visible = False
        Pswrd_lbl.Visible = False
        Pass_SN_txtbx.Visible = False
        LogIn_bttn.Visible = False
        Who_lbl.Visible = False
        Clt_bttn.Visible = False
        Csr_bttn.Visible = False
        Adm_bttn.Visible = False
        Csr_bttn.Visible = False
    End Sub

    'Proceeds to Who's gonna sign in
    Private Sub SgnIn_bttn_Click(sender As Object, e As EventArgs) Handles SgnIn_bttn.Click
        HideSgnCrtAccBttns()
        Who()
    End Sub

    'To hide both Sign In and Creat an Account options
    Public Sub HideSgnCrtAccBttns()
        SgnIn_bttn.Visible = False
        CrtAcc_bttn.Visible = False
    End Sub

    'Who's gonna sign in
    Public Sub Who()
        Who_lbl.Visible = True
        Clt_bttn.Visible = True
        Csr_bttn.Visible = True
        Adm_bttn.Visible = True
    End Sub

    'Hide Who
    Public Sub HideWho()
        Who_lbl.Visible = False
        Clt_bttn.Visible = False
        Csr_bttn.Visible = False
        Adm_bttn.Visible = False
    End Sub

    'To Show Sign In txt boxes and buttons
    Public Sub ShowSignInComponents()
        Usr_lbl.Visible = True
        Usr_SN_txtbx.Visible = True
        Pswrd_lbl.Visible = True
        Pass_SN_txtbx.Visible = True
        LogIn_bttn.Visible = True
    End Sub

    'Go to admin page
    Private Sub Adm_bttn_Click(sender As Object, e As EventArgs) Handles Adm_bttn.Click
        ShowSignInComponents()
        HideWho()
        SelectedTable = "adminAccount"
    End Sub

    'Go to client page
    Private Sub Client_bttn_Click(sender As Object, e As EventArgs) Handles Clt_bttn.Click
        ShowSignInComponents()
        HideWho()
        SelectedTable = "clientAccounts"
    End Sub

    'Go to cashier page
    Private Sub Cashier_bttn_Click(sender As Object, e As EventArgs) Handles Csr_bttn.Click
        ShowSignInComponents()
        HideWho()
        SelectedTable = "cashierAccounts"
    End Sub

    Private Sub LogIn_bttn_Click(sender As Object, e As EventArgs) Handles LogIn_bttn.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-5PTEBQH\SQLEXPRESS;Initial Catalog=Stephanie;Integrated Security=True;Encrypt=False")
        Dim query As String = $"SELECT COUNT(*) FROM {SelectedTable} WHERE username=@Username AND password=@Password"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@Username", Usr_SN_txtbx.Text)
        cmd.Parameters.AddWithValue("@Password", Pass_SN_txtbx.Text)
        con.Open()
        Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar)
        con.Close()
        If count > 0 Then
            If SelectedTable = "adminAccount" Then
                Admin_Formvb.Show()
            ElseIf SelectedTable = "clientAccounts" Then
                Client_Formvb.Show()
            ElseIf SelectedTable = "cashierAccounts" Then
                Cashier_Formvb.Show()
            End If
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

End Class
