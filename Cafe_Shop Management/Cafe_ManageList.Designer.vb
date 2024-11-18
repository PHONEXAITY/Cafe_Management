<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cafe_ManageList
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Cafe_ManageList))
        txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        btn_Addnew = New Guna.UI2.WinForms.Guna2GradientButton()
        btn_s = New Guna.UI2.WinForms.Guna2GradientButton()
        dgv_manage = New Guna.UI2.WinForms.Guna2DataGridView()
        cafe_code = New DataGridViewTextBoxColumn()
        cafe_name = New DataGridViewTextBoxColumn()
        size = New DataGridViewTextBoxColumn()
        price = New DataGridViewTextBoxColumn()
        status = New DataGridViewCheckBoxColumn()
        img = New DataGridViewTextBoxColumn()
        btn_close = New PictureBox()
        Label2 = New Label()
        CType(dgv_manage, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_close, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_search
        ' 
        txt_search.CustomizableEdges = CustomizableEdges1
        txt_search.DefaultText = ""
        txt_search.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_search.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_search.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_search.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_search.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_search.Font = New Font("Phetsarath OT", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txt_search.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_search.IconRight = My.Resources.Resources.search_interface_symbol
        txt_search.Location = New Point(60, 65)
        txt_search.Name = "txt_search"
        txt_search.PasswordChar = ChrW(0)
        txt_search.PlaceholderText = "ຄົ້ນຫາລະຫັດຄາເຟ່"
        txt_search.SelectedText = ""
        txt_search.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txt_search.Size = New Size(407, 52)
        txt_search.TabIndex = 2
        ' 
        ' btn_Addnew
        ' 
        btn_Addnew.CustomizableEdges = CustomizableEdges3
        btn_Addnew.DisabledState.BorderColor = Color.DarkGray
        btn_Addnew.DisabledState.CustomBorderColor = Color.DarkGray
        btn_Addnew.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_Addnew.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_Addnew.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_Addnew.FillColor = Color.SkyBlue
        btn_Addnew.FillColor2 = Color.DodgerBlue
        btn_Addnew.Font = New Font("Phetsarath OT", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        btn_Addnew.ForeColor = Color.White
        btn_Addnew.Location = New Point(700, 116)
        btn_Addnew.Name = "btn_Addnew"
        btn_Addnew.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btn_Addnew.Size = New Size(146, 49)
        btn_Addnew.TabIndex = 3
        btn_Addnew.Text = "ເພິ່ມສິນຄ້າ"
        ' 
        ' btn_s
        ' 
        btn_s.BorderRadius = 15
        btn_s.CustomizableEdges = CustomizableEdges5
        btn_s.DisabledState.BorderColor = Color.DarkGray
        btn_s.DisabledState.CustomBorderColor = Color.DarkGray
        btn_s.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_s.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_s.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_s.FillColor = Color.SkyBlue
        btn_s.FillColor2 = Color.DodgerBlue
        btn_s.Font = New Font("Phetsarath OT", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        btn_s.ForeColor = Color.White
        btn_s.Location = New Point(473, 68)
        btn_s.Name = "btn_s"
        btn_s.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btn_s.Size = New Size(146, 49)
        btn_s.TabIndex = 4
        btn_s.Text = "ຄົ້ນຫາ"
        ' 
        ' dgv_manage
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgv_manage.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgv_manage.BorderStyle = BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgv_manage.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgv_manage.ColumnHeadersHeight = 60
        dgv_manage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgv_manage.Columns.AddRange(New DataGridViewColumn() {cafe_code, cafe_name, size, price, status, img})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgv_manage.DefaultCellStyle = DataGridViewCellStyle3
        dgv_manage.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgv_manage.Location = New Point(45, 171)
        dgv_manage.Name = "dgv_manage"
        dgv_manage.RowHeadersVisible = False
        dgv_manage.RowHeadersWidth = 51
        dgv_manage.RowTemplate.Height = 29
        dgv_manage.Size = New Size(801, 425)
        dgv_manage.TabIndex = 5
        dgv_manage.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgv_manage.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgv_manage.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgv_manage.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgv_manage.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgv_manage.ThemeStyle.BackColor = Color.White
        dgv_manage.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgv_manage.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgv_manage.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgv_manage.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgv_manage.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgv_manage.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgv_manage.ThemeStyle.HeaderStyle.Height = 60
        dgv_manage.ThemeStyle.ReadOnly = False
        dgv_manage.ThemeStyle.RowsStyle.BackColor = Color.White
        dgv_manage.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv_manage.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgv_manage.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgv_manage.ThemeStyle.RowsStyle.Height = 29
        dgv_manage.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgv_manage.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' cafe_code
        ' 
        cafe_code.HeaderText = "Coffee Code"
        cafe_code.MinimumWidth = 6
        cafe_code.Name = "cafe_code"
        ' 
        ' cafe_name
        ' 
        cafe_name.HeaderText = "Description"
        cafe_name.MinimumWidth = 6
        cafe_name.Name = "cafe_name"
        ' 
        ' size
        ' 
        size.HeaderText = "Size"
        size.MinimumWidth = 6
        size.Name = "size"
        ' 
        ' price
        ' 
        price.HeaderText = "Price"
        price.MinimumWidth = 6
        price.Name = "price"
        ' 
        ' status
        ' 
        status.HeaderText = "Status"
        status.MinimumWidth = 6
        status.Name = "status"
        status.Resizable = DataGridViewTriState.True
        status.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' img
        ' 
        img.HeaderText = "Picture"
        img.MinimumWidth = 6
        img.Name = "img"
        img.ReadOnly = True
        img.Visible = False
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = Color.Transparent
        btn_close.ErrorImage = CType(resources.GetObject("btn_close.ErrorImage"), Image)
        btn_close.Image = CType(resources.GetObject("btn_close.Image"), Image)
        btn_close.Location = New Point(875, -1)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(28, 27)
        btn_close.SizeMode = PictureBoxSizeMode.Zoom
        btn_close.TabIndex = 24
        btn_close.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(22, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 31)
        Label2.TabIndex = 25
        Label2.Text = "ຈັດການເມນູຄາເຟ່"
        ' 
        ' Cafe_ManageList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(902, 634)
        Controls.Add(Label2)
        Controls.Add(btn_close)
        Controls.Add(dgv_manage)
        Controls.Add(btn_s)
        Controls.Add(btn_Addnew)
        Controls.Add(txt_search)
        FormBorderStyle = FormBorderStyle.None
        Name = "Cafe_ManageList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cafe_ManageList"
        CType(dgv_manage, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_close, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_Addnew As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_s As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgv_manage As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btn_close As PictureBox
    Friend WithEvents cafe_code As DataGridViewTextBoxColumn
    Friend WithEvents cafe_name As DataGridViewTextBoxColumn
    Friend WithEvents size As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewCheckBoxColumn
    Friend WithEvents img As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
