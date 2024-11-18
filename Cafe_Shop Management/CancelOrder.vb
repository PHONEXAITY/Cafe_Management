Imports System.IO
Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class CancelOrder
    Dim Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")
    Dim dr As SqlDataReader
    Dim tr As SqlTransaction
    Dim i As Integer
    Dim btncategory As New Button

    Private Sub CancelOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Orderload()
    End Sub

    Sub Orderload()
        dgv_cancelorder.Rows.Clear()


        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If
        Dim com As New SqlCommand("SELECT Order_No, price FROM Order_manage", Conn)
        dr = com.ExecuteReader

        If dgv_cancelorder.Columns.Count = 0 Then
            dgv_cancelorder.Columns.Add("Order_No", "Order Number")
            dgv_cancelorder.Columns.Add("total_price", "Total Price")
        End If

        While dr.Read
            dgv_cancelorder.Rows.Add(dr.Item("Order_No"), dr.Item("price"))
        End While

        FormatDgvList()

        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If MessageBox.Show("Do you want to delete", "Command", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim tr As SqlTransaction = Nothing


            Conn.Open() ' Open the connection before starting the transaction
            tr = Conn.BeginTransaction()

            Dim sb As New StringBuilder()
            sb.Append("DELETE FROM Order_manage WHERE Order_No=@Order_No")

            Dim sqlDelete As String = sb.ToString()

            Using com As New SqlCommand(sqlDelete, Conn, tr)
                com.Parameters.AddWithValue("@Order_No", dgv_cancelorder.CurrentRow.Cells("Order_No").Value.ToString())

                Dim result As Integer = com.ExecuteNonQuery()

                If result = 0 Then
                    tr.Rollback()
                    MessageBox.Show("Order cannot be deleted", "Command", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    tr.Commit()
                    MessageBox.Show("Order cancelled successfully!!!", "Command", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Orderload()
                End If
            End Using

            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If

        End If

        Orderload()
    End Sub

    Private Sub FormatDgvList()
        With dgv_cancelorder
            If .RowCount = 0 Then
                .Columns(0).Width = 80
                .Columns(1).Width = 120
            End If
        End With
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()


    End Sub

    Private Sub btn_s_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        dgv_cancelorder.Rows.Clear()

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        ' Specify a condition after the LIKE keyword in the WHERE clause
        Dim com As New SqlCommand("SELECT Order_No, price FROM Order_manage WHERE Order_No LIKE '%" & txt_search.Text & "%' or cafe_name like '%" & txt_search.Text & "%'", Conn)

        dr = com.ExecuteReader

        While dr.Read
            dgv_cancelorder.Rows.Add(dr.Item("Order_No"), dr.Item("price"))
            '
        End While

        FormatDgvList()

        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        txt_search.Clear()

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim tr As SqlTransaction = Nothing

        Try
            Conn.Open() ' Open the connection before starting the transaction
            tr = Conn.BeginTransaction()

            Dim sb As New StringBuilder()
            sb.Append("DELETE FROM Order_manage")

            Dim sqlDelete As String = sb.ToString()

            Using com As New SqlCommand(sqlDelete, Conn, tr)

                Dim result As Integer = com.ExecuteNonQuery()

                If result = 0 Then
                    tr.Rollback()
                    MessageBox.Show("Order cannot be deleted", "Command", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    tr.Commit()
                    MessageBox.Show("Order cancelled successfully!!!", "Command", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Orderload()
                End If
            End Using
        Catch ex As Exception
            tr.Rollback()
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try


    End Sub


End Class
