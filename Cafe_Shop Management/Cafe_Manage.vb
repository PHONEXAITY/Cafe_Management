Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection.Metadata.Ecma335

Public Class Cafe_Manage
    Dim Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub Cafe_Manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            img_browse.Image = Image.FromFile(pop.FileName)
        End If
    End Sub
    Sub clear()
        cafe_code.Clear()
        cafe_name.Clear()
        price.Clear()
        Combo_Size.Text = ""
        check_av.Checked = False
        img_browse.Image = Nothing
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        SaveDataToDatabase()
    End Sub
    Sub SaveDataToDatabase()
        Try
            Conn.Open()
            Dim com As New SqlCommand("INSERT INTO cafe_manage (cafe_code,cafe_name,size,price,status,img) VALUES (@cafe_code,@cafe_name,@size,@price,@status,@img)", Conn)
            Dim i As New Integer
            With com
                .Parameters.Clear()
                .Parameters.AddWithValue("@cafe_code", cafe_code.Text)
                .Parameters.AddWithValue("@cafe_name", cafe_name.Text)
                .Parameters.AddWithValue("@size", Combo_Size.Text)
                .Parameters.AddWithValue("@price", price.Text)
                .Parameters.AddWithValue("@status", CBool(check_av.Checked.ToString))
                Dim FileSize As New UInt64
                Dim mstream As New System.IO.MemoryStream
                img_browse.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                FileSize = mstream.Length
                mstream.Close()
                .Parameters.AddWithValue("@img", picture)
                i = .ExecuteNonQuery
                If i > 0 Then
                    MsgBox("New Coffee Register Success !", vbInformation)
                Else
                    MsgBox("New Coffee Register Failed !", vbCritical)
                End If
            End With
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
        Manangements_main.Imageload()
        Cafe_ManageList.dgv_load()

    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        edit()
    End Sub

    Sub edit()
        Try
            Conn.Open()
            Dim com As New SqlCommand("UPDATE cafe_manage SET cafe_name=@cafe_name,size=@size,price=@price,status=@status,img=@img WHERE cafe_code=@cafe_code", Conn)
            Dim i As New Integer
            With com
                .Parameters.Clear()

                .Parameters.AddWithValue("@cafe_name", cafe_name.Text)
                .Parameters.AddWithValue("@size", Combo_Size.Text)
                .Parameters.AddWithValue("@price", price.Text)
                .Parameters.AddWithValue("@status", CBool(check_av.Checked.ToString))

                'image convert to binary format

                Dim FileSize As New UInt64
                Dim mstream As New System.IO.MemoryStream
                img_browse.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                FileSize = mstream.Length
                mstream.Close()
                .Parameters.AddWithValue("@img", picture)
                .Parameters.AddWithValue("@cafe_code", cafe_code.Text)
                i = .ExecuteNonQuery
                If i > 0 Then
                    MsgBox("New Coffee Update Success !", vbInformation)
                Else
                    MsgBox("New Coffee Update Failed !", vbCritical)
                End If
            End With
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
        Cafe_ManageList.dgv_load()
        Manangements_main.Imageload()
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        delete()
    End Sub
    Sub delete()
        If MsgBox("Are you Sure Delete This Record !", vbQuestion + vbYesNo) = vbYes Then
            Try
                Conn.Open()
                Dim com As New SqlCommand("DELETE FROM cafe_manage WHERE cafe_code=@cafe_code", Conn)
                Dim i As New Integer
                With com
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@cafe_code", cafe_code.Text)
                    i = .ExecuteNonQuery
                End With
                If i > 0 Then
                    MsgBox("Coffee Deleted Successfully !", vbInformation)
                Else
                    MsgBox("Coffee Deleted Failed !", vbCritical)
                End If

                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Conn.Close()
            Cafe_ManageList.dgv_load()
            Manangements_main.Imageload()
        End If
    End Sub

    Private Sub price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles price.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' Allows digits 0 to 9
            Case 46 ' Allows the decimal point (.)
            Case 8 ' Allows the Backspace key
            Case Else
                e.Handled = True ' Blocks any other key
        End Select
    End Sub
End Class