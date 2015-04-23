<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchaseReturn
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
        Me.purchaseBtn = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.totalamt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.PurchaseitemdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SDPdatabaseDataSet8 = New Meet_Garments_Fisics.SDPdatabaseDataSet8
        Me.Label3 = New System.Windows.Forms.Label
        Me.pur_date = New System.Windows.Forms.DateTimePicker
        Me.pur_id = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Return_id = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Purchase_item_detailsTableAdapter = New Meet_Garments_Fisics.SDPdatabaseDataSet8TableAdapters.Purchase_item_detailsTableAdapter
        Me.Desc = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rec_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseitemdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDPdatabaseDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'purchaseBtn
        '
        Me.purchaseBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchaseBtn.Location = New System.Drawing.Point(808, 450)
        Me.purchaseBtn.Name = "purchaseBtn"
        Me.purchaseBtn.Size = New System.Drawing.Size(117, 30)
        Me.purchaseBtn.TabIndex = 18
        Me.purchaseBtn.Text = "Return"
        Me.purchaseBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.totalamt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(24, 444)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 41)
        Me.Panel1.TabIndex = 17
        '
        'totalamt
        '
        Me.totalamt.Location = New System.Drawing.Point(602, 10)
        Me.totalamt.Name = "totalamt"
        Me.totalamt.Size = New System.Drawing.Size(158, 20)
        Me.totalamt.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(585, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total:*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.rec_Qty, Me.Qty, Me.Rate, Me.Amt})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(774, 323)
        Me.DataGridView1.TabIndex = 16
        '
        'PurchaseitemdetailsBindingSource
        '
        Me.PurchaseitemdetailsBindingSource.DataMember = "Purchase_item_details"
        Me.PurchaseitemdetailsBindingSource.DataSource = Me.SDPdatabaseDataSet8
        '
        'SDPdatabaseDataSet8
        '
        Me.SDPdatabaseDataSet8.DataSetName = "SDPdatabaseDataSet8"
        Me.SDPdatabaseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Date:*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pur_date
        '
        Me.pur_date.Location = New System.Drawing.Point(134, 81)
        Me.pur_date.Name = "pur_date"
        Me.pur_date.Size = New System.Drawing.Size(240, 20)
        Me.pur_date.TabIndex = 13
        '
        'pur_id
        '
        Me.pur_id.Enabled = False
        Me.pur_id.Location = New System.Drawing.Point(134, 50)
        Me.pur_id.Name = "pur_id"
        Me.pur_id.Size = New System.Drawing.Size(240, 20)
        Me.pur_id.TabIndex = 12
        Me.pur_id.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Purchase Id:*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Return_id
        '
        Me.Return_id.Enabled = False
        Me.Return_id.Location = New System.Drawing.Point(134, 20)
        Me.Return_id.Name = "Return_id"
        Me.Return_id.Size = New System.Drawing.Size(240, 20)
        Me.Return_id.TabIndex = 20
        Me.Return_id.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Return Id:*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Purchase_item_detailsTableAdapter
        '
        Me.Purchase_item_detailsTableAdapter.ClearBeforeFill = True
        '
        'Desc
        '
        Me.Desc.Location = New System.Drawing.Point(804, 143)
        Me.Desc.Multiline = True
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(255, 293)
        Me.Desc.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(805, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Description:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(931, 450)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(117, 30)
        Me.BtnClose.TabIndex = 23
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Sr no."
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'rec_Qty
        '
        Me.rec_Qty.HeaderText = "Recieved Quantity"
        Me.rec_Qty.Name = "rec_Qty"
        '
        'Qty
        '
        Me.Qty.HeaderText = "Quantity"
        Me.Qty.Name = "Qty"
        '
        'Rate
        '
        Me.Rate.HeaderText = "Rate (₹)"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 70
        '
        'Amt
        '
        Me.Amt.HeaderText = "Amount (₹)"
        Me.Amt.Name = "Amt"
        Me.Amt.Width = 160
        '
        'purchaseReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1072, 497)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.Return_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.purchaseBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pur_date)
        Me.Controls.Add(Me.pur_id)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "purchaseReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Return"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseitemdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDPdatabaseDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents purchaseBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents totalamt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pur_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents pur_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Return_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SDPdatabaseDataSet8 As Meet_Garments_Fisics.SDPdatabaseDataSet8
    Friend WithEvents PurchaseitemdetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Purchase_item_detailsTableAdapter As Meet_Garments_Fisics.SDPdatabaseDataSet8TableAdapters.Purchase_item_detailsTableAdapter
    Friend WithEvents Desc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rec_Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
