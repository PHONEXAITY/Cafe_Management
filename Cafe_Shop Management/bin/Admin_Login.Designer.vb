<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Admin_Login))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Panel1 = New Panel()
        btn_back = New Guna.UI2.WinForms.Guna2CircleButton()
        btn_close = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Check_showpass = New Guna.UI2.WinForms.Guna2CheckBox()
        btn_login = New Guna.UI2.WinForms.Guna2Button()
        txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        txt_Username = New Guna.UI2.WinForms.Guna2TextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        CType(btn_close, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Controls.Add(btn_back)
        Panel1.Controls.Add(btn_close)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(498, 47)
        Panel1.TabIndex = 16
        ' 
        ' btn_back
        ' 
        btn_back.BackColor = Color.Transparent
        btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), Image)
        btn_back.BackgroundImageLayout = ImageLayout.Zoom
        btn_back.DisabledState.BorderColor = Color.DarkGray
        btn_back.DisabledState.CustomBorderColor = Color.DarkGray
        btn_back.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_back.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_back.FillColor = Color.Transparent
        btn_back.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_back.ForeColor = Color.Transparent
        btn_back.Location = New Point(3, 0)
        btn_back.Name = "btn_back"
        btn_back.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        btn_back.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btn_back.Size = New Size(52, 47)
        btn_back.TabIndex = 23
        btn_back.Text = "<"
        ' 
        ' btn_close
        ' 
        btn_close.ErrorImage = CType(resources.GetObject("btn_close.ErrorImage"), Image)
        btn_close.Image = CType(resources.GetObject("btn_close.Image"), Image)
        btn_close.Location = New Point(449, 3)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(46, 40)
        btn_close.SizeMode = PictureBoxSizeMode.Zoom
        btn_close.TabIndex = 22
        btn_close.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(59, 385)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 31)
        Label3.TabIndex = 15
        Label3.Text = "ລະຫັດຜ່ານ"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(53, 249)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 31)
        Label2.TabIndex = 14
        Label2.Text = "ຊື່ເຂົ້າໃຊ້ງານ"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Phetsarath OT", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(91, 105)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 36)
        Label1.TabIndex = 13
        Label1.Text = "ໜ້າເຂົ້າສູ່ລະບົບຂອງ Admin"
        ' 
        ' Check_showpass
        ' 
        Check_showpass.Animated = True
        Check_showpass.AutoSize = True
        Check_showpass.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Check_showpass.CheckedState.BorderRadius = 3
        Check_showpass.CheckedState.BorderThickness = 0
        Check_showpass.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Check_showpass.Location = New Point(387, 448)
        Check_showpass.Margin = New Padding(4, 5, 4, 5)
        Check_showpass.Name = "Check_showpass"
        Check_showpass.Size = New Size(18, 17)
        Check_showpass.TabIndex = 12
        Check_showpass.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Check_showpass.UncheckedState.BorderRadius = 3
        Check_showpass.UncheckedState.BorderThickness = 0
        Check_showpass.UncheckedState.FillColor = Color.Silver
        ' 
        ' btn_login
        ' 
        btn_login.Animated = True
        btn_login.AnimatedGIF = True
        btn_login.BorderRadius = 5
        btn_login.CustomizableEdges = CustomizableEdges2
        btn_login.DisabledState.BorderColor = Color.DarkGray
        btn_login.DisabledState.CustomBorderColor = Color.DarkGray
        btn_login.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_login.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_login.Font = New Font("Phetsarath OT", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btn_login.ForeColor = Color.White
        btn_login.Location = New Point(154, 554)
        btn_login.Margin = New Padding(4, 5, 4, 5)
        btn_login.Name = "btn_login"
        btn_login.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        btn_login.Size = New Size(163, 49)
        btn_login.TabIndex = 11
        btn_login.Text = "ເຂົ້າສູ່ລະບົບ"
        ' 
        ' txt_password
        ' 
        txt_password.BorderRadius = 5
        txt_password.Cursor = Cursors.IBeam
        txt_password.CustomizableEdges = CustomizableEdges4
        txt_password.DefaultText = ""
        txt_password.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_password.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_password.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_password.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_password.FillColor = SystemColors.Menu
        txt_password.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_password.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txt_password.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_password.Location = New Point(103, 430)
        txt_password.Margin = New Padding(4, 5, 4, 5)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "●"c
        txt_password.PlaceholderText = ""
        txt_password.SelectedText = ""
        txt_password.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        txt_password.Size = New Size(315, 55)
        txt_password.TabIndex = 10
        txt_password.TextOffset = New Point(5, 0)
        txt_password.UseSystemPasswordChar = True
        ' 
        ' txt_Username
        ' 
        txt_Username.BorderRadius = 5
        txt_Username.Cursor = Cursors.IBeam
        txt_Username.CustomizableEdges = CustomizableEdges6
        txt_Username.DefaultText = ""
        txt_Username.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_Username.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_Username.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_Username.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_Username.FillColor = SystemColors.Menu
        txt_Username.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_Username.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txt_Username.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_Username.Location = New Point(103, 300)
        txt_Username.Margin = New Padding(4, 5, 4, 5)
        txt_Username.Name = "txt_Username"
        txt_Username.PasswordChar = "●"c
        txt_Username.PlaceholderText = ""
        txt_Username.SelectedText = ""
        txt_Username.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        txt_Username.Size = New Size(315, 55)
        txt_Username.TabIndex = 17
        txt_Username.TextOffset = New Point(5, 0)
        txt_Username.UseSystemPasswordChar = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(25, 86)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(59, 55)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), Image)
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(23, 249)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 31)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 19
        PictureBox2.TabStop = False
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.ErrorImage = CType(resources.GetObject("PictureBox3.ErrorImage"), Image)
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(25, 385)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(30, 30)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 20
        PictureBox3.TabStop = False
        ' 
        ' Admin_Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(498, 738)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(txt_Username)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Check_showpass)
        Controls.Add(btn_login)
        Controls.Add(txt_password)
        FormBorderStyle = FormBorderStyle.None
        Name = "Admin_Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin_Login"
        Panel1.ResumeLayout(False)
        CType(btn_close, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Check_showpass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_close As PictureBox
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2CircleButton
End Class
