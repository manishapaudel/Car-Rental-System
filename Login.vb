Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Security.Policy

Public Class Login

    Dim connection As New SqlConnection("Server=LAPTOP-D08B083K\SQLEXPRESS; Database=CRMS; Integrated Security=true")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cmd As SqlCommand = New SqlCommand("select *from login where username='" + Username.Text + "'and password='" + Password.Text + "'", connection)
        Dim sda As sqldataadapter = New sqldataadapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        connection.Open()
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("login sucess", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim fdash As New Dashboard()
            Dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fcreate As New SignUp()
        SignUp.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class



