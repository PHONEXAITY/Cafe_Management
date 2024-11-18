
Imports System.Data.SqlClient
Imports System.IO
Public Class dashboard
    Dim Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")
    Dim dr As SqlDataReader


    Private Sub Dashboardfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalUser()
        totalproduct()
        totalOrder()
        LOADZEROSTOCK()
        negativestock()
        totalsales()
        Timer1.Start()
    End Sub

    Sub totalUser()
        Try
            Conn.Open()
            Dim cmd As New SqlCommand("select count(Login_id) from SignUp_db ", Conn)
            lbl_totalcustomer.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Sub totalproduct()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select count(cafe_id) from cafe_manage ", Conn)
            lbl_totalProduct.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub totalOrder()
        Try
            Conn.Open()
            Dim cmd As New SqlCommand("select count(Order_id) from Order_manage ", Conn)
            lbl_totalusers.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Sub totalsales()
        Try
            Conn.Open()
            Dim cmd As New SqlCommand("select SUM(TotalAmount) from BillPay ", Conn)
            lbl_todayinbound.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Sub LOADZEROSTOCK()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from cafe_manage ", Conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("cafe_code"), dr.Item("cafe_name"), dr.Item("size"), dr.Item("price"), dr.Item("status"), dr.Item("img"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub negativestock()
        DataGridView2.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from Order_manage ", Conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("Order_No"), dr.Item("Order_Date"), dr.Item("cafe_code"), dr.Item("cafe_name"), dr.Item("price"), dr.Item("qty"), dr.Item("total"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        totalUser()
        totalproduct()
        totalOrder()
        LOADZEROSTOCK()
        negativestock()
        totalsales()
    End Sub


End Class