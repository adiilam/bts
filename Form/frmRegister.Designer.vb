<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        btnCancel = New Button()
        btnRegister = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txtEmail = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(290, 202)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(72, 33)
        btnCancel.TabIndex = 11
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(195, 202)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(72, 33)
        btnRegister.TabIndex = 10
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(239, 162)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(141, 23)
        txtPassword.TabIndex = 3
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(239, 126)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(141, 23)
        txtUsername.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(167, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 7
        Label2.Text = "Password :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(167, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 6
        Label1.Text = "Username :"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(239, 90)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(141, 23)
        txtEmail.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(185, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 12
        Label3.Text = "Email :"
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(574, 386)
        Controls.Add(txtEmail)
        Controls.Add(Label3)
        Controls.Add(btnCancel)
        Controls.Add(btnRegister)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmRegister"
        Text = "frmRegister"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
End Class
