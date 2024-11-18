Imports System
Imports System.Data.SqlClient
Imports System.IO


Public Class Manangements_main
    Dim Conn As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cafe_ManageSystem;Integrated Security=True")
    Dim dr As SqlDataReader
    Dim i As Integer
    Private WithEvents pic As New PictureBox
    Private WithEvents lbldesc As New Label
    Private WithEvents lblprice As New Label
    Dim username As String
    Dim j As Integer


    Dim overtotal As Decimal



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_managecafe.Click
        Cafe_ManageList.ShowDialog()
    End Sub





    Private Sub hidemanagebtn()
        Panel_submenu.Visible = False

    End Sub
    Private Sub showmanagebtn(submenu As Panel)
        If submenu.Visible = False Then
            hidemanagebtn()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub Manangements_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hidemanagebtn()
        Imageload()

        lb_orderDate.Text = Date.Now.ToString("dd/MM/yyyy")


        lb_orderNo.Text = GetOrderNo()


        username = SignIn.cm_username.Text
        lblUsername.Text = username




        GetRoleProfileByUsername(username)

        CheckPermissionFunction()

    End Sub




    Sub CheckPermissionFunction()

        Try
            Select Case lblRole.Text.ToLowerInvariant()
                Case "staffs"
                    btn_cafeManage.Visible = False
                    Panel_submenu.Visible = False
                    btn_manageuser.Visible = False
                    btn_managecafe.Visible = False
                    Login.Visible = False
                Case "manager"
                    Panel_submenu.Visible = True
                    btn_manageuser.Visible = False
                    btn_managecafe.Visible = True

                Case Else
                    ' MsgBox($"Unsupported role: {lblRole.Text}")
                    Panel_submenu.Visible = True
                    btn_manageuser.Visible = True
                    btn_managecafe.Visible = True
            End Select
        Catch ex As Exception
            MsgBox("Error adjusting button visibility: " & ex.Message)
        End Try
    End Sub


    Sub GetRoleProfileByUsername(username As String)
        Try

            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If

            Dim sqlQuery As String = "SELECT [role], [pic] FROM SignUp_db WHERE [username] = @username"

            Using com As New SqlCommand(sqlQuery, Conn)

                com.Parameters.AddWithValue("@username", username)

                Using reader As SqlDataReader = com.ExecuteReader()

                    If reader.HasRows Then

                        reader.Read()
                        Dim role As String = reader.GetString(reader.GetOrdinal("role"))

                        lblRole.Text = role
                        LoadImageIntoPictureBox(reader("pic"))
                        '   Else

                        '   MsgBox($"No data found for username: {username}.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally

            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

    Sub LoadImageIntoPictureBox(pic As Object)
        Try

            Dim picByteArray As Byte() = DirectCast(pic, Byte())

            UpdatePictureBox(picByteArray)
        Catch ex As Exception
            MsgBox("Error loading image: " & ex.Message)
        End Try
    End Sub

    Sub UpdatePictureBox(imageData As Byte())
        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then

            Using ms As New System.IO.MemoryStream(imageData)
                picUser.Image = Image.FromStream(ms)
            End Using
        Else

            picUser.Image = Nothing
        End If
    End Sub



    Private Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function







    Private Sub btn_cafeManage_Click(sender As Object, e As EventArgs) Handles btn_cafeManage.Click
        showmanagebtn(Panel_submenu)



    End Sub


    Function GetOrderNo() As String
        Try
            Dim sdate As String = Now.ToString("yyyy")
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If

            Dim com As New SqlCommand("SELECT TOP 1 Order_No FROM Order_manage WHERE Order_No LIKE '" & sdate & "%' ORDER BY Order_id DESC", Conn)
            Dim result As Object = com.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                GetOrderNo = CLng(result.ToString()) + 0



            Else
                GetOrderNo = sdate & "0001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Function









    Sub Imageload()
        Try
            Conn.Open()

            Using com As New SqlCommand("SELECT [img], [cafe_code], [cafe_name], [size], [price], [status] FROM cafe_manage", Conn)
                Using dr As SqlDataReader = com.ExecuteReader
                    Selectimg.AutoScroll = True
                    Selectimg.Controls.Clear()

                    While dr.Read
                        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                        Dim array(CInt(len)) As Byte
                        dr.GetBytes(0, 0, array, 0, CInt(len))

                        Dim pic As New PictureBox With {
                        .Width = 120,
                        .Height = 150,
                        .BackgroundImageLayout = ImageLayout.Stretch,
                        .Tag = dr.Item("cafe_code").ToString
                    }

                        Dim lbldesc As New Label With {
                        .ForeColor = Color.White,
                        .BackColor = Color.DodgerBlue,
                        .TextAlign = ContentAlignment.MiddleCenter,
                        .Dock = DockStyle.Top,
                        .Font = New Font("Segoe UI", 8, FontStyle.Bold),
                        .Tag = dr.Item("cafe_code").ToString
                    }

                        Dim lblprice As New Label With {
                        .ForeColor = Color.White,
                        .BackColor = Color.DarkOrange,
                        .Dock = DockStyle.Bottom,
                        .TextAlign = ContentAlignment.MiddleCenter,
                        .AutoSize = False,
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                        .Tag = dr.Item("cafe_code").ToString
                    }

                        Dim ms As New System.IO.MemoryStream(array)
                        Dim bitmap As New System.Drawing.Bitmap(ms)
                        pic.BackgroundImage = bitmap
                        lbldesc.Text = dr.Item("cafe_name").ToString
                        lblprice.Text = dr.Item("price").ToString

                        pic.Controls.Add(lbldesc)
                        pic.Controls.Add(lblprice)
                        Selectimg.Controls.Add(pic)

                        AddHandler pic.Click, AddressOf ViewOrder.Selectimg_Click
                        AddHandler lbldesc.Click, AddressOf ViewOrder.Selectimg_Click
                        AddHandler lblprice.Click, AddressOf ViewOrder.Selectimg_Click
                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub






    Sub QtyValidate()

    End Sub




    Private Sub Btn_report_Click(sender As Object, e As EventArgs)
        Report.Show()

    End Sub



    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        ViewOrder.ShowDialog()

    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles search_order.Click
        Conn.Open()
        Dim com As New SqlCommand("SELECT [img],[cafe_code],[cafe_name],[size],[price],[status] FROM cafe_manage Where cafe_code like '%" & txt_searchCafe.Text & "%' or cafe_name like '%" & txt_searchCafe.Text & "%'", Conn)
        dr = com.ExecuteReader
        Selectimg.AutoScroll = True
        Selectimg.Controls.Clear()

        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)


            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            pic = New PictureBox
            pic.Width = 120
            pic.Height = 150
            pic.BackgroundImageLayout = ImageLayout.Stretch
            pic.Tag = dr.Item("cafe_code").ToString

            With lbldesc
                lbldesc = New Label
                .ForeColor = Color.White
                .BackColor = Color.DodgerBlue
                .TextAlign = ContentAlignment.MiddleCenter
                .Dock = DockStyle.Top
                .Font = New Font("Segoe UI", 8, FontStyle.Bold)
                .Tag = dr.Item("cafe_code").ToString
            End With

            lblprice = New Label
            With lblprice
                .ForeColor = Color.White
                .BackColor = Color.DarkOrange
                .Dock = DockStyle.Bottom
                .TextAlign = ContentAlignment.MiddleCenter
                .AutoSize = False
                .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                .Tag = dr.Item("cafe_code").ToString
            End With

            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            lbldesc.Text = dr.Item("cafe_name").ToString
            lblprice.Text = dr.Item("price").ToString

            pic.Controls.Add(lbldesc)
            pic.Controls.Add(lblprice)
            Selectimg.Controls.Add(pic)

            AddHandler pic.Click, AddressOf ViewOrder.Selectimg_Click
            AddHandler lbldesc.Click, AddressOf ViewOrder.Selectimg_Click
            AddHandler lblprice.Click, AddressOf ViewOrder.Selectimg_Click

        End While
        dr.Dispose()
        Conn.Close()
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Imageload()

    End Sub

    Private Sub btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click
        If MessageBox.Show("ທ້ານຕ້ອງການອອກຫຼືບໍ", "ລະບົບ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Application.Exit()

        Else
            Return
        End If

    End Sub

    Private Sub btn_oder_Click(sender As Object, e As EventArgs) Handles btn_oder.Click
        dashboard.Show()

    End Sub

    Private Sub btn_manageuser_Click(sender As Object, e As EventArgs) Handles btn_manageuser.Click
        ManageUser_Cafe.ShowDialog()

    End Sub


    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click

        Me.Close()
        Dim loginForm As New Login()

        loginForm.Show()
    End Sub

    Private Sub btn_report_Click_1(sender As Object, e As EventArgs) Handles btn_report.Click
        Dim rpForm As New report_Order()

        rpForm.Show()
    End Sub

    Private Sub btn_sup_Click(sender As Object, e As EventArgs) Handles btn_sup.Click
        Help_Sup.ShowDialog()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class