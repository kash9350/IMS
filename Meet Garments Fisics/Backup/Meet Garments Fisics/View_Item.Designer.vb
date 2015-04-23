<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Item))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RdItem = New System.Windows.Forms.RadioButton
        Me.RDid = New System.Windows.Forms.RadioButton
        Me.eror = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridItem = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Search = New System.Windows.Forms.TextBox
        Me.SearchOrd = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.Refresh = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RdItem)
        Me.GroupBox3.Controls.Add(Me.RDid)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(254, 35)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        '
        'RdItem
        '
        Me.RdItem.AutoSize = True
        Me.RdItem.Location = New System.Drawing.Point(120, 12)
        Me.RdItem.Name = "RdItem"
        Me.RdItem.Size = New System.Drawing.Size(128, 17)
        Me.RdItem.TabIndex = 15
        Me.RdItem.Text = "Search By Item Name"
        Me.RdItem.UseVisualStyleBackColor = True
        '
        'RDid
        '
        Me.RDid.AutoSize = True
        Me.RDid.Checked = True
        Me.RDid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RDid.Location = New System.Drawing.Point(6, 12)
        Me.RDid.Name = "RDid"
        Me.RDid.Size = New System.Drawing.Size(109, 17)
        Me.RDid.TabIndex = 14
        Me.RDid.TabStop = True
        Me.RDid.Text = "Search By Item Id"
        Me.RDid.UseVisualStyleBackColor = True
        '
        'eror
        '
        Me.eror.AutoSize = True
        Me.eror.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eror.Location = New System.Drawing.Point(311, 61)
        Me.eror.Name = "eror"
        Me.eror.Size = New System.Drawing.Size(43, 12)
        Me.eror.TabIndex = 42
        Me.eror.Text = "Label2"
        Me.eror.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridItem)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 331)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Details"
        '
        'GridItem
        '
        Me.GridItem.AllowUserToAddRows = False
        Me.GridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridItem.Location = New System.Drawing.Point(6, 14)
        Me.GridItem.Name = "GridItem"
        Me.GridItem.Size = New System.Drawing.Size(467, 311)
        Me.GridItem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 22)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Search:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(158, 20)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(196, 20)
        Me.Search.TabIndex = 36
        '
        'SearchOrd
        '
        Me.SearchOrd.Location = New System.Drawing.Point(360, 18)
        Me.SearchOrd.Name = "SearchOrd"
        Me.SearchOrd.Size = New System.Drawing.Size(108, 23)
        Me.SearchOrd.TabIndex = 35
        Me.SearchOrd.Text = "Search Item"
        Me.SearchOrd.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(519, 18)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 44
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Refresh
        '
        Me.Refresh.BackgroundImage = CType(resources.GetObject("Refresh.BackgroundImage"), System.Drawing.Image)
        Me.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Refresh.Location = New System.Drawing.Point(519, 86)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(54, 43)
        Me.Refresh.TabIndex = 39
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'View_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(602, 436)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.eror)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.SearchOrd)
        Me.MaximizeBox = False
        Me.Name = "View_Item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Sales Item Stock"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RdItem As System.Windows.Forms.RadioButton
    Friend WithEvents RDid As System.Windows.Forms.RadioButton
    Friend WithEvents eror As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridItem As System.Windows.Forms.DataGridView
    Friend WithEvents Refresh As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Search As System.Windows.Forms.TextBox
    Friend WithEvents SearchOrd As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
