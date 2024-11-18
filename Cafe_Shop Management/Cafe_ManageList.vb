Imports System.IO
Imports System.Data.SqlClient


Public Class Cafe_ManageList
    Dim Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")
    Dim dr As SqlDataReader


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub



    Private Sub Cafe_ManageList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_load()
    End Sub


    Sub dgv_load()
        dgv_manage.Rows.Clear()

        Try
            Conn.Open()
            Dim query As String = "SELECT * FROM cafe_manage"
            Using com As New SqlCommand(query, Conn)
                Using dr As SqlDataReader = com.ExecuteReader
                    While dr.Read
                        dgv_manage.Rows.Add(
                        dr("cafe_code"),
                        dr("cafe_name"),
                        dr("size"),
                        dr("price"),
                        CBool(dr("status")),
                        dr("img")
                    )

                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Conn.Close()

    End Sub

    Private Sub btn_Addnew_Click(sender As Object, e As EventArgs) Handles btn_Addnew.Click
        Cafe_Manage.ShowDialog()


    End Sub




    Private Sub dgv_manage_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_manage.CellClick
        With Cafe_Manage
            .cafe_code.Text = dgv_manage.CurrentRow.Cells(0).Value
            .cafe_name.Text = dgv_manage.CurrentRow.Cells(1).Value
            .Combo_Size.Text = dgv_manage.CurrentRow.Cells(2).Value
            .price.Text = dgv_manage.CurrentRow.Cells(3).Value
            .check_av.Checked = CBool(dgv_manage.CurrentRow.Cells(4).Value)
            Dim bytes As Byte() = dgv_manage.CurrentRow.Cells(5).Value
            Dim msstream As New MemoryStream(bytes)
            .img_browse.Image = Image.FromStream(msstream)

            .btn_save.Enabled = False
            .cafe_code.ReadOnly = True
            .ShowDialog()
        End With





    End Sub

    Private Sub dgv_manage_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_manage.CellContentClick

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub btn_s_Click(sender As Object, e As EventArgs) Handles btn_s.Click
        dgv_manage.Rows.Clear()

        Try
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If

            ' Specify a condition after the LIKE keyword in the WHERE clause
            Dim query As String = "SELECT cafe_code, cafe_name, size, price, status FROM cafe_manage WHERE cafe_code LIKE @SearchText OR cafe_name LIKE @SearchText"

            Using com As New SqlCommand(query, Conn)
                com.Parameters.AddWithValue("@SearchText", "%" & txt_search.Text & "%")

                Using dr As SqlDataReader = com.ExecuteReader
                    While dr.Read
                        dgv_manage.Rows.Add(dr("cafe_code"), dr("cafe_name"), dr("size"), dr("price"), dr("status"))
                    End While
                End Using
            End Using
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try

        txt_search.Clear()
    End Sub

End Class