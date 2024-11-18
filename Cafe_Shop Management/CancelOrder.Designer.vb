<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelOrder
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CancelOrder))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        btn_search = New Guna.UI2.WinForms.Guna2GradientButton()
        txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        dgv_cancelorder = New Guna.UI2.WinForms.Guna2DataGridView()
        btn_close = New PictureBox()
        btn_del = New Guna.UI2.WinForms.Guna2Button()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(dgv_cancelorder, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_close, ComponentModel.ISupportInitialize).BeginInit()
        Guna2CustomGradientPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Phetsarath OT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(73, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 36)
        Label1.TabIndex = 2
        Label1.Text = "ຖອນການສັ່ງຊື້"
        ' 
        ' btn_search
        ' 
        btn_search.BorderRadius = 15
        btn_search.CustomizableEdges = CustomizableEdges1
        btn_search.DisabledState.BorderColor = Color.DarkGray
        btn_search.DisabledState.CustomBorderColor = Color.DarkGray
        btn_search.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_search.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_search.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_search.FillColor = Color.SkyBlue
        btn_search.FillColor2 = Color.DodgerBlue
        btn_search.Font = New Font("Phetsarath OT", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        btn_search.ForeColor = Color.White
        btn_search.Location = New Point(491, 71)
        btn_search.Name = "btn_search"
        btn_search.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btn_search.Size = New Size(146, 49)
        btn_search.TabIndex = 6
        btn_search.Text = "ຄົ້ນຫາ"
        ' 
        ' txt_search
        ' 
        txt_search.CustomizableEdges = CustomizableEdges3
        txt_search.DefaultText = ""
        txt_search.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_search.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_search.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_search.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_search.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_search.Font = New Font("Phetsarath OT", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txt_search.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_search.IconRight = My.Resources.Resources.search_interface_symbol
        txt_search.Location = New Point(73, 71)
        txt_search.Name = "txt_search"
        txt_search.PasswordChar = ChrW(0)
        txt_search.PlaceholderText = "ຄົ້ນຫາລະຫັດສັ່ງຊື້"
        txt_search.SelectedText = ""
        txt_search.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txt_search.Size = New Size(407, 52)
        txt_search.TabIndex = 5
        ' 
        ' dgv_cancelorder
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgv_cancelorder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgv_cancelorder.BorderStyle = BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgv_cancelorder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgv_cancelorder.ColumnHeadersHeight = 30
        dgv_cancelorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgv_cancelorder.DefaultCellStyle = DataGridViewCellStyle3
        dgv_cancelorder.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgv_cancelorder.Location = New Point(51, 169)
        dgv_cancelorder.Name = "dgv_cancelorder"
        dgv_cancelorder.RowHeadersVisible = False
        dgv_cancelorder.RowHeadersWidth = 51
        dgv_cancelorder.RowTemplate.Height = 29
        dgv_cancelorder.Size = New Size(811, 429)
        dgv_cancelorder.TabIndex = 7
        dgv_cancelorder.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgv_cancelorder.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgv_cancelorder.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgv_cancelorder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgv_cancelorder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgv_cancelorder.ThemeStyle.BackColor = Color.White
        dgv_cancelorder.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgv_cancelorder.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgv_cancelorder.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgv_cancelorder.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgv_cancelorder.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgv_cancelorder.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgv_cancelorder.ThemeStyle.HeaderStyle.Height = 30
        dgv_cancelorder.ThemeStyle.ReadOnly = False
        dgv_cancelorder.ThemeStyle.RowsStyle.BackColor = Color.White
        dgv_cancelorder.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv_cancelorder.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgv_cancelorder.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgv_cancelorder.ThemeStyle.RowsStyle.Height = 29
        dgv_cancelorder.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgv_cancelorder.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = Color.Transparent
        btn_close.ErrorImage = CType(resources.GetObject("btn_close.ErrorImage"), Image)
        btn_close.Image = CType(resources.GetObject("btn_close.Image"), Image)
        btn_close.Location = New Point(873, 1)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(28, 27)
        btn_close.SizeMode = PictureBoxSizeMode.Zoom
        btn_close.TabIndex = 23
        btn_close.TabStop = False
        ' 
        ' btn_del
        ' 
        btn_del.BorderRadius = 15
        btn_del.CustomizableEdges = CustomizableEdges5
        btn_del.DisabledState.BorderColor = Color.DarkGray
        btn_del.DisabledState.CustomBorderColor = Color.DarkGray
        btn_del.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_del.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_del.Font = New Font("Phetsarath OT", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btn_del.ForeColor = Color.White
        btn_del.Location = New Point(707, 126)
        btn_del.Name = "btn_del"
        btn_del.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btn_del.Size = New Size(135, 37)
        btn_del.TabIndex = 24
        btn_del.Text = "ຖອນ"
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.Controls.Add(PictureBox2)
        Guna2CustomGradientPanel1.Controls.Add(PictureBox1)
        Guna2CustomGradientPanel1.Controls.Add(Label1)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges7
        Guna2CustomGradientPanel1.Dock = DockStyle.Top
        Guna2CustomGradientPanel1.FillColor = Color.Blue
        Guna2CustomGradientPanel1.FillColor4 = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Guna2CustomGradientPanel1.Location = New Point(0, 0)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2CustomGradientPanel1.Size = New Size(902, 43)
        Guna2CustomGradientPanel1.TabIndex = 25
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), Image)
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(874, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 26
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(55, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 15
        Guna2Button1.CustomizableEdges = CustomizableEdges9
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Phetsarath OT", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button1.ForeColor = Color.DimGray
        Guna2Button1.Location = New Point(831, 49)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Button1.Size = New Size(70, 37)
        Guna2Button1.TabIndex = 26
        Guna2Button1.Text = "Del"
        ' 
        ' CancelOrder
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(902, 634)
        Controls.Add(Guna2Button1)
        Controls.Add(Guna2CustomGradientPanel1)
        Controls.Add(btn_del)
        Controls.Add(btn_close)
        Controls.Add(dgv_cancelorder)
        Controls.Add(btn_search)
        Controls.Add(txt_search)
        FormBorderStyle = FormBorderStyle.None
        Name = "CancelOrder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CancelOrder"
        CType(dgv_cancelorder, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_close, ComponentModel.ISupportInitialize).EndInit()
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Guna2CustomGradientPanel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgv_cancelorder As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btn_close As PictureBox
    Friend WithEvents btn_del As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
