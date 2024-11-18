Imports System.Data.SqlClient
Imports System.Text

Public Class Admin_Login
    Dim Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")

    Private Sub Check_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Check_showpass.CheckedChanged
        txt_password.UseSystemPasswordChar = Not Check_showpass.Checked
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            If AuthenticateUser(txt_Username.Text.Trim(), txt_password.Text.Trim()) Then


                Dim mainmangeForm As New Manangements_main()
                mainmangeForm.Show()

                Me.Close()
                SignIn.Close()

                Login.Hide()

            Else
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Using Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")
            Conn.Open()

            Using com As SqlCommand = New SqlCommand("SELECT * FROM SignUp_db WHERE username=@username AND password=@password", Conn)
                com.Parameters.AddWithValue("@username", username)
                com.Parameters.AddWithValue("@password", password)

                Using dr As SqlDataReader = com.ExecuteReader()
                    Return dr.Read()
                End Using
            End Using



            Conn.Close()
        End Using


    End Function
End Class
