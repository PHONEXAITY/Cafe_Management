Option Explicit On
Option Strict On
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Drawing2D
Public Class SignUp
    Dim Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")
    Dim com As SqlCommand


    Dim tr As SqlTransaction

    Dim sb As StringBuilder
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
    End Sub

    Private Sub show_hide_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub unmaskps()
        txt_Pw.PasswordChar = CChar("*")
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        unmaskps()
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            show_img.Image = Image.FromFile(pop.FileName)


        End If
    End Sub

    Private Sub save()
        Try
            Conn.Open()
            Dim com As New SqlCommand("INSERT INTO SignUp_db (f_name, l_name, username, password, dob, role, status, pic) values (@f_name, @l_name, @username, @password, @dob, @role, @status, @pic)", Conn)
            Dim i As New Integer

            With com

                .CommandType = CommandType.Text
                .Connection = Conn
                .Transaction = tr
                .Parameters.Clear()
                .Parameters.AddWithValue("@f_name", txt_Name.Text.Trim())
                .Parameters.AddWithValue("@l_name", txt_Lname.Text.Trim())
                .Parameters.AddWithValue("@username", txt_Username.Text.Trim())
                .Parameters.AddWithValue("@password", txt_Pw.Text.Trim())
                .Parameters.AddWithValue("@dob", dob_picker.Value)
                .Parameters.AddWithValue("@role", Combo_Role.SelectedItem.ToString().Trim())
                .Parameters.AddWithValue("@status", CBool(cb_status.Checked.ToString))

                Dim filesize As UInt64
                Dim mstream As New System.IO.MemoryStream
                show_img.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                filesize = CULng(mstream.Length)
                mstream.Close()

                .Parameters.AddWithValue("@pic", picture)
                i = .ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("ລົງທະບຽນສຳເລັດແລ້ວ !", "ລົງທະບຽນ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("ລົງທະບຽນຜິດພາດ !", "ລົງທະບຽນ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                txt_Name.Clear()
                txt_Lname.Clear()
                txt_Username.Clear()
                txt_Pw.Clear()
                Combo_Role.Text = ""
                show_img.Image = Nothing
                cb_status.Checked = False

                Me.Dispose()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Conn.Close()
        SignIn.Usercomboload()
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        save()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles show_hide.CheckedChanged
        If show_hide.Checked Then
            txt_Pw.PasswordChar = Chr(0)
        Else
            txt_Pw.PasswordChar = CChar("*")
        End If
    End Sub
End Class