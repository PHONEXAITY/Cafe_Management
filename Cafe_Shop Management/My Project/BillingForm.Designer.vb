<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingForm
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
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(BillingForm))
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        DataGridView1 = New DataGridView()
        btnPrint = New Guna.UI2.WinForms.Guna2Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        setup = New Guna.UI2.WinForms.Guna2Button()
        PageSetupDialog1 = New PageSetupDialog()
        btn_close = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_close, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(23, 96)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(531, 585)
        DataGridView1.TabIndex = 0
        ' 
        ' btnPrint
        ' 
        btnPrint.CustomizableEdges = CustomizableEdges13
        btnPrint.DisabledState.BorderColor = Color.DarkGray
        btnPrint.DisabledState.CustomBorderColor = Color.DarkGray
        btnPrint.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnPrint.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnPrint.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(408, 690)
        btnPrint.Name = "btnPrint"
        btnPrint.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btnPrint.Size = New Size(146, 56)
        btnPrint.TabIndex = 1
        btnPrint.Text = "Print"
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
        ' setup
        ' 
        setup.CustomizableEdges = CustomizableEdges15
        setup.DisabledState.BorderColor = Color.DarkGray
        setup.DisabledState.CustomBorderColor = Color.DarkGray
        setup.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        setup.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        setup.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        setup.ForeColor = Color.White
        setup.Location = New Point(226, 690)
        setup.Name = "setup"
        setup.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        setup.Size = New Size(146, 56)
        setup.TabIndex = 2
        setup.Text = "Page Setup"
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = Color.Transparent
        btn_close.ErrorImage = CType(resources.GetObject("btn_close.ErrorImage"), Image)
        btn_close.Image = CType(resources.GetObject("btn_close.Image"), Image)
        btn_close.Location = New Point(550, -1)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(28, 27)
        btn_close.SizeMode = PictureBoxSizeMode.Zoom
        btn_close.TabIndex = 24
        btn_close.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Phetsarath OT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(103, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 36)
        Label1.TabIndex = 25
        Label1.Text = "ໃບບິນສິນຄ້າ"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(33, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 72)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' BillingForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(577, 758)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btn_close)
        Controls.Add(setup)
        Controls.Add(btnPrint)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "BillingForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BillingForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_close, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents setup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents btn_close As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
