<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_sales))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RdCustomer = New System.Windows.Forms.RadioButton
        Me.RDid = New System.Windows.Forms.RadioButton
        Me.eror = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridSalesdetails = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridSales = New System.Windows.Forms.DataGridView
        Me.VItems = New System.Windows.Forms.Button
        Me.PurReturn = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Search = New System.Windows.Forms.TextBox
        Me.SearchSal = New System.Windows.Forms.Button
        Me.Refresh = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridSalesdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RdCustomer)
        Me.GroupBox3.Controls.Add(Me.RDid)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(226, 35)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        '
        'RdCustomer
        '
        Me.RdCustomer.AutoSize = True
        Me.RdCustomer.Location = New System.Drawing.Point(105, 12)
        Me.RdCustomer.Name = "RdCustomer"
        Me.RdCustomer.Size = New System.Drawing.Size(115, 17)
        Me.RdCustomer.TabIndex = 15
        Me.RdCustomer.Text = "Search By Supplier"
        Me.RdCustomer.UseVisualStyleBackColor = True
        '
        'RDid
        '
        Me.RDid.AutoSize = True
        Me.RDid.Checked = True
        Me.RDid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RDid.Location = New System.Drawing.Point(6, 12)
        Me.RDid.Name = "RDid"
        Me.RDid.Size = New System.Drawing.Size(88, 17)
        Me.RDid.TabIndex = 14
        Me.RDid.TabStop = True
        Me.RDid.Text = "Search By ID"
        Me.RDid.UseVisualStyleBackColor = True
        '
        'eror
        '
        Me.eror.AutoSize = True
        Me.eror.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eror.Location = New System.Drawing.Point(261, 55)
        Me.eror.Name = "eror"
        Me.eror.Size = New System.Drawing.Size(43, 12)
        Me.eror.TabIndex = 22
        Me.eror.Text = "Label2"
        Me.eror.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridSalesdetails)
        Me.GroupBox2.Location = New System.Drawing.Point(578, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 331)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sales Details"
        '
        'GridSalesdetails
        '
        Me.GridSalesdetails.AllowUserToAddRows = False
        Me.GridSalesdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSalesdetails.Location = New System.Drawing.Point(6, 14)
        Me.GridSalesdetails.Name = "GridSalesdetails"
        Me.GridSalesdetails.Size = New System.Drawing.Size(467, 311)
        Me.GridSalesdetails.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridSales)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 331)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "All Sales"
        '
        'GridSales
        '
        Me.GridSales.AllowUserToAddRows = False
        Me.GridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSales.Location = New System.Drawing.Point(6, 14)
        Me.GridSales.Name = "GridSales"
        Me.GridSales.Size = New System.Drawing.Size(467, 311)
        Me.GridSales.TabIndex = 1
        '
        'VItems
        '
        Me.VItems.Location = New System.Drawing.Point(497, 320)
        Me.VItems.Name = "VItems"
        Me.VItems.Size = New System.Drawing.Size(75, 23)
        Me.VItems.TabIndex = 19
        Me.VItems.Text = "View Items"
        Me.VItems.UseVisualStyleBackColor = True
        '
        'PurReturn
        '
        Me.PurReturn.Location = New System.Drawing.Point(497, 359)
        Me.PurReturn.Name = "PurReturn"
        Me.PurReturn.Size = New System.Drawing.Size(75, 23)
        Me.PurReturn.TabIndex = 17
        Me.PurReturn.Text = "Return"
        Me.PurReturn.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(983, 14)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 16
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 22)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Search:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(147, 14)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(196, 20)
        Me.Search.TabIndex = 14
        '
        'SearchSal
        '
        Me.SearchSal.Location = New System.Drawing.Point(349, 12)
        Me.SearchSal.Name = "SearchSal"
        Me.SearchSal.Size = New System.Drawing.Size(108, 23)
        Me.SearchSal.TabIndex = 13
        Me.SearchSal.Text = "Search Purchase"
        Me.SearchSal.UseVisualStyleBackColor = True
        '
        'Refresh
        '
        Me.Refresh.BackgroundImage = CType(resources.GetObject("Refresh.BackgroundImage"), System.Drawing.Image)
        Me.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Refresh.Location = New System.Drawing.Point(508, 80)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(54, 43)
        Me.Refresh.TabIndex = 18
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'View_sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 424)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.eror)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VItems)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.PurReturn)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.SearchSal)
        Me.MaximizeBox = False
        Me.Name = "View_sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Sales"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridSalesdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RdCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents RDid As System.Windows.Forms.RadioButton
    Friend WithEvents eror As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridSalesdetails As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridSales As System.Windows.Forms.DataGridView
    Friend WithEvents VItems As System.Windows.Forms.Button
    Friend WithEvents Refresh As System.Windows.Forms.Button
    Friend WithEvents PurReturn As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Search As System.Windows.Forms.TextBox
    Friend WithEvents SearchSal As System.Windows.Forms.Button
End Class
