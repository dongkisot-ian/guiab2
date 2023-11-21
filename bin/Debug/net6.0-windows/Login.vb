Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlTypes

Public Class Login
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If (TxtUsername.Text = "") Then
            MsgBox("Enter the Username")
            TxtUsername.Focus()
            Exit Sub
        End If
        If (TxtPassword.Text = "") Then
            MsgBox("Enter the password")

            TxtPassword.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection("Data Source=LAPTOP-6SETF7QJ\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("select * from tbl_USERS where username= @username AND password= @password ", con)
            rdr = cmd.ExecuteReader()
            'If (rdr.Read()) Then
            'End If
            'If cmd.Parameters.Add("@username", SqlDbType.VarChar).Value Is cmd.Parameters.Add("@password", SqlDbType.VarChar) Then
            'DashboardCashier.Show()
            'Me.Hide()
            'End If

        Catch ex As Exception

        End Try
        If TxtUsername.Text = "admin" Then


        End If
    End Sub


    Private Sub BtnForgotPassword_Click(sender As Object, e As EventArgs) Handles BtnForgotPassword.Click

    End Sub

End Class