Imports System.Data.SqlClient
Imports System.IO
Public Class ManageUser_Cafe
    Dim Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")
    Dim dr As SqlDataReader
    Private Sub manageUser_Cafe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userdataloading()

        '  roleload()
    End Sub
    Sub clear()
        txt_firstname.Clear()
        txt_lastname.Clear()
        txt_password.Clear()
        txt_username.Clear()
        combo_role.Text = ""

    End Sub
    Sub userdataloading()
        DataGridView1.Rows.Clear()
        Try
            Conn.Open()
            Dim cmd As New SqlCommand("Select * from SignUp_db", Conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("Login_id").ToString, dr.Item("f_name").ToString, dr.Item("l_name").ToString, dr.Item("username").ToString, dr.Item("password").ToString, dr.Item("dob").ToString, dr.Item("role").ToString, dr.Item("status").ToString, dr.Item("pic"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()

    End Sub
    Sub roleload()
        Try
            Conn.Open()
            Dim cmd As New SqlCommand("SELECT DISTINCT  role FROM SignUp_db", Conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Clear existing items in the combo_role
            combo_role.Items.Clear()

            ' Add roles to the combo_role
            While reader.Read()
                combo_role.Items.Add(reader("role").ToString())
            End While
        Catch ex As Exception
            ' Handle exceptions (display or log error)
            MsgBox(ex.Message)
        Finally
            ' Close the connection
            Conn.Close()
        End Try
    End Sub


    Sub save()
        Try
            Conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO SignUp_db(f_name, l_name, username, password, role) VALUES (@f_name,@l_name,@username,@password,@role)", Conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@f_name", txt_firstname.Text)
            cmd.Parameters.AddWithValue("@l_name", txt_lastname.Text)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.Parameters.AddWithValue("@role", combo_role.Text)

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New User Register Success !", vbInformation)
            Else
                MsgBox("New User Register Failed !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
        userdataloading()
        clear()
    End Sub



    Private Sub btn_back_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub




    Private Sub btn_back_Click_1(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()

    End Sub





    Private Sub Check_showpass_Click_1(sender As Object, e As EventArgs) Handles Check_showpass.Click
        If Check_showpass.Checked = True Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True
        End If

    End Sub




    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Conn.Open()
        Try
            Dim cmd As New SqlCommand("UPDATE SignUp_db SET f_name=@f_name, l_name=@l_name, username=@username, password=@password, role=@role WHERE Login_id=@Login_id", Conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Login_id", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
            cmd.Parameters.AddWithValue("@f_name", txt_firstname.Text)
            cmd.Parameters.AddWithValue("@l_name", txt_lastname.Text)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.Parameters.AddWithValue("@role", combo_role.Text)

            ' Check if the pic_box.Image is not Nothing before attempting to save


            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Edit Successfully !", vbInformation)
            Else
                MsgBox("Failed !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
        userdataloading()
        clear()
    End Sub



    Private Sub DataGridView1_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp

        '   roleload()
        Me.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_firstname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_lastname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_username.Text = DataGridView1.CurrentRow.Cells(3).Value
        txt_password.Text = DataGridView1.CurrentRow.Cells(4).Value
        combo_role.Text = DataGridView1.CurrentRow.Cells(5).Value


        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "colDelete" Then
            Dim selectedUsername As String = DataGridView1.CurrentRow.Cells("Column3").Value.ToString

            If selectedUsername = Admin_Login.txt_Username.Text Then
                MsgBox("You cannot delete your own account!", vbExclamation)
                Return
            End If
            Conn.Open()

            If MsgBox("Are you Sure Delete This Record !", vbQuestion + vbYesNo) = vbYes Then
                Try
                    Dim cmd As New SqlCommand("delete from SignUp_db where Login_id=@Login_id", Conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Login_id", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
                    Dim i As Integer
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("User Delete Success !", vbInformation)
                    Else
                        MsgBox("Failed !", vbCritical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            Conn.Close()
            userdataloading()

            clear()
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        clear()

        Btn_Edit.Enabled = False

    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub


End Class