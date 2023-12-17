<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        PictureBox1 = New PictureBox()
        Username = New TextBox()
        Password = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = My.Resources.Resources.relax
        PictureBox1.Location = New Point(-3, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(441, 499)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Username
        ' 
        Username.AccessibleName = "txtusername"
        Username.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Username.Location = New Point(528, 175)
        Username.Name = "Username"
        Username.PlaceholderText = "Enter Username"
        Username.Size = New Size(263, 35)
        Username.TabIndex = 1
        ' 
        ' Password
        ' 
        Password.AccessibleName = "txtpassword"
        Password.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Password.Location = New Point(528, 239)
        Password.Name = "Password"
        Password.PasswordChar = "*"c
        Password.PlaceholderText = "Enter Password"
        Password.Size = New Size(263, 35)
        Password.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(566, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 27)
        Label1.TabIndex = 3
        Label1.Text = "Login your account"
        ' 
        ' Button1
        ' 
        Button1.AccessibleName = "btnSignIn"
        Button1.Location = New Point(597, 308)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 4
        Button1.Text = "SignIn"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.AccessibleName = "btnSignUp"
        Button2.Font = New Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(625, 423)
        Button2.Name = "Button2"
        Button2.Size = New Size(64, 32)
        Button2.TabIndex = 5
        Button2.Text = "SignUp"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(827, -2)
        Button3.Name = "Button3"
        Button3.Size = New Size(47, 34)
        Button3.TabIndex = 6
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(590, 401)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 19)
        Label2.TabIndex = 7
        Label2.Text = "Don't have an account?"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.Image = My.Resources.Resources.images
        PictureBox2.Location = New Point(499, 237)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(33, 37)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BorderStyle = BorderStyle.Fixed3D
        PictureBox3.Image = My.Resources.Resources.person_4
        PictureBox3.Location = New Point(499, 173)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(33, 37)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Login
        ' 
        AccessibleName = "frmlogin"
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(874, 485)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Password)
        Controls.Add(Username)
        Controls.Add(PictureBox1)
        Name = "Login"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
