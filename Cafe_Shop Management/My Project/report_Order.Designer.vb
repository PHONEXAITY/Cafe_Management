<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report_Order
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(report_Order))
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        OrdermanageTableAdapterBindingSource = New BindingSource(components)
        TableAdapterManagerBindingSource = New BindingSource(components)
        CafeManageSystemDataSetBindingSource = New BindingSource(components)
        ToolStrip1 = New ToolStrip()
        ToolStripButton1 = New ToolStripDropDownButton()
        Report_Cafe = New ToolStripMenuItem()
        rp_Order = New ToolStripMenuItem()
        PrintToolStripButton = New ToolStripButton()
        toolStripSeparator = New ToolStripSeparator()
        CutToolStripButton = New ToolStripButton()
        CopyToolStripButton = New ToolStripButton()
        PasteToolStripButton = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        HelpToolStripButton = New ToolStripButton()
        page_setup = New ToolStripButton()
        PrintDocument1 = New Printing.PrintDocument()
        PageSetupDialog1 = New PageSetupDialog()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(OrdermanageTableAdapterBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(TableAdapterManagerBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(CafeManageSystemDataSetBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Guna2DataGridView1.ColumnHeadersHeight = 22
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(57, 64)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.RowHeadersWidth = 51
        Guna2DataGridView1.RowTemplate.Height = 29
        Guna2DataGridView1.Size = New Size(758, 512)
        Guna2DataGridView1.TabIndex = 0
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 22
        Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' OrdermanageTableAdapterBindingSource
        ' 
        OrdermanageTableAdapterBindingSource.DataSource = GetType(Cafe_Shop_Management.Cafe_ManageSystemDataSetTableAdapters.Order_manageTableAdapter)
        ' 
        ' TableAdapterManagerBindingSource
        ' 
        TableAdapterManagerBindingSource.DataSource = GetType(Cafe_Shop_Management.Cafe_ManageSystemDataSetTableAdapters.TableAdapterManager)
        ' 
        ' CafeManageSystemDataSetBindingSource
        ' 
        CafeManageSystemDataSetBindingSource.DataSource = GetType(Cafe_Shop_Management.Cafe_ManageSystemDataSet)
        CafeManageSystemDataSetBindingSource.Position = 0
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1, PrintToolStripButton, toolStripSeparator, CutToolStripButton, CopyToolStripButton, PasteToolStripButton, toolStripSeparator1, HelpToolStripButton, page_setup})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(875, 35)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DropDownItems.AddRange(New ToolStripItem() {Report_Cafe, rp_Order})
        ToolStripButton1.Font = New Font("Phetsarath OT", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(51, 32)
        ToolStripButton1.Text = " "
        ' 
        ' Report_Cafe
        ' 
        Report_Cafe.Font = New Font("Phetsarath OT", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Report_Cafe.Name = "Report_Cafe"
        Report_Cafe.Size = New Size(211, 32)
        Report_Cafe.Text = "ລາຍງານເມນູຄາເຟ່"
        ' 
        ' rp_Order
        ' 
        rp_Order.Font = New Font("Phetsarath OT", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        rp_Order.Name = "rp_Order"
        rp_Order.Size = New Size(211, 32)
        rp_Order.Text = "ລາຍງານການສັ່ງຊື້"
        ' 
        ' PrintToolStripButton
        ' 
        PrintToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), Image)
        PrintToolStripButton.ImageTransparentColor = Color.Magenta
        PrintToolStripButton.Name = "PrintToolStripButton"
        PrintToolStripButton.Size = New Size(29, 32)
        PrintToolStripButton.Text = "&Print"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 35)
        ' 
        ' CutToolStripButton
        ' 
        CutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), Image)
        CutToolStripButton.ImageTransparentColor = Color.Magenta
        CutToolStripButton.Name = "CutToolStripButton"
        CutToolStripButton.Size = New Size(29, 32)
        CutToolStripButton.Text = "C&ut"
        ' 
        ' CopyToolStripButton
        ' 
        CopyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), Image)
        CopyToolStripButton.ImageTransparentColor = Color.Magenta
        CopyToolStripButton.Name = "CopyToolStripButton"
        CopyToolStripButton.Size = New Size(29, 32)
        CopyToolStripButton.Text = "&Copy"
        ' 
        ' PasteToolStripButton
        ' 
        PasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), Image)
        PasteToolStripButton.ImageTransparentColor = Color.Magenta
        PasteToolStripButton.Name = "PasteToolStripButton"
        PasteToolStripButton.Size = New Size(29, 32)
        PasteToolStripButton.Text = "&Paste"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 35)
        ' 
        ' HelpToolStripButton
        ' 
        HelpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), Image)
        HelpToolStripButton.ImageTransparentColor = Color.Magenta
        HelpToolStripButton.Name = "HelpToolStripButton"
        HelpToolStripButton.Size = New Size(29, 32)
        HelpToolStripButton.Text = "He&lp"
        ' 
        ' page_setup
        ' 
        page_setup.Alignment = ToolStripItemAlignment.Right
        page_setup.Font = New Font("Phetsarath OT", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        page_setup.Image = CType(resources.GetObject("page_setup.Image"), Image)
        page_setup.ImageTransparentColor = Color.Magenta
        page_setup.Name = "page_setup"
        page_setup.Size = New Size(103, 32)
        page_setup.Text = "ຕັ້ງໜ້າເຈ້ຍ"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' report_Order
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(875, 605)
        Controls.Add(ToolStrip1)
        Controls.Add(Guna2DataGridView1)
        Name = "report_Order"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(OrdermanageTableAdapterBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(TableAdapterManagerBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(CafeManageSystemDataSetBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TableAdapterManagerBindingSource As BindingSource
    Friend WithEvents OrdermanageTableAdapterBindingSource As BindingSource
    Friend WithEvents CafeManageSystemDataSetBindingSource As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripDropDownButton
    Friend WithEvents Report_Cafe As ToolStripMenuItem
    Friend WithEvents rp_Order As ToolStripMenuItem
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents page_setup As ToolStripButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
