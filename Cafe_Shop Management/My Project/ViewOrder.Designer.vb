<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOrder
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ViewOrder))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        label_total = New Label()
        Label5 = New Label()
        Label4 = New Label()
        btn_pay = New Guna.UI2.WinForms.Guna2GradientButton()
        DataGridView1 = New DataGridView()
        btn_oder = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Timer1 = New Timer(components)
        btn_close = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_close, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label_total
        ' 
        label_total.AutoSize = True
        label_total.BackColor = Color.Transparent
        label_total.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        label_total.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        label_total.Location = New Point(288, 616)
        label_total.Name = "label_total"
        label_total.Size = New Size(23, 28)
        label_total.TabIndex = 22
        label_total.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(144, 618)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 31)
        Label5.TabIndex = 21
        Label5.Text = "ລວມມູນຄ່າ :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Phetsarath OT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(397, 613)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 36)
        Label4.TabIndex = 20
        Label4.Text = "ກີບ"
        ' 
        ' btn_pay
        ' 
        btn_pay.BorderRadius = 20
        btn_pay.CustomizableEdges = CustomizableEdges1
        btn_pay.DisabledState.BorderColor = Color.DarkGray
        btn_pay.DisabledState.CustomBorderColor = Color.DarkGray
        btn_pay.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_pay.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_pay.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_pay.FillColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btn_pay.FillColor2 = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btn_pay.FocusedColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        btn_pay.Font = New Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_pay.ForeColor = Color.White
        btn_pay.Location = New Point(465, 602)
        btn_pay.Name = "btn_pay"
        btn_pay.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btn_pay.Size = New Size(148, 56)
        btn_pay.TabIndex = 19
        btn_pay.Text = "ຊຳລະ"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(26, 135)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 30
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(587, 452)
        DataGridView1.TabIndex = 18
        ' 
        ' btn_oder
        ' 
        btn_oder.BackColor = Color.Transparent
        btn_oder.BorderRadius = 20
        btn_oder.CustomizableEdges = CustomizableEdges3
        btn_oder.DisabledState.BorderColor = Color.DarkGray
        btn_oder.DisabledState.CustomBorderColor = Color.DarkGray
        btn_oder.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_oder.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_oder.FillColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btn_oder.Font = New Font("Phetsarath OT", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btn_oder.ForeColor = Color.White
        btn_oder.ImageAlign = HorizontalAlignment.Left
        btn_oder.ImageSize = New Size(10, 10)
        btn_oder.Location = New Point(318, 79)
        btn_oder.Name = "btn_oder"
        btn_oder.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btn_oder.Size = New Size(122, 47)
        btn_oder.TabIndex = 23
        btn_oder.Text = "ສັ່ງຊື້ໃໝ່"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Phetsarath OT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(94, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 36)
        Label1.TabIndex = 24
        Label1.Text = "ລາຍການສັ່ງຊື້"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(40, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 63)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' btn_cancel
        ' 
        btn_cancel.BackColor = Color.Transparent
        btn_cancel.BorderRadius = 20
        btn_cancel.CustomizableEdges = CustomizableEdges5
        btn_cancel.DisabledState.BorderColor = Color.DarkGray
        btn_cancel.DisabledState.CustomBorderColor = Color.DarkGray
        btn_cancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_cancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_cancel.FillColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btn_cancel.Font = New Font("Phetsarath OT", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btn_cancel.ForeColor = Color.White
        btn_cancel.Location = New Point(463, 79)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btn_cancel.Size = New Size(150, 47)
        btn_cancel.TabIndex = 26
        btn_cancel.Text = "ຖອນການສັ່ງຊື້"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = Color.Transparent
        btn_close.ErrorImage = CType(resources.GetObject("btn_close.ErrorImage"), Image)
        btn_close.Image = CType(resources.GetObject("btn_close.Image"), Image)
        btn_close.Location = New Point(622, -1)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(28, 27)
        btn_close.SizeMode = PictureBoxSizeMode.Zoom
        btn_close.TabIndex = 27
        btn_close.TabStop = False
        ' 
        ' ViewOrder
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(649, 699)
        Controls.Add(btn_close)
        Controls.Add(btn_cancel)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btn_oder)
        Controls.Add(label_total)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btn_pay)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ViewOrder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewOrder"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_close, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label_total As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_pay As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_oder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_close As PictureBox
End Class
