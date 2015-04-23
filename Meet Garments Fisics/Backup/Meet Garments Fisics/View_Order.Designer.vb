<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Order))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RdOrder = New System.Windows.Forms.RadioButton
        Me.RDid = New System.Windows.Forms.RadioButton
        Me.eror = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridOrderdetails = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridOrder = New System.Windows.Forms.DataGridView
        Me.VItems = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Search = New System.Windows.Forms.TextBox
        Me.SearchOrd = New System.Windows.Forms.Button
        Me.Refresh = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridOrderdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RdOrder)
        Me.GroupBox3.Controls.Add(Me.RDid)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(235, 35)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        '
        'RdOrder
        '
        Me.RdOrder.AutoSize = True
        Me.RdOrder.Location = New System.Drawing.Point(105, 12)
        Me.RdOrder.Name = "RdOrder"
        Me.RdOrder.Size = New System.Drawing.Size(121, 17)
        Me.RdOrder.TabIndex = 15
        Me.RdOrder.Text = "Search By Customer"
        Me.RdOrder.UseVisualStyleBackColor = True
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
        Me.eror.Location = New System.Drawing.Point(300, 57)
        Me.eror.Name = "eror"
        Me.eror.Size = New System.Drawing.Size(43, 12)
        Me.eror.TabIndex = 33
        Me.eror.Text = "Label2"
        Me.eror.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridOrderdetails)
        Me.GroupBox2.Location = New System.Drawing.Point(578, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 331)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order Details"
        '
        'GridOrderdetails
        '
        Me.GridOrderdetails.AllowUserToAddRows = False
        Me.GridOrderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridOrderdetails.Location = New System.Drawing.Point(6, 14)
        Me.GridOrderdetails.Name = "GridOrderdetails"
        Me.GridOrderdetails.Size = New System.Drawing.Size(467, 311)
        Me.GridOrderdetails.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridOrder)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 331)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "All Orders"
        '
        'GridOrder
        '
        Me.GridOrder.AllowUserToAddRows = False
        Me.GridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridOrder.Location = New System.Drawing.Point(6, 14)
        Me.GridOrder.Name = "GridOrder"
        Me.GridOrder.Size = New System.Drawing.Size(467, 311)
        Me.GridOrder.TabIndex = 1
        '
        'VItems
        '
        Me.VItems.Location = New System.Drawing.Point(497, 279)
        Me.VItems.Name = "VItems"
        Me.VItems.Size = New System.Drawing.Size(75, 23)
        Me.VItems.TabIndex = 30
        Me.VItems.Text = "View Items"
        Me.VItems.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(983, 14)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 27
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
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Search:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(147, 14)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(196, 20)
        Me.Search.TabIndex = 25
        '
        'SearchOrd
        '
        Me.SearchOrd.Location = New System.Drawing.Point(349, 14)
        Me.SearchOrd.Name = "SearchOrd"
        Me.SearchOrd.Size = New System.Drawing.Size(108, 23)
        Me.SearchOrd.TabIndex = 24
        Me.SearchOrd.Text = "Search Order"
        Me.SearchOrd.UseVisualStyleBackColor = True
        '
        'Refresh
        '
        Me.Refresh.BackgroundImage = CType(resources.GetObject("Refresh.BackgroundImage"), System.Drawing.Image)
        Me.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Refresh.Location = New System.Drawing.Point(508, 80)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(54, 43)
        Me.Refresh.TabIndex = 29
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(497, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Change Status"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(497, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 43)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Generate Order"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'View_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 424)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.eror)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VItems)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.SearchOrd)
        Me.MaximizeBox = False
        Me.Name = "View_Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Order Details"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridOrderdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RdOrder As System.Windows.Forms.RadioButton
    Friend WithEvents RDid As System.Windows.Forms.RadioButton
    Friend WithEvents eror As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridOrderdetails As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridOrder As System.Windows.Forms.DataGridView
    Friend WithEvents VItems As System.Windows.Forms.Button
    Friend WithEvents Refresh As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Search As System.Windows.Forms.TextBox
    Friend WithEvents SearchOrd As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
