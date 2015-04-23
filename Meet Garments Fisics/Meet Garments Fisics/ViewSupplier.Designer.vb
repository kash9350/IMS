<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSupplier))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SupGridView = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CityCheck = New System.Windows.Forms.CheckBox
        Me.NameCheck = New System.Windows.Forms.CheckBox
        Me.CityDDL = New System.Windows.Forms.ComboBox
        Me.CityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Supplier_city = New Meet_Garments_Fisics.Supplier_city
        Me.Label1 = New System.Windows.Forms.Label
        Me.srchCst = New System.Windows.Forms.Button
        Me.searchTxtbox = New System.Windows.Forms.TextBox
        Me.Cls = New System.Windows.Forms.Button
        Me.dltCst = New System.Windows.Forms.Button
        Me.updtCst = New System.Windows.Forms.Button
        Me.CityTableAdapter = New Meet_Garments_Fisics.Supplier_cityTableAdapters.CityTableAdapter
        Me.eror = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.SupGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Supplier_city, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.SupGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 275)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Supplier"
        '
        'SupGridView
        '
        Me.SupGridView.AllowUserToAddRows = False
        Me.SupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupGridView.Location = New System.Drawing.Point(6, 19)
        Me.SupGridView.Name = "SupGridView"
        Me.SupGridView.Size = New System.Drawing.Size(845, 252)
        Me.SupGridView.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.eror)
        Me.GroupBox2.Controls.Add(Me.CityCheck)
        Me.GroupBox2.Controls.Add(Me.NameCheck)
        Me.GroupBox2.Controls.Add(Me.CityDDL)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.srchCst)
        Me.GroupBox2.Controls.Add(Me.searchTxtbox)
        Me.GroupBox2.Controls.Add(Me.Cls)
        Me.GroupBox2.Controls.Add(Me.dltCst)
        Me.GroupBox2.Controls.Add(Me.updtCst)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(857, 104)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search, Update and Delete"
        '
        'CityCheck
        '
        Me.CityCheck.AutoSize = True
        Me.CityCheck.Location = New System.Drawing.Point(135, 46)
        Me.CityCheck.Name = "CityCheck"
        Me.CityCheck.Size = New System.Drawing.Size(112, 18)
        Me.CityCheck.TabIndex = 20
        Me.CityCheck.Text = "Search By City"
        Me.CityCheck.UseVisualStyleBackColor = True
        '
        'NameCheck
        '
        Me.NameCheck.AutoSize = True
        Me.NameCheck.Checked = True
        Me.NameCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NameCheck.Location = New System.Drawing.Point(6, 46)
        Me.NameCheck.Name = "NameCheck"
        Me.NameCheck.Size = New System.Drawing.Size(123, 18)
        Me.NameCheck.TabIndex = 19
        Me.NameCheck.Text = "Search By Name"
        Me.NameCheck.UseVisualStyleBackColor = True
        '
        'CityDDL
        '
        Me.CityDDL.DataSource = Me.CityBindingSource
        Me.CityDDL.DisplayMember = "City_name"
        Me.CityDDL.Enabled = False
        Me.CityDDL.FormattingEnabled = True
        Me.CityDDL.Location = New System.Drawing.Point(357, 17)
        Me.CityDDL.Name = "CityDDL"
        Me.CityDDL.Size = New System.Drawing.Size(156, 22)
        Me.CityDDL.TabIndex = 18
        Me.CityDDL.ValueMember = "City_id"
        '
        'CityBindingSource
        '
        Me.CityBindingSource.DataMember = "City"
        Me.CityBindingSource.DataSource = Me.Supplier_city
        '
        'Supplier_city
        '
        Me.Supplier_city.DataSetName = "Supplier_city"
        Me.Supplier_city.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Supplier Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'srchCst
        '
        Me.srchCst.Location = New System.Drawing.Point(520, 16)
        Me.srchCst.Name = "srchCst"
        Me.srchCst.Size = New System.Drawing.Size(75, 23)
        Me.srchCst.TabIndex = 16
        Me.srchCst.Text = "Search"
        Me.srchCst.UseVisualStyleBackColor = True
        '
        'searchTxtbox
        '
        Me.searchTxtbox.Location = New System.Drawing.Point(121, 17)
        Me.searchTxtbox.Name = "searchTxtbox"
        Me.searchTxtbox.Size = New System.Drawing.Size(230, 21)
        Me.searchTxtbox.TabIndex = 15
        '
        'Cls
        '
        Me.Cls.Location = New System.Drawing.Point(776, 16)
        Me.Cls.Name = "Cls"
        Me.Cls.Size = New System.Drawing.Size(75, 23)
        Me.Cls.TabIndex = 14
        Me.Cls.Text = "Close"
        Me.Cls.UseVisualStyleBackColor = True
        '
        'dltCst
        '
        Me.dltCst.Location = New System.Drawing.Point(695, 16)
        Me.dltCst.Name = "dltCst"
        Me.dltCst.Size = New System.Drawing.Size(75, 23)
        Me.dltCst.TabIndex = 13
        Me.dltCst.Text = "Delete"
        Me.dltCst.UseVisualStyleBackColor = True
        '
        'updtCst
        '
        Me.updtCst.Location = New System.Drawing.Point(614, 16)
        Me.updtCst.Name = "updtCst"
        Me.updtCst.Size = New System.Drawing.Size(75, 23)
        Me.updtCst.TabIndex = 12
        Me.updtCst.Text = "Update"
        Me.updtCst.UseVisualStyleBackColor = True
        '
        'CityTableAdapter
        '
        Me.CityTableAdapter.ClearBeforeFill = True
        '
        'eror
        '
        Me.eror.AutoSize = True
        Me.eror.Location = New System.Drawing.Point(405, 73)
        Me.eror.Name = "eror"
        Me.eror.Size = New System.Drawing.Size(46, 14)
        Me.eror.TabIndex = 21
        Me.eror.Text = "Label2"
        Me.eror.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(800, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 44)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ViewSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(881, 408)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "ViewSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewSupplier"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SupGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Supplier_city, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SupGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents srchCst As System.Windows.Forms.Button
    Friend WithEvents searchTxtbox As System.Windows.Forms.TextBox
    Friend WithEvents Cls As System.Windows.Forms.Button
    Friend WithEvents dltCst As System.Windows.Forms.Button
    Friend WithEvents updtCst As System.Windows.Forms.Button
    Friend WithEvents CityDDL As System.Windows.Forms.ComboBox
    Friend WithEvents CityCheck As System.Windows.Forms.CheckBox
    Friend WithEvents NameCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Supplier_city As Meet_Garments_Fisics.Supplier_city
    Friend WithEvents CityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CityTableAdapter As Meet_Garments_Fisics.Supplier_cityTableAdapters.CityTableAdapter
    Friend WithEvents eror As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
