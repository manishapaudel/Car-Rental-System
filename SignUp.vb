
Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class SignUp
    Dim connection As New SqlConnection("Server=LAPTOP-D08B083K\SQLEXPRESS; Database=CRMS; Integrated Security=true")

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[Registercreate]
           ([username]
           ,[gender]
           ,[address]
           ,[D.O.B]
           ,[password]
            ,[ID NO.]
           ,[E-mail]
           ,[contact]
            ,[state]
            ',[registerID])
     VALUES
           ('" + Txtusername.Text + "','" + cmbgender.SelectedItem.ToString() + "','" + txtaddress.Text + "','" + txtDOB.Text + "','" + Txtpassword.Text + "','" + Txtidno.Text + "','" + txtemail.Text + "','" + Txtcontact.Text + "','" + Cmbstate.SelectedItem.ToString() + "')", connection)
        connection.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("you have registered sucessfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()

    End Sub
End Class