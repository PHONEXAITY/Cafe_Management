
Imports System.Data.SqlClient
Imports System.Text

Public Class SignIn
    Dim Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")
    Dim com As SqlCommand


    Dim tr As SqlTransaction
    Dim dt As DataTable
    Dim da As SqlDataAdapter
    Dim sb As StringBuilder


    Private Sub unmaskps()
        txtpassword.PasswordChar = "*"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        unmaskps()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If remindme.Checked Then

            My.Settings.remindme = True
        Else
            My.Settings.remindMe = False
        End If

        My.Settings.Save()
        Try
            Conn.Open()
            Dim com As New SqlCommand("SELECT * FROM SignUp_db WHERE username=@username AND password=@password ", Conn)
            Dim dr As SqlDataReader
            With com
                .CommandType = CommandType.Text
                .Connection = Conn
                .Transaction = tr
                .Parameters.Clear()
                .Parameters.AddWithValue("@username", cm_username.Text.Trim())
                .Parameters.AddWithValue("@password", txtpassword.Text.Trim())

                Dim username As String = ""
                Dim password As String = ""
                dr = .ExecuteReader
                If (dr.Read() = True) Then
                    username = dr("username")
                    password = dr("password")
                    '  MessageBox.Show("OK !", "Operating Results", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    dr.Close()
                    Dim mainmangeForm As New Manangements_main()

                    mainmangeForm.Show()



                    Me.Close()
                    Login.Hide()





                Else
                    MessageBox.Show("Wrong Password !", "Operating Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Conn.Close()





    End Sub
    Sub LoginForm(sender As Object, e As FormClosedEventArgs)

        Login.Close()
    End Sub


    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remindme.Checked = My.Settings.remindme
        Usercomboload()

    End Sub
    Sub Usercomboload()
        Dim dr As SqlDataReader
        Conn.Open()
        cm_username.Items.Clear()
        Dim com As New SqlCommand("SELECT * FROM SignUp_db WHERE role <> 'Administrator'", Conn)
        dr = com.ExecuteReader
        While dr.Read
            cm_username.Items.Add(dr.GetString(3))
        End While
        dr.Close()
        Conn.Close()
    End Sub

    Private Sub cm_username_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cm_username.SelectedIndexChanged
        Dim picture() As Byte
        Showimg.Image = Nothing

        Try
            Conn.Open()
            Dim com As New SqlCommand("SELECT * FROM SignUp_db where username =@username", Conn)
            With com
                .CommandType = CommandType.Text
                .Connection = Conn
                .Transaction = tr
                .Parameters.Clear()
                .Parameters.AddWithValue("@username", cm_username.Text.Trim())
                da = New SqlDataAdapter
                dt = New DataTable
                da.selectcommand = com
                da.Fill(dt)

                ' convert img to byte
                picture = dt.Rows(0).Item("pic")
                Dim mstream As New System.IO.MemoryStream(picture)
                Showimg.Image = Image.FromStream(mstream)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtpassword.PasswordChar = Chr(0)
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub
End Class