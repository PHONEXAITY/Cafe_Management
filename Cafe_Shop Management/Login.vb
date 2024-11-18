Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SignIn.TopLevel = False
        Panel1.Controls.Add(SignIn)
        SignIn.BringToFront()
        SignIn.Show()


    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        SignUp.TopLevel = False
        Panel1.Controls.Add(SignUp)
        SignUp.BringToFront()
        SignUp.Show()
    End Sub

    Private Sub admin_log_Click(sender As Object, e As EventArgs) Handles admin_log.Click
        Admin_Login.TopLevel = False
        Panel1.Controls.Add(Admin_Login)
        Admin_Login.BringToFront()
        Admin_Login.Show()


    End Sub
End Class
