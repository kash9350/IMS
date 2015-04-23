<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewCustomer))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.eror2 = New System.Windows.Forms.Label
        Me.CityCheck = New System.Windows.Forms.CheckBox
        Me.NameCheck = New System.Windows.Forms.CheckBox
        Me.CityDdl = New System.Windows.Forms.ComboBox
        Me.CityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SDPdatabaseDataSet6 = New Meet_Garments_Fisics.SDPdatabaseDataSet6
        Me.searchbtn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.searchTxtbox = New System.Windows.Forms.TextBox
        Me.Cls = New System.Windows.Forms.Button
        Me.dltCst = New System.Windows.Forms.Button
        Me.updtCst = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CstGridView = New System.Windows.Forms.DataGridView
        Me.CityTableAdapter = New Meet_Garments_Fisics.SDPdatabaseDataSet6TableAdapters.CityTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDPdatabaseDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CstGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.eror2)
        Me.GroupBox1.Controls.Add(Me.CityCheck)
        Me.GroupBox1.Controls.Add(Me.NameCheck)
        Me.GroupBox1.Controls.Add(Me.CityDdl)
        Me.GroupBox1.Controls.Add(Me.searchbtn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.searchTxtbox)
        Me.GroupBox1.Controls.Add(Me.Cls)
        Me.GroupBox1.Controls.Add(Me.dltCst)
        Me.GroupBox1.Controls.Add(Me.updtCst)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(875, 104)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search, Update and Delete"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(818, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 44)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = True
        '
        'eror2
        '
        Me.eror2.AutoSize = True
        Me.eror2.Location = New System.Drawing.Point(414, 75)
        Me.eror2.Name = "eror2"
        Me.eror2.Size = New System.Drawing.Size(46, 14)
        Me.eror2.TabIndex = 23
        Me.eror2.Text = "Label2"
        Me.eror2.Visible = False
        '
        'CityCheck
        '
        Me.CityCheck.AutoSize = True
        Me.CityCheck.Location = New System.Drawing.Point(135, 48)
        Me.CityCheck.Name = "CityCheck"
        Me.CityCheck.Size = New System.Drawing.Size(112, 18)
        Me.CityCheck.TabIndex = 22
        Me.CityCheck.Text = "Search By City"
        Me.CityCheck.UseVisualStyleBackColor = True
        '
        'NameCheck
        '
        Me.NameCheck.AutoSize = True
        Me.NameCheck.Checked = True
        Me.NameCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NameCheck.Location = New System.Drawing.Point(6, 48)
        Me.NameCheck.Name = "NameCheck"
        Me.NameCheck.Size = New System.Drawing.Size(123, 18)
        Me.NameCheck.TabIndex = 21
        Me.NameCheck.Text = "Search By Name"
        Me.NameCheck.UseVisualStyleBackColor = True
        '
        'CityDdl
        '
        Me.CityDdl.DataSource = Me.CityBindingSource
        Me.CityDdl.DisplayMember = "City_name"
        Me.CityDdl.Enabled = False
        Me.CityDdl.FormattingEnabled = True
        Me.CityDdl.Location = New System.Drawing.Point(367, 17)
        Me.CityDdl.Name = "CityDdl"
        Me.CityDdl.Size = New System.Drawing.Size(156, 22)
        Me.CityDdl.TabIndex = 19
        Me.CityDdl.ValueMember = "City_id"
        '
        'CityBindingSource
        '
        Me.CityBindingSource.DataMember = "City"
        Me.CityBindingSource.DataSource = Me.SDPdatabaseDataSet6
        '
        'SDPdatabaseDataSet6
        '
        Me.SDPdatabaseDataSet6.DataSetName = "SDPdatabaseDataSet6"
        Me.SDPdatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'searchbtn
        '
        Me.searchbtn.Location = New System.Drawing.Point(529, 17)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(75, 23)
        Me.searchbtn.TabIndex = 13
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Customer Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'searchTxtbox
        '
        Me.searchTxtbox.Location = New System.Drawing.Point(121, 18)
        Me.searchTxtbox.Name = "searchTxtbox"
        Me.searchTxtbox.Size = New System.Drawing.Size(240, 21)
        Me.searchTxtbox.TabIndex = 10
        '
        'Cls
        '
        Me.Cls.Location = New System.Drawing.Point(794, 17)
        Me.Cls.Name = "Cls"
        Me.Cls.Size = New System.Drawing.Size(75, 23)
        Me.Cls.TabIndex = 9
        Me.Cls.Text = "Close"
        Me.Cls.UseVisualStyleBackColor = True
        '
        'dltCst
        '
        Me.dltCst.Location = New System.Drawing.Point(713, 18)
        Me.dltCst.Name = "dltCst"
        Me.dltCst.Size = New System.Drawing.Size(75, 23)
        Me.dltCst.TabIndex = 8
        Me.dltCst.Text = "Delete"
        Me.dltCst.UseVisualStyleBackColor = True
        '
        'updtCst
        '
        Me.updtCst.Location = New System.Drawing.Point(632, 18)
        Me.updtCst.Name = "updtCst"
        Me.updtCst.Size = New System.Drawing.Size(75, 23)
        Me.updtCst.TabIndex = 7
        Me.updtCst.Text = "Update"
        Me.updtCst.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.CstGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(875, 275)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Customer"
        '
        'CstGridView
        '
        Me.CstGridView.AllowUserToAddRows = False
        Me.CstGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CstGridView.Location = New System.Drawing.Point(6, 19)
        Me.CstGridView.Name = "CstGridView"
        Me.CstGridView.Size = New System.Drawing.Size(863, 252)
        Me.CstGridView.TabIndex = 1
        '
        'CityTableAdapter
        '
        Me.CityTableAdapter.ClearBeforeFill = True
        '
        'ViewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(903, 407)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "ViewCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDPdatabaseDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CstGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents searchTxtbox As System.Windows.Forms.TextBox
    Friend WithEvents Cls As System.Windows.Forms.Button
    Friend WithEvents dltCst As System.Windows.Forms.Button
    Friend WithEvents updtCst As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CstGridView As System.Windows.Forms.DataGridView
    Friend WithEvents searchbtn As System.Windows.Forms.Button
    Friend WithEvents CityDdl As System.Windows.Forms.ComboBox
    Friend WithEvents CityCheck As System.Windows.Forms.CheckBox
    Friend WithEvents NameCheck As System.Windows.Forms.CheckBox
    Friend WithEvents SDPdatabaseDataSet6 As Meet_Garments_Fisics.SDPdatabaseDataSet6
    Friend WithEvents CityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CityTableAdapter As Meet_Garments_Fisics.SDPdatabaseDataSet6TableAdapters.CityTableAdapter
    Friend WithEvents eror2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
