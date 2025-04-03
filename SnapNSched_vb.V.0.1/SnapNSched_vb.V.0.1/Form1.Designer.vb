<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.SgnIn_bttn = New System.Windows.Forms.Button()
        Me.CrtAcc_bttn = New System.Windows.Forms.Button()
        Me.Usr_lbl = New System.Windows.Forms.Label()
        Me.Pswrd_lbl = New System.Windows.Forms.Label()
        Me.Usr_SN_txtbx = New System.Windows.Forms.TextBox()
        Me.Pass_SN_txtbx = New System.Windows.Forms.TextBox()
        Me.LogIn_bttn = New System.Windows.Forms.Button()
        Me.Clt_bttn = New System.Windows.Forms.Button()
        Me.Csr_bttn = New System.Windows.Forms.Button()
        Me.Adm_bttn = New System.Windows.Forms.Button()
        Me.Who_lbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SgnIn_bttn
        '
        Me.SgnIn_bttn.Location = New System.Drawing.Point(429, 181)
        Me.SgnIn_bttn.Margin = New System.Windows.Forms.Padding(4)
        Me.SgnIn_bttn.Name = "SgnIn_bttn"
        Me.SgnIn_bttn.Size = New System.Drawing.Size(203, 62)
        Me.SgnIn_bttn.TabIndex = 0
        Me.SgnIn_bttn.Text = "Sign in"
        Me.SgnIn_bttn.UseVisualStyleBackColor = True
        '
        'CrtAcc_bttn
        '
        Me.CrtAcc_bttn.Location = New System.Drawing.Point(429, 250)
        Me.CrtAcc_bttn.Margin = New System.Windows.Forms.Padding(4)
        Me.CrtAcc_bttn.Name = "CrtAcc_bttn"
        Me.CrtAcc_bttn.Size = New System.Drawing.Size(203, 62)
        Me.CrtAcc_bttn.TabIndex = 1
        Me.CrtAcc_bttn.Text = "Create an account"
        Me.CrtAcc_bttn.UseVisualStyleBackColor = True
        '
        'Usr_lbl
        '
        Me.Usr_lbl.AutoSize = True
        Me.Usr_lbl.Location = New System.Drawing.Point(379, 185)
        Me.Usr_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Usr_lbl.Name = "Usr_lbl"
        Me.Usr_lbl.Size = New System.Drawing.Size(70, 16)
        Me.Usr_lbl.TabIndex = 2
        Me.Usr_lbl.Text = "username:"
        '
        'Pswrd_lbl
        '
        Me.Pswrd_lbl.AutoSize = True
        Me.Pswrd_lbl.Location = New System.Drawing.Point(379, 225)
        Me.Pswrd_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Pswrd_lbl.Name = "Pswrd_lbl"
        Me.Pswrd_lbl.Size = New System.Drawing.Size(69, 16)
        Me.Pswrd_lbl.TabIndex = 3
        Me.Pswrd_lbl.Text = "password:"
        '
        'Usr_SN_txtbx
        '
        Me.Usr_SN_txtbx.Location = New System.Drawing.Point(461, 181)
        Me.Usr_SN_txtbx.Margin = New System.Windows.Forms.Padding(4)
        Me.Usr_SN_txtbx.Name = "Usr_SN_txtbx"
        Me.Usr_SN_txtbx.Size = New System.Drawing.Size(213, 22)
        Me.Usr_SN_txtbx.TabIndex = 4
        '
        'Pass_SN_txtbx
        '
        Me.Pass_SN_txtbx.Location = New System.Drawing.Point(460, 222)
        Me.Pass_SN_txtbx.Margin = New System.Windows.Forms.Padding(4)
        Me.Pass_SN_txtbx.Name = "Pass_SN_txtbx"
        Me.Pass_SN_txtbx.Size = New System.Drawing.Size(213, 22)
        Me.Pass_SN_txtbx.TabIndex = 5
        '
        'LogIn_bttn
        '
        Me.LogIn_bttn.Location = New System.Drawing.Point(492, 257)
        Me.LogIn_bttn.Margin = New System.Windows.Forms.Padding(4)
        Me.LogIn_bttn.Name = "LogIn_bttn"
        Me.LogIn_bttn.Size = New System.Drawing.Size(151, 33)
        Me.LogIn_bttn.TabIndex = 6
        Me.LogIn_bttn.Text = "Sign in"
        Me.LogIn_bttn.UseVisualStyleBackColor = True
        '
        'Clt_bttn
        '
        Me.Clt_bttn.Location = New System.Drawing.Point(460, 181)
        Me.Clt_bttn.Margin = New System.Windows.Forms.Padding(4)
        Me.Clt_bttn.Name = "Clt_bttn"
        Me.Clt_bttn.Size = New System.Drawing.Size(151, 33)
        Me.Clt_bttn.TabIndex = 7
        Me.Clt_bttn.Text = "Client"
        Me.Clt_bttn.UseVisualStyleBackColor = True
        '
        'Csr_bttn
        '
        Me.Csr_bttn.Location = New System.Drawing.Point(460, 225)
        Me.Csr_bttn.Margin = New System.Windows.Forms.Padding(4)
        Me.Csr_bttn.Name = "Csr_bttn"
        Me.Csr_bttn.Size = New System.Drawing.Size(151, 33)
        Me.Csr_bttn.TabIndex = 8
        Me.Csr_bttn.Text = "Cashier"
        Me.Csr_bttn.UseVisualStyleBackColor = True
        '
        'Adm_bttn
        '
        Me.Adm_bttn.Location = New System.Drawing.Point(460, 266)
        Me.Adm_bttn.Margin = New System.Windows.Forms.Padding(4)
        Me.Adm_bttn.Name = "Adm_bttn"
        Me.Adm_bttn.Size = New System.Drawing.Size(151, 33)
        Me.Adm_bttn.TabIndex = 9
        Me.Adm_bttn.Text = "Admin"
        Me.Adm_bttn.UseVisualStyleBackColor = True
        '
        'Who_lbl
        '
        Me.Who_lbl.AutoSize = True
        Me.Who_lbl.Location = New System.Drawing.Point(500, 150)
        Me.Who_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Who_lbl.Name = "Who_lbl"
        Me.Who_lbl.Size = New System.Drawing.Size(66, 16)
        Me.Who_lbl.TabIndex = 10
        Me.Who_lbl.Text = "Sign In As"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(799, 469)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 33)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Admin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Who_lbl)
        Me.Controls.Add(Me.Adm_bttn)
        Me.Controls.Add(Me.Csr_bttn)
        Me.Controls.Add(Me.Clt_bttn)
        Me.Controls.Add(Me.LogIn_bttn)
        Me.Controls.Add(Me.Pass_SN_txtbx)
        Me.Controls.Add(Me.Usr_SN_txtbx)
        Me.Controls.Add(Me.Pswrd_lbl)
        Me.Controls.Add(Me.Usr_lbl)
        Me.Controls.Add(Me.CrtAcc_bttn)
        Me.Controls.Add(Me.SgnIn_bttn)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SgnIn_bttn As Button
    Friend WithEvents CrtAcc_bttn As Button
    Friend WithEvents Usr_lbl As Label
    Friend WithEvents Pswrd_lbl As Label
    Friend WithEvents Usr_SN_txtbx As TextBox
    Friend WithEvents Pass_SN_txtbx As TextBox
    Friend WithEvents LogIn_bttn As Button
    Friend WithEvents Clt_bttn As Button
    Friend WithEvents Csr_bttn As Button
    Friend WithEvents Adm_bttn As Button
    Friend WithEvents Who_lbl As Label
    Friend WithEvents Button1 As Button
End Class
