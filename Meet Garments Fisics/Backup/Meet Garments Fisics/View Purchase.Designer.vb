<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Purchase
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Purchase))
        Me.SearchPur = New System.Windows.Forms.Button
        Me.Search = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.PurReturn = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridPurchase = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridPurchaseDetails = New System.Windows.Forms.DataGridView
        Me.eror = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RdSup = New System.Windows.Forms.RadioButton
        Me.RDid = New System.Windows.Forms.RadioButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Refresh = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridPurchaseDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchPur
        '
        Me.SearchPur.Location = New System.Drawing.Point(349, 12)
        Me.SearchPur.Name = "SearchPur"
        Me.SearchPur.Size = New System.Drawing.Size(108, 23)
        Me.SearchPur.TabIndex = 3
        Me.SearchPur.Text = "Search Purchase"
        Me.SearchPur.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(147, 14)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(196, 20)
        Me.Search.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(986, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 16
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'PurReturn
        '
        Me.PurReturn.Location = New System.Drawing.Point(497, 359)
        Me.PurReturn.Name = "PurReturn"
        Me.PurReturn.Size = New System.Drawing.Size(75, 23)
        Me.PurReturn.TabIndex = 5
        Me.PurReturn.Text = "Return"
        Me.PurReturn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(497, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "View Items"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridPurchase)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 331)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "All Purchase"
        '
        'GridPurchase
        '
        Me.GridPurchase.AllowUserToAddRows = False
        Me.GridPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPurchase.Location = New System.Drawing.Point(6, 14)
        Me.GridPurchase.Name = "GridPurchase"
        Me.GridPurchase.Size = New System.Drawing.Size(467, 311)
        Me.GridPurchase.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridPurchaseDetails)
        Me.GroupBox2.Location = New System.Drawing.Point(578, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(479, 331)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Purchase Details"
        '
        'GridPurchaseDetails
        '
        Me.GridPurchaseDetails.AllowUserToAddRows = False
        Me.GridPurchaseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPurchaseDetails.Location = New System.Drawing.Point(6, 14)
        Me.GridPurchaseDetails.Name = "GridPurchaseDetails"
        Me.GridPurchaseDetails.Size = New System.Drawing.Size(467, 311)
        Me.GridPurchaseDetails.TabIndex = 1
        '
        'eror
        '
        Me.eror.AutoSize = True
        Me.eror.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eror.Location = New System.Drawing.Point(261, 55)
        Me.eror.Name = "eror"
        Me.eror.Size = New System.Drawing.Size(43, 12)
        Me.eror.TabIndex = 11
        Me.eror.Text = "Label2"
        Me.eror.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RdSup)
        Me.GroupBox3.Controls.Add(Me.RDid)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(226, 35)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'RdSup
        '
        Me.RdSup.AutoSize = True
        Me.RdSup.Location = New System.Drawing.Point(105, 12)
        Me.RdSup.Name = "RdSup"
        Me.RdSup.Size = New System.Drawing.Size(115, 17)
        Me.RdSup.TabIndex = 15
        Me.RdSup.Text = "Search By Supplier"
        Me.RdSup.UseVisualStyleBackColor = True
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
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Refresh
        '
        Me.Refresh.BackgroundImage = CType(resources.GetObject("Refresh.BackgroundImage"), System.Drawing.Image)
        Me.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Refresh.Location = New System.Drawing.Point(508, 80)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(54, 43)
        Me.Refresh.TabIndex = 6
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'View_Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1073, 424)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.eror)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.PurReturn)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.SearchPur)
        Me.MaximizeBox = False
        Me.Name = "View_Purchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Purchase"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridPurchaseDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchPur As System.Windows.Forms.Button
    Friend WithEvents Search As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents PurReturn As System.Windows.Forms.Button
    Friend WithEvents Refresh As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPurchase As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPurchaseDetails As System.Windows.Forms.DataGridView
    Friend WithEvents eror As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RdSup As System.Windows.Forms.RadioButton
    Friend WithEvents RDid As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
