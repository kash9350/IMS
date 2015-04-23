<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseReturnView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseReturnView))
        Me.eror = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridReturn = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridReturnDetails = New System.Windows.Forms.DataGridView
        Me.Refresh = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Search = New System.Windows.Forms.TextBox
        Me.SearchPur = New System.Windows.Forms.Button
        Me.RDid = New System.Windows.Forms.RadioButton
        Me.RdSup = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridReturnDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'eror
        '
        Me.eror.AutoSize = True
        Me.eror.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eror.Location = New System.Drawing.Point(278, 57)
        Me.eror.Name = "eror"
        Me.eror.Size = New System.Drawing.Size(43, 12)
        Me.eror.TabIndex = 35
        Me.eror.Text = "Label2"
        Me.eror.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridReturn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 331)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Returns"
        '
        'GridReturn
        '
        Me.GridReturn.AllowUserToAddRows = False
        Me.GridReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridReturn.Location = New System.Drawing.Point(6, 14)
        Me.GridReturn.Name = "GridReturn"
        Me.GridReturn.Size = New System.Drawing.Size(467, 311)
        Me.GridReturn.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(497, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "View Items"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridReturnDetails)
        Me.GroupBox2.Location = New System.Drawing.Point(578, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(479, 331)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Return Details"
        '
        'GridReturnDetails
        '
        Me.GridReturnDetails.AllowUserToAddRows = False
        Me.GridReturnDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridReturnDetails.Location = New System.Drawing.Point(6, 14)
        Me.GridReturnDetails.Name = "GridReturnDetails"
        Me.GridReturnDetails.Size = New System.Drawing.Size(467, 311)
        Me.GridReturnDetails.TabIndex = 1
        '
        'Refresh
        '
        Me.Refresh.BackgroundImage = CType(resources.GetObject("Refresh.BackgroundImage"), System.Drawing.Image)
        Me.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Refresh.Location = New System.Drawing.Point(508, 80)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(54, 43)
        Me.Refresh.TabIndex = 31
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(986, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 37
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
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Search:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(147, 14)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(196, 20)
        Me.Search.TabIndex = 28
        '
        'SearchPur
        '
        Me.SearchPur.Location = New System.Drawing.Point(349, 12)
        Me.SearchPur.Name = "SearchPur"
        Me.SearchPur.Size = New System.Drawing.Size(93, 23)
        Me.SearchPur.TabIndex = 29
        Me.SearchPur.Text = "Search"
        Me.SearchPur.UseVisualStyleBackColor = True
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
        'RdSup
        '
        Me.RdSup.AutoSize = True
        Me.RdSup.Location = New System.Drawing.Point(105, 12)
        Me.RdSup.Name = "RdSup"
        Me.RdSup.Size = New System.Drawing.Size(136, 17)
        Me.RdSup.TabIndex = 15
        Me.RdSup.Text = "Search By Purchase ID"
        Me.RdSup.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RdSup)
        Me.GroupBox3.Controls.Add(Me.RDid)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(254, 35)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        '
        'PurchaseReturnView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1073, 424)
        Me.Controls.Add(Me.eror)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.SearchPur)
        Me.MaximizeBox = False
        Me.Name = "PurchaseReturnView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PurchaseReturnView"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridReturnDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents eror As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridReturn As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridReturnDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Refresh As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Search As System.Windows.Forms.TextBox
    Friend WithEvents SearchPur As System.Windows.Forms.Button
    Friend WithEvents RDid As System.Windows.Forms.RadioButton
    Friend WithEvents RdSup As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
