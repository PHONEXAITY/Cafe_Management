Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class ViewOrder
    Dim Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")
    Dim dr As SqlDataReader
    Dim i As Integer


    Public Sub Selectimg_Click(sender As Object, e As EventArgs)
        Try
            Conn.Open()

            Dim query As String = "SELECT cafe_code, cafe_name, price FROM cafe_manage WHERE cafe_code LIKE @cafe_code"
            Using com As New SqlCommand(query, Conn)
                com.Parameters.AddWithValue("@cafe_code", sender.Tag.ToString & "%")

                ' Create a List to store the data
                Dim data As New List(Of Tuple(Of String, String, String))

                Using dr As SqlDataReader = com.ExecuteReader
                    ' Read data from the SqlDataReader and store it in the List
                    While dr.Read
                        Dim cafeCode As String = dr.GetString(dr.GetOrdinal("cafe_code"))
                        Dim cafeName As String = dr.GetString(dr.GetOrdinal("cafe_name"))
                        Dim price As String = dr.GetDecimal(dr.GetOrdinal("price")).ToString()
                        data.Add(Tuple.Create(cafeCode, cafeName, price))
                    End While
                End Using

                ' Only add columns if there are no existing columns
                If DataGridView1.Columns.Count = 0 Then
                    DataGridView1.Columns.Add("Column1", "NO")
                    DataGridView1.Columns.Add("Column2", "Cafe Code")
                    DataGridView1.Columns.Add("Column3", "Cafe Name")
                    DataGridView1.Columns.Add("Column4", "Price")
                    DataGridView1.Columns.Add("Column5", "Quantity")
                End If

                ' Add rows based on the data stored in the List
                For Each rowValues In data
                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridView1)
                    row.SetValues(DataGridView1.Rows.Count + 1, rowValues.Item1, rowValues.Item2, rowValues.Item3, "1")
                    DataGridView1.Rows.Add(row)

                    ' Insert into Order_manage
                    InsertIntoOrderManage(rowValues.Item1, rowValues.Item2, rowValues.Item3, 1)
                    ' MessageBox.Show("ເພີ່ມແລ້ວ")

                Next
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Conn.Close()
        End Try


    End Sub
    Private Sub btn_oder_Click(sender As Object, e As EventArgs) Handles btn_oder.Click
        clear()

    End Sub
    Sub clear()
        '  Manangements_main.lb_orderNo.Text = Manangements_main.updateGetOrderNo()
        DataGridView1.Rows.Clear()
        label_total.Text = "00.00"

    End Sub
    Sub overalltotal()
        Try
            Dim i As Decimal
            Dim sum As Decimal = 0

            For i = 0 To DataGridView1.Rows.Count - 1
                Debug.Print($"Row {i}: Column 3 - {DataGridView1.Rows(i).Cells(2).Value}, Column 4 - {DataGridView1.Rows(i).Cells(3).Value}")
                sum += CDec(DataGridView1.Rows(i).Cells(3).Value) * CDec(DataGridView1.Rows(i).Cells(4).Value)
            Next

            label_total.Text = CDec(sum)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        overalltotal()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub ViewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        overalltotal()
        CancelOrder.Orderload()

    End Sub

    Private Sub Btn_Pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click

        Try
            Conn.Open()

            ' Fetch the Order_No for the current order
            Dim orderNo As String = Manangements_main.GetOrderNo()

            ' Use a flag to determine if the entry has already been added
            Dim entryAdded As Boolean = False

            For j As Integer = 0 To DataGridView1.Rows.Count - 1
                Dim cafeCode As String = If(DataGridView1.Rows(j).Cells(0).Value IsNot Nothing, DataGridView1.Rows(j).Cells(0).Value.ToString(), "")
                Dim cafeName As String = If(DataGridView1.Rows(j).Cells(1).Value IsNot Nothing, DataGridView1.Rows(j).Cells(1).Value.ToString(), "")

                ' Handle null or invalid price values
                Dim price As Decimal = 0
                If DataGridView1.Rows(j).Cells(2).Value IsNot Nothing Then
                    Decimal.TryParse(DataGridView1.Rows(j).Cells(2).Value.ToString(), price)
                End If

                Dim qty As Decimal = If(DataGridView1.Rows(j).Cells(3).Value IsNot Nothing, CDec(DataGridView1.Rows(j).Cells(3).Value.ToString()), 0)

                ' Calculate total for the current item
                Dim total As Decimal = label_total.Text

                If Not entryAdded Then
                    Dim paymentDate As DateTime = DateTime.Now ' You can replace this with your specific payment date

                    Dim billCmd As New SqlCommand("INSERT INTO BillPay( Order_No, TotalAmount, PaymentAmount, PaymentDate) VALUES (@Order_No, @TotalAmount, @PaymentAmount, @PaymentDate) ", Conn)

                    billCmd.Parameters.AddWithValue("@Order_No", orderNo)
                    billCmd.Parameters.AddWithValue("@TotalAmount", total)
                    billCmd.Parameters.AddWithValue("@PaymentAmount", 0) ' Initially set to 0, update later if needed
                    billCmd.Parameters.AddWithValue("@PaymentDate", paymentDate) ' Set to the specific payment date

                    billCmd.ExecuteNonQuery()

                    ' Set the flag to indicate that the entry has been added
                    entryAdded = True
                End If
            Next


        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)

        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try


        BillingForm.Show()
        clear()


    End Sub


    Private Sub InsertIntoOrderManage(cafeCode As String, cafeName As String, price As String, qty As Integer)
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If

            Using cmd As New SqlCommand("INSERT INTO Order_manage(Order_No, Order_Date, cafe_code, cafe_name, price, qty, total) VALUES (@Order_No,@Order_Date,@cafe_code,@cafe_name,@price,@qty,@total)", Conn)
                cmd.Parameters.AddWithValue("@Order_No", Manangements_main.getorderno)
                cmd.Parameters.AddWithValue("@Order_Date", Date.Now.ToString("dd/MM/yyyy"))
                cmd.Parameters.AddWithValue("@cafe_code", cafeCode)
                cmd.Parameters.AddWithValue("@cafe_name", cafeName)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@qty", qty)
                cmd.Parameters.AddWithValue("@total", (Convert.ToDecimal(price) * qty).ToString())

                Dim i As Integer = cmd.ExecuteNonQuery()

                ' Optionally, you can handle the result of the insertion (i variable) if needed.
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        CancelOrder.Show()
    End Sub
End Class