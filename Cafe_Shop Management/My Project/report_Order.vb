Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Cafe_Shop_Management.Cafe_Shop_Management

Public Class report_Order
    Dim Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")
    Dim status As String

    Private dataTable As DataTable
    Private rowIndex As Integer

    Private Sub report_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim query As String = ""
        Select Case status
            Case "order"
                query = "SELECT * FROM Order_manage"
            Case "cafe"
                query = "SELECT * FROM cafe_manage"
            Case Else
                query = "SELECT * FROM Order_manage"
                Return
        End Select

        Dim dataTable As New DataTable()
        Dim cmd As New SqlCommand(query, Conn)

        Try
            Conn.Open()

            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dataTable)
            Guna2DataGridView1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error retrieving data: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub Report_Cafe_Click(sender As Object, e As EventArgs) Handles Report_Cafe.Click
        status = "cafe"
        LoadData()
    End Sub

    Private Sub rp_Order_Click(sender As Object, e As EventArgs) Handles rp_Order.Click
        status = "order"
        LoadData()
    End Sub


    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click
        Select Case status
            Case "order"
                dataTable = New DataTable()
                Using adapter As New SqlDataAdapter("SELECT * FROM Order_manage", Conn)
                    adapter.Fill(dataTable)
                End Using
            Case "cafe"
                dataTable = New DataTable()
                Using adapter As New SqlDataAdapter("SELECT * FROM cafe_manage", Conn)
                    adapter.Fill(dataTable)
                End Using
        End Select
        rowIndex = 0

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titleFont As New Font("Phetsarath OT", 16, FontStyle.Bold)
        Dim yPos As Single = 0
        Dim leftMargin As Single = e.MarginBounds.Left

        Dim title As String = "ຜົນລາຍງານທັງໝົດ"
        yPos += PrintCenteredText(title, titleFont, e, leftMargin, yPos)
        yPos += 30
        Dim startX As Integer = 35
        Dim startY As Integer = 35
        Dim lineHeight As Integer = 20

        Dim columnIndex As Integer = 0
        For Each column As DataColumn In DataTable.Columns
            e.Graphics.DrawString(column.ColumnName, Font, Brushes.Black, startX + columnIndex * 100, startY)
            columnIndex += 1
        Next
        For i As Integer = rowIndex To dataTable.Rows.Count - 1
            Dim row As DataRow = dataTable.Rows(i)
            rowIndex = i + 1


            columnIndex = 0
            For Each column As DataColumn In dataTable.Columns
                Dim cellValue As String = row(column).ToString()
                e.Graphics.DrawString(cellValue, Font, Brushes.Black, startX + columnIndex * 100, startY + rowIndex * lineHeight)
                columnIndex += 1
            Next


            If startY + (rowIndex + 1) * lineHeight > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If
        Next

        e.HasMorePages = False
    End Sub

    Private Function PrintCenteredText(text As String, font As Font, e As PrintPageEventArgs, x As Single, y As Single) As Single
        Dim width As Single = e.MarginBounds.Width
        Dim textWidth As Single = e.Graphics.MeasureString(text, font).Width
        Dim xPos As Single = x + (width - textWidth) / 2
        e.Graphics.DrawString(text, font, Brushes.Black, xPos, y)
        Return font.GetHeight(e.Graphics)
    End Function


    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles HelpToolStripButton.Click

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles page_setup.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub


    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        Try
            If Guna2DataGridView1.SelectedCells.Count > 0 Then
                Dim selectedRows As List(Of DataGridViewRow) = Guna2DataGridView1.SelectedRows.Cast(Of DataGridViewRow)().ToList()
                Dim selectedColumns As List(Of DataGridViewColumn) = Guna2DataGridView1.SelectedColumns.Cast(Of DataGridViewColumn)().ToList()

                Dim copiedData As New DataTable()

                For Each selectedColumn As DataGridViewColumn In selectedColumns
                    copiedData.Columns.Add(selectedColumn.Name)
                Next
                For Each selectedRow As DataGridViewRow In selectedRows
                    Dim newRow As DataRow = copiedData.NewRow()
                    For Each selectedColumn As DataGridViewColumn In selectedColumns
                        newRow(selectedColumn.Name) = selectedRow.Cells(selectedColumn.Name).Value
                    Next
                    copiedData.Rows.Add(newRow)
                Next

                Clipboard.SetDataObject(copiedData)
                MessageBox.Show("ຄັດລັອກຂໍ້ມູນສຳເລັດແລ້ວ", "ລະບົບ")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
