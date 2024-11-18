Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Text

Public Class BillingForm
    Dim Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")
    Dim dataAdapter As SqlDataAdapter
    Dim dataTable As DataTable

    Private Sub BillingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDataIntoDataGridView()
    End Sub


    Private Sub LoadDataIntoDataGridView()
        Try
            Conn.Open()

            Dim query As String = "SELECT Order_No , cafe_name, price   FROM Order_manage"
            dataAdapter = New SqlDataAdapter(query, Conn)
            dataTable = New DataTable()
            dataAdapter.Fill(dataTable)


            DataGridView1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally

            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        If DataGridView1.CurrentRow IsNot Nothing Then
            PrintPreviewDialog1.ShowDialog()



            ' Open the connection before starting the transaction

            Try
                Conn.Open()


                Using tr As SqlTransaction = Conn.BeginTransaction()
                    Try
                        Dim sb As New StringBuilder()
                        sb.Append("DELETE FROM Order_manage ")

                        Dim sqlDelete As String = sb.ToString()

                        Using com As New SqlCommand(sqlDelete, Conn, tr)
                            com.Parameters.AddWithValue("@Order_No", DataGridView1.CurrentRow.Cells("Order_No").Value.ToString())
                            Dim result As Integer = com.ExecuteNonQuery()
                            tr.Commit()
                        End Using

                    Catch ex As Exception

                        tr.Rollback()
                        Throw
                    End Try
                End Using

                Conn.Close()
                LoadDataIntoDataGridView()

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            MessageBox.Show("ຍັງບໍ່ມີລາຍການສັ່ງຊື້.", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titleFont As New Font("Phetsarath OT", 16, FontStyle.Bold)
        Dim headerFont As New Font("Phetsarath OT", 12, FontStyle.Bold)
        Dim regularFont As New Font("Phetsarath OT", 10)
        Dim totalFont As New Font("Phetsarath OT", 12, FontStyle.Bold)

        Dim yPos As Single = 0
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top




        Dim title As String = "ໃບບິນການສັ່ງຊື້"
        yPos += PrintCenteredText(title, titleFont, e, leftMargin, yPos)
        yPos += 30

        Dim currentDate As String = Date.Now.ToString("dd/MM/yyyy")
        Dim totalLineYPos As Single = yPos + 30
        yPos += PrintText(currentDate, regularFont, e, leftMargin, yPos)
        yPos += 20

        Dim customHeaders As String() = {"ລະຫັດການສັ່ງຊື້", "ຊື້ສິນຄ້າ", "ລາຄາ"}
        Dim headers As String = String.Join(vbTab, customHeaders.Select(Function(col) col.PadRight(38)))
        yPos += PrintText(headers, headerFont, e, leftMargin, yPos)
        yPos += 10


        For Each row As DataRow In dataTable.Rows
            Dim orderNo As String = row("Order_No").ToString().PadRight(60)
            Dim cafeName As String = row("Cafe_name").ToString().PadRight(40)
            Dim price As String = row("Price").ToString().PadRight(20)



            Dim rowData As String = $"{orderNo}{cafeName}{price}"
            yPos += PrintText(rowData, regularFont, e, leftMargin, yPos)
        Next



        Dim totalPrice As Decimal = If(dataTable.Rows.Count > 0, dataTable.AsEnumerable().Sum(Function(row) Convert.ToDecimal(row("Price"))), 0)


        Dim totalLine As String = $"ຍອດລວມທັງໝົດ: {totalPrice:N0} ກີບ"


        Dim totalLineXPos As Single = e.MarginBounds.Right - e.Graphics.MeasureString(totalLine, totalFont).Width
        Dim totalLineYPoss As Single = yPos + 30
        yPos += PrintText(totalLine, totalFont, e, totalLineXPos, totalLineYPoss)


        e.HasMorePages = False '
    End Sub





    Private Function PrintText(text As String, font As Font, e As PrintPageEventArgs, x As Single, y As Single) As Single
        e.Graphics.DrawString(text, font, Brushes.Black, x, y)
        Return font.GetHeight(e.Graphics)
    End Function

    Private Function PrintCenteredText(text As String, font As Font, e As PrintPageEventArgs, x As Single, y As Single) As Single
        Dim width As Single = e.MarginBounds.Width
        Dim textWidth As Single = e.Graphics.MeasureString(text, font).Width
        Dim xPos As Single = x + (width - textWidth) / 2
        e.Graphics.DrawString(text, font, Brushes.Black, xPos, y)
        Return font.GetHeight(e.Graphics)
    End Function

    Private Sub setup_Click(sender As Object, e As EventArgs) Handles setup.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub
End Class
