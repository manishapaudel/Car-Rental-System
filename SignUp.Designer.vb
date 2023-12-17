<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Panel1 = New Panel()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        Txtidno = New TextBox()
        Label1 = New Label()
        Create = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtaddress = New TextBox()
        Txtusername = New TextBox()
        Txtpassword = New TextBox()
        txtemail = New TextBox()
        Txtcontact = New TextBox()
        Label8 = New Label()
        txtDOB = New DateTimePicker()
        cmbgender = New ComboBox()
        Label10 = New Label()
        Cmbstate = New ComboBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(867, 69)
        Panel1.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(130, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(349, 46)
        Label9.TabIndex = 9
        Label9.Text = "Create New Account"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = My.Resources.Resources.register_filled_line_icon_vector
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(119, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Txtidno
        ' 
        Txtidno.AccessibleDescription = "txtID_No."
        Txtidno.Location = New Point(586, 103)
        Txtidno.Name = "Txtidno"
        Txtidno.Size = New Size(255, 31)
        Txtidno.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 25)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Create
        ' 
        Create.Location = New Point(388, 407)
        Create.Name = "Create"
        Create.Size = New Size(128, 46)
        Create.TabIndex = 3
        Create.Text = "Create"
        Create.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 25)
        Label2.TabIndex = 4
        Label2.Text = "Gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 25)
        Label3.TabIndex = 5
        Label3.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 282)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 25)
        Label4.TabIndex = 6
        Label4.Text = "D.O.B"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(16, 344)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 25)
        Label5.TabIndex = 7
        Label5.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(505, 103)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 25)
        Label6.TabIndex = 8
        Label6.Text = "ID No."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(505, 166)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 25)
        Label7.TabIndex = 9
        Label7.Text = "E-mail"
        ' 
        ' txtaddress
        ' 
        txtaddress.AccessibleName = "txtaddress"
        txtaddress.Location = New Point(130, 221)
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(272, 31)
        txtaddress.TabIndex = 11
        ' 
        ' Txtusername
        ' 
        Txtusername.AccessibleName = "txtusername"
        Txtusername.Location = New Point(130, 106)
        Txtusername.Name = "Txtusername"
        Txtusername.Size = New Size(272, 31)
        Txtusername.TabIndex = 13
        ' 
        ' Txtpassword
        ' 
        Txtpassword.AccessibleName = "txtpassword"
        Txtpassword.Location = New Point(130, 344)
        Txtpassword.Name = "Txtpassword"
        Txtpassword.Size = New Size(272, 31)
        Txtpassword.TabIndex = 15
        ' 
        ' txtemail
        ' 
        txtemail.AccessibleName = "txte-mail"
        txtemail.Location = New Point(586, 163)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(255, 31)
        txtemail.TabIndex = 16
        ' 
        ' Txtcontact
        ' 
        Txtcontact.AccessibleName = "txtcontact"
        Txtcontact.Location = New Point(586, 227)
        Txtcontact.Name = "Txtcontact"
        Txtcontact.Size = New Size(255, 31)
        Txtcontact.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(505, 233)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 25)
        Label8.TabIndex = 18
        Label8.Text = "Contact"
        ' 
        ' txtDOB
        ' 
        txtDOB.AccessibleName = "txtdob"
        txtDOB.Location = New Point(130, 282)
        txtDOB.Name = "txtDOB"
        txtDOB.Size = New Size(272, 31)
        txtDOB.TabIndex = 19
        ' 
        ' cmbgender
        ' 
        cmbgender.AccessibleName = "cmbgender"
        cmbgender.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female", "Others"})
        cmbgender.FormattingEnabled = True
        cmbgender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        cmbgender.Location = New Point(121, 166)
        cmbgender.Name = "cmbgender"
        cmbgender.Size = New Size(281, 33)
        cmbgender.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(505, 299)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 25)
        Label10.TabIndex = 21
        Label10.Text = "State"
        ' 
        ' Cmbstate
        ' 
        Cmbstate.AccessibleName = "cmbstate"
        Cmbstate.AutoCompleteCustomSource.AddRange(New String() {"Koshi", "Madhesh ", "Bagmati ", "Gandaki ", "Lumbini ", "Karnali ", "Sudur Pashchim "})
        Cmbstate.FormattingEnabled = True
        Cmbstate.Items.AddRange(New Object() {"Koshi", "Madhesh ", "Bagmati ", "Gandaki ", "Lumbini ", "Karnali ", "Sudur Pashchim "})
        Cmbstate.Location = New Point(586, 296)
        Cmbstate.Name = "Cmbstate"
        Cmbstate.Size = New Size(255, 33)
        Cmbstate.TabIndex = 22
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(867, 508)
        Controls.Add(Cmbstate)
        Controls.Add(Label10)
        Controls.Add(cmbgender)
        Controls.Add(txtDOB)
        Controls.Add(Label8)
        Controls.Add(Txtcontact)
        Controls.Add(txtemail)
        Controls.Add(Txtpassword)
        Controls.Add(Txtusername)
        Controls.Add(txtaddress)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Create)
        Controls.Add(Label1)
        Controls.Add(Txtidno)
        Controls.Add(Panel1)
        Name = "SignUp"
        Text = "SignUp"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txtidno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Create As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Txtcontact As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDOB As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Cmbstate As ComboBox
End Class
