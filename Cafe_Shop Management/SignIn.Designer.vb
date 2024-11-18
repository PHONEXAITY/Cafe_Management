<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SignIn))
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        cm_username = New Guna.UI2.WinForms.Guna2ComboBox()
        txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        remindme = New Guna.UI2.WinForms.Guna2CheckBox()
        btn_login = New Guna.UI2.WinForms.Guna2GradientButton()
        PictureBox4 = New PictureBox()
        showimg = New PictureBox()
        CheckBox1 = New CheckBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(showimg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Phetsarath OT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(28, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 36)
        Label1.TabIndex = 0
        Label1.Text = "ເຂົ້າສູ່ລະບົບ"
        ' 
        ' cm_username
        ' 
        cm_username.BackColor = Color.Transparent
        cm_username.BorderColor = Color.DodgerBlue
        cm_username.BorderRadius = 15
        cm_username.CustomizableEdges = CustomizableEdges7
        cm_username.DrawMode = DrawMode.OwnerDrawFixed
        cm_username.DropDownStyle = ComboBoxStyle.DropDownList
        cm_username.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cm_username.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cm_username.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        cm_username.ForeColor = Color.Black
        cm_username.ItemHeight = 40
        cm_username.Location = New Point(98, 357)
        cm_username.Name = "cm_username"
        cm_username.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        cm_username.Size = New Size(309, 46)
        cm_username.TabIndex = 2
        cm_username.TextAlign = HorizontalAlignment.Center
        cm_username.TextOffset = New Point(10, 0)
        ' 
        ' txtpassword
        ' 
        txtpassword.BorderColor = Color.DodgerBlue
        txtpassword.BorderRadius = 15
        txtpassword.CustomizableEdges = CustomizableEdges9
        txtpassword.DefaultText = ""
        txtpassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtpassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtpassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtpassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtpassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtpassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtpassword.Location = New Point(98, 484)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = ChrW(0)
        txtpassword.PlaceholderText = ""
        txtpassword.SelectedText = ""
        txtpassword.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtpassword.Size = New Size(309, 47)
        txtpassword.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(107, 310)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 31)
        Label2.TabIndex = 4
        Label2.Text = "ຊື່ຜູ້ໃຊ້ງານ"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.DodgerBlue
        Label3.Location = New Point(107, 436)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 31)
        Label3.TabIndex = 5
        Label3.Text = "ລະຫັດຜ່ານ"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), Image)
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(70, 310)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 31)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.ErrorImage = CType(resources.GetObject("PictureBox3.ErrorImage"), Image)
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(70, 436)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(31, 31)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' remindme
        ' 
        remindme.AutoSize = True
        remindme.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        remindme.CheckedState.BorderRadius = 0
        remindme.CheckedState.BorderThickness = 0
        remindme.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        remindme.Font = New Font("Phetsarath OT", 9F, FontStyle.Regular, GraphicsUnit.Point)
        remindme.Location = New Point(98, 537)
        remindme.Name = "remindme"
        remindme.Size = New Size(91, 27)
        remindme.TabIndex = 9
        remindme.Text = "ຈົດຈຳຂ້ອຍ"
        remindme.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        remindme.UncheckedState.BorderRadius = 0
        remindme.UncheckedState.BorderThickness = 0
        remindme.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ' 
        ' btn_login
        ' 
        btn_login.BorderRadius = 15
        btn_login.CustomizableEdges = CustomizableEdges11
        btn_login.DisabledState.BorderColor = Color.DarkGray
        btn_login.DisabledState.CustomBorderColor = Color.DarkGray
        btn_login.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_login.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_login.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_login.FillColor = Color.Blue
        btn_login.FillColor2 = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        btn_login.Font = New Font("Phetsarath OT", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btn_login.ForeColor = Color.White
        btn_login.HoverState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btn_login.HoverState.FillColor2 = Color.FromArgb(CByte(255), CByte(77), CByte(165))
        btn_login.Location = New Point(159, 600)
        btn_login.Name = "btn_login"
        btn_login.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btn_login.Size = New Size(181, 51)
        btn_login.TabIndex = 10
        btn_login.Text = "ເຂົ້າສູ່ລະບົບ"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(468, 1)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(28, 27)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 12
        PictureBox4.TabStop = False
        ' 
        ' showimg
        ' 
        showimg.BackColor = Color.Transparent
        showimg.ErrorImage = CType(resources.GetObject("showimg.ErrorImage"), Image)
        showimg.Image = CType(resources.GetObject("showimg.Image"), Image)
        showimg.Location = New Point(170, 102)
        showimg.Name = "showimg"
        showimg.Size = New Size(161, 162)
        showimg.SizeMode = PictureBoxSizeMode.Zoom
        showimg.TabIndex = 13
        showimg.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(376, 498)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(18, 17)
        CheckBox1.TabIndex = 14
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' SignIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(498, 738)
        Controls.Add(CheckBox1)
        Controls.Add(showimg)
        Controls.Add(PictureBox4)
        Controls.Add(btn_login)
        Controls.Add(remindme)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtpassword)
        Controls.Add(cm_username)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SignIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignIn"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(showimg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cm_username As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents remindme As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Guna2CirclePictureBox1 As PictureBox
    Friend WithEvents showimg As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
